#AdHocSettings

The ``AdHocSettings`` class contains all the settings Izenda uses to control various aspects of the interface and flow of data. Many of the more useful settings are explained in detail in our [[Guide to Report Design|/Guides/ReportDesign]] and [[Developer Guides|/Guides/Developer-Links-and-Guides]]. 

|Datatype|Setting name|Setting description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|string|[[AddAllFilterRegex|API/CodeSamples/AddAllFilterRegex]]|Gets or sets a regular expression to filter data source fields that can be added with the "Add All" button.|(id&#124;guid)$|
|   Dictionary<string,double>|[[AdditionalTimeZones |API/CodeSamples/AdditionalTimeZones ]]||Empty list|
|   AdHocConfig|[[AdHocConfig|http://wiki.izenda.us/Integration/Tutorials/Customizing-Izenda-Settings]]|Gets or sets the current Ad Hoc configuration.|new FileSystemAdHocConfig()|
|   string|[[AdHocUserKey|API/CodeSamples/AdHocUserKey]]|Gets or sets the password limiting access to the report designer, report list, and report viewer. This is for projects that do not need multi-user security.|string.Empty()|
|   AggregateFunctionCollection|[[AggregateFunctions|API/CodeSamples/AggregateFunctions]]||Empty list|
|   bool|[[AllowAnalysisGrid|API/CodeSamples/AllowAnalysisGrid]]|Gets or sets the value indicating whether to include Analysis Grid in the Visual Group Style field.|True|
|   bool|[[AllowArchivedReportTableCreation|API/CodeSamples/AllowArchivedReportTableCreation]]|Gets or sets whether to allow the application to create an archived reports table on the database.|True|
|   bool|[[AllowClientSorting|API/CodeSamples/AllowClientSorting]]||True|
|   bool|[[AllowComparativeArithmetic|API/CodeSamples/AllowComparativeArithmetic]]|Gets or sets the value indicating whether comparative arithmetic is allowed in arithmetic checkbox. Comparative operators appear in "A" checkboxes at the Fields tab in the ReportDesigner.|False|
|   bool|[[AllowCreateNewCategory|API/CodeSamples/AllowCreateNewCategory]]|Gets or sets the value indicating the possibility to create new categories in Save As dialog in the ReportDesigner.|True|
|   bool|[[AllowDataFieldsInDescription|API/CodeSamples/AllowDataFieldsInDescription]]|Gets or sets whether data fields can be used in report descriptions.|True|
|   bool|[[AllowDeletingReports|API/CodeSamples/AllowDeletingReports]]|This checkbox enables/disables the delete icons at the report list page against reports names, for the current user. Clicking on the red x delete icon deletes the report.|True|
|   bool|[[AllowDeltas|API/CodeSamples/AllowDeltas]]|Gets or sets the value indicating whether "Add Deltas" checkbox should be shown at the fields tab in the ReportDesigner. Any time there is a change in a quantity that change is calculated by taking the later value for that quantity and subtracting from it the earlier value for that quantity.|False|
|   bool|[[AllowDomainJoin|API/CodeSamples/AllowDomainJoin]]|Gets or sets the value indicating whether domain joins should be shown on the report designer.|False|
|   bool|[[AllowEqualsSelectForStoredProcedures|API/CodeSamples/AllowEqualsSelectForStoredProcedures]]|Gets or sets the value indicating is it allowed to use Equals(Select) or Equals(Multiple) for filters in case when stored procedure used. These options can be found in the Operator dropdown at the Filters tab in the ReportDesigner.|False|
|   bool|[[AllowFieldsAsValue|API/CodeSamples/AllowFieldsAsValue]]|Gets or sets the value indicating whether field name is allowed in filter value. If set, values like "Is Less Than (Field)" appear in the Operator combobox at the Filters tab in the ReportDesigner. Fields comparison allows you to compare values from one field with values from another field.|True|
|   bool|[[AllowGroupWithoutSelect|API/CodeSamples/AllowGroupWithoutSelect]]|Gets or sets value indicating if it is possible to make invisible fields which are used for Visual Grouping. If set, fields with both "Hide This Field" (in the advanced properties) and "VG"; flags set, will not lead to report being considered as invalid.|False|
|   bool|[[AllowHorizontalBarChart|API/CodeSamples/AllowHorizontalBarChart]]|Gets or sets the value indicating whether Horizontal Bar Chart is allowed. This defines if Horizontal checkbox will be available in the Advanced Properties at the Chart tab in the ReportDesigner, when Bar chart type is used.|True|
|   bool|[[AllowHtmlOutputsInScheduledReports|API/CodeSamples/AllowHtmlOutputsInScheduledReports]]||True|
|   bool|[[AllowInvalidCharacters|API/CodeSamples/AllowInvalidCharacters]]|Gets or sets the value indicating whether invalid characters in report namesare allowed if not striped. If disabled, non-literal characters in the report name, entered in the Report Designer in Save As dialog, will cause error message during saving report. <br>*Note: Invalid characters will be automatically removed from the report name if [[StripInvalidCharacters]] set to true.*|False|
|   bool|[[AllowInvertedGrid|API/CodeSamples/AllowInvertedGrid]]|Allows the inverted checkbox to be shown in the Summary tab in the ReportDesigner. Inverted grid means it exchanges columns for rows (up to 36 rows)|False|
|   bool|[[AllowLineOnBar|API/CodeSamples/AllowLineOnBar]]|Gets or sets the value indicating whether is it allowed line on Bar chart. If true, then Line Value feature is available at the Chart tab in the ReportDesigner, when Bar chart type is selected. Line can show additional values on the Bar chart.|True|
|   bool|[[AllowMultilineHeaders|API/CodeSamples/AllowMultilineHeaders]]|Gets or sets whether headers in the grid report can be multi-line. This setting could be useful if you have many columns in the report or columns names are very long.|False|
|   bool|[[AllowNewFiltersInReportViewer|API/CodeSamples/AllowNewFiltersInReportViewer]]|Gets or sets whether users have the ability to add new filters in the report viewer page of Izenda Reports.|True|
|   bool|[[AllowOverwritingReports|API/CodeSamples/AllowOverwritingReports]]|This enables/disables the current user's ability to overwrite reports currently saved. An example of this usage is that many users create base reports for their users to use. Disabling the overwrite report feature ensures that the default reports are not tampered with.|True|
|   bool|[[AllowSelfJoin|API/CodeSamples/AllowSelfJoin]]|Gets or sets the value indicating whether is it allowed datasources self join. If true and ShowDataSourcesAsCheckBoxes, then user can select the same data source twice and selfjoin it at the Data Sources tab in the ReportDesigner.|True|
|   bool|[[AllowStackedBarChart|API/CodeSamples/AllowStackedBarChart]]|Gets or sets the value indicating whether Stacked Bar Chart is allowed. This defines if Stacked checkbox will be available in the Advanced Properties at the Chart tab in the ReportDesigner, when Bar chart type is used.|True|
|   bool|[[AllowSummaryDeltas|API/CodeSamples/AllowSummaryDeltas]]|Gets or sets the value indicating whether the "Show Summary Deltas" checkbox should be shown in the summary tab in the ReportDesigner. Any time there is a change in a quantity, that change is calculated by taking the later value for that quantity and subtracting from it the earlier value for that quantity. The AllowDeltas feature MUST be turned on to use this feature.|True|
|   bool|[[AllowVisualGroups|API/CodeSamples/AllowVisualGroups]]||True
|
|   string|[[ApplicationHeaderImageUrl|API/CodeSamples/ApplicationHeaderImageUrl]]|Gets or sets the URL of the Application Header Logo.|
|
|   bool|[[AutoJoinOnRenderedRows|API/CodeSamples/AutoJoinOnRenderedRows]]||True
|
|   bool|[[AutoPostBackOnFilterChange|API/CodeSamples/AutoPostBackOnFilterChange]]|Gets or sets the value indicating whether should be postback on filter change. This affects behavior of ReportViewer when ShowFiltersInReportViewer is enabled, and user changes filters there. All changes will be applied immediately and report will be reloaded.|True
|
|   bool|[[CacheEqualsSelect|API/CodeSamples/CacheEqualsSelect]]|Gets or sets the value indicating whether "Equals (Select)" value should be cached. Caching "Equals (Select)" can be useful if you have problems with performance in your data base or slow connection to it. But data in cache may be not relevant if it is updated very often in the data base. So, use this setting carefully.|False
|
|   bool|[[CacheQueries|API/CodeSamples/CacheQueries]]|Gets or sets the value indicating whether all queries for the Driver should be cached.|True
|
|   bool|[[CacheReports|API/CodeSamples/CacheReports]]|Gets or sets the value indicating whether all loaded reports should be cached. This feature can be very useful if you have problems with performance in your database or connections are slow. Loaded ReportSet will be cached, so there will be no extra queries to the database. When you save the Reportset cache for it will be removed and it will be added again when ReportSet will be loaded again. Report caching may cause problems if you are running more than one instance of Izenda Adhoc with the same reports source (i.e. the same database and table or same reports folder).|False
|
|   bool|[[CacheSchema|API/CodeSamples/CacheSchema]]|Gets or sets the value indicating whether DatabaseSchema should be cached. Disable schema caching may be useful if you data base schema changes very often. But ussually it is better to use caching because it will prevent extra queries to the data base.|True
|
|   bool|[[CacheStoredProcedureMetaDataToDisk|API/CodeSamples/CacheStoredProcedureMetaDataToDisk]]|Gets or sets the value indicating whether the information about stored procedures will be cached on the server's disk. Normally stored procedures are updated with the database schema. But if CacheStoredProcedureMetaDataToDisk is enabled, they will be stored in the Izenda.config file and will not be updated with the schema. Normally, you don't need to use stored procedure caching, so use this feature only when you have problems with performance while loading a large amount of stored procedures.|False
|
|   bool|[[CascadeFilterValues|API/CodeSamples/CascadeFilterValues]]|Gets or sets the value indicating whether filter values at the Filters tab in the ReportDesigner will be cascaded. For example, this will only show cities in the country selected on the prior filter by country|True
|
|   char|[[CategoryCharacter|API/CodeSamples/CategoryCharacter]]|Get or set delimiter which is used to delimit category name and report name.|\
|
|   bool|[[ChangParentUrlWhenRedirect|API/CodeSamples/ChangParentUrlWhenRedirect]]||False
|
|   ChartingEngine|[[ChartingEngine|API/CodeSamples/ChartingEngine]]||DundasChart
|
|   int|[[ChartLimit|API/CodeSamples/ChartLimit]]|Gets or sets the value limiting chart items on Dashboards.|500
|
|   ChartCollection|[[Charts|API/CodeSamples/Charts]]|Gets or sets the collection of available Charts. The collection of available charts is shown in the Chart Type combobox on the Chart tab in the ReportDesigner.|Izenda.AdHoc.ChartCollection
|
|   Point|[[ChartSize|API/CodeSamples/ChartSize]]|Gets or sets the value indicating chart size. This will affect size of all charts in the rendered report or dashboard.|{X=700,Y=300}
|
|   string[]|[[ChartSortFields|API/CodeSamples/ChartSortFields]]|Gets or sets the value indicating the fields that will be used for sorting data in charts.|
|
|   int|[[CheckBoxListColumns|API/CodeSamples/CheckBoxListColumns]]|Gets or sets the maximum number of checkbox columns in "Quick add" dialog in the Report Designer on the Fields tab. <br> *Note: Fields will be grouped in columns in cases when the number of fields is greater then QuickAddMinElementsInColumn*.|2
|
|   bool|[[CheckForUpdates|API/CodeSamples/CheckForUpdates]]||True
|
|   bool|[[CheckUserPermission|API/CodeSamples/CheckUserPermission]]|Gets or sets value indicating that user permissions should be checked. If disabled, all reports will be accessible to all users.|True
|
|   bool|[[CollapsedFiltersInReportViewer|API/CodeSamples/CollapsedFiltersInReportViewer]]|Gets or sets the value indicating whether the filters section of the Report Viewer should be initially hidden. You should have ShowFiltersInReportViewer enabled to use this setting.|False
|
|   Unit|[[ColumnDropDownWidth|API/CodeSamples/ColumnDropDownWidth]]|Gets or sets the value indicating the width of the box for dropdown boxes on the Fields tab in the ReportDesigner.|200px
|
|   CultureInfo|[[Culture|API/CodeSamples/Culture]]|Gets or sets the default culture setting for AdHoc. <br> *Note: Use this only in special cases. Normally, you should use the Language setting for localization. To learn more, see the links below:* <br>[[Language]] <br>[[Izenda Language Pack]]|en-US
|
|   bool|[[CurrentUserIsAdmin|API/CodeSamples/CurrentUserIsAdmin]]|Gets or sets whether the current user is an Admin user. Admins may see and overwrite all reports for that tenant.|True
|
|   bool|[[CurrentUserIsGlobalAdministrator|API/CodeSamples/CurrentUserIsGlobalAdministrator]]|Defines if the current user has global administrator rights.|False
|
|   string|[[CurrentUserName|API/CodeSamples/CurrentUserName]]|Gets or sets the name of the current user. This is required for multi-user security.|DefaultAdministrator
|
|   string[]|[[CurrentUserRoles|API/CodeSamples/CurrentUserRoles]]|Defines groups set for the current user.|System.String[]
|
|   string|[[CurrentUserTenantId|API/CodeSamples/CurrentUserTenantId]]|This identifies what tenant the current user is associated with in a multi-tenant system.|
|
|   CustomizeChartDelegate|[[CustomizeChartDelegate|API/CodeSamples/CustomizeChartDelegate]]|Represents a method that runs before chart reports get run.|
|
|   CustomTimePeriodCollection|[[CustomTimePeriods|API/CodeSamples/CustomTimePeriods]]|Used to define custom time periods that will be accessible in the 'In Time Period' filter operator on the Filters tab in the ReportDesigner. These options will be appended to the list of time periods that ship with Izenda AdHoc.<br>*Note: There are several overloads for the CustomTimePeriod constructor, so you can define different time periods with various types.*|Izenda.AdHoc.CustomTimePeriodCollection
|
|   DashboardDateSliderMode|[[DashboardDateSliderMode|API/CodeSamples/DashboardDateSliderMode]]|Gets or sets the value indicating the size of each section of the graph with the Dashboard date slider.|Auto
|
|   string|[[DashboardDesignerUrl|API/CodeSamples/DashboardDesignerUrl]]|Gets or sets the URL of the page used to design dashboards (DashboardDesigner).|DashboardDesigner.aspx
|
|   string|[[DashboardDesignerUrlWithDelimiter|API/CodeSamples/DashboardDesignerUrlWithDelimiter]]|Gets the DashboardDesignerUrl with query string characters ("?" and "&") at the end.|DashboardDesigner.aspx?
|
|   int|[[DashboardFieldsCount|API/CodeSamples/DashboardFieldsCount]]|Gets or sets the count of additional reports. Affects ReportDesigner when ShowDashboardFieldsTab is true.|3
|
|   double|[[DashboardGaugeWidthMax|API/CodeSamples/DashboardGaugeWidthMax]]|Deprecated.|1.79769313486232E+308
|
|   double|[[DashboardGaugeWidthMin|API/CodeSamples/DashboardGaugeWidthMin]]|Deprecated.|-1.79769313486232E+308
|
|   int|[[DashboardGaugeWidth|API/CodeSamples/DashboardGaugeWidth]]|Gets or sets the gauge width for "Dashboard Gauge" format. This will affect the width of gauges when they are shown in the dashboards. This replaced DashboardGaugeMax and DashboardGaugeMin and should be used instead of these at all times.|200
|
|   int|[[DashboardMinimumWidth|/API/CodeSamples/DashboardMinimumWidth]]|Deprecated.|1000
|
|   bool|[[DashboardMode|/API/CodeSamples/DashboardMode]]||False
|
|   string|[[DashboardsCss|/API/CodeSamples/DashboardsCss]]|Deprecated.|@import url(rs.aspx?css=dashboard);
|
|   string|[[DashboardsCssUrl|API/CodeSamples/DashboardsCssUrl]]|Gets or sets the CSS stylesheet URL to use for the TabStrip.|rs.aspx?css=dashboard
|
|   string|[[DashboardTabBackgroundImageUrl|API/CodeSamples/DashboardTabBackgroundImageUrl]]|Gets or sets the URL of the image used for the Dashboards' tabs.|
|
|   string|[[DashboardViewer|API/CodeSamples/DashboardViewer]]||ReportViewer.aspx
|
|   string|[[DashboardViewerWithDelimiter|API/CodeSamples/DashboardViewer]]|Gets or the report viewer page with query string characters ("?" and "&") at the end.|ReportViewer.aspx?
|
|   string|[[DatabaseDiagramImageUrl|API/CodeSamples/DatabaseDiagramImageUrl]]|Gets or sets a link to a database diagram image that is displayed on the report designer. Database diagrams display table relationships and can be created through Microsoft SQL. Izenda recommends using a database diagram to simplify the process of joining complex related tables.|
|
|   DateTime|[[DataCacheExpiration|API/CodeSamples/DataCacheExpiration]]||null
|
|   int|[[DataCacheInterval|API/CodeSamples/DataCacheInterval]]||0
|
|   NameDistinctValueCollection|[[DataSourceAliases|API/CodeSamples/DataSourceAliases]]|Gets or sets the collection of key-value pairs where the key is the table name and the value is a table alias. <br> *Note:This property doesn't change the data source name in database. It is for display purposes only.|NameDistinctValueCollection
|
|   NameStringsCollection|[[DataSourceCategories|API/CodeSamples/DataSourceCategories]]|This allows you to assign sets of datasources to different categories. When ShowDataSourcesAsCheckBoxes is enabled, this list is added to the Data Sources tab dropdown in the ReportDesigner. If the user selects a category, only datasources from the selected category will be shown.|Izenda.AdHoc.Collections.NameStringsCollection
|
|   TimeSpan|[[DataSourceDropDownTimeout|API/CodeSamples/DataSourceDropDownTimeout]]|Gets or sets the timeout between starting loading dropdown values (in the DataSources dropdown at the Data Sources tab in the ReportDesigner) from the server and redirecting to the About page.|00/00/15
|
|   Unit|[[DataSourceDropdownWidth|API/CodeSamples/DataSourceDropdownWidth]]|Deprecated|190px
|
|   string|[[DataSourceHeading|API/CodeSamples/DataSourceHeading]]|Gets or sets the value of the title on the Data Sources tab of Report Designer. Some users rename this since other users may not be familiar with database terminology.|Data Sources (Tables and Views)
|
|   int|[[DataSourceLimit|API/CodeSamples/DataSourceLimit]]|This setting limits the number of data sources Izenda Reports allows to be used in a single report when designing reports.|1000
|
|   int|[[DateArithmeticDecimalPlaces|API/CodeSamples/DateArithmeticDecimalPlaces]]|Gets or sets the value indicating how many decimal places to use for comparing dates. This can help yield more precise dates in calculations.|0
|
|   string|[[Db2ConnectionString|API/CodeSamples/Db2ConnectionString]]|Gets or sets the connection string for DB2 connections.|
|
|   string|[[DefaultAlternatingItemColor|API/CodeSamples/DefaultAlternatingItemColor]]|Gets or sets the default alternating grid item color on reports.|Gainsboro
|
|   string|[[DefaultHeaderForegroundColor|API/CodeSamples/DefaultHeaderForegroundColor]]|Gets or sets the default grid header foreground color on reports.|White
|
|   string|[[DefaultItemForegroundColor|API/CodeSamples/DefaultItemForegroundColor]]|Gets or sets the default grid item foreground color on reports.|Black
|
|   int|[[DefaultItemsPerPage|API/CodeSamples/DefaultItemsPerPage]]|This setting changes how many items are shown in the report viewer per page. For example, let's say a report had 150 items. By default, this value is set to 100. So 100 items would be displayed on the first page. When the user scrolls to the bottom of the page, they will see a link that shows 101-150. When the user clicks on it, the remaining report items will be shown.|10000
|
|   int|[[DefaultLinesPerItem|API/CodeSamples/DefaultLinesPerItem]]|Gets or sets the default count of lines per item for the "Multi-Line" feature. The default value is 2 and is listed in the style tab of the report designer under the "Field/Value common pairs" dropdown. Let's say that you have a report with 12 fields. This report would be difficult to print. By changing this value to 2, the grid would be 6 fields wide instead of 12. This is a feature commonly used in accounting style reports.|1
|
|   string|[[DefaultLoadTab|API/CodeSamples/DefaultLoadTab]]|Sets the default tab that loads when a report is loaded in report designer. By default, this goes to the Fields tab.|Fields
|
|   int|[[DefaultPreviewResults|API/CodeSamples/DefaultPreviewResults]]|This changes the default number of results (records) shown in the report designer preview tab. When exporting, all results will always be exported. Web browsers can become slow or stop completely when reports with hundreds of thousands of lines are generated, so keep this in mind when changing this setting. Ideally, this should be set to a power of 10 (1, 10, 100, 1000, etc).|100
|
|   string|[[DefaultReportBorderColor|API/CodeSamples/DefaultReportBorderColor]]|Sets the default grid border color for reports.|White
|
|   string|[[DefaultReportHeaderColor|API/CodeSamples/DefaultReportHeaderColor]]|Sets the default report header color.|DarkSlateBlue
|
|   string|[[DefaultReportItemColor|API/CodeSamples/DefaultReportItemColor]]|Sets the default report item background color.|White
|
|   StringCollection|[[DefaultReportOrder|API/CodeSamples/DefaultReportOrder]]|Gets or sets the default report order on the Style tab in the ReportDesigner. Acceptable string values include: "Maps", "Chart", "Chart2", "Chart3", "Chart4", "Gauges", "Summary", and "Detail". Order is determined by each entry's position in the list.|System.Collections.Specialized.StringCollection
|
|   string|[[DefaultSharingRights|API/CodeSamples/DefaultSharingRights]]|Gets or sets the value defining sharing rights that are assigned to the report by default.|None
|
|   string|[[DefaultTable|API/CodeSamples/DefaultTable]]|Gets or sets the name of the default table that is automatically added to new reports. If this is blank, no default table will be used. The table must be present in the database and be accessible.|
|
|   string|[[DefaultUserName|API/CodeSamples/DefaultUserName]]|This settings allows the application to assign a default username for users logged into the Izenda Reports web application. User names are shown on the report list and on the reports tab of the report designer.|DefaultAdministrator
|
|   string|[[DefaultVisibilityForNonAdmins|API/CodeSamples/DefaultVisibilityForNonAdmins]]|Gets or sets the default visibility group for non admins. This setting defines which groups of reports will be visible by default to the non-administrator users.|OnlyMe
|
|   Unit|[[DescriptionWidth|API/CodeSamples/DescriptionWidth]]|Gets or sets the width of the "Description" textbox on the Fields tab of the Report Designer.|100px
|
|   NameValueCollection|[[DefaultReportOrder|API/CodeSamples/DefaultReportOrder]]|Deprecated.|System.Collections.Specialized.NameValueCollection
|
|   bool|[[Distinct|API/CodeSamples/Distinct]]|Sets the default value of the distinct checkbox. The distinct checkbox is located on the datasources tab of the report designer page.|True
|
|   bool|[[DistinctSubtotalInnerQuery|API/CodeSamples/DistinctSubtotalInnerQuery]]|Gets or sets the value indicating whether the DISTINCT option should be used in inner queries for calculating subtotals. This can affect database performance.|True
|
|   FormatCollection|[[DrillDownStyle|API/CodeSamples/DrillDownStyle]]|Gets or sets the list of available drill-down report field formats. This affects the contents of all "Drill-down style" comboboxes in the ReportDesigner.|Izenda.AdHoc.FormatCollection
|
|   AggregateFunctionCollection|[[DundasAggregateFunctions|API/CodeSamples/DundasAggregateFunctions]]||Izenda.AdHoc.AggregateFunctionCollection
|
|   string|[[EmailFromAddress|API/CodeSamples/EmailFromAddress]]|This gets or sets the value used as the default "email from" address for the automated scheduler.|adhoc@yourdomain.com
|
|   string|[[EmailSubjectFormatString|API/CodeSamples/EmailSubjectFormatString]]|This gets or sets the value used as the default subject of the emailed reports. By default it uses the report name as the subject of the email.|{0}
|
|   bool|[[EmbedReportInServerEmail|API/CodeSamples/EmbedReportInServerEmail]]|Gets or sets the value indicating whether a report will be embedded in the server email.|False
|
|   string|[[EmptyReportString|API/CodeSamples/EmptyReportString]]||
|
|   int|[[EqualsDropdownLimit|API/CodeSamples/EqualsDropdownLimit]]|Deprecated.|500
|
|   int|[[EqualsDropdownTimeout|API/CodeSamples/EqualsDropdownTimeout]]|Deprecated.|60
|
|   Dictionary<string,string[]>|[[EqualsPopupDestinations |API/CodeSamples/EqualsPopupDestinations ]]||System.Collections.Generic.Dictionary`2[System.String,System.String[]]
|
|   string|[[EqualsSelectDateFormat|API/CodeSamples/EqualsSelectDateFormat]]|Deprecated.|MM/dd/yyyy
|
|   int|[[EqualsSelectLimit|API/CodeSamples/EqualsSelectLimit]]|Limits the number of rows(the dropdown options) selectable through the "Equals(select)" filter. These filters can be found in the Filters tab of the Report Designer and in the report viewer when an "Equals(Select)" filter is utilized. <br>*Note: by default this is set to either 500 or 1000 rows. If, for example, you have 2 choices (true and false) and the false value is not in the first 1000 rows, then true will be the only option shown unless you increase this number.|500
|
|   string|[[EqualsSelectText|API/CodeSamples/EqualsSelectText]]|Gets or sets a value that allows the user to specify the wording for the "Equals(Select)" filter. The "Select(Equals)" option is found in the filter tab of report designer in the operator drop down box.|Equals (Select)
|
|   int|[[EqualsSelectTimeout|API/CodeSamples/EqualsSelectTimeout]]|This setting allows the user to set how long to wait while the values of the filters tab is populated before timing out. If you have a large or unoptimized database, increasing this setting can help with proper reporting performance. This setting replaced EqualsDropDownTimeout and should be used instead.|60
|
|   string|[[ErrorIzendaReplacement|API/CodeSamples/ErrorIzendaReplacement]]|Gets or sets the value that will replace the word "Izenda" in StackTrace when an exception occurs. This is useful when you brand your distribution of Izenda to your own company name.|Izenda
|
|   string[]|[[ExistingDatabaseConstraints|API/CodeSamples/ExistingDatabaseConstraints]]|Gets a list of your database's constraints, if any.|System.String[]
|
|   bool|[[ExpandCategorizedReports|API/CodeSamples/ExpandCategorizedReports]]|Gets or sets whether the categorized reports underneath each category in the report list and in the report designer's preview tab can be expanded.|True
|
|   bool|[[ExpandVisualGroupGrids|API/CodeSamples/ExpandVisualGroupGrids]]|Gets or sets whether the visually grouped data details can be expanded underneath each visual grouping in the report viewer and in the report designer's preview tab. When enabled, all visual groups will be expanded automatically when you view the report.|True
|
|   Font|[[ExportFont|API/CodeSamples/ExportFont]]|Gets or sets the font for the PDF and RTF outputs. This is set to a standard font for [[iTextSharphttp://sourceforge.net/projects/itextsharp/]] by default|iTextSharp.text.Font
|
|   int|[[ExportLimit|API/CodeSamples/ExportLimit]]|Gets or sets a value indicating the maximum number of rows a ReportSet may export.|100000
|
|   NameValueCollection|[[ExtendedFormats|API/CodeSamples/ExtendedFormats]]|Deprecated.|Izenda.AdHoc.ExtendedFormatsCollection
|
|   string[]|[[ExtendedFunctions|API/CodeSamples/ExtendedFunctions]]|This list allows the user specify additional SQL functions that should be included in the functions dropdown of the Fields tab. Learn more about [[UDFshttp://wiki.izenda.us/FAQ/izenda-and-udfs]].|System.String[]
|
|   NameValueCollection|[[FieldAliases|API/CodeSamples/FieldAliases]]|Gets or sets the field names(aliases) that the user sees in the Report Designer, on a per-user basis. The name of your database column is used as the key and the alias you want is the value. This is useful for localization and when custom fields are used in your application.|System.Collections.Specialized.NameValueCollection
|
|   Unit|[[FieldDropDownWidth|API/CodeSamples/FieldDropDownWidth]]|Gets or sets the width of field dropdown on the Fields tab in the ReportDesigner.|200px
|
|   string|[[FieldFilterRegex|API/CodeSamples/FieldFilterRegex]]|Deprecated.|MD5&#124;^(Passw)
|
|   int|[[FieldLimit|API/CodeSamples/FieldLimit]]|This setting limits the number of fields Izenda Reports allows to be used in a single report. Fields are set in the fields tab on the report designer page.|1000
|
|   FieldList|[[FieldList|API/CodeSamples/FieldList]]|Deprecated.|Izenda.Web.UI.FieldList
|
|   string|[[FieldsRegex|API/CodeSamples/FieldsRegex]]|Sets the regular expression used to select specific columns from your datasource. This setting allows the user to use a regular expression to filter certain fields from being added to the report through the fields tab in the report designer. This replaced FieldFilterRegex and should be used instead.|MD5&#124;^(Passw)
|
|   string|[[FieldValueCssUrl|API/CodeSamples/FieldValueCssUrl]]||rs.aspx?css=FieldValue
|
|   Unit|[[FilterParameterWidth|API/CodeSamples/FilterParameterWidth]]|Gets or sets the width of the Filters tab's "value(s)" controls when the "Equals" operator is selected.|300px
|
|   string|[[FiltersCustomPagesPath|API/CodeSamples/FiltersCustomPagesPath]]|Gets or sets the relative path to the Equals(PopUp) page if you are using a custom page.|
|
|   string|[[FiltersRegex|API/CodeSamples/FiltersRegex]]|Sets the regular expression used for column filtering for data selection. This setting allows the user to use a regular expression to filter certain fields from being added to the report through the Fields tab in the report designer.|MD5&#124;^(Passw)
|
|   bool|[[ForceNewNameOnSave|API/CodeSamples/ForceNewNameOnSave]]|Setting this property forces the "Save" button to function exactly like the "Save As" button. It requires the user to specify a report name when saving. If another report has the same name, Izenda Reports warns the user. <br> *Note: The AllowOverwritingReports property MUST be set to true for this to have any effect.|False
|
|   Unit|[[FormatDropDownWidth|API/CodeSamples/FormatDropDownWidth]]|Gets or sets the width of all "Format" dropdowns in the Report Designer.|190px
|
|   FormatCollection|[[Formats|API/CodeSamples/Formats]]|Gets or sets the list of available formats to apply to fields.|Izenda.AdHoc.FormatCollection
|
|   string|[[FormDesignerUrl|API/CodeSamples/FormDesignerUrl]]|Gets or sets the URL to the FormDesigner page.|./Forms/FormDesigner.aspx
|
|   Unit|[[FunctionDropDownWidth|API/CodeSamples/FunctionDropDownWidth]]|Gets or sets the width of Function dropdowns in the Report Designer.|182px
|
|   int|[[GaugeHeight|API/CodeSamples/GaugeHeight]]|Gets or sets the height for Gauge controls in ReportSets. This setting replaced GaugeMaximum and GaugeMinimum and should be used instead.<br> *Note: This setting will affect only Linear Gauges*.|50
|
|   int |[[GaugeMaximum|API/CodeSamples/GaugeMaximum|Deprecated.|1
|
|   int |[[GaugeMaximum|API/CodeSamples/GaugeMinimum]]|Deprecated.|0
|
|   string[]|[[GaugeStyles|API/CodeSamples/GaugeStyles]]|Gets or sets custom gauge types. This overrides the existing set of gauge styles, shown as radiobuttons on the Gauge tab in the ReportDesigner. If you use this, you should ensure that you either define IGaugeDrawer objects in the AdHocSettings.RadialGaugeDrawerCollection corresponding to your custom gauge styles, or you have overriden CustomizeGuage in your AdHocConfig.|
|
|   int|[[GaugeWidth|API/CodeSamples/GaugeWidth]]|Gets or sets the gauge width for "Gauge" format. This will affect width of gauges when they are shown in reportsets. <br> *Note: This setting will affect only Linear Gauges*.|250
|
|   bool|[[GenerateParameterizedSql|API/CodeSamples/GenerateParameterizedSql]]|Gets or sets the value indicating whether queries to the database should be parameterized.|True
|
|   bool|[[GenerateThumbnails|API/CodeSamples/GenerateThumbnails]]||False
|   string|[[GeoDataTable||API/CodeSamples/GeoDataTable]]|Gets or sets the value indicating the table name which contains geodata for maps.|
|
|   GetEqualsSelectValuesDelegate|[[GetEqualsSelectValues|API/CodeSamples/GetEqualsSelectValues]]|Represents a method that returns values for the "Equals(Select)" operator. This handles the list of values shown on the Fields tab in the ReportDesigner in the Value(s) combobox if the "Equals(Select)" operator is used.|
|
|   TableItemStyle|[[GridHeaderStyle|API/CodeSamples/GridHeaderStyle]]|Gets or sets the OpenOffice output style for grid headers in the report.|System.Web.UI.WebControls.TableItemStyle
|
|   TableItemStyle|[[GridItemStyle|API/CodeSamples/GridItemStyle]]|Gets or sets the OpenOffice output style for grid items in the report.|System.Web.UI.WebControls.TableItemStyle
|
|   System.Drawing.Color|[[HeaderForegroundColor|API/CodeSamples/HeaderForegroundColor]]|Gets or sets the color of the report header.|Color [White]
|
|   string|[[HeaderStyle|API/CodeSamples/HeaderStyle]]|Gets or sets the CSS style for the headers in the Fields, Summary, and Filters tabs.|font-family\ verdana, arial, helvetica, sans-serif; font-size\ 11px;color\blue;
|
|   NameValueCollection|[[HelpText|API/CodeSamples/HelpText]]|Gets or sets the collection of key-value pairs where the key is the tab name and the value is a hint that will be shown when the mouse is over the appropriate tab. Can be seen in the ReportDesigner if the ShowSideHelp property is enabled. <br> *Note: You can also enable/disable side help by clicking the Help button (the ShowHelpButton property must be enabled for this)*.|System.Collections.Specialized.NameValueCollection
|
|   string[]|[[HiddenCategories|API/CodeSamples/HiddenCategories]]|Sets which categories are hidden for the current user. Report from those categories will not be shown to the current user.|
|
|   string[]|[[HiddenColumns|API/CodeSamples/HiddenColumns]]|Gets or sets the array of Column names that should be hidden in the Fields tab dropdowns in the ReportDesigner.|
|
|   HiddenFilterCollection|[[HiddenFilters|API/CodeSamples/HiddenFilters]]|This controls row-level security throughout the application. This should be used in all multi-tenant systems and systems where users are restricted to certain records. Hidden filters are applied to the report being executed. They will not appear in the UI and are invisible to the user.|Izenda.AdHoc.HiddenFilterCollection
|
|   List<double>|[[HiddenTimeZones|API/CodeSamples/HiddenTimeZones]]|Deprecated.|System.Collections.Generic.List`1[System.Double]
|
|   string|[[IdentifiersRegex|API/CodeSamples/IdentifiersRegex]]||
|
|   string|[[ImagesPath|API/CodeSamples/ImagesPath]]|Gets or sets the path of the folder that contains the images used by Izenda AdHoc. If the value is not set, then built-in images will be used.|
|
|   bool|[[InheritFiltersInSubreports|API/CodeSamples/InheritFiltersInSubreports]]|Gets or sets the value indicating whether filters will be inherited in subreports. When enabled, subreports will have filters from the master report applied.|True
|
|   string|[[InstantReport|API/CodeSamples/InstantReport]]|Gets or sets the URL to the InstantReport page for custom implementations.|InstantReport.aspx
|
|   string|[[InstantReportWithDelimiter|API/CodeSamples/InstantReportWithDelimiter]]|Gets or sets the URL to the InstantReport page with query string characters appended("?" and "&").|InstantReport.aspx?
|
|   bool|[[InvalidateSchemaOnNew|API/CodeSamples/InvalidateSchemaOnNew]]|Gets or sets the value indicating whether the database schema should be invalidated when the user creates new report.|False
|
|   int|[[InvertedGridLimit|API/CodeSamples/InvertedGridLimit]]|Gets or sets the maximum count of rows for an inverted grid. This affects the maximum count of rows when set in the ReportDesigner.<br> *Note: The AllowInvertedGrid property MUST be enabled to use InvertedGridLimit*.|36
|
|   System.Drawing.Color|[[ItemForegroundColor|API/CodeSamples/ItemForegroundColor]]|Gets or sets the default color of the item text on the report grid.|Color [Black]
|
|   Unit|[[JoinDropDownWidth|API/CodeSamples/JoinDropDownWidth]]|Gets or sets the width of the join type dropdowns. These dropdowns can be found at the Data Sources tab of the ReportDesigner when ShowDataSourcesAsCheckBoxes is set to false.|100px
|
|   JoinedTablesList|[[JoinedTablesList|API/CodeSamples/JoinedTablesList]]|Deprecated.|Izenda.Web.UI.JoinedTablesList
|
|   string|[[JoinFieldRegex|API/CodeSamples/JoinFieldRegex]]|Gets or sets a regular expression used to filter certain fields from being shown in the join field between data sources in the data sources tab of report designer. For example, to show only fields ending with "ID", use following value: AdHocSettings.JoinFieldRegex = "^.*(?<!id)$";|
|
|   NameValueCollection|[[LabelAliases|API/CodeSamples/LabelAliases]]|Gets or sets the collection of key-value pairs where the key is the field name and the value is a field alias.|System.Collections.Specialized.NameValueCollection
|
|   AdHocLanguage|[[Language|API/CodeSamples/Language]]|Gets or sets the display language used for Izenda AdHoc.|English
|
|   string|[[LicenseKey|API/CodeSamples/LicenseKey]]|Gets or sets the license key for your distribution of Izenda AdHoc. This is absolutely required for the application to function.|null
|
|   char|[[LiteralComma|API/CodeSamples/LiteralComma]]|Gets or sets the delimiter separating items in the 'Equals' filter operator value. This is an actual comma by default for easy copy/paste from CSV format lists.|,
|
|   bool|[[LockViewer|API/CodeSamples/LockViewer]]|Gets or sets the value indicating whether the Report Viewer will be locked. If true, controls like Add/Remove field, filters control, etc. will be unavailable in the ReportViewer.|False
|
|   string|[[LoginUrl|API/CodeSamples/LoginUrl]]|This setting allows the user to specify their own login page to be utilized by Izenda Reports. Note to utilize this login page the "Require Login" check box must be selected.|Login.aspx
|
|   MapInfoCollection|[[MapInfoCollection|API/CodeSamples/MapInfoCollection]]|Gets or sets the registered maps data. This defines the contents of the Map Type dropdown at the Map tab in the ReportDesigner.|Izenda.AdHoc.Map.MapInfoCollection
|
|   Size|[[MaxImageSize|API/CodeSamples/MaxImageSize]]|Gets or sets the maximum image size of the report images. If the size of an image is larger than the specified value then the image will be scaled.|{Width=320, Height=240}
|
|   float|[[MaxVersion|API/CodeSamples/MaxVersion]]|Gets the max version number.|1048576
|
|   int|[[MaximumReportSizeForCache|API/CodeSamples/MaximumReportSizeForCache]]||6.7
|
|   Unit|[[MinPdfFontSize|API/CodeSamples/MinPdfFontSize]]|Sets the minimum font size that will be used when creating a PDF document. The default is 10 point.|10pt
|
|   bool|[[MultiLevelVisualGrouping|API/CodeSamples/MultiLevelVisualGrouping]]|Deprecated.|True
|
|   string|[[MySqlConnectionString|API/CodeSamples/MySqlConnectionString]]|Gets or sets the connection string for MySQL connections.|
|
|   string|[[NoDataSourcePage|API/CodeSamples/NoDataSourcePage]]|Gets or sets the URL of the page where users will be redirected if there are no tables in a database. By default it is the settings page.|Settings.aspx
|
|   int|[[NumChartPerRow|API/CodeSamples/NumChartPerRow]]|Gets or sets the value indicating the number of charts that should be displayed in one report row on Dashboards.|2
|
|   int|[[NumChartTabs|API/CodeSamples/NumChartTabs]]|Sets the maximum number of charts allowed per report in the ReportDesigner. Each chart will have it's own tab in the report designer. Setting this to more than 1 requries a Dashboards license.|2
|
|   int|[[NumSharedDropdowns|API/CodeSamples/NumSharedDropdowns]]|Gets or sets the maximum number of user/roles a report can be shared with. This affects the number of "Share With" dropdowns on the Misc tab of the ReportDesigner.|3
|
|   bool|[[OpenCustomUrlInNewWindow|API/CodeSamples/OpenCustomUrlInNewWindow]]|Gets or sets the value to enable opening a new window when a custom url link is clicked (See advanced filter settings). If this is not enabled, the current page will change to the clicked on the link.|True
|
|   int|[[OracleCommandTimeout|API/CodeSamples/OracleCommandTimeout]]|Sets the time Izenda Reports will wait for an Oracle command to execute before timing out.|3600
|
|   string|[[OracleConnectionString|API/CodeSamples/OracleConnectionString]]|Gets or sets the connection string for Oracle Server connections.|
|
|   ReportOutputGeneratorCollection|[[OutputTypes|API/CodeSamples/OutputTypes]]|Gets or sets the registered ReportOutputGenerators collection. These define what types of formats Izenda AdHoc can export to.|Izenda.AdHoc.ReportOutputGeneratorCollection
|
|   string|[[ParentReportDesignerUrl|API/CodeSamples/ParentReportDesignerUrl]]||
|
|   string|[[ParentReportListUrl|API/CodeSamples/ParentReportListUrl]]||
|
|   string|[[ParentReportViewerUrl|API/CodeSamples/ParentReportViewerUrl]]||
|
|   string|[[ParentSettingsUrl|API/CodeSamples/ParentSettingsUrl]]||
|
|   bool|[[PerUserCaching|API/CodeSamples/PerUserCaching]]|Gets or sets the value indicating whether the Driver.DatabaseSchema metadata should be cached.|False
|
|   int|[[PivotFieldLimit|API/CodeSamples/PivotFieldLimit]]|Sets the limit for the maximum number of pivot columns that can exist in a report. See more about pivots.|100
|
|   string|[[PostgreSQLConnectionString|API/CodeSamples/PostgreSQLConnectionString]]|Gets or sets the connection string for Postgre SQL connections.|
|
|   int|[[PreviewColumnLimit|API/CodeSamples/PreviewColumnLimit]]|Gets or sets the value indicating the number of columns to show in the report preview.|100
|
|   string|[[PreviewColumnLimitMessage|API/CodeSamples/PreviewColumnLimitMessage]]|Gets or sets the value indicating the message displayed when PreviewColumnLimit is exceeded.|Reports with more than 100 fields must be exported to CSV.  Please check CSV Export to view data.
|
|   int|[[PreviewTimeout|API/CodeSamples/PreviewTimeout]]|Sets the minimum time Izenda Reports will wait for a MSSQL command to execute before timing out.|0
|
|   PrintMode|[[PrintMode|API/CodeSamples/PrintMode]]|Gets or sets the value indicating what print mode will be used, PDF or HTML.|Html2PdfAndHtml
|
|   ProcessFiltersDelegate|[[ProcessFiltersDelegate|API/CodeSamples/ProcessFiltersDelegate]]|Deprecated.|
|
|   int|[[QuickAddFieldWidth|API/CodeSamples/QuickAddFieldWidth]]|Gets or sets the value indicating the max length of a string in one QuickAdd column.|20
|
|   int|[[QuickAddMinElementsInColumn|API/CodeSamples/QuickAddMinElementsInColumn]]|Set the minimum number of elements in each QuickAdd column.|20
|
|   string|[[RDLFolder|API/CodeSamples/RDLFolder]]|Gets or sets path to Folder where RDL files would be saved.|RDLFiles
|
|   int|[[RecentlyUpdatedCountAtReportList|API/CodeSamples/RecentlyUpdatedCountAtReportList]]||0
|
|   System.Drawing.Color|[[ReportAlternatingItemColor|API/CodeSamples/ReportAlternatingItemColor]]|Gets or sets the text color of alternating(even numbered) items in reports. See ReportItemColor for regular(odd numbered) items.|Color [Gainsboro]
|
|   System.Drawing.Color|[[ReportBorderColor|API/CodeSamples/ReportBorderColor]]|Gets or sets the color of the report border.|Color [White]
|
|   string|[[ReportCss|API/CodeSamples/ReportCss]]|Deprecated.|@import url(rs.aspx?css=Report);
|
|   string|[[ReportCssUrl|API/CodeSamples/ReportCssUrl]]|This setting allows the user to specify their own css file to be used on reports generated by Izenda Reports. This setting replaced the ReportCss property and should be used instead.|rs.aspx?css=Report
|
|   string|[[ReportDesignerUrl|API/CodeSamples/ReportDesignerUrl]]|Gets or sets the URL of a page used to design reports.|ReportDesigner.aspx
|
|   string|[[ReportDesignerUrlWithDelimiter|API/CodeSamples/ReportDesignerUrlWithDelimiter]]|Gets the ReportDesignerUrl with query string characters ("?" and "&") at the end.|ReportDesigner.aspx?
|
|   System.Drawing.Color|[[ReportHeaderColor|API/CodeSamples/ReportHeaderColor]]|Gets or sets the color of the report header.|Color [DarkSlateBlue]
|
|   Image|[[ReportHeaderImage|API/CodeSamples/ReportHeaderImage]]|Deprecated.|
|
|   string|[[ReportHeaderImageUrl|API/CodeSamples/ReportHeaderImageUrl]]|This setting allows the user to set a report header image to be used on reports. This replaced the property ReportHeaderImage and should be used instead.|
|
|   string|[[ReportingService2005Url|API/CodeSamples/ReportingService2005Url]]|Gets or sets the base URL of the XML Web service.|http\//localhost/ReportServer/ReportService2005.asmx
|
|   System.Drawing.Color|[[ReportItemColor|API/CodeSamples/ReportItemColor]]|Gets or sets the text color of regular(odd numbered) items in reports. See ReportAlternatingItemColor for alternating(even numbered) items.|Color [White]
|
|   string|[[ReportList|API/CodeSamples/ReportList]]|Gets or sets the URL of the report list page. If this is null or empty, the Report List button in the toolbar will be hidden.|ReportList.aspx
|
|   ReportListSettings|[[ReportListSettings|API/CodeSamples/ReportListSettings]]|Deprecated.|HideAll
|
|   ReportSetEventWatcherCollection|[[ReportSetEventWatchers|API/CodeSamples/ReportSetEventWatchers]]|Gets or sets the collection of registered IReportSetEventWatcher objects that perform various actions on ReportSet-related events.|Izenda.AdHoc.ReportSetEventWatcherCollection
|
|   string|[[ReportsPath|API/CodeSamples/ReportsPath]]|Sets the path to the directory where report files are stored. This is only needed when FileSystemMode is enabled. Note: Be sure the folder exists and has the correct network user permissions specified.|C/\cygwin64\home\jadams\webforms-cs\Reports
|
|   bool|[[ReportsSharedByDefault|API/CodeSamples/ReportsSharedByDefault]]|Deprecated.|True
|
|   StorageMode|[[ReportStorageMode|API/CodeSamples/ReportStorageMode]]|Defines how reports are stored: either in the file system or in the database.|Filesystem
|
|   ReportTypeCollection|[[ReportTypes|API/CodeSamples/ReportTypes]]|Deprecated.|Izenda.AdHoc.ReportTypeCollection
|
|   string|[[ReportViewer|API/CodeSamples/ReportViewer]]|Gets or sets the URL of the report viewer page.|ReportViewer.aspx
|
|   int|[[ReportViewerDefaultPreviewResults|API/CodeSamples/ReportViewerDefaultPreviewResults]]|This textbox specifies the default number of results in the Report Viewer for all reports. Izenda does not recommend setting this to a large number such as 5000 or larger as the html report will take a long time to generate. If you would like to view all the data, we recommend exporting the report. This will always provide the entire report.|100
|
|   string|[[ReportViewerPostHtml|API/CodeSamples/ReportViewerPostHtml]]|Gets or sets the string of html that will be placed after the entire HtmlOutputReportResults section. This can be seen in the ReportViewer at the bottom page after the report body.|
|
|   string|[[ReportViewerPreHtml|API/CodeSamples/ReportViewerPreHtml]]|Gets or sets the string of html code that placing before the entire HtmlOutputReportResults section. This can be seen in the ReportViewer in the top of the page before the report body.|
|
|   int|[[ReportViewerRefreshInterval|API/CodeSamples/ReportViewerRefreshInterval]]|Deprecated.|0
|
|   string|[[ReportViewerWithDelimiter|API/CodeSamples/ReportViewerWithDelimiter]]|Gets the url of the report viewer page with query string characters ("?" and "&") at the end.|ReportViewer.aspx?
|
|   string|[[ReportViewPageTitle|API/CodeSamples/ReportViewPageTitle]]|Gets or sets the title of report viewer page. This text can be seen as the title of the browser window when ReportViewer is opened.|
|
|   bool|[[RequireLogin|API/CodeSamples/RequireLogin]]|This setting tells Izenda Reports that system will use authorization.<br> *Note: The LoginUrl property MUST be specified if this setting is enabled*.|False
|
|   string|[[ResponseServer|API/CodeSamples/ResponseServer]]|Gets or sets the URL of the ResponseServer page.|rs.aspx
|
|   string|[[ResponseServerWithDelimiter|API/CodeSamples/ResponseServerWithDelimiter]]|Gets the URL of the ResponseServer page with query string characters("?" and "&") at the end.|rs.aspx?
|
|   string|[[ResponseServerWithDelimiterFull|API/CodeSamples/ResponseServerWithDelimiterFull]]|Deprecated.|rs.aspx?
|
|   int[]|[[ResultsDropdownValues|API/CodeSamples/ResultsDropdownValues]]|Gets or sets the list of the values in the "Results" dropdown in the toolbar of the ReportDesigner. This will override as many default entries in the list as it can.|System.Int32[]
|
|   string|[[SavedReportsTable|API/CodeSamples/SavedReportsTable]]|Gets or sets the table name for saved reports.|
|
|   string|[[SaveReportSetNextUrl|API/CodeSamples/SaveReportSetNextUrl]]|Gets or sets the URL of the page to which users will be redirected after saving reports.|
|
|   string|[[ScheduledReportsUrlFormatString|API/CodeSamples/ScheduledReportsUrlFormatString]]|Gets or sets the url that is sent via email as the report web address when the user selects "link" in the scheduling control's "send email as" field. [[Report schedulinghttp://wiki.izenda.us/FAQ/Questions/How-do-I-use-the-Izenda-Reports-report-email-scheduler]] MUST be turned on for this to have an effect.|http\//localhost\54232/ReportViewer.aspx?{0}
|
|   SchedulerOutputCollection|[[SchedulerExports|API/CodeSamples/SchedulerExports]]|Deprecated.|Izenda.AdHoc.SchedulerOutputCollection
|
|   SchedulerOutputCollection|[[SchedulerOutputTypes|API/CodeSamples/SchedulerOutputTypes]]|Gets or sets the value indicating the allowed formats for scheduling reports. This defines the contents of the "Send Email As" dropdown at the Misc tab in the ReportDesigner.|Izenda.AdHoc.SchedulerOutputCollection
|
|   string|[[SchedulerTenantID|API/CodeSamples/SchedulerTenantID]]|Deprecated.|
|
|   TimeSpan|[[SchemaCacheTimeout|API/CodeSamples/SchemaCacheTimeout]]|Gets or sets how long the system should wait before giving up on caching the schema.|1.00/00/00
|
|   string|[[ScriptDirectory|API/CodeSamples/ScriptDirectory]]|Deprecated.|
|
|   Unit|[[SelectValueDropDownWidth|API/CodeSamples/SelectValueDropDownWidth]]|Gets or sets the width of the "Value(s)" dropdown on the Filters tab in the Report Designer.|300px
|
|   bool|[[ServiceMode|API/CodeSamples/ServiceMode]]|Deprecated.|False
|
|   string|[[SettingsKey|API/CodeSamples/SettingsKey]]|Gets or sets a password used to access the settings page. It should be used in tandem with UserKey if you don't need multi-user security.|
|
|   string|[[SettingsPageUrl|API/CodeSamples/SettingsPageUrl]]|Gets or sets the URL of the Settings page.|Settings.aspx
|
|   string[]|[[SharedWithValues|API/CodeSamples/SharedWithValues]]|This sets the users or roles available in the "Shared With" dropdown of the Misc tab in the Report Designer.|
|
|   bool|[[ShowAddAll|API/CodeSamples/ShowAddAll]]|Deprecated|False
|
|   bool|[[ShowAddFieldInReportViewer|API/CodeSamples/ShowAddFieldInReportViewer]]|Deprecated|True
|
|   bool|[[ShowAdminButton|API/CodeSamples/ShowAdminButton]]|Deprecated|True
|
|   bool|[[ShowAdvancedChartingButton|API/CodeSamples/ShowAdvancedChartingButton]]|This checkbox enables/disables the advanced button from being shown in the Chart tab of Report Designer.|True
|
|   bool|[[ShowAllInPreview|API/CodeSamples/ShowAllInPreview]]|Gets or sets a value indicating whether an "All" option should be displayed in the "Results per page" dropdown on the Report Preview.|True
|
|   bool|[[ShowAllInResults|API/CodeSamples/ShowAllInResults]]|Gets or sets a value indicating whether an "All" option should be displayed in the "Results per page" dropdown on the Report Viewer.|True
|
|   bool|[[ShowAllTables|API/CodeSamples/ShowAllTables]]|Deprecated|True
|
|   bool|[[ShowArithmeticInSummary|API/CodeSamples/ShowArithmeticInSummary]]|Gets or sets the value indicating whether the "Arithmetic" options should be displayed in the Summary tab of the Report Designer.|False
|
|   bool|[[ShowArithmeticOperations|API/CodeSamples/ShowArithmeticOperations]]|Gets or sets the value indicating whether the "Arithmetic" options should be displayed in the Fields tab of the Report Designer.|True
|
|   bool|[[ShowBackButton|API/CodeSamples/ShowBackButton]]|Gets or sets whether to show a "Back" button on the Report Viewer & Report Designer toolbars.|False
|
|   bool|[[ShowBetweenDateCalendar|API/CodeSamples/ShowBetweenDateCalendar]]|Gets or sets the value indicating whether calendar controls should be used for "Between" operation for DateTime filters. |True
|
|   bool|[[ShowBulkCSVButton|API/CodeSamples/ShowBulkCSVButton]]|Deprecated|False
|
|   bool|[[ShowCategoryTextboxInSaveDialog|API/CodeSamples/ShowCategoryTextboxInSaveDialog]]|Gets or sets the value indicating whether the "Category" dropdown should be shown in the "save as" dialog for reports.|True
|
|   bool|[[ShowChartLegend|API/CodeSamples/ShowChartLegend]]|Get or sets the value controlling whether charts should show legends.|True
|
|   bool|[[ShowChartTab|API/CodeSamples/ShowChartTab]]|This checkbox enables/disables the "Charts" tab from the Izenda Reports application report designer page.|True
|
|   bool|[[ShowClientEmailButton|API/CodeSamples/ShowClientEmailButton]]|Gets or sets the value controlling whether the "email report from client" button is shown on the Izenda Reports toolbar.|True
|
|   bool|[[ShowConstraintsSettings|API/CodeSamples/ShowConstraintsSettings]]|Gets or sets the value indicating the "Constraints" tab is shown on the Settings page.|False
|
|   bool|[[ShowContinueLinks|API/CodeSamples/ShowContinueLinks]]|Gets or sets the value indicating whether the "Continue to" buttons are displayed throughout the tabs of the Report Designer.|True
|
|   bool|[[ShowCSVButton|API/CodeSamples/ShowCSVButton]]|Gets or sets the value indicating whether the Export to CSV button is displayed on the Izenda Reports toolbar.|True
|
|   bool|[[ShowCustomFormatType|API/CodeSamples/ShowCustomFormatType]]|Gets or sets the value indicating whether the "Custom" format type should be shown in the "Formats" dropdown.|False
|
|   bool|[[ShowDashboardAddDropDown|API/CodeSamples/ShowDashboardAddDropDown]]|Deprecated|False
|
|   bool|[[ShowDashboardFieldsTab|API/CodeSamples/ShowDashboardFieldsTab]]|Gets or sets the value indicating whether the "Dasbhoard Fields" tab is displayed on the Report Designer.|False
|
|   bool|[[ShowDashboardPartViewerLinks|API/CodeSamples/ShowDashboardPartViewerLinks]]|Gets or sets the value indicating whether the Dashboard Viewer will have "edit" links for it's reports.|True
|
|   bool|[[ShowDashboardSettings|API/CodeSamples/ShowDashboardSettings]]|Deprecated|False
|
|   bool|[[ShowDatabaseDiagramIcon|API/CodeSamples/ShowDatabaseDiagramIcon]]|Gets or sets the value indicating whether the Database Diagram icon should be shown in the toolbar in the ReportDesigner.|True
|
|   bool|[[ShowDatabaseTypes|API/CodeSamples/ShowDatabaseTypes]]|Gets or sets the value indicating whether database types should be shown in the Fields dropdown.|False
|
|   bool|[[ShowDataSourcesAsCheckBoxes|API/CodeSamples/ShowDataSourcesAsCheckBoxes]]|Gets or sets the value indicating which mode of the Data Sources list is shown.|True
|
|   bool|[[ShowDataSourcesTab|API/CodeSamples/ShowDataSourcesTab]]|Gets or sets whether the Data Sources tab is shown on the Report Designer.|True
|
|   bool|[[ShowDataWhenParametersBlank|API/CodeSamples/ShowDataWhenParametersBlank]]|Deprecated|True
|
|   bool|[[ShowDescriptionsInReportsTab|API/CodeSamples/ShowDescriptionsInReportsTab]]|Deprecated|False
|
|   bool|[[ShowDesignDashboardLink|API/CodeSamples/ShowDesignDashboardLink]]|Deprecated. Use ShowDesignLinks instead.|True
|
|   bool|[[ShowDesignLinkInReportViewer|API/CodeSamples/ShowDesignLinkInReportViewer]]|Deprecated. Use ShowDesignLinks instead.|True
|
|   bool|[[ShowDesignLinks|API/CodeSamples/ShowDesignLinks]]|Gets or sets a value indicating whether "Design" links should be shown in the Report list and in the toolbar.|True
|
|   bool|[[ShowDetailFormat|API/CodeSamples/ShowDetailFormat]]|Deprecated.|True
|
|   bool|[[ShowDistinct|API/CodeSamples/ShowDistinct]]|Gets or sets the value indicating whether the "Distinct" checkbox should be shown on the Data Source tab in the Report Designer.|True
|
|   bool|[[ShowDOCButton|API/CodeSamples/ShowDOCButton]]|Gets or sets whether to show the Microsoft Word export button on the Report Viewer & Designer toolbar.|True
|
|   bool|[[ShowEtlButton|API/CodeSamples/ShowEtlButton]]|Gets or sets the value indicating whether the upload data button should be shown in the report viewer. |False
|
|   bool|[[ShowFieldAsValueDropDown|API/CodeSamples/ShowFieldAsValueDropDown]]|Gets or sets the value indicating whether the "(Field)" operators will display their "Value(s)" as textboxes or dropdown menus.|True
|
|   bool|[[ShowFieldsTab|API/CodeSamples/ShowFieldsTab]]|Gets or sets the value indicating whether the fields tab should be shown on the Report Designer.|True
|
|   bool|[[ShowFieldValueCheckbox|API/CodeSamples/ShowFieldValueCheckbox]]|Gets or sets the value indicating whether the "Show main report in Field/Value style" checkbox should be shown on the Style tab in the ReportDesigner.|True
|
|   bool|[[ShowFieldValueSummaryCheckbox|API/CodeSamples/ShowFieldValueSummaryCheckbox]]|Gets or sets the value indicating whether the "Show summary report in Field/Value style" checkbox should be shown on the Style tab in the ReportDesigner.|True
|
|   bool|[[ShowFilterFunctions|API/CodeSamples/ShowFilterFunctions]]|Deprecated|True
|
|   bool|[[ShowFilterLogic|API/CodeSamples/ShowFilterLogic]]|Gets or sets the value indicating whether the "Filter Logic" textbox should be shown in the Filters tab in the Report Designer.|True
|
|   bool|[[ShowFiltersInDashboards|API/CodeSamples/ShowFiltersInDashboards]]|Gets or sets the value indicating whether the "Filters" tab should be shown when viewing Dashboards.|True
|
|   bool|[[ShowFiltersInReportViewer|API/CodeSamples/ShowFiltersInReportViewer]]|Gets or sets the value indicating whether the "Filters" tab should be shown in the Report Viewer.|True
|
|   bool|[[ShowFiltersTab|API/CodeSamples/ShowFiltersTab]]|Gets or sets the value indicating whether the "Filters" tab should be shown in the Report Designer.|True
|
|   bool|[[ShowFunctions|API/CodeSamples/ShowFunctions]]|Gets or sets whether "Functions" controls should be shown for "Fields" on the Fields and Summary tabs on the Report Designer.|True
|
|   bool|[[ShowGaugePercentage|API/CodeSamples/ShowGaugePercentage]]|Gets or sets the value indicating whether percentages should be shown on Gauges.|False
|
|   bool|[[ShowGaugeTab|API/CodeSamples/ShowGaugeTab]]|Gets or sets the value indicating whether the Gauges tab will be shown on the Report Designer.|True
|
|   bool|[[ShowGoButton|API/CodeSamples/ShowGoButton]]|Gets or sets whether the Go button is shown on the Izenda Reports toolbars.|False
|
|   bool|[[ShowGradientBackground|API/CodeSamples/ShowGradientBackground]]||False
|
|   bool|[[ShowGroupInFunctionDropdown|API/CodeSamples/ShowGroupInFunctionDropdown]]|Gets or sets the value indicating whether GROUP feature should be shown as a function at the Fields tab in the ReportDesigner.|True
|
|   bool|[[ShowGroupMonth|API/CodeSamples/ShowGroupMonth]]|Deprecated|False
|
|   bool|[[ShowHelpButton|API/CodeSamples/ShowHelpButton]]|Gets or sets the value indicating whether the "HideHelpPanel" icon should be shown in the toolbar. |False
|
|   bool|[[ShowHtmlAsCode|API/CodeSamples/ShowHtmlAsCode]]|Gets or sets whether fetching HTML code contained in database fields displays as HTML or plain text. |False
|
|   bool|[[ShowInTimePeriod|API/CodeSamples/ShowInTimePeriod]]|Gets or sets the value indicating whether "In Time Period" items are shown in operators dropdown on the Report Designer. |True
|
|   bool|[[ShowInvertSummaryCheckbox|API/CodeSamples/ShowInvertSummaryCheckbox]]|Deprecated|False
|
|   bool|[[ShowInvisible|API/CodeSamples/ShowInvisible]]|Deprecated|False
|
|   bool|[[ShowJoinDropDown|API/CodeSamples/ShowJoinDropDown]]|Gets or sets the value indicating whether the join type dropdown should be shown in the JoinedTablesList. |False
|
|   bool|[[ShowJustification|API/CodeSamples/ShowJustification]]|Gets or sets whether justification boxes are shown in the Report Designer.|True
|
|   bool|[[ShowLinkFormats|API/CodeSamples/ShowLinkFormats]]|Deprecated|True
|
|   bool|[[ShowLoadingForDesigner|API/CodeSamples/ShowLoadingForDesigner]]|Deprecated|False
|
|   bool|[[ShowLoadingOnDesignerLoad|API/CodeSamples/ShowLoadingOnDesignerLoad]]|Deprecated|False
|
|   bool|[[ShowLogoInPdf|API/CodeSamples/ShowLogoInPdf]]|Deprecated|False
|
|   bool|[[ShowMapTab|API/CodeSamples/ShowMapTab]]|Gets or sets the value indicating whether the Map tab should be shown in the Report Designer.|True
|
|   bool|[[ShowMenuInReportViewer|API/CodeSamples/ShowMenuInReportViewer]]|Deprecated|False
|
|   bool|[[ShowMiscTab|API/CodeSamples/ShowMiscTab]]|Gets or sets whether the Misc tab is displayed on the Report Designer page. |True
|
|   bool|[[ShowModifyButton|API/CodeSamples/ShowModifyButton]]|Deprecated|True
|
|   bool|[[ShowMultiLineControls|API/CodeSamples/ShowMultiLineControls]]|Gets or sets the value indicating whether the "Multi-Line" feature is enabled.|False
|
|   bool|[[ShowNewButton|API/CodeSamples/ShowNewButton]]|Gets or sets whether the "New" button is shown on the Report Viewer for creating new reports.|True
|
|   bool|[[ShowNonIndexedJoinFields|API/CodeSamples/ShowNonIndexedJoinFields]]|Gets or sets the value indicating whether non-indexed join fields should be shown.|True
|
|   bool|[[ShowODTButton|API/CodeSamples/ShowODTButton]]|Deprecated|False
|
|   bool|[[ShowOnlineDocumentation|API/CodeSamples/ShowOnlineDocumentation]]|Gets or sets the value indicating whether to show "Details" buttons in the settings page. |True
|
|   bool|[[ShowOpenOfficeButton|API/CodeSamples/ShowOpenOfficeButton]]|Gets or sets the value indicating whether the "OpenOffice" export button is shown. |False
|
|   bool|[[ShowPDFButton|API/CodeSamples/ShowPDFButton]]|Gets or sets the value indicating whether the "PDF" export button is shown.|True
|
|   bool|[[ShowPivot|API/CodeSamples/ShowPivot]]|Gets or sets whether to show the "Add Pivot" button on the Report Designer.|True
|
|   bool|[[ShowPoweredByLogo|API/CodeSamples/ShowPoweredByLogo]]|Gets or sets whether to show the "Powered By Izenda" logo throughout the application.|False
|
|   bool|[[ShowPreviewTab|API/CodeSamples/ShowPreviewTab]]|Gets or sets whether the "Preview" tab is shown in the Report Designer.|True
|
|   bool|[[ShowPublishRdlButton|API/CodeSamples/ShowPublishRdlButton]]|Gets or sets whether to show the "Publish RDL" button on the Report Designer toolbar.|False
|
|   bool|[[ShowRdlOutputIcon|API/CodeSamples/ShowRdlOutputIcon]]|Gets or sets whether to show the "RDL" button on the Report Designer toolbar.|False
|
|   bool|[[ShowReadOnlyCheckbox|/API/CodeSamples/ShowReadOnlyCheckbox]]|Deprecated. This setting is no longer available.|True
|
|   bool|[[ShowRecentDatasources|API/CodeSamples/ShowRecentDatasources]]|Gets or sets the value indicating whether the Recent Datasources dropdown list will be shown on the Data Sources tab of the Report Designer.|True
|
|   bool|[[ShowRemoveAll|API/CodeSamples/ShowRemoveAll]]||True
|
|   bool|[[ShowRemoveFieldInReportViewer|API/CodeSamples/ShowRemoveFieldInReportViewer]]||True
|
|   bool|[[ShowReportClassifiers|API/CodeSamples/ShowReportClassifiers]]|Gets or sets the value indicating whether the ReportClassifiers control should be shown on the "Misc" tab of the ReportDesigner.|True
|
|   bool|[[ShowReportColor|API/CodeSamples/ShowReportColor]]|Gets or sets the value indicating whether report color (Item and AlternatingItem) dropdowns are shown on the Style tab in the Report Designer.|True
|
|   bool|[[ShowReportingServicesSettings|API/CodeSamples/ShowReportingServicesSettings]]|Deprecated|False
|
|   bool|[[ShowReportsInHtmlOutput|API/CodeSamples/ShowReportsInHtmlOutput]]|Deprecated|True
|
|   bool|[[ShowReportsListAsDropDown|API/CodeSamples/ShowReportsListAsDropDown]]|Gets or sets the value indicating which mode to use for the Reports tab.|False
|
|   bool|[[ShowReportsTab|API/CodeSamples/ShowReportsTab]]|Gets or sets whether the Reports tab should be shown on the Report Designer.|False
|
|   bool|[[ShowResponseServerDetails|API/CodeSamples/ShowResponseServerDetails]]|Gets or sets whether to show a diagnostic test using the Response Server page.|True
|
|   bool|[[ShowRowButtons|API/CodeSamples/ShowRowButtons]]|Gets or sets the value indicating whether "insert" and "move" buttons should be shown on the Fields tab in the Report Designer.|True
|
|   bool|[[ShowRTFButton|API/CodeSamples/ShowRTFButton]]|Gets or sets the whether to enable the button to export to RTF format.|True
|
|   bool|[[ShowSaveAsToolbarButton|API/CodeSamples/ShowSaveAsToolbarButton]]|Gets or sets whether the save as button is shown on the toolbar in Report Designer.|True
|
|   bool|[[ShowSaveControls|API/CodeSamples/ShowSaveControls]]|Gets or sets whether the save controls (save and save as icons) in the toolbar are shown on the report designer.|True
|
|   bool|[[ShowSaveControlsInReportsTab|API/CodeSamples/ShowSaveControlsInReportsTab]]|Gets or sets the value indicating whether save controls should be shown in the toolbar in the Report Viewer.|False
|
|   bool|[[ShowSaveInReportViewer|API/CodeSamples/ShowSaveInReportViewer]]|Deprecated|True
|
|   bool|[[ShowSaveRdlToolbarButton|API/CodeSamples/ShowSaveRdlToolbarButton]]|Gets or sets the value indicating whether the "Save As RDL" button should be shown on the toolbar.|False
|
|   bool|[[ShowScheduleControls|API/CodeSamples/ShowScheduleControls]]|Defines whether or not the scheduling controls are show at the Misc tab in the Report Designer.|True
|
|   bool|[[ShowServerEmailButton|API/CodeSamples/ShowServerEmailButton]]|Gets or sets whether the "E-Mail report from server" button from the Izenda Reports toolbars.|False
|
|   bool|[[ShowSettingsButton|API/CodeSamples/ShowSettingsButton]]|Gets or sets whether the "Settings" button is shown on the toolbar.|True
|
|   bool|[[ShowSettingsButtonForNonAdmins|API/CodeSamples/ShowSettingsButtonForNonAdmins]]|Gets or sets whether the Settings button will be shown to users without administrator rights.|False
|
|   bool|[[ShowSharedCheckbox|API/CodeSamples/ShowSharedCheckbox]]|Deprecated|True
|
|   bool|[[ShowSharingControl|API/CodeSamples/ShowSharingControl]]|Gets or sets the value indicating whether the sharing control will be shown at the Misc tab in the Report Designer.|True
|
|   bool|[[ShowSideHelp|API/CodeSamples/ShowSideHelp]]|Gets or sets the value indicating whether side help should be shown in the Report Designer.|False
|
|   bool|[[ShowSimpleModeViewer|API/CodeSamples/ShowSimpleModeViewer]]|Gets or sets whether to display the Simple Mode of the Report Viewer.|False
|
|   bool|[[ShowSqlOutputIcon|API/CodeSamples/ShowSqlOutputIcon]]|Deprecated|True
|
|   bool|[[ShowStackTrace|API/CodeSamples/ShowStackTrace]]|Gets or sets the value indicating the format for showing exceptions.|True
|
|   bool|[[ShowStyleTab|API/CodeSamples/ShowStyleTab]]|Gets or sets whether the Style tab is shown on the Report Designer page.|True
|
|   bool|[[ShowSummaryLine|API/CodeSamples/ShowSummaryLine]]|Deprecated|True
|
|   bool|[[ShowSummaryTab|API/CodeSamples/ShowSummaryTab]]|Gets or sets whether the summary tab is shown on the Report Designer.|True
|
|   bool|[[ShowTableNames|API/CodeSamples/ShowTableNames]]|Gets or sets whether the fields in dropdowns should be grouped by table name. |True
|
|   bool|[[ShowTenantField|API/CodeSamples/ShowTenantField]]|Gets or sets whether the field identified in the TenantField property is shown.|True
|
|   bool|[[ShowTimeZoneDropdown|API/CodeSamples/ShowTimeZoneDropdown]]|Gets or sets the value indicating whether the timezone dropdown will be shown in the Report Designer on the Misc tab. <br> *Note: ShowScheduleControls MUST be set to true to use this*.|True
|
|   bool|[[ShowTopInFields|API/CodeSamples/ShowTopInFields]]|Gets or sets whether to display the "Records" textbox on the Fields tab of the Report Designer.|True
|
|   bool|[[ShowTopInSummary|API/CodeSamples/ShowTopInSummary]]|Gets or sets whether to display the "Records" textbox on the Summary tab of the Report Designer.|True
|
|   bool|[[ShowVisualGroupLabels|API/CodeSamples/ShowVisualGroupLabels]]|Deprecated|False
|
|   bool|[[ShowWatermarkedExports|API/CodeSamples/ShowWatermarkedExports]]|Gets or sets the value indicating whether a watermarked export should be used when there are license errors.|True
|
|   bool|[[ShowWaterMarks|API/CodeSamples/ShowWaterMarks]]|Gets or sets the value indicating whether watermarks should be used when there are license errors.|True
|
|   bool|[[ShowWidth|API/CodeSamples/ShowWidth]]|Deprecated|False
|
|   bool|[[ShowXLSButton|API/CodeSamples/ShowXLSButton]]|Gets or sets the value indicating whether the "XLS" export button is shown on the toolbar. |True
|
|   string|[[SimpleFilterCssUrl|API/CodeSamples/SimpleFilterCssUrl]]||rs.aspx?css=SimpleFilter
|
|   bool|[[SingleLineViewerToolbar|API/CodeSamples/SingleLineViewerToolbar]]|Gets or set value indicating whether the ReportViewer toolbar should be single line.|False
|
|   string|[[SmtpLogin|API/CodeSamples/SmtpLogin]]|Gets or sets the SMTP server login name.|
|
|   string|[[SmtpPassword|API/CodeSamples/SmtpPassword]]|Gets or sets the SMTP server password.|
|
|   string|[[SmtpServer|API/CodeSamples/SmtpServer]]|Gets or sets the SMTP server address used by your company to send out emails.|localhost
|
|   bool|[[SortColumnNames|API/CodeSamples/SortColumnNames]]|Gets or sets the value indicating whether dropdowns with column names are sorted alphabetically. |True
|
|   int|[[SqlCommandTimeout|API/CodeSamples/SqlCommandTimeout]]|Gets or sets the wait time in seconds for loading dropdowns from the database.|3600
|
|   string|[[SqlServerConnectionString|API/CodeSamples/SqlServerConnectionString]]|Gets or sets the connection string for MS SQL Server connections.|
|
|   bool|[[StoreCurrentReportSetInApplication|API/CodeSamples/StoreCurrentReportSetInApplication]]||False
|
|   int|[[StoredProcedureStringLimit|API/CodeSamples/StoredProcedureStringLimit]]|Gets or sets the value indicating the max length of a string returned by a Stored Procedure.|-1
|
|   bool|[[StoreImagesToCache|API/CodeSamples/StoreImagesToCache]]|Gets or sets the value indicating how temporary images should be stored.|True
|
|   bool|[[StrictANSIOuterJoin|API/CodeSamples/StrictANSIOuterJoin]]||True
|
|   bool|[[StripInvalidCharacters|API/CodeSamples/StripInvalidCharacters]]|Gets or sets the value indicating whether invalid characters in report names should be stripped out.|True
|
|   string|[[SubCalculationFilterRegex|API/CodeSamples/SubCalculationFilterRegex]]|Gets or sets whether the user can use a regular expression to filter certain numeric fields from having subcalculation function options when selected in the Fields tab of Report Designer.|ID$&#124;Id$&#124;^id$&#124;_id$
|
|   string|[[TabBackgroundImageUrl|API/CodeSamples/TabBackgroundImageUrl]]|Gets or sets the path to an image used to customize the look of the tabs on the Report Designer.|rs.aspx?image=TabStrip.Background.gif
|
|   NameDistinctValueCollection|[[TableAliases|API/CodeSamples/TableAliases]]|Deprecated|NameDistinctValueCollection
|
|   Unit|[[TableDropDownWidth|API/CodeSamples/TableDropDownWidth]]|This replaces the property DataSourceDropDownWidth and should be used instead.|190px
|
|   string|[[TableFilterRegex|API/CodeSamples/TableFilterRegex]]|Gets or sets the regular expression used for table filtering.|^(IzendaAdHoc)
|
|   string|[[TabsCss|API/CodeSamples/TabsCss]]|Deprecated. Use TabsCssUrl instead.|@import url(rs.aspx?css=tabs);
|
|   string|[[TabsCssUrl|API/CodeSamples/TabsCssUrl]]|Gets or sets the CSS stylesheet URL to use for the TabStrip.|rs.aspx?css=tabs
|
|   string|[[TempFiles|API/CodeSamples/TempFiles]]|Gets or sets the value indicating the path where temporary files are stored.|TempFiles
|
|   string|[[TemplatesPath|API/CodeSamples/TemplatesPath]]||C/\cygwin64\home\jadams\webforms-cs\Reports
|
|   string|[[TenantField|API/CodeSamples/TenantField]]|The field that will be internally filtered by the current TenantID value. |
|
|   FieldHighlightInfoDictionary|[[TextHighlight|API/CodeSamples/TextHighlight]]|Deprecated.|Izenda.AdHoc.FieldHighlightInfoDictionary
|
|   int|[[ThumbnailHeight|API/CodeSamples/ThumbnailHeight]]|Gets or sets the height of thumbnail images on the Report List.|220
|
|   int|[[ThumbnailWidth|API/CodeSamples/ThumbnailWidth]]|Gets or sets the width of thumbnail images on the Report List.|170
|
|   Unit|[[TimePeriodDropDownWidth|API/CodeSamples/TimePeriodDropDownWidth]]|Gets or sets the width of the time period dropdown.|190px
|
|   int|[[TimeZoneOffset|API/CodeSamples/TimeZoneOffset]]|Gets or sets the value indicating the time zone offset of the current user in hours.|0
|
|   SchedulerTimeZoneCollection|[[TimeZones|API/CodeSamples/TimeZones]]|Gets or sets the collection of additional and hidden time zones. |Izenda.AdHoc.SchedulerTimeZoneCollection
|
|   string|[[ToolbarBackgroundImageUrl|API/CodeSamples/ToolbarBackgroundImageUrl]]|Gets or sets a URL to an image to customize the look of the toolbar section of the report designer.|rs.aspx?image=Toolbar.Toolgrad.gif
|
|   string|[[ToolbarBorderColor|API/CodeSamples/ToolbarBorderColor]]|Gets or sets the color of the toolbar border.|#95b7f3
|
|   string|[[ToolbarCssUrl|API/CodeSamples/ToolbarCssUrl]]|Gets or sets the CSS stylesheet URL for the Toolbar.|rs.aspx?css=toolbar
|
|   string|[[UnCategorizedReportsMenuItemTitle|API/CodeSamples/UnCategorizedReportsMenuItemTitle]]|Deprecated|Reports
|
|   bool|[[UseAdvancedGauge|API/CodeSamples/UseAdvancedGauge]]|Gets or sets the value indicating whether advanced is used for "Gauge" format. |True
|
|   bool|[[UseBulkCSV|API/CodeSamples/UseBulkCSV]]|Gets or sets the value indicating whether to use the Bulk CSV export option. |True
|
|   bool|[[UseColumnNameForDashboardCommonFilters|API/CodeSamples/UseColumnNameForDashboardCommonFilters]]||True
|
|   bool|[[UseConstraintsForJoins|API/CodeSamples/UseConstraintsForJoins]]|Gets or sets the value indicating if multiple autojoining conditions are allowed. |False
|
|   bool|[[UseDefaultDialogs|API/CodeSamples/UseDefaultDialogs]]||False
|
|   bool|[[UseFriendlyErrors|API/CodeSamples/UseFriendlyErrors]]|Gets or sets the value indicating whether friendly errors should be shown on exceptions.|True
|
|   bool|[[UseImageDescriptions|API/CodeSamples/UseImageDescriptions]]||False
|
|   bool|[[UseNoLock|API/CodeSamples/UseNoLock]]|Gets or sets the value indicating whether nolock statements will be used in sql-queries.|True
|
|   bool|[[UseNonPostbackDeleting|API/CodeSamples/UseNonPostbackDeleting]]|Gets or sets the value indicating whether a postback should occur on deleting a report.|True
|
|   bool|[[UseNonPostbackExport|API/CodeSamples/UseNonPostbackExport]]|Gets or sets the value indicating whether a postback should occur on exporting a report.|True
|
|   bool|[[UseNonPostbackPreview|API/CodeSamples/UseNonPostbackPreview]]|Gets or sets the value indicating whether a postback should occur on previewing a report.|True
|
|   bool|[[UseNonPostbackServerEmailing|API/CodeSamples/UseNonPostbackServerEmailing]]|Gets or sets the value indicating whether a postback should occur when emailing a report from the server.|True
|
|   bool|[[UseReportID|API/CodeSamples/UseReportID]]|Gets or sets whether the application uses a GUID instead of the report name in the query string.|False
|
|   bool|[[ValidateBeforeSave|API/CodeSamples/ValidateBeforeSave]]|Gets or sets the value indicating whether ReportSet should be validated before saving.|False
|
|   bool|[[ViewsOnly|API/CodeSamples/ViewsOnly]]|ViewsOnly should be used if you would like all views visible and only views visible at the Data Sources tab. |False
|
|   string[]|[[VisibleDataSources|API/CodeSamples/VisibleDataSources]]|Gets or sets the array of table names that should be shown in the tables dropdown in the ReportDesigner on the Data Sources tab.|System.String[]
|
|   string[]|[[VisibleTables|API/CodeSamples/VisibleTables]]|Deprecated. Use VisibleDataSources instead.|System.String[]
|
|   VisualGroupStyle|[[VisualGroupStyle|API/CodeSamples/VisualGroupStyle]]|Deprecated|CommaDelimited|