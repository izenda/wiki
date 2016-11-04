##Announcements
[![] (/Home/2017UserConference.png)](https://www.izenda.com/embedded-bi-conference)

[Join us for our 2017 User Conference January 22-24, 2017 Atlanta, GA](https://www.izenda.com/embedded-bi-conference)

<br>

##Navigation
Welcome to the wiki for Izenda - the real-time data analysis tool that provides self-service BI to organizations. 

This wiki serves as the main source of documentation for development teams working with Izenda, but also includes resources for end-users around report creation. If you are unfamiliar with Izenda, we recommend starting with the Izenda website.

<br>

<table border="1" width="100%">
   <tr>
      <th width="33%">
         <a href="http://http://wiki.izenda.us/Guides/ReportDesign">
            Izenda Overview
         </a>
      </th>
      <th width="33%">
         <a href="http://http://wiki.izenda.us/Integration/Tutorials">
            Install/Maintenance 
         </a>
      </th>
      <th width="33%">
         <a href="http://http://wiki.izenda.us/Release Notes">
            Release Notes
         </a>
      </th>
   </tr>
   <tr>
      <td align="center">
         <a href="http://http://wiki.izenda.us/Guides/ReportDesign">
            <img src="/Home/Overview_Globe.png" alt="Overview Icon" style="width:128px;height:128px;">
         </a>
      </td>
      <td align="center">
         <a href="http://http://wiki.izenda.us/Integration/Tutorials">
            <img src="/Home/Install_Download.png" alt="Install Icon" style="width:128px;height:128px;">
         </a>
      </td>
      <td align="center">
         <a href="http://http://wiki.izenda.us/Release Notes">
         </a>  
      </td>
   </tr>
   <tr>
      <td align="center">
         Introduction to the Izenda product
      </td>
      <td align="center">
         Instructions on installing and updating Izenda
      </td>
      <td align="center">
         Review the changes with each new release
      </td>
   </tr>
</table>

<!-- Commented out Best Practices until we develop a page
[Izenda Overview](/Guides/ReportDesign) | [Install/<br>Maintenance](/Integration/Tutorials) | Best Practices
:--:|:---:|:---:
[![](/Home/Overview_Globe.png)](/Guides/ReportDesign)|[![](/Home/Install_Download.png)](/Integration/Tutorials)|[![](/Home/BestPractices_Trophy.png)]
Introduction to the Izenda product|Instructions on installing and updating Izenda|Recommended strategies from the Izenda team
-->

<br>

<table border="1" width="100%">
   <tr>
      <th width="33%">
         <a href="http://http://wiki.izenda.us/Guides/Developer-Links-and-Guides">
            Customization
         </a>
      </th>
      <th width="33%">
         <a href="http://http://wiki.izenda.us/API">
            Code Reference
         </a>
      </th>
      <th width="33%">
         <a href="http://http://wiki.izenda.us/FAQ/FAQ">
            FAQ
         </a>
      </th>
   </tr>
   <tr>
      <td align="center">
         <a href="http://http://wiki.izenda.us/Guides/Developer-Links-and-Guides">
            <img src="/Home/Customization_Wrench.png" alt="Customization Icon" style="width:128px;height:128px;">
         </a>
      </td>
      <td align="center">
         <a href="http://http://wiki.izenda.us/API">
            <img src="/Home/CodeRef_Terminal.png" alt="Code Reference Icon" style="width:128px;height:128px;">
         </a>
      </td>
      <td align="center">
         <a href="http://http://wiki.izenda.us/FAQ/FAQ">
	    <img src="/Home/FAQ_QuestionMark.png" alt="FAQ" style="width:128px;height:128px;">
         </a>  
      </td>
   </tr>
   <tr>
      <td align="center">
         Altering Izenda to meet your company's needs
      </td>
      <td align="center">
         Technical documentation on Izenda's features, methods, and variables
      </td>
      <td align="center">
         Frequently asked questions from developers and end users
      </td>
   </tr>
</table>

<br>


<!-- Commented out old home page. Holding on to ensure we don't need it

#Izenda Wiki

[[_TOC_]]

##Introduction

Izenda reports includes a flexible API that can be configured to integrate with your application. This guide covers most of the basic elements that are needed to apply branding and security to the majority of applications. Before beginning, make sure that Izenda Reports can properly connect to your database when setup as a stand-alone virtual directory. 

Please watch our ten minute integration video to see how to do a core integration with Visual Studio (redirects to Youtube):

[![Izenda Core Integration Video](/Home/izenda_intro_video.png)](https://www.youtube.com/watch?v=4E0npCxLi4o)

###Izenda Reports Quick Setup
To integrate Izenda into your own website, you will first need a development environment, such as Visual Studio. Once you have a development environment, you can get our website template from [[here|http://www.izenda.com/Site/DownloadComplete.aspx?msgId=0]]. Once you have followed the steps there, return here and find out more about how you can get started using Izenda Reports.

###[[Configuring Settings|Integration/Tutorials/Customizing-Izenda-Settings]]

The Izenda Reports API contains specific settings that alter the behavior of the tool on a per-user basis. Settings can be applied through the Settings.aspx page (please see important information on [[settings|http://wiki.izenda.us/Integration/Tutorials/Customizing-Izenda-Settings#The-Settings.aspx-page]] page - this is typically only used for trials and evaluations) or via a [[CustomAdHocConfig|http://wiki.izenda.us/Integration/Tutorials/Customizing-Izenda-Settings]] class. Your global.asax should contain a definition for this that inherits from either FileSystemAdHocConfig or DatabaseAdHocConfig. Examples of important settings include the [[license key|/API/CodeSamples/LicenseKey]], the [[connection string|/API/CodeSamples/SqlServerConnectionString]], and the [[user name|/API/CodeSamples/CurrentUserName]]. 

###[[Creating Views|Integration/Tutorials/Views]]

Some databases contain complex field names that may be confusing to users. In these situations, it may be necessary to create Views that simplify the data model for the user. Users can be limited to specific views using the [[AdHocSettings.VisibleDataSources|/API/CodeSamples/VisibleDataSources]] setting.

###Applying Branding

There are a few different ways to apply your branding, logo, or header controls to Izenda Reports. 

**Header Image** : The simplest way to apply your logo is to set the "Application Header Image Url" in the "CSS & Images" section of the Settings.aspx page. You can also do it in your global.asax by modifying the [[AdHocSettings.ApplicationHeaderImageUrl|/API/CodeSamples/ApplicationHeaderImageUrl]] setting. 

**Master Pages** : If you already have an ASP.NET master page, you can apply it to ReportDesigner.aspx, ReportList.aspx, and ReportViewer.aspx. Be careful not to apply a master page or theme to the rs.aspx page as that may interfere with the reporting operation. 

**IFRAMES or Frames** : The Izenda reports pages may be placed inside an IFRAME or FRAME. This would need to be done for ReportDesigner.aspx, ReportList.aspx, and ReportViewer.aspx. 

###[[Building Core Reports|/Guides/ReportDesign]]

The best way to deploy Izenda is to create a small set of base reports that users can then customize. Ideally initial reports should contain the most relevant data sources and fields. It may be beneficial to add summaries and charts to them as well. See the training section for details on how to create various types of reports. 

###[[Enforcing Security and User Limitations|Integration/Tutorials/Security]]

The Izenda Reports platform includes a robust and flexible security model which inherits rich security credentials from your application. This example covers how to apply security for most common scenarios by using the ``InitializeReporting()`` method to pass user credentials to the Izenda API. This method is normally found in the [[CustomAdHocConfig|/Integration/Tutorials/Customizing-Izenda-Settings]] class in the Global.asax file. 

####Assumptions

For demonstration purposes, we will be working with the following information:

* The user has already been authenticated with the application Izenda is embedded into
* The username is stored in a session variable called "UserName"
* The tenant ID is stored in a session variable called "TenantID"
* The user's role is stored in a session variable called "Role"
* The user's country name is stored in a session variable called "UserCountry"
* The database contains tables and views with a field named "ClientID"
* A method named GetUserName() exists in global.asax that accesses the session variable "UserName"
* A method named GetTenantID() exists in global.asax that accesses the session variable "TenantID"
* A method named GetUserRole() exists in global.asax that accesses the session variable "Role"
* A method named GetUserCountry() exists in global.asax that accesses the session variable "UserCountry"

####Limitations Enforced

  * The user is logged In
  * The user can only see records for their ClientID
  * The user can only see certain data sources and will not see reports that require unauthorized data sources
  * Non-admins will not be able to overwrite reports
  * Non-admins will not see the "Admin Reports" and "Sensitive Reports" categories in their report list 

###Basic Login Scenario

In this example, we will initialize some of the more common settings. This is done in the ``InitializeReporting()`` method of your ``CustomAdHocConfig`` class that we discussed earlier. You will have to call the ``InitializeReporting()`` method after your user has been authenticated.

``` c#
//Pass User Credentials
AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
AdHocSettings.CurrentUserName = GetUserName();
AdHocSettings.CurrentUserTenantId = GetTenantID();
AdHocSettings.CurrentUserIsAdmin = (GetUserRole() == "Admin");
AdHocSettings.CurrentUserRoles = new string[] {(string)HttpContext.Current.Session["Role"]};
AdHocSettings.VisibleDataSources = new string[]  { "Products", "Orders", "Customers" }; 
```

###Multi-Role Scenario

Now let's add some logic based on the user's role. In this example, we apply limitations based on whether or not the user is an administrator, report designer, or report viewer. However, your individual roles may vary based on your security model.
 
``` c#
Izenda.AdHoc.AdHocSettings.ShowSettingsButtonForNonAdmins = false; //Hides the button that redirects to the settings page for non-admins
if(AdHocSettings.CurrentUserIsAdmin)
{
	Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[] { "Purchasing.Vendor", "Products", "Orders", "Order Details", "Customers" };
}
else
{
    Izenda.AdHoc.AdHocSettings.HiddenFilters["ShipCountry"] = GetUserCountry(); //Hide data that the user isn't authorized to view
    Izenda.AdHoc.AdHocSettings.VisibleDataSources = new string[] { "Products", "Orders", "Customers" }; //non-admins only see certain data sources
    Izenda.AdHoc.AdHocSettings.OutputTypes["sql"].ShowInToolbar = false; //Hides the SQL output icon on the toolbar for non-admins
    if(new List<string>(AdHocSettings.CurrentUserRoles).Contains("ReportViewer")) {
        AdHocSettings.ShowDesignDashboardLink = false;
        AdHocSettings.ShowDesignLinks = false;
        AdHocSettings.ShowDesignLinkInReportViewer = false;
    }
    else if (new List<string>(AdHocSettings.CurrentUserRoles).Contains("ReportDesigner")) {
        AdHocSettings.ShowMiscTab = false;
    }
}
```
-->
