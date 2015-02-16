#CurrentUserName

[[_TOC_]]

##About

Gets or sets the roles of the current user. This is used to customize security based on roles already established client-side. It can be used in addition to a User ID and Tenant ID.

In the following example, the user's role(s) are pulled from session. If the role of Power User is within their set of roles, they will be see the modify button but will not be allowed to delete reports.

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
    AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.CurrentUserRoles = new string[] {(string)HttpContext.Current.Session["Role"]}; //The relevant setting

    if (AdHocSettings.CurrentUserRoles.Contains("PowerUser"))  //Role level security
	{    
		AdHocSettings.ShowModifyButton=true;    
		AdHocSettings.AllowDeletingReports=false;      
	}
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```