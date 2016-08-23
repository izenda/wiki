#ShowAdditionalJoinConditions

[[_TOC_]]

##About
**Data Type:** Bool  
**Accepted Values:** true,false,1,0  
**Default value:** true  
**Impacted Features:** Report Designer
**Purpose:** Adds the ability to add multiple conditions to each join.  
**Usage:** This setting is used to create more complex joins where And, Or and other operators need to be used in join conditions.  
**Caveats:** More complex joins will add to the initial report load. If caching is turned off, this processing time will occur each time the report loads. This can be alleviated in part by ensuring to use indexed and/or key columns.

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
    AdHocSettings.ShowAdditionalJoinConditions = true; //The relevant setting
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
        AdHocSettings.ShowAdditionalJoinConditions = true 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Screenshots

AdHocSettings.ShowAdditionalJoinConditions = true;

![](/API/ShowAdditionalJoinConditions/show-additional-join-conditions.PNG)

AdHocSettings.ShowAdditionalJoinConditions = false;
![](/API/ShowAdditionalJoinConditions/without-add-join-conditions.PNG)