#GetPivotGuiData

[[_TOC_]]

##About

The ``GetPivotGuiData`` command is passed through rs.aspx via an [[AjaxRequest|/API/CodeSamples/Javscript/AjaxRequest]]. This returns JSON formatted data related to displaying pivoting information on the ReportViewer. 

Here is the AJAX call to use:

```
AjaxRequest('./rs.aspx', 'wscmd=reportviewerconfig&wsarg0=' + jq$(window).width() + '&wsarg1=' + jq$(window).height(), GotReportViewerConfig, null, 'reportviewerconfig');
```

Here is the hierarchy of object keys sent back:

* SelectionsList
  * [0]...[n]
    * Fields
      * [0]...[n]
        * Selected
        * Description
        * Total
        * VG
        * Format
        * FilterOperator
        * FormatNames
          * [0]...[n]
        * FormatValues
          * [0]...[n]
        * FilterOperatorNames
          * [0]...[n]
        * FilterOperatorValues
          * [0]...[n]
        * FunctionNames
          * [0]...[n]
        * FunctionValues
          * [0]...[n]
        * LabelJ
        * ValueJ
        * Hidden
        * FriendlyName
        * DbName (field)
        * DataType
    * IsStoredProc
    * FriendlyName
    * DbName (datasource)
    * DataType
  * CanSaveReport

GotPivotGuiData is a callback method that takes two parameters. The first is the returnObj and the second is the id of the called method (getpivotguidata).