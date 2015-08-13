#WebServiceRequestProcessor

[[_TOC_]]

##Properties

None.


##Methods

###AddAndDeleteFieldsContent()
Gets a JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representing the columns available to the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with calculated columns included.





Returns:

The JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the columns in the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] among all joined tables and calculated columns.


---


###AddPartToCurrentDashboard(System.Collections.Generic.List&lt;System.String&gt;)
Adds a new report part to the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] provided the reportset is a dashboard reportset.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the reportset that the dashboard report part belongs to originally <br> 1 - The name of the report part to add to the dashboard reportset





Returns:

A JSON formatted response message denoting success or an error message if an error occurred.


---


###AddReportPartToCrs(System.Collections.Generic.List&lt;System.String&gt;)
 Adds a new report part to the current reportset that is a dashboard reportset. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the report part to add to the current reportset 1 - The X (vertical) position of the report part in the reportset 2 - The Y (horizontal) position of the report part in the reportset





Returns:

The name of the new report that was added to the reportset or a message describing the error that occurred.


---


###ApplyTopForCrs(System.Collections.Generic.List&lt;System.String&gt;)
Sets the number of records returned by the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] for all reports contained with in the set.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The number of records to apply to all the reports within the set.





Returns:

The JSON serialized response containing the status of the result.


---


###CheckIfReportExists(System.Collections.Generic.List&lt;System.String&gt;)
 Gets a JSON serialized response to determine whether a report specified in the parameters exists. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the report to check for





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON response containing the result of the check or an error message if an error was encountered.


---


###CheckReportPartExist(System.Collections.Generic.List&lt;System.String&gt;)
Gets a JSON [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of a [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] of whether a report exists.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - the name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].





Returns:

A JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] of the boolean representation of whether the report exists.


---


###CheckReportSetExists(System.Collections.Generic.List&lt;System.String&gt;)
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to determine whether the report specified in the arguments exists.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the reportset





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response indicating whether the operation was successful.


---


###DeleteReportSet(System.Collections.Generic.List&lt;System.String&gt;)
 Deletes the report with the name specified by the parameters. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the report to delete





Returns:

A JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing a message if there were problems deleting the report.


---


###DeserializeFilters(System.Object)


Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj 






---


###DeserializeFromJson(System.String)
Constructs a [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] from the input JSON formatted string.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] str  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that will be converted back to an object.





Returns:

The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] that was built from the JSON formatted string.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GenerateReportSet(System.Collections.Generic.List&lt;System.String&gt;)
 Generate a new report set using the input JSON parameters. <param name="wsArgs">0 - report set json descriptor (see 'CollectReportData' in js)</param>

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs 






---


###GenerateThumbnail(System.Collections.Generic.List&lt;System.String&gt;)
Produces a thumbnail image of the HTML output for the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] specified by the parameters provided.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the reportset to generate a thumbnail image for






---


###GetAllFiltersData()
 Gets a list of filters and all data inside the filters in a JSON format that belong to the current reportset. 





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the dashboard filters found on the current reportset.


---


###GetAutoRefreshIntervals()
 Gets the JSON formatted serialized value representing the time period in seconds the report viewer will wait before auto-refreshing its results. 





Returns:

The time in seconds the report viewer will wait before refreshing its results.


---


###GetConstraintsData()
 Get constraints defined in AdHocContext.Driver.DatabaseSchema.Constraints as a JSON formatted string. 






---


###GetCrsCategories()
Gets a JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing all the categories found among all the reports currently available to the logged in user.





Returns:

A JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the status of the request and the category data found among all reports available to the logged in user.


---


###GetCrsDashboardCategories()
 Gets a list of all the categories containing dashboards serialized to a JSON object. 





Returns:

The list of categories that contain dashboards in JSON format.


---


###GetCrsDashboardConfig()
 Gets the dashboard configuration for the current dashboard reportset. 





Returns:

The JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the dashboard configuration data.


---


###GetCrsDatasources()
Gets a JSON serialized representation of all the datasources found on the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].





Returns:

The JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of all the datasources for the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###GetCrsReportPartPreview(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the HTML generated by the specified report part on the current reportset using the specified arguments. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the report part to render <br> 1 - The name of the report part to overwrite (not used for this command) <br> 2 - The number of report part cells in the current dashboard row <br> 3 - The number of results to pull for the report part being rendered <br> 4 - The width of the chart in the report part being rendered <br> 5 - The height of the chart in the report part being rendered <br> 6 - true or false whether the report part being rendered is being generated for an export





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML used to render the report part.


---


###GetCrsReportParts()
Gets the list of report part names of the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].






---


###GetCrsSchedule(System.Collections.Generic.List&lt;System.String&gt;)
Gets a JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the schedule information for the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The client timezone offset from the server in minutes





Returns:

The JSON formatted [[Izenda.AdHoc.Webservices.ScheduleData|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-ScheduleData]] that was found on the current Izenda.AdHoc.ReportSet, taking the offset into account.


---


###GetCrsShare()
Gets a JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the sharing information for the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].





Returns:

The JSON formatted list of sharing data found on the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###GetCrsTables()
Gets a JSON formatted string with the table information for the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].






---


###GetDashboardFiltersData()
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON formatted representation of the filters found on the current dashboard reportset.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the dashboard filters found on the current dashboard reportset.


---


###GetDashboardViewerConfig()
Gets the JSON serialized representation of the [[Izenda.AdHoc.Webservices.DashboardViewerConfig|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-DashboardViewerConfig]] settings.





Returns:

The JSON serialized representation of the [[Izenda.AdHoc.Webservices.DashboardViewerConfig|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-DashboardViewerConfig]] settings.


---


###GetFieldFormats(System.Collections.Generic.List&lt;System.String&gt;)
 Get available field formats for the specified field as a JSON formatted string. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - field column name






---


###GetFieldFormatsAndOperators(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the available field formats and operators in a single list for the specified field as a JSON formatted string. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - field column name





Returns:

The JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] object containing the operators and formats for the field.


---


###GetFieldFormatsWithDefault(System.Collections.Generic.List&lt;System.String&gt;)
 Get available field formats for the specified field as a JSON formatted string. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - field column name






---


###GetFieldPreview(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the HTML preview for a single report field provided by the input parameters. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The JSON representation of the field and its properties





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HTML generated by a report using only the field specified.


---


###GetFiltersData()
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON formatted representation of the data for the filters found on the current reportset.





Returns:

The JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the filter data for the current reportset.


---


###GetFiltersForDashboard(System.Collections.Generic.List&lt;System.String&gt;)
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON formatted representation of the filters found on the dashboard reportset obtained from the specified arguments.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The full name of the reportset to get the filters for





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON formatted representation of the filters found on the reportset.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetInstantReportConfig()
Gets the JSON serialized representation of the [[Izenda.AdHoc.Webservices.InstantReportConfig|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-InstantReportConfig]] settings.





Returns:

The JSON serialized representation of the [[Izenda.AdHoc.Webservices.InstantReportConfig|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-InstantReportConfig]] settings.


---


###GetPivotGuiData()
 Get pivot GUI data 






---


###GetPrintModeSetting()
Gets a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON representation of the print mode used by the application for exporting to HTML or PDF.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] print mode for HTML and PDF exports.


---


###GetRenderedReportPartAlone(System.Collections.Generic.List&lt;System.String&gt;)
Gets the HTML output for a single report part inside the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] specified in the parameters.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to use<br> 1 - The report part name to get the HTML output for <br> 2 - A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] code for determining whether to embed included resources in the HTML for the report part





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML results for the report part


---


###GetRenderedReportSet(System.Collections.Generic.List&lt;System.String&gt;)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the rendered HTML results of the specified report.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - the name of the report.






---


###GetReportDashboardConfig(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the dashboard configuration for the given dashboard reportset. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the dashboard reportset to get the configuration for





Returns:

The JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the dashboard configuration data.


---


###GetReportData(System.Collections.Generic.List&lt;System.String&gt;)
 Gets a JSON serialized representation of the report part data for a specified reportset. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the reportset that will be used to generate the JSON data





Returns:

The JSON serialized representation of the report part data for the specified reportset.


---


###GetReportHtml(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the rendered HTML for the reportset specified by the parameters. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to load and get the HTML output for





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the literal HTML output results generated from the reportset.


