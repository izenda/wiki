#Utility

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|String|[[MasterReport|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Utility_MasterReport]]| Gets a web-safe report name that can be used as a URL query parameter for a master report from either the current request or the current report set. |String.Empty|
|DateTime|[[NullDateTime|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Utility_NullDateTime]]|Gets the [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] value representative of a null throughout the AdHoc reporting tool.|null|
|String|[[ReportName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Utility_ReportName]]| Gets the name of the last report that was saved by checking the request parameters. |null|
|Int32|[[ReportVersion|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Utility_ReportVersion]]| Gets the major component of the version number for the reporting software. |6|
|Boolean|[[RequestFailed|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Utility_RequestFailed]]| Determines whether there has been a failure to process a web request in the application due to insufficient permissions. |False|


##Methods

###AddDeltas(System.Data.DataTable,System.Object[],Izenda.AdHoc.FieldCollection)
Creates a copy of the input [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] with the change in values between each row inserted between the source data rows.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The source [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to compute the change in values (deltas) for.
* [[System.Object[]|http://msdn.microsoft.com/en-us/library/e5kfa45b]] percents  - The array of rates of change that can be accessed to calculate a total change for the entire collection.
* [[Izenda.AdHoc.FieldCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FieldCollection]] fields  - The [[Izenda.AdHoc.FieldCollection|/API/Izenda/AdHoc/Izenda-AdHoc-FieldCollection]] containing the aggregation data associated with the source data.





Returns:

A [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the rates of change between each row of source data provided.


---


###AllowModifyReport(Izenda.AdHoc.ReportSet)
Checks the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to ensure the current user has the ability to modify the report.

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to check against the current user privileges.





Returns:

true when the user has the ability to modify the report, otherwise false.


---


###AnalyzeForCopyPaste(System.String,System.Boolean)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] s 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isDateTime 






---


###BitmapToBase64String(System.Drawing.Bitmap,System.Drawing.Imaging.ImageFormat)
Produces a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the specified [[System.Drawing.Bitmap|http://msdn.microsoft.com/en-us/library/4e7y164x]] image using base 64 encoding.

Parameters: 

* [[System.Drawing.Bitmap|http://msdn.microsoft.com/en-us/library/4e7y164x]] imageIn  - The image to transform into a base 64 string.
* [[System.Drawing.Imaging.ImageFormat|http://msdn.microsoft.com/en-us/library/z6x43tyt]] format  - The format of the image.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the base 64 encoded image data.


---


###BitmapToByteArray(System.Drawing.Bitmap,System.Drawing.Imaging.ImageFormat)
Produces the [[System.Byte|http://msdn.microsoft.com/en-us/library/yyb1w04y]] array representation of the specified [[System.Drawing.Bitmap|http://msdn.microsoft.com/en-us/library/4e7y164x]] image.

Parameters: 

* [[System.Drawing.Bitmap|http://msdn.microsoft.com/en-us/library/4e7y164x]] imageIn  - The image to transform into a byte array.
* [[System.Drawing.Imaging.ImageFormat|http://msdn.microsoft.com/en-us/library/z6x43tyt]] format  - The format of the image.





Returns:

A [[System.Byte|http://msdn.microsoft.com/en-us/library/yyb1w04y]] array containing the image data.


---


###ChangeConnectionTimeout(System.String,System.Int32)
 Changes the connection timeout attribute on the specified connection string. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] cs  - The database connection string to use.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] newValue  - The new connection timeout value in minutes.





Returns:

The new connection string with the modified connection timeout.


---


###CheckCondition(Izenda.AdHoc.ReportSet)
Determines whether the loaded [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] meets the conditions to be sent out as part of the scheduler procedure.

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to check for the scheduler condition prior to sending it out.






---


###CheckLimitations(System.Boolean)
 Performs various diagnostic checks to ensure the application is in a valid state. 

Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] asModernBi  - Whether the application will check for a valid license key and database connection.






---


###CheckLimitations()
 Performs various diagnostic checks to ensure the application is in a valid state. 






---


###CheckUserName()
 Determines if the current license key is valid and the current user is initialized properly and redirects the user to either the settings page or the login page if the tests fail. 






---


###Clone(System.Object)
Creates an exact copy of the input [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to clone.





Returns:

The copy of the [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###ConvertDataTableToCsv(System.Data.DataTable,System.String,System.Boolean)
Converts the data in the input [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] into a CSV [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] dt  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] source data to convert to CSV.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] delimeter  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] delimeter used to separate values.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] withColumnNames  - Whether or not the CSV will be generated with the column names as an additional row at the beginning.





Returns:

The generated [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the CSV data.


---


###ConvertDataTableToCsv(System.Data.DataTable,System.Boolean)
Converts the data in the input [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] into a CSV [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] dt  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] source data to convert to CSV.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] withColumnNames  - Whether or not the CSV will be generated with the column names as an additional row at the beginning.





Returns:

The generated [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the CSV data.


---


###ConvertToHtmlColor(System.Drawing.Color)
Generates a literal [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HTML color code using the specified [[System.Drawing.Color|http://msdn.microsoft.com/en-us/library/14w97wkc]].

Parameters: 

* [[System.Drawing.Color|http://msdn.microsoft.com/en-us/library/14w97wkc]] color  - The [[System.Drawing.Color|http://msdn.microsoft.com/en-us/library/14w97wkc]] to translate into a web color.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML color.


---


###ConvertToHtmlTable(System.Data.DataTable)
Generates an HTML table in a [[System.Web.UI.LiteralControl|http://msdn.microsoft.com/en-us/library/50eewx9c]] from the input [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] that can be inserted into a web page.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the data to insert into the HTML table.





Returns:

The [[System.Web.UI.LiteralControl|http://msdn.microsoft.com/en-us/library/50eewx9c]] containing the generated HTML table.


---


###CorrectPostBackEvent(System.String)
 Modifies the input script to use escaped characters for postback events. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Script  - The input script to correct.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the script with escaped characters.


---


###CultureFromName(System.String)
 Try to get CultureInfo based on the provided name 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  -  Culture name in the format languagecode2-country/regioncode2, or two-letter code for the language, or English language name or native language name 





Returns:

CultureInfo


---


###DiagnosticTest()
 Performs various diagnostic tests against the reporting tool and creates a set of results. 





Returns:

The [[System.Collections.Specialized.ListDictionary|http://msdn.microsoft.com/en-us/library/dc6bdt5e]] of the results for the diagnostic tests.


---


###Divide(System.Data.DataTable,System.Int32,Izenda.AdHoc.Report)
Separates the input [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] into the specified number of sections for use as field&#124;value pairs.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The source [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to split.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] parts  - The number of field&#124;value parts to split the data into.
* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The source [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that the data was loaded from.





Returns:

The [[Izenda.AdHoc.DataTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-DataTableCollection]] consisting of the entire set of split [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] parts.


---


###EncodeJsString(System.String,System.Boolean)
Gets the equivalent [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] encoded for javascript output by escaping escape characters and replacing unicode characters with their hex equivalents.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] s  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to encode for javascript.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] doubleOuterQuotes  - Whether or not the javascript will need double quotes for the outside quotes.





Returns:

The equivalent [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] encoded for javascript output.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###ExtractHexDigits(System.String)
Extracts any characters from the input [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that can be interpreted as hexadecimal values.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input value that a hexidecimal value can be extracted from.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the hexadecimal extracted from the input.


---


###FindControlByID(System.Web.UI.ControlCollection,System.String)
Locates the [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] object with the specified ID in the control hierarchy provided.

Parameters: 

* [[System.Web.UI.ControlCollection|http://msdn.microsoft.com/en-us/library/kbe31ba9]] controls  - The [[System.Web.UI.ControlCollection|http://msdn.microsoft.com/en-us/library/kbe31ba9]] containing the hierarchy of controls to search.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] id  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ID of the control to locate.





Returns:

The first [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] with the specified ID found in the collection.


---


###FindControlByType(System.Web.UI.ControlCollection,System.Type)
Locates the first [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] object of the specified [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] in the control hierarchy provided.

Parameters: 

* [[System.Web.UI.ControlCollection|http://msdn.microsoft.com/en-us/library/kbe31ba9]] controls  - The [[System.Web.UI.ControlCollection|http://msdn.microsoft.com/en-us/library/kbe31ba9]] containing the hierarchy of controls to search.
* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] type  - The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the controls that will be located in the collection.





Returns:

The first [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] of the specified [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] found in the collection.


---


###FindControlsByType(System.Web.UI.ControlCollection,System.Type)
Locates all [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] objects of the specified [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] in the control hierarchy provided.

Parameters: 

* [[System.Web.UI.ControlCollection|http://msdn.microsoft.com/en-us/library/kbe31ba9]] controls  - The [[System.Web.UI.ControlCollection|http://msdn.microsoft.com/en-us/library/kbe31ba9]] containing the hierarchy of controls to search.
* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] type  - The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the controls that will be located in the collection.





Returns:

A [[System.Collections.ArrayList|http://msdn.microsoft.com/en-us/library/7x4b0a97]] containing all the controls of the specified [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] found in the collection.


---


###FindForm(System.Web.UI.Page,System.String)
Locates the [[System.Web.UI.HtmlControls.HtmlForm|http://msdn.microsoft.com/en-us/library/s90z6fb3]] with the specified ID in the web page.

Parameters: 

* [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] page  - The [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] to find the form in.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] formID  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the ID the form was given.





Returns:

The [[System.Web.UI.HtmlControls.HtmlForm|http://msdn.microsoft.com/en-us/library/s90z6fb3]] that was found.


---


###FindForm(System.Web.UI.Page)
Locates the [[System.Web.UI.HtmlControls.HtmlForm|http://msdn.microsoft.com/en-us/library/s90z6fb3]] with no ID in the web page.

Parameters: 

* [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] page  - The [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] to find the form in.





Returns:

The [[System.Web.UI.HtmlControls.HtmlForm|http://msdn.microsoft.com/en-us/library/s90z6fb3]] that was found.


---


###FixImgTagUrlsForLocalhost(System.String)
 Scans the input HTML for images and updates the URLs with the base 64 string representation of the file. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] html  - The HTML with fid or image resources that need to be fixed by representing them as base 64 strings.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with the image links transformed into the image resource's base 64 string equivalents.


---


###FixImgTagUrlsForLocalhost(System.String,System.Boolean)
 Scans the input HTML for images and updates the URLs with the base 64 string representation of the file. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] html  - The HTML with fid or image resources that need to be fixed by representing them as base 64 strings.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isDirectHtmlRender  - Whether or not the images in the HTML are being directly rendered to the screen. This is usually the case when using an Internet Explorer version earlier than nine.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with the image links transformed into the image resource's base 64 string equivalents.


---


###GenerateChart(System.Data.DataTable,System.String,Izenda.AdHoc.Report,System.Boolean)
Creates a [[Izenda.Controls.ImageContentGenerator|/API/Izenda/Controls/Izenda-Controls-ImageContentGenerator]] containing the serialized chart image data.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the data loaded from the report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] chartType  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the type of chart being rendered.
* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] source that the data was loaded from.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] forceSizeFromChart  - Whether the chart type default height and width will override the height and width set on the report itself.





Returns:

An [[Izenda.Controls.ImageContentGenerator|/API/Izenda/Controls/Izenda-Controls-ImageContentGenerator]] containing the serialized information in the chart.


---


###GenerateChart(System.Data.DataTable,System.String,Izenda.AdHoc.Report)
Creates a [[Izenda.Controls.ImageContentGenerator|/API/Izenda/Controls/Izenda-Controls-ImageContentGenerator]] containing the serialized chart image data.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the data loaded from the report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] chartType  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the type of chart being rendered.
* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] source that the data was loaded from.





Returns:

An [[Izenda.Controls.ImageContentGenerator|/API/Izenda/Controls/Izenda-Controls-ImageContentGenerator]] containing the serialized information in the chart.


---


###GenerateChartBinary(Izenda.AdHoc.ReportSet)
Creates a [[Izenda.Controls.ImageContentGenerator|/API/Izenda/Controls/Izenda-Controls-ImageContentGenerator]] with the image data for the primary chart on the input [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] containing a chart report to generate an image for.





Returns:

An [[Izenda.Controls.ImageContentGenerator|/API/Izenda/Controls/Izenda-Controls-ImageContentGenerator]] containing the image data for the chart.


---


###GenerateLogo(System.String)
Creates a [[System.Web.UI.HtmlControls.HtmlTable|http://msdn.microsoft.com/en-us/library/kzt03tht]] that contains the powered by Izenda logo as a control inside the table.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] heght  - The height in pixels that the image should have.





Returns:

A [[System.Web.UI.HtmlControls.HtmlTable|http://msdn.microsoft.com/en-us/library/kzt03tht]] control containing the powered by Izenda logo


---


###GenerateMap(System.Data.DataTable,Izenda.AdHoc.Report)
Generates a [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] containing the HTML for the map.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the data loaded by the report.
* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] source that the data was loaded from.





Returns:

The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] containing the HTML for the map.


---


###GenerateWebChart(System.Data.DataTable,System.String,Izenda.AdHoc.Report,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String)
Generates a [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] containing the rendered chart content that can be inserted into a web page.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the data loaded by the report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] chartType  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the type of chart that is being rendered.
* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] source that the data was loaded from.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isExcel  - Whether the chart is being rendered for an excel export.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] forWord  - Whether the chart is being rendered for a Microsoft Word export.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] forPDF  - Whether the chart is being rendered for a PDF export.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] probablyHoverSubreport  - Whether or not the browser rendering the chart offers support for the hover event.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] mwSet  - Whether Dundas charts will render their legends below the report.





Returns:

The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] containing the HTML that generates the control or the rendered chart image.


---


###GetAppSetting(System.String)
 Gets the setting in the application configuration settings with the specified name. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] settingName  - The name of the setting in the application configuration settings collection.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the application setting obtained.


---


###GetBool(System.Object)
Converts a [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] into a System.Boolean, if the conversion is possible.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to attempt to convert to a boolean.





Returns:

true if the conversion was successful and evaluates to true, otherwise false.


---


###GetBool(System.Object,System.Boolean)
Converts a [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] into a System.Boolean, if the conversion is possible.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to attempt to convert to a boolean.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] default  - The default value to return if the conversion is unsuccessful.





Returns:

true if the conversion was successful and evaluates to true, otherwise false.


---


###GetCurrentScriptSuffix()
 Gets a suffix that is appended onto the end of script files to denote the version and prevent conflicts between versioned files. 





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] suffix using the DLL version that is appended onto the end of script files.


---


###GetDateTime(System.Object)
Converts the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] into a System.DateTime, or a default value if the conversion is not possible.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to attempt to convert to a [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]].





Returns:

A [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] object with the converted value.


---


###GetDomain(System.String)
 Extracts the domain portion of a web address or email address. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] address 





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the domain for the web or email address.


---


###GetDrilDownStyleList()
 Gets a list of all the different methods of displaying a subreport in a form that can be added to a dropdown list control. 





Returns:

The [[System.Web.UI.WebControls.ListItemCollection|http://msdn.microsoft.com/en-us/library/ez4tsddk]] of drilldown styles for displaying subreports.


---


###GetEnum(System.Object)


Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o 






---


###GetEnum(System.Object,Izenda.AdHoc.Utility.TEnum)


Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o 
* [[Izenda.AdHoc.TEnum|/API/Izenda/AdHoc/Izenda-AdHoc-TEnum]] default 






---


###GetFlatTableTitle(System.Data.DataTable,System.Boolean)
Gets the customized table titles from the input [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] in a comma separated [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] with customized titles in the extended properties collection to use.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] showVisualGroupLabels  - Whether or not the list being generated will include column names as visual grouping information in the list of titles.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing a comma separated list of all the titles found in the extended properties list of the [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]].


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetInt(System.Object,System.Int32)
Converts a [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] into a System.Integer, if the conversion is possible.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to attempt to convert to an integer.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] default  - The default value to return if the conversion is unsuccessful.





Returns:

A System.Integer if the conversion was successful, otherwise the default value.


---


###GetListItems(System.Type)
Gets a [[System.Web.UI.WebControls.ListItem|http://msdn.microsoft.com/en-us/library/bb768tf6]] array of all the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] names of the members of an enumeration.

Parameters: 

* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] enumType  - The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] enumeration to extract the names of the members for.





Returns:

The [[System.Web.UI.WebControls.ListItem|http://msdn.microsoft.com/en-us/library/bb768tf6]] of all the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] enumeration member names found.


---


###GetMIMEType(System.String)
 Gets the MIME type that corresponds to the specified file exxtension. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] extension  - The file extension to get the MIME type for.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the MIME type used in web requests.


---


###GetNextTime(System.DateTime,Izenda.AdHoc.RepeatType)
Calculates the next [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] a scheduled report will be executed with the specified parameters.

Parameters: 

* [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] date  - The [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that the report is currently scheduled for.
* [[Izenda.AdHoc.RepeatType|/API/Izenda/AdHoc/Izenda-AdHoc-RepeatType]] repeatType  - The [[Izenda.AdHoc.RepeatType|/API/Izenda/AdHoc/Izenda-AdHoc-RepeatType]] interval the report is scheduled to execute at.





Returns:

A [[Izenda.AdHoc.DateRef|/API/Izenda/AdHoc/Izenda-AdHoc-DateRef]] containing the [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] that the report will next execute at.


---


###GetOperatorName(Izenda.AdHoc.OperatorTypes,System.Boolean)
 Gets the displayable name for the specified operator type. 

Parameters: 

* [[Izenda.AdHoc.OperatorTypes|/API/Izenda/AdHoc/Izenda-AdHoc-OperatorTypes]] operatorType  - The [[Izenda.AdHoc.OperatorTypes|/API/Izenda/AdHoc/Izenda-AdHoc-OperatorTypes]] enumeration item to get the name of.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] not  - Whether the filter that the operator belongs to applies the NOT condition.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] describing the operator that serves as a name.


---


###GetPostBackClientEvent(System.Web.UI.Control,System.String)
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that can be used in a client event to cause postback to the server. The reference [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] is defined by the specified control that handles the postback and a string argument of additional event information.

Parameters: 

* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] sender  - The server [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that references the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] that processes the postback on the server.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] argument  - A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] of optional arguments to pass to the control that processes the postback.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that, when treated as script on the client, initiates the postback.


---


###GetPostBackEventReference(System.Web.UI.Control,System.String)
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that can be used in a client event to cause postback to the server. The reference [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] is defined by the specified control that handles the postback and a string argument of additional event information.

Parameters: 

* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] sender  - The server [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that references the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] that processes the postback on the server.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] argument  - A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] of optional arguments to pass to the control that processes the postback.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that, when treated as script on the client, initiates the postback.


---


###GetReports(out System.Collections.Generic.Dictionary&lt;Izenda.AdHoc.ReportInfo,Izenda.AdHoc.ReportSet&gt;,out System.Web.UI.WebControls.ListItemCollection)


Parameters: 

* out [[System.Collections.Generic.Dictionary|About:blank]]&lt;[[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]],[[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]]&gt; reports 
* out [[System.Web.UI.WebControls.ListItemCollection|http://msdn.microsoft.com/en-us/library/ez4tsddk]] targetReports 






---


###GetResource(System.String)
 Gets the resource with the specified name from the collection of resources registered with the assembly. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the resource to locate.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the value obtained from the registered resources.


---


###GetRootUrl()
 Gets the base URL for the application. 





Returns:

The base URL for the application consisting of the protocol, port, server name, and application path.


---


###GetScriptsEmbeded(System.Collections.Generic.List&lt;System.String&gt;)
Gets a literal [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the script resources that are built by rendering the entire body of those scripts.

Parameters: 

* [[System.Collections.Generic.List|http://msdn.microsoft.com/en-us/library/6sh2ey19]]&lt;[[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]]&gt; scriptsList  - The list of script resource names to concatenate into the embedded resource.





Returns:

The literal [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the script resources that were loaded and concatenated.


---


###GetSqlTypeGroup(Izenda.AdHoc.Database.SqlType)
Gets the [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] that the input [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] belongs to.

Parameters: 

* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] sqlType  - The [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] to get the group for.





Returns:

The [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] that the input [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] belongs to.


---


###GetSqlTypeGroups()







---


###GetSqlValueString(System.Object)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the input [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] that is a database result.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] val  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] database result to convert to a string.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database object.


---


###GetSqlValueString(System.Object,Izenda.AdHoc.Database.SqlType)
Gets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the input [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] that is a database result.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] val  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] database result to convert to a string.
* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] columnType  - The [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] of the database object.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the database object.


---


###GetString(System.Object)
Casts the provided [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to its [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] equivalent.

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o  - The object to represent as a string.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the object.


---


###GetType(Izenda.AdHoc.Database.SqlType)
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] that represents the input [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]].

Parameters: 

* [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] sqlType  - The input [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]] to get the equivalent [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] for.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] that corresponds to the [[Izenda.AdHoc.Database.SqlType|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlType]].


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetTypeFromSqlTypeGroup(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] typeGroup 






---


###GetVisualGroupTableTitle(System.Data.DataTable)
Gets a [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the field&#124;value pairs with the customized title data in the value cell and the column name in the field cell.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The source [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the customized titles in the extended properties of the table.





Returns:

A [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] containing the column name of the visual group and the title value that was applied to the table.


---


###GetWebReportName(Izenda.AdHoc.ReportSet)
 Gets the web-safe representation of the report name with the specified parameter. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to get the report name from.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] web-safe name of the report.


---


###GetWindowsProductID()
 Gets the serial number of the Windows installation that the server is currently running. 





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the Windows serial number of the server OS installation.


---


###HexStringToColor(System.String)
Generates a [[System.Drawing.Color|http://msdn.microsoft.com/en-us/library/14w97wkc]] from the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] hexadecimal color value.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] hexColor  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the hexadecimal RGB color.





Returns:

The [[System.Drawing.Color|http://msdn.microsoft.com/en-us/library/14w97wkc]] corresponding to the RGB value of the hexadecimal color value.


---


###Humanize(System.String)
Gets a human-readable representation of the input [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] s  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to translate into a more human-readable form.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with special characters stripped out to be more readable.


---


###Humanize(System.String,System.String)
Gets a human-readable representation of the input [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] function  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the aggregation function to use as a prefix to the input string.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] s  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to translate into a more human-readable form.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with special characters stripped out to be more readable.


---


###InitFakeHttpContext()
 Initializes a dummy web server that can function as a headless instance of Izenda without a web browser. 






---


###IntToOrdinal(System.Int32)
 Converts the input System.Integer into an ordinal System.String equivalent. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] number  - The number to convert into its equivalnet ordinal.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ordinal representation of the number.


---


###Invert(System.Data.DataTable,System.Boolean)
Creates a copy of the input [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] with the columns and rows transposed with each other.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to invert.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] addColumnsNames  - Whether the inverted [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] will include the column names of the source table as column names on the inverted table.





Returns:

The inverted [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]].


---


###IsClientScriptBlockRegistered(System.Web.UI.Control,System.String)
Determines whether a script block with the specified key is registered to the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] of the provided control.

Parameters: 

* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] sender  - The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that references the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] to check.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the client script to check.





Returns:

true if the script with the specified key is registered on the page, otherwise false.


---


###IsDateTimeSqlTypeGroup(Izenda.AdHoc.Database.SqlTypeGroup)
Determines whether the [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] is part of the date or time type groups.

Parameters: 

* [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] sqlTypeGroup  - The [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] to check.





Returns:

true when the SQL type group is a date or time type, otherwise false.


---


###IsNull(System.String)
Determines whether the input [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] evaluates to null.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] s  - The input [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to check.





Returns:

true when the input string evaluates to null, otherwise false.


---


###IsNull(System.Object)
 Determines whether the input value evaluates logically to null for various datatypes. 

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] o  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to check.





Returns:

true if the object evaluates to null


---


###IsNumeric(System.Type)
Determines whether the input [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] can be represented as a number.

Parameters: 

* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] type  - The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] to check.





Returns:

true when the type can be represented as a number, otherwise false


---


###IsNumericSqlTypeGroup(Izenda.AdHoc.Database.SqlTypeGroup)
Determines whether the [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] is part of the numeric type group.

Parameters: 

* [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] sqlTypeGroup  - The [[Izenda.AdHoc.Database.SqlTypeGroup|/API/Izenda/AdHoc/Database/Izenda-AdHoc-Database-SqlTypeGroup]] to check.





Returns:

true when the SQL type group is numeric, otherwise false.


---


###IsValidHexColor(System.String)
Determines whether the input [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] represents a valid RGB hexadecimal color.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value to check.





Returns:

true if the input can be represented as a hexadecimal color.


---


###IsValuesRequedOperator(Izenda.AdHoc.OperatorTypes)
 Determines whether the specified operator type returns a range of values to choose from when used as a filter. 

Parameters: 

* [[Izenda.AdHoc.OperatorTypes|/API/Izenda/AdHoc/Izenda-AdHoc-OperatorTypes]] operatorType  - The [[Izenda.AdHoc.OperatorTypes|/API/Izenda/AdHoc/Izenda-AdHoc-OperatorTypes]] enumeration item to check.





Returns:

true when the values the user can choose from consists of a list of values, otherwise false.


---


###KeyIsExpired()
 Determines whether the current license key has expired or not. 





Returns:

true when the current license key has passed its expiration date.


---


###LimitColumns(System.Data.DataTable,System.Int32)
Constructs a [[Izenda.AdHoc.DataTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-DataTableCollection]] with the number of columns limited to the specified number.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] t  - The source [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to use.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] columnsLimit  - The number of columns the resulting collection of data should be limited to.





Returns:

The [[Izenda.AdHoc.DataTableCollection|/API/Izenda/AdHoc/Izenda-AdHoc-DataTableCollection]] with the columns limited.


---


###LoadReport(System.Web.UI.Page)
Loads the [[CurrentReportSet|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_AdHocContext_CurrentReportSet]] into the System.Web.UI.Page.

Parameters: 

* [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] page  - The [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] being loaded.





Returns:

True if the load was successful, otherwise false.


---


###MakeHtmlSnapshot(System.String,Izenda.AdHoc.ReportInfo,Izenda.AdHoc.ReportSet,System.Int32,System.Int32,System.Boolean)
 Creates a thumbnail image by taking a snapshot of a web page using the specified parameters. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] html  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HTML that will be rendered as a thumbnail by taking a snapshot.
* [[Izenda.AdHoc.ReportInfo|/API/Izenda/AdHoc/Izenda-AdHoc-ReportInfo]] reportInfo  - The information about the report that is being rendered.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The complete [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] containing the extended report information.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] thumbnailWidth  - The width in pixels to use for the generated thumbnail image.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] thumbnailHeight  - The height in pixels to use for the generated thumbnail image.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] reportChanged  - Whether the report has changed since it was last saved.






