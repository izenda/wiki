#PostLoadReportSet

[[_TOC_]]

##About

Represents a method that allows operations to be performed after loading the specified report. This method must be overridden if it is to be used and has no default behavior.

##C# Example

```csharp
public override void PostLoadReportSet(string name, ReportSet reportSet)
{
    File.WriteAllText(string.Format("C:\\Backup\\Reports\\{0}\\{1}.xml", reportSet.ReportCategory, reportSet.ReportName), reportSet.WriteXml());
}
```

##VB.NET Example

```visualbasic
Public Overrides Sub PostLoadReportSet(name As String, reportSet As ReportSet)
    File.WriteAllText(String.Format("C:\\Backup\\Reports\\{0}\\{1}.xml", reportSet.ReportCategory, reportSet.ReportName), reportSet.WriteXml())
End Sub
```