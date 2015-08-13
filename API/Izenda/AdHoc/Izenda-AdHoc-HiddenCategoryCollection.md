#HiddenCategoryCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Count|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_HiddenCategoryCollection_Count]]|Gets the number of elements contained in the [[Izenda.AdHoc.HiddenCategoryCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenCategoryCollection]].|0|
|String[]|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_HiddenCategoryCollection_Item_-_System_String_-_]]| Gets or sets the element with the specified username key. |null|
|ICollection|[[Keys|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_HiddenCategoryCollection_Keys]]|Gets an [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] object containing the username keys in the [[Izenda.AdHoc.HiddenCategoryCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenCategoryCollection]].|null|
|ICollection|[[Values|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_HiddenCategoryCollection_Values]]|Gets an [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] object containing the values in the [[Izenda.AdHoc.HiddenCategoryCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenCategoryCollection]].|null|


##Methods

###Add(System.String,System.Object)
Adds an item to the [[Izenda.AdHoc.HiddenCategoryCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenCategoryCollection]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The username that will be used for this category.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the category to add.






---


###Clear()
 Removes all items. 






---


###ContainsKey(System.String)
Determines whether the [[Izenda.AdHoc.HiddenCategoryCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenCategoryCollection]] contains a specific username key.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The username key to locate.





Returns:

true if the key is found;otherwise, false. 


---


###ContainsKey(System.Object)
Determines whether the [[Izenda.AdHoc.HiddenCategoryCollection|/API/Izenda/AdHoc/Izenda-AdHoc-HiddenCategoryCollection]] contains the specified category.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] representation of the category to locate.





Returns:

true if the category is found;otherwise, false. 


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetEnumerator()
 Returns an enumerator that iterates through the collection of hidden categories. 






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
 Removes the category with the specified username key. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The username key of the category to remove.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


