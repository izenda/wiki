#CRSDataSources

[[_TOC_]]

##About



```javascript
AjaxRequest('./rs.aspx', 'wscmd=crsdatasources', GotDatasourcesList, null, 'crsdatasources');
```

The GotDataSourcesList variable is a callback method that takes two arguments: the returnObj and the id. The returnObj is a JSON formatted object that contains the data sources used on the report. Below is an example of the hierarchy of this object.

* returnObj
  * SelectionsList
    * [0]
      * DataType
      * DbName
      * Fields
      * FriendlyName
      * IsStoredProc
    * [1]
      * ...
    * [2]
      * ...

So if you want to use the returnObj, you could use the javascript standard ``returnObj["SelectionsList"][0].DbName`` statement.

The id object is the name of the function (crsdadtasources).