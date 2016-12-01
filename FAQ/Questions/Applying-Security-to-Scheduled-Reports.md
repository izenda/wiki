#Applying Tenant Level Security to Scheduled Reports

[[_TOC_]]

##About

This code sample shows how to apply security for the owner of the report when it gets sent out via the scheduler. This can allow reports to get disseminated based on the report owner's tenant ID and prevent any users outside of that group from receiving the report.

##C♯ Example

```csharp
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
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

##VB.NET Example

```visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet)
    Dim scheduler As Boolean = AdHocSettings.CurrentUserName.Equals("DefaultAdministrator")
    If scheduler Then
        Dim f As Filter = New Filter("TenantID")
        f.Value = LookupTenantIDFromUser(reportSet.UserName) 'Write your own implementation of this method
        reportSet.Filters.AddHidden(f)
    End If
End Sub 'end method
```


##Limitations

The Email Scheduler in the reporting system does not have a way to provide authentication (login & password) to your SMTP server.  For the email scheduler to send messages to an SMTP server, you would need to provide an open path via the web server's IP address to the SMTP server that would not require authentication. 


##Per-user Security On Scheduled Reports

Scheduled reports only supports per-user security using the Link format.  Scheduled attachments will not apply hidden filters normally, but you can apply security through [[PreExecuteReportSet()|/FAQ/PreExecuteReportSet]] based on the security of the report owner.  If per-user security is required, the Link format will require the user to login before seeing the report.