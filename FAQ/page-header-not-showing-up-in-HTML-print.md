#Why isn't my page header appearing when using HTML print?

[[_TOC_]]

##Question

I've added some content to the page header, but it only appears during PDF print, not HTML print. Why is this?

##Answer

Page headers only really work when an export is divided into printable pages. HTML print does not produce printable pages by default, but rather a web 'page' which is not the same as a printable page. Therefore, there is no page for a page header to apply itself to when using HTML print.

You can use the following code example to get and inject values, in this case, the value you want to inject is **report.ParentReportSet.PageHeader**

###Code Sample

```csharp


 public override bool PerformCustomRendering(Report report, Izenda.AdHoc.Database.ReportQueryExecuteResult results, string appliedFilters, bool print, out string resultFromCustomRenderer)
  {
    string data;
    bool res = base.PerformCustomRendering(report, results, appliedFilters, print, out data);
    //change something in data
    resultFromCustomRenderer = data;
    return res;
  }

```