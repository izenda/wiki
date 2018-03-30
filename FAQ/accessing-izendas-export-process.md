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
foreach (ReportSet rs in AdHocSettings.AdHocConfig.FilteredListReportsDictionary().Values) //output all available reports
{
    try
    {
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

##Bulk CSV Output Generator

The bulk CSV output generator functions differently from other content generators. It is specifically made for large datasets, so instead of using the in-process memory to hold its content, a temporary file is created and a file id is generated that the response server can use to read that file into the HTTP response that is then delivered to the end user. There are a couple different ways to obtain the file and output a new copy to another location other than the temp directory. The sample code below will demonstrate one such method by finding the temp file directly, reading it into a stream, copying the stream to another output stream, and finally creating another file that will be the final exported file. We will also use chunking so we don't run into any out of memory exceptions.

```csharp
string message = string.Empty;
string outputPath = Path.GetFullPath(string.Format("{0}\\..\\..\\{1}", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "exports"));
if (!Directory.Exists(outputPath))
    Directory.CreateDirectory(outputPath);
foreach (ReportSet rs in AdHocSettings.AdHocConfig.FilteredListReportsDictionary().Values) //output all available reports
{
    try
    {
        var gen = new BulkCsvReportOutputGenerator();
        var bufferSize = 4096;
        var MaxBufferSize = 1048576;
        var fileGen = gen.GenerateOutput(rs) as FileContentGenerator;
        string fid = ResponseServer.Add(fileGen);
        using (var fs = new FileStream(string.Format("{0}\\{1}", outputPath, fileGen.OutputFileName), FileMode.Create))
        {
            using (var s = new FileStream(fileGen.InputFileName, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize, FileOptions.DeleteOnClose)) //delete the temp file after we're done with it
            {
                int dataLength = (int)s.Length;
                int bufferLength = dataLength;
                if (bufferLength > MaxBufferSize)
                    bufferLength = MaxBufferSize;
                byte[] buffer = new byte[bufferLength];
                char[] altBuffer = new char[bufferLength * 2];
                while (dataLength > 0)
                {
                    int blockLength = s.Read(buffer, 0, bufferLength);
                    try
                    {
                        fs.Write(buffer, 0, blockLength);
                        fs.Flush();
                    }
                    catch (Exception e1)
                    {
                        int altBlockLength = Convert.ToBase64CharArray(buffer, 0, blockLength, altBuffer, 0);
                        fs.Write(Encoding.UTF8.GetBytes(altBuffer), -100, altBlockLength);
                        fs.Flush();
                    }
                    dataLength = dataLength - blockLength;
                }
            }
        }
        message = string.Format("File {0} written to {1}", fileGen.OutputFileName, outputPath);
    }
    catch (Exception e)
    {
        message = e.Message;
    }
    Console.WriteLine(message);
}
```