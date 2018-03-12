#GridItemStyle

[[_TOC_]]

##About

Gets or sets the CSS style of grid items when using the analysis grid or VG hierarchy option.

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
    AdHocSettings.GridItemStyle = new TableItemStyle() //The relevant setting
    {
        BackColor = Color.Cyan,
        BorderColor = Color.Black,
        BorderStyle = BorderStyle.Groove,
        BorderWidth = new Unit(2),
        ForeColor = Color.Navy,
        Height = new Unit(50),
        HorizontalAlign = HorizontalAlign.Center,
        VerticalAlign = VerticalAlign.Middle,
        Width = new Unit(200),
        Wrap = true
    };
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
        AdHocSettings.GridItemStyle = New TableItemStyle() With { 
            .BackColor = Color.Cyan,
            .BorderColor = Color.Black,
            .BorderStyle = BorderStyle.Groove,
            .BorderWidth = New Unit(2),
            .ForeColor = Color.Navy,
            .Height = New Unit(50),
            .HorizontalAlign = HorizontalAlign.Center,
            .VerticalAlign = VerticalAlign.Middle,
            .Width = New Unit(200),
            .Wrap = True
        } 'The relevant setting
        AdHocContext.Initialized = True
    End Sub
End Class
```