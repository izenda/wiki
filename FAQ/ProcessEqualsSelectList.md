#ProcessEqualsSelectList()

[[_TOC_]]

##About

The ProcessEqualsSelectList method is used to re-define how the Equals(Select) option renders its results on the Filters tab of the Report Designer. There are many different ways to deal with this particular list depending on how your application is structured. This code will add the values "Vendor 1" and "Vendor 2" into the list when the column's name that is being filtered is "VendorName".

##C♯ Method

Here is sample code that you can add to your global.asax file:

```csharp
public override string[] ProcessEqualsSelectList(Izenda.AdHoc.Database.Column column)
{
    //look for a particular column name
    if (column.Name == "VendorName")
    {
        ArrayList filteredValues = new ArrayList();
        filteredValues.Add("Vendor 1");
        filteredValues.Add("Vendor 2");
    
        //return custom list of values instead of full list
        return (string[])filteredValues.ToArray(typeof(string));
    }
    
   // return base if custom array is not created
   return base.ProcessEqualsSelectList(column);
}
```

##Other Articles

* [[Using Stored Procedures|/FAQ/Questions/Using-Stored-Procedures-In-Izenda-6]]