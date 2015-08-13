#DataSetNameCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Capacity|http://msdn.microsoft.com/en-us/library/3d07z4fy]]|Gets or sets the number of elements that the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] can contain.|0|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/7zkh13cf]]|Gets the number of elements actually contained in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].|0|
|Boolean|[[IsFixedSize|http://msdn.microsoft.com/en-us/library/4y8fswcc]]|Gets a value indicating whether the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] has a fixed size.|False|
|Boolean|[[IsReadOnly|http://msdn.microsoft.com/en-us/library/fd64d8bs]]|Gets a value indicating whether the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] is read-only.|False|
|Boolean|[[IsSynchronized|http://msdn.microsoft.com/en-us/library/cx2sc7wy]]|Gets a value indicating whether access to the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] is synchronized (thread safe).|False|
|String|[[Item|/API/Rdl/CodeSamples/Rdl_DataSetNameCollection_Item_-_System_Int32_-_]]||null|
|Object|[[Item|http://msdn.microsoft.com/en-us/library/csc83bfy]]||null|
|Object|[[SyncRoot|http://msdn.microsoft.com/en-us/library/582s93ys]]|Gets an object that can be used to synchronize access to the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].|null|


##Methods

###Add(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] obj 






---


###Add(System.Object)
Adds an object to the end of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to be added to the end of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.





Returns:

The [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] index at which the <paramref name="value has been added.


---


###AddRange(System.Collections.ICollection)
Adds the elements of an [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] to the end of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] c  - The [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] whose elements should be added to the end of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The collection itself cannot be null, but it can contain elements that are null.






---


###BinarySearch(System.Int32,System.Int32,System.Object,System.Collections.IComparer)
Searches a range of elements in the sorted [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] for an element using the specified comparer and returns the zero-based index of the element.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based starting index of the range to search.  
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  -  The length of the range to search.  
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate. The value can be null.
* [[System.Collections.IComparer|http://msdn.microsoft.com/en-us/library/twxabsb7]] comparer  - The [[System.Collections.IComparer|http://msdn.microsoft.com/en-us/library/twxabsb7]] implementation to use when comparing elements.  -or-  null to use the default comparer that is the [[System.IComparable|http://msdn.microsoft.com/en-us/library/ey2t2ys5]] implementation of each element.






---


###BinarySearch(System.Object)
Searches the entire sorted [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] for an element using the default comparer and returns the zero-based index of the element.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate. The value can be null.






---


###BinarySearch(System.Object,System.Collections.IComparer)
Searches the entire sorted [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] for an element using the specified comparer and returns the zero-based index of the element.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate. The value can be null.
* [[System.Collections.IComparer|http://msdn.microsoft.com/en-us/library/twxabsb7]] comparer  - The [[System.Collections.IComparer|http://msdn.microsoft.com/en-us/library/twxabsb7]] implementation to use when comparing elements.  -or-  null to use the default comparer that is the [[System.IComparable|http://msdn.microsoft.com/en-us/library/ey2t2ys5]] implementation of each element.






---


###Clear()
Removes all elements from the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].






---


###Clone()
Creates a shallow copy of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].





Returns:

A shallow copy of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].


---


###Contains(System.Object)
Determines whether an element is in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] item  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.






---


###CopyTo(System.Array)
Copies the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] to a compatible one-dimensional System.Array, starting at the beginning of the target array.

Parameters: 

* [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] array  - The one-dimensional [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] that is the destination of the elements copied from [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] must have zero-based indexing.






---


###CopyTo(System.Array,System.Int32)
Copies the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] to a compatible one-dimensional System.Array, starting at the specified index of the target array.

Parameters: 

* [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] array  - The one-dimensional [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] that is the destination of the elements copied from [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] must have zero-based indexing.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] arrayIndex  -  The zero-based index in <paramref name="array at which copying begins.  






---


###CopyTo(System.Int32,System.Array,System.Int32,System.Int32)
Copies a range of elements from the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] to a compatible one-dimensional System.Array, starting at the specified index of the target array.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based index in the source [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] at which copying begins.
* [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] array  - The one-dimensional [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] that is the destination of the elements copied from [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] must have zero-based indexing.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] arrayIndex  -  The zero-based index in <paramref name="array at which copying begins.  
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  -  The number of elements to copy.  






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetEnumerator()
Returns an enumerator for the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].





Returns:

An [[System.Collections.IEnumerator|http://msdn.microsoft.com/en-us/library/1t2267t6]] for the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].


---


###GetEnumerator(System.Int32,System.Int32)
Returns an enumerator for a range of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based starting index of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] section that the enumerator should refer to.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  - The number of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] section that the enumerator should refer to.





Returns:

An [[System.Collections.IEnumerator|http://msdn.microsoft.com/en-us/library/1t2267t6]] for the specified range of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetRange(System.Int32,System.Int32)
Returns an [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] which represents a subset of the elements in the source [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] index at which the range starts.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  -  The number of elements in the range.  





Returns:

An [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] which represents a subset of the elements in the source [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###IndexOf(System.Object)
Searches for the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] and returns the zero-based index of the first occurrence within the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.






---


###IndexOf(System.Object,System.Int32)
Searches for the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] and returns the zero-based index of the first occurrence within the range of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] that extends from the specified index to the last element.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] startIndex  -  The zero-based starting index of the search.  






---


###IndexOf(System.Object,System.Int32,System.Int32)
Searches for the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] and returns the zero-based index of the first occurrence within the range of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] that starts at the specified index and contains the specified number of elements.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] startIndex  -  The zero-based starting index of the search.  
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  -  The number of elements in the section to search.  






