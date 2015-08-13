#ExportingButtonsContextButton

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Nullable|[[Align|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Align]]| Alignment for the buttons. Default: right |null|
|Nullable|[[Enabled|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Enabled]]| Whether to enable buttons. Default: true |null|
|Nullable|[[Height|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Height]]| Pixel height of the buttons. Default: 20 |null|
|MenuItem[]|[[MenuItems|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_MenuItems]]|<p>A collection of config options for the menu items. Each options object consists of a <code>text</code> option which is a string to show in the menu item, as well as an <code>onclick</code> parameter which is a callback function to run on click.</p><p>By default, there is the 'Print' menu item plus one menu item for each of the available export types. Menu items can be customized by defining a new array of items and assigning <code>null</code> to unwanted positions (see override example below).</p>|null|
|String|[[Onclick|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Onclick]]| A click handler callback to use on the button directly instead of the popup menu. |null|
|String|[[Symbol|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Symbol]]| The symbol for the button. Points to a definition function in the <code>Highcharts.Renderer.symbols</code> collection. The default <code>exportIcon</code> function is part of the exporting module. Default: menu |null|
|Nullable|[[SymbolFill|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_SymbolFill]]| See <a class="internal" href="#navigation-buttonOptions">navigation.buttonOptions</a> =&gt; symbolFill. Default: #A8BF77 |null|
|Nullable|[[SymbolSize|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_SymbolSize]]| The pixel size of the symbol on the button. Default: 14 |null|
|Nullable|[[SymbolStroke|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_SymbolStroke]]| The color of the symbol's stroke or line. Default: #666 |null|
|Nullable|[[SymbolStrokeWidth|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_SymbolStrokeWidth]]| The pixel stroke width of the symbol on the button. Default: 1 |null|
|Nullable|[[SymbolX|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_SymbolX]]| The x position of the center of the symbol inside the button. Default: 12.5 |null|
|Nullable|[[SymbolY|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_SymbolY]]| The y position of the center of the symbol inside the button. Default: 10.5 |null|
|String|[[Text|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Text]]| A text string to add to the individual button.  Default: null |null|
|Object|[[Theme|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Theme]]| A configuration object for the button theme. The object accepts SVG properties like <code>stroke-width</code>, <code>stroke</code> and <code>fill</code>. Tri-state button styles are supported by the <code>states.hover</code> and <code>states.select</code> objects. |null|
|Nullable|[[VerticalAlign|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_VerticalAlign]]| The vertical alignment of the buttons. Can be one of 'top', 'middle' or 'bottom'. Default: top |null|
|Nullable|[[Width|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Width]]| The pixel width of the button. Default: 24 |null|
|Nullable|[[X|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_X]]| The horizontal positioin of the button relative to the <code>align</code> option. Default: -10 |null|
|Nullable|[[Y|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_ExportingButtonsContextButton_Y]]| The vertical offset of the button's position relative to its <code>verticalAlign</code>. . Default: 0 |null|


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


