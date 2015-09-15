#Izenda Webform Integration Guide (Sub-directory)

[[_TOC_]]

##About

This guide is designed to instruct first-time users how to integrate Izenda webform kit into a basic ASP.NET website using Visual Studio Express 2013 for Web. In this integration guide, all Izenda files will be placed in a sub-directory called 'Izenda' within the hosting website. This guide will use an Izenda webform kit and a basic ASP.NET website, which can be created using Visual Studio Express 2013 for Web.  

[Izenda webform kit download link](http://archives.izenda.us/ri/webforms/webforms-cs.zip)

[Host Website download link](http://archives.izenda.us/ri/webforms/Integration_Demo.zip)

##Instructions

###Step 1. Open the host website in visual studio

You can also create a new web site in ASP.NET web forms

![1](http://wiki.izenda.us/Guides/Webform-Integration-Sub-Folder/1.png)


###Step 2. Copy contents of /Bin folder in webform kit to Bin folder of website

![1](http://wiki.izenda.us/Guides/Webform-Integration-Sub-Folder/2.png)


###Step 3. Copy contents of Global.asax in webform kit to Global.asax of website

Copy the below code from Global.asax of webform kit to Global.asax of website

```csharp
 [Serializable]
  public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
      //Check to see if we've already initialized.
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      //Initialize System
      AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
      AdHocSettings.SqlServerConnectionString = @"INSERT_CONNECTION_STRING_HERE";
      AdHocSettings.GenerateThumbnails = true;
      AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
      AdHocSettings.ShowSimpleModeViewer = true;
      AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
      AdHocSettings.TabsCssUrl = "Resources/css/tabs.css";
      AdHocSettings.ReportCssUrl = "Resources/css/Report.css";
      AdHocSettings.ShowBetweenDateCalendar = true;
      AdHocSettings.AdHocConfig = new CustomAdHocConfig();
      AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
      // AdHocSettings.ShowHtmlButton = true;
      //AdHocSettings.ShowPDFButton = true;
      //Initialize User
      //AdHocSettings.VisibleDataSources=
      //AdHocSettings.CurrentUserName=
      //AdHocSettings.HiddenFilters["Field"] = new string [] {"value1","value2"};
      //Success!
      HttpContext.Current.Session["ReportingInitialized"] = true;

      AdHocSettings.DashboardDateSliderMode = DashboardDateSliderMode.None;

      AdHocSettings.DashboardViewer = "Dash.aspx";
      AdHocSettings.DashboardDesignerUrl = "Dash.aspx";

      //EOPDF uses a DLL that converts HTML
      //AdHocSettings.PdfPrintMode = PdfMode.EOPDF;
      //PhantomJS PDF uses an EXE on the web server that produces the export
      AdHocSettings.PdfPrintMode = PdfMode.PhantomJs;
    }
    public override void ProcessDataSet(System.Data.DataSet ds, string reportPart) {
      base.ProcessDataSet(ds, reportPart);
    }
    public override void PreExecuteReportSet(ReportSet reportSet) {
      base.PreExecuteReportSet(reportSet);
    }
  }

```

And add Izenda.Adhoc namespace. now global.asax of website should look like as below

```csharp
<%@ Application Language="C#" %>
<%@ Import Namespace="_Sub_Final" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="Izenda.AdHoc" %>


<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
    }


    [Serializable]
    public class CustomAdHocConfig : FileSystemAdHocConfig {
      public static void InitializeReporting() {
        //Check to see if we've already initialized.
        if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
          return;
        //Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
      AdHocSettings.SqlServerConnectionString = @"INSERT_CONNECTION_STRING_HERE";
        AdHocSettings.GenerateThumbnails = true;
        AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
        AdHocSettings.ShowSimpleModeViewer = true;
        AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
        AdHocSettings.TabsCssUrl = "Resources/css/tabs.css";
        AdHocSettings.ReportCssUrl = "Resources/css/Report.css";
        AdHocSettings.ShowBetweenDateCalendar = true;
        AdHocSettings.AdHocConfig = new CustomAdHocConfig();
        AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
        // AdHocSettings.ShowHtmlButton = true;
        //AdHocSettings.ShowPDFButton = true;
        //Initialize User
        //AdHocSettings.VisibleDataSources=
        //AdHocSettings.CurrentUserName=
        //AdHocSettings.HiddenFilters["Field"] = new string [] {"value1","value2"};
        //Success!
        HttpContext.Current.Session["ReportingInitialized"] = true;

        AdHocSettings.DashboardDateSliderMode = DashboardDateSliderMode.None;

        AdHocSettings.DashboardViewer = "Dash.aspx";
        AdHocSettings.DashboardDesignerUrl = "Dash.aspx";

        //EOPDF uses a DLL that converts HTML
        //AdHocSettings.PdfPrintMode = PdfMode.EOPDF;
        //PhantomJS PDF uses an EXE on the web server that produces the export
        AdHocSettings.PdfPrintMode = PdfMode.PhantomJs;
      }
      public override void ProcessDataSet(System.Data.DataSet ds, string reportPart) {
        base.ProcessDataSet(ds, reportPart);
      }
      public override void PreExecuteReportSet(ReportSet reportSet) {
        base.PreExecuteReportSet(reportSet);
      }
    }
    
</script>

```
###Step 4. Copy everything except Global.asax, web.config, and Bin folder from webform kit into the sub folder 'Izenda' of website

Copy everything from webform kit except global.asax, web.config and bin folder to sub folder. In this integration guide, the sub folder is named as 'Izenda'

![3](http://wiki.izenda.us/Guides/Webform-Integration-Sub-Folder/3.png)	
			
###Step 5. Copy OnInit method from Default.master.cs from webform kit to corresponding file/method of website master page

Copy the below method from Default.master.cs of webform kit to Site.master.cs of the website. And add Izenda.AdHoc namespace to Site.master.cs

```csharp

protected override void OnInit(EventArgs e) {
    
    if (!String.IsNullOrEmpty(AdHocSettings.ApplicationHeaderImageUrl)) {
      rightLogo.Src = AdHocSettings.ApplicationHeaderImageUrl;
    }
    if (!AdHocSettings.ShowDesignLinks) {
      string script = "<script type=\"text/javascript\" language=\"javascript\">";
      script += "try { $(document).ready(function() {$('.designer-only').hide(); });}catch(e){}";
      script += " try{ jq$(document).ready(function() {jq$('.designer-only').hide(); });}catch(e){} ";
      script += "</script>";
      Page.Header.Controls.Add(new LiteralControl(script));
    }
    AdHocSettings.ShowSettingsButtonForNonAdmins = false;
  }

```



###Step 6. Copy < Head > Section from Default.master 

**a.** Copy the below code from < Head > section from Default.master of webform kit to the < Head > section of Site.master

```html
 <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta http-equiv="Expires" content="0" />
  <meta http-equiv="Pragma" content="no-cache" />
  <meta name="robots" content="noindex, follow" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="alternate" href="" title="Team Blog - RSS" type="application/rss+xml" />
  <link rel="shortcut icon" href="Resources/FromDLL/Resources/ModernImages/report-icon.png" type='image/png' />
  <link rel="stylesheet" href="Resources/css/reset2.css" type="text/css" />
  <link rel="stylesheet" href="Resources/css/print.css" type="text/css" media="print" />
  <link rel="stylesheet" href="Resources/css/fun.css" type="text/css" />

  <asp:ContentPlaceHolder ID="ChangeableHeader" runat="server">
    <link href="./rs.aspx?css=ModernStyles.bootstrap-responsive" rel="stylesheet" />
    <link href="./rs.aspx?css=ModernStyles.bootstrap" rel="stylesheet" />
    <link href="./rs.aspx?css=ModernStyles.bootstrap-modals" rel="stylesheet" />
    <link href="./rs.aspx?css=ModernStyles.bootstrap-override" rel="stylesheet" />
    <script type="text/javascript" src="//cdnjs.cloudflare.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script type="text/javascript" src="./rs.aspx?js=ModernScripts.jquery-1.7.2.min"></script>
  </asp:ContentPlaceHolder>

  <link rel="stylesheet" href="Resources/css/main.css" type="text/css" />
  <script type="text/javascript" src="./rs.aspx?js=ModernScripts.bootstrap-dropdown"></script>
  <script type="text/javascript" src="./rs.aspx?js=ModernScripts.bootstrap-tab"></script>
  <script type="text/javascript" src="./rs.aspx?js=ModernScripts.bootstrap-transition"></script>
  <script type="text/javascript" src="./rs.aspx?js=ModernScripts.bootstrap-modal"></script>
  <script type="text/javascript" src="Resources/js/main.js"></script>
  <script type="text/javascript">
    //htmlChartColors = ['#ff0000', '#00ff00', '#0000ff', '#910000', '#1aadce', '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a'];
  </script>
  <!-- Page header injection -->
  <asp:ContentPlaceHolder ID="HeadPlaceHolder" runat="server"></asp:ContentPlaceHolder>

```

**b.** In contents copied at previous step, locate five < link > tags which have following href attribute 

href="Resources/...."   and change them to href="Izenda/Resources/...."


**c.** At the end < Head > section, insert the below code snippet. If sub folder has different name, replace the index of 'Izenda' below with that name.
```html
 <script type="text/javascript">
     $(document).ready(function HideHeader() {
       if (window.location.href.indexOf('Izenda') === -1) { 
         document.getElementById('blueHeader').style.display = 'none';
       }
     });
  </script>

```

**d.** Now < Head > section of Site.master should look like as below
```html

<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - My ASP.NET Application</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />





  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta http-equiv="Expires" content="0" />
  <meta http-equiv="Pragma" content="no-cache" />
  <meta name="robots" content="noindex, follow" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="alternate" href="" title="Team Blog - RSS" type="application/rss+xml" />
  <link rel="shortcut icon" href="Izenda/Resources/FromDLL/Resources/ModernImages/report-icon.png" type='image/png' />
  <link rel="stylesheet" href="Izenda/Resources/css/reset2.css" type="text/css" />
  <link rel="stylesheet" href="Izenda/Resources/css/print.css" type="text/css" media="print" />
  <link rel="stylesheet" href="Izenda/Resources/css/fun.css" type="text/css" />

  <asp:ContentPlaceHolder ID="ChangeableHeader" runat="server">
    <link href="./rs.aspx?css=ModernStyles.bootstrap-responsive" rel="stylesheet" />
    <link href="./rs.aspx?css=ModernStyles.bootstrap" rel="stylesheet" />
    <link href="./rs.aspx?css=ModernStyles.bootstrap-modals" rel="stylesheet" />
    <link href="./rs.aspx?css=ModernStyles.bootstrap-override" rel="stylesheet" />
    <script type="text/javascript" src="//cdnjs.cloudflare.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script type="text/javascript" src="./rs.aspx?js=ModernScripts.jquery-1.7.2.min"></script>
  </asp:ContentPlaceHolder>

  <link rel="stylesheet" href="Izenda/Resources/css/main.css" type="text/css" />
  <script type="text/javascript" src="./rs.aspx?js=ModernScripts.bootstrap-dropdown"></script>
  <script type="text/javascript" src="./rs.aspx?js=ModernScripts.bootstrap-tab"></script>
  <script type="text/javascript" src="./rs.aspx?js=ModernScripts.bootstrap-transition"></script>
  <script type="text/javascript" src="./rs.aspx?js=ModernScripts.bootstrap-modal"></script>
  <script type="text/javascript" src="Resources/js/main.js"></script>
  <script type="text/javascript">
    //htmlChartColors = ['#ff0000', '#00ff00', '#0000ff', '#910000', '#1aadce', '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a'];
  </script>
  <!-- Page header injection -->
  <asp:ContentPlaceHolder ID="HeadPlaceHolder" runat="server"></asp:ContentPlaceHolder>


   <script type="text/javascript">
     $(document).ready(function HideHeader() {
       if (window.location.href.indexOf('Izenda') === -1) {
         document.getElementById('blueHeader').style.display = 'none';
       }
     });
  </script>


</head>

``` 



###Step 7. Copy < Body > Section from Default.master  

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


 