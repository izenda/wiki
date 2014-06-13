#Report Lifecycle

[[_TOC_]]

##About

The Izenda reports API has a various methods and properties that can be overridden to implement custom functionality that allows you to control reports, charts, and data at a granular level. Below you will find the order in which those methods are called and the context in which it is executed. You can find out more about our settings API by viewing the [[AdHocSettings|/API/AdHocSettings]] page.

##ReportList.aspx

This outlines the call structure when accessing the report list page as it pertains to reports and API hooks.

1. **[[InitializeReporting|http://wiki.izenda.us/FAQ/InitializeReporting]]:** The first call must be to InitializeReporting before other API calls are made. This sets the groundwork for all reporting operations. It is recommended that all pages using Izenda reports call this method in the code-behind.
2. **[[GetReportListConfig|/API/CodeSamples/Javascript/GetReportListConfig]] (webServer):** GetReportListConfig is an ajax call launched by the report list that is necessary to be called before the report list can be initialized.
3. **[[ReportListDataLite|/API/CodeSamples/Javascript/ReportListDataLite]] (webServer):** ReportListDataLite is an ajax call launched after the configuration is obtained by the report list and returns a JSON formatted object to the javascript callback specified.
4. **[[FilteredListReportsDictionary|http://wiki.izenda.us/FAQ/FilteredListReports]]:** FilteredListReportsDictionary is called upon requesting the report list data above and can be manipulated in global.asax. This will also get the database schema from the cache or cache it if it's not cached.
5. **[[ListReports|http://wiki.izenda.us/FAQ/ListReports]]:** The ListReports method returns a broader range of reports and can also be manipulated in global.asax. This method performs differently depending on if you use DatabaseAdHocConfig or FileSystemAdHocConfig. This will iterate through each report and perform the following operations:
  1. **[[GetReportNameById|/FAQ/GetReportNameById]]:** This will simply return the report name based on the ID of the report. This will run for each report before any other steps below are run.
  2. **[[ClearCachedReportSet|/FAQ/ClearCachedReportSet]]:** The cache is cleared in preparation for the new set of reports.
  3. **[[PreLoadReportSet|/FAQ/PreLoadReportSet]]:** Here, PreLoadReportSet 
  4. **[[LoadReportSet|http://wiki.izenda.us/FAQ/LoadReportSet]]:** It is at this point that XML definitions are read for each report and the ReportInfo is returned. If you want to perform your own processing of the report. Note that your customizations will only be kept if you perform them after ``base.LoadReportSet`` is called (if it's called).
  5. **[[PostLoadReportSet|/FAQ/PostLoadReportSet]]:** Alternately, you can perform any post-processing you wish to do in the PostLoadReportSet method. These three methods will always be called when fetching report definitions.
  6. **Caching:** Caching occurs at this point (turned on by default) so the definitions will not have to be loaded again.
  7. **Thumbnails:** The cached reports are accessed and thumbnails are loaded if [[GenerateThumbnails|/API/CodeSamples/GenerateThumbnails]] is on.

##ReportDesigner

This outlines the call structure when accessing the report designer page as it pertains to reports and API hooks.

1. **[[InitializeReporting|http://wiki.izenda.us/FAQ/InitializeReporting]]:** This should be called via the OnPreInit function in the page's code behind file, like all Izenda reports pages (except rs.aspx).
2. **[[FilteredListReportsDictionary|/FAQ/FilteredListReportsDictionary]]:** This will perform the same operation as in the report list.
3. **[[ListReports|]]:** If this is the first call to ListReports, or the cache was recently invalidated, this will obtain the reports as before. Otherwise it will skip the individual processing of reports in favor of the cache.
4. **[[GetReportNameById|/FAQ/GetReportNameById]]:** Called like above.
5. **[[GetOperatorList|/FAQ/GetOperatorList]]:** The ReportDesigner now gets a list of operators available for the SqlType context. If customizations to the operator list are required, it can be done here.

##Report Viewer

This outlines the call structure when accessing the report viewer page as it pertains to reports and API hooks.

1. **[[InitializeReporting|http://wiki.izenda.us/FAQ/InitializeReporting]]:**
2. **[[ReportViewerConfig|http://wiki.izenda.us/API/CodeSamples/Javascript/ReportViewerConfig]]:** This is an AJAX command sent by javascript and returns JSON formatted data related to the report viewer configuration.
3. **[[GetRenderedReportSet|http://wiki.izenda.us/API/CodeSamples/Javascript/GetRenderedReportSet]]:** This AJAX command will get the current report set being loaded by the viewer and return the object to the callback method
4. **[[PreLoadReportSet|/FAQ/PreLoadReportSet]]:**
5. **[[LoadReportSet|/FAQ/LoadReportSet]]:**
6. **[[PostLoadReportSet|/FAQ/PostLoadReportSet]]:**
7. **[[PreExecuteReportSet|/FAQ/PreExecuteReportSet]]:**
  1. **Detail report:** The following API calls are related specifically to the detail section of the report. (The reportPart specified is "Detail")
  2. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:** This call to ProcessDataSet returns the headers of the Detail table. It contains one table with as many columns as are in the report before pivot columns are added and one row.
  3. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:** This call to ProcessDataSet returns the body of the Detail table. This is where post processing of report viewer data can be performed. The difference between the previous call and this one is the presence of pivot columns and more than one row.
  4. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:** The next call to ProcessDataSet is to get the pivot column parameters. It will give as many values as specified by your function returns. For instance, using a Group(Year) function when your data has data for 2010, 2011, 2012, and 2013 will return a datatable with four columns at this particular time. This will repeat for as many pivot columns are on your report.
  5. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:** Then we have a call to ProcessDataSet with the totals line being returned as the dataset. Generally, this table will have as many columns as the total columns on your report (plus pivot columns) and one row.
  6. **[[PostExecuteReportSet|/FAQ/PostExecuteReportSet]]:** You can perform any post processing to the actual report here. The [[ReportSet|/API/CodeSamples/ReportSet]]
8. **[[GetFiltersData|/API/CodeSamples/Javascript/GetFiltersData]] (web server):** AJAX call 
9. **[[GetOperatorList|/FAQ/GetOperatorList]]:** This call hooks back into your global and applies the filters on the report using the operators in the list. 
10. **[[ReportViewerConfig|/API/CodeSamples/Javascript/RportViewer]] (web server):**
11. **[[GetFiltersData|/FAQ/GetFiltersData]]:**
12. **[[GetOperatorList|/FAQ/GetOperatorList]]:** This call hooks back into your global and applies the filters on the report using the operators in the list. 
13. **[[CrsDataSources|/API/CodeSamples/Javascript/CrsDataSources]] (web server):** Sends an AJAX call to the web server to get the current report set's datasources. This is used by the report viewer to get the data used in the inline filter editor.
14. **[[GetPivotGuiData|/API/CodeSamples/Javascript/GetPivotGuiData]] (web server):** Sends an AJAX call to the web server to get the pivot data for use on the pivots tab on the viewer.