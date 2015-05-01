#Izenda MVC Kit Integration Guide 

[[_TOC_]]

##About

This guide is designed to instruct first-time users how to integrate Izenda with simple MVC application. 
This guide will use Izenda mvc5r3 kit, a simple MVC application, which is downloadable at [http://wiki.izenda.us/Guides/MVC-Integration/Sample_MVCApp.zip](http://wiki.izenda.us/Guides/MVC-Integration/Sample_MVCApp.zip), and Visual Studio Express 2013 for Web. 


##Instructions

###Step 1. Open the simple MVC application in Visual Studio


![Open the Application](/Guides/MVC-Integration/Open_Application.png)


###Step 2. Add Izenda.AdHoc.dll and log4net.dll to the project’s reference

Right click on 'References' under project name in Solution Explorer window, then click 'Add Reference'.

Click the 'Browse' button and browse to \mvc5r3\bin, where Izenda.AdHoc.dll and log4net.dll are. Add them to reference. 

![DLL files](/Guides/MVC-Integration/DLLs.png)


###Step 3. Add IzendaStaticResourcesController.cs and IzendaReportingController.cs to the project

IzendaStaticResourcesController.cs and IzendaReportingController.cs are at mvc5r3\Controllers. Add them under Controllers as below.

![Controllers](/Guides/MVC-Integration/Controllers.png)
	
			
###Step 4. Change Namespaces of Controllers 

Change namespaces of IzendaStaticResourcesController.cs and IzendaReportingController.cs to match all other controllers in the application. 
Ex) if the namespace is in other controller file is ABC.Controllers, then MVC3SK.Controllers -> ABC.Controllers

![Controllers](/Guides/MVC-Integration/Namespace.png)

###Step 5. Add Reporting and Resources folders to the project

Add 'Reporting' and 'Resources' from \mvc5r3 to project by dragging and dropping them under Sample_MVCApp in Solution Explorer 

![Controllers](/Guides/MVC-Integration/Resources_Reporting.png)

###Step 6. Add mvc5r3\Views\Reporting folder 

Add the Reporting folder in mvc5r3\Views to the project's Views

![Controllers](/Guides/MVC-Integration/VR.png)

###Step 7. Add  _sitelayout (mvc5r3\Views\Shared) to the project’s Shared under Views

Add  _sitelayout (mvc5r3\Views\Shared) to the project’s Shared under Views

![Controllers](/Guides/MVC-Integration/SiteLayout.png)

###Step 8. Copy code from Global.asax except the first line and paste in project’s Global.asax

Copy code from Global.asax except the first line and paste in project’s Global.asax


##Global.asax from mvc5r3(C♯)

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


The below is how the project's Global.asax should look like.
##Global.asax from Sample_MVCApp(C♯)
```csharp
<%@ Application Codebehind="Global.asax.cs" Inherits="Sample_MVCApp.MvcApplication" Language="C#" %>


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


###Step 9. Copy specificFilerouter and IzendaResource constraint classes from Globa.asax.cs and paste them above MVCapplication class in Global.asax.cs of the project

Copy specificFilerouter and IzendaResource constraint classes from Globa.asax.cs and paste them above MVCapplication class in Global.asax.cs of the project

```csharp
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




###Step 10. Copy RegisterRoutes in MvcApplication class from Global.asax.cs and put it in MvcApplication class of the project’s Global.asax.cs

Copy RegisterRoutes in MvcApplication class from Global.asax.cs and put it in MvcApplication class of the project’s Global.asax.cs

![Controllers](/Guides/MVC-Integration/Namespace.png)

###Step 11. Change the LicenseKey and ConnnectionString in Global.asax of the project

Change the LicenseKey and ConnnectionString in Global.asax of the project

![Controllers](/Guides/MVC-Integration/Namespace.png)

