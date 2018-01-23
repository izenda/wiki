#VisualizationBaseUrl

[[_TOC_]]

##About
**Data Type:** string  
**Accepted Values:** URL locations   
**Default value:** string.Empty  
**Impacted Features:** Report Designer Chart Tab   
**Purpose:** Gets or sets the base URL of the site in image references for Visualizations on the Chart tab of the Report Designer    
**Usage:** This setting is used to ensure that the image files are located by the application for Visualizations on the Chart tab of the Report Designer.  A typical use case is a multi-tenant application, where the Izenda URL changes based on tenant (i.e. tenant alpha sees URL "http://www.mysite.com/alpha/ReportList" and tenant beta sees "http://www.mysite.com/beta/ReportList")    
**Caveats:** This setting should not be used in the typical integration.  Only use when Visualization images do not appear in the Chart tab of the Report Designer (see screenshots below) 

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
    AdHocSettings.VisualizationsBaseUrl = "http://www.mysite.com/"; //The relevant setting
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
        AdHocSettings.VisualizationsBaseUrl = "http://www.mysite.com/" 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

**Visualization Images**

![Visualization Images](/API/CodeSamples/VisualizationBaseUrl/Visualizations.png)

**Missing Images**

![Missing Visualization Images](http://fogbugz.izenda.us/default.asp?pg=pgDownload&pgType=pgFile&ixBugEvent=289238&ixAttachment=44189&sTicket=&sFileName=image.png)