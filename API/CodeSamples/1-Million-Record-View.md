#1 Million Record View

##About

Below is the SQL sample to create a View with 1 million records using the Northwind example database. This query can be used to load test your application with before you send it out to production.

```sql
CREATE View [1MOrders] AS
SELECT TOP 1000000 
       [Orders].[OrderID]
      ,[CustomerID]
      ,[OrderDate]
      ,[RequiredDate]
      ,[ShippedDate]
      ,[ShipVia]
      ,[Freight]
      ,[ShipName]
      ,[ShipAddress]
      ,[ShipCity]
      ,[ShipRegion]
      ,[ShipPostalCode]
      ,[ShipCountry]
      ,[Order Details].[UnitPrice]
      ,[Quantity]
      ,[Discount]
      ,[Products].[ProductID]
      ,[ProductName]
      ,[QuantityPerUnit]
      ,[UnitsInStock]
      ,[UnitsOnOrder]
      ,[ReorderLevel]
      ,[Discontinued]
      ,[CategoryName]
      ,[Description]

FROM Orders
JOIN [Order Details] ON  [Order Details].[OrderID] = [Orders].[OrderID]
CROSS JOIN Products
CROSS JOIN Categories
GO
```