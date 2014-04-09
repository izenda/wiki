[[_TOC_]]

##Purpose

Adding a blank column on export is a great way to ensure that a CSV export of your report is more readable and easier to work with. 

##Example

Here is the CSV output of a report that has blanked out one column:

![Export with a blank column](http://wiki.izenda.us/Guides/Developer-Links-and-Guides/blank-column-csv.png)

##Implementation

To add a blank column to your export, you simply have to set the Description of the field in the Fields Tab to "BLANK".

![Export with a blank column](http://wiki.izenda.us/Guides/Developer-Links-and-Guides/Blank-Column.png)

You'll also need to click on the gear icon to the far right of the field and set the Expression to ''.