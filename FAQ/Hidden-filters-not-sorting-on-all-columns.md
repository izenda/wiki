#My hidden filters are not sorting all available columns

[[_TOC_]]

##Question

My [[hidden filters|/API/CodeSamples/HiddenFilters]] are not sorting on all columns. Does my filtered table have to join to the report?

##Answer

For best results when using Hidden Filters, it is recommended to include the column you want to filter in the report. However, it is not necessary to use the column when the appropriate data source is used in the join.

For instance, if you want to filter by [CustomerID] then you don't have to use [CustomerID] in the report but you need to make sure that [Customers] or [Orders] or other table containing [CustomerID] column is joined.

In the event, that your report requires that both the column and the table be hidden to users, you can use resources available our Izenda Wiki under the [[API tab|/API/AdHocConfig]]:

To auto-filter your report by a given column from a stored procedure, use the following example:

Configuration:

AdHocSettings.VisibleDataSources = new string[] { "Products", "CustOrderHist" };
AdHocSettings.HiddenFilters["[dbo].[CustOrderHist].[CustomerID]"] = "ALFKI";
AdHocSettings.TableFilterRegex = "CustOrderHist";

PERS override:

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
    // If _security_ data source is not joined
    if (!reportSet.JoinedTables.Cast<JoinedTable>().Any<JoinedTable>(jt => jt.LeftConditionColumn == "[dbo].[CustOrderHist].[ProductName]" || jt.RightConditionColumn == "[dbo].[CustOrderHist].[ProductName]"))
    {
        // Manually join appropriate data source
        // In this sample code only one possible situation is processed since the actual code depends on the particular use case
        foreach (JoinedTable jt in reportSet.JoinedTables)
            if (jt.TableName == "[dbo].[Products]")
            {
                reportSet.JoinedTables.Add( new JoinedTable()
                    {
                        RightConditionTable = "[dbo].[Products]",
                        RightConditionColumn = "[dbo].[Products].[ProductName]",
                        TableName = "[dbo].[CustOrderHist]",
                        LeftConditionColumn = "[dbo].[CustOrderHist].[ProductName]"
                    });
                break;
            }
    }
}

```

Now when you select [Products] table the data will be filtered by "ALFKI" [CustomerID].
