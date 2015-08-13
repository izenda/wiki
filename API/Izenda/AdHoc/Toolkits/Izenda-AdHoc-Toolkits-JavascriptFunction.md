#JavascriptFunction

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[Name|/API/Izenda/AdHoc/Toolkits/CodeSamples/Izenda_AdHoc_Toolkits_JavascriptFunction_Name]]| Gets or sets the name of the javascript function. |null|


##Methods

###Add(Izenda.AdHoc.Toolkits.JavascriptObject)
 Adds a new statement to the list of statements that will comprise the body of the javascript function. 

Parameters: 

* [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] object  - The [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] statement that will be added to the function.





Returns:

The [[Izenda.AdHoc.Toolkits.JavascriptFunction|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptFunction]] after the statement is added.


---


###AddRange(System.Collections.Generic.IEnumerable&lt;Izenda.AdHoc.Toolkits.JavascriptObject&gt;)
 Adds a list of statements to the javascript statements that will comprise the body of the javascript function. 

Parameters: 

* [[System.Collections.Generic.IEnumerable|http://msdn.microsoft.com/en-us/library/9eekhta0]]&lt;[[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]]&gt; objects  - The list of [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] items to be added.





Returns:

The [[Izenda.AdHoc.Toolkits.JavascriptFunction|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptFunction]] after the statements are added.


---


###End()
 Renders the end of a javascript line. 





Returns:

The [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] that renders the end of a javascript line.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###Exec(Izenda.AdHoc.Toolkits.JavascriptObject[])
 Adds a statement that uses the specified parameter array that will get rendered as an execution of the javascript method declaration registered to the object. 

Parameters: 

* [[Izenda.AdHoc.Toolkits.JavascriptObject[]|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject[]]] params  - The [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] parameter list that the invocation declaration will use to build itself.





Returns:

The [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] that was created after adding the parameter information.


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


###Method(System.String,Izenda.AdHoc.Toolkits.JavascriptObject[])
 Adds a statement that uses the specified name and parameter array that will get rendered as a method invocation of a method on the javascript method declaration registered to the object. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the method to invoke that is a method of the javascript declaration registered to the object.
* [[Izenda.AdHoc.Toolkits.JavascriptObject[]|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject[]]] params  - The list of parameters of the method that is being invoked.





Returns:

The [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] that was created after adding the method and parameter information.


---


###Render()
Produces a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] javascript function from the name, parameters, and statements that can be inserted into a web page or web control.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] javascript function that can be inserted into a web page or web control.


---


###Render(Izenda.AdHoc.Toolkits.JavascriptObject.Indentation)
Produces a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] javascript function from the name, parameters, and statements that can be inserted into a web page or web control using the specified indentation.

Parameters: 

* [[Izenda.AdHoc.Toolkits.Indentation|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-Indentation]] indent  - The indentation information that will be used to control the level of indentation on the function.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] javascript function that can be inserted into a web page or web control.


---


###Render(System.String,System.String)
Renders the javascript constructed using the information on the [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] for the indentation level specified.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] initial  - The initial [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value to prepend to the rendered javascript.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] levelIndent  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value to prepend to the rendered javascript for each level of indentation.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] rendered javascript method with the prepended indentation characters, methods, and parameters for those methods.


---


###ToString()
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the object.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the object.


---


