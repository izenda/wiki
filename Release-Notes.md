[[_TOC_]]

#6.10.0.42 (August 07, 2020)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|ILS-282|Report Design|Gauges|Corrected an issue which prevented display of negative numeric values in gauges.|
|ILS-373|Report Design|Pivots|Fixed a situation where sometimes the pivot control could be removed from the designer page if the pivot were using a calculated field and the report was created prior to version 6.10.0.41.|
|ILS-410|Report Design|Formatting|Pagination prevented the cell highlight, text highlight, and value range features from applying to pages beyond the first. |
|ILS-421|Report Design|Subtotals|When a subtotal is calculated on a datetime subject to timezone shifting, this caused an error in subtotal generation if the same datetime were used in a visual group. The groups per subreport|
|ILS-465|Report Design|Maps|Default settings of indicator bar definition in the user interface on the Maps tab was being set to incorrect values, which would prevent saving the report.|
|ILS-537|Dashboards|Email|Prevented an error which could happen if an email of a dashboard were sent directly from the report viewer. The error can be thrown even if the email operation completes successfully.|
|ILS-556|Settings|Export|Added two new settings, PdfPageSize and PdfPageMargin, which allow for control over page size properties when exporting to PDF.|
|ILS-565|Internal|Encoding|Changed escaping behavior of characters in chart titles by making XssHtmlEncode less strict on these string inputs.|
|ILS-596|Internal|Functions|Made the internal function GetTopLevelAlias public so that it can be overridden for custom filter display behavior.|

#6.10.0.41 (January 24, 2020)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|ILS-82|Internal|Scheduling|Refactored Offline Scheduler code to better handle batch processing of reports scheduled for export.|
|ILS-160|Report Design|Exporting|Corrected date formatting in Excel export of a dashboard which includes visualization report parts.|
|ILS-161|Internal|Settings|Prevented datetime offset adjustments from being applied twice when a report is used as a virtual data source.|
|ILS-175|Internal|Settings|Corrected the safe divide by zero feature to properly work in subtotal expressions when an Analysis Grid visual group style is applied.|
|ILS-186|Report Design|User Interface|Fixed incorrect display of time between generated sql and the time shown on the filter display for the time datepart of a datetime field.|
|ILS-203|Internal|Settings|Exposed the API call Driver.RefreshVirtualDataSources(); which allows for programmatic refresh of all virtual data source reports.|
|ILS-214|Internal|Report Designer|Prevented Instant Report designer from generating a new ReportID on report save, to prevent inability to use SaveReportSet against a variable ReportID.|
|ILS-227|Internal|Query Generation|Modified query generation to properly handle fieldnames which include a period character.|
|ILS-266|Internal|Settings|Made the date smart tag account for datetime offset via the ReportTimeStampTimeZoneOffset setting.|
|ILS-286|Report Design|Filters|Modified Use Previous OR legacy filter parameter to properly account for non visible filters.|
|ILS-299|Internal|Settings|Made Utility.InitFakeHttpContext work properly on a multi-threaded system.|


#6.10.0.40 (October 11, 2019)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|30169|Internal|Internal|Optimized SQL parameter processing when generating cache key, which boosts performance and also prevents a rare error where HTML attachments to scheduled reports could be duplicated and send incorrect information.|
|30519|Internal|Internal|Refactored how often Izenda invalidates its internal report cache to speed performance.|
|30527|Report Design|Dashboards|Brought new tile creation permissions into conformity with report behavior when using dashboards. Now users who have 'view only' or 'locked' rights will not be able to add tiles to a dashboard.|
|30530|Report Design|Exports|Made two changes to image embedding in reports to provide more reliable image inclusion when exporting a report. First, Izenda will directly check a disk location for an image if it fails to load the image via a network call. Second, we added an additional function call to embed images embedding call in the Excel exporting routine.|
|30542|Report Design|Visual Groups|Corrected subtotal generation between visual groups when the string used to define a visual group is only different because of a leading or trailing space. "Test" and "Test " would generate two different visual groups, with combined subtotal rows.|
|30544|Report Design|Exports|Corrected an error where customized chart colors defined via CSS would not be carried over to HTML printing.|
|30549|Report Design|Charts|Fixed gauge needles being off center from the remainder of the rendered gauge if the column width were adjusted after initial render.|
|30573|Report Design|Dashboards|Extended the use of AdHocSettings.ShowDesignDashboardLinks to prevent users with this flag set from creating new dashboards.|
|30589|Report Design|Instant Reports|Charts were visible in Instant Reports even if a license key lacks the +VISION module. This is now corrected so that the Chart tab is not visible under this condition, as chart generation in Instant Reports requires access to Visualizations to work properly.|
|30590|Report Design|Visual Groups|Corrected broken markup for Field Value visual group style.|
|30599|Report Design|Visualizations|Made the error message for visualizations configurable when the specific error of the same date being used as the start and end of a date range causes a report to be considered invalid.|
|30609|User Interface|User Interface|Fixed some subcategories being incorrectly regarded as empty and non-interactive.|
|ILS-70|Internal|Filters|Found and fixed an error when trying to apply hidden filters when using the Fusion driver. If schema is specified but DB name is not specified in the hidden filter key, the hidden filter will not be applied correctly. |
|ILS-75|Internal|Exports|Permitted override of XmlReportOutputGenerator to remap hardcoded tags.|


#6.10.0.39 (June 26, 2019)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|30297|Report Design|Subreports|Modified visualization rendering to be easier to use when embedding the time line visualization as a subreport.|
|30316|Report Design|Dashboards|Prevented the "Cant save empty dashboard" error when saving a Dashboard which has an empty reportset but no tiles.|
|30320|Report Design|Charts|Corrected error preventing the sort order in a chart from being saved, where the error behavior is to default to reverse sort order on the value.|
|30399|Internal|Exporting|Fixed a problem where the print button would only work once in some version of Internet Explorer unless the page is reloaded.|
|30455|Report Design|CSS|Modified ReportList CSS so that reports do not look selected on touchscreen devices.|
|30464|Report Design|Formatting|Refactored text/cell highlighting code to better handle the order in which ranges are defined.|
|30475|Internal|Data|Prevented issue where in some circumstances Fusion would duplicate data in the report caching layer, causing the error "Could not recognize [fieldname]. Use fully qualified name for it."|
|30484|Internal|Dashboards|Prevented a rare dashboard error which throws System.ThrowHelper.ThrowInvalidOperationException when loading a dashboard.|
|30486|Report Design|Filters|Corrected an issue where multivalue filter operators like Equals(Select) and Equals(Multiple) would break other filters when selected.|
|30529|Report Design|Formatting|Corrected some faulty Dutch language translation.|

#6.10.0.38 (April 1, 2019)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|29970|Dashboards|Filters|Corrected situation where incorrect application of culture in dashboard filters results in day/month instead of month/day datetime processing.|
|30109|Report Designer|Filters|Prevented incorrect display of fields which are not aggregated from being shown as calculated fields when populating a filter.|
|30127|Report Designer|Exports|Refactored export code to more reliably detect relative paths to resources to ensure they are not being excluded from report exports.|
|30138|Dashboards|Filters|Corrected placement of date and month components in some datetime dashboard filters being incorrect in culture settings which track datetimes as MM/DD instead of DD/MM.|
|30140|Report Designer|Visualizations|Fixed auto chart visualization to better display bar labels when there are too many objects to label.|
|30145|Internal|Internal|Removed some old code which could cause scripting errors from MVC starter kits.|
|30151|Report Designer|Subreports|Added display of category name next to the report name when calling a report as a subreport.|
|30175|Report Viewer|Internal|Modified obsolete attribute as applied to legacy Report Viewer control to prevent false errors and exceptions.|
|30182|Dashboards|Dasboards|Prevented issues around loading resources into a new dashboard when creating dashboards in Firefox.|
|30188|Internal|Settings|Made the ReportDesignerURL setting care less if it is defined in https and some users access it via http links.|
|30191|Report Designer|Filters|Corrected error which prevented passing an In Time Period filter to a hidden filter when calling a report and passing filters through the URL.|
|30198|Report Designer|Pivots|Made additional fixes to the commit from case 30122 to correct more situations where subtotals are incorrect in pivots.|
|30199|Report Designer|Filters|Corrected filter dropdown errors when selecting a filter value using Internet Explorer.|
|30219|Dashboards|Dasboards|Prevented some errors related to dashboard tile movement and resizing when using Internet Explorer.|
|30221|Report Designer|Filters|Reverted some of the changes made in case 29830 to prevent issues related to filtering on calculated fields.|
|30247|Dashboards|Filters|Changed dashboard filters to more reliably accept filter values passed through the url as pNvalue.|

#6.10.0.37 (December 20, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|29295|Report Designer|Reports|Prevented hidden columns from disappearing from the designer and breaking the report when saving.|
|29936|Instant Reports|User Interface|Upgraded Angular in Instant Reports.|
|29957|Report Designer|Subtotals|Made subreport calculations and behavior consistent when changing number of preview records.|
|29961|Report Designer|Subtotals|Made subtotal behavior consistent when using pagination.|
|29966|Internal|Caching|Refactored caching code of temp tables to increase stored procedure performance.|
|29980|Report Designer|Subreports|Made behavior of embedded subreports consistent when subreports are using various visual group styles.|
|29981|Instant Reports|Filters|Corrected rare bug which could prevent date entry in Instant reports.|
|29991|Report Designer|Visual Groups|Corrected sorting and field order behavior caused by disabling a visual group.|
|29993|Report Designer|Subtotals|Changed subtotal behavior to better account for display of partial tables when using pagination.|
|30007|Dashboards|User Interface|Removed 'Refresh Report' button in dashboards after refactor of dashboard caching and refresh behavior.|
|30051|Report Designer|Exports|Prevented 'Invalid Object Name' error in CSV export when using a Fusion driver with aliased datasources.|
|30055|Dashboards|Reports|Corrected behavior of dashboard tiles when the source report of a dashboard report part is deleted.|
|30070|Report Designer|Filters|Corrected potential faulty filter output when using DoesNotEqualsMultiple filters on an Oracle database.|
|30089|Instant Reports|User Interface|Fixed footer styling of UI elements in Instant Reports.|
|30098|Dashboards|Reports|Fixed null reference exception in dashboards when creating a new dashboard when a prior report part with hidden columns was created.|
|30100|Report Designer|Subtotals|Refactored subtotal behavior and added new setting, AdHocSettings.ShowActualSubtotals. The default value is false, and this retains old behavior. When true, when visual groups are enabled, subtotals are calculated for visible records and not all records.|
|30101|Instant Reports|Filters|Prevented Between(Calendar) filter operator in Instant Reports from pulling current date.|
|30107|Report Designer|User Interface|Corrected some script and resource positioning issues in IE11.|

#6.10.0.36 (November 6, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|26891|Report Design|Visualizations|Fixed overflow tag on popup containers on Visualization to prevent cropping.|
|28253|Report Design|Visualizations|Corrected shading bug for Flowchart visualization when rendering in Edge.|
|29311|Internal|Optimization|Optimized Angular directives.|
|29557|Report Design|Gauges|Refactored Gauge report part to prevent some display errors.|
|29646|Report Design|Gauges|Corrected needle behavior when using the pop up function of the animated half circle gauge style.|
|29647|Report Design|Subreports|Prevented extra tags and rows from being appended to the end of a report when a form is embedded within a form.|
|29681|Report Design|Subreports|Corrected broken markup when embedding a subreport within a field value style visual group.|
|29698|Report Design|Instant Reports|Tweaked display and behavior of field formatting buttons in Instant Reports.|
|29766|Report Design|Visualizations|Enhanced handling of Autogauge visualizations to better handle single column datasets.|
|29801|Internal|Optimization|Refactored FilterList.js.|
|29890|Internal|Optimization|Prevented writing SMTP passwords to logs, for security reasons.|
|29894|Report Design|Subreports|Prevented automatic subreports from being used with Maps.|
|29908|Report List|Categories|Enhanced report list category behavior refactor to include subcategories as well.|
|29917|Report Design|Interface|Corrected issue caused when clicking export controls with expired session which could lead to infinite "loading" icon instead of immediate redirection to login screen.|
|29935|Internal|Optimization|Added serialization attribute to redis session handler class.|
|29939|Internal|Optimization|Optimized driver performance to prevent GetDataSet from being called too often.|
|29947|Report Design|Visual Groups|Corrected discrepancy where some rows could not be formatted when visual groups are used.|
|29952|Report Design|Filters|Corrected behavior of cascading filters when selecting single value after having selected multiple values.|
|29958|Report Design|Pagination|Corrected error resulting in a reset of grid styles when changing pages.|
|29965|Report Design|Instant Reports|Corrected height and usage of height spacing in Instant Reports.|
|29988|Report Design|Charts|Corrected chart legend building to use user culture rather than system culture.|
|29989|Report Design|Formats|Corrected categorization and display of Days Old format.|
|30000|Report Design|Interface|Corrected behavior of report refresh button when using mobile view.|

#6.10.0.35 (October 2, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|29721|Report Design|Data|Fixed some situations where user defined constraints could be ignored in Advanced data source mode.|
|29799|Internal|Performance|Refactored dropdown generation on page to render faster.|
|29816|Report Design|Subreports|Refactored formatting of values used as drilldown keys.|
|29830|Report Design|Filters|Corrected datatype error in filters which would cause reports to filter incorrectly as numerical values would be rounded such that equivalency matches always return false.|
|29838|Report Design|Data|Fixed crash bug if a report runs against an OData connection using Fusion with no Default connection.|
|29857|Report Design|Tables|Modified SubCalculationFilterRegex so as to not ignore fields with some variation of ID in the name. Now this setting is blank by default and can be overridden to ignore some values.|
|29873|Report Design|Subreports|Additional fixes for drilldownkey encoding.|
|29888|Report Design|Tables|Fixed error where changes to Records box would be ignored in a report with a Visualization.|
|29891|Report Design|Subreports|Corrected some drilldown errors which could occur if characters in the drilldownkey were not properly escaped.|
|29892|Report Design|Pivots|Prevented error where columns would not be found in the Group clause if they are automatic subreports generated from a pivot.|
|29808|Internal|Performance|Replaced strings with StandardAggregateFunctionType enums where possible.|
|29220|Report Design|User Interface|Enhanced report lists category handling by refactoring cookies. Now category status and last selected category are saved on a per-user basis.|
|29233|Report Design|Subreports|Prevented column access errors for Automatic subreports when using MySql.|
|29302|Report Design|Filters|Optimized Equals(Autocomplete) for numerics in MSSQL to generate less queries.|
|29483|Report Design|Subreports|Corrected automatic subreport generation to work better when based on a field using an expression.|
|29852|Report Design|Performance|Optimized Value Range feature to perform faster and also correct an error where value aliasing fails to work properly on XML export.|
|29785|Report Design|User Interface|Further fixed translations in UI labeling in Report Viewer.|
|29617|Report Design|Performance|Refactored column handling to correct logic of empty column values.|
|29887|Report Design|Pivots|Corrected object reference which could occur when using subtotal and sidetotal at the same time in a pivot. This fix has been retroactively applied.|
|29747|Report Design|User Interface|Added extra checks to prevent rare NRE error in Search.|
|29828|Internal|Settings|Added AdHocSettings.PreventCSVInjection setting. When true, this will prevent injection of strings which resemble Excel formulas.|

#6.10.0.34 (September 4, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|28853|Report Design|Subreports|Prevented page break rendering within embedded subreports.|
|29449|Report Design|Exports|Prevented pivoted table header from rendering on the wrong page when using EvoPdf.|
|29664|Report Design|Exports|Corrected potential crash and or system hang when scheduling an exported PDF and Izenda tries to pre-process generated HTML before feeding it to PDF converter.|
|29677|Internal|Data|Optimized handling of composite constraints.|
|29682|Internal|Data|Better handled checks for use of more obscure browsers such as Netscape and Opera.|
|29683|Internal|Localization|Corrected HTML strings containing Hebrew to be more easily customized and translatable.|
|29689|Internal|Data|Optimized behavior of InitializeCombinedConstraints and bulk adding/processing of user defined constraints.|
|29697|Report Design|User Interface|Corrected an issue where icons would not be properly displayed on the Instant Reports interface on a duplicated field.|
|29699|Report Design|User Interface|Tweaked field highlighting in Instant Reports to be more high contrast and visible.|
|29706|Report Design|Exports|Ensured correct use of CSS resources when exporting a visualization.|
|29707|Report Design|User Interface|Improved modal opening/closing in Dashboards and Instant Reports.|
|29708|Report Design|Filters|Made further enhancements to the display of calculated fields in filters in the report viewer.|
|29716|Report Design|Maps|Made Zoom to Data on Maps more effective at locating and zooming to the proper area.|
|29717|Internal|Data|Fixed error where Distinct checkbox in report designer would be disabled by default if AdHocSettings.CacheSchema = false.|
|29722|Report Design|Filters|Prevented use of OR in report filter logic from passing incomplete sets of filter values to a dashboard filter.|
|29730|Report Design|Subreports|Prevented object reference error when attempting a drilldown when the parent and child reports are in different culture settings.|
|29735|Internal|Functions|Corrected Group(Week) function in MySql to properly handle edge cases where weeks may span between years.|
|29740|Report Design|Dashboards|Optimized how often FilteredListReportsDictionary is called for dashboard tiles.|
|29741|Internal|Data|Optimized sequential loading of requests to prevent a lock in application cache.|
|29742|Internal|Errors|Further enhancements to add more informative error messages.|
|29748|Internal|Data|Modified internal datatypes to prevent mysterious rounding when performing numerical calculations via expressions in MySQL.|
|29752|Report Design|Dashboards|Made slight tweaks to make it easier to navigate in dashboard gallery mode when there is only one tile in the gallery.|
|29753|Report Design|Exports|Cleaned up display of visual group headers with embedded reports when exporting to PDF.|
|29754|Report Design|User Interface|Corrected UI alignments in filters in Instant Reports.|
|29755|Report Design|Dashboards|Corrected issue which would cause filters to fail to inherit correctly to a dashboard, if the filter is based on a calculated field which is calculated in a report part which is not being sent to the dashboard. For example, if the filter is calculated on a field in the summary report part, and the detail report part is passed to the dashboard.|
|29765|Report Design|User Interface|Prevented clipping of tooltip when hovering over pivoted collection of values on auto chart visualization from within a dashboard tile.|
|29772|Internal|Reporting|Properly escaped backslashes in report urls for reports within categories.|
|29774|Report Design|Charts|Fixed formatting on right side axis for line value on basic bar chart.|
|29777|Report Design|Charts|Corrected missing fields in Advanced options when switching from Funnel chart to another basic chart type.|
|29785|Internal|Localization|Further fixed translations in UI labeling in Report Viewer.|
|29795|Report Design|User Interface|Fixed Highlight Code option in Form designer such that it does not badly format visible code.|
|29800|Internal|Functions|Ensured standardized behavior of functions across different DB standards when regarding rounding of highly precise numbers.|




#6.10.0.33 (August 8, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|29154|Report Design|Internal|Enhanced uniformity among reporttype values to prevent possible problems when internally referring to report parts.|
|29239|Report Design|Pivots|Corrected ODBC error related to "Number of parameter markers is not equal" when using a Group by Datetime function as a pivot header.|
|29339|Report Design|Functions|Cleaned up possible functions in subtotal function list to apply properly by data type.|
|29344|Report Design|Maps|Prevented map shading from disappearing when city or location bars are also mapped on that area.|
|29350|Settings|Optimization|Optimized validation of connection string and implemented a friendlier error message.|
|29373|Internal|Internal|Prevented NRE exception from appearing in get_ReportHeaderColor() in get_Report.|
|29380|Report Design|Formats|Corrected visual based formats such as "Visual Square" and "Heat Map" to display properly when show when ShowHtmlAsCode and ApplyAntiXssToReportOutput are both true.|
|29453|Report Design|Dashboards|Corrected Dashboard error claiming "incorrect syntax near '='" when the Dashboard filters against a calculated field and a report part has a pivot.|
|29481|Internal|Resources|Corrected resource inclusion in exports when Izenda tries to download some resource such as an image to include it in the export but is not successful.|
|29482|Settings|Optimization|Refactored InitDefaultValues to instead use default value initialization on a per-setting basis.|
|29498|Settings|Optimization|Optimized logging by disabling some rarely used logging areas.|
|29537|Report Design|Dashboards|Ensured that visualization record count when the visualization is on a dashboard conforms to local record count settings.|
|29544|Internal|Optimization|Reduced number of calls to PullTables and PullSp when one or more values in VisibleDataSources is invalid.|
|29549|Report Design|Instant Reports|Added tickmark next to current value of preview records in Instant Reports 2.0.|
|29550|Report Design|Subreports|Corrected handling of automatic subreport links when they are attached to a visual group header.|
|29565|Report Design|Subreports|Fixed popup windows so that they properly display in automatic subreports.|
|29569|Internal|Resources|Prevented error related to a false value of File.Exists() when trying to load resources and Izenda can't locate the correct /Resources folder.|
|29573|Report Design|Filters|Corrected filter error preventing filters using calculated fields from being properly passed to dashboards.|
|29574|Report Design|Filters|Corrected filter error which prevented changing operators in report viewer.|
|29577|Report Design|Pagination|Fixed issue related to subtotal generation producing an extra row in table pagination. This error presents as an "index out of range" error in ProcessPagination.|
|29584|Report Design|Pivots|Refactored SQL generation around pivots to prevent errors related to grouped Datetime fields, which would not cause problems in SQL 2008 or 2012 but does cause problems in SQL 2014.|
|29585|Report Design|Translations|Made Help header label translatable.|
|29588|Report Design|Pivots|Corrected pivot related error when using an aliased table.|
|29600|Report Design|Pagination|Corrected pagination controls to be consistent in operation between visible and non-visible increments.|
|29604|Internal|Internal|Enhanced logging for AdHocConfig virtual methods.|
|29605|Report Design|Data|Corrected data vulnerability in log4net usage which could expose directory info in error logs.|
|29606|Report Design|Report Names|Prevented 'Report Not Found' error when there is a special character in the category name of a report.|
|29612|Internal|Resources|Refactored and optimized scripts, particularly FieldList.js.|
|29620|Report Design|Translations|Corrected some Japanese related translation strings.|
|29625|Report Design|Functions|Optimized GetSQL calls on aggregate functions to better handle custom code overrides.|
|29629|Internal|Data|Corrected error related to missing or incorrect column names in stored procedures.|
|29667|Report Design|Pivots|Prevented crash when a pivot is being generated on the fields tab without any other fields outside of the pivot.|
|29669|Report Design|Filters|Corrected issue where filters would not appear when using the legacy style ReportViewer if a report did not use the Fields tab.|
|29670|Settings|Internal|Prevented rare error which could cause AdHocConfig object to be split into two non-synchronized objects.|
|29675|Internal|Data|Ensured that cache is refreshed after "lazy loading" of stored procedure columns.|
|29690|Internal|Resources|Corrected scripted event handlers to work better in Internet Explorer.|



#6.10.0.32 (July 3, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|22038|Internal|Driver|Enabled option to use native Oracle.DataAccess.Client within Oracle driver. Must enable this setting using AdHocSettings.[[UseNativeOracleClient|/API/CodeSamples/UseNativeOracleClient]] = true|
|29222|Internal|Data|Optimized performance of VisibleDataSources when using tables and stored procedures at the same time.|
|29277|Internal|Data|Corrected some filter issues which could arise when using ODBC and filtering against fields with certain datatypes such as unsigned bigint. The error thrown is "Specified Cast not Valid."|
|29299|Internal|Data|Enhanced performance related to loading records in report viewer.|
|29318|Internal|Setting|Added setting [[AdjustSeparatorsInEqualsListValues|/API/CodeSamples/AdjustSeparatorsInEqualsListValues]] which permits disabling of automatic delimiter detection in the Equals(List) filter operator.|
|29342|Internal|Data|Prevented "item with the same key has already been added" error from appearing when using hidden filters.|
|29348|Report Design|Report Design|Corrected the Text and Cell highlight features to better handle characters like commas and periods within long strings which are being aliased.|
|29353|Report Design|Expressions|Prevented errors which could occur if expressions were trying to find a field with an alias attached.|
|29414|Report Design|Filters|Permitted overrides to first day of the week in the Izenda Calendar object.|
|29417|Internal|Data|Increased performance when listing stored procedures in Oracle.|
|29418|Internal|Data|Corrected issue related to Fusion aliasing against a full stored procedure name when using Oracle.|
|29426|Report Design|Dashboards|Refactored old style Dashboards to better support Visualizations.|
|29428|Report Design|Filters|Minor UI enhancements around filters to make graphical and rendered elements line up neatly.|
|29429|Report Design|Filters|UI enhancements made around the Show Filters In Report Description option, to make shown filters more responsive to empty/blank/null filter values.|
|29438|Report Design|Filters|Corrected error which prevented filter logic from appearing in the designer if additions are made to the ReportDesignerUrl string.|
|29447|Report Design|Instant Reports|Added support for pivot column splitting to Instant Report designer.|
|29448|Report Design|Exports|Corrected a label formatting error which would occur on PDF export if there are split columns on a report with a single column.|
|29460|Report Design|Report Design|Prevented 'Create New Category' from sometimes being automatically selected when clicking the 'Save As' button.|
|29461|Report Design|Report Design|Corrected redirect error which could occur when attempting to send a link to a report via email from within the ReportDesigner.|
|29484|Report Design|Subreports|Corrected application of distinct records when using Automatic subreports. Distinct was being ignored in this scenario.|
|29507|Report Design|Gauges|Corrected Animated Half Circle gauge behavior to prevent graphical/rendering issues.|
|29512|Report Design|Scheduler|Corrected scheduler from populating the year control starting with year 1.|
|29518|Report Design|Instant Reports|Enforced sanitation of some input values on instant reports, such as pagination controls.|
|29521|Report Design|Report Design|Corrected subtotal rendering when using a pivot with an attached analysis grid visual group style.|
|29531|Report Design|Gauges|Corrected issue where animated half circle gauge style would have values duplicated unnecessarily.|
|29533|Report Design|Filters|Corrected tooltip on filter control in the report viewer to properly display field name.|
|29538|Internal|Exports|Standardized request header casing to prevent exporting behavior failures in Edge browser.|
|29555|Report Design|Localization|Corrected caching issue preventing resources from appearing as properly localized.|

