[[_TOC_]]

# 6.10.0.4 (March 22, 2016)

## Fixes

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|8453|API|Feature| Izenda Reports - Added labels (EX: SUM, COUNT) that appear on the hover-over of a subtotal.|
|11189|API|Feature| Addition of commentary to Izenda serialization.|
|21937|Dashboards|Feature| Dash2.0 - Adding support for Fusion Report Cache timestamp to appear on report tiles in new Dashboard.|
|22505|Instant Reports|Feature| Dash2.0 - Ability added to easily set default category in Dash2.0 in code. Settings in file: "Resources/components/dashboards/module-definition.js" // dashboard config object: angular.module('izendaDashboard').constant('izendaDashboardConfig', { showDashboardToolbar: true, defaultDashboardCategory: 'Filters', defaultDashboardName: 'dashboard Autocomplete Filter' });|
|22537|API|Feature| Refactored Datatable class to increase performance on larger data sets. Implemented setting AdHocSettings.ClearManagedMemoryOnRender, this false by default. When set to true .NET Garbage Collector is explicitly called. To take full advantage of these changes in the Datatable class custom formats can be updated to use the following: 1) Replace IFormatter with BaseFormatter 2) Replace all DataTable occurrences with AdHocDataTable 3) Add override key words to the methods, so: - "public Type GetOutputDataType" -> "public override Type GetOutputDataType" - "public object Format" -> "public override object Format" Example below: Original: class CustomDateFormatter : IFormatter, IExcelFormatter { public string GetExcelCellClass { get { return "xls-text"; } } public Type GetOutputDataType(DataTable table, int columnNumber, ReportOutputOptions reportOutputOptions, Field field) { return typeof(string); } public object Format(DataTable table, int rowNumber, int columnNumber, Field field, DataTable originalTable, Field nameField) { var value = table.Rows[rowNumber][columnNumber]; if (value == null || value == DBNull.Value) return ""; return string.Format("{0:dd MMM yyyy}", value); } } Updated: class CustomDateFormatter : BaseFormatter, IExcelFormatter { public string GetExcelCellClass { get { return "xls-text"; } } public override Type GetOutputDataType(AdHocDataTable table, int columnNumber, ReportOutputOptions reportOutputOptions, Field field) { return typeof(string); } public override object Format(AdHocDataTable table, int rowNumber, int columnNumber, Field field, AdHocDataTable originalTable, Field nameField) { var value = table.Rows[rowNumber][columnNumber]; if (value == null || value == DBNull.Value) return ""; return string.Format("{0:dd MMM yyyy}", value); } } All previous implementations of IFormat will still work, but will not take advantage of the optimizations in the new Datatable implementation.|
|22749|Report Design|Feature| Cell Highlight - 'High' 'Medium' and 'Low' strings can no longer be used to address the upper, middle, and lower thirds of a range in highlighting or value range aliasing. You can use "x% to y%" range syntax to establish custom proportional ranges instead. High, Medium and Low will now function properly as strings.|
|23025|Instant Reports|Logging|Feature: IR2.0 (BETA) - Support for Filter Regex added to IR2.0.|
|23039|Scheduler|Logging|Feature: Scheduling - Added ability of configure local SMTP port. Add this method to customadhocconfig: public static System.Net.IPEndPoint BindIPEndPoint(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount) { return new System.Net.IPEndPoint(System.Net.IPAddress.Parse("192.168.0.61"), 6666); } Add this setting to InitializeReporting: AdHocSettings.SmtpClientBindIPEndPointDelegate = BindIPEndPoint;|
|23435|Instant Reports|Feature| IR2.0 (BETA) - added support for setting AdHocSettings.ShowChartTab which can hide the chart menu tab.|
|23438|Instant Reports|Feature| IR2.0 (BETA) - Adding support for hide grid feature in New Instant Report Designer. User can now create a Visualization from a grid and hide the grid from view in the report.|
|23642|Instant Reports|Feature| Enabling a feature on new Instant Report page to "Show Filters In Report Description". This option allows the filters to show on the screen and in the printed report.|


## Features

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|21656|API|Optimization|Fixed: When using an ODATA connection, the results drop down was not properly working to increase or decrease number of results.|
|22443|Instant Reports|Optimization|Fixed: In IR2.0, when checked all field headers now become bold.|
|22500|Instant Reports|UI|Fixed: IR2.0 AutoGauge missing size-adjustment slider.|
|22607|Instant Reports|Optimization|Feature: IR2.0 (BETA)- 'Expose as Datasource' functionality added to IR2.0. Requires 'AllowVirtualDatasources=true' to be set.|
|22611|Instant Reports|UI|Feature: IR2.0 (BETA) - Add 'Hide Grid' UI to make tables invisible for Visualization-only report styling.|
|22615|Instant Reports|Optimization|Fixed: BETA New IR page is not paginating reports properly. The first page appears to limit records properly, but the pagination controls do not appear at the bottom of the screen.|
|22678|Instant Reports|Visualization|Feature: IR2.0 (BETA) - Help links for visualizations added.|
|22738|Report Design|Filters|Fixed: Code conflict that could cause null reference exception using a 'GreaterThan: 1' filter.|
|22855|Report Design|Visualization|Fixed: Grouping in Calendar Visualisation shifting values improperly.|
|22886|Dashboards|Optimization|Fixed: Issue where certain customizations or report configurations could cause multiple copies of same dashboard pane to erroneously appear upon refresh of a dashboard.|
|22976|Report Design|Filters|Fixed: When using a Group(week) or Group(year & quarter) function and "Add Subtotals" is selected, some reports will throw an "ORA-01722: invalid number" error in Oracle. On SQL Server, Izenda will display the error "Conversion failed when converting date and/or time from character string".|
|22992|API|License Key|Fixed: Stack Overflow Exception experienced when reading value 'LicenseKey' from web/config in certain configurations using web.config instead of global API to set license.|
|22996|API|Optimization|Fixed: Issue with unexpected date behavior using Timezone offset setting and creating a pivot based on date.|
|23007|API|Optimization|Fixed: Situation when manual schema cache refresh is required when adding a new stored procedure. Schema refresh will not be needed to add a new stored procedure to VisibleDatasources.|
|23035|Report Design|UI|Fixed: Browser-specific issues with popup drill-down UI rendering.|
|23056|Report Design|Visualization|Fixed: Calendar Visualization and Auto-Gauge Visualization being cut off in PDF exports.|
|23059|Report Design|Visualization|Fixed: Issue with values containing a ',' using tree-filter operator corrected.|
|23066|Dashboards|Filters|Fixed: Dash2.0 - Issue where the filters for dashboard tiles did not apply to the first tile of a report. This occurred when that first tile was a visualization and 'attached to', or built off of, the report summary.|
|23068|Report Design|Visualization|Fixed: Description text not used for chart labelling|
|23079|Report Design|Export|Fixed: After export, default preview results value ignored upon report update.|
|23090|API|Optimization|Fixed: NULL label added to replace erroneous 'column position label' assigned to counted NULL columns.|
|23102|API|Optimization|Fixed: When a colon is in the description box and a column group is being applied either through advanced field settings or the field@group method, colon also produces a column header.|
|23115|API|Optimization|Fixed: The error - "The ORDER BY clause is invalid in views, inline functions, derived tables, subqueries, and common table expressions, unless TOP, OFFSET or FOR XML is also specified." - displayed when doing certain PERS operations with expressions.|
|23124|API|UI|Fixed: Using a view name containing apostrophes was disallowed by the UI.|
|23150|Dashboards|Export|Fixed: Issue with dashboards exported to Excel where formatting was lost.|
|23158|API|Optimization|Fixed: Issue opening Settings.aspx via a mobile browser.|
|23176|Instant Reports|Data Sources|Fixed: Implemneted LazyLoad behavior for IR1.0/2.0. Stored Procedures will not be called/cached until expanded in IR with LazyLoading enabled. **NOTE: StoredProcedure columns will not be available for 'search' in IR until expanded and column values cached.**|
|23194|Scheduler|Optimization|Fixed: Applying timezone to UTC caused error - 'The added or subtracted value results in an un-representable DateTime.' - using Izenda setting 'ScheduleTimeZone'.|
|23208|API|Optimization|Fixed: On-page UI sort of data by clicking column header using alphanumeric order for dates instead of date order.|
|23224|API|Optimization|Fixed: Legacy JS refactored to allow '&' symbol in the name value of a drilldown.|
|23227|Report Design|Forms|Fixed: Deploying Izenda using UNC pathing, issues with FORMS product corrected.|
|23230|Dashboards|UI|Fixed: "Missing color hue rotate" error resolved in dash 2.0 background hue UI.|
|23231|Dashboards|Filters|Fixed: Dash2.0 - New Dashboard slider fixed so that it can be drug one or many segments.|
|23234|Instant Reports|Filters|Fixed: "ORA-01036: illegal variable name/number" error when using IR2.0 and Equals(Calendar) and preview results 100.|
|23235|Instant Reports|Filters|Fixed: IR2.0 displayed 'Invalid Value' error switching between date-entry filter and calendar date filter operators.|
|23236|Instant Reports|Filters|Fixed: 'Object reference' error displayed when switching from 'Between(Calendar)' to 'Equals Calendar' in IR2.0.|
|23240|API|Optimization|Fixed: Subcategory creation during report saving using 'Category/Reportname' behaves the same in both Viewer and designer.|
|23249|API|Caching|Fixed: Conflict in logic that sometimes results in empty name of the file for schema cache, causing cache to be lost, causing frequent long loading times.|
|23260|API|Optimization|Fixed: Issues with pivots and session state handlers in webfarms resolved.|
|23282|API|Optimization|Fixed: Changed handling of report SQL generation to better support legacy reports from Izenda 6.7 versions being correctly generated in the latest versions of Izenda with no changes.|
|23316|Report Design|Export|Fixed: Issue exporting to Excel in the following situation- Field is a Date(Time) type; VG; Export to Excel|
|23317|Report Design|Visualization|Fixed: Autochart legend now mirrors field order.|
|23331|Report Design|Filters|Fixed: Issue in the ReportDesigner where datepicker does not open automatically.|
|23334|Report Viewer|Export|Fixed: Serialized several objects overlooked in the v6.10.x release. Also corrected bug with limited rows being exported for XLS output|
|23340|API|Optimization|Fixed: Session data storage provider is not available error when HttpContext.Current.Session is null.|
|23352|Instant Reports|Data Sources|Fixed: When initially selecting a datasource in Instant Reports, the checkbox remains blank and users are unable to create joins off of the tables. The checkbox will now contain a check and users will be able to create joins.|
|23354|Report Viewer|Export|Fixed: Distorted thumbnails sometimes generated by EVO engine.|
|23359|API|UI|Fixed: Issue with HiddenCategories and 'CurrentUserName' values in session which can clear or duplicate categories for other users.|
|23378|API|Optimization|Fixed: Error found in logs that had no effect in UI but did unnecessarily bloat logs.|
|23433|API|Optimization|Fixed: Issue with serialization of malformed blank reportSet object when preparing response to getReportDashboardConfig request.|
|23457|API|Optimization|Fixed: Regression issue where initialization logic was broken for MVC4 kit specifically.|
|23458|API|Data Sources|Fixed: Issue with missing pagination controls on reports generated from Stored Procedures.|
|23467|API|Optimization|Fixed: System.ArgumentException: Issue where you get 'URI formats are not supported' error when usingAdHocSettings.ImagesPath. Exception is thrown by .net method System.IO.Path.GetFullPath which was added to ImagesPath setting getter in the commit for mentioned above case.|
|23487|API|Optimization|Fixed: Starter-kit code for vanilla Izenda installs modified so that it will pick 1.12 jquery for <=ie8, and 2.1 for all other cases.|
|23508|API|Logging|**NOTE: Starting in the next version (v6.10.0.5+) ReportSet.GenerateOutput will be obsolesced. The new best practice is to use the ReportOutputGenerator classes directly.**|
|23539|Report Viewer|Save|Fixed: Issue where saved formats in a report would be wiped out by making any format changes in the viewer advanced area.|
|23576|Report Design|Data Sources|Fixed: Database object with " ' " in name causing error in reading visible data sources.|
|23584|Instant Reports|Data Sources|Fixed: IR2.0 BETA - Instant Reports page the data source columns sorting based on the field name in the database instead of the alias name assigned.|
|23588|API|Optimization|Fixed: Issue if the logger call is incorrectly designed then unhandled exception may occur.|
|23595|Report Design|Filters|Fixed: Issue with single empty string value used in filters similar to Equals(Select) in functionality. Example: Empty auto-complete filter generates SQL - WHERE ([dbo].[Orders].[ShipCountry] = N'')|
|23627|Report Design|Pivot|Fixed: When adding a pivot the row headers are clickable to view the field panel, column headers are not, but after adding a second pivoted column the row headers cannot be clicked to view the field panel.|
|23629|Instant Reports|UI|Fixed: IR2.0 (BETA) - Issue with menu option for print, the dropdown itself does not show, can't print a report on PDF and HTML.|
|23631|Instant Reports|Export|**NOTE: New settings in default global.asax. - Set New IR as Instant Report Page - Set AdHocSettings.ShowJoinDropDown = true - Set default PDF print mode to EVO**|
|23649|Report Design|Save|Erroneous _global_ tenantID saved instead of user tenantID.|
|23680|API|Data Sources|Fixed: Issue with DB Schema cache causing existing database relationships to not work with any FUSION connection.|
|23691|Instant Reports|Filters|Fixed: Dash2.0/IR2.0 (BETA) - Issue where report becomes invalid when user tries to filter values created from IR designer.|
|23724|API|Optimization|Fixed: Discrepancy between very old code and recently added improvements to cultures handling. This conflict caused issues with cultures that change date format and Stored procedure code.|
|23732|Instant Reports|Filters|Fixed: IR2.0 (BETA) - 'Equals' style operators erroneously showed 'No Results' when 'blank' selected.
|23759|Report Design|UI|Fixed: Issue with Equals(Calendar) UI where 'Next' and 'Previous' month buttons were not visible.|

# 6.10.0.3 (February 23, 2016)

