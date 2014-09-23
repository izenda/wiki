#Sub-reports and Drilldowns

[[_TOC_]]

##Question

How do sub-reports and drilldowns work? What are the options for sub-reports?

##Answer

Sub-reports are simply regular reports with one extra step. Their defining trait is the presence of a drilldown key. This is a key field that will be used by main reports to send information to the sub-report. This is done on the [[Misc tab|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab#9.2-Drill-Downs]] of the report designer. There is also a short example of how to create a basic sub-report and link it to the main report at that link. The [[Advanced Field Settings|http://wiki.izenda.us/Guides/ReportDesign/4.0-fields-tab#4.8-Advanced-Field-Settings-Button]] box is where you link a main report to a sub-report. 

###Sub-reports on charts

In addition to creating drilldowns for your main report items, you can create sub-reports for [[pie charts|http://wiki.izenda.us/Guides/ReportDesign/7.0-Chart-tab#7.3-Pie-Selection]] and [[bar charts|http://wiki.izenda.us/Guides/ReportDesign/7.0-Chart-tab#7.5-Bar-Selection]] as well. Currently, these only support a single key value, specified via the Label field. These will work with reports that have one drilldown key defined, but not ones with two keys defined.

_**Note:** Bar charts and pie charts do not support drilldown effects. They will always have the "Link" effect._

###Sub-reports on maps

You can also create a drilldown on the [[Maps tab|http://wiki.izenda.us/Guides/ReportDesign/13.0-Izenda-Maps#13.2-Maps-features]] that will trigger using the specified effect. You can learn more about the maps feature at the link above.

###Sub-reports on gauges

Gauges can also accept sub-reports and will use the Name field in order to select the appropriate drilldown key. See the [[Gauge tab|http://wiki.izenda.us/Guides/ReportDesign/8.0-Gauge-tab#8.4-Gauges-with-Drill-Down-Effects]] for more. You can have a drilldown effect defined here as well. Again, creating a sub-report on a gauge is just like anywhere else. They only accept one drilldown key currently as well.

###Sub-reports on forms

Finally, you can choose to use sub-reports in your FORMS report too. You can see the [[Izenda Forms|http://wiki.izenda.us/Guides/ReportDesign/14.0-Izenda-FORMS#14.3-Advanced-FORMS-Concepts]] section for more information about this feature. Drilldowns are defined in two ways, described in the article above. Sub-reports that you specify in the form with a declaration such as "[subreports/top products by state]" do not get a drilldown key and will be treated as a stand-alone report. You can reference the column alias in order to use drilldown key driven sub-reports.

###Using a URL instead of a sub-report

In addition to drilling down to a sub-report, you can also explicitly define a URL to open. This can be an external URL or an internal URL to the reporting application. You can use field brackets in the URL as well to pass data through query string parameters. (e.g. ReportViewer.aspx?rn=Subreport&master=MainReport&ddkvalue=[OrderID]&ddkvalue2=[ShipCountry]). 

###Settings applicable to drilldowns
* [[InheritFiltersInSubreports|/API/CodeSamples/InheritFiltersInSubreports]]
* [[DrilldownStyle|/API/CodeSamples/DrilldownStyle]]

###Multi-Value Drilldowns

There are two features, both accessible from the Advanced Field Options, which link parent-child reports with multiple values:

-The Standard Drilldown feature, which supports up to 2 values OR one proxy value and one actual value.
-The URL feature, which supports up to 4 values.

####Standard Drilldown
In order to build a parent-child subreporting pair, follow these steps:

* On the child report, set one or more drilldown keys.

* On the parent report, decide which field you want to pass values to the drilldown key of the child report. These fields do not have to have the same name – the only thing Izenda cares about is if it can find a matching value. For example, I have two fields – Country of Origin, and Favorite Food. If I pass the value Turkey from one field to the other, my drilldown will create valid results.

* In the Advanced Field Options for your first chosen field, select the target subreport name from the Subreport dropdown. This will instruct the field _which_ subreport to call. These are the values which will pass to your _first_ drilldown key value in the subreport.

_*NOTE:* If your subreport is not listed in this dropdown, it either has not been saved with a drilldown key value OR the parent report has not been refreshed since the subreport was listed as valid. Check your subreport and re-save it, and reload the parent report from the report list._

* In the Advanced Field Options for your first chosen field, select the ideal behavior for your subreport from the Drill-Down Style dropdown. This will instruct the field _how_ to call the subreport, whether it is a popup, a new link, etc.

* In the Advanced Field Options for your second chosen field, select the same target subreport name as the first field from the Subreport dropdown.

* In the Advanced Field Options for your second chosen field, select the ComboKey behavior. You _must_ select ComboKey for the second report. This behavior instructs this field to search back, find the nearest field above this field in the report list that is targeting the same subreport, and pass its value along with that field.

* *OPTIONAL:* Ingore First Key allows you to ignore the value passed by the first key to the subreport. The value will be passed, but then discarded before the subreport is filtered by values from the parent report. This is used when you want the on-click action to occur on one field, but then pass a second field as the singular drilldown value.