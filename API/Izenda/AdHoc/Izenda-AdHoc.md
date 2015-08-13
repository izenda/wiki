#Izenda.AdHoc

[[_TOC_]]

##[[Izenda.AdHoc.AdHocCache|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocCache]]
 Represents a set of methods and properties that define how items are stored to the application's in-memory cache according to the AdHocSettings.DefaultScope. 
##[[Izenda.AdHoc.AdHocColor|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocColor]]
 Represents a color that is saved with the report definition to define how each report should style grids. 
##[[Izenda.AdHoc.AdHocConfig|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocConfig]]
 Represents a set of properties and methods that can be used to save and load reports and manipulate result sets.  This class cannot be used directly. You should instead use FileSystemAdHocConfig, DatabaseAdHocConfig, or a custom AdHocConfig. 
##[[Izenda.AdHoc.AdHocContext|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocContext]]
 Represents a set of methods and properties that define the context in which the application is running, particularly about the database connection and license information. 
##[[Izenda.AdHoc.AdHocLanguage|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocLanguage]]
 Enumerates the different languages Izenda supports. 
##[[Izenda.AdHoc.AdHocLogger|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocLogger]]
 Represents base functionality for all loggers. 
##[[Izenda.AdHoc.AdHocScheduler|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocScheduler]]
 Represents a set of methods that run scheduled reports. 
##[[Izenda.AdHoc.AdHocSettings|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocSettings]]
 Contains various settings that are helpful when customizing the AdHoc tool 
##[[Izenda.AdHoc.AdHocStyle|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocStyle]]
 Represents a set of the various colors used to style sections of reports with. 
##[[Izenda.AdHoc.AggregateFunctionCollection|/API/Izenda/AdHoc/Izenda-AdHoc-AggregateFunctionCollection]]
 Represents a collection of aggregation functions that can be used on report fields. 
##[[Izenda.AdHoc.BarChartDataGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-BarChartDataGenerator]]
 Represents a set of methods and properties that apply to bar charts with a single series of data separated by the Separator column. 
##[[Izenda.AdHoc.BarData|/API/Izenda/AdHoc/Izenda-AdHoc-BarData]]
 Represents a set of methods and properties used to compare and sort data for individual bars on a bar chart. 
##[[Izenda.AdHoc.BoxFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-BoxFormatter]]
 Represents a formatter that formats the value of the field as a visual box on the report grid.  This represents a graph-like bar with negative values represented with red and positive with blue. 
##[[Izenda.AdHoc.BulkCsvReportOuputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-BulkCsvReportOuputGenerator]]
 Represents an output generator to produce a CSV file from data streamed directly from the database for performing large exports. 
##[[Izenda.AdHoc.CacheRecordInfo|/API/Izenda/AdHoc/Izenda-AdHoc-CacheRecordInfo]]
 Represents a data structure for holding cached reportset information. 
##[[Izenda.AdHoc.CaseSensitiveEqualityComparer|/API/Izenda/AdHoc/Izenda-AdHoc-CaseSensitiveEqualityComparer]]
 Represents a set of methods for comparing formats for equality. 
##[[Izenda.AdHoc.Chart|/API/Izenda/AdHoc/Izenda-AdHoc-Chart]]
 Represents a set of general methods and properties that define how charts will behave. 
##[[Izenda.AdHoc.ChartCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ChartCollection]]
Represents the collection of [[Izenda.AdHoc.Chart|/API/Izenda/AdHoc/Izenda-AdHoc-Chart]] objects.
##[[Izenda.AdHoc.ChartDataGeneratorBase|/API/Izenda/AdHoc/Izenda-AdHoc-ChartDataGeneratorBase]]
 Represents a generalized set of methods and properties that charts defined within AdHoc use to generate and order their data. 
##[[Izenda.AdHoc.ChartingEngine|/API/Izenda/AdHoc/Izenda-AdHoc-ChartingEngine]]
 Enumerates the different charting libraries that can be selected from when creating charts in AdHoc. 
##[[Izenda.AdHoc.ChartItem|/API/Izenda/AdHoc/Izenda-AdHoc-ChartItem]]
 Represents a set of properties and events that are used by the different chart types on the AdHocReportDesigner to define how the items for each chart will behave. 
##[[Izenda.AdHoc.ChartItemCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ChartItemCollection]]
 Represents a collection of chart items for use on the AdHocReportDesigner. 
##[[Izenda.AdHoc.ChartProperty|/API/Izenda/AdHoc/Izenda-AdHoc-ChartProperty]]
 Represents a single property of a chart that will be displayed on a web page. 
##[[Izenda.AdHoc.ChartPropertyCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ChartPropertyCollection]]
 Represents a collection of properties of a chart that will be displayed on a web page. 
##[[Izenda.AdHoc.CheckBoxChartProperty|/API/Izenda/AdHoc/Izenda-AdHoc-CheckBoxChartProperty]]
 Represents a single property of a chart that will be displayed on a web page as a checkbox control. 
##[[Izenda.AdHoc.ColorRef|/API/Izenda/AdHoc/Izenda-AdHoc-ColorRef]]
 Represents a color structure used to track changes to report grid colors. 
##[[Izenda.AdHoc.ConditionOperator|/API/Izenda/AdHoc/Izenda-AdHoc-ConditionOperator]]

