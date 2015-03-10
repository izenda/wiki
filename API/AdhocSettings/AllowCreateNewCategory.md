#AllowCreateNewCategory

[[_TOC_]]

##About
**Data Type:** Bool  
**Accepted Values:** true,false,1,0  
**Default value:** true  
**Impacted Features:** Report Design, Dashboard Design, Report List  
**Purpose:** Removes the "New Category" option from the initial Save and Save As dialogue box.  
**Usage:** This setting is used to disable new categories from being created by users. It can be set per user through security.  
**Caveats:** If [[HiddenCategories|/API/CodeSamples/HiddenCategories]] are used for the current user and this setting is true, the user will be able to "create" a category with the same name as the hidden category and save reports to it, but these reports will be invisible once the user navigates back to the report list.  

##Code Samples
###Global.asax (C♯)

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
        AdHocSettings.HeaderStyle = ""; //The relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

###Global.asax (VB.NET)

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
        AdHocSettings.HeaderStyle = "" 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

AdHocSettings.AllowCreateNewCategory = true;

![](/API/CodeSamples/AllowCreateNewCategory/allow_create_new_category_true.png)

AdHocSettings.AllowCreateNewCategory = false;

![](/API/CodeSamples/AllowCreateNewCategory/allow_create_new_category_false.png)
