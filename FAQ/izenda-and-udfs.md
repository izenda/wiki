#Izenda and UDFs (User Defined Functions)

[[_TOC_]]

##Question

How do I utilize a complex UDF from my database within Izenda?

##Answer

Here is a step-by-step tutorial on how to use UDFs from your database in Izenda.

**1.** Create the UDF in the database that performs your calculation:

**EXAMPLE UDF:**

**MsSQL**
```sql
CREATE FUNCTION [dbo].[SafeDivide] (@p1 real ,@p2 real )
RETURNS real 
AS
BEGIN
    RETURN ISNULL(@p1 / NULLIF(@p2, 0), 0)
END
```

**Oracle**
```sql
create or replace function "SAFEDIVIDE"
(p1 in NUMBER, p2 in NUMBER)
return NUMBER
as
begin
    RETURN ROUND(nvl(p1 / NULLIF(p2, 0), 0), 7);
end;
```

**2.** Add this function to your [[CustomAdHocConfig|http://wiki.izenda.us/Integration/Tutorials/Customizing-Izenda-Settings]]:
``AdHocSettings.ExtendedFunctions = new string[] { "[dbo].[SafeDivide]" };``

**3a.** You can now choose this function in the 'Fields' tab function drop down for any column. (Functions, as the one above, with more than one input parameter cannot be chosen for a single column in the functions drop-down and must be implemented as an expression.)

![Example UDF](http://wiki.izenda.us/FAQ/FAQ/udfs_example.png)

**3b.** You can also use this function in the [[Expression|http://wiki.izenda.us/FAQ/UserGuides/15.0-Expressions-in-Izenda]] box on the 'Fields' tab's [[advanced panel|http://wiki.izenda.us/FAQ/advanced-field-settings]].

```sql
    SafeDivide([UnitsOnOrder], [UnitsInStock])
```

You can also use the Format dropdown to turn the result into your desired format. See the result below for what happens when we use the above expression in our Northwind Traders DataSource.

![Percent of Stock With UDFs](http://wiki.izenda.us/FAQ/FAQ/udfs_example_2.png)