##[[Izenda.AdHoc.CsvReportOuputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-CsvReportOuputGenerator]]
Represents an output generator to produce a CSV file from the specified [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.CustomFormat|/API/Izenda/AdHoc/Izenda-AdHoc-CustomFormat]]
 Represents a user-defined customized format type. 
##[[Izenda.AdHoc.CustomFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-CustomFormatter]]
 Represents a formatter that formats the value of the field as a string. This will use the field description as the format string and the value of the cell as the first argument. 
##[[Izenda.AdHoc.CustomizeChartDelegate|/API/Izenda/AdHoc/Izenda-AdHoc-CustomizeChartDelegate]]

##[[Izenda.AdHoc.CustomTimePeriod|/API/Izenda/AdHoc/Izenda-AdHoc-CustomTimePeriod]]
 Represents custom time period, that can be used in filters. 
##[[Izenda.AdHoc.CustomTimePeriodCollection|/API/Izenda/AdHoc/Izenda-AdHoc-CustomTimePeriodCollection]]
Represents a collection of [[Izenda.AdHoc.CustomTimePeriod|/API/Izenda/AdHoc/Izenda-AdHoc-CustomTimePeriod]].
##[[Izenda.AdHoc.CustomUrlFormat|/API/Izenda/AdHoc/Izenda-AdHoc-CustomUrlFormat]]
 Represents a format object that formats the value of the field with an external hyperlink that will popup in the same window. 
##[[Izenda.AdHoc.CustomUrlFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-CustomUrlFormatter]]
 Represents a formatter that formats the value of the field with a link to a subreport that will open in a new window. 
##[[Izenda.AdHoc.CustomUrlPopupFormat|/API/Izenda/AdHoc/Izenda-AdHoc-CustomUrlPopupFormat]]
 Represents a format object that formats the value of the field with an external hyperlink that will popup in the same window. 
##[[Izenda.AdHoc.CustomUrlPopupFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-CustomUrlPopupFormatter]]
 Represents a formatter that formats the value of the field with an external hyperlink that will popup in the same window. 
##[[Izenda.AdHoc.DashboardDateSliderMode|/API/Izenda/AdHoc/Izenda-AdHoc-DashboardDateSliderMode]]
 Enumerates the various types of date sliders that can be displayed on dashboards. 
##[[Izenda.AdHoc.DashboardItem|/API/Izenda/AdHoc/Izenda-AdHoc-DashboardItem]]
 Represents an individual tile on a dashboard designer or dashboard viewer. 
##[[Izenda.AdHoc.DashboardItemCollection|/API/Izenda/AdHoc/Izenda-AdHoc-DashboardItemCollection]]
 Represents a collection of tiles that can be displayed on a dashboard. 
##[[Izenda.AdHoc.DatabaseAdHocConfig|/API/Izenda/AdHoc/Izenda-AdHoc-DatabaseAdHocConfig]]
 Represents a set of methods and properties for using the database to load/save/delete reports, forms, and thumbnails. 
##[[Izenda.AdHoc.DataTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-DataTableCollection]]
 Represents a set of System.Database.DataTable objects that can facilitate with referencing tables inside reports more easily. 
##[[Izenda.AdHoc.DaysOldFormat|/API/Izenda/AdHoc/Izenda-AdHoc-DaysOldFormat]]
 Represents a format that formats the value of the field with the number of days elapsed between a date in the past and the current date. 
##[[Izenda.AdHoc.DaysOldFormater|/API/Izenda/AdHoc/Izenda-AdHoc-DaysOldFormater]]
 Represents a formatter that formats the value of the field with the number of days elapsed between a date in the past and the current date. 
##[[Izenda.AdHoc.DetailFormat|/API/Izenda/AdHoc/Izenda-AdHoc-DetailFormat]]
 Represents a format that formats the value of the field with a link to a subreport. 
##[[Izenda.AdHoc.DetailFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-DetailFormatter]]
 Represents a formatter that formats the value of the field with a link to a subreport. 
##[[Izenda.AdHoc.DetailLinkPopupFormat|/API/Izenda/AdHoc/Izenda-AdHoc-DetailLinkPopupFormat]]
 Represents a format that formats the value of the field with a link that opens a subreport in a popup window. 
##[[Izenda.AdHoc.DetailLinkPopupFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-DetailLinkPopupFormatter]]
 Represents a formatter that formats the value of the field with a link that opens a subreport in a popup window. 
##[[Izenda.AdHoc.DivisionByZerro|/API/Izenda/AdHoc/Izenda-AdHoc-DivisionByZerro]]
 Represents a formatter that formats the value of the field to safely divide by zero.  This will replace the text in the report cell with a stand-in string value when division by zero is detected. 
##[[Izenda.AdHoc.DoNothingFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-DoNothingFormatter]]
 Represents a formatter that acts as a placeholder. 
##[[Izenda.AdHoc.DrillDownKeys|/API/Izenda/AdHoc/Izenda-AdHoc-DrillDownKeys]]
 Represents a collection of columns that are used to map data between a parent report and a drilldown report. 
##[[Izenda.AdHoc.DriverDefaultValueAttribute|/API/Izenda/AdHoc/Izenda-AdHoc-DriverDefaultValueAttribute]]
Used to define the default value that the property using the specified [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] database driver will have.
##[[Izenda.AdHoc.DropdownChartProperty|/API/Izenda/AdHoc/Izenda-AdHoc-DropdownChartProperty]]
 Represents a single property of a chart that will be displayed on a web page as a dropdown menu control. 
