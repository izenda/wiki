#How Does Filtering In Dashboards Work?

[[_TOC_]]

##About
To apply filters in a dashboard, all reports included in the dashboard must contain the same filter. 

**The new default behavior for Izenda dashboard filtering** looks at 'fully qualified' column names for matching report filters for dashboard filtering purposes by default.

##Example
Using the Northwinds database

1) Create Report A using the Employee table:

 * Fields:
 * Last Name
 * Country

 * Filter 1: Country
 * Filter 2: Last Name

2) Create Report B using the Supplier table

 * Fields:
 * Supplier Name
 * Country

 * Filter 1: Country
 * Filter 2: Supplier Name

3) Create a dashboard from these two reports

 * Expected dashboard filter: Country

##Explanation

**The default behavior in _classic_ (Pre v6.6) Izenda is to look at _fully qualified_ column names.**

**During v6.7 the default was to use ColumnName only.**

**The current default value is to use the fully qualified field name (AdHocSettings.UseColumnNameForDashboardCommonFilters = True;)**

Although they may share similar values or have the exact same values, _dbo.suppliers.country_ _**IS NOT**_ _dbo.employees.country_ . Because of this, the filter in the example will not show up in the dashboard in vanilla Izenda.

To disable datasource-specific behavior (fully qualified column names) for dashboard filtering, you will need to change the UseColumnNameForDashboardCommonFilters to false in your deployment after upgrading.


##Global.asax (C♯)

```csharp
//Using the fully qualified name to determine common filters (Example: View.ColumnName)
AdHocSettings.UseColumnNameForDashboardCommonFilters = true;

//Using only the 'ColumnName' to determine common filters
AdHocSettings.UseColumnNameForDashboardCommonFilters = false;
```

##Global.asax (VB.NET)

```visualbasic
//Using the fully qualified name to determine common filters (Example: View.ColumnName)
AdHocSettings.UseColumnNameForDashboardCommonFilters = True

//Using only the 'ColumnName' to determine common filters
AdHocSettings.UseColumnNameForDashboardCommonFilters = False
```