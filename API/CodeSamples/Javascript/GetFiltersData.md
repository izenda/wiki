#GetFiltersData

[[_TOC_]]

##About

The ``GetFiltersData`` command is passed through rs.aspx via an [[AjaxRequest|/API/CodeSamples/Javascript/AjaxRequest]]. This returns JSON formatted data related to the filters included in the reportSet. It can be used to identify and display filter information on the web page. 

Here is the AJAX call to use:

```javascript
AjaxRequest('./rs.aspx', 'wscmd=getfiltersdata', GotFiltersData, null, 'getfiltersdata');
```

Here is the hierarchy of the object keys sent back:

* returnObj
  * Filters
    * [0]...[n]
      * Description
      * ControlType
      * Type
      * Value
      * Values
         * [0]...[n]
      * ExistingLabels
         * [0]...[n]
      * ExistingValues 
         * [0]...[n]
      * uid
      * ColumnName
      * Parameter
      * OperatorFriendlyName
      * Removed
      * AgainstHiddenField

GotFiltersData is a callback method that takes two parameters. The first is the returnObj and the second is the id of the called method (getfiltersdata).