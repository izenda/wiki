If you wish to use one of the reports already created as a data source instead of existing tables:

1. Set AdHocSettings.AllowVirtualDataSources = true;
2. Create a report as usual
3. In Misc. Tab, near the bottom click the checkbox that says, "Expose as data source."
4. Make sure to save the report.
5. Create a new report. The data sources will include the saved report preceded by the folder you saved it under.  You will also notice some Data Sources have become links.  When you select one, a popup will appear, displaying all of the reports that currently use that data source.

![VirtualDataSources Screenshot](http://wiki.izenda.us/Virtualdatasource/19387.png)

6. Continue as usual, except that your column choices will be limited by the columns you chose in the previously saved report.