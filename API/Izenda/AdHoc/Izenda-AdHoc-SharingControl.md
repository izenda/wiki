#SharingControl

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[Global|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SharingControl_Global]]| Determines whether the report will be shared globally. |False|
|Boolean|[[ReadOnly|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SharingControl_ReadOnly]]| Determines whether the default sharing rights will be Read Only. |False|
|Boolean|[[ViewOnly|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SharingControl_ViewOnly]]| Determines whether the default sharing rights will be View Only. |False|
|String|[[Visibility|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SharingControl_Visibility]]| Represents the roles that can access the report. |String.Empty|


##Methods

###BuildShareControl()
Dynamically generates the sharing control HTML in a [[System.Web.UI.WebControls.PlaceHolder|http://msdn.microsoft.com/en-us/library/dxhhzts9]] that can be added to a web page.





Returns:

The generated [[System.Web.UI.WebControls.PlaceHolder|http://msdn.microsoft.com/en-us/library/dxhhzts9]] containing the HTML for the control.


---


###CreateVisiblityControlItem(System.Int32,System.String,System.String)
 Generates markup for the sharing control embedded inside a table row using the specified parameters. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] controlNumber  - An identifying number to attribute to the control's ID.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] selectedShare  - The name of the selected item in the sharing dropdown list.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] selectedRights  - The name of the selected item in the rights dropdown list.





Returns:

A [[System.Web.UI.LiteralControl|http://msdn.microsoft.com/en-us/library/50eewx9c]] containing the HTML generated for the sharing control.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GenerateDropDownControl(System.Int32,System.String,System.String)
 Generates markup for a dropdown menu using the specified parameters. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] ControlNumber  - An identifying number to attribute to the control's ID.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] type  - The type of the control used as a prefix for the control's ID.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] selected  - The name of the selected item in the list.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the dropdown menu created.


---


###GenerateDropDownItem(System.String,System.String)
 Generates markup for a dropdown menu item using the specified parameters. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the dropdown option. Doubles as the value.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] selected  - The name of the selected item in the list.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the dropdown menu item created.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetRights()
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the sharing rights based on the properties of the control or the default sharing rights.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] represenataion of the sharing rights value of the control.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetVisibility()
 Gets the sharing settings from a web request sent from the client. 





Returns:

A [[System.Collections.Hashtable|http://msdn.microsoft.com/en-us/library/aahzb21x]] containing the sharing settings obtained from the client.


---


###GetVisibilityFromReportSet(Izenda.AdHoc.ReportSet)
Loads the report sharing settings from the specified [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] containing the sharing settings to load into the control.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


