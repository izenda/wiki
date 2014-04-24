#Security Levels

[[_TOC_]]

##About

Izenda offers many various methods of implementing security over the scope of your reports. It is highly customizable and can be controlled through the global.asax file. Here we will provide various security samples for different levels of access. You may modify these to suit your own organization's needs.

##Basic security sample

Here we demonstrate what basic security settings might look like in your application. In this case, initialization would be performed while confirming the user's identity. You may also call the ``InitializeReporting()`` method after the user has been authenticated.

```csharp
public static void InitializeReporting() {
    AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
    AdHocSettings.SqlServerConnectionString = "...";
    AdHocSettings.CurrentUserName = GetUserName();
    AdHocSettings.CurrentUserTenantId = GetTenantID();
    string role = GetUserRoleFromApp()
    if(role == "Admin")
    {
    	Izenda.AdHoc.AdHocSettings.VisibleDataSources = 
            new string[] { "Purchasing.Vendor", "Products", "Orders", "Order Details", "Customers" };
    }
    else
    {
        Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[] { "Products", "Orders", "Customers" };
	Izenda.AdHoc.AdHocSettings.CurrentUserIsAdmin = false;
	Izenda.AdHoc.AdHocSettings.ShowSettingsButton = false;
	Izenda.AdHoc.AdHocSettings.ShowSqlOutputIcon = false;
	Izenda.AdHoc.AdHocSettings.HiddenFilters["ShipCountry"]= GetUserCountry();
    }
}
```

You could also use more complex logic. For example, you could filter all queries for the particular user or user group.

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
	bool isLocalManager = false;
	foreach (string role in AdHocSettings.CurrentUserRoles)
		if (role == "Local Manager")
			isLocalManager = true;
	if (!AdHocSettings.CurrentUserIsAdmin || isLocalManager)
	{
		Filter filter = new Filter();
		filter.Column = "ShipCity";
		filter.SqlOverride = "ShipCity IN (SELECT ShipCity FROM [dbo].[Orders] WHERE ShipCountry = 'USA')";
		reportSet.Filters.AddHidden(filter);
	}
}
```

##Data Source Level Security

**Table and View Access**

To limit what data sources a user can see, apply the [[VisibleDataSources|/API/CodeSamples/VisibleDataSources]] setting. Its argument is an array of strings. Izenda recommends creating database views to simplify the user experience. Izenda Reports will only show views if you set [[ViewsOnly|/API/CodeSamples/ViewsOnly]] to _true_. Here is an example:

```csharp
//set access to which tables and views are visible

if(!AdHocSettings.CurrentUserIsAdmin) 
    Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[]{ "Products", "Categories" };
else
    Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[] {"AdminData", "Employees", "Products", "Categories"};
```

##Field Level Access

Field access provides a way of limiting what a user sees in the application. You can use the [[FieldsRegex|/API/CodeSamples/FieldsRegex]] property to set a general filter on what fields users can select when building reports or you can use the ``PreExecuteReportSet()`` method, demonstrated below.

**Record Level Security Integration**

Izenda Reports supports the unique feature of being able to hide report data on-the-fly on a per user basis. Consider this scenario: Bill, Mary, and John are all sales people. You want to generate the same report for each of them, but with different sales territory data. With Izenda Reports, simply generate one report, give each user a link to that report, and change the filter for each user to show the specific sales data.

In this example, the ``PreExecuteReportSet`` method adds hidden filters to limit data on-the-fly.

```csharp
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
{
  Izenda.AdHoc.Filter f = new Izenda.AdHoc.Filter("TerritoryID");
  f.Value = GetCurrentUserTerritory();
  reportSet.Filters.AddHidden(f);
}
```