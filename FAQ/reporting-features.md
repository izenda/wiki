#11.0 Toolbar and Preview

[[_TOC_]]

##About

The toolbar is where report designers can see how their reports will look, save and create reports, and get technical readings of the report before the report is published for view. Many of its features can be turned on or off via the [[AdHocSettings|/API/AdHocSettings]] class properties.

The preview tab is where report designers will see how their report is generated and what it will appear like visually in the report viewer before publishing it. Report designers may freely explore the various settings easily because of this.

**The report designer's toolbar**

![Toolbar]()

The table below describes the functions of the toolbar buttons

|**Icon**|**Fuction**|**Description**|
|:------:|:---------:|:-------------:|
||Back|Goes to the browser’s previous page.|
||Report List|Takes you back to the report list page.|
||New|Creates a new report.|
||Save|Saves a report.|
||Save As|Allows a new report name to be saved.|
||Print (PDF Export)|Saves the report as a PDF document.|
||Print (HTML)||
||IE/FF|Runs the report in the web browser.|
||Publish RDL||
||Schema|Display database diagram.|
||SQL|Views the report in SQL mode.|
||Bulk CSV||
||CSV|Saves the report as a CSV file.|
||Excel Spread sheet|Saves the report as a MS-EXCEL file.|
||Word Document|Saves the report as a MS-Word document.|
||XML document|Saves the report as a XML document.|
||RTF document|Saves the report as a RTF document.|
||Open office document|Saves the report as an Open Office Document.|
||Show RDL||
||Server E-mail|E-mails a report from the server.|
||E-mail|E-mails a report to from a client.|
||Settings|Takes you to Settings.aspx page.|
||Results||

##11.1 Modifying the Toolbar Through the API

The toolbar represents a set of controls (mainly buttons) that allow users quick access to various reporting features while designing a report. The AdHoc platform provides a set of classes that allows you to construct a completely customized toolbar for the report designer. You can get a list of all the report designer buttons [[at this FAQ page|http://wiki.izenda.us/FAQ/Hiding-Buttons-and-Tabs#Report-Designer-Buttons]].

_**Note:** Before version 6.7, these settings also applied to the Report Viewer, Dashboard Designer, and Dashboard Viewer._