#6.10.0.31 (June 5, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|28555|Report Design|User Interface|Corrected label when using Percent of Group (Rounded) format on a Pie chart.|
|29117|Internal|Drivers|Implemented use of LazySPMetadataPulling when using the Fusion driver.|
|29146|Internal|Data Sources|Refactored schema extraction and caching to be more efficient.|
|29180|Internal|Settings|Enhanced support of AdHocSettings.ResourcesProvider to better handle multiuser environments and the embedding of specific report parts.|
|29195|Internal|Data Sources|Added support for database collation in different languages.|
|29215|Internal|Data Sources|Streamlined and consolidated the number of requests made when working with simple/advanced data source join mode to increase performance on large databases.|
|29235|Internal|Data Sources|Corrected 42000 error in MySql when attempting to perform numeric calculations in an expression.|
|29241|Internal|Drivers|Added support for direct connection when using MySql and Fusion driver together.|
|29247|Report Design|Filters|Corrected date division when using Week grouping to construct a pivot and Time Period filter.|
|29254|Report Design|Exports|Prevented culling of subtotals from Analysis Grid when exported to Excel.|
|29255|Report Design|Exports|Fixed table layout and formatting when exporting to Word.|
|29293|Internal|Filters|Fixed invalid cast problem when using a hidden filter against a field with datatype int64.|
|29317|Internal|Performance|Cleaned up code to improve performance in IIS.|
|29321|Report Design|Formatting|Prevented subtotal records from being included as an item for pagination purposes.|
|29324|Report Design|Instant Reports|Prevented Instant Report splash screen from being disabled in some circumstances when using Internet Explorer.|
|29326|Report Design|Performance|Refactored HTTP requests to prevent crashes in rare situations where bad output may be generated via an incorrect ID.|
|29331|Report Design|Report Design|Fixed some functions being culled from the Maps tab in IE11.|
|29355|Report Design|Formatting|Cleaned up all indents and borders when formatting the Analysis Grid.|
|29376|Report Design|Performance|Prevented conversion error when using Average(Days Old) function in a Trend chart.|
|29378|Report Design|Visualizations|Enhanced Visualization behavior to prevent attempting to execute a Visualization with no data.|
|29379|Report Design|Instant Reports|Cleaned up text artifacts in Instant Reports when using a small screen resolution.|
|29383|Report Design|Subreports|Fixed some errors in drilldowns when there are uncommon characters used in the drilldownkey value.|
|29395|Internal|Data Sources|Prevented crash which could occur if setting AliasTable for a datasource and not TableJoinAlias.|
|29398|Report Design|Filters|Prevented server 500 error when filter value is set to '...' ellipsis.|
|29408|Report Design|Exports|Prevented pivot column splitting on page print from also invalidating column superheaders.|



#6.10.0.30 (May 8, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|27266|Report Design|Filters|Expanded (blank) filter selection to detect empty strings as well as null values.|
|28655|Report Design|Visual Groups|Enhanced rendering behavior of hidden fields within visual groups to prevent mysterious commas, layout issues, or exceptions.|
|29125|Report Design|Toolbar|Ensured consistent behavior between results control on page and number of rendered records.|
|29200|Report Design|Visual Groups|Prevented AlternativeItem styling from being reset after Analysis Grid is disabled.|
|29201|Report Design|Visual Groups|Prevented Null Reference Exception when using Analysis Grid with insufficient data.|
|29202|Report Design|Visual Groups|Cleaned up table styles on Analysis Grid.|
|29212|Report Design|Dashboards|Prevented "Failed to load dashboard layout" error under some conditions, such as the source report being changed.|
|29229|Report Design|Filters|Prevented reloading of filter values when users delete or remove a filter.|
|29240|Report Design|Dashboards|Enhanced UI around the "Send PDF" functionality on Dashboards.|
|29243|Report Design|Pivots|Removed some functions from being eligible for pivot columns since their behavior inherently overlaps with pivots.|
|29256|Report Design|Filters|Fixed popup behavior of Autocomplete filter to be uniform across data types.|
|29276|Internal|Drivers|Enhanced support for filtering against calculated fields when using MySqlDriver.|
|29292|Report Design|Pivots|Ensured pivots would not break in the event that identical column headers could be generated from data.|

#6.10.0.29 (April 10, 2018)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|29212|Report Design|Dashboards|Prevented "Failed to load dashboard layout" error under some conditions, such as the source report being changed. This change was hotfixed on April 16, 2018.|
|28066|Report Design|Data Sources|Fixed exception when joining a datasource twice on the same report and adding an expression using an alias referencing one of those tables.|
|28908|Internal|Methods|Refactored ReportCollection class.|
|28931|Report Design|Styling|Corrected CSS not being applied to forms without first saving the report.|
|28947|Report Design|Expressions|Corrected proper escaping of angle brackets in expressions to prevent corruption of the expression in value testing or output.|
|28956|Report Design|Exports|Corrected some conditions in which externally hosted images would fail to be included in PDF export.|
|29025|Internal|Methods|Refactored authentication code.|
|29064|Internal|Data Sources|Refactored data source name links associated with virtual data source setting to prevent incorrect and faulty behavior when clicked.|
|29089|Internal|Data Sources|Prevented 'Invalid Cast' error related to filters on fields using the UInt16, UInt32 or UInt64 datatype and using the ODBCDriver. This fix breaks backwards compatibility for virtual data sources, which must be manually opened and resaved to correct their functioning.|
|29095|Internal|Data Sources|Corrected faulty behavior around drilling down on a 'date' type field in Oracle.|
|29103|Report Design|Filters|Ensured reduction of unnecessary activity when cascading filters are disabled.|
|29107|Internal|Data Sources|Prevented MySQL error when using stock MySQLDriver which throws "Incorrect Database Name". This fix was retroactively applied to 6.10.0.27 and 6.10.0.28.|
|29110|Internal|Scheduling|Enhanced handling of invalid times when a time does not exist due to timezone shifts.|
|29118|Report Design|Visualizations|Provided a more user friendly error message when embedded subreports are used on a grid which feeds data to a visualization which is not compatible with embedded subreports.|
|29120|Report Design|Filters|Re-enabled use of passing some values, including blanks and nulls, as stored procedure parameters via specific filter operators.|
|29123|Report Design|Charts|Prevented 'zero chart results' from appearing in error when using a calculated field to build a chart.|
|29124|Report Design|Pagination|Corrected problem which would cause additional records to appear (more than requested in preview) when paginating report parts.|
|29126|Internal|Methods|Corrected issues which sometimes cause SchemaCacheTimeout to never function properly.|
|29129|Report Design|Charts|Increased speed of rendering gauge formats.|
|29133|Report Design|Filters|Corrected issue where sometimes filters were not saved in Instant Reports when cascading filters are disabled.|
|29138|Report Design|Styling|Made further improvements to case 27885 to prevent word wrapping issues, as well as permit word wrapping in exports.|
|29142|Internal|Data Sources|Corrected datatype cast error which could arise when using some column formats with pagination.|
|29151|Report Design|Pivots|Corrected problem in pivots which could cause string '-Q' to appear in cell values when using Oracle.|
|29171|Report Design|Exports|Corrected an issue which could cause datetime formats to be lost on Excel export. This issue was retroactively applied to versions 6.10.0.27 and 6.10.0.28.|
|29191|Report Design|Charts|Corrected broken labels in Pie charts if label string contains a single quote character.|

#6.10.0.28 (March 13, 2018) IMPORTANT NOTE

**NOTE:** Any installations of this build prior to March 14, 2018 have a critical error fixed in case 29107. This fixes an error which prevents Izenda deployments based on MySQL from updating beyond version 6.10.0.25. The error thrown is an Incorrect Database Name error on saving a new report. 

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|28707|Report Design|Scheduler|Prevented error causing schedule changes to not always save or update when a report is successfully scheduled.|
|28725|Dashboard|Visualization|Prevented extra visualization refreshes when visualizations are used on a dashboard which is being resized.|
|28857|Report Design|Subreports|Corrected error with using combokey to call an embedded subreport.|
|28921|Report Design|Data|Prevented Distinct from being disabled when a report is saved with an invalid column name.|
|28962|Report Design|Instant Report|Corrected error which prevented calculated fields from populating filters in instant report.|
|28970|Report Design|Filters|Trimmed out some unnecessary filter query activity when cascading filters are disabled.|
|28974|Report Design|Visual Groups|Refactored AntiXSS protection to permit additional characters to be used in visual group.|
|28980|Report Design|Instant Report|Corrected issue with calendar selector filter in instant reports.|
|28983|Dashboard|Gauges|Corrected animated half circle gauge style conflicting with modern dashboards.|
|28985|Report Design|Pivots|Corrected issue where subtotals would not properly appear on pivots.|
|28992|Report Design|User Interface|Prevented some UI glitches when resizing screen.|
|29006|Report Design|Pivots|Changed behavior of clear pivot button so that it does not retain old data when pivot is re-added.|
|29008|Report Design|Settings|Prevented being able to input 0 for "Items Per Page" value.|
|29010|Report Design|Subreports|Fixed some issues around printing and rendering embedded subreports.|
|29026|Internal|Report Parts|Further overhauled report parts and resource caching to enhance performance when using individual report parts.|
|29043|Report Design|Subreports|Corrected behavior of subreports in auto chart when using instant reports.|
|29057|Internal|Settings|Corrected text description for EmbedReportInServerEmail setting.|
|29062|Report Design|Pivots|Corrected use of Group(Week) function in pivot so that it does not provide faulty output.|
|29085|Internal|Settings|Expanded diagnostic and logging ability around report exporting.|

#6.10.0.27 (February 13, 2018) IMPORTANT NOTE

**NOTE:** Any installations of this build prior to March 14, 2018 have a critical error fixed in case 29107. This fixes an error which prevents Izenda deployments based on MySQL from updating beyond version 6.10.0.25. The error thrown is an Incorrect Database Name error on saving a new report. Any installations of this build prior to March 7, 2018 have a critical error fixed in case 29079. Expressions which use a less than or greater than comparison will become corrupted if the report is saved.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|28481|Internal|Resources|Ensured that saving an image will always generate the same hash.|
|28587|Internal|Resources|Corrected image metadata problem which could lead to images being removed from emailed reports.|
|28673|Internal|Settings|Enhanced functionality of ForceResourceRequestsUniqueUrls to lower the number of hoops users have to jump through when this setting is first enabled.|
|28703|Instant Reports|Data|Corrected issues when saving Instant Reports which have a field with a default format, which can sometimes be set against type.|
|28745|Internal|Data|Permitted custom drivers to inherit from Driver class.|
|28809|Report Design|Data|Corrected some problems with arithmetic calculation of fields when applied to aggregated data.|
|28835|Report Design|Scheduler|Prevented issue where saving a report in the scheduler too soon after the new year will cause the report to skip ahead a year.|
|28844|Internal|Localization|Prevented value ranges on charts from being rendered incorrectly during non-English localization.|
|28845|Internal|Localization|Made equals filter in Instant Reports respect AdHocSettings.Language.|
|28847|Internal|Data|Enabled use of weekday datepart in SQL functions.|
|28851|Internal|Localization|Corrected some missing localization strings.|
|28875|Internal|Settings|Corrected chart failing to render in cases where ResourcesProviderWithDelimiter passes an incorrect value.|
|28892|Report Design|Rendering|Made it so that dashboard tile borders appear during a resize and not just after.|
|28901|Internal|Error Handling|Deescalated priority of column/table not found errors in some conditions to prevent application level error notifications.|
|28915|Internal|Internal|Eliminated need for .net 3.5 framework dependencies.|
|28936|Report Design|Data|Corrected join issues which can occur using table aliases.|
|28941|Report Design|Subreports|Corrected behavior of nested popup subreports.|
|28942|Report Design|Exports|Corrected some chart rendering errors on export to Word and PDF.|
|28951|Instant Reports|Data|Corrected saving of datetime formats in Instant Reports.|
|28963|Report Design|Data|Corrected object reference error which could occur when exporting a report to excel which has a default '...' format applied to a datetime.|
|28964|Report Design|Visual Group|Corrected arithmetic concatenation of strings in visual group.|

#6.10.0.26 (January 16, 2018) IMPORTANT NOTE

**NOTE:** Any installations of this build prior to March 14, 2018 have a critical error fixed in case 29107. This fixes an error which prevents Izenda deployments based on MySQL from updating beyond version 6.10.0.25. The error thrown is an Incorrect Database Name error on saving a new report. Any installations of this build prior to March 7, 2018 have a critical error fixed in case 29079. Expressions which use a less than or greater than comparison will become corrupted if the report is saved.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|28148|Internal|Data|Corrected Oracle error which could cause exceptions when using expressions and pivots in the same report.|
|28371|Dashboards|Scheduler|Fixed dashboard panels being "pushed down" the page when scheduled.|
|28568|Internal|Optimization|Refactored disk cache for constraints, general optimizations included.|
|28671|Dashboards|Dashboards|Corrected dashboards sometimes not loading necessary scripts, resulting in a "report not found" error for no apparent reason.|
|28719|Report Designer|Filters|Corrected "The given key was not present in the dictionary" related filter population error when updating filters.|
|28723|Dashboards|User Interface|Added truncation to long report names when selecting a report for a dashboard.|
|28731|Report Designer|Exports|Corrected text scaling issues in PDF export when using VG page break.|
|28733|Dashboards|Dashboards|Fixed some JS errors that could occurr in dashboards due to babel polyfill library.|
|28734|Report Designer|Formats|Better supported modifications of datetime formats in Excel which use the am/pm flag.|
|28749|Report List|User Interface|Corrected element borders for report icons in the report list when using no thumbnails mode.|
|28754|Report Designer|User Interface|Fixed some UI glitches when zooming the page in and out.|
|28755|Report Designer|User Interface|Added AdHocSettings.FilterTextAreaHeight to control the height of filter text boxes.|
|28764|Report Designer|Exports|Corrected encoding of spaces in XML export.|
|28778|Report Designer|User Interface|Fixed incorrect display of functions for a field based on wrong datatype in Chrome.|
|28784|Report Designer|Forms|Fixed XSS security removing script tags from Forms when unnecessary.|
|28792|Report List|User Interface|Corrected report searching on the report list to account for categories.|
|28793|Report Designer|User Interface|Corrected error notification display to prevent a loading loop in the case of multiple errors.|
|28796|Internal|Data|Corrected column population in custom drivers which override GetAllTables and GetColumns, which end up returning no columns.|
|28797|Report Designer|Filters|Corrected behavior of time portion of datetime in filter value display. This will address 'missing' time values in filters.|
|28807|Report Designer|User Interface|Prevented field functions from being blanked out in a saved report on a field using an expression.|
|28813|Report Designer|Forms|Corrected use of popup subreports in forms.|
|28817|Internal|Scheduler|Permitted customization of scheduler output using AdHocSettings.SchedulerOutputTypes.|
|28841|Internal|Data|Permitted ASPX implementation of independent reportparts.|
|28863|Internal|Settings|Prevented NullReferenceError when AdHocSettings.CacheSchema = false;.|

#6.10.0.25 (December 12, 2017)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|28375|Report Design|Instant Reports|Corrected behavior of clearing pivots in Instant Reports.|
|28416|Report Design|Report Designer|Enabled pagination for inverted summary grids.|
|28423|Report Design|Filters|Fixed population of filter values being pulled from an expression.|
|28424|Internal|Database|Fixed ORA-01036 error when filtering against a datetime in Oracle.|
|28429|Report Design|Instant Reports|Made Auto Gauge errors more explicit in Instant Reports.|
|28435|Report Design|Exports|Corrected error preventing CSV files from being exported if the ReportViewer has an HTML Form tag.|
|28449|Internal|Settings|Added setting to specify Izenda resource folder so that Izenda does not traverse the file structure outside of this folder.|
|28554|Internal|Settings|Corrected behavior of disappearing buttons when disabling thumbnail controls using ShowDesignLinks.|
|28612|Report Design|Report Designer|Enabled hiding visually grouped fields.|
|28615|Internal|Settings|Corrected issue which prevented the setting of AttachmentName in the scheduler.|
|28616|Internal|API|Corrected some issues related to overriding ProcessDataSet.|
|28621|Report Design|Filters|Corrected handling of string values with commas when passing them directly into filters via the url feature.|
|28626|Report Design|Visualizations|Refactored AutoGauge to be easier to customize.|
|28631|Internal|User Interface|Fixed error where the reportlist would load endlessly if there were no uncategorized reports.|
|28657|Report Design|Filters|Made datetimes in filter description match the correctly applied formatting.|
|28658|Report Design|Subreports|Fixed error which sometimes prevented popup subreports from appearing after a report has been saved and the report has not been reloaded.|
|28687|Report Design|User Interface|Prevented save dialog from appearing partially offscreen in case of an extremely long category name.|
|28716|Report Design|Visualizations|Corrected an error which could occur due to the D3 library when using visualizations on dashboards.|
|28721|Report Design|Dashboards|Corrected error which could occur when resizing a dashboard browser window when that dashboard includes a visualization.|
|28722|Report Design|Dashboards|Corrected tile positioning on dashboards to stop tiles from overlapping each other if the dashboard browser window is shrunk or minimized.|

#6.10.0.24 (November 14, 2017) IMPORTANT HOTFIX NOTE

There is a small issue in this version where the report list will not load if there are no uncategorized reports. All links still function normally, but the standard behavior in the case of no uncategorized reports is to either load the top alphabetical category, or to open the report designer. Replacing /Resources/js/ReportList.js with [[this|/Release-Notes/izenda-6.10.0.24+28631fix-reportlist.zip]] file will correct this behavior.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|27045|Internal|Filters|Corrected some bad SQL generation that could occur when using grouped expressions to calculate a value and some constituent fields to that calculated value are being filtered on.|
|28300|Internal|Thumbnails|Added support for loading thumbnails with async requests.|
|28359|Report Design|Reports|Fixed incorrect editor link generated in the report list with extra slashes.|
|28408|Report Design|Exports|Resolved regression issue with legacy pdf exporting|
|28409|Report Design|Reports|For every filter ("criteria" node in XML) izenda stores in XML two attributes: Value, and ValueEncoded. Value contains the field value in plain text. ValueEncoded contains the same value in base64-encoded form, and it is used by izenda when filling ReportSet object. If value is altered and encoded value is not the filters are broken and report will not load. Altered process to add encoded values if blank.|
|28414|Report Design|Summary|Prevented incorrect output which could occur when using Add Delta and Invert at the same time on a summary.|
|28455|Report Design|Pivots|Sorting on a column with Percentage format isn't displaying properly when used in a pivot grid.|
|28479|Report Design|Dashboards|Slight alteration to size and position of open dashboard control in dashboard page.|
|28487|Internal|Logging|Added additional logging for some AdHocSettings (OracleConstraintsQuery and VisualizationsFolder).|
|28488|Internal|Backend|Updated CurrentUserTenantID to enforce the processing of one value at a time. |
|28490|Report Design|Exports|Corrected URL generation when producing PDF exports.|
|28493|Report Design|Dashboards|Error noted when resizing charts in some dashboard tiles.|
|28495|Internal|Settings|Made linker timestamp visible on rs.aspx page to show dll date.|
|28496|Report Design|Dashboards|Removed underline displaying in dashboard toolbar.|
|28502|Report Design|Filters|Missing field name on Filters in Instant Report.|
|28503|Report Design|Visual Group|Incorrect computation of subtotal in Instant Report when using visual group.|
|28504|Report Design|Exports|Some Funnel charts are cut off in PDF export.|
|28508|Report Design|Calculation|Prevented overflow error which could occur when using Oracle and calculating date diffs.|
|28510|Report Design|Formats|Implemented ability to sort on custom date formats.|
|28518|Internal|Optimization|Refactored some areas in the Report List, application initializes tabs each time a category is clicked.|
|28538|Report Design|Forms|Filters smart tag for Forms now displays without needing to explicitly force "Show Filters".|
|28540|Internal|Optimization|Optimized filter loading for better performance.|
|28547|Internal|Optimization|Added performance improvements to Report Viewer loading|
|28559|Report Design|Drilldowns|Corrected behavior of aggregating blank and null strings for drilldowns.|
|28613|User Interface|Report List|Some categories when clicked in the report list are unresponsive.|

#6.10.0.23 (October 11, 2017)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|26158|Internal|Optimization|Refactored and optimized internal FiltersData behavior.|
|27337|User Interface|Exports|Permitted custom behaviors to be added to the toolbar Send Report button.|
|28098|Internal|Query Generation|Permitted the override of GenerateSQL for complex hidden filters.|
|28248|Internal|Optimization|Implemented gzip content compression.|
|28261|User Interface|Controls|Fixed location of dropdown menu in Instant Reports so as to not try to render itself partially offscreen.|
|28263|User Interface|Controls|Refactored use of forward and back slashes for greater ease of use (both should be acceptable for most uses).|
|28294|Internal|API|Allowed caching of AdHocSettings.Culture.|
|28326|User Interface|Controls|Corrected some UI behavior in Firefox that would prevent deleting reports.|
|28330|User Interface|Controls|Minor tweaks to button color and appearance in the Instant Reports toolbar.|
|28334|Report Design|Filters|Corrected "Multipart Identifier Could Not Be Bound" error when inheriting a field filter against a field from a datasource which is absent in the joined tables list of subreport.|
|28338|Report Design|Formatting|Fixed error preventing gradient cell shading from being used inside of a pivot when it is also being used outside of that pivot.|
|28351|Internal|Routing|Changed URL generation for images so that they load without permissions errors in MVC.|
|28357|Internal|Routing|Additional optimizations to MVC routing.|
|28373|Internal|Filters|Fixed an error in filter query construction which could cause unique values to fail to display in a populated filter.|
|28380|Report Design|Visualizations|Prevented an intermittent javascript error which arose on reports with multiple visualizations.|
|28391|Report Design|Reports|Corrected extra, empty line from being placed at the bottom of an inverted summary table.|
|28399|User Interface|Controls|Prevented some UI icons from disappearing in Edge.|
|28400|Internal|Routing|Optimized routing in the MVC kit.|
|28404|Report Design|Forms|Changed Form rendering to account for square brackets in field names as well as field values.|
|28407|User Interface|Fonts|Prevented font loading errors in Edge.|
|28411|Report Design|Expressions|Fixed an error preventing subtotal expressions from being generated from a stored procedure dataset.|
|28412|User Interface|Tooltips|Corrected tooltip when hovering over "Add New Filter" in the Report Viewer.|
|28415|Report Design|Visual Groups|Prevented using inverted grid and field value visual group style at the same time.|
|28421|Report Design|Dashboards|Fixed the display of chart titles on dashboard tiles.|
|28428|Report Design|Visualizations|Created some friendlier error messages for visualizations.|
|28430|Internal|API|Set rp.aspx to always open resources as readonly by default to prevent access errors.|
|28451|Internal|Query Generation|Prevented bad query code from being generated when a column name contains "PARAM" or "PARAM_".|
 
