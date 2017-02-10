#Applying hidden filters programmatically

##About

Sometimes a situation arises where using the hidden filters collection will not satisfy certain business requirements. Perhaps the hidden filter needs to be set per-report or per-user, and specific extra information is required that is not known during initialization in the CustomAdHocConfig. In these cases, it is necessary to implement custom code that will add the filter to reports on a case-by-case basis. To accomplish this, two general methods are used. One for the report viewer where one report is being executed, and one method for dashboards where multiple reports are being executed. While this is seemingly a very large difference, it is relatively simple to handle in Izenda with the right logic. Below is a code sample that programmatically adds a hidden filter to a report while taking into account whether the report being executed is a dashboard or a regular report.

##C♯ Method

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
    if (reportSet.IsDashBoard)
    {
        Report myReport = reportSet.Reports[0]; //This report will always represent the dashboard tile currently being handled by the system.
        Filter newFilter = null;
        if (FilterCanBeAddedToReport(myReport.JoinedTables, out newFilter))
        {
            myReport.Filters.Add(newFilter);
        }
    }
    else
    {
        Filter newFilter = null;
        if (FilterCanBeAddedToReport(reportSet.JoinedTables, out newFilter))
        {
            reportSet.Filters.Add(newFilter);
        }
    }
}

public bool FilterCanBeAddedToReport(JoinedTableCollection jts, out Filter newFilter)
{
    bool toReturn = false;
    newFilter = null;
    foreach (JoinedTable jt in jts)
    {
        foreach (Column col in AdHocContext.Driver.DatabaseSchema.Tables[jt.DbTable.FullName].Columns.AllValues)
        {
            if (col.FullName.ToLower().Contains("CustomerID".ToLower())) //replace "Customer_ID" with the column name to check for. If there is other criteria that must be met, then add that information into this if statement
            {
                newFilter = new Filter(col.FullName);
                newFilter.Hidden = true;
                newFilter.Value = "BONAP";
                toReturn = true;
            }
        }
    }
    return toReturn;
}
```

##VB.NET Method

```visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As ReportSet)
    If reportSet.IsDashBoard Then
        Dim myReport As Report = reportSet.Reports(0)
        Dim newFilter As Filter = Nothing
        If FilterCanBeAddedToReport(myReport.JoinedTables, newFilter) Then
            myReport.Filters.Add(newFilter)
        End If
    Else
        Dim newFilter As Filter = Nothing
        If (FilterCanBeAddedToReport(reportSet.JoinedTables, newFilter)) Then
            reportSet.Filters.Add(newFilter)
        End If
    End If
End Sub

Public Function FilterCanBeAddedToReport(jts As JoinedTableCollection, ByRef newFilter As Filter) As Boolean
    Dim toReturn As Boolean = False
    newFilter = Nothing
    For Each jt As JoinedTable In jts
        For Each col As Column In AdHocContext.Driver.DatabaseSchema.Tables(jt.DbTable.FullName).Columns.AllValues
            If col.FullName.ToLower().Contains("Customer_ID".ToLower()) Then
                newFilter = New Filter(col.FullName)
                newFilter.Hidden = True
                newFilter.Value = "BONAP"
                toReturn = True
            End If
        Next
    Next
    Return toReturn
End Function
```