#AdHocSettings

The ``AdHocSettings`` class contains all the settings Izenda uses to control various aspects of the interface and flow of data. Many of the more useful settings are explained in detail in our [[Guide to Report Design|/Guides/ReportDesign]] and [[Developer Guides|/Guides/Developer-Links-and-Guides]]. ")

|Datatype|Setting name|Setting description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[AddAllFilterRegex|/API/CodeSamples/AddAllFilterRegex]]|Gets or sets the regular expression used for filtering the fields added by clicking "Add All".            If the name of a column matches this expression then it will not be added when "Add All" is clicked.|(id&#124;guid)$|
|Dictionary|[[AdditionalTimeZones|/API/CodeSamples/AdditionalTimeZones]]|Gets or sets the collection of additional time zones.**(deprecated)**|null|
|AdHocConfig|[[AdHocConfig|/API/CodeSamples/AdHocConfig]]| Gets or sets the current Izenda.AdHoc.AdHocSettings.AdHocConfig - Ad Hoc configuration. |null|
|String|[[AdHocUserKey|/API/CodeSamples/AdHocUserKey]]|Gets or sets a single password limiting access to all reporting pages.|String.Empty|
|AggregateFunctionCollection|[[AggregateFunctions|/API/CodeSamples/AggregateFunctions]]| Gets or sets the list of aggregation functions to use in the "Function" dropdown lists on the Fields, Summary, Chart, and Gauge Tabs of the Izenda.Web.UI.AdHocReportDesigner. |{None, AVG, COUNT, <br>COUNT_DISTINCT, MAX, MIN, <br>SUM, TimeSUM, SUM_DISTINCT, <br>GROUP_BY_DAY, GROUP_BY_MONTH, GROUP_BY_YEAR, <br>GROUP_BY_MONTH_NAME, GROUP_BY_DAY_OF_WEEK, GROUP_BY_DATE, <br>GROUP_BY_YEAR_AND_MONTH, GROUP_BY_YEAR_AND_MONTH_NAME, GROUP_BY_WEEK, <br>GROUP_BY_QUARTER, DAYS_OLD, AVG_DAYS_OLD, <br>SUM_DAYS_OLD, GROUP}|
|Boolean|[[AllowAnalysisGrid|/API/CodeSamples/AllowAnalysisGrid]]| Determines whether the "Analysis Grid" visual grouping option is available on the Style Tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[AllowArchivedReportTableCreation|/API/CodeSamples/AllowArchivedReportTableCreation]]|Gets or sets whether an "Archive" table can be created on the database used to store reports.             This only applies when DatabaseAdHocConfig mode is used.|True|
|Boolean|[[AllowAutomaticSubreport|/API/CodeSamples/AllowAutomaticSubreport]]|Gets or sets whether (Automatic) subreport option is available.|True|
|Boolean|[[AllowClientSorting|/API/CodeSamples/AllowClientSorting]]|Gets or sets whether report viewers can apply sorting to rendered report grids by clicking the headers.|True|
|Boolean|[[AllowComparativeArithmetic|/API/CodeSamples/AllowComparativeArithmetic]]|Gets or sets whether comparative arithmetic operations are allowed in the arithmetic checkbox.            Some datatypes may be limited in the comparative arithmetic operations that are allowed.|False|
|Boolean|[[AllowCreateNewCategory|/API/CodeSamples/AllowCreateNewCategory]]|Gets or sets whether the "Save As" dialog on the ReportDesigner and ReportViewer will display the "Category" text field to enter a new category upon saving reports.|True|
|Boolean|[[AllowDataFieldsInDescription|/API/CodeSamples/AllowDataFieldsInDescription]]|Gets or sets whether any column names (enclosed in square brackets) in the "Header", "Title", "Description", or "Footer" of the report            should be replaced with the first value of the results for that column.|True|
|Boolean|[[AllowDeletingReports|/API/CodeSamples/AllowDeletingReports]]|Gets or sets whether deleting reports is allowed.|True|
|Boolean|[[AllowDeltas|/API/CodeSamples/AllowDeltas]]| Gets or sets whether the "Add Deltas" checkbox should be shown on the fields tab of the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[AllowDomainJoin|/API/CodeSamples/AllowDomainJoin]]| Gets or sets whether the "domain" join option should be shown on the Izenda.Web.UI.AdHocReportDesigner. This allows you to join datasources that contain web addresses. |False|
|Boolean|[[AllowEqualsSelectForStoredProcedures|/API/CodeSamples/AllowEqualsSelectForStoredProcedures]]|Gets or sets whether the Equals(Select), Equals(Multiple), Equals(Checkboxes), Equals(Popup), and Equals(Tree) options            are available for filters when working with stored procedure datasources.|False|
|Boolean|[[AllowFieldsAsValue|/API/CodeSamples/AllowFieldsAsValue]]|Gets or sets whether field names are allowed to be used as filter values.|True|
|Boolean|[[AllowGroupWithoutSelect|/API/CodeSamples/AllowGroupWithoutSelect]]|Gets or sets whether it is possible to hide fields that are used for Visual Grouping.**(deprecated)**|False|
|Boolean|[[AllowHorizontalBarChart|/API/CodeSamples/AllowHorizontalBarChart]]| Gets or sets whether the "Horizontal" option will be allowed for bar charts on the Charts tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[AllowHtmlOutputsInScheduledReports|/API/CodeSamples/AllowHtmlOutputsInScheduledReports]]|Get or sets whether HTML is an allowed export format for emailing scheduled reports.**(deprecated)**|True|
|Boolean|[[AllowInvalidCharacters|/API/CodeSamples/AllowInvalidCharacters]]| Gets or sets whether invalid characters in report names should be allowed. This only has an effect if Izenda.AdHoc.AdHocSettings.StripInvalidCharacters is false. |False|
|Boolean|[[AllowInvertedGrid|/API/CodeSamples/AllowInvertedGrid]]| Gets or sets whether the "Invert" checkbox should be shown on the summary tab of the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[AllowLineOnBar|/API/CodeSamples/AllowLineOnBar]]| Gets or sets whether the "Line Value" options are displayed on the Chart tab of the Izenda.Web.UI.AdHocReportDesigner when a bar chart is selected. Setting this to false will still allow the "Show Pareto" checkbox to be checked, but the line's value will not be able to be controlled. The line's value defaults to the percentage of the sum of the "Value" metric that occurred at each data point. |True|
|Boolean|[[AllowMultilineHeaders|/API/CodeSamples/AllowMultilineHeaders]]|Gets or sets whether report grid headers can be multiline.|False|
|Boolean|[[AllowNativeSqlViaOData|/API/CodeSamples/AllowNativeSqlViaOData]]|Gets or set possibility to exec native sql queries through odata.|False|
|Boolean|[[AllowNewFiltersInReportViewer|/API/CodeSamples/AllowNewFiltersInReportViewer]]|Gets or sets whether users can add new filters in the report viewer.|True|
|Boolean|[[AllowOverwritingReports|/API/CodeSamples/AllowOverwritingReports]]|Gets or sets whether reports may be overwritten when saving them.             If this is false, then a new name is required when saving any reports.|True|
|Boolean|[[AllowSelfJoin|/API/CodeSamples/AllowSelfJoin]]|Gets or sets whether joining a table to itself is allowed.**(deprecated)**|True|
|Boolean|[[AllowStackedBarChart|/API/CodeSamples/AllowStackedBarChart]]| Gets or sets whether the "Stacked" option will be allowed for bar charts on the Charts tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[AllowSummaryDeltas|/API/CodeSamples/AllowSummaryDeltas]]| Gets or sets the value indicating whether the "Show Summary Deltas" checkbox should be shown on the summary tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[AllowVirtualDataSources|/API/CodeSamples/AllowVirtualDataSources]]|Defines availability of virtual datasources feature|False|
|Boolean|[[AllowVisualGroups|/API/CodeSamples/AllowVisualGroups]]|Gets or sets whether visual groups are allowed.**(deprecated)**|True|
|String|[[ApplicationHeaderImageUrl|/API/CodeSamples/ApplicationHeaderImageUrl]]|Gets or sets the URL of the logo used at the top of every reporting page.|String.Empty|
|Boolean|[[ApplyAntiXssToReportOutput|/API/CodeSamples/ApplyAntiXssToReportOutput]]||False|
|Boolean|[[AutoJoinOnRenderedRows|/API/CodeSamples/AutoJoinOnRenderedRows]]| Gets or sets whether auto-join function should work for server-rendered rows in Izenda.AdHoc.AdHocSettings.JoinedTablesList. **(deprecated)**|True|
|Boolean|[[AutoOrForRepeatFilters|/API/CodeSamples/AutoOrForRepeatFilters]]|Determines whether OR operator is used to concatenate two subsequent filters that use the same column|False|
|Boolean|[[AutoPostBackOnFilterChange|/API/CodeSamples/AutoPostBackOnFilterChange]]|Gets or sets whether changing filters on a report will cause a postback to occur.|True|
|Boolean|[[CacheEqualsSelect|/API/CodeSamples/CacheEqualsSelect]]|Gets or sets whether the value of the "Equals (Select)" filter should be cached.|False|
|Boolean|[[CacheExternalResources|/API/CodeSamples/CacheExternalResources]]||True|
|String|[[CacheFolder|/API/CodeSamples/CacheFolder]]|Gets or sets the folder that will be used to store cached data on disk.|[drive]:\Temp\|
|Boolean|[[CacheQueries|/API/CodeSamples/CacheQueries]]| Gets or sets whether all queries sent to the Izenda.AdHoc.Database.Driver should be cached. |True|
|Boolean|[[CacheReports|/API/CodeSamples/CacheReports]]|Gets or sets whether all loaded reports should be cached in application memory.|False|
|Boolean|[[CacheResources|/API/CodeSamples/CacheResources]]|Gets or sets whether resources like css/js/html/fonts should be cached in application memory.            This setting is application-wide.|True|
|Boolean|[[CacheSchema|/API/CodeSamples/CacheSchema]]| Gets or sets whether the Izenda.AdHoc.Database.Driver.DatabaseSchema should be cached. |True|
|Boolean|[[CacheStoredProcedureMetaDataToDisk|/API/CodeSamples/CacheStoredProcedureMetaDataToDisk]]||False|
|Boolean|[[CascadeFilterValues|/API/CodeSamples/CascadeFilterValues]]|Gets or sets whether cascading is enabled for filter values.            For example, if two filters are defined for country and city, then selecting a value for "Country" will update the "City" filter with values for that country only.|True|
|Char|[[CategoryCharacter|/API/CodeSamples/CategoryCharacter]]|Gets or sets the character used as a delimiter separating the category from the report name.            '#', '?', '&', '%' symbols are not supported.            This setting is application-wide.|\|
|Boolean|[[ChangParentUrlWhenRedirect|/API/CodeSamples/ChangParentUrlWhenRedirect]]|Gets or sets whether to use different reporting pages than the ones specified by default when redirecting through AdHoc toolbar buttons and links.|False|
|ChartingEngine|[[ChartingEngine|/API/CodeSamples/ChartingEngine]]|Defines which ChartingEngine will be used (ZedGraph, ComponentArt, Dundas, or HtmlCharts)|HtmlChart|
|Int32|[[ChartLandscapePrintWidth|/API/CodeSamples/ChartLandscapePrintWidth]]|Gets or sets the width of the images with rasterized charts when exporting to excel/printing to html in landscape orientation|1400|
|Int32|[[ChartLimit|/API/CodeSamples/ChartLimit]]|Gets or sets the limit for the maximum number of labels that can exist on a single chart.|500|
|Int32|[[ChartPortraitPrintWidth|/API/CodeSamples/ChartPortraitPrintWidth]]|Gets or sets the width of the images with rasterized charts when exporting to excel/printing to html in portrait orientation|1000|
|ChartCollection|[[Charts|/API/CodeSamples/Charts]]| Gets or sets the collection of available Izenda.AdHoc.Charts. |{Trend, Bar, Pie, <br>Funnel}|
|Point|[[ChartSize|/API/CodeSamples/ChartSize]]|Gets or sets the value indicating the maximum length and width of charts.**(deprecated)**|{X=700,Y=300}|
|String[]|[[ChartSortFields|/API/CodeSamples/ChartSortFields]]|Gets or sets the fields that will be used to sort data when a chart is used.|String.Empty|
|Int32|[[ChartToImageTimeout|/API/CodeSamples/ChartToImageTimeout]]|Gets or sets the value indicating maximum waiting time for rendering chart to image, in seconds.            This setting is application-wide.|60|
|Int32|[[CheckBoxListColumns|/API/CodeSamples/CheckBoxListColumns]]| Gets or sets the number of checkbox columns displayed in the "Quick add" dialog of the Izenda.Web.UI.AdHocReportDesigner. |2|
|Boolean|[[CheckForUpdates|/API/CodeSamples/CheckForUpdates]]|Gets or sets whether AdHoc will check for updates.**(deprecated)**|False|
|Boolean|[[CheckUserPermission|/API/CodeSamples/CheckUserPermission]]|Get or sets whether the process of checking to ensure proper permissions on viewing reports is skipped or not.|True|
|Boolean|[[ClearManagedMemoryOnRender|/API/CodeSamples/ClearManagedMemoryOnRender]]|When true .Net Garbage Collector is called manually during the Report rendering process.            Large reports could consume a lot of memory while rendering. Releasing this memory frees it for other processes.|False|
|Boolean|[[CollapsedFiltersInReportViewer|/API/CodeSamples/CollapsedFiltersInReportViewer]]| Gets or sets whether filters should be initially collapsed on the classic Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|False|
|String|[[CollationForSorting|/API/CodeSamples/CollationForSorting]]|Gets or sets collation which will be specified for sorting. This can be needed for example, when subtotals are broken because of case insensitive sorting.            If null or empty (by default), then izenda will not specify any collation for sorting in queries.|String.Empty|
|Unit|[[ColumnDropDownWidth|/API/CodeSamples/ColumnDropDownWidth]]| Gets or sets the width of all dropdowns across all tabs of the Izenda.Web.UI.AdHocReportDesigner page that contain column names. |200px|
|Boolean|[[CompressStaticResources|/API/CodeSamples/CompressStaticResources]]|Gets or sets whether resources should be gzip-compressed.            This setting is application-wide.|True|
|Boolean|[[ConvertNullToEmptyString|/API/CodeSamples/ConvertNullToEmptyString]]|Determines whether NULL string values are processed the same way as empty string values|False|
|CultureInfo|[[Culture|/API/CodeSamples/Culture]]|Gets or sets the default culture information for Ad Hoc.|en-US|
|Boolean|[[CurrentUserIsAdmin|/API/CodeSamples/CurrentUserIsAdmin]]|Gets or sets whether the user is an administrator.            Administrators have full permissions throughout the application.|True|
|Boolean|[[CurrentUserIsGlobalAdministrator|/API/CodeSamples/CurrentUserIsGlobalAdministrator]]|Gets or sets whether the current user has global administrator rights.**(deprecated)**|False|
|String|[[CurrentUserName|/API/CodeSamples/CurrentUserName]]|Gets or sets the name of the current user.|DefaultAdministrator|
|String[]|[[CurrentUserRoles|/API/CodeSamples/CurrentUserRoles]]|Gets or sets the list of groups the current user belongs to.            Groups can be used to share reports and set visibility among sets of users.|System.String[] {}|
|String|[[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]]|This identifies a single tenant the current user is associated with in a multi-tenant system.|String.Empty|
|String|[[CustomEoPdfLicenseKey|/API/CodeSamples/CustomEoPdfLicenseKey]]|Sets custom license key for currently being used eopdf assembly.            This setting is application-wide.|String.Empty|
|CustomizeChartDelegate|[[CustomizeChartDelegate|/API/CodeSamples/CustomizeChartDelegate]]|Represents a method that runs before chart reports get run. This applies to all charts except visualizations.|String.Empty|
|PdfGeneratorBase|[[CustomPdfExporter|/API/CodeSamples/CustomPdfExporter]]|Customer custom pdf exporter|String.Empty|
|CustomTimePeriodCollection|[[CustomTimePeriods|/API/CodeSamples/CustomTimePeriods]]|Defines custom time periods that can be used as values with the 'In Time Period' filter.|null|
|DashboardDateSliderMode|[[DashboardDateSliderMode|/API/CodeSamples/DashboardDateSliderMode]]|Gets or sets the value indicating the unit of time between points on the date slider control for dashboards.|Auto|
|String|[[DashboardDesignerUrl|/API/CodeSamples/DashboardDesignerUrl]]|Gets or sets the URL of a page used to design dashboards ().|DashboardDesigner.aspx|
|String|[[DashboardDesignerUrlWithDelimiter|/API/CodeSamples/DashboardDesignerUrlWithDelimiter]]| Gets the Izenda.AdHoc.AdHocSettings.DashboardDesignerUrl with the <see cref="!:UrlParametrsDelimiter appended |DashboardDesigner.aspx?|
|Int32|[[DashboardFieldsCount|/API/CodeSamples/DashboardFieldsCount]]|Gets or sets the number of Dashboard Fields sections that are displayed on the Dashboard Fields tab.|3|
|Double|[[DashboardGaugeMax|/API/CodeSamples/DashboardGaugeMax]]|Gets or sets the gauge max value for the "Dashboard Gauge" format.**(deprecated)**|1.79769313486232E+308|
|Double|[[DashboardGaugeMin|/API/CodeSamples/DashboardGaugeMin]]|Gets or sets the guage min value for the "Dashboard Gauge" format.**(deprecated)**|-1.79769313486232E+308|
|Int32|[[DashboardGaugeWidth|/API/CodeSamples/DashboardGaugeWidth]]|Gets or sets the width of "Dashboard Gauge" objects.|200|
|Int32|[[DashboardMinimumWidth|/API/CodeSamples/DashboardMinimumWidth]]|Gets or set minimum dashboard width.**(deprecated)**|1000|
|Boolean|[[DashboardMode|/API/CodeSamples/DashboardMode]]|Gets or sets whether dashboard mode is enabled.**(deprecated)**|False|
|String|[[DashboardsCss|/API/CodeSamples/DashboardsCss]]| Gets or sets the CSS style for the Izenda.Web.UI.TabStrip. **(deprecated)**|@import url(rp.aspx?auid=[auid]&css=dashboard);|
|String|[[DashboardsCssUrl|/API/CodeSamples/DashboardsCssUrl]]| Gets or sets the link to the CSS stylesheet used for the Izenda.Web.UI.TabStrip. |rp.aspx?auid=[auid]&css=dashboard|
|String|[[DashboardTabBackgroundImageUrl|/API/CodeSamples/DashboardTabBackgroundImageUrl]]|Gets or sets the URL of the background image used for tabs on the "Dashboards" page.**(deprecated)**|String.Empty|
|String|[[DashboardViewer|/API/CodeSamples/DashboardViewer]]|Gets or sets the URL of the dashboard viewer page.|ReportViewer.aspx|
|String|[[DashboardViewerWithDelimiter|/API/CodeSamples/DashboardViewerWithDelimiter]]| Gets the DashboardViewer page with the Izenda.AdHoc.AdHocSettings.UrlParametersDelimiter character at the end. |ReportViewer.aspx?|
|String|[[DashboardViewerWithDelimiterFull|/API/CodeSamples/DashboardViewerWithDelimiterFull]]|Gets the dashboard viewer page with "?" or "&" char at the end.|http://localhost/ReportViewer.aspx?|
|String|[[DatabaseDiagramImageUrl|/API/CodeSamples/DatabaseDiagramImageUrl]]|Gets or sets the URL of the image to use for a database diagram icon.|String.Empty|
|Int32|[[DataCacheInterval|/API/CodeSamples/DataCacheInterval]]|Gets or sets how long in minutes HTML output results and images should persist in the cache. Zero means that the cache is disabled.|0|
|AliasesCollection|[[DataSourceAliases|/API/CodeSamples/DataSourceAliases]]|Gets or sets the collection of key-value pairs where the key is the table name and            the value is a table alias.|null|
|NameStringsCollection|[[DataSourceCategories|/API/CodeSamples/DataSourceCategories]]| Gets or sets a list of categories and the datasources in those categories that will be used on the checkbox view of the Izenda.Web.UI.AdHocReportDesigner to sort datasources. |null|
|TimeSpan|[[DataSourceDropDownTimeout|/API/CodeSamples/DataSourceDropDownTimeout]]|Gets or sets the timeout between starting loading dropdown values from server            and redicecting to About page.**(deprecated)**|00:00:00|
|Unit|[[DataSourceDropDownWidth|/API/CodeSamples/DataSourceDropDownWidth]]|Gets or sets the width of data source dropdown.**(deprecated)**|190px|
|String|[[DataSourceHeading|/API/CodeSamples/DataSourceHeading]]| Renames the heading within the datasources tab of the Izenda.Web.UI.AdHocReportDesigner. |Data Sources (Tables and Views)|
|Int32|[[DataSourceLimit|/API/CodeSamples/DataSourceLimit]]|Limits the number of data sources Izenda Reports allows to be used as data sources in a single report.|1000|
|Int32|[[DateArithmeticDecimalPlaces|/API/CodeSamples/DateArithmeticDecimalPlaces]]|Gets or sets the value indicating how many decimal places will be included when formatting date arithmetic operations.|0|
|String|[[DatePickerLanguage|/API/CodeSamples/DatePickerLanguage]]|Gets or sets the default localization for datepicker controls within Ad Hoc.|en-US|
|String|[[Db2ConnectionString|/API/CodeSamples/Db2ConnectionString]]|Gets or sets the connection string used to connect to a DB2 database.|String.Empty|
|Int32|[[DdkValuesMaxAmount|/API/CodeSamples/DdkValuesMaxAmount]]|Gets or sets the maximum number of allowed drill-down keys when creating multi-key sub-reports.|2|
|String|[[DefaultAlternatingItemColor|/API/CodeSamples/DefaultAlternatingItemColor]]|Gets or sets the default color that is used on alternating grid items.|Gainsboro|
|String|[[DefaultHeaderForegroundColor|/API/CodeSamples/DefaultHeaderForegroundColor]]|Gets or sets the default foreground color of grid headers.|White|
|String|[[DefaultItemForegroundColor|/API/CodeSamples/DefaultItemForegroundColor]]|Gets or sets the default foreground color used for grid items.|Black|
|Int32|[[DefaultItemsPerPage|/API/CodeSamples/DefaultItemsPerPage]]|Changes the default items shown in the ReportViewer per page.|10000|
|Int32|[[DefaultLinesPerItem|/API/CodeSamples/DefaultLinesPerItem]]|Gets or sets the default number of lines per item for the "Multi-Line" feature.|1|
|String|[[DefaultLoadTab|/API/CodeSamples/DefaultLoadTab]]|Gets or sets the name of tab on the Report Designer that is loaded by default.|Fields|
|Int32|[[DefaultPreviewResults|/API/CodeSamples/DefaultPreviewResults]]| Changes the default number of results shown in the Izenda.Web.UI.AdHocReportDesigner's preview tab. |100|
|String|[[DefaultReportBorderColor|/API/CodeSamples/DefaultReportBorderColor]]|Gets or sets the default color that will be used for the border around grid headers and items.|White|
|String|[[DefaultReportHeaderColor|/API/CodeSamples/DefaultReportHeaderColor]]|Gets or sets the default color that will be used for the grid headers.|DarkSlateBlue|
|String|[[DefaultReportItemColor|/API/CodeSamples/DefaultReportItemColor]]|Gets or sets the default background color of grid items.|White|
|StringCollection|[[DefaultReportOrder|/API/CodeSamples/DefaultReportOrder]]|Gets or sets the default order for report parts.|{Chart, Chart2, Chart3, <br>Chart4, Gauges, Summary, <br>Detail, Maps}|
|String|[[DefaultSharingRights|/API/CodeSamples/DefaultSharingRights]]| Gets or sets the default value of the "Rights" dropdown menu when the sharing controls are present on the Misc Tab of the Izenda.Web.UI.AdHocReportDesigner. |None|
|String|[[DefaultTable|/API/CodeSamples/DefaultTable]]|Gets or sets the name of the datasource that should be added to every report created.|String.Empty|
|String|[[DefaultUserName|/API/CodeSamples/DefaultUserName]]|Gets or sets the username of users who haven't logged in. By default, this is set to "DefaultAdministrator".|DefaultAdministrator|
|String|[[DefaultVisibilityForNonAdmins|/API/CodeSamples/DefaultVisibilityForNonAdmins]]|Gets or sets the default visibility setting for reports created by users without administrator privileges.            Valid values are OnlyMe, Everyone, or any of the CurrentUserRoles.|OnlyMe|
|Unit|[[DescriptionWidth|/API/CodeSamples/DescriptionWidth]]| Gets or sets the width of the "Description" textboxes on the Fields tab of the Izenda.Web.UI.AdHocReportDesigner. |100px|
|NameValueCollection|[[DetailReportFormatString|/API/CodeSamples/DetailReportFormatString]]|Gets or sets the extended link formats for the "Detail Link" format.**(deprecated)**|null|
|Boolean|[[Distinct|/API/CodeSamples/Distinct]]| GGets or sets the initial value for the Distinct option on the DataSources Tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[DistinctSubtotalInnerQuery|/API/CodeSamples/DistinctSubtotalInnerQuery]]|Gets or sets whether the DISTINCT option will be applied to inner queries when calculating subtotals.|True|
|FormatCollection|[[DrillDownStyle|/API/CodeSamples/DrillDownStyle]]|Gets or sets the list of available formats for displaying and accessing sub-reports from a main report.|{DetailLink, DetailLinkNewWindow, <br>EmbeddedDetail, DetailLinkPopup, ComboKey}|
|String|[[DundasImagesPath|/API/CodeSamples/DundasImagesPath]]| Gets or sets the base URL for dundas library images. If the value is null then the built-in base URL for images will be used. |String.Empty|
|String|[[EmailFromAddress|/API/CodeSamples/EmailFromAddress]]| Gets or sets the email address that will be used in the "from" line of emails sent via the scheduler and the Izenda.Web.UI.AdHocReportDesigner. |adhoc@yourdomain.com|
|String|[[EmailSubjectFormatString|/API/CodeSamples/EmailSubjectFormatString]]|Gets or sets the format string to use for the subject line of emails sent via the report scheduler.            The report name is the value used for the subject.|{0}|
|Boolean|[[EmbedReportInServerEmail|/API/CodeSamples/EmbedReportInServerEmail]]|Gets or sets whether reports sent via the server will be embedded in the email. When false, reports will be sent as links instead.**(deprecated)**|False|
|String|[[EmptyReportString|/API/CodeSamples/EmptyReportString]]| Gets or sets a System.String message to display when a report has zero results. This can accept HTML. |String.Empty|
|Int32|[[EOPdfLoadWaitTime|/API/CodeSamples/EOPdfLoadWaitTime]]|Gets or sets the number of seconds the converter waits before trying to render the page.|2|
|Int32|[[EqualsDropDownLimit|/API/CodeSamples/EqualsDropDownLimit]]|Gets or sets the limit for the number of items the Equals(Select), (Checkboxes), etc filters will fetch.**(deprecated)**|2000|
|Int32|[[EqualsDropDownTimeout|/API/CodeSamples/EqualsDropDownTimeout]]|Gets or sets the wait time in seconds to allow for "Equals (Select)" dropdown menus to load before timing out.**(deprecated)**|10|
|Dictionary|[[EqualsPopupDestinations|/API/CodeSamples/EqualsPopupDestinations]]|Gets or sets a collection of aspx pages and database columns that will be used for popup windows when the Equals(Popup) filter is selected.            When a column in the set is selected with this filter, then the corresponding aspx page will be launched instead of the standard popup window.|null|
|String|[[EqualsSelectDateFormat|/API/CodeSamples/EqualsSelectDateFormat]]|Gets or sets the default date format utilized by the equals (Select) filters.**(deprecated)**|MM/dd/yyyy|
|Int32|[[EqualsSelectLimit|/API/CodeSamples/EqualsSelectLimit]]|Gets or sets the limit for the number of items the Equals(Select), (Checkboxes), etc filters will fetch.|500|
|String|[[EqualsSelectText|/API/CodeSamples/EqualsSelectText]]|Gets or sets the text of "Equals (Select)" operator.|Equals (Select)|
|Int32|[[EqualsSelectTimeout|/API/CodeSamples/EqualsSelectTimeout]]|Gets or sets the wait time in seconds to allow for "Equals (Select)" dropdown menus to load before timing out.|60|
|String|[[ErrorIzendaReplacement|/API/CodeSamples/ErrorIzendaReplacement]]|Gets or sets the replacement string for instances of the word "Izenda" in stack traces generated from thrown exceptions.|Izenda|
|EvoPdfAzureCloudServiceConfig|[[EvoAzureServiceConfig|/API/CodeSamples/EvoAzureServiceConfig]]|The configuration for the Evo Azure Cloud Service|String.Empty|
|String[]|[[ExistingDatabaseConstraints|/API/CodeSamples/ExistingDatabaseConstraints]]|Gets database constraints from your database connection.|System.String[] {} - Depends on your database's constraints|
|Boolean|[[ExpandCategorizedReports|/API/CodeSamples/ExpandCategorizedReports]]|Gets or sets whether sub-categories will be expanded by default on the Report List.|True|
|Boolean|[[ExpandVisualGroupGrids|/API/CodeSamples/ExpandVisualGroupGrids]]|Gets or sets whether visual groups in rendered reports are expanded by default.|True|
|Encoding|[[ExportEncoding|/API/CodeSamples/ExportEncoding]]|Gets or sets the default character encoding type for exporting reports.|null|
|TextSharpFontWrapper|[[ExportFont|/API/CodeSamples/ExportFont]]|Gets or sets the font for the PDF and RTF outputs when using the iTextSharp library to generate exports.|String.Empty|
|Int32|[[ExportLimit|/API/CodeSamples/ExportLimit]]|Gets or sets the maximum number of rows that can be exported at once.|100000|
|String[]|[[ExpressionFunctions|/API/CodeSamples/ExpressionFunctions]]|Gets or sets the array of additional functions that can be used in the Expression|System.String[] {}|
|NameValueCollection|[[ExtendedFormats|/API/CodeSamples/ExtendedFormats]]|Gets or sets the collection of additional formats that will be displayed in the ReportDesigner's "Format" dropdown lists.**(deprecated)**|null|
|String[]|[[ExtendedFunctions|/API/CodeSamples/ExtendedFunctions]]|Gets or sets the array of additional functions to display in the ReportDesigner's "Function" dropdown lists.|System.String[] {}|
|NameDistinctValueCollection|[[FieldAliases|/API/CodeSamples/FieldAliases]]|Gets or sets the collection of key-value pairs where the key is the field name and            the value is a field alias.|null|
|Unit|[[FieldDropDownWidth|/API/CodeSamples/FieldDropDownWidth]]| Gets or sets the width of "Field" dropdowns on the Fields tab of the Izenda.Web.UI.AdHocReportDesigner. |200px|
|String|[[FieldFilterRegex|/API/CodeSamples/FieldFilterRegex]]|Gets or sets the regular expression used for column filtering.            If name of a column matches this expression then it will not be shown.**(deprecated)**|MD5&#124;^(Passw)|
|Int32|[[FieldLimit|/API/CodeSamples/FieldLimit]]|Limits the number of fields Izenda Reports allows to be used in a single report.|1000|
|FieldList|[[FieldList|/API/CodeSamples/FieldList]]| Gets or sets the default Izenda.AdHoc.AdHocSettings.FieldList control.  This represents the Fields tab on the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|null|
|String|[[FieldsRegex|/API/CodeSamples/FieldsRegex]]|Gets or sets the regular expression used for filtering which fields users can view.            If the name of a column matches this expression then it will not be shown on dropdowns that expose datasource fields.|MD5&#124;^(Passw)|
|String|[[FieldValueCssUrl|/API/CodeSamples/FieldValueCssUrl]]|Gets or sets the link to the CSS file to be used on reports that use the Field&#124;Value style.|rp.aspx?auid=[auid]&css=FieldValue|
|NameDistinctValueCollection|[[FilterAliases|/API/CodeSamples/FilterAliases]]|Gets or sets the collection of key-value pairs where the key is the column(field) name and            the value is a filter alias.|null|
|Unit|[[FilterParameterWidth|/API/CodeSamples/FilterParameterWidth]]| Gets or sets the width of the "Filter" dropdown menus on the Filters Tab of the Izenda.Web.UI.AdHocReportDesigner. |300px|
|String|[[FiltersCustomPagesPath|/API/CodeSamples/FiltersCustomPagesPath]]|Gets or sets the relative path to the Equals(PopUp) custom pages.|String.Empty|
|String|[[FiltersRegex|/API/CodeSamples/FiltersRegex]]| Gets or sets the regular expression used for column filtering on the Filters Tab of the Izenda.Web.UI.AdHocReportDesigner. If the name of a column matches this expression then it will not be shown on the "filter field" dropdown in Filters Tab. |MD5&#124;^(Passw)|
|Int32|[[FilterTextAreaHeight|/API/CodeSamples/FilterTextAreaHeight]]|Gets or sets textarea height for filters like equals_list, in pixels.|22|
|Boolean|[[ForceNewNameOnSave|/API/CodeSamples/ForceNewNameOnSave]]|Gets or sets whether the user will always be prompted for a new name upon saving reports.            This will cause the "save" button to function just like the "save as" button normally would.|False|
|Boolean|[[ForceOptimizeForUnknownMsSql|/API/CodeSamples/ForceOptimizeForUnknownMsSql]]||False|
|Boolean|[[ForceResourceRequestsUniqueUrls|/API/CodeSamples/ForceResourceRequestsUniqueUrls]]|Gets or sets whether the requests for resources should be redirected to dll-version-unique urls.            This setting is application-wide.|True|
|Unit|[[FormatDropDownWidth|/API/CodeSamples/FormatDropDownWidth]]| Gets or sets the width of the "Format" dropdown menus on the Fields, Summary, and Chart Tabs of the Izenda.Web.UI.AdHocReportDesigner. |190px|
|FormatCollection|[[Formats|/API/CodeSamples/Formats]]| Gets or sets the collection of available formats that will be displayed in the "Format" dropdown menus on the Izenda.Web.UI.AdHocReportDesigner. |{{0}, {0:#,0}, <br>{0:#,0.00}, {0:C2}, MoneyDividedByHundred, <br>{0:d}, {0:D}, {0:t}, <br>{0:T}, {0:f}, {0:F}, <br>{0:g}, {0:G}, {0:Old}, <br>TimePeriod, {0:##.0}, {0:##.00}, <br>{0:##.000}, {0:0.##%}, PercentOfGroupWithRounding, <br>PercentOfGroup, Gauge, GaugeVariable, <br>GaugeDashboard, GaugeDashboardLinear, GaugeDashboardLogarithmic, <br>LineFeed, Box, HeatMap, <br>HeatMapWithoutLabel, Custom, DivisionByZero}|
|Unit|[[FunctionDropDownWidth|/API/CodeSamples/FunctionDropDownWidth]]| Gets or sets the width of the "Function" dropdown menus on the Fields, Summary, Chart, and Gauge Tabs of the Izenda.Web.UI.AdHocReportDesigner. |182px|
|Int32|[[GaugeHeight|/API/CodeSamples/GaugeHeight]]|Gets or sets the height for the "Gauge" format.|50|
|Double|[[GaugeMaximum|/API/CodeSamples/GaugeMaximum]]|Gets or sets the maximum value of gauges created with the "Gauge" format.**(deprecated)**|1|
|Double|[[GaugeMinimum|/API/CodeSamples/GaugeMinimum]]|Gets or sets the maximum value of gauges created with the "Gauge" format.**(deprecated)**|0|
|String[]|[[GaugeStyles|/API/CodeSamples/GaugeStyles]]|Gets or sets the list of styles that will be displayed on the Gauge tab under "Gauge Style". Using this setting will overwrite the default "Gauge Styles".|String.Empty|
|Int32|[[GaugeWidth|/API/CodeSamples/GaugeWidth]]|Gets or sets the width for the "Gauge" format.|250|
|Boolean|[[GenerateParameterizedSql|/API/CodeSamples/GenerateParameterizedSql]]|Gets or sets the value indicating whether queries to the database should be parameterized.|True|
|Boolean|[[GenerateThumbnails|/API/CodeSamples/GenerateThumbnails]]|Gets or sets whether reports thumbnails will get generated for each report.|False|
|String|[[GeoDataTable|/API/CodeSamples/GeoDataTable]]|Gets or sets the value indicating the table name that contains geodata for maps.|String.Empty|
|GetEqualsSelectValuesDelegate|[[GetEqualsSelectValues|/API/CodeSamples/GetEqualsSelectValues]]|Represents a method that returns values for the  operator.|String.Empty|
|TableItemStyle|[[GridHeaderStyle|/API/CodeSamples/GridHeaderStyle]]|Gets or sets the CSS style of grid headers when using the analysis grid or VG hierarchy option.|null|
|TableItemStyle|[[GridItemStyle|/API/CodeSamples/GridItemStyle]]|Gets or sets the CSS style of grid items when using the analysis grid or VG hierarchy option.|null|
|Color|[[HeaderForegroundColor|/API/CodeSamples/HeaderForegroundColor]]|Gets or sets the foreground color of grid headers.|Color [White]|
|String|[[HeaderStyle|/API/CodeSamples/HeaderStyle]]| Gets or sets the style for the Izenda.AdHoc.AdHocSettings.JoinedTablesList, Izenda.AdHoc.AdHocSettings.FieldList, and Izenda.Web.UI.FilterList headers. |font-family: verdana, arial, helvetica, sans-serif; font-size: 11px;color:black;|
|NameValueCollection|[[HelpText|/API/CodeSamples/HelpText]]|Gets or sets the collection of key-value pairs where the key is the tab name and            the value is a hint that will be shown when the mouse is hovered over the appropriate tab.|null|
|String[]|[[HiddenCategories|/API/CodeSamples/HiddenCategories]]|Gets or sets which categories are hidden for the current user.|String.Empty|
|String[]|[[HiddenColumns|/API/CodeSamples/HiddenColumns]]|Gets or sets the array of columns that should be hidden in all field dropdowns throughout the application.|String.Empty|
|HiddenFilterCollection|[[HiddenFilters|/API/CodeSamples/HiddenFilters]]|Gets or sets a list of fields to use as filters that users cannot see or edit. This controls row-level security throughout the tool.              This should be used in all multi-tenant systems and systems where users are restricted to certain records.|null|
|List|[[HiddenTimeZones|/API/CodeSamples/HiddenTimeZones]]|Gets or sets the collection of hidden time zones.**(deprecated)**|null|
|Boolean|[[HideFiltersWhenLocked|/API/CodeSamples/HideFiltersWhenLocked]]|Gets or sets whether the Filters hidden on the report viewer for locked report.|False|
|Int32|[[HighChartLabelWidth|/API/CodeSamples/HighChartLabelWidth]]|Gets or sets the value indicating labels max width for highcharts|0|
|String|[[IdentifiersRegex|/API/CodeSamples/IdentifiersRegex]]|Gets or sets the pattern that will be used to apply a default aggregate COUNT function to any fields whose descriptions match the expression.|String.Empty|
|String|[[ImagesPath|/API/CodeSamples/ImagesPath]]| Gets or sets the base URL for images used by AdHoc. If the value is null then the built-in base URL for images will be used. |String.Empty|
|Boolean|[[InheritFiltersInSubreports|/API/CodeSamples/InheritFiltersInSubreports]]|Gets or sets whether filters will be inherited in subreports.|True|
|String|[[InstantReport|/API/CodeSamples/InstantReport]]|Gets or sets the URL of the InstantReports page.|InstantReport.aspx|
|String|[[InstantReportWithDelimiter|/API/CodeSamples/InstantReportWithDelimiter]]| Gets the InstantReport page with the Izenda.AdHoc.AdHocSettings.UrlParametersDelimiter character at the end. |InstantReport.aspx?|
|Boolean|[[InvalidateSchemaOnNew|/API/CodeSamples/InvalidateSchemaOnNew]]|Gets or sets whether the database schema is invalidated when a user creates a new report.|False|
|Int32|[[InvertedGridLimit|/API/CodeSamples/InvertedGridLimit]]|Gets or sets the maximum number of rows allowed when using the inverted grid option for summary reports.             If this limit is reached, an exception is thrown.|36|
|Color|[[ItemForegroundColor|/API/CodeSamples/ItemForegroundColor]]|Gets or sets the foreground color of grid items.|Color [Black]|
|Unit|[[JoinDropDownWidth|/API/CodeSamples/JoinDropDownWidth]]| Gets or sets the width of the "Join type" dropdown on the DataSources tab of the Izenda.Web.UI.AdHocReportDesigner. The ShowJoinDropDown setting must be enabled for this to have an effect. |100px|
|JoinedTablesList|[[JoinedTablesList|/API/CodeSamples/JoinedTablesList]]| Gets or sets the default Izenda.AdHoc.AdHocSettings.JoinedTablesList control.  This represents the Advanced mode for the DataSources Tab of the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|null|
|String|[[JoinFieldRegex|/API/CodeSamples/JoinFieldRegex]]| Gets or sets the regular expression used for filtering fields that can be used to join tables on the Datasources Tab of the Izenda.Web.UI.AdHocReportDesigner. If the name of a column matches this expression then it will be excluded from the dropdown used to select join fields. |String.Empty|
|NameValueCollection|[[LabelAliases|/API/CodeSamples/LabelAliases]]|Gets or sets the collection of key-value pairs where the key is the field name and            the value is a field alias.|null|
|AdHocLanguage|[[Language|/API/CodeSamples/Language]]|Gets or sets the default language and culture information for Ad Hoc.             Your license key must support alternate languages for this to be used.|English|
|Boolean|[[LazySpMetadataPulling|/API/CodeSamples/LazySpMetadataPulling]]|Gets or sets whether stored procedure metadata will be loaded at the same time as metadata for the rest of the schema.            When true, stored procedure metadata will only be pulled when the stored procedure is executed.|False|
|Boolean|[[LimitStoredProc|/API/CodeSamples/LimitStoredProc]]|If set to true, optimizes amount of stored procedures calls. Will has effect only if set BEFORE any database-related settings and driver initializations|False|
|Char|[[LiteralComma|/API/CodeSamples/LiteralComma]]|Gets or sets the delimiter character used to separate items in the 'Equals' filter value textbox.            This setting is application-wide.|,|
|Boolean|[[LockViewer|/API/CodeSamples/LockViewer]]|Gets or sets whether the Report Viewer will be locked or not. A locked Report Viewer means no filters or fields can be changed.|False|
|String|[[LoginUrl|/API/CodeSamples/LoginUrl]]|Gets or sets the page that will be used by the application as a login page.|Login.aspx|
|MapInfoCollection|[[MapInfoCollection|/API/CodeSamples/MapInfoCollection]]| Gets or sets the registered maps data for use on the Maps tab of the Izenda.Web.UI.AdHocReportDesigner. |{World, Europe, <br>USA, Australia}|
|Size|[[MaxImageSize|/API/CodeSamples/MaxImageSize]]|Gets or sets the maximum image size of the images generated for reports.            If the size of an image is larger than the specified value, the image will be scaled.|{Width=320, Height=240}|
|Int32|[[MaximumReportSizeForCache|/API/CodeSamples/MaximumReportSizeForCache]]|Gets or sets thet maximum amount of characters a single rendered report can contain.             This number is compared to the total length of the HTML output for the report.            If the report is smaller than this number, then it will be stored in the cache if caching is on.|1048576|
|Single|[[MaxVersion|/API/CodeSamples/MaxVersion]]|Gets Max Version.|7|
|Unit|[[MinPdfFontSize|/API/CodeSamples/MinPdfFontSize]]|Gets or sets the minimum font size that will be used when creating a PDF document. The default is 10 point.|10pt|
|Boolean|[[MultiLevelVisualGrouping|/API/CodeSamples/MultiLevelVisualGrouping]]|Gets or sets the value indicating whether Visual Groups should be multi-level.**(deprecated)**|True|
|String|[[MySqlConnectionString|/API/CodeSamples/MySqlConnectionString]]|Gets or sets the connection used to connect to a MYSQL database.|String.Empty|
|String|[[NoDataSourcePage|/API/CodeSamples/NoDataSourcePage]]|Gets or sets the URL of the page that users will be redirected to if the application fails to load the datasources from the database.|Settings.aspx|
|Int32|[[NumChartPerRow|/API/CodeSamples/NumChartPerRow]]|Gets or sets the maximum number of charts allowed per row.|2|
|Int32|[[NumChartTabs|/API/CodeSamples/NumChartTabs]]| Gets or sets the maximum number of Chart tabs displayed on the Izenda.Web.UI.AdHocReportDesigner. One chart can be added per chart tab. |2|
|Int32|[[NumSharedDropdowns|/API/CodeSamples/NumSharedDropdowns]]|Gets or sets the maximum number of user/roles a report can be shared with.|3|
|Boolean|[[OmitUnicodeFlagForCharParameters|/API/CodeSamples/OmitUnicodeFlagForCharParameters]]||False|
|Boolean|[[OpenCustomUrlInNewWindow|/API/CodeSamples/OpenCustomUrlInNewWindow]]|Gets or sets whether custom URL links will be opened in a new window or the same window.             Custom URLs can be defined in the "Advanced" field options.|True|
|Int32|[[OracleCommandTimeout|/API/CodeSamples/OracleCommandTimeout]]|Sets the time Izenda Reports will wait for an Oracle command to execute before timing out.**(deprecated)**|3600|
|String|[[OracleConnectionString|/API/CodeSamples/OracleConnectionString]]|Gets or sets the connection string used to connect to an Oracle database.|String.Empty|
|String|[[OracleConstraintsQuery|/API/CodeSamples/OracleConstraintsQuery]]|Gets or sets query for constraints in oracle.**(deprecated)**|String.Empty|
|ReportOutputGeneratorCollection|[[OutputTypes|/API/CodeSamples/OutputTypes]]| Gets or sets the registered Izenda.AdHoc.ReportOutputGenerators. These control what formats reports may be exported to. |{SQL, RDL, PDF, <br>HTMLREPORT, CSV, BULKCSV, <br>XLS(MIME), DOC, ODT, <br>XML, JSON, JSA}|
|String|[[ParentReportDesignerUrl|/API/CodeSamples/ParentReportDesignerUrl]]|Gets or sets the URL that will be used for links that open the Report Designer page using the "target=_parent" attribute.|String.Empty|
|String|[[ParentReportListUrl|/API/CodeSamples/ParentReportListUrl]]|Gets or sets the URL that will be used for links that open the Report List page using the "target=_parent" attribute.|String.Empty|
|String|[[ParentReportViewerUrl|/API/CodeSamples/ParentReportViewerUrl]]|Gets or sets the URL that will be used for links that open the Report Viewer page using the "target=_parent" attribute.|String.Empty|
|String|[[ParentSettingsUrl|/API/CodeSamples/ParentSettingsUrl]]|Gets or sets the URL that will be used for links that open the Settings page using the "target=_parent" attribute.|String.Empty|
|PdfMode|[[PdfPrintMode|/API/CodeSamples/PdfPrintMode]]|Gets or sets the default PDF generation mode. This only has an effect when PrintMode is using one of the Html2Pdf modes.|EOPDF|
|Boolean|[[PerUserCaching|/API/CodeSamples/PerUserCaching]]| Gets or sets whether the Izenda.AdHoc.Database.Driver.DatabaseSchema should be cached according to CurrentUserName and CurrentUserTenantID. |False|
|Int32|[[PivotFieldLimit|/API/CodeSamples/PivotFieldLimit]]|Gets or sets the limit of pivot columns allowed in a single report.|100|
|String|[[PostgreSQLConnectionString|/API/CodeSamples/PostgreSQLConnectionString]]|Gets or sets the connection string used to connect to a Postgres database.|String.Empty|
|Boolean|[[PredefineConstraintsInReportSet|/API/CodeSamples/PredefineConstraintsInReportSet]]||False|
|Int32|[[PreviewColumnLimit|/API/CodeSamples/PreviewColumnLimit]]|Gets or set value indicating number of columns to show in preview|100|
|String|[[PreviewColumnLimitMessage|/API/CodeSamples/PreviewColumnLimitMessage]]| Gets or sets the message that appears when the column limit is reached or exceeded on the Preview tab of the Izenda.Web.UI.AdHocReportDesigner. |Reports with more than 100 fields must be exported to CSV.  Please check CSV Export to view data.|
|Int32|[[PreviewTimeout|/API/CodeSamples/PreviewTimeout]]| Gets or sets the System.Data.IDbCommand.CommandTimeout for SQL commands. Note: Will not work for Oracle connections |0|
|ProcessFiltersDelegate|[[ProcessFiltersDelegate|/API/CodeSamples/ProcessFiltersDelegate]]|		/// Represents a method that can be used to intercept and modify filters on the current Izenda.AdHoc.Report object. **(deprecated)**|String.Empty|
|Int32|[[QuickAddFieldWidth|/API/CodeSamples/QuickAddFieldWidth]]| Gets or sets the maximum width for items on the "Quick Add" menu on the Fields Tab of the Izenda.Web.UI.AdHocReportDesigner. |20|
|Int32|[[QuickAddMinElementsInColumn|/API/CodeSamples/QuickAddMinElementsInColumn]]| Gets or sets the maximum number of items that will fit in a single column of fields when the "Quick Add" button is clicked on the Fields Tab of the Izenda.Web.UI.AdHocReportDesigner. |20|
|String|[[RDLFolder|/API/CodeSamples/RDLFolder]]|Gets or sets the path to the folder where RDL files should be saved.|RDLFiles|
|Int32|[[RecentlyUpdatedCountAtReportList|/API/CodeSamples/RecentlyUpdatedCountAtReportList]]|Gets or sets the value indicating how many reports will be displayed in the "recent reports" list on the Report List.|10|
|Boolean|[[RedirectExports|/API/CodeSamples/RedirectExports]]|Gets or sets the value indicating whether exported reportsets will be returned without redirection.|True|
|Color|[[ReportAlternatingItemColor|/API/CodeSamples/ReportAlternatingItemColor]]|Gets or sets the default color of even numbered rows for rendered report grids.|Color [Gainsboro]|
|Color|[[ReportBorderColor|/API/CodeSamples/ReportBorderColor]]|Gets or sets the default color of the border for rendered report grids.|Color [White]|
|String|[[ReportCss|/API/CodeSamples/ReportCss]]|Gets or sets the CSS style for the HTML and Excel output types for rendered reports.**(deprecated)**|@import url(rp.aspx?auid=[auid]&css=Report);|
|String|[[ReportCssUrl|/API/CodeSamples/ReportCssUrl]]|Gets or sets the link to the CSS file to be used on rendered reports.|rp.aspx?auid=[auid]&css=Report|
|String|[[ReportDesignerUrl|/API/CodeSamples/ReportDesignerUrl]]| Gets or sets the URL of the page used to design reports (Izenda.Web.UI.AdHocReportDesigner page). |ReportDesigner.aspx|
|String|[[ReportDesignerUrlWithDelimiter|/API/CodeSamples/ReportDesignerUrlWithDelimiter]]| Gets the ReportDesigner page with the Izenda.AdHoc.AdHocSettings.UrlParametersDelimiter character at the end. |ReportDesigner.aspx?|
|Color|[[ReportHeaderColor|/API/CodeSamples/ReportHeaderColor]]|Gets or sets the default color of the header row for rendered report grids.|Color [DarkSlateBlue]|
|Image|[[ReportHeaderImage|/API/CodeSamples/ReportHeaderImage]]|Gets or sets the image that will be shown at the top of all reports.**(deprecated)**|String.Empty|
|String|[[ReportHeaderImageUrl|/API/CodeSamples/ReportHeaderImageUrl]]|Gets or sets the link to the image that will be shown at the top of all reports.|String.Empty|
|String|[[ReportingService2005Url|/API/CodeSamples/ReportingService2005Url]]|Gets or sets the base URL of the XML Web service.|http://localhost/ReportServer/ReportService2005.asmx|
|Color|[[ReportItemColor|/API/CodeSamples/ReportItemColor]]|Gets or sets the default color of odd numbered rows for rendered report grids.|Color [White]|
|String|[[ReportList|/API/CodeSamples/ReportList]]|Gets or sets the URL of the ReportList page.|ReportList.aspx|
|ReportListSettings|[[ReportListSettings|/API/CodeSamples/ReportListSettings]]|Gets or sets whether to display the classic ReportList.**(deprecated)**|HideAll|
|ReportSetEventWatcherCollection|[[ReportSetEventWatchers|/API/CodeSamples/ReportSetEventWatchers]]| Gets or sets the collection of registered Izenda.AdHoc.IReportSetEventWatchers that are used for handling various events on Izenda.AdHoc.ReportSet-related events. |null|
|String|[[ReportsPath|/API/CodeSamples/ReportsPath]]| Gets or sets the path of the folder where the application stores its reports when running in Izenda.AdHoc.FileSystemAdHocConfig mode. If the value is null then reports will be stored in the "Reports" subfolder of the application folder. |[drive]:\[ApplicationFolder]\Reports|
|Boolean|[[ReportsSharedByDefault|/API/CodeSamples/ReportsSharedByDefault]]|Gets or sets whether reports created by users are shared by default.**(deprecated)**|True|
|StorageMode|[[ReportStorageMode|/API/CodeSamples/ReportStorageMode]]|Defines how reports are stored - in the file system or in the database**(deprecated)**|Filesystem|
|Double|[[ReportTimeStampTimeZoneOffset|/API/CodeSamples/ReportTimeStampTimeZoneOffset]]||0|
|ReportTypeCollection|[[ReportTypes|/API/CodeSamples/ReportTypes]]|Gets or sets the list of registered types of reports for use on the dashboard designer.**(deprecated)**|{Detail, Summary, Chart, <br>Gauge, Map}|
|String|[[ReportViewer|/API/CodeSamples/ReportViewer]]|Gets or sets the URL of the ReportViewer page.|ReportViewer.aspx|
|Int32|[[ReportViewerDefaultPreviewResults|/API/CodeSamples/ReportViewerDefaultPreviewResults]]|Specifies the default maximum number of results displayed on the report viewer page for all reports.|100|
|String|[[ReportViewerPostHtml|/API/CodeSamples/ReportViewerPostHtml]]|Gets or sets a string of HTML that will be rendered after the entire report.**(deprecated)**|String.Empty|
|String|[[ReportViewerPreHtml|/API/CodeSamples/ReportViewerPreHtml]]|Gets or sets a string of HTML that will be rendered before the entire report.**(deprecated)**|String.Empty|
|Int32|[[ReportViewerRefreshInterval|/API/CodeSamples/ReportViewerRefreshInterval]]|Gets or sets the time in milliseconds the classic Report Viewer will take to refresh itself.            Zero means that there will be no refresh.**(deprecated)**|0|
|String|[[ReportViewerWithDelimiter|/API/CodeSamples/ReportViewerWithDelimiter]]| Gets the ReportViewer page with the Izenda.AdHoc.AdHocSettings.UrlParametersDelimiter character at the end. |ReportViewer.aspx?|
|String|[[ReportViewPageTitle|/API/CodeSamples/ReportViewPageTitle]]|Gets or sets the title of the classic ReportViewer page.|String.Empty|
|Boolean|[[RequireLogin|/API/CodeSamples/RequireLogin]]| Gets or sets whether users will be automatically redirected to the page specified by the Izenda.AdHoc.AdHocSettings.LoginUrl setting upon accessing the application. |False|
|String|[[ResourcesAuidSalt|/API/CodeSamples/ResourcesAuidSalt]]|Gets or sets salt for hash-based assembly build unique id calculation (mainly affects forced resource requests unique urls).            This setting is application-wide.|String.Empty|
|String|[[ResourcesPath|/API/CodeSamples/ResourcesPath]]||Resources|
|String|[[ResourcesProvider|/API/CodeSamples/ResourcesProvider]]|Gets or sets the URL of the session non-blocking resources provider page.            This setting is application-wide.|rp.aspx|
|String|[[ResourcesProviderUniqueUrlWithDelimiter|/API/CodeSamples/ResourcesProviderUniqueUrlWithDelimiter]]||rp.aspx?auid=[auid]&|
|String|[[ResourcesProviderWithDelimiter|/API/CodeSamples/ResourcesProviderWithDelimiter]]||rp.aspx?|
|String|[[ResourcesRootFolder|/API/CodeSamples/ResourcesRootFolder]]|Gets or sets path to folder on disk with izenda resources. If set, izenda will NOT search for resources outside of this folder.            It must be absolute path, like d:\mysite\reporting            It must either specify resources folder itself, like d:\mysite\reporting\resources, or any upper folder in directory structure, like d:\mysite\reporting or d:\mysite            This setting can be used only before any other calls to izenda API, and even before license key            This setting is application-wide.|String.Empty|
|String|[[ResponseServer|/API/CodeSamples/ResponseServer]]| Gets or sets the URL of the Izenda.AdHoc.ResponseServer page. |rs.aspx|
|String|[[ResponseServerWithDelimiter|/API/CodeSamples/ResponseServerWithDelimiter]]| Gets the ResponseServer page with the Izenda.AdHoc.AdHocSettings.UrlParametersDelimiter character at the end. |rs.aspx?|
|String|[[ResponseServerWithDelimiterFull|/API/CodeSamples/ResponseServerWithDelimiterFull]]| Gets the ResponseServer page with the Izenda.AdHoc.AdHocSettings.UrlParametersDelimiter character at the end. **(deprecated)**|rs.aspx?|
|Int32[]|[[ResultsDropdownValues|/API/CodeSamples/ResultsDropdownValues]]| Gets or sets the list of the values in the "Results" dropdown menu on the Izenda.Web.UI.AdHocToolbarNavigation control. |System.Int32[]|
|String|[[SavedReportsTable|/API/CodeSamples/SavedReportsTable]]|Gets or sets the table name for saved reports.|IzendaAdHocReports|
|String|[[SaveReportSetNextUrl|/API/CodeSamples/SaveReportSetNextUrl]]|Gets or sets the URL of the URL that will be loaded after saving a report.|String.Empty|
|String|[[ScheduledDashboardUrlFormatString|/API/CodeSamples/ScheduledDashboardUrlFormatString]]|Gets or sets the url that is sent via email as the report web address.|http://localhost/ReportViewer.aspx?{0}|
|String|[[ScheduledReportsUrlFormatString|/API/CodeSamples/ScheduledReportsUrlFormatString]]|Gets or sets the URL that is sent via email as the report web address.|http://localhost/ReportViewer.aspx?{0}|
|SchedulerOutputCollection|[[SchedulerExports|/API/CodeSamples/SchedulerExports]]|Gets or sets the types of formats that are available as options for exporting scheduled reports to.**(deprecated)**|{}|
|SchedulerOutputCollection|[[SchedulerOutputTypes|/API/CodeSamples/SchedulerOutputTypes]]|Get or sets the export formats that are allowed when emailing scheduled reports.|{Link, Embedded, PDF, <br>CSV, HTML, XLS(MIME), <br>DOC}|
|String|[[SchedulerTenantID|/API/CodeSamples/SchedulerTenantID]]|Gets or sets the tenantId to use for the scheduler. This ensures reports of different tenants are not scheduled erroneously.**(deprecated)**|String.Empty|
|TimeSpan|[[SchemaCacheTimeout|/API/CodeSamples/SchemaCacheTimeout]]|Gets or sets how long the application will keep the schema in the cache before fetching it from the database again.|1.00:00:00|
|Unit|[[SelectValueDropDownWidth|/API/CodeSamples/SelectValueDropDownWidth]]| Gets or sets the width of the "Value" dropdown menus on the Filters tab of the Izenda.Web.UI.AdHocReportDesigner  when Equals(Select), Equals(Checkboxes), Select(Multiple), or any (Field) operator is selected. |300px|
|String|[[ServerEmailFormat|/API/CodeSamples/ServerEmailFormat]]| Gets or sets the value indicating which format will be used for the "server email" feature This value should be one of keys from Izenda.AdHoc.AdHocSettings.SchedulerOutputTypes collection |Link|
|Boolean|[[ServiceMode|/API/CodeSamples/ServiceMode]]|Gets or set value indication service mode**(deprecated)**|False|
|String|[[SettingsKey|/API/CodeSamples/SettingsKey]]|Gets or sets the password used to access the Settings page.|String.Empty|
|String|[[SettingsPageUrl|/API/CodeSamples/SettingsPageUrl]]| Gets or sets the URL of the Izenda.AdHoc.Settings page. |Settings.aspx|
|String[]|[[SharedWithValues|/API/CodeSamples/SharedWithValues]]| Gets or sets the users or roles available in the "Share With" dropdown on the Misc tab of the Izenda.Web.UI.AdHocReportDesigner. |String.Empty|
|Boolean|[[ShowAddAll|/API/CodeSamples/ShowAddAll]]| Gets or sets the value indicating whether the "AddAll" button and dropdown should be shown on the Fields Tab of the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowAddFieldInReportViewer|/API/CodeSamples/ShowAddFieldInReportViewer]]| Gets or sets the value indicating whether the "Add Field" dropdown lists are shown on the classic Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|True|
|Boolean|[[ShowAdditionalJoinConditions|/API/CodeSamples/ShowAdditionalJoinConditions]]|Gets or sets the value indicating whether to show additional Join conditions controls|False|
|Boolean|[[ShowAdminButton|/API/CodeSamples/ShowAdminButton]]|Gets or sets whether the Settings button is shown.**(deprecated)**|True|
|Boolean|[[ShowAdvancedChartingButton|/API/CodeSamples/ShowAdvancedChartingButton]]| Gets or sets whether the "Advanced" options button will be displayed on the Charts tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowAllInPreview|/API/CodeSamples/ShowAllInPreview]]|Gets or sets whether the "Results" control should have the "All" item for the ReportDesigner and IR 2.0.|True|
|Boolean|[[ShowAllInResults|/API/CodeSamples/ShowAllInResults]]|Gets or sets whether the "Results" control should have the "All" item for the ReportViewer and Dash 2.0.|True|
|Boolean|[[ShowAllTables|/API/CodeSamples/ShowAllTables]]|Gets or sets the value indicating whether all tables should be shown in tables dropdown.**(deprecated)**|True|
|Boolean|[[ShowAllVirtualDatasources|/API/CodeSamples/ShowAllVirtualDatasources]]|Defines default visibility of virtual datasources|True|
|Boolean|[[ShowArithmeticInSummary|/API/CodeSamples/ShowArithmeticInSummary]]| Gets or sets whether arithmetic operations are available to use on the  summary tab of Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowArithmeticOperations|/API/CodeSamples/ShowArithmeticOperations]]| Gets or sets whether arithmetic operations are available to use on the  fields tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowBackButton|/API/CodeSamples/ShowBackButton]]| Gets or sets whether the "Back" button should be shown on the Izenda.Web.UI.AdHocToolbarNavigation control. |False|
|Boolean|[[ShowBetweenDateCalendar|/API/CodeSamples/ShowBetweenDateCalendar]]|Gets or sets whether calendar controls should be used for Between operation for DateTime filters.|True|
|Boolean|[[ShowBulkCSVButton|/API/CodeSamples/ShowBulkCSVButton]]|Gets or sets whether bulk CSV exports are allowed.**(deprecated)**|False|
|Boolean|[[ShowCategoryTextboxInSaveDialog|/API/CodeSamples/ShowCategoryTextboxInSaveDialog]]|Gets or sets whether the category textbox should be shown in the save dialog.|True|
|Boolean|[[ShowChartLegend|/API/CodeSamples/ShowChartLegend]]| Gets or sets whether legends will be displayed on charts created via the Charts Tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowChartTab|/API/CodeSamples/ShowChartTab]]| Gets or sets whether the Chart Tabs should be displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowClientEmailButton|/API/CodeSamples/ShowClientEmailButton]]| Gets or sets the value indicating whether the "email from client" icon should be shown on the Izenda.Web.UI.AdHocToolbarNavigation control. |True|
|Boolean|[[ShowConstraintsSettings|/API/CodeSamples/ShowConstraintsSettings]]|Gets or sets whether editing constraints is allowed.**(deprecated)**|False|
|Boolean|[[ShowContinueLinks|/API/CodeSamples/ShowContinueLinks]]| Gets or sets whether the "Continue to" buttons are enabled on the Izenda.Web.UI.AdHocReportDesigner. The buttons are designed to assist walking a user through the tabs. |True|
|Boolean|[[ShowCSVButton|/API/CodeSamples/ShowCSVButton]]|Gets or sets whether exporting to CSV is allowed.|True|
|Boolean|[[ShowCustomFormatType|/API/CodeSamples/ShowCustomFormatType]]| Gets or sets whether any "Custom" format types will be shown in the formats dropdown menus on the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowDashboardAddDropDown|/API/CodeSamples/ShowDashboardAddDropDown]]|Gets or sets a value indicating whether "add dashboard subreport" should be shown as DropDownList control.**(deprecated)**|False|
|Boolean|[[ShowDashboardFieldsTab|/API/CodeSamples/ShowDashboardFieldsTab]]| Gets or sets the value indicating whether the Dashboard Fields Tab is displayed on the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowDashboardPartViewerLinks|/API/CodeSamples/ShowDashboardPartViewerLinks]]|Gets or sets whether the Dashboard Viewer will have edit links for the displayed report parts.|True|
|Boolean|[[ShowDashboardSettings|/API/CodeSamples/ShowDashboardSettings]]|Gets or sets whether dashboard settings are displayed for editing.**(deprecated)**|False|
|Boolean|[[ShowDatabaseDiagramIcon|/API/CodeSamples/ShowDatabaseDiagramIcon]]| Gets or sets whether the Database Diagram icon should be shown in the Izenda.Web.UI.AdHocToolbarNavigation control of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowDatabaseTypes|/API/CodeSamples/ShowDatabaseTypes]]|Gets or set value indicating whether database types should be shown in the fields dropdown.|False|
|Boolean|[[ShowDataSourcesAsCheckBoxes|/API/CodeSamples/ShowDataSourcesAsCheckBoxes]]| Gets or sets whether the Datasources Tab on the Izenda.Web.UI.AdHocReportDesigner will be initialized with checkboxes or dropdown menus. |True|
|Boolean|[[ShowDataSourcesTab|/API/CodeSamples/ShowDataSourcesTab]]| Gets or sets whether the Datasources Tab is displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowDataWhenParametersBlank|/API/CodeSamples/ShowDataWhenParametersBlank]]|Gets or sets whether data should be shown on the classic Report Viewer if all parameters are blank.**(deprecated)**|True|
|Boolean|[[ShowDescriptionsInReportsTab|/API/CodeSamples/ShowDescriptionsInReportsTab]]| Gets or sets whether each report's description should be shown in the Reports Tab of the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|False|
|Boolean|[[ShowDesignDashboardLink|/API/CodeSamples/ShowDesignDashboardLink]]|Gets or sets whether the "Open in Designer" link is shown for Dashboards.|True|
|Boolean|[[ShowDesignLinkInReportViewer|/API/CodeSamples/ShowDesignLinkInReportViewer]]| Gets or sets whether the "Design" link should be shown on the classic Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|True|
|Boolean|[[ShowDesignLinks|/API/CodeSamples/ShowDesignLinks]]| Gets or sets whether design links should be shown on the report list and on the Izenda.Web.UI.AdHocToolbarNavigation control. |True|
|Boolean|[[ShowDetailFormat|/API/CodeSamples/ShowDetailFormat]]|Gets or sets the value indicating whether the "Detail Link" format            should be shown in formats dropdown.**(deprecated)**|True|
|Boolean|[[ShowDistinct|/API/CodeSamples/ShowDistinct]]| Gets or sets whether the "Distinct" option will be shown on the Data Sources tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowDOCButton|/API/CodeSamples/ShowDOCButton]]|Gets or sets whether exporting to Microsoft Word is allowed.|True|
|Boolean|[[ShowEtlButton|/API/CodeSamples/ShowEtlButton]]| Gets or sets whether the upload data button should be shown on the Izenda.Web.UI.AdHocToolbarNavigation control.  Your License Key must allow ETL for this setting to take effect. |False|
|Boolean|[[ShowFieldAsValueDropDown|/API/CodeSamples/ShowFieldAsValueDropDown]]|Gets or sets whether filters using the "Is Less Then (Field)", "Is Greater Then (Field)" and "Equals (Field)" operators            will display their values in a dropdown list. When this is false, the dropdown will be replaced with a standard textbox.|True|
|Boolean|[[ShowFieldsTab|/API/CodeSamples/ShowFieldsTab]]| Gets or sets whether the Fields Tab is displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowFieldValueCheckbox|/API/CodeSamples/ShowFieldValueCheckbox]]| Gets or sets whether the "show main report in Field&#124;Value style" checkbox should be shown on the style tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowFieldValueSummaryCheckbox|/API/CodeSamples/ShowFieldValueSummaryCheckbox]]| Gets or sets whether the "show summary report in Field&#124;Value style" checkbox should be shown on the style tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowFilterFunctions|/API/CodeSamples/ShowFilterFunctions]]| Gets or sets whether functions are allowed on the filters tab of the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|True|
|Boolean|[[ShowFilterLogic|/API/CodeSamples/ShowFilterLogic]]| Gets or sets the value indicating whether Filter Logic should be shown on the filters tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowFiltersInDashboards|/API/CodeSamples/ShowFiltersInDashboards]]|Gets or sets whether filters should be shown on Dashboards.|True|
|Boolean|[[ShowFiltersInReportViewer|/API/CodeSamples/ShowFiltersInReportViewer]]| Gets or sets whether filters should be shown in the classic Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|True|
|Boolean|[[ShowFiltersTab|/API/CodeSamples/ShowFiltersTab]]| Gets or sets whether the Filters Tab is displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowFunctions|/API/CodeSamples/ShowFunctions]]| Gets or sets whether functions should be shown on the fields tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowGaugePercentage|/API/CodeSamples/ShowGaugePercentage]]|Gets or sets whether percentages of the total value of all gauages should be displayed on gauges.|False|
|Boolean|[[ShowGaugeTab|/API/CodeSamples/ShowGaugeTab]]| Gets or sets whether the Gauge Tab should be displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowGoButton|/API/CodeSamples/ShowGoButton]]| Gets or sets the value indicating whether the "Go" button should be shown  on the Izenda.Web.UI.AdHocToolbarNavigation control. |False|
|Boolean|[[ShowGradientBackground|/API/CodeSamples/ShowGradientBackground]]| Gets or sets whether data grid items will use a gradient background. The base color used depends on which color is selected for grid item background colors on the Style tab of the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowGroupInFunctionDropdown|/API/CodeSamples/ShowGroupInFunctionDropdown]]|Gets or sets the value indicating whether the GROUP option should be shown in the Function dropdown.            Otherwise, it will be shown as a separate checkbox.|True|
|Boolean|[[ShowGroupMonth|/API/CodeSamples/ShowGroupMonth]]| Gets or sets whether the Group(Month) function should be visible for grouping dates via the function dropdown menus on the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|False|
|Boolean|[[ShowHelpButton|/API/CodeSamples/ShowHelpButton]]| Gets or sets the value indicating whether the button to hide the help panel on the Izenda.Web.UI.AdHocReportDesigner should be shown on the Izenda.Web.UI.AdHocToolbarNavigation control. |False|
|Boolean|[[ShowHtmlAsCode|/API/CodeSamples/ShowHtmlAsCode]]|Gets or sets whether HTML code should be rendered or displayed as plain text in individual report fields.|False|
|Boolean|[[ShowHtmlButton|/API/CodeSamples/ShowHtmlButton]]|Gets or sets the value indicating possibility export to HTML (HTML Print)|True|
|Boolean|[[ShowInTimePeriod|/API/CodeSamples/ShowInTimePeriod]]|Gets or sets whether the "In Time Period" item is shown as an option in the operators dropdown.|True|
|Boolean|[[ShowInvalidVizExportLink|/API/CodeSamples/ShowInvalidVizExportLink]]|Gets or sets the value indicating whether "To view the interactive visualization please click this link."             message should be shown.|True|
|Boolean|[[ShowInvertSummaryCheckbox|/API/CodeSamples/ShowInvertSummaryCheckbox]]|Gets or sets whether the "Invert" checkbox should be shown on the summary tab.**(deprecated)**|False|
|Boolean|[[ShowInvisible|/API/CodeSamples/ShowInvisible]]| Gets or sets the value indicating whether invisible checkboxes should be shown in the Izenda.AdHoc.AdHocSettings.FieldList. **(deprecated)**|False|
|Boolean|[[ShowJoinAliasTextboxes|/API/CodeSamples/ShowJoinAliasTextboxes]]| Gets or sets whether textboxes will be displayed on the Data Sources tab of the Izenda.Web.UI.AdHocReportDesigner in advanced mode that can be used to assign specific aliases to datasources that are joined together. |False|
|Boolean|[[ShowJoinDropDown|/API/CodeSamples/ShowJoinDropDown]]| Gets or sets whether the join type dropdown should be displayed on the Datasources Tab of the Izenda.Web.UI.AdHocReportDesigner. This only applies when using the Advanced mode to select datasources. |False|
|Boolean|[[ShowJustification|/API/CodeSamples/ShowJustification]]| Gets or sets whether the checkboxes allowing users to change the justification setting for fields, headers, and footers will be  displayed on the Fields Tab and Misc Tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowLinkFormats|/API/CodeSamples/ShowLinkFormats]]|Gets or sets whether the link format function options for fields in the Fields tab of ReportDesigner.**(deprecated)**|True|
|Boolean|[[ShowLoadingForDesigner|/API/CodeSamples/ShowLoadingForDesigner]]| Gets or sets whether the "loading..." message should be shown when the Izenda.Web.UI.AdHocReportDesigner loads. **(deprecated)**|False|
|Boolean|[[ShowLoadingOnDesignerLoad|/API/CodeSamples/ShowLoadingOnDesignerLoad]]|Gets or sets whether the "loading..." message should be shown when the Report Designer loads.**(deprecated)**|False|
|Boolean|[[ShowLogoInPdf|/API/CodeSamples/ShowLogoInPdf]]|Gets or sets whether the "powered by Izenda" logo will be displayed on PDF exports using the iTextSharp PDF generator.**(deprecated)**|False|
|Boolean|[[ShowMapTab|/API/CodeSamples/ShowMapTab]]| Gets or sets whether the Map Tab should be shown on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowMenuInReportViewer|/API/CodeSamples/ShowMenuInReportViewer]]| Gets or sets whether the main menu should be shown on the classic Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|False|
|Boolean|[[ShowMiscTab|/API/CodeSamples/ShowMiscTab]]| Gets or sets whether the Misc Tab should be displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowModifiedReportMessage|/API/CodeSamples/ShowModifiedReportMessage]]| Gets or sets the value indicating whether the "report was modified by another user" message shown in the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowModifyButton|/API/CodeSamples/ShowModifyButton]]|Gets or sets whether the "Modify" button should be shown on the classic ReportViewer toolbar.**(deprecated)**|True|
|Boolean|[[ShowMultiLineControls|/API/CodeSamples/ShowMultiLineControls]]| Gets or sets whether the style tab on the Izenda.Web.UI.AdHocReportDesigner will display controls to manage multiline behaviors for individual reports. |False|
|Boolean|[[ShowNewButton|/API/CodeSamples/ShowNewButton]]| Gets or sets the value indicating whether the "New" icon should be shown in the Izenda.Web.UI.AdHocToolbarNavigation control  on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowNonIndexedJoinFields|/API/CodeSamples/ShowNonIndexedJoinFields]]|Gets or sets whether non-indexed join fields should be shown.|True|
|Boolean|[[ShowODTButton|/API/CodeSamples/ShowODTButton]]|Gets or sets whether exporting to OpenOffice is allowed.**(deprecated)**|False|
|Boolean|[[ShowOnlineDocumentation|/API/CodeSamples/ShowOnlineDocumentation]]|Gets or sets the value indicating if it's nessesary to show Details button in Settings.**(deprecated)**|False|
|Boolean|[[ShowOpenOfficeButton|/API/CodeSamples/ShowOpenOfficeButton]]|Gets or sets whether exporting to OpenOffice is allowed.|False|
|Boolean|[[ShowPDFButton|/API/CodeSamples/ShowPDFButton]]|Gets or sets whether exporting to Adobe PDF is allowed.|True|
|Boolean|[[ShowPivot|/API/CodeSamples/ShowPivot]]| Gets or sets whether the "Add Pivot" button is displayed on the Fields Tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowPoweredByLogo|/API/CodeSamples/ShowPoweredByLogo]]|Gets or sets whether the "Powered By Izenda" logo will be shown below rendered report results.|False|
|Boolean|[[ShowPreviewTab|/API/CodeSamples/ShowPreviewTab]]| Gets or sets the value indicating whether the Preview Tab is displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowPublishRdlButton|/API/CodeSamples/ShowPublishRdlButton]]| Gets or sets whether the publish RDL button should be shown on the Izenda.Web.UI.AdHocToolbarNavigation control. Your license key must also allow RDL output. |False|
|Boolean|[[ShowRdlOutputIcon|/API/CodeSamples/ShowRdlOutputIcon]]| Gets or sets whether the RDL button should be shown on the Izenda.Web.UI.AdHocToolbarNavigation control. |False|
|Boolean|[[ShowRecentDatasources|/API/CodeSamples/ShowRecentDatasources]]| Gets or sets whether the recent datasources dropdown list will be shown in the Izenda.Web.UI.AdHocReportDesigner.  |True|
|Boolean|[[ShowRemoveAll|/API/CodeSamples/ShowRemoveAll]]| Gets or sets the value indicating whether the "Remove All" button should be shown on the Fields Tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowRemoveFieldInReportViewer|/API/CodeSamples/ShowRemoveFieldInReportViewer]]| Gets or sets the value indicating whether the "Remove Field" dropdown lists are shown on the classic Izenda.AdHoc.AdHocSettings.ReportViewer. **(deprecated)**|True|
|Boolean|[[ShowReportClassifiers|/API/CodeSamples/ShowReportClassifiers]]| Gets or sets the value indicating whether the Izenda.Web.UI.ReportClassifiers control should be shown in the "Misc" tab of the Izenda.Web.UI.AdHocReportDesigner. Report classifiers control visibility and ownership. |True|
|Boolean|[[ShowReportColor|/API/CodeSamples/ShowReportColor]]| Gets or sets the value indicating whether report color dropdowns are shown in the Style tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowReportingServicesSettings|/API/CodeSamples/ShowReportingServicesSettings]]|Gets or sets the value indicating allows edit reporting services settings**(deprecated)**|False|
|Boolean|[[ShowReportsInHtmlOutput|/API/CodeSamples/ShowReportsInHtmlOutput]]|Gets or sets whether the list of reports should be shown in the ReportViewer.**(deprecated)**|True|
|Boolean|[[ShowReportsListAsDropDown|/API/CodeSamples/ShowReportsListAsDropDown]]| Gets or sets the value indicating whether reports displayed in Archive tab should be hyperlinks or should be items of dropdown list box. True if reports should be displayed as hyperlinks. False if reports should be displayed as items of dropdown list box. |False|
|Boolean|[[ShowReportsTab|/API/CodeSamples/ShowReportsTab]]| Gets or sets whether the Reports Tab is displayed on the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowResponseServerDetails|/API/CodeSamples/ShowResponseServerDetails]]|Gets or sets whether the response server page will display diagnostic information when navigated to directly.|True|
|Boolean|[[ShowRowButtons|/API/CodeSamples/ShowRowButtons]]| Gets or sets whether the insert and move buttons should be shown on the Fields Tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowSaveAsToolbarButton|/API/CodeSamples/ShowSaveAsToolbarButton]]| Gets or sets whether the "Save As" button should be shown  on the Izenda.Web.UI.AdHocToolbarNavigation control. |True|
|Boolean|[[ShowSaveControls|/API/CodeSamples/ShowSaveControls]]| Gets or sets whether save controls should be shown in the Izenda.Web.UI.AdHocToolbarNavigation control, the classic report viewer, and the reports tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowSaveControlsInReportsTab|/API/CodeSamples/ShowSaveControlsInReportsTab]]| Gets or sets whether save controls should be displayed on the Reports Tab of the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowSaveInReportViewer|/API/CodeSamples/ShowSaveInReportViewer]]| Gets or sets whether save controls should be shown in the ReportViewer.  The Izenda.AdHoc.AdHocSettings.ShowSaveControls setting must also be enabled for this setting to have an effect. **(deprecated)**|True|
|Boolean|[[ShowSaveRdlToolbarButton|/API/CodeSamples/ShowSaveRdlToolbarButton]]| Gets or sets whether the "Save As RDL" button should be shown  on the Izenda.Web.UI.AdHocToolbarNavigation control. |False|
|Boolean|[[ShowScheduleControls|/API/CodeSamples/ShowScheduleControls]]| Gets or sets whether the report scheduling controls will be shown on the "Misc" tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowServerEmailButton|/API/CodeSamples/ShowServerEmailButton]]| Gets or sets the value indicating whether the "server email" icon should be shown on the Izenda.Web.UI.AdHocToolbarNavigation control. |False|
|Boolean|[[ShowSettingsButton|/API/CodeSamples/ShowSettingsButton]]|Gets or sets whether the Settings button is displayed on the ribbon menu used throughout AdHoc.|True|
|Boolean|[[ShowSettingsButtonForNonAdmins|/API/CodeSamples/ShowSettingsButtonForNonAdmins]]|Gets or sets whether the Settings button will be shown to users without administrator rights.|False|
|Boolean|[[ShowSharedCheckbox|/API/CodeSamples/ShowSharedCheckbox]]| Gets or sets whether the checkbox for sharing the report is shown on the Misc tab of the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|True|
|Boolean|[[ShowSharingControl|/API/CodeSamples/ShowSharingControl]]| Gets or sets whether the report sharing controls will be displayed on the Misc tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowSideHelp|/API/CodeSamples/ShowSideHelp]]| Gets or sets whether side help should be shown on all tabs of the Izenda.Web.UI.AdHocReportDesigner. |False|
|Boolean|[[ShowSimpleModeViewer|/API/CodeSamples/ShowSimpleModeViewer]]| Gets or sets a value indicating whether the classic ReportViewer mode is simple mode. Simple mode hides the Izenda.Web.UI.AdHocToolbarNavigation control. |False|
|Boolean|[[ShowSqlEditor|/API/CodeSamples/ShowSqlEditor]]|Defines availability of SQL Editor tab for current user|False|
|Boolean|[[ShowSqlOutputIcon|/API/CodeSamples/ShowSqlOutputIcon]]| Gets or sets whether the SQL output icon should be shown in the Izenda.Web.UI.AdHocToolbarNavigation control of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowStackTrace|/API/CodeSamples/ShowStackTrace]]| Gets or sets the value indicating format for showing exceptions. Izenda.AdHoc.AdHocSettings.UseFriendlyErrors must be on for this to have an effect. |True|
|Boolean|[[ShowStyleTab|/API/CodeSamples/ShowStyleTab]]| Gets or sets whether the Style Tab should be displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowSummaryLine|/API/CodeSamples/ShowSummaryLine]]| Gets or sets whether the usage of a summary line on the fields tab of the Izenda.Web.UI.AdHocReportDesigner is allowed. **(deprecated)**|True|
|Boolean|[[ShowSummaryTab|/API/CodeSamples/ShowSummaryTab]]| Gets or sets whether the Summary Tab should be displayed on the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowTableNames|/API/CodeSamples/ShowTableNames]]|Gets or sets whether columns in the "Field" dropdown of the Fields tab will display the table name as well as the column name.            When enabled, columns display as [TableName].[ColumnName], as opposed to just "ColumnName".|False|
|Boolean|[[ShowTenantField|/API/CodeSamples/ShowTenantField]]|When false, this hides the field identified in the TenantField property from being selected or viewed by users.            Any filters based on the tenant field will still affect the results.|True|
|Boolean|[[ShowTimeInFilterPickers|/API/CodeSamples/ShowTimeInFilterPickers]]|Gets or sets the value indicating whether time will be available in datepickers in filters.|False|
|Boolean|[[ShowTimeZoneDropdown|/API/CodeSamples/ShowTimeZoneDropdown]]| Gets or sets the value indicating whether the timezone dropdown will be shown on the Misc tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowTopInFields|/API/CodeSamples/ShowTopInFields]]| Gets or sets whether the "Results" textbox should be displayed on the Fields Tab of the Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowTopInSummary|/API/CodeSamples/ShowTopInSummary]]| Gets or sets whether the "Results" textbox should be displayed on the Summary Tab of Izenda.Web.UI.AdHocReportDesigner. |True|
|Boolean|[[ShowVisPropertiesInDashboards|/API/CodeSamples/ShowVisPropertiesInDashboards]]|Gets or sets whether visualization properties should be shown on Dashboards.|False|
|Boolean|[[ShowVisualGroupLabels|/API/CodeSamples/ShowVisualGroupLabels]]|Gets or sets whether field names should be shown in visual group header.**(deprecated)**|False|
|Boolean|[[ShowWatermarkedExports|/API/CodeSamples/ShowWatermarkedExports]]|Gets or sets whether exports should contain a watermark when license errors occur.|True|
|Boolean|[[ShowWaterMarks|/API/CodeSamples/ShowWaterMarks]]|Gets or sets whether watermarks will be used on license errors.|True|
|Boolean|[[ShowWidth|/API/CodeSamples/ShowWidth]]| Gets or sets whether the "Width" textbox should be shown on the Fields Tab of the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|False|
|Boolean|[[ShowXLSButton|/API/CodeSamples/ShowXLSButton]]|Gets or sets whether exporting to Microsoft Excel is allowed.|True|
|String|[[SimpleFilterCssUrl|/API/CodeSamples/SimpleFilterCssUrl]]| Gets or sets the CSS stylesheet URL for the Izenda.Web.UI.FilterList. |rp.aspx?auid=[auid]&css=SimpleFilter|
|Boolean|[[SingleLineViewerToolbar|/API/CodeSamples/SingleLineViewerToolbar]]| Gets or set value indicating whether the toolbar for the classic Izenda.AdHoc.AdHocSettings.ReportViewer should be single line. **(deprecated)**|False|
|BindIPEndPoint|[[SmtpClientBindIPEndPointDelegate|/API/CodeSamples/SmtpClientBindIPEndPointDelegate]]|Gets or sets the BindIPEndPointDelegate of SMTPClient for sending e-mails.|String.Empty|
|String|[[SmtpLogin|/API/CodeSamples/SmtpLogin]]|Gets or sets the SMTP server login username.|String.Empty|
|String|[[SmtpPassword|/API/CodeSamples/SmtpPassword]]|Gets or sets the SMTP server password.|String.Empty|
|Int32|[[SmtpPort|/API/CodeSamples/SmtpPort]]|Gets or sets the SMTP server port for sending e-mails.|25|
|Boolean|[[SmtpSecureConnection|/API/CodeSamples/SmtpSecureConnection]]|Gets or sets the SMTP server secure connection for sending e-mails.|False|
|String|[[SmtpServer|/API/CodeSamples/SmtpServer]]|Gets or sets the SMTP server address for sending e-mails.|localhost|
|Boolean|[[SortColumnNames|/API/CodeSamples/SortColumnNames]]|Gets or sets whether dropdowns with column names are sorted alphabetically.|True|
|Boolean|[[SortGridOnServerInViewer|/API/CodeSamples/SortGridOnServerInViewer]]|Determines the behavior of the sorting feature triggered by clicking on the header in the report grid.            When set to True report grid is sorted on the server and rendered results are refreshed.            Note: Works only in Report Viewer.|False|
|Int32|[[SqlCommandTimeout|/API/CodeSamples/SqlCommandTimeout]]|Gets or sets the wait time in seconds for dropdown menus that use results loaded from database queries.            If the wait time has elapsed and the query has not returned, the command ends.|3600|
|String|[[SqlServerConnectionString|/API/CodeSamples/SqlServerConnectionString]]|Gets or sets the connection string used to connect to an MSSQL database.|String.Empty|
|Boolean|[[StoreCurrentReportSetInApplication|/API/CodeSamples/StoreCurrentReportSetInApplication]]|Gets or sets whether the CurrentReportSet should be stored as an application variable instead of a session variable.|False|
|Int32|[[StoredProcedureStringLimit|/API/CodeSamples/StoredProcedureStringLimit]]|Gets or sets the maximum length of VARCHAR parameters used by Stored Procedures (-1 for MAX)**(deprecated)**|-1|
|Boolean|[[StoreImagesToCache|/API/CodeSamples/StoreImagesToCache]]|Gets or sets the value indicating how temporary images should be stored.|True|
|Boolean|[[StrictANSIOuterJoin|/API/CodeSamples/StrictANSIOuterJoin]]|Gets or sets value indicating that strict ANSI/ISO SQL-92 outer join will be used (affects filters applied to joined tables).|True|
|Boolean|[[StripInvalidCharacters|/API/CodeSamples/StripInvalidCharacters]]|Gets or sets whether invalid characters in report names should be stripped.             Valid characters are any alphanumeric characters, underscores, hyphens, backslashes, single quotes, and whitespace.|True|
|String|[[SubCalculationFilterRegex|/API/CodeSamples/SubCalculationFilterRegex]]|Gets or sets the regular expression used for subtotal calculation.            If the name of a column matches this expression then it will not be considered when calculating subtotals.|ID$&#124;Id$&#124;^id$&#124;_id$|
|String|[[TabBackgroundImageUrl|/API/CodeSamples/TabBackgroundImageUrl]]| Gets or sets the URL of the background image used for the tabs on the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|String.Empty|
|AliasesCollection|[[TableAliases|/API/CodeSamples/TableAliases]]|Gets or sets the collection of key-value pairs where the key is the table name and            the value is a table alias.**(deprecated)**|null|
|Unit|[[TableDropDownWidth|/API/CodeSamples/TableDropDownWidth]]| Gets or sets the width of the dropdowns on the Advanced mode of the DataSources Tab of the Izenda.Web.UI.AdHocReportDesigner. |190px|
|String|[[TableFilterRegex|/API/CodeSamples/TableFilterRegex]]|Gets or sets the regular expression used for table filtering.            If the name of a table or a column matches this expression then it will be excluded.|^(IzendaAdHoc)|
|String|[[TabsCss|/API/CodeSamples/TabsCss]]| Gets or sets the CSS style for the Izenda.Web.UI.TabStrip. **(deprecated)**|@import url(rp.aspx?auid=[auid]&css=tabs);|
|String|[[TabsCssUrl|/API/CodeSamples/TabsCssUrl]]| Gets or sets the CSS stylesheet URL for the Izenda.Web.UI.TabStrip. |rp.aspx?auid=[auid]&css=tabs|
|String|[[TempFiles|/API/CodeSamples/TempFiles]]|Gets or sets the path to the folder for storing temporary files.|TempFiles|
|String|[[TemplatesPath|/API/CodeSamples/TemplatesPath]]|Gets or sets the path of the folder where designed form templates are stored.             Requires Izenda's forms product extension.|[drive]:\[ApplicationFolder]\Reports|
|String|[[TenantField|/API/CodeSamples/TenantField]]|The name of the database field that stores tenant information for users.            The user's TenantIDs are used as the values that will be matched within the field's data.|String.Empty|
|Boolean|[[TenantFilterOrIsBlank|/API/CodeSamples/TenantFilterOrIsBlank]]|Gets or sets if tenant-driven filter will be OrIsBlank|False|
|FieldHighlightInfoDictionary|[[TextHighlight|/API/CodeSamples/TextHighlight]]|Gets the list of name value pairs that correspond to fields in the report and the color used to shade the field contents.**(deprecated)**|null|
|Boolean|[[ThrowExceptionOnAddConstraintError|/API/CodeSamples/ThrowExceptionOnAddConstraintError]]|Determines whether exception will be thrown when constraint can't be added using Driver.AddConstraint method|True|
|Int32|[[ThumbnailHeight|/API/CodeSamples/ThumbnailHeight]]|Gets or sets the value indicating thumbnail height in pixels.|220|
|Int32|[[ThumbnailWidth|/API/CodeSamples/ThumbnailWidth]]|Gets or sets the value indicating thumbnail width in pixels.|170|
|Unit|[[TimePeriodDropDownWidth|/API/CodeSamples/TimePeriodDropDownWidth]]|Gets or sets the width of the "Values" dropdown when the "In Time Period" operator is selected.|190px|
|Double|[[TimeZoneOffset|/API/CodeSamples/TimeZoneOffset]]|Gets or sets the value indicating the time zone offset in Hours.|0|
|SchedulerTimeZoneCollection|[[TimeZones|/API/CodeSamples/TimeZones]]|Gets or sets the collection of additional and hidden time zones for scheduling reports.**(deprecated)**|null|
|String|[[ToolbarBackgroundImageUrl|/API/CodeSamples/ToolbarBackgroundImageUrl]]| Gets or sets the URL of the gradient image used on the Izenda.Web.UI.AdHocToolbarNavigation control of the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|String.Empty|
|String|[[ToolbarBorderColor|/API/CodeSamples/ToolbarBorderColor]]| Gets or sets the color of the border used on the Izenda.Web.UI.AdHocToolbarNavigation control of the Izenda.Web.UI.AdHocReportDesigner. **(deprecated)**|#95b7f3|
|String|[[ToolbarCssUrl|/API/CodeSamples/ToolbarCssUrl]]| Gets or sets the CSS stylesheet URL for the Izenda.Web.UI.AdHocToolbarNavigation control of the Izenda.Web.UI.AdHocReportDesigner. |rp.aspx?auid=[auid]&css=toolbar|
|Boolean|[[TrimSqlFilterInput|/API/CodeSamples/TrimSqlFilterInput]]|Determines whether filter values are trimmed automatically to avoid accidental incorrect input|True|
|Boolean|[[TrimTimeInJoins|/API/CodeSamples/TrimTimeInJoins]]|Gets or sets whether joins using DateTime database fields will use the time portion of the field value or not when constructing the join.|True|
|Int32|[[UltimateDbCommandTimeout|/API/CodeSamples/UltimateDbCommandTimeout]]|Gets or sets the wait time in seconds for ANY database command.|-1|
|String|[[UnCategorizedReportsMenuItemTitle|/API/CodeSamples/UnCategorizedReportsMenuItemTitle]]|Gets or sets the uncategorized reports menu item title.**(deprecated)**|Reports|
|Boolean|[[UseAdvancedGauge|/API/CodeSamples/UseAdvancedGauge]]|Gets or sets whether to use a more visually appealing gauge when using the "Gauge" format.            The basic gauge is a solid color non-stylized bar whereas the advanced gauge has tick marks and uses gradient colors.|True|
|Boolean|[[UseBulkCSV|/API/CodeSamples/UseBulkCSV]]|Gets or sets whether CSV exports will use standard or bulk processing methods.            The maximum number of rows a bulk export can retrieve is contingent on the ExportLimit.|True|
|Boolean|[[UseCachedFilteredLists|/API/CodeSamples/UseCachedFilteredLists]]|Gets or sets whether reports list caching is enabled.            This setting is application-wide.|True|
|Boolean|[[UseColumnNameForDashboardCommonFilters|/API/CodeSamples/UseColumnNameForDashboardCommonFilters]]|Gets or sets whether common filters in the Dashboard should be combined using Column Name only.             Otherwise filters will not be combined at all.|True|
|Boolean|[[UseConstraintsForJoins|/API/CodeSamples/UseConstraintsForJoins]]|Gets or sets whether multiple autojoining conditions are allowed.**(deprecated)**|False|
|Boolean|[[UseDefaultDialogs|/API/CodeSamples/UseDefaultDialogs]]|Gets or sets the value indicating whether system dialogs should be shown instead of AdHoc dialogs.**(deprecated)**|False|
|Boolean|[[UseFriendlyErrors|/API/CodeSamples/UseFriendlyErrors]]|Gets or sets the value indicating whether friendly errors should be shown on exceptions.             Friendly errors are represented with the error message and a hyperlink that opens the stack trace in a framed HTML output string.            When this is false, errors are simply re-thrown to be handled by .NET's error handling.|True|
|Boolean|[[UseImageDescriptions|/API/CodeSamples/UseImageDescriptions]]|Gets or sets whether charts, gauges, and other images will use an ALT tag containing relevant information to describe the image.|False|
|Boolean|[[UseNoLock|/API/CodeSamples/UseNoLock]]|Gets or sets the value indicating whether the NOLOCK statment will be used in SQL queries.|True|
|Boolean|[[UseNonPostbackDeleting|/API/CodeSamples/UseNonPostbackDeleting]]|Gets or sets whether deleting a report causes a postback to the server.            If the application is an MVC app, then this will always be true.|True|
|Boolean|[[UseNonPostbackExport|/API/CodeSamples/UseNonPostbackExport]]|Gets or sets whether exporting a report will cause a server postback to occur.|True|
|Boolean|[[UseNonPostbackPreview|/API/CodeSamples/UseNonPostbackPreview]]| Gets or sets whether clicking the "Preview" tab on the Izenda.Web.UI.AdHocReportDesigner causes a postback to the server. If the application is an MVC app, then this will always be true. |True|
|Boolean|[[UseNonPostbackServerEmailing|/API/CodeSamples/UseNonPostbackServerEmailing]]|Gets or sets the value indicating whether should not be postback on report sever emailing.|True|
|Boolean|[[UseReportID|/API/CodeSamples/UseReportID]]|Gets or sets whether GUIDs will be used instead of report names in web links and url parameters.|False|
|Boolean|[[UseSafeDivisionInExpressions|/API/CodeSamples/UseSafeDivisionInExpressions]]|Determines whether safe division SQL is automatically added to the Expressions with the division operator|True|
|Boolean|[[UseStrictDateTimeFilterParsing|/API/CodeSamples/UseStrictDateTimeFilterParsing]]|Gets or sets whether izenda should use strict parsing of pre-defined filter datetime values when saving report in designer to XML.|False|
|Boolean|[[ValidateBeforeSave|/API/CodeSamples/ValidateBeforeSave]]| Gets or sets the value indicating whether the Izenda.AdHoc.ReportSet should be validated before saving. Reports are invalid if they contain no fields or if any piece of the entire report threw an error. |False|
|Boolean|[[ValidateExistingReportsInDesigner|/API/CodeSamples/ValidateExistingReportsInDesigner]]|Gets or sets the value indicating whether reportset should be validated before saving|True|
|Boolean|[[ViewsOnly|/API/CodeSamples/ViewsOnly]]|Gets or sets the value indicating whether only views will be displayed on the datasources tab.|False|
|String[]|[[VisibleDataSources|/API/CodeSamples/VisibleDataSources]]| Gets or sets the array of datasource names that should be shown in the datasources dropdown on the Izenda.Web.UI.AdHocReportDesigner. |System.String[] {}|
|String[]|[[VisibleTables|/API/CodeSamples/VisibleTables]]|Gets or sets the array of table names that should be shown in the datasources dropdown.**(deprecated)**|System.String[] {}|
|VisualGroupStyle|[[VisualGroupStyle|/API/CodeSamples/VisualGroupStyle]]|Gets or sets the default Visual Group style that will be used when designing reports.**(deprecated)**|CommaDelimited|
|String|[[VisualizationsBaseUrl|/API/CodeSamples/VisualizationsBaseUrl]]|Gets or sets the base url for visualizations files.|String.Empty|
|String|[[VisualizationsFolder|/API/CodeSamples/VisualizationsFolder]]|Gets or sets full path to the Visualizations folder|String.Empty|
|String[]|[[WebFarmNodesRsUrls|/API/CodeSamples/WebFarmNodesRsUrls]]|Gets or sets response server urls of other machines in webfarm|String.Empty|