#Why did my report disappear?

[[_TOC_]]

##Question

A report that I created and was using just fine suddenly vanished. I know it wasn't deleted. Where did it go?

##Answer

There are two main reasons why an Izenda report might suddenly vanish from the report list: changes to the database, and changes to security or permissions.

###Database

Izenda reports are a collection of stored references to fields from one or more data sources (tables, views, or stored procedures). If those data sources are edited, either by being removed or by having some portion of them removed or changed, the Izenda report built on that data source may not appear any more, because some portion of the report can't be referenced. To troubleshoot, confirm that the data source(s) used to build the missing report are still visible to you, and all of the fields used in the report are visible as well and have not changed - particularly their names. 

Aside from the actual schema changing, there is a setting called [[VisibleDataSources|/API/CodeSamples/VisibleDataSources]] - data sources which are made 'invisible' can't be accessed, and have the same effect as if the data source were removed entirely.

###Security and Permissions

Another potential cause for a missing report is if the report were locked to a higher security level than you have access to. Check with your administrator or the properties of the sharedwith node in the xml report definition.

Additionally, check the TenantID of the report and make sure it matches with the permissions available to the current user.