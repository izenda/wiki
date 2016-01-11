#ExtendedFunctions

[[_TOC_]]

##About

This list allows the user specify additional SQL functions that should be included in the functions dropdown of the Fields tab. You can also enable functions in an [[Expression|http://wiki.izenda.us/API/CodeSamples/ExpressionFunctions]]

Below is a sample global.asax using the ExtendedFunctions setting. The code block will appear within ``<script runat="server"> </script>`` tags within global.asax.

##Best Practices

* If a function will be used ONLY in an Expression, then you should use the ExpressionFunctions setting. Otherwise, use ExtendedFunctions to allow the function to be placed into the dropdown Function list in the report designer.

* You should not use parentheses when you specify a function in ExtendedFunctions or ExpressionFunctions. All we want to do in these settings is list the function name itself, and not call the function.

* When you specify a function in ExtendedFunctions you should use the full function name with schema. When you specify it in ExpressionFunctions short name is sufficient.

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
    AdHocSettings.ExtendedFunctions = new string[] { "[dbo].[SafeDivide]", "LEFT", "SUBSTRING" };
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
        AdHocSettings.ExtendedFunctions = New String() { "[dbo].[SafeDivide]", "LEFT", "SUBSTRING" }
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Examples

* [[ExtendedFunctions to use UDFs (User-Defined Functions)|/FAQ/izenda-and-udfs]].