---


###Insert(System.Int32,System.String)


Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] obj 






---


###Insert(System.Int32,System.Object)
Inserts an element into the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] at the specified index.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index at which <paramref name="value should be inserted.  
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to insert. The value can be null.






---


###InsertRange(System.Int32,System.Collections.ICollection)
Inserts the elements of a collection into the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] at the specified index.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index at which the new elements should be inserted.  
* [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] c  - The [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] whose elements should be inserted into the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The collection itself cannot be null, but it can contain elements that are null.






---


###LastIndexOf(System.Object)
Searches for the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] and returns the zero-based index of the last occurrence within the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.






---


###LastIndexOf(System.Object,System.Int32)
Searches for the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] and returns the zero-based index of the last occurrence within the range of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] that extends from the first element to the specified index.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] startIndex  -  The zero-based starting index of the backward search.  






---


###LastIndexOf(System.Object,System.Int32,System.Int32)
Searches for the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] and returns the zero-based index of the last occurrence within the range of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] that contains the specified number of elements and ends at the specified index.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to locate in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] startIndex  -  The zero-based starting index of the backward search.  
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  -  The number of elements in the section to search.  






---


###Remove(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] obj 






---


###Remove(System.Object)
Removes the first occurrence of a specific object from the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to remove from the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The value can be null.






---


###RemoveAt(System.Int32)
Removes the element at the specified index of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index of the element to remove.  






---


###RemoveRange(System.Int32,System.Int32)
Removes a range of elements from the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based starting index of the range of elements to remove.  
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  -  The number of elements to remove.  






---


###Reverse()
Reverses the order of the elements in the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].






---


###Reverse(System.Int32,System.Int32)
 Reverses the order of the elements in the specified range. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based starting index of the range to reverse.  
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  -  The number of elements in the range to reverse.  






---


###SetRange(System.Int32,System.Collections.ICollection)
Copies the elements of a collection over a range of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The zero-based [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] index at which to start copying the elements of <paramref name="c.
* [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] c  - The [[System.Collections.ICollection|http://msdn.microsoft.com/en-us/library/b1ht6113]] whose elements to copy to the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]]. The collection itself cannot be null, but it can contain elements that are null.






---


###Sort()
Sorts the elements in the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] using the [[System.IComparable|http://msdn.microsoft.com/en-us/library/ey2t2ys5]] implementation of each element.






---


###Sort(System.Collections.IComparer)
Sorts the elements in the entire [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] using the specified comparer.

Parameters: 

* [[System.Collections.IComparer|http://msdn.microsoft.com/en-us/library/twxabsb7]] comparer  - The [[System.Collections.IComparer|http://msdn.microsoft.com/en-us/library/twxabsb7]] implementation to use when comparing elements.  -or-  null to use the [[System.IComparable|http://msdn.microsoft.com/en-us/library/ey2t2ys5]] implementation of each element.






---


###Sort(System.Int32,System.Int32,System.Collections.IComparer)
Sorts the elements in a range of elements in [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] using the specified comparer.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based starting index of the range to sort.  
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count  -  The length of the range to sort.  
* [[System.Collections.IComparer|http://msdn.microsoft.com/en-us/library/twxabsb7]] comparer  - The [[System.Collections.IComparer|http://msdn.microsoft.com/en-us/library/twxabsb7]] implementation to use when comparing elements.  -or-  null to use the [[System.IComparable|http://msdn.microsoft.com/en-us/library/ey2t2ys5]] implementation of each element.






---


###ToArray()
Copies the elements of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] to a new [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] array.





Returns:

An [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] array containing copies of the elements of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].


---


###ToArray(System.Type)
Copies the elements of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] to a new array of the specified element type.

Parameters: 

* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] type  - The element [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the destination array to create and copy elements to.





Returns:

An array of the specified element type containing copies of the elements of the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###TrimToSize()
Sets the capacity to the actual number of elements in the [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]].






---


