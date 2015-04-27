#Culture

[[_TOC_]]

##About

Gets or sets the default culture for Ad Hoc. Note: use this only in special cases, like when you want to use the date formats of a culture other than your own. Normally you should use Language setting for localization. 

**NOTE: If you experience a compilation error, you may need to add System.Globalization.CultureInfo()**

**ALSO NOTE: Izenda is built on .NET 2.0, which does not support the use of Neutral Culture codes, such as zh-CHT (Chinese Traditional) or zh-CHS (Chinese Simplified).  Instead, you must use Specific Culture codes, such as zh-CN (Chinese - China) or zh-TW (Chinese - Taiwan).**

See links below: 

[[Language|/API/CodeSamples/Language]]

[[Izenda Language Pack|http://wiki.izenda.us/Integration/Tutorials/Localization]]

[[A list of valid culture codes|http://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx]]

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
    AdHocSettings.Culture = new CultureInfo("en-US"); //the relevant setting
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
        AdHocSettings.Culture = new CultureInfo("en-US") 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```