#My date formats are broken in Excel when I open a file in a computer with a different culture setting.

[[_TOC_]]

#Question

My date formats are broken in Excel when I open a file in a computer with a different culture setting. Instead of a date, I just get numbers. I exported this file in an environment set to one culture setting, and opened it in an environment with a different culture setting. Why is this happening?

#Answer

This is a known issue, caused by a difference between how different cultures signify numbers with decimals. The American standard for large numbers is 123,456.789. Some European countries have a different standard, as in 123.456,789. That is, there is a difference of opinion on when to use periods and when to use commas. A file exported with the numerical date value of 44444.44 will be interpreted either as a proper date or as a number, depending on which culture setting is being used to interpret this value.

##Workarounds

This issue cannot be fixed in Izenda as it is not a bug. Some alternate method of handling the issue is necessary in your environment.

###Use Uniform Culture

Make sure to set the proper culture setting for the Izenda user so that the export file is exported with the correct placement of periods and commas: 
 
[[AdHocSettings.Language|http://wiki.izenda.us/API/CodeSamples/Language]] = AdHocLanguage.German;
 
###Excel Settings

In Excel's Advanced system settings, it is possible to change the characters used as system separators.
 
###Expression

Instead of exporting a file with a numeric date value and an attached date format which is open to interpretation, it is possible to write an [[Expression|/Guides/ReportDesign/15.0-Expressions-in-Izenda]] which converts the numeric date value to a fixed string. One example would be something like:
 
convert(varchar, [DateField], 101)
 
###Custom Format

It is possible to use a [[custom format|/API/CodeSamples/Formats]] to handle date conversion as well.
