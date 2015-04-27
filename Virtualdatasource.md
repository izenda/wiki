If you wish to use one of the reports already created as a data source instead of existing tables:

1 -- Set AdHocSettings.AllowVirtualDataSources = true;  

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
    HttpContext.Current.Session["ReportingInitialized"] = true;
    AdHocSettings.AllowVirtualDataSources = true;  //The relevant setting
  }
```

2 -- Create a report as usual  
3 -- In Misc. Tab, near the bottom click the checkbox that says, "Expose as data source."

![Enable VirtualDataSource](http://wiki.izenda.us/Virtualdatasource/AllowVirtualDatasources.png)

4 -- Make sure to save the report.  
5 -- Create a new report. The data sources will include the saved report preceded by the folder you saved it under.  You will also notice some Data Sources have become links.  When you select one, a popup will appear, displaying all of the reports that currently use that data source.

![VirtualDataSources Screenshot](http://wiki.izenda.us/Virtualdatasource/AVDS.png)

6 -- Continue as usual, except that your column choices will be limited by the columns you chose in the previously saved report.