---


###MessageBox(System.String)
 Inserts a modal dialog box into the current response object with the specified message. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] message  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] message to use as the text of the message box.






---


###PageIsPostBack(System.Web.UI.Page)
 Determines whether a postback operation is occurring in the page. 

Parameters: 

* [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] page  - The [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] that is being processed.





Returns:

true when a postback is occurring, otherwise false.


---


###RegexReplace(System.String,System.String,System.String,System.Boolean)
Evaluates a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with the regular expression and parameters.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] regex  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression to evaluate for matches.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input to scan for matches.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] replacement to insert when a match occurs.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] ignorecase  - Whether or not to ignore upper/lowercase variations of the input string.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with all instances of the matches replaced with the appropriate value.


---


###RegexReplace(System.String,System.String,System.String)
Evaluates a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with the regular expression and parameters.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] regex  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression to evaluate for matches.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input to scan for matches.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] replacement to insert when a match occurs.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with all instances of the matches replaced with the appropriate value.


---


###RegexReplace(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions)
Evaluates a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with the regular expression and parameters.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] regex  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] expression to evaluate for matches.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] input to scan for matches.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] replacement to insert when a match occurs.
* [[System.Text.RegularExpressions.RegexOptions|http://msdn.microsoft.com/en-us/library/443e8hc7]] ro  - The set of regular expression options to use when evaluating matches.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] with all instances of the matches replaced with the appropriate value.


---


###RegisterClientScriptBlock(System.Web.UI.Control,System.String,System.String)
Registers the client script with the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] with the key and script literal.

Parameters: 

* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] sender  - The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that references the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] to register the script with.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the client script to register.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] script  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] script literal to register.






