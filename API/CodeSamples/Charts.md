#Charts

[[_TOC_]]

##About

Gets or sets the list of chart types which will appear in the Chart Type dropdown on the Charts tab. This is primarily used to disable chart types. The Visualization chart type will appear based on the Visualizations feature.

**Default Value:** {Trend, Pie, Plot, Bar, Funnel}

**NOTE:** Depending on the [[charting engine|http://wiki.izenda.us/API/CodeSamples/ChartingEngine]], the Plot chart may not exist. Plot does not exist in HTMLCharts, but does exist in DundasCharts.

**Note:** To remove Visualizations from the drop down list you can add this sample below as Visualizations are appended based on the license key after the chart collection is complete.
```csharp
 public override ReportSet LoadReportSet(ReportInfo reportinfo, DatabaseSchema schema)
        {
            AdHocSettings.Charts.Remove("Visualization");
            return base.LoadReportSet(reportinfo, schema);
        }
```

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
    AdHocSettings.Charts = {Pie, Bar}; //The relevant setting
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
        AdHocSettings.Charts = {Pie, Bar} 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```