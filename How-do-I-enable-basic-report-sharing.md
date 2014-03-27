#How do I enable basic report sharing?

Basic report sharing allows users to decide if they want to share a report or keep it in their private sandbox. It also enables sharing reports in read-only mode which act as templates. This mode allows other users to load a report but not overwrite it. Report creators can find these features in the "Misc" tab of the report designer. In order to use basic report sharing, you will need to set the username and admin status. This needs to happen as part of your application's post-login process. These settings should be set right after the user credentials are authenticated. This example shows the specific code that must called to enable basic report sharing.

```c#
public override void PostLogin()
{  
	Izenda.AdHoc.AdHocSettings.CurrentUserName = "Bob";  
	Izenda.AdHoc.AdHocSettings.CurrentUserIsAdmin =  GetAdminStatus(AdHocSettings.CurrentUserName);
}
```

An essential part of database security is limiting access to tables and views. Izenda Reports provides a setting that allows you to set which tables and views are visible as datasources to your users.

```c#
public override void PostLogin()
{  
	if(GetDept(AdHocSettings.CurrentUserName).Equals("Sales"))   
		AdHocSettings.VisibleDataSources = new string[]    {"Products", "Categories", "Orders"};  
	else
		AdHocSettings.VisibleDataSources = new string[] {"Receivables"};  
}
```

By doing this, you can allow one set of users (or a company) to see some tables, and another set of users to see different tables.