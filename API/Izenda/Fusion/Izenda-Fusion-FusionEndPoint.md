#FusionEndPoint

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


###ProcessRequest(System.Web.HttpRequest,System.Web.HttpResponse,Izenda.Fusion.DataExtractor)
Enables requests from OData sources to have their commands processed on the server and returned as a [[System.Web.HttpResponse|http://msdn.microsoft.com/en-us/library/dhy78ycf]].

Parameters: 

* [[System.Web.HttpRequest|http://msdn.microsoft.com/en-us/library/h55b6cak]] request  - The [[System.Web.HttpRequest|http://msdn.microsoft.com/en-us/library/h55b6cak]] containing the OData command to be processed and the URL of the OData endpoint.
* [[System.Web.HttpResponse|http://msdn.microsoft.com/en-us/library/dhy78ycf]] response  - The [[System.Web.HttpResponse|http://msdn.microsoft.com/en-us/library/dhy78ycf]] that will contain the UTF8-encoded serialized results of the command after it has been processed.
* [[Izenda.Fusion.DataExtractor|/API/Izenda/Fusion/Izenda-Fusion-DataExtractor]] extractor  - The [[Izenda.Fusion.DataExtractor|/API/Izenda/Fusion/Izenda-Fusion-DataExtractor]] that will be used to perform the database operation associated with the OData command.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


