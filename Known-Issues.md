<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on July 7, 2017.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.20|July 11|25920|Removed dependence on Izenda's rs.aspx from being in the application root folder rather than an Izenda subfolder.|
|6.10.0.20|July 11|27498|Corrected joining engine to prevent joins from being built incorrectly relative to how they appear in the UI control, for example LEFT joins being reversed in the query.|
|6.10.0.20|July 11|27723|Added support for long text descriptions on dashboard tiles. Long descriptions will be truncated at a certain limit, but the full text will be displayed in a hovering tooltip.|
|6.10.0.20|July 11|27724|Refactored code to better support Require.js and Angular.js.|
|6.10.0.20|July 11|27750|Made export limit setting apply to subtotal query when exporting.|
|6.10.0.20|July 11|27759|Expanded support for stored procedures which only use IN parameters.|
|6.10.0.20|July 11|27767|Corrected format being lost from pie charts when editing report.|
|6.10.0.20|July 11|27769|Fixed conflicts between different culture settings if AdHocSettings.Culture conflicts with culture specified in the web.config.|
|6.10.0.20|July 11|27775|Corrected an issue related to exporting inverted grids to excel.|
|6.10.0.20|July 11|27808|Ensured table filtering from Auto Chart visualization activity is reflected in print mode.|
|6.10.0.20|July 11|27814|Corrected issue preventing datetimes from being used as a drilldown key if there is a culture token mismatch between parent and child reports.|
|6.10.0.20|July 11|27818|Fixed popup calendar for custom date using Instant Reports.|
|6.10.0.20|July 11|27819|Changed BulkCSV to apply a default format rather than display a blank cell for an unsupported format.|
|6.10.0.20|July 11|27820|Properly flagged fields calculated via expression as calculated for the purpose of filtering.|
|6.10.0.20|July 11|27821|Prevented reports from sharing filter settings and values when more than one report is open in the same browser session and both are refreshed simultaneously.|
|6.10.0.20|July 11|27823|Fixed object reference error which can arise when a filter with multiple listed numerical values is applied to a calculated field.|
|6.10.0.20|July 11|27844|Corrected some errors related to escaping brackets when using the native SQL REPLACE() function.|
|6.10.0.20|July 11|27880|Corrected an error preventing hidden filters from applying to filter population in some circumstances.|
|6.10.0.20|July 11|27912|Fixed some dashboard loading problems when dashboards and report parts were being saved with the same name across tenants.|
|6.10.0.20|July 11|27913|Refactored HttpContext.Current.Items to manage request cache.|
|6.10.0.20|July 11|27933|Corrected an issue preventing pivot behavior overrides from producing correct output.|
|6.10.0.20|July 11|27934|Fixed placement of 'United Kingdom' and 'Hong Kong' strings in World Tour visualization.|
|6.10.0.20|July 11|27970|Corrected error which could occur when using visual groups on an unsaved report lacking a report name (rn property).|
|6.10.0.20|July 11|27982|Prevented a Null Reference Error which could occur if a dashboard cannot find cached source reports while loading.|





