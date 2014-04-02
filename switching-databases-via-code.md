#Switching databases via code

##Database Level Access

Izenda Reports can connect to a database on a per-user basis. In order to connect to multiple data sources, you must create a view which draws information from those data sources. Izenda Reports can then connect to the database which contains the view and stream data in to create a report. Switching database is done via code.

You can dynamically set the database access on a per-user basis using Izenda Reports:

C♯
```csharp
Izenda.AdHoc.AdHocContext.Driver.SqlServerConnectionString = @"server==(local);database==Northwind;Trusted_Connection==True;";
```
VB.NET
```visualbasic
Izenda.AdHoc.AdHocContext.Driver.SqlServerConnectionString = "server==(local);database==Northwind;Trusted_Connection==True;"
```