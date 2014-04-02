#15.3 Advanced Expressions

### Ratios

We can use arithmetic to get a percentage of one value compared to an aggregate value.  

**The following expression determines the percentage of an order’s cost paid for shipping:**
```
([Orders].[Freight])/(([Order Details].[UnitPrice]) * ([Order Details].[Quantity])+([Orders].[Freight]))
```

![expressions5](http://wiki.izenda.us/FAQ/FAQ/expressions5.png)

![expressions6](http://wiki.izenda.us/FAQ/FAQ/expressions6.png)

The above expression would return a decimal output.  For example, if Freight were ``$10`` and the total sum of ``UnitPrice*Quantity`` were ``$90``, then ``10/(90+10) = .1`` as our result.  Izenda will read this as a numeric value, so all that is necessary to turn this into a percentage is to select the ‘%’ format from the Formats dropdown for this field.

### Caution: The Limits of Expressions

However, this is where we encounter a limitation on expressions.  The above expression will produce correct results for each product in the order.  Since the data necessary for this expression comes from multiple data sources (Orders, Products, and Order Details in the Northwind DB) it is necessary to use key variables – in this case, OrderID – to link the tables.  Also, each OrderID has multiple associated ProductID to represent multiple products in each order.  It is not possible to specify variables from within an expression.  The net result of our expression will produce the ``UnitPrice*Quantity`` for a single 'ProductID' on each line.  It will not sum the total ``UnitPrice*Quantity`` values for multiple products within an order.

If we break the total equation into steps, the problem becomes clearer:

1):  Calculate UnitPrice*Quantity for each ProductID within an OrderID.

2):  Sum these calculated values into a hypothetical TotalUnitPrice for the OrderID.

3):  Add Freight to TotalUnitPrice and divide Freight by this value to get a percentage freight cost of total order cost.

Since expressions cannot create fields, but only display calculations based on fields, expressions cannot execute step 2.  Steps 1 and 2 should be calculated in a view, which would create a computed column that can be used in an expression for step 3.

---

[[15.0 Expressions in Izenda]]

[[UserGuides]]