##[[Izenda.AdHoc.DundasBarChart|/API/Izenda/AdHoc/Izenda-AdHoc-DundasBarChart]]
 Represents a set of methods and properties that describe a bar chart that uses the Dundas chart library. 
##[[Izenda.AdHoc.DundasChart|/API/Izenda/AdHoc/Izenda-AdHoc-DundasChart]]
 Represents a set of methods and properties that define how a chart using the Dundas library will behave. 
##[[Izenda.AdHoc.DundasFunnelChart|/API/Izenda/AdHoc/Izenda-AdHoc-DundasFunnelChart]]
 Represents a set of methods and properties that describe a funnel chart that uses the Dundas chart library. 
##[[Izenda.AdHoc.DundasMap|/API/Izenda/AdHoc/Izenda-AdHoc-DundasMap]]
Represents a control used to add a map to the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] being rendered.
##[[Izenda.AdHoc.DundasPieChart|/API/Izenda/AdHoc/Izenda-AdHoc-DundasPieChart]]
 Represents a set of methods and properties that describe a pie chart that uses the Dundas chart library. 
##[[Izenda.AdHoc.DundasPlotChart|/API/Izenda/AdHoc/Izenda-AdHoc-DundasPlotChart]]
 Represents a set of methods an properties that describe a plot chart that uses the Dundas chart library. 
##[[Izenda.AdHoc.DundasTrendChart|/API/Izenda/AdHoc/Izenda-AdHoc-DundasTrendChart]]
 Represents a set of methods and properties that describe a trend chart that uses the Dundas chart library. 
##[[Izenda.AdHoc.EditionDefaultValueAttribute|/API/Izenda/AdHoc/Izenda-AdHoc-EditionDefaultValueAttribute]]
Used to define the default value that the property using the specified [[Izenda.AdHoc.IzendaAdHocEdition|/API/Izenda/AdHoc/Izenda-AdHoc-IzendaAdHocEdition]].
##[[Izenda.AdHoc.EmptyChartProperty|/API/Izenda/AdHoc/Izenda-AdHoc-EmptyChartProperty]]
 Represents a placeholder for a chart property. 
##[[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]]
Represents a field that exists on a [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] object.
##[[Izenda.AdHoc.FieldCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FieldCollection]]
Represents the collection of [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] objects  in the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.FieldHighlightInfo|/API/Izenda/AdHoc/Izenda-AdHoc-FieldHighlightInfo]]
 Represents a background color that is added to the background of individual fields on reports. 
##[[Izenda.AdHoc.FieldHighlightInfoDictionary|/API/Izenda/AdHoc/Izenda-AdHoc-FieldHighlightInfoDictionary]]
 Represents a collection of colors that can be used for shading cells on a report. 
##[[Izenda.AdHoc.FieldOperator|/API/Izenda/AdHoc/Izenda-AdHoc-FieldOperator]]
 Enumerates possible logical and arithmetic operators that can apply to fields. 
##[[Izenda.AdHoc.FieldRangeValueInfo|/API/Izenda/AdHoc/Izenda-AdHoc-FieldRangeValueInfo]]
 Represents a method of replacing a range of values on report fields with a different value. 
##[[Izenda.AdHoc.FileSystemAdHocConfig|/API/Izenda/AdHoc/Izenda-AdHoc-FileSystemAdHocConfig]]
 Represents a set of methods and properties for using the server's filesystem to load/save/delete reports, forms, and thumbnails. 
##[[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]]
Represents a filter for a [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.FilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FilterCollection]]
Represents a collection of [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] objects  in a [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.FilterEntry|/API/Izenda/AdHoc/Izenda-AdHoc-FilterEntry]]
 Represents a data structure for holding cached filter information. 
##[[Izenda.AdHoc.FilterParser|/API/Izenda/AdHoc/Izenda-AdHoc-FilterParser]]
 Represents a set of methods that parse a filter logic expression and prepare it for insertion into an SQL filter expression. 
##[[Izenda.AdHoc.FilterValue|/API/Izenda/AdHoc/Izenda-AdHoc-FilterValue]]
 Enumerates the various types of requirements that can apply to reports before allowing them to be viewed. 
##[[Izenda.AdHoc.FormatCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatCollection]]
 Represents a collection of formats available for use on reports. 
##[[Izenda.AdHoc.FormatContext|/API/Izenda/AdHoc/Izenda-AdHoc-FormatContext]]
Provides formatting context for a [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] source that was built from a report.
##[[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]]
 Represents a collection of formatters that can be applied to the various formats in AdHoc. 
##[[Izenda.AdHoc.FunnelChartDataGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-FunnelChartDataGenerator]]
 Represents a set of methods and properties that apply to plot charts with a single series of data separated by the Separator column. 
##[[Izenda.AdHoc.FusionCache|/API/Izenda/AdHoc/Izenda-AdHoc-FusionCache]]
 Represents a data cache that stores report results for a specified time period for easy access during that time period. This is useful for reports with large amounts of data that does not change often. 
##[[Izenda.AdHoc.GaugeBaseFormat|/API/Izenda/AdHoc/Izenda-AdHoc-GaugeBaseFormat]]
 Represents a format that provides a generic definition for formatting values as a gauge. 
##[[Izenda.AdHoc.GaugeBaseFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-GaugeBaseFormatter]]
 Represents a formatter that contains generic properties and methods to format the value of the field as a gauge.  
##[[Izenda.AdHoc.GaugeFormat|/API/Izenda/AdHoc/Izenda-AdHoc-GaugeFormat]]
 Represents a format that formats the value of the field as a gauge 
