#FilterAliases

[[_TOC_]]

##About

Gets or sets the Filter names(aliases) that the user sees in the Report Designer, Report Viewer, and Dashboards. This can be set globally or on a per-user basis. The key is the name of your column in the database and the value is the alias you wish the user to see. This is useful for localization and when custom filters are used in your application.

Below is a sample global.asax using the ExtendedFunctions setting. The code block will appear within ``<script runat="server"> </script>`` tags within global.asax.

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
    AdHocSettings.FilterAliases["ShipCity"] = "DepartureCity"; //The relevant setting
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
        AdHocSettings.FilterAliases("ShipCity") = "DepartureCity" 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Fully-qualified column names

You can use fully-qualified column names to allow columns from different tables and schemas with the same name to be aliased differently if you so desire. To do that, simply use bracket notation to specify the schema and table:

```csharp
AdHocSettings.FilterAliases.Add("[dbo].[Orders].[ShipCity]", "DepartureCity");
```

###Screenshots

![](/Home/2016-01-07-17_49_26-Report-Designer.png)

##UI Aliasing of Filter Names

The filter field name can be aliased using the Description field. This can be accessed in the Report designer from the filter tab or from the viewer by clicking the gear icon in the filter.

Here the Description can be entered in the Report Designer's Filter Tab.

![](/Guides/ReportDesign/5.0-Filters-tab/rdfilter.png)

And here is the description field in the Report Viewer by clicking the gear icon on the filter.

![](/Guides/ReportDesign/5.0-Filters-tab/vw1filter.png)