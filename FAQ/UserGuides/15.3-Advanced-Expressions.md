#Dynamically Changing Data Sources

[[_TOC_]]

##Question

How can I change the data source I'm using for my reports on the fly?

##Answer

You can change the data source for individual reports by overriding the [[PreExecuteReportSet|/FAQ/PreExecuteReportSet]] method. Here is the source code for changing data sources:

```
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet) 
{ 
    base.PreExecuteReportSet(reportSet);
    string orig = reportSet.Source;
    string target = "[dbo].[Orders2]"; 
    
    if(!orig.Contains("Orders")) {
        return; //check for strings like "Orders". If that's not found, we return.
    }
    foreach (JoinedTable jt in reportSet.JoinedTables) 
    { 
        jt.TableName = jt.TableName.Replace(orig, target); 
    } 
    foreach (Report r in reportSet.Reports.AllValues) 
    { 
        foreach (Field f in r.Fields) 
        { 
            f.ColumnName = f.ColumnName.Replace(orig, target); 
        } 
    } 

    foreach (Filter f in reportSet.Filters) 
    { 
        f.Column = f.Column.Replace(orig, target); 
    } 
} 
```