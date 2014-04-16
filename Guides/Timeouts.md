#Timeouts

[[_TOC_]]

*  All timeouts are in number of seconds. 
** All implementations should be added to the Global.asax file.

##Equals Drop Down

###Purpose
This setting allows the user to increase the database query time for building the drop down selection options at the Filters tab in the Report Designer. If you have a large or unoptimized database increasing this setting can help with proper reporting performance.

###Implementation
AdHocSettings.EqualsDropDownTimeout = 1000;

##Equals Select 

###Purpose 
This setting allows the user to increase the database query time for building the drop down selection options at the Filters tab in the Report Designer. If you have a large or unoptimized database increasing this setting can help with proper reporting performance.

###Implementation
AdHocSettings.EqualsSelectTimeout = 1000

##Oracle Command

###Purpose
Sets the time Izenda Reports will wait for an Oracle command to execute before timing out.

###Implementation
AdHocSettings.OracleCommandTimeout = 5000;

##Preview Timeout

###Purpose
Sets the minumum time Izenda Reports will wait for a MS SQL command to execute before timing out.

###Implementation
AdHocSettings.PreviewTimeout = 500;

##Schema Cache

###Purpose
Gets or sets the time span for schema caching.

###Implementation
Izenda.AdHoc.AdHocSettings.SchemaCacheTimeout = new TimeSpan(0, 0, 5, 0);

##SQL Command

###Purpose
Gets or sets the wait time in seconds for database command dropdown values loading.

###Implementations
AdHocSettings.SqlCommandTimeout = 1000;

##Data Source Drop Down

###Purpose
Gets or sets the timeout between starting loading dropdown values (in the DataSources dropdown at the Data Sources tab in the ReportDesigner) from server and redirecting to About page.

###Implementation
AdHocSettings.DataSourceDropDownTimeout = 10;