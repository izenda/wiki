#SetModelDrillthroughReportsCompletedEventHandler

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|MethodInfo|[[Method|http://msdn.microsoft.com/en-us/library/bt7be6za]]| Gets the method represented by the delegate. |null|
|Object|[[Target|http://msdn.microsoft.com/en-us/library/fwkdf75h]]| Gets the class instance on which the current delegate invokes the instance method. |null|


##Methods

###BeginInvoke(System.Object,System.ComponentModel.AsyncCompletedEventArgs,System.AsyncCallback,System.Object)


Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] sender 
* [[System.ComponentModel.AsyncCompletedEventArgs|http://msdn.microsoft.com/en-us/library/2tde67e9]] e 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] object 






---


###Clone()
 Creates a shallow copy of the delegate. 





Returns:

 A shallow copy of the delegate. 


---


###DynamicInvoke(System.Object[])
 Dynamically invokes (late-bound) the method represented by the current delegate. 

Parameters: 

* [[System.Object[]|http://msdn.microsoft.com/en-us/library/e5kfa45b]] args  -  An array of objects that are the arguments to pass to the method represented by the current delegate.  -or-  null, if the method represented by the current delegate does not require arguments.  





Returns:

 The object returned by the method represented by the delegate. 


---


###EndInvoke(System.IAsyncResult)


Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] result 






---


###Equals(System.Object)
 Determines whether this multicast delegate and the specified object are equal. 

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  -  The object to compare with this instance.  





Returns:

true if <paramref name="obj and this instance have the same invocation lists; otherwise, false. 


---


###GetHashCode()
 Returns the hash code for this instance. 





Returns:

 A 32-bit signed integer hash code. 


---


###GetInvocationList()
 Returns the invocation list of this multicast delegate, in invocation order. 





Returns:

 An array of delegates whose invocation lists collectively match the invocation list of this instance. 


---


###GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
Populates a [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] object with all the data needed to serialize this instance.

Parameters: 

* [[System.Runtime.Serialization.SerializationInfo|http://msdn.microsoft.com/en-us/library/a9b6042e]] info  -  An object that holds all the data needed to serialize or deserialize this instance.  
* [[System.Runtime.Serialization.StreamingContext|http://msdn.microsoft.com/en-us/library/t16abws5]] context  -  (Reserved) The location where serialized data is stored and retrieved.  






---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###Invoke(System.Object,System.ComponentModel.AsyncCompletedEventArgs)


Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] sender 
* [[System.ComponentModel.AsyncCompletedEventArgs|http://msdn.microsoft.com/en-us/library/2tde67e9]] e 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


