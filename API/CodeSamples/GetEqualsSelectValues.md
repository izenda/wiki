#GetEqualsSelectValues

[[_TOC_]]

##About

_**Obsolete:** Use the ProcessEqualsSelectList override in the CustomAdHocConfig class instead._

Represents a method that returns values for the OperatorTypes.Equals_Select operator.

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
    AdHocSettings.GetEqualsSelectValues = EqualsSelectDelegate; //The relevant setting
    AdHocContext.Initialized = true;
  }

  private static string[] EqualsSelectDelegate(Column column)
  {
    if (column.FullName.Contains("ShipCountry"))
      return new string[] { "USA", "UK", "Germany", "Japan", "China", "Brazil", "Canada" };
    else
      return AdHocSettings.AdHocConfig.ProcessEqualsSelectList(column);
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
        AdHocSettings.GetEqualsSelectValues = EqualsSelectDelegate 'The relevant setting
        AdHocContext.Initialized = True
    End Sub

    Private Function EqualsSelectDelegate(column As Column) As String()
        If column.FullName.Contains("ShipCountry") Then
            Return New String() {"USA", "UK", "Germany", "Japan", "China", "Brazil", "Canada"}
        Else
            Return AdHocSettings.AdHocConfig.ProcessEqualsSelectList(column)
        End If
    End Function

End Class
```