#FormatterCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Capacity|http://msdn.microsoft.com/en-us/library/29z9bdyd]]|Gets or sets the number of elements that the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] can contain.|0|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/8beysaaa]]|Gets the number of elements contained in the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This property cannot be overridden.|0|
|IFormatter|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_FormatterCollection_Item_-_System_Int32_-_]]|Gets the [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] at the specified index.|null|


##Methods

###Add(Izenda.AdHoc.IFormatter)
Adds an item to the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]]

Parameters: 

* [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] value  - The [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] to add to the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]].





Returns:

The position into which the new element was inserted.


---


###Add(Izenda.AdHoc.FormatterCollection)
Adds a series of entries onto the end of the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]] instance.

Parameters: 

* [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]] value  - The [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]] value of the collection of entries to add.






---


###AddRange(Izenda.AdHoc.IFormatter[])
Adds a series of entries onto the end of the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]] instance.

Parameters: 

* [[Izenda.AdHoc.IFormatter[]|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter[]]] value  - The [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] array of values to add.






---


###Clear()
Removes all objects from the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This method cannot be overridden.






---


###Contains(Izenda.AdHoc.IFormatter)
Determines whether the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]] contains a specific value.

Parameters: 

* [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] value  - The [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] to locate in the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]].





Returns:

true if the [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] is found in the Izenda.AdHoc.FormatterCollection; otherwise, false.


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


###IndexOf(Izenda.AdHoc.IFormatter)
Determines the index of a specific item in the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]].

Parameters: 

* [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] value  - The System.Object to locate in the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]].





Returns:

The index of the value if the item is in the list; otherwise, -1.


---


###Insert(System.Int32,Izenda.AdHoc.IFormatter)
Inserts an item to the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]] at the specified index.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based index at which value should be inserted.
* [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] value  - The [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] to insert into the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]].






---


###Remove(Izenda.AdHoc.IFormatter)
Removes the first occurrence of a specific object from the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]].

Parameters: 

* [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] value  - The [[Izenda.AdHoc.IFormatter|/API/Izenda/AdHoc/Izenda-AdHoc-IFormatter]] to remove from the [[Izenda.AdHoc.FormatterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FormatterCollection]].






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


