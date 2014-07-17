#ChartingEngine

[[_TOC_]]

##About
Gets or sets the charting engine to be DundasCharts or HTMLCharts.

**Default Value:** The Global.asax file in C# is defaulted to be HTMLCharts.  If left unspecified in the global.asax file, it will resort to DundasCharts, which is the default in the Izenda DLL.  For VisualBasic, nothing is defaulted in the Global.asax file, so it is defaulted to DundasCharts.

##Global.asax (C#)

```csharp
public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
      //Check to see if we've already initialized.
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      //Initialize System
      AdHocSettings.LicenseKey = "INSERT LICENSE KEY HERE";
      AdHocSettings.SqlServerConnectionString = @"INSERT CONNECTION STRING HERE";
      AdHocSettings.GenerateThumbnails = true;
      AdHocSettings.DashboardViewer = "Dashboards.aspx";
      AdHocSettings.ShowSimpleModeViewer = true;
      AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
      AdHocSettings.TabsCssUrl = "Resources/css/tabs.css";
      AdHocSettings.ReportCssUrl = "Resources/css/Report.css";
      AdHocSettings.ShowBetweenDateCalendar = true;
      AdHocSettings.AdHocConfig = new CustomAdHocConfig();
      AdHocSettings.PrintMode = PrintMode.Html2PdfAndHtml;
      AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;  //relevent setting, default in Global.asax
   

```

##Global.asax (VB.net)
```visualbasic

 <Serializable()> Public Class CustomAdHocConfig
        Inherits FileSystemAdHocConfig
        Public Shared Sub InitializeReporting()
            'Check to see if we've already initialized.
            If (HttpContext.Current.Session Is Nothing OrElse (Not (HttpContext.Current.Session("ReportingInitialized") Is Nothing))) Then
                Return
            End If
            'Initialize System
            AdHocSettings.LicenseKey = "Insert_license_key_here"
            AdHocSettings.SqlServerConnectionString = "Insert_connction_string_here"
            AdHocSettings.GenerateThumbnails = True
            AdHocSettings.DashboardViewer = "Dashboards.aspx"
            AdHocSettings.ShowSimpleModeViewer = True
            AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$"
            AdHocSettings.TabsCssUrl = "Resources/css/tabs.css"
            AdHocSettings.ReportCssUrl = "Resources/css/Report.css"
            AdHocSettings.ShowBetweenDateCalendar = True
            AdHocSettings.AdHocConfig = New CustomAdHocConfig()
            AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart //relevent setting to change to HTML Charts

```