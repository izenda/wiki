#HighchartsConfig

[[_TOC_]]

##Properties

None.


##Methods

###AddJavascripFunction(System.String,System.String,System.String[])
 Add javascript function to the same jQuery document ready where chart is initialized. The functions are added after the chart. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the function.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] body  - The body of the function.
* [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] variables  - The variables of the function.






---


###AddJavascripVariable(System.String,System.String)
 Add the javascript variable to the same jQuery document ready where chart is initialized. Variables are added before the chart. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the variable.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - The value of the variable.






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetChart()







---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetOptions()







---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###InFunction(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name 






---


###InitChart(Izenda.Web.UI.HighCharts.Options.Chart)
 Options regarding the chart area and plot area as well as general chart options. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Chart|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Chart]] chart 






---


###SetCredits(Izenda.Web.UI.HighCharts.Options.Credits)
 Highchart by default puts a credits label in the lower right corner of the chart.  This can be changed using these options. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Credits|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Credits]] credits 






---


###SetExporting(Izenda.Web.UI.HighCharts.Options.Exporting)
 Options for the exporting module. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Exporting|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Exporting]] exporting 






---


###SetLabels(Izenda.Web.UI.HighCharts.Options.Labels)
 HTML labels that can be positioined anywhere in the chart area. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Labels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Labels]] labels 






---


###SetLegend(Izenda.Web.UI.HighCharts.Options.Legend)
 The legend is a box containing a symbol and name for each series item or point item in the chart. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Legend|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Legend]] legend 






---


###SetLoading(Izenda.Web.UI.HighCharts.Options.Loading)
 The loading options control the appearance of the loading screen that covers the plot area on chart operations.  This screen only appears after an explicit call to chart.showLoading(). It is a utility for developers to  communicate to the end user that something is going on, for example while retrieving new data via an XHR connection.  The "Loading..." text itself is not part of this configuration object, but part of the lang object. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Loading|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Loading]] loading 






---


###SetNavigation(Izenda.Web.UI.HighCharts.Options.Navigation)
 A collection of options for buttons and menus appearing in the exporting module. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Navigation|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Navigation]] navigation 






---


###SetOptions(Izenda.Web.UI.HighCharts.Helpers.GlobalOptions)
 Global options that don't apply to each chart. These options, like the lang options, must be set using the Highcharts.setOptions method. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Helpers.GlobalOptions|/API/Izenda/Web/UI/HighCharts/Helpers/Izenda-Web-UI-HighCharts-Helpers-GlobalOptions]] options 






---


###SetPane(Izenda.Web.UI.HighCharts.Options.Pane[])
 Applies only to polar charts and angular gauges. This configuration object holds general options for the combined X and Y axes set. Each xAxis or yAxis can reference the pane by index. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Pane[]|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Pane[]]] paneArray  - Array of panes to set






---


###SetPane(Izenda.Web.UI.HighCharts.Options.Pane)


Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Pane|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Pane]] pane 






---


###SetPlotOptions(Izenda.Web.UI.HighCharts.Options.PlotOptions)
 The plotOptions is a wrapper object for config objects for each series type. The config objects for each series  can also be overridden for each series item as given in the series array. Configuration options for the series are given in three levels. Options for all series in a chart are given in  the plotOptions.series object. Then options for all series of a specific type are given in the plotOptions of  that type, for example plotOptions.line. Next, options for one single series are given in the series array. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.PlotOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptions]] plotOptions 






---


###SetSeries(Izenda.Web.UI.HighCharts.Options.Series)
 The actual series to append to the chart. In addition to the members listed below, any member of the plotOptions  for that specific type of plot can be added to a series individually. For example, even though a general lineWidth  is specified in plotOptions.series, an individual lineWidth can be specified for each series. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Series|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Series]] series 






---


###SetSeries(Izenda.Web.UI.HighCharts.Options.Series[])


Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Series[]|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Series[]]] seriesArray 






---


###SetSubtitle(Izenda.Web.UI.HighCharts.Options.Subtitle)
 The chart's subtitle 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Subtitle|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Subtitle]] subtitle 






---


###SetTitle(Izenda.Web.UI.HighCharts.Options.Title)
 The chart's main title. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Title|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Title]] title 






---


###SetTooltip(Izenda.Web.UI.HighCharts.Options.Tooltip)
 Options for the tooltip that appears when the user hovers over a series or point. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.Tooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Tooltip]] tooltip 






---


###SetXAxis(Izenda.Web.UI.HighCharts.Options.XAxis)
 The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis.  In case of multiple axes, the xAxis node is an array of configuration objects. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.XAxis|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxis]] xAxis 






---


###SetXAxis(Izenda.Web.UI.HighCharts.Options.XAxis[])


Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.XAxis[]|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxis[]]] xAxisArray 






---


###SetYAxis(Izenda.Web.UI.HighCharts.Options.YAxis)
 The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horiontal axis.  In case of multiple axes, the yAxis node is an array of configuration objects. 

Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.YAxis|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxis]] yAxis 






---


###SetYAxis(Izenda.Web.UI.HighCharts.Options.YAxis[])


Parameters: 

* [[Izenda.Web.UI.HighCharts.Options.YAxis[]|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxis[]]] yAxisArray 






---


###ToHtmlString()







---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


