#CRSDataSources

[[_TOC_]]

##About

The ``CrsDataSources`` command sends an [[AjaxRequest|/API/CodeSamples/Javascript/AjaxRequest]] that is used to obtain the CurrentReportSet information. This returns the data structure of the current report set and can be used to make logical choices about how to handle various features on the report viewer.

Here is the AJAX call to use:

```javascript
AjaxRequest('./rs.aspx', 'wscmd=crsdatasources', GotDatasourcesList, null, 'crsdatasources');
```
##GotDataSourcesList

The GotDataSourcesList variable is a callback method that takes two arguments: the returnObj and the id. The returnObj is a JSON formatted object that contains the data sources used on the report. Below is an example of the hierarchy of this object.

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

So if you want to use the returnObj, you could use the javascript standard ``returnObj["SelectionsList"]["Fields"][0].DbName`` statement. The id object is the name of the function (crsdadtasources).