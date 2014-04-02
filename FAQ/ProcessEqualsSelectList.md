#The ProcessEqualsSelectList() Method

This code sample overrides the equals select drop-down used in the "Filter" tab and in the Report Viewer.

Here is sample code that you can add to your global file:

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