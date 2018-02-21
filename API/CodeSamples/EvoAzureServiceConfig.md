#EvoAzureServiceConfig

[[_TOC_]]

##About

The configuration for the Evo Azure Cloud Service. This needs to be set before assigning ``PdfPrintMode = PdfMode.EvoPdfAzureCloudService``

**Default Value:** null

##Global.asax (C♯)

```csharp
//main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{
  // Configure settings
  // Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
  public static void InitializeReporting() {
    //Check to see if we've already initialized.
    if (AdHocContext.Initialized)
      return;
    AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.EvoAzureServiceConfig = new EvoPdfAzureCloudServiceConfig("127.0.0.1", 527); //The relevant setting
    AdHocSettings.PdfPrintMode = PdfMode.EvoPdfAzureCloudService; //related setting
    AdHocContext.Initialized = true;
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
        If AdHocContext.Initialized Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.EvoAzureServiceConfig = New EvoPdfAzureCloudServiceConfig("127.0.0.1", 527) 'The relevant setting
        AdHocSettings.PdfPrintMode = PdfMode.EvoPdfAzureCloudService 'Related setting
        AdHocContext.Initialized = True
    End Sub
End Class
```