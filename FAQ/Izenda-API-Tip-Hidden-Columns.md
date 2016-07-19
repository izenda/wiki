#Izenda API Tip: Hidden Columns

Acceptable formats for AdHocSettings.HiddenColumns API syntax:

```csharp
AdHocSettings.HiddenColumns = new string[] { "[dbo].[Orders].[CustomerID]" };
AdHocSettings.HiddenColumns = new string[] { "[Orders].[CustomerID]" };
AdHocSettings.HiddenColumns = new string[] { "Orders.CustomerID" };
AdHocSettings.HiddenColumns = new string[] { "CustomerID" };
```

When using Izenda Fusion, you must use the full identifier, for example: [db].[schema].[table].[column].