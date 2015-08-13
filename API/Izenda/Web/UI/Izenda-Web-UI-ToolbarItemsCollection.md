#ToolbarItemsCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String[]|[[AllKeys|/API/Izenda/Web/UI/CodeSamples/Izenda_Web_UI_ToolbarItemsCollection_AllKeys]]| Gets a String array that contains all the keys in the collection. |[]|
|Array|[[AllValues|/API/Izenda/Web/UI/CodeSamples/Izenda_Web_UI_ToolbarItemsCollection_AllValues]]| Gets an Object array that contains all the values in the collection. |[]|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/25705c27]]|Gets the number of key/value pairs contained in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|0|
|Boolean|[[HasKeys|/API/Izenda/Web/UI/CodeSamples/Izenda_Web_UI_ToolbarItemsCollection_HasKeys]]| Gets a value indicating if the collection contains keys that are not null. |False|
|DictionaryEntry|[[Item|/API/Izenda/Web/UI/CodeSamples/Izenda_Web_UI_ToolbarItemsCollection_Item_-_System_Int32_-_]]| Gets a key-and-value pair (DictionaryEntry) using an index. |null|
|ToolbarItem|[[Item|/API/Izenda/Web/UI/CodeSamples/Izenda_Web_UI_ToolbarItemsCollection_Item_-_System_String_-_]]| Gets or sets the value associated with the specified key. |null|
|KeysCollection|[[Keys|http://msdn.microsoft.com/en-us/library/s4tkstha]]|Gets a [[System.Collections.Specialized.KeysCollection|http://msdn.microsoft.com/en-us/library/w37hzh9w]] instance that contains all the keys in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|{}|
|Toolbar|[[ParentToolbar|/API/Izenda/Web/UI/CodeSamples/Izenda_Web_UI_ToolbarItemsCollection_ParentToolbar]]| Gets or sets the toolbar that this collection belongs to. |null|


##Methods

###Add(System.String,Izenda.Web.UI.ToolbarItem)
 Adds an entry to the collection. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 
* [[Izenda.Web.UI.ToolbarItem|/API/Izenda/Web/UI/Izenda-Web-UI-ToolbarItem]] value 






---


###Clear()
 Clears all the elements in the collection. 






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


###IndexOf(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 






---


###Insert(System.Int32,System.String,Izenda.Web.UI.ToolbarItem)
 Insert into collection at specificied index. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 
* [[Izenda.Web.UI.ToolbarItem|/API/Izenda/Web/UI/Izenda-Web-UI-ToolbarItem]] value 






---


###OnDeserialization(System.Object)
Implements the [[System.Runtime.Serialization.ISerializable|http://msdn.microsoft.com/en-us/library/wf4375ks]] interface and raises the deserialization event when the deserialization is complete.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] sender  -  The source of the deserialization event. 






---


###Remove(System.String)
 Removes an entry with the specified key from the collection. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


