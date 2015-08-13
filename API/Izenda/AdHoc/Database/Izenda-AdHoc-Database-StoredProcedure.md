#StoredProcedure

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|ColumnCollection|[[Columns|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_StoredProcedure_Columns]]|Gets the collection of [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] objects that are associated with this stored procedure.|{}|
|DateTime|[[CreatedDate|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_StoredProcedure_CreatedDate]]|Gets the [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that the stored procedure was created on the database.|null|
|String|[[FullName|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_StoredProcedure_FullName]]|Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the stored procedure with the schema included.|[].[]|
|String|[[Name|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_StoredProcedure_Name]]| Gets the name of the stored procedure. |String.Empty|
|ParamCollection|[[Params|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_StoredProcedure_Params]]|Gets the collection of [[Izenda.AdHoc.Database.Param|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Param]] objects that are associated with this stored procedure.|{}|
|String|[[Schema|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_StoredProcedure_Schema]]|Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the schema that the stored procedure belongs to.|String.Empty|


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


###GetSchema()
 Gets the XML schema. 





Returns:

XML schema of this object.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###ReadXml(System.Xml.XmlReader)
Creates a new [[Izenda.AdHoc.Database.StoredProcedure|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-StoredProcedure]] from the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] with parameter information stored to it.

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The source [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] that will be read to obtain the column information.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###WriteXml(System.Xml.XmlWriter)
Writes the [[Izenda.AdHoc.Database.StoredProcedure|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-StoredProcedure]] to the provided [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]].

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] object that will be used to serialize the [[Izenda.AdHoc.Database.StoredProcedure|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-StoredProcedure]].






---