#6.10.0.22 (September 12, 2017)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|18568|Internal|User Interface|Enabled support for very long report names.|
|20727|Internal|Logging|Expanded logging around stored procedure behavior.|
|23613|Report Design|Filters|Error thrown on input of decimal in comparison filter for days old. If user inputs any decimal the system gives object not set to instance of an object error.|
|26970|Internal|Settings|Corrected persistent "Report Not Found" errors when using ReportID instead of ReportName.|
|27484|Internal|API|Internal refactoring to deprecate the use of Report.Chart in favor of the "Chart" reportpart type.|
|27503|Internal|Optimization|Refactored query construction to optimize performance.|
|27545|Internal|Optimization|Prevented the same report open in different browser tabs from "sharing" settings across tabs.|
|27601|Internal|Charts|Refactored some date handling in Highcharts to better support localization of string labels of datetimes.|
|27863|Report Design|Dashboards|Made tile backgrounds in Dashboards more reactive to tile resizing.|
|27905|Internal|Optimization|Additional refactoring of internal RequireJS.|
|27938|Report Design|Exports|Expanded ability to export Auto Chart visualization as an image when exporting/printing in HTML.|
|27959|Internal|Dashboards|Refactored internal ReportViewer.js to better handle links in Dashboards.|
|27960|Report Design|Filters|Added a more explicit warning when a user adds a date which is invalid according to the current Culture setting.|
|28149|Internal|Settings|Added new setting, AdHocSettings.RasterizedChartWidth, to permit all chart labels to be rendered when a chart is very "wide" and should not be condensed for display or printing.|
|28159|Internal|Optimization|Small refactoring of HtmlReportRenderer.RenderHeader.|
|28160|Report Design|Exports|Corrected export behavior for PhantomJS when using offline mode.|
|28165|Report Design|User Interface|Prevented tile Delete icon from being removed when minimizing the Instant Report window.|
|28184|Report Design|Subreports|Corrected drilldown passing behavior which could, if a report is using a filter on the same field as the drilldown key, cause the filter to override the drilldown value.|
|28187|Report Design|Filters|Prevented filters from being dropped in Instant Report designer when adding fields.|
|28193|Report Design|Charts|Added more user friendly errors for the Auto Chart visualization when the underlying table has no metric field.|
|28196|Report Design|Filters|Filters now respect padding in data such that values which appear similar but are logically different (such as "Test" and " Test") will be handled properly in filters.|
|28198|Report Design|User Interface|Modified behavior of the Remove and Undo buttons when shrinking Dashboard tile to a very small size.|
|28199|Report Design|Dashboards|Enhanced "No Reports Found" message in Dashboards to be more user friendly.|
|28203|Report Design|Charts|Made further enhancements to sizing of report parts and report part metadata when using report parts independently.|
|28221|Report Design|Subreports|Changed Embedded report behavior to ignore drilldownkeys passed in the URL of a subreport being used as both a parent and child. For example, if a report is a subreport of some other report, while also having an embedded subreport itself.|
|28241|Report Design|Exports|Fixed an issue which could cause Excel exports from New Instant Reports to generate a bad format for some fields, causing them to be rendered incorrectly (numerics as text, for example).|
|28242|Report Design|User Interface|Correctly indexed columns in Instant Reports to prevent hidden columns from still being visible in the advanced settings if you clicked on the column header of an adjacent column.|
|28247|Report Design|Footers|Izenda now attempts to scale images used in the header or footer when producing a PDF and the image would otherwise extend "off the page".|
|28271|Internal|Data Sources|Corrected some issues with session provider which could cause data sources to be inaccessible.|
|28273|Internal|Optimization|Closed tag in Dashboard template toolbar which could cause browser errors.|
|28274|Report Design|User Interface|Fixed error which could cause the function and format to be dropped from a field in the New Instant Report designer.|
|28277|Internal|Optimization|Updated PhantomJS.|
|28281|Internal|Exports|Corrected "Izenda is not defined" script error when attempting to export an old dashboard (Dashboard.aspx) page to HTML.|
|28288|Report Design|Charts|Corrected some width related issues with Dundas chart rendering.|
|28290|Internal|Optimization|Corrected some memory leaks caused by static regex objects.|
|28303|Internal|Optimization|Refactored the way resources are cached when a Dev license key is being used, to make it easier to debug resource related issues.|
|28306|Internal|Data Sources|Corrected Izenda error which would not load data sources with a duplicate synonym from another database.|
|28312|Internal|Optimization|Modified image tags where appropriate so as to not throw unnecessary errors in IE.|

#6.10.0.21 (August 8, 2017)

*NOTE: There are extensive changes to the Dashboard UI in this update. Please be sure to flush your browser resource cache if Dashboards appear to be broken or nonfunctional!*

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|26538|Internal|Dashboards|Various UI and performance enhancements in Dashboards viewer page.|
|27497|Report Design|Subreports|Filter inheritance in subreports was behaving differently in Report Designer and Report Viewer. Now filters inherit consistently across pages.|
|27692|Report Design|Maps|Corrected issue with indicator bars on legacy maps (not visualizations) displaying incorrect values.|
|27734|Internal|Thumbnails|Fixed thumbnail duplication when dashboards belong to "_global_" tenant, which caused performance hits.|
|27809|Internal|Scheduler|Refactored scheduler to be more stable, performant, and support logging.|
|27817|Internal|Formats|Expanded support for custom formats for datetimes when using filters in Instant Reports.|
|27864|Report Design|Dashboards|Added truncation to the titles of dashboard tiles when the tile's width is reduced.|
|27877|Internal|API|Refactored Driver.InvalidateSchemaCache to dump cache on all machines in a webfarm when called on one of those machines.|
|27885|Internal|Printing|Refactored PhantomJS to handle page breaks after visual groups.|
|27901|Internal|Dashboards|Small change to dashboards permitting an override for custom sorting of dashboards by name and category.|
|27928|Report Design|Filters|Prevented filters from having their description set to 'null' under some conditions.|
|27930|Instant Reports|Appearance|The following settings were not being respected in Instant Reports v2: HeaderForegroundColor, ItemForegroundColor, ReportHeaderColor, ReportItemColor, ReportAlternatingItemColor, ReportBorderColor.|
|27962|Internal|Joins|Refactored constraints to prevent duplicate constraints from being created.|
|27964|Internal|Security|Clarified behavior of TenantField column setting when this field contains a mix of null and non-null values.|
|27996|Report Design|Dashboards|Made filters update on dashboard tile sync with other report metadata.|
|28002|Report Design|Visualizations|Modified Timeline Visualization to better support printing and exporting.|
|28010|Report Design|Formats|Some formats, such as percent of group, consistently display on pivots even with zero/null data.|
|28011|Report Design|Subreports|Closed some conditions under which popups spawned as subreports of subreports could inherit pagination controls.|
|28012|User Interface|Refactoring|Slight UI tweak to scheduler controls to make them line up visually.|
|28014|Internal|Security|Prevented sessionDataStorage.ProviderAvailable from returning false if Izenda is initialized in offline mode.|
|28063|Internal|Joins|Corrected error which could occur if AdHocContext.Driver is used to set a PostgreSQLDriver and a field is aliased from its literal name.|
|28064|Internal|Sett|ExportLimit is now applied to the results of a report after printing and updating the report viewer.|
|28066|Report Design|Joins|Fixed exception when joining a datasource twice on the same report and adding an expression using an alias referencing one of those tables.|
|28067|Report Design|Dashboards|Prevented dashboard tiles from opening the underlying report when dragging it to certain locations on the dashboard viewer.|
|28068|Report Design|Charts|Tweaked charts to fit the size of their HTML container when they are isolated as a report part.|
|28071|Report Design|Filters|Prevented an overflow error which could occur if a report had a filter which referred to a field that does not exist in the database schema cache.|
|28084|Internal|Security|Refactored AdHocContext.Initialized such that Izenda should not reinitialize when session is null by design.|
|28091|Internal|Joins|Refactored join code such that HTML entry validation won't trigger on expressions when checking for correct join conditions.|
|28094|User Interface|Dashboards|Added a dashboard refresh after resizing the browser window to prevent tiles from being "broken" and refusing to update.|
|28100|Report Design|Visualizations|Prevented JS exception which could be triggered by the use of double NaN strings instead of the literal string "NaN" in charts.|
|28109|Instant Reports|Appearance|Populated UI color selector in new Instant Reports pages with default Izenda colors.|
|28110|Report Design|Formats|Added tweak to properly sort currency values when using Culture to change currency format.|
|28134|Internal|API|Corrected Null Reference Exception in Driver.GetClearSchemaObjectName.|
|28144|Internal|Dashboards|Refactored dashboard tile loading to further reduce/eliminate "report not found" errors. This is caused by faulty parameters being fed to the 'getcrsreportpartpreview' query.|
|28177|User Interface|Dashboards|Corrected problem which prevented users from opening a tile's report in report designer from backside of dashboard tile|

#6.10.0.20 (July 11, 2017)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|22580|Report Design|Filters|Made further enhancements to filters to support custom datetime formats which are based on Culture token.|
|25920|Internal|API|Removed dependence on Izenda's rs.aspx from being in the application root folder rather than an Izenda subfolder.|
|27075|Report Design|Visualizations|Refactored Gauge Visualization to better handle long strings (tooltips implemented) and also updated fonts and styling.|
|27173|Internal|API|Refactored StaticSharedStorage and made it thread safe.|
|27436|Internal|Performance|Refactored internal key storage.|
|27498|Report Design|Joins|Corrected joining engine to prevent joins from being built incorrectly relative to how they appear in the UI control, for example LEFT joins being reversed in the query.|
|27534|Report Design|Styling|Refactored headers, footers, and image header alignment controls in Instant Reports.|
|27555|Internal|Query Generation|Solved an issue where in extreme circumstances it was possible for Izenda to reach the SQLServer Expression Limit.|
|27594|Internal|Query Generation|Corrected error which could cause pivot table to be dropped from query when applying a calculated filter directly to the top level grouping of values outside of the pivot.|
|27620|Report Design|Charts|Corrected error which permitted calculated numeric fields to be used incorrectly as the x axis value of the trend chart (it should only allow datetimes or datetime-based numerics).|
|27656|Report Design|Dashboards|Split dashboard tile refresh behavior into two actions - now a user can "Refresh" the data on the dashboard tile or "Sync" the tile's metadata to the source report.|
|27693|Internal|Report Loading|Prevented error which could occur when loading multiple reportparts on the same page - if the first reportpart fails to load, since it contained necessary scripts, other subsequent reportparts would also fail to load.|
|27695|Internal|API|Corrected error which could occur when calling GetObjectSchemaSql which returns no records.|
|27723|Report Design|Dashboards|Added support for long text descriptions on dashboard tiles. Long descriptions will be truncated at a certain limit, but the full text will be displayed in a hovering tooltip.|
|27724|Internal|Performance|Refactored code to better support Require.js and Angular.js.|
|27750|Report Design|Exporting|Made export limit setting apply to subtotal query when exporting.|
|27759|Report Design|Data|Expanded support for stored procedures which only use IN parameters.|
|27767|Report Design|Charts|Corrected format being lost from pie charts when editing report.|
|27769|Report Design|Styling|Fixed conflicts between different culture settings if AdHocSettings.Culture conflicts with culture specified in the web.config.|
|27775|Report Design|Exporting|Corrected an issue related to exporting inverted grids to excel.|
|27782|Report Design|Performance|Fixed object reference error when attempting to load or execute a report in the Report Viewer, when that same report works correctly in the Report Designer.|
|27808|Report Design|Filters|Ensured table filtering from Auto Chart visualization activity is reflected in print mode.|
|27814|Report Design|Subreports|Corrected issue preventing datetimes from being used as a drilldown key if there is a culture token mismatch between parent and child reports.|
|27818|Report Design|Filters|Fixed popup calendar for custom date using Instant Reports.|
|27819|Report Design|Exporting|Changed BulkCSV to apply a default format rather than display a blank cell for an unsupported format.|
|27820|Report Design|Filters|Properly flagged fields calculated via expression as calculated for the purpose of filtering.|
|27821|Internal|Session|Prevented reports from sharing filter settings and values when more than one report is open in the same browser session and both are refreshed simultaneously.|
|27823|Report Design|Filters|Fixed object reference error which can arise when a filter with multiple listed numerical values is applied to a calculated field.|
|27844|Report Design|Expressions|Corrected some errors related to escaping brackets when using the native SQL REPLACE() function.|
|27880|Internal|Filters|Corrected an error preventing hidden filters from applying to filter population in some circumstances.|
|27912|Internal|Dashboards|Fixed some dashboard loading problems when dashboards and report parts were being saved with the same name across tenants.|
|27913|Internal|API|Refactored HttpContext.Current.Items to manage request cache.|
|27933|Internal|Overrides|Corrected an issue preventing pivot behavior overrides from producing correct output.|
|27934|Report Design|Visualizations|Fixed placement of 'United Kingdom' and 'Hong Kong' strings in World Tour visualization.|
|27970|Report Design|Visual Groups|Corrected error which could occur when using visual groups on an unsaved report lacking a report name (rn property).|
|27982|Internal|Dashboards|Prevented a Null Reference Error which could occur if a dashboard cannot find cached source reports while loading.|



#6.10.0.19 (June 6, 2017)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|25071|Report Design|Visualizations|Corrected an issue where expressions with a zero in the denominator would render on visualizations as the max 16 bit int.|
|26207|Report Design|Visualizations|Corrected an issue where visualizations may not render correctly the first time in IE 10 due to a known error with jQuery.|
|27102|Report Design|Visualizations|Corrected an issue which would cause Auto Chart labels from not appearing correctly if a subreport using multiple drill down keys (comboKey) were used on the table.|
|27233|Report Design|Styling|Cleared out some unused CSS from resource files.|
|27500|API|Optimization|Prevented hyperlinks from being dropped if more than one report part is being displayed on a custom page.|
|27512|Report Design|Styling|Tweaked CSS of visual groups to maintain consistent padding in the Analysis Grid.|
|27513|Report Design|Filters|Changed encoding of special characters in URL when being passed through the URL feature from data.|
|27515|Dashboards|Dashboards|Fixed dashboard filtering behavior when inheriting filters upwards from a subreport being called from a report part on a dashboard.|
|27529|Data Sources|Data Sources|Deleting a Virtual Data Source now updates the data source cache.|
|27565|API|Error Reporting|Increased the number of internal exceptions which display a stacktrace along with the exception.|
|27569|Report Design|Subreports|Corrected change which permitted (broken) pagination behavior in the popup. Pagination of results should be ignored in popup and hover drilldown styles.|
|27570|Data Sources|Filters|Corrected some cases in which adding a data source using advanced join mode to an already existing report could filter out some values in error.|
|27590|Report Design|Exports|Corrected the application of formats to values when exporting to Excel and using the "Show Fields/Summary in Field Value" checkbox.|
|27595|Instant Reports|Exports|Enabled more email output types for the scheduler when using Instant Reports.|
|27606|Report Design|Categories|Fixed some incorrect behavior when placing subcategories in similarly named categories (subcategory 'Cat/Cat' appears in the 'Cat Cat' category instead of the 'Cat' category).|
|27613|API|Error Reporting|Improved performance of ajax error notifications in popups.|
|27619|Report Design|Exports|Corrected some custom formats being output as text instead of numeric (or other specified datatypes) when exporting to Excel.|
|27623|Report Design|Gauges|Prevented Gauge graphics from not being rendered if a calculated field is being used to generate the Gauge metric value.|
|27624|Report Design|Styling|Prevented header, description, and footer from being removed from an unsaved report under some rare circumstances.|
|27649|Report Design|Subreports|Corrected issue related to a datetime, grouped by week, which is being passed as the drilldown key to a subreport. Some days were being placed in the wrong week grouping.|
|27673|Dashboards|Error Reporting|Fixed a null reference exception which could occur when loading large dashboards.|
|27690|API|Settings|Added new setting, UseStrictDateTimeFilterParsing, which is a bool that determines if a Between date filter uses time as well as date (true) or just the date portion (false) of a datetime. The default value is false.|
|27728|Instant Reports|Filters|Corrected Instant Report filter behavior where the second value in a two part filter may sometimes not appear in a popup.|
|27729|Dashboards|Categories|Fixed some inconsistencies around setting a default category via code on Dashboards.|
|27745|API|Settings|Ensured that running InvalidateSchemaCache clears all in memory caches as well as disk caches.|
|27779|API|Error Reporting|Prevented a rare exception which could occur in the language resource files related to the PleaseEnterValidValueFormat string.|
|27787|Report Design|Exports|Prevented the popup calendar for a customized date field from appearing on a printed (PDF and HTML) export.|

#6.10.0.18 (May 2, 2017) IMPORTANT NOTICE FOR AZURE USERS

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|27317|API|Optimization|Upgraded EVO PDF generator to version 7. **Please note if you are using the Azure service you will need to use the 7 version of the service as well which can be found here:** http://www.evopdf.com/azure-html-to-pdf-converter.aspx  **Further instructions are provided for setting this up here on our wiki:** http://wiki.izenda.us/API/CodeSamples/PdfPrintMode/Pdf-Exports-in-Azure-Websites.docx|
|22876|API|Settings|Using ProcessEqualsSelectList to retrieve a list of filter values with the "Doesn't equals" filter operator returns no results.|
|25548|Report Design|Filters|Corrected custom Equals(Popup) not appearing.|
|26591|API|Optimization|Optimized memory usage when rendering Visualizations.|
|26717|Report Design|Filters|Prevented (calc) fields from appearing in filter dropdown selection when unnecessary, such as when there is no change to a field except for an alias.|
|26931|Report Design|Dashboards|Allowed ability to set and store dashboard background color in a cookie.|
|26933|Report Design|Visualization|If visualization cannot be rendered due to a lack of data, message should be displayed stating "No Data to Display"|
|27076|API|Settings|Removing AdHocSettings.ToolbarBackgroundImageUrl which is no longer used in application.|
|27131|Report Design|Visual Groups|Issues with Page Break and Separator on VG Hierarchy and Analysis Grid|
|27155|Report Design|Dashboards|In dashboard when "update results" is clicked several times, after the first time filters disappear because the dashboard loses the 'Is Dashboard' flag.|
|27162|API|Optimization|Intermittent Null Reference Error due to not-thread-safe work with dictionaries|
|27174|Report Design|Dashboards|Added ability to set "Enable Responsive Grid" setting value for each tile individually: value depends on source report setting value. If source report uses the responsive grid - dashboard tile will it use too.|
|27177|API|Drivers|Refactored Fusion driver for OData connections.|
|27206|API|Optimization|Corrected internal methods used in Calendar.cs to prevent rare index out of range errors.|
|27257|Report Design|Dashboards|Changed when scrollbars display on Dashboards to make them appear less often, especially when unnecessary.|
|27277|API|Drivers|Optimized use of AdHocSettings.Driver in Fusion.|
|27282|Report Design|Scheduler|Corrected problem which would reset the default time zone in the dashboard scheduler.|
|27296|Report Design|Report List|Corrected an issue preventing the category name from being listed along with the report name on some reports.|
|27304|API|Drivers|Changed how field aliases are assigned by the Fusion driver to prevent "object reference" errors from appearing when using an expression - the issue is that an alias can be assigned without a field name, causing conflicts where the expression could not distinguish a distinct field.|
|27327|Report Design|Visual Groups|Case sensitivity causes issues with some text groupings in Visual Groups.|
|27330|Report Design|Summary|Changed field alias swap from Total2 to Total for columns in the summary.|
|27344|Report Design|Dashboards|When user opens dashboard in the gallery mode for the first time, missing font errors are displayed in browser console.|
|27370|Report Design|Dashboards|Receiving JS errors in some pages when navigating from new Instant Reports or New Dashboard page to another page in Izenda before page is fully loaded.|
|27388|API|Optimization|Angular refactoring, unify all parts of the angular code which use $location service.|
|27394|API|Optimization|Refactored some methods inside of ReadXml().|
|27422|Report Design|Subreports|Fixed error preventing reports with long names from being used as a subreport in a form.|
|27440|Report Design|Scheduler|Added error message when report xml does not have a SendEmailAs property for the scheduler and is scheduled to be run, causing a null reference exception.|
|27442|Report Design|Settings|Corrected problem preventing header images from being included in a report when designed with the Instant Report designer.|
|27445|Report Design|Visualization|Corrected error where two copies of the same visualization with different filter settings would have the filter from the first visualization applied to both visualizations in print export.|
|27453|Report Design|Dashboards|Fixed error in URL handling which prevented dashboard URLs from being emailed properly, and the recipient has to log in to Izenda to view the linked object.|
|27467|Report Design|Data Sources|Prevented datasources from duplicating when switching from advanced to simple data source selection, and back again. Further fixes are scheduled for 6.10.0.19.|
|27475|Report Design|Visual Groups|Prevented initial VG value from being dropped when combining a visual group style other than field value with the "show report in field value" checkbox.|
|27514|Report Design|Dashboards|Dashboards showing extra pages when exporting to PDF|
|27547|Report Design|Charts|Prevented "vis.safeWrapper is not a function" error from appearing when creating charts in Instant Reports.|


#6.10.0.17 (April 5, 2017)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|25992|API|Settings|Corrected some broken behavior around AdHocSettings.EmbedReportInServerEmail.|
|26226|Report Design|Subreports|Corrected behavior of Hover drilldown style in Gauges tab.|
|26415|API|Hidden Filters|Corrected inconsistency which could allow hidden filters to override tenantid in some cases.|
|26539|Report Design|Dashboards|Removed ability to add duplicate tiles to Dashboard.|
|26622|API|Driver|Allowed Fusion driver to accept wildcards in multipart identifier.|
|26673|Report Design|Filters|Added support for filterable calculated fields in Instant Reports.|
|26798|Report Design|User Interface|Corrected issue which could sometimes prevent field descriptions from loading when using Instant Reports.|
|26851|Report Design|Exports|Using VG Hierarchy and Pivot at the same time throws an index exception when exported to PDF.|
|26912|API|Settings|Expanded TimeZoneOffset setting to apply to In Time Period filter as well.|
|26962|API|Security|Consolidated some unused scripts and updated some JS Methods to improve application security.|
|26975|Report Design|Filters|Corrected oversight which swapped dd/mm date format in date filters for mm/dd even when using a culture token override.|
|26988|API|Backend|Updated Ajax requests across Izenda to minimize browser hanging.|
|26992|Report Design|Filters|Improved handling of special characters, spaces, and tabs in filter values when using multi-line populated filter operators.|
|27007|Report Design|Filters|Changed behavior of report viewer such that if a calculated field is removed from the report body, any filters based on that field are also removed.|
|27073|Report Design|Filters|Modified date filters to prevent first portion of a date range from being set to a later date than the last portion of a date range.|
|27089|API|Settings|Fixed some gaps which allowed XSS and scripts to run in a report even when ApplyAntiXssToReportOutput = true;|
|27101|Report Design|User Interface|Suppressed internal designation of "field@group" from appearing in a fieldl description in Instant Reports when using a group header.|
|27108|Report Design|Data Sources|Corrected "Invalid Column Name" error when joining a virtual data source to a normal data source.|
|27113|Report Design|Instant Reports|Tweaked error messages in Instant Reports to make them more visible to the user and harder to click past.|
|27120|Report Design|Filters|Fixed a discrepancy in how the report viewer and report designer handle the "..." ellipsis character in a filter using the equals checkbox operator. This could cause the first value in a filtered list to be missing.|
|27129|Report Design|Expressions|Prevented setting expression type without an expression present.|
|27158|Report Design|Exports|Corrected csv export error claiming a datasource has an invalid object name when using a stored procedure in a Fusion environment.|
|27175|Report Design|User Interface|Corrected a missing font error in bootstrap.min.css in the 6.10.0.16 reference implementation.|
|27182|Report Design|Scheduler|Added ability to recognize and accept secured http connections to scheduler.|
|27204|API|Settings|Updated comments in code to show AdHocSettings.ShowModifyButton as deprecated. Customers should use AdHocSettings.ShowDesignLinks instead.|
|27205|Report Design|Exports|Removed extra line added when exporting report with embedded subreport to Excel.|
|27223|Report Design|Scheduler|Fixed scheduler error which can change the value of AdHocSettings.ResponseServer.|
|27224|Report Design|Visualizations|Prevented javascript errors from appearing when a current user/tenant setting conflicts with hidden filters.|
|27231|API|Backend|Reimplemented how and when UpdateSchemaCache is called in a new session.|
|27238|API|Backend|Changed how javascript is defined in response to a recent Chrome update (57.0.2987) that can result in odd UI behavior as critical variables are dropped from browser memory.|
|27256|Report Design|Filters|Cleaned up and made unavailable some incompatible filter operators when selecting a stored procedure parameter in Instant Reports.|
|27258|Report Design|Dashboards|Made friendlier errors in Dashboards when loading an empty title in Gallery mode.|
|27306|Report Design|Filters|Corrected issue with Instant Reports not passing a value correctly in a datetime filter when moving from report viewing to editing.|
|27316|Report Design|User Interface|Changed size of value ranges input box on charts tab.|
|27332|Report Design|Filters|Corrected an issue which prevented some filters from populating correctly if a calculated field were used as the first filter on a report.|
|27347|API|Backend|Prevented "Response is not available in this context" errors from appearing when Izenda is under heavy load from many users.|
|27349|Report Design|Exports|Prevented an issue which could cause Instant Reports to fail to produce a PDF export.|



#6.10.0.16 (March 8, 2017) BREAKING CHANGES
 
