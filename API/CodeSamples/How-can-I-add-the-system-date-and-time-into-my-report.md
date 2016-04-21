#Adding system date and time to a report

[[_TOC_]]

##Question

I have an older version of Izenda. How do I add the system date and time into my report if there is no checkbox on the Style tab?

Note: Versions of Izenda at least 6.9.0.1 will not require this modification.

##Answer

Place this custom code into your global.asax:

```csharp

public class CustomAdHocConfig : DatabaseAdHocConfig
{
    // Key-value collection of reports identifiers
    // and dates to remove from title
    private Hashtable _datesToRemove = new Hashtable();

    public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
    {
        string date = System.DateTime.Now.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("en-US"));
        // Alter the report title by adding a new line and the date and time
        reportSet.Title = reportSet.Title + Environment.NewLine + date;
        // Save just added value, so we will be able to remove it after
        if (!_datesToRemove.Contains(reportSet.ReportID))
            _datesToRemove.Add(reportSet.ReportID, date);
        else
            _datesToRemove[reportSet.ReportID] = date;
    }

    public override void PostExecuteReportSet(ReportSet reportSet)
    {
        // Remove data from the report title
        if (_datesToRemove.Contains(reportSet.ReportID))
            reportSet.Title = reportSet.Title.Replace(_datesToRemove[reportSet.ReportID].ToString(), String.Empty);
    }
}
```