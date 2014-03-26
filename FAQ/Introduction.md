#Introduction

[[_TOC_]]

We are continually developing online Izenda Reports training materials focused on the needs of novice users. The materials will include a basic overview of building reports which utilize bar, pie, and trend charts as well as some advanced topics. These materials include both video and printable formats.

All training materials are available on the Izenda Reports site at no charge. The presentations and lessons assume the availability of a working copy of Izenda Reports connected to a database containing both text and numerical data. You may print and re-distribute these materials to any users within the organization or company that licenses Izenda Reports. 

###Report Designer

The training walks through the features available in the various tabs of the Izenda Report Designer in order to familiarize the users with the options available: 
#### Datasources tab:
    Here you can select the data sources (tables and views) to use in your report.  There are two ways to view this.
    * **Basic:** The basic view of the data sources tab will let you choose from a list of recent data sources or choose one data source from a list.
    * **Advanced:** This view will let you choose any number of data sources and define their relationships. This acts as an SQL join would.
* **Field tab:**
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
* **Summary tab:**
    Here you can define a new set of data separate from the field list you selected that can act as a synopsis of your data. It is displayed above the table you defined on the Fields tab on the report viewer. Identical to the fields tab with a few exceptions.
    * No visual grouping (VG checkbox)
    * No arithmetic checkbox
    * **Show Deltas:** shows the changes in your data as a percentage (handy for quarterly report summaries)
* **Chart tab:**
    You can define a [chart](http://www.izenda.com/bi/ReportViewer.aspx?rn=Accounting) to use here from a list of Izenda-supported charts. Selecting a chart will update the settings form directly below, which can be filled out with labels and other options. The standard ones include:
    * **Title:** What the chart will be called. Displayed in bold above the chart
    * **Records:** 
    * **Target report:** 
* **Gauge tab:** 
    Applies a gauge control to your report that can give useful information about min/average/max load capacity and other magnitude-based data [Example](http://www.izenda.com/bi/ReportViewer.aspx?rn=Human+Resources)
    * 
* **Misc tab:**
    *
* **Style tab:**

* **Filters Tab:**

* **Pivots Feature:**

The training lessons focus on creating reports with these features: 
[[Lesson 1: The Basics]]
[[Lesson 2: Trend Charts]]
[[Lesson 3: Bar Charts]]
[[Lesson 4: Pie Charts]]
[[Lesson 5: Advanced Charting & Analysis]]
[[Lesson 6: Pivot Feature Steps]]
* [[Contacting Microsoft]]
* [[Setting Up a Branded Izenda Demo in 15 Minutes]]