#Db2Driver

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[AlwaysGenerateAs|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_AlwaysGenerateAs]]| Determines whether fields will always use the "AS" keyword when generating SQL queries. |True|
|String|[[AsForTables|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_OdbcDriver_AsForTables]]| Gets the ODBC keyword used to separate identifiers from aliases. |AS|
|String|[[CacheKeyBase|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_CacheKeyBase]]|Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents a unique key that can be used to query the cache.|Izenda.AdHoc.Database.Db2Driver|
|Int32|[[CmdTimeout|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_CmdTimeout]]||3600|
|IDbConnection|[[Connection|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_Connection]]| Gets the current connection to the database or creates a new one if one does not exist or if the existing connection is dropped. |null|
|IDbConnection|[[ConnectionOpened|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_ConnectionOpened]]||null|
|String|[[ConnectionString|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_ConnectionString]]| Represents the default connection string for the driver in use. |null|
|DatabaseSchema|[[DatabaseSchema|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_DatabaseSchema]]| Represents the schema obtained from the database. |null|
|String[]|[[DateFormats|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_DateFormats]]| Gets a collection of all the date format strings that are available. |[M/dd/yyyyH:m, M/d/yyyyH:m,<br>M/dd/yyyyH:mtt, M/d/yyyyH:mtt,<br>MMMMdd,yyyyHH:mm, MMMMdd,yyyyHH:mmtt,<br>M/dd/yyyyh:m, M/d/yyyyh:m,<br>M/dd/yyyyh:mtt, M/d/yyyyh:mtt,<br>MMMMdd,yyyyhh:mm, MMMMdd,yyyyhh:mmtt,<br>M-dd-yyyy, M-d-yyyy,<br>M-dd-yy, M-d-yy,<br>M/dd/yyyy, M/d/yyyy,<br>M/dd/yy, M/d/yy,<br>MMMMd,yyyy, MMMMdd,yyyy,<br>MMMd,yyyy, MMMdd,yyyy,<br>M,yyyy, M-yyyy,<br>M,yy, M-yy,<br>MMM,yyyy, MMM-yyyy,<br>MMM,yy, MMM-yy,<br>MMMM,yyyy, MMMM-yyyy,<br>MMMM,yy, MMMM-yy,<br>yyyy-mm-ddHH:mm:ss, yyyy-m-dHH:mm:ss,<br>yyyy-mm-ddH:m:ss, yyyy-m-dH:m:ss,<br>yyyy-mm-dd, yyyy-mm-ddhh:mm:ss,<br>yyyy-m-dhh:mm:ss, yyyy-mm-ddh:m:ss,<br>yyyy-m-dh:m:ss, yyyy-mm-ddhh:mm:ss,<br>yyyy-mm-ddhh:mm:ss]|
|String|[[DefaultSchemaName|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_DefaultSchemaName]]| Represents the name of the default schema of the DBMS for this driver. |dbo|
|Encoding|[[Encoding|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_Encoding]]|Gets the [[System.Text.Encoding|http://msdn.microsoft.com/en-us/library/86hf4sb8]] representation of the database's default text encoding.|Unicode (UTF-8)|
|List|[[NativeTypesOverrides|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_NativeTypesOverrides]]| Collection of the key-value pairs that is used to create a temporary table when SP is used as a data source. Key - SqlDbType Value - corresponding native DB type |{[Decimal,Decimal(18,6)], [Variant,sql_variant],<br>[VarChar,VarChar(MAX)]}|
|Boolean|[[OnlyNullIsBlank|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_OnlyNullIsBlank]]||False|
|TimeSpan|[[QueryCachingTime|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_QueryCachingTime]]| Represents the period of time that queries made to the database will remain in the cache. Cached queries exist within application memory until this time period has elapsed or the queries cache is invalidated. The default is five minutes. |00:01:00|
|TimeSpan|[[SchemaCachingTime|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_SchemaCachingTime]]| Represents the period of time that the database schema will remain in the cache before it is invalidated and will be re-loaded from the database.  The default is one day. |1.00:00:00|
|Boolean|[[SupportsCreateDateExpression|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_SupportsCreateDateExpression]]| Determines if the version of the database supports the ability to create a date from portions of a date. |True|
|Boolean|[[UseTablesFromSchemaOnly|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_UseTablesFromSchemaOnly]]||False|
|Version|[[Version|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_Version]]| Gets the version of the database that is being connected to. Once the version has been obtained, its value will be cached to disk. |1.0|


##Methods

###AddConstraint(System.String,System.String)
 Represents a method used to add a primary/foreign key relationship between two tables' columns in the schema using an INNER JOIN. The wildcard "*" is accepted and column names are case sensitive. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] primaryColumn  - The fully-qualified column name or wildcard to use as the primary(lefthand) table.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] foreignColumn  - The fully-qualified column name or wildcard to use as the foreign(righthand) table.






---


###AddConstraint(System.String,System.String,Izenda.AdHoc.Database.DatabaseSchema)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] primaryColumn 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] foreignColumn 
* [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] schema 






---


###AddForcedLeftJoin(System.String,System.String)
 Represents a method to add a primary/foreign key relationship between two tables in the schema using a LEFT OUTER JOIN. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] primaryTable  - The fully-qualified table name to use as the primary(lefthand) table.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] foreignTable  - The fully-qualified table name to use as the foreign(righthand) table.






