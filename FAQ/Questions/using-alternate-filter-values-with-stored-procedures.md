#Substituting filter values for other values when using a stored procedure

[[_TOC_]]

##Question

When I filter a report with a stored procedure datasource, I want to pass a different value than what is displayed. How can I accomplish this in Izenda?

##Answer

While we do not provide a simple API to do this, it can be done with some knowledge of our methods. The first step is to set up the Equals(Select) values for your stored procedures. In the example below, we will assume you have read our article on [[using stored procedures in Izenda 6|http://wiki.izenda.us/FAQ/Questions/Using-Stored-Procedures-In-Izenda-6]]. We will be using a column called "OrderStatus" that returns an integer, and another column called "OrderStatusName" that returns a string.

**Note: ** If you are substituting a value on a table or view instead of a stored procedure, click [[here|/FAQ/passing-alternate-filter-values-with-a-table-or-view]].

For the ProcessEqualsSelect override, we can put:

```csharp
public override string[] ProcessEqualsSelectList(Column column)
{
    if (column.FullName.Contains("PARAM_OrderStatus"))
    {
        DataSet ds = AdHocContext.Driver.GetDataSet(AdHocContext.Driver.CreateCommand("SELECT DISTINCT OrderStatusName FROM [Orders]"));
        string[] results = new string[ds.Tables[0].Rows.Count];
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            results[i] = ds.Tables[0].Rows[i][0].ToString();
        return results;
    }
    return base.ProcessEqualsSelectList(column);
}
```

This allows us to use the Equals(Select) filter type with the parameter OrderStatus. However, we are selecting the values that correspond to the OrderStatusName counterpart. Next, we will look at the PostProcessEqualsSelectList method.

```csharp
public override void PostProcessEqualsSelectList(Column column, List<string> labels, List<string> values)
{
    for (int i = 0; i < labels.Count; i++)
    {
        if (labels[i] == "Accepted")
            values[i] = "1";
        else if (labels[i] == "Pending")
            values[i] = "0";
    }
    base.PostProcessEqualsSelectList(column, labels, values);
}
```

Here, we are replacing the VALUES of the Equals(Select) list with our numerical data. Your own particular use case may be more complex.

The result is that we get an Equals(Select) list that has the following format:

```html
<select align="left" name="ctl00_PlaceHolder_Adhocreportdesigner1_ctl01_cc_SelectValue" style="width:300px" onchange="javascript:CC_OnSelectValueChangedHandler(this);;" pendingforautoupdate="true" size="1">
    <option value="...">...</option>
    <option value="1">Accepted</option>
    <option value="0">Pending</option>
</select>
```

Now when you run your report, the users will see the labels but the actual stored procedure will use the numerical values.