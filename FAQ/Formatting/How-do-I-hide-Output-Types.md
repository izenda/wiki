#How do I hide Output Types?

[[_TOC_]]

##Hiding Output Types

In order the hide the output types THAT are located in the ReportViewer, you would need to add the below line of code in your ConfigureSettings().

```csharp
AdHocSettings.OutputTypes["xxx"].Hidden=true;
```

###Example

In order to hide OpenOffice from the export types in the ReportViewer you would add:

```csharp
 AdHocSettings.OutputTypes["ODT"].Hidden=true;
```

Other formats that are also available to be hidden are sql, pdf, csv, bulkcsv, xls, doc, xml and rtf.