#Using Stored Procedures In Izenda 6

[[_TOC_]]

##Usage

Since version 6.0, Izenda Reports can expose existing SPs (Stored Procedures) in MSSQL databases as DataSources for designed reports. This tutorial explains how you can create the appropriate SP in MSSQL, and include it as a DataSource in a report. The Northwind sample database will be used in the examples. The main considerations are: 

* Creating or using an existing stored procedure in MSSQL
* Making SPs visible in Izenda Reports
* IMPORTANT- Filtering the Equals select drop-down
* Building the report

##Creating SPs in MSSQL to use in Izenda Reports

When SPs are detected in your MSSQL database, their names will appear in the list of available DataSources in the Report Designer. Currently, Izenda AdHoc supports only input parameters, while parameters of other types are ignored. Input parameters play the role of the columns that are used in the WHERE clause of the SELECT statement.
To be suitable for AdHoc, SPs must return a standard SELECT statement. This will be treated as the result of a standard SELECT statement being performed on a table. The column names returned from the SP will be available as fields in your DataSource.

**Example of a SP using the Northwind database:**

```sql
USE northwind;
GO
CREATE PROCEDURE GetContact
	@companyName varchar(250)
AS
  SELECT ContactName, Phone 
  FROM Customers 
  WHERE CompanyName LIKE '%' + @companyName + '%';
GO      
```

<a name="SampleOutput"></a>Here we have a SP named "GetContact" that accepts one input parameter, the name of a company. It returns two columns; the customer's name, and a phone number. There is also a condition that the CompanyName must be similar to the input variable @companyName. If we will execute this SP in MSSQL 2005 using the Customers table from Northwind, we will get the following result:

![MSSQL stored procedure results](/FAQ/Questions/Using-Stored-Procedures-In-Izenda-6/mssql_stored_procedure.png)
 
***Figure 1.** Results of sample SP execution in MSSQL.*

##Making SPs visible in Izenda Reports

You can use SPs in either DatabaseAdHocConfig mode or FileSystemAdHocConfig mode, as long as the SP exists in your database.

When using SPs, use the [[VisibleDataSources|/API/CodeSamples/VisibleDataSources]] setting to contain the all the SPs, tables, and views that should be available as DataSources. Each of the strings in this list must exactly mirror the name of the SP, table, or view as it appears in your data source.

**NOTE:** when the VisibleDataSources property is empty, all tables are visible by default, while all SP are hidden. If VisibleDataSources contains any names, then all tables not included in VisibleDataSources will become hidden. To use them, they must also be included in VisibleDataSources to be used together with SPs. In this code example, the table "DummyTable" is added to VisibleDataSources along with our SP to make it visible and denote the difference in naming between tables and SPs.

##Adding code for filtering the Equals(Select) drop-down.

Stored procedures generate sql for you and override the default queries created by Izenda Reports. Hence, the Equals(Select) drop-down will not be properly filtered because the stored procedure will not reflect the filter. In order to do this, you must populate the drop-down yourself using the "ProcessEqualsSelect" method. 

This will enable you to fully control what dropdown options are shown to the user.

```csharp
//Example implementation method to get the values that are to be used in the Equals(Select) dropdown
public string[] getEqualsSelectValues(string columnName, string dataSource)
{
	string sql = string.Format(@"SELECT TOP 500 {0} FROM {1} ", columnName, dataSource); 

	System.Data.IDbCommand command = Izenda.AdHoc.AdHocContext.Driver.CreateCommand(sql); 
	string[] results = null; 
	try 
	{ 
		command.ExecuteReader().GetValues(results); 
	} 
	finally 
	{ 
		if (command.Connection.State == System.Data.ConnectionState.Open) 
			command.Connection.Close(); 
	} 
	return results; 
} 

// Izenda Reports method to populate the Equals(Select) dropdown with your values  
public override string[] ProcessEqualsSelectList(Izenda.AdHoc.Database.Column column) 
{ 
	bool YouWantToUseCategories = true; 
	if(YouWantToUseCategories) 
		return getEqualsSelectValues(column.Name, "Categories"); 
	return base.ProcessEqualsSelectList(column); 
}
```

##Building a report using SPs as the DataSource

Once you have completed the steps above and access your web application, you may notice there are DataSources that have "(SP)" at the end of name. After the SP is selected as the DataSource, you may continue to the Fields tab. Once you do, you may notice that some of fields have "(Param)" after their names.