PLEASE NOTE THAT THIS RELEASE REQUIRES DOWNLOADING THE FULL REFERENCE IMPLEMENTATION AS WE ADDED ONE PAGE WHICH MUST BE ADDED TO YOUR IMPLEMENTATION. <br/>
Please follow the steps below to update your current Izenda version:<br/>

1.A Download the FULL RI <a href="http://archives.izenda.us/ri/">  Downloads RI Link   </a>
1.B If you are upgrading from an older version of Izenda and do not want to download the full RI, you can use the RI as a reference. The important thing here is to update your resource links per this example: link rel = "stylesheet" type = "text / css" href = "./ rp.aspx? extres = components.vendor.bootstrap.css.bootstrap.min.css" 
2. Unzip and copy the bin and resources to the corresponding website folders as would be done in a standard upgrade.
3. Locate the rp.aspx page in the extracted folder. For MVC Kits this is in the Reporting folder. In Webforms and VB this is located in the root of the extracted folder. 
4. Copy the new rp.aspx page to all locations in your implementation containing the rs.aspx page (please ensure you search as some implementations have more than one location for this file.
5. Locate the default.master page in Webforms or VB kit and _SiteLayout.cshtml in MVC kits. Find the following line `<script type="text/javascript" src="Resources/js/main.js"></script>` and replace with the following: `<script type="text/javascript" src="./rp.aspx?js=AdHocQuery"></script>` (this CHANGE IS REQUIRED as the main.js file is no longer included in the kit, and if this is not replaced there will be errors when you try to run the site).
6. Find and replace all references to ./rs.aspx wtih ./rp.aspx (this is not required but making these changes will improve the loading speed for resources on the pages - this change removes blocking issues faced with resources loading)
7. Replace `<link rel="stylesheet" href="Resources/css/main.css" type="text/css" />` with the following `<link rel="stylesheet" href="./rp.aspx?extres=css.main.css" type="text/css" />`

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|25750|API|Backend|Changed how resources are loaded to prevent intermittent errors when loading Dashboards related to "current result set is not a Dashboard" error, which seems to happen without pattern or cause.|
|26111|Report Design|Expressions|Prevented a null reference exception from being thrown in some circumstances when using an expression to calculate a field and not setting an expression type.|
|26609|API|Backend|Changed back end code to make it easier for filters to identify calculated fields by a guid rather than description string.|
|26692|Report Design|Subreports|Corrected behavior of stored procedure params when inheriting filters across subreports.|
|26731|Report Design|Subreports|Ensured parent report filters inherit to embedded subreports.|
|26758|Report Design|Visual Groups|Fixed page break behavior when visually grouping in Analysis Grid style.|
|26822|Report Design|Sorting|Corrected discrepancies in sort order between default and user-triggered sort.|
|26848|Report Design|Pivots|Corrected problems when constructing pivots which caused fields to be hidden in error.|
|26864|API|Settings|Expanded setting DataSourceLimit to incorporate Instant Reports.|
|26873|Report Design|Exporting|Fixed some subtotals being dropped from a pivoted analysis grid during excel export.|
|26877|User Interface|Instant Reports|Added report visibility control to Instant Report toolbar.|
|26878|User Interface|Categories|Expanded support for custom characters such as # and ^ when creating categories.|
|26889|API|Backend|Updated angular.js to 1.6.1.|
|26893|Report Design|Instant Reports|Corrected some conditions under which the Instant Report designer would not properly update field descriptions.|
|26894|Report Design|Subreports|Corrected issue which would prevent subreports from rendering correctly if a parent report has a filter on a calculated field.|
|26924|Report Design|Settings|Changed handling of special character encoding in column headers.|
|26980|Report Design|Settings|Fixed handling of url feature to prevent encoding or modification of strings which could lead to bad links built from data.|
|26981|API|Backend|Cleaned up creation and deletion of temporary files when using the report scheduler.|
|26983|API|Backend|Changed internal workings of databaseSchema method to be more responsive to report design modification.|
|26990|Report Design|Settings|Suppressed help text from being appended to the end of a custom url.|
|27004|Report Design|Dashboards|Corrected tile bounding and sizing in dashboards to prevent an error which prevents tiles from being extended to the edge of the dashboard page.|
|27006|API|Backend|Separated resource loading from session state storage to prevent session variables from blocking the loading of resources.|
|27020|API|Backend|Fixed an error which would happen if you attempted to bundle multiple resources through rs.aspx and one of those resources was empty.|
|27029|API|Backend|Implemented izu and izp parameters for the service based scheduler. Previously these parameters could only be used with the task based scheduler.|
|27032|Report Design|Visualizations|Corrected some rendering problems for visualizations when using Safari for Windows.|
|27034|Report Design|Instant Reports|Corrected preview not displaying in old version of the Instant Reports designer.|
|27040|User Interface|Instant Reports|Tweaked Instant Report toolbar to not obscure the preview window when minimized or on a small resolution or screen.|
|27041|User Interface|Filters|Fixed arrows for datetime calendar control if focus is changed unexpectedly.|
|27046|Report Design|Scheduler|Prevented the "Run Once" scheduler time from resetting the next scheduled datetime in the scheduler to the maximum possible value.|
|27053|API|Settings|Added setting, CacheExternalResources, which can be set to false to disable the caching of external resources.|
|27061|API|Settings|Fixed error preventing ArchiveReportOutput not firing for some export types when using SchedulerOutput.|
|27070|API|Settings|Prevented TimeZoneOffset from being applied to simple Date or Time datatypes.|
|27078|Report Design|Visualizations|Corrected issue which prevented Auto Chart visualization from rendering if the underlying grid is not aggregated.|
|27086|Report Design|Subtotals|Fixed "outer reference" error when subtotaling a field using an expression which overwrites its output, causing the field to lose reference in the subtotal query.|
|27149|Report Design|Sorting|Fixed grid sorting error related to ResourcesProviderUrl.|


# 6.10.0.15 (February 10, 2017)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|25889|Report Design|Filters|Corrected some logic which would invalidate filter overrides in dashboards.|
|26132|Report Design|Printing|Found and fixed some conditions where landscape printing mode would be ignored.|
|26183|API|Settings|ValidateBeforeSave setting displaying errors which are invalid.|
|26273|Report Design|Dashboards|Update behavior of record count in dashboard tiles. This limit should reflect record limit set on report parts set in the report record limits for each report part. This can be altered in the dashboard if user has permissions to flip the tile and access the record count.|
|26562|API|Compilation|Reduced use of DEBUG compiler flags to reduce memory consumption when using a debug or diagnostic hotfixed dll in a production environment.|
|26568|Report Design|Data Sources|Prevented data source from being removed from report if all fields are unselected from that data source, when using Instant Reports.|
|26579|Report Design|Subreports|Removed ability to use combo key within the VG block of an Analysis Grid and cleaned up AG construction methods.|
|26659|Report Design|Filters|Manual entry filters lose focus for end user after 1000 milliseconds of inactivity, causing users to reposition the mouse in the text entry box after typing and stopping.|
|26695|Report Design|Pivots|Fixed crash when using pivot and Izenda claims to "add pivot columns to report before removal of already existing ones was made".|
|26702|Report Design|Printing|Added ability to page break on split when using a fixed number of columns per printed page, and a low number of records causes multiple sets of columns to appear on the same page.|
|26704|Report Design|Filters|Made error message more explicit when a filter value is invalid for the data type of a field.|
|26743|API|Compilation|Cleaned up node_module folders to reduce compilation errors.|
|26765|Report Design|Saving|Category is lost when reports are saved in the new Instant Report page.|
|26778|Report Design|Saving|Fixed the error "current report set is not dashboard" which could happen if session data changed or was invalidated during the dashboard save process.|
|26788|API|Compilation|Cleaned up some internal code for a slight performance boost.|
|26799|API|Settings|Corrected a problem which prevented MSSQLDriver.GetSqlName from finding aliased fields.|
|26803|Report Design|Subreports|Prevented values passed via url to a filter from 'sticking' in the filter when a different value is input into filter and then the report is refreshed.|
|26804|Report Design|Data Sources|Prevented blank fields from appearing in Instant Report designer when using Fusion to connect to multiple databases.|
|26811|Report Design|Saving|Fixed error which prevented user from changing scheduler time code from AM to PM without setting time also, meaning reports couldn't easily be scheduled for noon.|
|26874|Report Design|Visualizations|Corrected issue which prevented Calendar visualization from appearing in Instant Reports.|
|26880|Report Design|Subreports|Corrected a condition which would cause the subreport link of a field on the grid to not be read correctly by the Auto Chart visualization.|
|26896|Report Design|Charts|Prevented user from selecting Gauge format for a field on the chart object.|
|26904|API|Settings|Closed obscure loophole which could allow writing to reports without permission.|
|26925|Report Design|Charts|Prevents chart label from being 0 or "Undefined" if a subreport is present on the chart.|
|26932|Report Design|Visualization|Fixed ReferenceError caused by Auto Gauge visualization.|

# 6.10.0.14 (January 11, 2017)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|25823|API|Optimization|Using this setting "AdHocSettings.CategoryCharacter = '#'" should not be supported as a character. It can cause issues with URL's within Izenda|
|26040|Report Design|Data Sources|In some environments visible data sources are not persisting causing reports to be missing on the report list.|
|26147|User Interface|Filters|Removed underscore from multi-word filter descriptions.|
|26242|Report Design|Pivots|Nulls are now aggregated together in a pivot instead of being discarded.|
|26270|Report Design|Visualizations|Added more relative paths to visualizations and other resources to prevent 404s when loading report part components.|
|26299|User Interface|Dashboards|Added ability to refresh dashboard items in the gallery. Add the following to the global file and these options will appear on the refresh menu in the dashboard. public override Dictionary<string, int> GetAutoRefreshIntervals() { var result = new Dictionary<string, int> { { "Every day", 60 * 60 * 24 }, { "Every hour", 60 * 60}, { "Every minute", 60}, { "Every 5 seconds", 5 } }; return result; }|
|26311|Report Design|Subreports|Fixed error which would occur if a field comparison filter were used in a popup subreport. The report would fail saying that the filter value could not be found.|
|26313|Report Design|Dashboards|Prevented a situation where custom css on one dashboard tile could override the css of another tile.|
|26317|Report Design|Filters|When changing filter operator from equals checkbox to equals multiple the results are blank for the filter values when using "AND" in the filter logic.|
|26336|Report Design|Data Sources|Fixed problem which prevented left joins from being recognized when using table aliasing on self-join.|
|26343|Report Design|Visualizations|Corrected a problem with stacked bar charts in auto visualization which would cause the bar elements to render in reverse order from the chart legend.|
|26357|Report Design|Subreports|Fixed an error preventing popup subreports from displaying from a Form.|
|26370|Report Design|Filters|Corrected a set of linked bugs relating to grouping by date in filters, dates cascading improperly in filters, as well as dates not properly respecting culture settings.|
|26371|Report Design|Dashboards|Fixed an error when adding two interactive visualizations to a dashboard and exporting that dashboard to excel, the generated link would return a faulty report instead of the dashboard.|
|26383|Report Design|Exports|_INTERNALDOTCHAR_ showing on scheduled CSV column headers where a "." exists in the column name.|
|26395|Report Design|Subreports|Clarified behavior of Auto Chart - Pie, when using the 'Other' slice setting - these other values cannot be used for a subreport or drilling to another level of data on the same report.|
|26397|Report Design|Exports|When exporting to CSV system generates TMP files and they are not being properly removed from temp directories.|
|26416|API|Settings|AdHocSettings.ShowDistinct ensure distinct text box is shown or hidden based on the setting and that query will remove distinct setting if datatype does not support this function.|
|26442|User Interface|Subreports|Custom URL field should not be available for any field if a subreport is already configured for that field.|
|26454|User Interface|Fields|Fixed a minor driver issue preventing column descriptions from being empty.|
|26461|Report Design|Visualizations|Calendar Visualization advanced setting options do not work properly in the New Instant Report page.|
|26479|User Interface|Filters|Fixed left and right arrows on the calendar popup display when filtering datetimes.|
|26499|User Interface|Instant Reports|In New Instant Reports page disabled settings for a field which not compatible with binary field type. and disabled ability to use groups when user added a binary field to report.|
|26506|Report Design|Exports|Corrected a problem which would prevent datetimes in non-US culture settings from being exported to Excel properly.|
|26532|Report Design|Exports|Corrected error when encoding datetimes which would sometimes cause them to be wrapped in bad HTML when exported to Excel.|
|26540|Report Design|Filters|Corrected a null reference error which could happen when filters are applied to a calculated field which is on a report using a stored procedure joined to a table or view.|
|26549|API|Optimization|Made further script/resource changes around the handling of IzPid in the webforms-cs kit.|
|26569|Report Design|Filters|British pound symbol is causing object reference error when used for filtering a expression value.|
|26614|User Interface|Forms|Adding the style tag in the Form editor would cause it to lock.|
|26634|Report Design|Charts|HTML bar chart is not saving proper settings created in the report designer. Once saved the settings are removed.|
|26664|Report Design|Filters|When editing a report with existing filter, operator from last filter is auto added to new filter field.|
|26679|Report Design|Instant Reports|In New Instant Report Designer, Round Style Auto Gauge is not displayed when selected. The grid is displayed instead.|
|26681|Report Design|Fields|Grid header styles (bold and italic) are not displayed properly in the dashboard when set in the report.|
|26707|Report Design|Visualizations|When creating a new report and adding a visualization, once previewed and the user saves report and attempts to return to the chart tab, the visualizations are not available to change the selected item.|

# 6.10.0.13 (December 6, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|24690|User Interface|Forms|Fixed an error that would appear if a user clicks on the Smart Tag button in the Form designer rather than the dropdown.|
|25711|API|Optimization|Cleaned up some unused classes and scripting files (\AdHocReport.js, AdHocReportRenderer.js, AdHocWebservices.js).|
|25902|User Interface|Printing|Added splash page when a new window is for opened for printing, for browsers that do not support ajax requests while this is open.|
|25998|API|Optimization|Implemented basic authentication in the standard scheduler to allow report scheduling when RequireLogin is true. More info [[here|/FAQ/Implementing-Scheduler-Security]]|
|26037|User Interface|Charts|Updated HTML charts to avoid having scroll bars in dashboard tiles. Charts should size within the container.|
|26070|User Interface|Report Designer|Fixed some missing resources which could cause 404 errors when interacting with some parts of the UI, such as the field position slider.|
|26081|Report Design|Joins|If user adds a join alias to the first join and it is the same type of alias that is used by Izenda auto aliasing, example "Orders2" for the first instance of the Orders table, the system is not checking that this alias is already used. This causes errors in the join as the alias is duplicated.|
|26100|Report Design|Subtotals|When using Visual Group and Field Value styling, some subtotals are not correctly calculated.|
|26128|User Interface|Dashboards|When clicking the edit report button on the back of Dashboard tiles, the user is redirected to the report designer even when the report was created in the Instant Report designer.|
|26133|Report Design|Report Designer|Unnecessary database query causing error when editing pivots in new Instant Report page.|
|26135|Report Design|Charts|Fixed error which would prevent datetime formatting from being applied correctly to the separator field of a chart.|
|26142|Report Design|Subreports|Re-implemented ability to use popup style subreport on one subreport and have another popup defined in that subreport. The first popup will close when the second is opened.|
|26144|Report Design|Report Designer|Adding support of AdHocSettings.DefaultTable setting in new Instant Report page.|
|26150|Report Design|Report Designer|Null reference error received when using some grouping functions.|
|26153|Report Design|Joins|When creating a report with multiple self joins to the same table, if user is not setting the alias, some reports are not saving the join properly.|
|26155|User Interface|Saving|"Save As" not working properly when report contains an apostrophe.|
|26170|API|Optimization|Fixed a crash which could result if virtual data sources were enabled, report validation is disabled, lazy stored procedure metadata pulling is true, and visible data sources are set.|
|26176|Report Design|Report Designer|When using more than one arithmetic function in a report the report becomes corrupted as there appears to be two fields without descriptions.|
|26178|Report Design|Subreports|When a comma is contained in a field value which is used for subreport drilldown, the drilldown sometimes fails.|
|26184|Report Design|Filters|Fixed the application of boolean filters to apply correctly during filter refresh.|
|26196|API|Settings|Obsolete Setting: AdHocSettings.UseDefaultDialogs = true;|
|26200|User Interface|Report Designer|When using New Instant Report page, if user clicks on a field multiple times quickly the preview is sometimes incorrect|
|26202|Report Design|Subreports|Additional changes for 26001, when using drilldown in Pivot grid to ensure no further issues based on values in column headers of pivoted data.|
|26219|Report Design|Filters|Fixed a problem which would cause filters to invalidate or disappear if they were built from fields calculated in virtual data sources.|
|26254|Report Design|Expressions|Enhanced case statement functionality to ensure that grouping data after case on multiple fields results in one row of data.|
|26257|API|Settings|When AdHocSettings.SortColumnNames is set to False it does not disable alphabetical sort of fields in the Report Designer or Instant Reports.|
|26271|API|Optimization|Cleaned up ReportSet.ScheduleUtc to prevent inadvertent changes in timezone from being saved to report xml.|
|26272|Report Design|Rendering|Changed doc type to prevent pagination from rendering an extra blank page in Internet Explorer.|
|26276|Report Design|Visualizations|Using the hide grid setting with World Tour visualization, received error "Cannot read property 'o' undefined"|
|26301|Report Design|Charts|Exported HTML - Pie chart not scaling properly when exporting after scale is increased in settings.|
|26302|API|Filters|Adding ability to create logic in PreExecuteReportSet to force user to add filter values for specific filters. Example: { if (reportSet.Filters.Count < 2) return; bool f1Set = true; bool f2Set = true; if (ReportSet.Filters[0].Value == null || reportSet.Filters[0].Value == "" || reportSet.Filters[0].Value == "...") f1Set = false; if (ReportSet.Filters[1].Value == null || reportSet.Filters[1].Value == "" || reportSet.Filters[1].Value == "...") f2Set = false; if(!f1Set && !f2Set) reportSet.FiltersNotSpecifieldMsg = "You must set values for at least one of the first two filters." }|
|26306|Report Design|Report Designer|Corrected problem that would cause numeric fields in the summary grid to drop formatting if they were not on the first page of a pagination.|
|26334|Report Design|Charts|Some labels of Funnel Auto Chart are being cut off in the New Instant Report page.|
|26372|User Interface|Saving|New category is not saved when changed while editing report in the new Instant Report page.|
|26378|API|Settings|Made a change to AdHocSettings.Language to properly set datetimes across culture and language settings when exporting to Excel.|
|26405|Report Design|Report Designer|In new Instant Reports, Pivot side totals are not properly calculating when pivots have more than 100 columns.|
|26408|Report Design|Charts|Removed white bar showing up in some large Funnel Charts when long label strings are truncated.|
|26410|Report Design|Joins|Added quotes to TenantID in query which generates Izenda table in database report storage mode in PostgreSQL.|
|26411|Report Design|Report Designer|Updating Reference Implementation for MVC kits to default to New Instant Report page.|
|26413|Report Design|Subreports|When adding a subreport to an X-axis on visualization the null values display as index values instead of null.|
|26471|Report Design|Visualizations|Prevented time only formats on datetimes from breaking visualization labeling.|
|26473|Report Design|Report Designer|Updated URL to settings page causing issues in MVC kits.|
|26478|Report Design|Charts|Corrected an issue which would prevent basic charts from rendering thumbnails correctly as well as appearing in Dashboard presentation mode.|
|26480|Report Design|Rendering|Clarified rendering logic to eliminate some problems when rendering Izenda within an IFrame.|
|26486|Report Design|Report Designer|Fixed subtotals sometimes being incorrect in PostGresql.|



# 6.10.0.12 (November 9, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|HF-25957|API|Methods|Corrected merge issue which was preventing ReportInfoLite from being accessible.|
|25060|Report Design|Dashboards|When adding HTML charts where user has changed the size to a Dashboard(V1 dashboards) sizing is not respected.|
|25453|API|Methods|New setting added in AdHocSettings, HideFiltersWhenLocked. This will remove the filter block when user is viewing the report in a locked view mode from report viewer.|
|25460|API|Databases|Multiple constraints are not not being added to queries when using Fusion driver.|
|25523|API|Databases|When using bracket notation with VisibleDataSources and an Oracle driver, those datasources would not be loaded due to a mismatch between the query looking for patterns with the double quote character as opposed to the bracket character.|
|25687|Report Design|Printing|Corrected a problem that when a user opens a sub report to a new tab, then goes back and opens a second sub report with different filter criteria to a new tab, if the user then goes to the first sub report tab and prints to HTML, they will get the second sub report printout because of a shared session.|
|25699|Report Design|Subreports|Fixed @subtotal error occurring if you use a stored procedure parameter as a drill down key to call an embedded subreport in a form.|
|25700|Configuration|Databases|Corrected a problem causing a failure to load constraints (PK/FK relationships) from database for newly added tables.|
|25756|API|Methods|Made following method public allowing users to refresh the cached reportset results when using Fusion Cache. The method takes the report full name (this must include Category and Subcategory if present. Izenda.AdHoc.FusionCache.RefreshReportInCache(reportFullName, true, true); It is recommended that this be used in PreExecuteReportSet, using outside of this method may result in unexpected behavior.|
|25760|Report Design|Exports|Increased font size for PDF exports to improve the look of exported PDF reports.|
|25763|API|Methods|Added ability for users to override the schema queries in Izenda.|
|25764|Report Design|Subreports|Using embedded subreport with combokey drilldown key caused error.|
|25767|API|Databases|Fully qualified datasource names in VisibleDataSources were failing to find datasources when using an Oracle driver and having the UseTablesFromSchemaOnly flag set to true.|
|25768|API|Databases|Stored procedures in VisibleDataSources would never be obtained when using an Oracle driver and when the UseTablesFromSchemaOnly flag was set to true.|
|25779|Report Design|Filters|Fixed In Time Period filters not appearing on dashboard when used in report, even if they are a common filter.|
|25804|Report Design|Subreports|Corrected drilldown reports using popup style showing no results when used in dashboard.|
|25845|API|Databases|Null reference exception was found in scenarios where any field with data type corresponding to SqlTypeGroup.Other.|
|25860|Report Design|Filters|Empty value In Time Period filter causing problem when at least one filter is required is used.|
|25863|Report Design|Expressions|Using a line break in the Expression text field would cause the javascript parser to fail and resulted in unexpected visual errors on the report designer.|
|25871|Report Design|Dashboards|Error received on dashboard when base report is deleted from report list.|
|25898|API|Methods|Optimized methods for rendering HTML.|
|25957|API|Methods|Added elements to ReportInfoLite() (Report Description, Title, and Drilldownkeys) allowing additional flexibility in the report list for hiding and displaying elements.|
|25958|Report Design|Subreports|Prevented an error which would occur if a report were designed to use a visually grouped field as a subreport trigger.|
|25961|Report Design|Filters|When using advanced tab of the report designer to create any join (more than one table selected), all filers values in the filter tab become pill type entries like an autocomplete instead of plain text entry.|
|25968|API|Filters|An ORA-01036 error would occur when using a DateTime filter with any Equals operator that allows more than one selection (e.g. Multiple, Popup, Checkboxes) and when selecting only a single value from the list.|
|25972|Report Design|Reports|Corrected a bug which prevented pagination from tallying records correctly.|
|25993|Report Design|Filters|Filter field properties cannot be opened after filter description is removed.|
|25994|Report Design|Visualization|World Tour visualization labels are not in proper alignment when filter is added.|
|26001|Report Design|Visualization|Fixed an exception which could occur if using a pivot in the fields tab to power a visualization. When doing this, sometimes the X axis label of the visualization woul display the literal field name rather than the alias or description.|
|26025|API|Methods|Made the flag UseCachedFilteredLists public to allow for scenarios where reports enter the system in non-standard ways where the internal cache updating mechanisms would have no knowledge of the new reports.|
|26072|Report Design|Exports|After setting a color for table border it is not exported to excel when scheduling a report.|
|26077|Report Design|Visualization|Added more specific error messages for issues around exporting charts/visualizations.|
|26112|Report Design|Pivots|Fixed error where New IR pivots cannot be created when using more than one datasource in.|
|26125|API|Methods|When creating instant reports the DefaultVisibilityForNonAdmins and DefaultSharingRights are not added to the XML.|
|26126|API|Resources|An error in the way base URL detection is handled in MVC kits caused the Instant Reports page to incorrectly redirect to the report designer, report tiles exported on the dashboard to fail, and report tiles opened in the report viewer to throw an error.|
|26140|User Interface|Dashboards|Navigation arrows missing from Dashboard when there are too many reports in a category to show them on one row.|
|26152|Report Design|Dashboards|When user clicks on New and selects Dashboard then clicks on Folder to see reports, but then clicks Dashboard the dashboard is blank. This should give the user a new blank tile to add a report part.|
|26162|Report Design|Dashboards|Scrollbars appearing in dashboards for charts when there is no scrollbar required|
|26164|Report Design|Dashboards|Position of popup values for calendar visualization when user switches the position of the report part on a dashboard.|
|26204|Report Design|Visualization|Prevented a bug which would prevent a subreport attached to an auto chart visualization from appearing on the instant report viewer while using Internet Explorer.|
|26205|Report Design|Dashboards|Prevented a problem where loading a dashboard from a category would sometimes cause dashboard tile functions to be unavailable.|

# 6.10.0.11 (October 4, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|HF 26010|Report Design|Dashboards|Resolved Issue found where filter logic is not applied to report parts used in dashboard. **(Oct. 14, 2016)***
|HF 25952|Report Design|Dashboards|Fixed "refresh tile" button visibility. **(Oct. 10, 2016)**|
|HF 25959|Database|MySQL|Fixed missing filter on Date/Time columns in ODBC drivers. **(Oct. 10, 2016)**|
|25441|Report Design|Dashboards|Subreports contained in Forms are not loading when using in Dashboard. **This change required moving Filters on Dashboards from ReportSet.Reports.Filters to ReportSet.Filters please note this will change behavior of any overrides used in areas like PreExecteReportSet**|
|24692|Report Design|Export|When using Bulk CSV export receiving errors when exporting pivoted data with large column headers. Additional issue with parameters when using Oracle with Bulk CSV.|
|24948|Report Design|Export|Adding Setting for exporting Grids to set number of columns per page on printed export.|
|25173|Database|Oracle|Issue when using Oracle, COLLATE database_default which is added to query is not compatible with Oracle. Removing from Oracle queries.|
|25220|API|Angular|Updates to URLs for integrating with Angular2 applications. angular url: http://..../path/to/page/page.aspx#/angular/path angular2 url: http://..../path/to/page/page.aspx/angular/path|
|25350|Report Design|Expressions|Fixed a problem where expressions could not track self-joined tables such that a Table might have the Table1 alias.|
|25360|Database|General|Changing query to database for schema data to always include VisibleDatasource to avoid pulling items not required for use in Izenda application.|
|25385|Report Design|Maps|Added support for unzipped version of map data. Due to security concerns this file (geoataalt.zip) can be unzipped in your implementation and used unzipped.|
|25387|Report Design|Instant Reports|Resolved issue with moving from New Instant Report page to Report Designer Page. Designer page loaded, but there were no fields selected.|
|25411|User Interface|Instant Reports|Fixed '\' category character for new IR page. Causing error when loading report to be uncategorized.|
|25418|User Interface|Report Designer|Issue resolved missing edit button on custom html page introduced by Case 23465, resolved.|
|25454|Report Design|Dashboards|Error when drilling down in chart with unsaved report/dashboard when using automatic as drilldown report.|
|25467|Report Design|Forms|Fixed bug in base64 encoding in JS which led to the inability to save a form with special symbols.|
|25473|Report Design|Export|Using Safari, export to Excel is missing from the Report Desinger.|
|25547|API|Settings|Adding AdHocSetting to remove N' from filter values. AdHocSettings.OmitUnicodeFlagForCharParameters = true;|
|25550|Report Design|Export|Fixed arithmetic calculated fields not being properly formatted when exported to Excel.|
|25597|Database|General|Fixed a bug which prevented fields on the second data source of an outer left join from being used properly as a filter.|
|25603|Report Design|Export|Prevented currency format from causing an invalid string error when used in a chart.|
|25618|Report Design|Dashboards|Prevented dashboard tiles from rendering improperly in presentation mode.|
|25619|Report Design|Export|Corrected the days old format such that it will properly export to Excel.|
|25622|Report Design|Filters|Error found when subreport inherits master report filters, filters on fields with expressions should not be passed to the subreport.|
|25636|Report Design|Visualization|When using calendar visualization and there are multiple items on one date there is a "+" to view multiple items. When clicking this item there only two items are displayed even when there are more items.|
|25637|API|User Interface|Cleaned up and minimized the number of Ajax requests in the Izenda UI.|
|25638|Database|General|Issue found which appears when you specify a column in the format "schema.table.column", this was found internally and not a reported issue.|
|25648|Report Design|Visualization|Three dots ( . . . ) are displayed instead of the event name in Calendar visualization. Also, found issue with event colors based on the value.|
|25649|Database|General|Unable to use the auto assigned alias of <TableName2> when creating expressions using multiple instances of one table. System throws error that the field being used is unknown.|
|25652|Report Design|Filters|Corrected date filters to assume a recent date rather than the earliest date in the data set.|
|25682|User Interface|Instant Reports|Error when navigating from Instant Report to the Report Designer using the edit (pencil) icon.|
|25697|User Interface|Dashboards|When resizing tiles in dashboard and presentation mode receiving error "Uncaught TypeError: Cannot read property 'offsetWidth' of null".|
|25698|User Interface|Dashboards|Scroll appears in dashboards tile when it is not needed.|
|25723|Report Design|Visualization|After creating report with a visualization that allows you to select a metric (AutoChart, for example) if you select a specific metric in the drop-down metric list (not the "All" pseudo metric). Save the report and then change description of metric field. This will break the visualization.|
|25733|User Interface|Report Designer|Resolved all button elements without type attribute specified. The default "type" value could be different for different browsers. Fixed all button elements without type.|
|25736|Report Design|Export|Issue found with IExcelFormatter and exporting some dates. Showing as decimal not date format.|
|25737|Report Design|Filters|Disabled field comparison for stored procedure parameters.|
|25741|Backend|Config|Removing unnecessary initialization changes during license key check.|
|25749|Report Design|Subreports|Subreport does not pop up and does not display on Map after the user saved the report.|
|25753|Report Design|Instant Reports|In New Instant Reports if you design a report with the Isn't Blank operator and save it, it will carry through the same operator into the Report Viewer. However if you edit that report after viewing it, the Isn't Blank operator will turn into a Blank operator.|
|25754|Report Design|Dashboards|Subreport won't display while report was on the full screen mode on dashboard.|
|25761|Report Design|Export|Removed extra lines and carriage return from bottom of .csv exports.|
|25788|User Interface|Dashboards|Error in dashboard scheduler changing scheduled time from 12 hour format to 24 hour format causing the wrong scheduled time to be saved.|
|25803|User Interface|Instant Reports|Using AdHocSettings.AllowCreateNewCategory = false, the New Instant Report Page is showing category option and allowing creation.|
|25851|Report Design|Report Designer|When there are no reports in the Izenda sysetm javascript error occurs on the report list page so the corresponding message is not displayed and the redirection to the designer is not occuring.|
|25884|Report Design|Dashboards|Report becomes Blank on presentation mode when Exported Report(HTML) was opened on dashboard.|
|25885|Report Design|Visualization|When adding a subreport to a visualization the linking field on the axis becomes unformatted.|
|25909|Report Design|Export|Fixed error where the text "[object]" would appear in HTML export instead of certain report parts.|

# 6.10.0.10 (September 7, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|23824|API|UI|Tenant Field is not properly aliasing when set to show in UI.|
|24358|API|Optimization|Added additional logging for session availability to assist with diagnosing session issues.|
|24585|Dashboards|UI|Tile resize handle in the right-bottom corner of tile doesn't react on tile animation.|
|24615|Report Design|Visualization|Made improvements to the Maps tab that conform to recent changes made to support map Visualizations. Also we now permit using more than one geographic descriptor (name, coordinates) at the same time.|
|25012|API|Optimization|New Setting for MSSQL use only. AdHocSettings.ForceOptimizeForUnknownMsSql = true; This setting adds the OPTIMIZE FOR UNKNOWN optimizer hint to all SQL queries. This hint directs the query optimizer to use the standard algorithms it has always used as if no parameters values had been passed to the query. In many situations this can speed up query time.|
|25067|Report Design|Export|Clicking on SQL export generating error when using chart with no separator.|
|25081|API|Optimization|When using synonym with the same name as the parent object only the synonym will be available in the datasources. Before this, both synonym and parent will be shown effectively showing duplicate datasources.|
|25103|API|Optimization|Added Setting AdHocSettings.DundasImagesPath to specify a alternate URL for obtaining Dundas Library images.|
|25129|Report Design|Optimization|Adding ability to use comma character in view/table/column name.|
|25179|Scheduler|Optimization|Scheduling dashboards as embedded in an emails shows broken images links, not the actual image for charts.|
|25205|Report Design|Pivots|When creating a pivot using the add field button is not working when using the FireFox browser.|
|25258|API|Optimization|Removing "Other" option for Expression Type. Removal of this will not effect reports already using this expression type but it will not be available in the dropdown list going forward.|
|25259|API|Optimization|Made the css for tabs, dashboard-tabs, toolbar configurable in /css rather than hardcoded in rs.aspx.|
|25292|Report Design|Joining|Adding forced left join errors without schema|
|25297|Report Design|Filters|Use previous or not working for filters using the same field name for self joined tables.|
|25314|Report Design|Optimization|When using field value report style, preview report. Return to the Style tab and input limit for number of items per page and preview. Causes report to return no data after page 1.|
|25328|API|UI|Trimmed extra spaces/lines from appearing in category dropdown on the save dialog.|
|25329|Dashboards|Optimization|Refactored Dashboard tile loading to prevent lag in browser responsiveness.|
|25331|Report Design|Expressions|Corrected a problem which would prevent an expression with spaces from executing properly in MySQL.|
|25333|Report Design|Visualization|Added a more explicit error condition when using World Tour visualization without proper data.|
|25342|Report Design|Optimization|Prevented a problem which would stop fields from properly displaying when used as smart tags in a report header.|
|25343|Report Design|Export|Error received "undefined is not an object(evaluating 'dynamicFontSizeCheckbox.prop')" when exporting calendar on HTML, PDF, Excel and Word.|
|25350|Report Design|Expressions|Fixed a problem where expressions could not track self-joined tables such that a Table might have the Table1 alias.|
|25356|Report Design|Charts|Adding setting to extend timeout on Chart snapshot for exporting charts. This timeout will extend the current 15 second limit to obtain image of chart prior to time out for exporting. AdHocSettings.ChartToImageTimeout = 200;|
|25366|Report Design|UI|Corrected an error where the wrong format was being applied to the subtotal of date fields.|
|25374|API|Optimization|When using ODATA connection and selecting equals select filter type on date field selecting date from drop down returns no results.|
|25375|API|Optimization|Changed how keys are obtained to prevent some Postgresql errors from appearing when some joins might create duplicate keys.|
|25377|API|Optimization|Corrected a problem which could prevent functions from being applied properly in Postgresql.|
|25383|API|Optimization|Corrected an error which prevented expressions from being applied properly in Postgresql.|
|25384|Dashboards|Optimization|Fixed izpid functionality on New Dashboard and New Instant Report page to prevent two different instances of Izenda on different browser tabs from sharing information when using the izpid. This feature only works with thew Instant Report page and the New Dashboard page.|
|25390|Report Design|Optimization|Corrected problems with Virtual Datasources. 1 - Tenant Specific, one tenant should not see the Virtual Datasources of another Tenant. 2 - Report security is respected, user A will not see user B virtual datasources unless shared via proper sharing rights. 3 - Schema updates correct to ensure all virtual datasources are added.|
|25393|API|Optimization|Error received when using @subtotal decorator when using a stored procedure param as a drill down key to call an embedded subreport in a form.|
|25425|Report Viewer|UI|Added more explicit exception when thumbnail generation fails rather than generic object reference error.|
|25431|API|Optimization|Prevented a crash when Izenda is trying to access a database synonym which points towards a nonexistent data source or database.|
|25439|Report Design|Filters|Corrected logic being applied when using autocomplete filters and automatic filter AND setting.|
|25451|Dashboards|Visualization|Corrected problem which would prevent visualizations from rendering properly in a dashboard tile if that tile is resized.|
|25452|Dashboards|Optimization|Missing close paren on dashboard code behind file on dashboard.aspx.vb|
|25472|Report Viewer|Saving|Prevented report guid from appearing in save dialog box instead of report name.|
|25483|Dashboards|UI|Enhanced dashboards to support a dashboard being visible to a user when some report on that dashboard is not visible.|
|25489|Report Design|Forms|Made it possible to use value ranges and subtotals at the same time on a form.|
|25512|API|Optimization|Fixed some static links in the webforms starter kits which would prevent some parts of the user interface from being properly overridden.|
|25556|Report Viewer|Visualization|Fixed error which would prevent Timeline visualization from rendering properly when using Oracle time data types.|
|25564|Report Viewer|Filters|Corrected an error that would prevent custom popup filters from applying instead of default popup filter.|
|25578|Dashboards|Filters|Prevented checkbox, popup, and multiple style filter operators from losing values on a dashboard after the dashboard is refreshed.|
|25584|Dashboards|Optimization|Using Records Count on back side of dashboard tile not working. Slider disabled.|
|25585|API|Optimization|Fixed jQuery error on Arcmap visualization that would prevent switching between different metrics, throwing a "cannot read property" error.|
|25593|Report Viewer|Filters|Between(Calendar) filter operator could disappear after saving the report under some circumstances.|
|25617|Report Design|Optimization|Corrected error exposing script when a subreport field with a link is used as a visual group header.|
|25627|Dashboards|Optimization|Error received "Report Not Found" when browsing to report from Dashboard tile. When User opens a existing report (with filter) by selecting from the Dashboard, and add new filter to it. After saving the report in Report Viewer, when User refreshes the Dashboard error is displayed.|
|25628|Dashboards|Optimization|Found incorrect spelling in Dashboard save notification "successfully" is misspelled.|
|25642|Instant Reports|Optimization|Issue with invalid character in URL causing Instant Reports and Dashboard page.|

#6.10.0.9 (August 10, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|21189|Dashboards|UI|Updating dashboard Thumbnails to display actual screen representation of tiles.|
|22808|API|Optimization|Expanding support of Izenda Geotable for Lat/Lon, expanding internal geotable, offering high volume additional geotables on GitHub.|
|24023|Dashboards|UI|Implemented custom gallery viewer for Dashboards.|
|24714|Report Design|Pivots|Custom Pivot sorting code no longer working after updating version past 6.10.0.5|
|24726|Report Viewer|Visualization|Changes needed with visualizations, in some cases where custom HTML is added the chart is always slightly larger than the tile space, thus forcing scroll bars to appear when unnecessary.|
|24734|Report Design|Filters|Cascading doesn't populate correctly if nothing is selected on the first filter in New IR Page.|
|24764|Report Viewer|UI|Responsive grid feature not working properly with column headers.|
|24799|Scheduler|Optimization|Fixed issue where leaving the repeat type in the scheduler caused the entire scheduler process to hang.|
|24904|Report Design|Visualization|When using drill down on visualization and display in new tab showing no framing information. Shows a pop up window style in new tab.|
|24920|Report Design|Visualization|Changing Sunburst Visualization center Percentage calculation on drilldown to show the total percentage of the slice after drill down.|
|24933|Scheduler|UI|When scheduling reports as links in email URL contains double slash which prohibits link from being clickable.|
|24937|Report Design|Visualization|Visualization built from Pivots where values contain whitespace causing %NaN to show in drill down breadcrumb navigation.|
|24938|Report Design|Pivots|Corrected a problem where a pivot built to display strings in the cells would throw an index error if subtotals are active, as then the tool would attempt to sum null strings.|
|24960|Dashboards|Optimization|Inconsistency between these methods, and code which prepares filters values data for serialization to json. Causing errors when sending dates to dashboard filters from URL.|
|24988|API|Optimization|Custom pop up pages no longer responding. Receiving "resources cannot be found" error in popup page.|
|25002|API|Saving|Saving prevented Forms HTML renderer from encoding characters within the <!--FORMSCRIPT--> tag, which would break some scripts/jquery.|
|25037|API|Optimization|AntiXss escaping causing issue when using totals on Analysis Grid. Showing extra text strings in totals.|
|25039|Report Viewer|Filters|Rendering incorrect date formats when exporting from Izenda Form to Excel.|
|25042|Report Viewer|Visualization|Hover text data colors and type does not properly match to colors in bar version of autochart.|
|25054|API|UI|Prevented a problem where custom header overrides could result in duplicate headers being generated.|
|25056|Dashboards|UI|Dashboard report titles are not properly updated if titles are added to report after dashboard is created.|
|25061|Report Design|Pivots|Corrected an error where pivot column headers were being included in the group clause.|
|25065|Dashboards|UI|Updating x/y coordinates for old dashboards to avoid overlaps of tiles when upgrading.|
|25080|Dashboards|Optimization|Fixed the issue where navigating directly to the dashboard would change "\" to "/" every time it is not in the URL parameter resulting in the category list not showing.|
|25086|Report Design|UI|When using Quick add in the Report Designer with large amounts of column names the popup only displays portions of the list and no ability to scroll or see all of the columns.|
|25098|Report Design|Saving|When using Report Categories and having no Uncategorized reports causes formatting issues in the Category drop down when saving the report.|
|25107|Report Viewer|Filters|Passing p values to In time period filter results in user having to update results in report viewer to apply filter.|
|25111|Report Design|Optimization|Fixed issue where combo keys and embedded sub-reports did not work together.|
|25132|API|Optimization|Using AdHocSettings.SettingsKey to password protect the Settings page is showing a null reference exception.|
|25142|API|Filters|When using FilterRegex setting, fields listed in regex are not able to be added to reports in the report viewer from the fields tab.|
|25189|Instant Reports|Filters|Values using "Equals(List)" as operator, the operator disappeared after saving the report in New IR page.|
|25190|Report Design|Export|Using VG Hierarchy Visual Group Style, the First column is exporting in the second column leaving the first column empty.|
|25223|Report Viewer|Charts|Fixed issue where correct chart was not displaying for pop-up sub-reports based on value clicked.|
|25241|Dashboards|UI|Refreshing unsaved dashboard causing sizing issues with dashboard tiles.|
|25244|Report Design|Filters|Fixed issue where the ellipses (select all) was missing from the Equals Multiple filter in the Instant Reports designer.|
|25263|Report Design|Visualization|"Cannot read property 'o' of undefined" / "Cannot read property 'formatter' of undefined" When using several visualizations. The bug is only reproduced when you create a new visualization (when you create a new report). This applies to the following visualizations: World Tour, Sunburst, Arc Map, Projected Map, Heatmap, Auto Chart, Flowchart and Tree.|
|25269|Report Design|Filters|When adding values in filters using "Equals(Autocomplete)" as operator, other values are being replaced/disappear when adding more.|
|25303|Report Design|Filters|Using Days Old format on field causing error on report when exported to Excel.|
|25311|Report Design|Charts|Result of Arc Map is, "This chart has been set up incorrectly (see Help)."|
|25344|Dashboards|Visualization|After the user saves the report Transition Visualization does display on presentation mode on dashboard.|
|25353|Dashboards|UI|Presentation mode returns blank tiles after user changes the report while on the Presentation mode of Dashboard.|
|25362|Report Design|Optimization|When using Italic and bold on separator in an analysis grid receiving HTML instead of Field Value.| 

# 6.10.0.8 (July 12, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|HF25061|Report Design|Pivots|Corrected an error where pivot column headers were being included in the group clause. 6/14/16|
|HF25062|Report Design|Dashboards|Removed a debug string which would cause the text " a"b " to appear on dashboards.6/14/16|
|22122|Report Design|Visualization|Corrected behavir of AutoChart when showing 'blank' (white) bars.|
|22385|Report Design|Visualization|Enhanced Bubble chart to support more than 31 items/styles in Internet Explorer 9 or older.|
|22521|User Interface|Instant Reports|Corrected labeling of panels in Instant Report.|
|22989|API|Settings|'\\' and other category denoting symbols can now be chosen through refactored/fixed 'CategoryCharacter' setting.|
|23448|API|Exports|Added API to allow post processing of export files. Initial intended use case is for compressing larger files prior to download for faster processing.|
|24104|Report Design|Dashboards|Corrected a problem where if the user is calculating a field using an expression, and then using that calculated field in a visualization, and then places that visualization on a dashboard, the dashboard tile would fail to render correctly as it could not properly reference the calculated field used to build the visualization.|
|24372|API|Reporting|Changed internal behavior to correct a rare issue where Izenda would incorrectly identify a report name when provided with a reportID.|
|24387|API|Database|Adding support for synonyms inherited from other databases. Current support for synonyms prior to this change will only show if the synonym and source are in the same database.|
|24405|User Interface|Controls|Corrected numerous Interface/button problems when using Internet Explorer 11 with Windows 7.|
|24500|Report Design|Data Sources|Corrected a rare problem where similar but not identical data types could cause a mismatch error.|
|24504|API|Database|Changed internal behavior of TO_DATE() to prevent the '&' ampersand character from throwing invalid queries in Oracle.|
|24517|Report Design|Culture|Corrected an error that could occur in Excel exports. When culture is switched in Excel, this would sometimes cause Izenda-generated exports to fail to properly match the data type of a field and apply correct formatting.|
|24532|Report Design|Maps|Changed Map legend rendering to prevent long label strings from overlapping the map itself.|
|24539|Report Design|Visualization|Corrected a problem where embedded subreports could break visualizations when they are rendered for export.|
|24551|Report Design|Visualization|Disabled use of Records box on visualizations. This record limit is based on the grid it is built from.|
|24590|User Interface|Controls|You can now add a column to your report in Instant Reports by clicking the checkbox or the column name in the Data Sources view.|
|24592|User Interface|Controls|When Save dialog is opened, cursor is automatically dropped into the Report Name box rather than requiring user to click in the box.|
|24595|Report Design|Visualization|Implemented the ability to use a Custom URL field with calendar Visualization.|
|24625|Report Design|Data Sources|Moved distinct checkbox in Instant Report Designer to Data tab.|
|24627|User Interface|Notifications|Removed text "Please contact sales@izenda.com" from License Key expiration notification.|
|24634|Report Design|Subreports|Two fixes: Removed ability to design a report which embeds into itself. Corrected a loading error that happened when a report was a assigned a drilldown key in the Instant Report designer and then opened again in the Instant Report designer.|
|24644|API|Culture|Corrected a problem where the thread culture would be used to determine the format of a pivot header rather than AdHoc.Culture.|
|24648|Report Design|Exports|Corrected a problem where exporting a report to .doc format would break subreport links.|
|24664|Report Design|Gauges|Truncated labels in Gauge visualization to prevent overlap of label and value.|
|24670|User Interface|Notifications|Clairified error message when using BulkCSV export on a report which lacks data in the Fields tab. BulkCSV only targets the Fields tab, a report with other report parts such as Summary or Chart but no Fields would produce a confusing error message.|
|24671|Report Design|Visualization|Expanded truncation of long labels in more kinds of visualizations.|
|24674|User Interface|Filters|Prevented the Autocomplete filter from showing results where it should not show them unless UI accessibility features are enabled.|
|24690|User Interface|Controls|Fixed an error that would appear if a user clicks on the Smart Tag button in the Form designer rather than the dropdown.|
|24691|Report Design|Gauges|Corrected an issue where Animated Half Circle gauge style could overlap other report parts.|
|24703|Report Design|Visualization|Corrected issues with Matrix visualization producing unreadable text if too many values are selected.|
|24704|API|Enhancement|Added a new setting, OracleDriver.GetStoredProceduresSQL, which allows the use of a custom query to pull metadata for stored procedures.|
|24709|API|Reporting|Changed how methods are called as when Response.Redirect(...) is called under some circumstances within the MVC controller, current session is lost.|
|24728|Report Design|Visualization|Fixed some problems where Arcmap visualization would not be editable in Internet Explorer 11.|
|24739|API|Reporting|Corrected a problem where Izenda could fail to initialize correctly. The given error is " Message: The constructor to deserialize an object of type 'AliasesCollection' was not found."|
|24741|API|Reporting|Fixed a potential problem where under some circumstances the VisibleDataSources could be populated incorrectly when building the schema cache.|
|24753|User Interface|Filters|Fixed filter behavior when user selects empty ('') and blank ('blank') values at the same time in a multiple select filter, which could cause incorrect filtering behavior.|
|24762|API|Enhancement|Added a method to the AdHocConfig to provide programmatic control over the sort order for dashboards on the dash.aspx page.|
|24780|API|Filters|Fixed the population of time periods when using the In Time Period filter.|
|24782|User Interface|Controls|Caught some uncaught functions when certain text is entered into the search bar in Instant Reports.|
|24787|API|Enhancement|Exposed EVO and PhantomJS pdf rendering to permit more extensive and easy customization of various rendering tasks.|
|24797|User Interface|Filters|Made further fixes to the way empty checkbox filters are treated in the report designer - now it should always treat filters with no values selected as if the filter were not there.|
|24821|Report Design|Dashboards|Prevented dashboard title or labels from changing when dashboard is refreshed but nothing else changes.|
|24823|User Interface|Filters|Fixed a problem where under some circumstances popup filter would not consistently display the same filter values.|
|24827|API|Reporting|Minimized the number of requests made by the chart renderer to prevent charts from failing to print correctly due to requests failing for lack of authenticaiton.|
|24847|API|Reporting|Expanded compatability with different server collations to minimize impact of case sensitive data source names.|
|24851|Report Design|Expressions|Enhanced functionality of subtotal expressions and prevented various errors from popping up even though user is correctly using feature.|
|24886|Report Design|Pivots|NOTE: This fix was reverted. Subtotals showing incorrectly when using Sum as subtotal function on pivots|
|24952|Report Design|Dashboards|Records not defaulting to 100 on the back of Dashboard tiles.|
|24967|API|Reporting|Error using Link to new window on New IR page while using Fusion connection. Error "Access to column <column name> is not allowed."|


# 6.10.0.7 (June 14, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|HF 24747 |API|Optimization|Corrected a problem where Field Aliases could not be duplicated across data sources.|
|19079|API|Optimization|Refactor Fusion Driver for better performance|
|22514|API|Optimization|Added a performance enhancement to greatly increase the speed at which metadata for virtual data sources and stored procedures is pulled and cached.|
|22814|Report Design|Maps|Expanding support of Izenda Geotable for Lat/Lon, expanding internal geotable, offering high volume additional geotables on GitHub.|
|23408|API|Optimization|Translations for localization of UI updated. Localization of IR2.0 added.|
|23460|API|Optimization|Corrected a problem where MSSQL synonyms for data sources wouldn't load the corresponding data source correctly.|
|23923|Report Design|Filters|Any filter on a calculated field will cause errors in the report when there is also at least one Pivot column.|
|24021|Report Design|Exports|Corrected a problem where using group(Month Name) for a datetime in a pivot cell would export incorrectly to excel.|
|24027|Report Design|UI|Adding notification to fields when using server side sorting if field cannot be sorted. "This field cannot be used for sorting, please select another field for sorting."|
|24041|API|Optimization|Corrected a problem that could occur with a customized LoadReportSet method attempting to access virtual data sources.|
|24125|Report Design|Exports|Error checking filters from dashboard on PDF export causing error showing "detail report is invalid".|
|24129|Report Design|Exports|When printing a report to HTML, the new browser tab displayed no longer has the scroll bar to browse the report.|
|24139|Report Design|Filters|Corrected a problem where the Equals(Checkbox) filter would interpret no selected values in such a way as to always return zero records, rather than behaving as a blank filter with no effect.|
|24141|Report Design|Scheduler|Adding support for schedule period type "Run Once". Scheduled item will only run one time at the set interval.|
|24145|API|Optimization|Adding exception when adding the same Alias to two different datasources. This should not be allowed and causes errors in reports.|
|24166|Report Design|Gauge|The notification for HTML Cache last update is overlapping the data grid.|
|24182|API|Optimization|Corrected a problem where some formats would not conform correctly to the specified .net culture setting.|
|24197|Report Design|Charts|When using Legend in the "Top" Position the legend overlaps other data in the Pie Chart.|
|24198|API|Optimization|Corrected a problem where SQL used to support pagination would be executed under some conditions where pagination is not enabled, which could cause errors when using Fusion.|
|24201|Report Design|UI|When using only one field in Visual Group style of Field Value the visual group style is not respected.|
|24214|Report Design|UI|Correct spelling error in dashboard, when pointing cursor to "+" sign Select "peport" part to add is displayed.|
|24265|Report Design|Charts|Made HighChart backgrounds transparent by default rather than having a white background.|
|24329|API|Optimization|Made further improvements to multiple joins to the same table while using arithmetic to concatenate strings sourced from multiple joins.|
|24333|Report Design|UI|Corrected a problem where changing the sort order on a table would not be inherited to any subtotal of that table.|
|24334|Report Design|Filters|Corrected a problem with equals(Checkbox) filter operator where filter with no selected value would be passed as an empty string instead of no value.|
|24336|API|Optimization|Made tenantid comparison case insensitive to ensure accurate matching when case sensitive database collation configurations are used.|
|24350|Report Design|Optimization|Show All option in Preview results missing in Report Viewer.|
|24364|Report Design|Charts|Corrected a problem where labeling the left or y-axis on a chart would override the label on the chart's hoverover popup.|
|24380|API|Optimization|Add support for Forced Left Join using Fusion|
|24388|Report Design|UI|Add support for enter button when saving reports in new Instant Report designer.|
|24415|Report Design|Exports|Incomplete Data for Heatmap Visualization display when exported to PDF, HTML, Excel.|
|24416|Report Design|Pivots|Corrected a problem where under some combinations of pivot, visual group, and subtotal the pivot columns per exported page setting would cause an incorrect export.|
|24417|Report Design|Gauge|Popup Effect on Gauge is not working when user clicks the Gauge, the other effects like Link and Hover are working properly.|
|24421|Report Design|Charts|Corrected an issue where long string values with no column label would overflow the popup when hovering over the bar of a bar chart.|
|24429|Report Design|Instant Reports|In the New Instant Report designer we use other default values for the following properties: Label Justification Value Justification Drill-Down Style Which is causing the Advanced field properties to appear used in the legacy report designer when no setting are set.|
|24438|Report Design|Forms|Setting default format ("...") for numeric fields causes these fields to disappear from forms.|
|24461|Report Design|Exports|Corrected a problem where a crash would sometimes occur when using a pivot in the Instant Report designer and exporting with bulkCSV.|
|24465|Report Design|Instant Reports|Error message when saving report in New Instant Report page showing "Dashboard name cannot be empty" instead of "Report name cannot be empty".|
|24467|Report Design|Instant Reports|In New Instant Report Page when adding a subreport to a field that contains an apostrophe, symbols are showing instead of the apostrophe.|
|24470|Report Design|Filters|Correct default width of Autocomplete filter box when empty.|
|24477|API|Subreporting|Combokey qubreport style is added to the DrillDownStyle collection after list is built and cannot be removed from collection using AdHocSettings.DrillDownStyle setting.|
|24498|Report Design|Subreporting|Corrected a problem where field grouping would not be correctly carried over to an automatically generated subreport, meaning that the internal filtering behavior would not filter as expected.|
|24516|API|Optimization|Fixed a problem where when AdHocSettings.ShowHtmlAsCode is set to true, some special characters in stored data would cause reports to fail to render.|
|24519|Report Design|Visualization|Corrected an issue with visualizations where the grid used to power a visualization would be filtered incorrectly when the visualization drills down if one or more individual fields are hidden.|
|24521|Report Design|Filters|Corrected an issue where adding an empty popup filter in the report viewer would filter out all results rather than acting as a blank filter with no supplied value.|
|24522|API|Optimization|Corrected a problem where if the VisibleDataSources setting is not populated, Izenda automatically pulls metadata for all stored procedures. The expected behavior should be that none of the stored procedures are loaded in this condition.|
|24523|Report Design|UI|When using setting AdHocSettings.ApplyAntiXssToReportOutput, error received when using custom URL in Advanced field settings.|
|24527|Report Design|Exports|"Show Date and Time" from Style tab now appear in Excel export when report is exported by the Scheduler|
|24544|API|Optimization|Added setting AdHocSettings.ExportEncoding to control the character encoding of an export, preventing extra characters from appearing in the export under some conditions.|
|24549|Report Design|Exports|Corrected a problem where animated visualizations in a report that has been exported without being saved would not export with a link to view the visualization.|
|24550|Report Design|Gauge|Corrected a problem where sometimes the linear gauge style would switch from vertical to horizontal after report save or export.|
|24560|API|Optimization|Restriction created to disallow adding the same datasource to different datasource categories.|
|24563|Report Design|Filters|Corrected a problem when using equals(Multiple) filter operator, if one value is selected then it is not possible to scroll down to select other filter options.|
|24584|Dashboards|Optimization|Fixed a problem where dashboards which have not been saved would not track tile locations correctly if the dashboard is refreshed without being saved.|
|24598|Report Design|Optimization|Made further enhancements to support custom popups due to recent popup behavior changes.|
|24623|Report Design|Subreporting|Corrected a problem where when AdHocSettings.ApplyAntiXssToReportOutput is enabled, undesired report parts would be passed down and rendered on a subreport.|
|24638|Report Design|Maps|Corrected a problem where the World map would appear sometimes when the Europe map is selected and the zoom to data feature is enabled.|
|24666|Report Design|Filters|Corrected a problem where using the Between filter could cause the report to become invalid.|
|24696|Report Design|Filters|Corrected a problem where saving more than one multiple choice filter with multiple selected values reset those filters to the default no values on report save.|




# 6.10.0.6 (May 18, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|HF24332|API|Optimization|Error received when attempting to save Settings page to Izenda.config file.|
|HF24469|Report Design|Pivots|Pivot reports designed in new Instant Reports page cannot be opened in the Instant Report page. Multiple Angular errors received.|
|HF24472|Instant Reports|Optimization|Popup subreports are not working in the new Instant Report Page. Uncaught reference error received.|
|HF24474|Dashboards|Optimization|Refreshing Dashboard page 2 times causes the dashboard to become empty with one blank tile.|
|HF24491|Report Viewer|Filters|Between date filter not working in the Report Viewer. Not properly adding the filter to the query.|
|HF24502|API|Saving|Using Windows 8 and Internet Explorer 9-11 not allowing reports to be saved from the Report Designer.|
|HF24509|Report Design|Visualization|Users are not being directed to the Settings page in newly downloaded Izenda Reference Implementations, getting a Null Reference Error instead.|
|21844|Report Design|Visualization|Feature: Viz - Addition of the ability to move the subreport popup for Visualizations around the screen.|
|22476|API|Optimization|Asp.net can't pass requests which parameters contain html markup by default, because possible dangerous code could be sent to server. So if column contains value with html markup (for example "test <b>!!!</b>"), drill down link throws exception. Solution is to url-encode drill-down key parameter when placing it into the URL and then decode it on the receiving side.|
|22677|Instant Reports|Filters|New Refresh added to all filters in New Instant Report page anytime filter logic is applied.|
|22894|Report Viewer|Export|Repeating headers do not work under the Visual Groups when exported to PDF.|
|22895|API|Optimization|Inconsistent Invalid License Key error shown in various Izenda pages.|
|23067|Report Design|Optimization|Add a setting to control Automatic Subreport availability.|
|23272|Report Design|Visualization|Flowchart Visualization displaying error 'n.getTransformToElement is not a function'.|
|23315|Report Design|Visualization|Altered functionality of Time bubble. If value of current item equals zero, then its circle will have zero radius and therefore become invisible.|
|23391|API|Optimization|Refactor Internal method CacheStoredProcedureMetaDataToDisk|
|23543|Report Design|Export|Issue with multiple CSS classes in Excel.|
|23652|Report Design|Visualization|Combinations of Visualizations or individual visualizations with grids embedded in FORMS do not export to PDF successfully.|
|23682|Instant Reports|UI|Change to New IR page, changing button on Field Properties for Advanced Field Properties to Arrow to Expand properties.|
|23719|Report Design|Visualization|When building a visualization on a summary report part and summary extends across multiple pages, error received when changing page.|
|23745|Instant Reports|Optimization|Refactoring loading datasources to new Instant Report page to increase loading speed with larger volumes of datasources|
|23758|API|Optimization|"Object reference not set to an instance of an object." Report designer attempts to find the cached reportset but cannot due to the caching being turned off. AdHocSettings.CacheReports = false|
|23766|Report Design|Optimization|Adding multi tenant scheduling functionality to standard Izenda scheduler.|
|23792|Report Design|Export|Export a report as a landscape PDF - the bar chart doesn't stretch to take up the full width of the paper which is causing the labels to stack and be hard to read|
|23818|Report Design|Charts|Issue with funnel chart labels where certain labels are drawn on the chart instead of to the side of it.|
|23837|API|Optimization|The Required Filter Message is using the DATABASE Parameter names instead of the Alias|
|23853|Dashboards|Visualization|Heatmap Visualization not appearing in dashboards when using Mozilla Firefox|
|23855|API|Filters|Auto-update is not working with the calendar control. You must click update results when a filter needed to be filled out before execution of export to Excel.|
|23859|API|Saving|A unique report ID is not generated for the new report with and without save override and a new unique ID is not generated for reports created from using Save As on the report viewer.|
|23873|API|Optimization|Color picker auto-completes color codes after you've typed in about three characters. This forces the user to type the code elsewhere, then copy and paste.|
|23879|API|Filters|Error in the in time period filter "Last 30 Days" does not include today.|
|23892|API|Optimization|Javascript error when attempting to add a column to a report after execution via report viewer.|
|23909|API|Optimization|Izenda.AdHoc.AdHocSettings.SchedulerOutputTypes.Remove("Link"); Izenda.AdHoc.AdHocSettings.SchedulerOutputTypes.Remove("DOC"); Link and Doc types are visible in SendEmailAs dropdown.|
|23919|API|UI|Bold and italic generate b and i tags, but alignment doesn't have a text tag so it won't generate div.|
|23920|Instant Reports|Optimization|IR1.0 - Can't change the format of a field in Instant Reports.|
|23921|API|Optimization|Combokeys breaking embedded drilldowns in FORMS.|
|23924|Dashboards|Optimization|To address the issue of exporting a dashboard and the description field not rendering in the export.|
|23953|Report Design|Filters|Using Oracle database the following error returned when using the Equals Field filter operator "ORA-01036: illegal variable name/number"|
|23959|Dashboards|Optimization|When using a report part in the dashboard that returns no results, nothing is displayed. Changed behavior to show "No Results".|
|23984|Dashboards|Visualization|Error when dashboard is created by global tenant and viewed by tenant. The Visualizations do not display in dashboard for specific tenant id.|
|24008|Report Design|Optimization|FEATURE: Autocomplete filter operator changed to display values inside of a pill. This eliminates the current issue of seeing values containing commas as #||#.|
|24031|Report Design|Optimization|Visualization built from summary report part gets error when changing pages if summary extends to multiple pages.|
|24035|Report Design|Optimization|Page Break added from menu option when using Form Report not working.|
|24051|API|Optimization|"print" button stops working after first print attempt when using izpid=<unique id>|
|24052|Report Design|Optimization|Report loses its visual group settings when using regular CSV mode (not BulkCSV).|
|24083|Report Design|Filters|Less/Greater than Days Old filter giving errors in Oracle environments.|
|24090|Report Design|Optimization|When adding a new field to a report in the report viewer and using update results an exception is thrown. "The SQLParameterCollection only accepts non-null SqlParameter type objects. Parameter name:value"|
|24099|API|Optimization|Error when filtering from stored procedure which returns aggregated field in MySQL.|
|24109|Report Viewer|UI|Rendering conflict caused visual groups which were collapsed by default (AdHocSettings.ExpandVisualGroupGrids set to false) to rquire two clicks to expand.|
|24124|API|Filters|When using PostgreSQL along with AdHocSettings.TimeZoneOffset the field function "Group(Week)" displays an error.|
|24128|Report Design|UI|FEATURE: Added support for Autochart to change line and area charts to stepped line or area. Use gear icon in Autochart after selecting line or area chart to change to stepped.|
|24136|Report Design|Pivots|Error creating pivot in New Instant Report Designer when user tries to add a pivot cell when column is not selected.|
|24146|API|Optimization|Added support for joining across different collations. Temp table is used to make collations match.|
|24156|API|Optimization|Error received "Group by expression must contain at least one column that is not an outer reference", received when Group function is used for the cell value field in a pivot.|
|24184|API|Filters|Error received when using values containing decimals in filters. Conversion error received "Specified cast is not valid."|
|24203|API|Saving|Error in ExtendedFormatCollection when serialization is required for storage.|
|24211|API|Optimization|Some formats not shown in new Instant Report page after save.|
|24212|Instant Reports|Optimization|Unable to open Report created in New Instant Report page after report is scheduled in scheduler. (Triggering report was edited in Report Designer, any report created in New IR designer cannot be edited in the New IR page after being edited in the Report Designer.)|
|24223|Instant Reports|Filters|When using European Culture with Equals(Calendar) filter, the month and day values are swapped after clicking "Update Results" if the day is less than 13. (Ex. 12/01/2016, January 12 is changed to 01/12/2016, December 1)|
|24234|API|Filters|Exports broken in 6.10.0.6 branch: js error occurred when user tried to export report to excel.|
|24347|Report Design|Export|Scheduler output PDF ignoring PdfPrintMode setting and reverting to default PDF exporter.|
|24351|Report Design|Optimization|When exporting report with visual group style field value and multi level in HTML, it shows characters like( '>' height='10px'>'>' height='10px'>)|
|24352|API|Saving|Message displayed "Visualization do not support rendering to image" when exporting charts to PDF.|
|24356|API|Optimization|Require login allowing access to some pages. No data displayed but redirect should force user to login page. Issue is with initialization process.|
|24359|Dashboards|Optimization|Popup on Gauges is not working on Report Viewer and Dashboard.|
|24373|Report Design|Visualization|Incorrect links displaying on Autochart when fields are used as drilldown.|
|24399|Instant Reports|Optimization|New Instant Report page, restore default colors is not working. No defaults return.|
|24401|Report Design|Gauge|Popup from AutoGage displaying "Report Not Found" when clicked.|
|24422|Report Design|Visualization|Regression issue with new Popup Modal from Drill down report. Popup not moveable and not displaying in IE.|
|24432|Report Design|Optimization|Drill down report showing characters instead of Drill Down value in popup header bar.|
|24436|API|Pivots|Null Reference Error received when creating a Pivot report and using Subtotals.|
|24442|Report Design|Visualization|Visualization hover text not working in Chrome or Firefox.|
|24447|API|Optimization|"Syntax error, unrecognized expression: li[val=]" received when adding AutoChart to Dashboard.|
|24459|API|Optimization|"Fixed: When using grid report with popup subreport the popup displays the rs.aspx page instead of data when the setting below is used in the Global AdHocSettings.ApplyAntiXssToReportOutput = true"|
|24461|Instant Reports|Optimization|"Fixed: Server Error shows when exporting a report with Pivot on CSV on Instant Report"|


# 6.10.0.5 (April 21, 2016)

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|22499|Instant Reports|Export|IR2.0 - When you export IR2.0 report to PDF, add a description, and export again "The report you've designed is invalid." error occurs.|
|22640|Instant Reports|Optimization|IR2.0 - Printing functions are implemented in New IR page using popup window. This is being blocked in some browsers.|
|22696|Report Design|Optimization|Fixed situations where field 'Advanced Settings' button could have the 'green check' mark indicating custom settings, when none were set.|
|22779|API|Optimization|Various IE8 .js compatibility issues.|
|22883|Dashboards|Filters|Filter values being lost when saving/switching dashboards.|
|23204|Instant Reports|UI|Fixed legacy report issue where "Each GROUP BY expression must contain at least one column that is not an outer reference." error occurred when loaded after upgrade.|
|23343|Report Viewer|Export|Animated (transitions/world tour/etc) visualizations cannot be printed to PDF so the user should get a link within the export. Regular visualizations will print to PDF.|
|23345|Instant Reports|Visualization|In IR2.0 'World Tour' & 'Projected Map' charts showed errors when exported to HTML.|
|23393|API|Logging|Improved logging of html->image process implemented.|
|23418|Report Design|Optimization|Fixed functionality of operator "Use Previous Or" described here http://wiki.izenda.us/FAQ/Questions/How-is-Use-Previous-OR-used-in-Filters|
|23424|API|Optimization|Fixed application crash in case of null key in http request parameters.|
|23447|Instant Reports|Caching|IR2.0 - When the following two settings are applied to enable caching, the new Instant Report designer will display an error upon initially saving a report, and will only allow reports to be opened with the legacy report designer. AdHocSettings.CacheReports = true; AdHocSettings.DataCacheInterval = 60 * 24 * 30;|
|23449|Instant Reports|UI|Feature: IR2.0 - Help text for Width in Field Formatting section.|
|23465|Dashboards|Export|Specific sequence of actions where the tile title and description is not used for tile printing of dashboards.|
|23470|Report Design|Pivots|When using new server side sort on pivot charts in Report Viewer error received "All Field descriptions must be unique. Make sure the same description is not used twice."|
|23497|API|Optimization|Even though correct culture is applied in the actual render format caption is incorrect. The reason is that AdHocSettings.Formats collection is stored on the application level.|
|23500|Dashboards|Export|When emailing dashboards from Izenda, 'Send as Link' fails in both cases. For non-saved dashboard it throws error in browser console as customer described. For existing/saved dashboards it doesn't throw error, but also does nothing at all - no email arrives to mailbox.|
|23514|API|Optimization|# not currently supported in report titles by default, fails when forced (AllowInvalidCharacters and StripInvalidCharacters).|
|23515|Dashboards|Optimization|Graphs, Titles missing, Report Parts out of order in scheduled Dashboard email.|
|23516|Dashboards|UI|The size of the dashboard tiles' text and graphics are not being resized correctly when viewed from an iframe or screen that is too narrow.|
|23571|Dashboards|Saving|- Put AdHocContext.DisableLogging = true; to initialization. - Create any situation when izenda internally throws and catches exception which is recorded in logs as error (for example try to load/execute report against missing datasource). Site will crash in browser.|
|23582|API|Optimization|Strings will now be identified using single quotes to differentiate all-number strings more easily from numeric values in highlighting and value ranges. Examples: 1) ALFKI:red; ANTON:green; ANATR:blue; 2) 1:red; 2:green; 3:blue; 3) "ALFKI":red; "ANTON":green; "ANATR":blue; 4) "1":red; "2":green; "3":blue; Current version: 1 - (string)ALFKI, (string)ANTON, (string)ANATR 2 - (number)1, (number)2, (number)3 3 - (string)"ALFKI", (string)"ANTON", (string)"ANATR" 4 - (string)"1", (string)"2", (string)"3" After the fix: 1 - (string)ALFKI, (string)ANTON, (string)ANATR 2 - (number)1, (number)2, (number)3 3 - (string)ALFKI, (string)ANTON, (string)ANATR 4 - (string)1, (string)2, (string)3|
|23585|Instant Reports|Optimization|Implement the reports from IR opening in simple mode in report designer.|
|23586|Report Design|Charts|Refactor: Code for chart label spacing. Added label angling instead of label offsets in Autocharts.|
|23592|API|Caching|Bug discovered when StoreImagesToCache is set to false which breaks exports.|
|23598|Dashboards|Visualization|Create AdHocSetting to show sizing element in dashboards for visualization. This sizing is temporary and will not save with the dashboards. Any permanent setting changes to sizing must be made in each report.|
|23653|Report Design|Export|Export to excel and word works fine but if the zoom the chart to 200%, the export fails to download the complete image|
|23655|Report Viewer|Pagination|Implemented possibility to adjust pagination controls. Video: Sample code which resulted in behavior shown on video: <style type="text/css"> .horrPaginationTable { position:absolute; top:-150px; left:100px; } </style> (should be put to ReportViewer page)|
|23659|API|Optimization|Resolved issue where the report that was opened last in a new tab/window will be exported (in IE), no mattter which report is currently being viewed.|
|23666|API|Optimization|Fixed issue when there is multiple values set on the filter (BetweenTwoDates), the filter values are written as xml elements right before the SqlOverrride xml attribute is written. This causes the XmlWriter method to fail because the state of the XmlWriter changes to content when the "Values" elements are added. When the state of the XmlWriter is content, attributes can no longer be added.|
|23675|Instant Reports|Optimization|IR2.0 - Error message: Cannot read property 'ci' of undefined|
|23676|Report Design|Filters|Special Characters in Filter create no results when selected from equals select type filters.|
|23688|Instant Reports|Optimization|IR2.0 - Shows "Object Reference not set to an instance of an object." when you remove the numbers on items per page in format tab|
|23695|Report Design|Filters|Two issues where only parameters are visible but no columns. This happens only with Date parameters.|
|23696|Report Design|Filters|InTimePeriod filters do not save to reports when added through the new IR2.0 Report Builder.|
|23722|API|Optimization|Crashes with "column not found" error when adding constraint, if you: 1) Didn't close browser. 2) Changed constraints configuration in Global. 3) Restarted website and reopened it in existing browser window. Also: MySQL Stored Procedures not getting listed in the Settings Page|
|23723|Report Design|UI|Fixes to legacy settings to support new UI 'ALL' option in browser row dropdown menus. In case of ReportDesigner, IR2.0 - to use ShowAllInPreview and in case of ReportViewer and Dash2.0 - to use ShowAllInResults|
|23727|API|Optimization|When AdHocSettings.ShowStackTrace=false; stacktrace link was disabled, but hyperlink text remains.|
|23734|API|Optimization|Method "ReportSet.GenerateOutput" is used in the ReportRenderer class in the following methods: ExportReportSet(string reportName, string output) ExportReportSet(string reportName, string output, string filters) also the ReportRenderer class has other two methods: RenderReportSet(string reportName) RenderReportSetWithFilters(string reportName, string filters) These have been obsolesced and removed from the Izenda API. For the best practice method to accomplish the same behavior: http://wiki.izenda.us/FAQ/accessing-izendas-export-process|
|23741|API|Optimization|'Click Link for Details' hyperlink in Izenda error screen the hyperlink doesn't show the standard "hand" cursor when hovering over the link.|
|23743|Report Design|Optimization|If you change drilldown style from anything to combokey, a visualization can break When you change it back to non-combokey setting, it breaks even further - notice the split metric dropdown.|
|23770|Report Viewer|UI|We have a report that has a date filter using "In Time Period". When users open this report and change the filter to Between (Calendar), the results come back correctly, but the filter label is wrong.|
|23782|Report Viewer|UI|Some thumbnails related code still executes despite GenerateThumbnails=false; being set.|
|23801|Report Design|Gauge|Current reports show "Object reference not set to an instance of an object. Stacktrace: at Izenda.AdHoc.Report.LoadAndFormatData(ReportOutputOptions options)" error in 6.10.0.4.|
|23814|Instant Reports|UI|IR2.0 - In New Instant Report page adding Visual Grouping disables the header fields from being clickable to access the field settings.|
|23816|API|Optimization|Functionality added to allow a developer to redirect logging data output from log4net to virtual AdHocConfig method so they can implement writing this log data to any storage suitable with custom code.|
|23823|Dashboards|Optimization|AdHocSettings.CacheReports = true; AdHocSettings.DataCacheInterval = 60 * 24 * 30; With those settings in place, dashboard presentation mode breaks|
|23850|Instant Reports|Optimization|Feature: Preparing IR2.0 page for localization.|
|23865|API|Optimization|AdHocSettings.RedirectExports added back to AdHocSettings.|
|23882|API|Export|With csv exports the same data is getting repeated row after row for exported csv files. So, if there is a report that has 50 unique rows, CSV export will repeat the first row 50 times.|
|23899|API|Optimization|Now universal standard set of TimeZones is used everywhere including Daylight Savings Time support. This change should be compatible with the previous versions since offset-based timezones are automatically converted to the new timezones.|
|23910|Report Design|Gauge|Javascript error in Gauge/Map hover effect.|
|24026|Instant Reports|Filters|In New IR page autocomplete filter operator not searching for values after first entry.|
|24030|Dashboards|Filters|Fixed 'Object reference not set' error in webserver|
|24039|Report Design|Visualization|Visualization improperly interacting with certain pivots.|
|24048|API|Optimization|Categories being created in wrong location when using \<category name>.|
|24057|API|Filters|Fixed issue where date filters not always work correctly in Dashboards when AdHocSettings.Culture is not default.|
|24058|Report Design|Filters|Field based filters (equals field) not working in reports.|
|24059|Dashboards|Optimization|Use previous or is disabled in dashboard as it cannot be used as a common filter. Each tile can have different logic in the report, so this logic will not be common among all dashboard tiles.|
|24155|Dashboards|Visualization|Autocharts not working in Dashboard when a report with sub report are loaded|
|24170|Report Viewer|Optimization|Fixed Reference Error when adding field to report in viewer|
|24174|Report Viewer|Fields|Added Field in Report from Report Viewer Showing as Count or Sum by default. Resolved|


