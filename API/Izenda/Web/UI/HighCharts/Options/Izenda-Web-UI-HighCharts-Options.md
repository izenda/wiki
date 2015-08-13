#Izenda.Web.UI.HighCharts.Options

[[_TOC_]]

##[[Izenda.Web.UI.HighCharts.Options.AreaChartOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-AreaChartOptions]]

##[[Izenda.Web.UI.HighCharts.Options.AxisLabelsOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-AxisLabelsOptions]]

##[[Izenda.Web.UI.HighCharts.Options.AxisOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-AxisOptions]]

##[[Izenda.Web.UI.HighCharts.Options.Chart|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Chart]]
 Options regarding the chart area and plot area as well as general chart options. 
##[[Izenda.Web.UI.HighCharts.Options.ChartEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-ChartEvents]]
 Event listeners for the chart. 
##[[Izenda.Web.UI.HighCharts.Options.ChartOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-ChartOptions]]

##[[Izenda.Web.UI.HighCharts.Options.ChartResetZoomButton|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-ChartResetZoomButton]]
 The button that appears after a selection zoom, allowing the user to reset zoom. 
##[[Izenda.Web.UI.HighCharts.Options.Colors|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Colors]]
<p>An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again. Defaults to:<pre>colors: [ '#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce', '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a']</pre><p>In Highcharts 2.x, the default colors were:<pre>colors: [ '#4572A7', '#AA4643', '#89A54E', '#80699B', '#3D96AE', '#DB843D', '#92A8CD', '#A47D7C', '#B5CA92']</pre></p></p>
##[[Izenda.Web.UI.HighCharts.Options.Credits|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Credits]]
 Highchart by default puts a credits label in the lower right corner of the chart. This can be changed using these options. 
##[[Izenda.Web.UI.HighCharts.Options.DataLabelsOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-DataLabelsOptions]]

##[[Izenda.Web.UI.HighCharts.Options.Exporting|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Exporting]]
 Options for the exporting module. For an overview on the matter, see <a href="http://docs.highcharts.com/#export-module">the docs</a>. 
##[[Izenda.Web.UI.HighCharts.Options.ExportingButtons|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-ExportingButtons]]
 Options for the export related buttons, print and export. In addition to the default buttons listed here, custom buttons can be added. See <a href="#navigation.buttonOptions">navigation.buttonOptions</a> for general options. 
##[[Izenda.Web.UI.HighCharts.Options.ExportingButtonsContextButton|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-ExportingButtonsContextButton]]
 Options for the export button. 
##[[Izenda.Web.UI.HighCharts.Options.ExportingButtonsExportButton|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-ExportingButtonsExportButton]]
 Options for the export button. 
##[[Izenda.Web.UI.HighCharts.Options.ExportingButtonsPrintButton|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-ExportingButtonsPrintButton]]
 Options for the print button. 
##[[Izenda.Web.UI.HighCharts.Options.FunnelChartOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-FunnelChartOptions]]

##[[Izenda.Web.UI.HighCharts.Options.Global|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Global]]
 Global options that don't apply to each chart. These options, like the <code>lang</code> options, must be set using the <code>Highcharts.setOptions</code> method.<pre>Highcharts.setOptions({ global: { useUTC: false }});</pre>
##[[Izenda.Web.UI.HighCharts.Options.Labels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Labels]]
 HTML labels that can be positioined anywhere in the chart area. 
##[[Izenda.Web.UI.HighCharts.Options.LabelsItems|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-LabelsItems]]
 A HTML label that can be positioined anywhere in the chart area. 
##[[Izenda.Web.UI.HighCharts.Options.Lang|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Lang]]
 Language object. The language object is global and it can't be set on each chart initiation. Instead, use <code>Highcharts.setOptions</code> to set it before any chart is initiated. <pre>Highcharts.setOptions({ lang: { months: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin', 'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'], weekdays: ['Dimanche', 'Lundi', 'Mardi', 'Mercredi', 'Jeudi', 'Vendredi', 'Samedi'] }});</pre>
