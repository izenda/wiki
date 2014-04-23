#Applying Security for Owner of the Report Out of Scheduler

[[_TOC_]]

##About

This code sample shows how to apply security for the owner of the report when it gets sent out via the scheduler. This can allow reports to get disseminated based on the report owner's tenant ID and prevent any users outside of that group from receiving the report.

```csharp
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSetreportSet)
  {
    bool scheduler = AdHocSettings.CurrentUserName.Equals("DefaultAdministrator");
    if (scheduler)
      {
        Filter f = new Filter("TenantID");
        f.Value = LookupTenantIDFromUser(reportSet.UserName); //Write your own implementation of this method
        reportSet.Filters.AddHidden(f);
      }
  } //end method
```