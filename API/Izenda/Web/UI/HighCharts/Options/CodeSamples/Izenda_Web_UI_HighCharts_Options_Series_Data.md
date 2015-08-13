#Data

[[_TOC_]]

##About

**Summary:**  An array of data points for the series. The points can be given in three ways: <ol><li>An array of numerical values. In this case, the numberical values will be interpreted and y values, and x values will be automatically calculated, either starting at 0 and incrementing by 1, or from <code>pointStart</code> and <code>pointInterval</code> given in the plotOptions. If the axis is has categories, these will be used. This option is not available for range series. Example:<pre>data: [0, 5, 3, 5]</pre></li><li><p>An array of arrays with two values. In this case, the first value is the x value and the second is the y value. If the first value is a string, it is applied as the name of the point, and the x value is incremented following the above rules.</p><p>For range series, the arrays will be interpreted as <code>[x, low, high]</code>. In this cases, the X value can be skipped altogether to make use of <code>pointStart</code> and <code>pointRange</code>.</p> Example:<pre>data: [[5, 2], [6, 3], [8, 2]]</pre></li><li><p>An array of objects with named values. In this case the objects are point configuration objects as seen below.</p><p>Range series values are given by <code>low</code> and <code>high</code>.</p>Example:<pre>data: [{ name: 'Point 1', color: '#00FF00', y: 0}, { name: 'Point 2', color: '#FF00FF', y: 5}]</pre></li></ol>  
**Data Type:** [[Izenda.Web.UI.HighCharts.Helpers.Data|/API/Izenda/Web/UI/HighCharts/Helpers/Izenda-Web-UI-HighCharts-Helpers-Data]]  
**Accepted Values:**   
**Default Value:** null  
**Impacted Features:**   
**Purpose:**   
**Usage:**   
**Caveats:**   

