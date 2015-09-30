#Creating a many-to-many database join and hiding the middle table as a datasource

[[_TOC_]]

##Question

How do I join two tables in Izenda that are in a many-to-many relationship with each other? I have a connecting table for the relationship, but I don't want the user to see the connecting table listed as a datasource.

##Answer

In order to achieve the results required for this scenario, some understanding about how Izenda handles constraints is required. This tutorial will deal with C# and VB as well as manipulating objects that Izenda normally controls automatically. The solution will vary based on your application's specific needs. However, here is what the process will require in its most basic form.

For this tutorial, all changes being made will exist in your CustomAdHocConfig class that is normally contained inside the Global.asax.

First, we need an instance variable to hold a reference to the driver.

``` csharp
Public Class CustomAdHocConfig : FileSystemAdHocConfig
  private oldDriver As Driver = null;

  {...} 'InitializeReporting, PreExecuteReportSet, etc.
End Class
```

``` visualbasic
public class CustomAdHocConfig Inherits FileSystemAdHocConfig
{
  private oldDriver As Drier = Nothing

  {...} //InitializeReporting, PreExecuteReportSet, etc.
}
```

Next, we need to modify the [[InitializeReporting()|/FAQ/InitializeReporting]] method:

``` csharp
public static void InitializeReporting() {
  //Check to see if we've already initialized.
  if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
    return;
  //Initialize System
  AdHocSettings.LicenseKey = "INSERT_YOUR_LICENSE_KEY_HERE";
  AdHocSettings.SqlServerConnectionString = @"INSERT_YOUR_CONNECTION_STRING_HERE";
  {...}
  AdHocContext.Driver.AddConstraint("[dbo].[Orders].[ShipName]", "[dbo].[Suppliers].[CompanyName]");
  AdHocSettings.visibleDataSources = new string[] { "[dbo].[Orders]", "[dbo].[Suppliers]" }; //Set our visible data sources to exclude our middle table
  HttpContext.Current.Session["ReportingInitialized"] = true;
}
```

``` visualbasic
Public Shared Sub InitializeReporting()
  'Check to see if we've already initialized.
  If (HttpContext.Current.Session Is Nothing OrElse (Not (HttpContext.Current.Session("ReportingInitialized") Is Nothing))) Then
    Return
  End If
  'Initialize System
  AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
  AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
  {...}
  AdHocContext.Driver.AddConstraint("[dbo].[Orders].[ShipName]", "[dbo].[Suppliers].[CompanyName]")
  HttpContext.Current.Session("ReportingInitialized") = True
End Sub
```
The statement critical to the [[InitializeReporting()|/FAQ/InitializeReporting]] method is the AddConstraint method call. Here, we set up a relationship between two columns in our two tables with a many-to-many relationship. At this point, the connector table has not entered the equation. This constraint must exist in order to select the two tables with a many-to-many relationship on the datasources tab. We will also reset the driver to re-obtain the database schema objects. This is because setting VisibleDataSources after the initialization of the current driver will not load the columns for any additional data sources.

_*NOTE:* The two columns in the fake constraint MUST have the same datatype._

Next, we modify the [[PreExecuteReportSet()|/FAQ/PreExecuteReportSet]] method.

``` csharp
public override void PreExecuteReportSet(ReportSet reportSet) {
  base.PreExecuteReportSet(reportSet);
  oldDriver = AdHocContext.Driver;
  AdHocContext.Driver = new MSSQLDriver(AdHocSettings.SqlServerConnectionString); //Set the specific type of driver we were using before
  AdHocSettings.VisibleDataSources = new string[] { "[dbo].[Orders]", "[dbo].[Suppliers]", "[dbo].[testcon]" }; //testcon is the name of the middle table we want to join with
  AdHocContext.Driver.AddConstraint("[dbo].[Orders].[OrderID]", "[dbo].[testcon].[ordernum]");
  AdHocContext.Driver.AddConstraint("[dbo].[Suppliers].[SupplierID]", "[dbo].[testcon].[supplier]"); //Add the correct constraints to the driver
  if(reportSet.JoinedTables.Count > 0) //check if we have selected multiple tables
  {
    IEnumerable<JoinedTable> jts = (from JoinedTable jt in reportSet.JoinedTables
      where (jt.DbTable.Name.Contains("Orders") || jt.DbTable.Name.Contains("Suppliers")) || 
             (jt.RightConditionTable.Contains("Orders") || jt.RightConditionTable.Contains("Suppliers"))
           select jt); //use LINQ to check if we selected the tables we want to define the relationship for
    JoinedTable middleJT = new JoinedTable(){
            TableName = "[dbo].[testcon]"                 
    };
    if(jts.Count() == 2) //We have both tables that we want
    {
      //we know the collection only contains the items we want to remove, so it is safe to refer to them by index.
      reportSet.JoinedTables.Remove(jts.ToArray()[1]); 
      reportSet.JoinedTables.Remove(jts.ToArray()[0]);
      //if any other joined tables exist, you can modify them according to your needs. This tutorial will not cover that scenario.
      reportSet.JoinedTables.Add(middleJT); //Add the connector table first. In this example, it will be the table in the FROM. Orders and Suppliers will be the JOINed tables.
      reportSet.JoinedTables.Add(new JoinedTable()
      {
        TableName = "[dbo].[Orders]",
        RightConditionTable = "[dbo].[testcon]",
        RightConditionColumn = "[dbo].[testcon].[ordernum]",
        LeftConditionColumn = "[dbo].[Orders].[OrderID]"
      }); //Add the first table in the many-to-many relationship and relate it to the connector table
      middleJT.RightConditionColumn = "[dbo].[Orders].[OrderID]"; //define the connector table's relationship. If the connector table is in position 0 of the JoinedTables list, this won't matter. 
      middleJT.LeftConditionColumn = "[dbo].[testcon].[ordernum]"; //If the connector table is not in position 0, then relate it to another table that is not in the many-to-many relationship
      middleJT.RightConditionTable = "[dbo].[Orders]"; //This tutorial will assume the connector table is in position 0 of the JoinedTables list.
      reportSet.JoinedTables.Add(new JoinedTable()
      {
        TableName = "[dbo].[Suppliers]",
        RightConditionTable = "[dbo].[testcon]",
        RightConditionColumn = "[dbo].[testcon].[supplier]",
        LeftConditionColumn = "[dbo].[Suppliers].[SupplierID]"
      }); //Add the second table in the many-to-many relationship and relate it to the connector table
    }
  }
}
```

``` visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As ReportSet)
  MyBase.PreExecuteReportSet(reportSet)
  oldDriver = AdHocContext.Driver
  AdHocContext.Driver = new MSSQLDriver(AdHocSettings.SqlServerConnectionString) 'Set the specific type of driver we were using before
  AdHocSettings.VisibleDataSources = New string() { "[dbo].[Orders]", "[dbo].[Suppliers]", "[dbo].[testcon]" } 'testcon is the name of the middle table we want to join with
  AdHocContext.Driver.AddConstraint("[dbo].[Orders].[OrderID]", "[dbo].[testcon].[ordernum]")
  AdHocContext.Driver.AddConstraint("[dbo].[Suppliers].[SupplierID]", "[dbo].[testcon].[supplier]") 'Add the correct constraints to the driver
  If (reportSet.JoinedTables.Count > 0) Then
    Dim jts As IEnumerable(Of JoinedTable) = (From jt As JoinedTable In reportSet.JoinedTables
      Where (jt.DbTable.Name.Contains("Orders") OrElse jt.DbTable.Name.Contains("Suppliers")) OrElse
      (jt.RightConditionTable.Contains("Orders") OrElse jt.RightConditionTable.Contains("Suppliers"))
      Select jt)
    Dim middleJT As New JoinedTable() With {
      .TableName = "[dbo].[testcon]"
    }
    If (jts.Count() = 2) Then
      reportSet.JoinedTables.Remove(jts.ToArray()(1))
      reportSet.JoinedTables.Remove(jts.ToArray()(0))
      reportSet.JoinedTables.Add(middleJT)
      reportSet.JoinedTables.Add(New JoinedTable() With {
        .TableName = "[dbo].[Orders]",
        .RightConditionTable = "[dbo].[testcon]",
        .RightConditionColumn = "[dbo].[testcon].[ordernum]",
        .LeftConditionColumn = "[dbo].[Orders].[OrderID]"
      })
      middleJT.RightConditionColumn = "[dbo].[Orders].[OrderID]"
      middleJT.LeftConditionColumn = "[dbo].[testcon].[ordernum]"
      middleJT.RightConditionTable = "[dbo].[Orders]"
      reportSet.JoinedTables.Add(New JoinedTable() With {
        .TableName = "[dbo].[Suppliers]",
        .RightConditionTable = "[dbo].[testcon]",
        .RightConditionColumn = "[dbo].[testcon].[supplier]",
        .LeftConditionColumn = "[dbo].[Suppliers].[SupplierID]"
      })
    End If
  End If
End Sub
```

The above code in the [[PreExecuteReportSet()|/FAQ/PreExecuteReportSet]] method will re-define the relationship between the two tables in a many-to-many relationship and insert the connector table silently. This will produce a working join on the two tables while leaving out the pre-defined fake join. The user will be able to freely select the two tables in the many-to-many relationship without seeing the connecting table.

Finally, we need a statement in the [[PostExecuteReportSet()|/FAQ/PostExecuteReportSet]] method to reset the driver.

``` csharp
public override void PostExecuteReportSet(ReportSet reportSet)
{
  base.PostExecuteReportSet(reportSet);
  AdHocContext.Driver = oldDriver;
}
```

``` visualbasic
Public Overrides Sub PostExecuteReportSet(ByVal reportSet As ReportSet)
  MyBase.PostExecuteReportSet(reportSet)
  AdHocContext.Driver = oldDriver
End Sub
```


Resetting the driver after report execution will ensure that the tables with no relationship will be selectable again when the user makes subsequent trips to the Report Designer. Other users in the system without the ability to select the datasources in question will not see any change in their current behavior. Report definitions using the relationship will not reflect the internal process. The fake constraint will appear in the definition.