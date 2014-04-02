#Introduction

[[_TOC_]]

Welcome to Izenda Reports and Dashboards. Izenda offers a rich API of reporting options and features. The following section aims to provide an overview of core Izenda features and a detailed explanation of these features. We at Izenda believe in creating a rich environment for self-service reporting and aim to keep this FAQ up-to-date with the latest information available. Izenda is growing all the time, so please check our [Release Notes](http://wiki.izenda.us/Release-Notes) frequently for new updates and improvements to existing features. You can also visit other sections of our FAQ for more specific answers to other questions you may have.

##Report Designer

This section of the training walks through the features available in the various tabs of the Izenda Report Designer in order to familiarize the users with the options available: 

###Datasources tab

Here you can select the data sources (tables and views) to use in your report.  There are two ways to view this.

* **Basic:** The basic view of the data sources tab will let you choose from a list of recent data sources or choose one data source from a list.
* **Advanced:** This view will let you choose any number of data sources and define their relationships. This acts as an SQL join would.

###Fields tab

Here you can select how many records to display, as well as define which data you wish to be included in your report. Here is a list of controls and their descriptions.

* **Records:** Defines the maximum amount of results to display.
* **Field:** Allows selection of the table columns from the data set(s) chosen in the datasources tab.
* **Description:** A name for the data column. This is filled in with the column name by default.
* **Sort:** Allows sorting of the data in ascending order when the report is generated
* **VG:** With this selected, a grid will be created for each unique value in the chosen field when the report is generated
* **A:** Allows arithmetic operations to be performed (+,-,*,/). This is context sensitive to the function being performed
* **Function:** Specifies an aggregate or grouping function to be performed, such as COUNT, SUM, and AVG
* **Format:** Specifies the format to be used when displaying the data. Applies to dates and numeric data. This is also context sensitive.
* **Delete:** Removes the field from the report.
* **Insert field above:** Creates a new field above the current one.
* **Insert field below:** Creates a new field below the current one.
* **Advanced Field Settings:** Learn more about [advanced field settings](http://wiki.izenda.us/FAQ/advanced-field-settings).
* **Add Subtotals:** Creates a total line between each report and highlights the value in bold

###Summary tab

Here you can define a new set of data separate from the field list you selected that can act as a synopsis of your data. It is displayed above the table you defined on the Fields tab on the report viewer. Identical to the fields tab with a few exceptions.

* No visual grouping (VG checkbox)
* No arithmetic checkbox
* **Show Deltas:** shows the changes in your data as a percentage (handy for quarterly report summaries)

###Chart tab

You can define a chart to use here from a list of Izenda-supported charts. Selecting a chart will update the settings form directly below, which can be filled out with labels and other options.

* **Trend:** Creates a standard line plot graph in your report with any of the following options:
    * **Label Title:** The label for the X-axis data.
    * **Value Title:** The label for the Y-axis data.
    * **Show Legend:** 
    * **Smooth:** Leaving this unchecked shows straight lines between data points. Checking it displays the chart with smooth interpolated lines.
    * [See An Example](http://www.izenda.com/bi/ReportViewer.aspx?rn=Accounting)
* **Pie:** Creates a circular pie graph in your report with any of the following options:
    * **Label:** The data column to use as the titles for each pie slice. Only shown by hovering the mouse over the pie slice by default.
    * **Show as 3D:** Toggles whether the chart is displayed in 3D.
    * **Explode Largest Slice:** Causes the largest slice of the pie graph to separate from the pie when the graph is displayed.
    * **Show Percentage:** Shows the percentage of the graph that each sector represents rounded to two decimal places.
    * **Chart Type:** Allows users to specify whether the graph is represented as a pie chart or a doughnut chart.
    * **Show Value Labels:** 
    * **Show Slice Labels:** Displays the Label for each pie slice on the outside of the chart.
    * **Combine Bottom %:** Displays a pie slice called "Other" as the aggregation of the remaining data.
    * [See an example](http://izenda.com/bi/ReportViewer.aspx?rn=Product+List)
* **Bar:** Creates a bar graph in your report with any of the following options:
    * **Separator:** This field causes the chart to create multiple bars per data category based on the column selected.
    * **Line Value:** Determines the value to use for a trend graph that is overlaid on top of the bar chart.
    * **Show Pareto:** Overlays a trend graph on top of the bar chart. Line Value is required for the value of the trend.
    * **Stacked:** Changes the bar graph from individual bars to a single bar stacked using the Separator field value. Disabled if not using the Separator field.
    * **Horizontal:** Causes the graph to be re-oriented 90 degrees.
    * **Shade Area Under Line:** Produces a shading effect underneath the trend chart line. The shading is color-coded with the line color.
    * **Label Title(Bottom):** Applies a label to the bottom of the chart (x-axis).
    * **Label Title(Left):** Applies a label to the left of the chart (y-axis, describes the data displayed with the bar chart).
    * **Label Title(Right):** Applies a label to the right of the chart (y-axis, describes the data displayed with the trend chart).
    * [See an example](http://izenda.com/bi/ReportViewer.aspx?rn=Human+Resources)
* **Funnel:** Displays a funnel graph in your report with any of the following options:
    * **Show Percent:** Displays the percentage of the funnel that the section represents.
    * **Mode:** Determines if the y-axis value is used for width or for height.
    * [See an example](http://www.izenda.com/bi/ReportViewer.aspx?rn=Charts\Simple+Funnel)
* **Visualization:** Adds an advanced type of chart into your report. While these do not have any options, there are a variety of templates you can use:
    * **Arc Map:** Displays a map with bubbles sized based on your data. When the bubbles are moused over, segments are drawn connecting the related data points. Can be used to show where on the map real world items have traveled.
    * **Auto Chart:** Combines several different types of charts that are selectable from a drop-down menu. These charts include, bar, trend, pie, funnel, and bubble charts. Offers more dynamic interaction with your data than the standard charts above.
    * **Bubble Grid:** Displays a chart with bubbles sized based on the magnitude of the data. The categories can be moused over to show the actual numbers behind the bubbles.
    * **Combo Grid:** Creates a pareto chart with much more dynamic and granular control of your data than the standard pareto chart.
    * **Crossfilter:** Creates a bar chart with a slider that you can use to select specific groups of your data dynamically.
    * **Heatmap:** Creates a heatmap with cells sized based on the magnitude of your data. The chart can be interacted with and clicking on any category will enact a drill-down of the data to the selected level. Clicking at the lowest level will send you back to the highest level. Great for massive amounts of hierarchical data.
    * **Matrix:** Creates a heatmap with cells of a uniform size that are shaded darker or lighter based on the magnitude of the data. Great for discerning where in your data the greatest concentration exists.
    * **Polar:** A type of radial graph that is good for multi-variate data of three or more quantitative values. The farther from the center the point is, the larger the value of the data.
    * **Projected Map:** Displays an Eckert map projection that is good for world geographical data and uses latitude/longitude to produce bubbles on the map sized to the data metric that is being measured. Use the mouse-wheel to zoom in or out of the map.
    * **Sunburst:** Another type of radial graph that is good for displaying hierarchical data. Data on the inside is broader while data on the outside is more specific.
    * **Time Bubble:** Creates an animated bubble chart that displays change over time.
    * **Timeline:** Displays data in a timeline format, with the x-axis being time. Timelines that overlap are shaded with a darker color. Great for project management or shipping metrics.
    * **Transitions:** Combines many different charts into one fluid animation of data, displaying it in various metrics.
    * **Tree:** Displays bubbles sized in comparison with your data that aggregates it into the "trunk" of the tree.
    * **Waterfall:** Displays a chart that can relate both positive and negative change for specific periods of time. Great for quarterly or yearly numeric data.
    * **World Tour:** This is a 3D spherical map of the entire world that animates itself to move around the world to your different datapoints. 
* **Settings:** Here is a list of settings that are applicable to all charts:
    * **Title:** Used to add a title to your chart that is displayed in bold.
    * **Records:** Determines how many records of your data will be displayed in the chart.
    * **Scale %:** Scales the chart's height by the input percentage. (All but visualizations)

###Gauge tab

Applies one or more gauge controls to your report that can give useful information about min/average/max load capacity and other magnitude-based data.

* **Title:** Adds a title to the chart displayed in bold above all the gauges.
* **Results:** The amount of records to be used for this chart. Unlike in regular charts, this will add a new gauge for each record and is capped at twelve.
* **Minimum:** Defines the lower bound of the gauge's display range. Defaults to 0.
* **Maximum:** Defines the upper bound of the gauge's display range. Defaults to the next order of magnitude beyond the range of your data. (e.g. if your data caps out at 15,146, 100,000 is the maximum value by default)
* **Color:** Defines the color transition used for the gauge. The valid color options are any HTML safe color name. HTML color codes may not be used.
* **Gauge Style:** This will change the graphic type used to display the gauge. There are four types:
    * **Radial:** Standard gauge that has a needle that has a 90 degree range. Does not animate.
    * **Radial 2:** Slightly more stylized version of the above gauge. Does not animate.
    * **Animated half circle:** An animated gauge with a 180 degree range of motion. This also has some optional settings:
        * **KPI Low:** Available on the animated half circle gauge only. This value will set the minimum for the target area of the gauge.
        * **KPI High:** Available on the animated half circle gauge only. This will set the maximum value for the target area to enclose.
        * **Update:** Allows a number input that represents the seconds the gauge will animate for.
        * **Red Values:** Has three options: Hide, Low, and High. Red values can be seen as a "danger zone" of sorts. Use Hide when neither low nor high values indicate danger.
    * **Linear:** This will produce a straight gauge with a bar on the inside to indicate the total value. Does not animate.
* **Target Report:** Select from a list of sub-reports to use as drill-down data on the gauge. The gauge will use its "Name" field data as the drill-down key.
* [See An Example](http://www.izenda.com/bi/ReportViewer.aspx?rn=Human+Resources)

###Misc tab

Here you can change properties concerning your general report. You can also schedule emails to send your report out via Izenda's custom scheduler.

* **Report Header Image Justification:** The report header is set in the [Izenda Settings]() page. More on justification [here](http://wiki.izenda.us/FAQ/How-do-I-control-the-alignment-of-text-fields-or-justification-in-report-output).
* **Title:** The report's title, displayed either left-aligned, right-aligned, or centered depending on what the box selection was to the right of the control. 
* **Description:** The report's description, displayed below the title. Can also be re-aligned.
* **Report Header:** Add a header to the report.
* **Page Header:** Add a header to the page. 
* **Footer:** Add a footer to the report.
* **Share With:** Choose what role(s) of users have the rights selected in the next box.
* **Rights:** Choose what level of access the users in the selected role can have with the report.
* **Owner:** The user who owns the report. Generally this will be the person who created the report.
* **Drill-down key:** The field that this report will use to filter data if another report attempts to access it as a sub-report.
* **Schedule:** Please see our documentation about the [Izenda Scheduler](http://wiki.izenda.us/How-do-I-use-the-Izenda-Reports-report-email-scheduler) for more information about these fields.
* *Hint: You can grab the first result of a field using [FieldName] and Izenda Reports will display the associated data! You can use this to make reports customized to individuals by putting these types of entities into the title and description fields.

###Style tab

Here you can add styling to your report. This affects the table that is displayed on the report viewer. A preview of what your table will look like is displayed here as well.
* **Border Color:** This allows you to set the color of the border that splits your table cells. This applies to the whole table rather than individual rows or columns.
* **Header Color:** This sets the background color for your table headers. The headers contain the titles of the columns in your report.
* **Header Foreground Color:** This allows you to set the text color within the header cells.
* **Item Color:** This allows you to set the background color of odd-numbered rows, starting with the first row below the header row.
* **Item Foreground Color:** This will set the text color of all the data contained in your report (with the exception of the header).
* **Alternating Item Color:** This sets the background color of eve-numbered rows, starting with the second row below the header row.
* **Restore Default:** Reverts the styling back to the page defaults
* **CSS:** You can define your own css classes and declarations to be used on your table for more customized control over your report.
* **Landscape Printing:** Checking this property will cause any reports you print using the menu buttons to be printed in landscape mode. Unchecking it will print reports in portrait mode.
* **Show Page Number:** Applies solely to printed reports. Displays the page number on each page of the report.
* **Show Date and Time:** Also applies to printed reports. This will display the date and time on the header of the report when it's printed.
* **Use pagination in web view:**
* **Add bookmark for each visual group:** Applies to PDF exports. This will create a bookmark for each table that has been generated using the visual grouping feature on the fields tab.
* **Page Break After Visual Groups:** This applies to PDFs and word documents.
This will use the visual grouping feature to create a PDF or DOC file with one page per visual group.
* **Minimize Grid Width:** 
* **Visual Group Style:** Changes how visual groups are displayed in the report viewer. There are a number of options here:
    * **Comma Delimited:** Displays all levels of the visual group separated by commas. (E.g. if you have visual groups based on country and region code, the title of the visual group will be [Country], [RegionCode])
    * **Comma Delimited With Labels:** Same as Comma Delimited, except it will display the field name description (E.g. Country:[Country], Region:[RegionCode])
    * **Line Delimited:** Displays each level of the visual group on a new line.
    * **Line Delimited With Labels:** As with the Comma Delimited With Labels style, except each label:value combination will be displayed on its own line.
    * **Field Value:** Displays the field name left aligned and the field value right aligned for all levels of the visual grouping.
    * **Multi Level:** Displays as the Line Delimited style except the highest level categories of the visual group are displayed as headers gradually decreasing in size.
    * **Multi Level With Labels:** As the Multi-Level style except with the Label:Value format described above.
    * **Analysis Grid:** Turns the datagrid into a dynamic drilldown list with the top-level data being an expandable row. Each sub-row will be expandable until the bottom-most item in the visual group is reached. (E.g. [Country] --click--> [RegionCode] --click--> [StateCode])
    * **VG Hierarchy:** Turns the datagrid into a dynamic drilldown list with every level of drilldown already expanded. Instead of introducing a new level of drilldown on each line like the Analysis Grid, however, VG Hierarchy will put all the drilldowns it can onto one row. Generally, if a grouping has only one value for a given field, it will be displayed on the same line as its predecessor. If a grouping has more than one value for a given field, it will attribute as many rows as there are unique values for that field.
* **Items Per Page (In Viewer):** Limits the amount of items displayed on the report viewer to the number in the box. If visual grouping is used, all visual groups are added together for purposes of showing records. Subtotal lines are not included in the count.
* **Report Order:** Allows you to change the order in which your report elements are shown in the viewer and in printed reports.
* **Field|Value Column Pairs:** 
* **Show Main Report In Field|Value Style:**
* **Show Summary Report In Field|Value Style:**

###Filters Tab

Here you can define filters for your data. These work as conditionals that are easier for non-technical users to use than the underlying queries. 
* **Filter Field:** The database field to apply the operation to. This is populated from the selected datasources like the fields tab.
* **Operator:** Applies the selected operation to the filter field. There are a number of options that are easily readable and understandable by average users. This field is context sensitive based on the type of data in the filter field.
* **Values:** Here you can specify what values you want to use the selected operation to compare with the values in the filter field. You can either use a pre-defined list of values presented in several different formats, or you can define your own conditions. This is context sensitive with regards to the other filters already selected.
* **Blank:** When checked, includes blank values in the list of acceptable values. Unchecked by default.
* **Param:** When checked, specifies that the filter field is included in the report viewer. Checked by default.
* **Show Filters In Report Description:** Displays the computed filter values in the report viewer. This can be used to more accurately see what the conditionals will look like when the data is sent to the server.
* **Require X Parameters In Viewer:** This value is used to set a lower limit on how many filter parameters are required for the report viewer.
* **Filter Logic:** Used to control how your filters are handled. Following the default example in how to reference your filters is ideal. [Learn more](http://wiki.izenda.us/FAQ/Questions/How-To-Apply-Advanced-Logic-Filters)

###Preview

Here you can preview the results of the report that you have created before you decide to publish it. You can also go back to any tab at any time and edit your report. Data will not be lost until you close the browser or navigate away from the page.

##Contacting Microsoft

Depending on what and how you purchased, Microsoft often provides full support for server products and development tools.  Any issues with server hardware, software, or configurations should be resolved via Microsoft's support channels and is not included in Izenda's support packages.