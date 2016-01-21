#Customizing Izenda Settings

[[_TOC_]]

##Introduction: common code additions

Izenda Reports can be integrated with the navigation, security, and appearance of existing applications. This is done through the code-level API, which can be accessed and extended through the **[[AdHocConfig|/API/AdHocConfig]]** and **[[AdHocSettings|/API/AdHocSettings]]** classes. By default, the Izenda starter kit includes pre-built code templates, which can be found in Global.asax.

##The Global.asax file

The Global.asax file, also known as the ASP.NET application file, is a file that contains code for responding to application-level and session-level events raised by ASP.NET or by HTTP modules. At run time, Global.asax is parsed and compiled.

The global.asax provides the ability to customize the following features and more:

* listing of reports
* loading of reports
* saving of reports
* deleting of reports
* user security on a per user/per role basis
* hidden filters for reports
* UI appearance
* report-level and datasource-level application logic

Here is an example of what a common global.asax might look like. 

###Sample Global.asax file

``` c#
<%@ Application Language="C#" %>
<%@ Import Namespace="Izenda.AdHoc" %>
<script runat="server">

[Serializable]
public class CustomAdHocConfig : Izenda.AdHoc.FileSystemAdHocConfig
{
    //the method to be called by each of your reporting web pages in the OnPreInit() method. This will instantiate Izenda reports throughout your reporting application.
    public static void InitializeReporting() {
      //Check to see if we've already initialized.
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      bool isMultiTenant = false;
      string role = GetUserRole();
      AdHocSettings.CurrentUserName = (string)HttpContext.Current.Session["UserName"]; //Assumes the authenticated username is stored in a session variable
      AdHocSettings.CurrentUserIsAdmin = (bool)HttpContext.Current.Session["IsAdmin"]; //Assumes the authenticated user's admin status is stored in a session variable
      AdHocSettings.ShowSettingsButton = AdHocSettings.CurrentUserIsAdmin;
      AdHocSettings.ShowModifyButton = AdHocSettings.CurrentUserIsAdmin;
      Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();

      if (!isMultiTenant) {
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
        //Creates a connection to Microsoft SQL Server
        AdHocSettings.SqlServerConnectionString = GetConnectionString();
        //Handle user specific logic
        AdHocSettings.CurrentUserIsAdmin = (bool)HttpContext.Current.Session
        AdHocSettings.VisibleDataSources = GetUserDataSources();
      }
      else {
        string company = GetUserCompany();
        //Set connection string per-tenant
        AdHocSettings.SqlServerConnectionString = GetConnectionStringByCompany(company);
        //Set the stored reports file folder path per-tenant
        AdHocSettings.ReportsPath = string.Format("\\{0}\\{1}", company, GetUserDepartment(AdHocSettings.CurrentUserName));
        //Set table and view access
        AdHocSettings.VisibleDataSources = GetTables(role); //get the allowed datasources based on role
        //Set all other settings
        if  (company=="AcmeWidget")
        {
          AdHocSettings.Formats["Currency"] = "{0:#,###.##}";
          if (GetUserRole()=="PowerUser") {
            AdHocSettings.ShowModifyButton=true;
            AdHocSettings.AllowDeletingReports=false; 
          }
       }
       HttpContext.Current.Session["ReportingInitialized"] = true;
    }

    // Dynamically modify the report before execution. 
    public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet) {
        // Add custom logic to run before the report is displayed     
    }
	
    // Dynamically modify the results after they come back 
    // from the database and before they are rendered
    public override void ProcessDataSet(System.Data.DataSet ds, string reportPart) {
        // Add custom logic to modify specific areas of the report
    }
}
</script>
```

For more a more detailed code sample, click any of the headings.

  * [[InitializeReporting()|/FAQ/InitializeReporting]] **The license key must be first!** Then add the connection string and initialize your custom AdHocConfig.
  * [[PreExecuteReportSet()|/FAQ/PreExecuteReportSet]] Add hidden filters and other code that needs to run before the report is displayed to the user.
  * [[ProcessDataSet()|/FAQ/ProcessDataSet]] You can manipulate the report how you please in this method. This is useful for substituting values in your reports.

##How do I add custom code?

To enable a custom configuration, we must put the key and connection string in the ``InitializeReporting()`` method. **If settings have already been set on the Settings.aspx page, they should be removed and set via code in the global.asax- otherwise, there could be complications when initializing. When adding custom code for a production integration, we recommend disabling Settings.aspx and Izenda.config altogether to prevent any conflicts from occurring.** Here is the process flow for enabling custom code: 

  * Navigate via the file system to the root directory of your Izenda Reports installation
  * Open your global.asax file in a text editor or your favorite IDE
  * Create the ``InitializeReporting()`` method as above
  * Your license key MUST be first. Add your license key to the ``InitializeReporting()`` method as shown in this example.
  * Add your connection string to the ``InitializeReporting()`` method as show in this example.
  * Call ``InitializeReporting()`` in the ``OnPreInit()`` method from your reporting web pages.

