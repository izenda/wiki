#Formatter

[[_TOC_]]

##About

**Summary:** <p>Callback function to format the text of the tooltip. Return false to disable tooltip for a specific point on series.</p><p>A subset of HTML is supported. The HTML of the tooltip is parsed and converted to SVG, therefore this isn't a complete HTML renderer. The following tabs are supported: <code>&lt;b&gt;</code>, <code>&lt;strong&gt;</code>, <code>&lt;i&gt;</code>, <code>&lt;em&gt;</code>, <code>&lt;br/&gt;</code>, <code>&lt;span&gt;</code>. Spans can be styled with a <code>style</code> attribute, but only text-related CSS that is shared with SVG is handled. </p><p>Since version 2.1 the tooltip can be shared between multiple series through the <code>shared</code> option. The available data in the formatter differ a bit depending on whether the tooltip is shared or not. In a shared tooltip, all properties except <code>x</code>, which is common for all points, are kept in an array, <code>this.points</code>.</p><p>Available data are:</p><dl><dt>this.percentage (not shared) / this.points[i].percentage (shared)</dt><dd>Stacked series and pies only. The point's percentage of the total.</dd><dt>this.point (not shared) / this.points[i].point (shared)</dt><dd>The point object. The point name, if defined, is available through <code>this.point.name</code>.</dd><dt>this.points</dt><dd>In a shared tooltip, this is an array containing all other properties for each point.</dd><dt>this.series (not shared) / this.points[i].series (shared)</dt><dd>The series object. The series name is available through <code>this.series.name</code>.</dd><dt>this.total (not shared) / this.points[i].total (shared)</dt><dd>Stacked series only. The total value at this point's x value.</dd><dt>this.x</dt><dd>The x value. This property is the same regardless of the tooltip being shared or not.</dd><dt>this.y (not shared) / this.points[i].y (shared)</dt><dd>The y value.</dd></dl>  
**Data Type:** [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]  
**Accepted Values:**   
**Default Value:** null  
**Impacted Features:**   
**Purpose:**   
**Usage:**   
**Caveats:**   

