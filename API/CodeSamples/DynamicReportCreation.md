#Dynamically Creating Reports Via the API

[[_TOC_]]

##Process

This code sample allows a user to create reports using API calls. Any tables added to the **JoinedTables** list must be in the current user's [[VisibleDataSources|/API/CodeSamples/VisibleDataSources]](usually handled in [[ConfigureSettings|/FAQ/ConfigureSettings]] or [[PostLogin|/FAQ/PostLogin]]) before the **CurrentReportSet** is processed. When a report is created this way, a Response.Redirect() call to the Report Viewer page will allow the user to view the report. Alternately, you can redirect to **rs.aspx** using the [[output query string parameter|/FAQ/Questions/Query-String-Keys-for-rs.aspx]] and create fully formed PDFs and Excel-formatted reports with the click of a button.

###C♯ Sample

```csharp
ReportSet rs = new ReportSet();
rs.ReportName = "Generated Report";

JoinedTable jt = new JoinedTable();
jt.TableName = "[dbo].[Orders]";
rs.JoinedTables.Add(jt);

Field f = new Field("[dbo].[Orders].[ShipCountry]", "Ship Country");

rs.Detail.Fields.Add(f);

Izenda.AdHoc.AdHocContext.CurrentReportSet = rs;
```

###VB.NET Sample

```visualbasic
Dim rs As New ReportSet()
rs.ReportName = "Generated Report"

Dim jt As New JoinedTable()
jt.TableName = "[dbo].[Orders]"
rs.JoinedTables.Add(jt)

Dim f As New Field("[dbo].[Orders].[ShipCountry]", "Ship Country")

rs.Detail.Fields.Add(f)

Izenda.AdHoc.AdHocContext.CurrentReportSet = rs
```