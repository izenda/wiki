#IFormatter

[[_TOC_]]

##Properties

None.


##Methods

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