---


###AddForcedLeftJoin(System.String)
 Represents a method to add a primary/foreign key relationship between a table and itself in the schema using a LEFT OUTER JOIN. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] table  - The fully-qualified table name to use to join it to itself.






---


###BeginAddingMultipleConstraints()







---


###CastPivotValue(System.String,Izenda.AdHoc.Database.SqlType)
Gets a SQL formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that safely converts values produced for pivot columns to the specified [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] paramName  - The name of the parameter that will be used for the pivot field.
* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] sqlType  - The [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] to cast the pivot field to.






---


###CheckConnection()
 Checks to ensure connectivity to the database 






---


###ContainColumn(System.String,System.String,System.String)
 Represents a method to determine whether the specified table in the schema contains the column with the specified name. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] schemaName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table within the schema to use.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] columnName  - The name of the column to determine the existence of.





Returns:

True if the column was found on the database. False if not.


---


###ContainsTableName(System.String)
 Checks to see if the specified table exists on the ODBC database. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the table to check for.





Returns:

A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] representation of the table's existence.


---


###ConvertToDbType(System.Type)
Gets the [[System.Data.SqlDbType|http://msdn.microsoft.com/en-us/library/wf35eysz]] that is type equivalent to the specified [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]]

Parameters: 

* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] t  - The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] to convert to a [[System.Data.SqlDbType|http://msdn.microsoft.com/en-us/library/wf35eysz]]





Returns:

The [[System.Data.SqlDbType|http://msdn.microsoft.com/en-us/library/wf35eysz]] produced from the specified [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]]


---


###CreateCommand(System.String)
Creates an [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object from the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SQL statement.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SQL statement.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be cast to a [[System.Data.Odbc.OdbcCommand|http://msdn.microsoft.com/en-us/library/f7w5fh74]]


---


###CreateConnection()







---


###CreateDataAdapter(System.Data.IDbCommand)
Creates an executable [[System.Data.IDbDataAdapter|http://msdn.microsoft.com/en-us/library/5bayt6fd]] for the specified command that can be cast to a [[System.Data.Odbc.OdbcDataAdapter|http://msdn.microsoft.com/en-us/library/1h8a5e3x]].

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to use.





Returns:

The executable adapter.


---


###CreateDataAdapter(System.String)
Represents a method that creates an executable [[System.Data.IDbDataAdapter|http://msdn.microsoft.com/en-us/library/5bayt6fd]] for the specified command.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL to use.





Returns:

The executable adapter.


---


###CreateJoinedTablesList(System.String[],Izenda.AdHoc.ReportSet)
 Represents a method that creates a collection of related tables from the provided array of datasources for determining possible relationships between datasources. 

Parameters: 

* [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] datasources 
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] rs 






---


###CreateParameter(System.String,System.Object)
Creates a generically-typed [[System.Data.IDataParameter|http://msdn.microsoft.com/en-us/library/b14k9y11]] object from the specified values that can be typecast to a [[System.Data.Odbc.OdbcParameter|http://msdn.microsoft.com/en-us/library/935kzcyw]] object.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the parameter.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The value the parameter will have.





Returns:

The [[System.Data.IDataParameter|http://msdn.microsoft.com/en-us/library/b14k9y11]] created.


---


###CreateParameter(System.String,System.Object,System.Data.DbType)
Creates a [[System.Data.IDataParameter|http://msdn.microsoft.com/en-us/library/b14k9y11]] object from the specified values that can be typecast to a [[System.Data.Odbc.OdbcParameter|http://msdn.microsoft.com/en-us/library/935kzcyw]] object.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the parameter.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The value the parameter will have.
* [[System.Data.DbType|http://msdn.microsoft.com/en-us/library/fhkx04c4]] originalType  - The [[System.Data.DbType|http://msdn.microsoft.com/en-us/library/fhkx04c4]] to use for the parameter. If String or AnsiString is specified, then the size will be set from the value given.





Returns:

The [[System.Data.IDataParameter|http://msdn.microsoft.com/en-us/library/b14k9y11]] created.


---


###DateTimeNow()
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the PostgreSQL command to return the current system date from the database server.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] function for returning the current date.


---


###DeleteReportTemplate(System.String,System.String)
Creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to delete the HTML form for the specified report from the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that the thumbnail belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantId 





Returns:

A [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be used to delete the form data.


---


###DeleteReportThumbnail(System.String,System.String)
Creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to delete a report thumbnail image in the [[SavedReportsTable|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_SavedReportsTable]] on the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that the thumbnail belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantId 





Returns:

A [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be used to delete a thumbnail.


---


###DeleteThumbnail(System.String,System.String)
Creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to delete a report thumbnail image in the [[SavedReportsTable|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_SavedReportsTable]] on the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that the thumbnail belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantID  - The tenant ID that the report belongs to.





Returns:

A [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be used to delete a thumbnail.


---


###DetectVersion()
 Gets the version of the IBM DB2 database that is being connected to. 





Returns:

The [[System.Version|http://msdn.microsoft.com/en-us/library/hdxyt63s]] representation of the IBM DB2 database version.


---


###EndAddingMultipleConstraints()







---


###EnsureCorrectMeta(System.String)
 Rrepresents a method that is used to create a clustered index on the specified table name if one doesn't exist. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The table to create an index on.






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###ExctractSchema()
 Represents a method that is used to obtain the database schema by populating the tables, views, stored procedures, and constraints. 





Returns:

The [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] object representing the collection of tables, views, stored procedures, and constraints.


---


###ExecuteDataSet(System.String)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] object from the database using the SQL query provided.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SQL query to execute.





Returns:

The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] produced by the query from the database.


---


###ExecuteDataSet(System.String,System.Boolean)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] object from the database using the SQL query provided.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SQL query to execute.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] returnNull  - Specifies whether an exception will cause the method to return null instead of the exception.






---


###ExecuteNonQuery(System.String)
 Executes the SQL query on the database server and produces its return code. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SQL query to execute.





Returns:

The System.Integer return code of the query.


---


###ExecuteNonQuery(System.Data.IDbCommand)
 Executes the SQL command on the database server and produces its return code. 

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] SQL command to execute.





Returns:

The System.Integer return code of the command.


---


###ExecuteScalar(System.String)
Gets the first result from executing the specified SQL [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - he [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the query to execute.





Returns:

The first result from the executed scalar command.


---


###ExecuteScalar(System.String,System.Boolean)
Gets the first result from executing the specified SQL [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the query to execute.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] returnNull  - Specifies whether an exception will cause the method to return null instead of the exception.





Returns:

The first result from the executed scalar command.


---


###FullStoredProceduresList()







---


###GenerateCommand(Izenda.AdHoc.Report,System.Boolean)
Creates an [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object from the specified [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate a database command for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] grandTotalCommand  - Makes the database command a grand total command or not.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to get the report data.


---


###GenerateSQL(Izenda.AdHoc.Report,System.Boolean,System.String,out System.Collections.IList)
 Gets a SQL statement for the specified report with the option of including filter parameters in the output. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate the SQL for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] includeParams  - Specifies whether to include filter parameters as output. When false, filter parameters will be added to the SQL string.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL command to get the report data.
* out [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] param  - The output [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] of parameters that are used as filters.






---


###GenerateSqlSafetyDescription(System.String)
Gets a SQL-safe [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the given description.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] description  - The alias of a column, table, or view that needs to be made SQL-safe.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] represetation of the description that has been made safe for executing in DB2.


---


###GenerateTotalsCommand(Izenda.AdHoc.Report,System.Int32)
Gets a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that produces grand totals for the specified [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that will be used to generate the command for.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] firstIgnored  - Specifies the index of the first column in the OrderBy clause that should be ignored.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that produces grand totals.


---


###GenerateTotalsSQL(Izenda.AdHoc.Report,System.Boolean,System.String,out System.Collections.IList)
 Gets a SQL statement that generates subtotals for the specified report with the option of including filter parameters in the output. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate the SQL totals for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] includeParams  - Specifies whether to include filter parameters as output. When false, filter parameters will be added to the SQL string.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL totals command to get the report data.
* out [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] param  - The output [[System.Collections.IList|http://msdn.microsoft.com/en-us/library/30ft6hw7]] of parameters that are used as filters.






---


###GetAggregateFunction(Izenda.AdHoc.StandardAggregateFunctionType,System.String)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL expression for the specified aggregate function using the input expression.

Parameters: 

* [[Izenda.AdHoc.StandardAggregateFunctionType|/API/Izenda/AdHoc/Izenda-AdHoc-StandardAggregateFunctionType]] aggregateFunction  - The [[Izenda.AdHoc.StandardAggregateFunctionType|/API/Izenda/AdHoc/Izenda-AdHoc-StandardAggregateFunctionType]] to get the SQL for.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sqlExpression  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input expression to apply the aggregate function to.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the entire aggregate function expression.


---


###GetAllStoredProcedures()
 Gets a list of all stored procedures on the ODBC database from the VisibleDatasources. 





Returns:

The AdHoc.Database.Storedprocedure array corresponding to the stored procedures found.


---


###GetAllTables()
 Gets a list of all tables and views on the ODBC database from the VisibleDataSources. 





Returns:

The [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] array corresponding to the tables and views found.


---


###GetAppropriateSqlTypeFromTypeGroup(Izenda.AdHoc.Database.SqlTypeGroup)


Parameters: 

* [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] sqlTypeGroup 






---


###GetBlankKeyword()
 Gets the keyword signifying NULLs or BLANK in DB2. 





Returns:

The symbol signifying NULL or BLANK


---


###GetColumns(Izenda.AdHoc.Database.Table)
 Gets the complete list of columns found on the ODBC database for the specified table. 

Parameters: 

* [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] table  - The [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] to find columns for.





Returns:

The [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] array corresponding to the columns found.


---


###GetColumns(Izenda.AdHoc.Database.StoredProcedure)
 Gets the list of columns for the specified stored procedure on the MSSQL database. 

Parameters: 

* [[Izenda.AdHoc.Database.StoredProcedure|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-StoredProcedure]] table 





Returns:

The [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] array corresponding to the columns found.


---


###GetColumnValuesSql(Izenda.AdHoc.Database.Column,System.Int32,System.String)


Parameters: 

* [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] dbColumn 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] maxRowCount 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] startWithValue 






---


###GetConcatStringsExpression(System.String,System.String)
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an expression to concatenate two strings.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression1  - The first expression to concatenate.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression2  - The second expression to concatenate.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL statement that can be executed to concatenate strings.


---


###GetConcatStringsExpression(System.String,System.String,System.String)
Represents a method that gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] of an expression to concatenate three strings.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression1  - The first expression to concatenate.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression2  - The second expression to concatenate.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression3  - The third expression to concatenate.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL statement that can be executed to concatenate strings.


---


###GetConstraints(Izenda.AdHoc.Database.DatabaseSchema)
 Gets a list of constraints for the specified database schema on the DB2 database. 

Parameters: 

* [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] schema  - The [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] to get the constraints for.





Returns:

The [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] array corresponding to the database constraints found.


---


###GetCreateArchiveTableCommand(System.String)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SQL statement to create a table with the specified name to be used as the archived reports table.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table to create.





Returns:

The complete command to be executed.


---


###GetCreateDateExpression(System.String,System.String,System.String)
Gets a SQL formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the function used to convert the specified parameters into a DB2 date.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] yearExp  - The year portion of the date.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] monthExp  - The month portion of the date.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] dayExp  - The day portion of the date.





Returns:

The SQL statement that can be executed to construct a DB2 formatted date from the parts provided.


---


###GetCreateReportCommand(System.String,System.String,System.String,System.String)
Gets a DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to create a report on the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that will be created on the database.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantId  - The tenantId that the report should belong to when it's created.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml  - The XML report representation of the report definition.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetCreateReportCommand(System.String,System.String,System.String)
Gets an DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to create a report on the database. This method uses an empty tenantId.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that will be created on the database.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml  - The XML report representation of the report definition.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetDatabase()







---


###GetDataReader(System.Data.IDbCommand)
Gets a [[System.Data.IDataReader|http://msdn.microsoft.com/en-us/library/sh674a6a]] object from the specified database command.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object to execute.





Returns:

The executed [[System.Data.IDataReader|http://msdn.microsoft.com/en-us/library/sh674a6a]] object.


---


###GetDataSet(System.Data.IDbCommand)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] for the specified SQL command.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that will be evaluated and executed.





Returns:

The new [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] with the results of the query.


---


###GetDataSet(System.Data.IDbCommand,System.String)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] for the specified SQL command.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that will be evaluated and executed.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportPart  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] designation for the portion of the report this query relates to.





Returns:

The new [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] with the results of the query.


---


###GetDataSetCached(System.String)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] for the specified SQL expression from the cache if possible.  [[CacheQueries|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_CacheQueries]] must be on, otherwise the query will touch the database instead.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the query to execute.





Returns:

The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] that was cached the first time the query was executed or a new [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] with the results.


---


###GetDataSetCached(System.Data.IDbCommand)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] for the specified SQL command from the cache if possible.  [[CacheQueries|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_CacheQueries]] must be on, otherwise the query will touch the database instead.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that will be evaluated and executed if the underlying SQL is not cached.





Returns:

The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] that was cached the first time the query was executed or a new [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] with the results.


---


###GetDataSetCached(System.Data.IDbCommand,System.Boolean)
Gets a [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] for the specified SQL command with the option of using the cached version.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that will be evaluated and executed if the underlying SQL is not cached.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] cache  - Specifies whether to use the cached [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] when possible. This depends on the [[QueryCachingTime|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_QueryCachingTime]].





Returns:

The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] that was cached the first time the query was executed or a new [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] with the results.


---


###GetDataTable(System.String,System.Boolean)
Gets the first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] in the DataSet returned from executing the SQL.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the query to execute.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] cache  - Specifies whether to use the cached [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] when possible. This depends on the [[QueryCachingTime|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_QueryCachingTime]].





Returns:

The first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] found on the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] returned by the query.


---


###GetDataTable(System.String)
Gets the first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] in the DataSet returned from executing the SQL. The results are loaded from the cache if possible when [[CacheQueries|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_CacheQueries]] is on.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the query to execute.





Returns:

The first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] found on the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] returned by the query.


---


###GetDataTable(System.Data.IDbCommand,System.Boolean)
Gets the first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] in the DataSet returned from executing the SQL command.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object to execute.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] cache  - Specifies whether to use the cached [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] when possible. This depends on the [[QueryCachingTime|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Driver_QueryCachingTime]].





Returns:

The first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] found on the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] returned by the query.


---


###GetDataTable(System.Data.IDbCommand,System.String)
Gets the first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] in the DataSet returned from executing the SQL command.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object to execute.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportPart  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] designation for the portion of the report this query relates to.





Returns:

The first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] found on the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] returned by the query.


---


###GetDataTable(System.Data.IDbCommand)
Gets the first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] in the DataSet returned from executing the SQL command.

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object to execute.





Returns:

The first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] found on the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] returned by the query.


