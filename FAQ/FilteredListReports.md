#FilteredListReports()

[[_TOC_]]

##About

This method is used on the dashboards page and returns a list of reports that are guaranteed to be available to the current user, taking into account all [[hidden filters|http://wiki.izenda.us/FAQ/applying-hidden-filter-using-inner-query]] and settings. This method can be overridden in your [[CustomAdHocConfig|http://wiki.izenda.us/Integration/Tutorials/Customizing-Izenda-Settings]] class as needed. Here is a sample of what an overridden implementation could look like.

_**Note:** For more on caching in Izenda, please see the [[UseCachedFilteredLists|/API/CodeSamples/UseCachedFilteredLists]] setting._

##Global.asax (C♯)

```csharp
public override ReportInfo[] FilteredListReports() {
      ReportInfo[] reports = ListReports();
      ArrayList result = new ArrayList();
      foreach (ReportInfo info in reports) {
        if (info.Category == "Hidden reports")
          continue;
        ReportSet reportSet = LoadFilteredReportSet(info.Name);
        if (reportSet != null && reportSet.CanBeLoaded)
          result.Add(info);
      }
      return (ReportInfo[])result.ToArray(typeof(ReportInfo));
    }
```

##Global.asax (VB.NET)

```visualbasic
Public Overrides Function FilteredListReports() As ReportInfo()
      Dim reports() As ReportInfo = ListReports()
      Dim result As New ArrayList()
      For Each info As ReportInfo in reports
        If info.Category = "Hidden reports" Then Continue For
        Dim reportSet As ReportSet = LoadFilteredReportSet(info.Name)
        If reportSet IsNot Nothing AndAlso reportSet.CanBeLoaded Then result.Add(info)
      Next
      Return DirectCast(result.ToArray(GetType(ReportInfo)), ReportInfo())
End Function
```

##See Also

* [[FilteredListReportsDictionary|FAQ/FilteredListReportsDictionary]]