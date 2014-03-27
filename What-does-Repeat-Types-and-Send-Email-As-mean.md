#What does Repeat Types and Send Email As mean

[[_TOC_]]

###What are "Repeat Types"?

Repeat Types exist in the miscellaneous section of ReportDesigner.aspx and are simply expressions that reflect how often the email should be sent.

![Repeat Types & Send Email As](http://wiki.izenda.us/FAQ/FAQ/RepeatType_And_Link.png)

|Type|Effect|
|-------------|-------------|
|Every Day|Email will be sent daily. Time part (hours amd minutes) will be the same as the original time.|
|Every Weekday|Email will be sent daily excluding weekends.|
|Every Week|Email will be sent every 7 days.|
|Every Two Weeks|Email will be sent every 14 days.|
|Every Month|Email will be sent monthly. Note that number of days in the month is taken into account, so it is not just "send every 30 days" or "send every 31 days" as it is for weeks schedule.|
|Every Quarter|Email will be sent every 3 months.|
|Alert Hourly|Email will be sent every hour. Minutes will remain the same.|
|Alert Daily|Email will be sent daily. If report returned zero results under some conditions the Email will not be sent.|



###What is "Send Email As"?

This dropdown determines how the email will be sent out. There are a number of different formats that email can be sent with.

|Type|Effect|
| ------------- |:-------------:|
|Link|Email body will contain a HTTP link to the report (Report Viewer). Report body will not be included in the Email.|
|Embedded|Report will be embedded in the Email body. Please note that client's Email client must support HTML in the body of the Email.|
|PDF|Report file in "*.pdf" format will be attached to the Email.|
|CSV|Report file in "*.csv" format will be attached to the Email.|
|Excel(XLS)|Report file in "*.xls" format will be attached to the Email.|
|Word(RTF)|Report file in "*.rtf" format will be attached to the Email.|

###Repeat types and export formats customization

Please note that if you want to customize repeat intervals or export formats (eg. add new interval "Every 10 days") you will have to use the Izenda Custom Scheduler.