#ChartItem

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[Advanced|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_Advanced]]| Determines whether the chart item should display as an advanced item on the chart tab of the AdHocReportDesigner. |False|
|Boolean|[[CanBeSorted|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_CanBeSorted]]| Determines whether the sort checkboxes will be displayed for this chart item on the AdHocReportDesigner. |True|
|SqlTypeGroup|[[DefaultAdvancedTypeGroup|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_DefaultAdvancedTypeGroup]]| Gets or sets the SQL type that the separator column starts with when selecting advanced properties on the AdHocReportDesigner. |None|
|StandardAggregateFunctionType|[[DefaultAggregateFunction|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_DefaultAggregateFunction]]| Gets or sets the aggregation function that is the default for this chart item when displaying it on the charts tab of the AdHocReportDesigner. |None|
|String|[[FieldName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_FieldName]]| Gets or sets the text and field name that is associated with the first dropdown menu on this chart item on the AdHocReportDesigner. |String.Empty|
|String|[[Filter|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_Filter]]| Gets or sets the data type that available columns for this chart item will be filtered to on the AdHocReportDesigner. |String.Empty|
|Boolean|[[ForbidAutoSelect|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_ForbidAutoSelect]]| Determines whether or not to allow automatic selection for the column dropdown on advanced selection items on the AdHocReportDesigner. |False|
|Boolean|[[FunctionVisible|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_FunctionVisible]]| Determines whether the function dropdown for this chart item will be displayed. |True|
|String|[[Label|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_Label]]| Gets or sets the text of the label for the item that will be displayed on the charts tab of the AdHocReportDesigner. |String.Empty|
|Boolean|[[NumericOnly|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_NumericOnly]]| Determines whether the type groups that are loaded for this chart item will only consist of numeric types. |False|
|String|[[OnClientChange|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_OnClientChange]]| Gets or sets the javascript function name that runs on the onChange event for the chart item on the AdHocReportDesigner. |null|
|OrderType|[[OrderType|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_OrderType]]| Specifies the default sort order that should be selected for this chart item on the AdHocReportDesigner. |NONE|
|Boolean|[[ShouldBeFormatted|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_ShouldBeFormatted]]| Determines whether the chart item will be able to use formatters other than the default one. |True|
|Boolean|[[ShouldBeSetted|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_ShouldBeSetted]]| Specifies whether the function dropdown for this chart item must be set manually. When true then a placeholder item for the function dropdown is populated first. |True|
|String|[[ValueRanges|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ChartItem_ValueRanges]]||String.Empty|


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


