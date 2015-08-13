#AdHocStyle

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


###GetColor(Izenda.AdHoc.AdHocColor,Izenda.AdHoc.AdHocColor)
 Returns one of the two input colors based on whether the color was modified. 

Parameters: 

* [[Izenda.AdHoc.AdHocColor|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocColor]] reportColor  - The color that applies to the individual report.
* [[Izenda.AdHoc.AdHocColor|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocColor]] reportSetColor  - The color that applies to the entire report set.






---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetReportCssClass(Izenda.AdHoc.Report)
 Generates a unique identifier for the report CSS styles from the name of the report. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to generate a unique ID from.





Returns:

The unique style ID for style controls belonging to the input report.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###InsertStyles(Izenda.AdHoc.ReportSet,System.Web.UI.ControlCollection,System.String,System.Boolean,out System.String,out System.String)
 Adds styling information to the web page using the specified parameters. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that contains the styling information to use.
* [[System.Web.UI.ControlCollection|http://msdn.microsoft.com/en-us/library/kbe31ba9]] controls  - The collection of web controls that should contain the inserted styling information.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] clientId  - The base ID that the inserted style tags will use.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] generateOnly  - Determines whether the styling information will be inserted directly into the control collection in a new style tag.  true indicates that the styles will not be inserted directly into the control collection.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] insertedCss  - The generated CSS string for the input reportSet.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] insertedCssIe  - The generated IE-specific CSS string for the input reportSet.






---


###LoadFromXml(System.Xml.XmlReader)
Reads the colors from the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] based on the name of the color.

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The XML stream reader that will be used to read the report definition.






---


###RenderXml(System.Xml.XmlWriter,System.Boolean)
Writes the color information to the specified [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] with the specified parameter.

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The XML stream that will be used to write the report definition.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] writeNotModified  - Determines whether each of the colors will be written to the XML file when changes were not made to the default colors.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


