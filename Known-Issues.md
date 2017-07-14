<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on July 14, 2017.

|Expected Release|Tentative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.20.0.21|August 8|27497|Filter inheritance in subreports was behaving differently in Report Designer and Report Viewer. Now filters inherit consistently across pages.|
|6.20.0.21|August 8|27692|Corrected issue with indicator bars on legacy maps (not visualizations) displaying incorrect values.|
|6.20.0.21|August 8|27734|Fixed thumbnail duplication when dashboards belong to "_global_" tenant, which caused performance hits.|
|6.20.0.21|August 8|27809|Refactored scheduler to be more stable, performant, and support logging.|
|6.20.0.21|August 8|27817|Expanded support for custom formats for datetimes when using filters in Instant Reports.|
|6.20.0.21|August 8|27885|Refactored PhantomJS to handle page breaks after visual groups.|
|6.20.0.21|August 8|27901|Small change to dashboards permitting an override for custom sorting of dashboards by name and category.|
|6.20.0.21|August 8|27928|Prevented filters from having their description set to 'null' under some conditions.|
|6.20.0.21|August 8|27930|The following settings were not being respected in Instant Reports v2: HeaderForegroundColor, ItemForegroundColor, ReportHeaderColor, ReportItemColor, ReportAlternatingItemColor, ReportBorderColor.|
|6.20.0.21|August 8|27962|Refactored constraints to prevent duplicate constraints from being created.|
|6.20.0.21|August 8|27996|Made filters update on dashboard tile sync with other report metadata.|
|6.20.0.21|August 8|28010|Some formats, such as percent of group, consistently display on pivots even with zero/null data.|






