#How to Upload CSV Data to SQL Server

[[_TOC_]]

## Prerequisites
* You must obtain the csvetl.exe program which is distributed as a part of the Izenda Fusion product
* Access to SQL Server with permissions to modify an existing table, or permissions to create a new table 

## SQL Server Setup

From within SQL Server Manager:

1. Create a new login by right clicking on (<ServerName> -> Security -> Logins) and choose "New Login"
2. Choose SQL Server authentication, choose a username and password.  Disable "User must change password at next login".
3. Choose the Database you want to upload the data to (<ServerName> -> Databases).  If you want to create a new Database, right click on (<ServerName> -> Databases) and choose "New Database".  After choosing or creating your Database, right click on (<ServerName> -> Databases -> <YourDatabase> -> Security -> Users) and choose "SQL user with login" and enter the login for the username and the login fields.  Next choose the Membership page and checkmark "db_owner".  Click OK.

## csvetl usage
```bash
Usage: csvetl.exe <work mode> <connection string> <file> [file] .... [file]
```

Where work mode can be:

* recreate - for recreating tables
* append - for inserting values to existing tables without recreation
 
The table created or appended to will be named after the imported CSV file without the extension

Example: Create the products table with a CSV file called products.csv using the connection string

```winbatch
csvetl recreate "server=DEV6;database=northwind;User Id=northwind;
  Password=northwind;" products.csv
```

### Screencast
http://screencast.com/t/LyjCp1TMI1qV