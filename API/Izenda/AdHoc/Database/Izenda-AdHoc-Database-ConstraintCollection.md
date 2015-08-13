#ConstraintCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Capacity|http://msdn.microsoft.com/en-us/library/29z9bdyd]]|Gets or sets the number of elements that the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] can contain.|0|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/8beysaaa]]|Gets the number of elements contained in the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This property cannot be overridden.|0|
|Constraint|[[Item|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_ConstraintCollection_Item_-_System_Int32_-_]]|Gets the [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] at the specified index  of the [[Izenda.AdHoc.Database.ColumnCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ColumnCollection]] instance.|null|


##Methods

###Add(Izenda.AdHoc.Database.Constraint)


Parameters: 

* [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] value 






---


###Clear()
Removes all objects from the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This method cannot be overridden.






---


###Contains(Izenda.AdHoc.Database.Constraint)
Determines whether or not the specified [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] is in the [[Izenda.AdHoc.Database.ConstraintCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ConstraintCollection]].

Parameters: 

* [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] value  - The [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] value to check for.






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


###IndexOf(Izenda.AdHoc.Database.Constraint)
Gets the numerical index of the specified [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]].

Parameters: 

* [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] value  - The [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] to find the index of.





Returns:

The index of the specified [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]].


---


###Insert(System.Int32,Izenda.AdHoc.Database.Constraint)
Inserts the specified [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] into the [[Izenda.AdHoc.Database.ConstraintCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ConstraintCollection]] at the specified index.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The numerical index to insert the value at.
* [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] value  - The [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] value to be inserted into the collection.






---


###Remove(Izenda.AdHoc.Database.Constraint)
Removes the specified [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] from the [[Izenda.AdHoc.Database.ConstraintCollection|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ConstraintCollection]].

Parameters: 

* [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] value  - The [[Izenda.AdHoc.Database.Constraint|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Constraint]] that will be removed from the collection.






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


