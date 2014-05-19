#Audit Report Access & Exports

[[_TOC_]]

##Question

How can I set up auditing so that whenever a user accesses or exports report data, an audit is performed?

##Answer

One way of doing this is to use the PreExecuteReportSet in your global.asax file. Every time a user clicks on print or exports, it fires a query. You would need to write the custom code in the PreExecuteReportSet method utilizing the querystring which contains the report name and output. You could then pass that data to a table in your database including the username, time, etc.

##C♯ FileSystemAdHocConfig Example

```csharp
public override void PreExecuteReportSet(ReportSet reportSet) {      
    Guid g = Guid.NewGuid();
    XElement audit = new XElement("Audit", 
        new XElement("AuditID", g.ToString()),
        new XElement("Name", AdHocSettings.CurrentUserName),
        new XElement("ReportName", reportSet.ReportName),
        new XElement("DateAccessed", DateTime.Now.ToString()));
    if (!Directory.Exists("C:\\Reports\\Audits\\" + DateTime.Now.ToShortDateString().Replace("/", "-"))) {
        Directory.CreateDirectory("C:\\Reports\\Audits\\" + DateTime.Now.ToShortDateString().Replace("/", "-"));
    }
    File.WriteAllText("C:\\Reports\\Audits\\" + DateTime.Now.ToShortDateString().Replace("/", "-") + "\\" + g.ToString() + ".log", audit.ToString(), Encoding.UTF8);
    base.PreExecuteReportSet(reportSet);
}
```

##VB.NET FileSystemAdHocConfig Example

```visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As ReportSet)
  Dim g As Guid = Guid.NewGuid()
  Dim audit As XElement = New XElement("Audit", _
    New XElement("AuditID", g.ToString()), _
    New XElement("Name", AdHocSettings.CurrentUserName), _
    New XElement("ReportName", reportSet.ReportName), _
    New XElement("DateAccessed", DateTime.Now.ToString()))
  If Not Directory.Exists("C:\\Reports\\Audits\\" + DateTime.Now.ToShortDateString().Replace("/", "-")) Then
    Directory.CreateDirectory("C:\\Reports\\Audits\\" + DateTime.Now.ToShortDateString().Replace("/", "-"))
  End If
  File.WriteAllText("C:\\Reports\\Audits\\" + DateTime.Now.ToShortDateString().Replace("/", "-") + "\\" + g.ToString() + ".log", audit.ToString(), Encoding.UTF8)
  MyBase.PreExecuteReportSet(reportSet)
End Sub
```

_**Note:** For this example, you will need to use a version of the .NET framework that uses ``System.Xml.Linq``_