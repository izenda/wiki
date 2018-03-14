#OracleConstraintsQuery

[[_TOC_]]

##About

_**Obsolete:** Set OracleDriver.GetConstraintsSQL instead._

Gets or sets query for constraints in oracle.

**Default Value:** String.Empty

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
    AdHocSettings.OracleConstraintsQuery = "SELECT col1 AS POWNER, col2 AS PTABLE, col3 AS PCOLUMN, col4 AS FOWNER, col5 AS FTABLE, col6 AS FCOLUMN FROM myConstraintsTable"; //The relevant setting
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
        AdHocSettings.OracleConstraintsQuery = "SELECT col1 AS POWNER, col2 AS PTABLE, col3 AS PCOLUMN, col4 AS FOWNER, col5 AS FTABLE, col6 AS FCOLUMN FROM myConstraintsTable" 'The relevant setting
        AdHocContext.Initialized = True
    End Sub
End Class
```