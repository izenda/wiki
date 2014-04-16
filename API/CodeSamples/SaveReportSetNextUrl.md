#SaveReportSetNextUrl

##About

Gets or sets the URL of the page to which users will be redirected after saving the report. If defined, the user will be automatically redirected to this url after saving a report.

You could use this feature if you want to modify how users save reports. Normally, a simple popup will appear on the screen that prompts the user to enter a Name and a Category and once these fields are entered, the user will be redirected back to the Report List. But if you define a url with this setting, users will be directed to your custom page where you can require additional elements such as custom scheduling controls or advanced sharing. Since Izenda saves the report before the redirect, you will have full access to the report by pulling it from your File System or Database.

**Note:** The report name will be automatically added to the url query string as a parameter named "rn". Therefore, your URL could look like "www.yourdomain.com/CustomSave.aspx?rn=SavedReportName" and you will be able to grab the report from the file system or database with the query string parameter.

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
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }

  //Add custom settings below
  public override void ConfigureSettings() {
    AdHocSettings.SaveReportSetNextUrl = "";
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
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub

    'Add custom settings below
    Public Overrides Sub ConfigureSettings()
        AdHocSettings.SaveReportSetNextUrl = "URL-TO-REDIRECT-TO.aspx"
    End Sub
End Class
```