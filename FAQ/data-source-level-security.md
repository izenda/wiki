#How Do I Create Data Source Level Security?

**Table and View Access**

To limit what data sources a user can see, apply the visible tables setting. Its argument is an array of strings. Izenda recommends creating database views to simplify the user experience. Izenda Reports will only show views, if you set ``ViewsOnly`` to _true_. Here is an example:

```csharp
//set access to which tables and views are visible

Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[]{ "Products", "Categories" };
```
[[Please see this code sample for more detail|Controlling access to tables and views]].