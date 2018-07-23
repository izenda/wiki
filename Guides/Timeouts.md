#Timeouts

[[_TOC_]]

*  All timeouts are in number of seconds. 
** All implementations should be added to the Global.asax file.

##[Equals Drop Down](http://wiki.izenda.us/API/CodeSamples/EqualsDropDownTimeout)

This setting allows the user to increase the database query time for building the drop down selection options at the Filters tab in the Report Designer. If you have a large or unoptimized database increasing this setting can help with proper reporting performance.

```csharp
AdHocSettings.EqualsDropDownTimeout = 1000;
```

##[Equals Select](http://wiki.izenda.us/API/CodeSamples/EqualsSelectTimeout) 

This setting allows the user to increase the database query time for building the drop down selection options at the Filters tab in the Report Designer. If you have a large or unoptimized database increasing this setting can help with proper reporting performance. This setting is deprecated.

```csharp
AdHocSettings.EqualsSelectTimeout = 1000
```
##[Oracle Command](http://wiki.izenda.us/API/CodeSamples/OracleCommandTimeout)

Sets the time Izenda Reports will wait for an Oracle command to execute before timing out. This setting is deprecated.

```csharp
AdHocSettings.OracleCommandTimeout = 5000;
```
##Preview Timeout

Sets the minumum time Izenda Reports will wait for a MS SQL command to execute before timing out.

```csharp
AdHocSettings.PreviewTimeout = 500;
```
##[Schema Cache](http://wiki.izenda.us/API/CodeSamples/SchemaCacheTimeout)

Gets or sets the time span for schema caching.

```csharp
Izenda.AdHoc.AdHocSettings.SchemaCacheTimeout = new TimeSpan(0, 0, 5, 0);
```
##SQL Command

Gets or sets the wait time in seconds for database command dropdown values loading.

```csharp
AdHocSettings.SqlCommandTimeout = 1000;
```
##Data Source Drop Down

Gets or sets the timeout between starting loading dropdown values (in the DataSources dropdown at the Data Sources tab in the ReportDesigner) from server and redirecting to About page.

```csharp
AdHocSettings.DataSourceDropDownTimeout = 10;
```

##[UltimateDbCommandTimeout](http://wiki.izenda.us/API/CodeSamples/UltimateDbCommandTimeout)

Gets or sets a timeout that overrides all other timeouts.

```csharp
AdHocSettings.UltimateDbCommandTimeout = 10;
```