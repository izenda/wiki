#DatabaseSchema

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|ConstraintCollection|[[Constraints|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_DatabaseSchema_Constraints]]| Represents the collection of primary/foreign key relationships on the database. |null|
|StoredProcedureCollection|[[StoredProcedureCollection|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_DatabaseSchema_StoredProcedureCollection]]| Represents the collection of stored procedures on the database. |null|
|TableCollection|[[Tables|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_DatabaseSchema_Tables]]| Represents the collection of tables and views on the database. |null|


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###FindColumn(System.String)
 Locates a single column in the schema that was loaded from the database using the specified fully-qualified column name. Column names are case sensitive. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullName  - The fully-qualified name of the column.





Returns:

The [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] representation of the loaded database column or null if the column was not found.


---


###FindColumns(System.String)
 Locates a set of columns in the schema that were loaded from the database using the specified fully-qualified column name. The wildcard "*" is accepted and column names are case sensitive. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullName  - The fully-qualified name of the column or wildcard token.





Returns:

An [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] array of column information matching the criteria.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
 Gets a serialized representation of the schema's data with the specified context. 

Parameters: 

* [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] info  - The serialized information of the database schema.
* [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] context  - The source and destination context in which the schema should be obtained. Null signifies no context.






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


###UpdateConstraints()
 Ensures that any constraints added to the current schema or removed from it will be respected throughout the schema's lifetime. 






---


