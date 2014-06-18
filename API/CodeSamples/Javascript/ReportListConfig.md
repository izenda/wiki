#ReportListConfig

[[_TOC_]]

##About

The ``ReportListConfig`` command sends an [[AjaxRequest|/API/CodeSamples/Javascript/AjaxRequest]] to the server to get the configuration of the report list page. This will return a JSON formatted string to the browser with data related to the report viewer.

Here is the AJAX call to use:

```javascript
AjaxRequest('./rs.aspx', 'wscmd=reportlistconfig&wsarg0=' + instant, AcceptConfig, null, 'reportlistconfig');
```

The AcceptConfig variable is a callback method that takes two arguments: the returnObj and the id. The returnObj is a JSON formatted object that contains the data sources used on the report. Below is an example of the hierarchy of this object.

* ReportDesignerTarget
* ReportDesignerLink
* DashboardDesignerLink
* ResponseServerUrl
* InstantReportUrl
* SettingsLink
* TimeOut
* UseDefaultDialogs
* ReportLinkTemplate
  * [0]...[n]
* ReportViewTemplate
  * [0]...[n]
* ReportDesignTemplate
  * [0]...[n]
* DashboardLinkTemplate
* DashboardViewTemplate
  * [0]...[n]
* DashboardDesignTemplate
  * [0]...[n]
* ThumbnailsAllowed
* ThumbnailWidth
* ThumbnailHeight
* Operational
* ExpandCategorizedReports
* CategoryCharacter
* AllowDeletingReports