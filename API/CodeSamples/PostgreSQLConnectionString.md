#PostgreSQLConnectionString

[[_TOC_]]

#About

The PostgreSQLConnectionString is what Izenda AdHoc uses to initialize an PostgreSQL connection. This will do all the heavy lifting for including tables, functions, and stored procedures. It will also build queries utilizing the Izenda PostgreSQL Driver. 

Below is a sample global.asax using the PostgreSQLConnectionString setting. The code block will appear within ``<script runat="server"> </script>`` tags within global.asax.

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
    AdHocSettings.PostgreSQLConnectionString = "INSERT_CONNECTION_STRING_HERE";  //The relevant setting
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
        AdHocSettings.PostgreSQLConnectionString = "INSERT_CONNECTION_STRING_HERE"  'The relevant setting
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        HttpContext.Current.Session("ReortingInitialized") = True
    End Sub

End Class
```

##Parts of a Connection String

Izenda uses a third party .NET data provider to connect to PostgreSQL instances, called Npgsql.  There are certain patterns that are recognized as settings within the connection string itself. The username and password are among them. You can read more about the parts of the Npgsql PostgreSQL connection string [[here|https://github.com/npgsql/npgsql/wiki/User-Manual#connection-string-parametersx]]. Here are the essential parts of the connection string:

* **Server** - Address/Name of PostgreSQL Server.
* **Port** - Port to connect to.  Default is 5432.
* **Database** - The name of the database you want to connect to.  Defaults to user name if not specified.
* **User ID** - The username that you're logging in as (Not recommended, but still popular). It is recommended to use Integrated Security instead.
* **Password** - The password you're using to log into the database (Not recommended, but still popular). It is recommended to use Integrated Security instead.
* **Integrated Security** - When false, User ID and Password are specified in the connection. When true, the current Windows account credentials are used for authentication.
Recognized values are true or false.  Default is set to false.

There are many different constructions of a proper connection string.  Please see the link above for more information.

Then you simply have to insert the values you need into the connection string:

```csharp
public static void InitializeReporting()
{
    String uname = HttpContext.Current.Session["UserName"];
    String pw = HttpContext.Current.Session["Password"]; //unsecure. Use at your own risk. There are many great articles about how to handle usernames and passwords and perhaps your organization already uses one.

    Izenda.AdHoc.AdHocSettings.PostgreSQLConnectionString =
    "Server=zag.izenda.com;Port=5432;Database=Northwind;User ID="+ uname +
    ";Password=" + pw + ";Integrated Security=False";
}