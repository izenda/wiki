#ShowBetweenDateCalendar

[[_TOC_]]

Gets or sets the value indicating whether calendar controls should be used for the "Between" operation for DateTime filters. 
When enabled, the Between(Calendar) option appears in the Operator dropdown at the Filters tab in the ReportDesigner for DateTime fields. If it is disabled, the option "Between" without "(Calendar)" will be displayed instead. By default, the Between(Calendar) option uses short date notation(unable to specify a time of day) whereas the standard Between option will allow datetimes to be specified.

Default value: true

Below is a sample global.asax using the ShowBetweenDateCalendar setting.

##C♯

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
            AdHocSettings.ShowBetweenDateCalendar = true;

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

##VB.NET

```visualbasic
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
            AdHocSettings.ShowBetweenDateCalendar = True

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

##Screenshots

###AdHocSettings.ShowBetweenDateCalendar = true

![ShowBetweenDateCalendar=true](http://wiki.izenda.us/API/CodeSamples/ShowBetweenDateCalendar/between_date_calendar.png)

###AdHocSettings.ShowBetweenDateCalendar = false

![ShowBetweenDateCalendar=false](http://wiki.izenda.us/API/CodeSamples/ShowBetweenDateCalendar/between_date_no_calendar.png)