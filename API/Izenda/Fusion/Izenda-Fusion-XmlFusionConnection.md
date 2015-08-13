#XmlFusionConnection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[Alias|/API/Izenda/Fusion/CodeSamples/Izenda_Fusion_FusionConnection_Alias]]|Gets the Izenda.Fusion.FusionConnection's alias that was registered with the [[Izenda.Fusion.FusionConnection|/API/Izenda/Fusion/Izenda-Fusion-FusionConnection]].|null|
|Boolean|[[IsDefault|/API/Izenda/Fusion/CodeSamples/Izenda_Fusion_FusionConnection_IsDefault]]|Gets a [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] representing whether this connection is the Izenda.Fusion.FusionDriver's default connection.|null|


##Methods

###AliasPresents(System.String)
Determines whether the input string contains the alias that was registered to this [[Izenda.Fusion.FusionConnection|/API/Izenda/Fusion/Izenda-Fusion-FusionConnection]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] s  - The database identifier to determine whether it has been aliased or not.





Returns:

A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] value representing whether the input identifier has been aliased or not.


---


###AppendAlias(System.String)
 Adds the alias and separator character for this connection to the identifier supplied. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] s  - The database identifier that should be aliased.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the entire aliased database identifier.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GenerateCommand(Izenda.AdHoc.Report,System.Boolean,out System.String)
 Gets a SQL or XML statement that generates subtotals for the specified report with data from an OData source with the option of including filter parameters in the output. This method behaves differently for indirect and direct connections. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate the SQL for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] grandTotalCommand  - Makes the database command a grand total command or not.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.






---


###GenerateSql(Izenda.AdHoc.Report,System.Boolean,System.String,out System.Collections.IList,out System.String)
 Gets a SQL or XML statement for the specified report with data from an OData source with the option of including filter parameters in the output. This method behaves differently for indirect and direct connections. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate the SQL for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] includeParams  - Specifies whether to include filter parameters as output. When false, filter parameters will be added to the SQL string.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL command to get the report data.
* out [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] param  - The output [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] of parameters that are used as filters.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.






---


###GenerateTotalsCommand(Izenda.AdHoc.Report,System.Int32,out System.String)
 Gets a SQL or XML statement that generates subtotals for the specified report with data from an OData source with the option of including filter parameters in the output. This method behaves differently for indirect and direct connections. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate the SQL for.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] firstIgnored  - Specifies the index of the first column in the OrderBy clause that should be ignored.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.






---


###GenerateTotalsSql(Izenda.AdHoc.Report,System.Boolean,System.String,out System.Collections.IList,out System.String)
 Gets a SQL or XML statement that generates subtotals for the specified report with data from an OData source with the option of including filter parameters in the output. This method behaves differently for indirect and direct connections. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate the SQL for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] includeParams  - Specifies whether to include filter parameters as output. When false, filter parameters will be added to the SQL string.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL command to get the report data.
* out [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] param  - The output [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] of parameters that are used as filters.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.






---


###GetAllTables()
 Gets a list of all tables and views on the schema registered to this connection. 





Returns:

The [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] array corresponding to the tables and views found.


---


###GetColumns(Izenda.AdHoc.Database.Table)
 Gets the complete list of columns found on the schema registered to this connection for the specified table. 

Parameters: 

* [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] table  - The [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] to find columns for.





Returns:

The [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] array corresponding to the columns found.


---


###GetConstraints(Izenda.AdHoc.Database.DatabaseSchema)
 Gets a list of constraints for the specified database schema. 

Parameters: 

* [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] schema  - The [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] to get the constraints for.





Returns:

The [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] array corresponding to the database constraints found.


---


###GetDatabase()







---


###GetDataSet(System.Data.IDbCommand,System.String,out System.String)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] for the specified SQL command using the OData source registered to this connection.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object to execute on the OData source.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportPart  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] designation for the portion of the report this query relates to.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.





Returns:

The new [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] with the results of the get_data_set command.


---


###GetDataTable(Izenda.AdHoc.Report,System.Data.IDbCommand,out System.String)
Gets a [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] from the specified [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] and [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] provided using the OData source registered to this connection.

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that corresponds to the OData source.
* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object to execute on the OData source. This command should conform to
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.





Returns:

The first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] found on the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] returned by the get_data_set command.


---


###GetDirectConnection()
Represents a method that can be used to get the [[Izenda.Fusion.FusionConnection|/API/Izenda/Fusion/Izenda-Fusion-FusionConnection]] that was registered as the default connection during initialization. This method must be overridden.





Returns:

