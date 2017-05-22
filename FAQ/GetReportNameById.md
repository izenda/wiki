#GetReportNameById

[[_TOC_]]

##About

Provides an override to the process that obtains a report name based on the report ID.

##C# Exmple

```csharp
public override string GetReportNameById(string id)
{
    Dictionary<string, string> nameToIdDict = new Dictionary<string, string>();
    LoadReportNames(nameToIdDict);
    return nameToIdDict.ContainsKey(id) ? nameToIdDict[id] : null;
}
```

##VB.NET

```visualbasic
Public Overrides Function GetReportNameById(id As String) As String
    Dim nameToIdDict As New Dictionary(Of String, String)
    LoadReportNames(nameToIdDict)
    Return If(nameToIdDict.ContainsKey(id), nameToIdDict(id), Nothing)
End Function
```