#How To Apply Advanced Logic Filters

[[_TOC_]]

##Question

How can I create filters that get applied conditionally when designing a report?

##Answer

Izenda Reports allows you to have an arbitrary number of filters on a new report. These filters can even be applied with custom logic that you define. This is done with the advanced logic filter. 

![Filter Logic](http://wiki.izenda.us/FAQ/Questions/How-To-Apply-Advanced-Logic-Filters/filter_logic.png)

The text box on the [[Filters tab|http://wiki.izenda.us/Guides/ReportDesign/5.0-Filters-tab]] labeled "Filter Logic" is where you configure this logic. By default, there is an example filter already populated into the box to guide users in the format they should use. 

Changing the contents of this box will cause Izenda to attempt to apply this logic to the filters on the report when "Preview" is clicked or when the Report Viewer is accessed for this report. Using the example, "(1 OR 2) AND (3 OR 4)", results will be filtered conditionally based on meeting either Filter 1 or Filter 2 in addition to meeting either Filter 3 or Filter 4. You can construct extremely simple to extremely complex logic using this control. If you have a mere two filters, a simple "1 OR 2" will force your results to meet either the first or the second filter condition.  Alternatively, you can nest parenthesis and combine logical operators to form sophisticated advanced filters.