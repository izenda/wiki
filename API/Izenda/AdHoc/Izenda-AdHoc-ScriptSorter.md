#ScriptSorter

[[_TOC_]]

##Properties

None.


##Methods

###BuildChildTree(Izenda.AdHoc.ScriptSorter.ScriptDownloadItem)
 Recursively constructs a search tree within the sorter for determining the fastest order to insert scripts into a page based on the given script item. 

Parameters: 

* [[Izenda.AdHoc.ScriptDownloadItem|/API/Izenda/AdHoc/Izenda-AdHoc-ScriptDownloadItem]] item  - The script item to determine the order for with respect to its dependencies.






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetDownloadOrder()
 Gets the collection of scripts in order of how the scripts need to be added to the web page. 






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


###RegisterScript(System.String,System.String,System.String[])
 Adds a javascript file to the collection with the specified parameters. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] scriptUrl  - The fully-qualified URL of the javascript file to be added to the collection.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the javascript file.
* [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] requiredScriptNames  - The array of script names that this script depends upon to run.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


