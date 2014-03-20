**Quick Start Guide**

[[_TOC_]]

#**Integration Quick Start Guide**



Izenda reports includes a flexible API that can be configured to integrate with your application. This guide covers most of the basic elements that are needed to apply branding and security to the majority of applications. Before beginning make sure that Izenda Reports can properly connect to your database when setup as a stand-alone virtual directory. 

####Configuring Settings





The Izenda Reports API contains specific settings that alter the behavior of the tool on a per-user basis. Settings can be applied through the Settings.aspx page or via a CustomAdHocConfig class which is normally found in the Global.asax file. Examples of important settings include the license key or the user name. 



####Creating Views



Some databases contain complex field names that may be confusing to users. In these situations it may be necessary to create reporting views that simplify the data model for the user. Users can be limited to specific views using the "Visible DataSources" setting. See the [[Views]] article for more details. 





####Applying Branding



There are a few different ways to apply your branding, logo or header controls to Izenda Reports. 



Header Image : The simplest way to apply your logo is to set the "Application Header Image Url" in the "CSS & Images" section of the configuration page or the ApplicationHeaderImageUrl setting. This can be done by navigating to Settings.aspx from a browser. 



Master Pages : If you already have an ASP.NET master page, you can apply it to ReportDesigner.aspx, ReportList.aspx, and ReportViewer.aspx. Be careful not to apply a master page or theme to the rs.aspx page as that may interfere with the reporting operation. 



IFRAMES or Frames : The Izenda reports pages may be placed inside an IFRAME or FRAME. This would need to be done for ReportDesigner.aspx, ReportList.aspx, and ReportViewer.aspx. 





####Building Core Reports



The best way to deploy Izenda is to create a small set of base reports that user can then customize. Ideally initial reports should contain the most relevant data sources and fields. It may be beneficial to add summaries and charts to them as well. See the training section for details on how to create various types of reports. 





####Enforcing Security and User Limitations



The Izenda Reports platform includes a robust and flexible security model which inherits rich security credentials from your application. This example covers how to apply security for most common scenarios by using the PostLogin() to pass user credentials to the Izenda API. This method is normally found in the CustomAdHocConfig class in the Global.asax file. 



####*Assumptions - These will vary based on your application*

  * The username is stored in a session variable called "UserName"
  * The users role is stored in a session variable called "Role" 

  * The database contains tables and views with a field named "ClientID"
  * Reports will be created and saved to a category called "Admin Reports" 



####*Limitations Enforced*

  * The user is logged In
  * The user can only see records for their ClientID
  * The user can only see certain data sources and will not see reports that require those data sources
  * Non-admins will not be able to overwrite reports
  * Non-admins will not see the "Admin Reports" and "Sensitive Reports" categories in their report list 



*Basic Login Security - Place in PostLogin() or InitializeReporting() method of CustomAdHocConfig which is normally found in Global.asax.*

``` c#
//Pass User Credentials
AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
AdHocSettings.CurrentUserName = GetUserName();
AdHocSettings.CurrentUserTenantId = GetTenantID();
AdHocSettings.CurrentUserIsAdmin = true; 
AdHocSettings.VisibleDataSources = new string[]  { "Products", "Orders", "Customers" }; 
```

*Multi-Role Scenario - Apply specific limitations to certain roles*
 
``` c#
string role = GetUserRoleFromApp()
if(role == "Admin")
{
	Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[] { "Purchasing.Vendor", "Products", "Orders", "Order Details", "Customers" };
}
else
{
	Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[] { "Products", "Orders", "Customers" };
	Izenda.AdHoc.AdHocSettings.CurrentUserIsAdmin = false;
	Izenda.AdHoc.AdHocSettings.ShowSettingsButton = false;
    Izenda.AdHoc.AdHocSettings.ShowSqlOutputIcon = false;
	Izenda.AdHoc.AdHocSettings.HiddenFilters["ShipCountry"] = GetUserCountry();
}
```

*The PostLogin() method needs to be called at the end of your authentication process after user credentials are added to the session.*

``` c#
// Call the Izenda PostLogin() from your login page after authentication is complete
Izenda.AdHoc.AdHocSettings.AdHocConfig.PostLogin(); 
```

*Once security is fully configured, add the following code to [ConfigureSettings()](http://wiki.izenda.us/Adding-Code) method to prevent users from navigating to reports without logging in first.*

``` c# 
// Require Login once security configured. 
AdHocSettings.RequireLogin = false; 
AdHocSettings.LoginUrl = "INSERT_YOUR_LOGIN_PAGE_HERE"; 
```

Continue to [[Security]]