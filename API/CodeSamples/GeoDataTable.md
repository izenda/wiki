#GeoDataTable

[[_TOC_]]

##About

Gets or sets the value indicating the table name that contains geodata for maps. This should be a fully qualified database object name such as [dbo].[MyGeoDataTable] and will be automatically joined to map reports using the indicator bar on the field supplied for the "City" option. For best results, ensure that each city in your database has exactly one corresponding record in your geodata table. Furthermore, the geodata table needs to be specified with the following fields in order for the automatic join function to work:

* City
* Latitude
* Longitude

_**Note:** If the geodata table requires a composite key, it is possible to specify the join manually or programatically, but automatic joining does not work for composite keys._

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
    AdHocSettings.GeoDataTable = 15D; //The relevant setting
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
        AdHocSettings.GeoDataTable = 15D 'The relevant setting
        AdHocContext.Initialized = True
    End Sub
End Class
```