[[_TOC_]]
# 6.7.0.259 *Not Released Yet*
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

# 6.7.0.258
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

# 6.7.0.257
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