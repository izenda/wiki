#CustomTimePeriods

[[_TOC_]]

##About

Used to define custom time periods that will be accessible in the 'In Time Period' filter operator on the Filters tab in the ReportDesigner. These options will be appended to the list of time periods that ship with Izenda AdHoc.<br>*Note: There are several overloads for the [[CustomTimePeriod|/FAQ/Questions/Adding-Custom-Time-Periods]] constructor, so you can define different time periods with various types.*

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
    AdHocSettings.CustomTimePeriods.Add("Lunar Cycle", new CustomTimePeriod("Lunar Cycle", new TimeSpan(29, 12, 44, 2, 976)));
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
  public override void ConfigureSettings() {
    AdHocSettings.VisibleDataSources = new string[] {"DataSource1", "DataSource2"};
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
        AdHocSettings.CustomTimePeriods.Add("Lunar Cycle", new CustomTimePeriod("Lunar Cycle", new TimeSpan(29, 12, 44, 2, 976)))
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub
End Class
```