#HiddenFilterCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Count|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_HiddenFilterCollection_Count]]|Gets the number of elements contained in the [[Izenda.AdHoc.HiddenFilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenFilterCollection]].|0|
|Object|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_HiddenFilterCollection_Item_-_System_String_-_]]| Gets or sets the element with the specified key. |null|
|ICollection|[[Keys|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_HiddenFilterCollection_Keys]]|Gets an [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] containing the username keys in the [[Izenda.AdHoc.HiddenFilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenFilterCollection]].|null|
|ICollection|[[Values|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_HiddenFilterCollection_Values]]|Gets an [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] containing the values in the [[Izenda.AdHoc.HiddenFilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenFilterCollection]].|null|


##Methods

###Add(System.String,System.Object)
Adds an item to the [[Izenda.AdHoc.HiddenFilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenFilterCollection]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The username key of the value to add.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - [[Izenda.AdHoc.CustomTimePeriod|/API/Izenda/AdHoc/Izenda-AdHoc-CustomTimePeriod]] to add.






---


###Clear()
 Removes all items. 






---


###ContainsKey(System.String)
Determines whether the [[Izenda.AdHoc.HiddenFilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenFilterCollection]] contains a specific username key.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The username key to locate.





Returns:

true if the key is found;otherwise, false. 


---


###ContainsKey(System.Object)
Determines whether the [[Izenda.AdHoc.HiddenFilterCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenFilterCollection]] contains a specific value.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value to locate.





Returns:

true if the value is found;otherwise, false. 


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetEnumerator()
 Returns an enumerator that iterates through a collection. 






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


###Remove(System.String)
 Removes the hidden filter value with the specified username key. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The username key of the hidden filter to remove.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


