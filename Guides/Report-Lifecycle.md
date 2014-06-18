#Report Lifecycle

[[_TOC_]]

##About

The Izenda reports API has a various methods and properties that can be overridden to implement custom functionality that allows you to control reports, charts, and data at a granular level. Below you will find the order in which those methods are called and the context in which it is executed. You can find out more about our settings API by viewing the [[AdHocSettings|/API/AdHocSettings]] page.

##ReportList.aspx

This outlines the call structure when accessing the report list page as it pertains to reports and API hooks.

1. **[[InitializeReporting|http://wiki.izenda.us/FAQ/InitializeReporting]]:** The first call must be to InitializeReporting before other API calls are made. This sets the groundwork for all reporting operations. It is recommended that all pages using Izenda reports call this method in the code-behind.
2. **[[ReportListConfig|/API/CodeSamples/Javascript/ReportListConfig]] (webServer):** GetReportListConfig is an ajax call launched by the report list that is necessary to be called before the report list can be initialized.
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

###New

1. **[[InitializeReporting|http://wiki.izenda.us/FAQ/InitializeReporting]]:** This should be called via the OnPreInit function in the page's code behind file, like all Izenda reports pages (except rs.aspx).
2. **[[FilteredListReportsDictionary|/FAQ/FilteredListReportsDictionary]]:** This will perform the same operation as in the report list.
3. **[[ListReports|]]:** If this is the first call to ListReports, or the cache was recently invalidated, this will obtain the reports as before. Otherwise it will skip the individual processing of reports in favor of the cache.
4. **[[GetReportNameById|/FAQ/GetReportNameById]]:** Called like above.
5. **[[GetOperatorList|/FAQ/GetOperatorList]]:** The ReportDesigner now gets a list of operators available for the SqlType context. If customizations to the operator list are required, it can be done here.

###Edit

1. **[[InitializeReporting|http://wiki.izenda.us/FAQ/InitializeReporting]]:** This should be called via the OnPreInit function in the page's code behind file, like all Izenda reports pages (except rs.aspx).
2. **[[PreLoadReportSet|/FAQ/PreLoadReportSet]]:** You can implement auditing or other custom pre-loading operations here.
3. **[[LoadReportSet|/FAQ/LoadReportSet]]:** Loads the report definition from XML. If you want changes to stick after making them, call base.LoadReportSet before you perform changes or do not call base.LoadReportSet at all.
4. **[[PostLoadReportSet|/FAQ/PostLoadReportSet]]:** You can perform post-processing of the report set here. This is the recommended point of direct modification.
5. **[[FilteredListReportsDictionary|/FAQ/FilteredListReportsDictionary]]:** This will perform the same operation as in the report list.
6. **[[ListReports|]]:** If this is the first call to ListReports, or the cache was recently invalidated, this will obtain the reports as before. Otherwise it will skip the individual processing of reports in favor of the cache.
7. **[[GetReportNameById|/FAQ/GetReportNameById]]:** Called like above.
8. **[[GetOperatorList|/FAQ/GetOperatorList]]:** The ReportDesigner now gets a list of operators available for the SqlType context. If customizations to the operator list are required, it can be done here.
9. **[[GetOperatorList|]]:** This is called as many times as there are fields on the report designer. Each call loads data based on the datatype of the field.

##Report Viewer

This outlines the call structure when accessing the report viewer page as it pertains to reports and API hooks.

1. **[[InitializeReporting|http://wiki.izenda.us/FAQ/InitializeReporting]]:** This is called by default again whenever you access a reporting page.
2. **[[ReportViewerConfig|http://wiki.izenda.us/API/CodeSamples/Javascript/ReportViewerConfig]]: (webServer)** This is an AJAX command sent by javascript and returns JSON formatted data related to the report viewer configuration.
3. **[[GetRenderedReportSet|http://wiki.izenda.us/API/CodeSamples/Javascript/GetRenderedReportSet]]: (webServer)** This AJAX command will get the current report set being loaded by the viewer and return the object to the callback method
  1. **Detail Report:** The following steps apply to the detail report(The reportPart specified is "Detail").
  2. **[[GetReportNameById|/FAQ/GetReportNameById]]:**
  3. **[[PreLoadReportSet|/FAQ/PreLoadReportSet]]:** This is run every time a report is viewed before the report set is loaded from the XML definition. You can perform various pre-processing operations based on the report name.
  4. **[[LoadReportSet|/FAQ/LoadReportSet]]:** The XML definition is loaded and the actual reportSet can be manipulated. Or custom loading operations can be implemented.
  5. **[[PostLoadReportSet|/FAQ/PostLoadReportSet]]:** You may perform post-processing of the reportSet here. The result of the post-processed reportSet will be stored as the CurrentReportSet.
  6. **[[PreExecuteReportSet|/FAQ/PreExecuteReportSet]]:** Occurs before rendering the reportSet to the screen.
  7. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:** If there are pivot columns in the report, this call to ProcessDataSet returns the result of the values for each pivot column group. This is used at the top of the report as column groupings.
  8. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:** This call to ProcessDataSet returns the results of the main query with pivot columns and filters applied.
  9. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:** If grand totals are added, the ProcessDataSet method is called again to generate and return column groupings for the totals line.
  10. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:** The result of the grand totals is returned in this call. Therefore, it will be a one-row dataset with pivot columns and filters taken into consideration.
  11. **[[PostExecuteReportSet|/FAQ/PostExecuteReportSet]]:** Allows any final touch-ups to the report to be made before pushing the report to the screen.
4. **[[GetFiltersData|/API/CodeSamples/Javascript/GetFiltersData]] (web server):** AJAX call to obtain the filters used on the CurrentReportSet. This is used to display filters on the page.
  1. **[[GetOperatorList|/FAQ/GetOperatorList]]:** This call hooks back into your global and applies the filters on the report using the operators in the list. This is called for as many filters as the CurrentReportSet has.
  2. **[[ProcessEqualsSelectList|/FAQ/ProcessEqualsSelectList]]:** 
  3. **[[ProcessDataSet|/FAQ/ProcessDataSet]]:**
5. **[[CrsDataSources|/API/CodeSamples/Javascript/CrsDataSources]] (web server):** Sends an AJAX call to the web server to get the current report set's datasources. This is used by the report viewer to get the data used in the inline filter editor.
  1. **[[GetOperatorList|/FAQ/GetOperatorList]]:** This is called here in order to return the possible filter operators available for each datasource returned to CrsDataSources.
6. **[[GetPivotGuiData|/API/CodeSamples/Javascript/GetPivotGuiData]] (web server):** Sends an AJAX call to the web server to get the pivot data for use on the pivots tab on the viewer.