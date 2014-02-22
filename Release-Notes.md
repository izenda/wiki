[[_TOC_]]

# 6.7.0.257
* FB-11687: Resolved a problem with MVC4R2 Instant Reports where the field properties gear was not clickable
* FB-11691: Fixed a bug that caused drop-down lists to jump to the top of the list when selecting values
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