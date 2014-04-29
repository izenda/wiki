#Customizing Izenda Settings

[[_TOC_]]

##Introduction: common code additions

Izenda Reports can be integrated with the navigation, security, and appearance of existing applications. This is done through the code-level API, which can be accessed and extended through the **[[AdHocConfig|/API/CodeSamples/AdHocConfig]]** and **[[AdHocSettings|/API/CodeSamples/AdHocSettings]]** classes. By default, the Izenda starter kit includes pre-built code templates, which can be found in Global.asax.

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
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
        //Creates a connection to Microsoft SQL Server
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
        Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
        //Handle user specific logic
        AdHocSettings.CurrentUserName = (string)HttpContext.Current.Session["UserName"]; //Assumes the authenticated username is stored in a session variable
        AdHocSettings.CurrentUserIsAdmin = (bool)HttpContext.Current.Session["IsAdmin"]; //Assumes the authenticated user's admin status is stored in a session variable
        AdHocSettings.ShowSettingsButton = AdHocSettings.CurrentUserIsAdmin;
        AdHocSettings.VisibleDataSources = GetUserDataSources();
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

  * InitializeReporting() **The license key must be first!** Then add the connection string and initialize your custom AdHocConfig.
  * [[PreExecuteReportSet()|/FAQ/PreExecuteReportSet]] Add hidden filters and other code that needs to run before the report is displayed to the user.
  * [[ProcessDataSet()|/FAQ/ProcessDataSet]] You can manipulate the report how you please in this method. This is useful for substituting values in your reports.

##How do I add custom code?

To enable a custom configuration, we must put the key and connection string in the ``InitializeReporting()`` method, even if they have already been set on the **Settings.aspx** page. Otherwise, there could be complications when initializing. When adding custom code, we recommend disabling **Settings.aspx** and **Izenda.config** altogether to prevent any conflicts from occurring. Here is the process flow for enabling custom code: 

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

In the case that you will not be using the **global.asax** file or that you are using a different **global.asax** than Izenda's, you can set the license key at the start of the user's session to obtain the same result. You will need to make sure that you set the license key before invoking any of the configuration methods or settings in Izenda Reports.