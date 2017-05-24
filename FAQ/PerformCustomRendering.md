#PerformCustomRendering

[[_TOC_]]

##About

Represents a method used to edit the literal HTML of the rendered report results before it gets pushed to the client via the report viewer, dashboard viewer, or Excel export. Forms can also be edited using a more context-specific override that uses a different signature. 

##C♯ Example

```csharp
//Represents a method used to replace the regular report results with the results of an HTML form.
public override bool PerformCustomRendering(Report report, ReportQueryExecuteResult results, string appliedFilters, bool print, out string resultFromCustomRenderer)
{
    bool customRendered = base.PerformCustomRendering(report, results, appliedFilters, print, out resultFromCustomRenderer);
    if (customRendered)
        foreach (Field f in report.Fields)
        {
            switch (f.FormatString)
            {
                case "{0:d}":
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-ShortDateFormat");
                    break;
                case "{0:D":
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-LongDateFormat");
                    break;
                case "{0:t}":
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-ShortTimeFormat");
                    break;
                case "{0:T}":
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-LongTimeFormat");
                    break;
                case "{0:f}":
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-FullShortFormat");
                    break;
                case "{0:F}":
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-FullLongFormat");
                    break;
                case "{0:g}":
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-GenShortFormat");
                    break;
                case "{0:G}":
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-GenLongFormat");
                    break;
            }
        }
    return customRendered;
}

//Represents a method used to modify the HTML results of reports on the report viewer, report designer, and Excel export
public override string PerformCustomRendering(string initialHtml)
{
    return initialHtml.Replace("foo", "xls-text");
}
```

##VB.NET Example

```visualbasic
'Represents a method used to replace the regular report results with the results of an HTML form.
Public Overrides Function PerformCustomRendering(report As Report, results As ReportQueryExecuteResult, appliedFilters As String, print As Boolean, ByRef resultFromCustomRenderer As String) As Boolean
    Dim customRendered As Boolean = MyBase.PerformCustomRendering(report, results, appliedFilters, print, resultFromCustomRenderer)
    If customRendered Then
        For Each f As Field In report.Fields
            Select Case f.FormatString
                Case "{0:d}"
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-ShortDateFormat")
                Case "{0:D}"
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-LongDateFormat")
                Case "{0:t}"
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-ShortTimeFormat")
                Case "{0:T}"
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-LongTimeFormat")
                Case "{0:f}"
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-FullShortFormat")
                Case "{0:F}"
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-FullLongFormat")
                Case "{0:g}"
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-GenShortFormat")
                Case "{0:G}"
                    resultFromCustomRenderer = resultFromCustomRenderer.Replace("foo", "xls-date-GenLongFormat")
            End Select
        Next
    End If
    Return customRendered
End Function

'Represents a method used to modify the HTML results of reports on the report viewer, report designer, and Excel export
Public Overrides Function PerformCustomRendering(initialHtml As String) As String
    Return initialHtml.Replace("foo", "xls-text")
End Function
```