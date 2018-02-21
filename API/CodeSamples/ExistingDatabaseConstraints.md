#ExistingDatabaseConstraints

[[_TOC_]]

##About

Gets database constraints from your database connection. To set database constraints programatically, use [[AddConstraint|http://wiki.izenda.us/Guides/Izenda-AdHoc-Driver#b)-Constraints]] or [[AddForcedLeftJoin|/API/CodeSamples/AddForcedLeftJoin]]

**Default Value:** depends on your database configuration

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
    string[] myConstraintsList = AdHocSettings.ExistingDatabaseConstraints; //The relevant setting. There is no setter for this setting.
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
        String() myConstraintsList = AdHocSettings.ExistingDatabaseConstraints 'The relevant setting. There is no setter for this setting.
        AdHocContext.Initialized = True
    End Sub
End Class
```