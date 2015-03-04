#How to Add a Custom TimePeriod Type

[[_TOC_]]

##Question

How can I add a new time period to the list of time period filter options?

##Answer

You can use our [[CustomTimePeriods|/API/CodeSamples/CustomTimePeriods]] setting to dynamically add time periods with a **StartDate** and a **TimePeriod**.

Here is an example of how to add custom time spans to the filters. Apply this code within [[InitializeReporting()|/FAQ/InitializeReporting]] in your Global.asax.

###Example: Lunar Cycle

```csharp
//the if block prevents the key from being re-added to the list
if (!AdHocSettings.CustomTimePeriods.ContainsKey("Lunar Cycle")) { 
    AdHocSettings.CustomTimePeriods.Add("Lunar Cycle", new CustomTimePeriod("Lunar Cycle", new TimeSpan(29, 12, 44, 2, 976))); 
}
```

Since we didn't specify a **StartDate**, Izenda will assume the server's current date and time as the **StartDate** of the time period. If we run a report with an **in time period** filter on OrderDate that used **lunar cycle** as its time period on March 4, 2015 at 3:46:58 PM, the query results of this would like similar to the below SQL:

```sql
SELECT TOP 100000  
DATEPART(year, [dbo].[Invoices].[OrderDate]) AS 'Label', SUM([dbo].[Invoices].[Freight]) AS 'Value', DATEPART(month, [dbo].[Invoices].[OrderDate]) AS 'Separator'
FROM [dbo].[Invoices] WITH(NOLOCK) 
WHERE  ([dbo].[Invoices].[OrderDate] BETWEEN '2015-03-04T15:46:58.541' AND '2015-04-03T04:31:01.517') 
GROUP BY DATEPART(year, [dbo].[Invoices].[OrderDate]), DATEPART(month, [dbo].[Invoices].[OrderDate])
ORDER BY DATEPART(year, [dbo].[Invoices].[OrderDate]) ASC;
```

###Example: Today

We can also specify the start date. So if we wanted to get the results from just today and today is March 4, 2015, then we could craft a **TimePeriod** to do that.

```csharp
if(!AdHocSettings.CustomTimePeriods.ContainsKey("Today"))
{
    CustomTimePeriod today = new CustomTimePeriod("Today", new TimeSpan(23, 59, 59, 999), DateTime.Now.Date);
    AdHocSettings.CustomTimePeriods.Add("Today", today);
}
```

In this example, we specified the **StartDate** as today's date without any of the time information, which defaults to 0:00:00 (midnight). So if we query the results of the same report now, we would get:

```sql
SELECT TOP 100000  
DATEPART(year, [dbo].[Invoices].[OrderDate]) AS 'Label', SUM([dbo].[Invoices].[Freight]) AS 'Value', DATEPART(month, [dbo].[Invoices].[OrderDate]) AS 'Separator'
FROM [dbo].[Invoices] WITH(NOLOCK) 
WHERE  ([dbo].[Invoices].[OrderDate] BETWEEN '2015-03-04T00:00:00.000' AND '2015-03-04T23:59:59.999') 
GROUP BY DATEPART(year, [dbo].[Invoices].[OrderDate]), DATEPART(month, [dbo].[Invoices].[OrderDate])
ORDER BY DATEPART(year, [dbo].[Invoices].[OrderDate]) ASC;
```

###Modifying An Existing Time Period

You may at any time modify your existing set of custom time periods. You cannot, however, modify built-in time periods this way.

```csharp
      CustomTimePeriod ctp = AdHocSettings.CustomTimePeriods["Lunar Cycle"];
      ctp.StartDate = DateTime.Now + ctp.Period; //passed by reference so the original list will update
```