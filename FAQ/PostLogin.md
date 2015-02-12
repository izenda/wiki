#The PostLogin() Method

[[_TOC_]]

##About

The PostLogin method allows you to call it from your login page using the line of code: ``Izenda.AdHoc.AdHocSettngs.AdHocConfig.PostLogin();``

This will enable you to run any user/role related code, before the global settings are run from either the _Settings.aspx_ page or the ConfigureSettings() method in the _Global.asax_. 

> Call Izenda.AdHoc.AdHocSettngs.AdHocConfig.PostLogin() from your login
> page after authentication is successful

_**Obsolete:** This method has been replaced with [[InitializeReporting|/FAQ/InitializeReporting]] in Izenda 6.7 and later._
```csharp
public override void PostLogin()
  { 
    //user was already authenticated by login.aspx so we just need to use the information from the session in our AdHoc reporting
    AdHocSettings.CurrentUserName = HttpContext.Current.Session["UserName"];
    AdHocSettings.CurrentUserIsAdmin = HttpContext.Current.Session["IsAdmin"];
    if (AdHocSettings.CurrentUserIsAdmin)
        AdHocSettings.ShowSettingsButton = true;
    else
        AdHocSettings.ShowSettingsButton = false;
  }
```