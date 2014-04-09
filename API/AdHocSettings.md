#AdHocSettings

The ``AdHocSettings`` class contains all the settings Izenda uses to control various aspects of the interface and flow of data. Many of the more useful settings are explained in detail in our [[User Guides|/FAQ/UserGuides]] and [[Developer Guides|/Guides/Developer-Links-and-Guides]]. 

|Datatype|Setting name|Setting description|
|:-------|:----------:|:-----------------:|  
|   string|AddAllFilterRegex|This setting allows the user to use a regular expression to filter certain fields from being added through the "Add All" button (the "Add All" button can be turned on in the features tab of the settings guide and is added in the fields section of report designer). An example of when this may be used is if you don't want social security numbers added to reports you could add part of the name of that field to the regular expression.|
|   Dictionary<string,double>|AdditionalTimeZones ||
|   AdHocConfig|AdHocConfig|Gets or sets the current AdHocConfig - Ad Hoc configuration.|
|   string|AdHocUserKey|A single password limiting access to the report designer, report list and report viewer. This is for projects that do not need multi-user security.|
|   AggregateFunctionCollection|AggregateFunctions||
|   bool|AllowAnalysisGrid|Gets or sets the value indicating whether it is allowed analysis grid. 
The option appears in the Visual Group Style combobox at the Style tab in the ReportDesigner.|
|   bool|AllowArchivedReportTableCreation|Gets or sets the value indicating whether it is allowed to create the database table that contains archived reports if there is no such table in the database. 
If set, AdHoc checks if table in database for keeping reportsets exists, and creates it if necessary.|
|   bool|AllowClientSorting||
|   bool|AllowComparativeArithmetic|Gets or sets the value indicating whether comparative arithmetic is allowed in arithmetic checkbox. 
Comparative operators appear in "A" checkboxes at the Fields tab in the ReportDesigner.|
|   bool|AllowCreateNewCategory|Gets or sets the value indicating the possibility to create new categories in Save As dialog in the ReportDesigner.|
|   bool|AllowDataFieldsInDescription|This checkbox enables/disables the ability to allow a data field to be used in the description of the report (which is set in the misc tab). This is particularly useful in drill down reports and those reports with filters. For example: Let's say we are filtering a report by the field CategoryName and the value Produce. For the Description we enter: [CategoryName] details. This will show on the report as Produce details and dynamically change when the user changes the filter value.|
|   bool|AllowDeletingReports|This checkbox enables/disables the delete icons at the report list page against reports names, for the current user. Clicking on the red x delete icon deletes the report.|
|   bool|AllowDeltas|Gets or sets the value indicating whether "Add Deltas" checkbox should be shown at the fields tab in the ReportDesigner. 
Any time there is a change in a quantity that change is calculated by taking the later value for that quantity and subtracting from it the earlier value for that quantity.|
|   bool|AllowDomainJoin|Gets or set value indicating domain join should be shown at report designer. 
Domain join could be usefull if you want to join tables on colums with web addresses. 
For example, if you set up Domain Join option columns with strings "http://www.yourdomain.com" and "www.yourdomain.com" will be equal.|
|   bool|AllowEqualsSelectForStoredProcedures|Gets or sets the value indicating is it allowed to use Equals(Select) or Equals(Multiple) for filters in case when stored procedure used. These options can be found in the Operator dropdown at the Filters tab in the ReportDesigner.|
|   bool|AllowFieldsAsValue|Gets or sets the value indicating whether field name is allowed in filter value. 
If set, values like "Is Less Than (Field)" appear in the Operator combobox at the Filters tab in the ReportDesigner. Fields comparison allows you to compare values from one field with values from another field.|
|   bool|AllowGroupWithoutSelect|Gets or sets value indicating if it is possible to make invisible fields which are used for Visual Grouping. 
If set, fields with both "Hide This Field" (in the advanced properties) and "VG"; flags set, will not lead to report being considered as invalid.|
|   bool|AllowHorizontalBarChart|Gets or sets the value indicating whether Horizontal Bar Chart is allowed. 
This defines if Horizontal checkbox will be available in the Advanced Properties at the Chart tab in the ReportDesigner, when Bar chart type is used.|
|   bool|AllowHtmlOutputsInScheduledReports||
|   bool|AllowInvalidCharacters|Gets or sets the value indicating whether invalid characters in report namesare allowed if not striped. 
If disabled, non-literal characters in the report name, entered in the Report Designer in Save As dialog, will cause error message during saving report. 
Note: Invalid characters will be automatically removed from the report name if [[StripInvalidCharacters]] set to true.|
|   bool|AllowInvertedGrid|Allows the inverted checkbox to be shown in the Summary tab in the ReportDesigner. Inverted grid means it exchanges columns for rows (up to 36 rows)|
|   bool|AllowLineOnBar|Gets or sets the value indicating whether is it allowed line on Bar chart. 
If true, then Line Value feature is available at the Chart tab in the ReportDesigner, when Bar chart type is selected. 
Line can show additional values on the Bar chart.|
|   bool|AllowMultilineHeaders|Gets or sets if headers in the grid report can be multiline. 
This setting could be useful if you have many columns in the report or columns names are very long.|
|   bool|AllowNewFiltersInReportViewer|This checkbox enables/disables the ability to add new filters in the report viewer page of Izenda Reports. Note: Current filters used on the report will still be displayed.|
|   bool|AllowOverwritingReports|This enables/disables the current user's ability to overwrite reports currently saved. An example of this usage is that many users create base reports for their users to use. Disabling the overwrite report feature ensures that the default reports are not tampered with.|
|   bool|AllowSelfJoin|Gets or sets the value indicating whether is it allowed datasources self join. 
If true and ShowDataSourcesAsCheckBoxes, then user can select the same data source twice and selfjoin it at the Data Sources tab in the ReportDesigner.|
|   bool|AllowStackedBarChart|Gets or sets the value indicating whether Stacked Bar Chart is allowed. 
This defines if Stacked checkbox will be available in the Advanced Properties at the Chart tab in the ReportDesigner, when Bar chart type is used.|
|   bool|AllowSummaryDeltas|Gets or sets the value indicating whether "Show Summary Deltas" checkbox should be shown in the summary tab in the ReportDesigner. 
Any time there is a change in a quantity that change is calculated by taking the later value for that quantity and subtracting from it the earlier value for that quantity. 