##[[Izenda.AdHoc.GaugeFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-GaugeFormatter]]
 Represents a formatter that formats the value of the field as a gauge. 
##[[Izenda.AdHoc.GaugeVariableFormat|/API/Izenda/AdHoc/Izenda-AdHoc-GaugeVariableFormat]]
 Represents a format that formats the value of the field as a gauge with the minimum and maximum values of the gauge set by the values of the next two columns. 
##[[Izenda.AdHoc.GaugeVariableFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-GaugeVariableFormatter]]
 Represents a formatter that formats the value of the field as a gauge with the minimum and maximum values of the gauge set by the values of the next two columns. 
##[[Izenda.AdHoc.GetEqualsSelectValuesDelegate|/API/Izenda/AdHoc/Izenda-AdHoc-GetEqualsSelectValuesDelegate]]

##[[Izenda.AdHoc.HeatMapFormat|/API/Izenda/AdHoc/Izenda-AdHoc-HeatMapFormat]]
 Represents a format that formats a field as a heatmap. 
##[[Izenda.AdHoc.HeatMapFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-HeatMapFormatter]]
 Represents a formatter that formats the value of the field as a heatmap. 
##[[Izenda.AdHoc.HiddenCategoryCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenCategoryCollection]]
 Represents a collection of report categories that are hidden for various users. 
##[[Izenda.AdHoc.HiddenChartProperty|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenChartProperty]]
 Represents a single property of a chart that will be displayed on a web page as a hidden input control. 
##[[Izenda.AdHoc.HiddenFilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenFilterCollection]]
 Represents a collection of filters that are hidden from the view of report viewers and cannot be changed by them. 
##[[Izenda.AdHoc.HighChart|/API/Izenda/AdHoc/Izenda-AdHoc-HighChart]]
 Represents a set of methods and properties that define how a chart using the HighCharts library will behave. 
##[[Izenda.AdHoc.HighChartBarChart|/API/Izenda/AdHoc/Izenda-AdHoc-HighChartBarChart]]
 Represents a set of methods and properties that define how a bar chart using the HighCharts library will behave. 
##[[Izenda.AdHoc.HighChartCustomChart|/API/Izenda/AdHoc/Izenda-AdHoc-HighChartCustomChart]]
 Represents a set of methods and properties that define how a custom type of chart using the HighCharts library will behave. 
##[[Izenda.AdHoc.HighChartEffectScript|/API/Izenda/AdHoc/Izenda-AdHoc-HighChartEffectScript]]
 Represents a subreport script and click effect that is added to charts made with HighCharts. 
##[[Izenda.AdHoc.HighChartFunnelChart|/API/Izenda/AdHoc/Izenda-AdHoc-HighChartFunnelChart]]
 Represents a set of methods and properties that define how a funnel chart using the HighCharts library will behave. 
##[[Izenda.AdHoc.HighChartLineChart|/API/Izenda/AdHoc/Izenda-AdHoc-HighChartLineChart]]
 Represents a set of methods and properties that define how a line chart using the HighCharts library will behave. 
##[[Izenda.AdHoc.HighChartPieChart|/API/Izenda/AdHoc/Izenda-AdHoc-HighChartPieChart]]
 Represents a set of methods and properties that define how a pie chart using the HighCharts library will behave. 
##[[Izenda.AdHoc.Html2PdfGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-Html2PdfGenerator]]
Represents an output generator to produce a PDF file from the specified [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.HtmlOutputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-HtmlOutputGenerator]]
Represents an output generator to produce a printable HTML document from the specified [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.HtmlToPictureRenderer|/API/Izenda/AdHoc/Izenda-AdHoc-HtmlToPictureRenderer]]
 Represents a set of methods and properties to convert the rendered HTML of a report into a bitmap image. 
##[[Izenda.AdHoc.IAggregateFunction|/API/Izenda/AdHoc/Izenda-AdHoc-IAggregateFunction]]
 Represents a set of methods and properties that determine how column aggregation occurs during report generation. 
##[[Izenda.AdHoc.IFormat|/API/Izenda/AdHoc/Izenda-AdHoc-IFormat]]
 Represents a format that can be applied to individual fields on a report. 
##[[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]]
 Represents a formatter that can be used to create additional formats for report values. 
##[[Izenda.AdHoc.IJSFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IJSFormatter]]
 Represents an interface for adding column formatting for javascript output when processing report formatters. 
##[[Izenda.AdHoc.Interval|/API/Izenda/AdHoc/Izenda-AdHoc-Interval]]
 Represents an interval for the number of records that are rendered per page on a report when paging is used. 
##[[Izenda.AdHoc.InvalidReportException|/API/Izenda/AdHoc/Izenda-AdHoc-InvalidReportException]]
 Represents an exception that is thrown when a report is invalid due to errors. 
##[[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]]
 Represents a set of methods that are used to intercept report operations such as saving, loading, and executing. 
##[[Izenda.AdHoc.ITextSharpOutputType|/API/Izenda/AdHoc/Izenda-AdHoc-ITextSharpOutputType]]
 Enumerates the possible output formats for exports using the iTextSharp library 
##[[Izenda.AdHoc.ITextSharpPdfGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-ITextSharpPdfGenerator]]
Represents report output generator which generate PDF report file for specified [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].
##[[Izenda.AdHoc.ITotalDifferentFormaters|/API/Izenda/AdHoc/Izenda-AdHoc-ITotalDifferentFormaters]]
 Represents an interface for creating formatters that apply to a total group of different values. 
