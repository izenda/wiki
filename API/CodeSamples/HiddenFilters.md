#HiddenFilters

[[_TOC_]]

##About

This controls row-level security throughout the tool. This collection is designed to be used in all multi-tenant systems and systems where users are restricted to certain records. 
Hidden filters are applied per-report upon execution and are invisible to the user. Users may still add their own filters to reports and will not override the hidden filters applied to them.

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
    AdHocSettings.HiddenFilters.Add("EmployeeID", new int[5] { 1, 2, 3, 4, 5 });
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

##Global.asax (VB.NET)

```visualbasic
'main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
Public Class CustomAdHocConfig
    Inherits Izenda.AdHoc.DatabaseAdHocConfig

    'Configure settings
    'Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
    Shared Sub InitializeReporting()
        'Check to see if we've already initialized.
        If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.HiddenFilters.Add("EmployeeID", New Integer(4) { 1, 2, 3, 4, 5 })
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Fully qualified filters

If, for instance, you have two database tables in the same schema with identical names but they do not contain the same data, you can use fully qualified names with the hidden filters list to ensure you only filter the correct one. This can be done by prepending the schema and table name to the column name as in the example below:

###C♯

```csharp
AdHocSettings.HiddenFilters.Add("[dbo].[Employees].[EmployeeID]", new int[5] { 1, 2, 3, 4, 5 });
```

###VB.NET

```visualbasic
AdHocSettings.HiddenFilters.Add("[dbo].[Employees].[EmployeeID]", New Integer(4) {1, 2, 3, 4, 5})
```

_**Note:** You will have to add a new filter for each individual table you wish to filter by this methodology._