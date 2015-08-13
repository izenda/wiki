#TopCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/zcy6t6cc]]|Gets the number of strings contained in the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].|0|
|Boolean|[[IsReadOnly|http://msdn.microsoft.com/en-us/library/2hh1sf6d]]|Gets a value indicating whether the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]] is read-only.|False|
|Boolean|[[IsSynchronized|http://msdn.microsoft.com/en-us/library/wzd1wte5]]|Gets a value indicating whether access to the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]] is synchronized (thread safe).|False|
|String|[[Item|/API/Rdl/CodeSamples/Rdl_TopCollection_Item_-_System_Int32_-_]]||null|
|Object|[[SyncRoot|http://msdn.microsoft.com/en-us/library/a64w52zy]]|Gets an object that can be used to synchronize access to the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].|null|


##Methods

###Add(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] obj 






---


###Add(System.String)
Adds a string to the end of the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - The string to add to the end of the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]]. The value can be null.





Returns:

 The zero-based index at which the new element is inserted. 


---


###AddRange(System.String[])
Copies the elements of a string array to the end of the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].

Parameters: 

* [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - An array of strings to add to the end of the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]]. The array itself can not be null but it can contain elements that are null.






---


###Clear()
Removes all the strings from the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].






---


###Contains(System.String)
Determines whether the specified string is in the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - The string to locate in the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]]. The value can be null.






---


###CopyTo(System.String[],System.Int32)
Copies the entire [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]] values to a one-dimensional array of strings, starting at the specified index of the target array.

Parameters: 

* [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array  - The one-dimensional array of strings that is the destination of the elements copied from [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]]. The [[System.Array|http://msdn.microsoft.com/en-us/library/czz5hkty]] must have zero-based indexing.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index in <paramref name="array at which copying begins.  






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetEnumerator()
Returns a [[System.Collections.Specialized.StringEnumerator|http://msdn.microsoft.com/en-us/library/39k34y8h]] that iterates through the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].





Returns:

A [[System.Collections.Specialized.StringEnumerator|http://msdn.microsoft.com/en-us/library/39k34y8h]] for the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].


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


###IndexOf(System.String)
Searches for the specified string and returns the zero-based index of the first occurrence within the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  -  The string to locate. The value can be null.  






---


###Insert(System.Int32,System.String)


Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] obj 






---


###Insert(System.Int32,System.String)
Inserts a string into the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]] at the specified index.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index at which <paramref name="value is inserted.  
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  -  The string to insert. The value can be null.  






---


###Remove(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] obj 






---


###Remove(System.String)
Removes the first occurrence of a specific string from the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value  - The string to remove from the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]]. The value can be null.






---


###RemoveAt(System.Int32)
Removes the string at the specified index of the [[System.Collections.Specialized.StringCollection|http://msdn.microsoft.com/en-us/library/d1w61sc5]].

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index of the string to remove.  






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


