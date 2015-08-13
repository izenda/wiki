#IAggregateFunction

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Hashtable|[[AllowedTypeGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_IAggregateFunction_AllowedTypeGroups]]|Represents a list of key/value pairs that define the collection of Izenda.AdHoc.Database.SqlTypeGroups that are valid for this aggregation function.|inherited from concrete class|
|String|[[Caption|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_IAggregateFunction_Caption]]| Represents the display text that is used for this aggregation function. |inherited from concrete class|
|Hashtable|[[DisallowedTypeGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_IAggregateFunction_DisallowedTypeGroups]]|Represents a list of key/value pairs that define the collection of Izenda.AdHoc.Database.SqlTypeGroups that are not valid for this aggregation function.|inherited from concrete class|
|IFormatter[]|[[Formatters|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_IAggregateFunction_Formatters]]| Represents a set of formatters that can optionally be used to format the results of the aggregation function. |inherited from concrete class|
|Boolean|[[IsExtraFunction|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_IAggregateFunction_IsExtraFunction]]| Represents whether this function can be used in pivot column function lists. |inherited from concrete class|
|Boolean|[[IsGroup|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_IAggregateFunction_IsGroup]]| Represents whether this aggregate function requires grouping in order to be used. |inherited from concrete class|
|Boolean|[[IsScalar|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_IAggregateFunction_IsScalar]]| Represents whether or not this aggregation function is able to accept a group function. |inherited from concrete class|
|SqlType|[[OutputType|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_IAggregateFunction_OutputType]]| Represents the database type that the resulting output of the aggregate function will use. |inherited from concrete class|


##Methods

###CompatibilityWithFunction(System.Boolean)
 Represents a method that determines whether this aggregate function is compatible with pivots. 

Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isExtraFunction  - Whether the function list that the aggregation function is being added to is a pivot column function list.  When false then the function list is a standard aggregate function list.





Returns:

True when this aggregation function can be used with the aggregation function list that is being constructed.


---


###GetSQL(System.String,Izenda.AdHoc.Database.SqlType)
 Represents the method that builds the SQL expression for the aggregate function. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] innerExpression  - Represents the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value that should be wrapped in the aggregation function.
* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] type  - Represents the [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] that the original expression was typed with.





Returns:

The entire SQL statement that will be generated when the aggregation function is applied to the statement.


---


