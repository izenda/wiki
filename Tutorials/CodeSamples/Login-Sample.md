#Authentication Function

[[_TOC_]]

##About

This is a simple authentication function you can place in your Login page (Login.aspx in the default starter kit). We will review adding a hard-coded login to the page and enabling that login in the Global.asax file.

##Editing Login.aspx

Normally, logins should be pulled from the database, active directory, or whatever system your organization uses for storing user info. We also support using your company's existing login page in place of our example login page. If nothing is available, here is a simple method to provide basic authentication. Also included is the callback function used by **btnLogin**'s "OnClick" property.

In the global, you will need to define:

AdHocSettings.SharedWithValues = new string[] { "Administrator", "Regular User" };

```csharp
Bool AuthenticateUser(string userName, string password, out bool isAdmin)
{            
        //We can control logins through hashtables, which enable a key (the username) to be associated with a value (the password). We can also have a separate list of admins
        //that can contain duplicate usernames since checking the person's admin status is a separate operation
	System.Collections.Hashtable Passwords = new System.Collections.Hashtable();
	System.Collections.ArrayList Admins = new System.Collections.ArrayList();
			
	Passwords["Bob"]="password"; //Adds a key called "Bob" if it doesn't exist and sets the value to "password"
	Passwords["Steve"]="$tr0ng_pA$$w0rd"; //Adds "Steve"
	Passwords["Stacey"]="password"; //Adds "Stacey"
	Passwords["Kim"]="password"; //Adds "Kim"
			
	Admins.Add("Bob"); //Adds "Bob" as an admin
	Admins.Add("Steve"); //Adds "Steve" as an admin
			
        isAdmin = false; //Ensure false is returned in the "out" direction variable "isAdmin" if authentication fails
	if(Passwords.ContainsKey(userName) && Passwords[userName].Equals(password)) //Authenticate the username with the password
	{
		isAdmin = Admins.Contains(userName); //Check if the user is an admin
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
  Izenda.AdHoc.AdHocSettings.CurrentUserName = userNameTextbox.Text;
  if (isAdmin)
  {
    Izenda.AdHoc.AdHocSettings.CurrentUserIsAdmin = true;
    Izenda.AdHoc.AdHocSettings.CurrentUserRoles = new string[] { "Administrator" };
  }
  else
    Izenda.AdHoc.AdHocSettings.CurrentUserRoles = new string[] { "Regular User" };
  global_asax.CustomAdHocConfig.InitializeReporting();
  FormsAuthentication.RedirectFromLoginPage(userNameTextbox.Text, false);
  return;
}
loginValidator.IsValid = false;
}
```

If you are using a database to hold usernames and passwords, your ``AuthenticateUser()`` method will look slightly different. For instance, you could have a method to load all usernames from the database into an array that you can call from a utility class. Notice that we set the isAdmin property to false before checking if the user is an admin. This will help prevent false positives. You will also notice that we comment out the ``FormsAuthentication.RedirectFromLoginPage`` line. This is because we are using a different redirection technique with ``Response.Redirect`` that will ensure the Report List page is the next page the user sees. We also call ``InitializeReporting()`` at this time. Find out more about the [[InitializeReporting|/FAQ/InitializeReporting]] method.

##Conclusion

After you have set up your global.asax to use ``InitializeReporing()``, you now have basic authentication that integrates with Izenda. You may now use your login page.