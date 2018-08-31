<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. 

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.34|September 4|28853|Prevented page break rendering within embedded subreports.|
|6.10.0.34|September 4|29449|Prevented pivoted table header from rendering on the wrong page when using EvoPdf.|
|6.10.0.34|September 4|29677|Optimized handling of composite constraints.|
|6.10.0.34|September 4|29682|Better handled checks for use of more obscure browsers such as Netscape and Opera.|
|6.10.0.34|September 4|29683|Corrected HTML strings containing Hebrew to be more easily customized and translatable.|
|6.10.0.34|September 4|29689|Optimized behavior of InitializeCombinedConstraints and bulk adding/processing of user defined constraints.|
|6.10.0.34|September 4|29697|Corrected an issue where icons would not be properly displayed on the Instant Reports interface on a duplicated field.|
|6.10.0.34|September 4|29699|Tweaked field highlighting in Instant Reports to be more high contrast and visible.|
|6.10.0.34|September 4|29706|Ensured correct use of CSS resources when exporting a visualization.|
|6.10.0.34|September 4|29707|Improved modal opening/closing in Dashboards and Instant Reports.|
|6.10.0.34|September 4|29708|Made further enhancements to the display of calculated fields in filters in the report viewer.|
|6.10.0.34|September 4|29717|Fixed error where Distinct checkbox in report designer would be disabled by default if AdHocSettings.CacheSchema = false.|
|6.10.0.34|September 4|29722|Prevented use of OR in report filter logic from passing incomplete sets of filter values to a dashboard filter.|
|6.10.0.34|September 4|29735|Corrected Group(Week) function in MySql to properly handle edge cases where weeks may span between years.|
|6.10.0.34|September 4|29740|Optimized how often FilteredListReportsDictionary is called for dashboard tiles.|
|6.10.0.34|September 4|29741|Optimized sequential loading of requests to prevent a lock in application cache.|
|6.10.0.34|September 4|29742|Further enhancements to add more informative error messages.|
|6.10.0.34|September 4|29747|Added extra checks to prevent rare NRE error in Search.|
|6.10.0.34|September 4|29748|Modified internal datatypes to prevent mysterious rounding when performing numerical calculations via expressions in MySQL.|
|6.10.0.34|September 4|29752|Made slight tweaks to make it easier to navigate in dashboard gallery mode when there is only one tile in the gallery.|
|6.10.0.34|September 4|29753|Cleaned up display of visual group headers with embedded reports when exporting to PDF.|
|6.10.0.34|September 4|29754|Corrected UI alignments in filters in Instant Reports.|
|6.10.0.34|September 4|29755|Corrected issue which would cause filters to fail to inherit correctly to a dashboard, if the filter is based on a calculated field which is calculated in a report part which is not being sent to the dashboard. For example, if the filter is calculated on a field in the summary report part, and the detail report part is passed to the dashboard.|
|6.10.0.34|September 4|29765|Prevented clipping of tooltip when hovering over pivoted collection of values on auto chart visualization from within a dashboard tile.|
|6.10.0.34|September 4|29772|Properly escaped backslashes in report urls for reports within categories.|
|6.10.0.34|September 4|29774|Fixed formatting on right side axis for line value on basic bar chart.|
|6.10.0.34|September 4|29777|Corrected missing fields in Advanced options when switching from Funnel chart to another basic chart type.|
|6.10.0.34|September 4|29785|Further fixed translations in UI labeling in Report Viewer.|







