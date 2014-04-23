#AllowArchivedReportTableCreation

[[_TOC_]]

##About

Gets or sets the value indicating whether the application will use a database table for archiving reports. The application must be running in Database Mode for this to have any effect. When set, the application will first check if the table specified by the [[SavedReportsTable|/API/CodeSamples/SavedReportsTable]] setting exists. If your SavedReportsTable setting is not explicitly set, Izenda will use the default table name **IzendaAdHocReports**. The application will then use this table to save archived reports.

_**Note:** Database Mode requires the ability to save reports. This setting simply allows the application to store archived reports. Read more about [[storing reports|/FAQ/Storing-Reports]]._

##Global.asax (C♯)

```csharp
//main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{
  // Configure settings
  // Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
  public static void InitializeReporting() {
    //Check to see if we've already initialized.
    if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
      return;
    AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
    //Creates a connection to Microsoft SQL Server
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
  public override void ConfigureSettings() {
    AdHocSettings.AllowArchivedReportTableCreation = true;
  }
}
```

##Global.asax (VB.NET)

```visualbasic
'main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
Public Class CustomAdHocConfig
    Inherits Izenda.AdHoc.DatabaseAdHocConfig

    Shared Sub InitializeReporting()
        'Check to see if we've already initialized
        If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub

    Public Overrides Sub ConfigureSettings()
        AdHocSettings.AllowArchivedReportTableCreation = True
    End Sub
End Class
```