---


###GetDataTable(Izenda.AdHoc.Report,System.Data.IDbCommand)
Gets a [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] from the specified [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] and [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] provided.

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that corresponds to the database command
* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object to execute on the database.





Returns:

The first [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] found on the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] returned by the query.


---


###GetDateAdd(System.String,System.Int32,System.String)
Gets a formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that constructs a SQL statement to add the specified value to the dateTime provided.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] dateTime  - The base SQL formatted date to begin with.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] addedValue  - The value to add to the date.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] addedMeasure  - The SQL keyword for the interval you want to specify to add.





Returns:

The SQL formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] constructed from the parts.


---


###GetDateAdd(System.String,System.Double,System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] dateTime 
* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] addedValue 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] addedMeasure 






---


###GetDateDiffSQL(System.String,System.String,Izenda.AdHoc.StandardAggregateFunctionType)
 Represents a method that gets the difference in days between the two dates using the specified aggregation function. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] date1  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the date to be the subtrahend of the expression.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] date2  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the date to be the minuend of the expression.
* [[Izenda.AdHoc.StandardAggregateFunctionType|/API/Izenda/AdHoc/Izenda-AdHoc-StandardAggregateFunctionType]] funcType  - The [[Izenda.AdHoc.StandardAggregateFunctionType|/API/Izenda/AdHoc/Izenda-AdHoc-StandardAggregateFunctionType]] to apply to the statement after the difference is calculated.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the completed function to calculate the difference in days between dates.


