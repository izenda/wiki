#AdHocSettings

The ``AdHocSettings`` class contains all the settings Izenda uses to control various aspects of the interface and flow of data. Many of the more useful settings are explained in detail in our [[Guide to Report Design|/Guides/ReportDesign]] and [[Developer Guides|/Guides/Developer-Links-and-Guides]]. ")

|Datatype|Setting name|Setting description|Default Value|
|:---|:---:|:---:|:---:|
|String|[[AddAllFilterRegex|/API/CodeSamples/AddAllFilterRegex]]|Gets or sets the regular expression used for "Add All" filtering.            If name of a column matches this expression then it will not be added on "Add All" click.|(id&#124;guid)$|
|Dictionary|[[AdditionalTimeZones|/API/CodeSamples/AdditionalTimeZones]]|List of additional timezones.**(deprecated)**|null|
|AdHocConfig|[[AdHocConfig|/API/CodeSamples/AdHocConfig]]| Gets or sets the current Izenda.AdHoc.AdHocSettings.AdHocConfig - Ad Hoc configuration. |null|
|String|[[AdHocUserKey|/API/CodeSamples/AdHocUserKey]]|Gets or sets a single password limiting access to the report designer, report list and report viewer.|String.Empty|
|AggregateFunctionCollection|[[AggregateFunctions|/API/CodeSamples/AggregateFunctions]]||{None, AVG, COUNT, <br>COUNT_DISTINCT, MAX, MIN, <br>SUM, TimeSUM, SUM_DISTINCT, <br>GROUP_BY_DAY, GROUP_BY_MONTH, GROUP_BY_YEAR, <br>GROUP_BY_MONTH_NAME, GROUP_BY_DAY_OF_WEEK, GROUP_BY_DATE, <br>GROUP_BY_YEAR_AND_MONTH, GROUP_BY_YEAR_AND_MONTH_NAME, GROUP_BY_WEEK, <br>GROUP_BY_QUARTER, DAYS_OLD, AVG_DAYS_OLD, <br>SUM_DAYS_OLD, GROUP}|
|Boolean|[[AllowAnalysisGrid|/API/CodeSamples/AllowAnalysisGrid]]|Gets or sets the value indicating whether it is allowed analysis grid|True|
|Boolean|[[AllowArchivedReportTableCreation|/API/CodeSamples/AllowArchivedReportTableCreation]]|Gets or sets the value indicating whether it is allowed to create the database table            that contains archived reports if there is no such table in the database.|True|
|Boolean|[[AllowClientSorting|/API/CodeSamples/AllowClientSorting]]||True|
|Boolean|[[AllowComparativeArithmetic|/API/CodeSamples/AllowComparativeArithmetic]]|Gets or sets the value indicating whether comparative arithmetic is allowed in arithmetic checkbox.|False|
|Boolean|[[AllowCreateNewCategory|/API/CodeSamples/AllowCreateNewCategory]]|Gets or sets the value indicating the possibility to create new categories in Save As dialog.|True|
|Boolean|[[AllowDataFieldsInDescription|/API/CodeSamples/AllowDataFieldsInDescription]]|Gets or sets the value indicating whether any column names            (enclosed in square brackets) in the description of the report should be replaced            to the value of Details report cell placed in the first row and the specified column.|True|
|Boolean|[[AllowDeletingReports|/API/CodeSamples/AllowDeletingReports]]|Gets or sets the value indicating whether deleting reports is allowed.|True|
|Boolean|[[AllowDeltas|/API/CodeSamples/AllowDeltas]]|Gets or sets the value indicating whether "Add Deltas" checkbox should be shown             in fields.|False|
|Boolean|[[AllowDomainJoin|/API/CodeSamples/AllowDomainJoin]]|Gets or set value indicating domain join should be shown at report designer.|False|
|Boolean|[[AllowEqualsSelectForStoredProcedures|/API/CodeSamples/AllowEqualsSelectForStoredProcedures]]|Gets or sets the value indicating is it allowed to use Equals(Select) or Equals(Multiple) for filters in case when stored procedure used.|False|
|Boolean|[[AllowFieldsAsValue|/API/CodeSamples/AllowFieldsAsValue]]|Gets or sets the value indicating whether field name is allowed in filter value.|True|
|Boolean|[[AllowGroupWithoutSelect|/API/CodeSamples/AllowGroupWithoutSelect]]|Gets or sets value indicating if it is possible to make invisible fields which are used for Visual Grouping.**(deprecated)**|False|
|Boolean|[[AllowHorizontalBarChart|/API/CodeSamples/AllowHorizontalBarChart]]|Gets or sets the value indicating whether Horizontal Bar Chart is allowed|True|
|Boolean|[[AllowHtmlOutputsInScheduledReports|/API/CodeSamples/AllowHtmlOutputsInScheduledReports]]|Get or set value indicating allowing formats for scheduling reports**(deprecated)**|True|
|Boolean|[[AllowInvalidCharacters|/API/CodeSamples/AllowInvalidCharacters]]|Gets or sets the value indicating whether invalid characters in report namesare allowed if not striped.|False|
|Boolean|[[AllowInvertedGrid|/API/CodeSamples/AllowInvertedGrid]]|Gets or sets the value indicating whether "Invert" checkbox should be shown             in the summary tab.|False|
|Boolean|[[AllowLineOnBar|/API/CodeSamples/AllowLineOnBar]]|Gets or sets the value indicating whether is it allowed line on Bar chart.|True|
|Boolean|[[AllowMultilineHeaders|/API/CodeSamples/AllowMultilineHeaders]]|Gets or sets if headers can be multiline.|False|
|Boolean|[[AllowNewFiltersInReportViewer|/API/CodeSamples/AllowNewFiltersInReportViewer]]|Gets or sets the value indicating whether user can add new filters in the report viewer.|True|
|Boolean|[[AllowOverwritingReports|/API/CodeSamples/AllowOverwritingReports]]|Gets or sets the value indicating whether reports overwriting is allowed.|True|
|Boolean|[[AllowSelfJoin|/API/CodeSamples/AllowSelfJoin]]|Gets or sets the value indicating whether is it allowed datasources self join.|True|
|Boolean|[[AllowStackedBarChart|/API/CodeSamples/AllowStackedBarChart]]|Gets or sets the value indicating whether Stacked Bar Chart is allowed|True|
|Boolean|[[AllowSummaryDeltas|/API/CodeSamples/AllowSummaryDeltas]]|Gets or sets the value indicating whether "Show Summary Deltas" checkbox should be shown             in the summary tab.|True|
|Boolean|[[AllowVisualGroups|/API/CodeSamples/AllowVisualGroups]]|Gets or sets the value indicating whether visual groups are allowed.**(deprecated)**|True|
|String|[[ApplicationHeaderImageUrl|/API/CodeSamples/ApplicationHeaderImageUrl]]|Gets or sets the URL of the Header Logo.|String.Empty|
|Boolean|[[AutoJoinOnRenderedRows|/API/CodeSamples/AutoJoinOnRenderedRows]]| Gets or sets the value indicating whether auto-join function should work  for server-rendered rows in Izenda.AdHoc.AdHocSettings.JoinedTablesList**(deprecated)**|True|
|Boolean|[[AutoPostBackOnFilterChange|/API/CodeSamples/AutoPostBackOnFilterChange]]|Gets or sets the value indicating whether should be postback on filter change.|True|
|Boolean|[[CacheEqualsSelect|/API/CodeSamples/CacheEqualsSelect]]|Gets or sets the value indicating whether "Equals (Select)" value should be cached.|False|
|String|[[CacheFolder|/API/CodeSamples/CacheFolder]]|Gets or sets the folder where cache is stored|[drive]:\Temp\|
|Boolean|[[CacheQueries|/API/CodeSamples/CacheQueries]]| Gets or sets the value indicating whether all queries for the Izenda.AdHoc.Database.Driver should be cached. |True|
|Boolean|[[CacheReports|/API/CodeSamples/CacheReports]]|Gets or sets the value indicating whether all loaded reports should be cached.|True|
|Boolean|[[CacheSchema|/API/CodeSamples/CacheSchema]]| Gets or sets the value indicating whether Izenda.AdHoc.Database.Driver.DatabaseSchema should be cached. |True|
|Boolean|[[CacheStoredProcedureMetaDataToDisk|/API/CodeSamples/CacheStoredProcedureMetaDataToDisk]]|Gets or sets the value indicating is the information about the stored procedures will be cached on disk.|False|
|Boolean|[[CascadeFilterValues|/API/CodeSamples/CascadeFilterValues]]|Gets or sets the value indicating whether filter values will be cascaded.            For example, this will only show cities in the countries selected on the prior filter|True|
|Char|[[CategoryCharacter|/API/CodeSamples/CategoryCharacter]]|Get or set delimiter which is used to delimit category name and report name|\|
|Boolean|[[ChangParentUrlWhenRedirect|/API/CodeSamples/ChangParentUrlWhenRedirect]]||False|
|ChartingEngine|[[ChartingEngine|/API/CodeSamples/ChartingEngine]]|Defines which ChartingEngine will be used (ZedGraph, ComponentArt, or Dundas)|DundasChart|
|Int32|[[ChartLimit|/API/CodeSamples/ChartLimit]]|Gets or sets the value limiting chart items|500|
|ChartCollection|[[Charts|/API/CodeSamples/Charts]]| Gets or sets the collection of available Izenda.AdHoc.Charts. |{Trend, Pie, Plot, <br>Bar, Funnel, Visualization}|
|Point|[[ChartSize|/API/CodeSamples/ChartSize]]|Gets or sets the value indicating chart size.|{X=700,Y=300}|
|String[]|[[ChartSortFields|/API/CodeSamples/ChartSortFields]]|Gets or sets the value indicating the fields which will be used for sorting in a chart case.|String.Empty|
|Int32|[[CheckBoxListColumns|/API/CodeSamples/CheckBoxListColumns]]|Number of checkboxes columns in "Quick add" dialog in the report designer|2|
|Boolean|[[CheckForUpdates|/API/CodeSamples/CheckForUpdates]]|Gets or sets the value indicating whether AdHoc is check for updates.**(deprecated)**|False|
|Boolean|[[CheckUserPermission|/API/CodeSamples/CheckUserPermission]]|Get or set value indicating checking user permission|True|
|Boolean|[[CollapsedFiltersInReportViewer|/API/CodeSamples/CollapsedFiltersInReportViewer]]| Gets or set value indicating whether filters should be initially collapsed in Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|False|
|Unit|[[ColumnDropDownWidth|/API/CodeSamples/ColumnDropDownWidth]]|Gets or sets the width of column dropdown.|200px|
|CultureInfo|[[Culture|/API/CodeSamples/Culture]]|Gets or sets the default culture for Ad Hoc.|en-US|
|Boolean|[[CurrentUserIsAdmin|/API/CodeSamples/CurrentUserIsAdmin]]|Gets or sets a value indicating whether current user is admin.|True|
|Boolean|[[CurrentUserIsGlobalAdministrator|/API/CodeSamples/CurrentUserIsGlobalAdministrator]]|Defines if current user has global administrator rights**(deprecated)**|False|
|String|[[CurrentUserName|/API/CodeSamples/CurrentUserName]]|Gets or sets the name of the current user.|DefaultAdministrator|
|String[]|[[CurrentUserRoles|/API/CodeSamples/CurrentUserRoles]]|Gets or sets the the current user groups set.|System.String[] {}|
|String|[[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]]|This identifies what tenant the current user is associated with in a multi-tenant system.|String.Empty|
|CustomizeChartDelegate|[[CustomizeChartDelegate|/API/CodeSamples/CustomizeChartDelegate]]|Represents a method that runs before chart reports get run.|String.Empty|
|CustomTimePeriodCollection|[[CustomTimePeriods|/API/CodeSamples/CustomTimePeriods]]|Defines custom time periods, that can be used in 'In Time Period' filter.|null|
|DashboardDateSliderMode|[[DashboardDateSliderMode|/API/CodeSamples/DashboardDateSliderMode]]|Gets or sets the value indicating the size of division for Dashborad date slider.|Auto|
|String|[[DashboardDesignerUrl|/API/CodeSamples/DashboardDesignerUrl]]| Gets or sets the URL of a page used to design dashboards (Izenda.Web.UI.DashboardDesigner). |DashboardDesigner.aspx|
|String|[[DashboardDesignerUrlWithDelimiter|/API/CodeSamples/DashboardDesignerUrlWithDelimiter]]| Gets the Izenda.AdHoc.AdHocSettings.DashboardDesignerUrl with "?" or "&amp;" char at the end. |DashboardDesigner.aspx?|
|Int32|[[DashboardFieldsCount|/API/CodeSamples/DashboardFieldsCount]]|Gets or sets the count of additional reports.|3|
|Double|[[DashboardGaugeMax|/API/CodeSamples/DashboardGaugeMax]]|Gets or sets the gauge max value for "Dashboard Gauge" format.**(deprecated)**|1.79769313486232E+308|
|Double|[[DashboardGaugeMin|/API/CodeSamples/DashboardGaugeMin]]|Gets or sets the guage min value for "Dashboard Gauge" format.**(deprecated)**|-1.79769313486232E+308|
|Int32|[[DashboardGaugeWidth|/API/CodeSamples/DashboardGaugeWidth]]|Gets or sets value, indicating how long (minutes) reportSet output html will stay in cache. Zero means cache disabled.|200|
|Int32|[[DashboardMinimumWidth|/API/CodeSamples/DashboardMinimumWidth]]|Gets or set minimum dashboard width.**(deprecated)**|1000|
|Boolean|[[DashboardMode|/API/CodeSamples/DashboardMode]]|Gets or sets the value indicating whether dashboard mode is enabled.**(deprecated)**|False|
|String|[[DashboardsCss|/API/CodeSamples/DashboardsCss]]| Gets or sets the css style for the Izenda.Web.UI.TabStrip. **(deprecated)**|@import url(rs.aspx?css=dashboard);|
|String|[[DashboardsCssUrl|/API/CodeSamples/DashboardsCssUrl]]| Gets or sets the css stylesheet URL for the Izenda.Web.UI.TabStrip. |rs.aspx?css=dashboard|
|String|[[DashboardTabBackgroundImageUrl|/API/CodeSamples/DashboardTabBackgroundImageUrl]]|Gets or sets the URL of the tabs background image for Dashboard.|String.Empty|
|String|[[DashboardViewer|/API/CodeSamples/DashboardViewer]]|Gets or sets the URL of the dashboard viewer page.|ReportViewer.aspx|
|String|[[DashboardViewerWithDelimiter|/API/CodeSamples/DashboardViewerWithDelimiter]]|Gets the report viewer page with "?" or "&" char at the end.|ReportViewer.aspx?|
|String|[[DatabaseDiagramImageUrl|/API/CodeSamples/DatabaseDiagramImageUrl]]|Gets or sets the URL of image with database diagram.|String.Empty|
|Int32|[[DataCacheInterval|/API/CodeSamples/DataCacheInterval]]|Sets the number of seconds between cache refreshes.|0|
|NameDistinctValueCollection|[[DataSourceAliases|/API/CodeSamples/DataSourceAliases]]|Gets or sets the collection of key-value pairs where the key is the table name and            the value is a table alias.|null|
|NameStringsCollection|[[DataSourceCategories|/API/CodeSamples/DataSourceCategories]]|This allows to assign sets of datasources to different categories.|null|
|TimeSpan|[[DataSourceDropDownTimeout|/API/CodeSamples/DataSourceDropDownTimeout]]|Gets or sets the timeout between starting loading dropdown values from server            and redicecting to About page.|00:00:15|
|Unit|[[DataSourceDropDownWidth|/API/CodeSamples/DataSourceDropDownWidth]]|Gets or sets the width of data source dropdown.**(deprecated)**|190px|
|String|[[DataSourceHeading|/API/CodeSamples/DataSourceHeading]]|Renames the heading within the datasources tab of Izenda Reports.|Data Sources (Tables and Views)|
|Int32|[[DataSourceLimit|/API/CodeSamples/DataSourceLimit]]|Limits the number of data sources Izenda Reports allows to be used as data sources in a single report.|1000|
|Int32|[[DateArithmeticDecimalPlaces|/API/CodeSamples/DateArithmeticDecimalPlaces]]|Gets or sets the value indicating how many decimal places dates show up when comparing dates.|0|
|String|[[DatePickerLanguage|/API/CodeSamples/DatePickerLanguage]]|Friendly setter of the default culture for datepicker Ad Hoc.|String.Empty|
|String|[[Db2ConnectionString|/API/CodeSamples/Db2ConnectionString]]|Gets or sets the connection string for DB2|String.Empty|
|Int32|[[DdkValuesMaxAmount|/API/CodeSamples/DdkValuesMaxAmount]]|Gets or sets the maximum number of allowed drill-down keys|2|
|String|[[DefaultAlternatingItemColor|/API/CodeSamples/DefaultAlternatingItemColor]]|Sets the default alternating item color.|Gainsboro|
|String|[[DefaultHeaderForegroundColor|/API/CodeSamples/DefaultHeaderForegroundColor]]|Sets the default header foreground color.|White|
|String|[[DefaultItemForegroundColor|/API/CodeSamples/DefaultItemForegroundColor]]|Sets the default item forground color.|Black|
|Int32|[[DefaultItemsPerPage|/API/CodeSamples/DefaultItemsPerPage]]|Changes the default items shown in the report viewer per page.|10000|
|Int32|[[DefaultLinesPerItem|/API/CodeSamples/DefaultLinesPerItem]]|Gets or sets the default count of lines per item for "Multi-Line" feature.|1|
|String|[[DefaultLoadTab|/API/CodeSamples/DefaultLoadTab]]|Gets or sets the name of tab with is loaded by default.|Fields|
|Int32|[[DefaultPreviewResults|/API/CodeSamples/DefaultPreviewResults]]|Changes the default number of results shown in the report designer preview tab.|100|
|String|[[DefaultReportBorderColor|/API/CodeSamples/DefaultReportBorderColor]]|Sets the default border color for reports.|White|
|String|[[DefaultReportHeaderColor|/API/CodeSamples/DefaultReportHeaderColor]]|Sets the default report header color.|DarkSlateBlue|
|String|[[DefaultReportItemColor|/API/CodeSamples/DefaultReportItemColor]]|Sets the default report item color.|White|
|StringCollection|[[DefaultReportOrder|/API/CodeSamples/DefaultReportOrder]]|Gets or sets the default report order.|{Chart, Chart2, Chart3, <br>Chart4, Gauges, Summary, <br>Detail, Maps}|
|String|[[DefaultSharingRights|/API/CodeSamples/DefaultSharingRights]]|Gets or sets the Default Sharing Rights|None|
|String|[[DefaultTable|/API/CodeSamples/DefaultTable]]|Gets or sets the default table which is automatically added to new report.|String.Empty|
|String|[[DefaultUserName|/API/CodeSamples/DefaultUserName]]|This settings allows the user to set the default username for users logged into the Izenda Reports web application.|DefaultAdministrator|
|String|[[DefaultVisibilityForNonAdmins|/API/CodeSamples/DefaultVisibilityForNonAdmins]]|Gets or sets the default default visibility group for non admins.|OnlyMe|
|Unit|[[DescriptionWidth|/API/CodeSamples/DescriptionWidth]]|Gets or sets the width of description edit.|100px|
|NameValueCollection|[[DetailReportFormatString|/API/CodeSamples/DetailReportFormatString]]|Gets or sets the extended link formats for "Detail Link" format.**(deprecated)**|null|
|Boolean|[[Distinct|/API/CodeSamples/Distinct]]| Gets or sets the initial value for Izenda.AdHoc.Report.Distinct field. |True|
|Boolean|[[DistinctSubtotalInnerQuery|/API/CodeSamples/DistinctSubtotalInnerQuery]]|Gets or sets the value indicating whether DISTINCT option should be used            in inner query for the subtotals calculating.|True|
|FormatCollection|[[DrillDownStyle|/API/CodeSamples/DrillDownStyle]]|Gets or sets the list of available drill-down report fields formats.|{DetailLink, DetailLinkNewWindow, <br>EmbeddedDetail, DetailLinkPopup}|
|AggregateFunctionCollection|[[DundasAggregateFunctions|/API/CodeSamples/DundasAggregateFunctions]]||{None, AVG, COUNT, <br>COUNT_DISTINCT, SUM}|
|String|[[EmailFromAddress|/API/CodeSamples/EmailFromAddress]]|Email from address for the automated scheduler.|adhoc@yourdomain.com|
|String|[[EmailSubjectFormatString|/API/CodeSamples/EmailSubjectFormatString]]|Gets or set subject of the emailed report for scheduler.|{0}|
|Boolean|[[EmbedReportInServerEmail|/API/CodeSamples/EmbedReportInServerEmail]]|Gets or sets the value indicating whether report will be embedded in the server email.|False|
|String|[[EmptyReportString|/API/CodeSamples/EmptyReportString]]||String.Empty|
|Int32|[[EqualsDropDownLimit|/API/CodeSamples/EqualsDropDownLimit]]|Limits the number of (options) rows selectable through an equals (drop down) filter.**(deprecated)**|2000|
|Int32|[[EqualsDropDownTimeout|/API/CodeSamples/EqualsDropDownTimeout]]|Gets or sets the wait time in seconds for "Equals (Select)"            dropdown values loading.**(deprecated)**|10|
|Dictionary|[[EqualsPopupDestinations|/API/CodeSamples/EqualsPopupDestinations]]|Gets or sets the value indicating which aspx page will be used for column in Equlas Popup filter.|null|
|String|[[EqualsSelectDateFormat|/API/CodeSamples/EqualsSelectDateFormat]]|Gets or sets default date format utilized by the equals select filters.**(deprecated)**|MM/dd/yyyy|
|Int32|[[EqualsSelectLimit|/API/CodeSamples/EqualsSelectLimit]]|Limits the number of (options) rows selectable through an equals (drop down) filter.|500|
|String|[[EqualsSelectText|/API/CodeSamples/EqualsSelectText]]|Gets or sets the text of "Equals (Select)" operator.|Equals (Select)|
|Int32|[[EqualsSelectTimeout|/API/CodeSamples/EqualsSelectTimeout]]|Gets or sets the wait time in seconds for "Equals (Select)"            dropdown values loading.|60|
|String|[[ErrorIzendaReplacement|/API/CodeSamples/ErrorIzendaReplacement]]|Gets or set value wich will replace "Izenda" word in StackTrace while exception|Izenda|
|String[]|[[ExistingDatabaseConstraints|/API/CodeSamples/ExistingDatabaseConstraints]]|Gets database constraints.|System.String[] {} - Depends on your database's constraints|
|Boolean|[[ExpandCategorizedReports|/API/CodeSamples/ExpandCategorizedReports]]|Gets or sets the value indicating whether categorized             reports should be expanded by default.|True|
|Boolean|[[ExpandVisualGroupGrids|/API/CodeSamples/ExpandVisualGroupGrids]]|Gets or sets the value indicating visual groups are expanded by default.|True|
|Encoding|[[ExportEncoding|/API/CodeSamples/ExportEncoding]]||null|
|TextSharpFontWrapper|[[ExportFont|/API/CodeSamples/ExportFont]]|Gets or sets the font for the PDF and RTF outputs.|null|
|Int32|[[ExportLimit|/API/CodeSamples/ExportLimit]]|Gets or set value indicating ReportSet max row count while export|100000|
|NameValueCollection|[[ExtendedFormats|/API/CodeSamples/ExtendedFormats]]|Gets or sets the collection of names and values of additional formats            which should be displayed in "Formats" dropdown lists.**(deprecated)**|null|
|String[]|[[ExtendedFunctions|/API/CodeSamples/ExtendedFunctions]]|Gets or sets the array of additional functions to display in every            "Functions" dropdown lists.|System.String[] {}|
|NameValueCollection|[[FieldAliases|/API/CodeSamples/FieldAliases]]|Gets or sets the collection of key-value pairs where the key is the field name and            the value is a field alias.|null|
|Unit|[[FieldDropDownWidth|/API/CodeSamples/FieldDropDownWidth]]|Gets or sets the width of field dropdown.|200px|
|String|[[FieldFilterRegex|/API/CodeSamples/FieldFilterRegex]]|Gets or sets the regular expression used for column filtering.            If name of a column matches this expression then it will not be shown.**(deprecated)**|MD5&#124;^(Passw)|
|Int32|[[FieldLimit|/API/CodeSamples/FieldLimit]]|Limits the number of fields Izenda Reports allows to be used in a single report.|1000|
|FieldList|[[FieldList|/API/CodeSamples/FieldList]]| Gets or sets the default Izenda.AdHoc.AdHocSettings.FieldList control. **(deprecated)**|null|
|String|[[FieldsRegex|/API/CodeSamples/FieldsRegex]]|Gets or sets the regular expression used for column filtering in Field tab.            If name of a column matches this expression then it will not be shown in fields select in Field tab.|MD5&#124;^(Passw)|
|String|[[FieldValueCssUrl|/API/CodeSamples/FieldValueCssUrl]]|Css file to be used on reports with Field&#124;Value style.|rs.aspx?css=FieldValue|
|Unit|[[FilterParameterWidth|/API/CodeSamples/FilterParameterWidth]]|Gets or sets the width of filter parameter edit.|300px|
|String|[[FiltersCustomPagesPath|/API/CodeSamples/FiltersCustomPagesPath]]|Gets or sets the relative path to the Equals(PopUp) custom pages.|String.Empty|
|String|[[FiltersRegex|/API/CodeSamples/FiltersRegex]]|Gets or sets the regular expression used for column filtering in Filter tab.            If name of a column matches this expression then it will not be shown in fields select in Filter tab.|MD5&#124;^(Passw)|
|Boolean|[[ForceNewNameOnSave|/API/CodeSamples/ForceNewNameOnSave]]|This feature always uses the save as function and requires the user to specify a report name when saving.|False|
|Unit|[[FormatDropDownWidth|/API/CodeSamples/FormatDropDownWidth]]|Gets or sets the width of format dropdown.|190px|
|FormatCollection|[[Formats|/API/CodeSamples/Formats]]|Gets or sets the list of available fields formats.|String.Empty|
|String|[[FormDesignerUrl|/API/CodeSamples/FormDesignerUrl]]||./Forms/FormDesigner.aspx|
|Unit|[[FunctionDropDownWidth|/API/CodeSamples/FunctionDropDownWidth]]|Gets or sets the width of function dropdown.|182px|
|Int32|[[GaugeHeight|/API/CodeSamples/GaugeHeight]]|Gets or sets the gauge height for "Gauge" format.|50|
|Double|[[GaugeMaximum|/API/CodeSamples/GaugeMaximum]]|Gets or sets the maximum value of gauge.**(deprecated)**|1|
|Double|[[GaugeMinimum|/API/CodeSamples/GaugeMinimum]]|Gets or sets the minimum value of gauge.**(deprecated)**|0|
|String[]|[[GaugeStyles|/API/CodeSamples/GaugeStyles]]|Gets or sets custom gauge types.|String.Empty|
|Int32|[[GaugeWidth|/API/CodeSamples/GaugeWidth]]|Gets or sets the gauge width for "Gauge" format.|250|
|Boolean|[[GenerateParameterizedSql|/API/CodeSamples/GenerateParameterizedSql]]|Gets or sets the value indicating whether queries to the database should            be parameterized.|True|
|Boolean|[[GenerateThumbnails|/API/CodeSamples/GenerateThumbnails]]|Gets or sets the value indicating whether reports thumbnails should popup in the ReportList.|False|
|String|[[GeoDataTable|/API/CodeSamples/GeoDataTable]]|Gets or sets the value indicating the table name wich contains geodata for maps.|String.Empty|
|GetEqualsSelectValuesDelegate|[[GetEqualsSelectValues|/API/CodeSamples/GetEqualsSelectValues]]|Represents a method that returns values for  operator.|String.Empty|
|TableItemStyle|[[GridHeaderStyle|/API/CodeSamples/GridHeaderStyle]]|Gets or sets the OpenOffice output style for report results grid header.|null|
|TableItemStyle|[[GridItemStyle|/API/CodeSamples/GridItemStyle]]|Gets or sets the Excel output style for report results grid item.|null|
|Color|[[HeaderForegroundColor|/API/CodeSamples/HeaderForegroundColor]]|Gets or sets the color of report header.|Color [White]|
|String|[[HeaderStyle|/API/CodeSamples/HeaderStyle]]| Gets or sets the style for the Izenda.AdHoc.AdHocSettings.JoinedTablesList, Izenda.AdHoc.AdHocSettings.FieldList and Izenda.Web.UI.FilterList headers. |font-family: verdana, arial, helvetica, sans-serif; font-size: 11px;color:black;|
|NameValueCollection|[[HelpText|/API/CodeSamples/HelpText]]|Gets or sets the collection of key-value pairs where the key is the tab name and            the value is a hint that will be shown when mouse is over the appropriate tab.|null|
|String[]|[[HiddenCategories|/API/CodeSamples/HiddenCategories]]|Sets which categories are hidden for the current user|String.Empty|
|String[]|[[HiddenColumns|/API/CodeSamples/HiddenColumns]]|Gets or sets the array of Column names should be hidden in fileds dropdown.|String.Empty|
|HiddenFilterCollection|[[HiddenFilters|/API/CodeSamples/HiddenFilters]]|This controls row-level security throughout the tool.  This should be used in all multi-tenant systems and systems where users are restricted to certain records|null|
|List|[[HiddenTimeZones|/API/CodeSamples/HiddenTimeZones]]|List of timezones to hide.**(deprecated)**|null|
|String|[[IdentifiersRegex|/API/CodeSamples/IdentifiersRegex]]||String.Empty|
|String|[[ImagesPath|/API/CodeSamples/ImagesPath]]| Gets or sets the path of the folder which contains the images used by Ad Hoc. If the value is null then built-in images will be used. |String.Empty|
|Boolean|[[InheritFiltersInSubreports|/API/CodeSamples/InheritFiltersInSubreports]]|Gets or sets the value indicating whether filters will be inherited in subreports.|True|
|String|[[InstantReport|/API/CodeSamples/InstantReport]]|Gets or sets the URL of the report viewer page.|InstantReport.aspx|
|String|[[InstantReportWithDelimiter|/API/CodeSamples/InstantReportWithDelimiter]]|Gets the instant report page with "?" or "&" char at the end.|InstantReport.aspx?|
|Boolean|[[InvalidateSchemaOnNew|/API/CodeSamples/InvalidateSchemaOnNew]]|Gets or sets the value indicating whether database schema is invalidated then            user creates new report.|False|
|Int32|[[InvertedGridLimit|/API/CodeSamples/InvertedGridLimit]]|Gets or sets the maximum count of rows for inverted grid.|36|
|Color|[[ItemForegroundColor|/API/CodeSamples/ItemForegroundColor]]|Gets or sets the color of report header.|Color [Black]|
|Unit|[[JoinDropDownWidth|/API/CodeSamples/JoinDropDownWidth]]|Gets or sets the width of join type dropdown.|100px|
|JoinedTablesList|[[JoinedTablesList|/API/CodeSamples/JoinedTablesList]]| Gets or sets the default Izenda.AdHoc.AdHocSettings.JoinedTablesList control. **(deprecated)**|null|
|String|[[JoinFieldRegex|/API/CodeSamples/JoinFieldRegex]]|Gets or sets the regular expression used for table filtering.            If name of a table or a column matches this expression then it will be excluded|String.Empty|
|NameValueCollection|[[LabelAliases|/API/CodeSamples/LabelAliases]]|Gets or sets the collection of key-value pairs where the key is the field name and            the value is a field alias.|null|
|AdHocLanguage|[[Language|/API/CodeSamples/Language]]|Friendly setter of the default culture for Ad Hoc.|English|
|Boolean|[[LazySpMetadataPulling|/API/CodeSamples/LazySpMetadataPulling]]||False|
|Char|[[LiteralComma|/API/CodeSamples/LiteralComma]]|Gets or sets the delimiter separating items in the 'Equals' filter operator value.|,|
|Boolean|[[LockViewer|/API/CodeSamples/LockViewer]]|Gets or sets the value indicating whether Report Viewer will be locked or not.|False|
|String|[[LoginUrl|/API/CodeSamples/LoginUrl]]|Gets or sets login page Url.|Login.aspx|
|MapInfoCollection|[[MapInfoCollection|/API/CodeSamples/MapInfoCollection]]|Gets or sets the registered maps data.|{World, Europe, <br>USA, Australia}|
|Size|[[MaxImageSize|/API/CodeSamples/MaxImageSize]]|Gets or sets the maximum image size of the report images.            If the size of an image is larger than the specified value then            the image will be scaled.|{Width=320, Height=240}|
|Int32|[[MaximumReportSizeForCache|/API/CodeSamples/MaximumReportSizeForCache]]||1048576|
|Single|[[MaxVersion|/API/CodeSamples/MaxVersion]]|Gets Max Version.|6.8|
|Unit|[[MinPdfFontSize|/API/CodeSamples/MinPdfFontSize]]|Sets the minium font size that will be used when creating a PDF document. Default is 10 point.|10pt|
|Boolean|[[MultiLevelVisualGrouping|/API/CodeSamples/MultiLevelVisualGrouping]]|Gets or set value indicating whether Visual Groups should be multi-level.**(deprecated)**|True|
|String|[[MySqlConnectionString|/API/CodeSamples/MySqlConnectionString]]|Gets or sets the connection string for MySQL.|String.Empty|
|String|[[NoDataSourcePage|/API/CodeSamples/NoDataSourcePage]]|Gets or sets url of the page where user will be redirected if            there is no tables in a data base|Settings.aspx|
|Int32|[[NumChartPerRow|/API/CodeSamples/NumChartPerRow]]|Gets or set value indicating number of charts in one reports row|2|
|Int32|[[NumChartTabs|/API/CodeSamples/NumChartTabs]]|Gets or set value indicating maximum possibile charts for the report set.|2|
|Int32|[[NumSharedDropdowns|/API/CodeSamples/NumSharedDropdowns]]|Gets or sets the maximum number of user/roles a report can be shared with.|3|
|Boolean|[[OpenCustomUrlInNewWindow|/API/CodeSamples/OpenCustomUrlInNewWindow]]|Gets or sets the value indicating whether CustomUrl field links should open in a new window.|True|
|Int32|[[OracleCommandTimeout|/API/CodeSamples/OracleCommandTimeout]]|Sets the time Izenda Reports will wait for an Oracle command to execute before timing out.|3600|
|String|[[OracleConnectionString|/API/CodeSamples/OracleConnectionString]]|Gets or sets the connection string for Oracle.|String.Empty|
|ReportOutputGeneratorCollection|[[OutputTypes|/FAQ/Formatting/How-do-I-hide-Output-Types]]| Gets or sets the registered Izenda.AdHoc.ReportOutputGenerators. |{SQL, PDF, HTMLREPORT, <br>CSV, BULKCSV, XLS(MIME), <br>DOC, XML, JSON, <br>JSA}|
|String|[[ParentReportDesignerUrl|/API/CodeSamples/ParentReportDesignerUrl]]||String.Empty|
|String|[[ParentReportListUrl|/API/CodeSamples/ParentReportListUrl]]||String.Empty|
|String|[[ParentReportViewerUrl|/API/CodeSamples/ParentReportViewerUrl]]||String.Empty|
|String|[[ParentSettingsUrl|/API/CodeSamples/ParentSettingsUrl]]||String.Empty|
|Boolean|[[PerUserCaching|/API/CodeSamples/PerUserCaching]]| Gets or sets the value indicating whether Izenda.AdHoc.Database.Driver.DatabaseSchema should be cached. |False|
|Int32|[[PivotFieldLimit|/API/CodeSamples/PivotFieldLimit]]|Limit for how many pivot columns are in a report.|100|
|String|[[PostgreSQLConnectionString|/API/CodeSamples/PostgreSQLConnectionString]]|Gets or sets the connection string for Postgres.|String.Empty|
|Int32|[[PreviewColumnLimit|/API/CodeSamples/PreviewColumnLimit]]|Gets or set value indicating number of columns to show in preview|100|
|String|[[PreviewColumnLimitMessage|/API/CodeSamples/PreviewColumnLimitMessage]]|Gets or set value indicating message displayed when PreviewColumnLimit is exceeded|Reports with more than 100 fields must be exported to CSV.  Please check CSV Export to view data.|
|Int32|[[PreviewTimeout|/API/CodeSamples/PreviewTimeout]]| Gets or sets the System.Data.IDbCommand.CommandTimeout for SQL commands. |0|
|PrintMode|[[PrintMode|/API/CodeSamples/PrintMode]]|Gets or sets the value indicating what print mode will be used, PDF or HTML.|PdfAndHtml|
|ProcessFiltersDelegate|[[ProcessFiltersDelegate|/API/CodeSamples/ProcessFiltersDelegate]]| Represents a method that handles Izenda.AdHoc.Report execution. **(deprecated)**|String.Empty|
|Int32|[[QuickAddFieldWidth|/API/CodeSamples/QuickAddFieldWidth]]|Gets or set value indicating max length of string in one QuickAdd column|20|
|Int32|[[QuickAddMinElementsInColumn|/API/CodeSamples/QuickAddMinElementsInColumn]]|Gets or set value indicating how many elements are in one QuickAdd column|20|
|String|[[RDLFolder|/API/CodeSamples/RDLFolder]]|Gets or sets path to Folder where RDL files whould be saved|RDLFiles|
|Int32|[[RecentlyUpdatedCountAtReportList|/API/CodeSamples/RecentlyUpdatedCountAtReportList]]|Gets or sets the value indicating how many reports will shown at recent list at ReportList|0|
|Color|[[ReportAlternatingItemColor|/API/CodeSamples/ReportAlternatingItemColor]]|Gets or sets the color of report alternating item.|Color [Gainsboro]|
|Color|[[ReportBorderColor|/API/CodeSamples/ReportBorderColor]]|Gets or sets the color of report border.|Color [White]|
|String|[[ReportCss|/API/CodeSamples/ReportCss]]|Gets or sets the css style for the report HTML and Word output.**(deprecated)**|@import url(rs.aspx?css=Report);|
|String|[[ReportCssUrl|/API/CodeSamples/ReportCssUrl]]|Css file to be used on reports generated by Izenda Reports.|rs.aspx?css=Report|
|String|[[ReportDesignerUrl|/API/CodeSamples/ReportDesignerUrl]]| Gets or sets the URL of a page used to design reports (Izenda.Web.UI.ReportDesigner page). |ReportDesigner.aspx|
|String|[[ReportDesignerUrlWithDelimiter|/API/CodeSamples/ReportDesignerUrlWithDelimiter]]| Gets the Izenda.AdHoc.AdHocSettings.ReportDesignerUrl with "?" or "&amp;" char at the end. |ReportDesigner.aspx?|
|Color|[[ReportHeaderColor|/API/CodeSamples/ReportHeaderColor]]|Gets or sets the color of report header.|Color [DarkSlateBlue]|
|Image|[[ReportHeaderImage|/API/CodeSamples/ReportHeaderImage]]||String.Empty|
|String|[[ReportHeaderImageUrl|/API/CodeSamples/ReportHeaderImageUrl]]|Gets or sets the image which will be shown at the top of the report.|String.Empty|
|String|[[ReportingService2005Url|/API/CodeSamples/ReportingService2005Url]]|Gets or sets the base URL of the XML Web service.|http://localhost/ReportServer/ReportService2005.asmx|
|Color|[[ReportItemColor|/API/CodeSamples/ReportItemColor]]|Gets or sets the color of report item.|Color [White]|
|String|[[ReportList|/API/CodeSamples/ReportList]]|Gets or sets the URL of the report list page.|ReportList.aspx|
|ReportListSettings|[[ReportListSettings|/API/CodeSamples/ReportListSettings]]|Gets or sets the value indicating ReportList display**(deprecated)**|HideAll|
|ReportSetEventWatcherCollection|[[ReportSetEventWatchers|/API/CodeSamples/ReportSetEventWatchers]]| Gets or sets the collection of registered Izenda.AdHoc.IReportSetEventWatcher which can do some actions on Izenda.AdHoc.ReportSet-related events. |null|
|String|[[ReportsPath|/API/CodeSamples/ReportsPath]]| Gets or sets the path of the folder where Izenda.AdHoc.FileSystemAdHocConfig stores its reports. If the value is null then reports will be stored in "Reports" subfolder of application folder. |[drive]:\[ApplicationFolder]\Reports|
|Boolean|[[ReportsSharedByDefault|/API/CodeSamples/ReportsSharedByDefault]]||True|
|StorageMode|[[ReportStorageMode|/API/CodeSamples/ReportStorageMode]]|Defines how reports are stored - in the file system or in the database**(deprecated)**|Filesystem|
|ReportTypeCollection|[[ReportTypes|/API/CodeSamples/ReportTypes]]|Gets or sets the report types.**(deprecated)**|{Detail, Summary, Chart, <br>Gauge}|
|String|[[ReportViewer|/API/CodeSamples/ReportViewer]]|Gets or sets the URL of the report viewer page.|ReportViewer.aspx|
|Int32|[[ReportViewerDefaultPreviewResults|/API/CodeSamples/ReportViewerDefaultPreviewResults]]|Specifies the default number of results previewed in the report view page for all reports.|100|
|String|[[ReportViewerPostHtml|/API/CodeSamples/ReportViewerPostHtml]]|Gets or sets the string contains html code that placing after the            entire HtmlOutputReportResults section.**(deprecated)**|String.Empty|
|String|[[ReportViewerPreHtml|/API/CodeSamples/ReportViewerPreHtml]]|Gets or sets the string contains html code that placing before the            entire HtmlOutputReportResults section.**(deprecated)**|String.Empty|
|Int32|[[ReportViewerRefreshInterval|/API/CodeSamples/ReportViewerRefreshInterval]]|Gets or sets the milliseconds between preview auto-refresh.            If 0 then there no auto-refresh.**(deprecated)**|0|
|String|[[ReportViewerWithDelimiter|/API/CodeSamples/ReportViewerWithDelimiter]]|Gets the report viewer page with "?" or "&" char at the end.|ReportViewer.aspx?|
|String|[[ReportViewPageTitle|/API/CodeSamples/ReportViewPageTitle]]|Gets or sets the title of report view page.|String.Empty|
|Boolean|[[RequireLogin|/API/CodeSamples/RequireLogin]]|This setting tells Izenda Reports to use the login page specified above in the Login URL setting.|False|
|String|[[ResponseServer|/API/CodeSamples/ResponseServer]]| Gets or sets the URL of the Izenda.AdHoc.ResponseServer page. |rs.aspx|
|String|[[ResponseServerWithDelimiter|/API/CodeSamples/ResponseServerWithDelimiter]]| Gets the Izenda.AdHoc.AdHocSettings.ResponseServer page with "?" or "&amp;" char at the end. |rs.aspx?|
|String|[[ResponseServerWithDelimiterFull|/API/CodeSamples/ResponseServerWithDelimiterFull]]||rs.aspx?|
|Int32[]|[[ResultsDropdownValues|/API/CodeSamples/ResultsDropdownValues]]|Gets or sets the list of the values in the preview results dropdown dialog.|System.Int32[]|
|String|[[SavedReportsTable|/API/CodeSamples/SavedReportsTable]]|Gets or sets the table name for saved reports.|IzendaAdHocReports|
|String|[[SaveReportSetNextUrl|/API/CodeSamples/SaveReportSetNextUrl]]|Gets or sets the URL of the report viewer page.|String.Empty|
|String|[[ScheduledReportsUrlFormatString|/API/CodeSamples/ScheduledReportsUrlFormatString]]|Gets or sets the url that is sent via email as the report web address.|http://localhost:57642/ReportViewer.aspx?{0}|
|SchedulerOutputCollection|[[SchedulerExports|/API/CodeSamples/SchedulerExports]]||{}|
|SchedulerOutputCollection|[[SchedulerOutputTypes|/API/CodeSamples/SchedulerOutputTypes]]|Get or set value indicating allowed formats for scheduling reports|{Link, Embedded, PDF, <br>CSV, HTML, XLS(MIME)}|
|String|[[SchedulerTenantID|/API/CodeSamples/SchedulerTenantID]]|Gets or sets the tenantId for scheduler.**(deprecated)**|String.Empty|
|TimeSpan|[[SchemaCacheTimeout|/API/CodeSamples/SchemaCacheTimeout]]|Gets or sets the time span for schema caching.|1.00:00:00|
|String|[[ScriptDirectory|/API/CodeSamples/ScriptDirectory]]||String.Empty|
|Unit|[[SelectValueDropDownWidth|/API/CodeSamples/SelectValueDropDownWidth]]|Gets or sets the width of filter values dropdown.|300px|
|Boolean|[[ServiceMode|/API/CodeSamples/ServiceMode]]|Gets or set value indication service mode**(deprecated)**|False|
|String|[[SettingsKey|/API/CodeSamples/SettingsKey]]|Gets or sets password to access Settings control|String.Empty|
|String|[[SettingsPageUrl|/API/CodeSamples/SettingsPageUrl]]| Gets or sets the URL of the Izenda.AdHoc.Settings page. |Settings.aspx|
|String[]|[[SharedWithValues|/API/CodeSamples/SharedWithValues]]|This sets the users or roles available in the Shared With dropdown of the Misc tab in the report designer.|String.Empty|
|Boolean|[[ShowAddAll|/API/CodeSamples/ShowAddAll]]| Gets or sets the value indicating whether AddAll button and dropdown should be shown in the Izenda.AdHoc.AdHocSettings.FieldList. **(deprecated)**|False|
|Boolean|[[ShowAddFieldInReportViewer|/API/CodeSamples/ShowAddFieldInReportViewer]]||True|
|Boolean|[[ShowAdminButton|/API/CodeSamples/ShowAdminButton]]|Gets or sets the value indicating showing buttons for administration**(deprecated)**|True|
|Boolean|[[ShowAdvancedChartingButton|/API/CodeSamples/ShowAdvancedChartingButton]]| Gets or sets the value indicating whether "Show Advanced" button should be shown  in the Izenda.Web.UI.ChartControl. |True|
|Boolean|[[ShowAllInPreview|/API/CodeSamples/ShowAllInPreview]]|Gets or sets the value indicating whether "CombinedTop Count" dropdown list should have the            "All" item in preview.|True|
|Boolean|[[ShowAllInResults|/API/CodeSamples/ShowAllInResults]]|Gets or sets the value indicating whether "CombinedTop Count" dropdown list should have the            "All" item in results.|True|
|Boolean|[[ShowAllTables|/API/CodeSamples/ShowAllTables]]|Gets or sets the value indicating whether all tables should be shown in tables dropdown.**(deprecated)**|True|
|Boolean|[[ShowArithmeticInSummary|/API/CodeSamples/ShowArithmeticInSummary]]| Gets or sets the value indicating whether arithmetic operations are shown in the  summary tab of Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowArithmeticOperations|/API/CodeSamples/ShowArithmeticOperations]]| Gets or sets the value indicating whether arithmetic operations are shown in Izenda.AdHoc.AdHocSettings.FieldList. |True|
|Boolean|[[ShowBackButton|/API/CodeSamples/ShowBackButton]]| Gets or sets the value indicating whether "Back" button should be shown in the Izenda.Web.UI.AdHocToolbarNavigation. |False|
|Boolean|[[ShowBetweenDateCalendar|/API/CodeSamples/ShowBetweenDateCalendar]]||True|
|Boolean|[[ShowBulkCSVButton|/API/CodeSamples/ShowBulkCSVButton]]|Gets or sets the value indicating possibility export to BulkCSV**(deprecated)**|False|
|Boolean|[[ShowCategoryTextboxInSaveDialog|/API/CodeSamples/ShowCategoryTextboxInSaveDialog]]|Gets or sets the value indicating whether category checkbox should be shown            in the save dialog.|True|
|Boolean|[[ShowChartLegend|/API/CodeSamples/ShowChartLegend]]|Gets or sets the value indicating whether chart legend should be shown.|True|
|Boolean|[[ShowChartTab|/API/CodeSamples/ShowChartTab]]|Gets or sets the value indicating whether chart tab should be shown.|True|
|Boolean|[[ShowClientEmailButton|/API/CodeSamples/ShowClientEmailButton]]|Gets or sets the value indicating whether the email from client icon should be            shown in the toolbar.|True|
|Boolean|[[ShowConstraintsSettings|/API/CodeSamples/ShowConstraintsSettings]]|Gets or sets the value indicating allows edit constraints settings.**(deprecated)**|False|
|Boolean|[[ShowContinueLinks|/API/CodeSamples/ShowContinueLinks]]|This setting enables or disables the "Continue to" buttons in report designer that assist walking a user through the tabs in report designer.|True|
|Boolean|[[ShowCSVButton|/API/CodeSamples/ShowCSVButton]]|Gets or sets the value indicating possibility export to CSV|True|
|Boolean|[[ShowCustomFormatType|/API/CodeSamples/ShowCustomFormatType]]|Gets or sets the value indicating whether "Custom" format type            should be shown in formats dropdown.|False|
|Boolean|[[ShowDashboardAddDropDown|/API/CodeSamples/ShowDashboardAddDropDown]]|Gets or sets a value indicating whether "add dashboard subreport" should be shown as DropDownList control.**(deprecated)**|False|
|Boolean|[[ShowDashboardFieldsTab|/API/CodeSamples/ShowDashboardFieldsTab]]| Gets or sets the value indicating whether Izenda.Web.UI.AdHocReportDesigner tab with dashboard fields is shown. |False|
|Boolean|[[ShowDashboardPartViewerLinks|/API/CodeSamples/ShowDashboardPartViewerLinks]]|Gets or sets the value indicating whether Dashboard Viewer will have edit links for it's reports|True|
|Boolean|[[ShowDashboardSettings|/API/CodeSamples/ShowDashboardSettings]]|Gets or sets the value indicating allows edit dashboard settings**(deprecated)**|False|
|Boolean|[[ShowDatabaseDiagramIcon|/API/CodeSamples/ShowDatabaseDiagramIcon]]|Gets or sets the value indicating whether the Database Diagram icon should be            shown in the toolbar.|True|
|Boolean|[[ShowDatabaseTypes|/API/CodeSamples/ShowDatabaseTypes]]|Gets or set value indicating whether database types should be shown in the fields dropdown.|False|
|Boolean|[[ShowDataSourcesAsCheckBoxes|/API/CodeSamples/ShowDataSourcesAsCheckBoxes]]|Gets or sets the value indicating mode of data sources list is showed.|True|
|Boolean|[[ShowDataSourcesTab|/API/CodeSamples/ShowDataSourcesTab]]| Gets or sets the value indicating whether Izenda.Web.UI.AdHocReportDesigner tab with data sources list is showed. |True|
|Boolean|[[ShowDataWhenParametersBlank|/API/CodeSamples/ShowDataWhenParametersBlank]]|Gets or sets the value indicating whether data should be shown            in report viewer if all parameters is blank.**(deprecated)**|True|
|Boolean|[[ShowDescriptionsInReportsTab|/API/CodeSamples/ShowDescriptionsInReportsTab]]| Gets or sets the value indicating whether reports descriptions should be shown in the reports tab of Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|False|
|Boolean|[[ShowDesignDashboardLink|/API/CodeSamples/ShowDesignDashboardLink]]|Gets or sets the value indicating whether design new dashboard link is shown|True|
|Boolean|[[ShowDesignLinkInReportViewer|/API/CodeSamples/ShowDesignLinkInReportViewer]]| Gets or set value indicating whether design link should be shown in Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|True|
|Boolean|[[ShowDesignLinks|/API/CodeSamples/ShowDesignLinks]]|Gets or sets a value indicating whether design links should be shown in report list and in the toolbar.|True|
|Boolean|[[ShowDetailFormat|/API/CodeSamples/ShowDetailFormat]]|Gets or sets the value indicating whether "Detail Link" format            should be shown in formats dropdown.**(deprecated)**|True|
|Boolean|[[ShowDistinct|/API/CodeSamples/ShowDistinct]]|Gets or set value indicating whether "Distinct" should be shown at the Data Source tab.|True|
|Boolean|[[ShowDOCButton|/API/CodeSamples/ShowDOCButton]]|Gets or sets the value indicating possibility export to DOC|True|
|Boolean|[[ShowEtlButton|/API/CodeSamples/ShowEtlButton]]|Gets or sets the value indicating whether the upload data button should be            shown in the report viewer.|False|
|Boolean|[[ShowFieldAsValueDropDown|/API/CodeSamples/ShowFieldAsValueDropDown]]|Gets or sets the value indicating whether fields dropdown will be shown as value            on "Is Less Then (Field)", "Is Greater Then (Field)" and "Equals (Field)" operators.|True|
|Boolean|[[ShowFieldsTab|/API/CodeSamples/ShowFieldsTab]]| Gets or sets the value indicating whether Izenda.Web.UI.AdHocReportDesigner tab with fields list is shown. |True|
|Boolean|[[ShowFieldValueCheckbox|/API/CodeSamples/ShowFieldValueCheckbox]]|Gets or sets the value indicating whether "Field&#124;Value" checkbox should be shown             in the field tab.|True|
|Boolean|[[ShowFieldValueSummaryCheckbox|/API/CodeSamples/ShowFieldValueSummaryCheckbox]]|Gets or sets the value indicating whether "Field&#124;Value" checkbox should be shown             in the summary tab.|True|
|Boolean|[[ShowFilterFunctions|/API/CodeSamples/ShowFilterFunctions]]| Gets or sets the value indicating whether Remove All button should be shown in the Izenda.AdHoc.AdHocSettings.FieldList. **(deprecated)**|True|
|Boolean|[[ShowFilterLogic|/API/CodeSamples/ShowFilterLogic]]| Gets or sets the value indicating whether Filter Logic should be shown in the Izenda.Web.UI.FilterList. |True|
|Boolean|[[ShowFiltersInDashboards|/API/CodeSamples/ShowFiltersInDashboards]]| Gets or set value indicating whether filters should be shown in Izenda.AdHoc.AdHocSettings.ReportViewer. |True|
|Boolean|[[ShowFiltersInReportViewer|/API/CodeSamples/ShowFiltersInReportViewer]]| Gets or set value indicating whether filters should be shown in Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|True|
|Boolean|[[ShowFiltersTab|/API/CodeSamples/ShowFiltersTab]]| Gets or sets the value indicating whether Izenda.Web.UI.AdHocReportDesigner tab with filters list is showed. |True|
|Boolean|[[ShowFunctions|/API/CodeSamples/ShowFunctions]]| Gets or sets the value indicating whether functions should be shown in the Izenda.AdHoc.AdHocSettings.FieldList. |True|
|Boolean|[[ShowGaugePercentage|/API/CodeSamples/ShowGaugePercentage]]|Gets or sets the value indicating whether percentage at gauges should be shown.|False|
|Boolean|[[ShowGaugeTab|/API/CodeSamples/ShowGaugeTab]]|Gets or sets the value indicating whether gauges tab should be shown in report designer.|True|
|Boolean|[[ShowGoButton|/API/CodeSamples/ShowGoButton]]| Gets or sets the value indicating whether "Go" button should be shown  in the Izenda.Web.UI.AdHocToolbarNavigation. |False|
|Boolean|[[ShowGradientBackground|/API/CodeSamples/ShowGradientBackground]]|Gets or sets the value indicating is data grid items will be shaded with gradient|False|
|Boolean|[[ShowGroupInFunctionDropdown|/API/CodeSamples/ShowGroupInFunctionDropdown]]|Gets or sets the value indicating whether GROUP feature should be shown as a function.            Otherwise, it will be shown as a separate checkbox.|True|
|Boolean|[[ShowGroupMonth|/API/CodeSamples/ShowGroupMonth]]|Gets or set value indicating whether Group(Month) function should be visible.**(deprecated)**|False|
|Boolean|[[ShowHelpButton|/API/CodeSamples/ShowHelpButton]]|Gets or sets the value indicating whether the "HideHelpPanel" icon should be            shown in the toolbar.|False|
|Boolean|[[ShowHtmlAsCode|/API/CodeSamples/ShowHtmlAsCode]]|This feature enables/disables showing HTML code containing in database fields as plain text.|False|
|Boolean|[[ShowInTimePeriod|/API/CodeSamples/ShowInTimePeriod]]|Gets or sets the value indicating whether "In Time Period" item is shown in operators dropdown.|True|
|Boolean|[[ShowInvalidVizExportLink|/API/CodeSamples/ShowInTimePeriod]]|Gets or sets the value indicating whether "In Time Period" item is shown in operators dropdown.|True|
|Boolean|[[ShowInvertSummaryCheckbox|/API/CodeSamples/ShowInvertSummaryCheckbox]]|Gets or sets the value indicating whether "Invert" checkbox should be shown             in the summary tab.**(deprecated)**|False|
|Boolean|[[ShowInvisible|/API/CodeSamples/ShowInvisible]]| Gets or sets the value indicating whether invisible checkboxes should be shown in the Izenda.AdHoc.AdHocSettings.FieldList. **(deprecated)**|False|
|Boolean|[[ShowJoinAliasTextboxes|/API/CodeSamples/ShowJoinAliasTextboxes]]||False|
|Boolean|[[ShowJoinDropDown|/API/CodeSamples/ShowJoinDropDown]]| Gets or sets the value indicating whether join type dropdown should be shown in the Izenda.AdHoc.AdHocSettings.JoinedTablesList. |False|
|Boolean|[[ShowJustification|/API/CodeSamples/ShowJustification]]|Gets or sets the value indicating whether justification type should be            shown in the field tab.|True|
|Boolean|[[ShowLinkFormats|/API/CodeSamples/ShowLinkFormats]]|This feature enables/disables the link format function options for fields in the fields tab of reportdesigner.**(deprecated)**|True|
|Boolean|[[ShowLoadingForDesigner|/API/CodeSamples/ShowLoadingForDesigner]]|Gets or set value indicating whether loading message should be shown.**(deprecated)**|False|
|Boolean|[[ShowLoadingOnDesignerLoad|/API/CodeSamples/ShowLoadingOnDesignerLoad]]|Gets or set value indicating whether loading message should be shown on designer load.**(deprecated)**|False|
|Boolean|[[ShowLogoInPdf|/API/CodeSamples/ShowLogoInPdf]]|**(deprecated)**|False|
|Boolean|[[ShowMapTab|/API/CodeSamples/ShowMapTab]]|Gets or sets the value indicating whether the Map Tab should be            shown in the report viewer.|True|
|Boolean|[[ShowMenuInReportViewer|/API/CodeSamples/ShowMenuInReportViewer]]| Gets or set value indicating whether menu should be shown in Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|False|
|Boolean|[[ShowMiscTab|/API/CodeSamples/ShowMiscTab]]|This checkbox enables/disables the misc tab from the Izenda Reports application report designer page.|True|
|Boolean|[[ShowModifiedReportMessage|/API/CodeSamples/ShowModifiedReportMessage]]|Gets or sets the value indicating whether the modified save message can appear on save.|True|
|Boolean|[[ShowModifyButton|/API/CodeSamples/ShowModifyButton]]|Gets or sets the value indicating whether the "Modify" button should be            shown in the report viewer.**(deprecated)**|True|
|Boolean|[[ShowMultiLineControls|/API/CodeSamples/ShowMultiLineControls]]|Gets or sets the value indicating whether "Multi-Line" feature is enabled.|False|
|Boolean|[[ShowNewButton|/API/CodeSamples/ShowNewButton]]|Gets or sets the value indicating whether the "New" icon should be            shown in the toolbar.|True|
|Boolean|[[ShowNonIndexedJoinFields|/API/CodeSamples/ShowNonIndexedJoinFields]]|Gets or sets the value indicating whether non-indexed join fields should be shown.|True|
|Boolean|[[ShowODTButton|/API/CodeSamples/ShowODTButton]]|Gets or sets the value indicating possibility export to ODT**(deprecated)**|False|
|Boolean|[[ShowOnlineDocumentation|/API/CodeSamples/ShowOnlineDocumentation]]|Gets or sets the value indicating if it's nessesary to show Details button in Settings.|True|
|Boolean|[[ShowOpenOfficeButton|/API/CodeSamples/ShowOpenOfficeButton]]|Gets or sets the value indicating possibility export to OpenOffice|False|
|Boolean|[[ShowPDFButton|/API/CodeSamples/ShowPDFButton]]|Gets or sets the value indicating possibility export to PDF|True|
|Boolean|[[ShowPivot|/API/CodeSamples/ShowPivot]]|Enables/disables the option of adding pivots to reports.|True|
|Boolean|[[ShowPoweredByLogo|/API/CodeSamples/ShowPoweredByLogo]]|Gets or sets the value indicating whether "Powered By Izenda" logo            should be shown.|False|
|Boolean|[[ShowPreviewTab|/API/CodeSamples/ShowPreviewTab]]| Gets or sets the value indicating whether Izenda.Web.UI.AdHocReportDesigner tab with preview is showed. |True|
|Boolean|[[ShowPublishRdlButton|/API/CodeSamples/ShowPublishRdlButton]]| Gets or sets the value indicating whether publish rdl button should be shown in the reports tab of Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowRdlOutputIcon|/API/CodeSamples/ShowRdlOutputIcon]]| Gets or sets the value indicating whether rdl button should be shown in the reports tab of Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowRecentDatasources|/API/CodeSamples/ShowRecentDatasources]]|Gets or sets the value indicating whether recent datasources dropdown list will be shown in ReportDesigner.|True|
|Boolean|[[ShowRemoveAll|/API/CodeSamples/ShowRemoveAll]]| Gets or sets the value indicating whether Remove All button should be shown in the Izenda.AdHoc.AdHocSettings.FieldList. **(deprecated)**|True|
|Boolean|[[ShowRemoveFieldInReportViewer|/API/CodeSamples/ShowRemoveFieldInReportViewer]]||True|
|Boolean|[[ShowReportClassifiers|/API/CodeSamples/ShowReportClassifiers]]| Gets or sets the value indicating whether Izenda.Web.UI.ReportClassifiers control should be shown in the "Misc" tab. |True|
|Boolean|[[ShowReportColor|/API/CodeSamples/ShowReportColor]]| Gets or sets the value indicating whether report color dropdowns are shown in Izenda.Web.UI.StyleControl. |True|
|Boolean|[[ShowReportingServicesSettings|/API/CodeSamples/ShowReportingServicesSettings]]|Gets or sets the value indicating allows edit reporting services settings**(deprecated)**|False|
|Boolean|[[ShowReportsInHtmlOutput|/API/CodeSamples/ShowReportsInHtmlOutput]]|Gets or sets the value indicating whether the list of reports should be shown in the            Report viewer.**(deprecated)**|True|
|Boolean|[[ShowReportsListAsDropDown|/API/CodeSamples/ShowReportsListAsDropDown]]| Gets or sets the value indicating whether reports displayed in Archive tab should be hyperlinks or should be items of dropdown list box. True if reports should be displayed as hyperlinks. False if reports should be displayed as items of dropdown list box. |False|
|Boolean|[[ShowReportsTab|/API/CodeSamples/ShowReportsTab]]| Gets or sets the value indicating whether Izenda.Web.UI.AdHocReportDesigner tab with reports list is showed. |False|
|Boolean|[[ShowResponseServerDetails|/API/CodeSamples/ShowResponseServerDetails]]|Gets or set value indicating showing diagnostic test at response server page|True|
|Boolean|[[ShowRowButtons|/API/CodeSamples/ShowRowButtons]]| Gets or sets the value indicating whether insert and move buttons should be shown in the Izenda.AdHoc.AdHocSettings.FieldList. |True|
|Boolean|[[ShowSaveAsToolbarButton|/API/CodeSamples/ShowSaveAsToolbarButton]]| Gets or sets the value indicating whether "Save As" button should be shown  in the Izenda.Web.UI.AdHocToolbarNavigation. |True|
|Boolean|[[ShowSaveControls|/API/CodeSamples/ShowSaveControls]]| Gets or sets the value indicating whether save controls should be shown in the reports tab of Izenda.Web.UI.AdHocReportDesigner and in the Izenda.Web.UI.AdHocToolbarNavigation. |True|
|Boolean|[[ShowSaveControlsInReportsTab|/API/CodeSamples/ShowSaveControlsInReportsTab]]| Gets or sets the value indicating whether save controls should be shown in the reports tab of Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowSaveInReportViewer|/API/CodeSamples/ShowSaveInReportViewer]]|Gets or sets the value indicating whether save controls should be            shown in the ReportViewer.**(deprecated)**|True|
|Boolean|[[ShowSaveRdlToolbarButton|/API/CodeSamples/ShowSaveRdlToolbarButton]]| Gets or sets the value indicating whether "Save As RDL" button should be shown  in the Izenda.Web.UI.AdHocToolbarNavigation. |False|
|Boolean|[[ShowScheduleControls|/API/CodeSamples/ShowScheduleControls]]| Gets or sets the value indicating whether Izenda.Web.UI.ScheduleControl  should be shown in the "Misc" tab. |True|
|Boolean|[[ShowServerEmailButton|/API/CodeSamples/ShowServerEmailButton]]|Gets or sets the value indicating whether the email from server icon should be            shown in the toolbar.|False|
|Boolean|[[ShowSettingsButton|/API/CodeSamples/ShowSettingsButton]]|Gets or sets the value indicating showing buttons for administration.            An alias for ShowAdminButton setting.|True|
|Boolean|[[ShowSettingsButtonForNonAdmins|/API/CodeSamples/ShowSettingsButtonForNonAdmins]]|Defines if Settings button will be shown to users without administrator rights|False|
|Boolean|[[ShowSharedCheckbox|/API/CodeSamples/ShowSharedCheckbox]]||True|
|Boolean|[[ShowSharingControl|/API/CodeSamples/ShowSharingControl]]|Gets or sets the value indicating is the sharing control will be shown.|True|
|Boolean|[[ShowSideHelp|/API/CodeSamples/ShowSideHelp]]| Gets or set value indicating whether side help should be shown in Izenda.Web.UI.ReportDesigner. |False|
|Boolean|[[ShowSimpleModeViewer|/API/CodeSamples/ShowSimpleModeViewer]]|Gets or sets a value indicating whether report viewer mode is simple mode.|False|
|Boolean|[[ShowSqlOutputIcon|/API/CodeSamples/ShowSqlOutputIcon]]|Gets or sets the value indicating whether the SQL output icon should be            shown in the toolbar.|True|
|Boolean|[[ShowStackTrace|/API/CodeSamples/ShowStackTrace]]|Gets or sets the value indicating format for showing exceptions.|True|
|Boolean|[[ShowStyleTab|/API/CodeSamples/ShowStyleTab]]|Gets or sets the value indicating whether style tab should be shown in the report designer.|True|
|Boolean|[[ShowSummaryLine|/API/CodeSamples/ShowSummaryLine]]|This feature allows the usage of a summary line in the fields tab of report designer.**(deprecated)**|True|
|Boolean|[[ShowSummaryTab|/API/CodeSamples/ShowSummaryTab]]|Gets or sets the value indicating whether summary tab should be shown.|True|
|Boolean|[[ShowTableNames|/API/CodeSamples/ShowTableNames]]|Gets or sets the value indicating whether colums should be grouped by table name.            Otherwise show columns as "ColumnName(TableName)".|False|
|Boolean|[[ShowTenantField|/API/CodeSamples/ShowTenantField]]|When false, this hides the field identified in the TenantField property|True|
|Boolean|[[ShowTimeZoneDropdown|/API/CodeSamples/ShowTimeZoneDropdown]]|Gets or sets the value indicating whether  timezone dropdown will be shown in the Report Designer.|True|
|Boolean|[[ShowTopInFields|/API/CodeSamples/ShowTopInFields]]| Gets or sets the value indicating whether results count dropdown should be shown in the fields tab of Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowTopInSummary|/API/CodeSamples/ShowTopInSummary]]| Gets or sets the value indicating whether results count dropdown should be shown in the summary tab of Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowVisualGroupLabels|/API/CodeSamples/ShowVisualGroupLabels]]|Gets or sets the value indicating whether field names should be shown in visual group header.**(deprecated)**|False|
|Boolean|[[ShowWatermarkedExports|/API/CodeSamples/ShowWatermarkedExports]]|Gets or sets the value indicating whether watermarked             export should be used on license errors.|True|
|Boolean|[[ShowWaterMarks|/API/CodeSamples/ShowWaterMarks]]|Gets or sets the value indicating whether watermarks            should be used on license errors.|True|
|Boolean|[[ShowWidth|/API/CodeSamples/ShowWidth]]| Gets or sets the value indicating whether width edit should be shown in the Izenda.AdHoc.AdHocSettings.FieldList. **(deprecated)**|False|
|Boolean|[[ShowXLSButton|/API/CodeSamples/ShowXLSButton]]|Gets or sets the value indicating possibility export to XLS|True|
|String|[[SimpleFilterCssUrl|/API/CodeSamples/SimpleFilterCssUrl]]| Gets or sets the css stylesheet URL for the Izenda.Web.UI.FilterList. |rs.aspx?css=SimpleFilter|
|Boolean|[[SingleLineViewerToolbar|/API/CodeSamples/SingleLineViewerToolbar]]| Gets or set value indicating whether Izenda.AdHoc.AdHocSettings.ReportViewer toolbar should be single line. **(deprecated)**|False|
|String|[[SmtpLogin|/API/CodeSamples/SmtpLogin]]|Gets or sets the SMTP server login.|String.Empty|
|String|[[SmtpPassword|/API/CodeSamples/SmtpPassword]]|Gets or sets the SMTP server password.|String.Empty|
|String|[[SmtpServer|/API/CodeSamples/SmtpServer]]|Gets or sets the SMTP server address for sending e-mails.|localhost|
|Boolean|[[SortColumnNames|/API/CodeSamples/SortColumnNames]]|Gets or sets the value indicating whether dropdowns with column names             are sorted alphabetically.|True|
|Int32|[[SqlCommandTimeout|/API/CodeSamples/SqlCommandTimeout]]|Gets or sets the wait time in seconds for database command dropdown values loading.|3600|
|String|[[SqlServerConnectionString|/API/CodeSamples/SqlServerConnectionString]]|Gets or sets the connection string for MS SQL Server.|Server=66.29.211.132,41433;Database=northwind;User ID=northwind;Password=traders;|
|Boolean|[[StoreCurrentReportSetInApplication|/API/CodeSamples/StoreCurrentReportSetInApplication]]|Gets or sets whether reportSet should be stored in application instead of session.|False|
|Int32|[[StoredProcedureStringLimit|/API/CodeSamples/StoredProcedureStringLimit]]|Gets or set value indicating the max length of an string returned by a Stored Procedure (-1 for MAX)**(deprecated)**|-1|
|Boolean|[[StoreImagesToCache|/API/CodeSamples/StoreImagesToCache]]|Gets or sets the value indicating how temporary images should be stored.|True|
|Boolean|[[StrictANSIOuterJoin|/API/CodeSamples/StrictANSIOuterJoin]]|Gets or sets value indicating that strict ANSI/ISO SQL-92 outer join will be used (affects filters applied to joined tables).|True|
|Boolean|[[StripInvalidCharacters|/API/CodeSamples/StripInvalidCharacters]]|Gets or sets the value indicating whether invalid characters in report names            should be striped.|True|
|String|[[SubCalculationFilterRegex|/API/CodeSamples/SubCalculationFilterRegex]]|Gets or sets the regular expression used for subtotals calculation.            If name of a column matches this expression then it will not be added to subtotals.|ID$&#124;Id$&#124;^id$&#124;_id$|
|String|[[TabBackgroundImageUrl|/API/CodeSamples/TabBackgroundImageUrl]]|Gets or sets the URL of the tabs background image.|rs.aspx?image=TabStrip.Background.gif|
|NameDistinctValueCollection|[[TableAliases|/API/CodeSamples/TableAliases]]|Gets or sets the collection of key-value pairs where the key is the table name and            the value is a table alias.**(deprecated)**|null|
|Unit|[[TableDropDownWidth|/API/CodeSamples/TableDropDownWidth]]|Gets or sets the width of table dropdown.|190px|
|String|[[TableFilterRegex|/API/CodeSamples/TableFilterRegex]]|Gets or sets the regular expression used for table filtering.            If name of a table or a column matches this expression then it will be excluded|^(IzendaAdHoc)|
|String|[[TabsCss|/API/CodeSamples/TabsCss]]| Gets or sets the css style for the Izenda.Web.UI.TabStrip. **(deprecated)**|@import url(rs.aspx?css=tabs);|
|String|[[TabsCssUrl|/API/CodeSamples/TabsCssUrl]]| Gets or sets the css stylesheet URL for the Izenda.Web.UI.TabStrip. |rs.aspx?css=tabs|
|String|[[TempFiles|/API/CodeSamples/TempFiles]]|Gets or set value indicating path to temporary files.|TempFiles|
|String|[[TemplatesPath|/API/CodeSamples/TemplatesPath]]|Gets or sets the path of the folder where templates are stored.|[drive]:\[ApplicationFolder]\Reports|
|String|[[TenantField|/API/CodeSamples/TenantField]]|The name of the database field which stores a user's tenant.  This is required for multi-tenant schedulin|String.Empty|
|FieldHighlightInfoDictionary|[[TextHighlight|/API/CodeSamples/TextHighlight]]||null|
|Int32|[[ThumbnailHeight|/API/CodeSamples/ThumbnailHeight]]|Gets or sets the value indicating thumbnail size in pixels.|220|
|Int32|[[ThumbnailWidth|/API/CodeSamples/ThumbnailWidth]]|Gets or sets the value indicating thumbnail size in pixels.|170|
|Unit|[[TimePeriodDropDownWidth|/API/CodeSamples/TimePeriodDropDownWidth]]|Gets or sets the width of time period dropdown.|190px|
|Int32|[[TimeZoneOffset|/API/CodeSamples/TimeZoneOffset]]|Gets or sets the value indicating the time zone offset in Hours.|0|
|SchedulerTimeZoneCollection|[[TimeZones|/API/CodeSamples/TimeZones]]|Collection of additional and hidden time zones.|null|
|String|[[ToolbarBackgroundImageUrl|/API/CodeSamples/ToolbarBackgroundImageUrl]]|Gets or sets the URL of the toolbar background image.|rs.aspx?image=Toolbar.Toolgrad.gif|
|String|[[ToolbarBorderColor|/API/CodeSamples/ToolbarBorderColor]]|Gets or sets the color of toolbar border.|#95b7f3|
|String|[[ToolbarCssUrl|/API/CodeSamples/ToolbarCssUrl]]| Gets or sets the css stylesheet URL for the Izenda.Web.UI.Toolbar. |rs.aspx?css=toolbar|
|String|[[UnCategorizedReportsMenuItemTitle|/API/CodeSamples/UnCategorizedReportsMenuItemTitle]]|Gets or sets the uncategorized reports menu item title.**(deprecated)**|Reports|
|Boolean|[[UseAdvancedGauge|/API/CodeSamples/UseAdvancedGauge]]|Gets or sets the value indicating whether advanced is used for "Gauge" format.|True|
|Boolean|[[UseBulkCSV|/API/CodeSamples/UseBulkCSV]]|Gets or sets the value indicating whether Bulk CSV use.|True|
|Boolean|[[UseColumnNameForDashboardCommonFilters|/API/CodeSamples/UseColumnNameForDashboardCommonFilters]]|Gets or sets the value indicating whether common filters in the Dasboard should be combined using Column Name only|True|
|Boolean|[[UseConstraintsForJoins|/API/CodeSamples/UseConstraintsForJoins]]|Gets or sets the value indicating if multiple autojoining conditions are allowed.**(deprecated)**|False|
|Boolean|[[UseDefaultDialogs|/API/CodeSamples/UseDefaultDialogs]]|Gets or sets the value indicating whether system dialogs should be shown instead of Ad hoc dialogs.|False|
|Boolean|[[UseFriendlyErrors|/API/CodeSamples/UseFriendlyErrors]]|Gets or sets the value indicating whether friendly errors            should be shown on exceptions.|True|
|Boolean|[[UseImageDescriptions|/API/CodeSamples/UseImageDescriptions]]||False|
|Boolean|[[UseNoLock|/API/CodeSamples/UseNoLock]]|Gets or sets the value indicating whether nolock statment will be used in sql-queries|True|
|Boolean|[[UseNonPostbackDeleting|/API/CodeSamples/UseNonPostbackDeleting]]|Gets or sets the value indicating whether should not be postback on report deleting.|True|
|Boolean|[[UseNonPostbackExport|/API/CodeSamples/UseNonPostbackExport]]|Gets or sets the value indicating whether should not be postback on report export.|True|
|Boolean|[[UseNonPostbackPreview|/API/CodeSamples/UseNonPostbackPreview]]|Gets or sets the value indicating whether should not be postback on report preview.|True|
|Boolean|[[UseNonPostbackServerEmailing|/API/CodeSamples/UseNonPostbackServerEmailing]]|Gets or sets the value indicating whether should not be postback on report sever emailing.|True|
|Boolean|[[UseReportID|/API/CodeSamples/UseReportID]]|Gets or sets the value indicating whether GUIDs will be used instead of report names in addresses.|False|
|Boolean|[[ValidateBeforeSave|/API/CodeSamples/ValidateBeforeSave]]|Gets or sets the value indicating whether reportset should be validated before saving|False|
|Boolean|[[ViewsOnly|/API/CodeSamples/ViewsOnly]]|Gets or sets the value indicating whether only views is shown in tables dropdown.|False|
|String[]|[[VisibleDataSources|/API/CodeSamples/VisibleDataSources]]|Gets or sets the array of table names should be shown in tables dropdown.|System.String[] {}|
|String[]|[[VisibleTables|/API/CodeSamples/VisibleTables]]|Gets or sets the array of table names should be shown in tables dropdown.**(deprecated)**|System.String[] {}|
|VisualGroupStyle|[[VisualGroupStyle|/API/CodeSamples/VisualGroupStyle]]|Gets or set value indicating what style should be used for visual groups.**(deprecated)**|CommaDelimited|