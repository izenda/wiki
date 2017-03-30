<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tenative and expected to change. Last updated on March 30, 2017.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.17|April 4|25992|Corrected some broken behavior around AdHocSettings.EmbedReportInServerEmail.|
|6.10.0.17|April 4|26226|Corrected behavior of Hover drilldown style in Gauges tab.|
|6.10.0.17|April 4|26415|Corrected inconsistency which could allow hidden filters to override tenantid in some cases.|
|6.10.0.17|April 4|26539|Removed ability to add duplicate tiles to Dashboard.|
|6.10.0.17|April 4|26591|Optimized memory usage when rendering Visualizations.|
|6.10.0.17|April 4|26673|Added support for filterable calculated fields in Instant Reports.|
|6.10.0.17|April 4|26798|Corrected issue which could sometimes prevent field descriptions from loading when using Instant Reports.|
|6.10.0.17|April 4|26851|Using VG Hierarchy and Pivot at the same time throws an index exception when exported to PDF.|
|6.10.0.17|April 4|26962|Consolidated some unused scripts to secure internal methods and increase safety.|
|6.10.0.17|April 4|26975|Corrected oversight which swapped dd/mm date format in date filters for mm/dd even when using a culture token override.|
|6.10.0.17|April 4|26988|Updated Ajax requests across Izenda to minimize browser hanging.|
|6.10.0.17|April 4|26992|Improved handling of special characters, spaces, and tabs in filter values when using multi-line populated filter operators.|
|6.10.0.17|April 4|27073|Modified date filters to prevent first portion of a date range from being set to a later date than the last portion of a date range.|
|6.10.0.17|April 4|27089|Fixed some gaps which allowed XSS and scripts to run in a report even when ApplyAntiXssToReportOutput = true;|
|6.10.0.17|April 4|27101|Suppressed internal designation of "field@group" from appearing in a fieldl description in Instant Reports when using a group header.|
|6.10.0.17|April 4|27108|Corrected "Invalid Column Name" error when joining a virtual data source to a normal data source.|
|6.10.0.17|April 4|27113|Tweaked error messages in Instant Reports to make them more visible to the user and harder to click past.|
|6.10.0.17|April 4|27120|Fixed a discrepancy in how the report viewer and report designer handle the "..." ellipsis character in a filter using the equals checkbox operator. This could cause the first value in a filtered list to be missing.|
|6.10.0.17|April 4|27129|Prevented setting expression type without an expression present.|
|6.10.0.17|April 4|27158|Corrected csv export error claiming a datasource has an invalid object name when using a stored procedure in a Fusion environment.|
|6.10.0.17|April 4|27175|Corrected a missing font error in bootstrap.min.css in the 6.10.0.16 reference implementation.|
|6.10.0.17|April 4|27182|Added ability to recognize and accept secured http connections to scheduler.|
|6.10.0.17|April 4|27205|Removed extra line added when exporting report with embedded subreport to Excel.|
|6.10.0.17|April 4|27223|Fixed scheduler error which can change the value of AdHocSettings.ResponseServer.|
|6.10.0.17|April 4|27224|Corrected error which caused scheduler to override the ResponseServer setting.|
|6.10.0.17|April 4|27231|Reimplemented how and when UpdateSchemaCache is called in a new session.|
|6.10.0.17|April 4|27238|Changed how javascript is defined in response to a recent Chrome update (57.0.2987) that can result in odd UI behavior as critical variables are dropped from browser memory.|
|6.10.0.17|April 4|27256|Cleaned up and made unavailable some incompatible filter operators when selecting a stored procedure parameter in Instant Reports.|
|6.10.0.17|April 4|27257|Changed when scrollbars display on Dashboards to make them appear less often, especially when unnecessary.|
|6.10.0.17|April 4|27258|Made friendlier errors in Dashboards when loading an empty title in Gallery mode.|
|6.10.0.17|April 4|27306|Corrected issue with Instant Reports not passing a value correctly in a datetime filter when moving from report viewing to editing.|