## Features

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|**HF:23222**|Report Design|Data Sources|**Hot Fix (03/02/2016)** Fixed: Bug limiting maximum number of joins to ~10 corrected. When adding data sources in Report Designer Advanced mode, additional copies of the same table were not being aliased to allow for self joining|
|19644|API|Optimization|Added intelligent schema labelling in ReportDesigner 'DataSources' tab, which applies schema names when two DataSources have the same name from two different schemas.|
|20555|Report Viewer|Optimization|Added Support of Server Side sorting in the Report Viewer. Setting which controls the behavior is AdHocSettings.SortGridOnServerInViewer. The default value is set to false so the behavior will remain the same for all existing customers. This change only works in the Report Viewer, on other pages default client-side filtering should be utilized by changing the sort on the field in the designer. - All active field settings are shown and user can change the sort on multiple columns. With pure client-side sorting there is no way to apply sorting hierarchy while in this case we can do this so user can cycle asc/desc/none sorting on any column keeping previously saved sort. For instance, you could sort by Country and by City using this new feature while with the old sorting you can sort either by Country or by City. Applied sorting is respected in exports. In case of a pagination current page is preserved.|
|22561|API|Optimization|Added setting for number of recently updated reports to allow client to set a value for how many should be displayed.  The default value for the new setting, AdHocSettings.RecentlyUpdatedCountAtReportList is 10 but any other interger may be used.|
|22608|Instant Reports|Optimization|Added support for BETA Instant Report page for user to drag new field into the work area between two existing fields on a report. User can drag existing fields around in the report work area to change position as well.|
|22703|Instant Reports|Optimization|Adding support for creating pivots in the BETA New Instant Report page. [Documentation](http://wiki.izenda.us/Guides/Instant-Reports-v2-BETA#Adding-a-Pivot---Added-6.10.0.3-Release)|
|22704|Instant Reports|UI|New BETA Instant Report - Rearranged the Field formatting options on the field panel. [Documentation](http://wiki.izenda.us/Guides/Instant-Reports-v2-BETA#Field-Settings---Updated-6.10.0.3-Release)|
|22708|Instant Reports|Optimization|Enabled full support of FUSION with DataSourceCategories API for InstantReports 1.0/2.0. FUSION connections and DataSourceCategories now both create hierarchies in IR 1.0/2.0.|
|23251|Report Design|Expressions|Changed default of value of AdHocSettings.ShowModifiedReportMessage to false from true. This feature has been noted to cause issues for some client and the default has been changed until a final resolution can be made to enhance the feature.|

## Fixes

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|18570|UI|Visualization|Fixed an issue where  the Drilldown on Visualization "AutoChart" were not properly drilling down on Ipad and similar smaller mobile and tablet devices.|
|18933|Report Design|Optimization|Fix of regression bug where if you create a report with a concatenated field, remove & re-add that field from the viewer, it loses its original concatenated value. Also of note, if you edit the report from the same page after this happens, the order of the fields is different.|
|19948|Report Design|Optimization|Standardized 'Report Visibility' syntax in XML between ReportDesigner and InstantReports.|
|21403|Feature|Optimization|AdHocSettings.UltimateDbCommandTimeout added. When value is >0 DB request for filling the DataSet is executed asynchronously. If specified time is passed but DataSet is not yet filled then DB command is interrupted and canceled.|
|21620|Report Design|Optimization|Fixed JavaScript error in Internet Explorer created by Date picker due to change of focus.|
|21699|API|Optimization|Refactoring of initialization flags enhancing Izenda's compatibility with various webfarm environments.|
|21755|Dashboards|Visualization|When adding a Visualization to a report part on a dashboard, the sizing element has been removed. The size change cannot be saved in the dashboard as the report part is loaded from the current report format. If a sizing change is needed it should be made in the report and saved there.|
|22000|API|Optimization|Fixed issue with browser zoom settings overzealously moved the InstantReports preview area to the screen bottom, emulating narrow screen (mobile) behavior on full monitors.|
|22225|Report Viewer|Export|Fixed an issue with printing to HTML from report viewer where user could only print one time. On second try there is no response when clicking selecting the Print to HTML print option.|
|22275|API|Export|Reimplemented feature "Limit Outputs to CSV". This allows the report designer to select this option on the Misc tab of the report designer and when the report is viewed in the Report Viewer only CSV and XML export options are shown for export. This is useful in larger report sets where exporting may be very lengthy or where data is needed for export.|
|22348|API|UI|Fixed issue moving from InstantReports to ReportViewer where 'Area' chart is changed back to 'Column' chart default.|
|22395|Report Design|Optimization|Fixed issue where reports with the TenatID _global_ would not load in the ReportDesigner when session included AdHocSettings.CurrentTenantID.|
|22407|Dashboards|Saving|In Dashboard V2 after moving two report parts to different locations in the dashboard, if users clicks 'save dashboard' , then it saves. However, when reloaded, the report parts are back to their original areas.|
|22444|Instant Reports|UI|Fixed issue with restore default colors button not functioning in InstantReports.|
|22495|API|Optimization|Fixed serialization issue with 'Izenda.AdHoc.PdfGeneratorBase' error.|
|22544|Dashboards|Export|Fixed issue with dashboards export to Excel of tables using VGHierarchy style where style was changed before export.|
|22548|API|Expressions|Feature: Added support for DATETIME and SMALLDATETIME for use in expression field.|
|22612|API|Optimization|Updating 'Preview Not Available' image for better user friendliness. Preview will now use a standard report image with a watermark as "Sample" until an actual preview is created from opening the report in the Report Viewer.|
|22626|Report Design|Visualization|Fixed error when choosing PREVIEW in the ReportDesigner if not all information is correctly entered to generate a map in the MAPS tab, causing a SQL error to display in IE.|
|22634|Report Design|Gauge|When creating a new report using a gauge (from gauge tab)in report designer there is a setting showing how may gauges to display - this is not respected in the dashboard, the limit is respected in the report, but all gauges are displayed in dashboard tile.|
|22673|API|Optimization|When using a field where the data contains a comma "," as a drill down filter the comma was not properly escaped in code. This resulted in bad data being sent to the subreport and the subreport was not properly filtered. Resolved, now fields containing commas can be used as drill down fields to a subreport without error.|
|22734|API|Optimization|Reverted changes with unintended consequence of disallowing pathing using both '/' and '\'.|
|22752|API|Optimization|Added value validation code for 'Records' box in 'Fields' tab of ReportDesigner.|
|22772|Dashboards|Optimization|Fixed issues with scheduling dashboards where the schedule type could not be changed from 'Embedded'. Also fixes issue where embedded reports do not export in the correct order.|
|22776|Scheduler|Export|Fixed legacy SchedulerExecuting flag - used to determine whether charts must be rendered to picture. Now Izenda sets this flag automatically when SchedulerOutput.GenerateMessage method is called.|
|22784|API|Export|CSV export using wrong separator ";" when exporting while using culture set to Spanish. Resolved, now properly using the "," separator.|
|22802|API|UI|Fixed issue with SubReport headers are displayed under filters section in reports.|
|22805|API|Optimization|Fixed bug in logic in code which renders report in field|value style if there are hidden fields - previously resulted in "Uncaught SyntaxError: missing ) after argument list" error message.|
|22817|API|Optimization|Fixed issue where artificial limits on paging (10K rows) and report row limit (100K rows) were forced without settings being active.|
|22824|Report Design|UI|Resolved issue where chart titles added in the report designer are not showing up in the title section on the dashboard.|
|22872|Dashboards|UI|Tiles in dashboard using "user-select: none;" css style, but text should be available for copy. This is resolved now and the text from the dashboard tiles can now be copied.|
|22893|API|UI|Added support for Drilldown key passed to subreport to be an aggregate. Prior to this change values would not be passed to subreport if any aggregate function (sum, count, etc.) was used in the field.|
|22898|API|Optimization|Setting AdHocSettings.ApplicationHeaderImageUrl not working properly in Webforms VB kit. Issue resolved. Issue can be resolved without this fix by uncommenting the following lines in default.master.vb: 'If (Not String.IsNullOrEmpty(AdHocSettings.ApplicationHeaderImageUrl)) Then ' rightLogo.Src = AdHocSettings.ApplicationHeaderImageUrl 'End If|
|22932|Instant Reports|Optimization|Fixed issue in InstantReports where 'Search' values were not correctly reducing available options (greying out).|
|22933|API|Optimization|Fixed issue with internal key values for Arabic and Bulgarian localization where the English values were inappropriately used.|
|22947|Report Design|Gauge|Fixed an error with 'Count Distinct' function and 'Linear' gauges causing preview error. Also, improved log gauge readability in some situations.|
|22949|Report Design|Filters|Fix to various 'time period' filters (EX: 'This Week', 'Last Week', 'Today') which had inconsistent/unexpected results.|
|22953|API|Optimization|Fixed difficulty when using VS2015 with Izenda. VS 2015 creates local applicationHostConfig files, solution is to edit ri.csproj to use: <UseGlobalApplicationHostFile>true</UseGlobalApplicationHostFile>|
|22962|API|UI|Fixed issue breaking 'italics' style when subtotals are used.|
|22972|API|Optimization|Beginning with the RI for 6.10.0.3, the AdhocSettings.CurrentUserIsAdmin setting will be put in the global as set to true. This is not a change to the default setting, it is added to make it visible that the default value is true.|
|22999|Instant Reports|Filters|Build script removed from final build on archives site. This is an internal file used for building the site and is not needed in the reference implementation.|
|23013|Instant Reports|Filters|Fixed issue with export to PDF of Projection Map where map duplicates and the link is not clickable.|
|23049|Feature|Visualization|In BETA Instant Reports, reports not saving properly. Issue only seen in complex reports that take a few seconds to save. Optimized save process to speed time and changes made to ensure save process completes.|
|23053|Instant Reports|UI|When adding a new drilldown report to the BETA Instant Report page the popup style was not loading properly, resolved.|
|23054|Dashboards|UI|Possibly HTML injection issue. When using a link to access a report in the report designer, if the report name does not exist the report name given in the link should not be displayed on the screen in the designer. Resolved.|
|23071|Dashboards|Filters|When exporting charts to excel, labels containing dates are exporting as the integer value in excel. Resolved.|
|23081|Report Design|UI|When joining a table twice in the report designer, the second instance of the of the join does not contain "No Lock". Resolved.|
|23104|Dashboards|UI|Fixed issue with delay in opening 'Fields' dropdown in report designer. Optimized JS to increase performance significantly.|
|23109|API|Optimization|Fixed issue when Arithmetic addition checkboxes on the 'Fields' tab were used to sum 3 or more columns consecutively.|
|23121|Report Design|Visualization|Fixed errors with Dashboard2.0 tiles loading blank, and broken funnel chart loading behavior. (Requires browser cache refresh)|
|23156|API|Optimization|Izenda.AdHoc.PdfGeneratorBase was not properly made serializable, resolved.|
|23252|Report Design|Charts|Fixed issue where report name disappears when the cursor is not on the dashboard tile.|
|23255|Scheduler|Optimization|Name of field disappears from filter description when user changes the field format from the fields tab of the report viewer page. Example - date field selected as filter and changed from 2/1/16 to February 1, 2016 the filter field description is removed from the filter header bar.|
|23266|API|Optimization|Fixed server error when using the 'PopUp' drilldown style in InstantReports.|
|23281|Feature|UI|Fixed error with exporting Dashboard Visualization chart parts individually where the links provided for the export were not functional.|
|23290|Report Design|UI|Using a Visually grouped field on a field with a URL link applied and a style of Field Value, results in JavaScript error. Resolved.|
|23326|Report Design|UI|Time Bubble chart not displaying in Internet Explorer, showing error "Timebubble visualization Object doesn't support property or method 'isNaN'". Resolved.|

# 6.10.0.2 (January 26, 2016)

##Important Note about 6.10.0.2
The update process has changed for stand alone MVC versions using Izenda's solution file.  
It is recommended that when upgrading to this version (if you are using a stand alone) to download a new RI.
Any upgrades going forward will require to to copy the contents of the Bin folder of the upgrade pack into your existing Bin folder and another copy into the new Lib folder.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|**HF:23145**|Report Design|Filter|**Hot Fix (02/09/2016)** for new Date/Time picker feature. By default, the date picker does not use time. The picker can be changed to use Date & Time by using AdHocSettings.ShowTimeInFilterPickers = true. <br/><br/>This ticket resolves the following issues: <br/>1 - Dashboard scheduling was inoperable after the date/time picker was added. This is now resolved <br/>2 - Date/Time Picker respects dates using European format in the filter operator. <br/>3 - The second date for Between Calendar operator was defaulting to the beginning of the day (00:00:00). It now defaults to end of the day (23:59:59). This can be modified by the user, but the second date cannot be set to (00:00:00) it should be set to the day prior and the midnight default (23:59:59). These time defaults match the Izenda queries used if the time function is not used. <br/>4 - Previously when user is manually entering data, the cursor is moved to the "Time" field in the date time picker. This has been resolved. <br/>5 - Date picker icons have different vertical alignment in the Report Viewer and in  the Dashboard page. The issue is addressed the new date time picker, which is larger than the old date only version. For this reason the focus for selection had to be changed to the calendar icon to avoid covering the input fields for smaller screens if the user wants to type in the date. Previously, the user could click in the input field to use the picker, now the pickers must be selected by clicking the calendar icon. <br/>6 - Previously, if the user used "AdHocSettings.Language/AdHocSettings.Culture" to implement foreign language settings, the culture was not respected by the date/time picker. The new changes implemented in the current release enabled " AdHocSettings.Language = AdHocLanguage." to automatically set the culture settings when a language is selected i.e. DateTime fields & Currency fields will get adjusted to Language chosen. e.g. When user selects "French" as the language to be implemented then the setting will be " AdHocSettings.Language = AdHocLanguage.French". The Date format will change to European i.e. DD/MM/YYYY & Currency will be changed to Euro.|
|17815|API|Optimization|AdHocSettings.AllowVisualGroups setting is deprecated and will no longer be available.|
|19792|Report List|Optimization|Enhancement of thumbnail generation process fixing incompatibilities with Azure Web Apps and other scenarios with COM restrictions.|
|20471|Report Design|Gauge|Applying highlight to calculated field then applied to a gauge breaks the gauge. Fixed.|
|21106|Report Design|Charts|Fix: The Bezier curves on the Funnel Chart slice labels is off in viewer and Dashboards.|
|21642|Report Design|Charts|Fix: Legends not showing in pie charts|
|21816|Report Design|UI|Fix: "..." appears in grid; Error with links in CG fields; Issue with "" in field names.|
|21885|Report Design|Expressions|When one adds a field, and the adds and expression to that field under advanced settings, that expression is then added to any NEW field of the same name when using either insert field above/insert field below.|
|21930|Report Design|Optimization|Fix: Erroneous long decimal values in Dashboard.|
|21934|Report Design|Optimization|Fixed long load times as StoredProcedures queried on rpeport load. If following setting is added to Global: AdHocSettings.ValidateExistingReportsInDesigner = false; then Izenda doesn't validate tables/columns in database for existing reports when constructing list of them for reportDesigner (so it still checks if user has access rights to this reportset, tenant, etc. Also it doesn't affect ReportList or anything else except designer). This results in much faster reportDesigner loading, along with no pulling any StoredPProcedure metadata from database for existing reports, though reportDesigner will still show list of subreports, mark datasources which are used in any reports, etc.|
|21935|Feature|Optimization|Fixed Oracle numeric types mapping bug and added datatype mapping control. EX: AdHocContext.Driver.NativeToInternalTypesMap["NUMBER(18,0)"] = SqlType.TimeStamp;|
|21963|Report Design|Optimization|Fix: Issue with Instant Report pages not respecting FieldsRegex.|
|22041|Feature|Optimization|Fix: The date in the header will be displayed, even though we didn't select the "Show date and time".|
|22070|Dashboards|UI|Fixed issue with Dashboard background images not covering the top of Dashboard area.|
|22110|Dashboards|UI|Hover text from individual dashboard tiles is behind adjacent tiles in the dashboard.|
|22131|Report Design|UI|Show Legend Checkbox is implemented.|
|22140|Feature|Forms|You can now add css to the body of a form itself using the <!--FORMSTYLE--> add CSS here <!--FORMSTYLE--> tag|
|22157|Dashboards|UI|After re-sizing a tile in the dashboard, scroll bars appear on unaltered tiles and will continue to display until the unaltered tile is selected for re-sizing.|
|22193|Report Design|Optimization|Refactored Pivot queries for enhanced performance.|
|22235|Report Design|Filters|Fix: Issues and inconsistency found in Filters for Fields with NULL or a Blank available as value.|
|22254|Report Design|Export|CSV files downloaded from Report Viewer and report Designer are having same file size|
|22260|Report Design|Filters|Fixed issue with filters, where with two different joins of the same table, one aliased, any change you make to one is copied over to the other when you click "update results".|
|22266|Report Design|Expressions|When Join Alias is added it does not work in the Expression, also table name stops working.|
|22272|API|Visualization|Fix: Issues with IE9 translucency of the AutoChart tool-tip|
|22316|Feature|Export|Fixed issue with exporting to CSV always returns an excel spreadsheet with the error "Could not pickup appropriate connection" instead of data. Specifically applies to OData connection with BulkCSV enabled.|
|22329|Report Design|UI|Adding constraints using the Izenda.AdHoc.AdHocContext.Driver.AddConstraint method caused garbled field headers when using a pivot.|
|22333|API|Optimization|Updated report name dialog, so now it respects AllowCreateNewCategory setting and don't show "Create New Category" option when AllowCreateNewCategory is false.|
|22335|Report Design|Gauge|Fix: Autogage does not respect $/100 format|
|22340|Report Design|Export|Fix: No report found on excel when exporting a report with a subreport on dashboards.|
|22352|Report Design|Gauge|Fix: The value and Format of Radial Gauge is incomplete when it is previewed.|
|22353|API|Optimization|Fixed issue with exceeding of url length of GET requests in report designer, replaced all with POST.|
|22377|API|Export|PhantomJS headers repeating disabled, hiding bug in core PhantomJS tool. EVO PDF engine added as alternative.|
|22394|API|Optimization|Fix: Made class serializable that wasn't previously. Exception type: SerializationException Exception message: Type 'Izenda.AdHoc.Webservices.SubreportFiltersCollection' in Assembly 'Izenda.AdHoc, Version=6.9.0.6, Culture=neutral,|
|22401|Report Design|Export|Dates changing to number text after exporting to excel when grouped by year/month in report designer.|
|22421|Report Viewer|UI|Fix: Issue with viewer sorting behavior when ResponsiveGrid is on and more columns are added than screenwidth can display.|
|22432|API|UI|Fix spelling error on dashboard scheduler page dashboards says "Recepients" in the email to box. Corrected to show correct spelling "Recipients".|
|22436|Report Design|Visualization|Changing the selection process for Visualization types on the Report Designer Charts tab from radio button to clicking image or name under the image.|
|22449|Dashboards|UI|In Dashboard V2 when filter panel is expanded, the mouse over function in the dashboard grid is not correct. The mouse hovers over one grid square but a different gird square is highlighted. Resolved hover over grid item is also the selected one.|
|22456|Report Design|Filters|Fix to 'Between' filter operator availability and addition of between calendar support to the dashboard.|
|22508|API|Optimization|Fix loss of timezone offset when certain grouping combinations are used.|
|22533|Dashboards|UI|Corrected spelling on dashboards|
|22539|API|Optimization|Separated 'Linear' and 'Logarithmic' gauge scaling|
|22551|Instant Reports|Saving|Error message displayed to user when attempting to save a report from New DEMO IR page in a new Reference Implementation without a Reports folder. Change made to create folder for user to save report definition.|
|22585|API|Filters|Fixed a null reference exception when report is opened with filter values passed in a URL, also resolving issues where Left Join fails to render a report.|
|22587|Report Design|Filters|Fixed lost filter logic parameters upon report export.|
|22598|Report Design|Optimization|Fix: Fields dropdown delays in MVC. Implemented optimization in branch FB-22598, now adding field works ten times faster.|
|22602|Report Design|Visualization|Heatmap issue with values/labels not exporting to PDF fixed.|
|22614|Instant Reports|UI|Add "Expose as datasource" option for Virtual Datasources to new DEMO Instant Report page.|
|22651|API|Optimization|Fix: Broken recognition on multiple constraints containing foreign keys.|
|22662|Instant Reports|Filters|BETA New Instant Report page added support of Param indicator for filters. This allows the user creating the report the ability to display filters to the report viewer as parameters for changing the report filter values. This ability is based on the sharing rights given to the viewing user.|
|22676|Instant Reports|Filters|New Instant Report Page added support for filter descriptions. User can change the name of the filter for viewing in the report viewer.|
|22683|Feature|Visualization|User help information added into base fileset for AutoGauge & Flowchart visualizations.|
|22701|Instant Reports|UI|Added responsive behavior for reduced screen sizes for New Instant Report page. For mobile all items are moved to left panel and UI elements are are adapted for small screen size.|
|22712|Dashboards|UI|Fix: Report Parts on dashboard disappear if Show tile options was clicked while the print tile report is open in another window.|
|22717|Dashboards|Filters|Autocomplete filters from reports are not functioning in Dashboard V2. Data is not displaying when user types in any data to the filter. Resolved.|
|22748|Report Design|UI|Fixed css style which prevents proper Width value from being applied.|
|22753|Dashboards|UI|When using setting AdHocSettings.ShowSaveControls = false; the setting is not removed from the Dashboard V2 page. Resolved, setting now disables all save functionality from Dashboard page.|
|22762|API|Optimization|Izenda License keys were not expired as expected. After the fix testing is done in all the environments i.e. SQL, MySQL, Oracle, PostGress, ODATA, MVC.|
|22773|Report Design|Visualization|Adding help text for ArcMap and Projected Map in Visualizations area of Report Designer.|
|22787|API|Optimization|When using tables with "." in name. Constraints were not loading from the database to allow users to join tables in simple mode of Report Designer and Instant Reports. Resolved now tables names with "." are not blocking constraints.|
|22818|Report Design|Charts|Fix: Y-Axis labels improperly formatted for right-hand Y-Axis values.|
|22861|Scheduler|Optimization|Fix: Scheduled Dashboard uses 'ReportViewer' link instead of 'Dashboards' link.|
|22875|API|Optimization|Fix: Minimization of StoredPocedure calls amount when rendering reportSet with several reports.|
|22922|Feature|UI|Folder structure modified to alleviate issues with helper files being deleted on Clean or Rebuild processes in Visual Studio. New Libs folder now contains a copy of the bin folder (must be kept up-to-date on maintenance release upgrades where bin folder is replaced without a new RI) to keep helper files from being deleted when the project is cleaned.|
|22945|Report Design|UI|Fixed grid filtering based on Viz drilldowns.|
|22968|Report Design|UI|Fixed broken HTML charts (HiCharts) in MVC deployments.|
|23045|Report Design|UI|Regression issue using popup filter. The selection of values in pop up after save causes report to display no records selected.|

# 6.10.0.1 (December 29, 2015)

##Features
|Case|Category|SubCategory|Description|
|:----|:---------------|:---------------|:---------------|
|**Architecture Update**|**Internal**|**Browser Support**|**Izenda 6.10.0.x versions have dropped support for IE8. IE9+ must be used for versions 6.10.0.1 and later. While users may still be able to access the application from IE8 new and or existing features and functionality may no longer work in these browsers. In addition, bugs or performance issues that appear only when using IE8 will not be investigated or fixed after this release.**|
|**HF:22762**|**Security**|**License Conflict**|**Hotfix patch to Izenda 6.10.0.1 to resolve a licensing conflict. (01/05/2016)**|
|FB:22008|Framework|.NET Version Update |**Updated the Izenda .NET framework to 4.0**|
|FB:13917|Data|Data Sources|Feature - Addition of support for Oracle Stored Procedures. The only stored procedures supported at this time are pipelined functions that return a table-valued object. See [[this documentation|http://docs.oracle.com/cd/B19306_01/appdev.102/b14289/dcitblfns.htm]] for more details on table-valued pipelined functions. Functionally, these work just like MSSQL stored procedures as far as Izenda is concerned. The processes for including them in VisibleDataSources, working with constraints, passing parameters as filters, etc are the same.|
|FB:21959|Data|Data Sources|Feature - Addition of MySQL Stored Procedure support. The only stored procedures supported at this time MUST be formatted a specific way for Izenda to be able to use them. The connection string must use the MULTI_STATEMENTS=1 identifier. The procedures themselves must use the following syntax: DELIMITER $$ BEGIN DROP TABLE IF EXISTS `[SprocName]_spResult`; /* Izenda-specific code */ CREATE TEMPORARY TABLE `[SprocName]_spResult` AS /* Izenda-specific code */ [The normal sproc body goes here] SELECT * FROM `[SprocName]_spResult`; /* Izenda-specific code */ END$$ DELIMITER ; where [SprocName] is the exact name of your stored procedure without the brackets. Functionally, these work just like MSSQL stored procedures as far as Izenda is concerned. The processes for including them in VisibleDataSources, working with constraints, passing parameters as filters, etc are the same. Be sure to change the DELIMITER to something other than the semicolon or else MySQL will not correctly compile the stored procedure.|
|FB:22093|API|Cache|Feature - Add support to allow 'InvalidateSchemaCache' to be executed across entire webfarm. New setting implemented, activated through a single setting. If there are two machines "server1" and "server2" in webfarm, for both servers, use the following setting in InitializeReporting:AdHocSettings.WebFarmNodesRsUrls = new string[] { "http://server1/rs.aspx", "http://server2/rs.aspx" }; When invalidate schema cache is used it works across all machines.|
|FB:19135|API|Session State|Feature - Added IDataStorage interface to allow customization of the storage mechanisms for sessions. Izenda can be configured to use a custom class that implements this interface. Sample use:// This code should be placed before any Izenda calls.AdHocContext.Storage = new CustomSessionStorage(); A code sample was created to illustrate the concepts. Code Sample available [here](http://wiki.izenda.us/Release-Notes/sessionsample.txt)|
|FB:19705|Report Design|Filters|Feature – Add Filter Alias. Prior to this new feature filters must be named the same as the column name or Field Alias set in code. Now to alias filters there are 2 options 1 – Use AdHocSettings.FilterAliases to set the alias for how column names are displayed in the filter selection drop down from code. 2 – User can change the filter name using the new Description field. This can be accessed in the Report designer from the filter tab or from the viewer by clicking the gear icon in the filter. The logic of applying aliases is the following (from the highest priority to the lowest): 1) Defined by the user alias - Description property of the filter 2) AdHocSettings.FilterAliases 3) AdHocSettings.FieldAliases 4) Column name. More information can be found [here](http://wiki.izenda.us/Guides/ReportDesign/5.0-Filters-tab)|
|FB:19756|API|Caching|Feature - Cache Interface Added. The first phase of cache changes to allow easy customization of the caching mechanism(s) used in Izenda. A new cache interface (IPermanentDataCache) was implemented for two Izenda data caches. RenderedResultsCache: the Fusion(HTML) cache DatabaseSchemaCache: used to cache the schema information. With these changes, any caching provider can be used by implementing the IPermanentDataCache interface in a custom class and configuring Izenda to use the custom class. AdHoc.Cache.DataCache.IPermanentDataCache is called "permanent" because for these caches we do not use the "storage" expiration approach. The expiration policy of all objects in the cache can be controlled by custom code. - Custom caches can be specified using AdHocContext.Caches property. Currently DataCacheRepository contain only two caches - RenderedResultsCache and DatabaseSchemaCache but we will expand this list to more different caches. Having one repository will make adding them easier in the future. Here is how you can apply custom class for DB cache: AdHocContext.Caches.DatabaseSchemaCache = new CustomDbSchemaCache(); And here is the same for Fusion cache: AdHocContext.Caches.RenderedResultsCache = new CustomHtmlCache(); Be sure to do this before all other Izenda calls. A sample Redis cache for DB Schema has been created for reference. This was implemented using Redis. Code Sample available [here](http://wiki.izenda.us/Release-Notes/CacheSample.txt)|
|FB:19815|Instant Reports|New BETA Page|Feature - The new Instant Report Designer page is being released as a *BETA* version in the Izenda 6.10.0.1 release. This beta release is made available to allow a broad user base to evaluate and give us feedback on the future of the Report Designer, but is not recommended for production use at this stage. This is not a fully supported feature however and any product defects will be noted, but not slated for immediately scheduled work.Please review documentation [here](http://wiki.izenda.us/Guides/Instant-Reports-v2-BETA)|
|FB:21663|Printing|PDF Support In Azure|Addition of new PDF engine - EVO. Provides Azure support via cloud service. There is a known issue with HTML charts and EVO printing that is scheduled for resolution in 6.10.0.2. Learn more on this configuring the cloud service [here](http://wiki.izenda.us/API/CodeSamples/PdfPrintMode#PdfPrintMode)|

##Fixes
|Case|Category|SubCategory|Description|
|:----|:---------------|:---------------|:---------------|
|FB:22308|UI|Language Support|Updated several language files with incremental changes from recent UI changes.|
|FB:21917|Report Design|Visualization|Reintroducing ArcMap Visualization to stock Visualization pool.|
|FB:22277|Scheduler|Scheduler|Removed dummy URL references within utility file and replaced with empty string. Supporting use case of offline custom scheduler. Added minor url changes to resolve javascript errors.|
|FB:21988|Report Design|Virtual Data Source|Fix VirtualDataSources to ignore TOP setting of last viewer save state.|
|FB:22660|Report Design|Localization|Fixed issue with string sources loading with empty values in localization.|
|FB:22658|Starter Kit|Instant Report|Updated RI kits for standard deployment|
|FB:22311|Report Design|Visualization|Transitions visualization labels overlapping each other in the chart. Updated and now are displaying dispersed as expected.|
|FB:22135|Report Design|Pivots|Oracle Pivots bug resulting in 'Invalid Report Definition' error due to improper string conversion, resolved.|
|FB:21874|API|Dashboards|Added angular configuration option to show dashboard without list/toolbar.|
|FB:22512|Data|Data Sources|Oracle CHAR datatype concatenating values in ReportViewer Filter panel. Fixed in \Resources\js\ReportViewerFilters.js file. Replace "if (newVal.length > 1)" with "if (newVal.length > 0)".|
|FB:22570|API|Language Support|Updated Resources files with additional Language files to be distributed. |
|FB:22078|API|Hidden Columns|Fix: HiddenColumns - apply to ALL FieldsRegex - apply only to Fields FiltersRegex - apply only to Filters|
|FB:21806|UI|Report List|Fix/Enhancement: Improved ReportList search behavior. Now when user types in report name, categories are limited to only the ones containing a similar name as search.|
|FB:21857|Starter Kit|MVC|Fix: Workaround to MVC version routing issues when publishing to IIS as a website directly from VisualStudio. Now a vanilla download should be able to be published directly with no changes.|
|FB:22168|API|Security|XSS attack security measures conflict with '&' symbol in multi-select filters. Fixed.|
|FB:22160|Data|Data Sources|Added additional support for MySQL filters with numeric/decimal field types.|
|FB:21807|Report Design|UI|Fix: Corrected erroneous 'flagging' of advanced field properties panel when new field is added.|
|FB:22347|Printing|Printing|AutoChart missing from HTML export, resolved|
|FB:21733|Printing|Printing|Fix: Support of printing/exporting an unsaved dashboard.|
|FB:21220|Report Design|Charts|Fix: Doughnut Pie-Chart wedges very thin.|
|FB:22146|Report Design|Gauge|Animation is not disabled for the Gauges visualization when printing. As a result intermittently incorrect data is displayed.|
|FB:22480|Report Design|Visualization|When using only visualizations on a dashboard, the sub-report linking doesn't honor the filters selected user clicks-through to the sub reports. Fixed|
|FB:19428|Refactor|Exporting|Fix: Refactor of export code to improve rendering performance and memory performance.|
|FB:21969|Scheduler|Scheduler|Fix: Scheduler 'embed' option. "rn=" parameter name is missed in the link URL so instead of "ReportViewer.aspx?rn=ReportName" the link uses "ReportViewer.aspx?ReportName" URL now corrected.|
|FB:22383|Report Design|Filters|Discovered place in code with the inconsistency - Filter.GetConvertedColumnValue - causes filter dates to be converted to US dates when running filters (MM/dd/yyyy)|
|FB:20529|Report Design|Forms|Removed unused code for @total used in form creation as it was not used. Also it was removed from the Smart Tags drop-down in Forms editor.|
|FB:22555|Report Design|Filters|Field Comparison Filter not working, displays message “Please enter a valid value in String format" when comparing fields. Resolved|
|FB:22214|Report Design|Visualization|Visualizations now support fields of Object type.|
|FB:22655|Report List|Report List|Regression issue found with pivot scroll bars, missing horizontal and vertical scrolling function when creating large pivots resolved.|
|FB:22637|Report Design|Forms|Removed button "Go To Online Documentation" from within the Features tab of the Settings page. This linked to old Izenda Knowledgebase that will be taken offline.|
|FB:22711|UI|DashBoard|Dashboard error "An entry with the same keys already exists" when refreshing dashboard. resolved.|
|FB:22239|Charts|Exporting|Trend and Bar charts are being compressed in HTML and PDF exporting. Resolved|
|FB:22296|Charts|Visualization|Error when printing to HTML with visualizations, overlapping of visualizations in document. Fixed|
|FB:22477|UI|Charts|Pie chart with Separator will not render in dashboard when used in report. Fixed|

# 6.9.0.7 (November 25, 2015)

|Case|Category|SubCategory|Description|
|:----|:-----------|:----------------|:---------------|
|21723|API|Saving|Categories with apostrophes in names are causing Visualizations option to disappear in the chart tab of the Report Designer. This was also causing existing reports with Visualizations contained to be unavailable. Resolved.|
|22127|Scheduler|Export|Implemented support for the following settings system wide for scheduler. AdHocSettings.SmtpPort = ; AdHocSettings.SmtpSecureConnection = true; Previously these were only used from Dashboard 2.0, now these can be used with all standard scheduled items.|
|21944|API|Fusion|Found with this Fusion Implementation below, some Visible Data Dources were not being displayed: AdHocSettings.VisibleDataSources = new string[] { "central/CustOrderHist" }; FusionDriver fd = new FusionDriver(); fd.AddConnection("central", FusionConnectionType.MsSql, @"Persist Security Info=False;XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX;"); AdHocContext.Driver = fd; Resolved and now all Visible Data Sources are showing as Data Sources.|
|21946|API|Security|Security issue where the connection string used by Izenda was recorded in logs found and fixed.|
|21964|UI|UI|Changing notice on Settings page to remove "Izenda". New warning text "The settings page is intended for trials and evaluations. For a production environment: All new settings, changes made to existing settings, and tests of settings should be implemented via the API in the global.asax - or wherever you instantiate the AdHocSettings class."|
|22271|API|UI|Added the following setting to Global file for new Reference Implementations AdHocSettings.ShowModifiedReportMessage = false; Default implementation of this setting is True, but some customers have seen issues with the setting. Turning off by default in Global only until final resolution can be made on cause of false errors. This does not affect anyone upgrading, this will only be seen if downloading new RI.|
|22276|Dashboards|Browser|Dashboards 2.0 not loading properly in IE9, fixed.|
|21661|UI|Resources|Added translations for updated RESX files to support localization in v6.9.x.x Dash2.0 UI and FORMS UI.|
|22055|API|Optimization|Fixed line of code in Driver.cs, line "asStrings.Add(asString, asStrings);" to "asStrings.Add(asString, 0);" as more definitive code reference.|
|22045|Report Design|Visualization|New Setting On Both Detail and Summary Tabs - "Hide Grid". When this is checked the grid for summary / detail will be hidden in the report. This is useful to hide the detail if you do not want to see it after building a visualization. Hiding a field will remove it from the visualization, but hiding the grid will remove the entire detail / summary report part. Detail/Summary will still appear in Dashboard as available report part, but will not display if selected.|
|22001|API|Security|When AdHocSettings.ShowDesignLinks = false, all buttons and links to the report designer should be hidden from the user. However, in Dash.aspx, the icon still exists and still links to ReportDesigner.aspx when a tile is reversed to show settings. Fixed|
|22011|API|Optimization|Incorrect spelling fixed in Class Filter, method Clone, line filter.column = filter.column;|
|18173|Report Design|Charts|For Bar Chart under "Charts" sort is not working for calculated "Value" field, resolved.|
|18837|API|Logging|Expanded tool logging hooks to cover more of core functionality. 1) Enum-based logging commands; 2) Logging areas system implemented - turn on/off INFO logging for some particular areas. Example: If you want to know the exact values of the settings - don't wan't to see heavy DB logs: AdHocContext.LogActiveAreas = new List() { LogArea.Settings }; Diagnose an issue on the Dash 2.0 page: AdHocContext.LogActiveAreas = new List() { LogArea.WebService, LogArea.ResponseServer };|
|21515|API|PostgreSQL|Support for PostgreSQL constraints in the database added. Izenda will find the Foreign key relationships existing in the database and allow the user to select these tables for reporting in simple join mode of the designer and in Instant Reports.|
|22195|API|Export|When exporting any report to, excel, or open report which has no thumbnail yet, the importCSS method puts a excessive data to logs. Altered amount of data logged for effective troubleshooting with log data.|
|21629|API|Data Sources|Implemented the ability to give Virtual Data Sources a category in Data Source Categories setting. Sample Implementation below: AdHocSettings.DataSourceCategories["Virtual"] = new string[] { "VDS.*" }; This would list all Virtual Data Sources in a category called Virtual (for both Report Designer Data Sources Tab and Instant Reports)|
|21570|Report Viewer|Filter|If user adds several filters and selects the same field more than once then the next filters copies the first instance for operator and data. Fixed|
|21507|Dashboards|UI|Removal of small gap on right side of dashboard tiles. Width of HTML was set to 98% now 100% in table style.|
|21739|API|Resources|Updated of RESX localization files for support of new UI elements.|
|21714|Dashboards|Export|While printing Forms from Dashboard the print appeared transparent. Resolve and form now prints as displayed on screen.|
|19866|Dashboards|Resources|New Dashboard page is now supported using localization for translation to supported languages.|
|22082|API|Export|Refactored Bulk CSV for optimized output times and less memory usage. 1 million record output to CSV file ranging in 2-3 minutes.|
|21141|Report Design|Export|In Report Designer Scheduler the year drop down was showing prior years. Now only displays future years for scheduling.|
|21530|Report Design|Pagination|Fixed inconsistency between Report Preview and Report Viewer when using pagination. When paginating a report with both Summary and Detail, only Summary would display with no additional paging in Report Viewer. Correct behavior was seen in Report Preview.|
|21322|API|Data Sources|Issue found when using tables with "." in name. Constraints were not loading from the database to allow users to join tables in simple mode of Report Designer and Instant Reports. Resolved.|
|22049|API|Optimization|Typo fixed in Izenda code causing the following error when using AdHocSettings.SavedReportsTable with MySQL driver "Unknown column '_global_' in 'where clause'"|
|21291|API|Optimization|Fixed SQL generation error/crash when using AdHocSettings.StrictANSIOuterJoin = false;|
|22025|Report Design|Filters|Pop Up filter not responding in Report Designer (working as expected in Report Viewer) - fixed|
|21364|Scheduler|Optimization|Fixed timezone support issue in ScheduleTimeZone.|
|21496|API|Resources|Adding localization support for: Czech, Danish, Greek, Estonian, Finnish, Hebrew, Croatian, Hungarian, Icelandic, Lithuanian, Latvian, Macedonian, Norwegian, Polish, Romanian, Slovenian, Serbian, Swedish, Turkish & Ukranian.|
|21440|API|Export|Java Script name was missing while exported to PDF or trying to Print HTML|
|22009|API|Export|Fix implemented for Bulk CSV exports. Receiving error message "Bulk CSV export is called against odata(or other kind of non-direct) fusion connection which is not supported" when not using Fusion connection.|
|21939|Report Design|Forms|@Subtotal used in Form reports causing report not to load. Fixed; now loading/formatting properly.|
|19163|Dashboards|UI|Dashboard ignores color selections on style tab of report designer, corrected.|
|21784|Report Design|Charts|On Charts Tab in Report Designer, the 3rd column drop downs have no label to indicate the drop down is for Format. Resolved.|
|21801|Report Design|Export|Issue found when exporting gauges to PDF that were consuming extra memory and exports were not completing. Resolved issue with gauge and now exporting properly.|
|21804|API|Optimization|Added support for the following settings in the Report Viewer and Dashboard 2.0. Settings to check: - AdHocSettings.AllowInvalidCharacters - AdHocSettings.StripInvalidCharacters Working normally in: - Report Designer - Old Dashboard Designer - Old Report Viewer More info can be found on these settings here in the Izenda wiki http://wiki.izenda.us/API/AdHocSettings|
|21668|UI|Optimization|When creating a category with an apostrophe in the title is is displayed incorrectly. The apostrophe is not being escaped properly and the category is displayed in the category drop down as a "%27". Resolved. Routines to pull category lists unified to avoid inconsistencies between Designer and Viewer.|
|21878|Report Viewer|Filters|When using "equals field" filter operator filters are not appearing in the report viewer. Resolved.|
|21380|Dashboards|Export|When exporting Dashboards (v2) to PDF, the exported version does not follow the same order as it appears on screen. Fixed|
|21284|API|Optimization|Fixed AdHocSettings.ShowHtmlAsCode = true; not being respected.|
|21758|Report Design|Visualization|Fixes to 'Tree Chart' Visualization logic (aggregation and value listing).|
|21438|API|Filters|Server side validation added for filter values. Validation added for the following field types: - Date/Time (both mm/dd and dd/mm are validated based on what AdHocSettings.Culture is used. - Numeric - Boolean - GUID User will be given a message stating that Invalid value entered in filters and an example of proper input. Example: Invalid value entered in filters. Field: isnew Value: hhhh Please enter a valid value in Boolean(1-TRUE/0-FALSE) format.|
|21503|Report Design|Optimization|Fixed rendering errors Field-Value VG type caused by commas in the [Field Description] field values.|
|21280|API|Optimization|Made Wildcard constraint syntax compatible with BulkConstraints setting. (EX:'*.ID' '*.TableID')|
|21826|API|Resources|Fixed internal mechanism to refresh localization. This mechanism conflicts with the request-wide settings cache, causing custom aggregate functions to disappear.|
|21579|UI|Browser|Using Internet Explorer, when adding a new filter or changing an existing filter operator the advanced filter options pop up will not close when clicking the "OK" button. This fix can be implemented without a new DLL using the following code sample: Add the lines below to the beginning of Resources\js\ReportViewerFilters.js file String.prototype.endsWith = function (suffix) { return this.indexOf(suffix, this.length - suffix.length) !== -1; };|
|22295|Report Design|Pagination|Paging when using a summary was fixed in Case 21530, additional issues found when using MySQL and PostgreSQL. Resolved.|
|21576|Report Design|Visualization|Report with Heatmaps break subtotals - fixed.|
|21549|Report Design|Visualization|Fixed 'Sunburst' Visualization logic surrounding breadcrumbs and 'level' navigation.|
|21625|API|Optimization|Fixed hard-coded relative paths to be more compatible with various integration methods & use-cases.|
|21656|Report Design|Optimization|When using ODATA connection number of results drop down was not properly working to increase or decrease number of results. Resolved.|
|22248|Report Design|Gauge|Fixed 'broken report' bug when 'Gauge' format is used.|
|22251|Report Design|PostgreSQL|Fixed Postgres support for 'Crossfilter' Visualization.|
|22253|Report Design|Visualization|Fixed 'Time Bubble' help message: "This chart has been set up incorrectly (see Help)."|
|21798|Report Design|Gauge|Implemented symbolic logic for Gauge support of large numbers. Example - x=0-999 xK = x,000 xM = x,000,000 xB = x,000,000,000 xT = x,000,000,000,000|
|22304|Report Design|Resources|JS Error appear in report when using Bold/Italic on field settings that are Visually Grouped and Sorted|
|21706|Report Design|Pivots|Intial issue was " User was getting Pivots column limit error". During retesting found issue with "Calculated cell values" i.e. default description was displayed and unable to delete it|
|22179|Dashboards|Filters|Fixed broken filter cascading in Dashboards 1.0.|
|21727|Report Design|Pivots|Using the same field more than once in pivot resulting in system column alias being displayed in the report instead of the actual column name in some pivot columns. Fixed|
|19444|Report Design|UI|"Collapse/Expand" buttons on Visual Groups to show that the group can be hidden and expanded. This functionality already existed in the product, but was not clear in the UI that it was available. The new arrow buttons will indicate to the user that they can collapse the group.|
|21196|Report Design|Forms|Fixed 'residual HTML' left by FORMS UI when form is deleted &/or cancelled.|
|21346|Report Design|UI|Behavior fixed where total box is checked on all fields even though we only added it for one field.|
|21473|API|Data Sources|Issue found with Table Names containing "&". Fields would not load in designer drop downs and report would not build. Resolved.|
|21535|UI|Gauge|Though gauge tab has percentage - gauge display does not change (says 0-1 instead of 0-100 for % selection)|
|21768|Dashboards|UI|Chart Title showing up in Dashboard and appearing as Chart@"ReportName". Resolved|
|21903|Dashboards|Browser|In the Dashboard URL, if the user deletes anything after "#", user is navigated to blank page.|
|22079|Dashboards|Visualization|Data was not being properly filtered properly when using a Visualization in Dashboard 1.0, but working properly in Dashboard 2.0, fixed.|
|21501|UI|Browser|I found that the error is caused by a bug in IE11. The error is in the wrong determination of the number of rows in the table. Fixed by changing method of working with rows table.|
|22280|Dashboards|Optimization|Fixed spelling issue in dashboard - on reverse side of tile the hover text shows "Select a preport part to add" fixed to state "Select a report part to add".|
|21906|API|Filters|When setting up ProcessEqualsSelectList to populate a drop down filter, and using auto complete filter operator (@autoCompleteVal), the autocompleted filter value is not updated in the filter collection. This is used in the where clause of any subsequent filters when implementing cascading filter functionality. This value is now retained and can be used for cascading.|
|21707|API|Data Sources|Database objects with Period "." in Column name displaying literal string "_INTERALDOTCHAR_" in column name in Izenda. This was due to internal literal string replacement in code. Resolved.|
|21791|Report Design|Export|Implemented new method of rendering dates to excel, which solves a lot of problems/cases like given one with dates formatting in Excel. Previously, when exporting to Excel, Izenda converted datetime values to string (text) of necessary format, and wrote those string values to html file with a mark for Excel that they are dates in some string format. Now when exporting to Excel, it writes to HTML the native for excel numeric value of date, and description of format in which this date should be shown.|
|21862|UI|Optimization|CSS files were reloading from iis server versus from local cache causing lag time. Change implemented to reduce time to load by ensuring the css is loading from cache when available.|
|20936|UI|UI|"Limit Outputs to CSV" checkbox in Misc tab of the report designer has been deprecated in the 6.9.0.7 release. It will no longer show on the UI.|
|21524|Report Design|Forms|When Subreport created using Form designer (with Filter) is embedded with parent report. Subreport Filter is missing|
|21929|Dashboards|Security|Fixed shared with locks on new dashboards to work the same as reports. Izenda guidelines Full Access: Dashboard is available to the user to view, modify, and save changes to the report. Note that owner user(UserName property of the ReportSet) will not be changed on saving, i.e. the original owner(creator) of the report will stay the same. Read Only Dashboard is available to the user to view, user can modify existing filters' values. Also user can modify(design) the Dashboard but cannot save it, however user could Save As a new Dashboard. View Only: Dashboard is available to the user to view, but not to modify in any way or save changes to the report. Locked: Dashboard is available to the user to view, and user can modify existing filters' values None: Dashboard is unavailable to (hidden from) the user.|
|21556|UI|Data Sources|Izenda removes underscores contained in column names in Field Descriptions. This behavior was inconsistent in the Report Designer and the Instant Report Designer. Now, underscores are removed in both places.|
|21779|UI|Expressions|Added "Current Date" (Today) option to the DefaultDate setting. GETDATE() can be used in the expression text boxes.|
|20980|API|Filter|Fixed error in Report Viewer, when editing the filter operators list, if equals is removed it was still added as default filter operator when new filter is selected in report viewer. Now the first remaining filter operator available will be used as the default if equal operator is removed.|
|21527|UI|Filter|Corrected Stored Procedure Parameter use as Filters. User cannot add any parameter more than one time in the Report Viewer as this will give an error "Procedure or function ##SP_NAME## has too many arguments specified".|
|21456|Report Viewer|Filter|Long field names overlap the filter buttons. This has been corrected by truncating the field name using (...) to ensure buttons are clearly available to the end user.|
|21119|UI|Data Sources|Fixed Stored Procedure parameter support of European date format in equals calendar and equals filter options. Before fix when formatting date in European format (using equals or equals calendar) the report would return no results as date format was not properly converting.|
|22040|Report Design|Auto Chart|When using a stored procedure to create an AutoChart the chart was not properly exporting to excel after save. Now chart will export before or after saving the report.|
|22102|Report Design|Auto Chart|When exporting an auto chart that uses a link (links are added via the URL Link field of the advanced field options in the Report Designer), the chart appears correct but the export would only show one value as slice. This has been corrected so HTML/WORD/EXCEL export as shown on screen.|
|21717|Scheduler|Optimization|New Setting added for offline mode of Scheduler to initialize Visualization folder. AdHocSettings.VisualizationsFolder = @"Add Folder Path Here"; Please Note this MUST BE SET PRIOR TO LICENSE KEY|
|21814|Report Design|Auto Chart|Fixed long strings from overlapping chart in AutoChart. Long Stings will be truncated using (...) to prevent them from overlaying the chart|
|21866|Report Design|Auto Chart|When exporting an auto chart that uses a link (links are added via the URL Link field of the advanced field options in the Report Designer), the chart appears correct but the export would only show one value as slice. This has been corrected and PDF exports as shown on screen.|
|21689|Report Viewer|Forms|When a subreport which is created using "Form Designer" for image field is used, images are not displayed in the parent report.|
|21891|API|Data Sources|This fix ensures that names of temporary tables in generated sql queries will not have database name/schema nodes that were causing issues with some SQL versions when using Stored Procedures.|
|21846|API|Export|This interface is used to apply specific formats to excel exports when custom formatters are used in Izenda. Add the following to the formatter class: [Serializable] public class ProportionFormatter : IFormatter, IExcelFormatter { public string GetExcelCellClass { get { return "xls-"; } } ... The following formats are supported xls-text xls-percent xls-date xls-time|


# 6.9.0.6 (October 21, 2015)

##Features
|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|19596|Feature|UI|Responsive Grid Control added to Style tab for changing on a report level basis|
|20203|Feature|UI|Added user-friendly invalid date error message for date based filters|
|20292|Feature|Filters|Added New option to filters tab for user to select if each filter is required |
|20726|Feature|Export|Send Deshboard as a Link will now use client side email function allowing user to add message to email|
|20733|Feature|Export|Added option on style tab to remove headers for CSV exports|
|20761|Feature|Fusion|Implemented ability to add custom Fusion Connections|
|20948|Feature|Auto Chart|Implemented change to always show Denominator in the Auto Gauge Round Style.|
|20974|Feature|Visualization|Introduced setting for visualization base path|
|21260|Feature|Fusion|Implementation of stored procedures joined from different fusion connections|
|21311|Feature|UI|New Setting to disable Izenda  automatic divide by zero handling in both regular and subtotal expressions AdHocSettings.UseSafeDivisionInExpressions = false;|
|21317|Feature|Filters|AdHocSettings.AutoOrForRepeatFilters setting implemented|
|21343|Feature|Filters|Improved style for popup filter on Dashboard 2 - uses modal|
|21430|Feature|Export|Support Landscape orientation inPhantom PDF export implemented|
|21450|Feature|UI|Implemented localization of Forms Designer  - English language is complete, all other languages will be released with 6.9.0.7|
|21519|Feature|UI|Updated Record Count Slider for Dashboard 2 - added increments to slider|
|21553|Feature|Optimization|Refactored D3.js for ease of client customizations - [Learn How Here](http://wiki.izenda.us/FAQ/How-Do-I-Customize-A-Visualization)|

##Fixes
|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|19328|Report Design|Filters|Updated formats for filters viewable in report|
|20246|Report Design|Forms|Implemented new spellchecker in forms designer|
|20757|Instant Reports|UI|Corrected borders on Instant Reports|
|20863|Report Design|Charts|Dundas Map https internal resources loading image error fixed|
|20864|Report Design|Forms|Fixed overlay style of Forms Designer in Report Designer|
|20952|Report Design|UI|Implemented target/Max behavior in Round Style fixed|
|20961|Report Design|UI|Fixed visual notification flag on advanced field options of pivoted columns to show changes|
|21029|Report Design|Visualization|Fixed Visualizations - Fields hidden in grid should not render in visualizations |
|21069|Report Design|Visualization|Fixed Visualization subreport popup|
|21090|Report Viewer|Export|Analysis Grid print to HTML as expanded error resolved|
|21093|API|Optimization|Altered Setting AdHocSettings.AllowVirtualDataSources to show all when enabled (Without using Visible Data Sources)|
|21148|Report Design|Charts|Fixed Combo Chart xAxis - Date values not respected|
|21149|UI|Pivots|Subtotal display (NULL) for Non Interger Date Grouping - fixed|
|21179|Dashboards|Filters|Dashboard Filter issue resolved using table/column name without respect to UseColumnNameForDashboardCommonFilters setting|
|21219|Report Viewer|Charts|Fixed Pie Chart Seperator Lables not appearing|
|21224|API|Optimization|Added user-friendly message when fields are not sorted in Transitions Visualization|
|21248|UI|Filters|Format dates using AdHocSettings.Culture in the Equals(Select)-like filters fixed|
|21249|UI|Filters|Hardcoded datetime string patterns replaced with formats specified in AdHocSettings.Culture|
|21257|API|Fields|Fixed Boolean filter operators not showing in filter options|
|21273|Report Design|Pivots|Fixed error associated with Advanced Field Options on Pivot Columns|
|21277|Report Design|Filters|Filters in Designer when additional constraints are used - empty results issue fixed.|
|21287|API|Analysis Grid|Show error message when invalid Analysis Grid is constructed|
|21293|Report Design|Export|Properly split table cells in reports separator in the Excel output of footer text|
|21310|Report Design|Optimization|Fixed funnel highchart size adjusting from div generation|
|21319|UI|Visualization|Use stand-alone fonts resources in visualizations |
|21321|Report Design|Expressions|Properly process FieldAliases (Set in Field Alias AdHocSetting) in the Expressions|
|21371|Report Design|Export|Fixed relative images links in the headers and footers when printing in PDF EO.PEF mode|
|21381|Report Design|Export|Fixed Chart cropping with PDF exports using EO.PDF mode|
|21412|Report Design|Optimization|Fixed missing data for last column of reports using VG Hierarchy when one field is hidden|
|21453|Report Design|Visualization|Optimized scrollSize method for visualization popup subreports.|
|21458|Dashboards|Optimization|Optimized Dashboard to reduce long-running script errors in some browsers |
|21459|Report Design|Saving|Fixed duplicating html part of report after saving.|
|21488|Dashboards|UI|Removed scrollbars in dashboard tiles where not needed|
|21489|API|Optimization|Fixed misspelling in JavaScript|
|21491|Report Design|UI|Fixed Analysis Grid not respecting all cell highlighting |
|21506|API|Optimization|Fixed License for Language Feature - English file availablity |
|21520|Dashboards|Visualization|Fixed errors in exporting Visualizations in Dashboard2 for PEF / Excel|
|21526|API|Optimization|Fixed wrong values passed to userConstraintsActions|
|21558|Report Design|Optimization|Drilldrown filters missing parameter fixed|
|21559|Dashboards|Charts|Maps not rendering properly in Dashboard 2 - fixed|
|21560|API|UI|Properly handle div/0 in Subtotals when Expression is used instead of arithmetic |
|21577|API|Optimization|Advanced Settings lost when new Data Source added to report - fixed|
|21589|API|Optimization|Fixed Subotal calculations when using Timezone offset feature|
|21602|API|Optimization|Apply date as an interval feature to the Date filters when Stored Procedure is used as a data source|
|21626|API|Optimization|Fixed handling Field data type according to the applied Function|
|21628|Dashboards|UI|Fixed dashboard "folder" menu in toolbar for small resolutions.|
|21647|Dashboards|UI|Apply Custom CSS from the parent report to the tile in the Dashboard|
|21683|API|Optimization|Fixed HiddenCategories when using DatabaseAdHocConfig mode for saving reports|
|21685|API|UI|Return NULL for NULL-valued dates when TimeZoneOffset is applied|
|21734|Dashboards|UI|Fixed scrollbars for charts in dashboard2|
|21740|Dashboards|Optimization|Regression Fix for detail report parts not responding  in dashboard |
|21744|API|Saving|Fixed Report XML truncating when saving reports using DatabaseAdHocConfig|
|21745|Report Design|Forms|Fixed saving issue with reports containing Forms|
|21794|Dashboards|Optimization|Regression fix for using HTML/Visualization in dashboard|
|21800|Report Design|Export|Fixed bulkcsvexport error when using fusion driver|
|21840|Report Design|Auto Chart|Regression fix for AutoChart not displaying properly |


# 6.9.0.5 (September 22, 2015)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|18056|Report Design|Optimization|DataSourceDropDownTimeout - Obsolete |
|19284|Report Design|Optimization|Oracle - Average(Days Old) inconsistent data types causing issue - resolved|
|19401|Report Viewer|Export|Excel Exports will respect <br> tags on export for wrapping large large text lines|
|20002|API|Compatibility|Language Packs - Storage/Distribution updated for use in standard kit|
|20051|Feature||New Setting for use in Extended Functions and Expressions|
|20131|Feature||FEATURE  - Update to Forms Designer adding Field/Column/Smart Tag and SubReport Dropdowns for Ease of Use in creating forms|
|20164|UI|Optimization|Gradient header removed still being displayed - resolved|
|20173|UI|Optimization|Random Color Palette Changes for visualizations resolved|
|20219|Feature||FEATURE - "Add Repeater" button in forms implemented |
|20280|Feature||FEATURE - Add Calc Fields for use in Map Charts|
|20333|API|Compatibility|License key locks - standardized to remove features which should not be locked|
|20473|API|Compatibility|6.9.0.2 not working on azure with Redis session state provider - resolved|
|20479|Report Design|Visualization|World Tour Visualization - resolved issue with Country names in mixed cases|
|20509|API|Export|Resolved issues with "copy these files from filesystem to database" on settings page|
|20548|Report Viewer|Export|PhantomJS missing print features added - page break after visual groups / pivot columns per exported page - resolved|
|20594|UI|Optimization|Long String text not being displayed when using Responsive Grid - resolved|
|20596|Report Design|UI|Cell highlight not respecting VG field in Analysis Grid - resolved|
|20613|API|Optimization|Hiding buttons in the ReportDesigner breaks button in ReportViewer - resolved|
|20636|Report Design|Filters|Filter display error showing schema and table resolved|
|20678|API|Optimization|AdhocSettings.HiddenCategores not working properly - resolved|
|20692|Report Viewer|Export|Issue resolved using BulkCSV and export from Stored Procs|
|20711|Dashboards|UI|Pie Charts Sizing Issue - now autosizing for dashboard|
|20732|API|Compatibility|Rounding issue in Oracle Driver resolved - Added Custom driver for Oracle that can be implemented using 6.9.0.5 and execute this code after AdHocSettings.OracleConnectionString is specified|
|20749|API|Compatibility|Internet Explorer issue with extra padding in dashboard cells resolved|
|20760|UI|Optimization|Tables Misspelled in Error  message - resolved|
|20765|API|Optimization|AdHocSettings.ChartingEngine now set to ChartingEngine.HtmlChart by default|
|20777|Report Design|Optimization|Report Header/Footer with [date] or [time] fails to render - resolved|
|20781|Dashboards|UI|UI Change - Dashboard name field showing "report name"|
|20784|UI|Pivots|Pivot headers for collapsed Visual Groups sections still render when using Visualization - resolved|
|20785|Report Design|Visualization|Visualizations on Pivoted Reports Hover Over displays incorrect formats|
|20814|Report Design|Charts|Chart reports not working propertly with HTTPS |
|20821|Report Design|Filters|Drilldown filter - Doesn't Equal causing subresports to display everything other than item in drilldown key|
|20857|UI|Filters|String Characters causing issues when used in Filter Values - resolved|
|20861|API|Optimization|"Data is too heavily clustered" dialog appears even when show value labels is not selected in Report Designer Preview|
|20889|API|Data Sources|Time Zone Offset for date/time stamp - Offset is from UTC Time NEW SETTING AdHocSettings.ReportTimeStampTimeZoneOffset = (numeric value);|
|20932|Report Viewer|UI|Filter listing data types in fields resolved|
|20950|UI|Filters|Popup Filter In SubReport Not Working|
|20962|Report Viewer|Export|Print Function corrected when using embedded subreport in form|
|20983|Scheduler|Charts|Charts/Graphs not appearing in email - resolved|
|20990|API|Optimization|Oracle Database Timeout - Deprecated |
|21015|Report Design|Charts|Changing Subtotal Function on Chart Skews Charts |
|21036|API|Optimization|Update report list issue causing infinate loop with AllowVirtualDataSource|
|21037|API|Compatibility|Resolved Permissions issue with GaugeRadial.png |
|21039|API|Optimization|Fixed issue with inconsistent code around table/column name when using report set|
|21046|Dashboards|UI|Problem with visualization's tooltip on Dashboards v2|
|21056|Report Design|Optimization|Getting error Grouping by the same datetime more than once in different ways |
|21058|Scheduler|Charts|Charts/Graphs not appearing in email |
|21059|Report Design|Forms|Empty Format options displayed in Forms editor|
|21097|Dashboards|Optimization|Using of same report parts in one dashboard should not be allowed|
|21098|Dashboards|Optimization|Refresh button: refreshing dashboard itself, not content of the tiles |
|21104|Report Design|Pivots|Pivot Value Functions for min/max, count/distinct for text and number field types|
|21125|API|Optimization|Add fields using schema name not  alias names  -resolved|
|21131|UI|Optimization|Sorting columns no longer in the right order - resolved|
|21134|UI|Optimization|"Show Page Number" and "Show Date and Time" options in Style Tab not working with Header items|
|21140|Report Design|Filters|Filter disappears when user choose "Isn't Between" as filter condition |
|21147|Report Design|Auto Chart|Auto Charts Using Count of incorrect item|
|21157|Dashboards|Visualization|Incorrect size of visualization on Dashboards v2 - resolved|
|21158|UI|Optimization|Scrollbars do not appear after expanding window to larger size |
|21159|Dashboards|UI|Dashboards v2 request server with incorrect height of tile - resolved|
|21160|Dashboards|Visualization|Incorrect Sunburst size on first load inside new Dashboards v2 resolved|
|21173|Report Design|Pagination|Corrected differences in resources|
|21174|API|Optimization|Duplicate VisibleDataSources causing Key error - resolved|
|21183|Dashboards|Visualization|Visualization errors before refresh in Dashboards v2|
|21185|API|Optimization|Category / Report Name Check - should not echo back unfound report name or category |
|21187|API|Gauge|Cannot run Reports or Report Parts containing Gauges using sort |
|21191|API|Optimization|Unable to read beyond the end of stream error using ODATA - resolved|
|21206|Report Design|Optimization|Error - length cannot be less than zero when using sub report|
|21210|UI|Visualization|Visualization automatic display of string text error - resolved|
|21212|API|Compatibility|PostgreSQL Fusion Connections cause error resolved|
|21215|API|Compatibility|Virtual data sources not working with PostgreSQL  |
|21221|UI|Charts|Changes to stacked horizontal bar chart - stacked propertey being ignored for horizontal chart|
|21226|Report Design|Pivots|Pivot Update to allow for header and column to be used as params for drilldown|
|21227|Scheduler|Optimization|WCF Scheduler Issue - Fix implemented when Izenda is executed in a WCF service|
|21256|Dashboards|Forms|Forms not working in Dashboard - each form must be reivewed in dashbaord for verification|
|21313|API|Visualization|Curly Braces causing issues in string when used in Visualization - resolved|
|21316|API|Optimization|URL Drilldown Capability of Header Link - ""{column}"" feature should work as we expect, for example you can use a custom URL like this - Page.aspx?id={0}&value={column}|
|21323|API|Compatibility|Issue in Designer while using Izenda as IFRAME|
|21347|Report Design|Visualization|World tour Failing on mixed case Country names|
|21370|Report Viewer|Export|Save issue in branch for 6.9.0.5|
|21374|API|Export|Impossibility to switch to phantomjs pdf generator - reinitializes pdf was removed from ShowPDFButton setter in error|
|21375|API|Auto Chart|Auto Chart crashes on Record Count metric |
|21390|Report Design|UI|Reports order in Designer from Style Tab incorrect|
|21391|UI|Auto Chart|Problem with expand panel on Auto Chart|
|21392|API|Filters|replaceAll function undefined error in JS causing filter misfunction|
|21415|API|Charts|Unable to export Pie Charts using seperator to excel|
|21445|UI|Visualization|Visualization Breadcrumbs not working in Firefox - resolved|
|21449|UI|Visualization|Visualizations not displayed when adding subtotals - resolved|

# 6.9.0.4 (August 24, 2015)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|13518|Report Design|Pivots|Pivot Reports Now Available to be Saved as Datasources|
|15076|UI|Optimization|Improve "expand" border concept for popup|
|18540|API|Optimization|Properly handle inputs where HTML input is allowed|
|18555|API|Optimization|English Resx File Missing Translation|
|18717|API|Optimization|Update to Driver Performance|
|19492|API|Filters|Filters for Report Parts & Exports Fix|
|19876|API|Responsive Grid|responsive grid fails with embedded subreport fixed|
|19950|UI|Optimization|Update to Izenda License Text|
|20054|API|Data Sources|Optimization to getting schema of stored procedures|
|20130|UI|Optimization|CSS for dropdowns text color fixed|
|20132|Dashboards|Visualization|Issue with Dashboards v2 tiles and AutoCharts with Drilldowns resolved|
|20134|UI|Dashboards|Color overlay issue on slides in presentation mode in Dashboards v2 resolved|
|20175|Dashboards|UI|Dashboards v2 Thumbnails Don't Generate resolved (outside of Azure PaaS)|
|20180|Dashboards|UI|Resovled Dashboard 2.0 Toolbar issue with Min/Max Screen Resolution|
|20184|API|Optimization|Multiple instances of Izenda in one browser - Multiple current reportset available|
|20195|Report Design|UI|Remove Join Alias box if only one table is used |
|20199|Report Design|UI|Properly handle data source aliases in multi-conditional joins|
|20217|UI|Analysis Grid|Problems with the Analysis Grid style - Move VG fields to the top of the list automatically and show warning message when issues found|
|20223|Report Design|Expressions|Expression type on advanced options does not set function list - Properly update Functions list when Expression type is changed|
|20224|Report Design|Expressions|Apply Expression type during the Arithmetic SQL construction|
|20228|Report Design|Expressions|Apply Expression type when calculating subtotals|
|20239|Report Design|Visualization|Do not hide grouped header of the grid if Visualization is attached to this grid|
|20252|Report Design|UI|AutoCharts Subtotals Don't Appear After DrillDown - fixed|
|20262|API|Optimization|TrimSqlFilterInput setting implemented -  AdHocSettings.TrimSqlFilterInput = false and leading spaces will be kept to make filters work properly for db columns containing leading spaces which must be preserved|
|20282|Report Design|Export|Fixed drilldown filter loss in export|
|20297|Report Design|Export|Fixed applying AllowClientSorting settings when using Scheduler.|
|20313|Report Design|Export|XXS Issues in Report Designer - Added Setting to Avoid XSS issues in Designer AdHocSettings.ApplyAntiXssToReportOutput = True. Please note this could cause any existing HTML customizations on reports to not render. Especially with use of URL links in report designer.|
|20316|Report Design|Optimization|New Header Formatting Options added to Make Headers Bold or Italicized located on the Style Tab|
|20321|Dashboards|Optimization|Removed extrawhitespace when datasource tab is hidden|
|20322|Report Design|Optimization|Properly handle Footer justification when AdHocSettings.ShowJustification is false|
|20323|API|Optimization|Fixed icons not appearing in IE8 in reportList on hover & JS Errors|
|20377|UI|Optimization|Do not drop join condition selection when data source is added to the join above specified data source|
|20379|UI|Optimization|Settings page Page width corrected|
|20400|API|Optimization|Report List SQL Calls Optimized|
|20421|API|Data Sources|Changed conditions of the definition of a simple stored procedure.|
|20428|Dashboards|UI|Changing background option in new dashboards in IE fixed|
|20464|UI|Optimization|MVC Settings page missing images resolved|
|20475|API|Optimization|Make Utility.GetMd5Sum public|
|20492|Report Design|Charts|Fixed displaing horizontal labels of bar chart (HighChart).|
|20494|Report Design|UI|Hide Field Not Respected When using Invert on Summary - Resolved|
|20501|Report Viewer|UI|Fix fields in UI when arithmetic is used.|
|20513|Report Design|Optimization|XSS Issues Resolved|
|20529|Report Design|Forms|Fixed subtotals in forms|
|20542|Report Design|Optimization|XSS Issues Resolved|
|20543|API|Security|Security Scan Cryptographic Issues - Remove obsolete feature (Version checker) causing issue. |
|20544|API|Security|Security Scan Directory Traversal issue noted in static scan due to obsolete feature (RDL export) resolved|
|20545|API|Security|Security Scan Information Leakage - XXE issue found in static scan. False positive result, but code changes made to avoid findings in the future.|
|20624|Report Design|Optimization|Resolved AutoGroup Feature Not working in Designer|
|20630|Dashboards|Optimization|Dashboard event system improvement. |
|20689|API|Dashboards|MVC4r2 reference Install and new dashboards|
|20697|Instant Reports|Filter|Filter condition (Equals Popup) doesn't work on Instant Reports - Resolved|
|20708|Dashboards|Visualization|Fixed autochart broken in dashboard if reportset is created on IR page|
|20717|API|Visualization|Handling of server errors in Visualizations|
|20718|Dashboards|Filters|Fixed Applying Filters in Dashboard 2.0|
|20720|UI|Optimization|Added Warning Text to Settings Page|
|20745|Report Design|Fusion|Fusion Driver + Stored Procedures with constraints issue resolved|
|20754|Report Design|UI|Fix inconsistent behavior when Column property of the Fields is changed automatically|
|20756|Instant Reports|Optimization|Fix error on the Instant Report page when Uncategorized category is absent|
|20774|Report Design|Forms|Fixed Issue with Forms Editor in Google Chrome browser|
|20780|Report Design|Data Sources|Fixed stored  procedures designation to datasources categories|
|20795|Report Design|Pagination|Properly handle pagination in reports with Form|
|20853|UI|Optimization|Adjust doughnut Pie Chart style thickness|
|20867|API|Optimization|MVC4r2 namespace change in RI for MVC5r3 branch |
|20882|Report Design|Optimization|Izenda Vulnerability Issue - XSS issue resolved|
|20908|Dashboards|UI|Fixed wrong "detail", "summary" and "chart" tiles.|
|20941|Instant Reports|Optimization|Instant report filter Table Names Corrected|
|20957|API|Optimization|Possible null reference exception in Utility.UnifyReportName method|
|20978|Report Design|Forms|Forms Editor reference error resolved|
|21031|API|Optimization|Fix in field.GetSql |
|21045|API|Optimization|Resource files desynchronized in FromDLL folder and in DLL |
|21050|UI|Optimization|Fixed scrolling of container inside tooltip|
|21105|Dashboards|Expressions|Subtotals in Dashboards Not Appearing correctly resolved|
|21120|Report Viewer|Export|Export Failure for back of dashboard tile resolved|

# 6.9.0.3 (July 27, 2015)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|15400|Dashboards|Optimization|Added automatic dashboard tile update when source report was updated|
|18324|API|Optimization|Changed report.ParentReportSet to report._parentReportSet in SQL generation routine, movedparent |
|18333|API|Optimization|SetValueInternal set to internal|
|18769|API|Optimization|Fixed possible exception when existing constraints collection has duplicates|
|19042|Report Viewer|Export|Print Page Headers not Loading for All Pages |
|19149|API|Optimization|Text with bracket issue - escape square brackets in names with a '\'.|
|19171|API|Visualization|Removing insufficient width error from autochart|
|19427|Report Design|Optimization|Fixed Formats for Fields Selected from Quik Add in Report Designer|
|19438|API|Optimization|Duplicate Resources Fixed|
|19442|Report Design|Gauge|Fixed "Radial 2" Gauge style rendering when value hits the extreme|
|19477|API|Save| Prevent "report has been modified" warning false alarms|
|19500|API|Optimization|View Results Drop down Not Updating - Made GetNTopSql case-insensitive|
|19522|Report Design|Optimization|Fixed duplicating columns of stored procedures via OData connection|
|19557|Report Design|Export|Fixed Sub Report Data not being Exported into CSV or XML files|
|19568|UI|Optimization|MVC4R2 Kit images fixed with Starter Kit|
|19638|API|Optimization|Removed ETL Code not used due to security Concern|
|19653|Report Design|Charts|Fixed labels in barchart when using object type labels.|
|19690|API|Optimization|Possible inconsistency in JoinedTable class|
|19731|Dashboards|Filter|Filters are now displayed on dashboard before saving |
|19745|Scheduler|Optimization|Added word support to scheduler form|
|19787|API|Optimization|Full support of UseTablesFromSchemaOnly and DefaultSchemaName implemented for Oracle connections|
|19820|Report Design|Visualization|New Calendar Visualization Type|
|19830|Dashboards|UI|New Folder Structure for dashboards Category Dropdown|
|19846|API|Optimization|Formatting is not working in subtotal when field function is set to count -Apply ReportSet.CustomFormatter to all values|
|19861|API|Optimization|Report Header Image - Justification Switch Fixed|
|19868|Report Design|Visualization|New Flow Chart  - Visualization |
|19874|API|Optimization|DefaultItemsPerPage setting for VG and Analysis Grid |
|19893|Report Design|Optimization|Fixed reportDesigner crash when opening report with joined SP+table+filters|
|19915|Dashboards|Optimization|Auto Refresh Support added for Dashboard 2.0|
|19931|Report Design|Optimization|Subreport doesn't apply the combokey if using Analysis Grid - Fixed|
|19968|API|Optimization|Duplicate/overlapping delete/clear icons in IE 10/11|
|19969|UI|Optimization|Slider comment bubble hidden behind category drop down In IE Fixed|
|19973|API|Optimization|Updated Global In Starter Kit with new Dashboard Settings as Default|
|20010|Dashboards|Optimization|Turned off AdHocSettings.DashboardDateSliderMode = DashboardDateSliderMode.None; not supported in new dashboards|
|20014|Report Design|Pivots|Fixed Pivot Column Group Naming|
|20016|Report Design|Forms|Forms editor is now draggable for larger editing area|
|20023|API|Pagination|Pagination Slows load of report - fixed|
|20042|Report Design|Optimization|Summary subtotal broken|
|20044|API|Optimization|Fixed Additional Plus sign added to filter on JS event |
|20045|API|Optimization|showMiscTab = False fixed|
|20046|Report Viewer|UI|Resolved Text issues in Column Headers (hex char)|
|20055|Dashboards|Optimization|Resolve Routing issues on Report Viewer / Report Editor buttons for MVC New Dashboards|
|20061|Report Design|Optimization|Fixed subtotals on Function "Days Old"|
|20071|Dashboards|Optimization|Dashboards loading fixed when using custom methods to store reports|
|20097|API|Optimization|Fixed ExtendedFunctions handling in the Expression if name of the functions contains in the string literal or field nam|
|20107|Report Design|Filters|Filters remain after table deleted from join - fixed|
|20123|Report List|UI|Fixed Black Thumbnails caused by MS Security Update|
|20133|Report Viewer|Export|Enable HTML2PDF Pdf rendering for all licenses by default|
|20151|Report Viewer|Dundas Charts|Fixed typo issues in BulkCsvReportOuputGenerator, CsvReportOuputGenerator, SqlReportOuputGenerator |
|20182|Instant Reports|Optimization|Instant Report page  to sort data source names by alias name |
|20192|Report Viewer|Export|Exporting to CSV does not respect Value Ranges - fixed|
|20196|Report Viewer|Optimization|Fixed Issues in HTMLREportRenderer|
|20197|API|Optimization|Update Schema Button Resolved for New Tables|
|20204|Scheduler|Charts|Charts not displaying in scheduled emails fixed|
|20205|Report Design|Gauge|Fixed incorrect Auto Gauge values|
|20236|Dashboards|Export|Fixed html/pdf printing on new dashbords|
|20240|Instant Reports|UI|Instant Reports Data Source Categories still provide Uncategorized Group when all are catagorized - Fixed|
|20245|API|Optimization|Fusion Driver and Constraints fixed when using two different servers, Primary server cannot be Azure SQL Instance|
|20261|UI|Optimization|Fixed - Removing Advanced Field settings when changing to new field|
|20267|Report Viewer|Optimization|Fixed XSS issues in rs.aspx page and review viewer|
|20325|Report Design|Filters|Filters do not consistently use the AND operator by default - Fixed|
|20362|API|Optimization|Security Issue: Path Traversal  Fixed|
|20372|API|Optimization|Stored  Procedures do not render data - LAdHocSettings.LazySpMetadataPulling = true; fixed|
|20383|Dashboards|Visualization|Visualization layout inside New Dashboards fixed (autochart)|
|20396|API|Optimization|ItextSharp Setting added to increase performance |
|20412|API|Optimization|Isn't Between filter fixed|
|20433|API|Optimization|Security Issue: File Inclusion - Fixed|
|20475|Report Design|Filters|Make Utility.GetMd5Sum changed to  public |
|20490|API|Optimization|Synchronized resources in DLL and in RI |
|20511|Instant Reports|UI|Some icons are not loading on Instant Reports|
|20587|Dashboards|Optimization|Refresh Dashboard Error fixed|
|20588|Dashboards|Export|Update Print Functions for Dashboard 1.0 |
|20592|Report Viewer|Pagination|Pagination error in Pivoted Analysis Grid - fixed|
|20655|Report Viewer|Export|Print Issues both HTML and PDF with all visualizations - Fixed|


# 6.9.0.2 (June 23, 2015)

**NOTE** Advanced joins has been enhanced to allow multiple join conditions. [Read more here.](http://wiki.izenda.us/API/ShowAdditionalJoinConditions)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|**HF:20196**|Report Design|Joins| Fixed issue where the join alias was attributed incorrectly  6/30/2015|
|**HF:20224**|Dashboards|Optimization| Fixed issue where Old Dashboards no longer rendered in 6.9.0.2.  6/30/2015|
|**HF:20235**|Report Design|Data Sources| Fixed issue where virtual data sources would appear but still throw a stack trace error  6/30/2015|
|**HF:20251**|Instant Reports|Filters| Fixed issue where filters were working improperly. Appearance Change of Filter Properties - separated from field properties   6/30/2015|
|FB:18576|API|Optimization|Rename form script &lt;div id="launchmeplease"&gt; to &lt;div id="iz-custom-js"&gt;|
|FB:18972|Dashboards|Optimization|jQuery slider overlap in dashboard tiles in Dashboard 1.0 |
|FB:18976|Report Design|Expressions|Properly update format according to the Expression Type - Advanced Field Settings updates|
|FB:18997|Report Design|Visualization|Fixed incorrect calculation of visualization width when scrollbar exist.|
|FB:19000|Dashboards|Export|Added ability to email link and PDF from Dashboard 2.0|
|FB:19055|API|Optimization| Made two members public to allow customer to use optimized izenda api calls (ReportListAuxData() and  ReadXml(string xml, ReportListAuxData auxData) )|
|FB:19159|Report Design|Visualization|Metric selection on Visualization Save - updated|
|FB:19189|Report Design|Filters|Initialization of Filters corrected for use of same field in 2 filters|
|FB:19199|Report Design|Export| Fixed Page Break for Field Value visual group style and Multi Level Visual Group Style. Removed Doc type support to be ready in subsequent release - PDF support only now|
|FB:19213|API|Optimization| Version locks with License Key and related legacy code removed|
|FB:19235|Report Viewer|Charts| Added possibility to wrap labels of width exceeding certain value on all highcharts|
|FB:19282|Report Viewer|Optimization|Text (cell) highlight in a Analysis Grid style fixed|
|FB:19300|Report Design|Expressions| Fixed update format according to the Expression Type.|
|FB:19314|Report Design|Filters| Cascade filters with Calculation fields and filter logic fixed|
|FB:19319|Report Design|Filters| Unhanded exception in the Designer with Equals(Select)-like filters when design is incorrect fixed.|
|FB:19330|Report Design|Filters|Hidden Columns showing in filters fixed |
|FB:19364|Instant Reports|Charts|Instant Report Designer where while building an instant report with both an Autochart and Visual Grouping, the styling will break and the alternating item colors will change behaviors fixed|
|FB:19368|Report Design|Auto Chart|Autochart - Start At Zero functionality fixed|
|FB:19386|Report Design|Auto Chart|AutoChart - Scale changes as user drills down - fixed.|
|FB:19388|API|Optimization| Fixed deleting reports using an apostrophe in title.|
|FB:19405|Report Design|Saving|Concurrency and the ShowModifiedReportMessage|
|FB:19420|API|Fusion|Fixed FusionDriver when it generates SQL for report built against tables from different databases from the same db server. Previously it modified on demand the Schema property of certain Tables from DatabaseSchema to add database names to fully qualified tables/columns names in generated SQL. Now it doesn't modify on demand, instead now FusionDriver always uses all Tables/Columns with database name added to Schema property (which means it now always uses fully qualified Tables/Columns name with database name included)|
|FB:19441|UI|Optimization| Enable PopUp drill down interactivity by adding Close button to the dialog|
|FB:19472|API|Joining|Added additional constraints operator - now user can select multiple conditions on the join - see article on [ShowAdditionalJoinConditions](http://wiki.izenda.us/API/ShowAdditionalJoinConditions) for more information|
|FB:19497|UI|Optimization|Removed Obsolete Warning Messages|
|FB:19519|Scheduler|Optimization| Modified the scheduler to use the report name as the attachment name|
|FB:19528|API|Optimization|Removed unused method from Driver|
|FB:19543|API|Optimization|Added Resources Version Marker for identification |
|FB:19552|Report Design|Filters|Filters from Instant Report duplicate in Report Viewer fixed|
|FB:19553|Report Design|Pivots|Visual Grouping with Pivots conflicts removed|
|FB:19573|API|Optimization|Sorting on numeric fields as dates updated to use strict mode of the date parsing to avoid sorting errors|
|FB:19582|UI|Optimization| Hide "Update data sources aliases" button when aliases are disabled|
|FB:19586|API|Export|Bulk Constraints - New setting - AdHocSettings.ThrowExceptionOnAddConstraintError Default value - true. This setting controls whether error message is thrown on constraints not found or if errors are only logged. For example if tenant does not have access to table in constraint error should be logged rather than presented to user.|
|FB:19635|API|Forms| Fixed inconstancy in the Tenant Field behavior with Forms|
|FB:19646|API|Optimization|Languages in Izenda AdHocSettings.Language -1) Languages enum updated 2) French Canadian fr-CA resources file renamed so now it can be processed just like all other languages in the enum|
|FB:19656|UI|Optimization|"Expand All" option overriding all the expand options within the report using Visual Group Analysis Grid Fixed|
|FB:19657|UI|Optimization|Scroll Bar is not available in Dashboard 2.0 for the reports when the grid expands beyond the screen space - fixed|
|FB:19688|API|Export|Bulk CSV and Fusion connections updated to work with all supported database types|
|FB:19689|Report Design|Joining|Tables are not joined automatically if ShowDataSourcesTab=false fixed|
|FB:19695|Report Viewer|Optimization|Formatting Separators Updated for Displayed filters |
|FB:19698|Dashboards|Saving|Corrected users ability to save and save as an empty Dashboard 2.0|
|FB:19700|Dashboards|Export|Corrected users ability to print empty Dashboard 2.0|
|FB:19711|UI|Optimization|"Records Count" scroll bar is not adjusted back to correct position when changed from default Fixed Dashboard 2.0|
|FB:19730|Dashboards|Export|Exception is thrown when user try to print on a empty tile fixed|
|FB:19757|API|Optimization|When Gauges tab is hidden, getting js error - fixed|
|FB:19774|Report Viewer|Pivots|Pivot Report Output showing column identifiers instead of column headers - fixed|
|FB:19810|Dashboards|Saving|Save and Save As errors fixed for Dashboard 2.0 - Save shows no error and Save as errors showing dashboard exists (user must change name to use save as)|
|FB:19828|Report Viewer|Charts|Legend Disabled in Bar Charts -fixed|
|FB:19870|Report Viewer|Optimization|Running a report does not respect the Results per page setting - fixed|
|FB:19894|API|Optimization|Fixed issue with filter list report object when AdHocSettings.UseReportID = true;|
|FB:19897|Report Viewer|Optimization|Drilldown Report (popup) not working - fixed|
|FB:19960|API|Optimization|Driver.InvalidateSchemaCache doesn't clean stored procedures from cache - fixed|
|FB:19989|API|Joining|JoinedTableCollection modified in error during work of JoinedTableCollection.SQL getter - fixed|
|FB:20004|API|Optimization|Time zone offset fixed for Oracle and PosGreSQL|
|FB:20015|Report Viewer|Auto Chart|Autochart auto rebuild of y-axis fixed|
|FB:20019|Report Viewer|Visualization|Shading Heat Map - added a 'simple color change' function to heat map|
|FB:20022|API|Optimization|AJAX of Phantom export stops - fixed|
|FB:20026|API|Expressions|Expressions adding unwanted Group By clause - fixed|
|FB:20036|Report Design|Filters|Use Previous OR Error - support reinstated|
|FB:20039|API|Fusion|Virtual Data sources supported with Fusion - NOT SUPPORTED ON ODATA|
|FB:20058|Report Design|Optimization|TinyMCE Code Short Cuts creating unexpected behavior - fixed|
|FB:20070|API|Export|Chart Exports No Longer Work - Latest Windows Server 2012R2 Updates - fixed|
|FB:20075|Report Viewer|Charts|Pie Chart Exception Error fixed.|
|FB:20114|Dashboards|Saving|Fixed Dashboard 2.0 error when more than 5 tiles added|
|FB:20116|API|Optimization|Aliased field error - using incorrect alias fixed|
|FB:20126|API|Optimization|Security change bool ContainsTableName(string)  fixed|
|FB:20186|Report Design|Filters|Equal (Multiple) & Equal (Popup) in Filters doesn't work when user enter a name in "Join Alias" - fixed|
|FB:20191|API|Fusion|Datasource categories don't work in designer if FusionDriver is used - fixed|


# 6.9.0.1 (May 28, 2015)

## Important Note about 6.9:
**The command AdHocSettings.PrintMode is now deprecated. It has been replaced with AdHocSettings.PDFPrintMode will allow you to select between PDFMode.EO, PDFMode.iTextSharp and PDFMode.PhantomJS  PDF export engines. Please ensure that you have replaced this variable before running 6.9. AdHocSettings.ShowHtmlButton and AdHocSettings.ShowPdfButton have been introduced to specific control over the appearance of said buttons.**

## New Features: 
* **Auto-Gauges** - A new set of four gauges with a modern look and feel.
* **Dashboards 2.0** - A completely overhauled module which provides greater control over the look and feel of your dashboards. Learn how to install and use Dashboards 2.0 [here](http://wiki.izenda.us/Guides/Dashboards-v2).
* **PhantomJS Exporter** - An additional exporter emphasizing speed. **PhantomJS is not currently compatible with Azure PaaS installs, the EXE will not run in this environment.** It uses an EXE on the server instead of a DLL to move processing PDFs to a different thread than the Izenda's regular processing. Read more about it [here](http://wiki.izenda.us/API/CodeSamples/PdfPrintMode#PdfPrintMode).
* **Pivoted Analysis Grid** - New functionality offering a better breakdown of data over categories or periods of time

##Enhancements:
* **Virtual Data Sources** - A convenient way to use an existing report as a data source. Click [here](http://wiki.izenda.us/Virtualdatasource) for more information.


## Fixes:

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|FB:10310|Report Design|Charts|Implemented Auto Gauges with four styles: Simple, Linear, Round and Trending|
|FB:13120|Dashboards|UI|New Dashboards Support|
|FB:14686|Report Design|Analysis Grid|Fixed issues around alignment with Analysis Grid and Pivoted Analysis Grid|
|FB:15484|Dashboards|Filters|Added cascading for dashboard filters..|
|FB:18052|UI|Optimization|Optimized Mobile Support|
|FB:18253|API|Joining|AdHocSettings.TrimTimeInJoins setting added to eliminate time stamp from joins|
|FB:18285|UI|Charts|Fixed minimizeGridWidth when switching from Instant Report to Report Designer/Viewer|
|FB:18348|UI|Gauge|Implemented formatting value for gauges|
|FB:18350|Report Design|Auto Chart|Implemented aggregate function support in the Auto Chart visualization and improved general date behavior|
|FB:18457|Dashboards|Filters|Apply URL filters parameters to the Dashboard filters|
|FB:18572|API|Filters|Now able to specify column name in different formats for the hidden filter|
|FB:18575|API|Caching|Changed default QueryCachingTime value from 5 min to 1 min to maintain data relevance|
|FB:18615|Report Viewer|Export|AdHocSettings.EOPdfLoadWaitTime setting added to give users the ability to set the loading timeout for a PDF export|
|FB:18844|API|Optimization|Additional security optimizations|
|FB:18900|API|Filters|Properly handle unicode strings in Filters|
|FB:18975|Report Viewer|Charts|Removed halo effect of Pie chart (Highcharts) when hoving cursor over pie piece|
|FB:18979|Report List|UI|Corrected size and position of the dashboards icons when zooming out|
|FB:18996|Report Viewer|Filters|Fixed not showing filter name in case of Equals(Autocomplete).|
|FB:19010|Report Design|UI|Made AdvancedProperties modified flag work for all changed properties|
|FB:19072|Report Design|UI|Implemented changing of the chart labels when turned on/off "Horizontal" checkbox.|
|FB:19086|Report Design|Forms|Fixed summary causing issues in forms|
|FB:19098|Dashboards|Optimization|Fixed Dashboards page issue related to single quote in dashboard name|
|FB:19100|UI|Optimization|Do not show empty data source categories|
|FB:19115|Report Design|Charts|Fixed Dundas Bar chart numeric labels handling|
|FB:19120|API|Saving|Fixed null reference exception when re-saving report|
|FB:19139|Report Design|Visualization|Fixed inconsistency of items and columns in the Matrix visualization.|
|FB:19144|Instant Reports|Auto Chart|Fix for correct hiding Auto Chart icon on the Instant Report page.|
|FB:19155|Report Design|Expressions|Support zero-argument SQL functions in the Expressions.|
|FB:19160|Report Design|UI|Manual field descriptions are now changed when a new column or function is selected|
|FB:19173|API|Optimization|Made unnecessary protections against sql injections in 5 places|
|FB:19183|API|Charts|Enabled custom filters to be used in charts|
|FB:19203|UI|Optimization|Html Print and Pdf Print settings reorganized|
|FB:19216|Report Design|Expressions|Group By Expression feature implemented|
|FB:19221|Report Design|Optimization|Properly sort data sources within each category|
|FB:19222|Report Viewer|Filters|Fixed issue with Equals(Field) operator|
|FB:19223|API|Caching|IvalidateSchemaCache improved to update OperativeSchema with AdHocSettings.CacheSchema = false|
|FB:19224|Instant Reports|Optimization|Optimization of JavaScript on Instant Report page for search|
|FB:19240|Report Design|Visualization|Added user friendly visualization errors.|
|FB:19242|API|Optimization|Added error message for failed requests|
|FB:19246|UI|Optimization|Fixed share modal dialog|
|FB:19247|UI|Optimization|Appropriately scale windows with screen ratios so that windows are too large to make buttons accessable|
|FB:19274|API|Optimization|Prevented possibility to get contents of files from site root folder via rs.aspx|
|FB:19278|API|Optimization|ReImplemented AdHocSettings.Culture to work correctly for dates|
|FB:19285|Report Design|UI|Datasources are no longer lost when switching from Advanced to Simple Datasource Selection modes|
|FB:19292|Report Design|Optimization|Fixed Value Ranges/Cell Highlight when using Arithmetic.|
|FB:19293|API|Optimization|Fixed issue with cultures like "zh-zht"|
|FB:19317|Report Viewer|Saving|Implemented multilevel categories support in reportViewer save-as dialog|
|FB:19321|Report Viewer|Export|Added AdHocSettings.ConvertNullToEmptyString to allow a blank to display in outputs instead of (NULL)|
|FB:19325|API|Optimization|Localization resources loading from the shared folder fixed|
|FB:19334|Report Design|Saving|Fixed disappearing controls after cancelling a save|
|FB:19351|API|Optimization|Removed erroneous node in "WHERE" clause in case of left outer join|
|FB:19360|Report Design|UI|Fixed Visualization localization which resulted in the word Heatmap not being displayed|
|FB:19397|API|Optimization|Removed json length limitation|
|FB:19456|Report Viewer|Export|Fixed exporting of all visualizations.|
|FB:19524|Report Viewer|Optimization|Fixed not showing loading icon in ReportViewer.|
|FB:19542|Report Viewer|Visualization|Fixed issue with Visualizations not centering|
|FB:19706|API|Fields|Properly show currency format according to the AdHocSettings.Culture setting|
|FB:19719|Report Design|Auto Chart|Fixed Auto-Chart aggregate function error.|


# 6.8.0.8 (April 21, 2015)


**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

Note: The Visualizations help text contains a link directing the user to the Visualization feature page on the Izenda Wiki. If you would like to remove this like, you can modify the Doc.html files within the Resources/Vis folder for each chart type.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|**HF:19382**| **MVC Builds Only**|**API**|**In 6.8.0.x MVC kits downloaded prior to 4/24/2015, there was an issue where using AdHoc settings would not disable the ability to create new reports and dashboards. To fix this issue, please replace the _SiteLayout.cshtml file located in Views/Shared with [this one](https://izenda.sharefile.com/d-scab81cb6d6e43b3a).**|
|FB:14779|Report Design|Visualization|Corrected allowable size of bars (Auto Chart, Combo).|
|FB:17625|API|UI|Adressed localization not being applied in new UI elements.|
|FB:17962|API|Logging|Internal logger can now be completely disabled|
|FB:18248|Report Design|Visualization|Fixed breaking visualization with URL Advanced Field Setting.|
|FB:18281|API|Constraints|Implemented bulk adding constraints, Optimized FusionDriver.GetAllTables method, FusionConnection.GetColumns() method and Driver.ExtractSchema method|
|FB:18303|API|UI|Implemented possibility to configure join aliases in Advanced mode, and possibility to switch from Advanced to Simple mode without loosing join aliases|
|FB:18332|API|Optimization|Fixed error in JS when opening field properties window several times|
|FB:18371|API|Optimization|Trim trailing space to group Visual Grouping according to the ANSI/ISO SQL-92 standard for MSSQL|
|FB:18373|API|Optimization|Cleaned up .ascx pages in RI/Resources|
|FB:18418|API|Optimization|Removed excess string concatenations, made "variable cache" optimization in ResponseServer.IsTableVisible and ResponseServer.GetFunctionsList, removed excess ToLowerInvariant calls. Refactored AllTablesWithColumns member in Drivers, and thus fixed not-working part of disk schema cache for oracle and postgresql drivers. Changed linear search to picking from dictionary in "Column[] GetColumns(Table table)" methods of Driver-s.|
|FB:18422|Instant Reports|UI|Automatically sort VG fields in the report created on the Instant Report page|
|FB:18474|API|Optimization|Try to load only particular itextsharp assembly version to avoid versions conflicts|
|FB:18485|Report Design|UI|Visual Group headers now respect colors set for fields|
|FB:18508|API|Export|Apply all formatting levels to the Bulk CSV output|
|FB:18515|Instant Reports|Optimization|Improve autocomplete performance on the Instant Report page|
|FB:18560|API|Optimization|Fixed data filtering bug.|
|FB:18591|Report Design|Optimization|Fixed drill-down key field showing as a smart-tag|
|FB:18594|Report Design|Charts|Fixed applying simple custom formats to DundasCharts. Added properties to Funnel and Plot (Dundas) and Funnel (HtmlChart)|
|FB:18595|Report Design|Filters|Do not include extra param when filter operator is changed to Between|
|FB:18597|Report Design|Filters|Client-side sorting of dates before 1970 fixed|
|FB:18661|Report Design|Filters|Do not refresh filters automatically in the Viewer if CascadeFilterValues is set to false. Properly handle filters with identical structure in the Viewer.|
|FB:18670|API|Database Mode|Fixed null reference error when Fusion Driver is used together with DatabaseAdHocConfig and reportList caching|
|FB:18695|API|Optimization|API to specify a valid native type to override internal DB type for temp SP table creation|
|FB:18710|Report Design|Optimization|Apply "Page Break After VG" setting to the field-value styled VG|
|FB:18714|API|Fusion|Made it possible to create and use virtual datasources with FusionDriver against databases exposed via fusion connections|
|FB:18736|API|Pagination|Removed pagination from dashboards.|
|FB:18737|API|Optimization|Apply AdHocSettings.TimeZoneOffset to some Date aggregate functions, AdHocSettings.TimeZoneOffset datatype is now double|
|FB:18756|API|Optimization|New auto-join algorithm|
|FB:18766|API|Pagination|Tiny fix for correct calculation of the amount of pages. Properly format both Detail and Summary grids when pagination is used|
|FB:18802|API|Expressions|Properly handle FieldAliases in the expressions|
|FB:18828|API|Caching|Fixed cherry pick conflict|
|FB:18845|Report Viewer|Charts|Restore fade-out of the long labels in a vertical Bar Chart|
|FB:18849|API|Data Sources|Do not show SavedReportsTable as available data source. Properly handle SavedReportsTable with schema name in Oracle and PostGreSQL|
|FB:18854|API|Optimization|Fixed out of range exception in DrillDownKeys|
|FB:18858|API|Expressions|Allow tabulation chars in the Expression for better formatting|
|FB:18859|UI|Expressions|Refresh calculated fields list when Arithmetic or Expression is changed|
|FB:18869|API|Export|Fixed exporting from the Designer (regression bug from the FB-17901)|
|FB:18873|API|Visualization|Refactored Visualization charts and fixed help text|
|FB:18915|Report Design|Joining|Fixed missing joins on switching between modes, and another issue with join aliases after switching to simple mode|
|FB:18919|UI|Database Mode|Do not create duplicates in the report list in DatabaseAdHocConfig when CurrentUserTenantId is specified|
|FB:18920|API|Pagination|Use cache with pagination so SQL request is not required to change the page|
|FB:18942|Report Design|UI|Fixed Gradient Cell not working in case of some formats.|
|FB:18949|Report Design|Charts|Properly round Axis labels in Bar and Trend charts when integer format is used|
|FB:18955|API|Optimization|Removed unused empty class.|
|FB:18970|API|Optimization|Distinct keys values in the AdHocSettings.FieldAliases collection|
|FB:18973|Save|Visualization|Fixed bug saving the properties in the case of two or more visualizations in a single report.|
|FB:18974|Report Design|Visualization|Fixed showing subreport charts in expand panel of the Auto Chart.|
|FB:18977|Report Design|Optimization|Fixed the Record Count metric.|
|FB:18980|API|Optimization|Fixed malformed mime type header|
|FB:18998|Report Design|Optimization|Avoid to add empty HAVING clause|
|FB:19014|API|Saving|NullReferenceException on save when UseReportID setting is set to true fixed|
|FB:19022|Save|Forms|Save Form in the proper location when CurrentUserTenantId is set|
|FB:19030|API|Optimization|Replace text for Divide-By-Zero will now show empty strings|
|FB:19034|API|Optimization|Prevent XSS attack via HTTP header on the Settings and rs pages|
|FB:19044|API|Logging|Added logging to ListReportsCache/ReportListCacheStorage classes.|
|FB:19046|Report Design|Optimization|Fixed NullReferenceException when processing hidden filter with empty column|
|FB:19061|API|Expressions|Subtotals Expression feature implemented|
|FB:19080|API|Optimization|Fixed deadloop in GetConstraintsInfo|
|FB:19087|Report Design|UI|Properly handle VG Hierarchy rows visibility according to the ExpandVisualGroupGrids setting value|
|FB:19107|API|Optimization|Added public method Utility.InitFakeHttpContext() which customer can call to ensure that Izenda is not running null http context in win32 (not web) application.|
|FB:19110|Report Viewer|Export|Fixed hiding wrong fields when using /csv and BulkCSV.|
|FB:19123|UI|Optimization|Changed margin of the AllowNulls checkbox.|
|FB:19125|API|Caching|Added disabling query cache if SavedReportsTable occurs in parameters values.|
|FB:19294|API|Arithmetic|Changed ShowArithmetics default value to true|
|FB:19304|Report Viewer|Optimization|Fixed JS error when opening field properties in viewer|


# 6.8.0.7 (March 24, 2015)


**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

Note: The Visualizations help text contains a link directing the user to the Visualization feature page on the Izenda Wiki. If you would like to remove this link, you can modify the Doc.html files within the Resources/Vis folder for each chart type.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|HF:19020|API|Filters|Fixed issue resulting in unneeded HAVING clauses|
|FB:12976|API|PostgreSQL|PostgreSQL type mapping reviewed.|
|FB:13008|Report Design|Filters|Selecting a value for "Require" in the Report Viewer will no longer throw an exception when calculated columns are being filtered upon.|
|FB:14209|Report Viewer|Visualization|Text labels are removed from the World Tour when the user takes control using the mouse. Resume the animation by clicking the visualization.|
|FB:14271|Report Design|Joining|Automatically COLLATE Stored Procedures columns to the database_default if Stored Procedure is used in the JOIN|
|FB:15381|Report Design|Fusion|Fixed Pivots and Filters when Fusion connection is used|
|FB:17588|Save|Export|Modified exports to use the report name as the file name. If the report has not been saved, the name will default to 'Report.xxx'|
|FB:17695|Scheduler|Resources|Internal static resources load directly instead of using HttpRequests so emailed reports appear correctly|
|FB:17783|API|Caching|Implemented updating databaseschema on new session  |
|FB:17942|Report Design|Pagination|Fixed pagination error in Report Designer where changing pages would result in "No field selected"|
|FB:17943|API|Browser|WorldMap in FireFox now appears correctly|
|FB:18080|Save|Export|Pie charts can now cross pages without being cut off.|
|FB:18082|Report Viewer|Responsive Grid|Updated Responsive Grid to work with higher rowcounts|
|FB:18107|Scheduler|Dundas Charts|Fixed bug in rendering DundasChart within scheduled reports.|
|FB:18140|Report Design|Gauge|Pass correct parent report param to the drill-down report of the Gauge report inDashboard|
|FB:18165|Report Design|Pivots|Properties of columns in Pivots and Fields are not independent of eachother|
|FB:18171|Report Viewer|Fields|Fixed group issue on fields adding in report viewer|
|FB:18218|API|License Key|Fixed Data Sources page error when license contains no +MAPS.|
|FB:18226|Report Viewer|Charts|Fixed inconsistency between Value field and available Functions in charts.|
|FB:18231|API|Data Sources|Fixed issue in fusion driver when odata connection to webservice behind load balancer is used|
|FB:18245|Report Design|Filter|FilterLogic with HAVING fixed|
|FB:18295|Report Design|Expressions|Allow NOT key word in Expression|
|FB:18304|API|Caching|Do not include Report Position in the cache signature|
|FB:18323|API|Performance|made driver calls to the ParentReportSet more consistent|
|FB:18349|Report Design|Charts|Fixed inconsistency in formatting between Field and Chart (Trend, Pie, Funnel).|
|FB:18354|Dashboards|Analysis Grid|Fixed showing Analysis Grid on Dashboard.|
|FB:18359|Report Viewer|Fields|Do not show fields that are part of the arithmetic in the Viewer Fields control|
|FB:18369|Report Viewer|Fields|Persist field properties when it's moved to the unused pane in the Viewer|
|FB:18370|API|Caching|Synchronize report list cache in DB storage mode when App server and DB server have different time zones|
|FB:18380|Report Design|Forms|Ensure tinymce empty form is removed from report|
|FB:18390|Save|Dashboards|Use real form id instead of the hard-coded one on the Dashboards page|
|FB:18413|API|Caching|Fixed showing obsolete data on UpdateResults click when CacheQueries enabled|
|FB:18455|Report Design|Forms|Allowed to put fields absent in Form without sorting to the top of selection list|
|FB:18491|Report Viewer|Summary|Fixed Gradient Cell Shading in Summary.|
|FB:18508|API|Export|Execute report only one time for BulkCSV export & ProcessDataRow method added to the API|
|FB:18509|Instant Reports|Fields|Properly sort field names on the Instant Report page.|
|FB:18532|Report Design|Auto Chart|"Auto chart" refactoring. Fixed non-unique element ids.|
|FB:18534|Save|Export|Allow HTML content (in report header/footer/title and field description) to be rendered in export output|
|FB:18545|UI|Filters|Filters with long names UI issue fixed|
|FB:18552|API|Forms|updated CodeMagic to use syntax highlighting|
|FB:18559|Report Design|Visualization|Use Visualization from any Chart tab rather than from the first only|
|FB:18573|Report Viewer|Report List|Authentication no longer impedes thumnail viewing|
|FB:18577|Save|Database Mode|Properly handle SavedReportsTable with schema name|
|FB:18602|Dashboards|Security|Encode user input on the Dashboard Designer page|
|FB:18610|Report Design|Fusion|Do not auto group fields with aggregate function in expression - Fusion connection fix|
|FB:18621|API|Save|AdHocSettings.ShowModifiedReportMessage setting added|
|FB:18622|API|Export|Modified build script. Only distributes phantomjs exe now.|
|FB:18624|Save|Export|Fixed exporting of the visualizations.|
|FB:18641|Report Design|Filters|Fixed '(blank)' behavior of the multi-selection operators in the filters.|
|FB:18696|API|Security|Implemented concealing connectionstring in logs|
|FB:18715|API|Data Sources|Made virtual datasources working correctly together with changes from 16086|
|FB:18721|Report Design|Visualization|Upgraded Visualization Helptext. This text contains a reference to the Izenda wiki that can be removed in the doc.html file for each visualization contained in the Resources folder|
|FB:18731|Report Design|UI|Fixed hiding of service field.|
|FB:18732|Report Viewer|Resizing|Fixed report title, description and other header items from maximum 33% size to100%, removed nowrap from description, header and footer of report.|
|FB:18735|API|Broswer|Fixed error in IE9 when cssText property is changed.|
|FB:18793|Report Design|Arithmetic|Fixed checking on division by zero.|
|FB:18833|Report Design|Forms|Made autocompletion hidden on forms by default|
|FB:18834|API|Visible  Datasources|Fixed missing constraints|
|FB:18838|API||Fixed izenda crash on null value in Xml column in reports table|
|FB:18871|Report Design|Visualization|Fixed Timeline visualization not working.|
|FB:18902|Dashboards|Charts|Fixed charts on dashboards not working.|
|FB:18939|Instant Reports|Auto Chart|AutoChart fixed on the Instant Report page|
|FB:18961|Report Viewer|Saving|Added confirmation of overwriting reportset in reportviewer|

# 6.8.0.6 (February 25, 2015)


**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

* **HF-18699: Predefined Constraints Not Being Recognized - Download links updated 2/26/2015**
* FB-13156: Show friendly error when Analysis Grid report is designed incorrectly
* FB-13980: Fixed formatting values for: Matrix, Waterfall, Time Bubble, World Tour, Combo, Tree and Autochart Visualizations. Fixed displaying "Others" and percent values in Autochart.
* FB-14319: Grammatical issue was fixed "does" not "do"
* FB-14067: Fix common filters in Dashboards when there are several filters on the same column and with the same Operator.
* FB-14744: Fixed Appearance tab on Settings page.
* FB-14779: Fixed correct rendering of visualization in small containers. Hide breadcrumbs if the content overflows an element's container.
* FB-15238: Fixed behavior of Pie and Funnel chart types.
* FB-15790: Implement Filters on the Instant Report page
* FB-16415: ReportDesigner fixed to handle browser width while piechart generates
* FB-17549: Fixed bulkcsv export crash when pivots are used
* FB-17669: Added possibility to post-process highcharts labels
* FB-17790: Expand analysis grid groups in Scheduler output
* FB-17821: Fixed missing of FusionConnection.getDataSetUrl value in new session
* FB-17852: Scheduler - Include category in the Report link
* FB-17869: Added support for DB Mode in PostGreSQL and Amazon Red Shift
* FB-17901: Implemented Loader... until print window is closed. Fixed multiple html-prints in ReportDesigner
* FB-17918: Implemented possibility to export reports without redirection. Changed name of setting.
* FB-17935: Made FORMSCRIPT and VISUALISATION Forms smart-tags case-insensitive
* FB-17948: Re-implemented AddAll and RemoveAll on fields tab
* FB-17961: Fixed issue with scheduler where clients were getting multiple copies of the same email
* FB-17981: Fixed indicators in dundas map
* FB-18008: Finished changes to wrap labels on horizontal bar chart
* FB-18091: Properly select reports from DB when name contains special symbols or spaces
* FB-18100: Respect UseBulkCSV setting in scheduled output. Fixed subtotals in Bulk CSV export when filters are used
* FB-18117: Apply new color scheme to the Filters, Field Properties and Instant Report page elements
* FB-18132 Fixed waterfall/html-charts component updated
* FB-18144: Fix :hover behavior in Report List on touch interfaces. Use link controls on the ReportList page.
* FB-18155: Simplified instant reports UI related to totals/subtotals. Disabled applying SUM subtotal function on IR page.
* FB-18175: Reconciliation of changes in 15602 with 18175
* FB-18175: Optimization of first reportlist loading
* FB-18251: Fixed datetime formatting when exporting to excel
* FB-18276: Or issue in hidden filters fixed
* FB-18336: Optimize ReportSet objects writing. Do not include GUIDs of the hidden filters. Do not use auto-generated IDs when calculating ReportSet cache key
* FB-18344: Fixed stack overflow when loading reports from DB (issue introduced in FB-16086)
* FB-18352: Added codemagic as the new source editor for forms. Added z-index property to pop up box.
* FB-18357: Forms popup hidden behind main navigation bar
* FB-18356: Fixed issue where a user with full access is unable to move from the fields tab and no user is able to view the report thereafter.
* FB-18381: Fixed infinite recursion when updating report in reportviewer
* FB-18419: Prevent recursion call of GetDataSet method when CurrentReportSet is not initialized
* FB-18439: Populate columns for data sources when VisibleDataSources collection is changed
* FB-18470: Fixed Virtual Data Sources column names generating
* FB-18528: Altered ToolbarBackgroundImageUrl's default value to be empty
* FB-18605: Allow only fields from the Details to be used for the new Filters in the Viewer


# 6.8.0.5 (January 29, 2015)


**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

* FB-15635: Fixed chart name position for pie charts
* FB-15913: Fixed "Print HTML" and "HTML-powered PDF" for visualizations ("Auto Chart", "Sunburst", "Heatmap"). Fixed a bug of printing inconsistent data (Chart and Table).
* FB-16304: Pass only parameters with values to the SP
* FB-17519: Show note message in Preview if labels on the Line Chart were hidden automatically
* FB-17524: Implemented front-end Money and % formatters for autocharts. Implemented front-end PercentOfGroupFormatter for aurocharts
* FB-17640: Fixed exception which could occur if table is not found during constraints deserialization
* FB-17692: UseTablesFromSchemaOnly setting implemented for MSSQL connections. Load objects from different schemas mechanism implemented for PostgreSQL connections
* FB-17698: Changed powered by Izenda logo to new logo
* FB-17753: Fixed Time-slider values changing
* FB-17754: Use current Thread culture to format dates in the Slider control
* FB-17771: Fixed field properties button in reportviewer
* FB-17807: Implemented changing pdf export button when itextsharp is engaged
* FB-17818: Do not auto group fields with aggregate function in expression
* FB-17825: Fixed Drill-Down links in AG value cells
* FB-17826: Apply font style to values cells in AG
* FB-17827: Apply column Width to AG value columns
* FB-17828: Fixed labels and values alignment in AG
* FB-17851: Trim long labels in Heatmap Vis
* FB-17858: Apply Width, font style and justification settings to AG hierarchy columns
* FB-17951: Fixed Numbers subtotal calculation in PostgreSQL
* FB-17958: Made Cancel button always enabled in form designer
* FB-17969: Quick fix of tiny issue - not showing thumbnail image in reportlist which was requested first. ReportList optimizations #1
* FB-17976: Remove used fields from the available columns panel in the Viewer
* FB-17982: Do not show labels if container is too small in Heatmap Visualization
* FB-18071: Fixed error with thumbnail retrieval in database mode
* FB-18081: Fixed Trend(Line) chart value labels
* FB-18104: Fixed issue which caused ignoring overriden methods.
* FB-18110: Fixed failure of creating thumbnails when there are two or more thumbnail generation tasks in queue. Reverted back public methods signatures which were erroneously modified.
* FB-18130: Fixed Gauges headers formatting
* FB-18157: Use minimum value as a floor of the Y axis in linear chart
* FB-18158: Do not cache requests to the table with reports
* FB-18278: Fixed appearing invisible datasources on IR page
* Changed button colors to new color scheme
* Implemented printing report using current position on breadcrumb (Sunburst, Heatmap).
* Modified build script to move phantomJS dependencies to bin


# 6.8.0.4 (January 8, 2015)

**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

* FB-13507: Moved forms out of sessions, switched to new form designer, moved templates out of sessins, fixed issue with forms being modified concurrently
* FB-13832: Fix of null reference exception for two different users with the same tenantid and optimize report list loading
* FB-15612: Fix charts width in PDF render and increase timeout limits
* FB-16097: PieChart doesn't smash anymore on mousemove while starting
* FB-16120: Fixed radius of the inner circle in Sunburst visualization.
* FB-16228: Fixed not working in some cases forced left joins
* FB-16286: Added missing variable to JoinedTablesList.js
* FB-16295: Fixed error when url doesn't contain port number.
* FB-16351: Implemented switch from advanced to simple datasources
* FB-16415: Fixed Pie char labels cutting off
* FB-17478: Combine Bottom % - ViZ Pie implementation
* FB-17513: Fixed showing visualization on dashboards (reports with VG).
* FB-17543: Use current report state when exporting charts as images
* FB-17586: Fixed subreports cascade filters loading
* FB-17663: Buttons below field list
* FB-17699: Fixed logo sizing issue and hanged main navbar color scheme and logo
* FB-17718: Join aliases of self-joined tables support in Viewer
* FB-17723: Added forms data to objects in report list cache
* FB-17787: Fixed broken charts when report part is on page without rs.aspx in folder, missing dashboard.css, implemented support of custom reportpart locations in visualizations 
* FB-17788: Respect fields visibility in Bulk CSV export
* FB-17793: Made it possible to configure path to rs.aspx in html reportpart
* FB-17796: Fixed funnel cutoff in dashboards
* FB-17797: Removed jquery191 script from reportpart
* FB-17801: Switch between plus-minus icons in responsive grid
* FB-17803: Added deprecation information for AllowSelfJoin
* FB-17805: Fixed dialog dropdowns "Loading..." issue
* FB-17819: Case-insensitive  AdHocSettings.DataSourceCategories
* FB-17822: Fixed Bulk CSV export with Oracle connection and filters
* FB-17844: Avoid zero columns for pie charts
* FB-17856: Fixed Heatmap visualization vertical justification and size
* FB-17857: Fixed false messages upon 2nd+ saves in the Designer.
* FB-17861: Added percents to animated half circle gauge and implemented percentage values in animated gauges
* FB-17870: Fixed Equals(Select) filters in the Designer 
* FB-17829: Fixed GaugeRadial.png resource loading
* FB-17940: Fixed crash when fieldForHaving is null
* FB-17959: Added using _global_ report if report for current user tenant is not found


# 6.8.0.3 (December 17, 2014)

**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

* FB-15865: Fixed bulk CSV output for reports with custom ProcessDataSet results
* FB-17715: Probable fix of null reference exception
* FB-17765: Fixed not-working "update results" button when report is without filters.
* FB-16228: Chose correct base table for join when Forced Left Joins are used.
* FB-15157: fixed RemoveUsedFields function
* FB-15884: Implemented storing custom chart legend in report
* FB-14600: Filter field quoted to prevent js-injection
* FB-15330: Borders, background and chart sizes in HTML-print fixed
* FB-17760: Synchronize calculated fields descriptions in the Designer
* FB-17759: Fixed rendering HTML report parts
* FB-17682: Added blank option to InTimePeriod values
* FB-17536: Fixed shift of plus symbol on collapsed grid rows
* FB-14714: Update calculated fields and filters automatically when Field Description is changed in the Viewer
* FB-14703: SMTP SSL support added to the Scheduler
* FB-16350: Fixed adding fields from the data source with join alias in the Viewer
* FB-16443: Always align report title, header, description and footer to the left in Excel output
* FB-17721: Implemented possibility to embed scripts in server response when using reportPart on HTML page
* FB-17710: Made highcharts stretching to the width of hosting container
* FB-17669: Filters functionality added to the HTML Report Parts
* FB-15672: Numerous javascript fixes
* FB-17701: Fixed crash of summary report with subtotals when VG style is set to VGHierarchy.
* FB-17729: Fixed possible out of range error when copying rows between tables.
* FB-17542: Fixed dynamic filters with HTML markup in values
* FB-17669: Fixed subtotals calculation of non-numeric fields
* FB-17709: Fixed report deletion on the Report List page
* FB-17702: Insert Quick Add fields below all selected fields
* FB-13700: Added 'X' to report list search
* FB-17644: Fixed issues on IR page
* FB-15815: Fixed show thumbnails of the visualization (Auto Chart, Sunburst).
* FB-15895: Headers style changed
* FB-15501: Changed position of the legend of the "Combo" visualization.
* FB-15118: Fixed missing form on first reportset save operation
* FB-17475: Fixed issue with pivots and FusionDriverMySql+MsSqlConnection
* FB-17460: Fixed issue with pivots when FusionDriver is used
* FB-16405: Fixed losing pivots when INFO logging level enabled and subtotals enabled.
* FB-16439: Autocharts fixed with pivoted source
* FB-15157: Copy resources to DLL
* FB-17654: Fixed filters values update in the Viewer
* FB-17594: Correct hiding fields and filters columns in Viewer
* FB-16350: Show data sources join aliases in the Viewer.
* FB-15157: Fix issue with modifying existing field
* FB-15746: Do not modify aggregate function when Total field property is changed in the Viewer
* FB-15157: Numerous fixes and performance upgrades
* FB-16090: Properly sort fields list at the Viewer Fields tab
* FB-17483: Fixed several issues relating to hidden fields.
* FB-15684: Show Vis documentation if Vis is failed to render
* FB-17518: Fixed  Field-Value grids PDF printing
* FB-17558: Fixed data extraction when AdHocSettings.CacheQueries is false
* FB-17503: Fixed report Title in the Viewer
* FB-16189: Reload some settings when lic key is changed
* FB-16255: Fixed reports with hidden fields formatting

# 6.8.0.2 (November 25, 2014)

**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**
 
* FB-10702: Language Pack GUI Updated
* FB-13603: Disable VG automatically if report contain Form
* FB-14598: Implemented support of multiple drilldown keys in reportset
* FB-14969: Encode HTML in inputs on misc tab
* FB-14976: Added auto refresh functionality in viewers
* FB-15075: Added sub report filter control from master report
* FB-15077: Added multi line header and width field properties
* FB-15164: Hide Summary with Title if there are no summary rows on the current page is pagination is used
* FB-15300: Fixed Instant Report schema loading when HiddenColumns setting isused
* FB-15320: Legend disabled for piecharts with separator
* FB-15322: Fixed gauge color styling
* FB-15471: Implemented confirmation of saving reportset which was modified onserver side by other user
* FB-15556: Increased subtotals calculation performance when VG is used
* FB-15579: Fixed slowdown caused by Preview button handling in IE8
* FB-15623: Support Stored Procedures in BulkCSV output
* FB-15624: Send all scheduled emails using single SmtpClient
* FB-15631: Scheduler for Dashboards implemented
* FB-15671: FORMS - Default adjusted to x
* FB-15686: Fixed broken Save button in dashboard preview, made join aliases hiddable, fixed in highcharts error related to overflowing number of styles in IE8
* FB-15708: Use AdHocSettings.Culture to format Date values in filters description
* FB-15716: Fixed js exception in animated gauges
* FB-15737: Fixed missing datetime stamp in excel/word export
* FB-15776: Disable filters inputs when loading
* FB-15782: Fixed overlapping labels in pie charts
* FB-15784: Report List page - show message when no reports found
* FB-15794: Fixed slowdown when adding many fields through QuickAdd
* FB-15801: Fixed axis labels on the Linear Gauge
* FB-15804: Fixed subtotals when single SP is used as a data source
* FB-15864: Removed hidden filter fields from fieldlist while viewing
* FB-15876: Removed redundant report refreshes in the Viewer
* FB-15877: Format labels and tooltip values in Combo Chart
* FB-15883: Fixed issue with HTML Footer in HTML2PDF print
* FB-15889: Properly sort DateTime values on the client if format is not specified
* FB-15896: Updated Waterfall/Doc.html preview to show the preview image afterclicking the help box on the report designer.
* FB-15900: Removed onhover checkboxes from InstantReport page. Also removed old data-sources.css from Resources/css folder.
* FB-15922: Fixed css for instant report table
* FB-15949: Properly apply Value format in the Dundas Pie chart when "Show percentage" is checked
* FB-15953: Adjusted the settings tabs to make them more responsive to UI changes.Added missing separators to the toolbar menu to make the UI more consistent.
* FB-15981: Improved locating of Vis folder in site folders tree
* FB-15983: Altered css to fix thumbnail API defect
* FB-15984: Enhanced security in Dashboards
* FB-16015: Fixed responsiveness in Pie and Funnel charts
* FB-16032: Subtotals added to BulkCSV export
* FB-16037: Properly sort results from the SP in a simple mode
* FB-16039: Show Loading message in Filters/Fields tabs during initialization
* FB-16050: Show only valid to join data sources sets in the Recent Data Sources list
* FB-16052: Fixed report export after exporting to Bulk CSV
* FB-16079: Optimized query Cache for all SQL requests
* FB-16105: Removed duplicate Report List javascript reference
* FB-16122: Fixed apostrophes in fields aliases
* FB-16123: fixed world tour animation pathing
* FB-16135: Fixed VG and Pivots when AdHocSettings.ExpandVisualGroupGrids is false
* FB-16137: Fixed Gauges in reports with pagination
* FB-16145: Fixed Pivot columns Advanced Properties
* FB-16162: Fixed Forms reports rendering when filter operators with no valuesareused
* FB-16194: Apply Field Description to the corresponding Filter in the filtersdescription
* FB-16200: Fixed Count Distinct function in Maps
* FB-16201: Adjust Charts height in Excel export
* FB-16210: Do not try to create clustered index on IzendaAdHocReports table if index already exists
* FB-16226: Allow for data sources to be in multiple categories in the Designer
* FB-16243: Refresh report Thumbnail with every save
* FB-16253: Summary title now wraps around if too long
* FB-16254: Fixed emails from the client Subject text encoding
* FB-16297: Fixed resources folder location when dll works in offline mode
* FB-16317: Combine Bottom option fixed for piechart with separator
* FB-16320: Bread crumbs alignment improvement in the Heatmap vis
* FB-16360: Added intelligently forced disabling value labels on trend High Charts
* FB-16372: Fixed Stored Procedures without available columns serialization
* FB-16377: Use appropriate Parameters types for Ansi and Unicode strings
* FB-16445: Fixed crash on second reportset viewing

* HF-15686: Fixed adhoc failure when query caching is disabled

# 6.8.0.1 (October 31, 2014)

**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

##Features: 
* FB-13936: Pure HTML Report Parts
* FB-14462: Responsive Grids - Refactored tables to diplay data responsively for smaller screens
* FB-14865: Vision - Visualizations are a D3-based visual supplement to Izenda’s core charting engine

##Enhancements: 
* FB-13393: JQuery version Upgrade and move of jquery into /resources/js
* FB-13872: Simplified Expressions - supports statements with/out parenthesis
* FB-13982: Secondary Drill Down Keys
* FB-14227: Date picker localization 
* FB-14383: Extraction of CSS/JS/Images from DLL
* FB-14488: Navigation, Toolbar and Breadcrumb Responsive 
* FB-14548: Jquery namespace change from $ to jq$
* FB-14898: Optimize PostProcessEqualsSelectList
* FB-15057: Multiple Self Join Alias Support /Displaying the values of multiple datasources

##Fixes: 
* FB-13282:  Fix subtotals order in Forms
* FB-13557:  Optimize bulk CSV streaming operation
* FB-13847:  Avoid truncation of datasource names 
* FB-14216:  Separate Null and Empty String values if both are presented in the data set.
* FB-14219:  Smoothly cut long labels in the Funnel chart
* FB-14310:  Optimized reportParts with htmlCharts
* FB-14448:  Removed overlapping of breadcrumb and field with metric selector
* FB-14528:  BreakPage property added to the Field advanced properties
* FB-14601:  Fixed unexpected increasing chart height
* FB-14715:  Fixed highcharts legend cut off when chart is exported
* FB-14780:  Hide Fields tab in the Viewer for View Only reports
* FB-14836:  Added support Equals(Field) filters in the Viewer
* FB-14870:  Fixed Auto Chart not working on IE8
* FB-14937:  Apply DIV/0 formatter if there is a division operation in Expression
* FB-14942:  Fixed subtotals calculation if arithmetic is used
* FB-15068:  Fix phantom "Summary" and "Detail" creation for new dashboards.
* FB-15070:  Fixed broken gauge subreports
* FB-15081:  Fixed several issues related to gauge hover subreports
* FB-15097:  Use CurrentThread.CurrentUICulture to format dates
* FB-15103:  Fixed broken legends in piechart
* FB-15115:  Fixed rendering of Pie/Doughnuts charts with Separator
* FB-15148:  Made reportset created/modified dates to be correct in logs
* FB-15160:  Fixed sorted grid columns export
* FB-15165:  Fixed missing styles in report viewer, not-working styles application to sample grid
* FB-15169:  Made page numbers disabled by default
* FB-15176:  Fixed VisibleDataSources saving form the Settings page
* FB-15238:  Removed unnecessary changing of chart type, added storing of legend data while changing of chart type
* FB-15276:  Use LEFT join if it is available in auto-join algorithm
* FB-15280:  Do not add redundant ddk filters to automatic subreport
* FB-15288:  Fields responsive design in the Viewer and InstantReport page
* FB-15304:  Fixed Group(Week) format in charts
* FB-15322:  Style tab header color only applies to all guages
* FB-15326:  Fixed erroneous adding to grouping of field with expression which effectively doesn't present in report
* FB-15344:  Made simple databaseSchema (de)serialize optimization
* FB-15351:  Populate correct ReportInfo.OwnerName in FilteredListReports method
* FB-15370:  Added line-polar and spline-polar chart types
* FB-15377:  Fixed pagination when SP is used as a data source
* FB-15379:  Fixed issues with downloading data when authentication is used on the site
* FB-15383:  Fixed Filter Logic in the classic ReportViewer
* FB-15390:  Additional pagination controls implemented
* FB-15398:  Added message about forcibly fields reordering
* FB-15405:  Implemented datasource alias support in reportviewer
* FB-15472:  Fixed behavior when Total is checked in report viewer.
* FB-15482:  Fixed hidden filters when fusion is used.
* FB-15488:  UseReportID affects subreport references on fields and TargetReport property in ReportSet
* FB-15529:  Fixed client side alphanumeric sorting
* FB-15547:  Fixed Report saving and report name titles in Viewer and Designer when ReportID is used
* FB-15550:  Fixed formatting in csv output generator after 10000-th line
* FB-15566:  Fixed erroneous write to log
* FB-15584:  Allow to close image modal dialog when image is invalid
* FB-15586:  Trimmed description to avoid undefined exporting behavior
* FB-15625:  ReportScripting.js in FromDLL directory updated
* FB-15652:  Do not attach volatile Form to the random reports
* FB-15657:  Implemented simple form designer for elrte-incompatible browsers
* FB-15685:  Fixed JS error in IE8
* FB-15686:  Fixed numeric formats in Chart Labels
* FB-15699:  Fixed js error on hover item in Timelime chart
* FB-15700:  Fixed out of memory exception in gauges
* FB-15704:  Fixed scheduled reports sending to many recipients
* FB-15715:  Added indexes to the reports table
* FB-15725:  Fixed required parameters filters for operators without value in the Viewer
* FB-15733:  Removed unnecessary resources from outside of dll
* FB-15750:  Changed AdHocSettings.ShowTableNames setting behavior
* FB-15753:  Implemented ExtendedFunctions support in expressions
* FB-15753:  Fixed issue with ExtendedFunctions and refactored Fusion
* FB-15760:  Fixed issues with dup fields in reportViewer
* FB-15762:  Fixed animated gauges in reportparts
* FB-15797:  Fixed issues with Time Slider
* FB-15801:  Fixed axis labels on the Linear Gauge
* FB-15823:  Fixed auto-complete filters in the Viewer
* FB-15851:  Fixed simple-mode filters for Dashboards
* FB-15852:  UI improvements on the Instant Report page
* FB-15853:  Update to allow modification of resources in English
* FB-15857:  Fixed date filters when Thread Culture is not default en-US
* FB-15858:  Removed all RTF funcationality
* FB-15859:  Call PreExecuteReportSet and PostExecuteReportSet when exporting to Bulk CSV
* FB-15887:  Fixed Edit/View controls on the Dashboards page when saving new report
* FB-15913:  Export to PDF now uses currently selected breadcrumb node to render the report
* FB-15949:  Fixed Chart formatting
* FB-15955:  Do not show Edit and Delete buttons in the Report List when ShowDesignLinks setting is false
* FB-15975:  Fixed stored procedures interaction with fusiondriver
* FB-15990:  Fixed automatic subreports in Gauges
* FB-16020:  Fixed "Zoom To Data" property of the Map
* FB-16064:  Fixed inputs justification
* FB-16077:  Apply "require filter value" rules to Stored Procedure Parameters



# 6.7.0.276 (August 22, 2014)
* FB-14154: added formatting to bulk csv exports (**Backwards Compatibility Enhanced in 6.7.0.277 --> September 4, 2014**)
* FB-15101: Fixed calculated fields filters for DateTime columns
* FB-15184: Improved auto-join algorithm when LEFT joins are used
* FB-15222: Fixed all gauges crash caused by malformed highlight value
* FB-15193: Added possibility to specify log4net config file
* FB-14683: Fixed gauges hover autodrilldown report
* FB-15007: Fixed SP Parameters filters in Dashboards
* FB-14131: Fixed conversion of week day number to week day name for case of mysql DB
* FB-15240: Async Thumbnails generation upon report save implemented
* FB-14832: ExportEncoding setting added
* FB-14527: Properly populate values for the Equals(Select) filters for SP fields
* FB-14842: Do not treat ReportSet as Analysis Grid report unless Detail Report has VG specified
* FB-14232: 3D option for html pie chart hidden
* FB-15037: Added restriction to chart scale value.
* FB-13726: Fixed issues with SP with fusion driver

# 6.7.0.275 (August 12, 2014)
* FB-15034: Fixed drill-down style auto selection in the Advanced field properties
* FB-14792: Fixed bar chart sort with separator
* FB-14723: Fixed Inverted grid export to CSV
* FB-13360: Color highlighting and Value ranges applying to DateTime fields
* FB-15152: Fixed CHart to Picture rendering issue with scroll-bar
* FB-14131: Fixed day of week number, and daysOld function
* FB-14355: Lazy SP metadata pulling
* FB-15069: Fixed footer position processing in html2pdf generator
* FB-15082: Made it possible to override default sql and oracle dataextractors behavior
* FB-15106: Made scale working together with separator for pie charts
* FB-15103: Fixed combine bottom feature for highchart pie chart
* FB-15070: Fixed popup recursion for gauges
* FB-15080: Fixed missing gauge needles in subreport
* FB-15120: Fixed HTML Pie Chart with Separator
* FB-14996: Do not use simple SP execution mode is Records count is specified
* FB-15004: Fixed erroneous chart container height
* FB-14487: Fixed Date columns Equals(Field) filter operator
* FB-15035: Disable redundant aggregate functions for Boolean data type
* FB-14781: Fixed auto-grouping from Expression in Oracle
* FB-15004: Fixed piechart legend overlapping
* FB-14951: userid info added to Message in log.
* FB-14227: Fully localized DatePicker
* FB-14315: Fix js errors for PieChart.
* FB-14488: Optimize Report Viewer tab for narrow screens
* FB-15028: Made reportset renderer to respect changes of reportset.Style in PERS

# 6.7.0.274 (July 30, 2014)
* FB-14902: Fixed XSS security vulnerability in Designer
* FB-14315: Fix pie chart "Combine Bottom" for charts with separator.
* FB-14973: Fixed JS error on reportDesigner page.

# 6.7.0.273 (July 28, 2014)
* FB-13872: Improving CASE statements usage to use it without brackets
* FB-14906: Made click on legend affecting all stacked pie charts
* FB-14669: Filter SQL load report request by current TenantID
* FB-14948: Fixed erroneous adding field from expression to grouping
* FB-14949: Fixed filters without values in the Viewer
* FB-14791: Extended palette of barchart colors.
* FB-13936: Added HTML Report Part control
* FB-14622: Made different users having separate files for databaseSchema cache on HDD if PerUserCaching is true
* FB-14908: Fixed broken stored procedure metadata save to izenda.config
* FB-14756: Fixed grouping by week
* FB-14805: Update report in reports list cache on save.
* FB-13119: Fixed Pagination in Oracle when Sort is used

# 6.7.0.272 (July 15, 2014)
* FB-14548: Unified internal references to jquery as alias jq
* FB-14813: Minor fixes in Designer UI CSS classes added to some controls in the Designer for easier customization
* FB-13982: Implemented ability to utilize multiple or alternate DrillDown keys for sub-reports.
* FB-14224: Columns Width property added to the Report
* FB-14309: Fixed Y-Axis rounding for bar and trend chart. There was wrong values when selected value format "0,000".
* FB-13449: Fixed incorrect CSV export reports with several embedded sub-reports
* FB-14674: Improved reliability of bulkCsv export
* FB-14546: Fixed issues with table borders in XLS and DOC exports
* FB-14725: Enable CSV export for Dashboards

# 6.7.0.271 (July 7, 2014)
* FB-14428: Made stacked pie chart really stacked
* FB-14712: Fixed Legend and Stacked Chart properties auto-selection
* FB-14131: Fixed number of first week in year in mysql DB
* FB-14711: Fixed issues with drill-down reports in HTML Bar Chart caused by FB-14265
* FB-14427: Fixed labels positioning in highchart piecharts with separator
* FB-14396: Fixed not showing highcharts in pdf export due to missing scripts
* FB-14392: Fixed wide charts cutoff in export to word/excel
* FB-14053: FieldCollection getter by column name implemented
* FB-14710: Providing backward compatibility in behavior of ConnectionOpened
* FB-14710: Turned back lost virtual method
* FB-14429: Made charts 100% wide in pdf export
* FB-14623: Improved automatically page breaks in PDF print when Multi Level VG style is used
* FB-14561: Added possibility for easy pagination controls customization
* FB-14603: Fixed calculated fields filters if LEFT JOIN is used
* FB-13988: Fixed Gauges drill-down reports
* FB-14308: Fixed Stored Procedures with a schema name part adding
* FB-13916: Added VisibleDataSources multiple schemes support for Oracle connections

# 6.7.0.270 (June 26, 2014)
* FB-14141: Fixed 'Year and Quarter' function in MySQL Driver
* FB-14628: Show charts indexes in the "Report order" section
* FB-14403: Fixed conflicts between several changes in the Expression behavior
* FB-14467: Boolean operators support added to the Expression feature

# 6.7.0.269 (June 23, 2014)
* FB-14182: Added possibility to use XML format in scheduler
* FB-14430: Fixed dashboard crash when report is modified before save
* FB-14520: Fixed DIV/0 formatting when OData connection is used
* FB-13768: Fixed Filters and Fields adding in IE8
* FB-14486: Fixed report crash when tenantField is specified without any tenants
* FB-14294: Allow to remove all fields from the report in the Viewer
* FB-14296: Fixed filters on the Dashboards page
* FB-14328: Fixed erroneous removal field from "to be grouped" collection if it has itself in expression, and aggregate function is selected
* FB-13937: API INFO logging implementation
* FB-14361: Fixed Line HTML Chart export (Trend chart and Pareto Bar chart)
* FB-14336: Fixed missing SqlOverride value in filters when ExistentValuesList for operators like Equals(Select) is generated with taking into account previous filters
* FB-13449: Improve embedded sub-reports and column grouping/pivots support in the CSV output
* FB-13739: Added information about records amount in dataset which is returned by GetDataSet, to log at INFO level
* FB-14377: Do not crop data labels on the HTML Trend chart
* FB-14217: Fixed filters on calculated columns in the Viewer
* FB-14257: Replace spaces with underscores in the XML output
* FB-14366: Export only Detail and Summary parts to CSV instead of throwing exception if other parts contains in the ReportSet
* FB-14370: Added a setting to configure hard-drive cache location
* FB-14337: Fixed count of the Share With drop-downs in Report and Dashboard Designers
* FB-14265: Made text truncated and last few letters fade to white if label is too long and text orientation is vertical
* FB-14321: Fixed issue with license key when StaticSharedStorage is used
* FB-14145: Do not attach ColumnGroup to the Field Description in the Report Viewer

# 6.7.0.268 (June 4, 2014)
* FB-13960: Fixed issue with displaying base64-encoded images
* FB-14116: Fixed enable/disable subtotal logic in the Viewer
* FB-14089: Allow to use arithmetic "-" operator with Date data type fields
* FB-14285: Do not use Viewer browser dimensions in the Preview render
* FB-14112: Fixed "Field-Value column pairs" feature behavior in Dashboards
* FB-14221: Allow to use special characters(backslash, single/double quote, etc.) in the Chart a titles
* FB-14101: Fixed images rendering in PDF output if the client browser is IE8
* FB-14237: Fixed issue with adding new filters after removing some filters in the Viewer
* FB-14170: Hide/Show Advanced properties of the Charts when it's needed
* FB-13811: Implemented value ranges feature for chart separator

# 6.7.0.267 (May 30, 2014)
* FB-14250: Fixed CROSS join
* FB-14236: Fixed cascade filters update when filter values are changing rapidly.
* FB-14215: Fixed error after filter removal when filter logic is used.
* FB-13986: Fix color setting (#RRGGBB) for gauges.
* FB-14148: Fixed numerous issues with HTML Charts exporting and Viewing.
* FB-14108: Do not include HTML tags in CSV export.
* FB-13539: Implemented Auto 'Group' support for all other aggregate functions also.
* FB-14121: Preview container now appear only on Preview tab in report designer
* FB-14118: Fixed CSV export failure when data contains double quotes
* FB-13766: Enable datepicker for non-English cultures
* FB-13765: Fix rounding in the Animated Half Circle Gauges.
* FB-14144: Prevented erroneous grouping by fields from expression if no aggregation is involved in report.
* FB-13600: Made fields with expression not affect grouping.
* FB-14121: Enable caching of visualization files
* FB-14140: Fix Chart appearance on 'hover' when master report is not saved.
* FB-13539: Made fields from expressions automatically added to group by clause if needed.
* FB-14046: Properly apply Drill-Down filter if both master report and sub report have Between filter on the same field as a Drill-Down Key.
* FB-13557: Made bulk csv output generator to stream date from DB to client
* FB-13889: Switched CacheReports default value to true
* FB-13762: Fix formatting when VG, Pagination and Subtotals are used at the same time.
* FB-14113: Do not show 'null' for empty regions on the Map if hover sub-report is used.
* FB-14108: Do not include HTML tags in CSV export.
* FB-13978: Loggers conflict fixed
* FB-13889: Optimized reports table existence checks.
* FB-13372: Disable "Show Legend" check-box if Separator is not selected.
* FB-13971: Respect "Records" value when calculating subtotals.
* FB-13762: Fix formatting when pagination is used with VG.
* FB-14062: Fix Tennessee short name on the USA map.
* FB-13940: Do not copy embedded resources in the Scheduler output.
* FB-13834: Allow to use multiple-value filters for storage procedure fields
* FB-14037: Prevent throwing exception when same name is found several times in the AdHocSettings.VisibleDataSources collection.
* FB-13954: Fix issue with reports storage in the DB after invalidating reports cache.
* FB-13941: Fixed erroneous brackets removal from field description when they are specified in field alias.
* FB-13713: Made fields/filters against HiddenColumns invisible in reportViewer.
* FB-13946: Fix filters inheritance in sub-reports when filters on calculated columns are used.
* FB-13967: Removed unused button for toolbar
* FB-13950: Made all connections/dataReaders always reliably disposed, made every dataReader use separate connection object, fixed throwing exceptions in ReportClearTemplateName
* FB-13950: Ensured that all connections which are opened in DLL are always reliably closed after usage
* FB-13950: Ensured that each reader uses individual connection object, and that that connection is closed after reader is closed .
* FB-13950: Removed unnecessary connection closings
* FB-13950: Ensuring that every datareader closes connection when it finishes work
* FB-13950: Enclosed all datareaders in using()
* FB-13967: Removed unused button for toolbar
* FB-13950: Fix of System.Exception: ReportName property unknown. and System.Exception: ReportCategory property unknown. errors
* FB-13857: Fixed high charts with '%' value format
* FB-13947: Implement drill-down reports in HTML Bar Charts.
* FB-13938: Fixed stored procedures serialization/deserialization error

# 6.7.0.266 (May 7, 2014)
* FB-13933: API error level logging implemented
* FB-13915: Fix issues with Form loading in the Designer caused by the changes in FB-13523
* FB-13715: Allow to export reports to RTF with a single VG field
* FB-13689: Avoid crash if iTextSharp DLL isn't present
* FB-13587: Data Access Layer INFO logging implemented
* FB-13846: Fixed "index out of range exception" for pie chart with 0 values
* FB-13484 Map tab country/state label updates correctly
* FB-13414 Add switching back to simple data source mode
* FB-13885: Fixed crash when switching filter operator from Between to InTimePeriod
* FB-13755: Changed pagination to entering record number
* FB-13718: Made reports with pagination return ExportLimit reports when printing to HTML
* FB-13530: Filter description behavior fix in reportViewer UI
* FB-13826: Fixed crashing pie chart in reportPart window when hovering mouse over it

# 6.7.0.265 (May 1, 2014)
* FB-13532: Fix date-picker if cascade filters values load too slowly
* FB-13613: Do not use pagination in Viewer if Analysis Grid or Visual Group Hierarchy is used
* FB-13725: Apply Filter Logic to the Pivots sub-queries
* FB-13792: Added separator titles for pie chart
* FB-13760: Fix Between Filter Operator for calculated columns
* FB-13745: Use images URLs instead of base-64 data in IE8
* FB-13587: Added creation of default log4net configuration file
* FB-13523: Forms data now loads for every report individually only at the moment of its execution, and doesn't load during just opening reportList
* FB-13361: Apply AdHocSettings.CurrentUserTenantId filter to the list reports SQL if DatabaseAdHocConfig is used
* FB-13467: Optimization of initialization-related routines and CheckLimitation() calls
* FB-13282: Attach subtotals to the Form report in order
* FB-13675: Fixed thumbnails generation in case of Dashboard reports
* FB-11797: Fixed out of memory exception caused by many simultaneous thumbnail generation threads, by introducing queue for thumbnails generation
* FB-13640: return default button returns default now
* FB-13746: Fixed loss of NOT flag in filter properties during manipulations from modern reportViewer
* FB-13659: Added missing css to reportViewer
* FB-13723: Added hiding Visualizations if no visualizations were found
* FB-13263: Fix asynchronous loading of the ReportPart controls.
* FB-13414: add switching to simple mode for datasources tab
* FB-13526: the auto-selection in indicator bar is disabled
* FB-13711: Auto refresh Quick Add dialog until fields list is populated
* FB-13730: Fix HTML Charts exporting to RTF when ReportSet has category
* FB-13715: Show error text in the output body instead of throwing exception if there is an error during Chart rendering in RTF export
* FB-13691: Fix Embedded subreports filters inheritance
* FB-13687: Changed log4net configuration file to log4net.xml
* FB-13706: Fix drill-down subreports when special characters are used as a drill-down key values
* FB-13679: Added the ability to process HTTP POST Requests in OData Fusion Connection.
* FB-13683: Implemented percent symbol escaping in filter value when LIKE is applied to filter value in sql query
* FB-13547: Behavior fix - made ItemsPerPage to be ignored if UsePagination is disabled
* FB-13661: Fixed bug in datasources joining when switching in reportDesigner from simple to advanced mode
* FB-13639: AdHocSettings.EmptyReportString setting added, this setting can be used to configure the message shown when reports return an empty result
* FB-13674: Fixing HintPath for log4net dll in AdHoc2012.csproj
* FB-13687: Logging @ERROR level for Data Access Layer
* FB-13665: Made FusionCache taking into account .SqlOverride members of Filter/Field during cache key calculation
* FB-13587: log4net infrastructure, and data access layer@ERROR level logging implemented
* FB-13646: Implemented drill-down subreports in Detail report when rendered in ReportPart
* FB-13634: Prevent showing all Filters (even with Parameter = false) in the Report Viewer when any filter is removed
* FB-13449: Implemented limited support of embedded subreports in csv output generator

# 6.7.0.264 (April 14, 2014)
* FB-13579: Disable toolbar if no datasources are selected
* FB-13592: Improved combine bottom mechanism for Pie chart
* FB-13345: Fix issues with custom category separator - AdHocSettings.CategoryCharacter
* FB-13590: Allow to use Formats in Charts for Date and DateTime fields + allow to use custom formats
* FB-13582: Fixed glitch in code which spontaneously could cause exception inside cycle, and as a hence early exit from cycle, which led to missing custom DashboardFilters control in Dashboards page, though all conditions are met.
* FB-13535: Fixed error which was caused by application of aggregate function in Gauge to Label column independently on presence/absence of aggregate function in Value column in case when calculated field from Fields report is selected in Value column
* FB-13450: Show Print buttons in Dashboard designer
* FB-13382: Made calculated field description appearing in bar chart legends
* FB-13305: Fixed map-related part of reportSet validation to restore correct Preview availability behavior
* FB-13546: Solve issues with Title and Description in the CSV output
* FB-13556: Allow editing Label Justification in the newly created report
* FB-13413: Limited stored procedures returned by FusionDriver by only those which are enlisted in VisibleDatasources, in the same way like it works now in usual drivers
* FB-13517: Show All available filter operators if type of the column is unknown.
* FB-13561: Copy all Filter properties (Like Operator, OrIsBlank, etc.) from the master-report to the sub-report in Forms
* FB-13329: Improved custom color setting for highcharts
* FB-13486: Added data source categories sort for instant report page.
* FB-13515: Fixed problems with changing between Calendar to other date filter types in reportViewer
* FB-13532: Hide Datepicker dialog when filtering on refresh so there are no conflicts between the old and new dialog
* FB-13386: Fixed browser slowdowns by fixing in JS code calendar z-order at the moment of its appearing, instead of repeating calls of function which did the same
* FB-13291: Fixed report title and description not showing when part param exists
* FB-13504: Fix wrong colors for stacked bar chart
* FB-13483: Removed obsolete attribute from ShowSqlOutputButton setings
* FB-12823: Add ability to control Filter dropdown content on a per-column basis
* FB-13329: Add ability to set custom colors for all html chart types
* FB-13439: Keep scroll position in the Equals(Checkboxes) filter when filters are refreshed. Do not send ajax redundant calls for the last or single filter in the Report Viewer
* FB-13507: ListReports cache implementation
* Revert "FB-13269: Prevented showing report data without required filters values specified by user"

# 6.7.0.263 (April 7, 2014)
* FB-13494: Fix jQuery conflicts in the classic Asp.Net interface
* FB-13490: Show "[FieldName] not found" text instead of exception when invalid field is used in the report Title, Description or Footer
* FB-13459: Fix Map image file URL in HTTPS deployments
* FB-13482: Made modern reportList respect setting AllowDeletingReports
* FB-13003: Changes made in PerformCustomReportRendering were missed in html cache. Fixed by correcting order of PerformCustomReportRendering and caching calls
* FB-13444: Enable Autocomplete filter in the HTML Report Viewer
* FB-13408: Apply format of the same field from the Fields to the appropriate date value in filter description.
* FB-13269: Prevented showing report data without required filters values specified by user
* FB-13277: Fix filters refreshing on the Dashboards page in IE11
* FB-13232: Fix Issue with Parameters on the Dashboards page by adding support for POST requests
* FB-13223: Made modern reportViewer respect LockViewer setting
* FB-13435: Fix typo in the ReportList without thumbnails. Change title of the "X" icon from "Edit" to "Remove"
* FB-13432: Fix issues with Summary report when pagination is used
* FB-13411: Fixed brackets escaping in Fields expressions
* FB-13430: Fixed printing reports with highcharts to HTML by switching highcharts rendering to images when printing report to html
* FB-13268: Implementation of adding new filter in modern reportViewer.
* FB-13382: Fix calculated columns (when Arithmetic is used) in Charts.
* FB-13410: Fix artifacts in the Dashboard PDF output is if report with a large number of rows is presented in the Dashboard
* FB-13309: Apply AdHocSettings.FieldAliases to all controls on the Report Viewer page.
* FB-13404: Fix CSV export if Value Ranges is used and Add Subtotals is checked
* FB-13309: Apply AdHocSettings.FieldAliases to all controls on the Report Viewer page
* FB-13381: Fix javascript errors when Equals(Popup) or Equals(Checkboxes) filter is used
* FB-13273: Implementation of FormRenderer compatibility with visualizations like highcharts which render html/js into report body
* FB-10401: Resolved issue where when using multiple datasources all the fields are not immediately available
* FB-13277: Improve toolbar UI on the Dashboards page for narrow screens
* FB-13368: Fix Funnel HTML chart when data in the Label column contain single quotes
* FB-13255: Added function filtering for column dropdowns in the maps tab
* FB-11581: Updated AddForcedLeftJoin method to be capable of usage with custom DB schema. This will allow this feature to work correctly with tables that are not in the "dbo" schema
* FB-13329: Added customization variable for htmlchart barchart colors
* FB-13119: Fixed pagination problems with Oracle
* FB-13240: Added meta tags to force WebBrowser to work in proper (IE9/10/11) mode to resolve issues with chart rendering
* FB-12908: Fix issues with loading Form if ReportSet.OwnerTenantID and AdHocSettings.CurrentUserTenantId do not match
* FB-13290: Manually create HttpContext if it is not initialized and activate StaticSharedStorage in this case. As a result many Izenda functions can be used in the "offline" mode
* FB-13305: Fix drill-down on the World Map for the USA and UK countries

# 6.7.0.262 (Mar 25, 2014)
* FB-13006: Use a filestream to write thumbnail data to improve error reporting when permissions are not set correctly
* FB-13282: Apply AdHocSettings.TenantField filter to the request for the Equals(Select) filter.
* FB-13166: Added support of the MSSQL CASE-WHEN-ELSE-END clause in the Expressions.
* FB-13240: Add trim() function to javascript output used by highcharts
* FB-13267: Fix Equals(Checkboxes) and Equals(Multiple) filters behavior in the Report Viewer. It was impossible to check/select value if it is a single digit or single char
* FB-13223: Prevented PIVOT tabs from showing in ReportViewer if reportSet is Locked
* FB-13193: Fix filter logic when hidden filters are used
* FB-13139: Add basic cache usage statistics for static memory mode
* FB-13017: Significantly increase performance in paginated reports with many rows of data (10k+)
* FB-13243: Fix Inverted Grid CSS so it stays up-to-date when modified in the Designer and refreshed in the Viewer
* FB-13240: Provide separate rendering path for exporting when using HtmlCharts charting engine
* FB-13237: Fixed rendering of gauges in thumbnails to include the needle
* FB-13028: Use POST parameters when loading ReportParts
* FB-13119: Fix Text Highlight and Cell Highlight in the paginated report

# 6.7.0.261 (Mar 17, 2014)
* FB-12970: Removed unnecessary ActivateNewDashboardViewerControls() calls from reportViewer
* FB-13193: Fixed problems with previewing reports after modifying Filter Logic
* FB-13106: Resolved issue where tabs were greyed out on the report designer page when VisibleDataSources have been changed

# 6.7.0.260 (Mar 16, 2014)
* FB-13177: Changed "Reset to default" button on Style tab in reportDesigner to standard button control which is used across all designers
* FB-13113: Fixed empty jquery formatNumber result for 0 value
* FB-13025: Resolved issue where HighCharts auto-sizing and auto-centering didn't work because chart as an inner element couldn't detect dimensions of outer container. Implemented support for specifying dimensions in pixels in chart property, so highcharts can rely on those values.
* FB-13181: Fixed inverted Summary grid styling. This makes styles for headers items and alts the same as the normal grid.
* FB-13189: Waiting timeout removed if renderer detects an error at the the beginning of rendering process
* FB-13113: Removed "default" series name in HtmlCharts if only one series has been selected
* FB-13180: Updated copyright in response server
* FB-13164: URL encode fields when updating field properties in report viewer
* FB-13160: Marked FilteredReportListCache as serializable
* FB-11598: Added fusion support for Postgres
* FB-12943: Add support to stored procedures for sql_variant data type as a parameter
* FB-11720: Fixed glitch in htmlcharts, which could result in generation of malformed JSON data
* FB-12970: Removed Templates (Forms), and custom entities from session in staticmemory mode. Basic report designing/viewing no longer stores anything in session
* FB-12970: Added support for logging session contents
* FB-13132: Changed formatting of dates (from filters values) in reportset description to respect AdHocSettings.Culture
* FB-13115: Resolved issue where thumbnails would remain in the "Generating" state
* FB-11684: Added disk/reports cache cleanup functionality to Driver.InvalidateSchemaCache()
* FB-13114: Resolved regression in AdHocSettings.ReloadStrings()
* FB-13081: Resolved redirect loop when AdHocUserKey is specified
* FB-13116: Fixed Equals(Popup) filter when one of the values is empty string. Empty string can now be selected as any other not empty value.
* FB-13103: Fixed "(blank)" value in the filters. "(blank)" value is now interpreted as NULL when selected for example in the Equals(Popup) or Equals(Checkboxes) filter.

# 6.7.0.259 (Mar 9, 2014)
* FB-13036: URL Encode '&' when processed in a drill-down value
* FB-13035: Fixed erroneous adding of excess parameter to SqlCommand when drilldown filter with equals operator presents in reportSet
* FB-13034: Fixed spontaneous loss of database connections
* FB-13026: Added currentUserName verification routine to CheckLimitations routine, to make pure html pages respect RequireLogin setting.
* FB-13012: Fixed unsafe operation on possible null string, which caused error in case of rendering gauges
* FB-12969: Optimized static memory mode to minimize whole memory usage by minimizing objects kept in session and resolved bugs related to CurrentReportSet in static memory mode
* FB-13042: Fix drill-downs with Dates and different grouping types. For example, correct value will be passes to the subreport if drill-down key is a Date field with Group(Year & MN) Function.
* FB-11707: Added LinkedColumns property for Filter and Filter ICloneable interface implementation.
* FB-12979: Default DataCacheInterval to 0 so the HTML cache is disabled by default
* FB-12957: Added additional PostgreSQL type mappings
* FB-12836: FusionConnections getter was made public

# 6.7.0.258 (Feb 27, 2014)
* FB-12933: Make Instant Reports respect AdHocSettings.HiddenColumns
* FB-11781: Fixed bug causing server resources to not be found in Instant Reports and Report Viewer
* FB-12919: Disable default selection of Separator dropdown
* FB-12914: Fixed style issue where custom grid styles subtotals did not apply border color
* FB-11792: Fixed bug affecting loading of ReportSets that could result in null pointer exceptions
* FB-12930: No longer require +HTMLCHARTS in license key to utilize HTML Charts
* FB-12901: Removed extraneous warning message from Dashboard Designer
* FB-12904: Fixed Between filter when values are numeric that can be parsed as dates
* FB-12912: Fixed problem where preview would cache dashboards
* FB-11692: Fixed automatic drilldown ReportSet issue "Report loading error: Report (AUTO) is not found" which impacted gauges in pure HTML
* FB-12834: Fixed "Response canceled: 500 Internal Server Error" when rendering HTML charts to RTF
* FB-12887: Fixed add report part to dashboard modal dialog
* FB-11697: Fixed "Page breaks after visual group" setting for pdf printing
* FB-11807: Enable output to CSV format for Visual Groups of the following styles: CommaDelimited, CommaDelimitedWithLabels, LineDelimited, LineDelimitedWithLabels
* FB-12843: Remove extra empty table after report content. Wrap report content in the extra table so all Reports in the ReportSet will have different and independent widths.
* FB-11792: Added support for arbitrary ordering of columns when executing report against a stored proc without "insert into exec"
* FB-11517: ReportSet.Owner property is changed according to the AdHocSettings.CurrentUserName when report saved using "Save As"

# 6.7.0.257 (Feb 22, 2014)
* FB-11687: Resolved issue with MVC4R2 Instant Reports where the field properties gear was not clickable
* FB-11691: Resolved issue where drop-down lists of equals multiple filters would jump to the top of the list when selecting values
* FB-11619: Added separator support for HTMLCHARTS pie chart
* FB-11621: Fixed chart parameters initialization and extended chart margins to full width
* FB-11621: Format htmlchart numbers from "0000" to "0,000"
* HTMLCHARTS: Fixed tooltip formatting on funnel charts
* HTMLCHARTS: Resolved issue where axis label was cut in half on line charts
* HTMLCHARTS: Fixed problem where pie chart 'CombineBottom%' would rename the smallest slice to 'Other' when it had not been combined with another slice
* HTMLCHARTS: Increased right and left margin for line, bar and area chart
* HTMLCHARTS: Changed top offset of gauges
* HTMLCHARTS: Resolved bug where the description of an applied filter was listed multiple times
* FB-11678: Fixed intermittent "Unable to connect to the remote server" scheduler error
* FB-11808: Changed styles of VisualGroups to make them bolder
* FB-11610: Added support for CustomizeChart to htmlCharts
* FB-11781: Fixed a problem where string filter values were misidentified as dates
* FB-11703: Fixed a bug which prevented switching the PDF outputGenerator to ITextSharp
* FB-11566: Fixed iframe ReportPart where an object reference was not being set to an instance of an object
* FB-11700: Update the user property when reports are saved
* FB-11710: Changed export to respect the formatting of datetime
* FB-11684: Changed rs.aspx?clear=1 to clear schema, fusion, and reports caches
* FB-11682: Resolved concurrency issues when caching reports on load balanced systems
* FB-11726: Fixed bug where "TimeClass" was erroneously shown as a filter description

# 6.7.0.256 (Feb 8, 2014)