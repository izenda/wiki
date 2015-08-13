#SchedulerOutput

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[Active|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SchedulerOutput_Active]]| Gets or sets the value indicating whether this sheduler type should be used in mail sending. |True|
|String|[[AdditionalText|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SchedulerOutput_AdditionalText]]| Gets or sets additional text in e-mail body for Attachment output type. |Report attached.|
|String|[[AttachmentName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SchedulerOutput_AttachmentName]]| Gets or sets name of attachment in e-mail without extension. |report|
|String|[[Name|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SchedulerOutput_Name]]|Gets or sets the displayed name of the output type on the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]].|null|
|Boolean|[[ResolveLinks|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SchedulerOutput_ResolveLinks]]| Gets or sets value indicating if it is necessary to resolve links in message and use MIME or not. <remarks>This setting doesn't make any effect for PDF and CSV formats or for Link output type.</remarks>|False|
|Boolean|[[Visible|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SchedulerOutput_Visible]]|Determines whether this output type will be displayed on the [[Izenda.Web.UI.ScheduleControl|/API/Izenda/Web/UI/Izenda-Web-UI-ScheduleControl]] of the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]].|True|


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GenerateMessage(Izenda.AdHoc.ReportSet)
Creates a [[System.Net.Mail.MailMessage|http://msdn.microsoft.com/en-us/library/8t22a8ww]] using the specified [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The source [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that will be included in the message.





Returns:

The completed message to be sent to the end users.


---


###GenerateMessage(Izenda.AdHoc.ReportSet,System.Boolean)
 Generates e-mail message by reportSet. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - Source ReportSet to generate message from.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isDashboard 





Returns:

Generated message


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


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


