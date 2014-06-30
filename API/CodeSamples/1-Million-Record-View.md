#1 Million Record View

##About

Below is the SQL sample to create a View with 1 million records using the Northwind example database. This query can be used to load test your application with before you send it out to production.

##SQL Server

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

##Oracle

```sql
DROP VIEW NORTHWIND."1MOrders";

CREATE OR REPLACE FORCE VIEW NORTHWIND."1MOrders"
(
      "OrderID"
      ,"CustomerID"
      ,"OrderDate"
      ,"RequiredDate"
      ,"ShippedDate"
      ,"ShipVia"
      ,"Freight"
      ,"ShipName"
      ,"ShipAddress"
      ,"ShipCity"
      ,"ShipRegion"
      ,"ShipPostalCode"
      ,"ShipCountry"
      ,"UnitPrice"
      ,"Quantity"
      ,"Discount"
      ,"ProductID"
      ,"ProductName"
      ,"QuantityPerUnit"
      ,"UnitsInStock"
      ,"UnitsOnOrder"
      ,"ReorderLevel"
      ,"Discontinued"
      ,"CategoryName"
      ,"Description"
)
AS
   SELECT Orders.OrderID
      ,CustomerID
      ,OrderDate
      ,RequiredDate
      ,ShippedDate
      ,ShipVia
      ,Freight
      ,ShipName
      ,ShipAddress
      ,ShipCity
      ,ShipRegion
      ,ShipPostalCode
      ,ShipCountry
      ,Order_Details.UnitPrice
      ,Quantity
      ,Discount
      ,Products.ProductID
      ,ProductName
      ,QuantityPerUnit
      ,UnitsInStock
      ,UnitsOnOrder
      ,ReorderLevel
      ,Discontinued
      ,CategoryName
      ,Description
     FROM  Orders
     JOIN "ORDER_DETAILS" ON "ORDER_DETAILS"."ORDERID" = "ORDERS"."ORDERID"
     CROSS JOIN PRODUCTS
     CROSS JOIN CATEGORIES
     where rownum <= 1000000;

CREATE OR REPLACE SYNONYM NORTHWIND."Orders Qry" FOR NORTHWIND."1MOrders";
```