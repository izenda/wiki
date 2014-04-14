#Customizing Izenda Settings

[[_TOC_]]

##Introduction: common code additions

Izenda Reports can be integrated with the navigation, security, and appearance of existing applications. This is done through the code-level API, which can be accessed and extended through the **AdHocConfig** and **AdHocSettings** classes. By default, the Izenda starter kit includes pre-built code templates, which can be found in Global.asax. Here you will find settings that set critical values like the connection string and license key as well as a custom **AdHocConfig** implementation that overrides common methods. Here is an example of what a common global.asax might look like. 

##Sample Global.asax file

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
        HttpContext.Current.Session["ReportingInitialized"] = true;
    }

    // Configure settings
    // Add custom global settings after setting the license key and connection string
    public override void ConfigureSettings() {
        //Add custom settings here
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
    public override void PostLogin() {
        // Call Izenda.AdHoc.AdHocSettngs.AdHocConfig.PostLogin() from your login
        // page after authentication is successful
        AdHocSettings.CurrentUserName = (string)HttpContext.Current.Session["UserName"]; //Assumes the authenticated username is stored in a session variable
        AdHocSettings.CurrentUserIsAdmin = (bool)HttpContext.Current.Session["IsAdmin"]; //Assumes the authenticated user's admin status is stored in a session variable
        AdHocSettings.ShowSettingsButton = AdHocSettings.CurrentUserIsAdmin;
        AdHocSettings.VisibleDataSources = GetUserDataSources();
    }
}
</script>
```

For more a more detailed code sample, click any of the headings.

  * InitializeReporting() **The license key must be first!** Then add the connection string and initialize your custom AdHocConfig.
  * ConfigureSettings() Add global settings here. Global settings will affect all users and any settings made here will override the settings.aspx page.
  * PostLogin() Add per-user code here, such as setting the username and other per-user settings.
  * PreExecuteReportSet() Add hidden filters and other code that needs to run before the report is displayed to the user.

##How do I add custom code?

To enable a custom configuration, we must put the key and connection string in the ``InitializeReporting()`` method, even if they have already been set on the **Settings.aspx** page. Otherwise, the Izenda Reports application will ignore the ``ConfigureSettings()`` method completely and only use the settings set in the **settings.aspx** page. To enable custom code: 

  * Navigate via the file system to the root directory of your Izenda Reports installation
  * Open your global.asax file in a text editor or your favorite IDE
  * Create the ``InitializeReporting()`` method as above
  * Your license key MUST be first. Add your license key to the ``InitializeReporting()`` method as shown in this example.
  * Add your connection string to the ``InitializeReporting()`` method as show in this example.
  * Call ``InitializeReporting()`` in the ``OnPreInit()`` method from your reporting web pages.

You may now add custom code to Izenda Reports.

##AdHocSettings and AdHocConfig: The Main Integration Objects

Izenda Reports is an ASP.NET application and utilizes an object model. There are two classes upon which an integrator should primarily focus. These classes contain many settings and methods that will help you integrate our application with yours.

  * **AdHocSettings**: the class that contains all of the settings for Izenda Reports. Using the Settings.aspx page will enable application-wide usage of these settings. However, they can be set on a per-user basis. Customization at the user level is fairly easy and simply involves assigning values to settings. For example:
    * ``AdHocSettings.ShowAdminButton=false;``
  * **AdHocConfig**: the class that enables you to call the methods and properties that you have altered from anywhere else in your code. For example, you could call the ``PostLogin()`` method on any page and it will use the singular method definition that contains your custom logic:
    * ``AdHocSettings.AdHocConfig.PostLogin();``

Both of these classes are customized by adding your code into the global.asax file, as shown above.

##Creating a custom AdHocConfig class using the Global.asax file

By putting code in the **global.asax** file, you are simply choosing to use the ``CustomAdHocConfig`` class, which will extend either database mode or file system mode. Unless you specifically override the above methods, they will retain their default behavior.

In general, most custom code will be placed in the **Global.asax** file. Custom code applies to one of the following contexts:

  * **Global:** Affect on the Izenda Reports application: This type of code applies to all users and all reports. This type of code should be contained in the ``ConfigureSettings()`` method in the global.asax file. [[Please see this example for details|/FAQ/ConfigureSettings]]. 
  * **Per User Basis/Per Role Basis/etc:** This type of code applies to different users in different ways. We recommend that this type of code be contained in the ``PostLogin()`` method. Note that this method needs to be called from your application's authentication process. [[Please see this example for details|/FAQ/PostLogin]].
  * **Per Report/Custom Processing of Reports:** Applied before execution of each report. Generally, this is used for applying hidden filters. This code needs to be placed in the ``PreExecuteReportSet()`` method. [[Please see this example for details|/FAQ/applying-hidden-filter-using-inner-query]].

##Calling Izenda Reports from your application

The ``CustomAdHocConfig`` class contains a variety of methods that can be overridden to your specifications. Initially, the two most important are global and per-user configuration settings.

  * Global configuration settings: use the ``ConfigureSettings()`` method in the **global.asax**. Code placed in here will override the **settings.aspx** settings.
  * Per-user settings: place your code in the ``PostLogin()`` method and invoke this method from your application by calling:
    * ``Izenda.AdHoc.AdHocSettings.AdHocConfig.PostLogin();``

##What if my global.asax is already integrated or I cannot use it?

In the case that you will not be using the **global.asax** file or that you are using a different **global.asax** than Izenda's, you will need to make sure that you set the license key before invoking any of the configuration methods or settings in Izenda Reports. You can set the license key at the start of the user's session.