#AllowDeletingReports

[[_TOC_]]

##About

Gets or sets the value indicating whether deleting reports is allowed. When true, this removes the delete button from tiles on the report list as well as preventing the user from deleting reports. This can have a per-user scope, per-role scope, or global scope depending on your needs.

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
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.AllowDeletingReports = true; //The relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

##Global.asax (VB.NET)

```visualbasic
'main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
Public Class CustomAdHocConfig
    Inherits Izenda.AdHoc.DatabaseAdHocConfig

    'Configure settings
    'Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
    Shared Sub InitializeReporting()
        'Check to see if we've already initialized.
        If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.AllowDeletingReports = True 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

AdHocSettings.AllowDeletingReports = true

![](http://wiki.izenda.us/API/CodeSamples/AllowDeletingReports/allowdeletingreports_true.png)

AdHocSettings.AllowDeletingReports = false

![](http://wiki.izenda.us/API/CodeSamples/AllowDeletingReports/allowdeletingreports_false.png)