#AdHocCache

[[_TOC_]]

##Properties

None.


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


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


###GetValue(Izenda.AdHoc.Scope,System.String)
Fetches the cached value with the specified [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] and name with the specified value.

Parameters: 

* [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] scope  - The [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] that describes where in memory the object is stored.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name given to the cache item to identify it uniquely in the cache.





Returns:

The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] representation of the value that the cached value will be updated with.


---


###Remove(Izenda.AdHoc.Scope,System.String)
Removes an item from the cache with the specified [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] and name identifier.

Parameters: 

* [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] scope  - The [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] that describes where in memory the object will be stored.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name given to the cache item to identify it uniquely in the cache.






---


###SetValue(Izenda.AdHoc.Scope,System.String,System.Object)
Creates or updates the cached value with the specified [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] and name with the specified value.

Parameters: 

* [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] scope  - The [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] that describes where in memory the object will be stored.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name given to the cache item to identify it uniquely in the cache.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] representation of the value that the cached value will be updated with.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


