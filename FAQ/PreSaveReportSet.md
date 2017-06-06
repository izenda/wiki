#PreSaveReportSet

[[_TOC_]]

##About

Represents a method that allows the ReportSet to be processed before it goes to the server. This method must be overridden and contains no default behavior.

##C# Example

```csharp
[Obsolete]
public override void PreSaveReportSet(string name, ReportSet reportSet)
{
    if (!AdHocSettings.CurrentUserName.Equals(reportSet.Owner))
        Debug.WriteLine(string.Format("Non-owner about to save report: {0}", AdHocSettings.CurrentUserName));
}
```

##VB.NET Example

```visualbasic
<Obsolete>
Public Overrides Sub PreSaveReportSet(name As String, reportSet As ReportSet)
    If Not AdHocSettings.CurrentUserName.Equals(reportSet.Owner) Then
        Debug.WriteLine(String.Format("Non-owner about to save report: {0}", AdHocSettings.CurrentUserName))
    End If
End Sub
```