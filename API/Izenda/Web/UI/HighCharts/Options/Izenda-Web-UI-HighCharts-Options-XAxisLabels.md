#XAxisLabels

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Nullable|[[Align|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Align]]| What part of the string the given position is anchored to. Can be one of <code>'left'</code>, <code>'center'</code> or <code>'right'</code>. In inverted charts, x axis label alignment and y axis alignment are swapped. Default: center |null|
|Nullable|[[Enabled|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Enabled]]| Enable or disable the axis labels. Default: true |null|
|String|[[Format|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Format]]| A <a href="http://docs.highcharts.com#formatting">format string</a> for the axis label.  |null|
|String|[[Formatter|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Formatter]]| Callback JavaScript function to format the label. The value is given by <code>this.value</code>. Additional properties for <code>this</code> are <code>axis</code>, <code>chart</code>, <code>isFirst</code> and <code>isLast</code>. Defaults to: <pre>function() { return this.value;}</pre>|null|
|Nullable|[[MaxStaggerLines|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_MaxStaggerLines]]||null|
|String|[[Overflow|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Overflow]]| How to handle overflowing labels on horizontal axis. Can be undefined or 'justify'. If 'justify', labels will not render outside the plot area. If there is room to move it, it will be aligned to the edge, else it will be removed. |null|
|Nullable|[[Rotation|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Rotation]]| Rotation of the labels in degrees. Default: 0 |null|
|Nullable|[[StaggerLines|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_StaggerLines]]| Horizontal axes only. The number of lines to spread the labels over to make room or tighter labels. . |null|
|Nullable|[[Step|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Step]]| To show only every <em>n</em>'th label on the axis, set the step to <em>n</em>. Setting the step to 2 shows every other label. |null|
|String|[[Style|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Style]]| CSS styles for the label. Defaults to:<pre>style: { color: '#6D869F', fontWeight: 'bold'}</pre>|null|
|Nullable|[[UseHTML|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_UseHTML]]| Whether to use HTML to render the labels. Using HTML allows advanced formatting, images and reliable bi-directional text rendering. Note that exported images won't respect the HTML, and that HTML won't respect Z-index settings. Default: false |null|
|Nullable|[[X|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_X]]| The x position offset of the label relative to the tick position on the axis. Default: 0 |null|
|Nullable|[[Y|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_Y]]| The y position offset of the label relative to the tick position on the axis. Default: 0 |null|
|Nullable|[[ZIndex|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_XAxisLabels_ZIndex]]| The Z index for the axis labels. Default: 7 |null|


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


