[[_TOC_]]

#Report Viewer 

All buttons in the Report Viewer are implemented in pure HTML. They all can be manipulated from Resources/html/ReportViewer-Body.ascx. To completely disable any button, simply remove it from the ascx file. If you wish to conditionally suppress a button, you can write conditional logic in your ascx to hide it based on your own custom logic.

##Report List Button 

![Report List Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/report-list.png)

The report list button is used to jump right into the report list. This is the code within the ReportViewer-Body.ascx that renders this button:
```html
<a class="btn" id="rlhref" href="ReportList.aspx" lang-title="js_Reportlist" title="Report list">
  <img class="icon" src="rs.aspx?image=ModernImages.report-list.png" lang-alt="js_Reportlist" alt="Report list" />
  <span class="hide" lang-text="js_Reportlist">Report list</span>
</a>
```

##Save Options

![Save Options](http://wiki.izenda.us/Guides/Toolbar-Buttons/save-options.png)

Clicking the downward facing triangle next to the save icon will reveal further save options; save and save as.

```html
<button type="button" class="btn" lang-title="js_Save" title="Save" id="btnSaveDirect" onclick="javascript:event.preventDefault();SaveReportSet();">
  <img class="icon" src="rs.aspx?image=ModernImages.floppy.png" lang-alt="js_Save" alt="Save" />
  <span class="hide" lang-text="js_Save">Save</span>
</button>

<button type="button" class="btn dropdown-toggle" data-toggle="dropdown">
  <span class="caret"></span>
</button>
```

###Save

![Save Options Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/save-32.png)
 
The save button simply saves the current report. 

```html
<li class="hide-readonly"><a href="javascript:void(0)" style="min-width: 18em;" onclick="javascript:SaveReportSet();">
  <img class="icon" src="rs.aspx?image=ModernImages.save-32.png" lang-alt="js_SaveChanges" alt="Save changes" />
  <b lang-text="js_Save">Save</b><br>
  <span lang-text="js_SaveChangesMessage">Save changes to the report for everyone it is shared with</span>
</a></li>
```

###Save As

![Save As Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/save-as-32.png)

This button allows a user to save the current report with a specific name. 

```html 
<li><a href="javascript:void(0)" onclick="javascript:ShowSaveAsDialog();">
  <img class="icon" src="rs.aspx?image=ModernImages.save-as-32.png" lang-alt="js_SaveACopy" alt="Save a copy" />
  <b lang-text="js_SaveAs">Save As</b><br>
  <span lang-text="js_SaveACopyMessage">Save a copy with a new name, keeping the original intact</span>
</a></li>

```

##Print Options

![Print Options Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/print-options.png)

Clicking the downward facing triangle next to the print icon will reveal further print options; HTML print and PDF print.

```html
<button type="button" class="btn" lang-title="js_Print" title="Print" onclick="responseServer.OpenUrl('rs.aspx?p=htmlreport&print=1', 'aspnetForm', '');">
  <img class="icon" src="rs.aspx?image=ModernImages.print.png" alt="Printer" />
  <span class="hide" lang-text="js_Print">Print</span>
</button>

<button type="button" class="btn dropdown-toggle" data-toggle="dropdown">
  <span class="caret"></span>
</button>
```

###HTML Print

![HTML Print Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/html-print.png)

This button allows for direct printing of a report from the browser. 

```html
<li><a href="javascript:void(0)" title="" style="min-width: 18em;" onclick="responseServer.OpenUrl('rs.aspx?p=htmlreport&print=1', 'aspnetForm', '');">
  <img class="icon" src="rs.aspx?image=ModernImages.print-32.png" alt="" />
  <b lang-text="js_PrintHTML">Print HTML</b><br>
  <span lang-text="js_PrintDirectlyMessage">Print directly from your browser, the fastest way for modern browsers</span>
</a></li>
```

###PDF Print

![PDF Print Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/pdf-print.png)

This button allows for printing of a report as a PDF file. 

```html
<li><a href="javascript:void(0)" title="" style="min-width: 18em;" onclick="responseServer.OpenUrl('rs.aspx?p=htmlreport&print=1', 'aspnetForm', '');">
  <img class="icon" src="rs.aspx?image=ModernImages.print-32.png" alt="" />
  <b lang-text="js_PrintHTML">Print HTML</b><br>
  <span lang-text="js_PrintDirectlyMessage">Print directly from your browser, the fastest way for modern browsers</span>
</a></li>
```

##Exports Button

![Exports Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/exports2.png)

Clicking the downward facing triangle next to the Exports icon will reveal further exporting options; Excel, Word, CSV, XML, and RTF.

```html
<button type="button" class="btn" title="Excel" onclick="responseServer.OpenUrlWithModalDialogNewCustomRsUrl('rs.aspx?output=XLS(MIME)', 'aspnetForm', 'reportFrame', nrvConfig.ResponseServerUrl);">
  <img class="icon" src="rs.aspx?image=ModernImages.excel.png" alt="Get Excel file" />
  <span class="hide" lang-text="js_ExportToExcel">Export to Excel</span>
</button>

<button type="button" class="btn dropdown-toggle" data-toggle="dropdown">
  <span class="caret"></span>
</button>
```

###Excel Button

![Excel Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/excel.png)

Clicking this causes the current report to be exported as an excel document. 

```html
<li><a href="javascript:void(0)" title="" style="min-width: 18em;" onclick="responseServer.OpenUrlWithModalDialogNewCustomRsUrl('rs.aspx?output=XLS(MIME)', 'aspnetForm', 'reportFrame', nrvConfig.ResponseServerUrl);">
  <img class="icon" src="rs.aspx?image=ModernImages.xls-32.png" alt="" />
  <b lang-text="js_ExportToExcel">Export to Excel</b><br>
  <span lang-text="js_ExportToExcelMessage">File for Microsoft's spreadsheet application</span>
</a></li>
```

###Word Button

![Word Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/word.png)

Clicking this causes the current report to be exported as a word document. 

```html
<li><a href="javascript:void(0)" title="" onclick="responseServer.OpenUrlWithModalDialogNewCustomRsUrl('rs.aspx?output=DOC', 'aspnetForm', 'reportFrame', nrvConfig.ResponseServerUrl);">
  <img class="icon" src="rs.aspx?image=ModernImages.word-32.png" alt="" />
  <b lang-text="js_WordDocument">Word document</b><br>
  <span lang-text="js_WordDocumentMessage">File for Microsoft's word processor, most widely-used office application</span>
</a></li>
```

###CSV Button

![CSV Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/csv.png)

Clicking this causes the current report to be exported in CSV format. 

```html
<li><a href="javascript:void(0)" title="" onclick="responseServer.OpenUrlWithModalDialogNewCustomRsUrl('rs.aspx?output=CSV', 'aspnetForm', 'reportFrame', nrvConfig.ResponseServerUrl);">
  <img class="icon" src="rs.aspx?image=ModernImages.csv-32.png" alt="" />
  <b lang-text="js_CSV">CSV</b><br>
  <span lang-text="js_CSVMessage">Stores tabular data in text file, that can be used in Google Docs</span>
</a></li>
```

###XML Button

![XML Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/xml.png)

Clicking this causes the current report to be exported in XML format. 

```html
<li><a href="javascript:void(0)" title="" onclick="responseServer.OpenUrlWithModalDialogNewCustomRsUrl('rs.aspx?output=XML', 'aspnetForm', 'reportFrame', nrvConfig.ResponseServerUrl);">
  <img class="icon" src="rs.aspx?image=ModernImages.xml-32.png" alt="" />
  <b lang-text="js_XML">XML</b><br>
  <span lang-text="js_XMLMessage">Both human-readable and machine-readable text file</span>
</a></li>
```

###RTF Button

![RTF Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/rtf.png)

Clicking this causes the current report to be exported in RTF format. 

```html
<li id="RTFExportButton"><a href="javascript:void(0)" title="" onclick="responseServer.OpenUrlWithModalDialogNewCustomRsUrl('rs.aspx?output=RTF', 'aspnetForm', 'reportFrame', nrvConfig.ResponseServerUrl);">
    <img class='icon' src="rs.aspx?image=ModernImages.rtf-32.png" alt="" />
    <b lang-text='js_RTF'>RTF</b><br>
    <span lang-text='js_RTFMessage'>File format for cross-platform document interchange</span>
  </a>
</li>
```

##Send Button

![Send Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/send.png)

Clicking this will send the current report via email.

```html
<div class="btn-group">
  <button type="button" class="btn" lang-title="js_SendReport" title="Send report" onclick="InitiateEmail();">
    <img class="icon" src="rs.aspx?image=ModernImages.mail.png" lang-alt="js_SendReport" alt="Send report" />
    <span class="hide" lang-text="js_SendReport">Send report</span>
  </button>
</div>  
```

##Results Per Page Button

![Results Per Page Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/results.png)

The results per page button set the numbers of results to be displayed on a single page. Clicking the dropdown next to the button allows the user to specify how many records per page they'd like to see.

```html
<button type="button" class="btn" lang-title="js_ResultsPerPage" title="Results per page" onclick="">
  <img class="icon" id="resNumImg" src="rs.aspx?image=ModernImages.rows-100.png" alt="Results per page" />
  <span class="hide" lang-text="js_ResultsPerPage">Results per page</span>
</button>

<button type="button" class="btn dropdown-toggle" data-toggle="dropdown">
  <span class="caret"></span>
</button>
```

The following is the code for the 5 record options provided by default.

```html
<ul class="dropdown-menu">
  <li onclick="ChangeTopRecords(1, true);" id="resNumLi0"><a href="javascript:void(0)" title="" style="min-width: 12em;">
    <img class="icon" src="rs.aspx?image=ModernImages.result-1-32.png" alt="" />
    <b lang-text="js_Result_1">1 Result</b><br />
    <span lang-text="js_Result_1_Message">Ideal for large forms</span>
  </a></li>
  <li onclick="ChangeTopRecords(10, true);" id="resNumLi1"><a href="javascript:void(0)" title="">
    <img class="icon" src="rs.aspx?image=ModernImages.results-10-32.png" alt="" />
    <b lang-text="js_Result_10">10 Results</b><br />
    <span lang-text="js_Result_10_Message">Good for single parameter reports</span>
  </a></li>
  <li onclick="ChangeTopRecords(100, true);" id="resNumLi2"><a href="javascript:void(0)" title="">
    <img class="icon" src="rs.aspx?image=ModernImages.results-100-32.png" alt="" />
    <b lang-text="js_Result_100">100 Results</b><br />
    <span lang-text="js_Result_100_Message">Default and recommended value</span>
  </a></li>
  <li onclick="ChangeTopRecords(1000, true);" id="resNumLi3"><a href="javascript:void(0)" title="">
    <img class="icon" src="rs.aspx?image=ModernImages.results-1000-32.png" alt="" />
    <b lang-text="js_Result_1000">1000 Results</b><br />
    <span lang-text="js_Result_1000_Message">Good for larger reports</span>
  </a></li>
  <li onclick="ChangeTopRecords(10000, true);" id="resNumLi5"><a href="javascript:void(0)" title="">
    <img class="icon" src="rs.aspx?image=ModernImages.results-10000-32.png" alt="" />
    <b lang-text="js_Result_10000">10000 Results</b><br />
    <span lang-text="js_Result_10000_Message">10000 Results</span>
  </a></li>     
  <li class="divider"></li>
  <li onclick="ChangeTopRecords(-1, true);" id="resNumLi4"><a href="javascript:void(0)" title="">
    <img class="icon" src="rs.aspx?image=ModernImages.results-all-32.png" alt="" />
    <b lang-text="js_Result_All">Show all results</b><br>
    <span lang-text="js_Result_All_Message">Use carefully as this may overload the browser</span>
  </a></li>
</ul>
```

##Open in Designer Button

![Results Per Page Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/designer.png)

This button allows a user to open the current report in the Report Designer. 

```html
<div class="btn-group">
  <button type="button" class="btn designer-only hide-locked hide-viewonly" lang-title="js_OpenInDesigner" title="Open in designer" id="designerBtn">
     <img class="icon" src="rs.aspx?image=ModernImages.design.png" lang-alt="js_OpenInDesigner" alt="Open in designer" />
     <span class="hide" lang-text="js_OpenInDesigner">Open in designer</span>
   </button>
</div>  
```

#Report Designer

Buttons and tabs in the Report Designer are controlled from within the core product. Manipulating these buttons and tabs requires the use of properties within the Global.asax.

##Buttons

###Report List

![Report List Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/reportlist.png)

The report list button is used to jump right into the report list. To disable the Report List button in the designer, you need to set the ReportList property to be empty or null. 

```csharp
AdHocSettings.ReportList = "";
```

###New

![New Report Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/new.png)

The New Report button begins designing a report from the beginning. To disable the New Report button in the designer, you need to set the ShowNewButton property to false.

```csharp
AdHocSettings.ShowNewButtons = false;
```

###Save

![Save Report Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/savedesigner.png)

The Save Report button saves the report you are currently designing. To disable it, you'll have to set the ShowSaveControls property to false. This will hide both Save and Save As.

```csharp
AdHocSettings.ShowSaveControls = false;
```

###Save As

![Save Report As Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/saveAsDesigner.png)

The Save Report As button allows the user to save the report they'll currently working on with a specified name. To disable it, set either ShowSaveAsToolbarButton or ShowSaveControls properties to false. The latter will disable both Save and Save As buttons. 

```csharp
AdHocSettings.ShowSaveAsToolbarButton = false;
```

###PDF Print

![PDF Print Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/pdfDesigner.png)

The PDF Print button will export a PDF version of the report being designed. To disable it, set ShowPDFButton to false.

```csharp
AdHocSettings.ShowPDFButton = false;
```
###HTML Print

![HTML Print Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/htmlPrint.png)

The HTML Print button allows a user to print the current report being designed. 

###Show SQL

![Show SQL Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/sql.gif)

The SQL button shows the generated SQL for the report being designed. To disable it, set ShowSqlOutputIcon to false.

```csharp
AdHocSettings.ShowSqlOutputIcon = false;
```

###CSV

![CSV Export Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/csvDesigner.gif)

THE CSV Export button causes the report being designed to be exported in csv format. To disable it, set ShowCSVButton to false.

```csharp
AdHocSettings.ShowCSVButton = false;
```

###Excel

![Excel Export Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/excelDesigner.gif)

The Excel Export button causes the report being designed to be exported in excel format. To disable it, set ShowXLSButton to false.

```csharp
AdHocSettings.ShowXLSButton = false;
```

###Word

![Doc Export Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/wordDesigner.gif)

The Doc Export button exports the report being designed in a .doc(MS Word) format. To disable it, set ShowDOCButton to false.

```csharp
AdHocSettings.ShowDOCButton = false;
```

###XML

![XML Export Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/xmlDesigner.gif)

The XML export button exports the report being designed as a .xml file.

###RTF

![RTF Export Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/rtfDesigner.gif)

The RTF export button exports the report being designed as a .rtf file. To disable it, set ShowRTFButton to false. 

```csharp
AdHocSettings.ShowRTFButton = false;
```

###Email

![Email Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/email.gif)

The email button allows the user to email the current report. To disable it, set ShowClientEmailButton to false.

```csharp
AdHocSettings.ShowClientEmailButton = false;
```

###Settings

![Settings Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/settings.gif)

The settings button takes the user to the Settings.aspx page. To disable it, set ShowSettingsButton to false.

```csharp
AdHocSettings.ShowSettingsButton = false;
```

###Results

![Results Per Page Dropdown](http://wiki.izenda.us/Guides/Toolbar-Buttons/resultsDesigner.png)

The Results dropdown allows the user to select how many records to display.

###Hide Help

![Show/Hide Help Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/help.gif)

The Hide Help button toggles the side help panel.TO disable it, set ShowHelpButton to false.

```csharp
AdHocSettings.ShowHelpButton = false;
```

##Tabs
 
###Data Sources

![Data Sources Tab](http://wiki.izenda.us/Guides/Toolbar-Buttons/dstab.png)

The Data Sources tabs allow report designers to add/remove data sources for a report. To disable it, set ShowDataSourcesTab to false.

```csharp
AdHocSettings.ShowDataSourcesTab = false;
```

###Fields 

![Fields Tab](http://wiki.izenda.us/Guides/Toolbar-Buttons/fields.png)

The fields tab allows the user to add or modify the fields reported on in a report, the functions used on them, the descriptions, and the formatting of the field through the report designer. To disable it, set ShowFieldsTab to false.

```csharp
AdHocSettings.ShowFieldsTab = false;
```