# 6.10.0.4 (March 22, 2016)

## **Hotfix (March 24, 2016)**
|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|**HF:23784**|VisualGroups|Bug| Fixed: First field in a report, with VG enabled, can disappear when subtotals added and report is previewed.|
|**HF:23491**|Joins|Bug| Fixed: Issue where if you to add multiple joins to the same table you must save the report in between adding each field in order for additional table joins to appear.|

## Features

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|8453|API|Feature| Izenda Reports - Added labels (EX: SUM, COUNT) that appear on the hover-over of a subtotal.|
|11189|API|Feature| Addition of commentary to Izenda serialization.|
|21937|Dashboards|Feature| Dash2.0 - Adding support for Fusion Report Cache timestamp to appear on report tiles in new Dashboard.|
|22505|Instant Reports|Feature| Dash2.0 - Ability added to easily set default category in Dash2.0 in code. Settings in file: "Resources/components/dashboards/module-definition.js" // dashboard config object: angular.module('izendaDashboard').constant('izendaDashboardConfig', { showDashboardToolbar: true, defaultDashboardCategory: 'Filters', defaultDashboardName: 'dashboard Autocomplete Filter' });|
|22537|API|Feature| Refactored Datatable class to increase performance on larger data sets. Implemented setting AdHocSettings.ClearManagedMemoryOnRender, this false by default. When set to true .NET Garbage Collector is explicitly called. To take full advantage of these changes in the Datatable class custom formats can be updated to use the following: **1) Replace IFormatter with BaseFormatter** **2) Replace all DataTable occurrences with AdHocDataTable** **3) Add override key words to the methods:** `"public Type GetOutputDataType" -> "public override Type GetOutputDataType" - "public object Format" -> "public override object Format"` http://wiki.izenda.us/Release-Notes/Code-for-22537-ReleaseNote _**All previous implementations of IFormat will still work, but will not take advantage of the optimizations in the new Datatable implementation**_. |
|22749|Report Design|Feature| Cell Highlight - 'High' 'Medium' and 'Low' strings can no longer be used to address the upper, middle, and lower thirds of a range in highlighting or value range aliasing. You can use "x% to y%" range syntax to establish custom proportional ranges instead. High, Medium and Low will now function properly as strings.|
|23025|Instant Reports|Logging|Feature: IR2.0 (BETA) - Support for Filter Regex added to IR2.0.|
|23039|Scheduler|Logging|Feature: Scheduling - Added ability of configure local SMTP port. Add this method to customadhocconfig: public static System.Net.IPEndPoint BindIPEndPoint(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount) { return new System.Net.IPEndPoint(System.Net.IPAddress.Parse("192.168.0.61"), 6666); } Add this setting to InitializeReporting: AdHocSettings.SmtpClientBindIPEndPointDelegate = BindIPEndPoint;|
|23435|Instant Reports|Feature| IR2.0 (BETA) - added support for setting AdHocSettings.ShowChartTab which can hide the chart menu tab.|
|23438|Instant Reports|Feature| IR2.0 (BETA) - Adding support for hide grid feature in New Instant Report Designer. User can now create a Visualization from a grid and hide the grid from view in the report.|
|23642|Instant Reports|Feature| Enabling a feature on new Instant Report page to "Show Filters In Report Description". This option allows the filters to show on the screen and in the printed report.|


