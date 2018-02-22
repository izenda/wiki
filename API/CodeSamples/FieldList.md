#FieldList

[[_TOC_]]

##About

_**Obsolete:** This feature is no longer supported._

Gets or sets the default Izenda.AdHoc.AdHocSettings.FieldList control. This represents the Fields tab on the Izenda.Web.UI.AdHocReportDesigner. 

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
    AdHocSettings.FieldList = new MyFieldList(); //The relevant setting
    AdHocContext.Initialized = true;
  }
}

private class MyFieldList : Izenda.Web.UI.FieldList
{

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
        AdHocSettings.FieldList = New MyFieldList() 'The relevant setting
        AdHocContext.Initialized = True
    End Sub
End Class

Private Class MyFieldList
    Inherits Izenda.Web.UI.FieldList

End Class

```