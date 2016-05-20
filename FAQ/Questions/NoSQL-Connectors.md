#NoSQL Connections

[[_TOC_]]

##Question

Will Izenda work with a NoSQL database, like MongoDB?

##Answer

While Izenda requires a .NET connection string to access any of the four databases supported, there are multiple ADO.NET or ODBC connectors available for the various NoSQL databases, like MongoDB or RavenDB, as well as other data sources like Salesforce.  As long as the connection uses a SQL profile Izenda supports (MS SQL Server, Oracle, MySQL, and PostgreSQL), reporting off of these data sources is an option in Izenda.

Please see our tutorial on setting up MongoDB's BI Connector to work with Izenda:

[[Connecting Izenda to MongoDB for Reporting|http://wiki.izenda.us/Guides/mongo-bi-connector]]