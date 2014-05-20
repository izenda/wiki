#Query String Keys for rs.aspx

[[_TOC_]]

##Question

What are the different parameters I can pass to the rs.aspx page in the query string, and what do they do?

##Answer

This is the current list of useful rs.aspx query string keys:

**rn=[reportName]**
This is the name specified for the report (e.g. a report named Cost Analysis would be accessed with rs.aspx?rn=Cost+Analysis)

**output=[ExportFormat], export=[ExportFormat]**
This will generate the desired export of the tabular data in the report (e.g. rs.aspx?rn=Cost+Analysis&output=pdf)

**run_scheduled_reports=[Minutes]**
Adds the report to the [[Izenda Scheduler|http://wiki.izenda.us/FAQ/Questions/How-do-I-use-the-Izenda-Reports-report-email-scheduler]] to be run after the designated period of time (e.g. rs.aspx?rn=Cost+Analysis&run_scheduled_reports=30)

_**Note:** The Izenda Scheduler must be configured in order for this parameter to have any effect._

**reportonly=[0 or 1]**
Specifies whether the returned report will contain styling and scripts (0 indicates no styling or scripts are to be used)

**clear=[0 or 1]**
Clears the cache

**pxvalue=[value]**
These are directly related to the filters used in the report and range from 1 to the number of filters used in the report where x is the number of the filter. The value indicates what default value the filter should have. (e.g. a report that filters on country, company, and product could have p1value=usa&p2value=general+mills&p3value=lucky+charms)

**wscmd=[value]**
This parameter takes any of the following string values and returns a JSON formatted object to the browser. This can help developers who wish to work with JSON objects to build customized application pages using Izenda.

Possible Values

* reportlistdata - returns a list of all the reports on file.
* reportlistdatalite - similar to reportlistdata but returns less data.
* fulldslist - returns a list of all data sources.
* getconstraintslist - returns a list of the database constraints
* getcrsparts - returns a list of the current report set's report parts
* getcrstables - returns a list of the current report set's table names
* getpivotguidata - returns the current report set's pivot data along with field names applicable to the current report set and all possible values for pivoting

*Note: At this time, Izenda supports at most 5 query string parameters*