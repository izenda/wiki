#6.9 Release Notes Archive

[[_TOC_]]

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