#IsFieldAllowedInFilters

[[_TOC_]]

##About

This method allows for custom handling of whether specific fields can be used in filters or not. 

Note: Overriding this method with custom behavior will cause certain settings to get ignored, such as HiddenColumns and FiltersRegex.

##C♯ Example

```csharp
public override bool IsFieldAllowedInFilters(string fullColumnName, string columnName)
{
    switch (columnName)
    {
        case "OrderID":
        case "CustomerID":
        case "EmployeeID":
        case "ShipperID":
            return false;
        default:
            return true;
    }
}
```

##VB.NET Example

```visualbasic
Public Overrides Function IsFieldAllowedInFilters(fullColumnName As String, columnName As String) As Boolean
    Select Case columnName
        Case "OrderID", "CustomerID", "EmployeeID", "ShipperID"
            Return False
        Case Else
            Return True
    End Select
End Function
```