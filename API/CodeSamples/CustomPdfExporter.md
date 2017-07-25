#Code Sample: Custom PDF Exporter

```csharp
using Izenda.Controls;
using Izenda.AdHoc;
using System;

public class CustomPdfGenerator : PdfGeneratorBase
{
    public override IContentGenerator GenerateOutput(ReportSet reportSet)
    {
        string html = PrepareReportSetHtml(reportSet, true, true);
        byte[] fileContents = null;
        try
        {
            fileContents = CustomExport(html, reportSet);
        }
        catch (Exception ex)
        {
            Debug.Write(string.Format("CustomPdfGenerator::GenerateOutput {0}", ex.Message));
        }
        return new FileContentGenerator(Guid.NewGuid().ToString(), fileContents, GetOutputFileName(reportSet.ReportNameSafe),
            Utility.GetMIMEType(FileExtension.ToUpper()));
    }

    private byte[] CustomExport(string html, ReportSet reportSet)
    {
        //perform custom logic here
        return new byte[0];
    }
}
```

```visualbasic
Imports Izenda.Controls
Imports Izenda.AdHoc
Imports System

Public Class CustomPdfGenerator
    Inherits PdfGeneratorBase
    Public Overrides Function GenerateOutput(ByVal reportSet As ReportSet) As IContentGenerator
        Dim html As String = PrepareReportSetHtml(reportSet, True, True)
        Dim fileContents As Byte() = Nothing
        Try
            fileContents = CustomExport(html, reportSet)
        Catch ex As Exception
            Debug.Write(String.Format("CustomPdfGenerator::GenerateOutput {0}", ex.Message))
        End Try
        Return New FileContentGenerator(Guid.NewGuid().ToString(), fileContents, GetOutputFileName(reportSet.ReportNameSafe),
        Utility.GetMIMEType(FileExtension.ToUpper()))
    End Function

    Private Function CustomExport(ByVal html As String, ByVal reportSet As ReportSet) As Byte()
        'perform custom logic here
        Return New Byte() {}
    End Function
End Class
```