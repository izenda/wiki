#SaveReportRDL

[[_TOC_]]

##About

Represents a method that saves an RDL format file to the server's filesystem.

Note: To specify the path that report RDL files will be saved to by default, use the [[AdHocSettings.RDLFolder|API/CodeSamples/RDLFolder]] setting.

##C# Example

```csharp
// Overrides the method of saving report in .rdl format
public override void SaveReportRDL(string reportName)
{
	// Get file path
	string rdlFilePath = "C:\\Reports\\RDL\\" + reportName + ".rdl";

	// Build rdl content
	StringBuilder builder = new StringBuilder();

	XmlTextWriter writer = new XmlTextWriter(new StringWriter(builder));
	Izenda.AdHoc.AdHocContext.CurrentReportSet.WriteRdl(writer);
	writer.Flush();
	// Write content to file
	File.WriteAllText( rdlFilePath, builder.ToString());
}
```

##VB.NET Example

```visualbasic
Public Overrides Sub SaveReportRDL(reportName As String)

    'Get file path
    Dim rdlFilePath As String = "C:\\Reports\\RDL\\" + reportName + ".rdl"

    'Build rdl content
    Dim builder As New StringBuilder()

    Dim writer As New XmlTextWriter((New StringWriter(builder)))
    Izenda.AdHoc.AdHocContext.CurrentReportSet.WriteRdl(writer)
    writer.Flush()
    'Write content to file
    File.WriteAllText(rdlFilePath, builder.ToString())
End Sub
```