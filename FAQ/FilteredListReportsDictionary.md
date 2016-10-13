#FilteredListReportsDictionary()

[[_TOC_]]

##About

This method is used on the report list page and returns a list of reports that are guaranteed to be available to the current user, taking into account all [[hidden filters|http://wiki.izenda.us/FAQ/applying-hidden-filter-using-inner-query]] and settings. This method can be overridden in your [[CustomAdHocConfig|http://wiki.izenda.us/Integration/Tutorials/Customizing-Izenda-Settings]] class as needed. Here is a sample of what an overridden implementation could look like.

##Global.asax (C♯)

```csharp
public override Dictionary<ReportInfo, ReportSet> FilteredListReportsDictionary()
{
    Dictionary<ReportInfo, ReportSet> reports = base.FilteredListReportsDictionary();
    Dictionary<ReportInfo, ReportSet> result = new Dictionary<ReportInfo, ReportSet>();
    foreach (ReportInfo info in reports.Keys)
    {
        if (info.Category == "Hidden reports")
            continue;
        if (reports[info] != null && reports[info].CanBeLoaded)
            result.Add(info, reports[info]);
    }
    return result;
}
```

##Global.asax (VB.NET)

```visualbasic
Public Overrides Function FilteredListReportsDictionary() As Dictionary(Of ReportInfo, ReportSet)
    Dim reports As Dictionary(Of ReportInfo, ReportSet) = MyBase.FilteredListReportsDictionary()
    Dim result As New Dictionary(Of ReportInfo, ReportSet)
    For Each info As ReportInfo In reports.Keys
        If info.Category = "Hidden reports" Then Continue For
        If reports(info) IsNot Nothing AndAlso reports(info).CanBeLoaded Then result.Add(info, reports(info))
    Next
    Return result
End Function
```

##See Also

* [[FilteredListReports|FAQ/FilteredListReports]]