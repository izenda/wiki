#Report

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Hashtable|[[ChartProperties|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_ChartProperties]]| Gets the collection of key/value pairs that represent the collection of properties used by charts to control chart settings across the report. |null|
|Unit|[[ColumnsWidth|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_ColumnsWidth]]|Gets or sets the universal width of all columns for this report using the specified [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]].|String.Empty|
|Int32|[[CombinedTop|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_CombinedTop]]|Gets the number of rows that will be fetched by this report when it is executed. If the parent [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] returns less rows, then that number is used instead.|-2147483648|
|Boolean|[[Distinct|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Distinct]]| Gets or sets the value indicating whether distinct rows only should be in the report. |True|
|Field|[[ExtraColumn|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_ExtraColumn]]|Gets or sets a temporary [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] placeholder on the report that is used for pivots and calculated fields.|null|
|FieldCollection|[[ExtraColumnValue|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_ExtraColumnValue]]|Gets or sets the collection of [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] values that correspond to the pivot column specified by the ExtraColumn property.|null|
|FieldCollection|[[Fields|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Fields]]|Gets or sets a collection of contained Izenda.AdHoc.Fields.|null|
|Int32|[[FieldValueColumnPairs|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_FieldValueColumnPairs]]| Gets or sets the number of field/value pairs to use on a single line of this report when the report is displayed using field/value style. |2|
|FilterCollection|[[Filters|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Filters]]|Gets or sets a collection of contained Izenda.AdHoc.Filters used in this report.|null|
|Field|[[GroupByFieldWhenUsedAllFields|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_GroupByFieldWhenUsedAllFields]]|Gets or sets the [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that will always be used to group data by on a report.**(deprecated)**|null|
|Nullable|[[Height|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Height]]| Gets or sets the height of the report. **(deprecated)**|null|
|Boolean|[[IsChart|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_IsChart]]| Determines whether or not this report is a chart. |False|
|Boolean|[[IsGauge|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_IsGauge]]| Determines whether or not this report is a gauge. |False|
|Boolean|[[IsMap|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_IsMap]]| Determines whether or not this report is a map. |False|
|Boolean|[[IsPdfPrint|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_IsPdfPrint]]| Gets or sets whether cthis report will be exported to PDF for purposes of determining whether charts should be rendered as images or interactive HTML. |False|
|Boolean|[[IsRenderingToPicture|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_IsRenderingToPicture]]| Gets or sets whether charts in the report will be rendered as a static image or as HTML. |False|
|Boolean|[[IsSimpleGridReport|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_IsSimpleGridReport]]| Determines whether the report renders its contents in the standard fashion for a basic grid report. |True|
|Boolean|[[IsValid|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_IsValid]]| Determines whether the report has errors or is invalid in some way. |False|
|Boolean|[[IsVisualization|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_IsVisualization]]| Determines whether or not this report is a visualization. |False|
|JoinedTableCollection|[[JoinedTables|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_JoinedTables]]|Gets or sets a collection of contained Izenda.AdHoc.JoinedTables that describe all the data sources used in this report.|null|
|Int32|[[LinesPerItem|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_LinesPerItem]]| Gets or sets the default number of lines per item for the "Multi-Line" feature for this report. |1|
|MapSettings|[[MapSettings|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_MapSettings]]| Gets or sets the map settings that are to be used on this report. |null|
|String|[[Name|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Name]]|Gets or sets the internal name of this report that is a part of the entire [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|null|
|ReportSet|[[ParentReportSet|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_ParentReportSet]]|Gets or sets the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that this report object belongs to.|new Izenda.AdHoc.ReportSet()|
|Boolean|[[ParentReportSetEmpty|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_ParentReportSetEmpty]]|Determines whether or not the parent [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] object was initialized for this report.|True|
|Position|[[Position|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Position]]|Gets or sets the position relative to other reports in the parent [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|null|
|Field|[[SortByFieldWhenUsedAllFields|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_SortByFieldWhenUsedAllFields]]|Gets or sets the [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that will always be used to sort data on a report.**(deprecated)**|null|
|String|[[Source|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Source]]| Gets or sets the primary source table of this report. |String.Empty|
|String|[[SQL|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_SQL]]|Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL statement that is built by the report when it is executed.|null|
|AdHocStyle|[[Style|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Style]]| Gets style related to current color. |null|
|Int32|[[Top|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Top]]| Gets or sets how many rows (records) the current report will retrieve in its result set. Gauge reports have a maximum of sixteen. |-2147483648|
|IAggregateFunction|[[TotalsFunction|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_TotalsFunction]]| Gets the aggregation function that is used for aggregating totals on data in this report. |null|
|String|[[TotalsSQL|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_TotalsSQL]]|Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL that is built when producing the totals for the report.|null|
|Boolean|[[UseAllFields|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_UseAllFields]]| Determines whether all fields in the data sources associated with this report have been added to the report  and whether to use controls on the report designer to handle sorting and grouping in this case. **(deprecated)**|False|
|VisualGroupStyle|[[VisualGroupStyle|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_VisualGroupStyle]]|Gets or sets the [[Izenda.AdHoc.VisualGroupStyle|/API/Izenda/AdHoc/Izenda-AdHoc-VisualGroupStyle]] that will be used when rendering the report.|CommaDelimited|
|Hashtable|[[VisualizationProperties|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_VisualizationProperties]]| Gets the collection of key/value pairs that represent the collection of properties used by visualizations to control visualization settings across the report. |null|
|String|[[VisualizationPropertiesValue|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_VisualizationPropertiesValue]]| Gets or sets a JSON string representation of the properties that persist with a visualization on a report. |null|
|String|[[VisualizationReportSet|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_VisualizationReportSet]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the category and name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that the visualization belongs to.|null|
|String|[[VisualizationResource|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_VisualizationResource]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the visualization category and name that is included in this report.|null|
|Nullable|[[Width|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Report_Width]]| Gets or sets the width of the report. **(deprecated)**|null|


##Methods

###ClearExtraColumnList()
 Removes any additional columns that were generated as a result of calculating pivots or multi-column expressions from this report. 






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###FormatTable(System.Data.DataTable,System.Boolean,Izenda.AdHoc.ReportOutputOptions,System.Boolean)
Formats the specified [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] using the specified parameters to get a new table with formatting context.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The source [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to be formatted.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] totals  - Whether the report results will be formatted for totals or standard report results.
* [[Izenda.AdHoc.ReportOutputOptions|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputOptions]] options  - Specifies options that can be used to conditionally add or ignore special formatters.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] summaryLine  - Whether the output report will have a summary line at the bottom.





Returns:

The [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] containing the formatted table and formatting data for rendering the report.


---


###GetCombinedFilters()
Gets the combined set of all filters on the current report and the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] it belongs to.





Returns:

The [[Izenda.AdHoc.FilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FilterCollection]] that comprises every filter found on the report and the parent [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###GetCombinedJoinedTables()
Gets the collection of [[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]] objects that represent the data sources associated with the current report and its parent [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].





Returns:

The [[Izenda.AdHoc.JoinedTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTableCollection]] built from the current [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] and its parent [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###GetDataReader()
Gets a readable [[System.Data.IDataReader|http://msdn.microsoft.com/en-us/library/sh674a6a]] object that contains the report's query execution results.





Returns:

The forward-only stream of result sets obtained by executing the report's command against the data sources for the report.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetSchema()
Gets the XML schema structure for the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] object.





Returns:

XML schema of this object.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###LoadAndFormatData()
Gets a [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]] for this report containing the report's data and the respective column formatter data.





Returns:

The [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]] with the report's data and column formatting information.


---


###LoadAndFormatData(Izenda.AdHoc.ReportOutputOptions)
 Formats the current report with the specified options to produce formatted output. 

Parameters: 

* [[Izenda.AdHoc.ReportOutputOptions|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputOptions]] options  - The [[Izenda.AdHoc.ReportOutputOptions|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputOptions]] to apply to the formatted results.





Returns:

The [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]] with the report's data and column formatting information.


---


###LoadAndFormatData(Izenda.AdHoc.ReportOutputOptions,System.Data.DataTable)
Loads data for the current report using the specified options and [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] the data will be loaded from.

Parameters: 

* [[Izenda.AdHoc.ReportOutputOptions|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputOptions]] options  - Specifies options that can be used to conditionally add or ignore special formatters.
* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] workTable  - The source [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to be formatted.





Returns:

The [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] containing the formatted table and formatting data for rendering the report.


---


###LoadDataSet(System.Boolean)
 Gets the set of data associated with this report by running the SQL command constructed by this report. **(deprecated)**

Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] graphicsAllowed  - Specifies whether image content is included in the resulting [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]].





Returns:

The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] that contains the report data.


---


###ReadXml(System.String)
Reads XML data into the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] from the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] from which to read.






---


###ReadXml(System.Xml.XmlReader)
Reads XML data into the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] using the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]].

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] from which to read.






---


###RenderHtml()
 Renders the report HTML with the default width and height for the container where the report HTML resides. 





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the literal HTML report.


---


###RenderHtml(System.Int32,System.Int32)
 Renders the report HTML with the specified width and height for the container where the report HTML resides. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] width  - The width of the container for the HTML report.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] height  - The height of the container for the HTML report.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the literal HTML report.


---


###ReplaceFields(System.String)
Ensures the supplied [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value contains references to valid database fields. Fields that are hidden filters will be replaced with the HIDDEN identifier.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] str  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] descriptor with field names to check.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the input string with valid field references.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###WriteXml()
Writes the current data of the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] and returns it.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the XML string containing the report data.


---


###WriteXml(System.Xml.XmlWriter)
Writes the current data of the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to the specified [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]].

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] with which to write.






---


