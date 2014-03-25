#Adding Code

[[_TOC_]]

###Introduction: common code additions

Izenda Reports can be integrated with the navigation, security, and appearance of existing applications. This is done through the code-level API, which can be accessed and extended through the **AdHocConfig** and **AdHocSettings** classes. By default, the Izenda starter kit includes pre-built code templates, which can be found in Global.asax. Here you will find settings that set critical values like the connection string and license key as well as a custom **AdHocConfig** implementation that overrides common methods. Here is an example of what a common global.asax might look like. 

###Sample Global.asax file

``` c#
<%@ Application Language="C#" %>
<%@ Import Namespace="Izenda.AdHoc" %>
<script runat="server">
    
void Session_Start(object sender, EventArgs e) 
{
	// set license key and connection string
	Izenda.AdHoc.AdHocSettings.LicenseKey = "IzendaReports|Corporate|XXXXXXXXXXXX";
	Izenda.AdHoc.AdHocSettings.SqlServerConnectionString = "server=localhost;Database=Database1;Trusted_Connection=True";
	//initialize a new custom configuration 
	Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
}

[Serializable]
public class CustomAdHocConfig : Izenda.AdHoc.FileSystemAdHocConfig
{
	public override void ConfigureSettings()
	{
	//Add custom global settings
	}

	public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
	{
	// Add hidden filters before the report is displayed     
	}
	
	public override void PostLogin()
	{
		// Call Izenda.AdHoc.AdHocSettngs.AdHocConfig.PostLogin() from your login
		// page after authentication is successful
               
		if (userName == joe)
		{
			AdHocSettings.CurrentUserName = userName;
			AdHocSettings.CurrentUserIsAdmin = false;
			AdHocSettings.ShowSettingsButton = false;
		}
		else
		{
			AdHocSettings.CurrentUserIsAdmin = true; 
		}
	}
}
</script>
```

For more a more detailed code sample, click any of the headings.

  * Session_Start() **The license key must be first!** Then add the connection string and initialize your custom AdHocConfig.
  * ConfigureSettings() Add global settings here. Global settings will affect all users and any settings made here will override the settings.aspx page.
  * PostLogin() Add per-user code here, such as setting the username and other per-user settings.
  * PreExecuteReportSet() Add hidden filters and other code which needs to run before the report is displayed to the user.

###How do I add custom code?

To enable a custom configuration, we must put the key and connection string in the Session_Start method, even though they have already been set in the Settings.aspx page. Otherwise, the Izenda Reports application will ignore the Configure_Settings method completely and only use the settings set in the settings.aspx page. To enable custom code: 

  * Navigate via the file system to the root directory of your Izenda Reports installation
  * Open your global.asax file in a text editor or your favorite IDE
  * Find the Session_Start() method
  * Your license key MUST be first. Add your license key to the Session_Start() method as show in this example.
  * Add your connection string to the Session_Start() method as show in this example.

You may now add custom code to Izenda Reports.

**AdHocSettings and AdHocConfig: The Main Integration Objects**

Izenda Reports is an ASP.NET application and utilizes an object model. There are two classes upon which an integrator should primarily focus. These classes contain many settings and methods that will help you integrate our application with yours.

  * AdHocSettings: the class which contains all of the settings for Izenda Reports. The settings page references these settings global, however, as explained, they can be set on a per-user basis. At this level, customization is fairly easy and involves assigning values to a settings. For example:
    * AdHocSettings.ShowAdminButton=false;
  * AdHocConfig: the class which enables you to call the methods and properties which you have altered from anywhere else in your code. For example, to invoke a the method which contains the logic for after a user has logged in you would call, where the PostLogin() method contains the logic:
    * AdHocSettings.AdHocConfig.PostLogin();

Both of these classes are customized by adding your code into the global.asax file, as shown above.

**Creating a custom AdHocConfig class using the Global.asax file**

By putting code in the global.asax file, you are simply choosing to use the CustomAdHocConfig class, which will extend either database mode or file system mode. Unless you specifically override the methods, they will retain their default behavior.

In general, most custom code will be placed in the Global.asax file. [[Please see this code sample for details]]. Custom code applies to one of the following contexts:

  * Global - Affect on the Izenda Reports application: This type of code applies to all users and all reports. This type of code should be contained in the ConfigureSettings() method in the global.asax file. [[Please see this example for details]]. 
  * Per User Basis/Per Role Basis/etc - This type of code applies to different users in different ways. We recommend that this type of code should be contained in the PostLogin() method. Note that this method needs to be called from your application's authentication process. [[Please see this example for details]].
  * Per Report/Custom Processing of Reports - Applied before execution of each report. Generally, this is used for applying hidden filters. This code needs to be placed in the PreExecuteReportSet() method. [[Please see this example for details]].

**Calling Izenda Reports from your application**

The CustomAdHocConfig class contains a variety of methods that can be overridden to your specifications. Initially, the two most important are global and per-user configuration settings.

  * Global configuration settings: use the ConfigureSettings() method in the global.asax. Code placed in here will override the settings.aspx settings.
  * Per-user settings: place your code in the PostLogin() method and invoke this method from your application by calling:
    * Izenda.AdHoc.AdHocSettings.AdHocConfig.PostLogin();

**What if my global.asax is already integrated or I cannot use it?**

In the case that you will not be using the global.asax file or that you are using a different global.asax than Izenda's, you will need to make sure that you set the license key before invoking any of the configuration methods or settings in Izenda Reports. You can set the license key with:

  * Izenda.AdHoc.AdHocSettings.LicenseKey = \[key here\];

We recommend setting this at the start of the user's session.



**Izenda Reports API **

Izenda also provides customers with access to its API Source code and to various pages with the purchase of our product. To access our API and browse through it, click access the Izenda Reports API. 