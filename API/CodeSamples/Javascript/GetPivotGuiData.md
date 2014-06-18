#GetPivotGuiData

[[_TOC_]]

##About

The ``GetPivotGuiData`` command is passed through rs.aspx via an [[AjaxRequest|/API/CodeSamples/Javscript/AjaxRequest]]. This returns JSON formatted data related to displaying pivoting information on the ReportViewer. 

Here is the AJAX call to use:

```javascript
AjaxRequest('./rs.aspx', 'wscmd=reportviewerconfig&wsarg0=' + jq$(window).width() + '&wsarg1=' + jq$(window).height(), GotReportViewerConfig, null, 'reportviewerconfig');
```

Here is the hierarchy of object keys sent back:

* Currentield
* CurrentFunction
* FieldNames
  * [0]...[n]
* FieldIds
  * [0]...[n]
* FunctionNames
  * [0]...[n]
* FunctionIds
  * [0]...[n]

GotPivotGuiData is a callback method that takes two parameters. The first is the returnObj and the second is the id of the called method (getpivotguidata).