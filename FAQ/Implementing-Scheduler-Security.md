#Implementing Scheduler Security

[[_TOC_]]

By default, the Izenda report scheduler queries the reporting site's response server (rs.aspx) page. Due to the response server calling the InitializeReporting method, this will result in any requests sent from the scheduler to run through the normal program flow, including any security measures to require users to login. Since the scheduler cannot interact with the webpage and click a button to securely login normally, it can be somewhat of a challenge to ensure that the scheduler has access to the site. For this reason, other security measures are required to ensure a secure report scheduler experience.

There are two optional parameters that are available to the scheduler program shipped with the default starter kit. These optional parameters are:

* izu
* izp

These will be used to represent the username and password sent to the reporting site when the scheduler queries the site to initiate the scheduler. As an example of how to form a command line argument call to include these parameters, here is an example:

`C:/> IzendaScheduler.exe http://[myreportingsite]/rs.aspx [interval] izu:[username] izp:[password]`

Running that command will send the following request to your reporting site:

`http://[myreportingsite]/rs.aspx?run_scheduled_reports=[interval]&izUser=[username]&izPassword=[password]`

The values for izUser and izPassword can then be handled in your InitializeReporting method accordingly, and AdHocSettings.CurrentUserName should be set to the value of [username].

Figure 1: The scheduler request and response model

![Scheduler request and response model](http://wiki.izenda.us//FAQ/Implementing-Scheduler-Security/izenda_scheduler_validation.png)

As demonstrated in the above graphic, custom code is required to handle the values passed into the site.

Note: The logic for checking izUser and izPassword from the request MUST precede the assignment of AdHocSettings.AdHocConfig if AdHocSettings.RequireLogin is set before AdHocSettings.AdHocConfig, or else the application will redirect to the login page before the logic for checking izUser and izPassword is hit.

An example of the logic used to validate izUser and izPassword might look something like the sample below:

```csharp
public class CustomAdHocConfig : FileSystemAdHocConfig
{
    public static void InitializeReporting()
    {
        if (AdHocContext.Initialized)
            return;
        AdHocSettings.LicenseKey = "SET_LICENSE_KEY_HERE";
        string izUserName = string.Empty;
        string izPassword = string.Empty;
        if (!string.IsNullOrEmpty(HttpContext.Current.Request["izUser"]))
            izUserName = HttpContext.Current.Request["izUser"];
        if (!string.IsNullOrEmpty(HttpContext.Current.Request["izPassword"]))
            izPassword = HttpContext.Current.Request["izPassword"];
        if (!string.IsNullOrEmpty(izUserName) && !string.IsNullOrEmpty(izPassword))
        {
            if (AuthenticateSchedulerUser(izUserName, izPassword)) //AuthenticateSchedulerUser is a method that will need to be created specially to handle this case and returns a boolean value.
                AdHocSettings.CurrentUserName = izUserName;
        }
        AdHocSettings.RequireLogin = true;
        AdHocSettings.AdHocConfig = new CustomAdHocConfig(); //setting this after RequireLogin will force a redirect if AdHocSettings.CurrentUserName has not been set. This assumes that different login logic handles a standard user login.
        //continue to initialize normally
        AdHocContext.Initialized = true;
    }
}
```

The above snippet, in conjunction with the Izenda reports scheduler executable included in starter kits after version 6.10.0.12 (6.10.0.13 and above), will allow the scheduler to bypass the normal RequireLogin setting and schedule reports freely and securely while still requiring any other users to login using the standard mechanism. This example can be modified to meet individual business requirements.