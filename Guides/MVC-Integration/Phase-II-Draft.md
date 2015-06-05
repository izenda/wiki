#Izenda MVC Kit Integration Guide Phase II

[[_TOC_]]

##About

Phase II Integration is a continuation to the last step of Phase I integration. This guide will show how to add a login page to an MVC application and give different user roles to Izenda based on user login info. This guide will use Izenda mvc5r3 kit, a simple MVC application, which is downloadable at [http://wiki.izenda.us/Guides/MVC-Integration/Sample_MVCApp.zip](http://wiki.izenda.us/Guides/MVC-Integration/Sample_MVCApp.zip), and Visual Studio Express 2013 for Web. 

### Step 1. Connecting to Northwind Database

Get the ConnectionString

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

### Step 6. Add Views

### Step 7. Add user role model

 