These fields represent the input parameters of the SP, and can not be used as output fields. In our example above, we selected two fields: ContactName and Phone. These are the columns in the final SELECT statement of our SP. The last thing that we need before executing our report is to set the value for the input parameter "companyName". This can be done at the Filters tab of the Report Designer.

To assign values to parameters of your SP, you need to select the field from the previous step (the one with "(Param)" at the end of name), then select the "Equals" operator, and type in the value for the parameter. In our example, we used the name "Gourmet" as our filter value. Now the report can be saved and executed. If you were following along, then you should have a datatable with the data [described above](#SampleOutput).


##Using extended Equals operators (Equals(Multiple); Equals(Popup); etc) with SPs

Within the Izenda Report Designer are filter options that allow you to select a value from a list instead of typing the value directly. When only using table names as data sources, these work just fine. You just select the field name and AdHoc fetches all values for that field from the data source in the database, groups them, and pulls them into the dropdown control. If SPs are used as data sources, this becomes a bit more complex. This is due to a couple of factors: 

* **Input parameters:** These are denoted with (Param) beside their names and must satisfy the SP's requirements for input. (i.e. having two required input parameters means using two filters whenever the SP is used) **Input parameters can NOT be used with the extended Equals operators as their possible values cannot be pre-determined.**
* **Output Fields:** These are the fields returned by the SP. Izenda detects what valid values can be selected with the given input parameters. **The list of output values can ONLY be built when all input parameters have defined values.**

In other words, you can only get a list of values for the **output fields** when values for all **input parameters** have been defined.

We will demonstrate how this works using the **SalesByCategory** SP in the **Northwind** database. To see this Stored Procedure in the data sources list, you need following line of code in your Global.asax:

```csharp
    AdHocSettings.VisibleDataSources = new string[] {"SalesByCategory"};
```

Also, you need to set the [[AllowEqualsSelectForStoredProcedures|/API/CodeSamples/AllowEqualsSelectForStoredProcedures]] setting to true to allow usage of the extended Equals operators for Stored Procedures. After this, you will be able to select SalesByCategory as data source, and select extended Equals operators for its fields. Once you have done so, you should be able to see the below fields available in your "Fields" dropdown on the ReportDesigner.

![Fig. 1: SalesByCategory](http://www.izenda.com/Site/KB/Uploads/Images/dhj3phkc_174gmzpr5fj_b.png)

**CategoryName** and **OrdYear** are input parameters (denoted with **(Param)**) whereas **ProductName** and **TotalPurchase** are output fields. After clicking on the "Filters" tab, we can set pre-defined values for our input parameters using a standard Equals operator, since they will be passed to our SP instead of being used in the query. After doing so, we can use the extended Equals operators with our output fields. Below, we have used the values "Beverages" and "1997" for our input parameters.

![Fig. 2: Filters Using SPs]()

After this, you can get a list of predefined values for any output fields using the extended Equals operators. Below, we have selected the **Equals (Multiple)** and **Equals (Select)**

![Fig. 3: Output Fields With SPs]()

Note that if you change the values of your **input parameters**, the output possibilities will also change. This is because the output fields depend on the input data. For instance, if we change the values that query our Northwinds database to "Meat/Poultry" and "1998", our output will change.

![Fig. 4: Output Fields Changed]()

##Using ProcessEqualsSelectList

From the example above, you can see that it is required to specify all stored procedure parameters. But if you don't want to specify parameters every time, you can pre-define them by overriding the ProcessEqualsSelectList() method in your [[AdHocConfig|/Integration/Tutorials/Customizing-Izenda-Settings]] class. 
The example below will give the same results as if you had specified the values as "Beverages" and "1998" above.

```csharp
public override string[] ProcessEqualsSelectList(Izenda.AdHoc.Database.Column column)
{
	if (column.Name == "ProductName")
	{
		string sql = @"EXEC SalesByCategory 'Beverages', '1998'";
		DataSet res = Izenda.AdHoc.AdHocContext.Driver.GetDataSet(Izenda.AdHoc.AdHocContext.Driver.CreateCommand(sql));
		List results = new List();
		foreach (DataRow row in res.Tables[0].Rows)
			results.Add(row.ItemArray[0].ToString());

		return results.ToArray();
	}
	return base.ProcessEqualsSelectList(column);
}
```

Now you can just select **ProductName** and apply the **Equals(Select)** filter to it:

![Fig. 5: Using ProcessEqualsSelectList results]()

##Using PreExecuteReportSet

This example uses a stored procedure to populate a table before report design or execution. Every time a report is created or viewed, the below stored procedure will update the results of the **StoredProcResults** table also defined below. Let's first create the table to hold the data.

```sql
CREATE TABLE [dbo].[StoredProcResults]  
    [ProductID] [int] NOT NULL,
    [OrderQuantity] [int] NOT NULL,   
    [Total] [int] NOT NULL,  
    [DueDate] [smalldatetime] NOT NULL    
    ) ON [PRIMARY]
```

Now we will create the SP to interface with this table.

```sql
CREATE PROCEDURE DoCustomAction  (   
    @date1 as smalldatetime,    
    @date2 as smalldatetime  
    ) 
    AS  
    BEGIN  
    
    insert into StoredProcResults   
    select p.ProductID, p.UnitsOnOrder, (p.UnitPrice * p.UnitsOnOrder), o.RequiredDate  
    from Orders o 
    join [Order Details] od on o.OrderID = od.OrderID
    join Products p on od.ProductID = p.ProductID
    where o.RequiredDate >= @date1 and o.RequiredDate <= @date2   
     
    END  
```

Now we will override the [[PreExecuteReportSet|/FAQ/PreExecuteReportSet]] method to access and execute the stored procedure under certain conditions. In our example, we will specify that any time a report is viewed with the name "StoredProcExample", we will update the StoredProcResults table with orders of products whose due dates fall between 1/1/2003 and 12/31/2003.

```csharp
// Customize a report on the fly prior to execution on a per user basis
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
{    
string currentReportName = HttpContext.Current.Request.QueryString["rn"];

    if (currentReportName == "StoredProcExample")   
    {      
      SqlConnection myConnection = new SqlConnection(Izenda.AdHoc.AdHocSettings.SqlServerConnectionString);      
      SqlCommand myCommand = new SqlCommand("DoCustomAction", myConnection);      

      // Mark the Command as a SPROC      
      myCommand.CommandType = System.Data.CommandType.StoredProcedure;    

      // Add Parameters to SPROC      
      SqlParameter parameterdate1 = new SqlParameter
      ("@date1", System.Data.SqlDbType.SmallDateTime);       
      parameterdate1.Value = "1/1/2003";       
      myCommand.Parameters.Add(parameterdate1);        
      
      SqlParameter parameterdate2 = new SqlParameter
      ("@date2", System.Data.SqlDbType.SmallDateTime);       
      parameterdate2.Value = "12/31/2003";      
      myCommand.Parameters.Add(parameterdate2);       

      try      
                
        myConnection.Open();           
        myCommand.ExecuteNonQuery();      
      }       
      
      finally      
      {
        myConnection.Close();       
      }    
    }
}
```

##Best Practices with Izenda

Izenda primarily uses metadata to obtain information about the schema, views, and other database objects, including stored procedures. Therefore, there are some expectations to be followed for these procedures that are to be used with Izenda.

Izenda sends NULL values for all parameters except dates, dates use an empty string, in a stored procedure and expects to receive column headers with no data in return. This allows Izenda to use the headers in the report designer just like a table or view to create reports. Below is a sample stored procedure that returns only the report headers when NULL values for the parameters parameters are passed from Izenda.

```sql
CREATE PROCEDURE [dbo].[CustOrdersDetail] @OrderID int
  AS
  IF @OrderID IS NULL
  BEGIN
    SELECT cast('' as nvarchar) as 'ProductName',
      cast(0 as float) as 'UnitPrice',
      cast(0 as int) as 'Quantity',
      cast(0 as float) as 'Discount',
      cast(0 as float) as 'ExtendedPrice'
    RETURN
  END
  SELECT ProductName,
    UnitPrice=ROUND(Od.UnitPrice, 2),
    Quantity,
    Discount=CONVERT(int, Discount * 100), 
    ExtendedPrice=ROUND(CONVERT(money, Quantity * (1 - Discount) * Od.UnitPrice), 2)
  FROM Products P, [Order Details] Od
  WHERE Od.ProductID = P.ProductID and Od.OrderID = @OrderID
```

Additionally, Izenda will occasionally need to create a temp table from the StoredProcedure for joining to other tables and views. The headers obtained when passing NULL parameter values are used to create this temp table. 

* INSERT EXEC - You cannot nest INSERT INTO ... EXEC statements in stored procedures used with Izenda. This is a limitation of SQL server.
* Return columns - The stored procedure MUST return the same columns in all cases. It is because the metadata expected when running the stored procedure must comply with the specifications given to it.
* Temp tables - You can build temp tables with the stored procedure and return that as long as the rules above are followed. Just ensure that the returned value is not null. This allows Izenda to obtain metadata from the empty result set of the stored procedure.
* Multiple values as one parameter - It is possible to pass multiple values as a single parameter. For instance, you can construct a comma separated list of values and pass that resulting string to the SP. It would then be possible to split the string into its respective parts within your SP.

##Stored Procedures in Oracle

As of Izenda 6.10.0.1, certain types of stored procedures can be used in Izenda with an Oracle database deployment. The criteria for stored procedures in Oracle such as needing the same columns to be returned in all situations is the same as MSSQL but with one additional condition: the stored procedure definition must be a [[table-valued pipeline function|http://docs.oracle.com/cd/B19306_01/appdev.102/b14289/dcitblfns.htm]]. This is the only way that Izenda will be able to detect what returned columns the stored procedure will yield.

Example:

```sql
create or replace TYPE IZ_CUSTORDERSORDERS_TY AS OBJECT (OrderID NUMBER, OrderDate TIMESTAMP(6), RequiredDate TIMESTAMP(6), ShippedDate TIMESTAMP(6));

create or replace TYPE IZ_CUSTORDERSORDERS_TB AS TABLE OF IZ_CUSTORDERSORDERS_TY;

create or replace FUNCTION IZ_CUSTORDERSORDERS (CUSTOMER_ID IN VARCHAR2) RETURN IZ_CUSTORDERSORDERS_TB PIPELINED IS
   RESULT_CUR SYS_REFCURSOR;
   val_1 Orders.OrderID%TYPE;
   val_2 Orders.OrderDate%TYPE;
   val_3 Orders.RequiredDate%TYPE;
   val_4 Orders.ShippedDate%TYPE;
BEGIN
  OPEN RESULT_CUR FOR
    SELECT OrderID, OrderDate, RequiredDate, ShippedDate
    FROM Orders
    WHERE Orders.CustomerID = CUSTOMER_ID
    ORDER BY OrderID;
    
  LOOP 
    FETCH RESULT_CUR INTO val_1,val_2,val_3,val_4;
    PIPE ROW(IZ_CUSTORDERSORDERS_TY(val_1,val_2,val_3,val_4));
    EXIT WHEN RESULT_CUR%NOTFOUND;
  END LOOP;
    
  CLOSE RESULT_CUR;
  RETURN;
END;
```

##Stored Procedures in MySQL

As of Izenda 6.10.0.1, the use of stored procedures is also available in Izenda with a MySql database deployment. The criteria for stored procedures such as needing the same columns to be returned in all situations is the same as MSSQL but there are some additional steps that must be taken for Izenda to properly interact with the stored procedure.

First, the [[MySqlConnectionString|/API/CodeSamples/MySqlConnectionString]] must be updated to include the following:

`MULTI_STATEMENTS=1`

Example:

`Driver={MySQL ODBC 5.2 ANSI Driver};DSN=MySQL;Server=YOUR_SERVER_IP;Port=YOUR_SERVER_PORT;Database=northwind;User=northwind;Password=traders;Option=3;MULTI_STATEMENTS=1`

Second, the stored procedure definition must contain a pattern of statements similar to the example below. Note that any line that does not include `/* Izenda-specific code */` may be substituted for your own code. Any place the stored procedure name appears such as `[sp_name]_spResult` requires the specific string `_spResult` on the end of the identifier to function properly.

Example:

```sql
DELIMITER $$
CREATE DEFINER=`northwind`@`%` PROCEDURE `izSales_by_Year`(in Beginning_Date Datetime,in Ending_Date Datetime)
BEGIN
	DROP TABLE IF EXISTS `izSales_by_Year_spResult`; /* Izenda-specific code */
    CREATE TEMPORARY TABLE `izSales_by_Year_spResult` AS /* Izenda-specific code */
	SELECT Orders.ShippedDate,
	   Orders.OrderID,
	  `Order Subtotals`.Subtotal,
	  ShippedDate AS Year
	FROM Orders  JOIN `Order Subtotals` ON Orders.OrderID = `Order Subtotals`.OrderID
	WHERE Orders.ShippedDate Between Beginning_Date And Ending_Date;
    
	SELECT * FROM `izSales_by_Year_spResult`; /* Izenda-specific code */
END$$
DELIMITER ;
```
##Notes: Some characters are not supported in Izenda field names. This is not an all-inclusive list, but some common items we have seen issues with.
- horizontal tabulation (\u0009)
- vertical tabulation (\u000B)
- line feed (\u000A)
- carriage return (\u000D)
- line separator (\u2028)
- paragraph separator (\u2029)
- form feed (\u000C)
- "[a].[b]" is not supported as a field name