##[[Izenda.AdHoc.IVersedFormat|/API/Izenda/AdHoc/Izenda-AdHoc-IVersedFormat]]
 Represents a format that is version-specific. 
##[[Izenda.AdHoc.IXmlSerializableEx|/API/Izenda/AdHoc/Izenda-AdHoc-IXmlSerializableEx]]
 Interface allowing serialization to and from xml. 
##[[Izenda.AdHoc.IzendaAdHocEdition|/API/Izenda/AdHoc/Izenda-AdHoc-IzendaAdHocEdition]]
 Enumerates different AdHoc editions. 
##[[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]]
Represents a table with relational joining information that is used on a [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.JoinedTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTableCollection]]
Represents a collection of [[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]] objects  in a [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]]
 Represents a lightweight data structure for providing context for joined tables associated with reports. 
##[[Izenda.AdHoc.JoinHintCollection|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHintCollection]]
Represents a collection of [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] items.
##[[Izenda.AdHoc.JoinType|/API/Izenda/AdHoc/Izenda-AdHoc-JoinType]]
 Enumerates different SQL JOIN types. 
##[[Izenda.AdHoc.JsonArraysOutputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-JsonArraysOutputGenerator]]
Represents an output generator that creates a javascript file containing the input [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] tables represented as JSON formatted array variables.
##[[Izenda.AdHoc.JsonOutputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-JsonOutputGenerator]]
Represents an output generator that creates a JSON file from an input [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].
##[[Izenda.AdHoc.JsonReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-JsonReportSet]]
 This class is a container for a ReportSet, it is used to facilitate simpler  more efficient means of exporting a ReportSet to JSON. 
##[[Izenda.AdHoc.LicenseParameters|/API/Izenda/AdHoc/Izenda-AdHoc-LicenseParameters]]
 Enumerates the various license key parameters that settings should check for before being available. 
##[[Izenda.AdHoc.ListItemComparer|/API/Izenda/AdHoc/Izenda-AdHoc-ListItemComparer]]
Represents a method for comparing two [[System.Web.UI.WebControls.ListItem|http://msdn.microsoft.com/en-us/library/bb768tf6]] objects for equality and sorting them.
##[[Izenda.AdHoc.MapSettings|/API/Izenda/AdHoc/Izenda-AdHoc-MapSettings]]
 Represents various settings that are used on a map inside a report. 
##[[Izenda.AdHoc.MD5|/API/Izenda/AdHoc/Izenda-AdHoc-MD5]]
 Represents methods of performing MD5 encryption algorithms. 
##[[Izenda.AdHoc.MD5CryptoServiceProvider|/API/Izenda/AdHoc/Izenda-AdHoc-MD5CryptoServiceProvider]]
 Represents a wrapper for an MD5 encryption provider. 
##[[Izenda.AdHoc.MoneyDividedByHundredFormat|/API/Izenda/AdHoc/Izenda-AdHoc-MoneyDividedByHundredFormat]]
 Represents a format that formats the value of the field as money with two decimal places. 
##[[Izenda.AdHoc.MoneyDividedByHundredFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-MoneyDividedByHundredFormatter]]
 Represents a formatter that formats the value of the field as money with two decimal places. 
##[[Izenda.AdHoc.OperatorTypes|/API/Izenda/AdHoc/Izenda-AdHoc-OperatorTypes]]
 Enumerates different SQL operators that can apply to filters. 
##[[Izenda.AdHoc.OrderType|/API/Izenda/AdHoc/Izenda-AdHoc-OrderType]]
 Enumerates the list of data ordering types that can be applied to fields. 
##[[Izenda.AdHoc.PdfMode|/API/Izenda/AdHoc/Izenda-AdHoc-PdfMode]]
 Enumerates the different libraries that can be leveraged for converting reports to PDF. 
##[[Izenda.AdHoc.PercentOfGroupFormat|/API/Izenda/AdHoc/Izenda-AdHoc-PercentOfGroupFormat]]
 Represents a format that formats the value of the field as a percent of a total group of values. 
##[[Izenda.AdHoc.PercentOfGroupFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-PercentOfGroupFormatter]]
 Represents a formatter that formats the value of the field as a percent of a total group of values. 
##[[Izenda.AdHoc.PieChartDataGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-PieChartDataGenerator]]
 Represents a set of methods and properties that apply to pie charts with a single series of data separated by the Separator column. 
##[[Izenda.AdHoc.PlotChartDataGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-PlotChartDataGenerator]]
 Represents a set of methods and properties that apply to plot charts with a single series of data separated by the Separator column. 
##[[Izenda.AdHoc.PlotData|/API/Izenda/AdHoc/Izenda-AdHoc-PlotData]]
 Represents a set of methods and properties used to compare and sort data for individual points on a plot chart. Multiple PlotData lines can exist on a single chart. 
##[[Izenda.AdHoc.Position|/API/Izenda/AdHoc/Izenda-AdHoc-Position]]
Represents the position of a [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] relative to other [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] objects in a complete [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] for use on a dashboard.
##[[Izenda.AdHoc.ProcessFiltersDelegate|/API/Izenda/AdHoc/Izenda-AdHoc-ProcessFiltersDelegate]]

##[[Izenda.AdHoc.PropertySetEditionAttribute|/API/Izenda/AdHoc/Izenda-AdHoc-PropertySetEditionAttribute]]
Used to define the [[Izenda.AdHoc.IzendaAdHocEdition|/API/Izenda/AdHoc/Izenda-AdHoc-IzendaAdHocEdition]] of properties to determine what edition of the product the item should be available in.
##[[Izenda.AdHoc.QuarterFormater|/API/Izenda/AdHoc/Izenda-AdHoc-QuarterFormater]]
 Represents a formatter that formats the value of the field as the quarter of the year and the year. 
##[[Izenda.AdHoc.RangeDescriptorType|/API/Izenda/AdHoc/Izenda-AdHoc-RangeDescriptorType]]
 Enumerates the possible ways that background color descriptions can be parsed. 
##[[Izenda.AdHoc.RdlConverter|/API/Izenda/AdHoc/Izenda-AdHoc-RdlConverter]]
Represents a set of methods used to create an RDL file from a [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].
##[[Izenda.AdHoc.RdlReportOutputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-RdlReportOutputGenerator]]
Represents an output generator that creates an RDL file from an input [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].
##[[Izenda.AdHoc.RepeatType|/API/Izenda/AdHoc/Izenda-AdHoc-RepeatType]]
 Enumerates the different types of intervals scheduled reports can be sent at. 
##[[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]]
Represents an individual report to be used on a [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] or by itself.
##[[Izenda.AdHoc.ReportArchiveConverter|/API/Izenda/AdHoc/Izenda-AdHoc-ReportArchiveConverter]]
 Represents converter that can be used when loading old version of report archives (w/o schema name in table name and column name). 
##[[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]]
Represents the collection of [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] objects  in the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].
##[[Izenda.AdHoc.ReportExistsException|/API/Izenda/AdHoc/Izenda-AdHoc-ReportExistsException]]
Initializes an exception that is thrown when a report is invalid due to the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] not being found.
##[[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]]
 Represents a basic set of report information that can be compared and sorted based on name and category. 