##[[Izenda.Web.UI.HighCharts.Options.Legend|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Legend]]
 The legend is a box containing a symbol and name for each series item or point item in the chart. 
##[[Izenda.Web.UI.HighCharts.Options.LegendNavigation|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-LegendNavigation]]
 Options for the paging or navigation appearing when the legend is overflown. When <a href="#legend.useHTML">legend.useHTML</a> is enabled, navigation is disabled.  
##[[Izenda.Web.UI.HighCharts.Options.LegendNavigationOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-LegendNavigationOptions]]

##[[Izenda.Web.UI.HighCharts.Options.LegendOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-LegendOptions]]

##[[Izenda.Web.UI.HighCharts.Options.LegendTitle|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-LegendTitle]]
 A title to be added on top of the legend. 
##[[Izenda.Web.UI.HighCharts.Options.LegendTitleOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-LegendTitleOptions]]

##[[Izenda.Web.UI.HighCharts.Options.Loading|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Loading]]
 The loading options control the appearance of the loading screen that covers the plot area on chart operations. This screen only appears after an explicit call to <code>chart.showLoading()</code>. It is a utility for developers to communicate to the end user that something is going on, for example while retrieving new data via an XHR connection. The 'Loading...' text itself is not part of this configuration object, but part of the <code>lang</code> object. 
##[[Izenda.Web.UI.HighCharts.Options.Navigation|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Navigation]]
 A collection of options for buttons and menus appearing in the exporting module. 
##[[Izenda.Web.UI.HighCharts.Options.NavigationButtonOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-NavigationButtonOptions]]
 A collection of options for buttons appearing in the exporting module. 
##[[Izenda.Web.UI.HighCharts.Options.OptionsBase|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-OptionsBase]]

##[[Izenda.Web.UI.HighCharts.Options.Pane|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Pane]]
 Applies only to polar charts and angular gauges. This configuration object holds general options for the combined X and Y axes set. Each xAxis or yAxis can reference the pane by index. 
##[[Izenda.Web.UI.HighCharts.Options.PlotAreaMarkerOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotAreaMarkerOptions]]

##[[Izenda.Web.UI.HighCharts.Options.PlotAreaOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotAreaOptions]]

##[[Izenda.Web.UI.HighCharts.Options.PlotAreaTooltipOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotAreaTooltipOptions]]

