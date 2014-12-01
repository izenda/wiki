[[_TOC_]]

# 6.8.0.2 (November 25, 2014)
 
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



# 6.7.0.276 (August 22, 2014)
* FB-14154: added formatting to bulk csv exports (**Backwards Compatibility Enhanced in 6.7.0.277 --> September 4, 2014**)
* FB-15101: Fixed calculated fields filters for DateTime columns
* FB-15184: Improved auto-join algorithm when LEFT joins are used
* FB-15222: Fixed all gauges crash caused by malformed highlight value
* FB-15193: Added possibility to specify log4net config file
* FB-14683: Fixed gauges hover autodrilldown report
* FB-15007: Fixed SP Parameters filters in Dashboards
* FB-14131: Fixed conversion of week day number to week day name for case of mysql DB
* FB-15240: Async Thumbnails generation upon report save implemented
* FB-14832: ExportEncoding setting added
* FB-14527: Properly populate values for the Equals(Select) filters for SP fields
* FB-14842: Do not treat ReportSet as Analysis Grid report unless Detail Report has VG specified
* FB-14232: 3D option for html pie chart hidden
* FB-15037: Added restriction to chart scale value.
* FB-13726: Fixed issues with SP with fusion driver

# 6.7.0.275 (August 12, 2014)
* FB-15034: Fixed drill-down style auto selection in the Advanced field properties
* FB-14792: Fixed bar chart sort with separator
* FB-14723: Fixed Inverted grid export to CSV
* FB-13360: Color highlighting and Value ranges applying to DateTime fields
* FB-15152: Fixed CHart to Picture rendering issue with scroll-bar
* FB-14131: Fixed day of week number, and daysOld function
* FB-14355: Lazy SP metadata pulling
* FB-15069: Fixed footer position processing in html2pdf generator
* FB-15082: Made it possible to override default sql and oracle dataextractors behavior
* FB-15106: Made scale working together with separator for pie charts
* FB-15103: Fixed combine bottom feature for highchart pie chart
* FB-15070: Fixed popup recursion for gauges
* FB-15080: Fixed missing gauge needles in subreport
* FB-15120: Fixed HTML Pie Chart with Separator
* FB-14996: Do not use simple SP execution mode is Records count is specified
* FB-15004: Fixed erroneous chart container height
* FB-14487: Fixed Date columns Equals(Field) filter operator
* FB-15035: Disable redundant aggregate functions for Boolean data type
* FB-14781: Fixed auto-grouping from Expression in Oracle
* FB-15004: Fixed piechart legend overlapping
* FB-14951: userid info added to Message in log.
* FB-14227: Fully localized DatePicker
* FB-14315: Fix js errors for PieChart.
* FB-14488: Optimize Report Viewer tab for narrow screens
* FB-15028: Made reportset renderer to respect changes of reportset.Style in PERS

# 6.7.0.274 (July 30, 2014)
* FB-14902: Fixed XSS security vulnerability in Designer
* FB-14315: Fix pie chart "Combine Bottom" for charts with separator.
* FB-14973: Fixed JS error on reportDesigner page.

# 6.7.0.273 (July 28, 2014)
* FB-13872: Improving CASE statements usage to use it without brackets
* FB-14906: Made click on legend affecting all stacked pie charts
* FB-14669: Filter SQL load report request by current TenantID
* FB-14948: Fixed erroneous adding field from expression to grouping
* FB-14949: Fixed filters without values in the Viewer
* FB-14791: Extended palette of barchart colors.
* FB-13936: Added HTML Report Part control
* FB-14622: Made different users having separate files for databaseSchema cache on HDD if PerUserCaching is true
* FB-14908: Fixed broken stored procedure metadata save to izenda.config
* FB-14756: Fixed grouping by week
* FB-14805: Update report in reports list cache on save.
* FB-13119: Fixed Pagination in Oracle when Sort is used

# 6.7.0.272 (July 15, 2014)
* FB-14548: Unified internal references to jquery as alias jq
* FB-14813: Minor fixes in Designer UI CSS classes added to some controls in the Designer for easier customization
* FB-13982: Implemented ability to utilize multiple or alternate DrillDown keys for sub-reports.
* FB-14224: Columns Width property added to the Report
* FB-14309: Fixed Y-Axis rounding for bar and trend chart. There was wrong values when selected value format "0,000".
* FB-13449: Fixed incorrect CSV export reports with several embedded sub-reports
* FB-14674: Improved reliability of bulkCsv export
* FB-14546: Fixed issues with table borders in XLS and DOC exports
* FB-14725: Enable CSV export for Dashboards

