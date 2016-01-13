#TimeZoneOffset

[[_TOC_]]

##About
Sets an hour shift applied to each datetime in an Izenda report, in both data and filters. It is added before a report is executed, but not saved as part of the base report. This allows for all times to be shifted by a specific amount, which can be varied depending on the user or set globally. To change the time zone offset applied to the time stamp of an exported report, use [[Report Time Stamp Time Zone Offset|http://wiki.izenda.us/API/CodeSamples/ReportTimeStampTimeZoneOffset]].

**Default Value:** By default no action is taken. If a TimeZoneOffset is set, then that value will be applied to all datetimes. For example, a TimeZoneOffset of -10 will cause all datetimes to be passed to the database as DATEADD(Hour, -10, [OrderDate])
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
      AdHocSettings.TimeZoneOffset = 5
   

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
            AdHocSettings.TimeZoneOffset = 5

```