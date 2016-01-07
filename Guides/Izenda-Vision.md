[[_TOC_]]

#Introduction to Visualizations

Izenda Visualizations are a D3-based visual supplement to Izenda’s core charting engine. Visualizations are rendered in a chart report part, but are built on the columnar data in your summary or fields tab. These columns must be arranged in a specific order to provide valid data for certain visualizations. This document lists which column arrangement works with each visualization style.

Given that visualizations rely on the teamwork between the chart itself and the column data which supports it, this means that visualizations may not be easy to include in a complex report. Currently, any data in the Summary tab will be read, and if this tab is empty, the Fields tab will be used instead.

In Izenda terms, a field and a column are the same thing. This documentation will refer to fields and columns interchangeably. To be precise, fields are listed from top to bottom on the Fields tab, and displayed as columns from left to right.

##Field Order

When creating a visualization, you must pay specific attention to the field order. This is the idea that fields, from top to bottom, can be numbered - the first field in the list is 1, the second field is 2, and so on. Likewise, the leftmost column is column 1, the column immediately to the right is column 2, and so on. This field order is critical, as visualizations demand a specific order to fields which dictates not only if they will be used, but how they will be used.

##Field Order and Group Hierarchy

Some visualizations permit multiple group fields. Group field hierarchy must be placed in proper field order. This means highest category first, and lowest category last. Here are some examples:

Country, State/Region, City, Neighborhood

Company, Department, Office, Desk

Tera, Giga, Mega, Kilo

Visualizations read the exact field order as you define it. If I place Neighborhood before Country, my visualization will not make any sense by definition. Double check that fields are in the correct order if the visualization does not appear to be correct.

##Field Sorting

Visualizations sort in an order defined by the columns in the Summary or Fields tab. This order does not change if you select a different metric, which means that you can be viewing Metric B as sorted by Metric A. Currently, the only way to change the sort order is to change the sorting behavior defined by the arrangement of fields. If you are experiencing undesired or confusing sort behavior, check to make sure that the field sort order is correct.

Count(Order ID), Year(Order Date), Count(Customer ID), Ship City, Country

##Drill-downs and Dynamic Filtering

Some visualizations support dynamic filtering and drill-down-like behavior. Currently, a full drill-down - connecting through a visualization to another Izenda report - is not possible. A visualization can exist on a child report, and can exist on a parent report, but no part of the visualization is clickable to activate a downhill. The drill-down terminology in this case means that some visualizations, like heat map and sunburst, can drill-down within themselves. This is more accurately described as dynamic filtering. Dynamic filtering the visualization will also filter the linked summary or detail view.

##Fields labeled with a plus (+) sign

Some visualizations can accept an indefinite number of fields as metrics. These fields are noted with a plus sign after the field number order. That is to say, if a visualization requires 3 and only 3 fields, its fields will be listed as 1, 2, 3. However, if a visualization can have multiple fields after the first two fields which define its boundaries, its fields would be listed as 1, 2, 3+. In other words, after the mandatory fields 1 and 2, we could have fields 3, 4, 5, 6 which all serve as additional selectable metrics. Generally only one of these fields will be displayed at a time, but with the option of selecting between them.

##Fields labeled with ellipsis (...)

Some visualizations can accept a large number of fields as groups. These fields are noted with an ellipsis after the field order number. This means that if a visualization accepts multiple levels of hierarchical data, I could have 5 group fields representing hierarchy in fields 1 through 5, and begin my metrics at field 6. In this documentation, this will be noted as Field 1…, Field 2. This does not mean that the metric needs to be in the actual second field. This means that the metric field(s) must be placed after all of the group fields in fields 1 through X.

##Fields labeled with a question mark (?)

Some visualizations do not care where a field is, so long as it exists. These fields are noted with a question mark after the field order number. This means that you don’t necessarily have to place that field in the noted order, if you have some reason not to follow the recommended best practice.

##Terms

These terms refer to the types of columns that each visualization reads.

* **Group** - This column can be any data type, aggregated or not aggregated. These columns are used to group data in other columns, and often serve as the axis or scale of a particular visualization.  
* **Time** - This column must be a Datetime data type.  
* **Metric** - This column can be any data type. It is generally an aggregate, and most commonly a numeric, but does not have to be. These columns are the elements that are being charted, mapped, or displayed on your visualization. 
* **Geographic Field** - This column is a special case. It is used in map-style visualizations. It must be a list of geographic entities, such as a list of countries, regions, or states.

