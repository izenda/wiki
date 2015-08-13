#Selection

[[_TOC_]]

##About

**Summary:** <p>Fires when an area of the chart has been selected. Selection is enabled by setting the chart's zoomType. The <code>this</code> keyword refers to the chart object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts. The default action for the selection event is to zoom the chart to the selected area. It can be prevented by calling <code>event.preventDefault()</code>.</p><p>Information on the selected area can be found through <code>event.xAxis</code> and <code>event.yAxis</code>, which are arrays containing the axes of each dimension and each axis' min and max values. The primary axes are <code>event.xAxis[0]</code> and <code>event.yAxis[0]</code>. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.</p><pre>selection: function(event) { // log the min and max of the primary, datetime x-axis console.log( Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].min), Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].max) ); // log the min and max of the y axis console.log(event.yAxis[0].min, event.yAxis[0].max);}</pre>  
**Data Type:** [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]  
**Accepted Values:**   
**Default Value:** null  
**Impacted Features:**   
**Purpose:**   
**Usage:**   
**Caveats:**   

