##Question

Is there a way to store a pre-built string or object at application level? so that the application does not have to call the AddConstraint() method every time a user wants to connect to a database


##Answer

Custom constraints can be stored in application through following 3 steps

 1) Before adding constraints, put this line of code:

  Driver driver = AdHocContext.Driver;

and change all their "AdHocContext.Driver.AddConstraint(...)" lines to "driver.AddConstraint(...)"

 

2) Add following line of code right before adding first custom constraint:

  AdHocContext.Driver.BeginAddingMultipleConstraints();

 

3) Add following line of code right after adding last custom constraint:

  AdHocContext.Driver.EndAddingMultipleConstraints();


