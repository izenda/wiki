#Session_Start()

[[_TOC_]]

##About

_**Note:** This method is obsolete to the Izenda platform. Please use [[InitializeReporting|/FAQ/InitializeReporting]] instead.

This code sample turns on the customization capabilities by setting the license key and connection string in the Session_Start(). This must be done in order to allow any other custom code to run. The Session_Start() method is called when a user begins a new session. The length of a session is determined by IIS and has a default length of 20 minutes.

```csharp
void Session_Start(object sender, EventArgs e) 
{
    Izenda.AdHoc.AdHocSettings.LicenseKey = "Some License Key";
    Izenda.AdHoc.AdHocSettings.SqlServerConnectionString = "Some Connection String";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
}
```