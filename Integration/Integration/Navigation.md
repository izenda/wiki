#**Navigation**

[[_TOC_]]

###Introduction

Navigation can be customized globally, for all users, by using the settings.aspx page. It can also be customized on a per-user basis. The two pages which are generally affected most by navigation are the report viewer and the report list.

###Report List Navigation

The Reports List page can be completely re-written if you choose. You use the AdHocSettings.AdHocConfig class to return a list of filtered reports, which could then be put into a table or any other html format. The query string format for the links to point to the other pages is as follows, where ReportName is the actual report name from the filtered reports list:

* Report Viewer links: ReportViewer.aspx?rn=ReportName
* Report Designer links: ReportDesigner.aspx?rn=ReportName&tab=Fields 

By creating a page with these links, you can completely control the Report List navigation. You can also display buttons or other links which further control navigation or integration with your product. 

###Report Viewer Navigation Using Query String Parameters

The report viewer provides the ability to give links to the users which are generated as reports. This means that you can provide a link to a user and when that link is clicked upon, a report will automatically generate in the needed format and a Download load file dialog will appear. The user does not need to be taken to the page in a browser. The following output types are supported:

* Portable Document Format (pdf): "&output=pdf"
  * Sample link [[http://www.izenda.com/bi/ReportViewer.aspx?rn=Product+List&output=pdf]]
* Microsoft Excel Format: "&output=xls"
  * Sample link [[http://www.izenda.com/bi/ReportViewer.aspx?rn=Product+List&output=xls]]
* Microsoft Word Format: "&output=csv"
  * Sample link [[http://www.izenda.com/bi/ReportViewer.aspx?rn=Product+List&output=csv]]
* XML Format: "&output=xml"
  * Sample link [[http://www.izenda.com/bi/ReportViewer.aspx?rn=Product+List&output=xml]]
* RTF Format: "&output=rtf"
  * Sample link [[http://www.izenda.com/bi/ReportViewer.aspx?rn=Product+List&output=rtf]]

###Simple Mode

Simple Mode disables the ability in the Report Viewer to load another report, export the report, or add fields and filters to the report. If there are existing filters it allows the ability to change the current filter.

* Simple Mode Format: "&simple=1"
  * Sample link [[http://www.izenda.com/bi/ReportViewer.aspx?rn=Department+Reports/Dashboard&simple=1]]

###Izenda Reports supports unlimited query string parameters

It is also possible that you may want to pass a query string to Izenda which has a filter field parameter already set for the user. To accomplish this you can use the pNvalue paramater, as in this example where we use p1 through p5. Each of the parameters corresponds to the actual order of filters on the report viewer page. So in this example we see the filter field labels in red next to the filters. Call the filters using the following naming convention:

![](http://wiki.izenda.us/Integration/Navigation/filter_example.png)

**Note: The values in "Red" (p1value, etc.) above are for reference to the information below only. The Value(s) spaces need to remain "Blank" in the Report Designer. 

* **p1value,p1value2**: "Between" filter operator, ReportViewer.aspx?rn=SomeReport&p1value=1/1/2005&p1value2=1/1/2008
* **p2value**: "Equals" filter operator,ReportViewer.aspx?rn=SomeReport&p2value=USA
* **p3value**: "Equals" filter operatorReportViewer.aspx?rn=SomeReport&p3value=SomeCompany
* **p4value**: "Greater Than" filter operatorReportViewer.aspx?rn=SomeReport&p4value=15
* **p5value**: not used in this example (maximum amount of parameters reached)

*Note: p1value2 is only valid due to using the "Between" operator and would not be valid when working with other operators.*

*Note2: When the filter operator is "Multiple" then you can specify the respective pxvalue={filtervalue1},{filtervalue2},{filtervaluex} and so on.*
You can combine filters together and add an output type. Examine this example:

* ReportViewer.aspx?rn=Product+List&p1value=1/1/2005&p1value2=1/1/2008&p2value=USA&output=pdf

###Get just the report

All of the above commands can also be accomplished by replacing ReportViewer.aspx with rs.aspx and appending the appropriate query string. This will generate the same report seen in ReportViewer.aspx but without any of the menu items.