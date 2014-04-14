#VisibleDataSources

[[_TOC_]]

Gets or sets the array of names for tables and views that should be shown in the "Data Sources (Tables and Views)" dropdown in the ReportDesigner on the Data Sources tab. Setting any values in this list will completely override the normally constructed list of tables and views on a per-user basis.

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
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub

    Public Overrides Sub ConfigureSettings()
        AdHocSettings.VisibleDataSources = New String() {"Datasource1", "Datasource2"}
    End Sub
End Class
```

##Screenshots

**AdHocSettings.VisibleDataSources = new string[] { "Products", "Orders", "Customers" };**

![VisibleDataSources = new string[] {"Products", "Orders", "Customers" };](/API/CodeSamples/VisibleDataSources/VisibleDataSources)