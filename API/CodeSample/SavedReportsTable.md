#SavedReportsTable

[[_TOC_]]

##About

Gets or sets the name of the database table that will be used to store reports when running in [[DatabaseAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]] mode. The table will be created on the database specified with the [[connection string|http://wiki.izenda.us/Integration/Tutorials/connect-to-the-database]] unless a [[SavedReportsDriver|http://wiki.izenda.us/Guides/Izenda-AdHoc-Driver#c)-Saving-Reports-with-Fusion]] is also specified. In that case, the table will be created using the connection specified by that driver. The [[SavedReportsDriver|http://wiki.izenda.us/Guides/Izenda-AdHoc-Driver#c)-Saving-Reports-with-Fusion]] requires [[Fusion|http://wiki.izenda.us/Guides/Izenda-AdHoc-Driver#Izenda-Fusion-Driver]] to be able to use. The table will be created with the following structure:

Name: [[SavedReportsTable|/API/CodeSamples/SavedReportsTable]]

Columns:
* Name: The report's name.
* Xml: The report's XML definition.
* CreatedDate: The date the report was first created.
* ModifiedDate: The date the report was last modified/updated.
* TenantID: The report's tenant ID (this is dependent on the user who created the report. See [[CurrentUserTenantID|/API/CodeSamples/CurrentUserTenantID]] for more info.)
* IzendaAdHocReportsID: not used internally.
* ReportSourceID: not used internally.
* Thumbnail: The serialized image data for the thumbnail saved for this report. This can be avoided when [[GenerateThumbnails|/API/CodeSamples/GenerateThumbnails]] is set to false.
* Form: Contains the HTML definition of any form that is associated with the report.

##Global.asax (C♯)

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
    AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.CurrentUserName = "MyReportsTable"; //The relevant setting
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
        AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.SavedReportsTable = "MyReportsTable" 'The relevant setting
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub
End Class
```