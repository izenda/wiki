#HtmlToPictureRenderer

[[_TOC_]]

##Properties

None.


##Methods

###Abort(System.String)
 Invokes the error handler delegate with the specified error message. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] message  - The error message to send to the delegate.






---


###CreateScreenshot()
 Runs the delegate that was specified for image processing of the loaded HTML report. 






---


###CreateScreenshot(System.String)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] svgHtml 






---


###CreateScreenshotAdjustedHeight(System.Int32)
 Executes the delegate for taking a screenshot of the dummy web browser using the specified height. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] adjustedHeight  - The height of the dummy web browser to use instead of the previously specified value.






---


###CreateScreenshotAdjustedHeightSvgHtml(System.String,System.Int32)
 Executes the delegate for taking a screenshot of the dummy web browser with special considerations for SVG-based charts. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] svgHtml  - The SVG-based chart markup that will be used
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] adjustedHeight  - The height of the dummy web browser to use instead of the previously specified value.






---


###Dispose()
 Releases the thread that the image processing occurred on and any in-memory resources used by the rendering process. 






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


###Notify(System.String)
 Writes a notification string to the log. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] str  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] message to write to the log.






---


###Render(Izenda.AdHoc.Report,System.String,System.Web.UI.WebControls.Unit,System.Web.UI.WebControls.Unit)
Renders the HTML from the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the HTML for the report into a new thread.

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that the chart belongs to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] html  - The source HTML for the report that will be converted to an image.
* [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]] w  - The width of the web browser that will be created in the background for rendering.
* [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]] h  - The height of the web browser that will be created in the background for rendering.






---


###RenderHighChart(Izenda.AdHoc.Report,System.Web.UI.Control,System.Web.UI.WebControls.Unit,System.Web.UI.WebControls.Unit)


Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report 
* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] chartContainerControl 
* [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]] w 
* [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]] h 






---


###RenderHighChart(Izenda.AdHoc.Report,Izenda.Web.UI.HighCharts.HighChartBase,System.Web.UI.WebControls.Unit,System.Web.UI.WebControls.Unit)
 Creates a context for producing an image of the specified HighCharts-based report with the specified parameters. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that the chart belongs to.
* [[Izenda.Web.UI.HighCharts.HighChartBase|/API/Izenda/Web/UI/HighCharts/Izenda-Web-UI-HighCharts-HighChartBase]] chartControl  - The [[Izenda.Web.UI.HighCharts.HighChartBase|/API/Izenda/Web/UI/HighCharts/Izenda-Web-UI-HighCharts-HighChartBase]] source control that will be used to generate the chart HTML to be converted to an image.
* [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]] w  - The width of the web browser that will be created in the background for rendering.
* [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]] h  - The height of the web browser that will be created in the background for rendering.






---


###RenderVisualization(Izenda.AdHoc.Report,System.Web.UI.Control,System.Web.UI.WebControls.Unit,System.Web.UI.WebControls.Unit)
 Creates a context for producing an image of the specified visualization report with the specified parameters. 

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] report  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that the chart belongs to.
* [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] control  - The [[System.Web.UI.Control|http://msdn.microsoft.com/en-us/library/983zwx2h]] source control that will be used to generate the visualization HTML to be converted to an image.
* [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]] w  - The width of the web browser that will be created in the background for rendering.
* [[System.Web.UI.WebControls.Unit|http://msdn.microsoft.com/en-us/library/ctewx7ch]] h  - The height of the web browser that will be created in the background for rendering.






---


###SetHeight(System.Int32)
 Sets the height of the web browser that will be used for background rendering. 

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] height  - The height in pixels that the browser should be.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


