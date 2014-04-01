#Using Hidden Column Settings

[[_TOC_]]

The hidden column setting removes database fields from the report viewer and report designer dropdowns. 
Please note that you should specify the full column name with the table name and schema. Also all parts of the name should be enclosed in square brackets. So the format of the correct full column name is "[Schema].[TableName].[ColumnName]" 
In the example below we want to hide the OrderID column of the Orders table from dropdowns in Izenda:

```csharp
AdHocSettings.HiddenColumns = new string[] { "[dbo].[Orders].[OrderID]" }; 
```