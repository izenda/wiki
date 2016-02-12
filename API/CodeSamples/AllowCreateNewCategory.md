#AllowCreateNewCategory

[[_TOC_]]

##About

Gets or sets whether or not to allow the [[current user|/API/CodeSamples/CurrentUserName]] to create new categories in the "Save As" dialog in the ReportDesigner.

_**Note:** If [[HiddenCategories|/API/CodeSamples/HiddenCategories]] are used for the current user and this setting is true, the user will be able to "create" a category with the same name as the hidden category and save reports to it, but these reports will be invisible once the user navigates back to the report list._

**Default value:** true

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
  AdHocSettings.AllowCreateNewCategory = false; //The relevant setting
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
  AdHocSettings.AllowCreateNewCategory = false //The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

AdHocSettings.AllowCreateNewCategory = true;

![](/API/CodeSamples/AllowCreateNewCategory/allow_create_new_category_true.png)

AdHocSettings.AllowCreateNewCategory = false;

![](/API/CodeSamples/AllowCreateNewCategory/allow_create_new_category_false.png)