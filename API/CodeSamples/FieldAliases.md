#FieldAliases

[[_TOC_]]

##About

Gets or sets the field names(aliases) that the user sees in the Report Designer. This can be set globally or on a per-user basis. The key is the name of your column in the database and the value is the alias you wish the user to see. This is useful for localization and when custom fields are used in your application.

Below is a sample global.asax using the ExtendedFunctions setting. The code block will appear within ``<script runat="server"> </script>`` tags within global.asax.

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
    AdHocSettings.FieldAliases["ShipCity"] = "DepartureCity"; //The relevant setting
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
        AdHocSettings.FieldAliases("ShipCity") = "DepartureCity" 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Fully-qualified column names

You can use fully-qualified column names to allow columns from different tables and schemas with the same name to be aliased differently if you so desire. To do that, simply use bracket notation to specify the schema and table:

```csharp
AdHocSettings.FieldAliases.Add("[dbo].[Orders].[ShipCity]", "DepartureCity")
```

###Screenshots

![](/API/CodeSamples/FieldAliasesfield_alias_qualified.png)