---


###RegisterCommonScripts(System.Web.UI.Control)
Registers a script block for the specified [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] containing the scripts used throughout the application.

Parameters: 

* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] sender  - The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that the scripts should be added to.






---


###RegisterHiddenField(System.Web.UI.Control,System.String,System.String)
Registers a hidden value with the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] with the name and initial value.

Parameters: 

* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] sender  - The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that references the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] to register the hidden field to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] hiddenFieldName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name that the hidden field will have.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] hiddenFieldInitialValue  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] value that the hidden field will be initialized with.






---


###RegisterStartupScript(System.Web.UI.Control,System.String,System.String)
Registers the startup script with the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] with the key and script literal.

Parameters: 

* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] sender  - The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] that references the [[System.Web.UI.Page|http://msdn.microsoft.com/en-us/library/dfbt9et1]] to register the script with.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the startup script to register.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] script  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] script literal to register.






---


###ReportExistsToOtherUser(System.String)
 Determines whether the report with the specified name can be loaded by the currently logged in user if the user is not the owner of the report. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] reportName  - The name of the report to check.





Returns:

true when the user can load the report, otherwise false.


---


###ReportNameToInternalJavascriptName(System.String)
 Gets the report name converted to a format that is safe for use in a javascript function by replacing the %27 entity with a single quote. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] report name with %27 entities that need replacing.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] report name that is safe for javascript functions.


