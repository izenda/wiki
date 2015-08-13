#GaugeBaseFormatter

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|IGaugeDrawer|[[GaugeDrawer|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_GaugeBaseFormatter_GaugeDrawer]]| Represents an strategy for rendering the gauge to the screen. |inherited from concrete class|


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###Format(System.Data.DataTable,System.Int32,System.Int32,Izenda.AdHoc.Field,System.Data.DataTable,Izenda.AdHoc.Field)
 Formats the data using the specified parameters. 

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] that is being formatted.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] rowNumber  - The row number of the table that is being formatted.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] columnNumber  - The column number of the table that is being formatted.
* [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] field  - The [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that contains information relevant to the formatter.
* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] originalTable  - The original [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] that is being formatted.
* [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] nameField  - The [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that contains information relevant to the formatter.





Returns:

The formatted mutable type object.


---


###getCeiling(System.Double)
 Returns the next power of ten greater than or equal to the specified double-precision floating-point number. 

Parameters: 

* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] d  - A double-precision floating-point number.





Returns:

A double-precsion floating-point whole number that is the next power of ten for the input number.


---


###getCeilingForPositive(System.Double)
 Returns the next power of ten greater than or equal to the specified positive double-precision floating-point number. 

Parameters: 

* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] d  - A double-precision floating-point number.





Returns:

A double-precsion floating-point whole number that is the next power of ten for the input number.


---


###getFloor(System.Double)
 Returns the next power of ten less than or equal to the specified double-precision floating-point number. 

Parameters: 

* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] d  - A double-precision floating-point number.





Returns:

A double-precsion floating-point whole number that is the previous power of ten from the input number.


---


###getFloorForPositive(System.Double)
 Returns the next power of ten less than or equal to the specified positive double-precision floating-point number. 

Parameters: 

* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] d  - A double-precision floating-point number.





Returns:

A double-precsion floating-point whole number that is the previous power of ten from the input number.


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
* [[Izenda.AdHoc.ReportOutputOptions|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputOptions]] reportOutputOptions  - The options being used on the report.
* [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] field  - The [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that contains information relevant to the formatter.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the value returned by the formatter.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###JSFormatter()
 Returns a javascript function that is used to format data dynamically on a visualization. 





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the javascript function used to format visualization data.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


