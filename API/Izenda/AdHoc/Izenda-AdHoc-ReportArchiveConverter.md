#ReportArchiveConverter

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|ReportArchiveConverter|[[Instance|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportArchiveConverter_Instance]]||null|


##Methods

###ConvertColumnName(System.String,System.String)
 Converts old column name (in table.column format) w/o schema name to the new column name. Adds [dbo] schema name, adds [ and ] to the table name and column name. This method has no affect if column name has new format (with schema name). 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] columnName  - Old table.column or column name.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - Old table name.





Returns:

Converted table name.


---


###ConvertColumnName(System.String)
 Converts old column name (in table.column format) w/o schema name to the new column name. Adds [dbo] schema name, adds [ and ] to the table name and column name. This method has no affect if column name has new format (with schema name). 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] columnName  - Old table name.





Returns:

Converted table name.


---


###ConvertTableName(System.String)
 Converts old table name (w/o schema name) to the new table name. Adds [dbo] schema name, adds [ and ]. This method has no affect if table name has new format (with schema name). 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - Old table name.





Returns:

Converted table name.


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


