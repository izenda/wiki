#DataTableCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Capacity|http://msdn.microsoft.com/en-us/library/29z9bdyd]]|Gets or sets the number of elements that the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] can contain.|0|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/8beysaaa]]|Gets the number of elements contained in the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This property cannot be overridden.|0|
|DataTable|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_DataTableCollection_Item_-_System_Int32_-_]]|Gets or sets the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] at the specified index  of the [[Izenda.AdHoc.DataTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-DataTableCollection]] instance.|null|


##Methods

###Add(System.Data.DataTable)
 Adds an entry with the specified key and value into the AdHoc.DataSetCollection instance. 

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] value  - The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] value of the entry to add.





Returns:

The System.Integer index that the new item occupies.


---


###Add(Izenda.AdHoc.DataTableCollection)
 Adds a series of entries onto the end of the AdHoc.DataSetCollection instance. 

Parameters: 

* [[Izenda.AdHoc.DataTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-DataTableCollection]] value  - The [[Izenda.AdHoc.DataTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-DataTableCollection]] value of the collection of entries to add.






---


###Clear()
Removes all objects from the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This method cannot be overridden.






---


###Contains(System.Data.DataTable)
 Determines whether an element is in the collection. 

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] value  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to locate in the collection.






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


###IndexOf(System.Data.DataTable)
Determines the index of the specified [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] object.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] value  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] value to search for in the collection.





Returns:

The zero-based index of the item in the collection.


---


###Insert(System.Int32,System.Data.DataTable)
Inserts a [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] into the collection at the specified index.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based index at which the item should be inserted.
* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] value  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to insert into the collection.






---


###Remove(System.Data.DataTable)
Removes the first occurance of the specified [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] from the collection.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] value  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to remove from the collection.






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


