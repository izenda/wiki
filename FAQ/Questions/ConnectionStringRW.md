#ConnectionStringRW
[[_TOC_]]


##About

ConnectionStringRW is one of the Izenda Driver's properties, which enables users to have Read-Write access permission to a Database.
Below is a sample global.asax using the ConnectionStringRW setting. The code block will appear within <script runat="server"> </script> tags within global.asax

##Global.asax (C♯)
```csharp

 public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
      //Check to see if we've already initialized.
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      //Initialize System
      AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
      AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
      AdHocContext.Driver.ConnectionStringRW = "INSERT_CONNECTION_STRING_HERE";   // ConnectionStringRW was used
      ...
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
        AdHocContext.Driver.ConnectionStringRW = "INSERT_CONNECTION_STRING_HERE"


    End Sub

End Class
```

Though ConnectionStringRW doesn't require Fusion, if you want to use Fusion together with ConnectionStringRW, read-only connection strings should be used everywhere in Fusion/DB initialization, and assign read/write connection string here:

```csharp
FusionDriver fd = new FusionDriver();
      fd.AddConnection("_alias_", FusionConnectionType.MsSql, "_read_only_connection_string_");
      AdHocContext.Driver = fd;
      AdHocSettings.AdHocConfig = new CustomAdHocConfig();
      ((DatabaseAdHocConfig) AdHocSettings.AdHocConfig).SavedReportsDriver = new MSSQLDriver("_read_only_connection_string_");
      ((DatabaseAdHocConfig) AdHocSettings.AdHocConfig).SavedReportsDriver.ConnectionStringRW = "_read/write_connection_string_";
```

##How ConnectionStringRW works

1) If ConnectionStringRW is not assigned, Izenda uses Driver.ConnectionString for all operations against DB

2) If ConnectionStringRW is also assigned, then Izenda will

  ---a) Use Driver.ConnectionString for Read-Only operations against DB, thus Driver.ConnectionString can have ReadOnly access to the DB

  ---b) Use Driver.ConnectionStringRW for Read-Write operations. At this moment this includes only following:

    - Create Reports table if it doesn't exist

    - Create/Update/Delete Thumbnails in Reports table in Database mode

    - Create/Update/Delete Forms in Reports table in Database mode

    - Create/Save/Delete ReportSets in Reports table in Database mode


##Usage
ConnectionStringRW can always be used. The general case is as a safety improvement - if your site specifies ConnectionStringRW, and uses read-only DB account for usual Driver.ConnectionString, you can be sure that users will not be able to modify anything in DB by any means such as SQL injections.

##


