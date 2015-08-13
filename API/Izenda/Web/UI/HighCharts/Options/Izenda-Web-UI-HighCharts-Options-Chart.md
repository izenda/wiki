#Chart

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Nullable|[[AlignTicks|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_AlignTicks]]| When using multiple axis, the ticks of two or more opposite axes will automatically be aligned by adding ticks to the axis or axes with the least ticks. This can be prevented by setting <code>alignTicks</code> to false. If the grid lines look messy, it's a good idea to hide them for the secondary axis by setting <code>gridLineWidth</code> to 0. Default: true |null|
|Animation|[[Animation|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Animation]]|<p>Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the initial series animation, see <a class="internal" href="#plotOptions.series.animation">plotOptions.series.animation</a>.</p><p>The animation can either be set as a boolean or a configuration object. If <code>true</code>, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported: </p><dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or <code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. See <a href="http://api.jquery.com/animate/">the jQuery docs</a>. When using MooTools as the general framework, use the property name <code>transition</code> instead of <code>easing</code>.</dd></dl>. Default: true |null|
|BackColorOrGradient|[[BackgroundColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_BackgroundColor]]| The background color or gradient for the outer chart area. Default: #FFFFFF |null|
|Nullable|[[BorderColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_BorderColor]]| The color of the outer chart border. The border is painted using vector graphic techniques to allow rounded corners. Default: #4572A7 |null|
|Nullable|[[BorderRadius|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_BorderRadius]]| The corner radius of the outer chart border. In export, the radius defaults to 0. Default: 5 |null|
|Nullable|[[BorderWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_BorderWidth]]| The pixel width of the outer chart border. The border is painted using vector graphic techniques to allow rounded corners. Default: 0 |null|
|String|[[ClassName|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_ClassName]]| A CSS class name to apply to the charts container <code>div</code>, allowing unique CSS styling for each chart. |null|
|Nullable|[[DefaultSeriesType|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_DefaultSeriesType]]| Alias of <code>type</code>. Default: line |null|
|ChartEvents|[[Events|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Events]]| Event listeners for the chart. |null|
|Nullable|[[ForceSize|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_ForceSize]]||null|
|Nullable|[[Height|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Height]]| An explicit height for the chart. By default the height is calculated from the offset height of the containing element, or 400 pixels if the containing element's height is 0. |null|
|Nullable|[[IgnoreHiddenSeries|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_IgnoreHiddenSeries]]| If true, the axes will scale to the remaining visible series once one series is hidden. If false, hiding and showing a series will not affect the axes or the other series. For stacks, once one series within the stack is hidden, the rest of the stack will close in around it even if the axis is not affected. Default: true |null|
|Nullable|[[Inverted|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Inverted]]| Whether to invert the axes so that the x axis is vertical and y axis is horizontal. When true, the x axis is reversed by default. If a bar series is present in the chart, it will be inverted automatically. Default: false |null|
|Int32[]|[[Margin|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Margin]]|<p>The margin between the outer edge of the chart and the plot area. The numbers in the array designate top, right, bottom and left respectively. Use the options <code>marginTop</code>, <code>marginRight</code>, <code>marginBottom</code> and <code>marginLeft</code> for shorthand setting of one option.</p><p>Since version 2.1, the margin is 0 by default. The actual space is dynamically calculated from the offset of axis labels, axis title, title, subtitle and legend in addition to the <code>spacingTop</code>, <code>spacingRight</code>, <code>spacingBottom</code> and <code>spacingLeft</code> options.</p> Defaults to <code>[null]</code>. |null|
|Nullable|[[MarginBottom|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_MarginBottom]]| The margin between the bottom outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingBottom</code>. |null|
|Nullable|[[MarginLeft|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_MarginLeft]]| The margin between the left outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingLeft</code>. |null|
|Nullable|[[MarginRight|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_MarginRight]]| The margin between the right outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingRight</code>. |null|
|Nullable|[[MarginTop|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_MarginTop]]| The margin between the top outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also <code>spacingTop</code>. |null|
|String|[[PinchType|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_PinchType]]| Equivalent to <a href="#chart.zoomType">zoomType</a>, but for multitouch gestures only. By default, the <code>pinchType</code> is the same as the <code>zoomType</code> setting. However, pinching can be enabled separately in some cases, for example in stock charts where a mouse drag pans the chart, while pinching is enabled. Default: null |null|
|BackColorOrGradient|[[PlotBackgroundColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_PlotBackgroundColor]]| The background color or gradient for the plot area. |null|
|String|[[PlotBackgroundImage|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_PlotBackgroundImage]]| The URL for an image to use as the plot background. To set an image as the background for the entire chart, set a CSS background image to the container element. |null|
|Nullable|[[PlotBorderColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_PlotBorderColor]]| The color of the inner chart or plot area border. Default: #C0C0C0 |null|
|Nullable|[[PlotBorderWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_PlotBorderWidth]]| The pixel width of the plot area border. Default: 0 |null|
|Nullable|[[PlotShadow|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_PlotShadow]]| Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>. Default: false |null|
|Nullable|[[Polar|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Polar]]| When true, cartesian charts like line, spline, area and column are transformed into the polar coordinate system. Requires <code>highcharts-more.js</code>. Default: false |null|
|Nullable|[[Reflow|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Reflow]]| Whether to reflow the chart to fit the width of the container div on resizing the window. Default: true |null|
|ChartResetZoomButton|[[ResetZoomButton|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_ResetZoomButton]]| The button that appears after a selection zoom, allowing the user to reset zoom. |null|
|Nullable|[[SelectionMarkerFill|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_SelectionMarkerFill]]| The background color of the marker square when selecting (zooming in on) an area of the chart. Default: rgba(69,114,167,0.25) |null|
|Nullable|[[Shadow|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Shadow]]| Whether to apply a drop shadow to the outer chart area. Requires that backgroundColor be set. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>. Default: false |null|
|Nullable|[[ShowAxes|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_ShowAxes]]| Whether to show the axes initially. This only applies to empty charts where series are added dynamically, as axes are automatically added to cartesian series. Default: false |null|
|Nullable|[[SpacingBottom|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_SpacingBottom]]|<p>The space between the bottom edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).</p> . Default: 15 |null|
|Nullable|[[SpacingLeft|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_SpacingLeft]]|<p>The space between the left edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).</p> . Default: 10 |null|
|Nullable|[[SpacingRight|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_SpacingRight]]|<p>The space between the right edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).</p> . Default: 10 |null|
|Nullable|[[SpacingTop|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_SpacingTop]]|<p>The space between the top edge of the chart and the content (plot area, axis title and labels, title, subtitle or legend in top position).</p> . Default: 10 |null|
|String|[[Style|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Style]]| Additional CSS styles to apply inline to the container <code>div</code>. Note that since the default font styles are applied in the renderer, it is ignorant of the individual chart options and must be set globally. Defaults to:<pre>style: { fontFamily: ''Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helvetica, sans-serif', // default font fontSize: '12px'}</pre>|null|
|Nullable|[[Type|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Type]]| The default series type for the chart. Can be one of line, spline, area, areaspline, column, bar, pie and scatter. From version 2.3, <code>arearange</code>, <code>areasplinerange</code> and <code>columnrange</code> are supported with the highcharts-more.js component. Default: line |null|
|Nullable|[[Width|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_Width]]| An explicit width for the chart. By default the width is calculated from the offset width of the containing element. |null|
|Nullable|[[ZoomType|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Chart_ZoomType]]| Decides in what dimentions the user can zoom by dragging the mouse. Can be one of <code>x</code>, <code>y</code> or <code>xy</code>. |null|


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