You may now add custom code to Izenda Reports.

##AdHocSettings and AdHocConfig: The Main Integration Objects

Izenda Reports is an ASP.NET application and utilizes an object model. There are two classes upon which an integrator should primarily focus. These classes contain many settings and methods that will help you integrate our application with yours.

* **AdHocSettings**: the class that contains all of the settings for Izenda Reports. A complete list of settings can be found [[here|API/AdHocSettings]]. There are a few different ways to scope settings:
    * **Global Settings:** These generally do not require specific logic and can be set to constant values. You may also use the Settings.aspx page in our downloadable demo to create a global config file.
    * **Per-User Settings:** You can use specific logic in the ``InitializeReporting`` method to give users roles, hide or show buttons, and much more. However, this does require some experience with C♯ or VB.NET.
* **AdHocConfig**: the class that enables you to call the methods and properties that you have altered from anywhere else in your code. Generally, your global.asax will inherit either ``DataBaseAdHocConfig`` or ``FileSystemAdHocConfig``.

Both of these classes are customized by adding your code into the global.asax file, as shown above.

##Creating a custom AdHocConfig class using the Global.asax file

By putting code in the **global.asax** file, you are simply choosing to use the ``CustomAdHocConfig`` class, which will extend either database mode or file system mode. Unless you specifically override the above methods, they will retain their default behavior.

In general, most custom code will be placed in the **Global.asax** file. Custom code applies to one of the following contexts:

  * **Global:** This type of code applies to all users and all reports. Generally, these will be the first settings initialized in your application and will not require custom logic as they apply the same everywhere in your application. 
  * **Per User Basis/Per Role Basis/etc:** This type of code applies to different users in different ways. You can use your own logic to implement settings at this level. Core settings of this nature that Izenda offers include [[CurrentUserName|/API/CodeSamples/CurrentUserName]], [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]], [[CurrentUserRoles|/API/CodeSamples/CurrentUserRoles]], and [[CurrentUserIsAdmin|/API/CodeSamples/CurrentUserIsAdmin]].
  * **Per Report/Custom Processing of Reports:** Applied before execution of each report. Generally, this is used for applying hidden filters. This code needs to be placed in the [[PreExecuteReportSet()|/FAQ/PreExecuteReportSet]] method. [[Please see this example for details|/FAQ/applying-hidden-filter-using-inner-query]].

##What if my global.asax is already integrated or I cannot use it?

In the case that you will not be using the **global.asax** file or that you are using a different **global.asax** than Izenda's, you can set the license key at the start of the user's session to obtain the same result. You will need to make sure that you set the license key before invoking any of the configuration methods or settings in Izenda Reports. You can also use [[this guide|http://wiki.izenda.us/Guides/Integrating-Izenda]] to decide how to integrate Izenda into your existing application. _**Note:** This requires knowledge of asp.net and C# at the least._

##Web Farms/Gardens/Clusters/Load Balancers/Clouds/Azure

You can use the following steps to allow proper operation of Izenda Reports on distributed cloud computing systems:

1. Call the ``InitializeReporting()`` method from the OnPreInit() method of all pages that utilize the Izenda API. by default, the demo site already uses this configuration.
2. Enable shared state management by setting the mode attribute of sessionstate to "sqlserver" or "stateserver" in the web.config file. Following is an example web.config showing where to place this option.

```xml
<configuration>
  <system.web>
    <sessionState mode="StateServer"
      stateConnectionString="tcpip=SampleStateServer:42424"
      cookieless="false"
      timeout="20"/>
  </system.web>
</configuration>
```

_**Note:** Due to the heavy use of session state Izenda relies on for caching images, javascript, and CSS, performance may suffer while using SQL as your state server. We recommend using a third party session state tool such as [[AppFabric|http://msdn.microsoft.com/en-us/library/ee677312(v=azure.10).aspx]] to handle your sessions on a farm. If that isn't an option, you can also use a [[memory optimized session state provider|http://blogs.technet.com/b/dataplatforminsider/archive/2014/07/10/new-asp-net-session-state-provider-for-sql-server-in-memory-oltp.aspx]] for your SQL session state server cluster._

##The Settings.aspx page

Izenda Reports also allows most common settings to be turned on or off through its settings page. In this page you will find that settings have been grouped into categories depending on the function they server. This page can also provide helpful diagnostic data about your application. **It is an Izenda best practice to only use the settings.aspx page and izenda.config for trials and evaluations, and not in production.**