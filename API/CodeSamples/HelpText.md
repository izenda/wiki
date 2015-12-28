#HelpText

[[_TOC_]]

##About

Gets or sets the collection of key-value pairs where the key is the tab name and the value is a hint that will be shown when mouse is over the appropriate tab. 
Can be seen in the ReportDesigner if ShowSideHelp is enabled. 

Note: You can also enable/disable side help by clicking the Help button ([[AdHocSettings.ShowHelpButton|http://wiki.izenda.us/API/CodeSamples/ShowHelpButton]] should be enabled).

##Global.asax (C♯)

```csharp
 public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
    {
        // Configure settings
        // Add Custom Setting below license key and connection string setting
        public override void ConfigureSettings()
        {
            AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
            //AdHocSettings.VisibleTables = new string[] { "VIEW1", "TABLE2" };
            Izenda.AdHoc.AdHocSettings.HelpText["Fields"] = "Some help for fields"; //The relevant setting
        }

        // Control what reports are visible for the current user
        public override Izenda.AdHoc.ReportInfo[] ListReports()
        {
            return base.ListReports();
        }

        // Customize a report on the fly prior to execution on a per user basis
        public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
        {
            
        }

    }
```

##Global.asax (VB.net)

```visualbasic
Public Class CustomAdHocConfig
        Inherits Izenda.AdHoc.DatabaseAdHocConfig
        
        ' Configure settings
        ' Add Custom Setting below license key and connection string setting
        Public Overrides Sub ConfigureSettings()
            AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
            'AdHocSettings.VisibleTables = New String() { "VIEW1", "TABLE2" }
            Izenda.AdHoc.AdHocSettings.HelpText("Fields") = "Some help for fields" ' The relevant setting
        End Sub
        
        ' Control what reports are visible for the current user
        Public Overrides Function ListReports() As Izenda.AdHoc.ReportInfo()
            Return MyBase.ListReports
        End Function

        ' Customize a report on the fly prior to execution on a per user basis
        Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet)
        
        End Sub

    End Class
```