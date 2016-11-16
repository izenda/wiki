#LazySpMetadataPulling

[[_TOC_]]

##About
**Data Type:** boolean  
**Accepted Values:** true, false   
**Default value:** false  
**Impacted Features:** Report Design, Data Sources, InitializeReporting()  
**Purpose:** Gets or sets whether stored procedure metadata will be loaded at the same time as metadata for the rest of the schema. When true, stored procedure metadata will only be pulled when the stored procedure is executed.  
**Usage:** This setting, when set to true, is used to prevent Izenda from executing all stored procedures in VisibleDataSources on the database at initialization.  
**Caveats:** Initialization will be quicker when LazySpMetadataPulling is set to true, but individual reports may take longer to load (if the stored procedure has not been executed and cached by Izenda). This setting must be set prior to setting VisibleDataSources in the Settings.

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
    AdHocSettings.LazySpMetadataPulling = true; //The relevant setting -- must be set PRIOR to VisibleDataSources, if applicable
    AdHocSettings.VisibleDataSources = new string[] {"DataSource1", "DataSource2"};
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
        AdHocSettings.LazySpMetadataPulling = true 'The relevant setting -- must be set PRIOR to VisibleDataSources, if applicable
        AdHocSettings.VisibleDataSources = New String() {"Datasource1", "Datasource2"} 
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub
End Class
```