---


###GetDateDiffSQL(System.String,System.String,System.String,Izenda.AdHoc.StandardAggregateFunctionType)
 Represents a method that gets the difference between the two dates using the specified aggregation function. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] date1  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the date to be the subtrahend of the expression.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] date2  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the date to be the minuend of the expression.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] measure  - The SQL keyword for the interval you want to specify to add.
* [[Izenda.AdHoc.StandardAggregateFunctionType|/API/Izenda/AdHoc/Izenda-AdHoc-StandardAggregateFunctionType]] funcType  - The [[Izenda.AdHoc.StandardAggregateFunctionType|/API/Izenda/AdHoc/Izenda-AdHoc-StandardAggregateFunctionType]] to apply to the statement after the difference is calculated.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the completed function to calculate the difference between dates for the interval specified.


---


###GetDateExpression(System.DateTime)


Parameters: 

* [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] date 






---


###GetDateNameExpression(System.String,System.String)
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the specified date part and SQL expression formatted to be executed in SQL.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] part  - The DB2 date portion to convert the expression into.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression  - The expression that should be modified by the expression built by this method.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the completed expression.


---


###GetDatePartExpression(System.String,System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] part 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression 






---


###GetDeleteReportSetCommand(System.String,System.String)
Gets a DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to delete the specified report definition from the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that will be deleted from the database.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetDeleteReportSetCommand(System.String,System.String,System.String)
Gets a DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to delete the specified report definition from the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that will be deleted from the database.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantId 





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetDomainFunction()
 Represents a method that is used to get the SQL function that will be used for joining tables with web addresses. 





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the SQL function if the DBMS supports it, or an exception if not.


