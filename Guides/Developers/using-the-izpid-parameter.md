[[_TOC_]]

#Using the izpid parameter

##What is the izpid?

The izpid (Izenda Page ID) is an optional request parameter that can be passed into the Izenda reporting tool via the URL (e.g. http://mysite.reporting.com/reportlist.aspx?izpid=123) in order to differentiate sessions when a user is simultaneously accessing two different accounts that each access the AdHoc reporting tool using a single browser window. Izenda will automatically append this parameter to subsequent requests within the same browser window if the initial request contained the parameter.

##How is the izpid set up?

###InitializeReporting

In order to use the izpid properly, some setup is required in the global.asax and the InitializeReporting method. In a vanilla Izenda installation, the following code appears in the global.asax:

```c#
public static void InitializeReporting()
{
    //Check to see if we've already initialized.
    if (AdHocContext.Initialized)
        return;
    //Initialize System
    {...}
    AdHocContext.Initialized = true;
}
```

Or in editions of Izenda before 6.10.0.3:

```c#
public static void InitializeReporting()
{
    //Check to see if we've already initialized.
    if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
    //Initialize System
    {...}
    HttpContext.Current.Session["ReportingInitialized"] = true;
}
```

This code will need to change to something like the following:

```c#
public static void InitializeReporting()
{
    //Check to see if we've already initialized.
    if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitializedFor#" + StaticSharedStorage.ConfigId] != null)
        return;
    //Initialize System
    StaticSharedStorage.Activate(true);
    {...}
    HttpContext.Current.Session["ReportingInitializedFor#" + StaticSharedStorage.ConfigId] = true;
}
```

The [[StaticSharedStorage|http://wiki.izenda.us/FAQ/Questions/Caching#StaticSharedStorage]] will be discussed in the next section as it pertains to the izpid. The other statements that changed will enable izpid-aware re-initialization for a user. Since ASP.NET's session storage persists for the length of time the user is active on the site, different session variables will be needed in order to re-initialize AdHocSettings. The settings will persist as long as the StaticSharedStorage.ConfigId property does not change. If it changes, then InitializeReporting will run again and that configId will have its own unique set of values. No additional logical considerations will be required to ensure that user settings are re-initialized independently of universal settings.

###StaticSharedStorage.Activate

The statement StaticSharedStorage.Activate(true) will turn on the static settings cache. This is independent of session state and uses the StaticSharedStorage.ConfigId in order to locate the set of values that AdHocSettings properties will access. Normally, these values are accessed according to AdHocSettings.DefaultScope (normally set to Session scope). Activating the StaticSharedStorage will override the DefaultScope in favor of a static memory cache. Static memory caches do not clear when a user's session expires, so ensure that all server memory considerations are made before publishing to a production environment.

###Application_AcquireRequestState

In addition to the InitializeReporting method, an override for the method [[Application_AcquireRequestState|https://msdn.microsoft.com/en-us/library/bb470252(v=vs.100).aspx]] is also required in the global.asax. This method is invoked during the time the server is processing a request and will run before InitializeReporting. This is important as the StaticSharedStorage goes through a critical update at this time.

```c#
protected void Application_AcquireRequestState(object sender, EventArgs e)
{
    string someUserUid = null;
    if (HttpContext.Current != null && HttpContext.Current.Request != null)
        someUserUid = (HttpContext.Current.Request["izpid"] ?? "").Split(',')[0];
    if (!String.IsNullOrEmpty(someUserUid))
        StaticSharedStorage.CurrentRequestUserStorageUID = someUserUid;
}
```

As demonstrated above, if the izpid is found then the StaticSharedStorage.CurrentRequestUserStorageUID is updated as well. The CurrentRequestUserStorageUID directly ties to the StaticSharedStorage.ConfigId discussed earlier. This assignation will ensure that the request uses the proper ConfigId to obtain the settings for the user.

With these two considerations in place, the izpid parameter will start segregating sessions throughout the AdHoc reporting tool.

###Additional considerations

Apart from implementing the izpid in the global.asax, another key part of the izpid for a seamless user experience is to ensure that all requests from the hosting application into any of the reporting pages append the izpid parameter. This will vary according to the exact setup for the website or web application. Depending on how many entry points exist between the parent application and the AdHoc reporting tool, one or more URL redirects will need to be updated to include the izpid.

Also keep in mind that the izpid is not a magic string value that needs to adhere to any particular conventions. The only requirements for maintaining the wall of separation between user sessions in the same browser is that each time the user logs in under a different account, the izpid changes for that particular login. The original login must still use the original izpid, but the second login will need to use a different izpid.