# 6.7.0.271 (July 7, 2014)
* FB-14428: Made stacked pie chart really stacked
* FB-14712: Fixed Legend and Stacked Chart properties auto-selection
* FB-14131: Fixed number of first week in year in mysql DB
* FB-14711: Fixed issues with drill-down reports in HTML Bar Chart caused by FB-14265
* FB-14427: Fixed labels positioning in highchart piecharts with separator
* FB-14396: Fixed not showing highcharts in pdf export due to missing scripts
* FB-14392: Fixed wide charts cutoff in export to word/excel
* FB-14053: FieldCollection getter by column name implemented
* FB-14710: Providing backward compatibility in behavior of ConnectionOpened
* FB-14710: Turned back lost virtual method
* FB-14429: Made charts 100% wide in pdf export
* FB-14623: Improved automatically page breaks in PDF print when Multi Level VG style is used
* FB-14561: Added possibility for easy pagination controls customization
* FB-14603: Fixed calculated fields filters if LEFT JOIN is used
* FB-13988: Fixed Gauges drill-down reports
* FB-14308: Fixed Stored Procedures with a schema name part adding
* FB-13916: Added VisibleDataSources multiple schemes support for Oracle connections

# 6.7.0.270 (June 26, 2014)
* FB-14141: Fixed 'Year and Quarter' function in MySQL Driver
* FB-14628: Show charts indexes in the "Report order" section
* FB-14403: Fixed conflicts between several changes in the Expression behavior
* FB-14467: Boolean operators support added to the Expression feature

# 6.7.0.269 (June 23, 2014)
* FB-14182: Added possibility to use XML format in scheduler
* FB-14430: Fixed dashboard crash when report is modified before save
* FB-14520: Fixed DIV/0 formatting when OData connection is used
* FB-13768: Fixed Filters and Fields adding in IE8
* FB-14486: Fixed report crash when tenantField is specified without any tenants
* FB-14294: Allow to remove all fields from the report in the Viewer
* FB-14296: Fixed filters on the Dashboards page
* FB-14328: Fixed erroneous removal field from "to be grouped" collection if it has itself in expression, and aggregate function is selected
* FB-13937: API INFO logging implementation
* FB-14361: Fixed Line HTML Chart export (Trend chart and Pareto Bar chart)
* FB-14336: Fixed missing SqlOverride value in filters when ExistentValuesList for operators like Equals(Select) is generated with taking into account previous filters
* FB-13449: Improve embedded sub-reports and column grouping/pivots support in the CSV output
* FB-13739: Added information about records amount in dataset which is returned by GetDataSet, to log at INFO level
* FB-14377: Do not crop data labels on the HTML Trend chart
* FB-14217: Fixed filters on calculated columns in the Viewer
* FB-14257: Replace spaces with underscores in the XML output
* FB-14366: Export only Detail and Summary parts to CSV instead of throwing exception if other parts contains in the ReportSet
* FB-14370: Added a setting to configure hard-drive cache location
* FB-14337: Fixed count of the Share With drop-downs in Report and Dashboard Designers
* FB-14265: Made text truncated and last few letters fade to white if label is too long and text orientation is vertical
* FB-14321: Fixed issue with license key when StaticSharedStorage is used
* FB-14145: Do not attach ColumnGroup to the Field Description in the Report Viewer

# 6.7.0.268 (June 4, 2014)
* FB-13960: Fixed issue with displaying base64-encoded images
* FB-14116: Fixed enable/disable subtotal logic in the Viewer
* FB-14089: Allow to use arithmetic "-" operator with Date data type fields
* FB-14285: Do not use Viewer browser dimensions in the Preview render
* FB-14112: Fixed "Field-Value column pairs" feature behavior in Dashboards
* FB-14221: Allow to use special characters(backslash, single/double quote, etc.) in the Chart a titles
* FB-14101: Fixed images rendering in PDF output if the client browser is IE8
* FB-14237: Fixed issue with adding new filters after removing some filters in the Viewer
* FB-14170: Hide/Show Advanced properties of the Charts when it's needed
* FB-13811: Implemented value ranges feature for chart separator

