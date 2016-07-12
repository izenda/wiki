#Security Design Guide - Section 2: Logging in

[[_TOC_]]

##Introduction

Izenda, out of the box, does not come with a log-in mechanism. However, there variables and functions set up to allow you to authenticate Izenda based on your application's log-in process. For those who are using a stand-alone version, we recommend creating a log-in page. Although Izenda comes with a sample log-in page, it should only be used as a guide and customized for your use cases.

##Tips and Best Practices  

* Common ways to deliver authentication from your application are session variables and cookies. Other methods can be used as long as they are able to populate Izenda's variables within the InitializeReporting method.  
* When integrated, common information that we recommend be passed to Izenda includes the User Name, Tenant ID, Admin or Not and Roles.
* The boolean [RequireLogin](http://wiki.izenda.us/API/CodeSamples/RequireLogin) only asserts that the [CurrentUsername](http://wiki.izenda.us/API/CodeSamples/CurrentUserName) is not null or the Izenda default. When it is one of these, the user will be redirected to whatever location is set in the [LoginUrl](http://wiki.izenda.us/API/CodeSamples/LoginUrl) variable.
* There is a sanity check within the InitializeReporting function to ensure that initializtion is run once. We recommend putting code that sets the user outside of this so that it is run every page change. This will ensure that the user hasn't changed and they will only see whatever data they are allowed to see.

##Example Log-In Logic

```csharp
bool AuthenticateUser(string userName, string password, out bool isAdmin) {
          DataSet ds = AdHocContext.Driver.GetDataSet(AdHocContext.Driver.CreateCommand(string.Format("select 1 from employeeLogin where userName = '{0}' and password = '{1}'",userName,password)));
          isAdmin = false;
          string validated = ds.Tables[0].Rows[0][0].ToString();

          if (userName.ToLower() == "admin" || userName.ToLower() == "administrator")
            isAdmin = true;
          
          if (validated.Equals("1"))
            return true;
          else
            return false;
        }

        void Button1_Click(object sender, EventArgs args) {
		try{
          loginValidator.IsValid = true;
          bool isAdmin;
          if (AuthenticateUser(userNameTextbox.Text, userPassword.Value, out isAdmin)) {
            HttpContext.Current.Session["UserName"] = userNameTextbox.Text;
            if (isAdmin)
              HttpContext.Current.Session["Role"] = "Administrator";
            else
              HttpContext.Current.Session["Role"] = "RegularUser";
            FormsAuthentication.RedirectFromLoginPage(userNameTextbox.Text, false);
            return;
          }
          loginValidator.IsValid = false;
		}
		catch(IndexOutOfRangeException e)
		{
			return;
		}
        }
```