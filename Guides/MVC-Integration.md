#Izenda MVC Kit Integration Guide Phase I 

[[_TOC_]]

##About

This guide is designed to instruct first-time users how to integrate Izenda with simple MVC application. 
This guide will use Izenda mvc5r3 kit, a simple MVC application, which is downloadable at [http://wiki.izenda.us/Guides/MVC-Integration/Sample_MVCApp.zip](http://wiki.izenda.us/Guides/MVC-Integration/Sample_MVCApp.zip), and Visual Studio Express 2013 for Web. 

[mvc5r3 download link](http://archives.izenda.us/ri/mvc/mvc5r3/)
##Instructions

###Step 1. Open the simple MVC application in Visual Studio


![Open the Application](/Guides/MVC-Integration/Open_Application.png)


###Step 2. Add Izenda.AdHoc.dll and log4net.dll to the project’s reference

Right click on 'References' under project name in Solution Explorer window, then click 'Add Reference'.

Click the 'Browse' button and browse to \mvc5r3\bin, where Izenda.AdHoc.dll and log4net.dll are. Add them to reference. 

![DLL files](/Guides/MVC-Integration/DLLs.png)


###Step 3. Add IzendaStaticResourcesController.cs and IzendaReportingController.cs to the project

IzendaStaticResourcesController.cs and IzendaReportingController.cs are at mvc5r3\Controllers. Add them under Controllers as below (You can add by either 'drag and drop' or 'right click->Add->Existing Item)

![Controllers](/Guides/MVC-Integration/Controllers.png)
	
			
###Step 4. Change Namespaces of Controllers 

Change namespaces of IzendaStaticResourcesController.cs and IzendaReportingController.cs to match all other controllers in the application. 
Ex) if the namespace is in other controller file is ABC.Controllers, then MVC3SK.Controllers -> ABC.Controllers

![Controllers](/Guides/MVC-Integration/Namespace.png)

###Step 5. Add Reporting and Resources folders to the project

**a.** Add 'Reporting'and 'Resources'from \mvc5r3 to project by dragging and dropping them in Solution Explorer as below

![Controllers](/Guides/MVC-Integration/Resources_Reporting.png)

**b.** In Solution Explorer, exclude Dashboards-Body.ascx and Dashboards-Head.ascx from \Resources\html by right click on them and click 'Exclude From Project'

![Controllers](/Guides/MVC-Integration/Exclude.png)

**c.** Copy /Resources folder from the root of the application into the /Reporting folder. This will create two copies of the Resources folder, one in the root and another under the Reporting folder.

**d.** Copy rs.aspx from /Reporting and paste it in /Resources/html as below

![](/Guides/MVC-Integration/rs.png)   


**** If Izenda toolbar icons don't appear, check if Reporting folder contains rs.aspx and Resources folder  ****


###Step 6. Add mvc5r3\Views\Reporting folder 

Add the Reporting folder in mvc5r3\Views to the project's Views

![Controllers](/Guides/MVC-Integration/VR.png)

###Step 7. Add  _sitelayout to project’s Views\Shared

Add _sitelayout from mvc5r3\Views\Shared to project’s Views\Shared

![Controllers](/Guides/MVC-Integration/SiteLayout.png)

###Step 8. Copy code from Global.asax except the first line

**a.** Copy code from Global.asax except the first line 

###Global.asax from mvc5r3(C♯)

```csharp

<%@ Application Codebehind="Global.asax.cs" Inherits="MVC4Razor2.MvcApplication" Language="C#" %> //Copy except this line

<%@ Import Namespace="Izenda.AdHoc"%>
<%@ Import Namespace="System.IO"%>

<script runat="server">
  void Application_AcquireRequestState(object sender, EventArgs e) {
    CustomAdHocConfig.InitializeReporting();
  }

  [Serializable]
  public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
      AdHocSettings.SqlServerConnectionString = @"INSERT_CONNECTION_STRING_HERE";
      AdHocSettings.GenerateThumbnails = true;
      AdHocSettings.ShowSimpleModeViewer = true;
      AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
      AdHocSettings.TabsCssUrl = "/Resources/css/tabs.css";
      AdHocSettings.ReportCssUrl = "../Resources/css/Report.css";
      AdHocSettings.ShowBetweenDateCalendar = true;
      AdHocSettings.DashboardViewer = "Dashboards";
      AdHocSettings.ReportViewer = "ReportViewer";
      AdHocSettings.InstantReport = "InstantReport";
      AdHocSettings.ReportDesignerUrl = "ReportDesigner";
      AdHocSettings.DashboardDesignerUrl = "DashboardDesigner";
      AdHocSettings.ReportList = "ReportList";
      AdHocSettings.SettingsPageUrl = "Settings";
      AdHocSettings.ParentSettingsUrl = "Settings";
      AdHocSettings.ResponseServer = "rs.aspx";
      AdHocSettings.ReportsPath = Path.Combine(HttpContext.Current.Server.MapPath("~/"), "Reports");
      AdHocSettings.PrintMode = PrintMode.Html2PdfAndHtml;
      AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
      AdHocSettings.AdHocConfig = new CustomAdHocConfig();
      HttpContext.Current.Session["ReportingInitialized"] = true;
    }
  }
</script>

```

**b.** Paste it in project’s Global.asax

###Global.asax from Sample_MVCApp(C♯)
```csharp
<%@ Application Codebehind="Global.asax.cs" Inherits="Sample_MVCApp.MvcApplication" Language="C#" %>

//THE BELOW IS PASTED CODE

<%@ Import Namespace="Izenda.AdHoc"%>
<%@ Import Namespace="System.IO"%>

<script runat="server">
  void Application_AcquireRequestState(object sender, EventArgs e) {
    CustomAdHocConfig.InitializeReporting();
  }

  [Serializable]
  public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
      AdHocSettings.SqlServerConnectionString = @"INSERT_CONNECTION_STRING_HERE";
      AdHocSettings.GenerateThumbnails = true;
      AdHocSettings.ShowSimpleModeViewer = true;
      AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
      AdHocSettings.TabsCssUrl = "/Resources/css/tabs.css";
      AdHocSettings.ReportCssUrl = "../Resources/css/Report.css";
      AdHocSettings.ShowBetweenDateCalendar = true;
      AdHocSettings.DashboardViewer = "Dashboards";
      AdHocSettings.ReportViewer = "ReportViewer";
      AdHocSettings.InstantReport = "InstantReport";
      AdHocSettings.ReportDesignerUrl = "ReportDesigner";
      AdHocSettings.DashboardDesignerUrl = "DashboardDesigner";
      AdHocSettings.ReportList = "ReportList";
      AdHocSettings.SettingsPageUrl = "Settings";
      AdHocSettings.ParentSettingsUrl = "Settings";
      AdHocSettings.ResponseServer = "rs.aspx";
      AdHocSettings.ReportsPath = Path.Combine(HttpContext.Current.Server.MapPath("~/"), "Reports");
      AdHocSettings.PrintMode = PrintMode.Html2PdfAndHtml;
      AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
      AdHocSettings.AdHocConfig = new CustomAdHocConfig();
      HttpContext.Current.Session["ReportingInitialized"] = true;
    }
  }
</script>
```


###Step 9. Copy constraints classes from Global.asax.cs


**a.** Copy below two constraints from Global.asax.cs of mvc5r3
```csharp

//IRouteConstraint
public class SpecificFileRouterConstraint : IRouteConstraint {
    private string extensionToBeRouted = null;
    private string fileToBeRouted = null;

    public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection) {
      return !String.IsNullOrEmpty(extensionToBeRouted) && !String.IsNullOrEmpty(fileToBeRouted) && values[extensionToBeRouted] != null && values[extensionToBeRouted].ToString().ToLower().Contains(fileToBeRouted);
    }

    public SpecificFileRouterConstraint() { }

    public SpecificFileRouterConstraint(string extension, string fileName) {
      extensionToBeRouted = extension.ToLower();
      fileToBeRouted = fileName.ToLower();
    }
  }




//IRouteConstraint
public class IzendaResourceConstraint : IRouteConstraint {
    private string extensionToBeRouted = null;

    public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection) {
      if (String.IsNullOrEmpty(extensionToBeRouted) || values[extensionToBeRouted] == null) {
        return false;
      }
      string requestUrl = values[extensionToBeRouted].ToString().ToLower();
      bool result = false;
      if (extensionToBeRouted == "js") {
        result = result || requestUrl.Contains("reportviewerfilters.js");
        result = result || requestUrl.Contains("reportlist.js");
        result = result || requestUrl.Contains("data-sources.js");
        result = result || requestUrl.Contains("data-sources-preview.js");
        result = result || requestUrl.Contains("charts.js");
        result = result || requestUrl.Contains("datasources-search.js");
        result = result || requestUrl.Contains("jquery-1.6.1.min.js");
        result = result || requestUrl.Contains("jquery-ui-1.8.13.custom.min.js");
        result = result || requestUrl.Contains("elrte.full.js");
        result = result || requestUrl.Contains("elrte.ru.js");
        result = result || requestUrl.Contains("fieldproperties.js");
        result = result || requestUrl.Contains("shrinkable-grid.js");
      }
      if (extensionToBeRouted == "css") {
        result = result || requestUrl.Contains("tabs.css");
        result = result || requestUrl.Contains("report.css");
        result = result || requestUrl.Contains("filters.css");
        result = result || requestUrl.Contains("base.css");
        result = result || requestUrl.Contains("report-list-modal.css");
        result = result || requestUrl.Contains("data-sources.css");
        result = result || requestUrl.Contains("charts.css");
        result = result || requestUrl.Contains("jquery-ui-1.8.13.custom.css");
        result = result || requestUrl.Contains("elrte.min.css");
        result = result || requestUrl.Contains("elrte-inner.css");
        result = result || requestUrl.Contains("shrinkable-grid.css");
      }
      if (extensionToBeRouted == "png") {
        result = result || requestUrl.Contains("elrtebg.png");
        result = result || requestUrl.Contains("elrte-toolbar.png");
      }
      if (extensionToBeRouted == "gif") {
        result = result || requestUrl.Contains("elrte/images/pixel.gif");
      }
      return result;
    }

    public IzendaResourceConstraint() { }

    public IzendaResourceConstraint(string extension) {
      extensionToBeRouted = extension.ToLower();
    }
  }

```

**b.** Paste it above MVCapplication class in Global.asax.cs of project

```csharp

namespace Sample_MVCApp
{
    public class SpecificFileRouterConstraint : IRouteConstraint
    {
        private string extensionToBeRouted = null;
        private string fileToBeRouted = null;

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return !String.IsNullOrEmpty(extensionToBeRouted) && !String.IsNullOrEmpty(fileToBeRouted) && values[extensionToBeRouted] != null && values[extensionToBeRouted].ToString().ToLower().Contains(fileToBeRouted);
        }

        public SpecificFileRouterConstraint() { }

        public SpecificFileRouterConstraint(string extension, string fileName)
        {
            extensionToBeRouted = extension.ToLower();
            fileToBeRouted = fileName.ToLower();
        }
    }

    public class IzendaResourceConstraint : IRouteConstraint
    {
        private string extensionToBeRouted = null;

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (String.IsNullOrEmpty(extensionToBeRouted) || values[extensionToBeRouted] == null)
            {
                return false;
            }
            string requestUrl = values[extensionToBeRouted].ToString().ToLower();
            bool result = false;
            if (extensionToBeRouted == "js")
            {
                result = result || requestUrl.Contains("reportviewerfilters.js");
                result = result || requestUrl.Contains("reportlist.js");
                result = result || requestUrl.Contains("data-sources.js");
                result = result || requestUrl.Contains("data-sources-preview.js");
                result = result || requestUrl.Contains("charts.js");
                result = result || requestUrl.Contains("datasources-search.js");
                result = result || requestUrl.Contains("jquery-1.6.1.min.js");
                result = result || requestUrl.Contains("jquery-ui-1.8.13.custom.min.js");
                result = result || requestUrl.Contains("elrte.full.js");
                result = result || requestUrl.Contains("elrte.ru.js");
                result = result || requestUrl.Contains("fieldproperties.js");
                result = result || requestUrl.Contains("shrinkable-grid.js");
            }
            if (extensionToBeRouted == "css")
            {
                result = result || requestUrl.Contains("tabs.css");
                result = result || requestUrl.Contains("report.css");
                result = result || requestUrl.Contains("filters.css");
                result = result || requestUrl.Contains("base.css");
                result = result || requestUrl.Contains("report-list-modal.css");
                result = result || requestUrl.Contains("data-sources.css");
                result = result || requestUrl.Contains("charts.css");
                result = result || requestUrl.Contains("jquery-ui-1.8.13.custom.css");
                result = result || requestUrl.Contains("elrte.min.css");
                result = result || requestUrl.Contains("elrte-inner.css");
                result = result || requestUrl.Contains("shrinkable-grid.css");
            }
            if (extensionToBeRouted == "png")
            {
                result = result || requestUrl.Contains("elrtebg.png");
                result = result || requestUrl.Contains("elrte-toolbar.png");
            }
            if (extensionToBeRouted == "gif")
            {
                result = result || requestUrl.Contains("elrte/images/pixel.gif");
            }
            return result;
        }

        public IzendaResourceConstraint() { }

        public IzendaResourceConstraint(string extension)
        {
            extensionToBeRouted = extension.ToLower();
        }
    }



    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }
}


```


###Step 10. Copy over RegisterRoutes in MvcApplication

**a.** Copy the below class from Global.asax.cs of mvc5r3

```csharp
public static void RegisterRoutes(RouteCollection routes) {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
      routes.MapRoute("IzendaResources", "Reporting/Resources/{*resource}", new { controller = "IzendaStaticResources", action = "Index" });
      routes.MapRoute("IzendaJsResources", "{*js}", new { controller = "IzendaStaticResources", action = "Index" }, new { irc = new IzendaResourceConstraint("js") });
      routes.MapRoute("IzendaCssResources", "{*css}",	new { controller = "IzendaStaticResources", action = "Index" },	new { irc = new IzendaResourceConstraint("css") });
      routes.MapRoute("IzendaPngResources", "{*png}", new { controller = "IzendaStaticResources", action = "Index" }, new { irc = new IzendaResourceConstraint("png") });
      routes.MapRoute("IzendaGifResources", "{*gif}", new { controller = "IzendaStaticResources", action = "Index" }, new { irc = new IzendaResourceConstraint("gif") });
      routes.MapRoute("IzendaReporting", "{controller}/{action}/{id}", new { controller = "Reporting", id = UrlParameter.Optional });
      routes.MapRoute("StarterKitDefault", "{controller}/{action}/{id}", new { controller = "Reporting", action = "ReportList", id = UrlParameter.Optional });
      routes.MapRoute("HomeDefault", "{*pathInfo}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });
    }
```

**b.** Paste it inside MvcApplication class of tproject’s Global.asax.cs

```csharp
public class MvcApplication : System.Web.HttpApplication
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("IzendaResources", "Reporting/Resources/{*resource}", new { controller = "IzendaStaticResources", action = "Index" });
            routes.MapRoute("IzendaJsResources", "{*js}", new { controller = "IzendaStaticResources", action = "Index" }, new { irc = new IzendaResourceConstraint("js") });
            routes.MapRoute("IzendaCssResources", "{*css}", new { controller = "IzendaStaticResources", action = "Index" }, new { irc = new IzendaResourceConstraint("css") });
            routes.MapRoute("IzendaPngResources", "{*png}", new { controller = "IzendaStaticResources", action = "Index" }, new { irc = new IzendaResourceConstraint("png") });
            routes.MapRoute("IzendaGifResources", "{*gif}", new { controller = "IzendaStaticResources", action = "Index" }, new { irc = new IzendaResourceConstraint("gif") });
            routes.MapRoute("IzendaReporting", "{controller}/{action}/{id}", new { controller = "Reporting", id = UrlParameter.Optional });
            routes.MapRoute("StarterKitDefault", "{controller}/{action}/{id}", new { controller = "Reporting", action = "ReportList", id = UrlParameter.Optional });
            routes.MapRoute("HomeDefault", "{*pathInfo}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }

```


###Step 11. Change the LicenseKey and ConnnectionString in Global.asax of project

 To get a new trial key, you may contact [sales@izenda.com](mailto:sales@izenda.com).

```csharp

AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";   
AdHocSettings.SqlServerConnectionString = @"INSERT_CONNECTION_STRING_HERE";

```

###Step 12. Run it!

After Step#11, the Sample_MVCApp should build and work without a problem. To see if Izenda is integrated with this web application,

**a.** Open _Layout.cshtml in Views\Shared\ in Solution Explorer

**b.** Add an ActionLink which leads to Izenda as below

```html
<li>@Html.ActionLink("Home", "Index", "Home")</li>
<li>@Html.ActionLink("About", "About", "Home")</li>
<li>@Html.ActionLink("Contact", "Contact", "Home")</li>
<li>@Html.ActionLink("Izenda", "ReportList", "Reporting")</li>  //Add this line
```

**c.** Notice 'Izenda' item added to the menu as below. Click it and see if it leads to Izenda ReportList page.

![Test](/Guides/MVC-Integration/Test.PNG)


###Step 13. Change the Logo 

**a.** Open _SiteLayout.cshtml in Views\Shared\ in Solution Explorer

**b.** Find below two lines in the body of the html and edit the source image directory, alt, and the link address for top-right image

```html
<img src="~/Resources/FromDLL/Resources/ModernImages/bi-logo.png" alt="Business intelligence" />  //top-left image

<a href="http://izenda.com" style="position: relative; top: 4px;"><img class="right-logo" src="~/Resources/FromDLL/Resources/ModernImages/IzendaNewLogoBlue.png" alt="Izenda Reports" /></a> //top-right image

```
**c.** Run the application and check if the images appear as edited.


In this guide, two images, Logo.png and SeaEagle.png, were put in the project folder, /Sample_MVCApp, and the above two lines were edited as below 

```html
<img src="~/Logo.png" alt="Angry Sea Eagle" />  //top-left image

<a href="http://SeaEagle.com" style="position: relative; top: 4px;"><img class="right-logo" src="~/SeaEagle.png" alt="SeaEagle.Com" /></a> //top-right image
```



Two top logos have changed as below

![Test](/Guides/MVC-Integration/Logo_Change2.png)

[Izenda MVC Kit Integration Guide Phase II](http://wiki.izenda.us/Guides/MVC-Integration/Phase-II-Draft)


 