## Fixes

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|21656|API|Optimization|Fixed: When using an ODATA connection, the results drop down was not properly working to increase or decrease number of results.|
|22443|Instant Reports|Optimization|Fixed: In IR2.0, when checked all field headers now become bold.|
|22500|Instant Reports|UI|Fixed: IR2.0 AutoGauge missing size-adjustment slider.|
|22607|Instant Reports|Optimization|Feature: IR2.0 (BETA)- 'Expose as Datasource' functionality added to IR2.0. Requires 'AllowVirtualDatasources=true' to be set.|
|22611|Instant Reports|UI|Feature: IR2.0 (BETA) - Add 'Hide Grid' UI to make tables invisible for Visualization-only report styling.|
|22615|Instant Reports|Optimization|Fixed: BETA New IR page is not paginating reports properly. The first page appears to limit records properly, but the pagination controls do not appear at the bottom of the screen.|
|22678|Instant Reports|Visualization|Feature: IR2.0 (BETA) - Help links for visualizations added.|
|22738|Report Design|Filters|Fixed: Code conflict that could cause null reference exception using a 'GreaterThan: 1' filter.|
|22855|Report Design|Visualization|Fixed: Grouping in Calendar Visualisation shifting values improperly.|
|22886|Dashboards|Optimization|Fixed: Issue where certain customizations or report configurations could cause multiple copies of same dashboard pane to erroneously appear upon refresh of a dashboard.|
|22976|Report Design|Filters|Fixed: When using a Group(week) or Group(year & quarter) function and "Add Subtotals" is selected, some reports will throw an "ORA-01722: invalid number" error in Oracle. On SQL Server, Izenda will display the error "Conversion failed when converting date and/or time from character string".|
|22992|API|License Key|Fixed: Stack Overflow Exception experienced when reading value 'LicenseKey' from web/config in certain configurations using web.config instead of global API to set license.|
|22996|API|Optimization|Fixed: Issue with unexpected date behavior using Timezone offset setting and creating a pivot based on date.|
|23007|API|Optimization|Fixed: Situation when manual schema cache refresh is required when adding a new stored procedure. Schema refresh will not be needed to add a new stored procedure to VisibleDatasources.|
|23035|Report Design|UI|Fixed: Browser-specific issues with popup drill-down UI rendering.|
|23056|Report Design|Visualization|Fixed: Calendar Visualization and Auto-Gauge Visualization being cut off in PDF exports.|
|23059|Report Design|Visualization|Fixed: Issue with values containing a ',' using tree-filter operator corrected.|
|23066|Dashboards|Filters|Fixed: Dash2.0 - Issue where the filters for dashboard tiles did not apply to the first tile of a report. This occurred when that first tile was a visualization and 'attached to', or built off of, the report summary.|
|23068|Report Design|Visualization|Fixed: Description text not used for chart labelling|
|23079|Report Design|Export|Fixed: After export, default preview results value ignored upon report update.|
|23090|API|Optimization|Fixed: NULL label added to replace erroneous 'column position label' assigned to counted NULL columns.|
|23102|API|Optimization|Fixed: When a colon is in the description box and a column group is being applied either through advanced field settings or the field@group method, colon also produces a column header.|
|23115|API|Optimization|Fixed: The error - "The ORDER BY clause is invalid in views, inline functions, derived tables, subqueries, and common table expressions, unless TOP, OFFSET or FOR XML is also specified." - displayed when doing certain PERS operations with expressions.|
|23124|API|UI|Fixed: Using a view name containing apostrophes was disallowed by the UI.|
|23150|Dashboards|Export|Fixed: Issue with dashboards exported to Excel where formatting was lost.|
|23158|API|Optimization|Fixed: Issue opening Settings.aspx via a mobile browser.|
|23176|Instant Reports|Data Sources|Fixed: Implemneted LazyLoad behavior for IR1.0/2.0. Stored Procedures will not be called/cached until expanded in IR with LazyLoading enabled. **NOTE: StoredProcedure columns will not be available for 'search' in IR until expanded and column values cached.**|
|23194|Scheduler|Optimization|Fixed: Applying timezone to UTC caused error - 'The added or subtracted value results in an un-representable DateTime.' - using Izenda setting 'ScheduleTimeZone'.|
|23208|API|Optimization|Fixed: On-page UI sort of data by clicking column header using alphanumeric order for dates instead of date order.|
|23224|API|Optimization|Fixed: Legacy JS refactored to allow '&' symbol in the name value of a drilldown.|
|23227|Report Design|Forms|Fixed: Deploying Izenda using UNC pathing, issues with FORMS product corrected.|
|23230|Dashboards|UI|Fixed: "Missing color hue rotate" error resolved in dash 2.0 background hue UI.|
|23231|Dashboards|Filters|Fixed: Dash2.0 - New Dashboard slider fixed so that it can be drug one or many segments.|
|23234|Instant Reports|Filters|Fixed: "ORA-01036: illegal variable name/number" error when using IR2.0 and Equals(Calendar) and preview results 100.|
|23235|Instant Reports|Filters|Fixed: IR2.0 displayed 'Invalid Value' error switching between date-entry filter and calendar date filter operators.|
|23236|Instant Reports|Filters|Fixed: 'Object reference' error displayed when switching from 'Between(Calendar)' to 'Equals Calendar' in IR2.0.|
|23240|API|Optimization|Fixed: Subcategory creation during report saving using 'Category/Reportname' behaves the same in both Viewer and designer.|
|23249|API|Caching|Fixed: Conflict in logic that sometimes results in empty name of the file for schema cache, causing cache to be lost, causing frequent long loading times.|
|23260|API|Optimization|Fixed: Issues with pivots and session state handlers in webfarms resolved.|
|23282|API|Optimization|Fixed: Changed handling of report SQL generation to better support legacy reports from Izenda 6.7 versions being correctly generated in the latest versions of Izenda with no changes.|
|23316|Report Design|Export|Fixed: Issue exporting to Excel in the following situation- Field is a Date(Time) type; VG; Export to Excel|
|23317|Report Design|Visualization|Fixed: Autochart legend now mirrors field order.|
|23331|Report Design|Filters|Fixed: Issue in the ReportDesigner where datepicker does not open automatically.|
|23334|Report Viewer|Export|Fixed: Serialized several objects overlooked in the v6.10.x release. Also corrected bug with limited rows being exported for XLS output|
|23340|API|Optimization|Fixed: Session data storage provider is not available error when HttpContext.Current.Session is null.|
|23352|Instant Reports|Data Sources|Fixed: When initially selecting a datasource in Instant Reports, the checkbox remains blank and users are unable to create joins off of the tables. The checkbox will now contain a check and users will be able to create joins.|
|23354|Report Viewer|Export|Fixed: Distorted thumbnails sometimes generated by EVO engine.|
|23359|API|UI|Fixed: Issue with HiddenCategories and 'CurrentUserName' values in session which can clear or duplicate categories for other users.|
|23378|API|Optimization|Fixed: Error found in logs that had no effect in UI but did unnecessarily bloat logs.|
|23433|API|Optimization|Fixed: Issue with serialization of malformed blank reportSet object when preparing response to getReportDashboardConfig request.|
|23457|API|Optimization|Fixed: Regression issue where initialization logic was broken for MVC4 kit specifically.|
|23458|API|Data Sources|Fixed: Issue with missing pagination controls on reports generated from Stored Procedures.|
|23467|API|Optimization|Fixed: System.ArgumentException: Issue where you get 'URI formats are not supported' error when usingAdHocSettings.ImagesPath. Exception is thrown by .net method System.IO.Path.GetFullPath which was added to ImagesPath setting getter in the commit for mentioned above case.|
|23487|API|Optimization|Fixed: Starter-kit code for vanilla Izenda installs modified so that it will pick 1.12 jquery for <=ie8, and 2.1 for all other cases.|
|23508|API|Logging|**NOTE: Starting in the next version (v6.10.0.5+) ReportSet.GenerateOutput will be obsolesced. The new best practice is to use the ReportOutputGenerator classes directly.**|
|23539|Report Viewer|Save|Fixed: Issue where saved formats in a report would be wiped out by making any format changes in the viewer advanced area.|
|23576|Report Design|Data Sources|Fixed: Database object with " ' " in name causing error in reading visible data sources.|
|23584|Instant Reports|Data Sources|Fixed: IR2.0 BETA - Instant Reports page the data source columns sorting based on the field name in the database instead of the alias name assigned.|
|23588|API|Optimization|Fixed: Issue if the logger call is incorrectly designed then unhandled exception may occur.|
|23595|Report Design|Filters|Fixed: Issue with single empty string value used in filters similar to Equals(Select) in functionality. Example: Empty auto-complete filter generates SQL - WHERE ([dbo].[Orders].[ShipCountry] = N'')|
|23627|Report Design|Pivot|Fixed: When adding a pivot the row headers are clickable to view the field panel, column headers are not, but after adding a second pivoted column the row headers cannot be clicked to view the field panel.|
|23629|Instant Reports|UI|Fixed: IR2.0 (BETA) - Issue with menu option for print, the dropdown itself does not show, can't print a report on PDF and HTML.|
|23631|Instant Reports|Export|**NOTE: New settings in default global.asax. - Set New IR as Instant Report Page - Set AdHocSettings.ShowJoinDropDown = true - Set default PDF print mode to EVO**|
|23649|Report Design|Save|Fixed: Erroneous _global_ tenantID saved instead of user tenantID.|
|23680|API|Data Sources|Fixed: Issue with DB Schema cache causing existing database relationships to not work with any FUSION connection.|
|23691|Instant Reports|Filters|Fixed: Dash2.0/IR2.0 (BETA) - Issue where report becomes invalid when user tries to filter values created from IR designer.|
|23724|API|Optimization|Fixed: Discrepancy between very old code and recently added improvements to cultures handling. This conflict caused issues with cultures that change date format and Stored procedure code.|
|23732|Instant Reports|Filters|Fixed: IR2.0 (BETA) - 'Equals' style operators erroneously showed 'No Results' when 'blank' selected.
|23759|Report Design|UI|Fixed: Issue with Equals(Calendar) UI where 'Next' and 'Previous' month buttons were not visible.|

