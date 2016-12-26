<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

|Expected Release|Tentative Date|Case|Notes|Known Duplicate Tickets|
|:----|:----|:----|:----|:----|
|6.10.0.14|1/10/2017|25823|Using this setting "AdHocSettings.CategoryCharacter = '#'" can cause issues with URL's as it is used in New Dashboard page and New Instant Report page. Updating to properly escape the report name.||
|6.10.0.14|1/10/2017|26040|In some environments visible data sources are not persisting causing reports to be missing on the report list.||
|6.10.0.14|1/10/2017|26147|Removed underscored from multi-word filter descriptions.||
|6.10.0.14|1/10/2017|26183|ValidateBeforeSave setting displaying errors which are invalid.||
|6.10.0.14|1/10/2017|26242|Nulls are now aggregated together in a pivot instead of being discarded.||
|6.10.0.14|1/10/2017|26270|Added more relative paths to visualizations and other resources to prevent 404s when loading report part components.||
|6.10.0.14|1/10/2017|26273|Update behavior of record count in dashboard tiles. This limit should reflect record limit set on report parts set in the report record limits for each report part. This can be altered in the dashboard if user has permissions to flip the tile and access the record count.||
|6.10.0.14|1/10/2017|26299|Added ability to refresh dashboard items in the gallery. Add the following to the global file and these options will appear on the refresh menu in the dashboard. public override Dictionary<string, int> GetAutoRefreshIntervals() { var result = new Dictionary<string, int> { { "Every day", 60 * 60 * 24 }, { "Every hour", 60 * 60}, { "Every minute", 60}, { "Every 5 seconds", 5 } }; return result; }|26324|
|6.10.0.14|1/10/2017|26311|Fixed error which would occur if a field comparison filter were used in a popup subreport. The report would fail saying that the filter value could not be found.||
|6.10.0.14|1/10/2017|26313|Prevented a situation where custom css on one dashboard tile could override the css of another tile.||
|6.10.0.14|1/10/2017|26336|Fixed problem which prevented left joins from being recognized when using table aliasing on self-join.||
|6.10.0.14|1/10/2017|26343|Corrected a problem with stacked bar charts in auto visualization which would cause the bar elements to render in reverse order from the chart legend.||
|6.10.0.14|1/10/2017|26357|Fixed an error preventing popup subreports from displaying from a Form.||
|6.10.0.14|1/10/2017|26370|Corrected a set of linked bugs relating to grouping by date in filters, dates cascading improperly in filters, as well as dates not properly respecting culture settings.||
|6.10.0.14|1/10/2017|26383|_INTERNALDOTCHAR_ showing on scheduled CSV column headers where a "." exists in the column name.||
|6.10.0.14|1/10/2017|26389|Heatmap results change in visualization when using the setting to hide grid.||
|6.10.0.14|1/10/2017|26395|Clarified behavior of Auto Chart - Pie, when using the 'Other' slice setting - these other values cannot be used for a subreport or drilling to another level of data on the same report.||
|6.10.0.14|1/10/2017|26397|When exporting to CSV system generates TMP files and they are not being properly removed from temp directories.||
|6.10.0.14|1/10/2017|26416|AdHocSettings.ShowDistinct ensure distinct text box is shown or hidden based on the setting and that query will remove distinct setting if datatype does not support this function.||
|6.10.0.14|1/10/2017|26442|Custom URL field should not be available for any field if a subreport is already configured for that field.||
|6.10.0.14|1/10/2017|26461|Calendar Visualization advanced setting options do not work properly in the New Instant Report page.||
|6.10.0.14|1/10/2017|26485|When inserts a new row in the middle of a field list all field functions are shown and are not limited by the field's data type||
|6.10.0.14|1/10/2017|26506|Corrected a problem which would prevent datetimes in non-US culture settings from being exported to Excel properly.||
|6.10.0.14|1/10/2017|26532|Corrected error when encoding datetimes which would sometimes cause them to be wrapped in bad HTML when exported to Excel.||
|6.10.0.14|1/10/2017|26540|Corrected a null reference error which could happen when filters are applied to a calculated field which is on a report using a stored procedure joined to a table or view.||
