#AdHocSettings

The ``AdHocSettings`` class contains all the settings Izenda uses to control various aspects of the interface and flow of data. Many of the more useful settings are explained in detail in our [[User Guides|/FAQ/UserGuides]] and [[Developer Guides|/Guides/Developer-Links-and-Guides]]. 

|Datatype|Setting name|Setting description|
|:-------|:----------:|:-----------------:|  
|   string|[[AddAllFilterRegex|/API/CodeSamples/AddAllFilterRegex]]|Gets or sets a regular expression to filter data source fields that can be added with the "Add All" button.|
|   Dictionary<string,double>|AdditionalTimeZones ||
|   AdHocConfig|[[AdHocConfig|/Integration/Tutorials/Customizing-Izenda-Settings]]|Gets or sets the current Ad Hoc configuration.|
|   string|[[AdHocUserKey|/API/CodeSamples/AdHocUserKey]]|Gets or sets the password limiting access to the report designer, report list, and report viewer. This is for projects that do not need multi-user security.|
|   AggregateFunctionCollection|AggregateFunctions||
|   bool|AllowAnalysisGrid|Gets or sets the value indicating whether it is allowed analysis grid. The option appears in the Visual Group Style combobox at the Style tab in the ReportDesigner.|
|   bool|AllowArchivedReportTableCreation|Gets or sets the value indicating whether it is allowed to create the database table that contains archived reports if there is no such table in the database. If set, AdHoc checks if table in database for keeping reportsets exists, and creates it if necessary.|
|   bool|AllowClientSorting||
|   bool|AllowComparativeArithmetic|Gets or sets the value indicating whether comparative arithmetic is allowed in arithmetic checkbox. Comparative operators appear in "A" checkboxes at the Fields tab in the ReportDesigner.|
|   bool|AllowCreateNewCategory|Gets or sets the value indicating the possibility to create new categories in Save As dialog in the ReportDesigner.|
|   bool|AllowDataFieldsInDescription|This checkbox enables/disables the ability to allow a data field to be used in the description of the report (which is set in the misc tab). This is particularly useful in drill down reports and those reports with filters. For example: Let's say we are filtering a report by the field CategoryName and the value Produce. For the Description we enter: [CategoryName] details. This will show on the report as Produce details and dynamically change when the user changes the filter value.|
|   bool|AllowDeletingReports|This checkbox enables/disables the delete icons at the report list page against reports names, for the current user. Clicking on the red x delete icon deletes the report.|
|   bool|AllowDeltas|Gets or sets the value indicating whether "Add Deltas" checkbox should be shown at the fields tab in the ReportDesigner. Any time there is a change in a quantity that change is calculated by taking the later value for that quantity and subtracting from it the earlier value for that quantity.|
|   bool|AllowDomainJoin|Gets or sets the value indicating that domain joins should be shown on the report designer. Domain join could be useful if you want to join tables on columns with web addresses. For example, if you set up Domain Join option columns with strings "http://www.yourdomain.com" and "www.yourdomain.com" will be equal.|
|   bool|AllowEqualsSelectForStoredProcedures|Gets or sets the value indicating is it allowed to use Equals(Select) or Equals(Multiple) for filters in case when stored procedure used. These options can be found in the Operator dropdown at the Filters tab in the ReportDesigner.|
|   bool|AllowFieldsAsValue|Gets or sets the value indicating whether field name is allowed in filter value. If set, values like "Is Less Than (Field)" appear in the Operator combobox at the Filters tab in the ReportDesigner. Fields comparison allows you to compare values from one field with values from another field.|
|   bool|AllowGroupWithoutSelect|Gets or sets value indicating if it is possible to make invisible fields which are used for Visual Grouping. If set, fields with both "Hide This Field" (in the advanced properties) and "VG"; flags set, will not lead to report being considered as invalid.|
|   bool|AllowHorizontalBarChart|Gets or sets the value indicating whether Horizontal Bar Chart is allowed. This defines if Horizontal checkbox will be available in the Advanced Properties at the Chart tab in the ReportDesigner, when Bar chart type is used.|
|   bool|AllowHtmlOutputsInScheduledReports||
|   bool|AllowInvalidCharacters|Gets or sets the value indicating whether invalid characters in report namesare allowed if not striped. If disabled, non-literal characters in the report name, entered in the Report Designer in Save As dialog, will cause error message during saving report. <br>*Note: Invalid characters will be automatically removed from the report name if [[StripInvalidCharacters]] set to true.*|
|   bool|AllowInvertedGrid|Allows the inverted checkbox to be shown in the Summary tab in the ReportDesigner. Inverted grid means it exchanges columns for rows (up to 36 rows)|
|   bool|AllowLineOnBar|Gets or sets the value indicating whether is it allowed line on Bar chart. If true, then Line Value feature is available at the Chart tab in the ReportDesigner, when Bar chart type is selected. Line can show additional values on the Bar chart.|
|   bool|AllowMultilineHeaders|Gets or sets whether headers in the grid report can be multi-line. This setting could be useful if you have many columns in the report or columns names are very long.|
|   bool|AllowNewFiltersInReportViewer|Gets or sets whether users have the ability to add new filters in the report viewer page of Izenda Reports. <br>*Note: Current filters used on the report will still be displayed.*|
|   bool|AllowOverwritingReports|This enables/disables the current user's ability to overwrite reports currently saved. An example of this usage is that many users create base reports for their users to use. Disabling the overwrite report feature ensures that the default reports are not tampered with.|
|   bool|AllowSelfJoin|Gets or sets the value indicating whether is it allowed datasources self join. If true and ShowDataSourcesAsCheckBoxes, then user can select the same data source twice and selfjoin it at the Data Sources tab in the ReportDesigner.|
|   bool|AllowStackedBarChart|Gets or sets the value indicating whether Stacked Bar Chart is allowed. This defines if Stacked checkbox will be available in the Advanced Properties at the Chart tab in the ReportDesigner, when Bar chart type is used.|
|   bool|AllowSummaryDeltas|Gets or sets the value indicating whether the "Show Summary Deltas" checkbox should be shown in the summary tab in the ReportDesigner. Any time there is a change in a quantity, that change is calculated by taking the later value for that quantity and subtracting from it the earlier value for that quantity. The AllowDeltas feature MUST be turned on to use this feature.|
|   bool|AllowVisualGroups||
|   string|ApplicationHeaderImageUrl|Gets or sets the URL of the Application Header Logo.|
|   bool|AutoJoinOnRenderedRows||
|   bool|AutoPostBackOnFilterChange|Gets or sets the value indicating whether should be postback on filter change. This affects behavior of ReportViewer when ShowFiltersInReportViewer is enabled, and user changes filters there. All changes will be applied immediately and report will be reloaded.|
|   bool|CacheEqualsSelect|Gets or sets the value indicating whether "Equals (Select)" value should be cached. Caching "Equals (Select)" can be useful if you have problems with performance in your data base or slow connection to it. But data in cache may be not relevant if it is updated very often in the data base. So, use this setting carefully.|
|   bool|CacheQueries|Gets or sets the value indicating whether all queries for the Driver should be cached.|
|   bool|CacheReports|Gets or sets the value indicating whether all loaded reports should be cached. This feature can be very useful if you have problems with performance in your database or connections are slow. Loaded ReportSet will be cached, so there will be no extra queries to the database. When you save the Reportset cache for it will be removed and it will be added again when ReportSet will be loaded again. Report caching may cause problems if you are running more than one instance of Izenda Adhoc with the same reports source (i.e. the same database and table or same reports folder).|
|   bool|CacheSchema|Gets or sets the value indicating whether DatabaseSchema should be cached. Disable schema caching may be useful if you data base schema changes very often. But ussually it is better to use caching because it will prevent extra queries to the data base.|
|   bool|CacheStoredProcedureMetaDataToDisk|Gets or sets the value indicating whether the information about stored procedures will be cached on the server's disk. Normally stored procedures are updated with the database schema. But if CacheStoredProcedureMetaDataToDisk is enabled, they will be stored in the Izenda.config file and will not be updated with the schema. Normally, you don't need to use stored procedure caching, so use this feature only when you have problems with performance while loading a large amount of stored procedures.|
|   bool|CascadeFilterValues|Gets or sets the value indicating whether filter values at the Filters tab in the ReportDesigner will be cascaded. For example, this will only show cities in the country selected on the prior filter by country|
|   char|CategoryCharacter|Get or set delimiter which is used to delimit category name and report name.|
|   bool|ChangParentUrlWhenRedirect||
|   ChartingEngine|ChartingEngine||
|   int|ChartLimit|Gets or sets the value limiting chart items on Dashboards.|
|   ChartCollection|Charts|Gets or sets the collection of available Charts. The collection of available charts is shown in the Chart Type combobox on the Chart tab in the ReportDesigner.|
|   Point|ChartSize|Gets or sets the value indicating chart size. This will affect size of all charts in the rendered report or dashboard.|
|   string[]|ChartSortFields|Gets or sets the value indicating the fields that will be used for sorting data in charts.|
|   int|CheckBoxListColumns|Gets or sets the maximum number of checkbox columns in "Quick add" dialog in the Report Designer on the Fields tab. <br> *Note: Fields will be grouped in columns in cases when the number of fields is greater then QuickAddMinElementsInColumn*.|
|   bool|CheckForUpdates||
|   bool|CheckUserPermission|Gets or sets value indicating that user permissions should be checked. If disabled, all reports will be accessible to all users.|
|   bool|CollapsedFiltersInReportViewer|Gets or sets the value indicating whether the filters section of the Report Viewer should be initially hidden. You should have ShowFiltersInReportViewer enabled to use this setting.|
|   Unit|ColumnDropDownWidth|Gets or sets the value indicating the width of the box for dropdown boxes on the Fields tab in the ReportDesigner.|
|   CultureInfo|Culture|Gets or sets the default culture setting for AdHoc. <br> *Note: Use this only in special cases. Normally, you should use the Language setting for localization. To learn more, see the links below:* <br>[[Language]] <br>[[Izenda Language Pack]]|
|   bool|CurrentUserIsAdmin|Gets or sets whether the current user is an Admin user. Admins may see and overwrite all reports for that tenant.|
|   bool|CurrentUserIsGlobalAdministrator|Defines if the current user has global administrator rights.|
|   string|CurrentUserName|Gets or sets the name of the current user. This is required for multi-user security.|
|   string[]|CurrentUserRoles|Defines groups set for the current user.|
|   string|CurrentUserTenantId|This identifies what tenant the current user is associated with in a multi-tenant system.|
|   CustomizeChartDelegate|CustomizeChartDelegate|Represents a method that runs before chart reports get run.|
|   CustomTimePeriodCollection|CustomTimePeriods|Used to define custom time periods that will be accessible in the 'In Time Period' filter operator on the Filters tab in the ReportDesigner. These options will be appended to the list of time periods that ship with Izenda AdHoc.<br>*Note: There are several overloads for the CustomTimePeriod constructor, so you can define different time periods with various types.*|
|   DashboardDateSliderMode|DashboardDateSliderMode|Gets or sets the value indicating the size of each section of the graph with the Dashboard date slider.|
|   string|DashboardDesignerUrl|Gets or sets the URL of the page used to design dashboards (DashboardDesigner).|
|   string|DashboardDesignerUrlWithDelimiter|Gets the DashboardDesignerUrl with query string characters ("?" and "&") at the end.|
|   int|DashboardFieldsCount|Gets or sets the count of additional reports. Affects ReportDesigner when ShowDashboardFieldsTab is true.|
|   int|DashboardGaugeWidth|Gets or sets the gauge width for "Dashboard Gauge" format. This will affect the width of gauges when they are shown in the dashboards. This replaced DashboardGaugeMax and DashboardGaugeMin and should be used instead of these at all times.|
|   string|DashboardsCssUrl|Gets or sets the CSS stylesheet URL to use for the TabStrip.|
|   string|DashboardTabBackgroundImageUrl|Gets or sets the URL of the image used for the Dashboards' tabs.|
|   string|DashboardViewer||
|   string|DatabaseDiagramImageUrl|Gets or sets a link to a database diagram image that is displayed on the report designer. Database diagrams display table relationships and can be created through Microsoft SQL. Izenda recommends using a database diagram to simplify the process of joining complex related tables.|
|   DateTime|DataCacheExpiration||
|   int|DataCacheInterval||
|   NameDistinctValueCollection|DataSourceAliases|Gets or sets the collection of key-value pairs where the key is the table name and the value is a table alias. <br> *Note:This property doesn't change the data source name in database. It is for display purposes only.|
|   NameStringsCollection|DataSourceCategories|This allows you to assign sets of datasources to different categories. When ShowDataSourcesAsCheckBoxes is enabled, this list is added to the Data Sources tab dropdown in the ReportDesigner. If the user selects a category, only datasources from the selected category will be shown.|
|   TimeSpan|DataSourceDropDownTimeout|Gets or sets the timeout between starting loading dropdown values (in the DataSources dropdown at the Data Sources tab in the ReportDesigner) from the server and redirecting to the About page.|
|   string|DataSourceHeading|Gets or sets the value of the title on the Data Sources tab of Report Designer. Some users rename this since other users may not be familiar with database terminology.|
|   int|DataSourceLimit|This setting limits the number of data sources Izenda Reports allows to be used in a single report when designing reports.|
|   int|DateArithmeticDecimalPlaces|Gets or sets the value indicating how many decimal places to use for comparing dates. This can help yield more precise dates in calculations.|
|   string|Db2ConnectionString|Gets or sets the connection string for DB2 connections.|
|   string|DefaultAlternatingItemColor|Gets or sets the default alternating grid item color on reports.|
|   string|DefaultHeaderForegroundColor|Gets or sets the default grid header foreground color on reports.|
|   string|DefaultItemForegroundColor|Gets or sets the default grid item foreground color on reports.|
|   int|DefaultItemsPerPage|This setting changes how many items are shown in the report viewer per page. For example, let's say a report had 150 items. By default, this value is set to 100. So 100 items would be displayed on the first page. When the user scrolls to the bottom of the page, they will see a link that shows 101-150. When the user clicks on it, the remaining report items will be shown.|
|   int|DefaultLinesPerItem|Gets or sets the default count of lines per item for the "Multi-Line" feature. The default value is 2 and is listed in the style tab of the report designer under the "Field/Value common pairs" dropdown. Let's say that you have a report with 12 fields. This report would be difficult to print. By changing this value to 2, the grid would be 6 fields wide instead of 12. This is a feature commonly used in accounting style reports.|
|   string|DefaultLoadTab|Sets the default tab that loads when a report is loaded in report designer. By default, this goes to the Fields tab.|
|   int|DefaultPreviewResults|This changes the default number of results (records) shown in the report designer preview tab. When exporting, all results will always be exported. Web browsers can become slow or stop completely when reports with hundreds of thousands of lines are generated, so keep this in mind when changing this setting. Ideally, this should be set to a power of 10 (1, 10, 100, 1000, etc).|
|   string|DefaultReportBorderColor|Sets the default grid border color for reports.|
|   string|DefaultReportHeaderColor|Sets the default report header color.|
|   string|DefaultReportItemColor|Sets the default report item background color.|
|   StringCollection|DefaultReportOrder|Gets or sets the default report order on the Style tab in the ReportDesigner. Acceptable string values include: "Maps", "Chart", "Chart2", "Chart3", "Chart4", "Gauges", "Summary", and "Detail". Order is determined by each entry's position in the list.|
|   string|DefaultSharingRights|Gets or sets the value defining sharing rights that are assigned to the report by default.|
|   string|DefaultTable|Gets or sets the name of the default table that is automatically added to new reports. If this is blank, no default table will be used. The table must be present in the database and be accessible.|
|   string|DefaultUserName|This settings allows the application to assign a default username for users logged into the Izenda Reports web application. User names are shown on the report list and on the reports tab of the report designer.|
|   string|DefaultVisibilityForNonAdmins|Gets or sets the default visibility group for non admins. This setting defines which groups of reports will be visible by default to the non-administrator users.|
|   Unit|DescriptionWidth|Gets or sets the width of the "Description" textbox on the Fields tab of the Report Designer.|
|   bool|Distinct|Sets the default value of the distinct checkbox. The distinct checkbox is located on the datasources tab of the report designer page.|
|   bool|DistinctSubtotalInnerQuery|Gets or sets the value indicating whether the DISTINCT option should be used in inner queries for calculating subtotals. This can affect database performance.|
|   FormatCollection|DrillDownStyle|Gets or sets the list of available drill-down report field formats. This affects the contents of all "Drill-down style" comboboxes in the ReportDesigner.|
|   AggregateFunctionCollection|DundasAggregateFunctions||
|   string|EmailFromAddress|This gets or sets the value used as the default "email from" address for the automated scheduler.|
|   string|EmailSubjectFormatString|This gets or sets the value used as the default subject of the emailed reports. By default it uses the report name as the subject of the email.|
|   bool|EmbedReportInServerEmail|Gets or sets the value indicating whether a report will be embedded in the server email.|
|   Dictionary<string,string[]>|EqualsPopupDestinations ||
|   int|EqualsSelectLimit|Limits the number of rows(the dropdown options) selectable through the "Equals(select)" filter. These filters can be found in the Filters tab of the Report Designer and in the report viewer when an "Equals(Select)" filter is utilized. <br>*Note: by default this is set to either 500 or 1000 rows. If, for example, you have 2 choices (true and false) and the false value is not in the first 1000 rows, then true will be the only option shown unless you increase this number.|
|   string|EqualsSelectText|Gets or sets a value that allows the user to specify the wording for the "Equals(Select)" filter. The "Select(Equals)" option is found in the filter tab of report designer in the operator drop down box.|
|   int|EqualsSelectTimeout|This setting allows the user to set how long to wait while the values of the filters tab is populated before timing out. If you have a large or unoptimized database, increasing this setting can help with proper reporting performance. This setting replaced EqualsDropDownTimeout and should be used instead.|
|   string|ErrorIzendaReplacement|Gets or sets the value that will replace the word "Izenda" in StackTrace when an exception occurs. This is useful when you brand your distribution of Izenda to your own company name.|
|   string[]|ExistingDatabaseConstraints|Gets a list of your database's constraints, if any.|
|   bool|ExpandCategorizedReports|Gets or sets whether the categorized reports underneath each category in the report list and in the report designer's preview tab can be expanded.|
|   bool|ExpandVisualGroupGrids|Gets or sets whether the visually grouped data details can be expanded underneath each visual grouping in the report viewer and in the report designer's preview tab. When enabled, all visual groups will be expanded automatically when you view the report.|
|   Font|ExportFont|Gets or sets the font for the PDF and RTF outputs. This is set to a standard font for [[iTextSharp|http://sourceforge.net/projects/itextsharp/]] by default|
|   int|ExportLimit|Gets or sets a value indicating the maximum number of rows a ReportSet may export.|
|   string[]|ExtendedFunctions|This list allows the user specify additional SQL functions that should be included in the functions dropdown of the Fields tab. Learn more about [[UDFs|http://wiki.izenda.us/FAQ/izenda-and-udfs]].|
|   NameValueCollection|FieldAliases|Gets or sets the field names(aliases) that the user sees in the Report Designer, on a per-user basis. The name of your database column is used as the key and the alias you want is the value. This is useful for localization and when custom fields are used in your application.|
|   Unit|FieldDropDownWidth|Gets or sets the width of field dropdown on the Fields tab in the ReportDesigner.|
|   int|FieldLimit|This setting limits the number of fields Izenda Reports allows to be used in a single report. Fields are set in the fields tab on the report designer page.|
|   string|FieldsRegex|Sets the regular expression used to select specific columns from your datasource. This setting allows the user to use a regular expression to filter certain fields from being added to the report through the fields tab in the report designer. This replaced FieldFilterRegex and should be used instead.|
|   string|FieldValueCssUrl||
|   Unit|FilterParameterWidth|Gets or sets the width of the Filters tab's "value(s)" controls when the "Equals" operator is selected.|
|   string|FiltersCustomPagesPath|Gets or sets the relative path to the Equals(PopUp) page if you are using a custom page.|
|   string|FiltersRegex|Sets the regular expression used for column filtering for data selection. This setting allows the user to use a regular expression to filter certain fields from being added to the report through the Fields tab in the report designer.|
|   bool|ForceNewNameOnSave|Setting this property forces the "Save" button to function exactly like the "Save As" button. It requires the user to specify a report name when saving. If another report has the same name, Izenda Reports warns the user. <br> *Note: The AllowOverwritingReports property MUST be set to true for this to have any effect.|
|   Unit|FormatDropDownWidth|Gets or sets the width of all "Format" dropdowns in the Report Designer.|
|   FormatCollection|Formats|Gets or sets the list of available formats to apply to fields. This affects the Formats dropdown on the Fields tab of the ReportDesigner. <br> *Note: You could use Formats to add new custom formats. Read more [[here|http://wiki.izenda.us/FAQ/Questions/How-do-I-use-ExtendedFormats-for-European-Date-Formats]]*|
|   string|FormDesignerUrl|Gets or sets the URL to the FormDesigner page.|
|   Unit|FunctionDropDownWidth|Gets or sets the width of Function dropdowns in the Report Designer.|
|   int|GaugeHeight|Gets or sets the height for Gauge controls in ReportSets. This setting replaced GaugeMaximum and GaugeMinimum and should be used instead.<br> *Note: This setting will affect only Linear Gauges*.|
|   string[]|GaugeStyles|Gets or sets custom gauge types. This overrides the existing set of gauge styles, shown as radiobuttons on the Gauge tab in the ReportDesigner. If you use this, you should ensure that you either define IGaugeDrawer objects in the AdHocSettings.RadialGaugeDrawerCollection corresponding to your custom gauge styles, or you have overriden CustomizeGuage in your AdHocConfig.|
|   int|GaugeWidth|Gets or sets the gauge width for "Gauge" format. This will affect width of gauges when they are shown in reportsets. <br> *Note: This setting will affect only Linear Gauges*.|
|   bool|GenerateParameterizedSql|Gets or sets the value indicating whether queries to the database should be parameterized.|
|   bool|GenerateThumbnails|
|   string|GeoDataTable||Gets or sets the value indicating the table name which contains geodata for maps.|
|   GetEqualsSelectValuesDelegate|GetEqualsSelectValues|Represents a method that returns values for the "Equals(Select)" operator. This handles the list of values shown on the Fields tab in the ReportDesigner in the Value(s) combobox if the "Equals(Select)" operator is used.|
|   TableItemStyle|GridHeaderStyle|Gets or sets the OpenOffice output style for grid headers in the report.|
|   TableItemStyle|GridItemStyle|Gets or sets the OpenOffice output style for grid items in the report.|
|   System.Drawing.Color|HeaderForegroundColor|Gets or sets the color of the report header.|
|   string|HeaderStyle|Gets or sets the CSS style for the headers in the Fields, Summary, and Filters tabs.|
|   NameValueCollection|HelpText|Gets or sets the collection of key-value pairs where the key is the tab name and the value is a hint that will be shown when the mouse is over the appropriate tab. Can be seen in the ReportDesigner if the ShowSideHelp property is enabled. <br> *Note: You can also enable/disable side help by clicking the Help button (the ShowHelpButton property must be enabled for this)*.|
|   string[]|HiddenCategories|Sets which categories are hidden for the current user. Report from those categories will not be shown to the current user.|
|   string[]|HiddenColumns|Gets or sets the array of Column names that should be hidden in the Fields tab dropdowns in the ReportDesigner.|
|   HiddenFilterCollection|HiddenFilters|This controls row-level security throughout the application. This should be used in all multi-tenant systems and systems where users are restricted to certain records. Hidden filters are applied to the report being executed. They will not appear in the UI and are invisible to the user.|
|   string|IdentifiersRegex||
|   string|ImagesPath|Gets or sets the path of the folder that contains the images used by Izenda AdHoc. If the value is not set, then built-in images will be used.|
|   bool|InheritFiltersInSubreports|Gets or sets the value indicating whether filters will be inherited in subreports. When enabled, subreports will have filters from the master report applied.|
|   string|InstantReport|Gets or sets the URL to the InstantReport page for custom implementations.|
|   string|InstantReportWithDelimiter|Gets or sets the URL to the InstantReport page with query string characters appended("?" and "&").|
|   bool|InvalidateSchemaOnNew|Gets or sets the value indicating whether the database schema should be invalidated when the user creates new report.|
|   int|InvertedGridLimit|Gets or sets the maximum count of rows for an inverted grid. This affects the maximum count of rows when set in the ReportDesigner.<br> *Note: The AllowInvertedGrid property MUST be enabled to use InvertedGridLimit*.|
|   System.Drawing.Color|ItemForegroundColor|Gets or sets the default color of the item text on the report grid.|
|   Unit|JoinDropDownWidth|Gets or sets the width of the join type dropdowns. These dropdowns can be found at the Data Sources tab of the ReportDesigner when ShowDataSourcesAsCheckBoxes is set to false.|
|   string|JoinFieldRegex|Gets or sets a regular expression used to filter certain fields from being shown in the join field between data sources in the data sources tab of report designer. For example, to show only fields ending with "ID", use following value: AdHocSettings.JoinFieldRegex = "^.*(?<!id)$";|
|   NameValueCollection|LabelAliases|Gets or sets the collection of key-value pairs where the key is the field name and the value is a field alias.|
|   AdHocLanguage|Language|Gets or sets the display language used for Izenda AdHoc.|
|   string|LicenseKey|Gets or sets the license key for your distribution of Izenda AdHoc. This is absolutely required for the application to function.
|   char|LiteralComma|Gets or sets the delimiter separating items in the 'Equals' filter operator value. This is an actual comma by default for easy copy/paste from CSV format lists.|
|   bool|LockViewer|Gets or sets the value indicating whether the Report Viewer will be locked. If true, controls like Add/Remove field, filters control, etc. will be unavailable in the ReportViewer.|
|   string|LoginUrl|This setting allows the user to specify their own login page to be utilized by Izenda Reports. Note to utilize this login page the "Require Login" check box must be selected.|
|   MapInfoCollection|MapInfoCollection|Gets or sets the registered maps data. This defines the contents of the Map Type dropdown at the Map tab in the ReportDesigner.|
|   Size|MaxImageSize|Gets or sets the maximum image size of the report images. If the size of an image is larger than the specified value then the image will be scaled.|
|   int|MaximumReportSizeForCache||
|   Unit|MinPdfFontSize|Sets the minimum font size that will be used when creating a PDF document. The default is 10 point.|
|   string|MySqlConnectionString|Gets or sets the connection string for MySQL connections.|
|   string|NoDataSourcePage|Gets or sets the URL of the page where users will be redirected if there are no tables in a database. By default it is the settings page.|
|   int|NumChartPerRow|Gets or sets the value indicating the number of charts that should be displayed in one report row on Dashboards.|
|   int|NumChartTabs|Sets the maximum number of charts allowed per report in the ReportDesigner. Each chart will have it's own tab in the report designer. Setting this to more than 1 requries a Dashboards license.|
|   int|NumSharedDropdowns|Gets or sets the maximum number of user/roles a report can be shared with. This affects the number of "Share With" dropdowns on the Misc tab of the ReportDesigner.|
|   bool|OpenCustomUrlInNewWindow|Gets or sets the value to enable opening a new window when a custom url link is clicked (See [[advanced filter settings|/FAQ/UserGuides/4.0 Fields Tab#4.8 Advanced Field Settings Button]]). If this is not enabled, the current page will change to the clicked on the link.|
|   int|OracleCommandTimeout|Sets the time Izenda Reports will wait for an Oracle command to execute before timing out.|
|   string|OracleConnectionString|Gets or sets the connection string for Oracle Server connections.|
|   ReportOutputGeneratorCollection|OutputTypes|Gets or sets the registered ReportOutputGenerators collection. These define what types of formats Izenda AdHoc can export to.|
|   string|ParentReportDesignerUrl||
|   string|ParentReportListUrl||
|   string|ParentReportViewerUrl||
|   string|ParentSettingsUrl||
|   bool|PerUserCaching|Gets or sets the value indicating whether the Driver.DatabaseSchema metadata should be cached.|
|   int|PivotFieldLimit|Sets the limit for the maximum number of pivot columns that can exist in a report. See more about [[pivots|/FAQ/UserGuides/12.0 Pivots]].|
|   string|PostgreSQLConnectionString|Gets or sets the connection string for Postgre SQL connections.|
|   int|PreviewColumnLimit|Gets or sets the value indicating the number of columns to show in the report preview.|
|   string|PreviewColumnLimitMessage|Gets or sets the value indicating the message displayed when PreviewColumnLimit is exceeded.|
|   int|PreviewTimeout|Sets the minimum time Izenda Reports will wait for a MSSQL command to execute before timing out.|
|   PrintMode|PrintMode|Gets or sets the value indicating what print mode will be used, PDF or HTML.|
|   int|QuickAddFieldWidth|Gets or sets the value indicating the max length of a string in one [[QuickAdd|/FAQ/UserGuides/4.0 Fields Tab#4.7 Quick Add]] column.|
|   int|QuickAddMinElementsInColumn|Set the minimum number of elements in each QuickAdd column.|
|   string|RDLFolder|Gets or sets path to Folder where [[RDL|http://technet.microsoft.com/en-us/library/ms155062.aspx]] files would be saved.|
|   int|RecentlyUpdatedCountAtReportList||
|   System.Drawing.Color|ReportAlternatingItemColor|Gets or sets the text color of alternating(even numbered) items in reports. See ReportItemColor for regular(odd numbered) items.|
|   System.Drawing.Color|ReportBorderColor|Gets or sets the color of the report border.|
|   string|ReportCssUrl|This setting allows the user to specify their own css file to be used on reports generated by Izenda Reports. This setting replaced the ReportCss property and should be used instead.|
|   string|ReportDesignerUrl|Gets or sets the URL of a page used to design reports.|
|   string|ReportDesignerUrlWithDelimiter|Gets the ReportDesignerUrl with query string characters ("?" and "&") at the end.|
|   System.Drawing.Color|ReportHeaderColor|Gets or sets the color of the report header.|
|   string|ReportHeaderImageUrl|This setting allows the user to set a report header image to be used on reports. This replaced the property ReportHeaderImage and should be used instead.|
|   string|ReportingService2005Url|Gets or sets the base URL of the XML Web service.|
|   System.Drawing.Color|ReportItemColor|Gets or sets the text color of regular(odd numbered) items in reports. See ReportAlternatingItemColor for alternating(even numbered) items.|
|   string|ReportList|Gets or sets the URL of the report list page. If this is null or empty, the Report List button in the toolbar will be hidden.|
|   ReportSetEventWatcherCollection|ReportSetEventWatchers|Gets or sets the collection of registered IReportSetEventWatcher objects that perform various actions on ReportSet-related events.|
|   string|ReportsPath|Sets the path to the directory where report files are stored. This is only needed when [[FileSystemMode|/Storing-Reports]] is enabled. Note: Be sure the folder exists and has the correct [[network user permissions|/Integration/Tutorials/Installing-Izenda#Step-3.-Configure-website-under-IIS]] specified.|
|   StorageMode|ReportStorageMode|Defines how reports are stored: either in the file system or in the database.|
|   string|ReportViewer|Gets or sets the URL of the report viewer page.|
|   int|ReportViewerDefaultPreviewResults|This textbox specifies the default number of results in the Report Viewer for all reports. Izenda does not recommend setting this to a large number such as 5000 or larger as the html report will take a long time to generate. If you would like to view all the data, we recommend exporting the report. This will always provide the entire report.|
|   string|ReportViewerPostHtml|Gets or sets the string of html that will be placed after the entire HtmlOutputReportResults section. This can be seen in the ReportViewer at the bottom page after the report body.|
|   string|ReportViewerPreHtml|Gets or sets the string of html code that placing before the entire HtmlOutputReportResults section. This can be seen in the ReportViewer in the top of the page before the report body.|
|   string|ReportViewerWithDelimiter|Gets the url of the report viewer page with query string characters ("?" and "&") at the end.
|   string|ReportViewPageTitle|Gets or sets the title of report viewer page. This text can be seen as the title of the browser window when ReportViewer is opened.|
|   bool|RequireLogin|This setting tells Izenda Reports that system will use authorization.<br> *Note: The LoginUrl property MUST be specified if this setting is enabled*.|
|   string|ResponseServer|Gets or sets the URL of the ResponseServer page.|
|   string|ResponseServerWithDelimiter|Gets the URL of the ResponseServer page with query string characters("?" and "&") at the end.|
|   int[]|ResultsDropdownValues|Gets or sets the list of the values in the "Results" dropdown in the toolbar of the ReportDesigner. This will override as many default entries in the list as it can.|
|   string|SavedReportsTable|Gets or sets the table name for saved reports. If DatabaseAdHocConfig is used, reports data will be saved in this table in the database. This setting does nothing if FileSystemAdHocConfig is used. By default, a table named "IzendaAdHocReports" is used.|
|   string|SaveReportSetNextUrl|Gets or sets the URL of the page to which users will be redirected after saving reports. <br>*Note:The Report name will be automatically appended to the url as a parameter named "rn"*.|
|   string|ScheduledReportsUrlFormatString|Gets or sets the url that is sent via email as the report web address when the user selects "link" in the scheduling control's "send email as" field. [[Report scheduling|/FAQ/Questions/How-do-I-use-the-Izenda-Reports-report-email-scheduler]] MUST be turned on for this to have an effect.|
|   SchedulerOutputCollection|SchedulerOutputTypes|Gets or sets the value indicating the allowed formats for scheduling reports. This defines the contents of the "Send Email As" dropdown at the Misc tab in the ReportDesigner.|
|   TimeSpan|SchemaCacheTimeout|Gets or sets how long the system should wait before giving up on caching the schema.|
|   Unit|SelectValueDropDownWidth|Gets or sets the width of the "Value(s)" dropdown on the Filters tab in the Report Designer.|
|   string|SettingsKey|Gets or sets a password used to access the settings page. It should be used in tandem with UserKey if you don't need multi-user security.|
|   string|SettingsPageUrl|Gets or sets the URL of the Settings page.|
|   string[]|SharedWithValues|This sets the users or roles available in the "Shared With" dropdown of the Misc tab in the Report Designer.|
|   bool|ShowAddAll|Deprecated|
|   bool|ShowAddFieldInReportViewer|Deprecated|
|   bool|ShowAdminButton|Deprecated|
|   bool|ShowAdvancedChartingButton|This checkbox enables/disables the advanced button from being shown in the Chart tab of Report Designer.|
|   bool|ShowAllInPreview|Gets or sets a value indicating whether an "All" option should be displayed in the "Results per page" dropdown on the Report Preview.|
|   bool|ShowAllInResults|Gets or sets a value indicating whether an "All" option should be displayed in the "Results per page" dropdown on the Report Viewer.|
|   bool|ShowAllTables|Deprecated|
|   bool|ShowArithmeticInSummary|Gets or sets the value indicating whether the "Arithmetic" options should be displayed in the Summary tab of the Report Designer.|
|   bool|ShowArithmeticOperations|Gets or sets the value indicating whether the "Arithmetic" options should be displayed in the Fields tab of the Report Designer.|
|   bool|ShowBackButton|Gets or sets whether to show a "Back" button on the Report Viewer & Report Designer toolbars.|
|   bool|[[ShowBetweenDateCalendar|/API/CodeSamples/ShowBetweenDateCalendar]]|Gets or sets the value indicating whether calendar controls should be used for "Between" operation for DateTime filters. |
|   bool|ShowBulkCSVButton|Deprecated|
|   bool|ShowCategoryTextboxInSaveDialog|Gets or sets the value indicating whether the "Category" dropdown should be shown in the "save as" dialog for reports.|
|   bool|ShowChartLegend|Get or sets the value controlling whether charts should show legends.|
|   bool|ShowChartTab|This checkbox enables/disables the "Charts" tab from the Izenda Reports application report designer page.|
|   bool|ShowClientEmailButton|Gets or sets the value controlling whether the "email report from client" button is shown on the Izenda Reports toolbar.|
|   bool|ShowConstraintsSettings|Gets or sets the value indicating the "Constraints" tab is shown on the Settings page.|
|   bool|ShowContinueLinks|Gets or sets the value indicating whether the "Continue to" buttons are displayed throughout the tabs of the Report Designer.|
|   bool|ShowCSVButton|Gets or sets the value indicating whether the Export to CSV button is displayed on the Izenda Reports toolbar.|
|   bool|ShowCustomFormatType|Gets or sets the value indicating whether the "Custom" format type should be shown in the "Formats" dropdown.|
|   bool|ShowDashboardAddDropDown|Deprecated|
|   bool|ShowDashboardFieldsTab|Gets or sets the value indicating whether the "Dasbhoard Fields" tab is displayed on the Report Designer.|
|   bool|ShowDashboardPartViewerLinks|Gets or sets the value indicating whether the Dashboard Viewer will have "edit" links for it's reports.|
|   bool|ShowDashboardSettings|Deprecated|
|   bool|ShowDatabaseDiagramIcon|Gets or sets the value indicating whether the Database Diagram icon should be shown in the toolbar in the ReportDesigner.|
|   bool|ShowDatabaseTypes|Gets or sets the value indicating whether database types should be shown in the Fields dropdown.
|   bool|ShowDataSourcesAsCheckBoxes|Gets or sets the value indicating which mode of the Data Sources list is shown.|
|   bool|ShowDataSourcesTab|Gets or sets whether the Data Sources tab is shown on the Report Designer.|
|   bool|ShowDataWhenParametersBlank|Deprecated|
|   bool|ShowDescriptionsInReportsTab|Deprecated|
|   bool|ShowDesignDashboardLink|Gets or sets the value indicating whether the "New Dashboard" link should be shown in the Report list.|
|   bool|ShowDesignLinkInReportViewer|Gets or sets the value indicating whether the "Design" button should be shown in the Report Viewer in the toolbar.|
|   bool|ShowDesignLinks|Gets or sets a value indicating whether "Design" links should be shown in the Report list and in the toolbar.|
|   bool|ShowDetailFormat|Deprecated|
|   bool|ShowDistinct|Gets or sets the value indicating whether the "Distinct" checkbox should be shown on the Data Source tab in the Report Designer.|
|   bool|ShowDOCButton|Gets or sets whether to show the Microsoft Word export button on the Report Viewer & Designer toolbar.|
|   bool|ShowEtlButton|Gets or sets the value indicating whether the upload data button should be shown in the report viewer. |
|   bool|ShowFieldAsValueDropDown|Gets or sets the value indicating whether the "(Field)" operators will display their "Value(s)" as textboxes or dropdown menus.|
|   bool|ShowFieldsTab|Gets or sets the value indicating whether the fields tab should be shown on the Report Designer.|
|   bool|ShowFieldValueCheckbox|Gets or sets the value indicating whether the "Show main report in Field/Value style" checkbox should be shown on the Style tab in the ReportDesigner.|
|   bool|ShowFieldValueSummaryCheckbox|Gets or sets the value indicating whether the "Show summary report in Field/Value style" checkbox should be shown on the Style tab in the ReportDesigner.|
|   bool|ShowFilterFunctions|Deprecated|
|   bool|ShowFilterLogic|Gets or sets the value indicating whether the "Filter Logic" textbox should be shown in the Filters tab in the Report Designer.|
|   bool|ShowFiltersInDashboards|Gets or sets the value indicating whether the "Filters" tab should be shown when viewing Dashboards.|
|   bool|ShowFiltersInReportViewer|Gets or sets the value indicating whether the "Filters" tab should be shown in the Report Viewer.|
|   bool|ShowFiltersTab|Gets or sets the value indicating whether the "Filters" tab should be shown in the Report Designer.|
|   bool|ShowFunctions|Gets or sets whether "Functions" controls should be shown for "Fields" on the Fields and Summary tabs on the Report Designer.|
|   bool|ShowGaugePercentage|Gets or sets the value indicating whether percentages should be shown on Gauges.|
|   bool|ShowGaugeTab|Gets or sets the value indicating whether the Gauges tab will be shown on the Report Designer.|
|   bool|ShowGoButton|Gets or sets whether the Go button is shown on the Izenda Reports toolbars.|
|   bool|ShowGradientBackground||
|   bool|ShowGroupInFunctionDropdown|Gets or sets the value indicating whether GROUP feature should be shown as a function at the Fields tab in the ReportDesigner.|
|   bool|ShowGroupMonth|Deprecated|
|   bool|ShowHelpButton|Gets or sets the value indicating whether the "HideHelpPanel" icon should be shown in the toolbar. |
|   bool|ShowHtmlAsCode|Gets or sets whether fetching HTML code contained in database fields displays as HTML or plain text. |
|   bool|ShowInTimePeriod|Gets or sets the value indicating whether "In Time Period" items are shown in operators dropdown on the Report Designer. |
|   bool|ShowInvertSummaryCheckbox|Deprecated|
|   bool|ShowInvisible|Deprecated|
|   bool|ShowJoinDropDown|Gets or sets the value indicating whether the join type dropdown should be shown in the JoinedTablesList. |
|   bool|[[ShowJustification|http://wiki.izenda.us/FAQ/Formatting/How-do-I-control-the-alignment-of-text-fields-or-justification-in-report-output]]|Gets or sets whether justification boxes are shown in the Report Designer.|
|   bool|ShowLinkFormats|Deprecated|
|   bool|ShowLoadingForDesigner|Deprecated|
|   bool|ShowLoadingOnDesignerLoad|Deprecated|
|   bool|ShowLogoInPdf|Deprecated|
|   bool|ShowMapTab|Gets or sets the value indicating whether the Map tab should be shown in the Report Designer.|
|   bool|ShowMenuInReportViewer|Deprecated|
|   bool|ShowMiscTab|Gets or sets whether the Misc tab is displayed on the Report Designer page. |
|   bool|ShowModifyButton|Deprecated|
|   bool|ShowMultiLineControls|Gets or sets the value indicating whether the "Multi-Line" feature is enabled.|
|   bool|ShowNewButton|Gets or sets whether the "New" button is shown on the Report Viewer for creating new reports.|
|   bool|ShowNonIndexedJoinFields|Gets or sets the value indicating whether non-indexed join fields should be shown.|
|   bool|ShowODTButton|Deprecated|
|   bool|ShowOnlineDocumentation|Gets or sets the value indicating whether to show "Details" buttons in the settings page. |
|   bool|ShowOpenOfficeButton|Gets or sets the value indicating whether the "OpenOffice" export button is shown. |
|   bool|ShowPDFButton|Gets or sets the value indicating whether the "PDF" export button is shown.|
|   bool|ShowPivot|Gets or sets whether to show the "Add Pivot" button on the Report Designer.|
|   bool|ShowPoweredByLogo|Gets or sets whether to show the "Powered By Izenda" logo throughout the application.|
|   bool|ShowPreviewTab|Gets or sets whether the "Preview" tab is shown in the Report Designer.|
|   bool|ShowPublishRdlButton|Gets or sets whether to show the "Publish RDL" button on the Report Designer toolbar.|
|   bool|ShowRdlOutputIcon|Gets or sets whether to show the "RDL" button on the Report Designer toolbar.|
|   bool|ShowRecentDatasources|Gets or sets the value indicating whether the Recent Datasources dropdown list will be shown on the Data Sources tab of the Report Designer.|
|   bool|ShowRemoveAll||
|   bool|ShowRemoveFieldInReportViewer||
|   bool|ShowReportClassifiers|Gets or sets the value indicating whether the ReportClassifiers control should be shown on the "Misc" tab of the ReportDesigner.|
|   bool|ShowReportColor|Gets or sets the value indicating whether report color (Item and AlternatingItem) dropdowns are shown on the Style tab in the Report Designer.|
|   bool|ShowReportingServicesSettings|Deprecated|
|   bool|ShowReportsInHtmlOutput|Deprecated|
|   bool|ShowReportsListAsDropDown|Gets or sets the value indicating which mode to use for the Reports tab.|
|   bool|ShowReportsTab|Gets or sets whether the Reports tab should be shown on the Report Designer.|
|   bool|ShowResponseServerDetails|Gets or sets whether to show a diagnostic test using the Response Server page.|
|   bool|ShowRowButtons|Gets or sets the value indicating whether "insert" and "move" buttons should be shown on the Fields tab in the Report Designer.|
|   bool|ShowRTFButton|Gets or sets the whether to enable the button to export to RTF format.|
|   bool|ShowSaveAsToolbarButton|Gets or sets whether the save as button is shown on the toolbar in Report Designer.|
|   bool|ShowSaveControls|Gets or sets whether the save controls (save and save as icons) in the toolbar are shown on the report designer.|
|   bool|ShowSaveControlsInReportsTab|Gets or sets the value indicating whether save controls should be shown in the toolbar in the Report Viewer.|
|   bool|ShowSaveInReportViewer|Deprecated|
|   bool|ShowSaveRdlToolbarButton|Gets or sets the value indicating whether the "Save As RDL" button should be shown on the toolbar.|
|   bool|ShowScheduleControls|Defines whether or not the scheduling controls are show at the Misc tab in the Report Designer.|
|   bool|ShowServerEmailButton|Gets or sets whether the "E-Mail report from server" button from the Izenda Reports toolbars.|
|   bool|ShowSettingsButton|Gets or sets whether the "Settings" button is shown on the toolbar.|
|   bool|ShowSettingsButtonForNonAdmins|Gets or sets whether the Settings button will be shown to users without administrator rights.|
|   bool|ShowSharedCheckbox|Deprecated|
|   bool|ShowSharingControl|Gets or sets the value indicating whether the sharing control will be shown at the Misc tab in the Report Designer.|
|   bool|ShowSideHelp|Gets or sets the value indicating whether side help should be shown in the Report Designer.|
|   bool|ShowSimpleModeViewer|Gets or sets whether to display the Simple Mode of the Report Viewer.|
|   bool|ShowSqlOutputIcon|Deprecated|
|   bool|ShowStackTrace|Gets or sets the value indicating the format for showing exceptions.|
|   bool|ShowStyleTab|Gets or sets whether the Style tab is shown on the Report Designer page.|
|   bool|ShowSummaryLine|Deprecated|
|   bool|ShowSummaryTab|Gets or sets whether the summary tab is shown on the Report Designer.|
|   bool|ShowTableNames|Gets or sets whether the fields in dropdowns should be grouped by table name. |
|   bool|ShowTenantField|Gets or sets whether the field identified in the TenantField property is shown.|
|   bool|ShowTimeZoneDropdown|Gets or sets the value indicating whether the timezone dropdown will be shown in the Report Designer on the Misc tab. <br> *Note: ShowScheduleControls MUST be set to true to use this*.|
|   bool|ShowTopInFields|Gets or sets whether to display the "Records" textbox on the Fields tab of the Report Designer.|
|   bool|ShowTopInSummary|Gets or sets whether to display the "Records" textbox on the Summary tab of the Report Designer.|
|   bool|ShowVisualGroupLabels|Deprecated|
|   bool|ShowWatermarkedExports|Gets or sets the value indicating whether a watermarked export should be used when there are license errors.|
|   bool|ShowWaterMarks|Gets or sets the value indicating whether watermarks should be used when there are license errors.|
|   bool|ShowWidth|Deprecated|
|   bool|ShowXLSButton|Gets or sets the value indicating whether the "XLS" export button is shown on the toolbar. |
|   string|SimpleFilterCssUrl||
|   bool|SingleLineViewerToolbar|Gets or set value indicating whether the ReportViewer toolbar should be single line.|
|   string|SmtpLogin|Gets or sets the SMTP server login name.|
|   string|SmtpPassword|Gets or sets the SMTP server password.|
|   string|SmtpServer|Gets or sets the SMTP server address used by your company to send out emails.|
|   bool|SortColumnNames|Gets or sets the value indicating whether dropdowns with column names are sorted alphabetically. |
|   int|SqlCommandTimeout|Gets or sets the wait time in seconds for loading dropdowns from the database.|
|   string|SqlServerConnectionString|Gets or sets the connection string for MS SQL Server connections.|
|   bool|StoreCurrentReportSetInApplication||
|   int|StoredProcedureStringLimit|Gets or sets the value indicating the max length of a string returned by a Stored Procedure.|
|   bool|StoreImagesToCache|Gets or sets the value indicating how temporary images should be stored.|
|   bool|StrictANSIOuterJoin||
|   bool|StripInvalidCharacters|Gets or sets the value indicating whether invalid characters in report names should be stripped out.|
|   string|SubCalculationFilterRegex|Gets or sets whether the user can use a regular expression to filter certain numeric fields from having subcalculation function options when selected in the Fields tab of Report Designer.|
|   string|TabBackgroundImageUrl|Gets or sets the path to an image used to customize the look of the tabs on the Report Designer.|
|   NameDistinctValueCollection|TableAliases|Deprecated|
|   Unit|TableDropDownWidth|This replaces the property DataSourceDropDownWidth and should be used instead.|
|   string|TableFilterRegex|Gets or sets the regular expression used for table filtering.|
|   string|TabsCss|Deprecated. Use TabsCssUrl instead.|
|   string|TabsCssUrl|Gets or sets the CSS stylesheet URL to use for the TabStrip.|
|   string|TempFiles|Gets or sets the value indicating the path where temporary files are stored.|
|   string|TemplatesPath||
|   string|TenantField|The field that will be internally filtered by the current TenantID value. |
|   int|ThumbnailHeight|Gets or sets the height of thumbnail images on the Report List.|
|   int|ThumbnailWidth|Gets or sets the width of thumbnail images on the Report List.|
|   Unit|TimePeriodDropDownWidth|Gets or sets the width of the time period dropdown.|
|   int|TimeZoneOffset|Gets or sets the value indicating the time zone offset of the current user in hours.|
|   SchedulerTimeZoneCollection|TimeZones|Gets or sets the collection of additional and hidden time zones. |
|   string|ToolbarBackgroundImageUrl|Gets or sets a URL to an image to customize the look of the toolbar section of the report designer.|
|   string|ToolbarBorderColor|Gets or sets the color of the toolbar border.|
|   string|ToolbarCssUrl|Gets or sets the CSS stylesheet URL for the Toolbar.|
|   string|UnCategorizedReportsMenuItemTitle|Deprecated|
|   bool|UseAdvancedGauge|Gets or sets the value indicating whether advanced is used for "Gauge" format. |
|   bool|UseBulkCSV|Gets or sets the value indicating whether to use the Bulk CSV export option. |
|   bool|UseColumnNameForDashboardCommonFilters||
|   bool|UseConstraintsForJoins|Gets or sets the value indicating if multiple autojoining conditions are allowed. |
|   bool|UseDefaultDialogs||
|   bool|UseFriendlyErrors|Gets or sets the value indicating whether friendly errors should be shown on exceptions.|
|   bool|UseImageDescriptions||
|   bool|UseNoLock|Gets or sets the value indicating whether nolock statements will be used in sql-queries.|
|   bool|UseNonPostbackDeleting|Gets or sets the value indicating whether a postback should occur on deleting a report.|
|   bool|UseNonPostbackExport|Gets or sets the value indicating whether a postback should occur on exporting a report.|
|   bool|UseNonPostbackPreview|Gets or sets the value indicating whether a postback should occur on previewing a report.|
|   bool|UseNonPostbackServerEmailing|Gets or sets the value indicating whether a postback should occur when emailing a report from the server.|
|   bool|UseReportID|Gets or sets whether the application uses a GUID instead of the report name in the query string.|
|   bool|ValidateBeforeSave|Gets or sets the value indicating whether ReportSet should be validated before saving.|
|   bool|ViewsOnly|ViewsOnly should be used if you would like all views visible and only views visible at the Data Sources tab. |
|   string[]|VisibleDataSources|Gets or sets the array of table names that should be shown in the tables dropdown in the ReportDesigner on the Data Sources tab.|
|   string[]|VisibleTables|Deprecated. Use VisibleDataSources instead.|
|   VisualGroupStyle|VisualGroupStyle|Deprecated|
