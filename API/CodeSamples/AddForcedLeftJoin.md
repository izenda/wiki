#AddForcedLeftJoin

[[_TOC_]]

##About

Gets or sets the column names of tables that should always use a LEFT OUTER JOIN instead of a RIGHT INNER JOIN (the standard).

##When should you use AddForcedLeftJoin

Sometimes there are situations where some data sources should always be joined using a left join. 
This means that certain data source pairs will be always joined using a left join instead of a right inner join (by default). This will also override any user-defined joins in the Report Designer. This can aid in ease in report creation, as the user will not have to specify the join type with the menu controls every time he/she creates a report joining these data sources.

##How to use AddForcedLeftJoin

To force data source pairs to be joined using a left join, you should call the setting within your global.asax.

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
    AdHocContext.Driver.AddForcedLeftJoin("Order Details", "Orders"); //The relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

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
        AdHocContext.Driver.AddForcedLeftJoin("Order Details", "Orders") 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

_**Note:** AddForcedLeftJoin will force tables to be joined using a left join. This means that even if you specify another join type in the Report Designer or manually in code, this setting will override the other join automatically._

_**Note2:** The order of parameters in this method is important. (i.e. these tables will be joined with a left join only if the "Orders" table (left side) is joined to the "Order Details" table (right side) but not vice versa._

So, the generated SQL will looks like this:

```sql
[dbo].[Northwind].[Order Details] LEFT OUTER JOIN [dbo].[Northwind].[Orders]
```

You can also use a single table parameter to force that table to be joined with all other tables using a left join:

```csharp
AdHocContext.Driver.AddForcedLeftJoin("Orders");
```

##AddForcedLeftJoin and Constraints

You can join tables in two ways on the Report Designer: manually using Advanced mode, and automatically using check-boxes.

**Advanced mode:** In this case, you will be able to specify the join order and conditions. make sure that the join order corresponds to the order that you specified when you invoked the AddForcedLeftJoin method.

Below is an example of how to join tables using Advanced mode:
 
![]()

**[[Simple (check-box) mode|/API/CodeSamples/ShowDataSourcesAsCheckboxes]]:** In this case, tables will be joined using existing database constraints. If your database does not use constraints or the constraints you need do not exist, you will have to [[create them|/API/CodeSamples/AddConstraint]]. In our example database, the constraints are already present. So we will go ahead and call AddForcedLeftJoin.

```csharp
AdHocContext.Driver.AddForcedLeftJoin("Orders", "Order Details");
```

Next we will select our tables in the Report Designer

![](http://wiki.izenda.us/API/CodeSamples/AddForcedLeftJoin/addforcedleftjoin.png)

_**Note:** You need to pay even more attention to the constraints in case you use the single-parameter overload of the AddForcedLeftJoin method. 

_**Note2:** It is preferable to use check-box mode with the AddForcedLeftJoin method. This is because you will have full control of joining and joining rules in this case.

This example will generate the following SQL (Note that "Orders" and "Order Details" have been joined using LEFT OUTER JOIN):

```sql
SELECT *
FROM [dbo].[Customers]
INNER JOIN [dbo].[Orders] ON [dbo].[Orders].[CustomerID]=[dbo].[Customers].[CustomerID]
LEFT OUTER JOIN [dbo].[Order Details] ON [dbo].[Orders].[OrderID]=[dbo].[Order Details].[OrderID] 
									  AND [dbo].[Order Details].[ProductID]=[dbo].[Orders].[ProductID] 
									  AND [dbo].[Order Details].[OrderID]=[dbo].[Orders].[OrderID]
INNER JOIN [dbo].[Products] ON [dbo].[Order Details].[ProductID]=[dbo].[Products].[ProductID];
```

##Advanced Example

Here is a full example of how to use AddForcedLeftJoin and [[AddConstraints|/API/CodeSamples/AddConstraints]]:

```csharp
AdHocContext.Driver.AddForcedLeftJoin("Orders", "Order Details");
AdHocContext.Driver.AddConstraint("[Orders].[OrderID]", "[Order Details].[OrderID]");
AdHocContext.Driver.AddForcedLeftJoin("Employees");
```