#MySQL Connection String

[[_TOC_]]

##About

The MySqlConnectionString is used for setting up connections to My SQL databases. This will cause the AdHocContext.Driver object to become a MySqlDriver object. You can specify this setting for an entire user group or you can specify it per-user. 

##ODBC Driver

In order to connect to a MySQL database, you will need to have an ODBC driver installed on the server which is hosting the Izenda application.

[Download the latest ODBC Connector](https://dev.mysql.com/downloads/connector/odbc/)

##Setting Up a MySQL Connection String

To set up your MySql Connection String, use the AdHocSettings property MySqlConnectionString. Make sure the version of the driver in the connection string matches the version installed on your server.

```csharp
    Izenda.AdHoc.AdHocSettings.MySqlConnectionString = "Driver={MySQL ODBC 5.3 ANSI Driver};Server=localhost;Port=3307;Database=databasename;Uid=username;Pwd=password;pooling=false"; 
```

You will have to replace your port number (if different), databasename, 
username, and password. Additionally, pooling=false may not be required 
in your case.

##Testing Your MySQL Connection String

To test whether your MySQL connection string is working, there are some diagnostics on the Settings.aspx page that give a PASS/FAIL on various connectivity and permissions-based metrics.