---


###ReportNameToInternalJavascriptNameWithoutID(System.String)
Gets the equivalent [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] for the report name with all single quotes, backslashes

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name 






---


###ReportNameToWebName(Izenda.AdHoc.AdHocConfig,System.Boolean,System.String)
 Gets the web-safe representation of the report name with the specified parameters. 

Parameters: 

* [[Izenda.AdHoc.AdHocConfig|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocConfig]] config  - The [[Izenda.AdHoc.AdHocConfig|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocConfig]] used for the application.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] useReportID  - Whether or not the application uses the report ID instead of the report name.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] report name to convert to a web-safe name.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] web-safe name of the report.


---


###ReportNameToWebName(System.String)
 Gets the web-safe representation of the report name with the specified parameter. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] report name to convert to a web-safe name.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] web-safe name of the report.


---


###ReportWebNameToNormal(System.String)
 Gets the real report name from the a web-safe representation of the report name. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] webName  - The web-safe representation of the report name.





Returns:

The real report name.


---


###ScrubSql(System.String)
 Performs a basic search and replace on a SQL string to ensure arbitrary SQL is not executed. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sql  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL to check.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the SQL that has been checked with a basic level of injection attack checking.


---


###SendEmail(System.String,System.String,System.String,System.String)
 Constructs a mail message using the specified parameters and sends it using SMTP messaging. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] from  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address of the sender.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address(es) of the recipients.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] subject  - The text that will be used as the subject line of the mail message.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] body  - The text that will be used as the content body of the mail message.






