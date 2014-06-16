#Performance

##Question

How well does Izenda perform on large databases?

##Answer

###Scalability

Izenda scales well to systems with ~250 users per cpu. Response times on reporting pages will generally run about 4 seconds under these conditions. Izenda serves many multi-tenant clients using clustered databases as well as load-balanced multi-terabyte databases.

###Exporting

Large exports with 100k+ records need to be done in [[CSV format|http://wiki.izenda.us/FAQ/Formatting/How-do-I-Add-bulk-CSV-to-the-report-viewer]]. This is designed to stream the data in parts instead of one large download. This prevents browser timeouts by immediately pushing records to the requesting client. This way, if the full export takes 5 minutes and the browser times out in 1 minute, Izenda can use streaming capabilities to keep the browser active and the client will receive the entire file.

###Queries

Izenda creates smart queries instead of pulling all data at once. So if you need a report for each state and there are a billion records, Izenda will only pull an x record summary out of the database, where x is the number of records specified in the report definition. This means much faster response times as opposed to processing all of the billion records. You can set the limit of records per-report and per-dashboard.

Izenda is typically faster than the database so the query time tends to be the bottleneck. For this reason, it's important to create indexes and views.