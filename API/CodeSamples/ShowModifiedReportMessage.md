#ShowModifiedReportMessage

[[_TOC_]]

##About
**Data Type:** Bool  
**Accepted Values:** true,false,1,0  
**Default value:** true  
**Impacted Features:** Report Design, Dashboard Design  
**Purpose:** Enables or disables the Modified Report warning pop-up.  
**Usage:** This setting is used to disable the Modified Report warning pop-up on save. It is often turned off in projects that have strict share with rights where overwriting is rare or stand-alone projects.  
**Caveats:** N/A

##Code Samples
###Global.asax (C♯)

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
    AdHocSettings.ShowModifiedReportMessage = false; //The relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

###Global.asax (VB.NET)

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
        AdHocSettings.ShowModifiedReportMessage = false 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

## Screenshot
Screenshot of warning popping up on save.

![ShowModifiedReportMessage](/API/CodeSamples/ShowModifiedReportMessage/ShowModifiedReportWarning.png)