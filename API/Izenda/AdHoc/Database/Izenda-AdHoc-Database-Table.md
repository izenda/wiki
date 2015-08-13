#Table

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|ColumnCollection|[[Columns|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Table_Columns]]|Gets the collection of columns that were associated with the table when the schema information was fetched. If the [[Izenda.AdHoc.Database.TableType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-TableType]] is a stored procedure and lazy loading of stored procedures is on,  then calling this property for the fist time will fetch the stored procedure column data, which may take a long time.|{}|
|String|[[FullName|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Table_FullName]]| Represents the fully-qualified name of the entity with the schema as well. |[].[]|
|String|[[Name|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Table_Name]]| Gets or sets the name of the entity that was obtained from the database. |String.Empty|
|Table|[[Parent|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Table_Parent]]| Gets or sets the parent entity if there is one. This could be a synonym on the database. |null|
|String|[[Schema|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Table_Schema]]| Gets or sets the schema that the entity is associated with. |String.Empty|
|String|[[SqlName|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Table_SqlName]]|Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the entity's name formatted for a SQL statement.|[].[]|
|TableType|[[Type|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Table_Type]]|The [[Izenda.AdHoc.Database.TableType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-TableType]] that is used for various functions throughout the reporting application.|Table|


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


