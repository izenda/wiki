#Authentication Function

[[_TOC_]]

##About

This is a simple authentication function you can place in your Login page (Login.aspx in the default starter kit).

Normally, logins should be pulled from the database, active directory, or whatever system your organization uses for storing user info. We also support using your company's existing login page in place of our example login page. If nothing is available, here is a simple method to provide basic authentication. Also included is the callback function used by **btnLogin**'s "OnClick" property.

```csharp
Bool AuthenticateUser(string userName, string password, out bool isAdmin)
{            
	System.Collections.Hashtable Passwords = new System.Collections.Hashtable();
	System.Collections.ArrayList Admins = new System.Collections.ArrayList();
			
	Passwords["Bob"]="password";
	Passwords["Steve"]="password";
	Passwords["Stacey"]="password";
	Passwords["Kim"]="password";
			
	Admins.Add("Bob");
	Admins.Add("Steve");
			
	if(Passwords[userName].Equals(password))
	{
		isAdmin = Admins.Contains(userName);
		return true;
	}
	
	// Could not authenticate
	return false;   
}
void btnLogin_Click(object sender, EventArgs args) 
{
        loginValidator.IsValid = true;
        bool isAdmin;
        if (AuthenticateUser(userNameTextbox.Text, userPassword.Value, out isAdmin)) {
            HttpContext.Current.Session["UserName"] = userNameTextbox.Text;
            if (isAdmin)
                HttpContext.Current.Session["Role"] = "Admin";
            else
                HttpContext.Current.Session["Role"] = "RegularUser";
            global_asax.CustomAdHocConfig.InitializeReporting();
            Response.Redirect("ReportList.aspx");
            Page.Title = "Izenda - " + AdHocSettings.CurrentUserName;
            //FormsAuthentication.RedirectFromLoginPage(userNameTextbox.Text, false);
            return;
        }
        else
            loginValidator.IsValid = false; 
}
```