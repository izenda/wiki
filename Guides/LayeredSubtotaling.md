#Layered Subtotaling

[[_TOC_]]

##Purpose

Layered subtotaling is a customized way to display subtotals that will aggregate multiple subtotals based on a set of conditions into one lump sum. This is not a grand total. Below is an example of layered subtotaling.

##Example

![Custom Layered Subtotaling](http://wiki.izenda.us/Guides/Developer-Links-and-Guides/custom_layered_subtotaling.png)

In this example, the data would be aggregated based on [ShipCountry] normally. The subtotal of all countries' freight would be totaled up. With layered subtotaling, we can get subtotals for drilldowns (such as the subtotal of [ShipRegion] ([ShipCountry] drills down to [ShipRegion]&#41;&#41; in one report. This allows not only each [ShipCountry] field value to be totaled up, but it also allows us to see each [ShipRegion]'s total.

##Implementation

Here is a sample global.asax to implement layered subtotaling in your own application. This example behavior modifies the "Line Delimited With Labels" option in the Style tab of the Report Designer. However, you can customize which of the visual grouping styles this behavior modifies, if any, by modifying the following lines:

```csharp
LayeredSubtotaling myLayeredSubtotaling = new LayeredSubtotaling(VisualGroupStyle.LineDelimitedWithLabels);
```

###C♯

```csharp
using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using Izenda.AdHoc;

[Serializable]
public class CustomAdHocConfig : FileSystemAdHocConfig
{
    LayeredSubtotaling myLayeredSubtotaling = new LayeredSubtotaling(VisualGroupStyle.LineDelimitedWithLabels);

    public override void PreExecuteReportSet(ReportSet reportSet)
    {
        myLayeredSubtotaling.hasSubtotals = reportSet.Detail.AddGrandTotals;
    }

    public override void ProcessDataSet(DataSet ds, string reportPart)
    {
        myLayeredSubtotaling.DoSubtotalingForVG(ds, reportPart);
    }

    public override string PerformCustomRendering(string initialHtml)
    {
        return myLayeredSubtotaling.PerformCustomRendering(initialHtml);
    }
}

/// <summary>
/// Summary description for LayeredSubtotaling
/// </summary>
public class LayeredSubtotaling
{
    public bool hasSubtotals = false;
    static Dictionary<string, List<object>> deltas = new Dictionary<string, List<object>>();
    bool firstPass = true;
    VisualGroupStyle targetVGStyle;

    public LayeredSubtotaling(VisualGroupStyle targetVGStyle)
    {
        _targetVGStyle = targetVGStyle;
    }

    /// <summary>
    /// Overrides base version to support custom totaling of various deltas in the report. 
    /// </summary>
    public void DoSubtotalingForVG(System.Data.DataSet ds, string reportPart)
    {
        if (firstPass && !String.IsNullOrEmpty(reportPart))
        {
            string header, where;
            List<object> dataColumns = new List<object>();
            Dictionary<string, string> dataHeaders = new Dictionary<string, string>();

            bool isTargetVGStyle = AdHocContext.CurrentReportSet.VisualGroupStyle == _targetVGStyle;

            if (isTargetVGStyle)
            {
                foreach (System.Data.DataTable table in ds.Tables)
                {
                    foreach (System.Data.DataRow row in table.Rows)
                    {
                        header = String.Empty;
                        where = String.Empty;

                        foreach (System.Data.DataColumn column in table.Columns)
                        {
                            // If the value in this column is a string, it means the column is a header, and not a data column.
                            if (row[column].GetType() == typeof(string))
                            {
                                // If the header is empty, add the first value formatted as follows. 
                                if (header.Length == 0)
                                {
                                    header = row[column].ToString();
                                    where = "[" + column + "] = '" + row[column] + "'";
                                }
                                else
                                {
                                    // Otherwise, add the item, separated by a comma.
                                    header += ", " + row[column].ToString();
                                    where += " AND [" + column + "] = '" + row[column] + "'";
                                }

                                // If the header is already in the list, ignore it and move on.
                                if (!dataHeaders.ContainsKey(header))
                                {
                                    dataHeaders.Add(header, where);
                                }
                            }

                            // Otherwise this is a data column and add it to that data structure. 
                            else if (!dataColumns.Contains(column) && row[column].GetType() != typeof(DBNull))
                            {
                                dataColumns.Add(column);
                            }
                        }
                    }

                    // Iterate over the gathered headers, computing the sum for each data column associated with it. 
                    foreach (string head in dataHeaders.Keys)
                    {
                        List<object> data = new List<object>();
                        foreach (object column in dataColumns)
                        {
                            data.Add(table.Compute("Sum(" + column.ToString() + ")", dataHeaders[head]));
                        }

                        if (data.Count > 0)
                        {
                            // add the header and all the sums for the data columns to the deltas structure. 
                            if(!deltas.ContainsKey(head))
                                deltas.Add(head, data);
                        }
                    }
                }
            }
        }

        // If subtotaling is enabled, toggle first pass so the subtotal loop does wipe out custom totals. 
        if (hasSubtotals)
        {
            firstPass = !firstPass;
        }
    }

    /// <summary>
    /// Override this to implement your own custom report rendering. This requires the 
    /// html agility pack NuGet package to work. 
    /// </summary>
    public string PerformCustomRendering(string initialHtml)
    {
        bool isTargetVGStyle = AdHocContext.CurrentReportSet.VisualGroupStyle == _targetVGStyle;
        if (isTargetVGStyle)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(initialHtml);

            // This uses an Xpath declaration to get all rows that are of class Visual group. This is done to match
            // the visual grouping to the deltas retreived from ProcessDataSet.
            HtmlNodeCollection highestLevelDeltas = doc.DocumentNode.SelectNodes("//tr[@class='VisualGroup']");

            if (highestLevelDeltas == null)
            {
                return initialHtml;
            }

            //The report table is passed to several functions as a reference to the current report. 
            HtmlNode reportTable = doc.DocumentNode.SelectSingleNode("//table[@class='ReportTable']");

            // Splits the string into an array for looping and comparison.
            string[] lastDelta = SanitizeDelta(highestLevelDeltas.FindFirst("tr").FirstChild.InnerHtml.Split(new string[] { "<br>" }, StringSplitOptions.RemoveEmptyEntries));

            // Loops through all the deltas extracted from the report, node by node.
            foreach (HtmlNode delta in highestLevelDeltas)
            {
                // Splits the string into an array for looping and comparison.
                string[] currentDelta = SanitizeDelta(delta.FirstChild.InnerHtml.Split(new string[] { "<br>" }, StringSplitOptions.RemoveEmptyEntries));

                string deltaString = string.Empty;

                // Loops through, comparing the arrays index by index. Ignores the last index since this
                // delta is handled by the standard subtotaling.         
                for (int i = 0; i < currentDelta.Length - 1; i++)
                {
                    // Adds the current index from the array to a string for later use. 
                    deltaString += lastDelta[i];

                    if (lastDelta[i] != currentDelta[i])
                    {
                        // This check is needed to handle 1st level delta changes. In these cases, there can be
                        // more than just one delta to output, and this method will print them all. 
                        if (i == 0)
                        {
                            PrintFinalDeltas(reportTable, delta, lastDelta);
                        }
                        // Otherwise, add the delta to report and remove it from the list of deltas. 
                        else
                        {
                            InjectHtml(reportTable, delta, deltaString);
                            deltas.Remove(deltaString);
                        }
                        break;
                    }
                    // If the values at the index are the same, add a , and move to the next index. 
                    else
                    {
                        deltaString += ", ";
                    }
                }

                lastDelta = currentDelta;

                // This sanitizes the string in the case of a DBNull value. 
                string deltaHead = string.Join(",", currentDelta).Replace(", ,", ", ");


                // Remove the delta from the list. 
                if (deltas.ContainsKey(deltaHead))
                {
                    deltas.Remove(deltaHead);
                }
            }

            // This final loop writes out the remaining deltas
            PrintFinalDeltas(reportTable, reportTable.LastChild, lastDelta);

            return doc.DocumentNode.OuterHtml;
        }
        return initialHtml;
    }

    /// <summary>
    /// PrintFinalDeltas is called to in the case of level 1 delta changes. It makes sure all deltas get printed out,
    /// not just the level 1.
    /// </summary>
    private static void PrintFinalDeltas(HtmlNode reportTable, HtmlNode previousNode, string[] lastDelta)
    {
        // delta takes the lastDelta array and converts it back into a string.
        string delta = string.Join(", ", lastDelta);

        // This loop keeps running until all of the pertinent information has been pulled from the string. 
        while (delta.LastIndexOf(',') > 0)
        {
            //Since standard subtotals print off the low level delta, this puuls that one out and discards it.
            delta = delta.Substring(0, delta.LastIndexOf(','));

            // If the string is a valid delta, print it out and remove it from the dictionary.
            if (deltas.ContainsKey(delta))
            {
                InjectHtml(reportTable, previousNode, delta);
                deltas.Remove(delta);
            }
        }
    }

    /// <summary>
    /// InjectHtml actually alters the html string, injecting the deltas into it. 
    /// </summary>
    private static void InjectHtml(HtmlNode reportTable, HtmlNode currentNode, string deltaString)
    {
        // Build up the table row to inject. 
        HtmlNode deltaRow = HtmlNode.CreateNode("<tr class=ReportFooter></tr>");
        deltaRow.AppendChild(HtmlNode.CreateNode("<td>" + deltaString + "</td>"));

        // This will loop through the various delta columns for a particular row, adding each as a td to the row.
        if (deltas.ContainsKey(deltaString))
        {
            foreach (object column in deltas[deltaString])
            {
                deltaRow.AppendChild(HtmlNode.CreateNode("<td>" + column + "</td>"));
            }

            // This is where the row actually gets inserted.
            reportTable.InsertBefore(deltaRow, currentNode);
        }
    }

    private static string[] SanitizeDelta(string[] delta)
    {
        string[] sanitizedDelta = new string[delta.Length];
        for (int i = 0; i < delta.Length; i++)
        {
            if (!string.IsNullOrEmpty(delta[i].Substring(delta[i].IndexOf(':') + 1).Trim()))
                sanitizedDelta[i] = delta[i].Substring(delta[i].IndexOf(':') + 2);
        }

        return sanitizedDelta;
    }
}
```

###VB.NET

```visualbasic
Imports System.Data
Imports HtmlAgilityPack
Imports Izenda.AdHoc

<Serializable()>
Public Class CustomAdHocConfig
    Inherits FileSystemAdHocConfig

    Dim myLayeredSubtotaling As New LayeredSubtotaling(VisualGroupStyle.LineDelimitedWithLabels)

    Public Overrides Sub PreExecuteReportSet(ByVal reportSet As ReportSet)
        myLayeredSubtotaling.hasSubtotals = reportSet.Detail.AddGrandTotals
    End Sub

    Public Overrides Sub ProcessDataSet(ByVal ds As DataSet, ByVal reportPart As String)
        myLayeredSubtotaling.DoSubtotalingForVG(ds, reportPart, VisualGroupStyle.LineDelimitedWithLabels)
    End Sub

    Public Overrides Function PerformCustomRendering(initialHtml As String) As String
        Return myLayeredSubtotaling.PerformCustomRendering(initialHtml, VisualGroupStyle.LineDelimitedWithLabels)
    End Function
End Class

' <summary>
' Summary description for LayeredSubtotaling
' </summary>
Public Class LayeredSubtotaling
    Public hasSubtotals As Boolean = False
    Shared deltas As New Dictionary(Of String, List(Of Object))()
    Dim firstPass As Boolean = True
    Dim _targetVGStyle As VisualGroupStyle

    Sub New(targetVGStyle As VisualGroupStyle)
        _targetVGStyle = targetVGStyle
    End Sub

    ' <summary>
    ' Overrides base version to support custom totaling of various deltas in the report. 
    ' </summary>
    Public Sub DoSubtotalingForVG(ds As DataSet, reportPart As String)
        If firstPass AndAlso Not String.IsNullOrEmpty(reportPart) Then
            Dim header, where As String
            Dim dataColumns As New List(Of Object)()
            Dim dataHeaders As New Dictionary(Of String, String)()

            Dim isTargetVGStyle As Boolean = AdHocContext.CurrentReportSet.VisualGroupStyle = _targetVGStyle

            If isTargetVGStyle Then
                For Each table As DataTable In ds.Tables
                    For Each row As DataRow In table.Rows
                        header = String.Empty
                        where = String.Empty

                        For Each column As DataColumn In table.Columns
                            ' If the value in this column Is a string, it means the column Is a header, And Not a data column.
                            If row(column).GetType() Is GetType(String) Then
                                'If the header Is empty, add the first value formatted as follows. 
                                If header.Length = 0 Then
                                    header = row(column).ToString()
                                    where = "[" & column.ToString() & "] = '" & row(column) & "'"
                                Else
                                    'Otherwise, add the item, separated by a comma.
                                    header += ", " & row(column).ToString()
                                    where += " AND [" & column.ToString() & "] = '" & row(column) & "'"

                                    'If the header Is already in the list, ignore it And move on.
                                    If (Not dataHeaders.ContainsKey(header)) Then
                                        dataHeaders.Add(header, where)
                                    End If
                                End If
                                'Otherwise this Is a data column And add it to that data structure. 
                            ElseIf Not dataColumns.Contains(column) AndAlso row(column).GetType() IsNot GetType(DBNull) Then
                                dataColumns.Add(column)
                            End If
                        Next
                    Next

                    'Iterate over the gathered headers, computing the sum for each data column associated with it. 
                    For Each head As String In dataHeaders.Keys
                        Dim data As New List(Of Object)()
                        For Each column As Object In dataColumns
                            data.Add(table.Compute("Sum(" + column.ToString() + ")", dataHeaders(head)))
                        Next

                        If data.Count > 0 Then
                            ' add the header And all the sums for the data columns to the deltas structure. 
                            If (Not deltas.ContainsKey(head)) Then
                                deltas.Add(head, data)
                            End If
                        End If
                    Next
                Next
            End If
        End If
        ' If subtotaling Is enabled, toggle first pass so the subtotal loop does wipe out custom totals. 
        If hasSubtotals Then
            firstPass = Not firstPass
        End If
    End Sub

    ' <summary>
    ' Override this to implement your own custom report rendering. This requires the 
    ' html agility pack NuGet package to work. 
    ' </summary>
    Public Function PerformCustomRendering(initialHtml As String) As String
        Dim isTargetVGStyle As Boolean = AdHocContext.CurrentReportSet.VisualGroupStyle = _targetVGStyle
        If isTargetVGStyle Then
            Dim doc As New HtmlDocument()
            doc.LoadHtml(initialHtml)

            ' This uses an Xpath declaration to get all rows that are of class Visual group. This Is done to match
            ' the visual grouping to the deltas retreived from ProcessDataSet.
            Dim highestLevelDeltas = doc.DocumentNode.SelectNodes("//tr[@class='VisualGroup']")

            If highestLevelDeltas Is Nothing Then
                Return initialHtml
            End If

            'The report table Is passed to several functions as a reference to the current report. 
            Dim reportTable = doc.DocumentNode.SelectSingleNode("//table[@class='ReportTable']")

            ' Splits the string into an array for looping And comparison.
            Dim lastDelta = SanitizeDelta(highestLevelDeltas.FindFirst("tr").FirstChild.InnerHtml.Split(New String() {"<br>"}, StringSplitOptions.RemoveEmptyEntries))

            'Loops through all the deltas extracted from the report, node by node.
            For Each delta As HtmlNode In highestLevelDeltas
                ' Splits the string into an array for looping And comparison.
                Dim currentDelta = SanitizeDelta(delta.FirstChild.InnerHtml.Split(New String() {"<br>"}, StringSplitOptions.RemoveEmptyEntries))

                Dim deltaString = String.Empty

                ' Loops through, comparing the arrays index by index. Ignores the last index since this
                ' delta Is handled by the standard subtotaling.         
                For i As Integer = 0 To currentDelta.Length - 1
                    'Adds the current index from the array to a string for later use. 
                    deltaString += lastDelta(i)

                    If Not lastDelta(i) = currentDelta(i) Then
                        ' This check Is needed to handle 1st level delta changes. In these cases, there can be
                        ' more than just one delta to output, And this method will print them all. 
                        If i = 0 Then
                            PrintFinalDeltas(reportTable, delta, lastDelta)
                            'Otherwise, add the delta to report And remove it from the list of deltas. 
                        Else
                            InjectHtml(reportTable, delta, deltaString)
                            deltas.Remove(deltaString)
                        End If
                        Exit For
                        'If the values at the index are the same, add a , And move to the next index. 
                    Else
                        deltaString += ", "
                    End If
                Next

                lastDelta = currentDelta

                'This sanitizes the string in the case of a DBNull value. 
                Dim deltaHead = String.Join(",", currentDelta).Replace(", ,", ", ")


                'Remove the delta from the list. 
                If deltas.ContainsKey(deltaHead) Then
                    deltas.Remove(deltaHead)
                End If
            Next

            ' This final loop writes out the remaining deltas
            PrintFinalDeltas(reportTable, reportTable.LastChild, lastDelta)

        Return doc.DocumentNode.OuterHtml
        End If
        Return initialHtml
    End Function

    ' <summary>
    ' PrintFinalDeltas Is called to in the case of level 1 delta changes. It makes sure all deltas get printed out,
    ' Not just the level 1.
    ' </summary>
    Private Shared Sub PrintFinalDeltas(reportTable As HtmlNode, previousNode As HtmlNode, lastDelta As String())
        'delta takes the lastDelta array And converts it back into a string.
        Dim delta = String.Join(", ", lastDelta)

        ' This loop keeps running until all of the pertinent information has been pulled from the string. 
        While (delta.LastIndexOf(",") > 0)
            'Since standard subtotals print off the low level delta, this puuls that one out And discards it.
            delta = delta.Substring(0, delta.LastIndexOf(","))

            'If the string Is a valid delta, print it out And remove it from the dictionary.
            If (deltas.ContainsKey(delta)) Then
                InjectHtml(reportTable, previousNode, delta)
                deltas.Remove(delta)
            End If
        End While
    End Sub

    ' <summary>
    ' InjectHtml actually alters the html string, injecting the deltas into it. 
    ' </summary>
    Private Shared Sub InjectHtml(reportTable As HtmlNode, currentNode As HtmlNode, deltaString As String)
        'Build up the table row to inject. 
        Dim deltaRow = HtmlNode.CreateNode("<tr class=ReportFooter></tr>")
        deltaRow.AppendChild(HtmlNode.CreateNode("<td>" + deltaString + "</td>"))

        'This will loop through the various delta columns for a particular row, adding each as a td to the row.
        If deltas.ContainsKey(deltaString) Then
            For Each column As Object In deltas(deltaString)
                deltaRow.AppendChild(HtmlNode.CreateNode("<td>" + column.ToString() + "</td>"))
            Next
            'This Is where the row actually gets inserted.
            reportTable.InsertBefore(deltaRow, currentNode)
        End If
    End Sub

    Private Shared Function SanitizeDelta(delta As String()) As String()
        Dim sanitizedDelta(delta.Length - 1) As String
        For i As Integer = 0 To delta.Length - 1
            If Not String.IsNullOrEmpty(delta(i).Substring(delta(i).IndexOf(":") + 1).Trim()) Then
                sanitizedDelta(i) = delta(i).Substring(delta(i).IndexOf(":") + 2)
            End If
        Next
        Return sanitizedDelta
    End Function
End Class
```