---


###GetGetReportSQL(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName 






---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetInstance()







---


###GetIsNullSqlForStringColumn(System.String)
Represents a method that gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] of an Oracle statement that will check if the input statement is null.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] columnSql  - The column statement to check for nulls.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] statement that can be executed.


---


###GetLikeExpression(System.String,System.String)
 Represents a method that gets a SQL formatted LIKE statement between the given values. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] column  - The column to have its values compared for matches.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - The value to compare to the column value for matches.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL formatted LIKE statement.


---


###GetListReportsCommand(System.String,System.DateTime,System.String)
Gets a DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to get a list of reports from the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] lastModified  - The [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that marks the earliest date to look for when obtaining reports
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantId 





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetLoadReportSetCommand(System.String,System.String)
Gets a DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to load the specified report definition from the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that will be loaded from the database.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetLoadReportSetCommand(System.String,System.String,System.String)
Gets a DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to load the specified report definition with the specified name and tenantId from the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that will be loaded from the database.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantID  - The tenantId that the report was saved with.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetMinMax(System.Collections.Generic.IDictionary&lt;System.String,System.Collections.Generic.IList&lt;System.String&gt;&gt;,out System.DateTime,out System.DateTime)
Gets the minimum and maximum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] values from a collection of date columns across various tables.

