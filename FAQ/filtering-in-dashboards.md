#How Does Filtering In Dashboards Work?

To apply filters in a dashboard, all reports included in the dashboard must contain the same filter. 

**New default behavior for Izenda dashboard filtering** (10/31/2013 - DLL v6.6.5052) looks at column names **ONLY** for matching report filters for dashboard filtering purposes.

---------

- **_I create Report A:_**

    _Employee Table:_

    Last Name

    Country

    **Filter 1** : Country

    **Filter 2** : Last Name


- **_I create Report B:_**

    _Supplier Table:_

    Supplier Name

    Country

    **Filter 1** : Country

    **Filter 2** : Supplier Name

- **I create a dashboard from these two reports:**

    _Dashboard contains Filter_ : Country

--------

**The default behavior in _classic_ Izenda is to look at _fully qualified_ column names:**

_dbo.suppliers.country_ _**IS NOT**_ _dbo.employees.country_ - though they may have many of the same values or the exact same- thus filters do not show up in dashboards at all for the above situation.

To re-enable classic behavior, fully qualified column names for dashboard filtering, in your deployment after upgrading:

``AdHocSettings.UseColumnNameForDashboardCommonFilters = false;``