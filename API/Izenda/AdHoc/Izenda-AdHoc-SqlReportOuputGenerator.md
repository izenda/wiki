#SqlReportOuputGenerator

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[FileExtension|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_SqlReportOuputGenerator_FileExtension]]| Gets or sets the SQL report file extension. |txt|
|Boolean|[[Hidden|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_Hidden]]|Determines whether the output type will be hidden by default on the [[Izenda.Web.UI.AdHocToolbarNavigation|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocToolbarNavigation]] control.|False|
|String|[[ImageName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_ImageName]]|Gets or sets the name of the image file that will be used on the [[Izenda.Web.UI.AdHocToolbarNavigation|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocToolbarNavigation]] control for this output type.|null|
|String|[[ImageUrl|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_ImageUrl]]| Gets the fully-qualified URL of the image that will be displayed on the report. |null|
|Boolean|[[LeftPart|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_LeftPart]]|Determines whether this output type will be displayed on the lefthand side of the [[Izenda.Web.UI.AdHocToolbarNavigation|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocToolbarNavigation]] control.|False|
|Boolean|[[ShowInExplorer|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_ShowInExplorer]]|Gets or sets a value indicating whether export button should be shown in [[Izenda.Web.UI.ReportViewer|/API/Izenda/Web/UI/Izenda-Web-UI-ReportViewer]].|True|
|Boolean|[[ShowInReportViewerExports|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_ShowInReportViewerExports]]| Determines whether the output type will be displayed by default on the classic AdHocReportViewer control. |True|
|Boolean|[[ShowInToolbar|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_ShowInToolbar]]|Determines whether the output type will be displayed by default on the [[Izenda.Web.UI.AdHocToolbarNavigation|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocToolbarNavigation]] control.|True|
|Boolean|[[ShowSeparator|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_ShowSeparator]]|Determines whether a separator element will be inserted between this output type and the next one on the [[Izenda.Web.UI.AdHocToolbarNavigation|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocToolbarNavigation]] control.|False|
|String|[[Text|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_Text]]| Gets or sets the text on the output type.  |String.Empty|
|String|[[ToolbarText|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_ToolbarText]]| Gets or sets the text that will be displayed on the toolbar button in an anchor tag. |String.Empty|
|String|[[ToolTip|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportOutputGenerator_ToolTip]]|Gets or sets the text that is displayed when the user hovers over the icon on the [[Izenda.Web.UI.AdHocToolbarNavigation|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocToolbarNavigation]] control.|String.Empty|


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GenerateOutput(Izenda.AdHoc.ReportSet)
Generates a SQL file containing the query that is built for the specified [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that will be processed.





Returns:

An [[Izenda.Controls.IContentGenerator|/API/Izenda/Controls/Izenda-Controls-IContentGenerator]] containing the SQL file output.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetOutputFileName(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName 






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