Parameters: 

* [[System.Collections.Generic.IDictionary|http://msdn.microsoft.com/en-us/library/s4ys34ea]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]],[[System.Collections.Generic.IList|http://msdn.microsoft.com/en-us/library/5y536ey6]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt;&gt; dateTimeColumns  - The [[System.Collections.Generic.IDictionary|http://msdn.microsoft.com/en-us/library/s4ys34ea]] collection of table keys and column values to check.
* out [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] minDate  - The minimum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that was found across all columns in the collection of tables.
* out [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] maxDate  - The maximum [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that was found across all columns in the collection of tables.






---


###GetNoLockSql()
 Represents the DBMS's NOLOCK statement, if one exists for the DBMS. 






---


###GetNumericColumnRoundSQL(System.String)
 Represents a method that gets a SQL formatted function to ROUND a numeric column. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] nativeColumnSql  - The SQL statement or column to ROUND.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL statement or column with the applied ROUND function.


---


###GetObjectIdAndTypeSql(System.String,System.Boolean)
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an Oracle command that gets the id and type of the specified object.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] objectName  - The name of the object to look for.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isStandard  - A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] representing whether the object being searched for is an Oracle standard object or a user object.  When true, the statement will require administrator privileges.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database command to get an object ID and its type.


---


###GetObjectMetaSql(System.String,System.Boolean)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of an database command that obtains metadata information about the object with the specified ID.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] objectID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isStandard  - A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] representing whether the object being searched for is a standard database object or a user object.  When true, the statement will require administrator privileges.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the command that gets the metadata for the object with the specified ID.


---


###GetObjectSchemaSql(System.String)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of a command that selects the database schema(owner) of the object with the specified name.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] objectName  - The name of the object to look for.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database command to get the schema of the object.


---


###GetParamFilters(Izenda.AdHoc.Report)
 Gets a collection of all the filters in a report that are parameters for stored procedures. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to find the paramter filters for.





Returns:

The [[Izenda.AdHoc.FilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FilterCollection]] containing all the filters that are stored procedure parameters.


---


###GetParams(Izenda.AdHoc.Database.StoredProcedure)
 Gets the list of parameters for the specified stored procedure on the MSSQL database. 

Parameters: 

* [[Izenda.AdHoc.Database.StoredProcedure|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-StoredProcedure]] storedProcedure  - The [[Izenda.AdHoc.Database.StoredProcedure|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-StoredProcedure]] to get the returned parameters for.





Returns:

he [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] array corresponding to the parameters found.


---


