#10.0 Style Tab

[[_TOC_]]

##About

The style tab is where you can customize the look and feel of your report. You can also change the color of the border, header, and rows, as well as the order of the report items. We will go over the controls in detail here and how you can use them to maximize the effectiveness of your reports.

![The Style Tab](http://wiki.izenda.us/Guides/ReportDesign/10-dot-0-Style-tab/style-tab.png)

##10.1 Style Properties

There are six separate controls that you can use to select the colors used for various elements on your report. You can see the results of your changes in the sample grid that is displayed directly below the dropdown menus.

The colors that can be changed are: Border color, Header color, Header foreground color, Item color, Item foreground color, and Alternating item color.

![Sample Grid and color dropdowns]()

Explanations of these features are given below:

|**Feature**|**Description**|
|:---------:|:-------------:|
|Border Color|Affects the color of the border surrounding your grid cells|
|Header Color|Affects the background color of the report header columns. If you use [[visual grouping|http://wiki.izenda.us/Guides/ReportDesign/4.0-fields-tab#4.3-Sort,-VG,-&-Arithmetic-Check-Boxes]], this affects all header columns in each visual group.|
|Header Foreground Color|Affects the text color of every header column in your report.|
|Item Color|Affects the background color of the odd numbered report items.|
|Item Foreground Color|Affects the text color of all report items.|
|Alternating Item Color|Affects the background color of the even numbered report items.|
|Restore Default|Reverts all of the previously mentioned controls' settings back to their defaults.|
|CSS|You can define any custom CSS to be used on this report inside the text box. You can use the browser object inspector to discern CSS class names used on the grid so you can override them.|
|Landscape Printing|When checked, this will cause reports printed from the report viewer to be printed in landscape mode. Otherwise they will be printed in portrait mode.|
|Show Page Number|When checked, this will display the page number on all page-dependent printed reports. This will not apply to the report viewer or to XML, XLS, and CSV exports.|
|Show Date and Time|When checked, this will display the date and time on all page-dependent printed reports. This will not apply to the report viewer or to XML, XLS, and CSV exports.|
|Use Pagination in Web View|Sets whether the report viewer will use paging.|
|Add Bookmark for Each Visual Group|Sets whether bookmarks will be used on each visual group. Applies only to PDF exports.|
|Page Break After Visual Groups|Sets whether each visual group will receive its own page when exported. This will not apply to XML, XLS, or CSV exports.|
|Minimize Grid Width|Adjusts the margins of the data grid to match the size of the data. This can result in columns that are not uniform size.|
|Visual Group Style|Sets how visual groupings will be displayed. [[See more|]].|
|Items Per Page|Allows a user to set the number of items shown per page in the report viewer.|
|Report Order|Allows the user to set the order of items included in the report (Summary, Chart, Gauge, Map, Detail). The detail grid is the one created on the Fields tab.
|Field&#124;Value Column Pairs|Allows the user to set the field value style for multiple columns displaying on one row. [[See an example|http://www.izenda.com/bi/ReportDesigner.aspx?rn=Accounting]].|
|Show Main Report in Field&#124;Value Style|Allows a user to set whether the entire detail grid will be shown using the field value style defined above.|
|Show Summary Report in Field&#124;Value Style|Allows a user to set whether the summary grid uses the field value style defined above.|

##10.2 Changing Colors Through CSS

You can get a complete overview of the process for using custom CSS styles on the report desinger from [[this tutorial|http://wiki.izenda.us/FAQ/Questions/Overriding-page-level-css#Report-Designer]].

###10.2.1 Customer Integration Example

Here is an example of one solution that used customized CSS in order to more fully integrate Izenda into the hosting application.

![](/Guides/ReportDesign/10.0-Style-tab/customer_example.png)
