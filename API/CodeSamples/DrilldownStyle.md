#DrilldownStyle

[[_TOC_]]

##About

Gets or sets the list of available drill-down report fields formats. 
This affects contents of all "Drill-down style" comboboxes in the ReportDesigner.
For example, in the Advanced Properties of a field at the Fields tab.

Note: You can find all possible keys by calling AdHocSettings.DrillDownStyle.AllKeys.

Currently, the valid keys are:
* DetailLink
* DetailLinkNewWindow
* EmbeddedDetail
* DetailLinkPopup

**Default Value**: 
* {object[4]}
  * {Izenda.AdHoc.DetailFormat}
  * {Izenda.AdHoc.DetailFormat}
  * {Izenda.AdHoc.EmbeddedDetailFormat}
  * {Izenda.AdHoc.DetailLinkPopupFormat}

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
    AdHocSettings.ExportLimit = 100000; //The relevant setting
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
        AdHocSettings.ExportLimit = 100000 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

![](http://izenda.com/Site/Images/Screenshots/DrillDownStyleDS.png)