# 6.7.0.267 (May 30, 2014)
* FB-14250: Fixed CROSS join
* FB-14236: Fixed cascade filters update when filter values are changing rapidly.
* FB-14215: Fixed error after filter removal when filter logic is used.
* FB-13986: Fix color setting (#RRGGBB) for gauges.
* FB-14148: Fixed numerous issues with HTML Charts exporting and Viewing.
* FB-14108: Do not include HTML tags in CSV export.
* FB-13539: Implemented Auto 'Group' support for all other aggregate functions also.
* FB-14121: Preview container now appear only on Preview tab in report designer
* FB-14118: Fixed CSV export failure when data contains double quotes
* FB-13766: Enable datepicker for non-English cultures
* FB-13765: Fix rounding in the Animated Half Circle Gauges.
* FB-14144: Prevented erroneous grouping by fields from expression if no aggregation is involved in report.
* FB-13600: Made fields with expression not affect grouping.
* FB-14121: Enable caching of visualization files
* FB-14140: Fix Chart appearance on 'hover' when master report is not saved.
* FB-13539: Made fields from expressions automatically added to group by clause if needed.
* FB-14046: Properly apply Drill-Down filter if both master report and sub report have Between filter on the same field as a Drill-Down Key.
* FB-13557: Made bulk csv output generator to stream date from DB to client
* FB-13889: Switched CacheReports default value to true
* FB-13762: Fix formatting when VG, Pagination and Subtotals are used at the same time.
* FB-14113: Do not show 'null' for empty regions on the Map if hover sub-report is used.
* FB-14108: Do not include HTML tags in CSV export.
* FB-13978: Loggers conflict fixed
* FB-13889: Optimized reports table existence checks.
* FB-13372: Disable "Show Legend" check-box if Separator is not selected.
* FB-13971: Respect "Records" value when calculating subtotals.
* FB-13762: Fix formatting when pagination is used with VG.
* FB-14062: Fix Tennessee short name on the USA map.
* FB-13940: Do not copy embedded resources in the Scheduler output.
* FB-13834: Allow to use multiple-value filters for storage procedure fields
* FB-14037: Prevent throwing exception when same name is found several times in the AdHocSettings.VisibleDataSources collection.
* FB-13954: Fix issue with reports storage in the DB after invalidating reports cache.
* FB-13941: Fixed erroneous brackets removal from field description when they are specified in field alias.
* FB-13713: Made fields/filters against HiddenColumns invisible in reportViewer.
* FB-13946: Fix filters inheritance in sub-reports when filters on calculated columns are used.
* FB-13967: Removed unused button for toolbar
* FB-13950: Made all connections/dataReaders always reliably disposed, made every dataReader use separate connection object, fixed throwing exceptions in ReportClearTemplateName
* FB-13950: Ensured that all connections which are opened in DLL are always reliably closed after usage
* FB-13950: Ensured that each reader uses individual connection object, and that that connection is closed after reader is closed .
* FB-13950: Removed unnecessary connection closings
* FB-13950: Ensuring that every datareader closes connection when it finishes work
* FB-13950: Enclosed all datareaders in using()
* FB-13967: Removed unused button for toolbar
* FB-13950: Fix of System.Exception: ReportName property unknown. and System.Exception: ReportCategory property unknown. errors
* FB-13857: Fixed high charts with '%' value format
* FB-13947: Implement drill-down reports in HTML Bar Charts.
* FB-13938: Fixed stored procedures serialization/deserialization error

# 6.7.0.266 (May 7, 2014)
* FB-13933: API error level logging implemented
* FB-13915: Fix issues with Form loading in the Designer caused by the changes in FB-13523
* FB-13715: Allow to export reports to RTF with a single VG field
* FB-13689: Avoid crash if iTextSharp DLL isn't present
* FB-13587: Data Access Layer INFO logging implemented
* FB-13846: Fixed "index out of range exception" for pie chart with 0 values
* FB-13484 Map tab country/state label updates correctly
* FB-13414 Add switching back to simple data source mode
* FB-13885: Fixed crash when switching filter operator from Between to InTimePeriod
* FB-13755: Changed pagination to entering record number
* FB-13718: Made reports with pagination return ExportLimit reports when printing to HTML
* FB-13530: Filter description behavior fix in reportViewer UI
* FB-13826: Fixed crashing pie chart in reportPart window when hovering mouse over it

# 6.7.0.265 (May 1, 2014)
* FB-13532: Fix date-picker if cascade filters values load too slowly
* FB-13613: Do not use pagination in Viewer if Analysis Grid or Visual Group Hierarchy is used
* FB-13725: Apply Filter Logic to the Pivots sub-queries
* FB-13792: Added separator titles for pie chart
* FB-13760: Fix Between Filter Operator for calculated columns
* FB-13745: Use images URLs instead of base-64 data in IE8
* FB-13587: Added creation of default log4net configuration file
* FB-13523: Forms data now loads for every report individually only at the moment of its execution, and doesn't load during just opening reportList
* FB-13361: Apply AdHocSettings.CurrentUserTenantId filter to the list reports SQL if DatabaseAdHocConfig is used
* FB-13467: Optimization of initialization-related routines and CheckLimitation() calls
* FB-13282: Attach subtotals to the Form report in order
* FB-13675: Fixed thumbnails generation in case of Dashboard reports
* FB-11797: Fixed out of memory exception caused by many simultaneous thumbnail generation threads, by introducing queue for thumbnails generation
* FB-13640: return default button returns default now
* FB-13746: Fixed loss of NOT flag in filter properties during manipulations from modern reportViewer
* FB-13659: Added missing css to reportViewer
* FB-13723: Added hiding Visualizations if no visualizations were found
* FB-13263: Fix asynchronous loading of the ReportPart controls.
* FB-13414: add switching to simple mode for datasources tab
* FB-13526: the auto-selection in indicator bar is disabled
* FB-13711: Auto refresh Quick Add dialog until fields list is populated
* FB-13730: Fix HTML Charts exporting to RTF when ReportSet has category
* FB-13715: Show error text in the output body instead of throwing exception if there is an error during Chart rendering in RTF export
* FB-13691: Fix Embedded subreports filters inheritance
* FB-13687: Changed log4net configuration file to log4net.xml
* FB-13706: Fix drill-down subreports when special characters are used as a drill-down key values
* FB-13679: Added the ability to process HTTP POST Requests in OData Fusion Connection.
* FB-13683: Implemented percent symbol escaping in filter value when LIKE is applied to filter value in sql query
* FB-13547: Behavior fix - made ItemsPerPage to be ignored if UsePagination is disabled
* FB-13661: Fixed bug in datasources joining when switching in reportDesigner from simple to advanced mode
* FB-13639: AdHocSettings.EmptyReportString setting added, this setting can be used to configure the message shown when reports return an empty result
* FB-13674: Fixing HintPath for log4net dll in AdHoc2012.csproj
* FB-13687: Logging @ERROR level for Data Access Layer
* FB-13665: Made FusionCache taking into account .SqlOverride members of Filter/Field during cache key calculation
* FB-13587: log4net infrastructure, and data access layer@ERROR level logging implemented
* FB-13646: Implemented drill-down subreports in Detail report when rendered in ReportPart
* FB-13634: Prevent showing all Filters (even with Parameter = false) in the Report Viewer when any filter is removed
* FB-13449: Implemented limited support of embedded subreports in csv output generator

# 6.7.0.264 (April 14, 2014)
* FB-13579: Disable toolbar if no datasources are selected
* FB-13592: Improved combine bottom mechanism for Pie chart
* FB-13345: Fix issues with custom category separator - AdHocSettings.CategoryCharacter
* FB-13590: Allow to use Formats in Charts for Date and DateTime fields + allow to use custom formats
* FB-13582: Fixed glitch in code which spontaneously could cause exception inside cycle, and as a hence early exit from cycle, which led to missing custom DashboardFilters control in Dashboards page, though all conditions are met.
* FB-13535: Fixed error which was caused by application of aggregate function in Gauge to Label column independently on presence/absence of aggregate function in Value column in case when calculated field from Fields report is selected in Value column
* FB-13450: Show Print buttons in Dashboard designer
* FB-13382: Made calculated field description appearing in bar chart legends
* FB-13305: Fixed map-related part of reportSet validation to restore correct Preview availability behavior
* FB-13546: Solve issues with Title and Description in the CSV output
* FB-13556: Allow editing Label Justification in the newly created report
* FB-13413: Limited stored procedures returned by FusionDriver by only those which are enlisted in VisibleDatasources, in the same way like it works now in usual drivers
* FB-13517: Show All available filter operators if type of the column is unknown.
* FB-13561: Copy all Filter properties (Like Operator, OrIsBlank, etc.) from the master-report to the sub-report in Forms
* FB-13329: Improved custom color setting for highcharts
* FB-13486: Added data source categories sort for instant report page.
* FB-13515: Fixed problems with changing between Calendar to other date filter types in reportViewer
* FB-13532: Hide Datepicker dialog when filtering on refresh so there are no conflicts between the old and new dialog
* FB-13386: Fixed browser slowdowns by fixing in JS code calendar z-order at the moment of its appearing, instead of repeating calls of function which did the same
* FB-13291: Fixed report title and description not showing when part param exists
* FB-13504: Fix wrong colors for stacked bar chart
* FB-13483: Removed obsolete attribute from ShowSqlOutputButton setings
* FB-12823: Add ability to control Filter dropdown content on a per-column basis
* FB-13329: Add ability to set custom colors for all html chart types
* FB-13439: Keep scroll position in the Equals(Checkboxes) filter when filters are refreshed. Do not send ajax redundant calls for the last or single filter in the Report Viewer
* FB-13507: ListReports cache implementation
* Revert "FB-13269: Prevented showing report data without required filters values specified by user"

# 6.7.0.263 (April 7, 2014)
* FB-13494: Fix jQuery conflicts in the classic Asp.Net interface
* FB-13490: Show "[FieldName] not found" text instead of exception when invalid field is used in the report Title, Description or Footer
* FB-13459: Fix Map image file URL in HTTPS deployments
* FB-13482: Made modern reportList respect setting AllowDeletingReports
* FB-13003: Changes made in PerformCustomReportRendering were missed in html cache. Fixed by correcting order of PerformCustomReportRendering and caching calls
* FB-13444: Enable Autocomplete filter in the HTML Report Viewer
* FB-13408: Apply format of the same field from the Fields to the appropriate date value in filter description.
* FB-13269: Prevented showing report data without required filters values specified by user
* FB-13277: Fix filters refreshing on the Dashboards page in IE11
* FB-13232: Fix Issue with Parameters on the Dashboards page by adding support for POST requests
* FB-13223: Made modern reportViewer respect LockViewer setting
* FB-13435: Fix typo in the ReportList without thumbnails. Change title of the "X" icon from "Edit" to "Remove"
* FB-13432: Fix issues with Summary report when pagination is used
* FB-13411: Fixed brackets escaping in Fields expressions
* FB-13430: Fixed printing reports with highcharts to HTML by switching highcharts rendering to images when printing report to html
* FB-13268: Implementation of adding new filter in modern reportViewer.
* FB-13382: Fix calculated columns (when Arithmetic is used) in Charts.
* FB-13410: Fix artifacts in the Dashboard PDF output is if report with a large number of rows is presented in the Dashboard
* FB-13309: Apply AdHocSettings.FieldAliases to all controls on the Report Viewer page.
* FB-13404: Fix CSV export if Value Ranges is used and Add Subtotals is checked
* FB-13309: Apply AdHocSettings.FieldAliases to all controls on the Report Viewer page
* FB-13381: Fix javascript errors when Equals(Popup) or Equals(Checkboxes) filter is used
* FB-13273: Implementation of FormRenderer compatibility with visualizations like highcharts which render html/js into report body
* FB-10401: Resolved issue where when using multiple datasources all the fields are not immediately available
* FB-13277: Improve toolbar UI on the Dashboards page for narrow screens
* FB-13368: Fix Funnel HTML chart when data in the Label column contain single quotes
* FB-13255: Added function filtering for column dropdowns in the maps tab
* FB-11581: Updated AddForcedLeftJoin method to be capable of usage with custom DB schema. This will allow this feature to work correctly with tables that are not in the "dbo" schema
* FB-13329: Added customization variable for htmlchart barchart colors
* FB-13119: Fixed pagination problems with Oracle
* FB-13240: Added meta tags to force WebBrowser to work in proper (IE9/10/11) mode to resolve issues with chart rendering
* FB-12908: Fix issues with loading Form if ReportSet.OwnerTenantID and AdHocSettings.CurrentUserTenantId do not match
* FB-13290: Manually create HttpContext if it is not initialized and activate StaticSharedStorage in this case. As a result many Izenda functions can be used in the "offline" mode
* FB-13305: Fix drill-down on the World Map for the USA and UK countries

# 6.7.0.262 (Mar 25, 2014)
* FB-13006: Use a filestream to write thumbnail data to improve error reporting when permissions are not set correctly
* FB-13282: Apply AdHocSettings.TenantField filter to the request for the Equals(Select) filter.
* FB-13166: Added support of the MSSQL CASE-WHEN-ELSE-END clause in the Expressions.
* FB-13240: Add trim() function to javascript output used by highcharts
* FB-13267: Fix Equals(Checkboxes) and Equals(Multiple) filters behavior in the Report Viewer. It was impossible to check/select value if it is a single digit or single char
* FB-13223: Prevented PIVOT tabs from showing in ReportViewer if reportSet is Locked
* FB-13193: Fix filter logic when hidden filters are used
* FB-13139: Add basic cache usage statistics for static memory mode
* FB-13017: Significantly increase performance in paginated reports with many rows of data (10k+)
* FB-13243: Fix Inverted Grid CSS so it stays up-to-date when modified in the Designer and refreshed in the Viewer
* FB-13240: Provide separate rendering path for exporting when using HtmlCharts charting engine
* FB-13237: Fixed rendering of gauges in thumbnails to include the needle
* FB-13028: Use POST parameters when loading ReportParts
* FB-13119: Fix Text Highlight and Cell Highlight in the paginated report

# 6.7.0.261 (Mar 17, 2014)
* FB-12970: Removed unnecessary ActivateNewDashboardViewerControls() calls from reportViewer
* FB-13193: Fixed problems with previewing reports after modifying Filter Logic
* FB-13106: Resolved issue where tabs were greyed out on the report designer page when VisibleDataSources have been changed

# 6.7.0.260 (Mar 16, 2014)
* FB-13177: Changed "Reset to default" button on Style tab in reportDesigner to standard button control which is used across all designers
* FB-13113: Fixed empty jquery formatNumber result for 0 value
* FB-13025: Resolved issue where HighCharts auto-sizing and auto-centering didn't work because chart as an inner element couldn't detect dimensions of outer container. Implemented support for specifying dimensions in pixels in chart property, so highcharts can rely on those values.
* FB-13181: Fixed inverted Summary grid styling. This makes styles for headers items and alts the same as the normal grid.
* FB-13189: Waiting timeout removed if renderer detects an error at the the beginning of rendering process
* FB-13113: Removed "default" series name in HtmlCharts if only one series has been selected
* FB-13180: Updated copyright in response server
* FB-13164: URL encode fields when updating field properties in report viewer
* FB-13160: Marked FilteredReportListCache as serializable
* FB-11598: Added fusion support for Postgres
* FB-12943: Add support to stored procedures for sql_variant data type as a parameter
* FB-11720: Fixed glitch in htmlcharts, which could result in generation of malformed JSON data
* FB-12970: Removed Templates (Forms), and custom entities from session in staticmemory mode. Basic report designing/viewing no longer stores anything in session
* FB-12970: Added support for logging session contents
* FB-13132: Changed formatting of dates (from filters values) in reportset description to respect AdHocSettings.Culture
* FB-13115: Resolved issue where thumbnails would remain in the "Generating" state
* FB-11684: Added disk/reports cache cleanup functionality to Driver.InvalidateSchemaCache()
* FB-13114: Resolved regression in AdHocSettings.ReloadStrings()
* FB-13081: Resolved redirect loop when AdHocUserKey is specified
* FB-13116: Fixed Equals(Popup) filter when one of the values is empty string. Empty string can now be selected as any other not empty value.
* FB-13103: Fixed "(blank)" value in the filters. "(blank)" value is now interpreted as NULL when selected for example in the Equals(Popup) or Equals(Checkboxes) filter.

# 6.7.0.259 (Mar 9, 2014)
* FB-13036: URL Encode '&' when processed in a drill-down value
* FB-13035: Fixed erroneous adding of excess parameter to SqlCommand when drilldown filter with equals operator presents in reportSet
* FB-13034: Fixed spontaneous loss of database connections
* FB-13026: Added currentUserName verification routine to CheckLimitations routine, to make pure html pages respect RequireLogin setting.
* FB-13012: Fixed unsafe operation on possible null string, which caused error in case of rendering gauges
* FB-12969: Optimized static memory mode to minimize whole memory usage by minimizing objects kept in session and resolved bugs related to CurrentReportSet in static memory mode
* FB-13042: Fix drill-downs with Dates and different grouping types. For example, correct value will be passes to the subreport if drill-down key is a Date field with Group(Year & MN) Function.
* FB-11707: Added LinkedColumns property for Filter and Filter ICloneable interface implementation.
* FB-12979: Default DataCacheInterval to 0 so the HTML cache is disabled by default
* FB-12957: Added additional PostgreSQL type mappings
* FB-12836: FusionConnections getter was made public

# 6.7.0.258 (Feb 27, 2014)
* FB-12933: Make Instant Reports respect AdHocSettings.HiddenColumns
* FB-11781: Fixed bug causing server resources to not be found in Instant Reports and Report Viewer
* FB-12919: Disable default selection of Separator dropdown
* FB-12914: Fixed style issue where custom grid styles subtotals did not apply border color
* FB-11792: Fixed bug affecting loading of ReportSets that could result in null pointer exceptions
* FB-12930: No longer require +HTMLCHARTS in license key to utilize HTML Charts
* FB-12901: Removed extraneous warning message from Dashboard Designer
* FB-12904: Fixed Between filter when values are numeric that can be parsed as dates
* FB-12912: Fixed problem where preview would cache dashboards
* FB-11692: Fixed automatic drilldown ReportSet issue "Report loading error: Report (AUTO) is not found" which impacted gauges in pure HTML
* FB-12834: Fixed "Response canceled: 500 Internal Server Error" when rendering HTML charts to RTF
* FB-12887: Fixed add report part to dashboard modal dialog
* FB-11697: Fixed "Page breaks after visual group" setting for pdf printing
* FB-11807: Enable output to CSV format for Visual Groups of the following styles: CommaDelimited, CommaDelimitedWithLabels, LineDelimited, LineDelimitedWithLabels
* FB-12843: Remove extra empty table after report content. Wrap report content in the extra table so all Reports in the ReportSet will have different and independent widths.
* FB-11792: Added support for arbitrary ordering of columns when executing report against a stored proc without "insert into exec"
* FB-11517: ReportSet.Owner property is changed according to the AdHocSettings.CurrentUserName when report saved using "Save As"

# 6.7.0.257 (Feb 22, 2014)
* FB-11687: Resolved issue with MVC4R2 Instant Reports where the field properties gear was not clickable
* FB-11691: Resolved issue where drop-down lists of equals multiple filters would jump to the top of the list when selecting values
* FB-11619: Added separator support for HTMLCHARTS pie chart
* FB-11621: Fixed chart parameters initialization and extended chart margins to full width
* FB-11621: Format htmlchart numbers from "0000" to "0,000"
* HTMLCHARTS: Fixed tooltip formatting on funnel charts
* HTMLCHARTS: Resolved issue where axis label was cut in half on line charts
* HTMLCHARTS: Fixed problem where pie chart 'CombineBottom%' would rename the smallest slice to 'Other' when it had not been combined with another slice
* HTMLCHARTS: Increased right and left margin for line, bar and area chart
* HTMLCHARTS: Changed top offset of gauges
* HTMLCHARTS: Resolved bug where the description of an applied filter was listed multiple times
* FB-11678: Fixed intermittent "Unable to connect to the remote server" scheduler error
* FB-11808: Changed styles of VisualGroups to make them bolder
* FB-11610: Added support for CustomizeChart to htmlCharts
* FB-11781: Fixed a problem where string filter values were misidentified as dates
* FB-11703: Fixed a bug which prevented switching the PDF outputGenerator to ITextSharp
* FB-11566: Fixed iframe ReportPart where an object reference was not being set to an instance of an object
* FB-11700: Update the user property when reports are saved
* FB-11710: Changed export to respect the formatting of datetime
* FB-11684: Changed rs.aspx?clear=1 to clear schema, fusion, and reports caches
* FB-11682: Resolved concurrency issues when caching reports on load balanced systems
* FB-11726: Fixed bug where "TimeClass" was erroneously shown as a filter description

# 6.7.0.256 (Feb 8, 2014)