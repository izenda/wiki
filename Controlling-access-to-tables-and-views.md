To control access to the data sources you can use [AdHocSettings.ViewsOnly](http://www.izenda.com/Site/CodeSample/CodeSample.aspx?setting=ViewsOnly) setting or [AdHocSettings.VisibleDataSources](http://www.izenda.com/Site/CodeSample/CodeSample.aspx?setting=VisibleDataSources) property.

If the ``ViewsOnly`` is set to _true_: only Views will be visible at the Data Sources tab.

The VisibleDataSources property is an array of table names. Only tables in this array will be visible at the Data Sources tab.

_Note: DO NOT use ViewsOnly and VisibleDataSources at the same time!_

**Using ViewsOnly:**

C#
```csharp
Izenda.AdHoc.AdHocSettings.ViewsOnly = true;
```
VB.NET
```visualbasic
Izenda.AdHoc.AdHocSettings.ViewsOnly = True
```
**Using VisibleDataSources:**

C#
```csharp
    Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[] { "Products", "Categories" };
```
VB.NET
```visualbasic
    Izenda.AdHoc.AdHocSettings.VisibleDataSources = New String() { "Products", "Categories" }
```