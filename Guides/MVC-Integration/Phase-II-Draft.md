#Izenda MVC Kit Integration Guide Phase II

[[_TOC_]]

##About

Phase II Integration is a continuation of the last step of Phase I integration. This guide will show how to add a login page and register page to MVC application and give different user roles to Izenda based on user login info. This guide will use Izenda mvc5r3 kit, a simple MVC application, which is downloadable at [http://wiki.izenda.us/Guides/MVC-Integration/Sample_MVCApp.zip](http://wiki.izenda.us/Guides/MVC-Integration/Sample_MVCApp.zip), and Visual Studio Express 2013 for Web. 

### Step 1. Connecting to Northwind Database


(To be added)


### Step 2. Delete unnecessary Login Model files.

The sample MVC app used in the guide already contains its own login model, since we will add a simpler user login model, in order to avoid any unnecessary conflict, delete existing user login files, Controller, Model, and View.

Delete UserController.cs, UserModels.cs, and the whole User folder under Views as below

![](/Guides/MVC-Integration/Phase-II-Draft/1.png) 



### Step 3. Add Link to Izenda

Since the link to Izenda will be visible only to logged in users, cut the actionlink we made in step 12 of Phase I and paste it in _LoginPartial.cshtml, which contains conditional statements on login. 

**a.** Open _Layout.cshtml in Views\Shared\ in Solution Explorer

**b.** Cut the ActionLink which leads to Izenda as below

```html
<li>@Html.ActionLink("Home", "Index", "Home")</li>
<li>@Html.ActionLink("About", "About", "Home")</li>
<li>@Html.ActionLink("Contact", "Contact", "Home")</li>
    <li>@Html.ActionLink("Izenda", "ReportList", "Reporting")</li>  //Cut this line
```

**c.** Open _LoginPartial.cshtml in Views\Shared\ in Solution Explorer

**d.** Paste the ActionLink in IF block as below so that link to Izenda is visible only after logging in

```html

@if (Request.IsAuthenticated) {

    <text>
        Hello, @Html.ActionLink(User.Identity.Name, "Manage", "Account", routeValues: null, htmlAttributes: new { @class = "username", title = "Manage" })
        @using (Html.BeginForm("LogOff", "Account", FormMethod.Post, new { id = "logoutForm" })) {
            @Html.AntiForgeryToken()
            <a href="javascript:document.getElementById('logoutForm').submit()">Log off</a>
          
  <li>@Html.ActionLink("Izenda", "ReportList", "Reporting")</li>        // Paste the action link here

        }
    </text>
}

```

### Step 4. Add Login User Model

![](/Guides/MVC-Integration/Phase-II-Draft/2.png) 

**a.** Right click on Models folder -> Add -> New Item -> Choose class. Name it User.cs ->Add

**b.** Copy and paste below code in User.cs

```csharp
// This is how User.cs should look like
// Our User model only contains username and password

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample_MVCApp.Models {
  public class User {
    [Required]
    [Key]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
  }
}


```

**c.** Right click on Models folder -> Add -> New Item -> Choose class. Name it UserContext.cs ->Add



**d.** Copy and paste below code in UserContext.cs


```csharp
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sample_MVCApp.Models {
  public class UserContext : DbContext {
    public DbSet<User> Users { get; set; }
  }
}

```
### Step 5. Add Controller

![](/Guides/MVC-Integration/Phase-II-Draft/3.png) 

**a.** Right click on Controllers folder -> Add -> Controller -> Name it AccountController.cs -> Add

**b.** Copy and paste the below code in AccountController.cs

```csharp

//This is how AccountController.cs should look like

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample_MVCApp.Models;
using System.Web.Security;
using Izenda.AdHoc;


namespace Sample_MVCApp.Controllers {
  public class AccountController : Controller {

   
    // Login Action. This leads to login page

    public ActionResult Login() {
      return View();
    }

    // Register Action. This leads to register view page
    public ActionResult Register() {
      return View();
    }

    // Post Register Action
 
    [HttpPost]
    public ActionResult Register(User user) {
      using (UserContext db = new UserContext()) {
        if (ModelState.IsValid) {
          db.Users.Add(user);
          db.SaveChanges();
          return RedirectToAction("Login");
        }
        else {
          ModelState.AddModelError("", "Some error has occured.");
          View();
        }
      }
      return View();
    }

    // Post Login Action

    [HttpPost]
    public ActionResult Login(User user) {
      using (UserContext db = new UserContext()) {
        try {
          if (ModelState.IsValid) {
            User us = db.Users.SingleOrDefault(m => m.Username == user.Username);
            if (us != null) {
              if (us.Password == user.Password) {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return RedirectToAction("Index", "Home");
              }
              ModelState.AddModelError("", "Invalid Username or Password");
              return View();
            }
            throw new ArgumentException("User doesn't exists");
          }
        }
        catch (ArgumentException e) {
          ModelState.AddModelError("", e.Message);
          return View();
        }
      }
      return View();
    }

    //Log Out.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult LogOff() {
      FormsAuthentication.SignOut();

      return RedirectToAction("Index", "Home");
    }

  }
}

```

### Step 6. Add Views

![](/Guides/MVC-Integration/Phase-II-Draft/4.png) 

**a.** Open AccountController.cs. Right click on public ActionResult Login()-> Add View->Name it Login -> Add

**b.** Copy and paste below code in Login.cshtml

```html
//This is how Login.cshtml should look like


@model Sample_MVCApp.Models.User
@{
  ViewBag.Title = "Login";
}

<h2>@ViewBag.Title.</h2>
<div class="row">
  <div class="col-md-8">
    <section id="loginForm">
      @using (Html.BeginForm("Login", "Account", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, new { @class = "form-horizontal", role = "form" })) {
        @Html.AntiForgeryToken()
        <h4>Use a local account to log in.</h4>
        <hr />
        @Html.ValidationSummary(true, "", new { @class = "text-danger" })
        <div class="form-group">
          @Html.LabelFor(m => m.Username, new { @class = "col-md-2 control-label" })
          <div class="col-md-10">
            @Html.TextBoxFor(m => m.Username, new { @class = "form-control" })
            @Html.ValidationMessageFor(m => m.Username, "", new { @class = "text-danger" })
          </div>
        </div>
        <div class="form-group">
          @Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" })
          <div class="col-md-10">
            @Html.PasswordFor(m => m.Password, new { @class = "form-control" })
            @Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" })
          </div>
        </div>

        <div class="form-group">
          <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Log in" class="btn btn-default" />
          </div>
        </div>
        <p>
          @Html.ActionLink("Register as a new user", "Register")
        </p>
      }
    </section>
  </div>

</div>

@section Scripts {
  @Scripts.Render("~/bundles/jqueryval")
}


```

**c.** Open AccountController.cs. Right click on public ActionResult Register() -> Add View -> Name it Register -> Add

**d.** Copy and paste the below code in Register.cshtml

```html
//This is how Register.cshtml should look like

@model Sample_MVCApp.Models.User

@{
  ViewBag.Title = "Register";
}

<hgroup class="title">
  <h1>@ViewBag.Title.</h1>
  <h2>Create a new account.</h2>
</hgroup>

@using (Html.BeginForm()) {
  @Html.AntiForgeryToken()
  @Html.ValidationSummary()

  <fieldset>
    <legend>Registration Form</legend>
    <ol>
      <li>
        @Html.LabelFor(m => m.Username)
        @Html.TextBoxFor(m => m.Username)
      </li>
      <li>
        @Html.LabelFor(m => m.Password)
        @Html.PasswordFor(m => m.Password)
      </li>
    </ol>
    <input type="submit" value="Register" />
  </fieldset>
}

@section Scripts {
  @Scripts.Render("~/bundles/jqueryval")
}
```

### Step 7. Run and Test it

After step 6, user should be able to register an account and log in. Then, the link to Izenda should be visible as below

![](/Guides/MVC-Integration/Phase-II-Draft/9.png) 

If the application does not run correctly, and instead the below error message appears,

![](/Guides/MVC-Integration/Phase-II-Draft/5.png) 

then open command prompt and type 'sqllocaldb.exe stop v11.0' and 'sqllocaldb.exe delete v11.0' in order as below

![](/Guides/MVC-Integration/Phase-II-Draft/10.png)
 

### Step 8. Update AccountConroller to set up user roles


**a.** Open AccountController.cs and add user role code in post login action as below

```csharp
//Sample User Role Model
 //Namespace Izenda.Adhoc is needed

                AdHocSettings.CurrentUserName = (string)user.Username;

                if (!AdHocSettings.CurrentUserIsAdmin) {
                  //Sam is an administrator in the system and has full access to everything
                  AdHocSettings.SharedWithValues = new string[] { "Bob", "Sales", "Alice", "Marketing", "Sam", "Mallory" }; //Sam can freely choose who to share with based on department or username
                }
                else {
                  if (AdHocSettings.CurrentUserName == "Bob") {
                    AdHocSettings.CurrentUserRoles = new string[] { "Sales" };
                    AdHocSettings.SharedWithValues = new string[] { "Bob", "Sales", "Alice", "Marketing", "Sam", "PR" }; //Bob can share reports with anyone but Mallory but cannot view reports that are not shared with "Bob" or "Sales"
                  }
                  else if (AdHocSettings.CurrentUserName == "Alice") {
                    AdHocSettings.CurrentUserRoles = new string[] { "Sales", "Marketing" };
                    AdHocSettings.SharedWithValues = new string[] { "Sales", "Alice", "Marketing", "Sam" }; //Alice cannot share reports with Bob or Mallory specifically but Bob can still view reports created by Alice if they are shared with "Sales" and Mallory can view reports shared by Alice if they are shared with "Marketing"
                  }
                  else if (AdHocSettings.CurrentUserName == "Mallory") {
                    AdHocSettings.CurrentUserRoles = new string[] { "PR" };
                    AdHocSettings.SharedWithValues = new string[] { "Sales", "Marketing", "Mallory", "Sam", "Visitor" }; //Mallory can share reports with the Visitor role. 
                  }
                  else {
                    AdHocSettings.CurrentUserRoles = new string[] { "Visitor" }; //visitors cannot share with anyone but can see reports shared with the "Visitor" role
                  }
                }


``` 