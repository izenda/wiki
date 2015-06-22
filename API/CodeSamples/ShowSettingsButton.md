#ShowSettingsButton

[[_TOC_]]

##About

Gets or sets the value enabling the Settings button on the Izenda Reports toolbar. The settings button launches the settings page, which allows for a GUI-oriented interface for modifying various common settings. However, we highly recommend either removing the settings page entirely, or implementing a custom settings page (example in the third code sample), and using the ``InitializeReporting()`` method to perform your initialization.

**Default Value:** True

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
    AdHocSettings.ShowSettingsButton = true; //the relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

##Global.asax (VB.NET)

```visualbasic
'main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
Public Class CustomAdHocConfig
    Inherits Izenda.AdHoc.DatabaseAdHocConfig

    'Configure settings
    'Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
    Shared Sub InitializeReporting()
        'Check to see if we've already initialized.
        If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.ShowSettingsButton = True 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Settings.aspx.cs (C♯)

```csharp
public partial class Settings : System.Web.UI.Page {
  protected override void OnLoad(System.EventArgs e) {
        ListDictionary tests = Izenda.AdHoc.Utility.DiagnosticTest();
        foreach (DictionaryEntry de in tests) {
            if (!(de.Value is bool))
                continue;
            if (!(bool) de.Value) {
                if (de.Key == "Connection String") {
                    errorlabel.Text = "Sorry, your Connection String is corrupted";
                }

                else if (de.Key == "License Key") {

                     errorlabel.Text = "Your License Key is invalid.";

                }

                 else if...
            }
        }
  }
```

##Screenshots

AdHocSettings.ShowSettingsButton = false

![](http://wiki.izenda.us/API/CodeSamples/ShowSettingsButton/toolbar_showsettingsbutton_false.png)

AdHocSettings.ShowSettingsButton = true

![](http://wiki.izenda.us/API/CodeSamples/ShowSettingsButton/toolbar_showsettingsbutton_true.png)

##Related Articles

Other settings and tutorials related to this setting are listed below:

* [[ShowSettingsButtonForNonAdmins|/API/CodeSamples/ShowSettingsButtonForNonAdmins]]
* [[Limiting Access to Settings.aspx|/API/CodeSamples/SettingsKey]]