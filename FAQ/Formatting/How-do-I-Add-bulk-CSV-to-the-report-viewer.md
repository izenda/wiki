#Adding Bulk CSV On the Report Viewer

[[_TOC_]]

##Question

How do I Add the Bulk CSV option to the Report Viewer and Report Designer?

##Answer

Newer versions of Izenda have diverged the Report Viewer from the Report Designer methodology of showing this button. One methodology for the Report Viewer is demonstrated below, but this is not an absolute edict.

###Report Viewer

The report viewer page is all contained in Resources/html/ReportViewer-Body.ascx and is completely editable within any standard text editor. Therefore, you can use any HTML you want as long as you call the following javascript function:

```javascript
responseServer.OpenUrlWithModalDialogNew, 'rs.aspx?output=BULKCSV', 'aspnetForm', 'reportFrame');
```

Here is an example HTML snippet to insert a new item into an unordered list (can be used on ReportViewer)

```html
<li><a href="javascript:void(0)" title=""
  onclick="responseServer.OpenUrlWithModalDialogNew, 'rs.aspx?output=BULKCSV', 'aspnetForm', 'reportFrame');">
  <img class="icon" src="rs.aspx?image=ModernImages.csv-32.png" alt="" />
  <b lang-text="js_CSV">Bulk CSV</b><br>
  <span lang-text="js_CSVMessage">Stores large batches of tabular data in a text file that is portable and easy to process</span>
</a></li>
```

###Report Designer

This code will show how to show the bulk csv option on the Report Designer.

```csharp
//show (unhide) the option for bulk csv
AdHocSettings.OutputTypes["BULKCSV"].Hidden = false;

//hide the option for csv
AdHocSettings.OutputTypes["CSV"].Hidden = true;

```

###String keys for other output types

The string keys which are available are:

* csv
* pdf
* doc
* xls
* sql
* bulkcsv
* xml
* odt (open office)
* rtf

##Troubleshooting the Bulk CSV Option

The Bulk CSV option is for exporting large amounts of data and is inherently dependent on your server's ability to process the data. If you are getting an **Out of memory exception**, the bulk CSV option may not be right for your application. 

If you want to test the bulk CSV export option to see if it's correct for you, follow the steps below.

* Open a larger report in the Report Viewer
* Append the string "&output=bulkcsv" onto the URL (e.g. http://www.izenda.com/bi/ReportViewer.aspx?rn=Budget&output=bulkcsv)
* Press enter to export the report as a bulk csv file