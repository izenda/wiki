#Why can't I use Group by Week on a datetime for a subreport action?

[[_TOC_]]

##Question

When I'm using a datetime grouped by week as a subreport action, I'm seeing more results than I would expect.

##Answer

In version 6.9.0.5, we fixed the group by week aggregate function so that it also passes year info. Previously, the week datepart was passed independently, leading to the aggregation of data by week across years. You can add the following code to your global.asax or wherever your adhocconfig is defined:

IAggregateFunction groupByWeek = AdHocSettings.AggregateFunctions[StandardAggregateFunctionType.GROUP_BY_WEEK.ToString()];
((WeekFormatter) groupByWeek.Formatters[0]).IncludeYear = true;