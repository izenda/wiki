#Security Guide

[[_TOC_]]

Izenda Reports fully integrates with the security of existing ASP.NET applications allowing for trusted self-service reporting in multi-tenant environments. Using the API, security can be applied on-the-fly based on the requirements of the application and user credentials.

Type of security|Example|Implementation Details
----------------|-------|----------------------
[Login](#Login-Security) |Users must login before gaining access to reports.|[[RequireLogin]] <br> [[CurrentUserName]] <br> [[CurrentUserIsAdmin]] <br> [[Your Login Page Integration]]
[Data Sources](#Data-Sources)|A specific user can only see certain data sources.|[[RequireLogin]] <br> [[Basic Report Sharing]] <br> [[VisibleDataSource]] <br> [[Database Security]]
[User Driven Report Sharing](#User-Driven-Report-Sharing)|A user can save a report and decide if they want other users to see this report. They can also mark a report read-only meaning it can be viewed but not saved over.|[[Basic Report Sharing]] <br> [[CurrentUserIsAdmin]] <br> [[ReportsPath]] <br> [[Read-Only & Shared Checkboxes]]
[Custom Report Control](#Custom-Report-Control)|Different departments can see different base reports.|[[VisibleDataSources hides reports for non-accessible datasources]] <br>[[ReportsList may be overridden]] <br>[[Storing Reports]]<br> [[ReportsPath]]
[Overwriting and Deleting Reports](#Overwriting-and-Deleting-Reports)|Users can load shared or base reports, but should not be able to delete them or overwrite them.|[[AllowOverwritingReports]] <br>[[AllowDeletingReports]] <br>[[CurrentUserIsAdmin]]<br>
[Altering Capabilities by Role](#Altering-Capabilities-by-Role)|Only power users should see the modify report button on the report viewer. Others will only access the report viewer.|[[ShowDesignLinks]] [[ShowModifyButton]]<br> [[AllowOverwritingReports]] [[ShowSettingsButton|/API/CodeSamples/ShowSettingsButton]]
[Field/Record or Tenant Level Security](#Field/Record-or-Tenant-Level-Security)|Salespeople look at the same report but see different data based on their territory and credentials. In a multi-tenant environment, reports and data for each customer, group, or tenant should be isolated.|[[PreExecuteReportSet - Hidden Filters]] <br>[[ProcessEqualsSelectList]] <br>[[Field & Record Level Security]]

###Login Security

To enable basic login security, add the following code to the ``InitializeReporting()`` method of your CustomAdHocConfig class. This is normally found in Global.asax file. The code should look up user credentials from your application, database or windows authentication and provide it to the Izenda Reports API. Furthermore, specifying your login page will ensure that users do not see reports without being logged in. If a login page is specified this way, you should ensure that ``InitializeReporting()`` is called again after the login process to ensure the user is properly authenticated. 

```c#
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
        AdHocSettings.RequireLogin = true;
}
```

###Data Sources

The [[API|/API/AdHocSettings]] allows control over which data sources a user sees based on their [[credentials|/FAQ/How-user-credentials-are-applied]]. In the following example, members of the "Sales" role would see additional data sources that normal users would not. Any reports that utilize these data sources would only be visible to members of the sales role.

```c#
 
    AdHocSettings.VisibleDataSources = new string[] {"Products"};         
    if(IsInRole("Sales"))  
    {
        AdHocSettings.VisibleDataSources = new string[]
        {"Products", "Categories", "Orders"};   
    }
```

The method will need to be called from your login process with the following line.

```c#
global_asax.CustomAdHocConfig.InitializeReporting();
```

###User Driven Report Sharing

Once the login security is implemented, users can set the shared and read only status of a report. If a report is shared, other members of that tenant will be able to see it. If it is marked read-only, users will be able to load the report, but any modifications will need to be saved as a different report name. These limitations do not apply to users with admin rights enabled via CurrentUserIsAdmin.

![Share and read only](http://wiki.izenda.us/Integration/Share-and-Read_only.png)

**A screenshot of the Misc tab in the Report Designer showing the "Shared" & "Read Only" checkboxes that a user can select on a per report basis.**

###Custom Report Control

To apply additional constraints to which users see what reports, it is necessary to override the ListReports method. See Report Management for additional details.

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

The API allows control of deleting or modifying reports. Reports marked Read-Only can not be modified or deleted even if the settings below are enabled. 

```c#
	AdHocSettings.AllowOverwritingReports = true;           
	AdHocSettings.AllowDeletingReports = true;
```

###Altering Capabilities by Role and Tenant ID

The versatility of Izenda reports allows for all settings to be applied on a per-user basis. The only limit to the customization level of Izenda's settings is your relevant coding experience, since this does require basic knowledge of either VB.NET or C#. 
The following code applies properties like the connection string, where reports are stored and visibility of the modify button modify button based on the user.

```c#
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
		AdHocSettings.ShowModifyButton=true;    
		AdHocSettings.AllowDeletingReports=false;      
	}
}
```

###Field/Record Level Security

Many applications limit users to specific records based on their credentials. The HiddenFilters API Setting may be used to add hidden filters to reports which limit the results based on the user, their credentials and their tenant. In this example, anyone reporting on the AcmeWidgetSales view will be limited to data in their TerritoryID.

```c# 
public static void InitializeReporting()
{
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
	AdHocSettings.HiddenFilters["AccountID"] = AccountID;
		//Set the account tenancy
	if (!Izenda.AdHoc.AdHocSettings.CurrentUserIsAdmin)  
	{    
		//needs to return an array of strings!    
		string[] TerritoryID = GetCurrentUserTerritories(UserName);            
		//add the filters to the reports based on the tenancy of this user    
		AdHocSettings.HiddenFilters["TerritoryID"] = TerritoryID; 
			// or new string[] {"1","2","3","4"};
		
		AdHocSettings.ShowModifyButton=false; //set regular permissions
		AdHocSettings.AllowDeletingReports=false; 
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