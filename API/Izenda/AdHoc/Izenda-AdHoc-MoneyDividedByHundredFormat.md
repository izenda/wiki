#MoneyDividedByHundredFormat

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|SqlTypeGroupCollection|[[AllowedTypeGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MoneyDividedByHundredFormat_AllowedTypeGroups]]| Gets the collection of SQL types that can accept this format. |{Numeric,Money,<br>Real}|
|SqlTypeGroup|[[DefaultFor|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MoneyDividedByHundredFormat_DefaultFor]]| Gets the SQL type that this format will be the default format for. |None|
|SqlTypeGroupCollection|[[DisallowedTypeGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MoneyDividedByHundredFormat_DisallowedTypeGroups]]| Gets the collection of SQL types that cannot accept this format. |null|
|String|[[Name|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MoneyDividedByHundredFormat_Name]]| Gets the display name of the format as it will appear in the list of available formats. |$/100|
|Boolean|[[Visible|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MoneyDividedByHundredFormat_Visible]]| Determines whether this format will be visible in the list of formats. |True|


##Methods

###CreateFormatters()
 Initializes the formatter that will perform the work on the results. 





Returns:

The [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] collection associated with this format.


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


