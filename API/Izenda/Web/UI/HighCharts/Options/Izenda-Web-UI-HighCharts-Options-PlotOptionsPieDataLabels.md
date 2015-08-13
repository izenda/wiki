#PlotOptionsPieDataLabels

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|BackColorOrGradient|[[BackgroundColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_BackgroundColor]]| The background color or gradient for the data label. Defaults to <code>undefined</code>. |null|
|Nullable|[[BorderColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_BorderColor]]| The border color for the data label. Defaults to <code>undefined</code>. |null|
|Nullable|[[BorderRadius|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_BorderRadius]]| The border radius in pixels for the data label. Defaults to <code>0</code>. Default: 0 |null|
|Nullable|[[BorderWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_BorderWidth]]| The border width in pixels for the data label. Defaults to <code>0</code>. Default: 0 |null|
|Nullable|[[Color|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Color]]| The text color for the data labels. Defaults to <code>null</code>. |null|
|Nullable|[[ConnectorColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_ConnectorColor]]| The color of the line connecting the data label to the pie slice. The default color is the same as the point's color. Default: {point.color} |null|
|Nullable|[[ConnectorPadding|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_ConnectorPadding]]| The distance from the data label to the connector. Default: 5 |null|
|Nullable|[[ConnectorWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_ConnectorWidth]]| The width of the line connecting the data label to the pie slice. Default: 1 |null|
|Nullable|[[Crop|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Crop]]| Whether to hide data labels that are outside the plot area. By default, a data label only shows if the point or the data label is within the plot area. Default: true |null|
|Nullable|[[Distance|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Distance]]| The distance of the data label from the pie's edge. Negative numbers put the data label on top of the pie slices. Connectors are only shown for data labels outside the pie. Default: 30 |null|
|Nullable|[[Enabled|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Enabled]]| Enable or disable the data labels. Default: true |null|
|String|[[Format|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Format]]| A <a href="http://docs.highcharts.com/#formatting">format string</a> for the data label. Available variables are the same as for <code>formatter</code>. Default: {y} |null|
|String|[[Formatter|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Formatter]]| Callback JavaScript function to format the data label. Available data are:<table><tbody><tr><td><code>this.percentage</code></td><td>Stacked series and pies only. The point's percentage of the total.</td></tr><tr><td><code>this.point</code></td><td>The point object. The point name, if defined, is available through <code>this.point.name</code>.</td></tr><tr><td><code>this.series</code>:</td><td>The series object. The series name is available through <code>this.series.name</code>.</td></tr><tr><td><code>this.total</code></td><td>Stacked series only. The total value at this point's x value.</td></tr><tr><td><code>this.x</code>:</td><td>The y value.</td></tr><tr><td><code>this.y</code>:</td><td>The y value.</td></tr></tbody></table>|null|
|Nullable|[[Inside|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Inside]]| For points with an extent, like columns, whether to align the data label inside the box or to the actual value point. Defaults to <code>false</code> in most cases, <code>true</code> in stacked columns. |null|
|Nullable|[[Padding|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Padding]]| When either the <code>borderWidth</code> or the <code>backgroundColor</code> is set, this is the padding within the box. Defaults to <code>2</code>. Default: 2 |null|
|Nullable|[[Rotation|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Rotation]]| Text rotation in degrees. Defaults to <code>0</code>. Default: 0 |null|
|Nullable|[[Shadow|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Shadow]]| The shadow of the box. Works best with <code>borderWidth</code> or <code>backgroundColor</code>. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>. Default: false |null|
|Nullable|[[SoftConnector|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_SoftConnector]]| Whether to render the connector as a soft arc or a line with sharp break. Default: true |null|
|String|[[Style|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Style]]| Styles for the label. |null|
|Nullable|[[UseHTML|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_UseHTML]]| Whether to use HTML to render the labels. Using HTML allows advanced formatting, images and reliable bi-directional text rendering. Note that exported images won't respect the HTML, and that HTML won't respect Z-index settings. Default: false |null|
|Nullable|[[VerticalAlign|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_VerticalAlign]]| The vertical alignment of a data label. Can be one of <code>top</code>, <code>middle</code> or <code>bottom</code>. The default value depends on the data, for instance in a column chart, the label is above positive values and below negative values. |null|
|Nullable|[[X|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_X]]| The x position offset of the label relative to the point. Defaults to <code>0</code>. Default: 0 |null|
|Nullable|[[Y|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_Y]]| The y position offset of the label relative to the point. Defaults to <code>-6</code>. Default: -6 |null|
|Nullable|[[ZIndex|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsPieDataLabels_ZIndex]]| The Z index of the data labels. The default Z index puts it above the series. Use a Z index of 2 to display it behind the series. Default: 6 |null|


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


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


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