##[[Izenda.Web.UI.HighCharts.Options.PlotFunnelOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotFunnelOptions]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptions]]
<p>The plotOptions is a wrapper object for config objects for each series type. The config objects for each series can also be overridden for each series item as given in the series array.</p><p>Configuration options for the series are given in three levels. Options for all series in a chart are given in the <a class="internal" href="#plotOptions.series">plotOptions.series</a> object. Then options for all series of a specific type are given in the plotOptions of that type, for example plotOptions.line. Next, options for one single series are given in <a class="internal" href="#series">the series array</a>.</p>
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArea|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArea]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaMarkerStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaMarkerStates]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaMarkerStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaMarkerStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaMarkerStatesSelect|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaMarkerStatesSelect]]
 The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearange|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearange]]
 The area range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highcharts-more.js</code>. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearangeDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearangeDataLabels]]
 Extended data labels for range series types. Range series data labels have no <code>x</code> and <code>y</code> options. Instead, they have <code>xLow</code>, <code>xHigh</code>, <code>yLow</code> and <code>yHigh</code> options to allow the higher and lower data label sets individually.  
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearangeEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearangeEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearangePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearangePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearangePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearangePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearangeStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearangeStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearangeStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearangeStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearangeStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearangeStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsArearangeTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsArearangeTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaspline|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaspline]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineMarkerStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineMarkerStates]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineMarkerStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineMarkerStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineMarkerStatesSelect|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineMarkerStatesSelect]]
 The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerange|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerange]]
 The area spline range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highcharts-more.js</code>. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerangeDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerangeDataLabels]]
 Extended data labels for range series types. Range series data labels have no <code>x</code> and <code>y</code> options. Instead, they have <code>xLow</code>, <code>xHigh</code>, <code>yLow</code> and <code>yHigh</code> options to allow the higher and lower data label sets individually.  
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerangeEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerangeEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerangePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerangePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerangePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerangePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerangeStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerangeStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerangeStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerangeStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerangeStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerangeStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplinerangeTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplinerangeTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreasplineTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreasplineTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsAreaTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsAreaTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBar|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBar]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBarDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBarDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBarEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBarEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBarPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBarPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBarPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBarPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBarStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBarStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBarStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBarStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBarStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBarStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBarTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBarTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBoxplot|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBoxplot]]
 A box plot is a convenient way of depicting groups of data through their five-number summaries: the smallest observation (sample minimum), lower quartile (Q1), median (Q2), upper quartile (Q3), and largest observation (sample maximum).  
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBoxplotEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBoxplotEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBoxplotPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBoxplotPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBoxplotPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBoxplotPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBoxplotStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBoxplotStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBoxplotStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBoxplotStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBoxplotStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBoxplotStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBoxplotTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBoxplotTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubble|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubble]]
 A bubble series is a three dimensional series type where each point renders an X, Y and Z value. Each points is drawn as a bubble where the position along the X and Y axes mark the X and Y values, and the size of the bubble relates to the Z value. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleMarkerStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleMarkerStates]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleMarkerStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleMarkerStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleMarkerStatesSelect|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleMarkerStatesSelect]]
 The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubblePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubblePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubblePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubblePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsBubbleTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsBubbleTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumn|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumn]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrange|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrange]]
 The column range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highcharts-more.js</code>. To display horizontal bars, set <a href="#chart.inverted">chart.inverted</a> to <code>true</code>. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrangeDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrangeDataLabels]]
 Extended data labels for range series types. Range series data labels have no <code>x</code> and <code>y</code> options. Instead, they have <code>xLow</code>, <code>xHigh</code>, <code>yLow</code> and <code>yHigh</code> options to allow the higher and lower data label sets individually.  
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrangeEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrangeEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrangePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrangePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrangePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrangePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrangeStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrangeStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrangeStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrangeStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrangeStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrangeStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnrangeTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnrangeTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsColumnTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsColumnTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsErrorbar|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsErrorbar]]
 Error bars are a graphical representation of the variability of data and are used on graphs to indicate the error, or uncertainty in a reported measurement.  
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsErrorbarEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsErrorbarEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsErrorbarPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsErrorbarPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsErrorbarPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsErrorbarPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsErrorbarStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsErrorbarStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsErrorbarStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsErrorbarStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsErrorbarStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsErrorbarStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsErrorbarTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsErrorbarTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnel|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnel]]
 Funnel charts are a type of chart often used to visualize stages in a sales project, where the top are the initial stages with the most clients. It requires that the <code>modules/funnel.js</code> file is loaded. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnelDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnelDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnelEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnelEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnelPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnelPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnelPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnelPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnelStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnelStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnelStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnelStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnelStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnelStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsFunnelTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsFunnelTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGauge|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGauge]]
 General plotting options for the gauge series type. Requires <code>highcharts-more.js</code>
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugeDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugeDataLabels]]
 Data labels for the gauge. For gauges, the data labels are enabled by default and shown in a bordered box below the point. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugeDial|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugeDial]]
 Options for the dial or arrow pointer of the gauge. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugeEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugeEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugePivot|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugePivot]]
 Options for the pivot or the center point of the gauge. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugeStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugeStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugeStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugeStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugeStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugeStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsGaugeTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsGaugeTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLine|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLine]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineMarkerStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineMarkerStates]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineMarkerStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineMarkerStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineMarkerStatesSelect|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineMarkerStatesSelect]]
 The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLinePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLinePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLinePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLinePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsLineTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsLineTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsOld|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsOld]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPie|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPie]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPieDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPieDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPieEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPieEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPiePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPiePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPiePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPiePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPieStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPieStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPieStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPieStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPieStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPieStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsPieTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsPieTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatter|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatter]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterMarkerStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterMarkerStates]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterMarkerStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterMarkerStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterMarkerStatesSelect|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterMarkerStatesSelect]]
 The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsScatterTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsScatterTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeries|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeries]]
