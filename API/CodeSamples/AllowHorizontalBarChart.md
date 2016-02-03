#AllowHorizontalBarChart

[[_TOC_]]

##About 
Gets or sets access to the "horizontal" checkbox in the chart editor tab.  When the box is checked, bar charts will run horizontally instead of vertically.  

**Default Value:** The default value is set to true, which displays a "Horizontal" check box in the chart editor page.

##Global.asax (C#)
```csharp
public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
      //Check to see if we've already initialized.
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      //Initialize System
      AdHocSettings.LicenseKey = "Insert_license_key_here";
      AdHocSettings.SqlServerConnectionString = @"insert_connection_string_here";
      AdHocSettings.GenerateThumbnails = true;
      AdHocSettings.DashboardViewer = "Dashboards.aspx";
      AdHocSettings.ShowSimpleModeViewer = true;
      AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
      AdHocSettings.TabsCssUrl = "Resources/css/tabs.css";
      AdHocSettings.ReportCssUrl = "Resources/css/Report.css";
      AdHocSettings.ShowBetweenDateCalendar = true;
      AdHocSettings.AdHocConfig = new CustomAdHocConfig();
      AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
      AdHocSettings.AllowHorizontalBarChart = false;     //relevent setting, setting to false removes horizontal checkbox option for bar chart editor
```

##Global.asax (VB.net)
```visualbasic
Public Class CustomAdHocConfig
 Inherits FileSystemAdHocConfig
        Public Shared Sub InitializeReporting()
            'Check to see if we've already initialized.
            If (HttpContext.Current.Session Is Nothing OrElse (Not (HttpContext.Current.Session("ReportingInitialized") Is Nothing))) Then
                Return
            End If
            'Initialize System
            AdHocSettings.LicenseKey = "insert_license_key_here"
            AdHocSettings.SqlServerConnectionString = "insert_connection_string_here"
            AdHocSettings.GenerateThumbnails = True
            AdHocSettings.DashboardViewer = "Dashboards.aspx"
            AdHocSettings.ShowSimpleModeViewer = True
            AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$"
            AdHocSettings.TabsCssUrl = "Resources/css/tabs.css"
            AdHocSettings.ReportCssUrl = "Resources/css/Report.css"
            AdHocSettings.ShowBetweenDateCalendar = True
            AdHocSettings.AdHocConfig = New CustomAdHocConfig()
            AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart
            AdHocSettings.AllowHorizontalBarChart = False        // relevent setting
```