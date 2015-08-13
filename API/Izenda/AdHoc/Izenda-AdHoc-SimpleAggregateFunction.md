#SimpleAggregateFunction

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Hashtable|[[AllowedTypeGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_AllowedTypeGroups]]|Gets a list of key/value pairs that define the collection of Izenda.AdHoc.Database.SqlTypeGroups that are valid for this aggregation function.|null|
|String|[[Caption|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_Caption]]| Gets the display text that is used for this aggregation function. |String.Empty|
|Hashtable|[[DisallowedTypeGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_DisallowedTypeGroups]]|Gets a list of key/value pairs that define the collection of Izenda.AdHoc.Database.SqlTypeGroups that are not valid for this aggregation function.|null|
|IFormatter[]|[[Formatters|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_Formatters]]| Gets a set of formatters that can optionally be used to format the results of the aggregation function. |[]|
|String|[[Function|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_Function]]|Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the raw SQL function that expressions will be wrapped with when using this aggregation function.|String.Empty|
|Boolean|[[IsExtraFunction|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_IsExtraFunction]]| Determines whether this function can be used in pivot column function lists. |False|
|Boolean|[[IsGroup|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_IsGroup]]| Determines whether this aggregate function requires grouping in order to be used. |False|
|Boolean|[[IsScalar|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_IsScalar]]| Determines whether or not this aggregation function is able to accept a group function. |False|
|SqlType|[[OutputType|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SimpleAggregateFunction_OutputType]]| Gets the database type that the resulting output of the aggregate function will use. |Unknown|


##Methods

###CompatibilityWithFunction(System.Boolean)
 Represents a method that determines whether this aggregate function is compatible with pivots. 

Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isExtraFunction  - Whether the function list that the aggregation function is being added to is a pivot column function list.  When false then the function list is a standard aggregate function list.





Returns:

True when this aggregation function can be used with the aggregation function list that is being constructed.


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


###GetSQL(System.String,Izenda.AdHoc.Database.SqlType)
 Represents the method that builds the SQL expression for the aggregate function. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] innerExpression  - Represents the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value that should be wrapped in the aggregation function.
* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] type  - Represents the [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] that the original expression was typed with.





Returns:

The entire SQL statement that will be generated when the aggregation function is applied to the statement.


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


