#Section 4 - User Types

[[_TOC_]]

##Introduction

The following example shows an example of security that combines report level and data level restrictions.

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

      //Remember to add <%@ Import Namespace="System.Data" %> to your imports
        DataSet tables = AdHocContext.Driver.GetDataSet(AdHocContext.Driver.CreateCommand(
           string.Format("SELECT roleName FROM EmployeeRoles WHERE EmployeeID = {0}", AdHocSettings.CurrentUserName)));
        string[] userRoles = new string[tables.Tables[0].Rows.Count];
        for (int i = 0; i < tables.Tables[0].Rows.Count; i++)
          userRoles [i] = tables.Tables[0].Rows[i][0].ToString();
      
      AdHocSettings.CurrentUserRoles = userRoles ;
      //Set the number of available drop downs for roles in the misc tab of the designer
      //+1 is for the default value of Everyone
      AdHocSettings.NumSharedDropdowns = AdHocSettings.CurrentUserRoles.Length + 1;
      //Set the value of the drop downs in the misc tab for roles
      AdHocSettings.SharedWithValues = AdHocSettings.CurrentUserRoles;
      
	//Please note that for new Izenda Reference Implementations 
	//the default mode for AdHocSettings.CurrentUserIsAdmin is set to TRUE 
      //You must set it to FALSE for share-with values to take effect
      
      //Determine user type permissions
      if (AdHocSettings.CurrentUserRoles.Contains<string>("Admin")) 
      {
        //The following settings allows the user to ignore share with values
        AdHocSettings.CurrentUserIsAdmin = true;
        //Determines if the settings page shortcut icon "wrench" should be shown
        AdHocSettings.ShowSettingsButton = true;
        //Determins if the new drop down, edit and save as functions are available
        AdHocSettings.ShowDesignLinks = true;
        //Setting tenant to global so that reports created can be accessed by others
        //And easily identified to copy to other servers/databases
        AdHocSettings.CurrentUserTenantId = "_global_";

        //Set which datasources the user can view
        //In this case we are pulling all tables, views and procedures
        DataSet ds = AdHocContext.Driver.GetDataSet(AdHocContext.Driver.CreateCommand("select * from sys.objects where type in ('U','P','V')"));
        string[] shownTables = new string[ds.Tables[0].Rows.Count];
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
          shownTables[i] = ds.Tables[0].Rows[i][0].ToString();

        AdHocSettings.VisibleDataSources = shownTables;   
      }
      else if (AdHocSettings.CurrentUserRoles.Contains<string>("Essentials")) {
        AdHocSettings.CurrentUserIsAdmin = false;
        AdHocSettings.ShowSettingsButton = false;
        AdHocSettings.ShowDesignLinks = false;
        //Setting tenant based on third cookie value
        AdHocSettings.CurrentUserTenantId = cookieVals[2];

        //Set which datasources the user can view
        //In this case we are setting a static list

        AdHocSettings.VisibleDataSources = new string[] {"Orders","Shippers","Invoices"};   
      }
      else if (AdHocSettings.CurrentUserRoles.Contains<string>("Pro")) {
        AdHocSettings.CurrentUserIsAdmin = false;
        AdHocSettings.ShowSettingsButton = false;
        AdHocSettings.ShowDesignLinks = false;
        AdHocSettings.CurrentUserTenantId = cookieVals[2];

        //Set which datasources the user can view
        //In this case we are pulling only Views
        DataSet ds = AdHocContext.Driver.GetDataSet(AdHocContext.Driver.CreateCommand("select * from sys.objects where type in ('V')"));
        string[] shownTables = new string[ds.Tables[0].Rows.Count];
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
          shownTables[i] = ds.Tables[0].Rows[i][0].ToString();

        AdHocSettings.VisibleDataSources = shownTables;      
      }
      else if (AdHocSettings.CurrentUserRoles.Contains<string>("Elite")) {
        AdHocSettings.CurrentUserIsAdmin = false;
        AdHocSettings.ShowSettingsButton = false;
        AdHocSettings.ShowDesignLinks = false;
        AdHocSettings.CurrentUserTenantId = cookieVals[2];

        //Set which datasources the user can view
        //In this case we are pulling all tables, views and procedures
        DataSet ds = AdHocContext.Driver.GetDataSet(AdHocContext.Driver.CreateCommand("select * from sys.objects where type in ('U','P','V')"));
        string[] shownTables = new string[ds.Tables[0].Rows.Count];
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
          shownTables[i] = ds.Tables[0].Rows[i][0].ToString();

        AdHocSettings.VisibleDataSources = shownTables;    
      }

    AdHocContext.Initialized = true;
    }

}
```