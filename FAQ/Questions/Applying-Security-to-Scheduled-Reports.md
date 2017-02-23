#Applying Tenant Level Security to Scheduled Reports

[[_TOC_]]

##About

This code sample shows how to apply security for the owner of the report when it gets sent out via the scheduler. This can allow reports to get disseminated based on the report owner's tenant ID and prevent any users outside of that group from receiving the report.

##C♯ Example

```csharp
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
  {
    bool scheduler = AdHocSettings.CurrentUserName.Equals(AdHocSettings.DefaultUserName); //For the scheduler, the CurrentUserName will be the DefaultUserName as no user has logged in using the normal process.
    if (scheduler && reportSet.SendEmailAs != SchedulerOutput.SchedulerOutputType.Link.ToString()) //Do not need to perform this step if the report is sent as a link
      {
        AdHocSettings.TenantField = "TenantID"; //CurrentUserTenantId is already set from running run_scheduled_reports with tenants=tenant1,tenant2,etc... and TenantField uses CurrentUserTenantId as its value.
        Filter f = new Filter("Field_Derived_From_User");
        f.Value = LookupDerivedTenantValue(reportSet.UserName); //Write your own implementation of this method. This will get the value for the field that should be derived from your user (the report owner) inside the tenant being run.
        reportSet.Filters.AddHidden(f); //add the temporary hidden filter. Normally this would be done during initialization. But since we didn't know the user's login information at initialization then we have to improvise.
      }
  } //end method
```

##VB.NET Example

```visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet)
    Dim scheduler As Boolean <> AdHocSettings.CurrentUserName.Equals(AdHocSettings.DefaultUserName) 'For the scheduler, the CurrentUserName will be the DefaultUserName as no user has logged in using the normal process.
    If scheduler AndAlso reportSet.SendEmailAs = SchedulerOutput.SchedulerOutputType.Link.ToString() Then 'Do not need to perform this step if the report is sent as a link
        AdHocSettings.TenantField = "TenantID" 'CurrentUserTenantId is already set from running run_scheduled_reports with tenants=tenant1,tenant2,etc... and TenantField uses CurrentUserTenantId as its value.
        Dim f As Filter = New Filter("Field_Derived_From_User")
        f.Value = LookupDerivedTenantValue(reportSet.UserName) 'Write your own implementation of this method. This will get the value for the field that should be derived from your user (the report owner) inside the tenant being run.
        reportSet.Filters.AddHidden(f) 'add the temporary hidden filter. Normally this would be done during initialization. But since we didn't know the user's login information at initialization then we have to improvise.
    End If
End Sub 'end method
```


##Limitations

The Email Scheduler in the reporting system does not have a way to provide authentication (login & password) to your SMTP server.  For the email scheduler to send messages to an SMTP server, you would need to provide an open path via the web server's IP address to the SMTP server that would not require authentication. 


##Per-user Security On Scheduled Reports

Scheduled reports only natively supports per-user security using the Link format.  Reports scheduled as attachments will not apply hidden filters normally unless using custom code as above based on the security of the report owner.  If per-user security is required and writing custom code to handle attached reports is too messy, the Link format will require the user to login before seeing the report, thus applying security as normal.