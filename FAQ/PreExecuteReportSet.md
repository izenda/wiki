#PreExecuteReportSet()

[[_TOC_]]

##About

The PreExecuteReportSet method is used to modify the report before it is sent to the Report Viewer or Report Preview for viewing. Overriding this method can add granular control of fields, filters, and other properties of the report before the person designing/viewing the report will see it. This method should be overridden inside your CustomAdHocConfig class within your global.asax page.

##C♯ Boilerplate

```csharp
public class CustomAdHocConfig : DatabaseAdHocConfig
{
        public static void InitializeReporting() 
        {
                AdHocSettings.LicenseKey = "INSERT_YOUR_LICENSE_KEY_HERE";
                AdHocSettings.SqlServerConnectionString = "INSERT_YOUR_CONNECTION_STRING_HERE";
                AdHocSettings.AdHocConfig = new CustomAdHocConfig();
        }
	public override void ConfigureSettings()
	{
		//Per-user settings go here
	}
        public override void PreExecuteReportSet(ReportSet reportSet)
        { 
                //put your own custom code inside this method
        }
}
```

##VB.NET Boilerplate

```visualbasic
Public Class CustomAdHocConfig 
                        Inherits DatabaseAdHocConfig
        Public Shared Sub InitializeReporting() 
                AdHocSettings.LicenseKey = "INSERT_YOUR_LICENSE_KEY_HERE"
                AdHocSettings.SqlServerConnectionString = "INSERT_YOUR_CONNECTION_STRING_HERE"
                AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        End Sub
	public override void ConfigureSettings()
		'Per-user settings go here
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