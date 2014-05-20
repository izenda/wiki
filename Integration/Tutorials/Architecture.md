#Architecture

[[_TOC_]]

##Introduction

Izenda Reports is a web application that runs on Microsoft's Internet Information Server (IIS). The application is built on Microsoft's ASP.NET platform, and code level customizations can be made in VB.NET or C#. Users connect to our application using a browser, then are served pages and can build reports using the pages. Ultimately, the reports that they build are saved on a server's file system or in a database.

Izenda Reports provides architecture centered on customization. The application is built using ASP.NET controls. Building the application using controls allows for a highly extensible object oriented architecture. There are four main components that comprise the user interface (UI). These components are pages in the application with which the user interacts.

A general description is given here. For more detail, please click on the page name for more detail.

##Database and Application Performance

Izenda Reports was designed with end-user performance in mind. We are 100% AJAX, desktop applications seem slow in comparison.

For optimal performance of your views, and database we suggest indexing any field that maybe joined in views, sorted, or filtered by. For example in SQL this can be done using the index tuning wizard.

##Report List Page (ReportList.aspx)

Report List (ReportList.aspx, example here) is first page the user typically interacts with unless given a link to a specific report. This page displays the list of reports. By default, it displays uncategorized reports first (in alphabetical order) and then displays an alphabetized list of the reports by category. If allowed, users may:

  * Click the report to view the report in the report viewer page
  * Click the modify icon to load the report in the report designer
  * Click the delete icon to delete the report

##Report Viewer Page (ReportViewer.aspx)

Report Viewer (ReportViewer.aspx, example: here) is used to view a report that has already been designed. Modifications to the report can be made without permanently altering or overwriting the report in any way. If permitted, users may:

  * Add fields to the report
  * Filter the report using fields
  * Export the report
  * Navigate to the report list page
  * Load the report into the report designer page

##Report Designer Page (ReportDesigner.aspx)

Report Designer (ReportDesigner.aspx, example: here) is used to create and modify reports. The page structure is a tabbed menu at the top, followed by a toolbar of icons, and then the page content. Using this page, users will be able to:

  * Choose data sources for a report
  * Choose fields that are shown in a report grid and perform simple operations on the fields
  * Create filters to filter report data
  * Create a summary grid using fields and perform simple operations on the fields
  * Create a chart to display data
  * Create gauges to display data
  * Schedule a report for emailing
  * Change visual elements of the report, titles, descriptions, colors, etc.
  * Preview the report after selecting all of the above

##Settings Page (Settings.aspx)

Settings Page (Settings.aspx, example here): the user, typically an admin, can set the most important settings that affect the UI and the application experience with this page. The changes made in the page primarily affect the Report List, Report Viewer, and the Report Designer.

##The Global.asax file and why it is important

The Global.asax file, also known as the ASP.NET application file, is a file that contains code for responding to application-level and session-level events raised by ASP.NET or by HTTP modules. At run time, Global.asax is parsed and compiled.

The Global.asax is not a page in the application, it is not served, and it is stored in the root directory of the Izenda Reports application. It contains methods which allow customizing appearance of reports, loading, saving, and displaying reports.

Please see the Global.asax section for a full discussion.

##Web Forms

In order to understand how the pages described above fit into our application and how to modify them, we provide a quick overview of ASP.NET web forms and controls.

Web forms are UI elements which give our web application its look and feel. Web forms contain the ASP.NET controls which our application uses to interact with the user and provide properties, methods, and events for the controls that are placed onto them. Ultimately, the UI elements are rendered into HTML.

Web forms are made up of two components: the visual portion (the ASPX file such as the ReportList.aspx page), and the code behind the form, which resides in a separate class file (ReportList.aspx.cs). 

##Controls

ASP.NET controls are components that are created and run on the server and encapsulate the user-interface and other related functionality. They are used in ASP.NET pages (ASPX) and in ASP.NET code-behind classes ( ASPX.CS or .CS ).

After performing whatever operation they are designed to do, the control renders the appropriate HTML and sends that HTML into the output stream. For example, a DropDownList control will allow you to bind to a data source, yet the output that is rendered is standard ``` <SELECT> ``` and ``` <OPTION> ``` tags when sent to a browser.

However, the same DropDownList control might render WML if the target is a portable phone. ASP.NET controls do not necessarily map to any one markup language, but have the flexibility to target the appropriate markup language. 

##How Izenda Reports Uses Web Forms and Controls


Each page in our application is a web form which contains the appropriate controls. As an example, let's examine the Report List ASPX page. It can be found in the root Izenda Reports application directory (ReportList.aspx). The page contains an include directive so that the code behind (ReportList.aspx.cs) is used if modified. It contains the standard html tags, then it includes a header user control which can be customized to our application's specifications. The server controls are placed between the ``` <FORM> </FORM> ``` tags.

When overriding the default behavior of pages, you may include other user or server controls by editing the code behind for the pages or by recompiling Izenda Reports into your web application.

##Izenda Reports Customization via Code

By default, Izenda Reports allows many different settings customizations. However, when integrating, you may have to write custom code. Izenda Reports is an object oriented ASP.NET web application, and so it uses the concept of "classes" for maximum flexibility and organization.

By default, it uses an AdHocConfig class. When you add code for customization (for example see [[Adding Code]]) you are adding code to a class called CustomAdHocConfig which extends either the Database or File System storage mode base class. The definition for the CustomAdHocConfig class is found in the global.asax file, which is also where custom code is added. All of the methods and properties of the current class are exposed through the Izenda.AdHoc.AdHocSettings.AdHocConfig setting.

Our structure enables you to access all of the relevant methods and properties without having to understand our object model.