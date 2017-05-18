#GetCustomFooter

[[_TOC_]]

##About

This method can be used to programatically set a unique footer on a ReportSet.

##C# Example

```csharp
public override void GetCustomFooter(ReportSet reportSet, ReportSetResults results, bool print, out string customFooter)
{
    customFooter = "My custom footer uses the fields in the report!";
    foreach (Field f in reportSet.Detail.Fields.AsEnumerable().DistinctBy(fld => fld.DbColumn.FullName))
        customFooter += string.Format("</br>[{0}]", f.DbColumn.Name);
    customFooter += "</br>The field names will get replaced with the data in the first row of the detail grid results. But I only appear if there's an existing footer on the report.";
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
Public Overrides Sub GetCustomFooter(reportSet As ReportSet, results As ReportSetResults, print As Boolean, ByRef customFooter As String)
    customFooter += "My custom footer uses the fields in the report!"
    For Each f As Field In reportSet.Detail.Fields.DistinctBy(Function(fld As Field) fld.DbColumn.FullName)
        customFooter += String.Format("</br>[{0}]", f.DbColumn.Name)
    Next
    customFooter += "</br>The field names will get replaced with the data in the first row of the detail grid results. But I only appear if there's an existing footer on the report."
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