##[[Izenda.AdHoc.ReportInfoLite|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfoLite]]
 Represents a data structure for holding basic report info that can be serialized as a JSON object for use on the report list page. 
##[[Izenda.AdHoc.ReportListAuxData|/API/Izenda/AdHoc/Izenda-AdHoc-ReportListAuxData]]
 Represents a set of additional data that can be used to hold various properties for reports. 
##[[Izenda.AdHoc.ReportOutputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputGenerator]]
 Represets a set of methods and properties that can apply to all output generators. 
##[[Izenda.AdHoc.ReportOutputGeneratorCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputGeneratorCollection]]
 Represents a set of output generators designed to handle processing of exports. 
##[[Izenda.AdHoc.ReportOutputOptions|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputOptions]]
 Enumerates options for reports that are used to determine how a report should be generated for specific output. 
##[[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]]
Represents a collection of [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] parts that make up an entire set.
##[[Izenda.AdHoc.ReportSetEventWatcherCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetEventWatcherCollection]]
 Represents a set of methods that execute delegate methods during certain points in the report saving, loading, and executing process. 
##[[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]]
Represents a container for the loaded data within a [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].
##[[Izenda.AdHoc.ReportSetType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetType]]
 Enumerates the various types of report sets. 
##[[Izenda.AdHoc.ReportType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportType]]
 Represents a single type of report that can be processed by the application. 
##[[Izenda.AdHoc.ReportTypeCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportTypeCollection]]
 Represents a collection of report types that can be processed by the application. 
##[[Izenda.AdHoc.ResponseServer|/API/Izenda/AdHoc/Izenda-AdHoc-ResponseServer]]
 Represents the base functionality for handling requests from the client machines and storing data on the server. 
##[[Izenda.AdHoc.SchedulerOutput|/API/Izenda/AdHoc/Izenda-AdHoc-SchedulerOutput]]
 Class which is encapsulating information about scheduler mail type and output format. 
##[[Izenda.AdHoc.SchedulerOutputCollection|/API/Izenda/AdHoc/Izenda-AdHoc-SchedulerOutputCollection]]
 Represents a collection of output types for the report scheduler. 
##[[Izenda.AdHoc.SchedulerOutputType|/API/Izenda/AdHoc/Izenda-AdHoc-SchedulerOutputType]]
 Enumerates the various methods that may be used to send scheduled reports. 
##[[Izenda.AdHoc.SchedulerTimeZone|/API/Izenda/AdHoc/Izenda-AdHoc-SchedulerTimeZone]]
 Represents a time zone on the AdHoc Report Scheduler control. 
##[[Izenda.AdHoc.SchedulerTimeZoneCollection|/API/Izenda/AdHoc/Izenda-AdHoc-SchedulerTimeZoneCollection]]
Represents a collection of [[Izenda.AdHoc.SchedulerTimeZone|/API/Izenda/AdHoc/Izenda-AdHoc-SchedulerTimeZone]] objects used on the scheduler controls.
##[[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]]
 Enumerates the various scoping types that can be used for AdHoc settings. 
##[[Izenda.AdHoc.ScopeAttribute|/API/Izenda/AdHoc/Izenda-AdHoc-ScopeAttribute]]
Used to define the [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] of where properties should be stored in memory.
##[[Izenda.AdHoc.ScopeCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ScopeCollection]]
Represents the collection of [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] objects.
##[[Izenda.AdHoc.ScriptSorter|/API/Izenda/AdHoc/Izenda-AdHoc-ScriptSorter]]
 Represents a set of methods that sort a set of client-side scripts in order of dependency. 