---


###GetReportListConfig(System.Collections.Generic.List&lt;System.String&gt;)
Gets the JSON serialized representation of the [[Izenda.AdHoc.Webservices.ReportListConfig|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-ReportListConfig]] settings.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - Whether the page being redirected from is the instant reports page or report viewer





Returns:

The JSON serialized representation of the [[Izenda.AdHoc.Webservices.ReportListConfig|/API/Izenda/AdHoc/Webservices/Izenda-AdHoc-Webservices-ReportListConfig]] settings.


---


###GetReportListData(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the JSON serialized representation of the data used on the report viewer page to build the dynamic content. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The report name keyword that will be used to filter the results





Returns:

The JSON serialized representation of the data used on the report viewer page to build the dynamic content.


---


###GetReportListDataLite(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the JSON serialized lightweight representation of the information that is used for building the report list data. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The category that should be used to filter the results <br> 1 - The report name keyword that will be used to filter the results <br> 2 - Whether to split report subcategories according to their nesting level





Returns:

The JSON serialized lightweight representation of the information that is used for building the report list data.


---


###GetReportPartHtml(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the HTML output for a single report part on the specified report using the provided parameters so that a single report part may be prepared for a print operation. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to use for rendering a single part from<br> 1 - The name of the report part to print the HTML for <br> 2 - Not used for this call <br> 3 - A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] code for determining whether to embed included resources in the HTML for the report part <br> 4 - (Optional) A base-64 [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] encoded response server path for finding embedded resources





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML results for the report part


---


###GetReportPartHtmlForPrint(Izenda.AdHoc.ReportSet,System.Collections.Generic.List&lt;System.String&gt;)
 Gets the HTML output for a single report part on the specified report using the provided parameters so that a single report part may be prepared for a print operation. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to use for rendering a single part from.
* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - Not used for this call <br> 1 - The name of the report part to print the HTML for <br> 2 - Not used for this call <br> 3 - A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] code for determining whether to embed included resources in the HTML for the report part <br> 4 - (Optional) A base-64 [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] encoded response server path for finding embedded resources





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML results for the report part


---


###GetReportPartPreview(Izenda.AdHoc.ReportSet,System.String,System.Int32,System.Boolean,System.Int32,System.Boolean,System.Int32,System.Boolean,System.Int32,System.Boolean)
 Returns the HTML generated by the specified AdHoc.Repor with the specified information. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The name of the reportset containing the report part to update.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportPartName  - The name of the report part to update the reportset with.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] cellsInRow  - The name of the report part to overwrite.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] topSet  - Whether or not the number of records returned on the report part needs to be changed for the rendering process.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] top  - The number of results to pull for the report part being updated.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] widthSet  - Whether the report part being rendered needs to update the width of the chart for the rendering process.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] width  - The width of the chart in the report part being updated.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] heightSet  - Whether the report part being rendered needs to update the height of the chart for the rendering process.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] height  - The height of the chart in the report part being updated.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] forPrinting  - Whether the report part being updated is being generated for an export.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML used to render the report part.


---


###GetReportPartPreview(System.Collections.Generic.List&lt;System.String&gt;)
 Gets the HTML generated by the specified report part using the specified arguments. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the reportset containing the report part to render <br> 1 - The name of the report part to render <br> 2 - The name of the report part to overwrite (not used for this command) <br> 3 - The number of report part cells in the current dashboard row <br> 4 - The number of results to pull for the report part being rendered <br> 5 - The width of the chart in the report part being rendered <br> 6 - The height of the chart in the report part being rendered <br> 7 - true or false whether the report part being rendered is being generated for an export





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML used to render the report part.


---


###GetReportPreview(System.Collections.Generic.List&lt;System.String&gt;)
 Get report preview (using RenderHtml()) 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - report set json descriptor (see 'CollectReportData' in js)





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HTML report output generated by the report.


---


###GetReportViewerConfig(System.Collections.Generic.List&lt;System.String&gt;)


Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs 






---


###GetReportVisualizationProperties(System.Collections.Generic.List&lt;System.String&gt;)
Gets the list of visualization properties for the specified report part on the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The report part name to get the visualization properties for





