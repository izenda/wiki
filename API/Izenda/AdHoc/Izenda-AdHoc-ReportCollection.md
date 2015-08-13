#ReportCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String[]|[[AllKeys|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportCollection_AllKeys]]|Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array that contains all the keys  in the [[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]] instance.|[]|
|Array|[[AllValues|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportCollection_AllValues]]|Returns an [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] array that contains all the values  in the [[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]] instance.|[]|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/25705c27]]|Gets the number of key/value pairs contained in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|0|
|Boolean|[[HasKeys|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportCollection_HasKeys]]|Gets a value indicating whether the [[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]] instance  contains entries whose keys are not a null reference|False|
|Report|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportCollection_Item_-_System_String_-_]]|Gets the value of the first entry with the specified key  from the [[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]] instance.|null|
|Report|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportCollection_Item_-_System_Int32_-_]]||null|
|KeysCollection|[[Keys|http://msdn.microsoft.com/en-us/library/s4tkstha]]|Gets a [[System.Collections.Specialized.KeysCollection|http://msdn.microsoft.com/en-us/library/w37hzh9w]] instance that contains all the keys in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|{}|
|ReportSet|[[ReportSet|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportCollection_ReportSet]]||null|


##Methods

###Add(System.String,Izenda.AdHoc.Report)
Adds an entry with the specified key and value into the [[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]] instance.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the entry to add.
* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] value  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] value of the entry to add.






---


###Clear()
Removes all entries from the [[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]] instance.






---


###Contains(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName 






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


###GetPosition(System.Int32,System.Int32[],System.Int32[])


Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] newWeight 
* [[System.Int32[]|http://msdn.microsoft.com/en-us/library/td2s409d]] weights 
* [[System.Int32[]|http://msdn.microsoft.com/en-us/library/td2s409d]] positions 






---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetWeight(System.String,System.Collections.Specialized.StringCollection)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name 
* [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]] reportOrders 






---


###OnDeserialization(System.Object)
Implements the [[System.Runtime.Serialization.ISerializable|http://msdn.microsoft.com/en-us/library/wf4375ks]] interface and raises the deserialization event when the deserialization is complete.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] sender  -  The source of the deserialization event. 






---


###Remove(System.String)
Removes the entries with the specified key from the [[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]] instance.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the entries to remove.






---


###Remove(System.Int32)
Removes the entry at the specified index of the [[Izenda.AdHoc.ReportCollection|/API/Izenda/AdHoc/Izenda-AdHoc-ReportCollection]] instance.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based index of the entry to remove.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


