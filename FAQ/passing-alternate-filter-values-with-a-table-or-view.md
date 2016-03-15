#Substituting filter values for other values when using a table or view

[[_TOC_]]

##Question

When I filter a report built on a table or view, I want to pass a different value than what is displayed. How can I accomplish this in Izenda?

##Answer

Please refer to the included sample code. In this code, we override PostProcessEqualsSelectList in order to populate a filter with a set of paired values. Values from the CompanyName column will be placed in the filter dropdown which users can select, but the corresponding value from CompanyID will be placed in the where clause of the query. 

**Note:** If you would like to substitute the value of a stored procedure param, click [[here|/FAQ/Questions/using-alternate-filter-values-with-stored-procedures]].

```csharp
public override void PostProcessEqualsSelectList(Column column, List<string> labels, List<string> values)
{
    if (column.Name == "CustomerID")
    {
        var sql = string.Format("SELECT [CustomerID] AS \"Value\", [CompanyName] AS \"Label\" FROM [Customers] WHERE [CustomerID] IN ({0}) ORDER BY [CompanyName]", string.Join(",", values.Where(v => v != "...").Select(v => "'" + v + "'")));
        var ds = AdHocContext.Driver.ExecuteDataSet(sql);
        if (ds != null && ds.Tables.Count > 0)
        {
            var table = ds.Tables[0];
            values.Clear();
            labels.Clear();
            values.Add("...");
            labels.Add("...");
            foreach (DataRow row in table.Rows)
            {
                values.Add(row["Value"].ToString());
                labels.Add(row["Label"].ToString());
            }
        }
    }
}
```