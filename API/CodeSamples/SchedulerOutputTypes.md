#SchedulerOutputTypes

[[_TOC_]]

##About

Gets or sets the array of permitted email output types when using the stock Izenda scheduler.

**Default Value:** 

{Link, DOC, Embedded, PDF, CSV, HTML, XLS(MIME)}

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
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    SchedulerOutputCollection collection = new SchedulerOutputCollection(); //The relevant setting
        collection.Add("Link", new SchedulerOutput(new SchedulerOutput.SchedulerOutputFormat(), SchedulerOutput.SchedulerOutputType.Link)); //The relevant setting
        AdHocSettings.SchedulerOutputTypes = collection; //The relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
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
        SchedulerOutputCollection collection = new SchedulerOutputCollection() 'The relevant setting
        collection.Add("Link", new SchedulerOutput(new SchedulerOutput.SchedulerOutputFormat(), SchedulerOutput.SchedulerOutputType.Link)) 'The relevant setting
        AdHocSettings.SchedulerOutputTypes = collection 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```