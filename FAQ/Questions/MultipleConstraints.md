#Multi Constraints
[[_TOC_]]


##Question

Is there a way to pre-build a string or object and store it at the application level? to let each session copy it and change the connection string.  It is not optimal to have to call the AddConstraint() method so many times every time a user wants to connect to a database


##Answer


Multiple constraints can be stored in application as below.



**a.** Before adding constraints, put this line of code:

  ***Izenda.AdHoc.Database.Driver driver = AdHocContext.Driver;***

and change all their "AdHocContext.Driver.AddConstraint(...)" lines to "driver.AddConstraint(...)"

**b.** Add following line of code right before adding first custom constraint:

  ***AdHocContext.Driver.BeginAddingMultipleConstraints();***

**c.** Add following line of code right after adding last custom constraint:

  ***AdHocContext.Driver.EndAddingMultipleConstraints();***

##Global.asax (C♯)
```csharp

 public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
      //Check to see if we've already initialized.
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;

      Izenda.AdHoc.Database.Driver driver = AdHocContext.Driver;    //before adding any constraints, put this line

     AdHocContext.Driver.BeginAddingMultipleConstraints();    // add as many constraints as you want between begin and end
    
      driver.AddConstraint("[dbo].[Orders].[CustomerID]", "[dbo].[Invoices].[CustomerID]");
      
      driver.AddConstraint("[dbo].[Orders].[OrderID]", "[dbo].[Invoices].[OrderID]");
      
      AdHocContext.Driver.EndAddingMultipleConstraints();          
      ...
      }
}
```