---


###SendEmail(System.String,System.String,System.String,System.String,System.String,System.String)
 Constructs a mail message using the specified parameters and sends it using SMTP messaging. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] from  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address of the sender.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address(es) of the recipients.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] subject  - The text that will be used as the subject line of the mail message.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] body  - The text that will be used as the content body of the mail message.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] attachmentUrl  - The web address where a downloadable attachment can be accessed that will be attached to the message.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] attachmentName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the attachment that will be used in the message.






---


###SendEmailEx(System.String,System.String,System.String,System.String,Izenda.Controls.IContentGenerator,System.String)
 Constructs a mail message using the specified parameters and sends it using SMTP messaging. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] from  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address of the sender.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address(es) of the recipients.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] subject  - The text that will be used as the subject line of the mail message.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] body  - The text that will be used as the content body of the mail message.
* [[Izenda.Controls.IContentGenerator|/API/Izenda/Controls/Izenda-Controls-IContentGenerator]] attachmentBody  - A [[ID|/API/Izenda/Controls/CodeSamples/Izenda_Controls_IContentGenerator_ID]] with the serialized attachment data to add to the message.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] attachmentName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the attachment that will be used in the message.






---


###SendEmailEx(System.Net.Mail.SmtpClient,System.String,System.Net.Mail.MailMessage)
 Sends an email message using the specified parameters. 

