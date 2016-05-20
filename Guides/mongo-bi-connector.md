#Using MongoDB Connector for BI with Izenda Reporting

[[_TOC_]]

##About

This tutorial is meant to provide guidance in setting up Izenda to work with MongoDB's Connector for BI.  The MongoDB Connector for BI is proprietary to MongoDB, and will only be available to MongoDB Enterprise users.  Izenda will not ship with MongoDB or the BI Connector.  The BI Connector is designed for use with business intelligence applications like Izenda, and provides an ODBC connection and SQL translator for a MongoDB noSQL database.  It does not store information, but it creates a schema, and uses PostgreSQL 9.4 as a standard.

Izenda is not responsible for any data issues resulting from the use of the MongoDB Connector for BI.

##Prerequisites

You will need to have a MongoDB Enterprise Server set up to use the Connector for BI.  You will also need to set up the BI Connector on a Linux server.  Please see the following links for more information:

- [[MongoDB Download Center - Get Enterprise Server and/or BI Connector|https://www.mongodb.com/download-center?jmp=nav#enterprise]]
- [[MongoDB Enterprise Server Documentation|https://docs.mongodb.com/manual/?_ga=1.160186494.270323263.1463507060]]
- [[MongoDB Connector for BI Documentation|https://docs.mongodb.com/bi-connector/]]

##Setting Up the Connection

Once you have installed the Connector for BI and opened the appropriate ports, you are ready to connect Izenda to your MongoDB database.  Izenda does not require any special downloads or drivers to connect to the BI Connector, as Izenda ships with a PostgreSQL driver.  To connect, simply form your connection string: 

- Server=(host name);Port=(port - MongoDB default is 27032);Database=(same as username);User Id=(username created during setup for BI Connector);Password=(created during setup for BI Connector);

You can add the connection string via [[AdHocSettings.PostgreSQLConnectionString|http://wiki.izenda.us/Integration/Tutorials/connect-to-the-database#PostgreSQL-9+]], or via [[Fusion connection|http://wiki.izenda.us/Guides/Izenda-AdHoc-Driver#Izenda-Fusion-Driver]].

##Code Samples
**Global.asax (C♯)**
```c#

//main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{
  // Configure settings
  // Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
  public static void InitializeReporting() {
    //Check to see if we've already initialized.
    if (AdHocContext.Initialized)
      return;
    AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
    AdHocSettings.PostgreSQLConnectionString = "Server=127.0.0.1;Port=27032;Database=izmongo;User Id=izmongo;Password=***;";  //The relevant setting
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

**Global.asax (VB.NET)**

```visualbasic

'main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
Public Class CustomAdHocConfig
    Inherits Izenda.AdHoc.DatabaseAdHocConfig

    Shared Sub InitializeReporting()
        'Check to see if we've already initialized
        If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.PostgreSQLConnectionString = "Server=127.0.0.1;Port=27032;Database=izmongo;User Id=izmongo;Password=***;"  'The relevant setting
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub

End Class
```


