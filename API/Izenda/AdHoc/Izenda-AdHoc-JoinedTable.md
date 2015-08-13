#JoinedTable

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|List|[[AdditionalConstraints|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_AdditionalConstraints]]||null|
|Column|[[DbLeftConditionColumn|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_DbLeftConditionColumn]]||null|
|Column|[[DbRightConditionColumn|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_DbRightConditionColumn]]||null|
|Table|[[DbRightConditionTable|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_DbRightConditionTable]]||null|
|Table|[[DbTable|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_DbTable]]| Gets or sets the database table for this join. This will also function as the lefthand table in multi-table reports. |null|
|String|[[LeftConditionColumn|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_LeftConditionColumn]]| Gets or sets the column name of the lefthand table, if any. Single table reports do not need this information. |null|
|String|[[RightConditionColumn|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_RightConditionColumn]]| Gets or sets the column name of the righthand table, if any. Single table reports do not need this information. |null|
|String|[[RightConditionTable|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_RightConditionTable]]| Gets or sets the table name of the righthand table, if any. Single table reports do not need this information. |null|
|String|[[TableName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinedTable_TableName]]| Gets or sets the name of the table for this join. |null|


##Methods

###AddAdditionalConstraint(System.String,System.String,Izenda.AdHoc.ConditionOperator)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] leftColumn 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] rightColumn 
* [[Izenda.AdHoc.ConditionOperator|/API/Izenda/AdHoc/Izenda-AdHoc-ConditionOperator]] oper 






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


###GetSchema()
 Gets the XML schema. 





Returns:

XML schema of this object.


---


###GetSQL(Izenda.AdHoc.JoinedTable,System.Boolean,System.Collections.Generic.ICollection&lt;System.String&gt;,System.Collections.Generic.ICollection&lt;Izenda.AdHoc.Filter&gt;,Izenda.AdHoc.FilterCollection,System.Boolean)


Parameters: 

* [[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]] lastJoin 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] firstTime 
* [[System.Collections.Generic.ICollection|http://msdn.microsoft.com/en-us/library/92t2ye13]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; previusTables 
* [[System.Collections.Generic.ICollection|http://msdn.microsoft.com/en-us/library/92t2ye13]]&lt;[[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]]&gt; filters 
* [[Izenda.AdHoc.FilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FilterCollection]] tableRelatedFilters 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] reportSetHasFilterLogic 






---


###GetSQL(Izenda.AdHoc.JoinedTable,System.Boolean,System.Collections.Generic.ICollection&lt;System.String&gt;,System.Collections.Generic.ICollection&lt;Izenda.AdHoc.Filter&gt;,Izenda.AdHoc.FilterCollection,System.Boolean,System.Boolean)


Parameters: 

* [[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]] lastJoin 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] firstTime 
* [[System.Collections.Generic.ICollection|http://msdn.microsoft.com/en-us/library/92t2ye13]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; previusTables 
* [[System.Collections.Generic.ICollection|http://msdn.microsoft.com/en-us/library/92t2ye13]]&lt;[[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]]&gt; filters 
* [[Izenda.AdHoc.FilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FilterCollection]] tableRelatedFilters 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] reportSetHasFilterLogic 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] useAutoConditions 






---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###ReadXml(System.String)
Reads XML data into the [[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]] from the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] from which to read.






---


###ReadXml(System.Xml.XmlReader)
Reads XML data into the [[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]] using the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]].

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] from which to read.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###WriteXml()
Writes the current data of the [[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]] to the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] and returns it.





Returns:

The XML formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] for the joined table.


---


###WriteXml(System.Xml.XmlWriter)
Writes the current data of the [[Izenda.AdHoc.JoinedTable|/API/Izenda/AdHoc/Izenda-AdHoc-JoinedTable]] to the specified XmlWriter.

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] with which to write.






---


