#FileSystemAdHocConfig

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[NewReportSetID|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocConfig_NewReportSetID]]|Gets a new unique ID that can be used to identify a [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] when a new report is created.|f5931ec2-1efa-45c0-bc6e-c345d5b1ec44|
|String|[[ReportPath|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_FileSystemAdHocConfig_ReportPath]]|Gets or sets the path to the location in the server's filesystem where reports are stored. Generally, this will not need to be set when [[ReportsPath|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocSettings_ReportsPath]] has been set.|\Reports|


##Methods

###ArchiveReportOutput(Izenda.AdHoc.ReportSet,System.String[],System.String,System.Byte[])
Represents a method that can be used to save the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to an archive location for backup purposes when the report is being exported.

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that contains the collection of [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] objects that are being exported.
* [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] emails  - The collection of recipient addresses for the exported report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] extension  - The Windows extension of the generated export.
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] data  - The serialized data of the exported report object.






---


###ConfigureSettings()
 Represents a method that can be used to load global application settings.  This method is run exactly once when the first request is made to the reporting pages. **(deprecated)**






---


###CustomizeChart(System.Object)
 Represents a method that can be used to modify a chart before it is rendered to the screen. 

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] chart  - The chart object that was produced on the server. The [[Izenda.AdHoc.ChartingEngine|/API/Izenda/AdHoc/Izenda-AdHoc-ChartingEngine]] being used determines what kind of object the chart can be cast to.






---


###CustomizeChart(System.Object,System.Collections.Hashtable)
 Represents a method that can be used to modify a chart before it is rendered to the screen. 

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] chart  - The chart object that was produced on the server. The [[Izenda.AdHoc.ChartingEngine|/API/Izenda/AdHoc/Izenda-AdHoc-ChartingEngine]] being used determines what kind of object the chart can be cast to.
* [[System.Collections.Hashtable|http://msdn.microsoft.com/en-us/library/aahzb21x]] properties  - A list of properties that the chart contains and will be applied to the chart after customization. Some chart types do not have properties.






---


###CustomizeDundasChart(System.Object,System.Collections.Hashtable,System.Type)
 Represents a method that can be used to modify a Dundas chart before it is rendered to the screen. 

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] chart  - The chart object that was produced on the server. The chart will always be an [[Izenda.AdHoc.DundasChart|/API/Izenda/AdHoc/Izenda-AdHoc-DundasChart]].
* [[System.Collections.Hashtable|http://msdn.microsoft.com/en-us/library/aahzb21x]] properties  - A list of properties that the chart contains and will be applied to the chart after customization. Some chart types do not have properties.
* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] chartType  - The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] representation of the type of chart being created.






---


###CustomizeGuage(System.Double,System.Double,System.Double,System.String,System.Drawing.Image)
 Represents a method that can be used to modify a gauge report before it is rendered to the screen. 

Parameters: 

* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] value  - The gauge control's numeric value represented as a [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]].
* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] min  - The minimum value to display on the gauge control represented as a [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]].
* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] max  - The maximum value to display on the gauge control represented as a [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]].
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name that the gauge was given based on the type of gauge being used.
* [[System.Drawing.Image|http://msdn.microsoft.com/en-us/library/k7e7b2kd]] guageImage  - The [[System.Drawing.Image|http://msdn.microsoft.com/en-us/library/k7e7b2kd]] for the gauge that is being used.






---


###DeleteReportSet(Izenda.AdHoc.ReportInfo)
 Deletes a report from the server's filesystem with the specified parameters. 

Parameters: 

* [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] reportInfo  - The [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object containing information about the report to delete.






---


###DeleteReportSet(System.String)
 Represents a method to delete the report with the specified name and the current user's tenant ID from the location where reports are stored. This method must be overridden. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report to delete.






---


###DeleteTemplate(System.String)
 Deletes a form attached to a report using the specified name. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullReportSetName 






---


###DeleteThumbnail(Izenda.AdHoc.ReportInfo)
 Deletes the thumbnail image associated with the specified report from the report thumbnails folder on the server. 

Parameters: 

* [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] reportInfo  - The [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object that contains the information required to delete the thumbnail.






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###FilteredListReports()
Gets a list of [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] objects that are available to the current user based on the factors of report availability and privileges.






---


###FilteredListReportsDictionary()
Gets a list of [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] objects for all loadable reports found that have been modified since the last time this method was called.






---


###GetAutoRefreshIntervals()
 Represents a method that gets the time the report viewer will wait before auto-refreshing the results on the page. 





Returns:

A [[System.Collections.Generic.Dictionary|http://msdn.microsoft.com/en-us/library/xfhwa508]] of key value pairs that determine how long the report viewer will wait before auto-refreshing itself.


---


###GetCustomFooter(Izenda.AdHoc.ReportSet,Izenda.AdHoc.ReportSetResults,System.Boolean,out System.String)
Represents a method that is used to add a footer to the generated [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being executed on the server. This method must be overridden.

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The source [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being executed on the server.
* [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] results  - The [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] that contains the results of executing the report.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] print  - Determines whether this report is being exported or run normally.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] customFooter  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HTML footer that will be added to the report output when it is displayed.






---


###GetCustomHeader(Izenda.AdHoc.ReportSet,Izenda.AdHoc.ReportSetResults,System.Boolean,out System.String)
Represents a method that is used to add a header to the generated [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being executed on the server. This method must be overridden.

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The source [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being executed on the server.
* [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] results  - The [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] that contains the results of executing the report.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] print  - Determines whether this report is being exported or run normally.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] customHeader  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HTML header that will be added to the report output when it is displayed.






---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetOperatorList(Izenda.AdHoc.Database.SqlType,System.Boolean)
Represents a method that gets the list of different operators that can be used for the specified [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]].

Parameters: 

* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] type  - The [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] datatype to check.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isStoredProcedureUsed  - Whether the results should check for stored procedures. Certain valid operators only work conditionally with stored procedures.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array of the different operators that can be applied to the [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]].


---


###GetOperatorList(Izenda.AdHoc.Database.SqlType,System.Boolean,System.String)
Represents a method that gets the list of different operators that can be used for the specified [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] and the column name.

Parameters: 

* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] type  - The [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] datatype to check.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isStoredProcedureUsed  - Whether the results should check for stored procedures. Certain valid operators only work conditionally with stored procedures.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] columnFullName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the column that the operator list is for.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array of the operators that can be applied.


---


###GetPossibleValuesAsTree(System.String,System.Int32,Izenda.AdHoc.ReportSet)
 Represents a method that gets the list of values for an equals(select) operator list in a tree structure, with the root node being on top and each subsequent node being a child of its parent. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullColumnName  - The fully-qualified name of the column with schema and table information.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] maxRowCount  - The maximum number of items that the resulting list and sub-lists will contain.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] rs  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that the column is associated with.





