#Advanced Field Settings

[[_TOC_]]

##Introduction

Advanced field settings provide more granular control over what data is displayed in your report. They can be accessed by clicking on the gear icon to the right of any row on the [fields tab](http://wiki.izenda.us/FAQ/Introduction#Fields-tab) or the [summary tab](http://wiki.izenda.us/FAQ/Introduction#Summary-tab) in the report designer. There are a number of options that can be selected here.

##Advanced Settings

* **Column group:** Allows you to define column groups for your report. Any columns with the same column group will be displayed together under the title given by the input text.
* **Hide this field:** Allows a field to be hidden in the report but still used to perform calculations and associated to other data.
* **Sort (z-a):** Reverses the sort order of the report from Z-A.
* **Italic:** Displays all data in this field as italic.
* **Bold:** Displays all data in this field as bold.
* **Width:** Allows you to define a custom field width for your data.
* **Label Justification:** Sets the column's header justification to either L, R, or M.
* **Value Justification:** Sets the column's data justification to L, R, M, or none.
* **Subreport:** Allows you to define a sub-report to use based on this field. More about [[subreports]].
* **Drill-Down Style:** Allows you to choose how the sub-report will be displayed.
* **Url:** Allows you to define a url to navigate to.
* **Subtotal Function:** Allows you to create a sub-total line for individual fields using the selected function.
* **Gradient Cells Shading:** Allows you to use a gradient (smooth color transition) effect within your report cells using the Item Color and the Alternating Item Color found on the [Style tab](http://wiki.izenda.us/FAQ/Introduction#Style-tab).
* **Text Highlight:** Alters the color of the text in the cells of the selected field based on the format given. (e.g. 1 to 10:green; 11 to 50:yellow;51 to 100:red)
* **Cell Highlight:** Highlights the entire cell of the selected field based on the format given. (see example above)
* **Value Ranges:** Allows you to define a substitute for ranges of values you define (e.g. 0 to 10:Under 10;10 to 100: 10-100)
* **Expression:** Allows you to use mathematical expressions and conditionals for your selected field if the existing controls do not provide you the level of control you desire. This is formatted as an SQL statement and can accept database column names.

*Note: These settings are available for both the fields tab and filters tab in the report designer.*