#Using Constraints

[[_TOC_]]

##About

Virtual constraints are easy to add in Izenda Reports. Complicated schemas no longer require extensive user education or the changing of database schemas. Virtual constraints allow Izenda Reports to know about all connections between tables. 

If there are already constraints in the database, this will work automatically.  If there are no constraints in the DB schema, you could add virtual constraints manually through the Izenda API.

**Note:** Constraints are *required* to use auto-joining in the Data Sources tab.

Here is a very simple example of how to use virtual constraints:

```csharp
AdHocContext.Driver.AddConstraint("Account.Id", "*.AccountID");
AdHocContext.Driver.AddConstraint("User.Id", "*.OwnerId");
AdHocContext.Driver.AddConstraint("User.Id", "Account.OwnerId");
```

**Note:** You can use wildcards (like the * above) to add rules for all tables instead of adding constraints for each pair of tables. 