###GetQuarterNumberExpresion(System.String)
Gets a SQL formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] of a function to extract the quarter of the year from the specified SQL expression.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression  - The Oracle [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that the week should be extracted from.





Returns:

The SQL formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that can be executed to return the quarter of the year.


---


###GetReportInfo(System.Data.DataRow)
Returns a new [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object from the specified [[System.Data.DataRow|http://msdn.microsoft.com/en-us/library/7f2d84ta]] that contains data relevant to constructing the object.

Parameters: 

* [[System.Data.DataRow|http://msdn.microsoft.com/en-us/library/7f2d84ta]] row  - The [[System.Data.DataRow|http://msdn.microsoft.com/en-us/library/7f2d84ta]] from which the [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] will be generated.  Certain columns are expected relating to the SavedReportsTable columns.





Returns:

A new [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object built from the [[System.Data.DataRow|http://msdn.microsoft.com/en-us/library/7f2d84ta]].


---


###GetReportInfo(System.Data.DataRow,System.String,System.Boolean)
Creates a new [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object from the parameters provided.

Parameters: 

* [[System.Data.DataRow|http://msdn.microsoft.com/en-us/library/7f2d84ta]] row  - The [[System.Data.DataRow|http://msdn.microsoft.com/en-us/library/7f2d84ta]] that will be used to populate the report's information. The columns required are the columns in the [[SavedReportsTable|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_SavedReportsTable]]
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] currentUserTenantId  - The tenant ID of the currently active user.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] useReportId  - Determines whether to use the report name or the report ID to identify which report to get the info for.





Returns:

The [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object containing information about the report.


---


###GetReportStoredProcedures(Izenda.AdHoc.Report)
Gets a collection of [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] objects that represent the stored procedures included on the report.

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to be checked for stored procedure datasources.





Returns:

A list of [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] objects corresponding to the stored procedures found on the report.


---


###GetReportTemplate(System.String,System.String)
Creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to get the HTML form for the specified report from the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that the thumbnail belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantId 





Returns:

A [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be used to get the form data.


---


###GetReportThumbnail(System.String,System.String)
Creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to get the binary thumbnail data for the specified report from the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that the thumbnail belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantId 





Returns:

A [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be used to obtain the thumbnail.


---


###GetScalar(System.Data.IDbCommand)
Gets the first result from executing the specified SQL [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]].

Parameters: 

* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] object to execute.





Returns:

The first result from the executed scalar command.


---


###GetScalar(System.String)
Gets the first result from executing the specified SQL [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the query to execute.





Returns:

The first result from the executed scalar command.


---


###GetSchemaInfo(System.Boolean)
Represents a method to obtain an array of [[Izenda.AdHoc.Webservices.DataBaseInfo|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-DataBaseInfo]] objects from a single database or multiple databases.  Multiple databases are only supported when using Fusion.

Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] useSingleDatabaseForFusionDriver  - Specifies whether to categorize all tables and columns under a category called "Single Database" or to obtain category information from the [[DataSourceCategories|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_DataSourceCategories]] collection.





Returns:

The collection of [[Izenda.AdHoc.Webservices.DataBaseInfo|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-DataBaseInfo]] objects corresponding to all tables, views, stored procedures, constraints, and columns in the database schema with category information.


---


###GetSqlName(Izenda.AdHoc.Database.Table)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the fully-qualified name of the table formatted for DB2.

Parameters: 

* [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] table  - The [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] to get the fully-qualified name of.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the table name.


---


###GetSqlName(Izenda.AdHoc.Database.Column)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the fully-qualified name of the column formatted for DB2.

Parameters: 

* [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] column  - The [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] to get the fully-qualified name of.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the column name.


---


###GetSqlTypeByDbType(System.String)
Gets an [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] object from the specified database type string if it exists in the list of registered types.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] dbType  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database type to check for.





Returns:

The [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] that was found, or a dummy if one was not found.


---


###GetStoredProceduresCommand(Izenda.AdHoc.Report,System.Collections.Generic.List&lt;Izenda.AdHoc.Database.Table&gt;,System.Data.IDbCommand,System.String,System.Boolean,out System.Boolean,out System.Boolean)
Gets a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that contains the SQL generated for a report containing stored procedures.

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to have a query generated for.
* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]]&gt; storedProceduresTables  - The [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] list of all the stored procedure tables the report contains.
* [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] command  - The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] SQL command that was generated by the report's default SQL property.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] uniqueID  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of a value that will be used to generate unique IDs for creating temp tables containing the executed stored procedure results.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] globalSame  - A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] indicating whether the command generated uses the simple method of executing the stored procedure command or the complex method.  The complex method is used when joining stored procedures to other tables. Simple mode also does not permit field descriptions to be applied.
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] someFiltersNotSpecified  - A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] indicating whether any filters on the report were not defined at the report level. The report is cross-referenced with the CurrentReportSet to determine this.
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] columnsReorderingRequired  - A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] indicating whether the [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] produced from executing the command will require its  columns to be re-ordered after the fact to match the DataTable's order to the report's order.





Returns:

A [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to obtain the data for the stored procedure report.


---


###GetStringConst(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] stringConst 






---


###GetTemporaryColumnByName(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name 






---


###GetTemporaryTableByName(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name 






---


###GetTextBracket()
 Gets the database field delimiter character. 





Returns:

The character that is used to delimit identifiers on the database.


---


###GetTimeSum(System.String)
Gets a formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that constructs a SQL statement to get the aggregate sum of the SQL time expression.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] innerSQL  - The SQL statement that produces a SQL date expression to construct a time period from.





Returns:

The sum of time that has elapsed since January 1, 1900 until the specified date.


---


###GetTopNSql(System.String,System.Int32)
 Creates a FIRST n ROWS statement to be used with the specified SQL expression to select the number of records specified. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The SQL statement that will receive the FIRST statement.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] n  - The number of records to fetch with this FIRST statement.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SQL statement where the appended FIRST statement is less than or equal to n ROWS.


---


###GetToStringExpression(System.String)
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the specified SQL expression that will be converted with the DB2 CHAR conversion function.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression  - The SQL expression that should be cast to a string type.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL statement.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetUpdateReportCommand(System.String,System.String,System.String,System.String)
Gets a DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to update a report on the database.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that will be updated on the database.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantId  - The tenantId that the report should belong to when it's updated.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml  - The XML report representation of the report definition.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetUpdateReportCommand(System.String,System.String,System.String)
Gets a DB2 statement from the specified parameters that creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] to update a report on the database. This method uses an empty tenantId.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table used to store reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that will be updated on the database.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml  - The XML report representation of the report definition.





Returns:

The [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] created from the parameters.


---


###GetUserTables()
 Represents a method that gets a list of all tables and views on the database available to the user(schema) specified in the connection string. 





Returns:

The [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] array corresponding to the tables and views found.


---


###GetWeekNumberExpression(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression 






---


###GetYearAndWeekExpression(System.String)
Gets a SQL formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of a DB2 function to extract the year and week from the specified SQL expression.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression  - The DB2 [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that the year and week should be extracted from.





Returns:

The SQL formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that can be executed to extract the year and week portion from the expression.


---


###InvalidateQueryCache()
 Represents a method to remove queries from the application's in-memory cache. 






---


###InvalidateSchemaCache()
 Represents a method to remove the schema from the application's in-memory cache. 






---


###IsJoinAllowable(Izenda.AdHoc.Database.SqlType,Izenda.AdHoc.Database.SqlType)
Represents a method that determines whether two tables' Izenda.AdHoc.Database.SqlTypes are compatible to join the tables.

Parameters: 

* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] type1  - The first [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] to check for join compatibility.
* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] type2  - The second [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] to check for join compatibility.





