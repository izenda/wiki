#Applying hidden filters programmatically

##About

Sometimes a situation arises where using the hidden filters collection will not satisfy certain business requirements. Perhaps the hidden filter needs to be set per-report or per-user, and specific extra information is required that is not known during initialization in the CustomAdHocConfig. In these cases, it is necessary to implement custom code that will add the filter to reports on a case-by-case basis. To accomplish this, two general methods are used. One for the report viewer where one report is being executed, and one method for dashboards where multiple reports are being executed. While this is seemingly a very large difference, it is relatively simple to handle in Izenda with the right logic. Below is a code sample that programmatically adds a hidden filter to a report while taking into account whether the report being executed is a dashboard or a regular report.

##C♯ Method

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
    bool isRenderingToVisualization = false;
    try
    { isRenderingToVisualization = (bool)reportSet.GetVolatileOption("VisualizationRendering"); } //Get the flag for whether this ReportSet is being used as source data for a visualization on a dashboard.
    catch { }
    if (reportSet.IsDashBoard && !isRenderingToVisualization)
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
        //This case is used for the report viewer and for source data for visualizations on dashboards.
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
            if (col.FullName.ToLower().Contains("CustomerID".ToLower())) //replace "Customer_ID" with the column name to check for. If there is other criteria that must be met, then add that information into this if statement.
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
    Dim isRenderingToVisualization As Boolean = False
    Try
        isRenderingToVisualization = reportSet.GetVolatileOption("VisualizationRendering") 'Get the flag for whether this ReportSet is being used as source data for a visualization on a dashboard.
    Catch
    End Try
    If reportSet.IsDashBoard AndAlso Not isRenderingToVisualization Then
        Dim myReport As Report = reportSet.Reports(0) 'This report will always represent the dashboard tile currently being handled by the system.
        Dim newFilter As Filter = Nothing
        If FilterCanBeAddedToReport(myReport.JoinedTables, newFilter) Then
            myReport.Filters.Add(newFilter)
        End If
    Else
        'This case is used for the report viewer and for source data for visualizations on dashboards.
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
            If col.FullName.ToLower().Contains("CustomerID".ToLower()) Then 'replace "Customer_ID" with the column name to check for. If there is other criteria that must be met, then add that information into this if statement.
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

##Stored Procedure Parameters

The process for applying a hidden stored procedure parameter programmatically is slightly different, as the column name needs to be referenced differently. If you are using the column fullname, then this will be done automatically. But in order to do it manually, here is a snippet that would add a stored procedure parameter as a hidden filter in PreExecuteReportSet. Keep in mind that while a fully-qualified table name is not required, if there is more than one match found, a null reference exception will occur.

```csharp
reportSet.Filters.AddHidden(new Filter("[dbo].[CustOrderHist].[PARAM_CustomerID]") { Value = "BONAP" });
```