Parameters: 

* [[System.Net.Mail.SmtpClient|http://msdn.microsoft.com/en-us/library/4971yhhc]] client  - The [[System.Net.Mail.SmtpClient|http://msdn.microsoft.com/en-us/library/4971yhhc]] that will be used to send the mail message.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address(es) of the recipients.
* [[System.Net.Mail.MailMessage|http://msdn.microsoft.com/en-us/library/8t22a8ww]] what  - The [[System.Net.Mail.MailMessage|http://msdn.microsoft.com/en-us/library/8t22a8ww]] to send.






---


###SendEmailEx(System.Net.Mail.SmtpClient,System.String,System.Net.Mail.MailMessage,System.Boolean,System.Int32)
 Sends an email message using the specified parameters. 

Parameters: 

* [[System.Net.Mail.SmtpClient|http://msdn.microsoft.com/en-us/library/4971yhhc]] client  - The [[System.Net.Mail.SmtpClient|http://msdn.microsoft.com/en-us/library/4971yhhc]] that will be used to send the mail message.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address(es) of the recipients.
* [[System.Net.Mail.MailMessage|http://msdn.microsoft.com/en-us/library/8t22a8ww]] what  - The [[System.Net.Mail.MailMessage|http://msdn.microsoft.com/en-us/library/8t22a8ww]] to send.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] secureConnection  - Whether the mail message will be sent with SSL encryption.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] port  - The port of the mail server to connect to.






---


###SendEmailEx(System.String,System.Net.Mail.MailMessage)
 Sends an email message using a default client and the specified parameters. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] to  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the mail address(es) of the recipients.
* [[System.Net.Mail.MailMessage|http://msdn.microsoft.com/en-us/library/8t22a8ww]] what  - The [[System.Net.Mail.MailMessage|http://msdn.microsoft.com/en-us/library/8t22a8ww]] to send.






---


###SplitToLines(System.Data.DataTable,System.Int32)
Constructs a [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] from the source data by splitting each row into the specified number of rows.

Parameters: 

* [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] table  - The source [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] to use.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] lines  - The number of rows to transform each row of the original data into.





Returns:

The transformed [[System.Data.DataTable|http://msdn.microsoft.com/en-us/library/9186hy08]] with the rows split into the specified number of lines per item.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


