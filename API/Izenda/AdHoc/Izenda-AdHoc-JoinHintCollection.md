#JoinHintCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Capacity|http://msdn.microsoft.com/en-us/library/29z9bdyd]]|Gets or sets the number of elements that the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] can contain.|0|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/8beysaaa]]|Gets the number of elements contained in the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This property cannot be overridden.|0|
|JoinHint|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_JoinHintCollection_Item_-_System_Int32_-_]]|Gets or sets the [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] at the specified index.|null|


##Methods

###Add(Izenda.AdHoc.JoinHint)
Appends the specified [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] onto the end of the collection of join hints.

Parameters: 

* [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] value  - The join hint to add to the collection.





Returns:

The index at which the value was added.


---


###Add(System.String,System.String,System.String)
Appends a new [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] onto the end of the collection using the specified parameters.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] leftTable  - The lefthand (primary) table that will be used in the join.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] rightTable  - The righthand (foreign) table that will be used in the join.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] conditionSql  - The SQL string that will be used to build the ON clause for the join.





Returns:

The index at which the value was added.


---


###Clear()
Removes all objects from the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This method cannot be overridden.






---


###Contains(Izenda.AdHoc.JoinHint)
 Determines whether the collection contains a specific value. 

Parameters: 

* [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] value  - The [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] to locate in the collection.






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetEnumerator()
Returns an enumerator that iterates through the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance.





Returns:

An [[System.Collections.IEnumerator|http://msdn.microsoft.com/en-us/library/1t2267t6]] for the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###IndexOf(Izenda.AdHoc.JoinHint)
 Determines the index of a specific item in the collection. 

Parameters: 

* [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] value  - The [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] to locate in the collection.





Returns:

The index of value if found in the list; otherwise, -1.


---


###Insert(System.Int32,Izenda.AdHoc.JoinHint)
 Inserts an item into the collection at the specified position. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based index at which the value should be inserted.
* [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] value  - The [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] to insert into the collection.






---


###Remove(Izenda.AdHoc.JoinHint)
Removes the first occurrence of a specific [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] from the collection.

Parameters: 

* [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] value  - The [[Izenda.AdHoc.JoinHint|/API/Izenda/AdHoc/Izenda-AdHoc-JoinHint]] to remove from the collection.






---


###RemoveAt(System.Int32)
Removes the element at the specified index of the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This method is not overridable.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index of the element to remove. 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


