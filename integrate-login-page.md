#Integrate Your Login Page

Izenda Reports ships with a sample login page, login.aspx, which is ready for customization. To learn how to customize your login.aspx, click [[here|Controlling user logins and login customization]] . During the login process, your login page will need to set the user name and admin status. Once the user information is obtained from the login page, we check what company the user belongs to and make settings changes based upon this. The setting that is used to set per-user settings is the ``PostLogin()`` method, and it should be called from your login page after setting the username and admin status but before you redirect to Izenda Reports.

```csharp
public override void PostLogin()

{

  //Set connection string per-tenant

  AdHocSettings.SqlServerConnectionString=

  GetConnectionStringByCompany();


  //Set the stored reports file folder path per-tenant

  AdHocSettings.ReportsPath="\\"   GetUserCompany()   "\\"   

  GetUserDepartment();


  //Set table and view access

  AdHocSettings.VisibleDataSources = GetTables(GetUserRole);          


  //Set all other settings

  AdHocSettings.ShowAdminButton = GetAdminStatus();

  AdHocSettings.ShowModifyButton = GetAdminStatus();  


  if  (GetUserCompany()=="AcmeWidget")

  {

    //Acme Widget wanted some custom settings that no other 

    //company wanted so we put them here

    AdHocSettings.Formats["Currency"] = "{0:#,###.##}";


    //Acme Widget wanted custom roles so we              

    //set settings for custom roles you define


    if (GetUserRole()=="PowerUser")

    {

      AdHocSettings.ShowModifyButton=true;

      AdHocSettings.AllowDeletingReports=false; 

    }

  }

} //end postlogin
```