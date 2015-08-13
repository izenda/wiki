#ShapeCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|IEqualityComparer|[[Comparer|http://msdn.microsoft.com/en-us/library/ms132092]]|Gets the [[System.Collections.Generic.IEqualityComparer|http://msdn.microsoft.com/en-us/library/ms132151]] that is used to determine equality of keys for the dictionary.|null|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/zhcy256f]]|Gets the number of key/value pairs contained in the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]].|0|
|String|[[Item|about:blank]]||null|
|KeyCollection|[[Keys|http://msdn.microsoft.com/en-us/library/yt2fy5zk]]|Gets a collection containing the keys in the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]].|null|
|ValueCollection|[[Values|http://msdn.microsoft.com/en-us/library/ekcfxy3x]]|Gets a collection containing the values in the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]].|null|


##Methods

###Add(System.String,System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value 






---


###Clear()
Removes all keys and values from the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]].






---


###ContainsKey(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 






---


###ContainsValue(System.String)
Determines whether the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]] contains a specific value.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - The value to locate in the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]]. The value can be null for reference types.





Returns:

true if the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]] contains an element with the specified value; otherwise, false.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetEnumerator()
Returns an enumerator that iterates through the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]].





Returns:

A [[System.Collections.Generic.Enumerator|About:blank]] structure for the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]].


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
Implements the [[System.Runtime.Serialization.ISerializable|http://msdn.microsoft.com/en-us/library/wf4375ks]] interface and returns the data needed to serialize the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]] instance.

Parameters: 

* [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] info  - A [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] object that contains the information required to serialize the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]] instance.
* [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] context  - A [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] structure that contains the source and destination of the serialized stream associated with the [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]] instance.






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


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###TryGetValue(System.String,out System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value 






---


