#Combining Multiple Event Based Fields with UNION

[[_TOC_]]

##About
Event-based or time-series data is often spread across multiple fields or data sources which makes it difficult to report on.  The UNION operator may be used to combine these fields into one and create an artificial categorical field which defines the type of event it is.

##Method 1

```sql
CREATE VIEW EventView AS
SELECT OrderDate AS Date, 'Order' AS Event, ShipCountry AS Country FROM 
Orders UNION
SELECT ShippedDate AS Date, 'Shipment' AS Event, ShipCountry AS Country 
FROM Orders UNION
SELECT HireDate AS Date, 'Hire' AS Event, Country AS Country 
FROM Employees
```

##Method 2

Additionally, an outer query may be used to further simplify the results of the UNION

```sql
CREATE VIEW EventView AS
SELECT DatePart(m,Date) as Month, DatePart(yyyy,Date) as YEAR, * FROM
(
SELECT OrderDate AS Date, 'Order' AS Event, ShipCountry AS Country FROM Orders UNION
SELECT ShippedDate AS Date, 'Shipment' AS Event, ShipCountry AS Country FROM Orders UNION
SELECT HireDate AS Date, 'Hire' AS Event, Country AS Country FROM Employees
) AS IQ
```