#ExecteReader requires an open and available connection when state is open

[[_TOC_]]

##Question

How do I resolve problems with the error message "ExecuteReader requires an open and available Connection. The connection's current state is open" that occur intermittently? 

##Answer

If you are not using a customized method of obtaining your datasources from the database, you may see the following error when lots of concurrent users are accessing the application:

```
ExecuteReader requires an open and available Connection. The connection's current state is open.

Stacktrace:
at Izenda.AdHoc.Database.Driver.GetDataSet(IDbCommand command, String reportPart)
at Izenda.AdHoc.Database.Driver.GetDataTable(IDbCommand command, String reportPart)
at Izenda.AdHoc.Database.Driver.GetDataTable(Report report, IDbCommand command)
at Izenda.AdHoc.Report.LoadAndFormatData(ReportOutputOptions options)
at Izenda.AdHoc.ReportSet.LoadData(ReportOutputOptions options, Boolean useCache, Boolean invalidateInCache, Boolean export, Boolean previewInDesigner, String& signature, Object& renderedReportSet, CacheRecordOptions& cacheOptions, String additionalKey, Boolean removeHiddenFilters)
```

To solve this, you should implement [[MARS(MultipleActiveResultSets)|http://msdn.microsoft.com/en-us/library/cfa084cz(v=vs.80).aspx]] in your connection string. This is accomplished by simply adding "MultipleActiveResultSets=True;" to your connection string.  

