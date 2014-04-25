#ViewsOnly

[[_TOC_]]

##About

Gets or sets whether the data sources will include only views or will include both views and other sources such as tables and stored procedures. This setting should be used if you would like only Views to be visible on the Data Sources tab of the Report Designer. This will show the users all views stored on the target database. You could also control access to specific tables and views with the [[VisibleDataSources|/API/CodeSamples/VisibleDataSources]] setting.

_**Note**: ViewsOnly will NOT work if you also use VisibleDataSources._

Use cases: 

1) Tables and fields may have not very user-friendly names. Creating Views with user-friendly names can make the process of working with the database much easier. 

2) You may not want to allow users to work with tables in your database because they may contain sensitive information or consist of raw data useless for reports. Creating Views with proper data aggregation may help you to build better reports with relevant data. 

**Troubleshooting:**
If you are getting a "No tables to select" message, check if there is at least one View in the connected database.

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
    AdHocSettings.ViewsOnly = true;  //The relevant setting
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
        AdHocSettings.ViewsOnly = True 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

![](http://www.izenda.com/Site/Images/Screenshots/ViewsOnlyDS.png)