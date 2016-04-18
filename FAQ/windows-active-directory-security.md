#Active Directory/Windows Authentication

[[_TOC_]]

##Question

##Answer

###Windows Authentication

In some cases, it is preferable to use a custom authentication system to store all authentication data, user lists, credentials, etc.
But sometimes it will be much easier to use built-in system authentication features that you are already leveraging instead of creating something new. ASP.NET can handle the authentication processes and all that is required is to apply needed roles/permissions/security rules for the user as described in our [[Security Guide|Integration/Tutorials/Security]].

Follow these steps to set up Windows Authentication with Impersonation for the AdHoc application:

###Open the Authentication settings for the website

* Open IIS Manager
* Expand the "Sites" tree and find your website
* At the Features panel, find the IIS section and click on the Authentication icon

###Configure Authentication settings

* Disable Anonymous Authentication
* Enable ASP.NET Impersonation
* Enable Windows Authentication

Or you can also set these settings manually in the web.config file at the root folder of the website. You will need to place the following settings inside the ``<system.web>`` section of your web.config:

```xml
<authentication mode="Windows" />
<identity impersonate="true" />
```			


###Use authentication information in the AdHoc security model 

Place the following lines of code into your ``global.asax``.

**C♯**
```csharp
Imports System.Security.Principal;

/*
   implementation code
*/

public static void InitializeReporting()
{
	WindowsIdentity user = WindowsIdentity.GetCurrent();
	AdHocSettings.CurrentUserName = user.Name;
	AdHocSettings.CurrentUserIsAdmin = new WindowsPrincipal(user).IsInRole(WindowsBuiltInRole.Administrator);
}
```

**VB.NET**
```visualbasic
Using System.Security.Principal

'implementation code

Public Shared Sub InitializeReporting()
	Dim user As WindowsIdentity = WindowsIdentity.GetCurrent()
	AdHocSettings.CurrentUserName = user.Name
	AdHocSettings.CurrentUserIsAdmin = New WindowsPrincipal(user).IsInRole(WindowsBuiltInRole.Administrator)
End Sub
```

###Authenticating Over OData

As of version 6.7.0.265, you can authenticate OData connections. The process for authenticating a user over an OData connection is slightly different in the code that must be implemented to enable this. A sample is shown below.

```csharp
public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
        FusionDriver fd = new FusionDriver();
        fd.AddCustomConnection(new CustomODataConnection("SecureConnection", "http://www.yoursite.com/odataprovider.aspx"));
    }
}

public class CustomODataConnection : ODataFusionConnection
{
    public CustomODataConnection(string alias, string getSchemaUrl) : base(alias, getSchemaUrl) { }

    public override void ProcessPostRequest(System.Net.HttpWebRequest request)
    {
        System.Net.NetworkCredential cred = new System.Net.NetworkCredential();
        cred.UserName = WindowsIdentity.GetCurrent().Name;
        cred.Password = HttpContext.Current.Session["Password"].ToString(); //This could be passed from a text field the user is prompted for or from custom storage code in your login process.
        request.Credentials = cred;
    }
}
```