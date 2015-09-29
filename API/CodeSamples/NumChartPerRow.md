##About

NumChartPerRow takes an integer (int32). This changes the number of charts per row that a report may contain. By default, the number of charts per row is 2, so you can have two charts side by side in a report. 

**NOTE:** Having multiple charts per row will override the report part order on the Style tab! Two charts side by side cannot have another report part between them!
##Example

```csharp

 public static void InitializeReporting() {
      //Check to see if we've already initialized.
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      //Initialize System
  
   //   


      AdHocSettings.GenerateThumbnails = true;
      AdHocSettings.DashboardViewer = "Dashboards.aspx";
      AdHocSettings.ShowSimpleModeViewer = true;
      AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
      AdHocSettings.TabsCssUrl = "Resources/css/tabs.css";
      AdHocSettings.ReportCssUrl = "Resources/css/Report.css";
      AdHocSettings.ShowBetweenDateCalendar = true;
      AdHocSettings.AdHocConfig = new CustomAdHocConfig();
      //AdHocSettings.PrintMode = PrintMode.Html2PdfAndHtml;
      AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;


      
      HttpContext.Current.Session["ReportingInitialized"] = true;
      AdHocSettings.DashboardViewer = "Dash.aspx";
      AdHocSettings.DashboardDesignerUrl = "Dash.aspx";


      AdHocSettings.NumChartPerRow = 3;   // Type an integer. Default value is 2
      
      
      AdHocSettings.ShowSqlEditor = true;
    }


```