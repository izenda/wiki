#Why are my charts stuck together?

[[_TOC_]]

##Question

Why can't I place a report part between two charts on my report using the report part position control on the Misc tab?

##Answer

This is due to a setting, [NumChartPerRow](http://wiki.izenda.us/API/CodeSamples/NumChartPerRow). This setting attempts to place two charts on one row for wide displays. By default it is set to 2. If you attempt to place a report part between two 'adjacent' charts, it will not be positioned correctly, as the two charts exist on one invisible row. Setting this value to 1 will correct this problem.