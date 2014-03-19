**Views**

[[_TOC_]]

###Why should I create views?

Izenda recommends using views as part of our best practices to optimize and simplify the user experience. Views offer the ability to draw data in from many sources, organize data, and perform many calculations on data before the user uses it as a report data source.

###What are views?

In SQL, a VIEW is a virtual table based on the result-set of a SELECT statement. A view contains rows and columns, just like a real table. The fields in a view are fields from one or more real tables in the database. You can add the SQL functions WHERE and JOIN to a view and present the data as if the data were coming from a single table. 

Note: The database design and structure will NOT be affected by the WHERE or JOIN functions in a view.

###How do I create views for my database?

Izenda Reports offers a direct front end for your database meaning that there is no need to create models, catalogs or secondary schemas.

Essentially the product does an analysis of the metadata rather than requiring a developer to create a mapping layer. This approach makes integration and maintenance significantly easier in that the product does not generally need to be maintained separately from the database. Most databases have evolved in such a way that the schema may be too complex from direct consumption by the user. Izenda recommends creating a series of views that present the user with a simplified and secure perspective to work with.

Izenda recommends creating views that use Camel Case (i.e. FirstName) or underscore format (i.e. first_name) to limit how much manual typing a report designer needs to do.

###View Code Samples

A Basic View

A view is generally created by adding the create view statement to a standard SQL statement.

``` sql
CREATE VIEW SampleView AS SELECT FirstName FROM User
```

This article will use a fictitious database to provide samples on how to best utilize views.


Table and Column Aliasing

Tables and columns are often named in ways that are not intuitive to the user. Izenda recommends aliasing in such situations.

``` sql
CREATE VIEW Persons AS SELECT ctx_fname  AS FirstName, ctx_lname AS LastName FROM ctx_usrs
```

Combining Columns

``` sql
CREATE VIEW Events AS
SELECT CASE DATEPART(w,CreateDate)
	WHEN ‘1’ THEN ‘Sunday’
	WHEN ‘2’ THEN ‘Monday’
	END AS DayOfWeekAggregating Data
CREATE VIEW OrderSummary 
SELECT DATEPART(yyyy,OrderDate) AS OrderMonth
	            ShipCountry AS Country,
		 COUNT(OrderID) AS Orders
FROM ORDERS
GROUP BY ShipCountry,DATEPART(yyyy,OrderDate)
```

**Pre-Joining Common Data Sources**

``` sql
CREATE VIEW Persons AS 
SELECT ctx_name
	AS Name, dep_dept_name
	AS Department
FROM ctx_usrs
JOIN ctx_depts
	ON ctx_usrs.did = ctx_depts.ctx_depts_id
Combining Multiple Databases

CREATE VIEW Persons AS 
SELECT DB1..ctx_name
	AS Name,DB2.. dep_dept_name
	AS Department
FROM DB1..ctx_usrs
JOIN DB2..ctx_depts
	ON DB1..ctx_usrs.did = DB2..ctx_depts.ctx_depts_id
```

**Combining Similar Data from Multiple Data Sources**

``` sql
CREATE VIEW Persons AS 
SELECT ctx_name
	AS Name
FROM ctx_usrs
UNION SELECT emp_name
	AS Name from ctx_employees
```

**Converting Numeric Values into Friendly Names**

``` sql
CREATE VIEW Events AS
SELECT CASE DATEPART(w,CreateDate)
		WHEN ‘1’ THEN ‘Sunday’
		WHEN ‘2’ THEN ‘Monday’
END AS DayOfWeekAggregating Data

CREATE VIEW OrderSummary
SELECT DATEPART(yyyy,OrderDate) AS OrderMonth
		    ShipCountry AS Country,
                 COUNT(OrderID) AS Orders
FROM ORDERS
GROUP BY ShipCountry,DATEPART(yyyy,OrderDate)
```

###Using Case Statements

**Simple Example**

``` sql
SELECT title, price, Budget = CASE price            
	WHEN price > 20.00 THEN 'Expensive'              
	WHEN price BETWEEN 10.00 AND 19.99 THEN 'Moderate'              
	WHEN price < 10.00 THEN 'Inexpensive'
ELSE 'Unknown' 
END,    
FROM titles
```

**Range Field Example**

``` sql
CREATE VIEW [RangeFieldExample] AS 
SELECT CASE
	WHEN [Freight] > 0   AND [Freight] < 1    THEN '$0 - $1'
	WHEN [Freight] > 1   AND [Freight] < 10   THEN '$1 - $10'
	WHEN [Freight] > 10  AND [Freight] < 100  THEN '$100 - $1'
	WHEN [Freight] > 100 AND [Freight] < 1000 THEN '$100 - $1000'
	WHEN [Freight] > 1000                        THEN '$1000 'END
AS [FreightRange],*
FROM [Orders]
```

###Pivot View Code Samples

**Pivot With Total Example**

``` sql
CREATE VIEW [PivotWithTotalExample] AS 
SELECT[ShipCountry]
	AS [Country],(CASE [Shippers].[CompanyName]
		WHEN 'Federal Shipping' 
			THEN Freight ELSE 0 END)
	AS [Federal Shipping], (CASE [Shippers].[CompanyName]
		WHEN 'Speedy Express'
			THEN Freight ELSE 0 END)
	AS [Speedy Express], (CASE [Shippers].[CompanyName]
		WHEN 'United Package'
			THEN Freight ELSE 0 END) 
	AS [United Package], Freight As [TotalFreight]
FROM [Orders]
JOIN [Shippers] on [Shippers].[ShipperID] = [Orders].[ShipVia]
```

**Year Pivot**

``` sql
SELECT [ShipCountry],SUM(Freight) AS Total,SUM(CASE DATEPART(yyyy,[OrderDate])
	WHEN '2005' THEN Freight ELSE 0 END) AS [2005], SUM(CASE DATEPART(yyyy,[OrderDate])
	WHEN '2006' THEN Freight ELSE 0 END) AS [2006], SUM(CASE DATEPART(yyyy,[OrderDate])
	WHEN '2007' THEN Freight ELSE 0 END) AS [2007], SUM(CASE DATEPART(yyyy,[OrderDate])
	WHEN '2008' THEN Freight ELSE 0 END) AS [2008]
FROM [Orders]
GROUP BY [ShipCountry]
```

Continue to [[Architecture]].