Returns:

The JSON formatted visualization properties for the specified report part within the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###GetSchema()
 Get and serialize AdHocContext.Driver.GetSchemaInfo() as a JSON formatted string. 






---


###GetTopForCrs(System.Collections.Generic.List&lt;System.String&gt;)
Gets the JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the number of records returned for the last [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] in the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - Not used for this call





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON serialized representation of the number of records for the last report in the current set.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetTypedDbsSchema()
Gets a JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the data used for containing autocomplete information and associating fields for a datasource with the datasource.





Returns:

The JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with the autocomplete data obtained from the database schema.


---


###GetUsedTypes(System.Collections.Generic.List&lt;System.String&gt;)
 Gets a report template that is serializable to JSON and contains the relevant information for constructing a basic report structure that is used on the instant reports page. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the report to generate a template from





Returns:

The serialized JSON template for the reportset to be returned to the instant reports page.


---


###LaunchReport(System.Collections.Generic.List&lt;System.String&gt;)
Generates a reportset and updates the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with the information in the list of column assignations.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The JSON serialized data containing the report name and the list of column Izenda.AdHoc.WebServices.Assignations that will populate the current Izenda.AdHoc.ReportSet





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON response representing whether the operation was successful or encountered an error.


---


###NewCurrentReportSetDashboard(System.Collections.Generic.List&lt;System.String&gt;)
Constructs a new [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] for the current reportset and initializes its properties to expect to be treated as a dashboard.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The new name of the dashboard reportset





Returns:

A JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response denoting success.


---


###Ping()
 Gets the amount of time, in minutes, allowed between requests before the session-state provider terminates the session. 





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON formatted representation of the time allowed between requests before the session is terminated.


---


###RemoveReportPartFromCrs(System.Collections.Generic.List&lt;System.String&gt;)
 Removes the report with the specified name from the current dashboard reportset. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The full name of the report to remove from the reportset





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] denoting whether the operation was successful or encountered an error.


---


###SaveCurrentReportSet(System.Collections.Generic.List&lt;System.String&gt;)
Saves the specified report with the information in the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] object.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - (Optional) The name of the report to save with the current reportset information





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON response containing a success message or an error message if errors were encountered while saving.


---


###SaveCurrentReportSetDashboard(System.Collections.Generic.List&lt;System.String&gt;)


Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs 






---


###SendReportViaEmail(System.Collections.Generic.List&lt;System.String&gt;)


Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs 






---


###SerializeToJson(System.Object)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the input object in JSON format.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] that will be serialized as a JSON string.






---


###SetCrsSchedule(System.Collections.Generic.List&lt;System.String&gt;)
Sets the schedule data for the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] using the specified JSON formatted parameters.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - The JSON formatted report schedule data to update the current reportset with





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JSON formatted response denoting the operation was successful or an error if errors were encountered.


---


###SetCrsShare(System.Collections.Generic.List&lt;System.String&gt;)
Sets the sharing rights for the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] using the provided parameters.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The serialized JSON [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] data containing the sharing rights to update





Returns:

A JSON formatted response message denoting whether the operation was successful.


---


###SetCurrentReportSet(System.Collections.Generic.List&lt;System.String&gt;)
 Sets the current reportset to the specified value using the name of the reportset. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - the name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that will be set as the current reportset.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] denoting whether the operation was successful or encountered an error.


---


###SetDashboardToCrs(System.Collections.Generic.List&lt;System.String&gt;)
 Loads the reportset with the name specified by the argument and sets it as the current reportset. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The full name of the reportset to set as the current reportset.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response indicating whether the operation was successful.


---


###SetFiltersData(System.Collections.Generic.List&lt;System.String&gt;,System.Boolean)
 Sets the filters on the current reportset using the current dashboard reportset and the input parameters. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The serialized JSON report filter data <br> 1 - the serialized JSON report datasource information
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] updateReportSet  - Whether the new filters will be retained on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] after execution.





Returns:

The JSON [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response that can consist of a simple response message or the contents of all filters sorted by report.


---


###SetFiltersData2(Izenda.AdHoc.ReportSet,System.String,System.Boolean)
 Sets the filters on a dashboard reportset using the specified parameters. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to change the filter values for.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] serializedFilters  - The JSON serialized [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] of filters to deserialize and apply to the reportset.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] updateReportSet  - Whether the new filters will be retained on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] after execution.





