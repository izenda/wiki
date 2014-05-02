#Hiding Output Types

[[_TOC_]]

##Question

How do I Use the OutputTypes Collection?

##Answer

The OutputTypes collection is used to hold data representing the possible export formats that are available in Izenda AdHoc. This collection is most used to hide certain buttons on the report designer toolbar. In order to hide the output types that are located in the Report Designer, you would need to add the below line of code in your [[InitializeReporting()|/FAQ/InitializeReporting]] method.

```csharp
AdHocSettings.OutputTypes["xxx"].Hidden=true;
```

###Example

In order to hide OpenOffice from the export types in the ReportViewer you would add:

```csharp
 AdHocSettings.OutputTypes["ODT"].Hidden=true;
```

##Output type keys

Here is a list of the possible output types. Input the exact string below into the string parameter of the output type as is shown above.

* CSV
* PDF
* DOC
* XLS(MIME)
* SQL
* BULKCSV
* XML
* ODT
* RTF
* HTMLREPORT