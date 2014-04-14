[[_TOC_]]

# 6.7.0.264 (Release Pending)
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
* FB-13515: Fixed problems with changing between Calendar to any other filter type in reportViewer
* FB-13532: Hide Datepicker dialog when filer on refresh so there are no conflicts between old dialog and newly created dialog
* FB-13386: Fixed browser slowdowns by fixing in JS code calendar z-order at the moment of its appearing, instead of repeating calls of function which did the same
* FB-13291: report title and description not showing when part param exists
* FB-13504: Fix wrong colors for stacked bar chart
* FB-13483: Removed obsolete attribute from ShowSqlOutputButton setings
* FB-12823: Added possibility to control Filter dropdown content on a per-column basis
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