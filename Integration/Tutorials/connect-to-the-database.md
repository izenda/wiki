#Database Connections

[[_TOC_]]

##Introduction

Izenda Reports lets business users generate simple custom reports without involving SQL experts or developers. Izenda Reports is an agile reporting solution for ASP.NET and can be installed in about an hour. These are the installation instructions for different database versions, if you have a question about the installation process, please contact us. If you have not already downloaded Izenda Reports, you can [[review this article|http://wiki.izenda.us/Integration/Tutorials/Installing-Izenda]] and [[request a trial license key|mailto:sales@izenda.com]]

##Supported Databases

**Izenda Reports supports the following databases:**

* SQL Server 2000-2012
* Oracle 9g
* MySQL 5, OData
* Web Services and EAV

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
* Open the Izenda Reports settings page by navigating to [Host]/[Virtual Directory]/settings.aspx in your web browser (i.e. http://localhost/AdHoc54/settings.aspx)
* Set the database and connection information using the Settings.aspx page:
  * Click the "Database" Tab, which is second from the left on the tab bar
  * Set the server type drop-down to "SqlServer"
  * Copy and paste your license key (make sure there is no extra whitespace)
  * Copy and paste your connection string (make sure there is no extra whitespace, remove the quotes if copying from sample)
    * Sample standard connection string (local database):
      * **"Server=myAddress;Database=mydb;User ID=myUsername;Password=myPassword;"**
    * Sample non-trusted connection string (remote database):
      * **"Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;"**
  * Click the "Test" button to test the connection string
  * You should see the word "Success" next to the "Test" button
    * If "Failure" then check your connection string again
  * Click the "Save to Izenda.config" button in the upper left hand corner
* Click the "Preview (Requires Clearing Browser Cache)" Button to navigate back to the Report List page (ReportList.aspx)
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
* Open the Izenda Reports settings page by navigating to [Host]/[Virtual Directory]/settings.aspx in your web browser (i.e. http://localhost/AdHoc54/settings.aspx)
* Set the database and connection information using the Settings.aspx page:
  * Click the "Database" Tab, which is second from the left on the tab bar
  * Set the server type drop-down to "Oracle"
  * Copy and paste your license key (make sure there is no extra whitespace)
  * Copy and paste your connection string (make sure there is no extra whitespace, remove the quotes if copying from sample)
    * Sample Oracle Microsoft Provider connection string:
      * " Provider = msdaora ; Data Source = MyOracleDB ; User Id = myUsername ; Password = myPassword ;"
    * Note: Oracle connection strings vary greatly, if this example doesn't work, please consult your Oracle DBA
  * Click the "Test" button to test the connection string
  * You should see the word "Success" next to the "Test" button
    * If "Failure" then check your connection string again
  * Click the "Save to Izenda.config" button in the upper left hand corner
* Click the "Preview (Requires Clearing Browser Cache)" Button to navigate back to the Report List page (ReportList.aspx)
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
* Open the Izenda Reports settings page by navigating to [Host]/[Virtual Directory]/settings.aspx in your web browser (i.e. http://localhost/AdHoc54/settings.aspx)
* Set the database and connection information using the Settings.aspx page:
  * Click the "Database" Tab, which is second from the left on the tab bar
  * Set the server type drop-down to "MySQL"
  * Copy and paste your license key (make sure there is no extra whitespace)
  * Copy and paste your connection string (make sure there is no extra whitespace, remove the quotes if copying from sample)
    * Sample MySQL .NET connector on default port 3306
      * **"DRIVER={MySQL ODBC 5.1 Driver};Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;"**
    * MySQL connection strings can vary greatly depending on installed components, if this does not work, please consult your MySQL database administrator
  * Click the "Test" button to test the connection string
  * You should see the word "Success" next to the "Test" button
    * If "Failure" then check your connection string again
  * Click the "Save to Izenda.config" button in the upper left hand corner
* Click the "Preview (Requires Clearing Browser Cache)" Button to navigate back to the Report List page (ReportList.aspx)
* Izenda Reports is ready for use