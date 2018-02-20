#

[[_TOC_]]

##Question

How can I utilize Izenda's export process for CSV, PDF, or Excel in an application?

##Answer

The export process can be invoked by following the code template provided below. The result can be served back to the client computer, to a server filesystem, to a database, or to an email client depending upon the requirements. In the example below, the result is output to the server's filesystem using a directory called "exports" created two levels up from where the program is being executed.

##Using FileContentGenerator

```csharp
string message = string.Empty;
string outputPath = Path.GetFullPath(string.Format("{0}\\..\\..\\{1}", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "exports"));
if (!Directory.Exists(outputPath))
    Directory.CreateDirectory(outputPath);
foreach (string fileName in Directory.EnumerateFiles(AdHocSettings.ReportsPath))
{
    string reportName = fileName.Substring(fileName.LastIndexOf("\\"), fileName.LastIndexOf(".") - fileName.LastIndexOf("\\"));
    FileInfo fi = new FileInfo(fileName);
    ReportSet rs = ReportSet.InitializeNew();
    string reportXml = string.Empty;
    byte[] reportBytes = File.ReadAllBytes(fi.FullName);
    reportXml = Encoding.UTF8.GetString(reportBytes, 0, reportBytes.Length);
    try
    {
        rs.ReadXml(reportXml);
        rs.ReportName = reportName;
        Izenda.AdHoc.EvoPdfGenerator gen = new Izenda.AdHoc.EvoPdfGenerator();
        Izenda.Controls.FileContentGenerator fileGen = gen.GenerateOutput(rs) as Izenda.Controls.FileContentGenerator;
        File.WriteAllBytes(string.Format("{0}\\{1}.{2}", outputPath, fileGen.OutputFileName, gen.FileExtension), fileGen.Content);
        message = string.Format("File {0}.{1} written to {2}", fileGen.OutputFileName, gen.FileExtension, outputPath);
    }
    catch (Exception e)
    {
        message = e.Message;
    }
    Console.WriteLine(message);
}
```

There are also other classes that are accessible in the same manner and that inherit from the same interface. Simply replace the EvoPdfGenerator with the necessary class to export to different formats. These classes are defined as follows:

* CsvReportOutputGenerator
* BulkCsvReportOutputGenerator
* XmlReportOutputGenerator
* SqlReportOutputGenerator
* ITextSharpPdfGenerator (older PDF generator, not recommended)
* Html2PdfGenerator (for EO PDF)
* PhantomJSPdfGenerator (note that the PhantomJS.exe is required for this output type and must exist in the bin/phantomjs/ folder for web apps and ~/phantomjs folder for non-web apps)
* EvoAzurePdfGenerator (for Azure cloud services)

These classes exist in the Izenda.AdHoc namespace. FileContentGenerator exists in Izenda.Controls.