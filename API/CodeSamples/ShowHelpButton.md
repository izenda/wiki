#ShowHelpButton

[[_TOC_]]

##About

Gets or set value indicating whether side help should be shown in ReportDesigner. Text in the side help can be filled out using [[AdHocSettings.HelpText|http://wiki.izenda.us/edit/API/CodeSamples/HelpText]]

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
            AdHocSettings.ShowSideHelp = true; //The relevant setting

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
            AdHocSettings.ShowSideHelp = True ' The relevant setting

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