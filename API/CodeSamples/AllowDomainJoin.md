#AllowDomainJoin

[[_TOC_]]

##About

Gets or sets the value indicating that domain joins should be shown on the report designer. Domain join could be useful if you want to join tables on columns with web addresses. For example, if you set up Domain Join, option columns with strings "http://www.yourdomain.com" and "www.yourdomain.com" will be equal.

_**Note:** This property should be used with ShowJoinDropDown set to true.Note: This property should be used with ShowJoinDropDown set to true._

Default value: false

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
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.AllowDomainJoin = true;
    HttpContext.Current.Session["ReportingInitialized"] = true;
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
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.AllowDomainJoin = True
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

``AdHocSettings.AllowDomainJoin = true``

![](/API/CodeSamples/AllowDomainJoin/domain_join_true.png)

``AdHocSettings.AllowDomainJoin = false``

![](/API/CodeSamples/AllowDomainJoin/domain_join_false.png)