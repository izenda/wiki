#AdHocContext

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[ClientLicenses|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_ClientLicenses]]||5|
|ReportSet|[[CurrentReportSet|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_CurrentReportSet]]|Gets or sets the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that was most recently loaded by the current user.|new Izenda.AdHoc.ReportSet()|
|String|[[CurrentUserName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_CurrentUserName]]| Gets or sets the name of the current user. |DefaultAdministrator|
|Boolean|[[DisableLogging|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_DisableLogging]]| Deterines whether logging is disabled. |False|
|Driver|[[Driver|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_Driver]]||new Izenda.AdHoc.Database.MSSQLDriver()|
|Int32|[[ProcessorLicenses|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_ProcessorLicenses]]||0|
|Int32|[[ReportSetCount|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_ReportSetCount]]|Gets the number of [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] objects|0|
|Boolean|[[SchedulerExecuting|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_SchedulerExecuting]]| Gets values indicating that current session started by scheduler |False|
|UsersCountModel|[[UsersCountModel|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_UsersCountModel]]||Monthly|
|Int32|[[ViewerLicenses|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_ViewerLicenses]]||5|


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


###SetSchedulerExecuting(System.Boolean)


Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isSchedulerExecuting 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


