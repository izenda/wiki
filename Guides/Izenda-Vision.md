Izenda Visualizations are a D3-based visual supplement to Izenda’s core charting engine. Visualizations are rendered in a chart report part, but are built on the columnar data in your summary or fields tab. These columns must be arranged in a specific order to provide valid data for certain visualizations. This document lists which column arrangement works with each visualization style.

Given that visualizations rely on the teamwork between the chart itself and the column data which supports it, this means that visualizations may not be easy to include in a complex report. Currently, any data in the Summary tab will be read, and if this tab is empty, the Fields tab will be used instead.

INSERT IMAGE HERE

In Izenda terms, a field and a column are the same thing. This documentation will refer to fields and columns interchangeably. To be precise, fields are listed from top to bottom on the Fields tab, and displayed as columns from left to right.

**Field Order**

When creating a visualization, you must pay specific attention to the field order. This is the idea that fields, from top to bottom, can be numbered - the first field in the list is 1, the second field is 2, and so on. Likewise, the leftmost column is column 1, the column immediately to the right is column 2, and so on. This field order is critical, as visualizations demand a specific order to fields which dictates not only if they will be used, but how they will be used.

INSERT IMAGE HERE

**Field Order and Group Hierarchy**

Some visualizations permit multiple group fields. Group field hierarchy must be placed in proper field order! This means highest category first, and lowest category last. Here are some examples:

Country, State/Region, City, Neighborhood

Company, Department, Office, Desk

Tera, Giga, Mega, Kilo

Expressions read the exact field order as you define it. If I place Neighborhood before Country, my visualization will not make any sense by definition! Double check that fields are in the correct order if the visualization does not appear to be correct.

**Field Sorting**

Visualizations sort in an order defined by the columns in the Summary or Fields tab. This order does not change if you select a different metric, which means that you can be viewing Metric B as sorted by Metric A. Currently, the only way to change the sort order is to change the sorting behavior defined by the arrangement of fields. If you are experiencing undesired or confusing sort behavior, check to make sure that the field sort order is correct.

Count(Order ID), Year(Order Date), Count(Customer ID), Ship City, Country

**Drill-downs and Dynamic Filtering**

Some visualizations support dynamic filtering and drill-down-like behavior. Currently, a full drill-down - connecting through a visualization to another Izenda report - is not possible. A visualization can exist on a child report, and can exist on a parent report, but no part of the visualization is clickable to activate a downhill. The drill-down terminology in this case means that some visualizations, like heat map and sunburst, can drill-down within themselves. This is more accurately described as dynamic filtering. Dynamic filtering the visualization will also filter the linked summary or detail view.

**Fields labeled with a plus (+) sign**

Some visualizations can accept an indefinite number of fields as metrics. These fields are noted with a + after the field number order. That is to say, if a visualization requires 3 and only 3 fields, its fields will be listed as 1, 2, 3. However, if a visualization can have multiple fields after the first two fields which define its boundaries, its fields would be listed as 1, 2, 3+. In other words, after the mandatory fields 1 and 2, we could have fields 3, 4, 5, 6 which all serve as additional selectable metrics. Generally only one of these fields will be displayed at a time, but with the option of selecting between them.

**Fields labeled with ellipsis (...)**

Some visualizations can accept a large number of fields as groups. These fields are noted with a … after the field order number. This means that if a visualization accepts multiple levels of hierarchical data, I could have 5 group fields representing hierarchy in fields 1 through 5, and begin my metrics at field 6. In this documentation, this will be noted as Field 1…, Field 2. This does not mean that the metric needs to be in the actual second field. This means that the metric field(s) must be placed after all of the group fields in fields 1 through X.

**Fields labeled with a question mark (?)**

Some visualizations do not care where a field is, so long as it exists. These fields are noted with a ? after the field order number. This means that you don’t necessarily have to place that field in the noted order, if you have some reason not to follow the recommended best practice.

**Terms**

These terms refer to the types of columns that each visualization reads.

**Group** - This column can be any data type, aggregated or not aggregated. These columns are used to group data in other columns, and often serve as the axis or scale of a particular visualization.  
**Time** - This column must be a Datetime data type.  
**Metric** - This column can be any data type. It is generally an aggregate, and most commonly a numeric, but does not have to be. These columns are the elements that are being charted, mapped, or displayed on your visualization. 
**Geographic Field** - This column is a special case. It is used in map-style visualizations. It must be a list of geographic entities, such as a list of countries, regions, or states.

#Visualization Styles:

##Auto Chart

INSERT AUTO CHARTS HERE

* Auto Chart permits the generation of many simple chart types. Some of these charts display a single metric at a time, others display multiple metrics at one time.
* Field 1 - **Group** - This field will represent the categories along the X axis, the Y axis, or the slices or items displayed on a proportional chart.
* Field 2+ - **Metric** - This field will represent the value on the chart. The metric currently being displayed is selectable from a drop-down.

##Bubble Grid 

