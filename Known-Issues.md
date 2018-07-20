<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. 

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.33|August 7|29154|Enhanced uniformity among reporttype values.|
|6.10.0.33|August 7|29239|Corrected ODBC error related to "Number of parameter markers is not equal" when using a Group by Datetime function as a pivot header.|
|6.10.0.33|August 7|29339|Cleaned up possible functions in subtotal function list to apply properly by data type.|
|6.10.0.33|August 7|29344|Prevented map shading from disappearing when city or location bars are also mapped on that area.|
|6.10.0.33|August 7|29380|Corrected visual based formats such as "Visual Square" and "Heat Map" to display properly when show when ShowHtmlAsCode and ApplyAntiXssToReportOutput are both true.|
|6.10.0.33|August 7|29481|Corrected resource inclusion in exports when Izenda tries to download some resource such as an image to include it in the export but is not successful.|
|6.10.0.33|August 7|29482|Refactored InitDefaultValues to instead use default value initialization on a per-setting basis.|
|6.10.0.33|August 7|29537|Ensured that visualization record count when the visualization is on a dashboard conforms to local record count settings.|
|6.10.0.33|August 7|29544|Reduced number of calls to PullTables and PullSp when one or more values in VisibleDataSources is invalid.|
|6.10.0.33|August 7|29549|Added tickmark next to current value of preview records in Instant Reports 2.0.|
|6.10.0.33|August 7|29550|Corrected handling of automatic subreport links when they are attached to a visual group header.|
|6.10.0.33|August 7|29565|Fixed popup windows so that they properly display in automatic subreports.|
|6.10.0.33|August 7|29573|Corrected filter error preventing filters using calculated fields from being properly passed to dashboards.|
|6.10.0.33|August 7|29574|Corrected filter error which prevented changing operators in report viewer.|
|6.10.0.33|August 7|29585|Made Help header label translatable.|
|6.10.0.33|August 7|29588|Corrected pivot related error when using an aliased table.|
|6.10.0.33|August 7|29605|Corrected data vulnerability in log4net usage which could expose directory info in error logs.|
|6.10.0.33|August 7|29606|Prevented 'Report Not Found' error when there is a special character in the category name of a report.|
|6.10.0.33|August 7|29625|Optimized GetSQL calls on aggregate functions to better handle custom code overrides.|






