#JavascriptObject

[[_TOC_]]

##Properties

None.


##Methods

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


###op_Implicit(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] string 






---


###Render()
Renders the javascript constructed using the information on the [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]]





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] rendered javascript method with the invocations of methods and parameters for those methods.


---


###Render(System.String,System.String)
Renders the javascript constructed using the information on the [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] for the indentation level specified.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] initial  - The initial [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value to prepend to the rendered javascript.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] levelIndent  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value to prepend to the rendered javascript for each level of indentation.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] rendered javascript method with the prepended indentation characters, methods, and parameters for those methods.


---


###Render(Izenda.AdHoc.Toolkits.JavascriptObject.Indentation)
Renders the javascript constructed using the information on the [[Izenda.AdHoc.Toolkits.JavascriptObject|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-JavascriptObject]] using the indentation information specified.

Parameters: 

* [[Izenda.AdHoc.Toolkits.Indentation|/API/Izenda/AdHoc/Toolkits/Izenda-AdHoc-Toolkits-Indentation]] indent  - The [[Initial|/API/Izenda/AdHoc/Toolkits/CodeSamples/Izenda_AdHoc_Toolkits_Indentation_Initial]] that will be applied to the javascript statement.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] rendered javascript method with the prepended indentation information, methods, and parameters for those methods.


---


###ToString()
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the object.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the object.


---


