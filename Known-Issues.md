<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

|Expected Release|Tentative Date|Case|Notes|Known Duplicate Tickets|
|:----|:----|:----|:----|:----|
|6.10.0.13|12/6/2016|24690|Error appears if a user clicks on the Smart Tag button in the Form designer rather than the dropdown.||
|6.10.0.13|12/6/2016|25823|Using this setting "AdHocSettings.CategoryCharacter = '#'" can cause issues with URL's as it is used in New Dashboard page and New Instant Report page. Updating to properly escape the report name.||
|6.10.0.13|12/6/2016|25902|Adding splash page when new window for opened for printing as browser does not support ajax requests while this is open.||
|6.10.0.13|12/6/2016|26037|Updated HTML charts to avoid having scroll bars in dashboard tiles. Charts should size within the container.||
|6.10.0.13|12/6/2016|26081|If user adds a join alias to the first join and it is the same type of alias that is used by Izenda auto aliasing, example "Orders2" for the first instance of the Orders table, the system is not checking that this alias is already used. This causes errors in the join as the alias is duplicated.||
|6.10.0.13|12/6/2016|26100|When using Visual Group and Field Value styling, some subtotals are not correctly calculated.||
|6.10.0.13|12/6/2016|26128|When clicking the edit report button on the back of Dashboard tiles, the user is redirected to the report designer even when the report was created in the Instant Report designer.||
|6.10.0.13|12/6/2016|26133|Unnecessary database query causing error when editing pivots in new Instant Report page.||
|6.10.0.13|12/6/2016|26135|Error prevents datetime formatting from being applied correctly to the separator field of a chart.||
|6.10.0.13|12/6/2016|26142|Re-implemented ability to use popup style subreport on one subreport and have another popup defined in that subreport. The first popup will close when the second is opened.||
|6.10.0.13|12/6/2016|26144|Adding support of AdHocSettings.DefaultTable setting in new Instant Report page.||
|6.10.0.13|12/6/2016|26150|Null reference error received when using some grouping functions.||
|6.10.0.13|12/6/2016|26153|When creating a report with multiple self joins to the same table, if user is not setting the alias, some reports are not saving the join properly.||
|6.10.0.13|12/6/2016|26155|"Save As" not working properly when report contains and apostrophe.||
|6.10.0.13|12/6/2016|26176|When using more than one arithmetic function in a report the report becomes corrupted as there appears to be two fields without descriptions.||
|6.10.0.13|12/6/2016|26178|When comma is contained in a field value which is used for subreport drilldown, the drilldown function is not working.||
|6.10.0.13|12/6/2016|26184|Fixed the application of boolean filters to apply correctly during filter refresh.||
|6.10.0.13|12/6/2016|26200|When using New Instant Report page, if user clicks on a field multiple times quickly the preview is sometimes incorrect||
|6.10.0.13|12/6/2016|26202|Additional changes for 26001, when using drilldown in Pivot grid to ensure no further issues based on values in column headers of pivoted data.||
|6.10.0.13|12/6/2016|26219|Error causing filters to invalidate or disappear if they were built from fields calculated in virtual data sources.||
|6.10.0.13|12/6/2016|26272|Changed doc type to prevent pagination from rendering an extra blank page in Internet Explorer.||
|6.10.0.13|12/6/2016|26273|Update behavior of record count in dashboard tiles. This limit should reflect record limit set on report parts set in the report record limits for each report part. This can be altered in the dashboard if user has permissions to flip the tile and access the record count.||
|6.10.0.13|12/6/2016|26276|Using the hide grid setting with World Tour visualization, received error "Cannot read property 'o' undefined"||
|6.10.0.13|12/6/2016|26301|Exported HTML - Pie chart not scaling properly when exporting after scale is increased in settings.||
|6.10.0.13|12/6/2016|26302|Adding ability to create logic in PreExecuteReportSet to force user to add filter values for specific filters. Example: { if (reportSet.Filters.Count < 2) return; bool f1Set = true; bool f2Set = true; if (ReportSet.Filters[0].Value == null || reportSet.Filters[0].Value == "" || reportSet.Filters[0].Value == "...") f1Set = false; if (ReportSet.Filters[1].Value == null || reportSet.Filters[1].Value == "" || reportSet.Filters[1].Value == "...") f2Set = false; if(!f1Set && !f2Set) reportSet.FiltersNotSpecifieldMsg = "You must set values for at least one of the first two filters." }||
|6.10.0.13|12/6/2016|26306|Corrected problem that would cause numeric fields in the summary grid to drop formatting if they were not on the first page of a pagination.||
|6.10.0.13|12/6/2016|26254|Enhanced case statement functionality to ensure that grouping data after case on multiple fields results in one row of data.||
|6.10.0.13|12/6/2016|26257|When AdHocSettings.SortColumnNames is set to False it does not disable alphabetical sort of fields in the Report Designer or Instant Reports.||
|6.10.0.13|12/6/2016|26334|Some labels of Funnel Auto Chart are being cut off in the New Instant Report page.||
|6.10.0.13|12/6/2016|26372|New category is not saved when changed while editing report in the new Instant Report page.||
|6.10.0.13|12/6/2016|26389|Heatmap results change in visualization when using the setting to hide grid.||
|6.10.0.13|12/6/2016|26405|In new Instant Reports, Pivot side totals are not properly calculating when pivots have more than 100 columns.||
|6.10.0.13|12/6/2016|26410|Added quotes to TenantID in query which generates Izenda table in database report storage mode in PostgreSQL.||
|6.10.0.13|12/6/2016|26411|Updating Reference Implementation for MVC kits to default to New Instant Report page.||
|6.10.0.13|12/6/2016|26413|When adding a subreport to an X-axis on visualization the null values display as index values instead of null.||



|Expected Release|Tentative Date|Case|Issue|Known Duplicate Tickets|
|:----|:----|:----|:----|:----|
|6.10.0.14 |1/10/2017|26336|Fixed problem which prevented left joins from being recognized when using table aliasing on self-join.||
|6.10.0.14 |1/10/2017|26343|Problem with stacked bar charts in auto visualization which would cause the bar elements to render in reverse order from the chart legend.||
|6.10.0.14 |1/10/2017|26270|Adding more relative paths to visualizations and other resources to prevent 404s when loading report part components.||
|6.10.0.14 |1/10/2017|26311|Error occurring if a field comparison filter used in a popup subreport. The report fails saying that the filter value could not be found.||
|6.10.0.14 |1/10/2017|26242|Nulls discarded in pivot instead of aggregating.||

