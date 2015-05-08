#ShowJoinAliasTextboxes

[[_TOC_]]

##About

Gets or sets the value indicating whether the join type alias text boxes should be shown on the DataSources tab (Advanced Mode). Advanced mode can be accessed by clicking "Advanced" on the DataSources tab when [[ShowDataSourcesAsCheckBoxes|/API/CodeSamples/ShowDataSourcesAsCheckBoxes]] is true, or by setting [[ShowDataSourcesAsCheckBoxes|/API/CodeSamples/ShowDataSourcesAsCheckBoxes]] to false.

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


    AdHocSettings.ShowJoinAliasTextboxes = true; // Enable join alias text boxes



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

        AdHocSettings.ShowJoinAliasTextboxes = false 'Disable join alias text boxes. By default, this is set to false.

        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End
```

##Screenshots
![](/API/CodeSamples/ShowJoinAliasTextboxes/Aliasing_TextBox2.png)
![](/API/CodeSamples/ShowJoinAliasTextboxes/No_Aliasing_TextBox.png)

##Instruction

By default, when the same table is used multiple times as joined table, Izenda differentiates them by number as below.

![JoinAlias](/API/CodeSamples/ShowJoinAliasTextboxes/JoinAlias.png)

Using Join Alias Textbox, user can distinguish the joined tables more clearly

**a.** Enable Join Alias Textbox. Refer to above [Global.asax](http://wiki.izenda.us/API/CodeSamples/ShowJoinAliasTextboxes#About)

**b.** In Join Alias Textbox, enter aliases and click 'Update datasources aliases'. 

**c.**In FIELDS tab, the oined tables should appear as aliased as below 

![JoinAlias](/API/CodeSamples/ShowJoinAliasTextboxes/JoinAlias2.png)


## How to implement 'join alias' via hardcoding

Below is a sample code that shows how to hardcode aliasing specific table names

```csharp
public override void PreSaveReportSet(string name, ReportSet reportSet) {
      //the collection of table names and the associated alias
      Dictionary<string, string> tableNameToAlias = new Dictionary<string, string>();

      //loop through the report's set of tables
      foreach (JoinedTable jt in reportSet.JoinedTables) {
        if (!String.IsNullOrEmpty(jt.Alias))
          return;
        if (!tableNameToAlias.ContainsKey(jt.TableName))
          tableNameToAlias.Add(jt.TableName, LookupTableAlias(jt.TableName)); //Add the table and set the alias as the full name with special characters replaced
      }
      //Set all the tables in the report to have the table on the right side of the join reflect the alias of itself.
      foreach (JoinedTable jt in reportSet.JoinedTables) {
        jt.Alias = tableNameToAlias[jt.TableName];
        if (!String.IsNullOrEmpty(jt.RightConditionTable))
          jt.RightAlias = tableNameToAlias[jt.RightConditionTable];
      }
      //update the selected fields and filters on the report to reflect the new aliases of the joined tables
      foreach (Report report in reportSet.Reports.AllValues) {
        foreach (Field field in report.Fields)
          if (field.DbColumn != null && field.DbColumn.Table != null)
            field.AliasTable = tableNameToAlias[field.DbColumn.Table.FullName];
        foreach (Filter filter in report.Filters)
          if (filter.dbColumn != null && filter.dbColumn.Table != null)
            filter.AliasTable = tableNameToAlias[filter.dbColumn.Table.FullName];
      }
      //update the selected filters on the entire reportSet to reflect the new aliases of the joined tables (in case of a dashboard)
      foreach (Filter filter in reportSet.Filters)
        if (filter.dbColumn != null && filter.dbColumn.Table != null)
          filter.AliasTable = tableNameToAlias[filter.dbColumn.Table.FullName];
    }


// In this case, 'Orders' table is to be aliased as 'o1','Customers' as 'c1','Order Details' as 'od1' and so on
    public string LookupTableAlias(string tableName) {
      switch (tableName) {
        case "[dbo].[Orders]":
          return "o1";
        case "[dbo].[Customers]":
          return "c1";
        case "[dbo].[Order Details]":
          return "od1";
        case "[dbo].[Employees]":
          return "e1";
        case "[dbo].[Suppliers]":
          return "s1";
        default:
          return tableName.Replace("[", "").Replace("]", "").Replace(".", "_");
      }


```







