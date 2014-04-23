#Dashboard filters

[[_TOC_]]

##About

As of AdHoc Version 6.6, custom dashboard filter controls are no longer supported. Instead, Izenda uses "report parts" to allow a dashboard to inherit filters from other reports. Report parts are the tabular elements (Detail, Summary, Chart1, etc.) that are defined within a report.

If a Dashboard is constructed from the parts of reports that have the same filter set defined, then the Dashboard will also have that filter set. The filters do not have to have the same value to co-operate. Simply setting the **Field** and **Operator** is enough. The user will be able to select the value on the Dashboard Viewer.