#Lifecycle of a VIS report:
 
1. First, the Detail (the tab is labeled Fields) or Summary report part is generated on the underlying report. These are .NET DateTable objects, initially termed SourceTable for raw data from the database, and FormattedTable after formatting is applied.
2. These tables are then used to render the HTML grids that are populated and displayed to the user.
3. The Visualization reads and formats the data from the underlying SourceTable and FormattedTable that forms either the Summary or Detail (Fields) grid.
4. This data is then serialized into a JSON string and sent to the client.
5. The JSON string is then deserialized into the Javascript object which renders the visualization.

#Visualization Styles:

##Arc Map

* Arc Map displays a map which ties a single metric at a time to pairs of cities.
* Field 1 - **Geographic Field** - This field will represent the source city on the map. A line will be drawn from it to the destination city.
* Field 2 - **Geographic Field** - This field will represent the destination city on the map. A line will be drawn to the destination city from the source city.
* Field 3+ - **Metric** - These values of one field at a time, selectable from a dropdown, will be displayed on the map.
**Notes:**
* *  Metric fields will not graphically display if they are negative. Arc Map currently only supports the continental United States.


##Auto Chart

![Auto Chart](http://wiki.izenda.us/Guides/Izenda-Vision/Auto-Chart.png)

* Auto Chart permits the generation of many simple chart types. Some of these charts display a single metric at a time, others display multiple metrics at one time.
* Field 1 - **Group** - This field will represent the categories along the X axis, the Y axis, or the slices or items displayed on a proportional chart.
* Field 2+ - **Metric** - This field will represent the value on the chart. The metric currently being displayed is selectable from a drop-down.

##Combo

![Combo](http://wiki.izenda.us/Guides/Izenda-Vision/Combo.png)

* Combo displays metrics with a series of bars and lines on the same graph. Each metric gets its own Y axis, with the X axis determined by the single group field. The first half of the metric fields will be displayed with bars, the second half with lines.
* Field 1 - **Group** - This field will represent the categories along the X axis.
* Field 2+ - **Metric** - This field will represent the values of each bar or line. Each bar or line will receive its own scale on the Y axis.  
**Notes:**
* * Metric fields will be split between bar and line graphs. The first half of your metric fields will be bars, the second half will be lines. 

##Crossfilter

![Crossfilter](http://wiki.izenda.us/Guides/Izenda-Vision/Crossfilter.png)

* Crossfilter displays multiple charts, one for the datetime grouping field and one for each metric. Clicking and dragging on any chart will establish a range, which acts as a filter on all other charts. You can also drag the range itself to move it without changing its size. This chart is useful for finding clusters of data within other data, for example we have less orders in June vs. August but they are worth more money.
* Field 1? - **Datetime** - This field will represent the time factor by which other metrics can be filtered. Range of values is displayed on the X axis and count of values is displayed on the Y axis.
* Field 2+ - **Metric** - This field will represent the value. Range of values is displayed on the X axis and count of values is displayed on the Y axis.
**Notes:**
* * Some group categories for Datetime will produce too many or invalid results. If your chart does not work, try a different grouping on the datetime or filtering the dataset from the Filter tab.

##Auto Gauges

Automatic Gauges have four different modes:  

* Round
* Linear
* Simple
* Trending

### Round Auto Gauge Style

* Round style draws a round dial gauge for each value of Field 1. The literal value will be displayed in the center of the gauge, and the proportion of this value to some maximal value will be displayed in blue around the edge of the gauge, starting from the 12 o'clock position or straight up, filling clockwise or to the right. You may place arbitrary indicators on this gauge to serve as Key Performance Indicators (KPI).
* Field 1 - **Group** - This field will determine what each gauge represents.
* Field 2 - **Metric** - This field will determine the numeric value displayed in each gauge. Supplying only one metric means that the gauge will always be 100%, as it is equal to itself.
* Field 3 - **Metric** - **OPTIONAL** - This field will establish a secondary metric in relation to the metric in Field 2. If Field 2 has a value of 50, and Field 3 has a value of 100, then the value displayed will be 50/100, and the gauge will be half full.
* The following fields do not have to be in any particular order: They read text in the description box to determine how they should behave.
* Field 4 - **Metric** - **OPTIONAL** - This field must have the text "Max" in the description box. It will establish an upper limit for the gauge itself, and any values in the gauge will be rendered as a proportion of the Max metric.
* Field 5 - **Metric** - **OPTIONAL** - This field must have the text "Low" in the description box. It will establish a red KPI indicator at the specified value.
* Field 6 - **Metric** - **OPTIONAL** - This field must have the text "High" in the description box. It will establish a green KPI indicator at the specified value.
* Field 7 - **Metric** - **OPTIONAL** - This field must have the text "Target" in the description box. It will establish a blue KPI indicator at the specified value.

### Linear Auto Gauge Style

* Linear style displays a series of linear gauges which display a number from 0 to 100, from left to right. You may set KPI areas for this gauge.
* Field 1 - **Group** - This field will determine what each gauge represents.
* Field 2 - **Metric** - This field will determine the value in each gauge.
* The following fields do not have to be in any particular order: They read text in the description box to determine how they should behave.
* Field 3 - **Metric** - **OPTIONAL** - This field must have the text "Low" in the description box. It will establish a green KPI region at and around the specified value.
* Field 4 - **Metric** - **OPTIONAL** - This field must have the text "High" in the description box. It will establish a red KPI region at and around the specified value.
* Field 5 - **Metric** - **OPTIONAL** - This field must have the text "Target" in the description box. It will establish a blue KPI region at and around the specified value.

### Simple Auto Gauge Style

* Simple style displays the name of each group value in Field 1, and then a numeric value as text from Field 2. You can establish a color gradient of this text value, as well as specify a Units value as a string to display beneath the gauge.
* Field 1 - **Group** - This field will determine what each gauge represents.
* Field 2 - **Metric** - This field will determine the value in each gauge.
* The following fields do not have to be in any particular order: They read text in the description box to determine how they should behave.
* Field 3 - **Metric** - **OPTIONAL** - This field must have the text "Low" in the description box. It will establish the lower bound of a KPI region. Field 2's value will be shaded a bright green as it approaches but does drop below this value.
* Field 4 - **Metric** - **OPTIONAL** - This field must have the text "High" in the description box. It will establish a upper bound of a KPI region. Field 2's value will be shaded a deep red as it approaches but does not exceed this value. 
* Field 5 - **Metric** - **OPTIONAL** - This field must have the text "Target" in the description box. It will establish a blue KPI region at and around the specified value. Field's 2's value will be shaded a bright blue as it approaches this value.
* Field 6 - **Group** - **OPTIONAL** - This field's value will be displayed as a string beneath each gauge as a subtext. 

### Trending Auto Gauge Style

* Trending style displays a series of data over time, as well as a proportional indicator showing the currently moused over time value in relation to the first time value of each gauge. You may also set a bulls-eye target indicator for a certain value. 
* Field 1 - **Group** - This field will determine what each gauge represents.
* Field 2 - **Datetime** - This field will determine the time order of the values for each gauge. This field must be sorted chronologically from oldest to newest (default sort) and grouped by Year & Month.
* Field 3 - **Metric** - This field determines the numerical value displayed for each time value.
* Field 4 - ** Metric** - **OPTIONAL** - This field determines a target value superimposed atop the gauge, indicating if the current value of Field 2 is too low or too high.

##Heat Map

![Heat Map](http://wiki.izenda.us/Guides/Izenda-Vision/Heat-Map.png)

* Heat Map displays a tree-like hierarchy of squares, each of which proportionally represents the aggregate metric at each level of the hierarchy.
* Field 1... - **Group** - This field represents the hierarchical levels which structure the heat map.
* Field 2+ - **Metric** - This field will represent the value on the chart. The metric currently being displayed is selectable from a drop-down.

##Matrix

![Matrix](http://wiki.izenda.us/Guides/Izenda-Vision/Matrix.png)

* Matrix displays a series of squares, arranged by group and time, in the style of a pivot. The squares are shaded according to each metric value.
* Field 1 - **Group** -  This field will represent the categories along the Y axis.
* Field 2 - **Time** - This field will represent the categories along the X axis. This field must have the function set to Group(Year & Month).
* Field 3 - **Metric** - This field will represent the value of each square.  
**Notes:**
* * Matrix can only render so many squares. If you aren't getting enough data on the time based X axis, try filtering out some items from the group based Y axis.

##Projected Map

* Projected Map displays a scalable, zoomable map which ties metrics to individual cities.
* Field 1 - Geographic Field -  This field will represent lists of cities.
* Field 2… - Metric - This field will represent the value selectable from a dropdown.
**Notes:**
* * Currently only the United States is supported.

##Sunburst

![Sunburst](http://wiki.izenda.us/Guides/Izenda-Vision/Sunburst3.png)

* Sunburst displays a tree-like hierarchy of items layered in a circular arrangement, each of which proportionally represents the aggregate metric at each level of the hierarchy. The layers from inner to outer represent each level of the hierarchy. Larger groups are displayed from the 12 o’clock position clockwise.
* Field 1... - **Group** - This field represents the hierarchical levels which structure the heat map.
* Field 2+   - **Metric** - This field will represent the value on the chart. The metric currently being displayed is selectable from a drop-down.

##Time Bubble

![Time Bubble](http://wiki.izenda.us/Guides/Izenda-Vision/Time-Bubble.png)

* Time Bubble is a multidimensional graph which displays circles which change in size and position over time. Mousing over the time label at the bottom right of the chart will move forward and backward in time.
* Field 1 - **Group** - This field will represent each circle. 
* Field 2 - **Date time** - This field will determine the scale at which circles move and change size. This field must be set to Group(Year & Month).
* Field 3 - **Metric** - This field will represent the Y axis.
* Field 4 - **Metric** - This field will represent the X axis.
* Field 5 - **Metric** - This field will represent the Z axis, represented by the area of the circle.

##Timeline

![Timeline](http://wiki.izenda.us/Guides/Izenda-Vision/Timeline.png)

* Timeline displays a single metric between two points in time. The length of each item represents the distance between your start and end times.
* Field 1 - **Group** - This field represents the Y axis.
* Field 2 - **Metric** - This field represents the item charted.
* Field 3 - **Datetime** - This field represents the beginning point from which the metric will be drawn.
* Field 4 - **Datetime** - This field represents the end point to which the metric will be drawn.  
**Notes:**
* * Timeline can only display up to a fixed amount of data. If you are not seeing all the data you expect to see, try filtering down your report set - particularly the time dimension.

##Transitions

![Transitions](http://wiki.izenda.us/Guides/Izenda-Vision/Transitions.png)

* Transitions displays multiple common graph styles in a fixed cycle.
* Field 1 - **Group** - This field represents categories on the Y axis or slices of proportional charts.
* Field 2 - **Datetime** - This field represents the X axis when applicable. It must be set to Group(Year & Month)
* Field 3 - **Metric** - This field represents the value.  
**Notes:**
* * You must sort Fields 1 and 2 to make coherent charts. If your charts look odd, make sure that the sorting behavior is correct.


##Tree

![Tree](http://wiki.izenda.us/Guides/Izenda-Vision/Tree2.png)

* Tree displays a tree design with a set of linked nodes.  Each node in a tree has zero or more child nodes.  
* Field 1... **Group** - This group represents the hierarchical levels which structure the tree.
* Field 2+ - **Metric** - This field will represent the value on the chart. The metric currently being displayed is selectable from a drop-down.

##Waterfall

![Waterfall](http://wiki.izenda.us/Guides/Izenda-Vision/Waterfall.png)

* Waterfall displays a bar chart with a built in pareto function - that is, the bottom of each bar begins at the top of the previous bar.
* Field 1 - **Group** - This field represents each bar along the X axis.
* Field 2 - **Metric** - This field represents the value of each bar.

##World Tour

![WorldTour](http://wiki.izenda.us/Guides/Izenda-Vision/World-Tour.png)

* World Tour displays countries and a single metric associated with that country.
* Field 1 - **Geographical Field** - This field represents the country.
* Field 2 - **Metric** - This field represents the value associated with each country.