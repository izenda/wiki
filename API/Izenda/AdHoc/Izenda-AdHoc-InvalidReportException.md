#InvalidReportException

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|IDictionary|[[Data|http://msdn.microsoft.com/en-us/library/2wyfbc48]]| Gets a collection of key/value pairs that provide additional user-defined information about the exception. |null|
|String|[[HelpLink|http://msdn.microsoft.com/en-us/library/71tawy4s]]| Gets or sets a link to the help file associated with this exception. |null|
|Int32|[[HResult|http://msdn.microsoft.com/en-us/library/sh5cw61c]]| Gets or sets HRESULT, a coded numerical value that is assigned to a specific exception. |-2146233088|
|Exception|[[InnerException|http://msdn.microsoft.com/en-us/library/902sca80]]|Gets the [[System.Exception|http://msdn.microsoft.com/en-us/library/c18k6c59]] instance that caused the current exception.|null|
|String|[[Message|http://msdn.microsoft.com/en-us/library/9btwf6wk]]| Gets a message that describes the current exception. |Report is invalid.|
|String|[[Source|http://msdn.microsoft.com/en-us/library/85weac5w]]| Gets or sets the name of the application or the object that causes the error. |null|
|String|[[StackTrace|http://msdn.microsoft.com/en-us/library/dxzhy005]]| Gets a string representation of the frames on the call stack at the time the current exception was thrown. |null|
|MethodBase|[[TargetSite|http://msdn.microsoft.com/en-us/library/2wchw354]]| Gets the method that throws the current exception. |null|


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetBaseException()
When overridden in a derived class, returns the [[System.Exception|http://msdn.microsoft.com/en-us/library/c18k6c59]] that is the root cause of one or more subsequent exceptions.





Returns:

The first exception thrown in a chain of exceptions. If the [[InnerException|http://msdn.microsoft.com/en-us/library/902sca80]] property of the current exception is a null reference (Nothing in Visual Basic), this property returns the current exception.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
When overridden in a derived class, sets the [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] with information about the exception.

Parameters: 

* [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] info  - The [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] that holds the serialized object data about the exception being thrown.
* [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] context  - The [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] that contains contextual information about the source or destination.






---


###GetType()
 Gets the runtime type of the current instance. 





Returns:

A [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] object that represents the exact runtime type of the current instance.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###ToString()
 Creates and returns a string representation of the current exception. 





Returns:

 A string representation of the current exception. 


---


