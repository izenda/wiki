#GetCustomHeader

[[_TOC_]]

##About

This method can be used to programatically set a unique header on a ReportSet.

##C# Exmple

```csharp
public override void GetCustomHeader(ReportSet reportSet, ReportSetResults results, bool print, out string customHeader)
{
    customHeader = "My custom header uses the fields in the report!";
    foreach (Field f in reportSet.Detail.Fields.AsEnumerable().DistinctBy(fld => fld.DbColumn.FullName))
        customHeader += string.Format("</br>[{0}]", f.DbColumn.Name);
    customHeader += "</br>The field names will get replaced with the data in the first row of the detail grid results. But I only appear if there's an existing header on the report.";
}

public static class LinqExtensions
{
    public static IEnumerable<TSource> DistinctBy<TSource, TKey>
    (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
    {
        HashSet<TKey> seenKeys = new HashSet<TKey>();
        foreach (TSource element in source)
        {
            if (seenKeys.Add(keySelector(element)))
            {
                yield return element;
            }
        }
    }
}

```

##VB.NET Example

```visualbasic
Public Overrides Sub GetCustomHeader(reportSet As ReportSet, results As ReportSetResults, print As Boolean, ByRef customHeader As String)
    customHeader += "My custom header uses the fields in the report!"
    For Each f As Field In reportSet.Detail.Fields.DistinctBy(Function(fld As Field) fld.DbColumn.FullName)
        customHeader += String.Format("</br>[{0}]", f.DbColumn.Name)
    Next
    customHeader += "</br>The field names will get replaced with the data in the first row of the detail grid results. But I only appear if there's an existing header on the report."
End Sub

Public Module LinqExtensions
    <Extension()>
    Public Function DistinctBy(Of TSource, TKey) _
        (ByVal source As IEnumerable(Of TSource), ByVal keySelector As Func(Of TSource, TKey)) _
        As IEnumerable(Of TSource)
        Dim seenKeys As New HashSet(Of TKey)()
        Dim toReturn As New List(Of TSource)
        For Each element As TSource In source
            If seenKeys.Add(keySelector(element)) Then
                toReturn.Add(element)
            End If
        Next
        Return toReturn.AsEnumerable()
    End Function
End Module
```