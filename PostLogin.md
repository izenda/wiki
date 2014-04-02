#The PostLogin() Method

The PostLogin method allows you to call it from your login page using the line of code: ``Izenda.AdHoc.AdHocSettngs.AdHocConfig.PostLogin();``

This will enable you to run any user/role related code, before the global settings are run from either the _Settings.aspx_ page or the ConfigureSettings() method in the _Global.asax_. 

> Call Izenda.AdHoc.AdHocSettngs.AdHocConfig.PostLogin() from your login
> page after authentication is successful

```csharp
public override void PostLogin()
  { 
    if (userName == joe)
      {
        AdHocSettings.CurrentUserName = userName;
        AdHocSettings.CurrentUserIsAdmin = false;
        AdHocSettings.ShowSettingsButton = false;
      }

    else
      {
        AdHocSettings.CurrentUserIsAdmin = true;
      }
  }
```