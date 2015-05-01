#Security Best Practices

[[_TOC_]]

##Page Restriction
Though you can hide buttons, it is still possible for a user to access pages such as the designer by directly entering the URL. As a part of tenant and user level security, you can add the code below to intercept the URL request and navigate them to a different page.

In the examples below, we are checking the URL for the Report Designer. If the user attempted to access it from a report, it will redirect them to the report viewer, otherwise, it will redirect them to the report list page.

This technique can be used for other pages such as the Dashboard Designer and Settings Page.

**NOTE** If you are using the MVC kit, remove ".aspx" from the page references below.

### Code Sample
```csharp
public static void InitializeReporting() {
  //Check to see if we've already initialized.
  if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
    return;
  //Initialize System
  AdHocSettings.LicenseKey = "Insert License Key";
  AdHocSettings.SqlServerConnectionString = @"Insert Connection String";
  AdHocSettings.GenerateThumbnails = true;
  AdHocSettings.DashboardViewer = "Dashboards.aspx";
  AdHocSettings.ShowSimpleModeViewer = true;
  AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
  AdHocSettings.TabsCssUrl = "Resources/css/tabs.css";
  AdHocSettings.ReportCssUrl = "Resources/css/Report.css";
  AdHocSettings.ShowBetweenDateCalendar = true;
  AdHocSettings.AdHocConfig = new CustomAdHocConfig();
  AdHocSettings.PrintMode = PrintMode.Html2PdfAndHtml;
  AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
  AdHocSettings.UseBulkCSV = true;

  //Relevant Code Block
  if(!AdHocSettings.CurrentUserIsAdmin = false) {
    if (HttpContext.Current.Request.Url.ToString().Contains("ReportDesigner.aspx")) {
      if (!string.IsNullOrEmpty(HttpContext.Current.Request.Params["rn"])) {
        HttpContext.Current.Response.Redirect("ReportViewer.aspx?rn=" + HttpContext.Current.Request.Params["rn"]);
      } else {
        HttpContext.Current.Response.Redirect("ReportList.aspx");
      }
    }
  }

  HttpContext.Current.Session["ReportingInitialized"] = true;
}
```
