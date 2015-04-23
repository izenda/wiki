#ShowInvalidVizExportLink

[[_TOC_]]

##About

ShowInvalidVizExportLink is a boolean variable that determines whether the message "To view the interactive visualization please click this link." is displayed when charts of type visualization is exported to Word,Excel, and other document form. By default ShowInvalidVizExportLink is true. When the user set it to false then message "To view the interactive visualization please click this link." will not be shown.

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
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.ShowJoinDropDown = true; //the relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

##Screenshots

![](http://izenda.com/Site/Images/Screenshots/ShowJoinDropDownDS.png)