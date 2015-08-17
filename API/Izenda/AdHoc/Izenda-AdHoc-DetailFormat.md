#DetailFormat

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|SqlTypeGroupCollection|[[AllowedTypeGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_DetailFormat_AllowedTypeGroups]]| Gets the collection of SQL types that can accept this format. |null|
|SqlTypeGroup|[[DefaultFor|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_DetailFormat_DefaultFor]]| Gets the display name of the format as it will appear in the list of available formats. |None|
|SqlTypeGroupCollection|[[DisallowedTypeGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_DetailFormat_DisallowedTypeGroups]]| Gets the collection of SQL types that cannot accept this format. |{Binary}|
|String|[[Name|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_DetailFormat_Name]]| Gets the display name of the format as it will appear in the list of available formats. |Link|
|Boolean|[[Visible|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_DetailFormat_Visible]]| Determines whether this format will be visible in the list of formats. |True|


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


###GetOutputDataType(System.Data.DataTable,System.Int32,Izenda.AdHoc.ReportOutputOptions,Izenda.AdHoc.Field)
 Gets which type of output this formatter will produce from the specified parameters. 

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] that is being formatted.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] columnNumber  - The column number of the table that is being formatted.
* [[Izenda.AdHoc.ReportOutputOptions|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputOptions]] options 
* [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] field  - The [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that contains information relevant to the formatter.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the value returned by the formatter.


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