##[[Izenda.AdHoc.SecurityReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-SecurityReportSetEventWatcher]]
Represents a security object that fires events to automatically add hidden filters used by all [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] objects to the report.
##[[Izenda.AdHoc.SeparatorBarChartDataGeneratorBase|/API/Izenda/AdHoc/Izenda-AdHoc-SeparatorBarChartDataGeneratorBase]]
 Represents a set of methods and properties that apply to bar charts that have the option to separate data logically by a separator field. 
##[[Izenda.AdHoc.SeparatorChartDataGeneratorBase|/API/Izenda/AdHoc/Izenda-AdHoc-SeparatorChartDataGeneratorBase]]
 Represents a set of methods and properties that can apply to any chart that has the option to separate data logically by a separator field. 
##[[Izenda.AdHoc.SeparatorPlotChartDataGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-SeparatorPlotChartDataGenerator]]
 Represents a set of methods and properties that apply to plot charts with the option to separate data logically by a separator field. 
##[[Izenda.AdHoc.ServerReportArchive|/API/Izenda/AdHoc/Izenda-AdHoc-ServerReportArchive]]
Represents a control used to store individual reports from the Reports Tab of the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]].
##[[Izenda.AdHoc.SettingDefaultValueAttribute|/API/Izenda/AdHoc/Izenda-AdHoc-SettingDefaultValueAttribute]]
 Used to determine what default value a setting should use. 
##[[Izenda.AdHoc.SettingFormatParametr|/API/Izenda/AdHoc/Izenda-AdHoc-SettingFormatParametr]]
Enumerates the formats that settings can display as on the [[Izenda.AdHoc.Settings|/API/Izenda/AdHoc/Izenda-AdHoc-Settings]] page.
##[[Izenda.AdHoc.Settings|/API/Izenda/AdHoc/Izenda-AdHoc-Settings]]
 Represents the base functionality for manipulating AdHoc settings. 
##[[Izenda.AdHoc.SettingsFormat|/API/Izenda/AdHoc/Izenda-AdHoc-SettingsFormat]]
Used to determine what formatting options to use on the [[Izenda.AdHoc.Settings|/API/Izenda/AdHoc/Izenda-AdHoc-Settings]] page.
##[[Izenda.AdHoc.SettingsUnchangedAttribute|/API/Izenda/AdHoc/Izenda-AdHoc-SettingsUnchangedAttribute]]
 Used to define what version the AdHoc key should be before allowing or preventing the property from being changed. 
##[[Izenda.AdHoc.SeverCommandDelegate|/API/Izenda/AdHoc/Izenda-AdHoc-SeverCommandDelegate]]
 Represents a reference to methods run as client requests to the server that execute a set of server commands using the specified parameters. 
##[[Izenda.AdHoc.SharingControl|/API/Izenda/AdHoc/Izenda-AdHoc-SharingControl]]
 Represents a control that can be used to share reports among users. 
##[[Izenda.AdHoc.SimpleAggregateFunction|/API/Izenda/AdHoc/Izenda-AdHoc-SimpleAggregateFunction]]
 Represents an additional aggregation function that can be added to the normally available aggregation function definitions. 
##[[Izenda.AdHoc.SimpleFormat|/API/Izenda/AdHoc/Izenda-AdHoc-SimpleFormat]]
 Represents a basic format that can be added to the list of available formats. 
##[[Izenda.AdHoc.SimpleFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-SimpleFormatter]]
 Represents a formatter that formats the value of the field using a provided format string. 
##[[Izenda.AdHoc.SqlReportOuputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-SqlReportOuputGenerator]]
Represents an output generator that creates a SQL script file from an input [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].
##[[Izenda.AdHoc.SqlResponseServer|/API/Izenda/AdHoc/Izenda-AdHoc-SqlResponseServer]]
 Provides a wrapper for the response server page that handles requests from client machines. 
##[[Izenda.AdHoc.StandardAggregateFunction|/API/Izenda/AdHoc/Izenda-AdHoc-StandardAggregateFunction]]
 Represents a default aggregation function that can be used by default on the database. 
##[[Izenda.AdHoc.StandardAggregateFunctionType|/API/Izenda/AdHoc/Izenda-AdHoc-StandardAggregateFunctionType]]
 Enumerates generic SQL aggregate functions that can apply to fields. 
##[[Izenda.AdHoc.StaticSharedStorage|/API/Izenda/AdHoc/Izenda-AdHoc-StaticSharedStorage]]
 Represents a set of methods that controls how large objects and user sessions are stored within the system. When active, these items are stored in the application's global memory cache. This can speed up retrieval of sessions and large objects when processing power is a bottleneck but server memory is plentiful. 
##[[Izenda.AdHoc.StorageMode|/API/Izenda/AdHoc/Izenda-AdHoc-StorageMode]]
 Enumerates the various methods that can be used to store reports. 
##[[Izenda.AdHoc.StringConsts|/API/Izenda/AdHoc/Izenda-AdHoc-StringConsts]]
 Represents a list of various gauge styles for component art gauges. 
##[[Izenda.AdHoc.StringHelper|/API/Izenda/AdHoc/Izenda-AdHoc-StringHelper]]
Provides helper methods for manipulating [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] objects.
##[[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]]
Represents a [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] and its associated [[Izenda.AdHoc.FormatContext|/API/Izenda/AdHoc/Izenda-AdHoc-FormatContext]].
##[[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]]
 Represents a collection of formatted results for report data. 
