<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on June 2, 2017.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.19|June 6|25071|Corrected an issue where expressions with a zero in the denominator would render on visualizations as the max 16 bit int.|
|6.10.0.19|June 6|25920|Removed dependence on Izenda's rs.aspx from being in the application root folder rather than an Izenda subfolder.|
|6.10.0.19|June 6|26207|Corrected an issue where visualizations may not render correctly the first time in IE 10 due to a known error with jQuery.|
|6.10.0.19|June 6|27233|Cleared out some unused CSS from resource files.|
|6.10.0.19|June 6|27498|Corrected joining engine to prevent joins from being built incorrectly relative to how they appear in the UI control, for example LEFT joins being reversed in the query.|
|6.10.0.19|June 6|27500|Prevented hyperlinks from being dropped if more than one report part is being displayed on a custom page.|
|6.10.0.19|June 6|27512|Tweaked CSS of visual groups to maintain consistent padding in the Analysis Grid.|
|6.10.0.19|June 6|27513|Changed encoding of special characters in URL when being passed through the URL feature from data.|
|6.10.0.19|June 6|27515|Fixed dashboard filtering behavior when inheriting filters upwards from a subreport being called from a report part on a dashboard.|
|6.10.0.19|June 6|27529|Deleting a Virtual Data Source now updates the data source cache.|
|6.10.0.19|June 6|27565|Increased the number of internal exceptions which display a stacktrace along with the exception.|
|6.10.0.19|June 6|27569|Corrected change which permitted (broken) pagination behavior in the popup. Pagination of results should be ignored in popup and hover drilldown styles.|
|6.10.0.19|June 6|27590|Corrected the application of formats to values when exporting to Excel and using the "Show Fields/Summary in Field Value" checkbox.|
|6.10.0.19|June 6|27595|Enabled more email output types for the scheduler when using Instant Reports.|
|6.10.0.19|June 6|27606|Fixed some incorrect behavior when placing subcategories in similarly named categories (subcategory 'Cat/Cat' appears in the 'Cat Cat' category instead of the 'Cat' category).|
|6.10.0.19|June 6|27613|Improved performance of ajax error notifications in popups.|
|6.10.0.19|June 6|27619|Corrected some custom formats being output as text instead of numeric (or other specified datatypes) when exporting to Excel.|
|6.10.0.19|June 6|27624|Prevented header, description, and footer from being removed from an unsaved report under some rare circumstances.|
|6.10.0.19|June 6|27649|Corrected issue related to a datetime, grouped by week, which is being passed as the drilldown key to a subreport. Some days were being placed in the wrong week grouping.|
|6.10.0.19|June 6|27690|Added new setting, UseStrictDateTimeFilterParsing, which is a bool that determines if a Between date filter uses time as well as date (true) or just the date portion (false) of a datetime. The default value is false.|
|6.10.0.19|June 6|27728|Corrected Instant Report filter behavior where the second value in a two part filter may sometimes not appear in a popup.|
|6.10.0.19|June 6|27729|Fixed some inconsistencies around setting a default category via code on Dashboards.|
|6.10.0.19|June 6|27745|Ensured that running InvalidateSchemaCache clears all in memory caches as well as disk caches.|
|6.10.0.19|June 6|27779|Prevented a rare exception which could occur in the language resource files related to the PleaseEnterValidValueFormat string.|
|6.10.0.19|June 6|27787|Prevented the popup calendar for a customized date field from appearing on a printed (PDF and HTML) export.|




