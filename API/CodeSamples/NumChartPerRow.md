##About

NumChartPerRow takes an integer (int32). User can customize the number of charts per row that a report contains. By default, the number of charts per row is 2, so user can include 2 charts per a row in a report.
However, by changing NumChartPerRow setting, multiple number of charts can be placed in the same row.

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