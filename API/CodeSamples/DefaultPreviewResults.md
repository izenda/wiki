#DefaultPreviewResults

[[_TOC_]]

##About

This changes the default number of results (records) shown in the report designer preview tab. Izenda does not recommend setting this to a large number such as 5000 or larger as the html report will take a long time to generate. When exporting, all results will always be exported. Web browsers can become slow or stop completely when reports with hundreds of thousands of lines are generated, so keep this in mind when changing this setting. Ideally, this should be set to a power of 10 (1, 10, 100, 1000, etc). This will not affect the [[Report Viewer|http://wiki.izenda.us/API/CodeSamples/ReportViewerDefaultPreviewResults]] results.

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
    AdHocSettings.DefaultPreviewResults = 500;
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
        AdHocSettings.DefaultPreviewResults= 500
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```