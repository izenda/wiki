[[_TOC_]]

# 6.7.0.257

* FB-11619: Implementation of separator support in HTML pie chart
* FB-11621: Fix wrong chart parameters initialization in some cases.  Fix full width chart margins
* FB-11621: Format htmlchart numbers with comma "0,000"
* HTMLcharts: Fixed tooltip formatting for Funnel chart
* HTMLcharts: Fixed Axis labels cut in half for line chart
* HTMLCharts: Fixed Pie Chart 'CombineBottom%' functionality erroneously renaming single smallest slice 'Other' which has not been combined with another slice
* HTMLcharts: Increased right and left margin for line, bar and area chart
* HTMLcharts: Changed top offset of gauge
* HTMLcharts: Changed generation of description in filters
* FB-11678: Fixed intermittent "Unable to connect to the remote server" scheduler error
* FB-11808: Fixed styles of VisualGroups to make them bolder
* FB-11610: Support of CustomizeChart implemented for htmlCharts
* FB-11781: Issue of filter values mixing up was fixed, by fixing bug which caused occasional treating numeric/string values as dates.
* FB-11703: Fix of bug which didn't allow to switch PDF outputGenerator to ITextSharp
* FB-11566: Fix iframe ReportPart where an object reference was not being set to an instance of an object
* FB-11700: Update user property on report save
* FB-11710: Change export to respect formatting of datetime
* FB-11684: Change rs.aspx?clear=1 to clear all caches - schema, fusion, and reports
* FB-11682: Resolved concurrency issues when caching reports on load balanced systems
* FB-11726: Fixed "TimeClass" being erroneously shown as filter description