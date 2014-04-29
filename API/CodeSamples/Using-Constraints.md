#Using Constraints

[[_TOC_]]

##About

Virtual constraints are easy to add in Izenda Reports. Complicated schemas no longer require extensive user education or the changing of database schemas. Virtual constraints allow Izenda Reports to know about all connections between tables. 

If there are already constraints in the database, this will work automatically. If there are no constraints in the DB schema, Izenda will also look for common field names across your data sources. If that does not work, you could add virtual constraints manually through the Izenda API.

Here is a very simple example of how to use virtual constraints:

```csharp
AdHocContext.Driver.AddConstraint("Account.Id", "*.AccountID");
AdHocContext.Driver.AddConstraint("User.Id", "*.OwnerId");
AdHocContext.Driver.AddConstraint("User.Id", "Account.OwnerId");
```

**Note:** You can use wildcards (like the * above) to add rules for all tables instead of adding constraints for each pair of tables. 

##Join data sources with composite keys

By default, two data sources can be joined using a single constraint as described above. We will use the following as an example:

```csharp
AdHocContext.Driver.AddConstraint("[dbo].[Table1].[Column1]", "[dbo].[Table2].[Column1]");
```

However, what happens when your data source has more than one column used as a constraint key? You can actually perform this very easily using Izenda. Here is an example of how to add more than one constraint:

```csharp
AdHocContext.Driver.AddConstraint("[dbo].[Orders].[CustomerID]", "[dbo].[Invoices].[CustomerID]");
AdHocContext.Driver.AddConstraint("[dbo].[Orders].[ShipCountry]", "[dbo].[Invoices].[ShipCountry]");
AdHocContext.Driver.AddConstraint("[dbo].[Orders].[OrderID]", "[dbo].[Invoices].[OrderID]");
```

Notice that we define multiple columns for a single data source and map them to multiple columns for our second data source.

In this case Izenda will generate the following SQL:

```sql
SELECT *
FROM [dbo].[Orders]
INNER JOIN [dbo].[Invoices] 
ON [dbo].[Invoices].[OrderID]=[dbo].[Orders].[OrderID] 
AND [dbo].[Orders].[CustomerID]=[dbo].[Invoices].[CustomerID] 
AND [dbo].[Orders].[ShipCountry]=[dbo].[Invoices].[ShipCountry]
```

Please note that the primary key constraint is always the **last** constraint added for that particular data source. I.e. the constraint "[dbo].[Orders].[OrderID]" - "[dbo].[Invoices].[OrderID]" will be the primary key constraint. Only this constraint will be use for auto-joining and all other secondary constrains will be added to the JOIN clause later. 

Also note that currently there is no way to perform this action on the Report Designer. This must be done manually through code.