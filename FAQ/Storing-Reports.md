#Storing Reports

[[_TOC_]]

##Choosing Database Mode or Filesystem Mode

Izenda Reports features two methods for saving reports: file system mode and database mode. The default is the Filesystem mode. The table shown will help you choose whether or not you want to use database or filesystem mode. You should choose the mode that best suits your company's needs.

|Database|Filesystem|
|--------|----------|
|Slower to access saved reports |Faster to access saved reports|
|Uses your database security features|Allows customized security implementation|
|No reports are stored in the |Able to customize the way reports are saved and shared|
|No default behavior changes required|Behavior implementation required|
|Copying data between databases not easily done|Easily copy reports between servers for use and testing|
|Requires modifications to the Schema|Schema of database is not changed at all|

##File System Mode

This is the default saving mode for Izenda Reports. In this mode, Izenda Reports saves to a folder called "Reports" by default. No data is stored in the database that is being queried by Izenda Reports. 

###Setting Filesystem mode

The mode is set in the global.asax file, which is found in the root directory to which you installed Izenda Reports. In the example below, the setting in bold is the actual code that must be changed to set filesystem mode.

```csharp
//C#
public class CustomAdHocConfig : Izenda.AdHoc.FileSystemAdHocConfig
```

```visualbasic
'VB.NET
Public Class CustomAdHocConfig Inherits Izenda.AdHoc.FileSystemAdHocConfig
```

One of the advantages of file system mode is that it allows for custom saving behavior. There are four main methods that control creating, loading, saving, and deleting reports:

* [[ListReports|/FAQ/ListReports]]
* [[LoadReportSet|/FAQ/LoadReportSet]]
* [[SaveReportSet|/FAQ/SaveReportSet]]
* [[DeleteReportSet|/FAQ/DeleteReportSet]]

Each of these methods may be over-ridden in order to implement custom behavior. Please see the global.asax example and the Izenda Reports API for examples. To set the default reports folder path that Izenda Reports should use, you must first create a folder in the file system and then ensure that the *NETWORK SERVICE* machine account has read and write access (if using ASP.NET 2.0) or that the *ASP.NET* machine account has read and write access (if using ASP.NET 1.1). Once this is complete, we must now tell Izenda Reports which folder to use by setting the "ReportsPath" property as shown in the example.

###Setting the Saved Reports Path

```csharp
//C#
public static void InitializeReporting()
{
    Izenda.AdHoc.AdHocSettings.ReportsPath = "\SomePath";
}
```

```visualbasic
'VB.NET
Public Shared Sub InitializeReporting()
    Izenda.AdHoc.AdHocSettings.ReportsPath = "\SomePath"
End Sub
```

##Database Mode

This is the alternative saving mode for Izenda Reports. Izenda Reports creates a default table in the database, IzendaAdHocReports, to save the report data. In this mode, no data is stored in the Reports folder in the Izenda Reports directory. To set the default table which Izenda Reports should use, you must first create a table in the database and then ensure that the NETWORK SERVICE machine account has owner access if using ASP.NET 2.0 or that the ASP.NET machine account has owner access if using ASP.NET 1.1. Now tell Izenda Reports which table to use by setting the "SavedReportsTable" property as shown in the example.

###Setting Database Mode

To set Database Mode in our global.asax, we simply need to have the global.asax inherit the appropriate base class. We will then have a few configuration settings that become available.

```csharp
//C#
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
```

```visualbasic
'VB.NET
Public Class CustomAdHocConfig Inherits Izenda.AdHoc.DatabaseAdHocConfig
```

###Setting the Saved Reports Table

This is the most essential setting to specify when using Database Mode. However, it is not required. If it is not specified, Izenda will create and use a table called "[[IzendaAdHocReports|http://wiki.izenda.us/FAQ/IzendaAdHocReports-table]]".
```csharp
//C#
public static void InitializeReporting()
{
    Izenda.AdHoc.AdHocSettings.SavedReportsTable = "SomeTableName";
}
```

```visualbasic
'VB.NET
Public Shared Sub InitializeReporting()
    Izenda.AdHoc.AdHocSettings.SavedReportsTable = "SomeTableName"
End Sub
```

It is possible to copy the reports when necessary to the Reports folder in the Izenda Reports directory by using the "Administrative Settings" button on the toolbar in the report designer. In the status screen, click "Copy reports from database to file system." This will place the files in the Reports folder in the Izenda Reports directory.