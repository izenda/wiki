#TableFormatResultCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Capacity|http://msdn.microsoft.com/en-us/library/29z9bdyd]]|Gets or sets the number of elements that the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] can contain.|0|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/8beysaaa]]|Gets the number of elements contained in the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This property cannot be overridden.|0|
|DataTable|[[FormattedSource|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_TableFormatResultCollection_FormattedSource]]| Gets or sets the formatted source data table that is associated with this collection. |null|
|TableFormatResult|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_TableFormatResultCollection_Item_-_System_Int32_-_]]| Gets or sets the item in the list at the specified index. |null|
|String[]|[[PivotColumns|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_TableFormatResultCollection_PivotColumns]]| Gets or sets the array of pivot columns in the source data if pivots are used. |null|
|DataTable|[[Source|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_TableFormatResultCollection_Source]]| Gets or sets the unformatted source data that is associated with this collection. |null|


##Methods

###Add(Izenda.AdHoc.TableFormatResult)
 Adds the item to the end of the list. 

Parameters: 

* [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] value  - The [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] to add to the [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]].





Returns:

The position into which the new element was inserted.


---


###Add(Izenda.AdHoc.TableFormatResultCollection)
 Adds all the elements in the source collection to the end of the list. 

Parameters: 

* [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]] value  - The collection of [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] objects to add to the list.






---


###Clear()
Removes all objects from the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This method cannot be overridden.






---


###Contains(Izenda.AdHoc.TableFormatResult)
 Determines whether the System.Collections.IList contains a specific value. 

Parameters: 

* [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] value  - The [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] to locate in the [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]].





Returns:

true if the System.Object is found in the System.Collections.IList; otherwise, false.


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


###IndexOf(Izenda.AdHoc.TableFormatResult)
 Gets the index of the specified item. 

Parameters: 

* [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] value  - The [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] to check for.





Returns:

The index of the item if it was found in the list; otherwise, -1.


---


###Insert(System.Int32,Izenda.AdHoc.TableFormatResult)
 Inserts the item into the list at the specified index. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based index at which value should be inserted.
* [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] value  - The [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] to insert into the [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]].






---


###Remove(Izenda.AdHoc.TableFormatResult)
Removes the first occurrence of the specified [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] from the [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]].

Parameters: 

* [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] value  - The [[Izenda.AdHoc.TableFormatResult|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResult]] to remove from the [[Izenda.AdHoc.TableFormatResultCollection|/API/Izenda/AdHoc/Izenda-AdHoc-TableFormatResultCollection]].






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


