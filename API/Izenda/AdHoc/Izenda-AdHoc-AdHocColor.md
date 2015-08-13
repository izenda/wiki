#AdHocColor

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Color|[[Color|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ColorRef_Color]]| Gets or sets the current value of the color. |Color [Empty]|
|Color|[[DefaultValue|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ColorRef_DefaultValue]]| Gets the default value that the color was instantiated with. |Color [Empty]|
|Boolean|[[Modified|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ColorRef_Modified]]| Determines whether or not the color has been modified since it was instantiated. |False|
|String|[[Name|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocColor_Name]]| The name of the color. |String.Empty|
|ColorRef|[[SavedValue|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocColor_SavedValue]]| The color and its associated properties that were registered to the associated report. |null|


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


###LoadFromRequest(System.String)
 Constructs a color from a web request using the specified parameter name where the value passed in the request parameter is a valid GDI+ drawing color. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] parameterName  - The name of the parameter being passed through the web request containing the color.






---


###Read(System.Xml.XmlReader)
Reads the color from the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] based on the name of the color.

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The XML stream reader that will be used to read the report definition.






---


###ResetToDefault()
 Resets the color to its default value. 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###Write(System.Xml.XmlWriter,System.Boolean)
Writes the color to the specified [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]].

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The XML stream that will be used to write the report definition.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] writeNotModified  - Determines whether the color will be written to the XML file when changes were not made to the default color.






---