INSERT IMAGE HERE

* Bubble Grid displays a circle with the area representing the metric field by the group field and the time field.
* Field 1 - **Group** - This field will represent the categories along the Y axis.
* Field 2 - **Time** - This field will represent the categories along the X axis. This field must have the function set to Group(Year & Month).
* Field 3 - **Metric** - This field will represent the value of each bubble.

##Combo

INSERT IMAGE HERE

* Combo displays metrics with a series of bars and lines on the same graph. Each metric gets its own Y axis, with the X axis determined by the single group field. The first half of the metric fields will be displayed with bars, the second half with lines.
* Field 1 - **Group** - This field will represent the categories along the X axis.
* Field 2+ - **Metric** - This field will represent the values of each bar or line. Each bar or line will receive its own scale on the Y axis.
* Notes:
* * Metric fields will be split between bar and line graphs. The first half of your metric fields will be bars, the second half will be lines. 

##Crossfilter

INSERT IMAGE HERE

* Crossfilter displays multiple charts, one for the datetime grouping field and one for each metric. Clicking and dragging on any chart will establish a range, which acts as a filter on all other charts. You can also drag the range itself to move it without changing its size. This chart is useful for finding clusters of data within other data, for example we have less orders in June vs. August but they are worth more money.
* Field 1? - **Datetime** - This field will represent the time factor by which other metrics can be filtered. Range of values is displayed on the X axis and count of values is displayed on the Y axis.
* Field 2+ - **Metric** - This field will represent the value. Range of values is displayed on the X axis and count of values is displayed on the Y axis.
* Notes:
* * Some group categories for Datetime will produce too many or invalid results. If your chart does not work, try a different grouping on the datetime or filtering the dataset from the Filter tab.

##Heat Map

INSERT IMAGE HERE

* Heat Map displays a tree-like hierarchy of squares, each of which proportionally represents the aggregate metric at each level of the hierarchy.
* Field 1... - **Group** - This field represents the hierarchical levels which structure the heat map.
* Field 2+ - **Metric** - This field will represent the value on the chart. The metric currently being displayed is selectable from a drop-down.

##Matrix

INSERT IMAGE HERE

* Matrix displays a series of squares, arranged by group and time, in the style of a pivot. The squares are shaded according to each metric value.
* Field 1 - **Group** -  This field will represent the categories along the Y axis.
* Field 2 - **Time** - This field will represent the categories along the X axis. This field must have the function set to Group(Year & Month).
* Field 3 - **Metric** - This field will represent the value of each square. 
* Notes:
* * Matrix can only render so many squares. If you aren't getting enough data on the time based X axis, try filtering out some items from the group based Y axis.

##Sunburst

![Sunburst](http://wiki.izenda.us/Guides/Izenda-Vision/Sunburst.png)

* Sunburst displays a tree-like hierarchy of items layered in a circular arrangement, each of which proportionally represents the aggregate metric at each level of the hierarchy. The layers from inner to outer represent each level of the hierarchy. Larger groups are displayed from the 12 o’clock position clockwise.
* Field 1... - **Group** - This field represents the hierarchical levels which structure the heat map.
* Field 2+   - **Metric** - This field will represent the value on the chart. The metric currently being displayed is selectable from a drop-down.

##Time Bubble

INSERT IMAGE HERE

* Time Bubble is a multidimensional graph which displays circles which change in size and position over time. Mousing over the time label at the bottom right of the chart will move forward and backward in time.
* Field 1 - **Group** - This field will represent each circle. 
* Field 2 - **Date time** - This field will determine the scale at which circles move and change size. This field must be set to Group(Year & Month).
* Field 3 - **Metric** - This field will represent the Y axis.
* Field 4 - **Metric** - This field will represent the X axis.
* Field 5 - **Metric** - This field will represent the Z axis, represented by the area of the circle.

##Timeline

INSERT IMAGE HERE

* Timeline displays a single metric between two points in time. The length of each item represents the distance between your start and end times.
* Field 1 - **Group** - This field represents the Y axis.
* Field 2 - **Metric** - This field represents the item charted.
* Field 3 - **Datetime** - This field represents the beginning point from which the metric will be drawn.
* Field 4 - **Datetime** - This field represents the end point to which the metric will be drawn.
* Notes:
* * Timeline can only display up to a fixed amount of data. If you are not seeing all the data you expect to see, try filtering down your report set - particularly the time dimension.

##Transitions

INSERT IMAGE HERE

* Transitions displays multiple common graph styles in a fixed cycle.
* Field 1 - **Group** - This field represents categories on the Y axis or slices of proportional charts.
* Field 2 - **Datetime** - This field represents the X axis when applicable. It must be set to Group(Year & Month)
* Field 3 - **Metric** - This field represents the value.
* Notes:
* * You must sort Fields 1 and 2 to make coherent charts. If your charts look odd, make sure that the sorting behavior is correct.


##Tree

INSERT IMAGE HERE

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








