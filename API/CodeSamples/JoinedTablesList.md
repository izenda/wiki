#JoinedTablesList

[[_TOC_]]

##About

_**Obsolete:** This setting no longer has any effect on the application._

Gets or sets the default Izenda.AdHoc.AdHocSettings.JoinedTablesList control. This represents the Advanced mode for the DataSources Tab of the Izenda.Web.UI.AdHocReportDesigner. 

_**Note:** The checkbox mode control is not available for overriding either._

**Default Value:** null

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
    AdHocSettings.JoinedTablesList = new Izenda.Web.UI.JoinedTablesList() { DefaultRowCount = 1000, InsertAboveImageUrl = "MyInsertAboveIcon.png", InsertBelowImageUrl = "MyInsertBelowIcon.png" }; //The relevant setting
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
        AdHocSettings.JoinedTablesList = New Izenda.Web.UI.JoinedTablesList() With
        {
            .DefaultRowCount = 1000,
            .InsertAboveImageUrl = "MyInsertAboveIcon.png",
            .InsertBelowImageUrl = "MyInsertBelowIcon.png"
        } ' The relevant setting        
        AdHocContext.Initialized = True
    End Sub
End Class
```