#SQL Samples of Various Join Types

[[_TOC_]

##Inner (Direct) Join

Selects rows from two tables such that the value in one column of the first table also appears in a column of the second table.  

```sql
SELECT DISTINCT 
[dbo].[Invoices].[CustomerName] AS 'Customer Name'
FROM [dbo].[Orders]
INNER JOIN [dbo].[Invoices] ON [dbo].[Invoices].[CustomerID]=[dbo].[Orders].[CustomerID];
```

##Cross Join

A cross join will return a result table where each row from the first table is combined with each row from the second table. 

```sql
SELECT DISTINCT 
[dbo].[Invoices].[CustomerName] AS 'Customer Name'
FROM [dbo].[Orders]
CROSS JOIN [dbo].[Invoices];
```

##Left(First Exists) Join

The Left Outer Join known also as Left Join returns all rows from the left table in the Left Outer Join clause, no matter if the joined columns match.  A field in a result row will be null if the corresponding input table did not contain a matching row.

```sql
SELECT DISTINCT 
[dbo].[Invoices].[CustomerName] AS 'Customer Name'
FROM [dbo].[Orders]
LEFT OUTER JOIN [dbo].[Invoices] ON [dbo].[Invoices].[CustomerID]=[dbo].[Orders].[CustomerID];
```

##Right Join

 The Right Outer Join known also as Right Join returns all rows from the right table in the Right Outer Join clause, no matter if the joined columns match.  A field in a result row will be null if the corresponding input table did not contain a matching row.

```sql
SELECT DISTINCT 
[dbo].[Invoices].[CustomerName] AS 'Customer Name'
FROM [dbo].[Orders]
RIGHT OUTER JOIN [dbo].[Invoices] ON [dbo].[Invoices].[CustomerID]=[dbo].[Orders].[CustomerID];
```

##Full Join

The Full Outer Join known also as Full Join returns all rows from Both the Right Outer Join & Left Outer Join.  A field in a result row will be null if the corresponding input table did not contain a matching row.

```sql
SELECT DISTINCT 
[dbo].[Invoices].[CustomerName] AS 'Customer Name'
FROM [dbo].[Orders]
FULL OUTER JOIN [dbo].[Invoices] ON [dbo].[Invoices].[CustomerID]=[dbo].[Orders].[CustomerID];
```

##Filters in WHERE

If you specify a [[filter|http://wiki.izenda.us/Guides/ReportDesign/5.0-Filters-tab]] for the column in first(left) table in JOIN clause, all filters will be applied as usual (i.e. all filters will be in the WHERE clause):

```sql
SELECT
[dbo].[Order Details].[Discount], 
[dbo].[Orders].[OrderID]
FROM [dbo].[Order Details]
LEFT OUTER JOIN [dbo].[Orders] ON [dbo].[Orders].[OrderID]=[dbo].[Order Details].[OrderID]
WHERE [dbo].[Order Details].[OrderID] = 10248
```

##Filters in Joins

Now let's say we want to specify filter for the column in the second(right) table. In this case, we should add this filter to the JOIN clause itself:

```sql
SELECT
[dbo].[Order Details].[Discount],
[dbo].[Orders].[OrderID]
FROM [dbo].[Order Details] 
LEFT OUTER JOIN [dbo].[Orders] ON [dbo].[Orders].[OrderID]=[dbo].[Order Details].[OrderID] AND [dbo].[Orders].[OrderID] = 10248
```

The reason why we shouldn't place the filter in the WHERE clause is that it will transform our **LEFT OUTER JOIN** to an **INNER JOIN**. For example, when you use "WHERE [dbo].[Order Details].[OrderID] = 10248", you remove all NULLs from the results (obviously NULL doesn't equal 10248). To avoid this (to retain NULLs in the results) we should follow ANSI-92 SQL syntax and use conditional joins.

##Filters in Inner Queries

We can also use an inner query to apply our outer left join:

```sql
SELECT
[dbo].[Order Details].[Discount],
Ord.[OrderID]
FROM [dbo].[Order Details] 
LEFT OUTER JOIN 
(SELECT * FROM [dbo].[Orders]
WHERE [dbo].[Orders].[OrderID] = 10248) AS Ord 
ON Ord.[OrderID]=[dbo].[Order Details].[OrderID]
```

When we apply filters within the JOIN clause, it's like we applied these filters separately to the table, and then added them to the JOIN. This can help speedup database performance. 

##References

Please refer to the articles below for more information:

* [[ANSI SQL-92 Standard|http://www.contrib.andrew.cmu.edu/~shadow/sql/sql1992.txt]]
* [[MSDN article about OUTER joins|http://msdn.microsoft.com/en-us/library/aa213228]]