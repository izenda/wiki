#Izenda API Tip: Constraints & Joins Best Practices

- All constraints are unidirectional (or anisotropic).

- Do not use simple table name without brackets, e.g. ***"Cases-Status"*** instead of ***"[Cases-Status]"***.

- Please make sure that you have two constraints for the target table relationship. e.g.:
```csharp
AdHocContext.Driver.
  AddConstraint("[dbo].[Cases-Status].[CaseID]","[dbo].[Cases-Payments].[CaseID]"); 
AdHocContext.Driver.
  AddConstraint("[dbo].[Cases-Payments].[CaseID]","[dbo].[Cases-Status].[CaseID]");
```

- LEFT JOIN syntax is also dependent on the 'direction' of the join. A->B produces different results than B->A. If you specify only one LEFT JOIN for Cases-Status and Cases-Payments tables then it will be used only in case when Cases-Payments table is joined to the Cases-Status table in that specific direction.

    If you want it to work in **both directions** you should specify two joins:
```csharp
    AdHocContext.Driver.AddForcedLeftJoin("Cases-Status","Cases-Payments");
    AdHocContext.Driver.AddForcedLeftJoin("Cases-Payments","Cases-Status");
```
