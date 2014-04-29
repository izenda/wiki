#SharedWithValues

[[_TOC_]]

##About

This sets the list of users or roles available in the "Shared With" dropdown of the Misc tab in the Report Designer. This is usually set per-user and may be fine-tuned to your organization's needs. While this setting doesn't have any immediate effect on what reports a user can see, the [[CurrentUserRoles|/API/CodeSamples/CurrentUserRoles]] and [[CurrentUserName|/API/CodeSamples/CurrentUserName]] properties are used in conjunction with this property to create report-level security.

**Default Value:** null/Nothing

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
    AdHocSettings.SharedWithValues = new string[] {"Marketing", "Sales", "Bob", "Alice", "Dan"}; //The relevant setting
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
        AdHocSettings.SharedWithValues = New String() {"Marketing", "Sales", "Bob", "Alice", "Dan"} 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

AdHocSettings.SharedWithValues = new string[] {"Marketing", "Sales", "Bob", "Alice", "Dan"}

![SharedWithValues dropdown](/API/CodeSamples/SharedWithValues/sharewithdropdown.png)