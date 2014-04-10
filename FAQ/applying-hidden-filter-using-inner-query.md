#How can I apply a hidden filter using an inner query

[[_TOC_]]

**Note:** Use the below method only when you have a large number of values.  Normaly you don't have to add filters via inner query. Please use AdHocSettings.HiddenFilters instead.

##Hidden Filter C♯

For this example, we will use the Northwind database as our datasource.
Here is our sample report in the report designer:

![]()

Below is a code sample showing how to add a hidden filter to a report. We will be using this query with our sample datasource.

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
	base.PreExecuteReportSet(reportSet);
	Filter filter = new Filter();
	filter.Column = "ShipCity";
	filter.SqlOverride = "ShipCity IN (SELECT ShipCity FROM [dbo].[Orders] WHERE ShipCountry = 'USA')";
	reportSet.Filters.AddHidden(filter);
}
```

After booting up our application and running our report, here is what we get:

![]()

##Hidden Filter with SQL Override

```csharp
public override void PreExecuteReportSet(ReportSet reportSet) 
{  
    base.PreExecuteReportSet(reportSet);   
    if(reportSet.Source.Equals("[dbo].[Customers]"))
    {    
        Filter filter = new Izenda.AdHoc.Filter();    
        filter.Column = "email";    
        filter.SqlOverride = "(aspnet_Membership.email = 'greg@edelinsolutions.com' or aspnet_Membership.email='gedelin@yahoo.com')";    
        reportSet.Filters.AddHidden(filter);    
    }
}
```

```visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet)   
	MyBase.PreExecuteReportSet(reportSet)    
	Dim emails(1) As String    
	emails(0) = "greg@edelinsolutions.com"    
	emails(1) = "gedelin@yahoo.com1"    
	Dim filter As New Izenda.AdHoc.Filter()   
	filter.Column = "email"    
	filter.Operator = OperatorTypes.In    
	filter.Values = emails    
	reportSet.Filters.AddHidden(filter)
End Sub
```