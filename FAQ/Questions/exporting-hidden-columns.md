#Exporting Hidden Columns

[[_TOC_]]

##Question

How can I export columns in a report that are normally hidden in the viewer?

##Answer

Izenda does not currently offer a simple way of exporting columns that are normally hidden. However, through some knowledge of our API calls, it is possible to support this behavior. The following is a short code sample that demonstrates this at a very simple level.

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
    if (!string.IsNullOrEmpty(HttpContext.Current.Request.QueryString["output"]))
    {
        foreach (Field f in reportSet.Detail.Fields)
        {
            if (!f.Visible)
                f.Visible = true;
        }
    }
    base.PreExecuteReportSet(reportSet);
}
```

This simply checks if the report is being exported. If it is, then it will set all fields that are not visible to be visible. You can modify this as per your own company's needs require.