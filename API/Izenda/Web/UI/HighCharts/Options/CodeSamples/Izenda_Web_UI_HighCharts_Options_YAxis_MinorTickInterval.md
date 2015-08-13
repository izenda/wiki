#MinorTickInterval

[[_TOC_]]

##About

**Summary:** <p>Tick interval in scale units for the minor ticks. On a linear axis, if <code>'auto'</code>, the minor tick interval is calculated as a fifth of the tickInterval. If <code>null</code>, minor ticks are not shown.</p><p>On logarithmic axes, the unit is the power of the value. For example, setting the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticks between 1 and 10, 10 and 100 etc. A minorTickInterval of 'auto' on a log axis results in a best guess, attempting to enter approximately 5 minor ticks between each major tick.</p><p>On axes using <a href="#xAxis.categories">categories</a>, minor ticks are not supported.</p>  
**Data Type:** [[System.Nullable|http://msdn.microsoft.com/en-us/library/b3h38hb0]]  
**Accepted Values:**   
**Default Value:** null  
**Impacted Features:**   
**Purpose:**   
**Usage:**   
**Caveats:**   

