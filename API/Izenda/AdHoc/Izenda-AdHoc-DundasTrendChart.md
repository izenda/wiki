#DundasTrendChart

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|ChartDataGeneratorBase|[[DataGenerator|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Chart_DataGenerator]]| Gets the data generation mechanism that will be used for this chart. |null|
|Boolean|[[ForceSize|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Chart_ForceSize]]| Gets or sets whether the height and width of the chart will be set at a fixed number defined by the chart or dynamic according to size requirements. |False|
|Unit|[[Height|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Chart_Height]]| Gets or sets the height of the chart. When not set manually, this defaults to use AdHocSettings.ChartSize.Y. |300px|
|ChartItemCollection|[[Items|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Chart_Items]]|Gets the list of [[Izenda.AdHoc.ChartItem|/API/Izenda/AdHoc/Izenda-AdHoc-ChartItem]] objects that form the labels and values for the chart.|null|
|String|[[Name|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Chart_Name]]| Gets or sets the name that identifies what type of chart is being created. |Trend|
|ChartPropertyCollection|[[Properties|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Chart_Properties]]| Gets the collection of chart properties that are used to control various settings. |{ShowLegend, LegendPosition,<br>ShowValueLabels, Smooth,<br>LabelTitle, ValueTitle,<br>Scale, UseSimpleStyle,<br>ThirdMode, CountInRow,<br>CountInRow}|
|Unit|[[Width|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Chart_Width]]| Gets or sets the width of the chart. When not set manually, this defaults to use AdHocSettings.ChartSize.X. |700px|


##Methods

###CreateDataGenerator()
 Initializes the data loading and generation mechanism for the trend chart that handles how column labels and values are loaded. 





Returns:

A new [[Izenda.AdHoc.TrendChartDataGenerator|/API/Izenda/AdHoc/Izenda-AdHoc-TrendChartDataGenerator]] to be used with the chart for loading labels and values.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetChartProperty(Izenda.AdHoc.Report,System.String)
 Gets the value of the property in the specified report using the specified property name. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that is associated with the chart and contains the chart properties.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the property.





Returns:

The value of the chart property that was requested.


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


###Render(Izenda.AdHoc.Report,System.Drawing.Graphics)
 Draws the chart to the provided GDI+ drawing surface. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that will be used to determine several charting options.
* [[System.Drawing.Graphics|http://msdn.microsoft.com/en-us/library/ac148eb3]] g  - The graphics container that the rendered chart will be output to.






---


###Render(Izenda.AdHoc.Report,System.String)
Renders a [[Izenda.AdHoc.DundasChart|/API/Izenda/AdHoc/Izenda-AdHoc-DundasChart]] as a [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] containing the rendered chart image.

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The source [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] used to generate the chart data.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] mwSet  - whether Dundas charts will render their legends below the report.





Returns:

A [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] containing the rendered chart image.


---


###Render(Izenda.AdHoc.Report)


Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report 






---


###Render(Izenda.AdHoc.Report,System.IO.Stream,System.Drawing.Imaging.ImageFormat)
 Draws the HTML for the chart to the specified stream as an image. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that will be used to determine several charting options.
* [[System.IO.Stream|http://msdn.microsoft.com/en-us/library/8f86tw9e]] s  - The [[System.IO.Stream|http://msdn.microsoft.com/en-us/library/8f86tw9e]] containing
* [[System.Drawing.Imaging.ImageFormat|http://msdn.microsoft.com/en-us/library/z6x43tyt]] format  - The output height that the chart will be after it is rendered.





Returns:

The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that contains the HTML of the HighChart object.


---


###SetData(System.Data.DataTable)
Represents a method that loads the data for the chart from the specified [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] using the data generator associated with it.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] dataTable  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] that holds the labels, values, and possibly a separator field for the chart.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


