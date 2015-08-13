#PlotOptionsArearangePointEvents

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[Click|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsArearangePointEvents_Click]]|<p></p>Fires when a point is clicked. The <code>this</code> keyword refers to the point object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.<p></p><p>If the <code>series.allowPointSelect</code> option is true, the default action for the point's click event is to toggle the point's select state. Returning <code>false</code> cansels this action.</p>|null|
|String|[[MouseOut|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsArearangePointEvents_MouseOut]]| Fires when the mouse leaves the area close to the point. The <code>this</code> keyword refers to the point object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts. |null|
|String|[[MouseOver|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsArearangePointEvents_MouseOver]]| Fires when the mouse enters the area close to the point. The <code>this</code> keyword refers to the point object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts. |null|
|String|[[Remove|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsArearangePointEvents_Remove]]| Fires when the point is removed using the <code>.remove()</code> method. The <code>this</code> keyword refers to the point object itself. One parameter, <code>event</code>, is passed to the function. Returning <code>false</code> cancels the operation. |null|
|String|[[Select|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsArearangePointEvents_Select]]| Fires when the point is selected either programatically or following a click on the point. The <code>this</code> keyword refers to the point object itself. One parameter, <code>event</code>, is passed to the function. Returning <code>false</code> cancels the operation. |null|
|String|[[Unselect|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsArearangePointEvents_Unselect]]| Fires when the point is unselected either programatically or following a click on the point. The <code>this</code> keyword refers to the point object itself. One parameter, <code>event</code>, is passed to the function. Returning <code>false</code> cancels the operation. |null|
|String|[[Update|/API/Izenda/Web/UI/HighCharts/Options/CodeSamples/Izenda_Web_UI_HighCharts_Options_PlotOptionsArearangePointEvents_Update]]| Fires when the point is updated programmatically through the <code>.update()</code> method. The <code>this</code> keyword refers to the point object itself. One parameter, <code>event</code>, is passed to the function. The new point options can be accessed through <code>event.options</code>. Returning <code>false</code> cancels the operation. |null|


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


