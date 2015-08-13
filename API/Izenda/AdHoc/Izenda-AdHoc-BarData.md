#BarData

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[BarName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_BarData_BarName]]| Gets or sets the name used to identify and label the bar. |String.Empty|
|Int32|[[DayOfWeekValue|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_BarData_DayOfWeekValue]]| Gets the numerical representation of the day of the week that the bar's name corresponds to, if any. |0|
|Single|[[DigitalName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_BarData_DigitalName]]| Gets the numeric representation of the name of the bar. An exception is thrown if the name cannot be cast to a number. |null|
|Boolean|[[IsDayOfWeek|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_BarData_IsDayOfWeek]]| Determines whether the name of the bar corresponds with the nam eof any of the seven days of the week based on the current culture information. |False|
|Boolean|[[IsDigita|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_BarData_IsDigita]]| Determines whether the name of the bar consists only of digits and can be treated as a number. |False|
|Boolean|[[IsMonthName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_BarData_IsMonthName]]| Determines whether the name of the bar corresponds with the name of any of the twelve months based on the current culture information. |False|
|Int32|[[MonthValue|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_BarData_MonthValue]]| Gets the numeric representation of the month that the bar's name corresponds to, if any. |0|
|Double[]|[[Values|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_BarData_Values]]|Gets or sets the [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] array of data values that will be displayed for the bar. Multiple values can render as side-by-side bars or stacked bars depending on chart options.|[]|


##Methods

###CompareTo(System.Object)
 Compares bar chart label values to determine the sort order for different bar charts. 

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The input [[Izenda.AdHoc.BarData|/API/Izenda/AdHoc/Izenda-AdHoc-BarData]] object to compare this instance of [[Izenda.AdHoc.BarData|/API/Izenda/AdHoc/Izenda-AdHoc-BarData]] to.





Returns:

A [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] indicating whether the input label value is less than, equal to, or greater than the source label value.


---


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


