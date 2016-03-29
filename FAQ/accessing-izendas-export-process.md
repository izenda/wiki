#

[[_TOC_]]

##Question

How can I utilize Izenda's export process for CSV, PDF, or Excel in an application?

##Answer

The export process can be invoked by following the code template provided below. The result can be served back to the client computer, to a server filesystem, to a database, or to an email client depending upon the requirements. In the example below, the result is output to the server's filesystem using a directory called "exports" created two levels up from where the program is being executed.

##Using FileContentGenerator

```csharp
string outputPath = Path.GetFullPath(string.Format("{0}\\..\\..\\{1}", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "exports"));
if (!Directory.Exists(outputPath))
    Directory.CreateDirectory(outputPath);
foreach (string fileName in Directory.EnumerateFiles(AdHocSettings.ReportsPath))
{
    reportName = fileName.Substring(fileName.LastIndexOf("\\"), fileName.LastIndexOf(".") - fileName.LastIndexOf("\\"));
    FileInfo fi = new FileInfo(fileName);
    ReportSet rs = ReportSet.InitializeNew();
    string reportXml = string.Empty;
    byte[] reportBytes = File.ReadAllBytes(fi.FullName);
    reportXml = Encoding.UTF8.GetString(reportBytes, 0, reportBytes.Length);
    try
    {
        rs.ReadXml(reportXml);
        Izenda.Controls.Html2PdfGenerator gen = new Izenda.Controls.Html2PdfGenerator();
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

There are also other classes that are accessible in the same manner and that inherit from the same interface. Simply replace the Html2PdfGenerator with the necessary class to export to different formats. These classes are defined as follows:

* CsvReportOutputGenerator
* BulkCsvReportOutputGenerator
* XmlReportOutputGenerator
* ITextSharpPdfGenerator (The Html2PdfGenerator uses EO)
* SqlReportOutputGenerator