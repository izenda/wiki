<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. 

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.35|October 2|29721|Fixed some situations where user defined constraints could be ignored in Advanced data source mode.|
|6.10.0.35|October 2|29799|Refactored dropdown generation on page to render faster.|
|6.10.0.35|October 2|29816|Refactored formatting of values used as drilldown keys.|
|6.10.0.35|October 2|29830|Corrected datatype error in filters which would cause reports to filter incorrectly as numerical values would be rounded such that equivalency matches always return false.|
|6.10.0.35|October 2|29838|Fixed crash bug if a report runs against an OData connection using Fusion with no Default connection.|
|6.10.0.35|October 2|29233|Prevented column access errors for Automatic subreports when using MySql.|
|6.10.0.35|October 2|29302|Optimized Equals(Autocomplete) for numerics in MSSQL to generate less queries.|
|6.10.0.35|October 2|29852|Optimized Value Range feature to perform faster and also correct an error where value aliasing fails to work properly on XML export.|
|6.10.0.35|October 2|29785|Further fixed translations in UI labeling in Report Viewer.|
|6.10.0.35|October 2|29617|Refactored column handling to correct logic of empty column values.|
|6.10.0.35|October 2|29747|Added extra checks to prevent rare NRE error in Search.|







