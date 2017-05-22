#GetReportIDByName

[[_TOC_]]

##About

Provides an override to the process that obtains a report ID based on the full report name including category.

##C Example

```csharp
public override string GetReportIDByName(string fullReportName)
{
    Dictionary<string, string> nameToIdDict = new Dictionary<string, string>();
    LoadReportIDs(nameToIdDict);
    return nameToIdDict.ContainsKey(fullReportName) ? nameToIdDict[fullReportName] : null;
}
```

##VB.NET Example

```visualbasic
Public Overrides Function GetReportIDByName(fullReportName As String) As String
    Dim nameToIdDict As New Dictionary(Of String, String)
    LoadReportIDs(nameToIdDict)
    Return If(nameToIdDict.ContainsKey(fullReportName), nameToIdDict(fullReportName), Nothing)
End Function
```