#Legend

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Nullable|[[Align|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Align]]| The horizontal alignment of the legend box within the chart area. Default: center |null|
|BackColorOrGradient|[[BackgroundColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_BackgroundColor]]| The background color of the legend, filling the rounded corner border. |null|
|Nullable|[[BorderColor|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_BorderColor]]| The color of the drawn border around the legend. Default: #909090 |null|
|Nullable|[[BorderRadius|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_BorderRadius]]| The border corner radius of the legend. Default: 5 |null|
|Nullable|[[BorderWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_BorderWidth]]| The width of the drawn border around the legend. Default: 1 |null|
|Nullable|[[Enabled|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Enabled]]| Enable or disable the legend. Default: true |null|
|Nullable|[[Floating|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Floating]]| When the legend is floating, the plot area ignores it and is allowed to be placed below it. Default: false |null|
|String|[[ItemHiddenStyle|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_ItemHiddenStyle]]| CSS styles for each legend item when the corresponding series or point is hidden. Properties are inherited from <code>style</code> unless overridden here. Defaults to:<pre>itemHiddenStyle: { color: '#CCC'}</pre>|null|
|String|[[ItemHoverStyle|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_ItemHoverStyle]]| CSS styles for each legend item in hover mode. Properties are inherited from <code>style</code> unless overridden here. Defaults to:<pre>itemHoverStyle: { color: '#000'}</pre>|null|
|Nullable|[[ItemMarginBottom|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_ItemMarginBottom]]| The pixel bottom margin for each legend item. Default: 0 |null|
|Nullable|[[ItemMarginTop|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_ItemMarginTop]]| The pixel top margin for each legend item. Default: 0 |null|
|String|[[ItemStyle|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_ItemStyle]]| CSS styles for each legend item. Defaults to:<pre>itemStyle: { cursor: 'pointer', color: '#274b6d', fontSize: '12px'}</pre>|null|
|Nullable|[[ItemWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_ItemWidth]]| The width for each legend item. This is useful in a horizontal layout with many items when you want the items to align vertically. . |null|
|String|[[LabelFormat|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_LabelFormat]]| A <a href="http://docs.highcharts.com#formatting">format string</a> for each legend label. Available variables relates to properties on the series, or the point in case of pies. Default: {name} |null|
|String|[[LabelFormatter|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_LabelFormatter]]| Callback function to format each of the series' labels. The <em>this</em> keyword refers to the series object, or the point object in case of pie charts. By default the series or point name is printed. |null|
|Nullable|[[Layout|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Layout]]| The layout of the legend items. Can be one of 'horizontal' or 'vertical'. Default: horizontal |null|
|Nullable|[[LineHeight|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_LineHeight]]| Line height for the legend items. Deprecated as of 2.1. Instead, the line height for each item can be set using itemStyle.lineHeight, and the padding between items using itemMarginTop and itemMarginBottom. Default: 16 |null|
|Nullable|[[Margin|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Margin]]| If the plot area sized is calculated automatically and the legend is not floating, the legend margin is the space between the legend and the axis labels or plot area. Default: 15 |null|
|Nullable|[[MaxHeight|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_MaxHeight]]| Maximum pixel height for the legend. When the maximum height is extended, navigation will show. |null|
|LegendNavigation|[[Navigation|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Navigation]]| Options for the paging or navigation appearing when the legend is overflown. When <a href="#legend.useHTML">legend.useHTML</a> is enabled, navigation is disabled.  |null|
|Nullable|[[Padding|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Padding]]| The inner padding of the legend box. Default: 8 |null|
|Nullable|[[Reversed|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Reversed]]| Whether to reverse the order of the legend items compared to the order of the series or points as defined in the configuration object. Default: false |null|
|Nullable|[[Rtl|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Rtl]]| Whether to show the symbol on the right side of the text rather than the left side. This is common in Arabic and Hebraic. Default: false |null|
|Nullable|[[Shadow|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Shadow]]| Whether to apply a drop shadow to the legend. A <code>backgroundColor</code> also needs to be applied for this to take effect. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>. Default: false |null|
|String|[[Style|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Style]]| CSS styles for the legend area. In the 1.x versions the position of the legend area was determined by CSS. In 2.x, the position is determined by properties like <code>align</code>, <code>verticalAlign</code>, <code>x</code> and <code>y</code>, but the styles are still parsed for backwards compatibility. |null|
|Nullable|[[SymbolPadding|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_SymbolPadding]]| The pixel padding between the legend item symbol and the legend item text. Default: 5 |null|
|Nullable|[[SymbolWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_SymbolWidth]]| The pixel width of the legend item symbol. Default: 30 |null|
|LegendTitle|[[Title|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Title]]| A title to be added on top of the legend. |null|
|Nullable|[[UseHTML|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_UseHTML]]|<p>Whether to use HTML to render the legend item texts. Using HTML allows for advanced formatting, images and reliable bi-directional text rendering. Note that exported images won't respect the HTML, and that HTML won't respect Z-index settings. When using HTML, <a href="#legend.navigation">legend.navigation</a> is disabled.</p> Default: false |null|
|Nullable|[[VerticalAlign|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_VerticalAlign]]| The vertical alignment of the legend box. Can be one of 'top', 'middle' or 'bottom'. Vertical position can be further determined by the <code>y</code> option. Default: bottom |null|
|Nullable|[[Width|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Width]]| The width of the legend box, not including style.padding. . |null|
|Nullable|[[X|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_X]]| The x offset of the legend relative to it's horizontal alignment <code>align</code> within chart.spacingLeft and chart.spacingRight. Negative x moves it to the left, positive x moves it to the right. The default value of 15 together with <code>align: 'center'</code> puts it in the center of the plot area. Default: 0 |null|
|Nullable|[[Y|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_Legend_Y]]| The vertical offset of the legend relative to it's vertical alignment <code>verticalAlign</code> within chart.spacingTop and chart.spacingBottom. Negative y moves it up, positive y moves it down. Default: 0 |null|


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


