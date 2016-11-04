#6.8 Release Notes Archive

[[_TOC_]]
# 6.8.0.8 (April 21, 2015)


**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

Note: The Visualizations help text contains a link directing the user to the Visualization feature page on the Izenda Wiki. If you would like to remove this like, you can modify the Doc.html files within the Resources/Vis folder for each chart type.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|**HF:19382**| **MVC Builds Only**|**API**|**In 6.8.0.x MVC kits downloaded prior to 4/24/2015, there was an issue where using AdHoc settings would not disable the ability to create new reports and dashboards. To fix this issue, please replace the _SiteLayout.cshtml file located in Views/Shared with [this one](https://izenda.sharefile.com/d-scab81cb6d6e43b3a).**|
|FB:14779|Report Design|Visualization|Corrected allowable size of bars (Auto Chart, Combo).|
|FB:17625|API|UI|Adressed localization not being applied in new UI elements.|
|FB:17962|API|Logging|Internal logger can now be completely disabled|
|FB:18248|Report Design|Visualization|Fixed breaking visualization with URL Advanced Field Setting.|
|FB:18281|API|Constraints|Implemented bulk adding constraints, Optimized FusionDriver.GetAllTables method, FusionConnection.GetColumns() method and Driver.ExtractSchema method|
|FB:18303|API|UI|Implemented possibility to configure join aliases in Advanced mode, and possibility to switch from Advanced to Simple mode without loosing join aliases|
|FB:18332|API|Optimization|Fixed error in JS when opening field properties window several times|
|FB:18371|API|Optimization|Trim trailing space to group Visual Grouping according to the ANSI/ISO SQL-92 standard for MSSQL|
|FB:18373|API|Optimization|Cleaned up .ascx pages in RI/Resources|
|FB:18418|API|Optimization|Removed excess string concatenations, made "variable cache" optimization in ResponseServer.IsTableVisible and ResponseServer.GetFunctionsList, removed excess ToLowerInvariant calls. Refactored AllTablesWithColumns member in Drivers, and thus fixed not-working part of disk schema cache for oracle and postgresql drivers. Changed linear search to picking from dictionary in "Column[] GetColumns(Table table)" methods of Driver-s.|
|FB:18422|Instant Reports|UI|Automatically sort VG fields in the report created on the Instant Report page|
|FB:18474|API|Optimization|Try to load only particular itextsharp assembly version to avoid versions conflicts|
|FB:18485|Report Design|UI|Visual Group headers now respect colors set for fields|
|FB:18508|API|Export|Apply all formatting levels to the Bulk CSV output|
|FB:18515|Instant Reports|Optimization|Improve autocomplete performance on the Instant Report page|
|FB:18560|API|Optimization|Fixed data filtering bug.|
|FB:18591|Report Design|Optimization|Fixed drill-down key field showing as a smart-tag|
|FB:18594|Report Design|Charts|Fixed applying simple custom formats to DundasCharts. Added properties to Funnel and Plot (Dundas) and Funnel (HtmlChart)|
|FB:18595|Report Design|Filters|Do not include extra param when filter operator is changed to Between|
|FB:18597|Report Design|Filters|Client-side sorting of dates before 1970 fixed|
|FB:18661|Report Design|Filters|Do not refresh filters automatically in the Viewer if CascadeFilterValues is set to false. Properly handle filters with identical structure in the Viewer.|
|FB:18670|API|Database Mode|Fixed null reference error when Fusion Driver is used together with DatabaseAdHocConfig and reportList caching|
|FB:18695|API|Optimization|API to specify a valid native type to override internal DB type for temp SP table creation|
|FB:18710|Report Design|Optimization|Apply "Page Break After VG" setting to the field-value styled VG|
|FB:18714|API|Fusion|Made it possible to create and use virtual datasources with FusionDriver against databases exposed via fusion connections|
|FB:18736|API|Pagination|Removed pagination from dashboards.|
|FB:18737|API|Optimization|Apply AdHocSettings.TimeZoneOffset to some Date aggregate functions, AdHocSettings.TimeZoneOffset datatype is now double|
|FB:18756|API|Optimization|New auto-join algorithm|
|FB:18766|API|Pagination|Tiny fix for correct calculation of the amount of pages. Properly format both Detail and Summary grids when pagination is used|
|FB:18802|API|Expressions|Properly handle FieldAliases in the expressions|
|FB:18828|API|Caching|Fixed cherry pick conflict|
|FB:18845|Report Viewer|Charts|Restore fade-out of the long labels in a vertical Bar Chart|
|FB:18849|API|Data Sources|Do not show SavedReportsTable as available data source. Properly handle SavedReportsTable with schema name in Oracle and PostGreSQL|
|FB:18854|API|Optimization|Fixed out of range exception in DrillDownKeys|
|FB:18858|API|Expressions|Allow tabulation chars in the Expression for better formatting|
|FB:18859|UI|Expressions|Refresh calculated fields list when Arithmetic or Expression is changed|
|FB:18869|API|Export|Fixed exporting from the Designer (regression bug from the FB-17901)|
|FB:18873|API|Visualization|Refactored Visualization charts and fixed help text|
|FB:18915|Report Design|Joining|Fixed missing joins on switching between modes, and another issue with join aliases after switching to simple mode|
|FB:18919|UI|Database Mode|Do not create duplicates in the report list in DatabaseAdHocConfig when CurrentUserTenantId is specified|
|FB:18920|API|Pagination|Use cache with pagination so SQL request is not required to change the page|
|FB:18942|Report Design|UI|Fixed Gradient Cell not working in case of some formats.|
|FB:18949|Report Design|Charts|Properly round Axis labels in Bar and Trend charts when integer format is used|
|FB:18955|API|Optimization|Removed unused empty class.|
|FB:18970|API|Optimization|Distinct keys values in the AdHocSettings.FieldAliases collection|
|FB:18973|Save|Visualization|Fixed bug saving the properties in the case of two or more visualizations in a single report.|
|FB:18974|Report Design|Visualization|Fixed showing subreport charts in expand panel of the Auto Chart.|
|FB:18977|Report Design|Optimization|Fixed the Record Count metric.|
|FB:18980|API|Optimization|Fixed malformed mime type header|
|FB:18998|Report Design|Optimization|Avoid to add empty HAVING clause|
|FB:19014|API|Saving|NullReferenceException on save when UseReportID setting is set to true fixed|
|FB:19022|Save|Forms|Save Form in the proper location when CurrentUserTenantId is set|
|FB:19030|API|Optimization|Replace text for Divide-By-Zero will now show empty strings|
|FB:19034|API|Optimization|Prevent XSS attack via HTTP header on the Settings and rs pages|
|FB:19044|API|Logging|Added logging to ListReportsCache/ReportListCacheStorage classes.|
|FB:19046|Report Design|Optimization|Fixed NullReferenceException when processing hidden filter with empty column|
|FB:19061|API|Expressions|Subtotals Expression feature implemented|
|FB:19080|API|Optimization|Fixed deadloop in GetConstraintsInfo|
|FB:19087|Report Design|UI|Properly handle VG Hierarchy rows visibility according to the ExpandVisualGroupGrids setting value|
|FB:19107|API|Optimization|Added public method Utility.InitFakeHttpContext() which customer can call to ensure that Izenda is not running null http context in win32 (not web) application.|
|FB:19110|Report Viewer|Export|Fixed hiding wrong fields when using /csv and BulkCSV.|
|FB:19123|UI|Optimization|Changed margin of the AllowNulls checkbox.|
|FB:19125|API|Caching|Added disabling query cache if SavedReportsTable occurs in parameters values.|
|FB:19294|API|Arithmetic|Changed ShowArithmetics default value to true|
|FB:19304|Report Viewer|Optimization|Fixed JS error when opening field properties in viewer|


# 6.8.0.7 (March 24, 2015)


**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

Note: The Visualizations help text contains a link directing the user to the Visualization feature page on the Izenda Wiki. If you would like to remove this link, you can modify the Doc.html files within the Resources/Vis folder for each chart type.

|Case|Category|Subcategory|Description|
|:----|:-----------|:----------------|:---------------|
|HF:19020|API|Filters|Fixed issue resulting in unneeded HAVING clauses|
|FB:12976|API|PostgreSQL|PostgreSQL type mapping reviewed.|
|FB:13008|Report Design|Filters|Selecting a value for "Require" in the Report Viewer will no longer throw an exception when calculated columns are being filtered upon.|
|FB:14209|Report Viewer|Visualization|Text labels are removed from the World Tour when the user takes control using the mouse. Resume the animation by clicking the visualization.|
|FB:14271|Report Design|Joining|Automatically COLLATE Stored Procedures columns to the database_default if Stored Procedure is used in the JOIN|
|FB:15381|Report Design|Fusion|Fixed Pivots and Filters when Fusion connection is used|
|FB:17588|Save|Export|Modified exports to use the report name as the file name. If the report has not been saved, the name will default to 'Report.xxx'|
|FB:17695|Scheduler|Resources|Internal static resources load directly instead of using HttpRequests so emailed reports appear correctly|
|FB:17783|API|Caching|Implemented updating databaseschema on new session  |
|FB:17942|Report Design|Pagination|Fixed pagination error in Report Designer where changing pages would result in "No field selected"|
|FB:17943|API|Browser|WorldMap in FireFox now appears correctly|
|FB:18080|Save|Export|Pie charts can now cross pages without being cut off.|
|FB:18082|Report Viewer|Responsive Grid|Updated Responsive Grid to work with higher rowcounts|
|FB:18107|Scheduler|Dundas Charts|Fixed bug in rendering DundasChart within scheduled reports.|
|FB:18140|Report Design|Gauge|Pass correct parent report param to the drill-down report of the Gauge report inDashboard|
|FB:18165|Report Design|Pivots|Properties of columns in Pivots and Fields are not independent of eachother|
|FB:18171|Report Viewer|Fields|Fixed group issue on fields adding in report viewer|
|FB:18218|API|License Key|Fixed Data Sources page error when license contains no +MAPS.|
|FB:18226|Report Viewer|Charts|Fixed inconsistency between Value field and available Functions in charts.|
|FB:18231|API|Data Sources|Fixed issue in fusion driver when odata connection to webservice behind load balancer is used|
|FB:18245|Report Design|Filter|FilterLogic with HAVING fixed|
|FB:18295|Report Design|Expressions|Allow NOT key word in Expression|
|FB:18304|API|Caching|Do not include Report Position in the cache signature|
|FB:18323|API|Performance|made driver calls to the ParentReportSet more consistent|
|FB:18349|Report Design|Charts|Fixed inconsistency in formatting between Field and Chart (Trend, Pie, Funnel).|
|FB:18354|Dashboards|Analysis Grid|Fixed showing Analysis Grid on Dashboard.|
|FB:18359|Report Viewer|Fields|Do not show fields that are part of the arithmetic in the Viewer Fields control|
|FB:18369|Report Viewer|Fields|Persist field properties when it's moved to the unused pane in the Viewer|
|FB:18370|API|Caching|Synchronize report list cache in DB storage mode when App server and DB server have different time zones|
|FB:18380|Report Design|Forms|Ensure tinymce empty form is removed from report|
|FB:18390|Save|Dashboards|Use real form id instead of the hard-coded one on the Dashboards page|
|FB:18413|API|Caching|Fixed showing obsolete data on UpdateResults click when CacheQueries enabled|
|FB:18455|Report Design|Forms|Allowed to put fields absent in Form without sorting to the top of selection list|
|FB:18491|Report Viewer|Summary|Fixed Gradient Cell Shading in Summary.|
|FB:18508|API|Export|Execute report only one time for BulkCSV export & ProcessDataRow method added to the API|
|FB:18509|Instant Reports|Fields|Properly sort field names on the Instant Report page.|
|FB:18532|Report Design|Auto Chart|"Auto chart" refactoring. Fixed non-unique element ids.|
|FB:18534|Save|Export|Allow HTML content (in report header/footer/title and field description) to be rendered in export output|
|FB:18545|UI|Filters|Filters with long names UI issue fixed|
|FB:18552|API|Forms|updated CodeMagic to use syntax highlighting|
|FB:18559|Report Design|Visualization|Use Visualization from any Chart tab rather than from the first only|
|FB:18573|Report Viewer|Report List|Authentication no longer impedes thumnail viewing|
|FB:18577|Save|Database Mode|Properly handle SavedReportsTable with schema name|
|FB:18602|Dashboards|Security|Encode user input on the Dashboard Designer page|
|FB:18610|Report Design|Fusion|Do not auto group fields with aggregate function in expression - Fusion connection fix|
|FB:18621|API|Save|AdHocSettings.ShowModifiedReportMessage setting added|
|FB:18622|API|Export|Modified build script. Only distributes phantomjs exe now.|
|FB:18624|Save|Export|Fixed exporting of the visualizations.|
|FB:18641|Report Design|Filters|Fixed '(blank)' behavior of the multi-selection operators in the filters.|
|FB:18696|API|Security|Implemented concealing connectionstring in logs|
|FB:18715|API|Data Sources|Made virtual datasources working correctly together with changes from 16086|
|FB:18721|Report Design|Visualization|Upgraded Visualization Helptext. This text contains a reference to the Izenda wiki that can be removed in the doc.html file for each visualization contained in the Resources folder|
|FB:18731|Report Design|UI|Fixed hiding of service field.|
|FB:18732|Report Viewer|Resizing|Fixed report title, description and other header items from maximum 33% size to100%, removed nowrap from description, header and footer of report.|
|FB:18735|API|Broswer|Fixed error in IE9 when cssText property is changed.|
|FB:18793|Report Design|Arithmetic|Fixed checking on division by zero.|
|FB:18833|Report Design|Forms|Made autocompletion hidden on forms by default|
|FB:18834|API|Visible  Datasources|Fixed missing constraints|
|FB:18838|API||Fixed izenda crash on null value in Xml column in reports table|
|FB:18871|Report Design|Visualization|Fixed Timeline visualization not working.|
|FB:18902|Dashboards|Charts|Fixed charts on dashboards not working.|
|FB:18939|Instant Reports|Auto Chart|AutoChart fixed on the Instant Report page|
|FB:18961|Report Viewer|Saving|Added confirmation of overwriting reportset in reportviewer|

# 6.8.0.6 (February 25, 2015)


**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

* **HF-18699: Predefined Constraints Not Being Recognized - Download links updated 2/26/2015**
* FB-13156: Show friendly error when Analysis Grid report is designed incorrectly
* FB-13980: Fixed formatting values for: Matrix, Waterfall, Time Bubble, World Tour, Combo, Tree and Autochart Visualizations. Fixed displaying "Others" and percent values in Autochart.
* FB-14319: Grammatical issue was fixed "does" not "do"
* FB-14067: Fix common filters in Dashboards when there are several filters on the same column and with the same Operator.
* FB-14744: Fixed Appearance tab on Settings page.
* FB-14779: Fixed correct rendering of visualization in small containers. Hide breadcrumbs if the content overflows an element's container.
* FB-15238: Fixed behavior of Pie and Funnel chart types.
* FB-15790: Implement Filters on the Instant Report page
* FB-16415: ReportDesigner fixed to handle browser width while piechart generates
* FB-17549: Fixed bulkcsv export crash when pivots are used
* FB-17669: Added possibility to post-process highcharts labels
* FB-17790: Expand analysis grid groups in Scheduler output
* FB-17821: Fixed missing of FusionConnection.getDataSetUrl value in new session
* FB-17852: Scheduler - Include category in the Report link
* FB-17869: Added support for DB Mode in PostGreSQL and Amazon Red Shift
* FB-17901: Implemented Loader... until print window is closed. Fixed multiple html-prints in ReportDesigner
* FB-17918: Implemented possibility to export reports without redirection. Changed name of setting.
* FB-17935: Made FORMSCRIPT and VISUALISATION Forms smart-tags case-insensitive
* FB-17948: Re-implemented AddAll and RemoveAll on fields tab
* FB-17961: Fixed issue with scheduler where clients were getting multiple copies of the same email
* FB-17981: Fixed indicators in dundas map
* FB-18008: Finished changes to wrap labels on horizontal bar chart
* FB-18091: Properly select reports from DB when name contains special symbols or spaces
* FB-18100: Respect UseBulkCSV setting in scheduled output. Fixed subtotals in Bulk CSV export when filters are used
* FB-18117: Apply new color scheme to the Filters, Field Properties and Instant Report page elements
* FB-18132 Fixed waterfall/html-charts component updated
* FB-18144: Fix :hover behavior in Report List on touch interfaces. Use link controls on the ReportList page.
* FB-18155: Simplified instant reports UI related to totals/subtotals. Disabled applying SUM subtotal function on IR page.
* FB-18175: Reconciliation of changes in 15602 with 18175
* FB-18175: Optimization of first reportlist loading
* FB-18251: Fixed datetime formatting when exporting to excel
* FB-18276: Or issue in hidden filters fixed
* FB-18336: Optimize ReportSet objects writing. Do not include GUIDs of the hidden filters. Do not use auto-generated IDs when calculating ReportSet cache key
* FB-18344: Fixed stack overflow when loading reports from DB (issue introduced in FB-16086)
* FB-18352: Added codemagic as the new source editor for forms. Added z-index property to pop up box.
* FB-18357: Forms popup hidden behind main navigation bar
* FB-18356: Fixed issue where a user with full access is unable to move from the fields tab and no user is able to view the report thereafter.
* FB-18381: Fixed infinite recursion when updating report in reportviewer
* FB-18419: Prevent recursion call of GetDataSet method when CurrentReportSet is not initialized
* FB-18439: Populate columns for data sources when VisibleDataSources collection is changed
* FB-18470: Fixed Virtual Data Sources column names generating
* FB-18528: Altered ToolbarBackgroundImageUrl's default value to be empty
* FB-18605: Allow only fields from the Details to be used for the new Filters in the Viewer


# 6.8.0.5 (January 29, 2015)


**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

* FB-15635: Fixed chart name position for pie charts
* FB-15913: Fixed "Print HTML" and "HTML-powered PDF" for visualizations ("Auto Chart", "Sunburst", "Heatmap"). Fixed a bug of printing inconsistent data (Chart and Table).
* FB-16304: Pass only parameters with values to the SP
* FB-17519: Show note message in Preview if labels on the Line Chart were hidden automatically
* FB-17524: Implemented front-end Money and % formatters for autocharts. Implemented front-end PercentOfGroupFormatter for aurocharts
* FB-17640: Fixed exception which could occur if table is not found during constraints deserialization
* FB-17692: UseTablesFromSchemaOnly setting implemented for MSSQL connections. Load objects from different schemas mechanism implemented for PostgreSQL connections
* FB-17698: Changed powered by Izenda logo to new logo
* FB-17753: Fixed Time-slider values changing
* FB-17754: Use current Thread culture to format dates in the Slider control
* FB-17771: Fixed field properties button in reportviewer
* FB-17807: Implemented changing pdf export button when itextsharp is engaged
* FB-17818: Do not auto group fields with aggregate function in expression
* FB-17825: Fixed Drill-Down links in AG value cells
* FB-17826: Apply font style to values cells in AG
* FB-17827: Apply column Width to AG value columns
* FB-17828: Fixed labels and values alignment in AG
* FB-17851: Trim long labels in Heatmap Vis
* FB-17858: Apply Width, font style and justification settings to AG hierarchy columns
* FB-17951: Fixed Numbers subtotal calculation in PostgreSQL
* FB-17958: Made Cancel button always enabled in form designer
* FB-17969: Quick fix of tiny issue - not showing thumbnail image in reportlist which was requested first. ReportList optimizations #1
* FB-17976: Remove used fields from the available columns panel in the Viewer
* FB-17982: Do not show labels if container is too small in Heatmap Visualization
* FB-18071: Fixed error with thumbnail retrieval in database mode
* FB-18081: Fixed Trend(Line) chart value labels
* FB-18104: Fixed issue which caused ignoring overriden methods.
* FB-18110: Fixed failure of creating thumbnails when there are two or more thumbnail generation tasks in queue. Reverted back public methods signatures which were erroneously modified.
* FB-18130: Fixed Gauges headers formatting
* FB-18157: Use minimum value as a floor of the Y axis in linear chart
* FB-18158: Do not cache requests to the table with reports
* FB-18278: Fixed appearing invisible datasources on IR page
* Changed button colors to new color scheme
* Implemented printing report using current position on breadcrumb (Sunburst, Heatmap).
* Modified build script to move phantomJS dependencies to bin


# 6.8.0.4 (January 8, 2015)

**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

* FB-13507: Moved forms out of sessions, switched to new form designer, moved templates out of sessins, fixed issue with forms being modified concurrently
* FB-13832: Fix of null reference exception for two different users with the same tenantid and optimize report list loading
* FB-15612: Fix charts width in PDF render and increase timeout limits
* FB-16097: PieChart doesn't smash anymore on mousemove while starting
* FB-16120: Fixed radius of the inner circle in Sunburst visualization.
* FB-16228: Fixed not working in some cases forced left joins
* FB-16286: Added missing variable to JoinedTablesList.js
* FB-16295: Fixed error when url doesn't contain port number.
* FB-16351: Implemented switch from advanced to simple datasources
* FB-16415: Fixed Pie char labels cutting off
* FB-17478: Combine Bottom % - ViZ Pie implementation
* FB-17513: Fixed showing visualization on dashboards (reports with VG).
* FB-17543: Use current report state when exporting charts as images
* FB-17586: Fixed subreports cascade filters loading
* FB-17663: Buttons below field list
* FB-17699: Fixed logo sizing issue and hanged main navbar color scheme and logo
* FB-17718: Join aliases of self-joined tables support in Viewer
* FB-17723: Added forms data to objects in report list cache
* FB-17787: Fixed broken charts when report part is on page without rs.aspx in folder, missing dashboard.css, implemented support of custom reportpart locations in visualizations 
* FB-17788: Respect fields visibility in Bulk CSV export
* FB-17793: Made it possible to configure path to rs.aspx in html reportpart
* FB-17796: Fixed funnel cutoff in dashboards
* FB-17797: Removed jquery191 script from reportpart
* FB-17801: Switch between plus-minus icons in responsive grid
* FB-17803: Added deprecation information for AllowSelfJoin
* FB-17805: Fixed dialog dropdowns "Loading..." issue
* FB-17819: Case-insensitive  AdHocSettings.DataSourceCategories
* FB-17822: Fixed Bulk CSV export with Oracle connection and filters
* FB-17844: Avoid zero columns for pie charts
* FB-17856: Fixed Heatmap visualization vertical justification and size
* FB-17857: Fixed false messages upon 2nd+ saves in the Designer.
* FB-17861: Added percents to animated half circle gauge and implemented percentage values in animated gauges
* FB-17870: Fixed Equals(Select) filters in the Designer 
* FB-17829: Fixed GaugeRadial.png resource loading
* FB-17940: Fixed crash when fieldForHaving is null
* FB-17959: Added using _global_ report if report for current user tenant is not found


# 6.8.0.3 (December 17, 2014)

**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

* FB-15865: Fixed bulk CSV output for reports with custom ProcessDataSet results
* FB-17715: Probable fix of null reference exception
* FB-17765: Fixed not-working "update results" button when report is without filters.
* FB-16228: Chose correct base table for join when Forced Left Joins are used.
* FB-15157: fixed RemoveUsedFields function
* FB-15884: Implemented storing custom chart legend in report
* FB-14600: Filter field quoted to prevent js-injection
* FB-15330: Borders, background and chart sizes in HTML-print fixed
* FB-17760: Synchronize calculated fields descriptions in the Designer
* FB-17759: Fixed rendering HTML report parts
* FB-17682: Added blank option to InTimePeriod values
* FB-17536: Fixed shift of plus symbol on collapsed grid rows
* FB-14714: Update calculated fields and filters automatically when Field Description is changed in the Viewer
* FB-14703: SMTP SSL support added to the Scheduler
* FB-16350: Fixed adding fields from the data source with join alias in the Viewer
* FB-16443: Always align report title, header, description and footer to the left in Excel output
* FB-17721: Implemented possibility to embed scripts in server response when using reportPart on HTML page
* FB-17710: Made highcharts stretching to the width of hosting container
* FB-17669: Filters functionality added to the HTML Report Parts
* FB-15672: Numerous javascript fixes
* FB-17701: Fixed crash of summary report with subtotals when VG style is set to VGHierarchy.
* FB-17729: Fixed possible out of range error when copying rows between tables.
* FB-17542: Fixed dynamic filters with HTML markup in values
* FB-17669: Fixed subtotals calculation of non-numeric fields
* FB-17709: Fixed report deletion on the Report List page
* FB-17702: Insert Quick Add fields below all selected fields
* FB-13700: Added 'X' to report list search
* FB-17644: Fixed issues on IR page
* FB-15815: Fixed show thumbnails of the visualization (Auto Chart, Sunburst).
* FB-15895: Headers style changed
* FB-15501: Changed position of the legend of the "Combo" visualization.
* FB-15118: Fixed missing form on first reportset save operation
* FB-17475: Fixed issue with pivots and FusionDriverMySql+MsSqlConnection
* FB-17460: Fixed issue with pivots when FusionDriver is used
* FB-16405: Fixed losing pivots when INFO logging level enabled and subtotals enabled.
* FB-16439: Autocharts fixed with pivoted source
* FB-15157: Copy resources to DLL
* FB-17654: Fixed filters values update in the Viewer
* FB-17594: Correct hiding fields and filters columns in Viewer
* FB-16350: Show data sources join aliases in the Viewer.
* FB-15157: Fix issue with modifying existing field
* FB-15746: Do not modify aggregate function when Total field property is changed in the Viewer
* FB-15157: Numerous fixes and performance upgrades
* FB-16090: Properly sort fields list at the Viewer Fields tab
* FB-17483: Fixed several issues relating to hidden fields.
* FB-15684: Show Vis documentation if Vis is failed to render
* FB-17518: Fixed  Field-Value grids PDF printing
* FB-17558: Fixed data extraction when AdHocSettings.CacheQueries is false
* FB-17503: Fixed report Title in the Viewer
* FB-16189: Reload some settings when lic key is changed
* FB-16255: Fixed reports with hidden fields formatting

# 6.8.0.2 (November 25, 2014)

**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**
 
* FB-10702: Language Pack GUI Updated
* FB-13603: Disable VG automatically if report contain Form
* FB-14598: Implemented support of multiple drilldown keys in reportset
* FB-14969: Encode HTML in inputs on misc tab
* FB-14976: Added auto refresh functionality in viewers
* FB-15075: Added sub report filter control from master report
* FB-15077: Added multi line header and width field properties
* FB-15164: Hide Summary with Title if there are no summary rows on the current page is pagination is used
* FB-15300: Fixed Instant Report schema loading when HiddenColumns setting isused
* FB-15320: Legend disabled for piecharts with separator
* FB-15322: Fixed gauge color styling
* FB-15471: Implemented confirmation of saving reportset which was modified onserver side by other user
* FB-15556: Increased subtotals calculation performance when VG is used
* FB-15579: Fixed slowdown caused by Preview button handling in IE8
* FB-15623: Support Stored Procedures in BulkCSV output
* FB-15624: Send all scheduled emails using single SmtpClient
* FB-15631: Scheduler for Dashboards implemented
* FB-15671: FORMS - Default adjusted to x
* FB-15686: Fixed broken Save button in dashboard preview, made join aliases hiddable, fixed in highcharts error related to overflowing number of styles in IE8
* FB-15708: Use AdHocSettings.Culture to format Date values in filters description
* FB-15716: Fixed js exception in animated gauges
* FB-15737: Fixed missing datetime stamp in excel/word export
* FB-15776: Disable filters inputs when loading
* FB-15782: Fixed overlapping labels in pie charts
* FB-15784: Report List page - show message when no reports found
* FB-15794: Fixed slowdown when adding many fields through QuickAdd
* FB-15801: Fixed axis labels on the Linear Gauge
* FB-15804: Fixed subtotals when single SP is used as a data source
* FB-15864: Removed hidden filter fields from fieldlist while viewing
* FB-15876: Removed redundant report refreshes in the Viewer
* FB-15877: Format labels and tooltip values in Combo Chart
* FB-15883: Fixed issue with HTML Footer in HTML2PDF print
* FB-15889: Properly sort DateTime values on the client if format is not specified
* FB-15896: Updated Waterfall/Doc.html preview to show the preview image afterclicking the help box on the report designer.
* FB-15900: Removed onhover checkboxes from InstantReport page. Also removed old data-sources.css from Resources/css folder.
* FB-15922: Fixed css for instant report table
* FB-15949: Properly apply Value format in the Dundas Pie chart when "Show percentage" is checked
* FB-15953: Adjusted the settings tabs to make them more responsive to UI changes.Added missing separators to the toolbar menu to make the UI more consistent.
* FB-15981: Improved locating of Vis folder in site folders tree
* FB-15983: Altered css to fix thumbnail API defect
* FB-15984: Enhanced security in Dashboards
* FB-16015: Fixed responsiveness in Pie and Funnel charts
* FB-16032: Subtotals added to BulkCSV export
* FB-16037: Properly sort results from the SP in a simple mode
* FB-16039: Show Loading message in Filters/Fields tabs during initialization
* FB-16050: Show only valid to join data sources sets in the Recent Data Sources list
* FB-16052: Fixed report export after exporting to Bulk CSV
* FB-16079: Optimized query Cache for all SQL requests
* FB-16105: Removed duplicate Report List javascript reference
* FB-16122: Fixed apostrophes in fields aliases
* FB-16123: fixed world tour animation pathing
* FB-16135: Fixed VG and Pivots when AdHocSettings.ExpandVisualGroupGrids is false
* FB-16137: Fixed Gauges in reports with pagination
* FB-16145: Fixed Pivot columns Advanced Properties
* FB-16162: Fixed Forms reports rendering when filter operators with no valuesareused
* FB-16194: Apply Field Description to the corresponding Filter in the filtersdescription
* FB-16200: Fixed Count Distinct function in Maps
* FB-16201: Adjust Charts height in Excel export
* FB-16210: Do not try to create clustered index on IzendaAdHocReports table if index already exists
* FB-16226: Allow for data sources to be in multiple categories in the Designer
* FB-16243: Refresh report Thumbnail with every save
* FB-16253: Summary title now wraps around if too long
* FB-16254: Fixed emails from the client Subject text encoding
* FB-16297: Fixed resources folder location when dll works in offline mode
* FB-16317: Combine Bottom option fixed for piechart with separator
* FB-16320: Bread crumbs alignment improvement in the Heatmap vis
* FB-16360: Added intelligently forced disabling value labels on trend High Charts
* FB-16372: Fixed Stored Procedures without available columns serialization
* FB-16377: Use appropriate Parameters types for Ansi and Unicode strings
* FB-16445: Fixed crash on second reportset viewing

* HF-15686: Fixed adhoc failure when query caching is disabled

# 6.8.0.1 (October 31, 2014)

**[Important Update Notes for 6.8](http://wiki.izenda.us/How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL)**

##Features: 
* FB-13936: Pure HTML Report Parts
* FB-14462: Responsive Grids - Refactored tables to diplay data responsively for smaller screens
* FB-14865: Vision - Visualizations are a D3-based visual supplement to Izenda’s core charting engine

##Enhancements: 
* FB-13393: JQuery version Upgrade and move of jquery into /resources/js
* FB-13872: Simplified Expressions - supports statements with/out parenthesis
* FB-13982: Secondary Drill Down Keys
* FB-14227: Date picker localization 
* FB-14383: Extraction of CSS/JS/Images from DLL
* FB-14488: Navigation, Toolbar and Breadcrumb Responsive 
* FB-14548: Jquery namespace change from $ to jq$
* FB-14898: Optimize PostProcessEqualsSelectList
* FB-15057: Multiple Self Join Alias Support /Displaying the values of multiple datasources

##Fixes: 
* FB-13282:  Fix subtotals order in Forms
* FB-13557:  Optimize bulk CSV streaming operation
* FB-13847:  Avoid truncation of datasource names 
* FB-14216:  Separate Null and Empty String values if both are presented in the data set.
* FB-14219:  Smoothly cut long labels in the Funnel chart
* FB-14310:  Optimized reportParts with htmlCharts
* FB-14448:  Removed overlapping of breadcrumb and field with metric selector
* FB-14528:  BreakPage property added to the Field advanced properties
* FB-14601:  Fixed unexpected increasing chart height
* FB-14715:  Fixed highcharts legend cut off when chart is exported
* FB-14780:  Hide Fields tab in the Viewer for View Only reports
* FB-14836:  Added support Equals(Field) filters in the Viewer
* FB-14870:  Fixed Auto Chart not working on IE8
* FB-14937:  Apply DIV/0 formatter if there is a division operation in Expression
* FB-14942:  Fixed subtotals calculation if arithmetic is used
* FB-15068:  Fix phantom "Summary" and "Detail" creation for new dashboards.
* FB-15070:  Fixed broken gauge subreports
* FB-15081:  Fixed several issues related to gauge hover subreports
* FB-15097:  Use CurrentThread.CurrentUICulture to format dates
* FB-15103:  Fixed broken legends in piechart
* FB-15115:  Fixed rendering of Pie/Doughnuts charts with Separator
* FB-15148:  Made reportset created/modified dates to be correct in logs
* FB-15160:  Fixed sorted grid columns export
* FB-15165:  Fixed missing styles in report viewer, not-working styles application to sample grid
* FB-15169:  Made page numbers disabled by default
* FB-15176:  Fixed VisibleDataSources saving form the Settings page
* FB-15238:  Removed unnecessary changing of chart type, added storing of legend data while changing of chart type
* FB-15276:  Use LEFT join if it is available in auto-join algorithm
* FB-15280:  Do not add redundant ddk filters to automatic subreport
* FB-15288:  Fields responsive design in the Viewer and InstantReport page
* FB-15304:  Fixed Group(Week) format in charts
* FB-15322:  Style tab header color only applies to all guages
* FB-15326:  Fixed erroneous adding to grouping of field with expression which effectively doesn't present in report
* FB-15344:  Made simple databaseSchema (de)serialize optimization
* FB-15351:  Populate correct ReportInfo.OwnerName in FilteredListReports method
* FB-15370:  Added line-polar and spline-polar chart types
* FB-15377:  Fixed pagination when SP is used as a data source
* FB-15379:  Fixed issues with downloading data when authentication is used on the site
* FB-15383:  Fixed Filter Logic in the classic ReportViewer
* FB-15390:  Additional pagination controls implemented
* FB-15398:  Added message about forcibly fields reordering
* FB-15405:  Implemented datasource alias support in reportviewer
* FB-15472:  Fixed behavior when Total is checked in report viewer.
* FB-15482:  Fixed hidden filters when fusion is used.
* FB-15488:  UseReportID affects subreport references on fields and TargetReport property in ReportSet
* FB-15529:  Fixed client side alphanumeric sorting
* FB-15547:  Fixed Report saving and report name titles in Viewer and Designer when ReportID is used
* FB-15550:  Fixed formatting in csv output generator after 10000-th line
* FB-15566:  Fixed erroneous write to log
* FB-15584:  Allow to close image modal dialog when image is invalid
* FB-15586:  Trimmed description to avoid undefined exporting behavior
* FB-15625:  ReportScripting.js in FromDLL directory updated
* FB-15652:  Do not attach volatile Form to the random reports
* FB-15657:  Implemented simple form designer for elrte-incompatible browsers
* FB-15685:  Fixed JS error in IE8
* FB-15686:  Fixed numeric formats in Chart Labels
* FB-15699:  Fixed js error on hover item in Timelime chart
* FB-15700:  Fixed out of memory exception in gauges
* FB-15704:  Fixed scheduled reports sending to many recipients
* FB-15715:  Added indexes to the reports table
* FB-15725:  Fixed required parameters filters for operators without value in the Viewer
* FB-15733:  Removed unnecessary resources from outside of dll
* FB-15750:  Changed AdHocSettings.ShowTableNames setting behavior
* FB-15753:  Implemented ExtendedFunctions support in expressions
* FB-15753:  Fixed issue with ExtendedFunctions and refactored Fusion
* FB-15760:  Fixed issues with dup fields in reportViewer
* FB-15762:  Fixed animated gauges in reportparts
* FB-15797:  Fixed issues with Time Slider
* FB-15801:  Fixed axis labels on the Linear Gauge
* FB-15823:  Fixed auto-complete filters in the Viewer
* FB-15851:  Fixed simple-mode filters for Dashboards
* FB-15852:  UI improvements on the Instant Report page
* FB-15853:  Update to allow modification of resources in English
* FB-15857:  Fixed date filters when Thread Culture is not default en-US
* FB-15858:  Removed all RTF funcationality
* FB-15859:  Call PreExecuteReportSet and PostExecuteReportSet when exporting to Bulk CSV
* FB-15887:  Fixed Edit/View controls on the Dashboards page when saving new report
* FB-15913:  Export to PDF now uses currently selected breadcrumb node to render the report
* FB-15949:  Fixed Chart formatting
* FB-15955:  Do not show Edit and Delete buttons in the Report List when ShowDesignLinks setting is false
* FB-15975:  Fixed stored procedures interaction with fusiondriver
* FB-15990:  Fixed automatic subreports in Gauges
* FB-16020:  Fixed "Zoom To Data" property of the Map
* FB-16064:  Fixed inputs justification
* FB-16077:  Apply "require filter value" rules to Stored Procedure Parameters