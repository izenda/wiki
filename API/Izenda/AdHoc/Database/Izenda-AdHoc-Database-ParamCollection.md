#ParamCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String[]|[[AllKeys|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_ParamCollection_AllKeys]]|Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array that contains all the keys  in the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance.|null|
|Array|[[AllValues|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_ParamCollection_AllValues]]|Returns an [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] array that contains all the values  in the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance.|null|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/25705c27]]|Gets the number of key/value pairs contained in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|null|
|Boolean|[[HasKeys|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_ParamCollection_HasKeys]]|Gets a value indicating whether the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance  contains entries whose keys are not a null reference|null|
|Param|[[Item|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_ParamCollection_Item_-_System_Int32_-_]]|Gets the [[Izenda.AdHoc.Database.Param|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Param]] at the specified index  of the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance.|null|
|Param|[[Item|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_ParamCollection_Item_-_System_String_-_]]|Gets the value of the first entry with the specified key  from the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance.|null|
|KeysCollection|[[Keys|http://msdn.microsoft.com/en-us/library/s4tkstha]]|Gets a [[System.Collections.Specialized.KeysCollection|http://msdn.microsoft.com/en-us/library/w37hzh9w]] instance that contains all the keys in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|null|
|StoredProcedure|[[StoredProcedure|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_ParamCollection_StoredProcedure]]|Gets or sets the [[Izenda.AdHoc.Database.StoredProcedure|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-StoredProcedure]] this [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] is associated with.|null|


##Methods

###Add(System.String,Izenda.AdHoc.Database.Param)
Adds an entry with the specified key and value into the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the entry to add.
* [[Izenda.AdHoc.Database.Param|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Param]] value  - The [[Izenda.AdHoc.Database.Param|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Param]] value of the entry to add.






---


###Clear()
Removes all entries from the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance.






---


###Contains(Izenda.AdHoc.Database.Param)
Determines whether the specified [[Izenda.AdHoc.Database.Param|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Param]] can be found in the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]].

Parameters: 

* [[Izenda.AdHoc.Database.Param|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Param]] value  - The [[Izenda.AdHoc.Database.Param|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Param]] to check for.






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetEnumerator()
Returns an enumerator that iterates through the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]].





Returns:

An [[System.Collections.IEnumerator|http://msdn.microsoft.com/en-us/library/1t2267t6]] for the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
Implements the [[System.Runtime.Serialization.ISerializable|http://msdn.microsoft.com/en-us/library/wf4375ks]] interface and returns the data needed to serialize the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.

Parameters: 

* [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] info  - A [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] object that contains the information required to serialize the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.
* [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] context  - A [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] object that contains the source and destination of the serialized stream associated with the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.






---


###GetSchema()
 Gets the XML schema. 





Returns:

XML schema of this object.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###OnDeserialization(System.Object)
Implements the [[System.Runtime.Serialization.ISerializable|http://msdn.microsoft.com/en-us/library/wf4375ks]] interface and raises the deserialization event when the deserialization is complete.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] sender  -  The source of the deserialization event. 






---


###ReadXml(System.Xml.XmlReader)
Creates a new [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] from the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] with parameter collection information stored to it.

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The source [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] that will be read to obtain the column information.






---


###Remove(System.String)
Removes the entries with the specified key from the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the entries to remove.






---


###Remove(System.Int32)
Removes the entry at the specified index of the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] instance.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based index of the entry to remove.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###WriteXml(System.Xml.XmlWriter)
Writes the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]] to the provided [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]].

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] object that will be used to serialize the [[Izenda.AdHoc.Database.ParamCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ParamCollection]].






---


