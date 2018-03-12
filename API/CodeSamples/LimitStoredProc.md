#LimitStoredProc

[[_TOC_]]

##About

If set to true, optimizes amount of stored procedures calls. Will have effect only if set BEFORE any database-related settings and driver initializations. This specifically affects the number of calls to stored procedures during report execution. Temporary tables will be created and each stored procedure will be executed once to populate the temporary tables. This is done when executing a report set for each report part in the set. The temporary table reference is kept on disk according to the driver's QueryCachingTime setting. After that period has expired, the next time a report set is executed containing the expired stored procedure, the temp table will be re-created. The stored procedure parameter values are taken into account when determining whether or not the temp table exists. Thus, many different temp tables can exist with different data that are mapped to a single stored procedure.

_**Note:** This setting currently only supports MSSQL drivers (normal and fusion)._

**Default Value:** False

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
    AdHocSettings.LimitStoredProc = true; //The relevant setting
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
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
        AdHocSettings.LimitStoredProc = True 'The relevant setting
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocContext.Initialized = True
    End Sub
End Class
```