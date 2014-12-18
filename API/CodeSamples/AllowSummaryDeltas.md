#AllowSummaryDeltas

[[_TOC_]]

##About

Gets or sets the value indicating whether the "Add Deltas" checkbox should be shown in the summary tab in the ReportDesigner. When this setting is on and the checkbox is checked on the report, any time there is a change in a quantity between two records, that change is calculated by taking the later value for that quantity and subtracting from it the earlier value for that quantity. 

_**Note:** The [[allowDeltas|/API/CodeSamples/AllowDeltas]] setting MUST be turned on to use this feature._

**Default Value:** true

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
    AdHocSettings.AllowSummaryDeltas = true; //The relevant setting
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
        AdHocSettings.AllowSummaryDeltas = True 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

AdHocSettings.AllowSummaryDeltas = true

![](http://wiki.izenda.us//API/CodeSamples/AllowSummaryDeltas/allowsummarydeltas_true.png)

Results

![](http://wiki.izenda.us//API/CodeSamples/AllowSummaryDeltas/allowsummarydeltas_results_true.png)

---

AdHocSettings.AllowSummaryDeltas = false

![](http://wiki.izenda.us//API/CodeSamples/AllowSummaryDeltas/allowsummarydeltas_false.png)

Results

![](http://wiki.izenda.us//API/CodeSamples/AllowSummaryDeltas/allowsummarydeltas_results_false.png)