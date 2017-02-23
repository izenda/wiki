<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|March 7, 2017|6.10.0.16|25920|Removed dependence on Izenda's rs.aspx from being in the application root folder rather than an Izenda subfolder.|
|March 7, 2017|6.10.0.16|26111|Prevented a null reference exception from being thrown in some circumstances when using an expression to calculate a field and not setting an expression type.|
|March 7, 2017|6.10.0.16|26609|Changed back end code to make it easier for filters to identify calculated fields by a guid rather than description string.|
|March 7, 2017|6.10.0.16|26673|Added support for filterable calculated fields in Instant Reports.|
|March 7, 2017|6.10.0.16|26692|Corrected behavior of stored procedure params when inheriting filters across subreports.|
|March 7, 2017|6.10.0.16|26731|Ensured parent report filters inherit to embedded subreports.|
|March 7, 2017|6.10.0.16|26758|Fixed page break behavior when visually grouping in Analysis Grid style.|
|March 7, 2017|6.10.0.16|26822|Corrected discrepancies in sort order between default and user-triggered sort.|
|March 7, 2017|6.10.0.16|26848|Corrected problems when constructing pivots which caused fields to be hidden in error.|
|March 7, 2017|6.10.0.16|26851|Using VG Hierarchy and Pivot at the same time throws an index exception when exported to PDF.|
|March 7, 2017|6.10.0.16|26864|Expanded setting DataSourceLimit to incorporate Instant Reports.|
|March 7, 2017|6.10.0.16|26873|Fixed some subtotals being dropped from a pivoted analysis grid during excel export.|
|March 7, 2017|6.10.0.16|26877|Added report visibility control to Instant Report toolbar.|
|March 7, 2017|6.10.0.16|26878|Expanded support for custom characters such as # and ^ when creating categories.|
|March 7, 2017|6.10.0.16|26889|Updated angular.js to 1.6.1.|
|March 7, 2017|6.10.0.16|26893|Corrected some conditions under which the Instant Report designer would not properly update field descriptions.|
|March 7, 2017|6.10.0.16|26894|Corrected issue which would prevent subreports from rendering correctly if a parent report has a filter on a calculated field.|
|March 7, 2017|6.10.0.16|26924|Changed handling of special character encoding in column headers.|
|March 7, 2017|6.10.0.16|26926|Corrected page error preventing a column from appearing on the report output if added in the report viewer.|
|March 7, 2017|6.10.0.16|26962|Consolidated some unused scripts to secure internal methods and increase safety.|
|March 7, 2017|6.10.0.16|26980|Fixed handling of url feature to prevent encoding or modification of strings which could lead to bad links built from data.|
|March 7, 2017|6.10.0.16|26981|Cleaned up creation and deletion of temporary files when using the report scheduler.|
|March 7, 2017|6.10.0.16|26983|Changed internal workings of databaseSchema method to be more responsive to report design modification.|
|March 7, 2017|6.10.0.16|26990|Suppressed help text from being appended to the end of a custom url.|
|March 7, 2017|6.10.0.16|27004|Corrected tile bounding and sizing in dashboards to prevent an error which prevents tiles from being extended to the edge of the dashboard page.|
|March 7, 2017|6.10.0.16|27020|Fixed an error which would happen if you attempted to bundle multiple resources through rs.aspx and one of those resources was empty.|
|March 7, 2017|6.10.0.16|27034|Corrected preview not displaying in old version of the Instant Reports designer.|
|March 7, 2017|6.10.0.16|27041|Fixed arrows for datetime calendar control if focus is changed unexpectedly.|