Returns:

A [[System.Collections.Generic.IList|http://msdn.microsoft.com/en-us/library/5y536ey6]] containing the structure of the tree that can be used for the equals(select) operator.


---


###GetReportIDByName(System.String)
 Represents a method that returns the report ID given the corresponding report name. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullReportName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the report.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the unique identifier for the report.


---


###GetReportNameById(System.String)
 Represents a method that returns the report name given the corresponding report ID. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] id  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the unique identifier for the report.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the report.


---


###GetReports()
Gets a list of all loadable [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] objects from the location where reports are stored.






---


###GetRichEditorContent(System.String)
 Represents a method that gets the contents of the forms editor when the forms editor is opened. The result is inserted into the forms editor. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] requestData  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML content of the forms editor.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HTML representation of the form that will be output to the content window.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###InvalidateFilteredCaches()
 Clears the application's in-memory cache of all reports. 






---


###IsFieldAllowedInFilters(System.String,System.String,System.String)
 Represents a method that checks whether a certain database column can be selected for a filter. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullColumnName  - The fully-qualified column name with schema and table information.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The name of the table the column is associated with.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] columnName  - The name of the column to check for.





Returns:

True when the column is allowed as a filter. Otherwise, false.


---


###ListReports()
 Gets a list of all reports since the last time the cache was updated or all reports if caching is not on. 





Returns:

A collection of [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] objects that contain the information about the obtained reports.


---


###LoadFilteredReportSet(System.String)
 Loads a report from the storage media using current TenantID. Returns null if the report is not loadable. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - Name of the report.






---


###LoadReportSet(Izenda.AdHoc.ReportInfo,Izenda.AdHoc.Database.DatabaseSchema)
 Loads a report's definition from the server's filesystem using the specified parameters. 

