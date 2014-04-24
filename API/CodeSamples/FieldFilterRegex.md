#FieldsRegex

[[_TOC_]]

##About

Sets the regular expression used for column filtering for data selection. This setting allows the user to use a regular expression to filter certain fields from being added to the report through the Fields tab in the Report Designer. An example of when this may be used is if you don't want social security numbers added to reports. You could add part of the name of that field to the regular expression so it is not listed as an option in the list. For example, to hide only fields ending with "ID", use the following value: ``AdHocSettings.FieldsRegex = "^.*(?<id)$``. There are also many excellent regular expression tools on the internet to build and test regular expressions that you can use with Izenda.

_**Note:** You still will be able to use any fields to join tables at the Data Sources tab._

**Troubleshooting:** If you see the message "No fields available to select" your regular expression might be too general. Check your regular expressions and your data source fields and try again.

##C♯

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
    Izenda.AdHoc.AdHocSettings.FieldsRegex = "pass|pw|admin";
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}

```

##VB.NET

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
        Izenda.AdHoc.AdHocSettings.FieldsRegex = "pass|pw|admin"
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

![](http://www.izenda.com/Site/Images/Screenshots/FieldsRegexDS.png)