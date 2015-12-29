#PdfPrintMode

[[_TOC_]]

##About

Gets or sets the value indicating what print mode will be used for printing PDF reports from the ReportDesigner and ReportViewer.  EO.PDF is a .NET class library (DLL) that converts HTML to PDF.  EO is lightweight, and all conversions occur inside the Izenda application, but it has some size limitations.  PhantomJS is a headless webkit that is provided in all Izenda reference implementations in the bin/phantomjs folder.  When PhantomJS PDF exports are requested, an EXE is triggered on the web server that produces the export and sends it to the client browser for download.

**Default Value:** PdfMode.EOPDF

Possible values:
* EOPDF
* PhantomJs - Available 6.9 **(not currently compatible with Azure PaaS installations)**
* EvoPdfAzureCloudService - Available 6.10 **(Uses cloud service which must be configured for use. More information on setting up service can be downloaded [here](http://wiki.izenda.us/API/CodeSamples/PdfPrintMode/Pdf-Exports-in-Azure-Websites.docx))**
* EvoPdf - Available 6.10

[Print Modes](http://wiki.izenda.us/FAQ/understanding-izenda-print-modes)

##Global.asax (C♯)

``` csharp
//main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{
  // Configure settings
  // Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
  public static void InitializeReporting() {
    //Check to see if we've already initialized.
    if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
      return;
    AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.PdfPrintMode = PdfMode.PhantomJs; //The relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

##Global.asax (VB.NET)

```visualbasic
'main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
Public Class CustomAdHocConfig
    Inherits Izenda.AdHoc.DatabaseAdHocConfig

    Shared Sub InitializeReporting()
        'Check to see if we've already initialized
        If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.PdfPrintMode = PdfMode.PhantomJs 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```