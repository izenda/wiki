#PreLoadReportSet()

[[_TOC_]]

##About

This method runs immediately prior to LoadReportSet and can be used to perform operations that must precede the loading of report XML and initialization of the ReportSet object. You can define its behavior by overriding it in your CustomAdHocConfig, usually contained in the global.asax.

##Sample C♯ Method

```csharp
public override void PreLoadReportSet(string name)
{
    //perform any operations that must be executed prior to loading the ReportSet
}
```

##Sample VB.NET Method

```visualbasic
Public Overrides Sub PreLoadReportSet(name As String)
    'perform any operations that must be executed prior to loading the ReportSet
End Sub
```
