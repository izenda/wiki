#DeleteTemplate

##About

This method allows customization of how forms associated with reports are deleted when deleting a report.

##C# Example

```csharp
public override void DeleteTemplate(string fullReportSetName)
{
    string customTemplatesPath = string.Format("C:\\ReportForms\\{0}", fullReportSetName);
    if (File.Exists(customTemplatesPath))
        File.Delete(customTemplatesPath);
}

```

##VB.NET Example

```visualbasic
Public Overrides Sub DeleteTemplate(fullReportSetName As String)
    Dim customTemplatesPath As String = String.Format("C:\\ReportForms\\{0}", fullReportSetName)
    If File.Exists(customTemplatesPath) Then
        File.Delete(customTemplatesPath)
    End If
End Sub
```