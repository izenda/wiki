#PreExecuteReportSet()

[[_TOC_]]

##About

The PreExecuteReportSet method is used to modify the report before it is sent to the Report Viewer or Report Preview for viewing. Overriding this method can add granular control of fields, filters, and other properties of the report before the person designing/viewing the report will see it. This method should be overridden inside your CustomAdHocConfig class within your global.asax page.

##Global.asax (C♯)

```csharp
public class CustomAdHocConfig : DatabaseAdHocConfig
{
        public static void InitializeReporting() 
        {
                //Check to see if we've already initialized.
                if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
                    return;
                AdHocSettings.LicenseKey = "INSERT_YOUR_LICENSE_KEY_HERE";
                AdHocSettings.SqlServerConnectionString = "INSERT_YOUR_CONNECTION_STRING_HERE";
                AdHocSettings.AdHocConfig = new CustomAdHocConfig();
                //Global and per-user initialization settings will be configured here
                HttpContext.Current.Session["ReportingInitialized"] = true;
        }

        public override void PreExecuteReportSet(ReportSet reportSet)
        { 
                //put your own custom code inside this method
        }
}
```

##Global.asax (VB.NET)

```visualbasic
Public Class CustomAdHocConfig 
                        Inherits DatabaseAdHocConfig
        Public Shared Sub InitializeReporting() 
                'Check to see if we've already initialized.
                If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
                    Return
                'Initialize System
                AdHocSettings.LicenseKey = "INSERT_YOUR_LICENSE_KEY_HERE"
                AdHocSettings.SqlServerConnectionString = "INSERT_YOUR_CONNECTION_STRING_HERE"
                AdHocSettings.AdHocConfig = New CustomAdHocConfig()
                'Global and per-user initialization settings will be configured here
                HttpContext.Current.Session("ReportingInitialized") = True
        End Sub

        Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet) 
                'put your own custom code inside this method
        End Sub
}
```
##Examples

Here are a couple examples of using the PreExecuteReportSet method.

* [[Hidden Filter Example|/FAQ/applying-hidden-filter-using-inner-query]]
* [[Using Stored Procedures|/FAQ/Questions/Using-Stored-Procedures-In-Izenda-6]]