<p>General options for all series types.</p>
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesMarkerStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesMarkerStates]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesMarkerStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesMarkerStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesMarkerStatesSelect|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesMarkerStatesSelect]]
 The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSeriesTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSeriesTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSpline|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSpline]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineMarkerStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineMarkerStates]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineMarkerStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineMarkerStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineMarkerStatesSelect|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineMarkerStatesSelect]]
 The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplinePoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplinePoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplinePointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplinePointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsSplineTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsSplineTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfall|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfall]]
 Options for the waterfall series type. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfallDataLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfallDataLabels]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfallEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfallEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfallPoint|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfallPoint]]
 Properties for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfallPointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfallPointEvents]]
 Events for each single point 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfallStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfallStates]]
 A wrapper object for all the series options in specific states. 
##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfallStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfallStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfallStatesHoverMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfallStatesHoverMarker]]

##[[Izenda.Web.UI.HighCharts.Options.PlotOptionsWaterfallTooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotOptionsWaterfallTooltip]]
 A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href="#tooltip">tooltip</a>, but only the following properties can be defined on a series level. 
##[[Izenda.Web.UI.HighCharts.Options.PlotSeriesOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PlotSeriesOptions]]

##[[Izenda.Web.UI.HighCharts.Options.Point|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Point]]
 Config options for the individual point as given in series.data. 
##[[Izenda.Web.UI.HighCharts.Options.PointEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PointEvents]]

##[[Izenda.Web.UI.HighCharts.Options.PointMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-PointMarker]]

##[[Izenda.Web.UI.HighCharts.Options.Series|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Series]]
 The actual series to append to the chart. In addition to the members listed below, any member of the <code>plotOptions</code> for that specifictype of plot can be added to a series individually. For example, even though a general<code>lineWidth</code> is specified in <code>plotOptions.series</code>, an individual<code>lineWidth</code> can be specified for each series. 
##[[Izenda.Web.UI.HighCharts.Options.SeriesData|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-SeriesData]]
 An array of data points for the series. The points can be given in three ways: <ol><li>An array of numerical values. In this case, the numberical values will be interpreted and y values, and x values will be automatically calculated, either starting at 0 and incrementing by 1, or from <code>pointStart</code> and <code>pointInterval</code> given in the plotOptions. If the axis is has categories, these will be used. This option is not available for range series. Example:<pre>data: [0, 5, 3, 5]</pre></li><li><p>An array of arrays with two values. In this case, the first value is the x value and the second is the y value. If the first value is a string, it is applied as the name of the point, and the x value is incremented following the above rules.</p><p>For range series, the arrays will be interpreted as <code>[x, low, high]</code>. In this cases, the X value can be skipped altogether to make use of <code>pointStart</code> and <code>pointRange</code>.</p> Example:<pre>data: [[5, 2], [6, 3], [8, 2]]</pre></li><li><p>An array of objects with named values. In this case the objects are point configuration objects as seen below.</p><p>Range series values are given by <code>low</code> and <code>high</code>.</p>Example:<pre>data: [{ name: 'Point 1', color: '#00FF00', y: 0}, { name: 'Point 2', color: '#FF00FF', y: 5}]</pre></li></ol>
##[[Izenda.Web.UI.HighCharts.Options.SeriesDataEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-SeriesDataEvents]]
 Individual point events 
##[[Izenda.Web.UI.HighCharts.Options.SeriesDataMarker|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-SeriesDataMarker]]

##[[Izenda.Web.UI.HighCharts.Options.SeriesDataMarkerStates|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-SeriesDataMarkerStates]]

##[[Izenda.Web.UI.HighCharts.Options.SeriesDataMarkerStatesHover|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-SeriesDataMarkerStatesHover]]

