#Code Samples

[[_TOC_]]

##Introduction

Here we will provide snippets of programming code in various languages applicable to Izenda Reports and Dashboards that will allow you to modify and enhance your reporting solution.

_**Note:** Some of the items below are listed more than once. This is because they apply to more than one area of Izenda Reports._

##Login Page

* [[Authentication Function|/Tutorials/CodeSamples/Login-Sample]]
* Controlling user logins and login customization

##Global Application

* Secure https on a load balancer
* [[How can I apply a hidden filter using an inner query|/FAQ/applying-hidden-filter-using-inner-query]]
* [[ProcessEqualsSelectList()|/FAQ/ProcessEqualsSelectList]]
* [[CustomizeChart()|/FAQ/CustomizeChart]]
* [[Introduction to the Global.asax file|/API/AdHocConfig]]
* [[InitializeReporting()|/FAQ/InitializeReporting]]
* [[Session_Start()|/FAQ/Session_Start]]
* [[Add Formatting to Grid or New Formats to Formats Dropdown|/FAQ/Questions/Add-Formatting-Options]]

##General

* Inherit filters in the subreport
* Storing Reports in Database and Fusion Driver
* Overriding Driver Methods
* Using constraints
* [[Custom Report Viewer Export Button|http://wiki.izenda.us/API/CodeSamples/ReportViewer/Custom-Export-Buttons]]
* Dymamically changing the database with url parameter
* Create Button to Switch Databases
* Secure https on a load balancer
* Control names change randomly when deployed from development to production
* Placement of custom code
* Turn off or Change the Background Gradient of the Trend Chart
* User Defined Function (UDF) in SQL 2000/2005
* Switching from File System to Database mode

##Security

* Basic security sample
* Support Active Directory/Windows Authentication
* Controlling access to tables and views
* Switching databases via code
* Using PreExecuteReportSet to control data level access
* Using query string, dynamically set connection string and authenticate against hash
* Using ListReports() to control report access
* Controlling access to fields
* Setting the user and administrator state

##Report List

* Writing your own Report Lists
* Turn off Report List Dropdown and Report List Button
* Hiding Report List Buttons
* Change or Remove Report Review Menu Buttons

##Report Designer

* Override/Changing Behavior for Popups
* Adding New Items to Time Period Dropdown List
* Create Custom Field Aliases
* Control names change randomly when deployed from development to production
* [[Report Designer Page Code Samples|/API/CodeSamples/ReportDesigner]]
* [[Add and Remove Report Designer Toolbar Buttons|http://wiki.izenda.us/API/CodeSamples/ReportDesigner#Toggling-toolbar-buttons]]

##Report Management

* SaveReportSet()
* DeleteReportSet()
* LoadReportSet()
* ListReports()

##Report Viewer

* Displaying Filter Names in the Report
* How to add/remove values to results dropdown
* Override/Changing Behavior for Popups
* Adding New Items to Time Period Dropdown List
* Code Sample for Export Button
* Creating Custom Export Buttons on the Report Viewer
* Report Viewer Page Code Samples

##SQL

* Join data sources with composite keys
* LEFT OUTER and FULL OUTER joins
* Different JOIN types and Filters
* Configure LEFT OUTER JOIN filters
* [[Add "Forms" column to the IzendaAdHocReports table manually|/FAQ/IzendaAdHocReports-table]]
* Create IzendaAdHocReports table manually
* Pulling Data From Analysis Services Cubes
* [[Combining Multiple Event Based Fields with UNION|http://wiki.izenda.us/FAQ/Questions/Combining-Fields-with-Union]]
* Organizing Dates by Week
* [[1 Million Record View|/API/CodeSamples/1 Million Record View]]

##Appearance

* [[Adding Custom Formats|/FAQ/Questions/Add-Formatting-Options]]
* [[Report List CSS Code Sample|/FAQ/Questions/Overriding-page-level-css]]

##[[API|/API/AdHocConfig]]

* [[Adding custom filters to the dashboards. MVC application|/FAQ/Questions/Adding-custom-filters-to-dashboards]]
* [[Adding custom filters to the dashboards|/FAQ/Questions/Adding-custom-filters-to-dashboards]]
* Reports and tenants
* How to dynamically change TimeZone in post-process
* Web Farms / Gardens / Clusters / Load Balancers / Clouds / Azure
* How to use Driver.AddForcedLeftJoin
* How Can I Archive Reports?
* Overriding AdHocConfig
* Secure https on a load balancer
* How can I add the system date and time into my report?
* How to post-process data
* Dynamically Creating Reports Via the API
* Applying Security for Owner of the Report Out of Scheduler
* Creating Custom Exporters
* Graphs are visible on development server (local) but not on production server (public)
* How do I hide the settings page button or aspx page from users?
* Run User/Role Related Code, Connection-String before Global Settings
* Passing Username/Password Credentials with Connection String when Login
* Logging the Loading Exception when "No Fields Selected" Occurs
* Dynamically Changing Data Sources
* Using Custom Time Period Setting
* Show How Many Records Returned to the Grid from SQL
* Override Equals Select Drop-Down Used in the "Filter" Tab & Report Viewer
* Hiding Read Only Check Box
* Reducing Server Trips in AdhocConfig Methods
* Getting the Report Name
* [[Changing the response server page ( rs.aspx ) for custom errors or redirects|http://www.izenda.com/Site/KB/CodeSamples/Code-Sample-for-Export-Button]]