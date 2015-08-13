#Filter

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[Column|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Filter_Column]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the column associated with the filter.|null|
|String|[[GUID|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Filter_GUID]]| Gets the globally unique identifier for the filter. |null|
|Boolean|[[IsSingleValueOperator|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Filter_IsSingleValueOperator]]| Determines whether this filter uses an operator that is not based on a database field or a beinning and ending value. |null|
|Boolean|[[IsValueOperator|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Filter_IsValueOperator]]| Determines whether the filter uses an operator that is not based on a database field. |null|
|OperatorTypes|[[Operator|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Filter_Operator]]| Gets or sets the type of operator the filter is using. |null|
|String|[[SQL|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Filter_SQL]]|Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the generated SQL expression for the filter.|null|
|String|[[Uid|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Filter_Uid]]| Gets a unique identifier for the filter. |null|


##Methods

###Clone()
Performs a deep clone of the [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]].





Returns:

A [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] representation of the filter.


---


###CompareTo(System.Object)
Compares the label on this plot chart to the input [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] object to determine the sort order for a list of filters.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] object to compare to.





Returns:

A [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] representing whether the compared object should precede, follow, or is the same as the current object.


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


###GetIsAdditionalFilter()
 Gets whether this filter is used as a drilldown filter when the filter did not exist on the report already. 






---


###GetIsDDFilter()







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


###op_Explicit(Izenda.AdHoc.Filter)


Parameters: 

* [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] f 






---


###ReadXml(System.Xml.XmlReader)
Reads XML data into the [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] using the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]].

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] from which to read.






---


###ReadXml(System.String)
Reads XML data into the [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] from the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] from which to read.






---


###SetIsAdditionalFilter(System.Boolean)
 Sets whether this filter is used as a drilldown filter when the filter did not exist on the report already. 

Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] val 






---


###SetIsDDFilter(System.Boolean)


Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] val 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###WriteXml()
Writes the current data of the [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] to the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] and returns it.





Returns:

The writed [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].


---


###WriteXml(System.Xml.XmlWriter)
Writes the current data of the [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] to the specified XmlWriter.

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] with which to write.






---


