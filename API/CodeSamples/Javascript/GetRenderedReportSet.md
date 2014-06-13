#GetRenderedReportSet

[[_TOC_]]

##About

The ``GetRenderedReportSet`` command is passed through rs.aspx via an [[AjaxRequest|]]. This returns CSS and HTML that is directly plugged into a container to display the report. This makes it very simple to use the report viewer data in your own website.  

Here is the Ajax call to use:

```javascript
AjaxRequest('./rs.aspx?', 'wscmd=getrenderedreportset&wsarg0=reportName', GotRenderedReportSet, null, 'getrenderedreportset');
```

The GotRenderedReportSet is a javascript callback that takes two arguments: the returnObj and the id. The returnObj is the raw HTML/CSS data that should get inserted into the container on the report viewer page. The id is the name of the wscmd. In this case, it would be "getrenderedreportset".