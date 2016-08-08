#Section 3 - Security Basics

[[_TOC_]]

##Introduction

The following example shows a basic example of security utilizing a combination of AdHocSettings.

##Code Sample

```csharp
[Serializable]
	public class CustomAdHocConfig : DatabaseAdHocConfig 
	{
		public static void InitializeReporting() 
		{
      if (AdHocContext.Initialized) {
        return;
      }
				
      //Your Licence Key
      AdHocSettings.LicenseKey = "Enter Key";
      //Datasource of the DB where the Data sources are stored
      AdHocSettings.SqlServerConnectionString = @"DBconnectionString;";

      AdHocSettings.AdHocConfig = new CustomAdHocConfig();
      AdHocSettings.GenerateThumbnails = true;
	AdHocSettings.ShowSimpleModeViewer = true;
	AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
	AdHocSettings.TabsCssUrl = "/Resources/css/tabs.css";
	AdHocSettings.ReportCssUrl = "../Resources/css/Report.css";
	AdHocSettings.ShowBetweenDateCalendar = true;
	AdHocSettings.ReportViewer = "ReportViewer";
	AdHocSettings.InstantReport = "InstantReport";
	AdHocSettings.ReportDesignerUrl = "ReportDesigner";
	AdHocSettings.ReportList = "ReportList";
	AdHocSettings.SettingsPageUrl = "Settings";
	AdHocSettings.ParentSettingsUrl = "Settings";
	AdHocSettings.ResponseServer = "rs.aspx";
	AdHocSettings.ReportsPath = Path.Combine(HttpContext.Current.Server.MapPath("~/"), "Reports");
	AdHocSettings.ChartingEngine = ChartingEngine.HtmlChart;
	AdHocSettings.ShowModifiedReportMessage = false;
	AdHocSettings.DashboardViewer = "Dash";
	AdHocSettings.DashboardDesignerUrl = "Dash";
	AdHocSettings.DashboardDateSliderMode = DashboardDateSliderMode.None;
	AdHocSettings.ShowJoinDropDown = true;
	AdHocSettings.InstantReport = "InstantReportNew";
	//EOPDF uses a DLL that converts HTML
	//AdHocSettings.PdfPrintMode = PdfMode.EOPDF;
	//PhantomJS PDF uses an EXE on the web server that produces the export
	AdHocSettings.PdfPrintMode = PdfMode.PhantomJs;
	//Asserts that the AdhocSettings.CurrentUserName is not null or the default value
	//If it is an unaccepted value, the user will be navigated to the specified login page
	AdHocSettings.RequireLogin = true;
	//Specifies the login page
	AdHocSettings.LoginUrl = "yourLoginPage.aspx";

      //the default mode for AdHocSettings.CurrentUserIsAdmin is set to TRUE 
      //You must set it to FALSE for share-with values to take effect
      AdHocSettings.CurrentUserIsAdmin = false;
      
      //Get username from session value that was set on Log-in page
        AdHocSettings.CurrentUserName = HttpContext.Current.Session["UserName"];

      //Set which datasources the user can view
        //In this case we are pulling all tables, views and procedures
        DataSet ds = AdHocContext.Driver.GetDataSet(AdHocContext.Driver.CreateCommand("select * from sys.objects where type in ('U','P','V')"));
        string[] shownTables = new string[ds.Tables[0].Rows.Count];
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
          shownTables[i] = ds.Tables[0].Rows[i][0].ToString();

        AdHocSettings.VisibleDataSources = shownTables;
   
	AdHocContext.Initialized = true;
   }
 
}
```