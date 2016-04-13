#Setting Defaults for the Report Designer

[[_TOC_]]

##Question

How can I set default report designer options that are not standard with Izenda for my customers? If I want the report designer to initialize with certain datasources already selected or certain report options enabled, how would I do that?

##Answer

In order to change the default report designer options, such as datasources, fields, filters, or other options, the underlying CurrentReportSet must be modified. The CurrentReportSet controls which report is currently loaded, and exists even when the report designer initializes a new ReportSet. In order to detect that the ReportSet contained within CurrentReportSet is new, simply check the ReportName property in the OnPreLoad() method of the ReportDesigner.aspx.cs file. An example of this can be seen below.

```csharp
protected override void OnPreLoad(EventArgs e)
{
    try
    {
        string name = AdHocContext.CurrentReportSet.ReportName;
    }
    catch // this is new report
    {
        //Perform any report designer behavior changes in here
    }
}

###Adding datasources

You may want to start all users who navigate to the report designer with a default datasource. In order to accomplish this, insert the code template below into your code.

```csharp
if(AdHocContext.CurrentReportSet.JoinedTables.Count == 0)
    AdHocContext.CurrentReportSet.JoinedTables.Add(new JoinedTable { TableName = "[dbo].[Orders]" });
```

Adding multiple tables with relationships is accomplished by performing the above step, plus adding additional tables with valid join relationships. Izenda will automatically check to ensure the tables and columns exist at runtime.

###Adding fields

In order to add any fields, you will need to access the underlying "Detail" report within the CurrentReportSet object and a valid datasource must be added as discussed above.

```csharp
AdHocContext.CurrentReportSet.Detail.Fields.Add(new Field("[dbo].[Orders].[ShipCountry]"));
```

###Changing default report options

You may want to adjust options that apply to the style of the report, such as the Visual Group style, whether the date and time are displayed in the report header for exports, or whether pagination is turned on by default. To accomplish these and other related actions, use code that accesses the corresponding property on the CurrentReportSet object.

```csharp
//Default Visual group style
AdHocContext.CurrentReportSet.VisualGroupStyle = VisualGroupStyle.LineDelimited;
//Show date and time on exports by default
AdHocContext.CurrentReportSet.ShowDateTime = true;
//Enable pagination by default
AdHocContext.CurrentReportSet.UsePaginationInWebView = true;
```

