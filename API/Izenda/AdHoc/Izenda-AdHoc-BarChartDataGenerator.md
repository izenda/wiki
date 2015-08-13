#BarChartDataGenerator

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[ContainsSeparator|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartDataGeneratorBase_ContainsSeparator]]| Determines whether the chart data contains a set of values that acts as a separator for creating multi-line/bar/pie/funnel charts. |False|
|Boolean|[[IsMultiSeries|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SeparatorBarChartDataGeneratorBase_IsMultiSeries]]| Determines whether the data for this chart has multiple series of data contained within it. |null|
|ArrayList|[[Labels|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SeparatorBarChartDataGeneratorBase_Labels]]| Gets a list of chart labels that were loaded from the source data during extraction. |null|


##Methods

###BarDataArray(System.String)
Gets the [[Izenda.AdHoc.BarData|/API/Izenda/AdHoc/Izenda-AdHoc-BarData]] array associated with the specified series name from the data that was loaded from the source during extraction.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name that was given to the series that the data belongs to.





Returns:

The [[Izenda.AdHoc.BarData|/API/Izenda/AdHoc/Izenda-AdHoc-BarData]] array of data points that belong to the series.


---


###ContainsColumn(System.String)
Determines whether the set of [[Izenda.AdHoc.BarData|/API/Izenda/AdHoc/Izenda-AdHoc-BarData]] associated with this chart data contains a series with the specified name.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name that was given to the series that the data belongs to.





Returns:

Whether the collection of bars on the chart contains a series with the specified name.


---


###CreateChartItems()
Creates a [[Izenda.AdHoc.ChartItemCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ChartItemCollection]] of controls that appear on the Chart tab of the AdHocReportDesigner when the bar option is selected.





Returns:

The collection of [[Izenda.AdHoc.ChartItem|/API/Izenda/AdHoc/Izenda-AdHoc-ChartItem]] objects that represent the charting controls for the AdHocReportDesigner for bar charts.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###ExctractData(System.Data.DataTable)
Loads the data the chart will use from the specified [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] that includes a single series of data based on a Separator column.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] dataTable  - The source [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to read from containing the results that will be made into a chart.






---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###PrepareField(Izenda.AdHoc.Field)
Represents a method that processes the input [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] for use in the chart. This method runs when the report loads and formats its data.

Parameters: 

* [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] field  - The input [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] to be processed for the chart.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


