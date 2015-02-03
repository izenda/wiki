#AdHocConfig

[[_TOC_]]

##About

The AdHocConfig class is where Izenda Reports will perform all of its initialization and configuration. You can also override various methods used by the base class in order to control various aspects of the reporting application. At a minimum, you will need to set the [[LicenseKey|/API/CodeSamples/LicenseKey]] and the [[connection string|/API/CodeSamples/SqlServerConnectionString]]. However, there are many more customizations you can make to Izenda Reports. We will provide a template with a full list of overridden methods below. You can also find a full list of [[settings|/API/AdHocsettings]] that Izenda can be customized with on our site. This code should be placed in the Global.asax file of your web site.

##Method List

These methods are overridable in any class that inherits from FileSystemAdHocConfig or DatabaseAdHocConfig

* [[ArchiveReportOutput|http://wiki.izenda.us/API/AdHocConfig/ArchiveReportOutput]] - Allows archival of any reports that are viewed/exported/scheduled.
* [[ConfigureSettings|http://wiki.izenda.us/API/AdHocConfig/ConfigureSettings]] - **Obsolete** Allows configuration of global settings all users of the system depend on
* [[CustomizeChart|http://wiki.izenda.us/API/AdHocConfig/CustomizeChart]] - Allows customization of chart objects before they appear on screen.
* [[CustomizeDundasChart|http://wiki.izenda.us/API/AdHocConfig/CustomizeDundasChart]] - Allows chart customization specific to the DundasCharts charting engine.
* [[CustomizeGuage|http://wiki.izenda.us/API/AdHocConfig/CustomizeGuage]] - Allows customization of gauge objects before they appear on screen.
* [[DeleteReportSet|http://wiki.izenda.us/API/AdHocConfig/DeleteReportSet]] - Allows customization for deleting reports.
* [[DeleteTemplate|http://wiki.izenda.us/API/AdHocConfig/DeleteTemplate]] - Allows customization for deleting forms associated with specific reports
* [[DeleteThumbnail|http://wiki.izenda.us/API/AdHocConfig/DeleteThumbnail]] - Allows customization for deleting report thumbnails.
* [[FilteredListReportsDictionary|http://wiki.izenda.us/API/AdHocConfig/FilteredListReportsDictionary]] - Allows customization of the list of reports guaranteed to be available to the user
* [[GetAutoRefreshIntervals|http://wiki.izenda.us/API/AdHocConfig/GetAutoRefreshIntervals]] - Allows end-users to set automatic refresh times on reports and dashboards.
* [[GetCustomFooter|http://wiki.izenda.us/API/AdHocConfig/GetCustomFooter]] - Allows customization of the footer that appears on all reports
* [[GetCustomHeader|http://wiki.izenda.us/API/AdHocConfig/GetCustomHeader]] - Allows customization of the header that appears on all reports
* [[GetOperatorList|http://wiki.izenda.us/API/AdHocConfig/GetOperatorList]] - Allows a customized list of possible SQL logic operators to be used
* [[GetPossibleValuesAsTree|http://wiki.izenda.us/API/AdHocConfig/GetPossibleValuesAsTree]] - Allows a special Equals(Select) dropdown menu to be created that contains a tree structure of values for filters
* [[GetReportIDByName|http://wiki.izenda.us/API/AdHocConfig/GetReportIDByName]] - Allows customization of the process that gets a report ID based on the report name
* [[GetReportNameById|http://wiki.izenda.us/API/AdHocConfig/GetReportNameById]] - Allows customization of the process that gets a report name based on the report ID
* [[IsFieldAllowedInFilters|http://wiki.izenda.us/API/AdHocConfig/IsFieldAllowedInFilters]] - Allows customization of determining whether or not to allow field names in filters
* [[ListReports|http://wiki.izenda.us/API/AdHocConfig/ListReports]] - Allows customization of the process used for obtaining a list of all reports 
* [[LoadReportSet|http://wiki.izenda.us/API/AdHocConfig/LoadReportSet]] - Allows customization of the process for loading report sets
* [[LoadThumbnail|http://wiki.izenda.us/API/AdHocConfig/LoadThumbnail]] - Allows customization of the process for loading report thumbnails
* [[PerformCustomRendering|http://wiki.izenda.us/API/AdHocConfig/PerformCustomRendering]] - Allows customization of the rendering method used when a form report is being rendered
* [[PostExecuteReportSet|http://wiki.izenda.us/API/AdHocConfig/PostExecuteReportSet]] - Allows customization of the ReportSet object currently being processed to be displayed/exported/sent via scheduler
* [[PostLoadReportSet|http://wiki.izenda.us/API/AdHocConfig/PostLoadReportSet]] - Allows customization of the process that occurs after the ReportSet is loaded
* [[PostLogin|http://wiki.izenda.us/API/AdHocConfig/PostLogin]] - **Obsolete** Allows customization of per-user settings once the user has logged in
* [[PostProcessEqualsSelectList|http://wiki.izenda.us/API/AdHocConfig/PostProcessEqualsSelectList]] - Allows customization of the process that runs after the Equals(Select/Checkbox/Popup/Multiple) values have been obtained
* [[PostSaveReportSet|http://wiki.izenda.us/API/AdHocConfig/PostSaveReportSet]] - **Obsolete** Allows customization of the process that occurs after saving a report
* [[PreLoadReportSet|http://wiki.izenda.us/API/AdHocConfig/PreLoadReportSet]] - Allows customization of the process that occurs before loading a report
* [[PreSaveReportSet|http://wiki.izenda.us/API/AdHocConfig/PreSaveReportSet]] - **Obsolete** Allows customization of the process that occurs before saving a report
* [[ProcessDataSet|http://wiki.izenda.us/API/AdHocConfig/ProcessDataSet]] - Allows customization of the process that loads data from the database
* [[ProcessEqualsSelectList|http://wiki.izenda.us/API/AdHocConfig/ProcessEqualsSelectList]] - Allows customization of the process that loads the Equals(Select/Checkbox/Popup/Multiple) values for filters
* [[ProcessFriendlyException|http://wiki.izenda.us/API/AdHocConfig/ProcessFriendlyException]] - Allows customization of how exceptions are handled when AdHocSettings.UseFriendlyErrors is true (Default value is true)
* [[SaveReportRDL|http://wiki.izenda.us/API/AdHocConfig/SaveReportRDL]] - Allows customization of the process that saves the RDL file to disk
* [[SaveReportSet|http://wiki.izenda.us/API/AdHocConfig/SaveReportSet]] - Allows customization of the process that saves the report to the disk/database
* [[SaveTemplate|http://wiki.izenda.us/API/AdHocConfig/SaveTemplate]] - Allows customization of the process that saves the form attached to a report
* [[SaveThumbail|http://wiki.izenda.us/API/AdHocConfig/SaveThumbail]] - Allows customization of the process that saves thumbnails for reports
* [[ThumbnailExists|http://wiki.izenda.us/API/AdHocConfig/ThumbnailExists]] - Allows customization of the process that checks whether thumbnail pictures exist for reports
* [[UpdateMetatdata|http://wiki.izenda.us/API/AdHocConfig/UpdateMetatdata]] - **Obsolete** Forces an update of the database schema

##C♯ Example

```csharp
[Serializable]
//The main reporting class, usually declared in global.asax. This can inherit FileSystemAdHocConfig or DatabaseAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.FileSystemAdHocConfig
{
    //Initializing these settings in a static context is a best practice for Izenda to run smoothly. 
    //This method will need to be called on your reporting pages in the OnPreInit() method.
    public static void InitializeReporting()
    {
        //Check to see if we've already initialized.
        if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
            return;
        //Initialize System      
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
	AdHocSettings.AllowOverwritingReports = true;
	AdHocSettings.AllowDeletingReports = true;
        //After initializing, set global settings applicable to all users
        AdHocSettings.GenerateThumbnails = True;
        AdHocSettings.DashboardViewer = "Dashboards.aspx";
        AdHocSettings.ShowSimpleModeViewer = True;
        AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
        AdHocSettings.TabsCssUrl = "Resources/css/tabs.css";
        AdHocSettings.ReportCssUrl = "Resources/css/Report.css";
        AdHocSettings.ShowBetweenDateCalendar = True;
        AdHocSettings.AdHocConfig = New CustomAdHocConfig();

	//Pass User Credentials. Set user-specific settings after we initialize the user
	AdHocSettings.CurrentUserName = HttpContext.Current.Session["UserName"] as string;
	AdHocSettings.VisibleDataSources = new string[] { "Orders", "Employees", "AdminData" };

	//Filters results for data sources containing ClientID  
	AdHocSettings.HiddenFilters["ClientID"] = HttpContext.Current.Session["ClientID"] as string;

	//Multi-Role Scenario - Apply specific limitations to certain roles
	string role = HttpContext.Current.Session["Role"] as string;
	AdHocSettings.CurrentUserIsAdmin = role == "Administrator" ? true : false;
	if (!role.Equals("Administrator"))
	{
		// Limit user to the orders table    
		AdHocSettings.VisibleDataSources = new string[] { "Orders" }; //Will override the previous setting
		// Prevent the user from seeing private reports and overwriting shared reports
		// Disable access to settings button.
		AdHocSettings.CurrentUserIsAdmin = false;
		// Hide reports saved to certain categories
		AdHocSettings.ShowSettingsButton = false;
		AdHocSettings.HiddenCategories = new string[] { "Admin Reports", "Sensitive Reports" };
	}
        if (role.Equals("Viewer"))
        {
                //Limit users' ability to save, modify, or delete reports
                AdHocsettings.ShowSaveControls = false;
                AdHocSettings.AllowDeletingReports = false;
                //Limit users' ability to design reports
                AdHocSettings.ShowDesignLinks = false;
        }
        HttpContext.Current.Session["ReportingInitialized"] = true;
    }

    // Gets a list of ReportInfo objects for all loadable reports stored.
    public override ReportInfo[] FilteredListReports()
    {
	ReportInfo[] reports = ListReports();
	ArrayList result = new ArrayList();

	foreach (ReportInfo info in reports)
	{
		if (info.Category == "Hidden reports")
			continue;
		ReportSet reportSet = LoadFilteredReportSet(info.Name);
		if (reportSet != null && reportSet.CanBeLoaded)
			result.Add(info);
	}
	return (ReportInfo[])result.ToArray(typeof(ReportInfo));
    }

    // Gets a list of ReportInfo for all loadable reports stored in the storage.
    public override System.Collections.Generic.Dictionary<Izenda.AdHoc.ReportInfo, Izenda.AdHoc.ReportSet> FilteredListReportsDictionary()
    {
	ReportInfo[] reports = ListReports();
	Array.Sort(reports);
	Dictionary<Izenda.AdHoc.ReportInfo, Izenda.AdHoc.ReportSet> result = new Dictionary<Izenda.AdHoc.ReportInfo, Izenda.AdHoc.ReportSet>();

	foreach (ReportInfo info in reports)
	{
		if (info.Category == "Hidden reports")
			continue;
		ReportSet reportSet = LoadFilteredReportSet(info.Name);
		if (reportSet != null && reportSet.CanBeLoaded)
			result.Add(info, reportSet);
	}
	return result;
    }

    // Convert report full name into report GUID
    public override string GetReportIDByName(string fullReportName)
    {
	if (fullReportName == "report_1")
		return base.GetReportIDByName("report_2");
	else
		return base.GetReportIDByName(fullReportName);
    }

// Convert report GUID into report full name
public override string GetReportNameById(string id)
{
	if (id == "report_1")
		return base.GetReportNameById("report_2");
	else
		return base.GetReportNameById(id);
}

// Method called after ReportSet was executed
public override void PostExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
{
	reportSet.WriteXml();
}

// Method called after reportSet was loaded
public override void PostLoadReportSet(string name, Izenda.AdHoc.ReportSet reportSet)
{
	base.PostLoadReportSet(name, reportSet);
}

public override void PreLoadReportSet(string name)
{
	base.PreLoadReportSet(name);
}

// Overrides the method of saving report in .rdl format
public override void SaveReportRDL(string reportName)
{
	// Get file path
	string rdlFilePath = "C:\\Reports\\RDL\\" + reportName + ".rdl";

	// Build rdl content
	StringBuilder builder = new StringBuilder();

	XmlTextWriter writer = new XmlTextWriter(new StringWriter(builder));
	Izenda.AdHoc.AdHocContext.CurrentReportSet.WriteRdl(writer);
	writer.Flush();
	// Write content to file
	File.WriteAllText( rdlFilePath, builder.ToString());
}

// Returns a list of reports to the report viewer and all report list dropdowns
public override ReportInfo[] ListReports()
{
	return new ReportInfo[] { new ReportInfo("report 1"), new ReportInfo("report 2") };
}

// Runs after report export to allow archiving
public override void ArchiveReportOutput(Izenda.AdHoc.ReportSet reportSet, 
	string[] emails, 
	string extension, 
	byte[] data)
{
// save to archive
	using (BinaryWriter bw = new BinaryWriter(File.Open(reportSet.ReportName + "_sent", FileMode.Create)))
		bw.Write(data);
}

// This method overrides the default behavior of the Equals(...) 
// operators in the filters tab and report viewer.  
// If using Equals(...) with stored procedures, this is required. 
public override string[] ProcessEqualsSelectList(Izenda.AdHoc.Database.Column column)
{
	if (column.Name == "ParameterField")
		return new string[] { "Value1", "Value2", "Value3" };
	return base.ProcessEqualsSelectList(column);
}

// Control what operators are available for each field type in the Filters tab or report viewer
public override string[] GetOperatorList(Izenda.AdHoc.Database.SqlType type, bool isStoredProcedureUsed)
{
	string[] result = base.GetOperatorList(type, isStoredProcedureUsed);
	string[] cutResult = new string[result.Length / 2];
	Array.Copy(result, cutResult, result.Length / 2);
	return cutResult;
}

// Executes whenever an existing report is loaded or executed
public override ReportSet LoadReportSet(string reportName)
{
	ReportSet rs = new ReportSet();
	using (StreamReader sr = new StreamReader(reportName + ".xml"))
		rs.ReadXml(sr.ReadToEnd());
	return rs;
}

public override void SaveReportSet(string reportName, Izenda.AdHoc.ReportSet reportSet)
{
	using (StreamWriter sw = new StreamWriter(reportName + ".xml"))
		sw.Write(reportSet.WriteXml());
}

public override void DeleteReportSet(string reportName)
{
	File.Delete(reportName + ".xml");
}

// Create new types of charts or customize existing styles
public override void CustomizeChart(object chart, Hashtable properties)
{
	if (!properties.ContainsKey("NoAA"))
		return;
	if ((bool)properties["NoAA"])
		((Dundas.Charting.WebControl.Chart)chart).AntiAliasing = Dundas.Charting.WebControl.AntiAliasing.None;
}

// Create new types of charts or customize existing styles
public override void CustomizeChart(object chart)
{
	((Dundas.Charting.WebControl.Chart)chart).AntiAliasing = Dundas.Charting.WebControl.AntiAliasing.None;
}

// Process exeptions in a custom manner
public override Control ProcessFriendlyException(Exception exception)
{
	return new LiteralControl("exception occurred "  + exception.Message);
}

// Add additional style elememnts to the guage 
public override System.Drawing.Image CustomizeGuage(double value, 
	double min, 
	double max, 
	string name, 
	System.Drawing.Image GuageImage)
{
	GuageImage.Save("rendered_gauge.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
	return GuageImage;
}

// Dynamically modify the report before execution.  
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
{
	reportSet.Footer = DateTime.Now.ToString();
}

// Dynamically modify the results after they come back 
// from the database and before they are rendered
public override void ProcessDataSet(DataSet ds, string reportPart)
{
	if (reportPart == "Chart")
		ds.Tables[0].Rows[0][0] = "modified_data";
}

}
```

##VB.NET Example

```visualbasic

<Serializable()> Public Class CustomAdHocConfig
    Inherits FileSystemAdHocConfig
    Public Shared Sub InitializeReporting()
      'Check to see if we've already initialized.
      If (HttpContext.Current.Session Is Nothing OrElse (Not (HttpContext.Current.Session("ReportingInitialized") Is Nothing))) Then
        Return
      End If
      'Initialize System
      AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
      AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
      'After initializing, set global settings applicable to all users
      AdHocSettings.AllowOverwritingReports = True
      AdHocSettings.AllowDeletingReports = True
      AdHocSettings.GenerateThumbnails = True
      AdHocSettings.DashboardViewer = "Dashboards.aspx"
      AdHocSettings.ShowSimpleModeViewer = True
      AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$"
      AdHocSettings.TabsCssUrl = "Resources/css/tabs.css"
      AdHocSettings.ReportCssUrl = "Resources/css/Report.css"
      AdHocSettings.ShowBetweenDateCalendar = True
      AdHocSettings.AdHocConfig = New CustomAdHocConfig()
      HttpContext.Current.Session("ReportingInitialized") = True

      'Pass User Credentials. Set user-specific settings after we initialize the user
      AdHocSettings.CurrentUserName = HttpContext.Current.Session("UserName").ToString()
      AdHocSettings.CurrentUserIsAdmin = True
      AdHocSettings.VisibleDataSources = New String() {"Orders", "Employees", "AdminData"}
      'Filters results for data sources containing ClientID  
      AdHocSettings.HiddenFilters("ClientID") = HttpContext.Current.Session("ClientID").ToString()
      'Multi-Role Scenario - Apply specific limitations to certain roles
      Dim role As String = HttpContext.Current.Session("Role").ToString()
      If Not role.Equals("Administrator") Then
        'Limit user to the orders table    
        AdHocSettings.VisibleDataSources = New String() {"Orders"}
        'Prevent the user from seeing private reports and overwriting shared reports
        'Disable access to settings button.
        AdHocSettings.CurrentUserIsAdmin = False
        'Hide reports saved to certain categories
        AdHocSettings.ShowSettingsButton = False
        AdHocSettings.HiddenCategories = New String() {"Admin Reports", "Sensitive Reports"}
      End If
    End Sub

    'Gets a list of ReportInfo objects for all loadable reports stored.
    Public Overrides Function FilteredListReports() As ReportInfo()
      Dim reports As ReportInfo() = ListReports()
      Dim result As New List(Of ReportInfo)

      For Each info As ReportInfo In reports
        If Not info.Category = "Hidden reports" Then
          Dim reportSet As ReportSet = LoadFilteredReportSet(info.Name)
          If reportSet IsNot Nothing AndAlso reportSet.CanBeLoaded Then
            result.Add(info)
          End If
        End If
      Next
      Return result.ToArray()
    End Function

    'Gets a list of ReportInfo for all loadable reports stored in the storage.
    Public Overrides Function FilteredListReportsDictionary() As Dictionary(Of ReportInfo, ReportSet)
      Dim reports As ReportInfo() = ListReports()
      Array.Sort(reports)
      Dim result As Dictionary(Of ReportInfo, ReportSet) = New Dictionary(Of ReportInfo, ReportSet)

      For Each info As ReportInfo In reports
        If Not (info.Category = "Hidden reports") Then
          Dim reportSet As ReportSet = LoadFilteredReportSet(info.Name)
          If reportSet IsNot Nothing AndAlso reportSet.CanBeLoaded Then
            result.Add(info, reportSet)
          End If
        End If
      Next
      Return result
    End Function

    'Convert report full name into report GUID
    Public Overrides Function GetReportIDByName(fullReportName As String) As String
      If (fullReportName = "report_1") Then
        Return MyBase.GetReportIDByName("report_2")
      Else
        Return MyBase.GetReportIDByName(fullReportName)
      End If
    End Function

    'Convert report GUID into report full name
    Public Overrides Function GetReportNameById(id As String) As String
      If (id = "report_1") Then
        Return MyBase.GetReportNameById("report_2")
      Else
        Return MyBase.GetReportNameById(id)
      End If
    End Function
    
    'Method called after ReportSet was executed
    Public Overrides Sub PostExecuteReportSet(reportSet As ReportSet)
      reportSet.WriteXml()
    End Sub

    'Method called after reportSet was loaded
    Public Overrides Sub PostLoadReportSet(name As String, reportSet As ReportSet)

      MyBase.PostLoadReportSet(name, reportSet)
    End Sub
    
    Public Overrides Sub PreLoadReportSet(name As String)
      MyBase.PreLoadReportSet(name)
    End Sub
    
    'Overrides the method of saving report in .rdl format
    Public Overrides Sub SaveReportRDL(reportName As String)

      'Get file path
      Dim rdlFilePath As String = "C:\\Reports\\RDL\\" + reportName + ".rdl"

      'Build rdl content
      Dim builder As New StringBuilder()

      Dim writer As New XmlTextWriter((New StringWriter(builder)))
      Izenda.AdHoc.AdHocContext.CurrentReportSet.WriteRdl(writer)
      writer.Flush()
      'Write content to file
      File.WriteAllText(rdlFilePath, builder.ToString())
    End Sub

    'Returns a list of reports to the reprt viewr and all report list dropdowns
    Public Overrides Function ListReports() As ReportInfo()
      Return New ReportInfo() {New ReportInfo("report 1"), New ReportInfo("report 2")}
    End Function

    'Runs after report export to allow archiving
    Public Overrides Sub ArchiveReportOutput(reportSet As ReportSet, _
                      emails As String(), _
                      extension As String, _
                      data As Byte())
      'save to archive
      Using bw As New BinaryWriter(File.Open(reportSet.ReportName + "_sent", FileMode.Create))
        bw.Write(data)
      End Using
    End Sub

    'This method overrides the default behavor of the Equals(...) 
    'operators in the filters tab and report viewer.  
    'If using Equals(...) with stored procedures, this is required. 
    Public Overrides Function ProcessEqualsSelectList(column As Column) As String()
      If column.Name = "ParameterField" Then
        Return New String() {"Value1", "Value2", "Value3"}
      End If
      Return MyBase.ProcessEqualsSelectList(column)
    End Function

    'Control what operators are availabile for each field type in the Filters tab or report viewer
    Public Overrides Function GetOperatorList(type As SqlType, isStoredProcedureUsed As Boolean) As String()
      Dim result As String() = MyBase.GetOperatorList(type, isStoredProcedureUsed)
      Dim cutResult(result.Length / 2) As String
      Array.Copy(result, cutResult, CLng(result.Length / 2))
      Return cutResult
    End Function

    'Executes whenever an existing report is loaded or executed
    Public Overrides Function LoadReportSet(reportName As String) As ReportSet
      Dim rs As New ReportSet()
      Using sr As New StreamReader(reportName + ".xml")
        rs.ReadXml(sr.ReadToEnd())
      End Using
      Return rs
    End Function

    Public Overrides Sub SaveReportSet(reportName As String, reportSet As ReportSet)
      Using sw As New StreamWriter(reportName + ".xml")
        sw.Write(reportSet.WriteXml())
      End Using
    End Sub

    Public Overrides Sub DeleteReportSet(reportName As String)
      File.Delete(reportName + ".xml")
    End Sub

    'Create new types of charts or customize existing styles
    Public Overrides Sub CustomizeChart(chart As Object, properties As Hashtable)
      If Not properties.ContainsKey("NoAA") Then
        Return
      End If
      If CBool(properties("NoAA")) Then
        DirectCast(chart, Dundas.Charting.WebControl.Chart).AntiAliasing = Dundas.Charting.WebControl.AntiAliasing.None
      End If
    End Sub

    'Create new types of charts or customize existing styles
    Public Overrides Sub CustomizeChart(chart As Object)
      DirectCast(chart, Dundas.Charting.WebControl.Chart).AntiAliasing = Dundas.Charting.WebControl.AntiAliasing.None
    End Sub

    'Process exeptions in a custom manner
    Public Overrides Function ProcessFriendlyException(exception As Exception) As Control
      Return New LiteralControl("exception occurred " + exception.Message)
    End Function

    'Add additional style elememnts to the guage 
    Public Overrides Function CustomizeGuage(value As Double, _
                      min As Double, _
                      max As Double, _
                      name As String, _
                      GuageImage As System.Drawing.Image) As System.Drawing.Image
      GuageImage.Save("rendered_gauge.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
      Return GuageImage
    End Function

    'Dynamically modify the report before execution.  
    Public Overrides Sub PreExecuteReportSet(reportSet As ReportSet)
      reportSet.Footer = DateTime.Now.ToString()
    End Sub

    'Dynamically modify the results after they come back 
    'from the database and before they are rendered
    Public Overrides Sub ProcessDataSet(ds As DataSet, reportPart As String)
      If reportPart = "Chart" Then
        ds.Tables(0).Rows(0)(0) = "modified_data"
      End If
    End Sub
End Class
```