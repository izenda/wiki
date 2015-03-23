#DeleteReportSet()

[[_TOC_]]

##Preface

The DeleteReportSet method is used to delete reports from your storage system. This method can be overridden in your [[CustomAdHocConfig|http://wiki.izenda.us/Integration/Tutorials/Customizing-Izenda-Settings]] class. 

##Usage
If you have overwritten [SaveReportSet()](http://wiki.izenda.us/FAQ/SaveReportSet) to change the location where reports are saved, it is necessary to use this override to indicate where the deletion will occur.

##Examples
The code samples below demonstrate method of overriding the method to implement custom functionality using both [[DatabaseAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]] and [[FileSystemAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#File-System-Mode]].

###DatabaseAdHocConfig Sample

```csharp
/* BEGIN Database Mode Code Sample */
public override void DeleteReportSet() {
    string sql = string.Format(@"DELETE FROM {1} WHERE Name='{0}'", reportName.Trim(), SavedReportsTable);
    System.Data.IDbCommand command = Izenda.AdHoc.AdHocContext.Driver.CreateCommand(sql);
    try
    {
        command.ExecuteNonQuery();
    }
    finally
    {
        if (command.Connection.State == System.Data.ConnectionState.Open)
        command.Connection.Close();
    }
}
/* END Database Mode Code Sample */
```

###FileSystemAdHocConfig Sample

```csharp
/* BEGIN Filesystem Mode Code Sample */
public override void DeleteReportSet() {
    string filePath = Path.Combine(ReportPath, reportName);
    File.Delete(filePath + ".xml");
}
/* END Filesystem Mode Code Sample */
```