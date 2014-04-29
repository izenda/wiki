#MySQL Connection String

[[_TOC_]]

##About

The MySqlConnectionString is used for setting up connections to My SQL databases. This will cause the AdHocContext.Driver object to become a MySqlDriver object. You can specify this setting for an entire user group or you can specify it per-user. 

##Setting Up a MySQL Connection String

To set up your MySql Connection String, use the AdHocSettings property MySqlConnectionString.

```csharp
    Izenda.AdHoc.AdHocSettings.MySqlConnectionString = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Port=3307;Database=databasename;Uid=username;Pwd=password;pooling=false"; 
```

You will have to replace your port number (if different), databasename, 
username, and password. Additionally, pooling=false may not be required 
in your case.

##Testing Your MySQL Connection String

To test whether your MySQL connection string is working, there are some diagnostics on the Settings.aspx page that give a PASS/FAIL on various connectivity and permissions-based metrics.