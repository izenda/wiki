<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on September 1, 2017.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.22|September 12|23613|Error thrown on input of decimal in comparison filter for days old. If user inputs any decimal the system gives object not set to instance of an object error.|
|6.10.0.22|September 12|27863|Made tile backgrounds in Dashboards more reactive to tile resizing.|
|6.10.0.22|September 12|27905|Additional refactoring of internal RequireJS.|
|6.10.0.22|September 12|27938|Expanded ability to export Auto Chart visualization as an image when exporting/printing in HTML.|
|6.10.0.22|September 12|27959|Refactored internal ReportViewer.js to better handle links in Dashboards.|
|6.10.0.22|September 12|27960|Added a more explicit warning when a user adds a date which is invalid according to the current Culture setting.|
|6.10.0.22|September 12|28085|Prevented Forms from being removed from the underlying report in the case of a TenantID disagreement between the Form and report.|
|6.10.0.22|September 12|28149|Added new setting, AdHocSettings.RasterizedChartWidth, to permit all chart labels to be rendered when a chart is very "wide" and should not be condensed for display or printing.|
|6.10.0.22|September 12|28159|Small refactoring of HtmlReportRenderer.RenderHeader.|
|6.10.0.22|September 12|28160|Corrected export behavior for PhantomJS when using offline mode.|
|6.10.0.22|September 12|28165|Prevented tile Delete icon from being removed when minimizing the Instant Report window.|
|6.10.0.22|September 12|28184|Corrected drilldown passing behavior which could, if a report is using a filter on the same field as the drilldown key, cause the filter to override the drilldown value.|
|6.10.0.22|September 12|28187|Prevented filters from being dropped in Instant Report designer when adding fields.|
|6.10.0.22|September 12|28188|Prevented export related error for the Sunburst visualization.|
|6.10.0.22|September 12|28193|Added more user friendly errors for the Auto Chart visualization when the underlying table has no metric field.|
|6.10.0.22|September 12|28196|Filters now respect padding in data such that values which appear similar but are logically different (such as "Test" and " Test") will be handled properly in filters.|
|6.10.0.22|September 12|28198|Modified behavior of the Remove and Undo buttons when shrinking Dashboard tile to a very small size.|
|6.10.0.22|September 12|28199|Enhanced "No Reports Found" message in Dashboards to be more user friendly.|
|6.10.0.22|September 12|28203|Made further enhancements to sizing of report parts and report part metadata when using report parts independently.|
|6.10.0.22|September 12|28221|Changed Embedded report behavior to ignore drilldownkeys passed in the URL of a subreport being used as both a parent and child. For example, if a report is a subreport of some other report, while also having an embedded subreport itself.|
|6.10.0.22|September 12|28242|Correctly indexed columns in Instant Reports to prevent hidden columns from still being visible in the advanced settings if you clicked on the column header of an adjacent column.|
|6.10.0.22|September 12|28247|Izenda now attempts to scale images used in the header or footer when producing a PDF and the image would otherwise extend "off the page".|
|6.10.0.22|September 12|28263|Refactored use of forward and back slashes for greater ease of use (both should be acceptable for most uses).|
|6.10.0.22|September 12|28271|Corrected some issues with session provider which could cause data sources to be inaccessible.|
|6.10.0.22|September 12|28277|Updated PhantomJS.|
|6.10.0.22|September 12|28288|Corrected some width related issues with Dundas chart rendering.|
|6.10.0.22|September 12|28290|Corrected some memory leaks caused by static regex objects.|







