#AllowOverwritingReports

[[_TOC_]]

##About

This enables/disables the current user's ability to overwrite reports currently saved. An example of this usage is that many users create base reports for their users to use. Disabling the overwrite report feature ensures that the default reports are not tampered with.

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
    AdHocSettings.AllowOverwritingReports = true; //The relevant setting
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
        AdHocSettings.AllowOverwritingReports = True 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

AdHocSettings.AllowOverwritingReports = true

![](http://wiki.izenda.us//API/CodeSamples/AllowOverwritingReports/allowoverwritingreports_true.png)

AdHocSettings.AllowOverwritingReports = false

![](http://wiki.izenda.us//API/CodeSamples/AllowOverwritingReports/allowoverwritingreports_false.png)