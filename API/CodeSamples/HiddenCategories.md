#HiddenCategories

[[_TOC_]]

##About

Sets which categories are hidden for the current user. The category and any reports from those categories will not be shown to the current user in the report list or the report designer (when selecting a cateogry for the report). 

_**Note:** If a user with [[AllowCreateNewCategory|/API/CodeSamples/AllowCreateNewCategory]] set to true can type in the name of the hidden category and save a report to it, but when the user navigates back to the report viewer, the category and report will not be accessible anymore._

**Default Value:** empty list

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
        AdHocSettings.HiddenCategories = new string[] {"Admin Reports", "Restricted Logs"}; //The relevant setting
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
        AdHocSettings.HiddenCategories = new string() {"Admin Reports", "Restricted Logs"}; 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots (legacy report list)

![](http://www.izenda.com/Site/Images/Screenshots/HiddenCategoriesDS.png)

##Screenshots (modern report list)

Below: The user is "admin" and there are no hidden categories for this user.

```csharp
AdHocSettings.CurrentUserName = "admin";
AdHocSettings.CurrentUserIsAdmin = true;
AdHocSettings.HiddenCategories = new string[0]; //nothing hidden
```

![](/API/CodeSamples/HiddenCategories/hidden_categories_admin.png)

Below: The user is "user" and the "base" category from above is hidden.

```csharp
AdHocSettings.CurrentUserName = "user";
AdHocSettings.HiddenCategories = new string[] {"base"}; //base is hidden
```

![](/API/CodeSamples/HiddenCategories/hidden_categories_user.png)
##Screenshots (report designer)

Below: the user is "admin" and can add reports to the "base" category

![](/API/CodeSamples/HiddenCategories/hidden_categories_admin2.png)

Below: The user is "designer" and cannot see the "base" category in the designer

![](/API/CodeSamples/HiddenCategories/hidden_categories_designer.png)