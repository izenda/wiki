#MD5CryptoServiceProvider

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[CanReuseTransform|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MD5_CanReuseTransform]]||True|
|Boolean|[[CanTransformMultipleBlocks|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MD5_CanTransformMultipleBlocks]]||True|
|Byte[]|[[Hash|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MD5_Hash]]||null|
|Int32|[[HashSize|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MD5_HashSize]]||128|
|Int32|[[InputBlockSize|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MD5_InputBlockSize]]||1|
|Int32|[[OutputBlockSize|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_MD5_OutputBlockSize]]||1|


##Methods

###Clear()







---


###ComputeHash(System.Byte[])


Parameters: 

* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] buffer 






---


###ComputeHash(System.Byte[],System.Int32,System.Int32)


Parameters: 

* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] buffer 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] offset 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] count 






---


###ComputeHash(System.IO.Stream)


Parameters: 

* [[System.IO.Stream|http://msdn.microsoft.com/en-us/library/8f86tw9e]] inputStream 






---


###Dispose()
 Disposes the object and frees up memory used by it. 






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


###Initialize()
 MD5 initialization. Begins an MD5 operation, writing a new context. 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###TransformBlock(System.Byte[],System.Int32,System.Int32,System.Byte[],System.Int32)


Parameters: 

* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] inputBuffer 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] inputOffset 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] inputCount 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] outputBuffer 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] outputOffset 






---


###TransformFinalBlock(System.Byte[],System.Int32,System.Int32)


Parameters: 

* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] inputBuffer 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] inputOffset 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] inputCount 






---


