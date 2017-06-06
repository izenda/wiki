#PostSaveReportSet

[[_TOC_]]

##About

Represents a method that allows the ReportSet to be processed after it is saved. This method must be overridden and contains no default behavior.

##C# Example

```csharp
[Obsolete]
public override void PostSaveReportSet(string name, ReportSet reportSet)
{
    if (!AdHocSettings.CurrentUserName.Equals(reportSet.Owner))
        Debug.WriteLine(string.Format("Non-owner saved report {1}: {0}", AdHocSettings.CurrentUserName, reportSet.ReportName));
}
```

##VB.NET Example

```visualbasic
<Obsolete>
Public Overrides Sub PostSaveReportSet(name As String, reportSet As ReportSet)
    If Not AdHocSettings.CurrentUserName.Equals(reportSet.Owner) Then
        Debug.WriteLine(String.Format("Non-owner saved report: {0}", AdHocSettings.CurrentUserName))
    End If
End Sub
```