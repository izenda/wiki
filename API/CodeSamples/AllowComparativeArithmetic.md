#AllowComparativeArithmetic

[[_TOC_]]

##About

Gets or sets the value indicating whether comparative arithmetic is allowed in arithmetic checkbox. Logical comparisons (less than and greater than) can be used between the preceding field and the selected field when cycling through values on the "A" checkbox of the report designer. Certain datatypes behave differently when this is enabled.

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
    AdHocSettings.AllowComparativeArithmetic = true;
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
        AdHocSettings.AllowComparativeArithmetic = True
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots (Report Designer)

Field "Quantity" compared to field "ExtendedPrice" with alias "Sales"

![]()

Provided "Average" is selected, this will generate SQL like the following:
CASE WHEN ([dbo].[Invoices].[ExtendedPrice]<AVG(CAST([dbo].[Invoices].[Quantity] AS float))) THEN 1 ELSE 0 END AS 'Sales'