##[[Izenda.AdHoc.TargetReportChartProperty|/API/Izenda/AdHoc/Izenda-AdHoc-TargetReportChartProperty]]
 Represents a single property of a chart that will be displayed on a web page as a dropdown list containing a list of possible reports that this control can use. 
##[[Izenda.AdHoc.TenantReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-TenantReportSetEventWatcher]]
 Represents an event watcher that ensures tenant filters are added to reports before executing the report. 
##[[Izenda.AdHoc.TextAreaChartProperty|/API/Izenda/AdHoc/Izenda-AdHoc-TextAreaChartProperty]]
 Represents a single property of a chart that will be displayed on a web page as a freeform text area. 
##[[Izenda.AdHoc.TextboxChartProperty|/API/Izenda/AdHoc/Izenda-AdHoc-TextboxChartProperty]]
 Represents a single property of a chart that will be displayed on a web page as a single line text box. 
##[[Izenda.AdHoc.TextSharpFontWrapper|/API/Izenda/AdHoc/Izenda-AdHoc-TextSharpFontWrapper]]
 Represents a set of methods used to retain multiple pieces of information about an iTextSharp font. 
##[[Izenda.AdHoc.TimePeriod|/API/Izenda/AdHoc/Izenda-AdHoc-TimePeriod]]
 Enumerates different time periods that can apply to the In Time Period operator. 
##[[Izenda.AdHoc.TimePeriodFormat|/API/Izenda/AdHoc/Izenda-AdHoc-TimePeriodFormat]]
 Represents a format that formats the value of a field as a time period. 
##[[Izenda.AdHoc.TimePeriodFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-TimePeriodFormatter]]
 Represents a formatter that formats the value of the field as a time period. 
##[[Izenda.AdHoc.TimeSumAggregateFunction|/API/Izenda/AdHoc/Izenda-AdHoc-TimeSumAggregateFunction]]
 Represents an aggregation function that can be used to add multiple periods of time on the database. 
##[[Izenda.AdHoc.TrendChartDataGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-TrendChartDataGenerator]]
 Represents a set of methods and properties that apply to trend charts with a single series of data separated by the Separator column. 
##[[Izenda.AdHoc.UrlFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-UrlFormatter]]
 Represents a formatter that formats the value of the field as a URL with column references. 
##[[Izenda.AdHoc.UsersCountModel|/API/Izenda/AdHoc/Izenda-AdHoc-UsersCountModel]]
 Enumerates the various types of licensing options for the number of users that may be using the product. 
##[[Izenda.AdHoc.Utility|/API/Izenda/AdHoc/Izenda-AdHoc-Utility]]
 Represents a collection of static helper methods used throughout the AdHoc reporting tool. 
##[[Izenda.AdHoc.ValueTreeNode|/API/Izenda/AdHoc/Izenda-AdHoc-ValueTreeNode]]
 Represents an individual item for use in a tree data structure. 
##[[Izenda.AdHoc.VersionPeriod|/API/Izenda/AdHoc/Izenda-AdHoc-VersionPeriod]]
 Enumerates the various periods of time that the AdHoc license key version can use to turn on or off property setters. 
##[[Izenda.AdHoc.VisualGroupStyle|/API/Izenda/AdHoc/Izenda-AdHoc-VisualGroupStyle]]
 Enumerates the possible types of visual grouping that a report can render. 
##[[Izenda.AdHoc.VisualizationsRenderer|/API/Izenda/AdHoc/Izenda-AdHoc-VisualizationsRenderer]]
 Represents a set of methods that are used to render a visualization to a GDI+ drawing surface. 
##[[Izenda.AdHoc.WeekFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-WeekFormatter]]
 Represents a formatter that formats the value of the field as the day of the week. This will be a numerical representation from one to seven. 
##[[Izenda.AdHoc.WeekNameFormater|/API/Izenda/AdHoc/Izenda-AdHoc-WeekNameFormater]]
 Represents a formatter that formats the value of the field as the day of the week. This will be the name of the weekday rather than the number. 
##[[Izenda.AdHoc.XmlReportOutputGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-XmlReportOutputGenerator]]
Represents an output generator that creates an XML file from an input [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].
##[[Izenda.AdHoc.ZedGraphBarChart|/API/Izenda/AdHoc/Izenda-AdHoc-ZedGraphBarChart]]
 Represents a set of methods and properties that define how a bar chart using the ZedGraph library will behave. 
##[[Izenda.AdHoc.ZedGraphChart|/API/Izenda/AdHoc/Izenda-AdHoc-ZedGraphChart]]
 Represents a set of general methods and properties that define how charts using the ZedGraph library will behave. 
##[[Izenda.AdHoc.ZedGraphPieChart|/API/Izenda/AdHoc/Izenda-AdHoc-ZedGraphPieChart]]
 Represents a set of methods and properties that define how an pie chart using the ZedGraph library will behave. 
##[[Izenda.AdHoc.ZedGraphPlotChart|/API/Izenda/AdHoc/Izenda-AdHoc-ZedGraphPlotChart]]
 Represents a set of general methods and properties that define how a plot chart using the ZedGraph library will behave. 
##[[Izenda.AdHoc.ZedGraphTrendChart|/API/Izenda/AdHoc/Izenda-AdHoc-ZedGraphTrendChart]]
 Represents a set of methods and properties that define how an trend chart using the ZedGraph library will behave. 
