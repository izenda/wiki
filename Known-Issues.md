<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on August 2, 2017.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.21|August 8|27497|Filter inheritance in subreports was behaving differently in Report Designer and Report Viewer. Now filters inherit consistently across pages.|
|6.10.0.21|August 8|27692|Corrected issue with indicator bars on legacy maps (not visualizations) displaying incorrect values.|
|6.10.0.21|August 8|27734|Fixed thumbnail duplication when dashboards belong to "_global_" tenant, which caused performance hits.|
|6.10.0.21|August 8|27809|Refactored scheduler to be more stable, performant, and support logging.|
|6.10.0.21|August 8|27817|Expanded support for custom formats for datetimes when using filters in Instant Reports.|
|6.10.0.21|August 8|27864|Added truncation to the titles of dashboard tiles when the tile's width is reduced.|
|6.10.0.21|August 8|27877|Refactored Driver.InvalidateSchemaCache to dump cache on all machines in a webfarm when called on one of those machines.|
|6.10.0.21|August 8|27885|Refactored PhantomJS to handle page breaks after visual groups.|
|6.10.0.21|August 8|27901|Small change to dashboards permitting an override for custom sorting of dashboards by name and category.|
|6.10.0.21|August 8|27928|Prevented filters from having their description set to 'null' under some conditions.|
|6.10.0.21|August 8|27930|The following settings were not being respected in Instant Reports v2: HeaderForegroundColor, ItemForegroundColor, ReportHeaderColor, ReportItemColor, ReportAlternatingItemColor, ReportBorderColor.|
|6.10.0.21|August 8|27962|Refactored constraints to prevent duplicate constraints from being created.|
|6.10.0.21|August 8|27996|Made filters update on dashboard tile sync with other report metadata.|
|6.10.0.21|August 8|28002|Modified Timeline Visualization to better support printing and exporting.|
|6.10.0.21|August 8|28010|Some formats, such as percent of group, consistently display on pivots even with zero/null data.|
|6.10.0.21|August 8|28011|Closed some conditions under which popups spawned as subreports of subreports could inherit pagination controls.|
|6.10.0.21|August 8|28012|Slight UI tweak to scheduler controls to make them line up visually.|
|6.10.0.21|August 8|28014|Prevented sessionDataStorage.ProviderAvailable from returning false if Izenda is initialized in offline mode.|
|6.10.0.21|August 8|28064|ExportLimit is now applied to the results of a report after printing and updating the report viewer.|
|6.10.0.21|August 8|28068|Tweaked charts to fit the size of their HTML container when they are isolated as a report part.|
|6.10.0.21|August 8|28071|Prevented an overflow error which could occur if a report had a filter which referred to a field that does not exist in the database schema cache.|
|6.10.0.21|August 8|28084|Refactored AdHocContext.Initialized such that Izenda should not reinitialize when session is null by design.|
|6.10.0.21|August 8|28091|Refactored join code such that HTML entry validation won't trigger on expressions when checking for correct join conditions.|
|6.10.0.21|August 8|28109|Populated UI color selector in new Instant Reports pages with default Izenda colors.|
|6.10.0.21|August 8|28110|Added tweak to properly sort currency values when using Culture to change currency format.|
|6.10.0.21|August 8|28134|Corrected Null Reference Exception in Driver.GetClearSchemaObjectName.|







