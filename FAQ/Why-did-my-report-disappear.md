#Why did my report disappear?

[[_TOC_]]

##Question

A report that I created and was using just fine suddenly vanished. I know it wasn't deleted. Where did it go?

##Answer

There are two main reasons why an Izenda report might suddenly vanish from the report list: changes to the database, and changes to security or permissions.

###First Steps

1) First, check some of the reports that don't appear, and write down the tables and views used from their report definitions.

2) Now, open Izenda and click 'new report'. On the datasources tab; Are all the required datasources for the reports that do not appear (from the definitions in step 1) available to report on in the new report?

If some are missing, go to 3 - If all the datasources are available, skip to 4.

3) Why aren't they available:

Has the DB schema changed? Does it frequently change or columns/tables get renamed? 

Does VisibleDatsources in the API contain values for these datasources?

If Izenda constraints API code is used, are they included there?

4) Since the datasources are all available that the reports need, why else could they be unavailable:

a) What are the Sharing Rights for the reports? (Check 'ReportVisibiliy' node - SharedWITH)

b) Does the Report Definition define a tenantID?

If 'a' is anything else than 'Everyone-FullControl', does the allowed role/user match the role you are logging in with to see the report? The userID logged in the report definition as creator can always see that report (even if set to 'Everyone/None').

If 'b' has any tenant ID value, does the tenantID of the user you are using the same as the report?

Additionally, check the TenantID of the report and make sure it matches with the permissions available to the current user.

###Database

Izenda reports are a collection of stored references to fields from one or more data sources (tables, views, or stored procedures). If those data sources are edited, either by being removed or by having some portion of them removed or changed, the Izenda report built on that data source may not appear any more, because some portion of the report can't be referenced. To troubleshoot, confirm that the data source(s) used to build the missing report are still visible to you, and all of the fields used in the report are visible as well and have not changed - particularly their names. 

Aside from the actual schema changing, there is a setting called [[VisibleDataSources|/API/CodeSamples/VisibleDataSources]] - data sources which are made 'invisible' can't be accessed, and have the same effect as if the data source were removed entirely.

###Security and Permissions

Another potential cause for a missing report is if the report were locked to a higher security level than you have access to. Check with your administrator or the properties of the sharedwith node in the xml report definition.

