<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on April 6, 2018.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.29|April 10|28066|Fixed exception when joining a datasource twice on the same report and adding an expression using an alias referencing one of those tables.|
|6.10.0.29|April 10|28908|Refactored ReportCollection class.|
|6.10.0.29|April 10|28931|Corrected CSS not being applied to forms without first saving the report.|
|6.10.0.29|April 10|28947|Corrected proper escaping of angle brackets in expressions to prevent corruption of the expression in value testing or output.|
|6.10.0.29|April 10|28956|Corrected some conditions in which externally hosted images would fail to be included in PDF export.|
|6.10.0.29|April 10|29025|Refactored authentication code.|
|6.10.0.29|April 10|29064|Refactored data source name links associated with virtual data source setting to prevent incorrect and faulty behavior when clicked.|
|6.10.0.29|April 10|29089|Prevented 'Invalid Cast' error related to filters on fields using the UInt16, UInt32 or UInt64 datatype and using the ODBCDriver. This fix breaks backwards compatibility for virtual data sources, which must be manually opened and resaved to correct their functioning.|
|6.10.0.29|April 10|29095|Corrected faulty behavior around drilling down on a 'date' type field in Oracle.|
|6.10.0.29|April 10|29103|Ensured reduction of unnecessary activity when cascading filters are disabled.|
|6.10.0.29|April 10|29107|Prevented MySQL error when using stock MySQLDriver which throws "Incorrect Database Name". This fix was retroactively applied to 6.10.0.27 and 6.10.0.28.|
|6.10.0.29|April 10|29110|Enhanced handling of invalid times when a time does not exist due to timezone shifts.|
|6.10.0.29|April 10|29118|Provided a more user friendly error message when embedded subreports are used on a grid which feeds data to a visualization which is not compatible with embedded subreports.|
|6.10.0.29|April 10|29120|Re-enabled use of passing some values, including blanks and nulls, as stored procedure parameters via specific filter operators.|
|6.10.0.29|April 10|29123|Prevented 'zero chart results' from appearing in error when using a calculated field to build a chart.|
|6.10.0.29|April 10|29124|Corrected problem which would cause additional records to appear (more than requested in preview) when paginating report parts.|
|6.10.0.29|April 10|29126|Corrected issues which sometimes cause SchemaCacheTimeout to never function properly.|
|6.10.0.29|April 10|29129|Increased speed of rendering gauge formats.|
|6.10.0.29|April 10|29133|Corrected issue where sometimes filters were not saved in Instant Reports when cascading filters are disabled.|
|6.10.0.29|April 10|29138|Made further improvements to case 27885 to prevent word wrapping issues, as well as permit word wrapping in exports.|
|6.10.0.29|April 10|29142|Corrected datatype cast error which could arise when using some column formats with pagination.|
|6.10.0.29|April 10|29151|Corrected problem in pivots which could cause string '-Q' to appear in cell values when using Oracle.|
|6.10.0.29|April 10|29171|Corrected an issue which could cause datetime formats to be lost on Excel export. This issue was retroactively applied to versions 6.10.0.27 and 6.10.0.28.|






