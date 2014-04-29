#SqlServerConnectionString

[[_TOC_]]

#About

The SqlServerconnectionString is what Izenda AdHoc uses to initialize an MSSQL connection. This will do all the heavy lifting for including tables, functions, and stored procedures. It will also build queries utilizing the Izenda MSSQLDriver. 

Below is a sample global.asax using the SqlServerConnectionString setting. The code block will appear within ``<script runat="server"> </script>`` tags within global.asax.

##Global.asax (C♯)
```c#

//main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{
  // Configure settings
  // Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
  public static void InitializeReporting() {
    //Check to see if we've already initialized.
    if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
      return;
    AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
    //Creates a connection to Microsoft SQL Server
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

##Global.asax (VB.NET)

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
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub

End Class
```

##Specifying Username and password

There are certain patterns that are recognized as settings within the connection string itself. The username and password are among them. You can read more about the parts of the SQL connection string [[here|http://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlconnection.connectionstring(v=vs.110).aspx]]. Here are the essential parts of the connection string:

* **server** - The name or network address of the instance of SQL Server to which to connect. The port number can be specified after the server name: ``server=tcp:servername, portnumber``. When specifying a local instance, always use (local). To force a protocol, add one of the following prefixes: np:(local), tcp:(local), lpc:(local).
* **Database** - the name of the database you want to connect to
* **User ID** - The username that you're logging in as (Not recommended, but still popular). It is recommended to use Trusted_Connection instead.
* **Password** - The password you're using to log into the database (Not recommended, but still popular). It is recommended to use Trusted_Connection instead.
* **Trusted_Connection** - When false, User ID and Password are specified in the connection. When true, the current Windows account credentials are used for authentication.
Recognized values are true, false, yes, no, and sspi (strongly recommended), which is equivalent to true. See the above article for more information.

Then you simply have to insert the values you need into the connection string

```csharp
public static void InitializeReporting()
{
    String uname = HttpContext.Current.Session["UserName"];
    String pw = HttpContext.Current.Session["Password"]; //unsecure. Use at your own risk. There are many great articles about how to handle usernames and passwords and perhaps your organization already uses one.

    Izenda.AdHoc.AdHocSettings.SqlServerConnectionString =
    "server=zag.izenda.com;Database=Northwind;User ID="+ uname +
    ";Password=" + pw + ";Trusted_Connection=False";
}