Parameters: 

* [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] reportInfo  - The [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object containing information about the report to load.
* [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] schema  - The [[Izenda.AdHoc.Database.DatabaseSchema|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-DatabaseSchema]] object that contains the schema information that the report metadata corresponds to.






---


###LoadReportSet(System.String)
 Represents a method that loads the report with the specified name and the current user's tenant ID from the location where reports are stored. This method must be overridden. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report to load.






---


###LoadTemplate(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullReportSetName 






---


###LoadThumbnail(Izenda.AdHoc.ReportInfo)
 Represents a method that loads the thumbnail image associated with the specified report from the report thumbnails folder on the server. 

Parameters: 

* [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] reportInfo  - The [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object that contains the information required to load the thumbnail.





Returns:

The raw [[System.Byte|http://msdn.microsoft.com/en-us/library/yyb1w04y]] array that represents the thumbnail image loaded.


---


###PerformCustomRendering(Izenda.AdHoc.ReportSet,Izenda.AdHoc.ReportSetResults,System.Boolean,out System.String)
 Represents a method used to replace the regular report results with the results of an HTML form. **(deprecated)**

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The source [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being executed on the server.
* [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] results  - The [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] that contains the results of executing the report.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] print  - Determines whether this report is being exported or run normally.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] resultFromCustomRenderer  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML that comprises the content of the form.





Returns:

True when the form should be rendered and false when it should use the normal rendering method.


---


###PerformCustomRendering(Izenda.AdHoc.Report,Izenda.AdHoc.Database.ReportQueryExecuteResult,System.String,System.Boolean,out System.String)
 Represents a method used to replace the regular report results with the results of an HTML form. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The source [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being executed on the server.
* [[Izenda.AdHoc.Database.ReportQueryExecuteResult|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ReportQueryExecuteResult]] results  - The [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] that contains the results of executing the report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] appliedFilters  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] XML representation of the filters that will be applied to the report.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] print  - Determines whether this report is being exported or run normally.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] resultFromCustomRenderer  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML that comprises the content of the form.





Returns:

True when the form should be rendered and false when it should use the normal rendering method.


---


###PerformCustomRendering(Izenda.AdHoc.Report,Izenda.AdHoc.Database.ReportQueryExecuteResult,System.Boolean,out System.String)
 Represents a method used to replace the regular report results with the results of an HTML form. **(deprecated)**

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The source [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being executed on the server.
* [[Izenda.AdHoc.Database.ReportQueryExecuteResult|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-ReportQueryExecuteResult]] results  - The AdHoc.ReportQueryExecuteResults that contains the results of executing the report.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] print  - Determines whether this report is being exported or run normally.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] resultFromCustomRenderer  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML that comprises the content of the form.





Returns:

True when the form should be rendered and false when it should use the normal rendering method.


---


###PerformCustomRendering(System.String)
 Represents a method used to replace the regular report results with the results of an HTML form. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] initialHtml  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML results of the report.






---


###PostExecuteReportSet(Izenda.AdHoc.ReportSet)
Represents a method that allows operations to be performed after executing a [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] and before displaying it to the screen.

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that was executed on the server.






---


###PostLoadReportSet(System.String,Izenda.AdHoc.ReportSet)
 Represents a method that allows operations to be performed after loading the specified report. This method must be overridden. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report name.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The source [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that was generated after loading it.






---


###PostLogin()
 Represents a method that can be used to load user-specific application settings.  This method is run after the user logs in from your integrated login page. **(deprecated)**






---


###PostProcessEqualsSelectList(Izenda.AdHoc.Database.Column,System.Collections.Generic.List&lt;System.String&gt;,System.Collections.Generic.List&lt;System.String&gt;)
 Represents a method that can be used to edit the values of the equals(select) filter after the results have been obtained. 

Parameters: 

* [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] column  - The [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] that the values will be obtained for.
* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; labels  - The [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]] of labels that will be used as the display text for the resulting dropdown list.
* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; values  - The [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]] of values that will be used as the underlying data for the resulting dropdown list.






---


###PostProcessHighChartLabels(Izenda.AdHoc.Report,System.String[])


Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report 
* [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] labels 






---


###PostSaveReportSet(System.String,Izenda.AdHoc.ReportSet)
Represents a method that allows the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to be processed after it is saved.**(deprecated)**

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report name.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is going to be saved.