Returns:

True if the types are compatible, false if not.


---


###IsStandardFunctionsAvailable()
 Determines whether Oracle standard functions are available to query and obtain metadata for. 





Returns:

A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] representing whether standard functions are available or not.


---


###isUserFunction(System.String)
 Determines whether the object with the specified name is a user function or a system function for the specified database object. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] objectName  - The name of the database object to find on the database.





Returns:

A [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] returned from executing the database command.


---


###ParameterName(System.String)
Gets the ODBC formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] for the specified parameter name.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the parameter.





Returns:

The formatted parameter name.


---


###PrepareData(Izenda.AdHoc.Report)
 Represents a method that can be used to pre-process the report before the results are obtained from the database and the data is formatted. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that is to be processed.






---


###PrepareForArithmeticOperation(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression 






---


###PrepareForArithmeticOperation(System.String,Izenda.AdHoc.Database.SqlTypeGroup)
 Represents a method that safely converts the expression into a database type that can receive arithmetic operations. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL column or expression to prepare.
* [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] typeGroup  - The [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] to attempt to CAST to. Certain database types cannot be cast to for this purpose.





Returns:

The SQL formatted expression that allows arithmetic operations to be performed on it.


---


###RemoveConstraint(System.String,System.String)
 Represents a method that removes a primary/foreign key relationship between two tables' columns in the schema. Wildcards are not accepted and column names are case sensitive. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullyQualifiedPrimaryColumn  - The fully-qualified column name or wildcard to use as the primary(lefthand) table.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullyQualifiedForeignColumn  - The fully-qualified column name or wildcard to use as the foreign(righthand) table.





Returns:

True when the constraint was removed. When it could not be found or removed, this is false.


---


###RemoveConstraint(System.String,System.String,Izenda.AdHoc.Database.DatabaseSchema)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullyQualifiedPrimaryColumn 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullyQualifiedForeignColumn 
* [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] schema 






---


###StringToSqlName(System.String)
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the specified value that will be formatted to be acceptible as an DB2 identifier.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] str  - The table, view, or column name to be formatted as an DB2 identifier





Returns:

The value specified with DB2 style identifier notation.


---


###StringToSqlNameBySafetyDescription(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] str 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###UnPrepareData(Izenda.AdHoc.Report)
 Represents a method that can be used to post-process the report after the results are obtained from the database and the data is formatted. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that was processed.






---


###UpdateForm(System.String,System.String,System.String,System.String)
Updates the database table where reports are stored with the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML form used for the specified report.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the database table that holds saved reports.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that the HTML form belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] form  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML form that is to be saved with the report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantID  - The tenantID that the report belongs to.






---


###UpdateThumbnail(System.String,System.String)
Creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to update a report thumbnail image in the [[SavedReportsTable|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_SavedReportsTable]] on the database. When the command is created, set @param0 to the thumbnail image.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that the thumbnail belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantID  - The tenantID that the report belongs to.





Returns:

A [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be used to update a thumbnail.


---


###VerifyThumbnail(System.String,System.String)
Creates a [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be executed to find whether the specified report on the database has a thumbnail for it.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report that the thumbnail belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tenantID  - The tenant ID that the report belongs to.





Returns:

A [[System.Data.IDbCommand|http://msdn.microsoft.com/en-us/library/bt2afddc]] that can be used to verify a thumbnail exists for a report.


---


