#Set Default Filter Values

[[_TOC_]]

##Purpose

There are multiple scenarios where having the filter values set as soon as a report loads can be beneficial. For example, reports that have access to large data sets can benefit from faster load times as a fewer number of results will come back immediately. Another benefit is when the report creator wants to hide filters but populate them automatically based on criteria. The following examples will show how it is coded for dashboards.
<!--
##Reports
-->

##Dashboards

Dashboards themselves do not have filters and therefore reference the filters of the reports it is composed of.
This method can be used for stored procedures as well as tables and views.

```c#
public override ReportSet LoadReportSet(ReportInfo reportInfo, DatabaseSchema schema) {
      ReportSet reportSet = base.LoadReportSet(reportInfo, schema);
      if (reportInfo.Name == "Dashboard Proc Test") {
        foreach (string report in reportSet.Reports) {
          reportSet.Reports[report].Filters[0].Value = DateTime.ParseExact("01/01/2010", "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
          reportSet.Reports[report].Filters[1].Value = DateTime.ParseExact("01/01/2014", "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }
      }
      return reportSet;
    }
```

#Additional Notes

The between calendar uses two values. To set each of its dates, you would use the following.

```c#
reportSet.Reports[report].Filters[0].Values.SetValue(DateTime.ParseExact("01/01/2010", "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture),0);
reportSet.Reports[report].Filters[0].Values.SetValue(DateTime.ParseExact("01/01/2014", "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture),1);
```