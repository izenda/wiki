#FunnelChartDataGenerator

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[ContainsSeparator|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartDataGeneratorBase_ContainsSeparator]]| Determines whether the chart data contains a set of values that acts as a separator for creating multi-line/bar/pie/funnel charts. |False|
|String[]|[[Labels|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_FunnelChartDataGenerator_Labels]]| Gets a list of chart labels that were loaded from the source data during extraction. |null|
|Double[]|[[Values|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_FunnelChartDataGenerator_Values]]|Gets the [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] array of data points that correspond to the labels that were loaded from the source data during extraction.|null|


##Methods

###CreateChartItems()
Creates a [[Izenda.AdHoc.ChartItemCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ChartItemCollection]] of controls that appear on the Chart tab of the AdHocReportDesigner when the trend option is selected.





Returns:

The collection of [[Izenda.AdHoc.ChartItem|/API/Izenda/AdHoc/Izenda-AdHoc-ChartItem]] objects that represent the charting controls for the AdHocReportDesigner for trend charts.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###ExctractData(System.Data.DataTable)
Loads the data the chart will use from the specified [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] using a column named Label as its Y axis values and a column named Value as its X axis values.

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


