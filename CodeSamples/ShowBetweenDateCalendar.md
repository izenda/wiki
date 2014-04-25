#ShowBetweenDateCalendar

[[_TOC_]]

Gets or sets the value indicating whether calendar controls should be used for the "Between" operation for DateTime filters. 
When enabled, the Between(Calendar) option appears in the Operator dropdown at the Filters tab in the ReportDesigner for DateTime fields. If it is disabled, the option "Between" without "(Calendar)" will be displayed instead. By default, the Between(Calendar) option uses short date notation(unable to specify a time of day) whereas the standard Between option will allow datetimes to be specified.

Default value: true

##Global.asax (C♯)
```c#

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
    AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.ShowBetweenDateCalendar = true; //The relevant setting
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
        AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.ShowBetweenDateCalendar = True 'The relevant setting
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub
End Class
```

##Screenshots

###AdHocSettings.ShowBetweenDateCalendar = true

![ShowBetweenDateCalendar=true](http://wiki.izenda.us/CodeSamples/ShowBetweenDateCalendar/between_date_calendar.png)

###AdHocSettings.ShowBetweenDateCalendar = false

![ShowBetweenDateCalendar=false](http://wiki.izenda.us/CodeSamples/ShowBetweenDateCalendar/between_date_no_calendar.png)