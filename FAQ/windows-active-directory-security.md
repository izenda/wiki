#Support Active Directory/Windows Authentication

[[_TOC_]]

##Windows Authentication

In some cases, it is preferable to use a custom authentication system to store all authentication data, user lists, credentials, etc.
But sometimes it will be much easier to use built-in system authentication features that you are already leveraging instead of creating something new. ASP.NET can handle the authentication processes and all that is required is to apply needed roles/permissions/security rules for the user as described in our [[Security Guide|Integration/Tutorials/Security]].

Follow these steps to set up Windows Authentication with Impersonation for the AdHoc application:

##Open the Authentication settings for the website

* Open IIS Manager
* Expand the "Sites" tree and find your website
* At the Features panel, find the IIS section and click on the Authentication icon

![Open Authentication settings](http://izenda.com/Site/KB/KB/Uploads/Images/IIS_auth.png)


##Configure Authentication settings

* Disable Anonymous Authentication
* Enable ASP.NET Impersonation
* Enable Windows Authentication

![Configure Authentication settings ](http://izenda.com/Site/KB/Uploads/Images/IIS_security.png
)
Or you can also set these settings manually in the web.config file at the root folder of the website. You will need to place the following settings inside the ``<system.web>`` section of your web.config:

```xml
<authentication mode="Windows" />
<identity impersonate="true" />
```			


##Use authentication information in the AdHoc security model 

```csharp
public override void PostLogin()
{
	WindowsIdentity user = WindowsIdentity.GetCurrent();
	AdHocSettings.CurrentUserName = user.Name;
	AdHocSettings.CurrentUserIsAdmin = new WindowsPrincipal(user).IsInRole(WindowsBuiltInRole.Administrator);
}
```