#SqlDataExtractor

[[_TOC_]]

##Properties

None.


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetColumns(System.Collections.Generic.Dictionary&lt;System.String,Izenda.Fusion.TableItem&gt;,Izenda.Fusion.ExtractedTable)
Gets the columns for the specified [[Izenda.Fusion.ExtractedTable|/API/Izenda/Fusion/Izenda-Fusion-ExtractedTable]] by referencing the collection of [[Izenda.Fusion.TableItem|/API/Izenda/Fusion/Izenda-Fusion-TableItem]] objects provided.

Parameters: 

* [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]],[[Izenda.Fusion.TableItem|/API/Izenda/Fusion/Izenda-Fusion-TableItem]]&gt; allTablesWithColumnsByName 
* [[Izenda.Fusion.ExtractedTable|/API/Izenda/Fusion/Izenda-Fusion-ExtractedTable]] table  - The [[Izenda.Fusion.ExtractedTable|/API/Izenda/Fusion/Izenda-Fusion-ExtractedTable]] representation of the table to search for.





Returns:

The [[Izenda.Fusion.ExtractedColumn|/API/Izenda/Fusion/Izenda-Fusion-ExtractedColumn]] list that was found for the specified table.


---


###GetConstraints()
Gets a collection of [[Izenda.Fusion.ExtractedConstraint|/API/Izenda/Fusion/Izenda-Fusion-ExtractedConstraint]] objects for the MSSQL database being connected to.





Returns:

The [[Izenda.Fusion.ExtractedConstraint|/API/Izenda/Fusion/Izenda-Fusion-ExtractedConstraint]] list corresponding to the database constraints found.


---


###GetDatabase()
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database that was registered with this [[Izenda.Fusion.SqlDataExtractor|/API/Izenda/Fusion/Izenda-Fusion-SqlDataExtractor]].





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the database that was registered with this connection.


---


###GetDirectConnection()
Represents the [[System.Data.IDbConnection|http://msdn.microsoft.com/en-us/library/bs16hf60]] that is used to connect directly to the database to extract data from.





Returns:

The [[System.Data.IDbConnection|http://msdn.microsoft.com/en-us/library/bs16hf60]] that is current for accessing the database.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetInstance()
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the instance of the DBMS that was registered with this [[Izenda.Fusion.SqlDataExtractor|/API/Izenda/Fusion/Izenda-Fusion-SqlDataExtractor]].





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the name of the instance of the DBMS registered with this extractor.


---


###GetMinMax(System.Collections.Generic.IDictionary&lt;System.String,System.Collections.Generic.IList&lt;System.String&gt;&gt;,out System.DateTime,out System.DateTime,out System.String)
Gets the minimum and maximum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] values from a collection of date columns across various tables.

Parameters: 

* [[System.Collections.Generic.IDictionary|http://msdn.microsoft.com/en-us/library/s4ys34ea]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]],[[System.Collections.Generic.IList|http://msdn.microsoft.com/en-us/library/5y536ey6]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt;&gt; dateTimeColumns  - The [[System.Collections.IDictionary|http://msdn.microsoft.com/en-us/library/9dhwsays]] collection of table keys and column values to check.
* out [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] minDate  - The minimum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that was found across all columns in the collection of tables.
* out [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] maxDate  - The maximum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that was found across all columns in the collection of tables.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.





Returns:

A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] indicating whether the operation was successful or not.


---


###GetSchema()
Gets a collection of [[Izenda.Fusion.ExtractedTable|/API/Izenda/Fusion/Izenda-Fusion-ExtractedTable]] objects that contain the extracted schema information from the MSSQL database.





Returns:

A collection of [[Izenda.Fusion.ExtractedTable|/API/Izenda/Fusion/Izenda-Fusion-ExtractedTable]] objects containing the schema information.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetVersion()
Represents a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that returns the version of the Oracle database being connected to.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database version.


---


###InjectDataSet(System.Data.DataSet,System.Data.IDbConnection,out System.String)
Represents a method that can be used to combine multiple datasets into a single database using the [[System.Data.SqlClient.SqlConnection|http://msdn.microsoft.com/en-us/library/sd2728ad]] specified.

Parameters: 

* [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] ds  - The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] that should be injected into the receiving database.
* [[System.Data.IDbConnection|http://msdn.microsoft.com/en-us/library/bs16hf60]] directConnection  - The default database connection that was registered to the [[Izenda.Fusion.SqlFusionDriver|/API/Izenda/Fusion/Izenda-Fusion-SqlFusionDriver]].
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] schema  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the schema that this Izenda.Fusion.SqlFusionDriverconnects to.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of a temporary table name that will be used to copy the data for this connection into.


---


###RetrieveDataSet(System.String,System.String,out System.Data.DataSet,out System.String)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] object that contains the entire result set from the specified schema and table.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableSchema  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database schema registered to the [[Izenda.Fusion.SqlFusionDriver|/API/Izenda/Fusion/Izenda-Fusion-SqlFusionDriver]] registered to this extractor.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the table name to get the data from.
* out [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] dataSet  - The output [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] containing the entire table's data.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.





Returns:

A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] value indicating whether the operation was successful or not.


---


###SetVisibleTables(System.String[])
Sets the list of tables that this [[Izenda.Fusion.DataExtractor|/API/Izenda/Fusion/Izenda-Fusion-DataExtractor]] has access to when obtaining the schema and data from the registered connection.

Parameters: 

* [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] visibleTablesList  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array that represents the list of tables and views that should be included in the resulting schema.






---


###TestConnection()
 Gets a value indicating whether connectivity to the database can be established. 





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] status code for whether the connection was successful or had problems.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


