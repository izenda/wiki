#PlotOptionsWaterfall

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Nullable|[[AllowPointSelect|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_AllowPointSelect]]| Allow this series' points to be selected by clicking on the markers, bars or pie slices. Default: false |null|
|Animation|[[Animation|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Animation]]|<p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href="#chart.animation">chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or<code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notablythe jQuery UI suite. See <a href="http://api.jquery.com/animate/">the jQuery docs</a>. When using MooTools as the general framework, use the property name <code>transition</code> instead of <code>easing</code>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.</p> Default: true |null|
|Nullable|[[BorderColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_BorderColor]]| The color of the border of each waterfall column. Default: #333333 |null|
|Nullable|[[BorderRadius|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_BorderRadius]]| The corner radius of the border surronding each column or bar. Default: 0 |null|
|Nullable|[[BorderWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_BorderWidth]]| The width of the border surronding each column or bar. Default: 1 |null|
|Nullable|[[Color|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Color]]| The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the <code>options.colors</code> array. |null|
|Nullable|[[ColorByPoint|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_ColorByPoint]]| When using automatic point colors pulled from the <code>options.colors</code> collection, this option determines whether the chart should receive one color per series or one color per point. Default: false |null|
|Color[]|[[Colors|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Colors]]| A series specific or series type specific color set to apply instead of the global <a href="#colors">colors</a> when <a href="#plotOptions.column.colorByPoint">colorByPoint</a> is true. |null|
|Nullable|[[Cursor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Cursor]]| You can set the cursor to 'pointer' if you have click events attached to the series, to signal to the user that the points and lines can be clicked. |null|
|Nullable|[[DashStyle|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_DashStyle]]| A name for the dash style to use for the line connecting the columns of the waterfall series. Possible values: <ul><li>Solid</li><li>ShortDash</li><li>ShortDot</li><li>ShortDashDot</li><li>ShortDashDotDot</li><li>Dot</li><li>Dash</li><li>LongDash</li><li>DashDot</li><li>LongDashDot</li><li>LongDashDotDot</li></ul>. Default: Dot |null|
|PlotOptionsWaterfallDataLabels|[[DataLabels|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_DataLabels]]||null|
|Nullable|[[EnableMouseTracking|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_EnableMouseTracking]]| Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance. Default: true |null|
|PlotOptionsWaterfallEvents|[[Events|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Events]]||null|
|Nullable|[[Grouping|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Grouping]]| Whether to group non-stacked columns or to let them render independent of each other. Non-grouped columns will be laid out individually and overlap each other. Default: true |null|
|Nullable|[[GroupPadding|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_GroupPadding]]| Padding between each value groups, in x axis units. Default: 0.2 |null|
|String|[[Id|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Id]]| An id for the series. This can be used after render time to get a pointer to the series object through <code>chart.get()</code>. |null|
|Nullable|[[LineColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_LineColor]]| The color of the line that connects columns in a waterfall series. Default: #333333 |null|
|String|[[LinkedTo|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_LinkedTo]]| The <a href="#series.id">id</a> of another series to link to. Additionally, the value can be ':previous' to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series. |null|
|Nullable|[[MinPointLength|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_MinPointLength]]| The minimal height for a column or width for a bar. By default, 0 values are not shown. To visualize a 0 (or close to zero) point, set the minimal point length to a pixel value like 3. In stacked column charts, minPointLength might not be respected for tightly packed values. Default: 0 |null|
|PlotOptionsWaterfallPoint|[[Point|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Point]]| Properties for each single point |null|
|Nullable|[[PointInterval|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_PointInterval]]|<p>If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.</p>. Default: 1 |null|
|Nullable|[[PointPadding|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_PointPadding]]| Padding between each column or bar, in x axis units. Default: 0.1 |null|
|Nullable|[[PointPlacement|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_PointPlacement]]|<p>Possible values: null, 'on', 'between'.</p><p>In a column chart, when pointPlacement is 'on', the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is 'between', the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.</p><p>Defaults to <code>null</code> in cartesian charts, <code>'between'</code> in polar charts.</p>|null|
|Nullable|[[PointRange|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_PointRange]]| The X axis range that each point is valid for. This determines the width of the column. On a categorized axis, the range will be 1 by default (one category unit). On linear and datetime axes, the range will be computed as the distance between the two closest data points. |null|
|PointStart|[[PointStart|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_PointStart]]| If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945. Default: 0 |null|
|Nullable|[[PointWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_PointWidth]]| A pixel value specifying a fixed width for each column or bar. When <code>null</code>, the width is calculated from the <code>pointPadding</code> and <code>groupPadding</code>. |null|
|Nullable|[[Selected|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Selected]]| Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series. Default: false |null|
|Nullable|[[Shadow|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Shadow]]| Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>. Default: false |null|
|Nullable|[[ShowCheckbox|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_ShowCheckbox]]| If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option. Default: false |null|
|Nullable|[[ShowInLegend|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_ShowInLegend]]| Whether to display this particular series or series type in the legend. Default: true |null|
|PlotOptionsWaterfallStates|[[States|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_States]]| A wrapper object for all the series options in specific states. |null|
|Nullable|[[StickyTracking|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_StickyTracking]]| Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the tooltip will be hidden when moving the mouse between series. Default: true |null|
|Nullable|[[Threshold|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Threshold]]| The Y axis value to serve as the base for the columns, for distinguishing between values above and below a threshold. If <code>null</code>, the columns extend from the padding Y axis minimum. Default: 0 |null|
|PlotOptionsWaterfallTooltip|[[Tooltip|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Tooltip]]| A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. |null|
|Nullable|[[Visible|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_Visible]]| Set the initial visibility of the series. Default: true |null|
|Nullable|[[ZIndex|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsWaterfall_ZIndex]]| Define the z index of the series. |null|


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


