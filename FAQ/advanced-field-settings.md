#Advanced Field Settings

[[_TOC_]]

##Introduction

Advanced field settings provide more granular control over what data is displayed in your report. They can be accessed by clicking on the gear icon to the right of any row on the [[fields tab|/Guides/ReportDesign/4.0-fields-tab]] or the [[summary tab|/Guides/ReportDesign/6.0-Summary-Tab]] in the report designer. There are a number of options that can be selected here.

##Advanced Settings

![](/FAQ/advanced-field-settings/advanced_settings_panel_042115.PNG)

|**Setting Name**|**Description**|
|:--------------:|:-------------:|
|Column Group|Applies a label to this column that can work over multiple consecutive columns. Any other column that shares the same label will be included in the grouping. <br> ![](/FAQ/advanced-field-settings/column_groups.png)|
|Page Break After Field|If 'Page Break After Field' box is checked and this field is also a visual group, then it will trigger a page break in a printed report every time this field has different value.|
|Multiline Header|'Multiline Header' allows a header to be multi-lined if the length of the header is longer than set width of the column. Each space between words works as a line breaker| 
|Hide this field|Hides the field from display when report the is ran. Useful for using expressions on multiple fields but when only one of the fields should be displayed.|
|Sort (z-a)|Sorts in descending order|
|Italic|Sets whether the column is shown in italics|
|Bold|Sets whether the column is shown in bold|
|Width|Set the width of the column in number of pixels|
|Label Justication|Sets the Column label to the left, right, or middle of the row|
|Value Justication|Sets the Value of the field to the left, right, or middle of the row|
|Subreport|Sets the drill-down child report. The list contains only reports that have a [[drill-down key|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab#9.2.2-Setting-the-drill-down-key]] set for them.<br>_**Note:** The "Automatic" option will attempt to choose a sub-report by matching the drill-down key to the selected field and cannot discern between two sub-reports that use the same drill-down key._|
|Drill-Down Style|**Link** – opens in same browser window <br>**Link (New Window)** – opens in new browser window<br>**Embedded** – embeds the drill-down results into the main report<br>**Popup** – opens the results on a pop-up screen<br>**Hover** - Shows the sub-report when you hover the mouse over the item that the sub-report is linked to<br>**ComboKey** - Used in combination with one of the above. When this setting is chosen for the second drilldown key, the value of both fields will be passed from the main report to the sub-report.<br>[[Click here for more information.|http://wiki.izenda.us/FAQ/Questions/sub-reports-and-drilldowns]]|
|Url|Allows you to define a custom Url to redirect to when the value in this cell is clicked. [You can set whether this url opens in the current tab or a new tab.](http://wiki.izenda.us/API/CodeSamples/OpenCustomUrlInNewWindow)|
|SubTotal Function|Sets a customized function for subtotals displayed with this field. The default value is "Sum". This only applies to the bottom sub-totals and not the side sub-totals.|
|Gradient Cells Shading|Sets whether cells will use a gradient or solid colors for shading. The larger the value in the cell is, the darker the shading will become.|
|Text Highlight|Highlights the text for a given range. You can refer to the [[Styles tab|http://wiki.izenda.us/Guides/ReportDesign/10.0-Style-tab]] for a list of valid colors. Example: "5 to 6:Blue;7 to 10:Red".|
|Cell Highlight|Highlights the entire cell for a given range. This follows the same rules as text highlight.|
|Value Ranges|Lets you set text values for number ranges. (i.e. setting this to 0 to 10:Under will display the text "Under" when it encounters a value between 0 and 10 for that column).|
|Expression|Allows you to define a customized mathematical or SQL expression to show as the value for the column cells. See more about [[Expressions|http://wiki.izenda.us/Guides/ReportDesign/15.0-Expressions-in-Izenda]]|
|Expression Type|Allows you to specify the data type of this field. This is most useful when| you are generating output with an expression and need to specify a data type.|
|Group By Expression|If checked, this field will be included in the group by statement of the query. This is functionally the same as the Group function, except applicable to expression output within a field rather than to the field itself.|