#Column

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[FullName|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Column_FullName]]| Represents the fully-qualified name of the column using the schema and table name. |null|
|Boolean|[[Indexed|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Column_Indexed]]| Determines whether the column has been indexed on the database and helps in determining joining capabilities for this column. |False|
|String|[[Name|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Column_Name]]| Represents the name of the database column. |String.Empty|
|String|[[NativeType|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Column_NativeType]]| Represents the raw database type obtained from the database metadata. |Object|
|String|[[SqlName|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Column_SqlName]]|Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the column's name formatted for a SQL statement.|null|
|SqlType|[[SqlType|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Column_SqlType]]|The [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] that is used for various functions throughout the reporting application.|Null|
|Table|[[Table|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Column_Table]]|Represents the parent [[Izenda.AdHoc.Database.Table|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Table]] that this column belongs to.|null|
|Type|[[Type|/API/Izenda/AdHoc/Database/CodeSamples/Izenda_AdHoc_Database_Column_Type]]|The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] representation of the [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] for this column.|null|


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


###InstancesEqual(Izenda.AdHoc.Database.Column,Izenda.AdHoc.Database.Column)


Parameters: 

* [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] col1 
* [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] col2 






---


###ReadXml(System.Xml.XmlReader)
Populates the database column using the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]].

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] containing the database schema data to be read into the column.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###WriteXml(System.Xml.XmlWriter)
Writes the contents of the database column to the specified [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]].

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] that will contain the database schema information.






---


