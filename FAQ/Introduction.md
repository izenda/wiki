#Introduction

[[_TOC_]]

We are continually developing online Izenda Reports training materials focused on the needs of novice users. The materials will include a basic overview of building reports which utilize bar, pie, and trend charts as well as some advanced topics. These materials include both video and printable formats.

All training materials are available on the Izenda Reports site at no charge. The presentations and lessons assume the availability of a working copy of Izenda Reports connected to a database containing both text and numerical data. You may print and re-distribute these materials to any users within the organization or company that licenses Izenda Reports. 

##Report Designer

The training walks through the features available in the various tabs of the Izenda Report Designer in order to familiarize the users with the options available: 

###Datasources tab

Here you can select the data sources (tables and views) to use in your report.  There are two ways to view this.

* **Basic:** The basic view of the data sources tab will let you choose from a list of recent data sources or choose one data source from a list.
* **Advanced:** This view will let you choose any number of data sources and define their relationships. This acts as an SQL join would.

###Field tab

Here you can select how many records to display, as well as define which data you wish to be included in your report. Here is a list of controls and their descriptions.

* **Records:** Defines the maximum amount of results to display.
* **Field:** Allows selection of the table columns from the data set(s) chosen in the previous tab.
* **Description:** A name for the data column. This is filled in with the column name by default.
* **Sort:** Allows sorting of the data in ascending order when the report is generated
* **VG:** With this selected, a grid will be created for each unique value in the chosen field when the report is generated
* **A:** Allows arithmetic operations to be performed (+,-,*,/). This is context sensitive to the function being performed
* **Function:** Specifies an aggregate or grouping function to be performed, such as COUNT, SUM, and AVG
* **Format:** Specifies the format to be used when displaying the data. Applies to dates and numeric data. This is also context sensitive.
* **Delete:** Removes the field from the report.
* **Insert field above:** Creates a new field above the current one.
* **Insert field below:** Creates a new field below the current one.
* **Advanced Field Settings:** Learn more about advanced field settings [[here]]
* **Add Subtotals:** Creates a total line between each report and highlights the value in bold

###Summary tab

Here you can define a new set of data separate from the field list you selected that can act as a synopsis of your data. It is displayed above the table you defined on the Fields tab on the report viewer. Identical to the fields tab with a few exceptions.

* No visual grouping (VG checkbox)
* No arithmetic checkbox
* **Show Deltas:** shows the changes in your data as a percentage (handy for quarterly report summaries)

###Chart tab

You can define a chart to use here from a list of Izenda-supported charts. Selecting a chart will update the settings form directly below, which can be filled out with labels and other options. The selectable chart types are:

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
    * **Title::** Used to add a title to your chart that is displayed in bold.
    * **Records:** Determines how many records of your data will be displayed in the chart.
    * **Scale %:** Scales the chart's height by the input percentage. (All but visualizations)
###Gauge tab

Applies one or more gauge controls to your report that can give useful information about min/average/max load capacity and other magnitude-based data.

* **Title:** Adds a title to the chart displayed in bold above all the gauges.
* **Records:** The amount of records to be used for this chart. Unlike in regular charts, this will add a new gauge for each record and is capped at twelve.
* [See An Example](http://www.izenda.com/bi/ReportViewer.aspx?rn=Human+Resources)
###Misc tab

Here you can change properties concerning your general report. You can also schedule emails to send your report out via Izenda's custom scheduler.
* **Report Header Image Justification:** Has three settings that can be cycled through by clicking (R - right, L - left, M - middle). The report header is set in the [Izenda Settings]() page.
* **Title:** The report's title, displayed either left-aligned, right-aligned, or centered depending on what the box selection was to the right of the control. 
* **Description:** The report's description, displayed below the title. Can also be re-aligned.
* **Report Header:** Add a header to the report.
* **Page Header:** Add a header to the page. 
* **Footer:** Add a footer to the report.
* *Hint: You can grab the first result of a field using [FieldName] and Izenda Reports will display the associated data! You can use this to make reports customized to individuals by putting these types of entities into the title and description fields.

###Style tab

####Filters Tab

####Pivots Feature