#LicenseKey

[[_TOC_]]

This setting is required to run Izenda and must be entered as one of the very first settings in the initialization code for Izenda to run properly.

##Global.asax (C♯)
```csharp
<%@ Application Language="C#" %>
<%@ Import Namespace="Izenda.AdHoc" %>

<script runat="server">

    void Session_Start(object sender, EventArgs e) 
    {
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
        Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    }

    public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
    {
        // Configure settings
        // Add Custom Setting below license key and connection string setting
        public override void ConfigureSettings()
        {
            AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
            //AdHocSettings.VisibleTables = new string[] { "VIEW1", "TABLE2" };
            AdHocSettings.LicenseKey = "INSERT LICENSE KEY HERE";

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
</script>
```

##Global.asax (VB.NET)

```vb.net
<%@ Application Language="VB" %>
<%@ Import Namespace="Izenda.AdHoc" %>

<script runat="server">

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
    End Sub
    
    Public Class CustomAdHocConfig
        Inherits Izenda.AdHoc.DatabaseAdHocConfig
        
        ' Configure settings
        ' Add Custom Setting below license key and connection string setting
        Public Overrides Sub ConfigureSettings()
            AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
            'AdHocSettings.VisibleTables = New String() { "VIEW1", "TABLE2" }
            AdHocSettings.LicenseKey = "INSERT LICENSE KEY HERE"

        End Sub
        
        ' Control what reports are visible for the current user
        Public Overrides Function ListReports() As Izenda.AdHoc.ReportInfo()
            Return MyBase.ListReports
        End Function

        ' Customize a report on the fly prior to execution on a per user basis
        Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet)
        
        End Sub

    End Class

</script>
```