#What does Repeat Types and Send Email As mean

[[_TOC_]]

###What are "Repeat Types"?

Repeat Types exist in the "Misc" section of ReportDesigner.aspx and are simply expressions that reflect how often the email should be sent.

![Repeat Types & Send Email As](http://wiki.izenda.us/FAQ/FAQ/RepeatType_And_Link.png)

|Type|Effect|
|-------------|-------------|
|...|No schedule will be used for this report.|
|Every Day|This report will be scheduled and sent to its recipients daily.|
|Every Weekday|This report will be scheduled and sent to its recipients Monday through Friday.|
|Every Week|This report will be scheduled and sent to its recipients once a week starting from the date specified on the report.|
|Every Two Weeks|This report will be scheduled and sent to its recipients once every other week starting from the date specified on the report.|
|Every Month|This report will be scheduled and sent to its recipients once a month starting from the date specified on the report. This is sensitive to the variant number of days in each month and will remain consistent throughout the year.|
|Every Quarter|This report will be scheduled and sent to its recipients quarterly (every three months) starting from the date specified on the report.|
|Alert Hourly|This report will be scheduled and sent to its recipients every hour only if the report has more than zero results in it.|
|Alert Daily|This report will be scheduled and sent to its recipients every day only if the report has more than zero results in it.|



###What is "Send Email As"?

This dropdown determines how the email will be sent out. There are a number of different formats that email can be sent with.

|Type|Effect|
| ------------- |:-------------:|
|Link|Email body will contain a HTTP link to the report (Report Viewer). Report body will not be included in the Email.|
|Embedded|Report will be embedded in the Email body. Please note that client's Email client must support HTML in the body of the Email. This style includes images and other resources from the HTML page.|
|HTML|Report's HTML output only will be embedded in the Email body. Please note that client's Email client must support HTML in the body of the Email. Images and other resources will *not* be included, as they would using the Embedded style.|
|PDF|Report file in "*.pdf" format will be attached to the Email.|
|CSV|Report file in "*.csv" format will be attached to the Email.|
|Excel(XLS)|Report file in "*.xls" format will be attached to the Email.|
|Word(RTF)|Report file in "*.rtf" format will be attached to the Email.|

###Repeat types and export formats customization

Please note that if you want to customize repeat intervals or export formats (eg. add new interval "Every 10 days") you will have to use the Izenda Custom Scheduler.