The [[System.Data.IDbConnection|http://msdn.microsoft.com/en-us/library/bs16hf60]] representation of the [[Izenda.Fusion.DirectFusionConnection|/API/Izenda/Fusion/Izenda-Fusion-DirectFusionConnection]].


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetInstance()







---


###GetMinMax(System.Collections.Generic.IDictionary&lt;System.String,System.Collections.Generic.IList&lt;System.String&gt;&gt;,out System.DateTime,out System.DateTime,out System.String)
Gets the minimum and maximum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] values from a collection of date columns across various tables.

Parameters: 

* [[System.Collections.Generic.IDictionary|http://msdn.microsoft.com/en-us/library/s4ys34ea]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]],[[System.Collections.Generic.IList|http://msdn.microsoft.com/en-us/library/5y536ey6]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt;&gt; dateTimeColumns  - The [[System.Collections.IDictionary|http://msdn.microsoft.com/en-us/library/9dhwsays]] collection of table keys and column values to check.
* out [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] minDate  - The minimum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that was found across all columns in the collection of tables.
* out [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] maxDate  - The maximum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that was found across all columns in the collection of tables.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.






---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetVersion()
 Represents a method that gets the version of the service-based datasource that is registered to this connection. 





Returns:

The [[System.Version|http://msdn.microsoft.com/en-us/library/hdxyt63s]] representation of the service-based datasource's version.


---


###InjectDataSet(System.Data.DataSet,System.Data.IDbConnection,out System.String)
Represents a method that can be used to combine multiple datasets from various databases into a single database using the [[BatchSize|http://msdn.microsoft.com/en-us/library/xbtatcx1]] class and the Izenda.Fusion.FusionDriver.DefaultConnection. This method must be overridden.

Parameters: 

* [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] ds  - The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] produced by executing the command using a single database connection.
* [[System.Data.IDbConnection|http://msdn.microsoft.com/en-us/library/bs16hf60]] directConnection  - The default database connection that was registered to the [[Izenda.Fusion.FusionDriver|/API/Izenda/Fusion/Izenda-Fusion-FusionDriver]].
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] schema  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the schema that this Izenda.Fusion.FusionConnectionbelongs to.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of a temporary table name that will be used to copy the data for this connection into.


---


###InvalidateSchemaCache()
Clears the server schema cache for this [[Izenda.Fusion.FusionConnection|/API/Izenda/Fusion/Izenda-Fusion-FusionConnection]] and forces an update on the clients as well.






---


###ProcessPostRequest(System.Net.HttpWebRequest)
 Represents a method that provides a way to intercept POST requests to OData services before the request is sent. 

Parameters: 

* [[System.Net.HttpWebRequest|http://msdn.microsoft.com/en-us/library/8y7x3zz2]] request  - The [[System.Net.HttpWebRequest|http://msdn.microsoft.com/en-us/library/8y7x3zz2]] containing the POST information to be sent.






---


###RequestRealSql(Izenda.AdHoc.Report,System.Boolean,System.String,out System.Collections.IList,out System.String)
 Gets a SQL or XML statement for the specified report with data from multiple databases with the option of including filter parameters in the output. This method behaves differently for indirect and direct connections. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate the SQL for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] includeParams  - Specifies whether to include filter parameters as output. When false, filter parameters will be added to the SQL string.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL command to get the report data.
* out [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] param  - The output [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] of parameters that are used as filters.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.






---


###RequestRealTotalsSql(Izenda.AdHoc.Report,System.Boolean,System.String,out System.Collections.IList,out System.String)
 Gets a SQL or XML statement that generates subtotals for the specified report with data from multiple databases with the option of including filter parameters in the output. This method behaves differently for indirect and direct connections. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate the SQL for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] includeParams  - Specifies whether to include filter parameters as output. When false, filter parameters will be added to the SQL string.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL command to get the report data.
* out [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] param  - The output [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] of parameters that are used as filters.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.






---


###RetrieveDataSet(System.String,System.String,out System.String)
 Gets a System.DataSet object that contains the entire result set from the specified schema and table using the OData soure registered to this connection. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableSchema  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database schema registered to this [[Izenda.Fusion.FusionConnection|/API/Izenda/Fusion/Izenda-Fusion-FusionConnection]]
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the table name to get the data from.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] error  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an error message that was generated if any errors occurred while processing the request.





Returns:

The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] containing the entire table's data from the retrieve_data_set command.


---


###StripAliases(System.String)
 Represents a method that is used to ensure aliases are not used for operations that require unaliased names. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] s  - The name of the identifier to strip aliases from.





Returns:

The unaliased [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the identifier.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


