#How can I apply a hidden filter using an inner query?

[[_TOC_]]

**Note:** Use the below method only when you have a large number of values.  Normaly you don't have to add filters via inner query. Please use AdHocSettings.HiddenFilters instead.

##Using a Hidden Filter

For this example, we will use the Northwind database as our datasource.
Here is our sample report in the report designer:

![](/FAQ/applying-hidden-filter-using-inner-query/hidden_filters_1.png)

Below is a code sample showing how to add a hidden filter to a report. We will be using this query with our sample datasource.

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
	base.PreExecuteReportSet(reportSet);
	Filter filter = new Filter();
        //These three parameters are what are normally shown in the Filters tab of the report designer
	filter.Column = "ShipCity"; //Filter Field
	filter.Operator = OperatorTypes.In; //Operator
        filter.Values = new string[] {"Boise"}; //Value(s)
	reportSet.Filters.AddHidden(filter);
}
```

**Note:** The **Values** property should always be used, even for one item.

After booting up our application and running our report, here is what we get:

![](/FAQ/applying-hidden-filter-using-inner-query/hidden_filters_0.png)

##Hidden Filter with SQL Override

The SqlOverride property can be used to more precisely handle inner queries for the filter. You simply need to define the Column and the SqlOverride properties to use it. See the query below for a demonstration.

###C♯

```csharp
public override void PreExecuteReportSet(ReportSet reportSet) 
{  
    base.PreExecuteReportSet(reportSet);   
    if(reportSet.Source.Equals("[dbo].[Orders]"))
    {    
        Filter filter = new Izenda.AdHoc.Filter();    
        filter.Column = "ShipCity";    
        filter.SqlOverride = "ShipCity IN (SELECT ShipCity FROM [dbo].[Orders] WHERE ShipCountry = 'USA')"; //There is no need to use the Operator or Values properties with SqlOverride
        reportSet.Filters.AddHidden(filter);    
    }
}
```

###VB.NET

```visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet) 
    MyBase.PreExecuteReportSet(reportSet)
    If reportSet.Source.Equals("[dbo].[Orders]") Then
        Dim filter As New Izenda.AdHoc.Filter()   
        filter.Column = "ShipCity"  
        filter.SqlOverride = "ShipCity IN (SELECT ShipCity FROM [dbo].[Orders] WHERE ShipCountry = 'USA')" 'There is no need to use the Operator or Values properties with SqlOverride
        reportSet.Filters.AddHidden(filter)   
    End If
End Sub
```

![](/FAQ/applying-hidden-filter-using-inner-query/hidden_filters_2.png)