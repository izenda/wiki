#Database Connections

[[_TOC_]]

##Introduction

Izenda Reports lets business users generate simple custom reports without involving SQL experts or developers. Izenda Reports is an agile reporting solution for ASP.NET and can be installed in about an hour. These are the installation instructions for different database versions, if you have a question about the installation process, please contact us. If you have not already downloaded Izenda Reports, you can [[review this article|http://wiki.izenda.us/Integration/Tutorials/Installing-Izenda]] and [request a trial license key](mailto:sales@izenda.com).

##Supported Databases

**Izenda Reports supports the following databases:**

* SQL Server 2000-2012
* Oracle 9g
* MySQL 5
* OData (requires FUSION add-on)
* Web Services and EAV  (with custom implementation)

[[Izenda Fusion|http://wiki.izenda.us/Guides/Izenda-AdHoc-Driver#Izenda-Fusion-Driver]] (additional module) delivers dynamic real-time analytics from **multiple databases** and applications without having to do periodic ETL into a data warehouse. Also, support for other database architectures is possible. Please speak to our sales team for more information.

##Connecting to multiple data sources

Izenda Reports supports connecting to multiple data sources simultaneously by using views. Views are the simplest and most secure way to connect to many different data sources in order to build reports. For specific examples of how to apply and use views, [[click here|http://wiki.izenda.us/Integration/Tutorials/Views]].

##Microsoft SQL Server 2000/2005 Setup

**Requirements:**

* Follow the directions to setup your web server
* The database must have at least 1 table

**Instructions :**

* You must have a functioning database in order to connect Izenda Reports
* _**Important!**_ For these steps, the database and NOT the file system must have the following permissions set:
  * Ensure that the database login can read the tables and views
  * Ensure that _"NT AUTHORITY\NETWORK SERVICE"_ account ("ASPNET" on XP) has the access level of "db_owner" permissions to the database which contains the tables and views
* Open your Izenda Reports Global.asax file in your IDE and find the ``InitializeReporting()`` method.
* Update the [[LicenseKey|http://wiki.izenda.us/API/CodeSamples/LicenseKey]] and [[ConnectionString|http://wiki.izenda.us/API/CodeSamples/SqlServerConnectionString]] 
  * Sample standard connection string (local database):
    * **"Server=myAddress;Database=mydb;User ID=myUsername;Password=myPassword;"**
  * Sample non-trusted connection string (remote database):
    * **"Server=Server\myAddress;Database=myDataBase;Trusted_Connection=True;"**
* Save your global.asax 
* Build your project
* Start up your project or navigate to your web server via browser
* Izenda Reports is ready for use

##Oracle 9i/10g Setup

**Requirements (must be installed prior to database setup):**

* Izenda Reports requires the [[Microsoft .NET Runtime|http://msdn.microsoft.com/en-us/netframework/default.aspx]]. Download and install if you do not have it already.
* Izenda Reports requires the [[Oracle Data Provider for .NET|http://www.oracle.com/technology/tech/windows/odpnet/index.html]]. Download and install if you do not have it already.
* Follow the directions to setup your web server.
* The database must have at least 1 table.

**Instructions:**

* You must have a functioning database in order to connect Izenda Reports
* _**Important!**_ For these steps, the database and NOT the file system must have the following permissions set:
  * Izenda Reports must have access to the metadata in the database
  * Ensure that the database login can read the tables and views
  * Ensure that _"NT AUTHORITY\NETWORK SERVICE"_ account ("ASPNET" on XP) has the access level of "db_owner" permissions to the database which contains the tables and views
* Open your Izenda Reports Global.asax file in your IDE and find the ``InitializeReporting()`` method.
* Update the [[LicenseKey|http://wiki.izenda.us/API/CodeSamples/LicenseKey]] and [[ConnectionString|http://wiki.izenda.us/API/CodeSamples/OracleConnectionString]] 
  * You can use your [[TNSNames.ora|http://www.orafaq.com/wiki/Tnsnames.ora]] file to create the connection string or you can plug the connection string directly into the OracleConnectionString.
  * Sample standard connection string (using TNS):
    * **"Data Source=TORCL;User Id=myUsername;Password=myPassword;"**
  * Sample non-trusted connection string (without TNS):
    * **"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=MyHost)(PORT=MyPort)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=MyOracleSID)));
User Id=myUsername;Password=myPassword;"**
* Save your global.asax 
* Build your project
* Start up your project or navigate to your web server via browser
* Izenda Reports is ready for use

##MySQL Setup

**Requirements (must be installed prior to database setup):**

* Izenda Reports requires the [[Microsoft .NET Runtime|http://msdn.microsoft.com/en-us/netframework/default.aspx]]. Download and install if you do not have it already.
* Izenda Reports requires the [[MySQL Connector/Net v5|http://dev.mysql.com/downloads/connector/net/5.0.html]]. Download and install if you do not have it already.
* OR if ODBC then Izenda Reports requires the latest version of [[MySQL Connector/ODBC|http://dev.mysql.com/downloads/connector/odbc/]]. Download and install if you do not have it already.
* Follow the directions to [[setup your web server|http://wiki.izenda.us/Integration/Tutorials/Installing-Izenda#How-to-Install-Izenda-on-Windows-2008-with-IIS-7]].
* The database must have at least 1 table.

**Instructions:**

* You must have a functioning database in order to connect Izenda Reports
* _**Important!**_ For these steps, the database and NOT the file system must have the following permissions set:
  * Izenda Reports must have access to the metadata in the database
  * Ensure that the database login can read the tables and views
  * Ensure that "NT AUTHORITY\NETWORK SERVICE" account ("ASPNET" on XP) has the access level of "db_owner" permissions to the database which contains the tables and views
* Open your Izenda Reports Global.asax file in your IDE and find the ``InitializeReporting()`` method.
* Update the [[LicenseKey|http://wiki.izenda.us/API/CodeSamples/LicenseKey]] and [[ConnectionString|http://wiki.izenda.us/API/CodeSamples/MySqlConnectionString]] 
  * Sample standard connection string (using SSL):
    * **"Driver={MySQL ODBC 5.2 ANSI Driver};Server=myServerAddress;Database=myDataBase;User=myUsername;Password=myPassword;sslca=c:\cacert.pem;sslcert=c:\client-cert.pem;sslkey=c:\client-key.pem;sslverify=1;Option=3;"**
  * Other sample connection strings: https://www.connectionstrings.com/mysql/
* Save your global.asax 
* Build your project
* Start up your project or navigate to your web server via browser
* Izenda Reports is ready for use

##Testing your connection string

If you wish to test your connection string to ensure connectivity, you can perform the following steps:

* Click the settings button on the ReportList page toolbar
* The KEY & DB CONNECTION tab should be open
* The license key and connection string you entered will be hidden, showing only "*******" in its place.
* Click "Test" below the connection string 
* Text will appear below the field describing either "SUCCESS" or "FAILURE". Failure lists the reason why it failed.

![](/Integration/Tutorials/connect-to-the-database/settings_aspx.png)

##Per-user database connections

If you wish to have different connections for different users, it can be accomplished easily in Izenda by simply setting up a conditional section in your InitializeReporting method to check whether your condition is true or not before setting the connection string. By default, this setting is initialized with each user who logs in or accesses the application. If you already have a login process in place with the conditions for each user's connection already worked out, then it is simply a matter of setting the connection string. Below is an example of a multi-conditional connection string. In the example, **WebServiceRequest** is a static interface to a web service that has a method called **GetCurrentApplicationUser** that returns an object of type **User**.

**C♯ example**

```csharp
public static void InitializeReporting() {
    //Check to see if we've already initialized.
    if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
      return;
    User myApplicationUser = WebServiceRequest.GetCurrentApplicationUser(); //your method for obtaining the authenticated user
    AdHocSettings.CurrentUserName = myApplicationUser.UserName; //Set the CurrentUserName
    if (myApplicationUser.IsAdministrator)
      AdHocSettings.SqlConnectionString = WebServiceRequest.GetConnectionStringForAdmin(); //Set the connection string for an admin
    else
      AdHocSettings.SqlConnectionString = WebServiceRequest.GetConnectionStringForUser(); //Set the connection string for a regular user
}    
```

**VB.NET example**

```visualbasic
Public Shared Sub InitializeReporting()
    'Check to see if we've already initialized.
    If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
      Return
    Dim myApplicationUser As User = WebServiceRequest.GetCurrentApplicationUser() 'your method for obtaining the authenticated user
    AdHocSettings.CurrentUserName = myApplicationUser.UserName 'Set the CurrentUserName
    If myApplicationUser.IsAdministrator Then
      AdHocSettings.SqlConnectionString = WebServiceRequest.GetConnectionStringForAdmin() 'Set the connection string for an admin
    Else
      AdHocSettings.SqlConnectionString = WebServiceRequest.GetConnectionStringForUser() 'Set the connection string for a regular user
    End If
End Sub
```