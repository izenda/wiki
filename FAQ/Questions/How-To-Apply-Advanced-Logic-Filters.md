#How To Apply Advanced Logic Filters

[[_TOC_]]

##Defining advanced filter logic

Izenda Reports allows you to have an arbitrary number of filters on a new report. These filters can even be applied with custom logic that you define. This is done with the advanced logic filter. 

The text box on the [[Filters tab|http://wiki.izenda.us/Guides/ReportDesign/5.0-Filters-tab]] labeled "Filter Logic" is where you configure this logic. By default, there is an example filter already populated into the box to guide users in the format they should use. Once you change its text, this setting goes into effect. Using the example, "(1 OR 2) AND (3 OR 4)", results will be filtered conditionally based on meeting either Filter 1 or Filter 2 in addition to meeting either Filter 3 or Filter 4. You can construct extremely simple to extremely complex filters. If you have a mere two filters, a simple "1 OR 2" will force your results to meet either the first or the second filter condition.  Alternatively, you can nest parenthesis and combine logical operators to form sophisticated advanced filters.