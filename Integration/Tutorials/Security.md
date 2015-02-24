#Security Guide

[[_TOC_]]

Izenda Reports fully integrates with the security of existing ASP.NET applications allowing for trusted self-service reporting in multi-tenant environments. Using the API, security can be applied on-the-fly based on the requirements of the application and user credentials.

Type of security|Example|Implementation Details
----------------|-------|----------------------
[Login](#Login-Security) |Users must login before gaining access to reports.|[[RequireLogin|/API/CodeSamples/RequireLogin]] <br> [[CurrentUserName|/API/CodeSamples/CurrentUserName]] <br> [[CurrentUserIsAdmin|/API/CodeSamples/CurrentUserIsAdmin]] <br> [[Your Login Page Integration|/FAQ/integrate-login-page]] |
[Data Sources](#Data-Sources)|A specific user can only see certain data sources.|[[RequireLogin|/API/CodeSamples/RequireLogin]] <br> [Basic Report Sharing](http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab#9.1-Share-With-&-Rights) <br> [[VisibleDataSources|/API/CodeSamples/VisibleDataSources]] <br> [Database Security](http://wiki.izenda.us/Integration/Tutorials/connect-to-the-database#Per-user-database-connections) |
[User Driven Report Sharing](#User-Driven-Report-Sharing)|A user can save a report and decide if they want other users to see this report. They can also mark a report read-only meaning it can be viewed but not saved over.|[Basic Report Sharing](http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab#9.1-Share-With-&-Rights) <br> [[CurrentUserIsAdmin|/API/CodeSamples/CurrentUserIsAdmin]] <br> [[ReportsPath|/API/CodeSamples/ReportsPath]] |
[Custom Report Control](#Custom-Report-Control)|Different departments can see different base reports.|[[VisibleDataSources hides reports for non-accessible datasources|/API/CodeSamples/VisibleDataSources]] <br>[[The ListReports method may be overridden|/FAQ/ListReports]] <br>[[Storing Reports|]]<br> [[ReportsPath|/API/CodeSamples/ReportsPath]] |
[Overwriting and Deleting Reports](#Overwriting-and-Deleting-Reports)|Users can load shared or base reports, but should not be able to delete them or overwrite them.|[[AllowOverwritingReports|/API/CodeSamples/AllowOverwritingReports]] <br>[[AllowDeletingReports|/API/CodeSamples/AllowDeletingReports]] <br>[[CurrentUserIsAdmin|/API/CodeSamples/CurrentUserIsAdmin]]<br>
[Altering Capabilities by Role](#Altering-Capabilities-by-Role)|Only power users should see the modify report button on the report viewer. Others will only access the report viewer.|[[ShowDesignLinks|/API/CodeSamples/ShowDesignLinks]] <br> [[AllowOverwritingReports|/API/CodeSamples/AllowOverwritingReports]] [[ShowSettingsButton|/API/CodeSamples/ShowSettingsButton]]
[Field/Record or Tenant Level Security](#Field/Record-or-Tenant-Level-Security)|Salespeople look at the same report but see different data based on their territory and credentials. In a multi-tenant environment, reports and data for each customer, group, or tenant should be isolated.|[[PreExecuteReportSet - Hidden Filters|/FAQ/applying-hidden-filter-using-inner-query]] <br>[[ProcessEqualsSelectList|/FAQ/ProcessEqualsSelectList]] <br>[Field & Record Level Security](http://wiki.izenda.us/FAQ/Questions/Applying-Security#Field-Level-Access)

###Login Security

Login security is fairly basic in Izenda to accommodate our customers' existing login processes. Logging into Izenda basically consists of four settings: [[CurrentUserName|/API/CodeSamples/CurrentUserName]], [[CurrentUserIsAdmin|/API/CodeSamples/CurrentUserIsAdmin]], [[CurrentUserRoles|/API/CodeSamples/CurrentUserRoles]], and [[CurrentUserTenantID|/API/CodeSamples/CurrentUserTenantID]] with the first one being the only one that is absolutely required to be considered logged in. However, it is good practice to set the user's admin status all the time. 

You can use the login page packaged with the starter kit or your own login page and login process to authenticate users who access the reporting tool. However you wish to get the user's information, Izenda can mold itself to your basic structure. A final consideration is that if a login page is specified this way, you should ensure that ``InitializeReporting()`` is called again AFTER the login process to ensure the user is properly authenticated. In the below example, **LookupUserName**, **LookupAdminRole**, and **GetTenantID** are used to represent methods that get the values associated with the various settings.

```csharp
public static void InitializeReporting()
{  
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
	AdHocSettings.CurrentUserName = LookupUserName();  
	AdHocSettings.CurrentUserIsAdmin = LookupAdminRole();  
        AdHocSettings.CurrentUserTenantId = GetTenantID();
	AdHocSettings.CurrentUserRoles = new string[] {(string)HttpContext.Current.Session["Role"]};
        AdHocSettings.VisibleDataSources = new string[]  { "Products", "Orders", "Customers" }; 
        AdHocsettings.LoginPage = "YOUR_LOGIN_PAGE.aspx";
        AdHocSettings.RequireLogin = true; //Require user to be directed to the login page when they have no username or the default username
}
```

###Data Sources

The [[API|/API/AdHocSettings]] allows control over which data sources a user sees based on their [[credentials|/FAQ/How-user-credentials-are-applied]]. In the following example, members of the "Sales" role would see additional data sources that normal users would not. Any reports that utilize these data sources would only be visible to members of the sales role.

```csharp
 
    AdHocSettings.VisibleDataSources = new string[] {"Products"};         
    if(IsInRole("Sales"))  
    {
        AdHocSettings.VisibleDataSources = new string[]
        {"Products", "Categories", "Orders"};   
    }
```

The method will need to be called from your login process with the following line.

```csharp
global_asax.CustomAdHocConfig.InitializeReporting();
```

###User Driven Report Sharing

You can learn more about sharing reports and controlling accessibility [[here|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab#9.1-Share-With-&-Rights]].

###Custom Report Control

To apply additional constraints to which users see what reports, it is necessary to override the FilteredListReports method. This is a list of reports that are guaranteed to be available to the current user based on their roles or tenant ID. If you need additional checks to be performed, you can either call the base implementation and then apply any other parameters you require or simply leave out the base implementation and perform the checks yourself.

```csharp
public override ReportInfo[] FilteredListReports() {
      ReportInfo[] reports = ListReports(); //Get the list of loaded reports. Can be overridden or used as-is
      ArrayList result = new ArrayList();

      foreach (ReportInfo info in reports) {
        if (info.Category == "Hidden reports")
          continue;
        ReportSet reportSet = LoadFilteredReportSet(info.Name);
        if (reportSet != null && reportSet.CanBeLoaded)
          result.Add(info);
      }
      return (ReportInfo[])result.ToArray(typeof(ReportInfo));
    }
```

###Overwriting and Deleting Reports</a>

The API allows control of deleting or modifying reports. Reports marked Read-Only or locked can not be modified or deleted even if the settings below are enabled. 

```csharp
	AdHocSettings.AllowOverwritingReports = true;           
	AdHocSettings.AllowDeletingReports = true;
```

###Altering Capabilities by Role and Tenant ID

The versatility of Izenda reports allows for all settings to be applied on a per-user basis. The only limit to the customization level of Izenda's settings is your relevant coding experience, since this does require basic knowledge of either VB.NET or C#. 
The following code applies properties like the connection string, where reports are stored and visibility of the modify button modify button based on the user.

```csharp
public static void InitializeReporting()
{  
        //GetConnectionForUser, GetUserCompany, GetUserDepartment, GetUserRole, and GetTables are all user-defined methods in global.asax
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
	//Set connection string per-tenant  
	AdHocSettings.SqlServerConnectionString = GetConnectionForUser();  
	//Set the stored reports file folder path per-tenant  
	AdHocSettings.ReportsPath="\\"   GetUserCompany()   "\\"     
	AdHocSettings.CurrentUserTenantId = GetUserDepartment(); //Organizational level security    
        AdHocSettings.CurrentUserRoles = new string[]{GetUserRole()}; //Role based security
	//Set table and view access  
        
	AdHocSettings.VisibleDataSources = GetTables(AdHocSettings.CurrentUserRoles);
	if (AdHocSettings.CurrentUserRoles.Contains("PowerUser"))  //User level security
	{    
		AdHocSettings.ShowSettingsButton = true;    
		AdHocSettings.AllowDeletingReports = false;      
	}
}
```

###Field/Record Level Security

Many applications limit users to specific records based on their credentials. The HiddenFilters API Setting may be used to add hidden filters to reports which limit the results based on the user, their credentials and their tenant. In this example, non-administrators will have data they report on limited when the field **TerritoryID** is present in any of the tables the report is using. In this case, a function called **GetCurrentUserTerritory** returns the value that the hidden filter will use. This will be specific to the user being initialized and will not apply to other users. Therefore, each user will have data filtered according to his/her territory.

```csharp
public static void InitializeReporting()
{
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
	AdHocSettings.HiddenFilters["AccountID"] = AccountID;
		//Set the account tenancy
	if (!Izenda.AdHoc.AdHocSettings.CurrentUserIsAdmin)  
	{    
		//needs to return an array of strings!    
		string[] TerritoryID = GetCurrentUserTerritory(UserName);            
		//add the filters to the reports based on the tenancy of this user    
		AdHocSettings.HiddenFilters["TerritoryID"] = TerritoryID; 
			// or new string[] {"1","2","3","4"};
		
		AdHocSettings.ShowSettingsButton = false; 
		AdHocSettings.AllowDeletingReports = false; 
	}
}
```
### Preventing URL Cross Scripting

In order to make sure a URL doesn't allow JavaScript injection, you must make sure that in your web.config that a page element has the **validateRequest** attribute set to true as you see 

Request Validation Source: [MSDN Request Validation](http://msdn.microsoft.com/en-us/library/hh882339%28v=vs.110%29.aspx)
Modified Webconfig Source: http://archives.izenda.us/ri/webforms-cs.zip

```xml
<?xml version="1.0" encoding="UTF-8"?>
<configuration>
  <system.web>
    <compilation debug="true">
    </compilation>
    <!-- Needed on .NET 4.0
      <httpRuntime requestValidationMode="2.0" />
    -->
    <pages validateRequest="true" enableEventValidation="false" viewStateEncryptionMode="Never" />
    <customErrors mode="Off">
      <error statusCode="403" redirect="NoAccess.htm" />
      <error statusCode="404" redirect="FileNotFound.htm" />
    </customErrors>
  </system.web>
  <system.webServer>
    <staticContent>
      <remove fileExtension=".json" />
      <mimeMap fileExtension=".json" mimeType="application/json" />
    </staticContent>
  </system.webServer>
```

###Determining user privileges

Another consideration to take into account when setting up security with Izenda is to use a restricted database user account in your connection string. Every relational DBMS supported by Izenda uses some kind of database server security model, and we encourage our customers to take full advantage of that. Restricting access to create or delete tables, restricting which schemas are able to be viewed, and which stored procedures can be executed are important considerations in any instance where a new entry point is introduced to a secure or sensitive system.