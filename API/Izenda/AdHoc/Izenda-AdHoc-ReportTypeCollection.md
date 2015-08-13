#ReportTypeCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String[]|[[AllKeys|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportTypeCollection_AllKeys]]|Gets a list of the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] keys that are contained in the collection.|[]|
|Array|[[AllValues|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportTypeCollection_AllValues]]|Gets a list of all the [[Izenda.AdHoc.ReportType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportType]] values that are contained in the collection.|[]|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/25705c27]]|Gets the number of key/value pairs contained in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|0|
|Boolean|[[HasKeys|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportTypeCollection_HasKeys]]| Determines whether the collection contains any keys. |False|
|ReportType|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportTypeCollection_Item_-_System_String_-_]]|Gets or sets the [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] in the collection using the specified key.|null|
|KeysCollection|[[Keys|http://msdn.microsoft.com/en-us/library/s4tkstha]]|Gets a [[System.Collections.Specialized.KeysCollection|http://msdn.microsoft.com/en-us/library/w37hzh9w]] instance that contains all the keys in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|{}|


##Methods

###Add(System.String,Izenda.AdHoc.ReportType)
Appends the specified [[Izenda.AdHoc.ReportType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportType]] to the end of the collection.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key to insert into the collection.
* [[Izenda.AdHoc.ReportType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportType]] value  - The [[Izenda.AdHoc.ReportType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportType]] to insert into the collection.






---


###Clear()
 Removes all items from the collection. 






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


###Remove(System.String)
Removes the specified [[Izenda.AdHoc.ReportType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportType]] from the collection based on its key.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 






---


###Remove(System.Int32)
Removes the specified [[Izenda.AdHoc.ReportType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportType]] from the collection based on its key.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The System.Integer index of the Izenda.AdHoc.ReportType to remove.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


