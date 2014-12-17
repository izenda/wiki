#AllowInvertedGrid

[[_TOC_]]

##About

Gets or sets the value indicating whether "Invert" checkbox should be shown in the summary tab. Inverting the summary grid will use the first selected field as the column headers and each subsequent field selected will be used as its own row with the values arranged according to the new headers. The  [[InvertedGridLimit|/API/CodeSamples/InvertedGridLimit]] setting determines the maximum number of header values can be used in a report.

**Default Value:** false

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
    AdHocSettings.AllowInvertedGrid = true; //The relevant setting
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
        AdHocSettings.AllowInvertedGrid = True 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

AdHocSettings.AllowInvertedGrid = true

![](http://wiki.izenda.us//API/CodeSamples/AllowInvertedGrid/allowinvertedgrid_true.png)

Results

![](http://wiki.izenda.us//API/CodeSamples/AllowInvertedGrid/allowinvertedgrid_results.png)

---

AdHocSettings.AllowInvertedGrid = false

![](http://wiki.izenda.us//API/CodeSamples/AllowInvertedGrid/allowinvertedgrid_false.png)

Results

![](http://wiki.izenda.us//API/CodeSamples/AllowInvertedGrid/allowinvertedgrid_results_false3.png)