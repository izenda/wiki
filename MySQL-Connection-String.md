#MySQL Connection String

[[_TOC_]]

##Setting Up a MySQL Connection String

To set up your MySql Connection String, use the AdHocSettings property MySqlConnectionString.

```csharp
    Izenda.AdHoc.AdHocSettings.MySqlConnectionString = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Port=3307;Database=databasename;Uid=user;Pwd=pass;pooling=false"; 
```

You will have to replace your port number (if different), databasename, 
username, and password. Additionally, pooling=false may not be required 
in your case.