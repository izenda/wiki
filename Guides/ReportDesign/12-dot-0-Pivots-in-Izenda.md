#12.0 Pivots

[[_TOC_]]

##About

The Izenda reports Pivot feature allows users to generate analytical data grids from within Izenda reports. The Pivot feature essentially adds extra pivot columns to the right side of the report. This is useful for comparing data over multiple categorical dimensions. 

Below is an example of the Design and Output of a standard Pivot View of the Average Amount Spent on Freight. 

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/pivots_section.png)

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/pivot_results_1.png)

##12.1 Create a Simple Pivot Report

1. Click on the **Data Sources** tab and select desired data sources. (Ex. Orders)
2. Click on the **Fields** tab.  Select the desired Field(s) names & attributes (Sorting, VG, Function, & Format) for the report. (Ex. ShipCountry) 

Before Pivot: 

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/ship_column_field_example.png)

Create pivot view on above report:

1. At the bottom of the **Fields** tab, click the **Add Pivot** button.
2. Select the **Add pivot columns for** dropdown.  Select the field you wish to display across the top of the pivot view (Ex. OrderDate).  Next, select the function type from drop down (Ex. Group(Year)). This will group the data by the selected function.
3. Select the **Calculate cell values on** dropdown.  Select the field you wish to display the calculated result for (Ex. Freight).  Next, select the function & format types from the drop downs (ex. Average & $0.00).  This field's data will also populate the rows within the pivot view.
4. Optional:  Select the "Add subtotals" option to show the sum of each pivot column at the bottom of the report.
5. Click Preview
After Pivot: 

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/pivots_section.png)

Essentially, the pivot capability adds additional columns based on the data to the right of the report. In this example, the first column is essentially a standard report and the 2010, 2011, 2012 columns were added by the pivot capability.

Standard Report View:

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/pivot_results_2.png)

Columns added by Pivot:

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/pivot_results_3.png)

##12.2 Create an Advanced Pivot Report 

Let's use these concepts to develop a more sophisticated report that shows us a monthly time-series report for each country visually grouped by employee. 

In this report, we want to show the Top 5 companies that accounted for the most freight in 2011 and breakdown the analysis by month. 

Here is what the design screen would look like for this report. 

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/pivot_example_1.png)

Here's how we add the non-pivot fields.  

1. We started off by using the same Data Source for the previous report, Orders.  
2. We then Select the Fields, grouping by ShipCountry, and Summing the Freight.  
3. Next, we check the Subtotals box to give us a summary line for each country. 
4. Then, we click on the advanced icon for the Freight field, sorting from Z-A to list the highest values first. 
5. After that, we selected 5 Records in the top left to show the 5 countries with the largest freight amount. 

For the pivot portion of the report, we: 

1. Select the OrderDate at the Pivot column and Year & MN as the way it will be displayed. 
2. Select Freight as what we will measure in our pivot, performing a sum for each column.  
The final step is to add the filter to make it calculate the results from only 2011 data.  

Finally, here are the results of the report with Pivot: 

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/pivot_group_year_&_mn.png)

To make the report more consumable, you might also want to add highlighting to show the months with lows values. 

For this, click on the [[Advanced Field Settings icon|http://wiki.izenda.us/Guides/ReportDesign/4.0-fields-tab#4.8-Advanced-Field-Settings-Button]] on the pivot field where you are calculating cell values on.

Then, set the Cell Highlight to 0 to 50: Red.

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/advanced_pivots_box.png)

Here is the result: 

![](/Guides/ReportDesign/12-dot-0-Pivots-in-Izenda/pivot_with_highlighting.png)

