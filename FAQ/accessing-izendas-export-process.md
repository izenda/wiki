#

[[_TOC_]]

##Question

How can I utilize Izenda's export process for CSV, PDF, or Excel in an application?

##Answer

There are multiple methods to use Izenda's export process in your own application for any export format supported by Izenda. Please refer to the code samples below for examples.

###Method 1: ReportRenderer method

```csharp
foreach (string fileName in Directory.EnumerateFiles(AdHocSettings.ReportsPath))
{
    reportName = fileName.Substring(fileName.LastIndexOf("\\") + 1, fileName.LastIndexOf(".") - fileName.LastIndexOf("\\") - 1);
    try
    {
        ReportRenderer repRndr = new ReportRenderer();
        byte[] export = repRndr.ExportReportSet(reportName, "PDF");
        File.WriteAllBytes(string.Format("{0}\\{1}.{2}", outputPath, reportName, "PDF"), export);
    }
    catch (Exception e)
    {
        message = e.Message;
    }
    Console.Write(message);
}
```

In order to do this with DatabaseAdHocConfig mode, use a data adapter matching your database system's architecture to access the reports within the table that contains the reports. Just having the report names will enable the system to load the reports and their data.

_*Note:* For PDF exports, this method uses iTextSharp explicitly instead of being dependent upon the [[PdfPrintMode|/API/CodeSamples/PdfPrintMode]] setting._

##Method 2: FileContentGenerator method

```csharp
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
        Html2PdfGenerator gen = new Html2PdfGenerator();
        FileContentGenerator fileGen = gen.GenerateOutput(rs) as FileContentGenerator;
        File.WriteAllBytes(string.Format("{0}\\{1}.{2}", outputPath, fileGen.OutputFileName, "PDF"), fileGen.Content);
        message = string.Format("File {0}.pdf written to {1}", fileGen.OutputFileName, outputPath);
    }
    catch (Exception e)
    {
        message = e.Message;
    }
}

This method provides a bit better control over the process, since it works with the explicitly defined .NET types within the Izenda framework. The previous method requires knowledge of the specific output type codes used and only works with iTextSharp as the PDF export.

Both methods can have their output file saved anywhere on the server that the code has access to, on a database, sent via email, etc. 