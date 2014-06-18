#ReportListDataLite

[[_TOC_]]

##About

The ``ReportListDataLite`` command sends an [[AjaxRequest|/API/CodeSamples/Javascript/AjaxRequest]] that gets data used on the report list page to display reports according to category and other metadata related to each report. 

Here is the AJAX call to use:

```javascript
AjaxRequest('./rs.aspx', 'wscmd=reportlistdatalite&wsarg0=' + category + '&wsarg1=' + keyword + '&wsarg2=1', AcceptReports, null, 'reportlistdatalite');
```

The AcceptReports variable is a callback method that takes two parameters. The first is the returnObj and the second is the id of the method that called it (reportlistdatalite). Below is the hierarchy of the returnObj.

* ReportSets
  * [0]...[n]
    * ImgUrl
    * Name
    * Category
    * CategoryFull
    * Subcategory
    * Subcategory
    * Subcategories
    * Dashboard
    * UrlEncodedName
    * UrlEncodedCategory
    * ReadOnly
    * ViewOnly
    * IsLocked
* Recent
  * [0]...[n]
    * ImgUrl
    * Name
    * Category
    * CategoryFull
    * Subcategory
    * Subcategories
    * Dashboard
    * UrlEncodedName
    * UrlEncodedCategory
    * ReadOnly
    * ViewOnly
    * IsLocked
* Frequent
  * [0]...[n]
    * ImgUrl
    * Name
    * Category
    * CategoryFull
    * Subcategory
    * Subcategories
    * Dashboard
    * UrlEncodedName
    * UrlEncodedCategory
    * ReadOnly
    * ViewOnly
    * IsLocked