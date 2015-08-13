#Position

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[ColSpan|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Position_ColSpan]]| Gets or sets the number of vertical tiles the report should span in the dashboard. |1|
|Int32|[[DbDsgn2Height|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Position_DbDsgn2Height]]| Gets or sets the height of the dashboard designer. |0|
|Int32|[[Height|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Position_Height]]||0|
|Int32|[[RowSpan|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Position_RowSpan]]| Gets or sets the number of horizontal tiles the report should span in the dashboard. |1|
|Int32|[[Width|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Position_Width]]||0|
|Int32|[[X|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Position_X]]| Gets or sets the column number of the dashboard to anchor the report at. |0|
|Int32|[[Y|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Position_Y]]| Gets or sets the row number of hte dashboard to anchor the report at. |0|


##Methods

###Clone()
Performs a shallow clone of the [[Izenda.AdHoc.Position|/API/Izenda/AdHoc/Izenda-AdHoc-Position]] object.





Returns:

The shallow copy of the [[Izenda.AdHoc.Position|/API/Izenda/AdHoc/Izenda-AdHoc-Position]] object.


---


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


###ReadXml(System.Xml.XmlReader)
Reads the data from the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] that contains information about the report position.

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] containing the loaded report XML definition with position information.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###WriteXml(System.Xml.XmlWriter)
Writes the data from the report position into the specified [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]]

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] to use for storing position information.






---


