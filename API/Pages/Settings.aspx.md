#Settings.aspx

[[_TOC_]]

##About
**THE SETTINGS PAGE AND IZENDA.CONFIG SHOULD BE ONLY USED IN TRIALS & EVALUATIONS NOT IN PRODUCTION DEPLOYMENTS.**

Izenda Reports allows basic configuration through its settings page. In this page you will find many options that can be configured with a simple button click. Using your browser, navigate to http://yourwebsiteroot/ApplicationName/settings.aspx to access this page. This page also includes diagnostic tests that you can use to ensure all the processes function before you begin using Izenda Reports. You can also get a full list of settings, their functions, and their default values by reviewing the [[AdHocSettings|http://wiki.izenda.us/API/AdHocSettings]] class. Generally, this page will be hidden from average users.

_**Note:** The primary purpose of this page is to be a diagnostic page and a demonstration for common settings on our demo site. This way people can see what effect certain settings have on the application before committing to writing the InitializeReporting method._

**THE SETTINGS PAGE AND IZENDA.CONFIG SHOULD BE ONLY USED IN TRIALS & EVALUATIONS NOT IN PRODUCTION DEPLOYMENTS.**

![The Settings Page](http://wiki.izenda.us/Integration/Tutorials/connect-to-the-database/settings_aspx.png)

##Key & DB Connection tab

Here you can set the license key, which DB server type you are using, the connection string, and the visible data sources.

* **License Key** - If you have already set the license key, this field will display ************** instead of the actual key for security reasons. It will still function properly unless you copy and paste the hiding marks back into the field. You can click the "test" button below it to ensure it's still a valid key. If you want a trial key, you can contact [sales@izenda.com](mailto:sales@izenda.com).
* **DB Server Type** - You can select the type of database server you are using with this dropdown. If you don't see the database type your application uses in the dropdown, you can contact [Services@izenda.com](mailto:services@izenda.com) to request a custom driver.
* **Connection String** - If you already have your connection string set, this field will display ************** like with the license key. If you don't have a connection string, there is the "Generate" button that will provide a small form that you can use to create one. The "Test" button will allow you to see if the connection string is valid before using it. 
* **Visible Tables and Views** - Here is where you can set the visible tables and views that are to be included in your reports. The default is all tables and views. If you already have [[VisibleDataSources|/API/CodeSamples/VisibleDataSources]] set in your code, you will only see those data sources listed.

##Status & Utils tab

The status & utils tab provides various diagnostics for your application. The sections are listed as follows:

* **Section 1:** Displays pass or Fail metrics testing whether core features of Izenda Reports function properly. 
* **Section 2:** Displays information about your web server, database system, browser, etc.
* **Section 3:** Displays a list of settings that have been modified from their original values
* **Section 4:** Displays links that can help with error reporting and switching between [[Database mode|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]] and [[FileSystem mode|http://wiki.izenda.us/FAQ/Storing-Reports#File-System-Mode]]
  * A link to send your system information to Izenda for error reporting
  * A link to easily port your reports from the file system to the database
  * A link to easily port your reports from the database to the file system
* **Section 5:** Displays information about your database including any hidden tables or views

##Features tab

This tab displays various settings that apply to optional features throughout Izenda. You can turn the features on/off with checkboxes or modify settings for these features via text boxes. You can also view what the setting does by clicking "Details", revert the setting back to its default value, or get a code sample to place in your [[InitializeReporting()|http://wiki.izenda.us/FAQ/InitializeReporting]] method.

##Viewer tab

This tab displays settings that apply to the Report Viewer. As of version 6.7, most of the report viewer specific settings have become obsolete.

##Appearance (Images & CSS) tab

This tab allows you to change the look and feel of the application. You can see more about the URL items [[here|http://wiki.izenda.us/FAQ/Questions/Overriding-page-level-css]].

##Email & Scheduling tab

This tab allows you to configure the Izenda Scheduler settings. You must [[configure the scheduler|http://wiki.izenda.us/FAQ/Questions/How-do-I-use-the-Izenda-Reports-report-email-scheduler]] prior to being able to set these settings.

##Performance tab

This tab allows you to change settings that could affect the performance of the reporting application. Such settings affect the amount of data returned by a single query, command timeouts, and export options.

##Security tab

This tab allows you to configure settings related to the security of the application. Izenda will inherit your security model automatically, but if you need certain restrictions here or want to change the behavior of certain security features, you can do it here.

##Toolbar tab

This tab directly affects the buttons on the [[Report Designer's toolbar|http://wiki.izenda.us/API/CodeSamples/ReportDesigner]]. You can click the link for a look at how to do this programatically too.

##Tabs tab

This tab controls which tabs will be displayed on the Report Designer. You can get a full look at the various tabs on the Report Designer by [[following this link|http://wiki.izenda.us/Guides/ReportDesign]].

##Other tab

This tab allows you to control miscellaneous settings that are not related to the areas described above and range from very small UI differences to paths for resources.

##Settings Toolbar

The settings toolbar is the grey banner directly above the tabs and has some helpful items on it as well.

* **New Report:** Takes you to the Report Designer page. This item is available even if [[ShowDesignLinks|/API/CodeSamples/ShowDesignLinks]] is turned off.
* **Report List:** Takes you to the Report List page. This is the default page for Izenda to direct to.
* **Save to Izenda.config:** Writes your current configuration to the file "Izenda.config" on your server. This is an XML file that contains all of your settings.
* **Update Schema:** Forces an update of the database schema to Izenda Reports. If changes are made to the database and you do not want to restart the application, you can use this button to do so.
* **Generate C♯ Code:** This will output a list of all modified settings in a format that is easy to copy and paste into your [[InitializeReporting()|http://wiki.izenda.us/FAQ/InitializeReporting]] method.
* **Generate VB.NET Code:** Acts just like the above button, except that it will output a list of those settings formatted for VB.NET.
* **Preview:** Launches another browser window where you can view changes to your settings made with Izenda.config. This will require clearing your browser cache or the old values will persist. Code entered via InitializeReporting cannot be re-evaluated until the application is re-built.

If you have questions or concerns about the features on this page, you can contact [Services@izenda.com](mailto:services@izenda.com)