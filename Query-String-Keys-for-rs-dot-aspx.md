**Query String Keys for rs.aspx**

This is the current list of useful rs.aspx query string keys:

**rn=[reportName]**
This is the name specified for the report (e.g. a report named Cost Analysis would be accessed with rs.aspx?rn=Cost+Analysis)

**output=[ExportFormat]**
This will generate the desired export of the tabular data in the report (e.g. rs.aspx?rn=Cost+Analysis&output=pdf)
Alternately called export

**run_scheduled_reports=[Minutes]
Schedules a report to run in the Windows Scheduler after a certain period of time

**reportonly=[0 or 1]**
Specifies whether the returned report will contain styling and scripts (0 indicates no styling or scripts are to be used)

**clear=[0 or 1]**
Clears the cache

**pxvalue=[value]**
These are directly related to the filters used in the report and range from 1 to the number of filters used in the report where x is the number of the filter. The value indicates what default value the filter should have. (e.g. a report that filters on country, company, and product could have p1value=usa&p2value=general+mills&p3value=lucky+charms)