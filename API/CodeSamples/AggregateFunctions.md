#AggregateFunctions

[[_TOC_]]

##About

This collection is used to store custom-built aggregation function definitions. By default, this list will add onto the pre-existing set of aggregate function definitions. It will not override the pre-built functions. To access your custom-built aggregate functions, simply click on the [[Fields Tab]] of the Report Designer and select a column that can support your aggregate function. It will appear in the list of functions at the very bottom. There are a variety of methods for [[implementing a custom aggregate function|/FAQ/Questions/Custom_Aggregate_Functions]].

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
    AdHocSettings.AggregateFunctions["Group By Fiscal Year"] = new SimpleAggregateFunction("DATEPART(yyyy, DATEADD(mm, 3, {0}))", "Group (Fiscal Year)", new SqlTypeGroup[] { SqlTypeGroup.Date, SqlTypeGroup.DateTime }, true, true); //The relevant setting
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
        AdHocSettings.AggregateFunctions("Group By Fiscal Year") = new SimpleAggregateFunction("DATEPART(yyyy, DATEADD(mm, 3, {0}))", "Group (Fiscal Year)", new SqlTypeGroup() { SqlTypeGroup.Date, SqlTypeGroup.DateTime }, True, True) 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

**The Group By Fiscal Year Function**

![]()