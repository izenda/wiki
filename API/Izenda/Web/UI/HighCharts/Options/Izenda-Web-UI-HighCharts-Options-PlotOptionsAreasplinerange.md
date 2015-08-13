#PlotOptionsAreasplinerange

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Nullable|[[AllowPointSelect|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_AllowPointSelect]]| Allow this series' points to be selected by clicking on the markers, bars or pie slices. Default: false |null|
|Animation|[[Animation|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Animation]]|<p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href="#chart.animation">chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or<code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notablythe jQuery UI suite. See <a href="http://api.jquery.com/animate/">the jQuery docs</a>. When using MooTools as the general framework, use the property name <code>transition</code> instead of <code>easing</code>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.</p> Default: true |null|
|Nullable|[[Color|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Color]]| The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the <code>options.colors</code> array. |null|
|Nullable|[[ConnectNulls|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_ConnectNulls]]| Whether to connect a graph line across null points. Default: false |null|
|Nullable|[[CropThreshold|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_CropThreshold]]| When the series contains less points than the crop threshold, all points are drawn, event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series. . Default: 300 |null|
|Nullable|[[Cursor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Cursor]]| You can set the cursor to 'pointer' if you have click events attached to the series, to signal to the user that the points and lines can be clicked. |null|
|Nullable|[[DashStyle|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_DashStyle]]| A name for the dash style to use for the graph. Applies only to series type having a graph, like <code>line</code>, <code>spline</code>, <code>area</code> and <code>scatter</code> in case it has a <code>lineWidth</code>. The value for the <code>dashStyle</code> include: <ul><li>Solid</li><li>ShortDash</li><li>ShortDot</li><li>ShortDashDot</li><li>ShortDashDotDot</li><li>Dot</li><li>Dash</li><li>LongDash</li><li>DashDot</li><li>LongDashDot</li><li>LongDashDotDot</li></ul>. |null|
|PlotOptionsAreasplinerangeDataLabels|[[DataLabels|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_DataLabels]]| Extended data labels for range series types. Range series data labels have no <code>x</code> and <code>y</code> options. Instead, they have <code>xLow</code>, <code>xHigh</code>, <code>yLow</code> and <code>yHigh</code> options to allow the higher and lower data label sets individually.  |null|
|Nullable|[[EnableMouseTracking|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_EnableMouseTracking]]| Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Default: true |null|
|PlotOptionsAreasplinerangeEvents|[[Events|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Events]]||null|
|BackColorOrGradient|[[FillColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_FillColor]]| Fill color or gradient for the area. When <code>null</code>, the series' <code>color</code> is used with the series' <code>fillOpacity</code>. |null|
|Nullable|[[FillOpacity|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_FillOpacity]]| Fill opacity for the area. Default: 0.75 |null|
|String|[[Id|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Id]]| An id for the series. This can be used after render time to get a pointer to the series object through <code>chart.get()</code>. |null|
|Nullable|[[LineColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_LineColor]]| A separate color for the graph line. By default the line takes the <code>color</code> of the series, but the lineColor setting allows setting a separate color for the line without altering the <code>fillColor</code>. |null|
|Nullable|[[LineWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_LineWidth]]| Pixel width of the arearange graph line. Default: 1 |null|
|String|[[LinkedTo|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_LinkedTo]]| The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ':previous' to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series. |null|
|Nullable|[[NegativeColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_NegativeColor]]| The color for the parts of the graph or points that are below the <a href="#plotOptions.series.threshold">threshold</a>. Default: null |null|
|Nullable|[[NegativeFillColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_NegativeFillColor]]| A separate color for the negative part of the area. |null|
|PlotOptionsAreasplinerangePoint|[[Point|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Point]]| Properties for each single point |null|
|Nullable|[[PointInterval|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_PointInterval]]|<p>If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.</p>. Default: 1 |null|
|Nullable|[[PointPlacement|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_PointPlacement]]|<p>Possible values: null, 'on', 'between'.</p><p>In a column chart, when pointPlacement is 'on', the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is 'between', the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.</p><p>Defaults to <code>null</code> in cartesian charts, <code>'between'</code> in polar charts.</p>|null|
|PointStart|[[PointStart|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_PointStart]]| If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Default: 0 |null|
|Nullable|[[Selected|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Selected]]| Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series. Default: false |null|
|Nullable|[[Shadow|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Shadow]]| Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.  Default: false |null|
|Nullable|[[ShowCheckbox|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_ShowCheckbox]]| If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option. Default: false |null|
|Nullable|[[ShowInLegend|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_ShowInLegend]]| Whether to display this particular series or series type in the legend. Default: true |null|
|Nullable|[[Stacking|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Stacking]]| Whether to stack the values of each series on top of each other. Possible values are null to disable, 'normal' to stack by value or 'percent'. |null|
|PlotOptionsAreasplinerangeStates|[[States|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_States]]| A wrapper object for all the series options in specific states. |null|
|Nullable|[[StickyTracking|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_StickyTracking]]| Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the tooltip will be hidden when moving the mouse between series. Default: true |null|
|PlotOptionsAreasplinerangeTooltip|[[Tooltip|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Tooltip]]| A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. |null|
|Nullable|[[TrackByArea|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_TrackByArea]]| Whether the whole area or just the line should respond to mouseover tooltips and other mouse or touch events. Default: true |null|
|Nullable|[[TurboThreshold|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_TurboThreshold]]| When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Default: 1000 |null|
|Nullable|[[Visible|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_Visible]]| Set the initial visibility of the series. Default: true |null|
|Nullable|[[ZIndex|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsAreasplinerange_ZIndex]]| Define the z index of the series. |null|


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


