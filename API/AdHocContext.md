#AdHocContext

[[_TOC_]]

##About

The AdHocContext class is used to setup the database driver, access the report set currently stored in the active user's session, and access various metrics for your license key. Below is an overview of the properties and methods available through AdHocContext and what each of them can do.

|Property|Description|
|:------:|:---------:|
|ClientLicenses|Gets the maximum number of clients supported by your current license key|
|CurrentReportSet|Gets the report object that was most recently loaded by the user|
|CurrentUserName|
|Driver|Gets or sets the database driver that your application will use|
|ProcessorLicenses|Gets the maximum number of processors your current license key can support|
|ReportSetCount|Not used|
|SchedulerExecuting|Gets a value indicating whether the Izenda Scheduler is executing scheduled reports or not|
|SetSchedulerExecuting|This method takes a boolean value that sets whether or not the Izenda Scheduler is executing|
|StoreInStaticMemory|Gets or sets whether the CurrentReportSet will be stored in static memory or not|
|UsersCountModel|Gets the 
|ViewerLicenses|Gets the maximum number of users supported by your current license key|

##CurrentReportSet

The CurrentReportSet object is the way that Izenda exposes the most recently loaded report definition. This object can be used in many of the overrides that can be used in the Global.asax for more flexibility when dealing with saving/loading reports, modifying datasets, and displaying other useful information as your organization needs.

##Driver

The Driver object is the single point of entry for all database traffic and must be set to any of the specific driver classes that Izenda provides. This will use your connection string and datasources to provide the framework for working with Izenda reports.