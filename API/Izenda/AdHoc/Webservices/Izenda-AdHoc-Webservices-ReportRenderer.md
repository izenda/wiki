#ReportRenderer

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|HttpApplicationState|[[Application|http://msdn.microsoft.com/en-us/library/a9a78ahz]]| Gets the application object for the current HTTP request. |{}|
|IContainer|[[Container|http://msdn.microsoft.com/en-us/library/ebx0az10]]| Gets the container for the component. |null|
|HttpContext|[[Context|http://msdn.microsoft.com/en-us/library/t84cw6zd]]|Gets the ASP.NET [[System.Web.HttpContext|http://msdn.microsoft.com/en-us/library/x08ey989]] for the current request, which encapsulates all HTTP-specific context used by the HTTP server to process Web requests.|null|
|Boolean|[[DesignMode|http://msdn.microsoft.com/en-us/library/kyabxy2z]]| Gets a value indicating whether the component is currently in design mode. |False|
|HttpServerUtility|[[Server|http://msdn.microsoft.com/en-us/library/8takb34a]]|Gets the [[System.Web.HttpServerUtility|http://msdn.microsoft.com/en-us/library/8409wd29]] for the current request.|null|
|HttpSessionState|[[Session|http://msdn.microsoft.com/en-us/library/szk893hf]]|Gets the [[System.Web.SessionState.HttpSessionState|http://msdn.microsoft.com/en-us/library/ah635ck5]] instance for the current request.|null|
|ISite|[[Site|http://msdn.microsoft.com/en-us/library/3btxye0d]]| Gets or sets the site of the component. |null|
|SoapProtocolVersion|[[SoapVersion|http://msdn.microsoft.com/en-us/library/zt7y4e6c]]| Gets the version of the SOAP protocol used to make the SOAP request to the XML Web service. |Default|
|IPrincipal|[[User|http://msdn.microsoft.com/en-us/library/wk0z6h1f]]|Gets the ASP.NET server [[User|http://msdn.microsoft.com/en-us/library/cc680188]] object. Can be used to authenticate whether a user is authorized to execute the request.|null|


##Methods

###Dispose()
Releases all resources used by the [[System.ComponentModel.MarshalByValueComponent|http://msdn.microsoft.com/en-us/library/53c82zyd]].






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###ExportReportSet(System.String,System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] output 






---


###ExportReportSet(System.String,System.String,System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] output 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] filters 






---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetService(System.Type)
Gets the implementer of the [[System.IServiceProvider|http://msdn.microsoft.com/en-us/library/zbywf1tw]].

Parameters: 

* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] service  - A [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] that represents the type of service you want.





Returns:

An [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] that represents the implementer of the [[System.IServiceProvider|http://msdn.microsoft.com/en-us/library/zbywf1tw]].


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###RenderReportSet(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName 






---


###RenderReportSetWithFilters(System.String,System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] filters 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the name of the System.ComponentModel.Component, if any. This method should not be overridden.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the name of the System.ComponentModel.Component, if any. null if the [[System.ComponentModel.Component|http://msdn.microsoft.com/en-us/library/9wbadbce]] is unnamed.


---


