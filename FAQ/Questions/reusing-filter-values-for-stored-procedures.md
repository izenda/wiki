#Reusing filter values for stored procedures

[[_TOC_]]

##Question

How can I use the same value for multiple filters using the same field when using stored procedure parameters?

##Answer

Izenda does not natively support the ability to re-use filter values for multiple filters using the same stored procedure parameter. In order to emulate this behavior, custom code will be required in your Global.asax file where your CustomAdHocConfig class exists. Below is a code sample that demonstrates how to implement this behavior at a basic level. The sample may need to be modified for individual use-cases so be sure to test the code before publishing.

###C♯ example

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
    // -----
    // Copy filter value form the filled SP parameter to the hidden parameters with the same column name
    // -----
    // Only process SP parameters
    // Collect values from the visible filters
    var filtersToCopy = new Dictionary<string, object>();
    foreach (Filter filter in reportSet.Filters)
    {
        if (filter.Parameter
                && filter.dbColumn != null
                && filter.dbColumn.Table.Type == TableType.StoredProcedure
                && filter.dbColumn.Name.StartsWith("PARAM_")
                && !filtersToCopy.ContainsKey(filter.dbColumn.Name))
            filtersToCopy.Add(filter.dbColumn.Name, filter.Value);
    }
    // Pass values from the visible filters to hidden filters
    foreach (Filter filter in reportSet.Filters)
    {
        if (!filter.Parameter
                && filter.dbColumn != null
                && filter.dbColumn.Table.Type == TableType.StoredProcedure
                && filtersToCopy.ContainsKey(filter.dbColumn.Name))
            filter.Value = filtersToCopy[filter.dbColumn.Name];
    }
}
```

#VB.NET example

```visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As ReportSet)
    ' -----
    ' Copy filter value form the filled SP parameter to the hidden parameters with the same column name
    ' -----
    ' Only process SP parameters
    ' Collect values from the visible filters
    Dim filtersToCopy As New Dictionary(Of String, Object)()
    For Each filter As Filter In reportSet.Filters
        If filter.Parameter _
        And filter.dbColumn IsNot Nothing _
        And filter.dbColumn.Table.Type = TableType.StoredProcedure _
        And filter.dbColumn.Name.StartsWith("PARAM_") _
        And Not filtersToCopy.ContainsKey(filter.dbColumn.Name) Then
            filtersToCopy.Add(filter.dbColumn.Name, filter.Value)
        End If
    Next
    ' Pass values from the visible filters to hidden filters
    For Each filter As Filter In reportSet.Filters
        If Not filter.Parameter _
        And filter.dbColumn IsNot Nothing _
        And filter.dbColumn.Table.Type = TableType.StoredProcedure _
        And filtersToCopy.ContainsKey(filter.dbColumn.Name) Then
            filter.Value = filtersToCopy(filter.dbColumn.Name)
        End If
    Next
End Sub
```