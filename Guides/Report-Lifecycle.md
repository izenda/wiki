#Report Lifecycle

[[_TOC_]]

##About

The Izenda reports API has a various methods and properties that can be overridden to implement custom functionality that allows you to control reports, charts, and data at a granular level. Below you will find the order in which those methods are called and the context in which it is executed. You can find out more about our settings API by viewing the [[AdHocSettings|/API/AdHocSettings]] page.

##ReportList.aspx

The ReportList page is loaded by default when Izenda first starts up or is navigated to on the web. This can vary if a custom solution is implemented, but the basic flow of the page will remain the same. 

[[InitializeReporting|http://wiki.izenda.us/FAQ/InitializeReporting]]

The first call must be to InitializeReporting before other API calls are made. This sets the groundwork for all reporting operations.

[[ProcessDataset|http://wiki.izenda.us/FAQ/ProcessDataSet]]

ProcessDataSet is where the raw data for reports is available for manipulation, and will be called after initialization, but before any caching is performed.

GetReportListConfig (webServer)

GetReportListConfig is an ajax call launched by the report list that is necessary to be called before the report list can be initialized.

ReportListDataLite (webServer)

ReportListDataLite is an ajax call launched after the configuration is obtained by the report list and returns a JSON formatted object to the javascript callback specified.

[[FilteredListReportsDictionary|http://wiki.izenda.us/FAQ/FilteredListReports]]

FilteredListReportsDictionary is called upon requesting the report list data above and can be manipulated in global.asax.

[[ListReports|http://wiki.izenda.us/FAQ/ListReports]]

The ListReports method returns a broader range of reports and can also be manipulated in global.asax. This method performs differently depending on if you use DatabaseAdHocConfig or FileSystemAdHocConfig. This will iterate through each report and perform the following operations:

getreportnamebyid

This will simply return the report name based on the ID of the report. This will run for each report before any other steps below are run.

processdataset

ProcessDataSet is again called 

ClearCachedReportSet

The cache is cleared in preparation for the new set of reports.

preloadreportset

PreLoadReportSet allows you 
loadreportset
ReadXml
postloadreportset
caching occurs
