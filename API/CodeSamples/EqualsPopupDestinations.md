#EqualsPopupDestinations

[[_TOC_]]

##About

Gets or sets a list of aspx pages and column names used to link the Equals(Popup) window to an aspx page. The page runs inside an iframe and uses two methods to pass values from the application to the custom page and back. To learn more about the custom aspx page, you can [[visit this link|http://wiki.izenda.us/API/CodeSamples/Equals-Popup-Custom-Page]].

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
      AdHocSettings.PrintMode = PrintMode.Html2PdfAndHtml;
      AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
      AdHocSettings.EqualsPopupDestinations["MyCustomFilters"] = new string[] { "ShipCountry", "ShipCity", "ShipRegion" };     //relevent setting. The string in the Key must match the name of the custom filters page. The string array values represent the columns that are associated with the page.
```

##Global.asax (VB.NET)

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
            AdHocSettings.EqualsPopupDestinations("MyCustomFilters") = New String() {"ShipCountry", "ShipCity", "ShipRegion" }       // relevent setting. The string in the Key must match the name of the custom filters page. The string array values represent the columns that are associated with the page.
```