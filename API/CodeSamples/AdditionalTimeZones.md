#AdditionalTimeZones

[[_TOC_]]

##About

Provides a list of customized timezones for the scheduler section of the [[Misc tab|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab]] of the report designer. 

**Default Value:** Empty List

**Deprecated:** This setting is obsolete. Please use [[TimeZones|/API/CodeSamples/TimeZones]] instead.

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
        AdHocSettings.AdditionalTimeZones.Add("ADT", -3, "Atlantic Daylight Time"); //The relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

Global.asax (VB.NET)

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
        AdHocSettings.AdditionalTimeZones.Add("ADT", -3, "Atlantic Daylight Time") 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```