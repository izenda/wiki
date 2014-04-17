#AdHocConfig

[[_TOC_]]

##About

The AdHocConfig class is where Izenda Reports will perform all of its initialization and configuration. You can also override various methods used by the base class in order to control various aspects of the reporting application. At a minimum, you will probably need to override the [[ConfigureSettings()|/FAQ/ConfigureSettings]] and [[PostLogin()|/FAQ/PostLogin]] methods. This will work for most cases, but we will provide a template with a full list of overridden methods below. Another core part of the Izenda API is the [[AdHocSettings|]] class. This code should be placed in the Global.asax file of your web site.

##C♯ Example

```csharp
[Serializable]
//The main reporting class, usually declared in global.asax. This can inherit FileSystemAdHocConfig or DatabaseAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.FileSystemAdHocConfig
{
    //Initializing these settings in a static context is a best practice for Izenda to run smoothly. This method will need to be called on your reporting pages or from Session_Start().
    public static void InitializeReporting()
    {
        //Check to see if we've already initialized.
        if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
            return;
        //Initialize System      
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
        AdHocSettings.GenerateThumbnails = True;
        AdHocSettings.DashboardViewer = "Dashboards.aspx";
        AdHocSettings.ShowSimpleModeViewer = True;
        AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$";
        AdHocSettings.TabsCssUrl = "Resources/css/tabs.css";
        AdHocSettings.ReportCssUrl = "Resources/css/Report.css";
        AdHocSettings.ShowBetweenDateCalendar = True;
        AdHocSettings.AdHocConfig = New CustomAdHocConfig();
        HttpContext.Current.Session("ReportingInitialized") = True;

    }
    // Store all global code here that applies to all users. 
    public override void ConfigureSettings()
    {
	AdHocSettings.AllowOverwritingReports = true;
	AdHocSettings.AllowDeletingReports = true;
    }

    // AdHocSettings.AdHocConfig.PostLogin() must be called from 
    // your application's login page after the user is authenticated
    // Place ALL user-specific or role-specific code here
    public override void PostLogin()
    {
	//Pass User Credentials
	AdHocSettings.CurrentUserName = HttpContext.Current.Session["UserName"] as string;
	AdHocSettings.CurrentUserIsAdmin = true;
	AdHocSettings.VisibleDataSources = new string[] { "Orders", "Employees", "AdminData" };

	//Filters results for data sources containing ClientID  
	AdHocSettings.HiddenFilters["ClientID"] = HttpContext.Current.Session["ClientID"] as string;

	//Multi-Role Scenario - Apply specific limitations to certain roles
	string role = HttpContext.Current.Session["Role"] as string;
	if (!role.Equals("Administrator"))
	{
		// Limit user to the orders table    
		AdHocSettings.VisibleDataSources = new string[] { "Orders" };
		// Prevent the user from seeing private reports and overwriting shared reports
		// Disable access to settings button.
		AdHocSettings.CurrentUserIsAdmin = false;
		// Hide reports saved to certain categories
		AdHocSettings.ShowSettingsButton = false;
		AdHocSettings.HiddenCategories = new string[] { "Admin Reports", "Sensitive Reports" };
	}
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
    public override System.Collections.Generic.Dictionary FilteredListReportsDictionary()
    {
	ReportInfo[] reports = ListReports();
	Array.Sort(reports);
	Dictionary result = new Dictionary();

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
public override void PostExecuteReportSet(ReportSet reportSet)
{
	reportSet.WriteXml();
}

// Method called after reportSet was loaded
public override void PostLoadReportSet(string name, ReportSet reportSet)
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

// Returns a list of reports to the reprt viewr and all report list dropdowns
public override ReportInfo[] ListReports()
{
	return new ReportInfo[] { new ReportInfo("report 1"), new ReportInfo("report 2") };
}

// Runs after report export to allow archiving
public override void ArchiveReportOutput(ReportSet reportSet, 
	string[] emails, 
	string extension, 
	byte[] data)
{
// save to archive
	using (BinaryWriter bw = new BinaryWriter(File.Open(reportSet.ReportName + "_sent", FileMode.Create)))
		bw.Write(data);
}

// This method overrides the default behavor of the Equals(...) 
// operators in the filters tab and report viewer.  
// If using Equals(...) with stored procedures, this is required. 
public override string[] ProcessEqualsSelectList(Column column)
{
	if (column.Name == "ParameterField")
		return new string[] { "Value1", "Value2", "Value3" };
	return base.ProcessEqualsSelectList(column);
}

// Control what operators are availabile for each field type in the Filters tab or report viewer
public override string[] GetOperatorList(SqlType type, bool isStoredProcedureUsed)
public override string[] GetOperatorList(SqlType type, bool isStoredProcedureUsed)
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

public override void SaveReportSet(string reportName, ReportSet reportSet)
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
public override void PreExecuteReportSet(ReportSet reportSet)
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
      AdHocSettings.GenerateThumbnails = True
      AdHocSettings.DashboardViewer = "Dashboards.aspx"
      AdHocSettings.ShowSimpleModeViewer = True
      AdHocSettings.IdentifiersRegex = "^.*[iI][Dd]$"
      AdHocSettings.TabsCssUrl = "Resources/css/tabs.css"
      AdHocSettings.ReportCssUrl = "Resources/css/Report.css"
      AdHocSettings.ShowBetweenDateCalendar = True
      AdHocSettings.AdHocConfig = New CustomAdHocConfig()
      HttpContext.Current.Session("ReportingInitialized") = True
    End Sub

'Store all global code here that applies to all users. 
    Public Overrides Sub ConfigureSettings()
      AdHocSettings.AllowOverwritingReports = True
      AdHocSettings.AllowDeletingReports = True
    End Sub
    
    'AdHocSettings.AdHocConfig.PostLogin() must be called from 
    'your application's login page after the user is authenticated
    'Place ALL user-specific or role-specific code here
    Public Overrides Sub PostLogin()
      'Pass User Credentials
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