#Why does my export say that it's missing a CSS file?

[[_TOC_]]

##Question

I tried to open an exported file and I got a warning that reads similarly to "Missing file: thismessage//MyEnvironment/Report.css". Why is this happening?

##Answer

Sometimes an Izenda deployment can be configured to reference a custom stylesheet that is not Reports.css. There is a setting which handles this, [[ReportsCssUrl|/API/CodeSamples/ReportCssUrl]], but this setting is not always used. If this setting is not configured properly, the export process will not grab the correct file which will cause exports to produce this error. 