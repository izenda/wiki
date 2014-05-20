#Dynamically Changing the Report Title

##Question

Can I change the report title dynamically?

##Answer

Yes, the report attributes can be changed in the PreExecuteReportSet method, most of the attributes for a report are available there.  To change the title of the report dynamically add this to the Global.asax PreExecuteReportSet:

```csharp
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
{
  reportSet.Title = "Some Title";
}//end PreExecute
```

This method executes when a report is created to be exported or viewed. At this point, the xml from the actual report file has been parsed and loaded, so changes made here will not be permanent. 