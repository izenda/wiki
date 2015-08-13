#Click

[[_TOC_]]

##About

**Summary:** <p>Fires when clicking on the plot background. The <code>this</code> keyword refers to the chart object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.</p><p>Information on the clicked spot can be found through <code>event.xAxis</code> and <code>event.yAxis</code>, which are arrays containing the axes of each dimension and each axis' value at the clicked spot. The primary axes are <code>event.xAxis[0]</code> and <code>event.yAxis[0]</code>. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.</p><pre>click: function(e) { console.log( Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value), e.yAxis[0].value )}</pre>  
**Data Type:** [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]  
**Accepted Values:**   
**Default Value:** null  
**Impacted Features:**   
**Purpose:**   
**Usage:**   
**Caveats:**   