AllowDeltas feature MUST be turned on to use this feature.|
|   bool|AllowVisualGroups||
|   string|ApplicationHeaderImageUrl|Gets or sets the URL of the Application Header Logo.|
|   bool|AutoJoinOnRenderedRows||
|   bool|AutoPostBackOnFilterChange|Gets or sets the value indicating whether should be postback on filter change. 
This affects behavior of ReportViewer when ShowFiltersInReportViewer is enabled, and user changes filters there. All changes will be applied immediately and report will be reloaded.|
|   bool|CacheEqualsSelect|Gets or sets the value indicating whether "Equals (Select)" value should be cached. 
Caching "Equals (Select)" can be usefull if you have problems with performance in your data base or slow connection to it. But data in cache may be not relevant if it is updated very often in the data base. So, use this setting carefully.|
|   bool|CacheQueries|Gets or sets the value indicating whether all queries for the Driver should be cached.|
|   bool|CacheReports|Gets or sets the value indicating whether all loaded reports should be cached. 
This feature can be very useful if you have problems with performance in your data base or slow connection to it. 
Loaded ReportSet will be cached, so there will be no extra queries to the data base. 
When you save the Reportset cache for it will be removed and it will be added again when ReportSet will be loaded again. 
Report caching may cause problems if you are running more than one instance of Izenda Adhoc with the same reports source (i.e. the same database and table or same reports folder)|
|   bool|CacheSchema|Gets or sets the value indicating whether DatabaseSchema should be cached. 
Disable schema caching may be useful if you data base schema changes very often. But ussually it is better to use caching because it will prevent extra queries to the data base.|
|   bool|CacheStoredProcedureMetaDataToDisk|Gets or sets the value indicating whether the information about stored procedures will be cached on the server's disk. 
Normally stored procedures are updated with the database schema. But if CacheStoredProcedureMetaDataToDisk is enabled, they will be stored in the Izenda.config file and will not be updated with the schema. Normally, you don't need to use stored procedure caching, so use this feature only when you have problems with performance while loading a large amount of stored procedures.|
|   bool|CascadeFilterValues|Gets or sets the value indicating whether filter values at the Filters tab in the ReportDesigner will be cascaded. For example, this will only show cities in the country selected on the prior filter by country|
|   char|CategoryCharacter|Get or set delimiter which is used to delimit category name and report name.|
|   bool|ChangParentUrlWhenRedirect||
|   ChartingEngine|ChartingEngine||
|   int|ChartLimit|Gets or sets the value limiting chart items on Dashboards.|
|   ChartCollection|Charts|Gets or sets the collection of available Charts. The collection of available charts is shown in the Chart Type combobox on the Chart tab in the ReportDesigner.|
|   Point|ChartSize|Gets or sets the value indicating chart size. This will affect size of all charts in the rendered report or dashboard.|
|   string[]|ChartSortFields|Gets or sets the value indicating the fields that will be used for sorting data in charts.|
|   int|CheckBoxListColumns|Gets or sets the maximum number of checkbox columns in "Quick add" dialog in the Report Designer on the Fields tab. 
Note: Fields will be grouped in columns in cases when the number of fields is greater then QuickAddMinElementsInColumn|
|   bool|CheckForUpdates||
|   bool|CheckUserPermission|Gets or sets value indicating that user permissions should be checked. If disabled, all reports will be accessible to all users.|
|   bool|CollapsedFiltersInReportViewer|Gets or sets the value indicating whether the filters section of the Report Viewer should be initially hidden. You should have ShowFiltersInReportViewer enabled to use this setting.|
|   Unit|ColumnDropDownWidth|Gets or sets the value indicating the width of the box for dropdown boxes on the Fields tab in the ReportDesigner.|
|   CultureInfo|Culture|Gets or sets the default culture setting for AdHoc. <br> *Note: Use this only in special cases. Normally, you should use the Language setting for localization. To learn more, see the links below:* <br>
[[Language]] <br>
[[Izenda Language Pack]]|
|   bool|CurrentUserIsAdmin|Gets or sets whether the current user is an Admin user. Admins may see and overwrite all reports for that tenant.|
|   bool|CurrentUserIsGlobalAdministrator|Defines if the current user has global administrator rights.|
|   string|CurrentUserName|Gets or sets the name of the current user. This is required for multi-user security.|
|   string[]|CurrentUserRoles|Defines groups set for the current user.|
|   string|CurrentUserTenantId|This identifies what tenant the current user is associated with in a multi-tenant system.|
|   CustomizeChartDelegate|CustomizeChartDelegate|Represents a method that runs before chart reports get run.|
|   CustomTimePeriodCollection|CustomTimePeriods|Used to define custom time periods that will be accessible in the 'In Time Period' filter operator on the Filters tab in the ReportDesigner. These options will be appended to the list of time periods that ship with Izenda AdHoc.<br>
*Note: There are several overloads for the CustomTimePeriod constructor, so you can define different time periods with various types.*|
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
|   NameDistinctValueCollection|DataSourceAliases|Gets or sets the collection of key-value pairs where the key is the table name and the value is a table alias. 
Note:This property doesn't change data source name in data base. You should use it if you want to change ONLY display name for the data source. I.e. you will still have to work with 'real' data source name if you want to use it in any other option.|
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
|   FormatCollection|DrillDownStyle|Gets or sets the list of available drill-down report fields formats. This affects contents of all "Drill-down style" comboboxes in the ReportDesigner.|
|   AggregateFunctionCollection|DundasAggregateFunctions||
|   string|EmailFromAddress||
|   string|EmailSubjectFormatString||
|   bool|EmbedReportInServerEmail||
|   int|EqualsDropDownLimit||
|   int|EqualsDropDownTimeout||
|   Dictionary<string,string[]>|EqualsPopupDestinations ||
|   string|EqualsSelectDateFormat||
|   int|EqualsSelectLimit||
|   string|EqualsSelectText||
|   int|EqualsSelectTimeout||
|   string|ErrorIzendaReplacement||
|   string[]|ExistingDatabaseConstraints||
|   bool|ExpandCategorizedReports||
|   bool|ExpandVisualGroupGrids||
|   Font|ExportFont||
|   int|ExportLimit||
|   NameValueCollection|ExtendedFormats||
|   string[]|ExtendedFunctions||
|   NameValueCollection|FieldAliases||
|   Unit|FieldDropDownWidth||
|   string|FieldFilterRegex||
|   int|FieldLimit||
|   FieldList|FieldList||
|   string|FieldsRegex||
|   string|FieldValueCssUrl||
|   Unit|FilterParameterWidth||
|   string|FiltersCustomPagesPath||
|   string|FiltersRegex||
|   bool|ForceNewNameOnSave||
|   Unit|FormatDropDownWidth||
|   FormatCollection|Formats||
|   string|FormDesignerUrl||
|   Unit|FunctionDropDownWidth||
|   int|GaugeHeight||
|   double|GaugeMaximum||
|   double|GaugeMinimum||
|   string[]|GaugeStyles||
|   int|GaugeWidth||
|   bool|GenerateParameterizedSql||
|   bool|GenerateThumbnails||
|   string|GeoDataTable||
|   GetEqualsSelectValuesDelegate|GetEqualsSelectValues||
|   TableItemStyle|GridHeaderStyle||
|   TableItemStyle|GridItemStyle||
|   System.Drawing.Color|HeaderForegroundColor||
|   string|HeaderStyle||
|   NameValueCollection|HelpText||
|   string[]|HiddenCategories||
|   string[]|HiddenColumns||
|   List<double>|HiddenTimeZones||
|   string|IdentifiersRegex||
|   string|ImagesPath||
|   bool|InheritFiltersInSubreports||
|   string|InstantReport||
|   bool|InvalidateSchemaOnNew||
|   int|InvertedGridLimit||
|   System.Drawing.Color|ItemForegroundColor||
|   Unit|JoinDropDownWidth||
|   JoinedTablesList|JoinedTablesList||
|   string|JoinFieldRegex||
|   NameValueCollection|LabelAliases||
|   AdHocLanguage|Language||
|   char|LiteralComma||
|   bool|LockViewer||
|   string|LoginUrl||
|   MapInfoCollection|MapInfoCollection||
|   Size|MaxImageSize||
|   int|MaximumReportSizeForCache||
|   Unit|MinPdfFontSize||
|   bool|MultiLevelVisualGrouping||
|   string|MySqlConnectionString||
|   string|NoDataSourcePage||
|   int|NumChartPerRow||
|   int|NumChartTabs||
|   int|NumSharedDropdowns||
|   bool|OpenCustomUrlInNewWindow||
|   int|OracleCommandTimeout||
|   string|OracleConnectionString||
|   ReportOutputGeneratorCollection|OutputTypes||
|   string|ParentReportDesignerUrl||
|   string|ParentReportListUrl||
|   string|ParentReportViewerUrl||
|   string|ParentSettingsUrl||
|   bool|PerUserCaching||
|   int|PivotFieldLimit||
|   string|PostgreSQLConnectionString||
|   int|PreviewColumnLimit||
|   string|PreviewColumnLimitMessage||
|   int|PreviewTimeout||
|   PrintMode|PrintMode||
|   ProcessFiltersDelegate|ProcessFiltersDelegate||
|   int|QuickAddFieldWidth||
|   int|QuickAddMinElementsInColumn||
|   string|RDLFolder||
|   int|RecentlyUpdatedCountAtReportList||
|   System.Drawing.Color|ReportAlternatingItemColor||
|   System.Drawing.Color|ReportBorderColor||
|   string|ReportCss||
|   string|ReportCssUrl||
|   string|ReportDesignerUrl||
|   System.Drawing.Color|ReportHeaderColor||
|   System.Drawing.Image|ReportHeaderImage||
|   string|ReportHeaderImageUrl||
|   string|ReportingService2005Url||
|   System.Drawing.Color|ReportItemColor||
|   string|ReportList||
|   ReportListSettings|ReportListSettings||
|   ReportSetEventWatcherCollection|ReportSetEventWatchers||
|   string|ReportsPath||
|   bool|ReportsSharedByDefault||
|   StorageMode|ReportStorageMode||
|   ReportTypeCollection|ReportTypes||
|   string|ReportViewer||
|   int|ReportViewerDefaultPreviewResults||
|   string|ReportViewerPostHtml||
|   string|ReportViewerPreHtml||
|   int|ReportViewerRefreshInterval||
|   string|ReportViewPageTitle||
|   bool|RequireLogin||
|   string|ResponseServer||
|   int[]|ResultsDropdownValues||
|   string|SavedReportsTable||
|   string|SaveReportSetNextUrl||
|   string|ScheduledReportsUrlFormatString||
|   SchedulerOutputCollection|SchedulerOutputTypes||
|   string|SchedulerTenantID||
|   TimeSpan|SchemaCacheTimeout||
|   string|ScriptDirectory||
|   Unit|SelectValueDropDownWidth||
|   bool|ServiceMode||
|   string|SettingsKey||
|   string|SettingsPageUrl||
|   string[]|SharedWithValues||
|   bool|ShowAddAll||
|   bool|ShowAddFieldInReportViewer||
|   bool|ShowAdminButton||
|   bool|ShowAdvancedChartingButton||
|   bool|ShowAllInPreview||
|   bool|ShowAllInResults||
|   bool|ShowAllTables||
|   bool|ShowArithmeticInSummary||
|   bool|ShowArithmeticOperations||
|   bool|ShowBackButton||
|   bool|ShowBetweenDateCalendar||
|   bool|ShowBulkCSVButton||
|   bool|ShowCategoryTextboxInSaveDialog||
|   bool|ShowChartLegend||
|   bool|ShowChartTab||
|   bool|ShowClientEmailButton||
|   bool|ShowConstraintsSettings||
|   bool|ShowContinueLinks||
|   bool|ShowCSVButton||
|   bool|ShowCustomFormatType||
|   bool|ShowDashboardAddDropDown||
|   bool|ShowDashboardFieldsTab||
|   bool|ShowDashboardPartViewerLinks||
|   bool|ShowDashboardSettings||
|   bool|ShowDatabaseDiagramIcon||
|   bool|ShowDatabaseTypes||
|   bool|ShowDataSourcesAsCheckBoxes||
|   bool|ShowDataSourcesTab||
|   bool|ShowDataWhenParametersBlank||
|   bool|ShowDescriptionsInReportsTab||
|   bool|ShowDesignDashboardLink||
|   bool|ShowDesignLinkInReportViewer||
|   bool|ShowDesignLinks||
|   bool|ShowDetailFormat||
|   bool|ShowDistinct||
|   bool|ShowDOCButton||
|   bool|ShowEtlButton||
|   bool|ShowFieldAsValueDropDown||
|   bool|ShowFieldsTab||
|   bool|ShowFieldValueCheckbox||
|   bool|ShowFieldValueSummaryCheckbox||
|   bool|ShowFilterFunctions||
|   bool|ShowFilterLogic||
|   bool|ShowFiltersInDashboards||
|   bool|ShowFiltersInReportViewer||
|   bool|ShowFiltersTab||
|   bool|ShowFunctions||
|   bool|ShowGaugePercentage||
|   bool|ShowGaugeTab||
|   bool|ShowGoButton||
|   bool|ShowGradientBackground||
|   bool|ShowGroupInFunctionDropdown||
|   bool|ShowGroupMonth||
|   bool|ShowHelpButton||
|   bool|ShowHtmlAsCode||
|   bool|ShowInTimePeriod||
|   bool|ShowInvertSummaryCheckbox||
|   bool|ShowInvisible||
|   bool|ShowJoinDropDown||
|   bool|ShowJustification||
|   bool|ShowLinkFormats||
|   bool|ShowLoadingForDesigner||
|   bool|ShowLoadingOnDesignerLoad||
|   bool|ShowLogoInPdf||
|   bool|ShowMapTab||
|   bool|ShowMenuInReportViewer||
|   bool|ShowMiscTab||
|   bool|ShowModifyButton||
|   bool|ShowMultiLineControls||
|   bool|ShowNewButton||
|   bool|ShowNonIndexedJoinFields||
|   bool|ShowODTButton||
|   bool|ShowOnlineDocumentation||
|   bool|ShowOpenOfficeButton||
|   bool|ShowPDFButton||
|   bool|ShowPivot||
|   bool|ShowPoweredByLogo||
|   bool|ShowPreviewTab||
|   bool|ShowPublishRdlButton||
|   bool|ShowRdlOutputIcon||
|   bool|ShowRecentDatasources||
|   bool|ShowRemoveAll||
|   bool|ShowRemoveFieldInReportViewer||
|   bool|ShowReportClassifiers||
|   bool|ShowReportColor||
|   bool|ShowReportingServicesSettings||
|   bool|ShowReportsInHtmlOutput||
|   bool|ShowReportsListAsDropDown||
|   bool|ShowReportsTab||
|   bool|ShowResponseServerDetails||
|   bool|ShowRowButtons||
|   bool|ShowRTFButton||
|   bool|ShowSaveAsToolbarButton||
|   bool|ShowSaveControls||
|   bool|ShowSaveControlsInReportsTab||
|   bool|ShowSaveInReportViewer||
|   bool|ShowSaveRdlToolbarButton||
|   bool|ShowScheduleControls||
|   bool|ShowServerEmailButton||
|   bool|ShowSettingsButton||
|   bool|ShowSettingsButtonForNonAdmins||
|   bool|ShowSharedCheckbox||
|   bool|ShowSharingControl||
|   bool|ShowSideHelp||
|   bool|ShowSimpleModeViewer||
|   bool|ShowSqlOutputIcon||
|   bool|ShowStackTrace||
|   bool|ShowStyleTab||
|   bool|ShowSummaryLine||
|   bool|ShowSummaryTab||
|   bool|ShowTableNames||
|   bool|ShowTenantField||
|   bool|ShowTimeZoneDropdown||
|   bool|ShowTopInFields||
|   bool|ShowTopInSummary||
|   bool|ShowVisualGroupLabels||
|   bool|ShowWatermarkedExports||
|   bool|ShowWaterMarks||
|   bool|ShowWidth||
|   bool|ShowXLSButton||
|   string|SimpleFilterCssUrl||
|   bool|SingleLineViewerToolbar||
|   string|SmtpLogin||
|   string|SmtpPassword||
|   string|SmtpServer||
|   bool|SortColumnNames||
|   int|SqlCommandTimeout||
|   string|SqlServerConnectionString||
|   bool|StoreCurrentReportSetInApplication||
|   int|StoredProcedureStringLimit||
|   bool|StoreImagesToCache||
|   bool|StrictANSIOuterJoin||
|   bool|StripInvalidCharacters||
|   string|SubCalculationFilterRegex||
|   string|TabBackgroundImageUrl||
|   NameDistinctValueCollection|TableAliases||
|   Unit|TableDropDownWidth|This replaces the property DataSourceDropDownWidth and should be used instead.|
|   string|TableFilterRegex||
|   string|TabsCss||
|   string|TabsCssUrl||
|   string|TempFiles||
|   string|TemplatesPath||
|   string|TenantField||
|   int|ThumbnailHeight||
|   int|ThumbnailWidth||
|   Unit|TimePeriodDropDownWidth||
|   int|TimeZoneOffset||
|   SchedulerTimeZoneCollection|TimeZones||
|   string|ToolbarBackgroundImageUrl||
|   string|ToolbarBorderColor||
|   string|ToolbarCssUrl||
|   string|UnCategorizedReportsMenuItemTitle||
|   bool|UseAdvancedGauge||
|   bool|UseBulkCSV||
|   bool|UseColumnNameForDashboardCommonFilters||
|   bool|UseConstraintsForJoins||
|   bool|UseDefaultDialogs||
|   bool|UseFriendlyErrors||
|   bool|UseImageDescriptions||
|   bool|UseNoLock||
|   bool|UseNonPostbackDeleting||
|   bool|UseNonPostbackExport||
|   bool|UseNonPostbackPreview||
|   bool|UseNonPostbackServerEmailing||
|   bool|UseReportID||
|   bool|ValidateBeforeSave||
|   bool|ViewsOnly||
|   string[]|VisibleDataSources||
|   string[]|VisibleTables||
|   VisualGroupStyle|VisualGroupStyle||