---


###PreExecuteReportSet(Izenda.AdHoc.ReportSet)
Represents a method that allows operations to be performed before executing a [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] and displaying it to the screen. This method must be overridden.

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The source [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that was generated prior to executing it.






---


###PreLoadReportSet(System.String)
 Represents a method that allows operations to be performed before loading the specified report. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report name.






---


###PreSaveReportSet(System.String,Izenda.AdHoc.ReportSet)
Represents a method that allows the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to be processed before it goes to the server.**(deprecated)**

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report name.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is going to be saved.






---


###ProcessDataRow(System.Data.DataRow,Izenda.AdHoc.Report,System.Boolean)
 Post-process DataRow for the streamed output (Bulk CSV). Use ProcessDataSet method to post-process data for other output types. 

Parameters: 

* [[System.Data.DataRow|http://msdn.microsoft.com/en-us/library/7f2d84ta]] row 
* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isTotals 






---


###ProcessDataSet(System.Data.DataSet,System.String)
Represents a method that can be used to change the results from executing a query on the database via the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]]. This method must be overridden.

Parameters: 

* [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] ds  - The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] that was obtained from executing the query on the database.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportPart  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the part of the report that the query is running on, if any.






---


###ProcessDataSet(System.Data.DataSet)
Represents a method that can be used to change the results from executing a query on the database via the [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]]. This method must be overridden.**(deprecated)**

Parameters: 

* [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] ds  - The [[System.Data.DataSet|http://msdn.microsoft.com/en-us/library/bwy42y0e]] that was obtained from executing the query on the database.






---


###ProcessEqualsSelectList(Izenda.AdHoc.Database.Column)
 Represents a method that gets the possible values of an equals(select) filter for the specified column.  This method must be overridden. 

Parameters: 

* [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] column  - The [[Izenda.AdHoc.Database.Column|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-Column]] that the values will be obtained for.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array of the possible values that the column can have.


---


###ProcessFriendlyException(System.Exception)
 Represents a method that produces more user-friendly output when a report has errors than the usual method would. 

Parameters: 

* [[System.Exception|http://msdn.microsoft.com/en-us/library/c18k6c59]] exception  - The [[System.Exception|http://msdn.microsoft.com/en-us/library/c18k6c59]] that was produced when the report being run encountered a non-trivial problem.





Returns:

A [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that contains the text of the exception for use on the reporting page.


---


###SaveReportRDL(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName 






---


###SaveReportSet(Izenda.AdHoc.ReportInfo,Izenda.AdHoc.ReportSet)
 Saves a report to the server's filesystem using the specified parameters. 

Parameters: 

* [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] reportInfo  - The [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object containing information about the report to save.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] definition of the report that will be saved.






---


###SaveReportSet(System.String,Izenda.AdHoc.ReportSet)
 Represents a method that saves the specified report and the current user's tenant ID to the location where reports are stored. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report being saved.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] object containing the report definition.






---


###SaveTemplate(System.String,System.String)
 Saves the form to the server's filesystem using the specified name. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullReportSetName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] template 






---


###SaveThumbnail(Izenda.AdHoc.ReportInfo,System.Drawing.Bitmap)
 Represents a method that stores a thumbnail image associated with the specified report to the report thumbnails folder on the server. 

Parameters: 

* [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] reportInfo  - The [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object that contains the information required to save the thumbnail.
* [[System.Drawing.Bitmap|http://msdn.microsoft.com/en-us/library/4e7y164x]] thumbnail  - The System.Image.Bitmap representation of the image that will be saved to the filesystem.






---


###SetRichEditorContent(System.String,System.String)
 Represents a method that intercepts the form editor contents for modification after the editor has been closed. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] requestData  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the web request data that was sent from the client to the server.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] content  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML form definition that was passed from the client to the server.





Returns:

The modified form content that will be returned to the client.


---


###ThumbnailExists(Izenda.AdHoc.ReportInfo)
 Represents a method that checks whether the thumbnail image associated with the specified report exists in the thumbnails folder on the server. 

Parameters: 

* [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] reportInfo  - The [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] object that contains the information about the report to check for a thumbnail image.





Returns:

True when the thumbnail image exists. False when the image is not found.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###UpdateMetadata()
 Clears the schema to allow a refresh of the schema's metadata on the next request. **(deprecated)**






---


