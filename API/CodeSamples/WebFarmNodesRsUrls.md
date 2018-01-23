#WebFarmodesRsUrls

[[_TOC_]]

##About

**Data Type:** string array    
**Accepted Values:** URL locations   
**Default value:** null   
**Impacted Features:** Website infrastructure and url navigation    
**Purpose:** Gets or sets response server urls of other machines in webfarm    
**Usage:** This setting is used to ensure that Izenda is aware of all rs.aspx URLs when issuing server commands such as invalidating the server's schema cache on the filesystem.    
**Caveats:** This setting is only to be used when the webfarm in question uses different URLs for routing and does not ensure that caches will be successfully invalidated if load balancing with a single website URL is used as there is no way to know strictly through the URL what machine is being accessed. Other measures need to be taken to ensure schema cache invalidation successfully occurs in that scenario.

##Code Samples
###Global.asax (C♯)

```csharp
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
    //Creates a connection to Microsoft SQL Server
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.WebFarmNodesRsUrls = new string[] { "http://mysite.reporting.com/rs.aspx", "http://mysite2.reporting.com/rs.aspx" };
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

###Global.asax (VB.NET)

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
        AdHocSettings.WebFarmNodesRsUrls = New String() { "http://mysite.reporting.com/rs.aspx", "http://mysite2.reporting.com/rs.aspx" }
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
``` 