#How do I Add bulk CSV to the report viewer

[[_TOC_]]

This code will show the bulk csv option export type in the Report Viewer.

```csharp
//show (unhide) the option for bulk csv

AdHocSettings.OutputTypes["BULKCSV"].Hidden = false;

//hide the option for csv

AdHocSettings.OutputTypes["CSV"].Hidden = true;

```

##String keys for other output types

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