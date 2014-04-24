#Controlling Access to Fields

The field level property ``FieldFilterRegex`` is a regular expression property which filters based upon the string it's given. The user would not see any fields containing the words 'pass', 'admin' or 'pw'.

C♯
```csharp
Izenda.AdHoc.AdHocSettings.FieldFilterRegex = "pass|pw|admin";
```
VB.NET
```vb
Izenda.AdHoc.AdHocSettings.FieldFilterRegex = "pass|pw|admin"
```

