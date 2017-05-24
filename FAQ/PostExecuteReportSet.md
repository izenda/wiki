#PostExecuteReportSet

[[_TOC_]]

##About

Represents a method that allows operations to be performed after executing a ReportSet and before displaying it to the screen.

##C♯ Example

```csharp

public override void PostExecuteReportSet(ReportSet reportSet)
{
    File.WriteAllText(string.Format("C:\\Backup\\Reports\\{0}\\{1}.xml", reportSet.ReportCategory, reportSet.ReportName), reportSet.WriteXml());
}
```

##VB.NET Example

```visualbasic
Public Overrides Sub PostExecuteReportSet(reportSet As ReportSet)
    File.WriteAllText(String.Format("C:\\Backup\\Reports\\{0}\\{1}.xml", reportSet.ReportCategory, reportSet.ReportName), reportSet.WriteXml())
End Sub
```