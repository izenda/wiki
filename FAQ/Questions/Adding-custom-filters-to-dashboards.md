#How Does Filtering In Dashboards Work?

[[_TOC_]]

##About
To apply filters in a dashboard, all reports included in the dashboard must contain the same filter. 

Filters in dashboards are inherited upwards from reports which contribute a report part to that dashboard. Any filter which ALL reports have in common will be sent to the dashboard, where a control will appear in the filters pane. Otherwise, the control will not appear, the filter will still be in place for that report part, but it will not be available to be changed from the dashboard.

Here is an example. Let's say I have reports 1, 2, and 3.

Report 1 has filters on the fields DS1.FieldA, DS1.FieldB, and DS1.FieldC. 

Report 2 has filters on the fields DS1.FieldA, DS2.FieldB, and DS1.FieldC

Report 3 has filters on the fields DS2.FieldA, and DS1.FieldC

All of these filters will be applied to their constituent report parts. So, the report part from Report 1 will have filters for DS1.FA, DS1.FB, and DS1.FC. 

However, the dashboard as a whole will only have a filter control for DS1.FC, as this is the only combination of Table.Field which all reports have in common.

There is a setting which allows us to pay attention to the qualified Table.Field name, or just the Field name. If the setting AdHocSettings.UseColumnNameForDashboardCommonFilters is set to False, then the filter FieldA will also show up on the dashboard - in Report 1 and 2, FieldA comes from DataSource1, and in Report 3 it comes from DataSource2. 

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