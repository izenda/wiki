#HiddenColumns

[[_TOC_]]

##About

Gets or sets the array of columns that should be hidden in all field dropdowns throughout the application. This can be set application-wide or conditionally by tenant, role, or other criteria as this is a session level setting by default.

**Default Value:** new string[] {}

##Global.asax (C♯)

```csharp
//main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{
  // Configure settings
  // Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
  public static void InitializeReporting() {
    //Check to see if we've already initialized.
    if (AdHocContext.Initialized)
      return;
    AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.HiddenColumns = new string[] { "[dbo].[Orders].[ShipVia]", "[dbo].[Employees].[BirthDate]", "[dbo].[Employees].[HireDate]" }; //The relevant setting
    AdHocContext.Initialized = true;
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
        If AdHocContext.Initialized Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.HiddenColumns = new string() { "[dbo].[Orders].[ShipVia]", "[dbo].[Employees].[BirthDate]", "[dbo].[Employees].[HireDate]" } 'The relevant setting
        AdHocContext.Initialized = True
    End Sub
End Class
```