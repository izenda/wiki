#Exporting Blank Columns
[[_TOC_]]

##Purpose

You can create reports that have a blank column in them using Izenda Reports. The benefit of blank columns is readability and ease of use, especially with CSV exports.

##Example

Here is the CSV output of a report that has one blank column:

![Export with a blank column](http://wiki.izenda.us/Guides/Developer-Links-and-Guides/blank-column-csv.png)

##Implementation

To add a blank column to your export, you simply have to set the Description of the field in the Fields Tab to "BLANK", then click on the gear icon to the far right of the field and set the Expression to ''.

![Export with a blank column](http://wiki.izenda.us/Guides/Developer-Links-and-Guides/Blank-Column.png)
