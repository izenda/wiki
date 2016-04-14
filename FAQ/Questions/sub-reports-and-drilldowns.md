#Subreports and Drilldowns

[[_TOC_]]

##Question

How do subreports and drilldowns work? What are the options for subreports?

##Answer

Subreports are simply regular reports with one extra step. Their defining trait is the presence of a drilldown key. This is a key field that will be used by any other report, acting as a parent report, to send information to the subreport. This is done on the [[Misc tab|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab#9.2-Drill-Downs]] of the report designer. There is also a short example of how to create a basic sub-report and link it to the main report at that link. The [[Advanced Field Settings|http://wiki.izenda.us/Guides/ReportDesign/4.0-fields-tab#4.8-Advanced-Field-Settings-Button]] box is where you link a main report to a subreport.

_*NOTE:* A subreport is not a special type of report! Any report can be a subreport if it has a drilldown key defined. Subreports can have their own subreports in turn. A report with a drilldown key defined might not have any reports that drilldown into it. The only distinction is that if a report has a drilldown key, it can be accessed as a subreport by any other report._

_*NOTE:* This article will refer to this relationship between reports as both report-subreport as well as parent-child. The language is not technical and does not matter. You could also think of the pair relationship as from-to or high-low._ 

###Blank and Null values

Currently, Izenda subreporting does not support blank or null values. 

###Subreports on charts

In addition to creating drilldowns for your main report items, you can create subreports for [[pie charts|http://wiki.izenda.us/Guides/ReportDesign/7.0-Chart-tab#7.3-Pie-Selection]] and [[bar charts|http://wiki.izenda.us/Guides/ReportDesign/7.0-Chart-tab#7.5-Bar-Selection]] as well. Currently, these only support a single key value, specified via the Label field. These will work with reports that have one drilldown key defined, but not ones with two keys defined.

_**Note:** Bar charts and pie charts do not support drilldown effects. They will always have the "Link" effect._

###Subreports on maps

You can also create a drilldown on the [[Maps tab|http://wiki.izenda.us/Guides/ReportDesign/13.0-Izenda-Maps#13.2-Maps-features]] that will trigger using the specified effect. You can learn more about the maps feature at the link above.

###Subreports on gauges

Gauges can also accept subreports and will use the Name field in order to select the appropriate drilldown key. See the [[Gauge tab|http://wiki.izenda.us/Guides/ReportDesign/8.0-Gauge-tab#8.4-Gauges-with-Drill-Down-Effects]] for more. You can have a drilldown effect defined here as well. Again, creating a subreport on a gauge is just like anywhere else. They currently only accept one drilldown key as well.

###Subreports on forms

Finally, you can also choose to use subreports in a Forms report. You can see the [[Izenda Forms|http://wiki.izenda.us/Guides/ReportDesign/14.0-Izenda-FORMS#14.3-Advanced-FORMS-Concepts]] section for more information about this feature. Drilldowns are defined in two ways, described in the article above. Subreports that you specify in the form with a declaration such as "[subreports/top products by state]" do not get a drilldown key and will be treated as a stand-alone report. You can reference the column alias in order to use drilldown key driven subreports.

###Using a URL instead of a subreport

In addition to drilling down to a subreport, you can also explicitly define a URL to open. This can be an external URL or an internal URL to the reporting application. You can use field brackets in the URL as well to pass data through query string parameters. (e.g. ReportViewer.aspx?rn=Subreport&master=MainReport&ddkvalue=[OrderID]&ddkvalue2=[ShipCountry]). 

###Settings applicable to drilldowns
* [[InheritFiltersInSubreports|/API/CodeSamples/InheritFiltersInSubreports]]
* [[DrilldownStyle|/API/CodeSamples/DrilldownStyle]]

###Multi-Value Drilldowns

There are two features, both accessible from the Advanced Field Options, which link parent-child reports with multiple values:

-The Standard Drilldown feature, which supports up to 2 values OR one proxy value and one actual value.

-The URL feature, which supports up to 4 values.

Values are passed from the current record-row, defined as all values on the current row (or current record) that the passing action is called from. If I want to pass values from a row, I must click a value elsewhere on that same row.

####Standard Drilldown
In order to build a parent-child subreporting pair, follow these steps:

* On the child report, set one or more drilldown keys.

* On the parent report, decide which field you want to pass values to the drilldown key of the child report. These fields do not have to have the same name – the only thing Izenda cares about is if it can find a matching value. For example, I have two fields – Country of Origin, and Favorite Food. If I pass the value Turkey from one field to the other, my drilldown will create valid results.

* In the Advanced Field Options for your first chosen field, select the target subreport name from the Subreport dropdown. This will instruct the field _which_ subreport to call. These are the values which will pass to your _first_ drilldown key value in the subreport.

_*NOTE:* If your subreport is not listed in this dropdown, it either has not been saved with a drilldown key value OR the parent report has not been refreshed since the subreport was listed as valid. Check your subreport and re-save it, and reload the parent report from the report list._

* In the Advanced Field Options for your first chosen field, select the ideal behavior for your subreport from the Drill-Down Style dropdown. This will instruct the field _how_ to call the subreport, whether it is a popup, a new link, etc.

* In the Advanced Field Options for your second chosen field, select the same target subreport name as the first field from the Subreport dropdown.

* In the Advanced Field Options for your second chosen field, select the ComboKey behavior. You _must_ select ComboKey for the second report. This behavior instructs this field to search back, find the nearest field above this field in the report list that is targeting the same subreport, and pass its value along with that field.

* *OPTIONAL:* Ignore First Key allows you to ignore the value passed by the first key to the subreport. The value will be passed, but then discarded before the subreport is filtered by values from the parent report. This is used when you want the on-click action to occur on one field, but then pass a second field as the singular drilldown value.

Here are some potential combinations:

Column A, to Subreport, as Popup - passes value A1

or

Column A, to Subreport, as Popup - passes value A1 and B1
Column B, to Subreport, as ComboKey - finds most recent column pointed at Subreport and tells it to pass B1 as well

or

Column A, to Subreport, as Link(New) - passes A1 and C1 
Column B, to OtherSubreport, as Link(New) - passes B1
Column C, to Subreport, as ComboKey - finds most recent column...

or 

Column A, to Subreport, as Link(New) - passes A1
Column B, to Subreport, as Embedded - passes B1

or, with Ignore First Key applied

Column A, to Subreport, as Link(New) - passes B1 and applies it, passes A1 and discards it, so only B1 is effective
Column B, to Subreport, as ComboKey - finds most recent column...

####URL Drilldowns

* The URL always passes values from a record from a single field. There are two different values you can use, ddkvalueX, where X is not defined (for first value) and 2 for second value, and pXvalue, where X is an integer from 1 to 4. The components of a URL string are:

* ReportViewer.aspx - this instructs the URL to load the ReportViewer.aspx page. You can also point this at ReportDesigner.aspx, or any other Izenda page including custom pages, or any other permissble url. 

* rn - this instructs the URL to load the given report name. If the report is named My Report, you would use the value rn=My+Report. Categories are appended to the front of this value, as in rn=My+Category\My+Report

* ddkvalue - this instructs the passed value to be used in a field defined as a drilldown key on the subreport. To pass the first value we set ddkvalue, to pass the second we set ddkvalue2.

* pXvalue - this instructs the passed value to be used in a filter. The filter must be set up ahead of time, it cannot be set dynamically by detecting the field or datatype of the passed value.

* {x} - This allows you to specify the column which passes a value on this record-row. A value of 0 means 'this column', values 1 to X indicate specifically columns 1 or X. If I am passing a value from the first column, I could use either {0} or {1} to relatively indicate 'this column' or absolutely indicate 'the first column'.

* ? and & - The first segment of the URL string should be seperated with a ?. Subsequent seperations use &.

#####Examples

http://www.google.com/?q={0} - Takes the value in this column and sends it to Google. It is necessary to add http:// to the beginning of this string to force it to call an external website.

ReportDesigner.aspx?rn=My+Category/My+Report&ddkvalue={2}&ddkvalue2={6} - Loads the Report Designer, loads the report named My Report in the category called My Category, takes the value in column 2 and passes it to the first drilldown field, and takes the value in column 6 to pass to the second drilldown field.

ReportDesigner.aspx?rn=My+Category/My+Report&p1value={0}&p2value={2}&p3value={3} - Loads the Report Designer, loads the report named My Report in the category called My Category, takes the value in the clicked column and passes it into the first filter on the subreport, passes the value from the second column to the second filter, and passes the value in the third column to the third filter.