##[[Izenda.Web.UI.HighCharts.Options.SeriesDataMarkerStatesSelect|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-SeriesDataMarkerStatesSelect]]
 The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true. 
##[[Izenda.Web.UI.HighCharts.Options.SeriesOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-SeriesOptions]]

##[[Izenda.Web.UI.HighCharts.Options.Subtitle|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Subtitle]]
 The chart's subtitle 
##[[Izenda.Web.UI.HighCharts.Options.Symbols|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Symbols]]
 An array containing the default symbols for the series point markers. When all  symbols are used, new symbols are pulled from the start again. Defaults to: symbols: [ 'circle',  'diamond',  'square',  'triangle',  'triangle-down' ] 
##[[Izenda.Web.UI.HighCharts.Options.Title|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Title]]
 The chart's main title. 
##[[Izenda.Web.UI.HighCharts.Options.TitleOptions|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-TitleOptions]]

##[[Izenda.Web.UI.HighCharts.Options.Tooltip|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-Tooltip]]
 Options for the tooltip that appears when the user hovers over a series or point. 
##[[Izenda.Web.UI.HighCharts.Options.XAxis|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxis]]
<p>The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis. In case of multiple axes, the xAxis node is an array of configuration objects.</p><p>See <a class="internal" href="#axis-object">the Axis object</a> for programmatic access to the axis.</p>
##[[Izenda.Web.UI.HighCharts.Options.XAxisEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxisEvents]]
 Event handlers for the axis. 
##[[Izenda.Web.UI.HighCharts.Options.XAxisLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxisLabels]]
 The axis labels show the number or category for each tick. 
##[[Izenda.Web.UI.HighCharts.Options.XAxisPlotBands|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxisPlotBands]]
<p>A colored band stretching across the plot area marking an interval on the axis.</p><p>In a gauge, a plot band on the Y axis (value axis) will stretch along the perimiter of the gauge.</p>
##[[Izenda.Web.UI.HighCharts.Options.XAxisPlotBandsLabel|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxisPlotBandsLabel]]
 Text labels for the plot bands 
##[[Izenda.Web.UI.HighCharts.Options.XAxisPlotLines|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxisPlotLines]]
 A line streching across the plot area, marking a specific value on one of the axes. 
##[[Izenda.Web.UI.HighCharts.Options.XAxisPlotLinesLabel|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxisPlotLinesLabel]]
 Text labels for the plot bands 
##[[Izenda.Web.UI.HighCharts.Options.XAxisTitle|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-XAxisTitle]]
 The axis title, showing next to the axis line. 
##[[Izenda.Web.UI.HighCharts.Options.YAxis|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxis]]
<p>The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horiontal axis. In case of multiple axes, the yAxis node is an array of configuration objects.</p><p>See <a class="internal" href="#axis-object">the Axis object</a> for programmatic access to the axis.</p>
##[[Izenda.Web.UI.HighCharts.Options.YAxisEvents|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxisEvents]]

##[[Izenda.Web.UI.HighCharts.Options.YAxisLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxisLabels]]

##[[Izenda.Web.UI.HighCharts.Options.YAxisPlotBands|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxisPlotBands]]

##[[Izenda.Web.UI.HighCharts.Options.YAxisPlotBandsLabel|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxisPlotBandsLabel]]
 Text labels for the plot bands 
##[[Izenda.Web.UI.HighCharts.Options.YAxisPlotLines|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxisPlotLines]]

##[[Izenda.Web.UI.HighCharts.Options.YAxisPlotLinesLabel|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxisPlotLinesLabel]]
 Text labels for the plot bands 
##[[Izenda.Web.UI.HighCharts.Options.YAxisStackLabels|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxisStackLabels]]
 The stack labels show the total value for each bar in a stacked column or bar chart. The label will be placed on top of positive columns and below negative columns. In case of an inverted column chart or a bar chart the label is placed to the right of positive bars and to the left of negative bars. 
##[[Izenda.Web.UI.HighCharts.Options.YAxisTitle|/API/Izenda/Web/UI/HighCharts/Options/Izenda-Web-UI-HighCharts-Options-YAxisTitle]]