# 6.10.0.3 (February 23, 2016)

## Features

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|**HF:23222**|Report Design|Data Sources|**Hot Fix (03/02/2016)** Fixed: Bug limiting maximum number of joins to ~10 corrected. When adding data sources in Report Designer Advanced mode, additional copies of the same table were not being aliased to allow for self joining|
|19644|API|Optimization|Added intelligent schema labelling in ReportDesigner 'DataSources' tab, which applies schema names when two DataSources have the same name from two different schemas.|
|20555|Report Viewer|Optimization|Added Support of Server Side sorting in the Report Viewer. Setting which controls the behavior is AdHocSettings.SortGridOnServerInViewer. The default value is set to false so the behavior will remain the same for all existing customers. This change only works in the Report Viewer, on other pages default client-side filtering should be utilized by changing the sort on the field in the designer. - All active field settings are shown and user can change the sort on multiple columns. With pure client-side sorting there is no way to apply sorting hierarchy while in this case we can do this so user can cycle asc/desc/none sorting on any column keeping previously saved sort. For instance, you could sort by Country and by City using this new feature while with the old sorting you can sort either by Country or by City. Applied sorting is respected in exports. In case of a pagination current page is preserved.|
|22561|API|Optimization|Added setting for number of recently updated reports to allow client to set a value for how many should be displayed.  The default value for the new setting, AdHocSettings.RecentlyUpdatedCountAtReportList is 10 but any other interger may be used.|
|22608|Instant Reports|Optimization|Added support for BETA Instant Report page for user to drag new field into the work area between two existing fields on a report. User can drag existing fields around in the report work area to change position as well.|
|22703|Instant Reports|Optimization|Adding support for creating pivots in the BETA New Instant Report page. [Documentation](http://wiki.izenda.us/Guides/Instant-Reports-v2-BETA#Adding-a-Pivot---Added-6.10.0.3-Release)|
|22704|Instant Reports|UI|New BETA Instant Report - Rearranged the Field formatting options on the field panel. [Documentation](http://wiki.izenda.us/Guides/Instant-Reports-v2-BETA#Field-Settings---Updated-6.10.0.3-Release)|
|22708|Instant Reports|Optimization|Enabled full support of FUSION with DataSourceCategories API for InstantReports 1.0/2.0. FUSION connections and DataSourceCategories now both create hierarchies in IR 1.0/2.0.|
|23251|Report Design|Expressions|Changed default of value of AdHocSettings.ShowModifiedReportMessage to false from true. This feature has been noted to cause issues for some client and the default has been changed until a final resolution can be made to enhance the feature.|

## Fixes

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|18570|UI|Visualization|Fixed an issue where  the Drilldown on Visualization "AutoChart" were not properly drilling down on Ipad and similar smaller mobile and tablet devices.|
|18933|Report Design|Optimization|Fix of regression bug where if you create a report with a concatenated field, remove & re-add that field from the viewer, it loses its original concatenated value. Also of note, if you edit the report from the same page after this happens, the order of the fields is different.|
|19948|Report Design|Optimization|Standardized 'Report Visibility' syntax in XML between ReportDesigner and InstantReports.|
|21403|Feature|Optimization|AdHocSettings.UltimateDbCommandTimeout added. When value is >0 DB request for filling the DataSet is executed asynchronously. If specified time is passed but DataSet is not yet filled then DB command is interrupted and canceled.|
|21620|Report Design|Optimization|Fixed JavaScript error in Internet Explorer created by Date picker due to change of focus.|
|21699|API|Optimization|Refactoring of initialization flags enhancing Izenda's compatibility with various webfarm environments.|
|21755|Dashboards|Visualization|When adding a Visualization to a report part on a dashboard, the sizing element has been removed. The size change cannot be saved in the dashboard as the report part is loaded from the current report format. If a sizing change is needed it should be made in the report and saved there.|
|22000|API|Optimization|Fixed issue with browser zoom settings overzealously moved the InstantReports preview area to the screen bottom, emulating narrow screen (mobile) behavior on full monitors.|
|22225|Report Viewer|Export|Fixed an issue with printing to HTML from report viewer where user could only print one time. On second try there is no response when clicking selecting the Print to HTML print option.|
|22275|API|Export|Reimplemented feature "Limit Outputs to CSV". This allows the report designer to select this option on the Misc tab of the report designer and when the report is viewed in the Report Viewer only CSV and XML export options are shown for export. This is useful in larger report sets where exporting may be very lengthy or where data is needed for export.|
|22348|API|UI|Fixed issue moving from InstantReports to ReportViewer where 'Area' chart is changed back to 'Column' chart default.|
|22395|Report Design|Optimization|Fixed issue where reports with the TenatID _global_ would not load in the ReportDesigner when session included AdHocSettings.CurrentTenantID.|
|22407|Dashboards|Saving|In Dashboard V2 after moving two report parts to different locations in the dashboard, if users clicks 'save dashboard' , then it saves. However, when reloaded, the report parts are back to their original areas.|
|22444|Instant Reports|UI|Fixed issue with restore default colors button not functioning in InstantReports.|
|22495|API|Optimization|Fixed serialization issue with 'Izenda.AdHoc.PdfGeneratorBase' error.|
|22544|Dashboards|Export|Fixed issue with dashboards export to Excel of tables using VGHierarchy style where style was changed before export.|
|22548|API|Expressions|Feature: Added support for DATETIME and SMALLDATETIME for use in expression field.|
|22612|API|Optimization|Updating 'Preview Not Available' image for better user friendliness. Preview will now use a standard report image with a watermark as "Sample" until an actual preview is created from opening the report in the Report Viewer.|
|22626|Report Design|Visualization|Fixed error when choosing PREVIEW in the ReportDesigner if not all information is correctly entered to generate a map in the MAPS tab, causing a SQL error to display in IE.|
|22634|Report Design|Gauge|When creating a new report using a gauge (from gauge tab)in report designer there is a setting showing how may gauges to display - this is not respected in the dashboard, the limit is respected in the report, but all gauges are displayed in dashboard tile.|
|22673|API|Optimization|When using a field where the data contains a comma "," as a drill down filter the comma was not properly escaped in code. This resulted in bad data being sent to the subreport and the subreport was not properly filtered. Resolved, now fields containing commas can be used as drill down fields to a subreport without error.|
|22734|API|Optimization|Reverted changes with unintended consequence of disallowing pathing using both '/' and '\'.|
|22752|API|Optimization|Added value validation code for 'Records' box in 'Fields' tab of ReportDesigner.|
|22772|Dashboards|Optimization|Fixed issues with scheduling dashboards where the schedule type could not be changed from 'Embedded'. Also fixes issue where embedded reports do not export in the correct order.|
|22776|Scheduler|Export|Fixed legacy SchedulerExecuting flag - used to determine whether charts must be rendered to picture. Now Izenda sets this flag automatically when SchedulerOutput.GenerateMessage method is called.|
|22784|API|Export|CSV export using wrong separator ";" when exporting while using culture set to Spanish. Resolved, now properly using the "," separator.|
|22802|API|UI|Fixed issue with SubReport headers are displayed under filters section in reports.|
|22805|API|Optimization|Fixed bug in logic in code which renders report in field|value style if there are hidden fields - previously resulted in "Uncaught SyntaxError: missing ) after argument list" error message.|
|22817|API|Optimization|Fixed issue where artificial limits on paging (10K rows) and report row limit (100K rows) were forced without settings being active.|
|22824|Report Design|UI|Resolved issue where chart titles added in the report designer are not showing up in the title section on the dashboard.|
|22872|Dashboards|UI|Tiles in dashboard using "user-select: none;" css style, but text should be available for copy. This is resolved now and the text from the dashboard tiles can now be copied.|
|22893|API|UI|Added support for Drilldown key passed to subreport to be an aggregate. Prior to this change values would not be passed to subreport if any aggregate function (sum, count, etc.) was used in the field.|
|22898|API|Optimization|Setting AdHocSettings.ApplicationHeaderImageUrl not working properly in Webforms VB kit. Issue resolved. Issue can be resolved without this fix by uncommenting the following lines in default.master.vb: 'If (Not String.IsNullOrEmpty(AdHocSettings.ApplicationHeaderImageUrl)) Then ' rightLogo.Src = AdHocSettings.ApplicationHeaderImageUrl 'End If|
|22932|Instant Reports|Optimization|Fixed issue in InstantReports where 'Search' values were not correctly reducing available options (greying out).|
|22933|API|Optimization|Fixed issue with internal key values for Arabic and Bulgarian localization where the English values were inappropriately used.|
|22947|Report Design|Gauge|Fixed an error with 'Count Distinct' function and 'Linear' gauges causing preview error. Also, improved log gauge readability in some situations.|
|22949|Report Design|Filters|Fix to various 'time period' filters (EX: 'This Week', 'Last Week', 'Today') which had inconsistent/unexpected results.|
|22953|API|Optimization|Fixed difficulty when using VS2015 with Izenda. VS 2015 creates local applicationHostConfig files, solution is to edit ri.csproj to use: <UseGlobalApplicationHostFile>true</UseGlobalApplicationHostFile>|
|22962|API|UI|Fixed issue breaking 'italics' style when subtotals are used.|
|22972|API|Optimization|Beginning with the RI for 6.10.0.3, the AdhocSettings.CurrentUserIsAdmin setting will be put in the global as set to true. This is not a change to the default setting, it is added to make it visible that the default value is true.|
|22999|Instant Reports|Filters|Build script removed from final build on archives site. This is an internal file used for building the site and is not needed in the reference implementation.|
|23013|Instant Reports|Filters|Fixed issue with export to PDF of Projection Map where map duplicates and the link is not clickable.|
|23049|Feature|Visualization|In BETA Instant Reports, reports not saving properly. Issue only seen in complex reports that take a few seconds to save. Optimized save process to speed time and changes made to ensure save process completes.|
|23053|Instant Reports|UI|When adding a new drilldown report to the BETA Instant Report page the popup style was not loading properly, resolved.|
|23054|Dashboards|UI|Possibly HTML injection issue. When using a link to access a report in the report designer, if the report name does not exist the report name given in the link should not be displayed on the screen in the designer. Resolved.|
|23071|Dashboards|Filters|When exporting charts to excel, labels containing dates are exporting as the integer value in excel. Resolved.|
|23081|Report Design|UI|When joining a table twice in the report designer, the second instance of the of the join does not contain "No Lock". Resolved.|
|23104|Dashboards|UI|Fixed issue with delay in opening 'Fields' dropdown in report designer. Optimized JS to increase performance significantly.|
|23109|API|Optimization|Fixed issue when Arithmetic addition checkboxes on the 'Fields' tab were used to sum 3 or more columns consecutively.|
|23121|Report Design|Visualization|Fixed errors with Dashboard2.0 tiles loading blank, and broken funnel chart loading behavior. (Requires browser cache refresh)|
|23156|API|Optimization|Izenda.AdHoc.PdfGeneratorBase was not properly made serializable, resolved.|
|23252|Report Design|Charts|Fixed issue where report name disappears when the cursor is not on the dashboard tile.|
|23255|Scheduler|Optimization|Name of field disappears from filter description when user changes the field format from the fields tab of the report viewer page. Example - date field selected as filter and changed from 2/1/16 to February 1, 2016 the filter field description is removed from the filter header bar.|
|23266|API|Optimization|Fixed server error when using the 'PopUp' drilldown style in InstantReports.|
|23281|Feature|UI|Fixed error with exporting Dashboard Visualization chart parts individually where the links provided for the export were not functional.|
|23290|Report Design|UI|Using a Visually grouped field on a field with a URL link applied and a style of Field Value, results in JavaScript error. Resolved.|
|23326|Report Design|UI|Time Bubble chart not displaying in Internet Explorer, showing error "Timebubble visualization Object doesn't support property or method 'isNaN'". Resolved.|

# 6.10.0.2 (January 26, 2016)

##Important Note about 6.10.0.2
The update process has changed for stand alone MVC versions using Izenda's solution file.  
It is recommended that when upgrading to this version (if you are using a stand alone) to download a new RI.
Any upgrades going forward will require to to copy the contents of the Bin folder of the upgrade pack into your existing Bin folder and another copy into the new Lib folder.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|**HF:23145**|Report Design|Filter|**Hot Fix (02/09/2016)** for new Date/Time picker feature. By default, the date picker does not use time. The picker can be changed to use Date & Time by using AdHocSettings.ShowTimeInFilterPickers = true. <br/><br/>This ticket resolves the following issues: <br/>1 - Dashboard scheduling was inoperable after the date/time picker was added. This is now resolved <br/>2 - Date/Time Picker respects dates using European format in the filter operator. <br/>3 - The second date for Between Calendar operator was defaulting to the beginning of the day (00:00:00). It now defaults to end of the day (23:59:59). This can be modified by the user, but the second date cannot be set to (00:00:00) it should be set to the day prior and the midnight default (23:59:59). These time defaults match the Izenda queries used if the time function is not used. <br/>4 - Previously when user is manually entering data, the cursor is moved to the "Time" field in the date time picker. This has been resolved. <br/>5 - Date picker icons have different vertical alignment in the Report Viewer and in  the Dashboard page. The issue is addressed the new date time picker, which is larger than the old date only version. For this reason the focus for selection had to be changed to the calendar icon to avoid covering the input fields for smaller screens if the user wants to type in the date. Previously, the user could click in the input field to use the picker, now the pickers must be selected by clicking the calendar icon. <br/>6 - Previously, if the user used "AdHocSettings.Language/AdHocSettings.Culture" to implement foreign language settings, the culture was not respected by the date/time picker. The new changes implemented in the current release enabled " AdHocSettings.Language = AdHocLanguage." to automatically set the culture settings when a language is selected i.e. DateTime fields & Currency fields will get adjusted to Language chosen. e.g. When user selects "French" as the language to be implemented then the setting will be " AdHocSettings.Language = AdHocLanguage.French". The Date format will change to European i.e. DD/MM/YYYY & Currency will be changed to Euro.|
|17815|API|Optimization|AdHocSettings.AllowVisualGroups setting is deprecated and will no longer be available.|
|19792|Report List|Optimization|Enhancement of thumbnail generation process fixing incompatibilities with Azure Web Apps and other scenarios with COM restrictions. Reports must be opened in the Report Viewer to generate the thumbnail.|
|20471|Report Design|Gauge|Applying highlight to calculated field then applied to a gauge breaks the gauge. Fixed.|
|21106|Report Design|Charts|Fix: The Bezier curves on the Funnel Chart slice labels is off in viewer and Dashboards.|
|21642|Report Design|Charts|Fix: Legends not showing in pie charts|
|21816|Report Design|UI|Fix: "..." appears in grid; Error with links in CG fields; Issue with "" in field names.|
|21885|Report Design|Expressions|When one adds a field, and the adds and expression to that field under advanced settings, that expression is then added to any NEW field of the same name when using either insert field above/insert field below.|
|21930|Report Design|Optimization|Fix: Erroneous long decimal values in Dashboard.|
|21934|Report Design|Optimization|Fixed long load times as StoredProcedures queried on rpeport load. If following setting is added to Global: AdHocSettings.ValidateExistingReportsInDesigner = false; then Izenda doesn't validate tables/columns in database for existing reports when constructing list of them for reportDesigner (so it still checks if user has access rights to this reportset, tenant, etc. Also it doesn't affect ReportList or anything else except designer). This results in much faster reportDesigner loading, along with no pulling any StoredPProcedure metadata from database for existing reports, though reportDesigner will still show list of subreports, mark datasources which are used in any reports, etc.|
|21935|Feature|Optimization|Fixed Oracle numeric types mapping bug and added datatype mapping control. EX: AdHocContext.Driver.NativeToInternalTypesMap["NUMBER(18,0)"] = SqlType.TimeStamp;|
|21963|Report Design|Optimization|Fix: Issue with Instant Report pages not respecting FieldsRegex.|
|22041|Feature|Optimization|Fix: The date in the header will be displayed, even though we didn't select the "Show date and time".|
|22070|Dashboards|UI|Fixed issue with Dashboard background images not covering the top of Dashboard area.|
|22110|Dashboards|UI|Hover text from individual dashboard tiles is behind adjacent tiles in the dashboard.|
|22131|Report Design|UI|Show Legend Checkbox is implemented.|
|22140|Feature|Forms|You can now add css to the body of a form itself using the <!--FORMSTYLE--> add CSS here <!--FORMSTYLE--> tag|
|22157|Dashboards|UI|After re-sizing a tile in the dashboard, scroll bars appear on unaltered tiles and will continue to display until the unaltered tile is selected for re-sizing.|
|22193|Report Design|Optimization|Refactored Pivot queries for enhanced performance.|
|22235|Report Design|Filters|Fix: Issues and inconsistency found in Filters for Fields with NULL or a Blank available as value.|
|22254|Report Design|Export|CSV files downloaded from Report Viewer and report Designer are having same file size|
|22260|Report Design|Filters|Fixed issue with filters, where with two different joins of the same table, one aliased, any change you make to one is copied over to the other when you click "update results".|
|22266|Report Design|Expressions|When Join Alias is added it does not work in the Expression, also table name stops working.|
|22272|API|Visualization|Fix: Issues with IE9 translucency of the AutoChart tool-tip|
|22316|Feature|Export|Fixed issue with exporting to CSV always returns an excel spreadsheet with the error "Could not pickup appropriate connection" instead of data. Specifically applies to OData connection with BulkCSV enabled.|
|22329|Report Design|UI|Adding constraints using the Izenda.AdHoc.AdHocContext.Driver.AddConstraint method caused garbled field headers when using a pivot.|
|22333|API|Optimization|Updated report name dialog, so now it respects AllowCreateNewCategory setting and don't show "Create New Category" option when AllowCreateNewCategory is false.|
|22335|Report Design|Gauge|Fix: Autogage does not respect $/100 format|
|22340|Report Design|Export|Fix: No report found on excel when exporting a report with a subreport on dashboards.|
|22352|Report Design|Gauge|Fix: The value and Format of Radial Gauge is incomplete when it is previewed.|
|22353|API|Optimization|Fixed issue with exceeding of url length of GET requests in report designer, replaced all with POST.|
|22377|API|Export|PhantomJS headers repeating disabled, hiding bug in core PhantomJS tool. EVO PDF engine added as alternative.|
|22394|API|Optimization|Fix: Made class serializable that wasn't previously. Exception type: SerializationException Exception message: Type 'Izenda.AdHoc.Webservices.SubreportFiltersCollection' in Assembly 'Izenda.AdHoc, Version=6.9.0.6, Culture=neutral,|
|22401|Report Design|Export|Dates changing to number text after exporting to excel when grouped by year/month in report designer.|
|22421|Report Viewer|UI|Fix: Issue with viewer sorting behavior when ResponsiveGrid is on and more columns are added than screenwidth can display.|
|22432|API|UI|Fix spelling error on dashboard scheduler page dashboards says "Recepients" in the email to box. Corrected to show correct spelling "Recipients".|
|22436|Report Design|Visualization|Changing the selection process for Visualization types on the Report Designer Charts tab from radio button to clicking image or name under the image.|
|22449|Dashboards|UI|In Dashboard V2 when filter panel is expanded, the mouse over function in the dashboard grid is not correct. The mouse hovers over one grid square but a different gird square is highlighted. Resolved hover over grid item is also the selected one.|
|22456|Report Design|Filters|Fix to 'Between' filter operator availability and addition of between calendar support to the dashboard.|
|22508|API|Optimization|Fix loss of timezone offset when certain grouping combinations are used.|
|22533|Dashboards|UI|Corrected spelling on dashboards|
|22539|API|Optimization|Separated 'Linear' and 'Logarithmic' gauge scaling|
|22551|Instant Reports|Saving|Error message displayed to user when attempting to save a report from New DEMO IR page in a new Reference Implementation without a Reports folder. Change made to create folder for user to save report definition.|
|22585|API|Filters|Fixed a null reference exception when report is opened with filter values passed in a URL, also resolving issues where Left Join fails to render a report.|
|22587|Report Design|Filters|Fixed lost filter logic parameters upon report export.|
|22598|Report Design|Optimization|Fix: Fields dropdown delays in MVC. Implemented optimization in branch FB-22598, now adding field works ten times faster.|
|22602|Report Design|Visualization|Heatmap issue with values/labels not exporting to PDF fixed.|
|22614|Instant Reports|UI|Add "Expose as datasource" option for Virtual Datasources to new DEMO Instant Report page.|
|22651|API|Optimization|Fix: Broken recognition on multiple constraints containing foreign keys.|
|22662|Instant Reports|Filters|BETA New Instant Report page added support of Param indicator for filters. This allows the user creating the report the ability to display filters to the report viewer as parameters for changing the report filter values. This ability is based on the sharing rights given to the viewing user.|
|22676|Instant Reports|Filters|New Instant Report Page added support for filter descriptions. User can change the name of the filter for viewing in the report viewer.|
|22683|Feature|Visualization|User help information added into base fileset for AutoGauge & Flowchart visualizations.|
|22701|Instant Reports|UI|Added responsive behavior for reduced screen sizes for New Instant Report page. For mobile all items are moved to left panel and UI elements are are adapted for small screen size.|
|22712|Dashboards|UI|Fix: Report Parts on dashboard disappear if Show tile options was clicked while the print tile report is open in another window.|
|22717|Dashboards|Filters|Autocomplete filters from reports are not functioning in Dashboard V2. Data is not displaying when user types in any data to the filter. Resolved.|
|22748|Report Design|UI|Fixed css style which prevents proper Width value from being applied.|
|22753|Dashboards|UI|When using setting AdHocSettings.ShowSaveControls = false; the setting is not removed from the Dashboard V2 page. Resolved, setting now disables all save functionality from Dashboard page.|
|22762|API|Optimization|Izenda License keys were not expired as expected. After the fix testing is done in all the environments i.e. SQL, MySQL, Oracle, PostGress, ODATA, MVC.|
|22773|Report Design|Visualization|Adding help text for ArcMap and Projected Map in Visualizations area of Report Designer.|
|22787|API|Optimization|When using tables with "." in name. Constraints were not loading from the database to allow users to join tables in simple mode of Report Designer and Instant Reports. Resolved now tables names with "." are not blocking constraints.|
|22818|Report Design|Charts|Fix: Y-Axis labels improperly formatted for right-hand Y-Axis values.|
|22861|Scheduler|Optimization|Fix: Scheduled Dashboard uses 'ReportViewer' link instead of 'Dashboards' link.|
|22875|API|Optimization|Fix: Minimization of StoredPocedure calls amount when rendering reportSet with several reports.|
|22922|Feature|UI|Folder structure modified to alleviate issues with helper files being deleted on Clean or Rebuild processes in Visual Studio. New Libs folder now contains a copy of the bin folder (must be kept up-to-date on maintenance release upgrades where bin folder is replaced without a new RI) to keep helper files from being deleted when the project is cleaned.|
|22945|Report Design|UI|Fixed grid filtering based on Viz drilldowns.|
|22968|Report Design|UI|Fixed broken HTML charts (HiCharts) in MVC deployments.|
|23045|Report Design|UI|Regression issue using popup filter. The selection of values in pop up after save causes report to display no records selected.|

# 6.10.0.1 (December 29, 2015)

##Features
|Case|Category|SubCategory|Description|
|:----|:---------------|:---------------|:---------------|
|**Architecture Update**|**Internal**|**Browser Support**|**Izenda 6.10.0.x versions have dropped support for IE8. IE9+ must be used for versions 6.10.0.1 and later. While users may still be able to access the application from IE8 new and or existing features and functionality may no longer work in these browsers. In addition, bugs or performance issues that appear only when using IE8 will not be investigated or fixed after this release.**|
|**HF:22762**|**Security**|**License Conflict**|**Hotfix patch to Izenda 6.10.0.1 to resolve a licensing conflict. (01/05/2016)**|
|FB:22008|Framework|.NET Version Update |**Updated the Izenda .NET framework to 4.0**|
|FB:13917|Data|Data Sources|Feature - Addition of support for Oracle Stored Procedures. The only stored procedures supported at this time are pipelined functions that return a table-valued object. See [[this documentation|http://docs.oracle.com/cd/B19306_01/appdev.102/b14289/dcitblfns.htm]] for more details on table-valued pipelined functions. Functionally, these work just like MSSQL stored procedures as far as Izenda is concerned. The processes for including them in VisibleDataSources, working with constraints, passing parameters as filters, etc are the same.|
|FB:21959|Data|Data Sources|Feature - Addition of MySQL Stored Procedure support. The only stored procedures supported at this time MUST be formatted a specific way for Izenda to be able to use them. The connection string must use the MULTI_STATEMENTS=1 identifier. The procedures themselves must use the following syntax: DELIMITER $$ BEGIN DROP TABLE IF EXISTS `[SprocName]_spResult`; /* Izenda-specific code */ CREATE TEMPORARY TABLE `[SprocName]_spResult` AS /* Izenda-specific code */ [The normal sproc body goes here] SELECT * FROM `[SprocName]_spResult`; /* Izenda-specific code */ END$$ DELIMITER ; where [SprocName] is the exact name of your stored procedure without the brackets. Functionally, these work just like MSSQL stored procedures as far as Izenda is concerned. The processes for including them in VisibleDataSources, working with constraints, passing parameters as filters, etc are the same. Be sure to change the DELIMITER to something other than the semicolon or else MySQL will not correctly compile the stored procedure.|
|FB:22093|API|Cache|Feature - Add support to allow 'InvalidateSchemaCache' to be executed across entire webfarm. New setting implemented, activated through a single setting. If there are two machines "server1" and "server2" in webfarm, for both servers, use the following setting in InitializeReporting:AdHocSettings.WebFarmNodesRsUrls = new string[] { "http://server1/rs.aspx", "http://server2/rs.aspx" }; When invalidate schema cache is used it works across all machines.|
|FB:19135|API|Session State|Feature - Added IDataStorage interface to allow customization of the storage mechanisms for sessions. Izenda can be configured to use a custom class that implements this interface. Sample use:// This code should be placed before any Izenda calls.AdHocContext.Storage = new CustomSessionStorage(); A code sample was created to illustrate the concepts. Code Sample available [here](http://wiki.izenda.us/Release-Notes/sessionsample.txt)|
|FB:19705|Report Design|Filters|Feature – Add Filter Alias. Prior to this new feature filters must be named the same as the column name or Field Alias set in code. Now to alias filters there are 2 options 1 – Use AdHocSettings.FilterAliases to set the alias for how column names are displayed in the filter selection drop down from code. 2 – User can change the filter name using the new Description field. This can be accessed in the Report designer from the filter tab or from the viewer by clicking the gear icon in the filter. The logic of applying aliases is the following (from the highest priority to the lowest): 1) Defined by the user alias - Description property of the filter 2) AdHocSettings.FilterAliases 3) AdHocSettings.FieldAliases 4) Column name. More information can be found [here](http://wiki.izenda.us/Guides/ReportDesign/5.0-Filters-tab)|
|FB:19756|API|Caching|Feature - Cache Interface Added. The first phase of cache changes to allow easy customization of the caching mechanism(s) used in Izenda. A new cache interface (IPermanentDataCache) was implemented for two Izenda data caches. RenderedResultsCache: the Fusion(HTML) cache DatabaseSchemaCache: used to cache the schema information. With these changes, any caching provider can be used by implementing the IPermanentDataCache interface in a custom class and configuring Izenda to use the custom class. AdHoc.Cache.DataCache.IPermanentDataCache is called "permanent" because for these caches we do not use the "storage" expiration approach. The expiration policy of all objects in the cache can be controlled by custom code. - Custom caches can be specified using AdHocContext.Caches property. Currently DataCacheRepository contain only two caches - RenderedResultsCache and DatabaseSchemaCache but we will expand this list to more different caches. Having one repository will make adding them easier in the future. Here is how you can apply custom class for DB cache: AdHocContext.Caches.DatabaseSchemaCache = new CustomDbSchemaCache(); And here is the same for Fusion cache: AdHocContext.Caches.RenderedResultsCache = new CustomHtmlCache(); Be sure to do this before all other Izenda calls. A sample Redis cache for DB Schema has been created for reference. This was implemented using Redis. Code Sample available [here](http://wiki.izenda.us/Release-Notes/CacheSample.txt)|
|FB:19815|Instant Reports|New BETA Page|Feature - The new Instant Report Designer page is being released as a *BETA* version in the Izenda 6.10.0.1 release. This beta release is made available to allow a broad user base to evaluate and give us feedback on the future of the Report Designer, but is not recommended for production use at this stage. This is not a fully supported feature however and any product defects will be noted, but not slated for immediately scheduled work.Please review documentation [here](http://wiki.izenda.us/Guides/Instant-Reports-v2-BETA)|
|FB:21663|Printing|PDF Support In Azure|Addition of new PDF engine - EVO. Provides Azure support via cloud service. There is a known issue with HTML charts and EVO printing that is scheduled for resolution in 6.10.0.2. Learn more on this configuring the cloud service [here](http://wiki.izenda.us/API/CodeSamples/PdfPrintMode#PdfPrintMode)|

##Fixes
|Case|Category|SubCategory|Description|
|:----|:---------------|:---------------|:---------------|
|FB:22308|UI|Language Support|Updated several language files with incremental changes from recent UI changes.|
|FB:21917|Report Design|Visualization|Reintroducing ArcMap Visualization to stock Visualization pool.|
|FB:22277|Scheduler|Scheduler|Removed dummy URL references within utility file and replaced with empty string. Supporting use case of offline custom scheduler. Added minor url changes to resolve javascript errors.|
|FB:21988|Report Design|Virtual Data Source|Fix VirtualDataSources to ignore TOP setting of last viewer save state.|
|FB:22660|Report Design|Localization|Fixed issue with string sources loading with empty values in localization.|
|FB:22658|Starter Kit|Instant Report|Updated RI kits for standard deployment|
|FB:22311|Report Design|Visualization|Transitions visualization labels overlapping each other in the chart. Updated and now are displaying dispersed as expected.|
|FB:22135|Report Design|Pivots|Oracle Pivots bug resulting in 'Invalid Report Definition' error due to improper string conversion, resolved.|
|FB:21874|API|Dashboards|Added angular configuration option to show dashboard without list/toolbar.|
|FB:22512|Data|Data Sources|Oracle CHAR datatype concatenating values in ReportViewer Filter panel. Fixed in \Resources\js\ReportViewerFilters.js file. Replace "if (newVal.length > 1)" with "if (newVal.length > 0)".|
|FB:22570|API|Language Support|Updated Resources files with additional Language files to be distributed. |
|FB:22078|API|Hidden Columns|Fix: HiddenColumns - apply to ALL FieldsRegex - apply only to Fields FiltersRegex - apply only to Filters|
|FB:21806|UI|Report List|Fix/Enhancement: Improved ReportList search behavior. Now when user types in report name, categories are limited to only the ones containing a similar name as search.|
|FB:21857|Starter Kit|MVC|Fix: Workaround to MVC version routing issues when publishing to IIS as a website directly from VisualStudio. Now a vanilla download should be able to be published directly with no changes.|
|FB:22168|API|Security|XSS attack security measures conflict with '&' symbol in multi-select filters. Fixed.|
|FB:22160|Data|Data Sources|Added additional support for MySQL filters with numeric/decimal field types.|
|FB:21807|Report Design|UI|Fix: Corrected erroneous 'flagging' of advanced field properties panel when new field is added.|
|FB:22347|Printing|Printing|AutoChart missing from HTML export, resolved|
|FB:21733|Printing|Printing|Fix: Support of printing/exporting an unsaved dashboard.|
|FB:21220|Report Design|Charts|Fix: Doughnut Pie-Chart wedges very thin.|
|FB:22146|Report Design|Gauge|Animation is not disabled for the Gauges visualization when printing. As a result intermittently incorrect data is displayed.|
|FB:22480|Report Design|Visualization|When using only visualizations on a dashboard, the sub-report linking doesn't honor the filters selected user clicks-through to the sub reports. Fixed|
|FB:19428|Refactor|Exporting|Fix: Refactor of export code to improve rendering performance and memory performance.|
|FB:21969|Scheduler|Scheduler|Fix: Scheduler 'embed' option. "rn=" parameter name is missed in the link URL so instead of "ReportViewer.aspx?rn=ReportName" the link uses "ReportViewer.aspx?ReportName" URL now corrected.|
|FB:22383|Report Design|Filters|Discovered place in code with the inconsistency - Filter.GetConvertedColumnValue - causes filter dates to be converted to US dates when running filters (MM/dd/yyyy)|
|FB:20529|Report Design|Forms|Removed unused code for @total used in form creation as it was not used. Also it was removed from the Smart Tags drop-down in Forms editor.|
|FB:22555|Report Design|Filters|Field Comparison Filter not working, displays message “Please enter a valid value in String format" when comparing fields. Resolved|
|FB:22214|Report Design|Visualization|Visualizations now support fields of Object type.|
|FB:22655|Report List|Report List|Regression issue found with pivot scroll bars, missing horizontal and vertical scrolling function when creating large pivots resolved.|
|FB:22637|Report Design|Forms|Removed button "Go To Online Documentation" from within the Features tab of the Settings page. This linked to old Izenda Knowledgebase that will be taken offline.|
|FB:22711|UI|DashBoard|Dashboard error "An entry with the same keys already exists" when refreshing dashboard. resolved.|
|FB:22239|Charts|Exporting|Trend and Bar charts are being compressed in HTML and PDF exporting. Resolved|
|FB:22296|Charts|Visualization|Error when printing to HTML with visualizations, overlapping of visualizations in document. Fixed|
|FB:22477|UI|Charts|Pie chart with Separator will not render in dashboard when used in report. Fixed|

#[6.9 Release Notes](/6-dot-9-Release-Notes-Archive)
#[6.8 Release Notes](/6-dot-8-Release-Notes-Archive)
#[6.7 Release Notes](/6-dot-7-Release-Notes-Archive)