Returns:

The JSON [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response that can consist of a simple response message or the contents of all filters sorted by report.


---


###SetFiltersData2(System.Collections.Generic.List&lt;System.String&gt;,System.Boolean)
 Sets the filters on a dashboard reportset using the current dashboard reportset and the input parameters. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The serialized JSON report filter data
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] updateReportSet  - Whether the new filters will be retained on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] after execution.





Returns:

The JSON [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response that can consist of a simple response message or the contents of all filters sorted by report.


---


###SetPivotCount(System.Collections.Generic.List&lt;System.String&gt;)
Sets the number of pivot columns for the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that will be displayed per page on exports.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The number of pivot columns that will be displayed on export per page





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response message denoting whether the operation succeeded.


---


###SetPivotField(System.Collections.Generic.List&lt;System.String&gt;)
Sets the pivot field on the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] using the input parameters.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The column name of the field to pivot on.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response message denoting whether the operation succeeded.


---


###SetPivotFunction(System.Collections.Generic.List&lt;System.String&gt;)
Sets the aggregation function used on the pivot field on the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] using the input parameters.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the aggregation function





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response message denoting whether the operation succeeded.


---


###SetReportVisualizationProperties(System.Collections.Generic.List&lt;System.String&gt;)
Sets the list of visualization properties that persist with a report using the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] and the specified parameters.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the report part to get the visualization properties for<br> 1 - The JSON serialized list of visualization properties to update the report with





Returns:

The JSON formatted visualization properties for the specified report part within the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###SetTopRecords(System.Collections.Generic.List&lt;System.String&gt;)
Sets the number of records returned for all report parts contained on the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The new number of records to return for the current reportset upon rendering





Returns:

The JSON formatted response message denoting success or an error message if an error occurred.


---


###SetTopToReportPartInCrs(System.Collections.Generic.List&lt;System.String&gt;)
 Sets the number of records obtained by the report specified that belongs to the current reportset to the amount specified. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the report within the current reportset to modify <br> 1 - The number of records to update the report to retrieve





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response indicating whether the operation was successful.


---


###SyncCurrentReportSetDashboard(System.Collections.Generic.List&lt;System.String&gt;)
 Sync dashboard 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs 






---


###TaskExists(System.Collections.Generic.List&lt;System.String&gt;)
 Checks whether a response server task exists based on the key the task was assigned at creation. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The key to check for in the collection of response server tasks.





Returns:

A JSON serialized boolean for whether the task exists or not.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###UpdateAndGetCrsReportPartPreview(System.Collections.Generic.List&lt;System.String&gt;)
 Updates information relevant to the report part stored on the current dashboard reportset and returns the HTML generated by the updated report part. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the report part to update the reportset with <br> 1 - The name of the report part to overwrite <br> 2 - The number of report part cells in the current dashboard row <br> 3 - The number of results to pull for the report part being updated <br> 4 - The width of the chart in the report part being updated <br> 5 - The height of the chart in the report part being updated <br> 6 - true or false whether the report part being updated is being generated for an export





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML used to render the report part.


---


###UpdateAndGetReportPartPreview(System.Collections.Generic.List&lt;System.String&gt;)
 Updates information relevant to the report part stored on a dashboard report set and returns the HTML generated by the updated report part. 

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The name of the reportset containing the report part to update <br> 1 - The name of the report part to update the reportset with <br> 2 - The name of the report part to overwrite <br> 3 - The number of report part cells in the current dashboard row <br> 4 - The number of results to pull for the report part being updated <br> 5 - The width of the chart in the report part being updated <br> 6 - The height of the chart in the report part being updated <br> 7 - true or false whether the report part being updated is being generated for an export





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML used to render the report part.


---


###UpdateCrsFields(System.Collections.Generic.List&lt;System.String&gt;)
Updates the list of fields on the current [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with the JSON formatted field data provided.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; wsArgs  - 0 - The serialized JSON formatted dictionary of field data to update the current reportset with





Returns:

A JSON formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] response denoting success.


---


