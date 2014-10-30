#ChartSortFields

[[_TOC_]]

##About

Gets or sets the list of additional columns that are used to sort chart data. This will apply only when using charts that have an additional chart element, such as Pareto charts. The resulting chart will sort elements according to any sort already specified by the report designer plus the value of the separator column. The strings entered into the array should be the column name without the schema and table.

_**Note:** The wildcard "*" denotes the list of existing sort items on the chart._
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
    AdHocSettings.ChartSortFields = new string[] {"*", "ShipCountry"}; //The relevant setting
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
        AdHocSettings.ChartSortFields = New String() {"*", "ShipCountry"} 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

A sample report definition. Note the chart's "line value" field value.

![](http://wiki.izenda.us/API/CodeSamples/ChartSortFields/chart_sort_fields_report_def.png)

AdHocSettings.ChartSortFields = {"*", "ShipCountry"}

![](http://wiki.izenda.us/API/CodeSamples/ChartSortFields/chart_sort_fields_set.png)

###Query Results

```sql
SELECT DISTINCT TOP 10 
[dbo].[Employees].[LastName] AS 'Label', SUM([dbo].[Orders].[Freight]) AS 'Value', [dbo].[Shippers].[CompanyName] AS 'Separator', COUNT([dbo].[Orders].[ShipCountry]) AS 'LineValue'
FROM [dbo].[Orders] WITH(NOLOCK) 
INNER JOIN [dbo].[Shippers] WITH(NOLOCK)  ON [dbo].[Shippers].[ShipperID]=[dbo].[Orders].[ShipVia]
INNER JOIN [dbo].[Customers] WITH(NOLOCK)  ON [dbo].[Customers].[CustomerID]=[dbo].[Orders].[CustomerID]
INNER JOIN [dbo].[Employees] WITH(NOLOCK)  ON [dbo].[Employees].[EmployeeID]=[dbo].[Orders].[EmployeeID]
GROUP BY [dbo].[Employees].[LastName], [dbo].[Shippers].[CompanyName]
ORDER BY SUM([dbo].[Orders].[Freight]) DESC, COUNT([dbo].[Orders].[ShipCountry]);
```

AdHocSettings.ChartSortFields = null

![](http://wiki.izenda.us/API/CodeSamples/ChartSortFields/chart_sort_fields_empty.png)

###Query Results

```sql
SELECT DISTINCT TOP 10 
[dbo].[Employees].[LastName] AS 'Label', SUM([dbo].[Orders].[Freight]) AS 'Value', [dbo].[Shippers].[CompanyName] AS 'Separator', COUNT([dbo].[Orders].[ShipCountry]) AS 'LineValue'
FROM [dbo].[Orders] WITH(NOLOCK) 
INNER JOIN [dbo].[Shippers] WITH(NOLOCK)  ON [dbo].[Shippers].[ShipperID]=[dbo].[Orders].[ShipVia]
INNER JOIN [dbo].[Customers] WITH(NOLOCK)  ON [dbo].[Customers].[CustomerID]=[dbo].[Orders].[CustomerID]
INNER JOIN [dbo].[Employees] WITH(NOLOCK)  ON [dbo].[Employees].[EmployeeID]=[dbo].[Orders].[EmployeeID]
GROUP BY [dbo].[Employees].[LastName], [dbo].[Shippers].[CompanyName]
ORDER BY SUM([dbo].[Orders].[Freight]) DESC;
```