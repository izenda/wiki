#NameDistinctValueCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String[]|[[AllKeys|http://msdn.microsoft.com/en-us/library/2bbhay2d]]|Gets all the keys in the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]].|[]|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/25705c27]]|Gets the number of key/value pairs contained in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|0|
|String|[[Item|http://msdn.microsoft.com/en-us/library/8d0bzeeb]]||null|
|String|[[Item|http://msdn.microsoft.com/en-us/library/53hx6h17]]||null|
|KeysCollection|[[Keys|http://msdn.microsoft.com/en-us/library/s4tkstha]]|Gets a [[System.Collections.Specialized.KeysCollection|http://msdn.microsoft.com/en-us/library/w37hzh9w]] instance that contains all the keys in the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.|{}|


##Methods

###Add(System.String,System.String)
Adds a new item to the end of the collection with the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key and value.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The key that will be used to identify this item. If the key already exists, the value will be overwritten.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value to be associated with the key.






---


###Add(System.Collections.Specialized.NameValueCollection)
Copies the entries in the specified [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]] to the current [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]].

Parameters: 

* [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]] c  - The [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]] to copy to the current [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]].






---


###Clear()
Invalidates the cached arrays and removes all entries from the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]].






---


###CopyTo(System.Array,System.Int32)
Copies the entire [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]] to a compatible one-dimensional System.Array, starting at the specified index of the target array.

Parameters: 

* [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] dest  - The one-dimensional [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] that is the destination of the elements copied from [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]]. The [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] must have zero-based indexing.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index in <paramref name="dest at which copying begins. 






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###Get(System.String)
Gets the values associated with the specified key from the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]] combined into one comma-separated list.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the entry that contains the values to get. The key can be null.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that contains a comma-separated list of the values associated with the specified key from the System.Collections.Specialized.NameValueCollection, if found; otherwise, null.


---


###Get(System.Int32)
Gets the values at the specified index of the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]] combined into one comma-separated list.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index of the entry that contains the values to get from the collection. 





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that contains a comma-separated list of the values at the specified index of the System.Collections.Specialized.NameValueCollection, if found; otherwise, null.


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


###GetKey(System.Int32)
Gets the key at the specified index of the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]].

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index of the key to get from the collection. 





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that contains the key at the specified index of the System.Collections.Specialized.NameValueCollection, if found; otherwise, null.


---


###GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
 Implements the System.Runtime.SerializationISerializable interface with the data needed to serialize the AdHoc.NameDistinctValueCollection instance. 

Parameters: 

* [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] info  - The serialized information of the AdHoc.Collections.NameDistinctValueCollection.
* [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] context  - The source and destination context in which the collection should be obtained. Null signifies no context.






---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetValues(System.String)
Gets the values associated with the specified key from the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the entry that contains the values to get. The key can be null.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array that contains the values associated with the specified key from the System.Collections.Specialized.NameValueCollection, if found; otherwise, null.


---


###GetValues(System.Int32)
Gets the values at the specified index of the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]].

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index of the entry that contains the values to get from the collection. 





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array that contains the values at the specified index of the System.Collections.Specialized.NameValueCollection, if found; otherwise, null.


---


###HasKeys()
Gets a value indicating whether the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]] contains keys that are not null.





Returns:

true if the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]] contains keys that are not null; otherwise, false.


---


###OnDeserialization(System.Object)
Implements the [[System.Runtime.Serialization.ISerializable|http://msdn.microsoft.com/en-us/library/wf4375ks]] interface and raises the deserialization event when the deserialization is complete.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] sender  -  The source of the deserialization event. 






---


###Remove(System.String)
Removes the entries with the specified key from the [[System.Collections.Specialized.NameObjectCollectionBase|http://msdn.microsoft.com/en-us/library/ts6a60s4]] instance.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the entry to remove. The key can be null.






---


###Set(System.String,System.String)
Sets the value of an entry in the [[System.Collections.Specialized.NameValueCollection|http://msdn.microsoft.com/en-us/library/689y5thy]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the entry to add the new value to. The key can be null.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] that represents the new value to add to the specified entry. The value can be null.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


