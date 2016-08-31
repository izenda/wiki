#ResponseServer

[[_TOC_]]

#What is the Response Server?

A deployment of Izenda will contain an rs.aspx page, which can handle requests for Report Parts as well as formatted and filtered exports.

Example: rs.aspx?output=<ExportType>&rn=<ReportName> Or rs.aspx?output=json&rn=Report_1

This URL can be "executed" as-is and you'll get JSON output. Or you can load JSON content using ajax call to this URL.

Live Example: http://izenda.com/bi/rs.aspx?output=json&rn=Subreports\Product+Quantity 

This URL can be "executed" as-is and you'll get JSON output. Or you can load JSON content using ajax call to this URL.

In relation to the Drilldowns concept, you can filter these results through things like drilldown keys:

http://izenda.com/bi/rs.aspx?output=json&rn=Subreports\Product+Quantity&ddkvalue=Beverages <http://izenda.com/bi/rs.aspx?output=json&rn=Subreports\Product+Quantity&ddkvalue=Beverages%20>

Or by passing through a filter/parameter value:

http://izenda.com/bi/rs.aspx?output=json&rn=Accounting&p1value=Alfreds+Futterkiste

You can add further filter values by appending &p2value=something&p3value=something and so on.

Note in the Report Name that categories are respected using ‘ \ ‘, for example: CategoryName\ReportName.

Export types are: json, xml, csv, doc, xls, and pdf.”