#Using Stored Procedures In Izenda 6

[[_TOC_]]

##Usage

Since version 6.0, Izenda Reports can expose existing SPs (Stored Procedures) in MSSQL databases as DataSources for designed reports. This tutorial explains how you can create the appropriate SP in MSSQL 2005, and include it as a DataSource in a report. The Northwind sample database will be used in the examples. The main considerations are: 

* Creating or using an existing stored procedure in MSSQL 2005
* Making SPs visible in Izenda Reports
* IMPORTANT- Filtering the Equals select drop-down
* Building the report

###Creating SPs in MSSQL 2005 to use in Izenda Reports

When SPs are detected in your MSSQL database, their names will appear in the list of available DataSources in the Report Designer. Currently, Izenda AdHoc supports only input parameters, while parameters of other types are ignored. Input parameters play the role of the columns that are used in the WHERE clause of the SELECT statement.
To be suitable for AdHoc, SPs must return a standard SELECT statement. This will be treated as the result of a standard SELECT statement being performed on a table. The column names returned from the SP will be available as fields in your DataSource.
Example of a SP:

```sql
CREATE PROCEDURE GetContact @companyName varchar (250) AS
	BEGIN 
		SELECT ContactName, Phone FROM Customers 
		WHERE CompanyName LIKE '%'   @companyName   '%' 
	END        
```

<a name="SampleOutput"></a>Here we have a SP named "GetContact" that accepts one input parameter, the name of a company. It returns two columns; the customer's name, and a phone number. There is also a condition that the CompanyName must be similar to the input variable @companyName. If we will execute this SP in MSSQL 2005 using the Customers table from Northwind, we will get the following result:

|ContactName|Phone|
|-----------|-----|
|Andre Fonseca|(11)555-9482|
|Jonas Bergulfsen|07-98 92 35|
|Helvetius Nagy|(206)555-8257|
 
*Results of sample SP execution in MSSQL 2005.*

###Using SPs in your application

In order to utilize SPs, we will need to setup database mode first in Global.asax.

####MVC applications

```csharp
void Session_Start(object sender, EventArgs e)
{
	AdHocSettings.AdHocConfig = new CustomAdHocConfig();
}
[Serializable]
public class CustomAdHocConfig : DatabaseAdHocConfig
{
	public override void ConfigureSettings()
	{
		AdHocSettings.VisibleTables = new string[] {"GetContact", "DummyTable"};
	}
}
```

####Standard method

```csharp
[Serializable]
public class CustomAdHocConfig : DatabaseAdHocConfig
{
        public static void InitializeReporting() 
        {
                AdHocSettings.AdHocConfig = new CustomAdHocConfig();
        }
	public override void ConfigureSettings()
	{
		AdHocSettings.VisibleTables = new string[] {"GetContact", "DummyTable"};
	}
}
```

###Making SPs visible in Izenda Reports

The VisibleTables property must contain the exact names of all SPs that should be available as DataSources. **Caveat:** when the VisibleTables property is empty, all tables are visible by default, while all SP are hidden. If VisibleTables contains any names, then all tables not included in VisibleTables will become hidden. To use them, they must also be included in VisibleTables to be used together with SPs. In this code example, the table "DummyTable" is added to VisibleTables along with our SP to make it visible.

###Adding code for filtering the Equals(Select) drop-down.

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

###Building a report using SPs as the DataSource

Once you have completed the steps above and access your web application, you may notice there are DataSources that have "(SP)" at the end of name. After the SP is selected as the DataSource, you may continue to the Fields tab. Once you do, you may notice that some of fields have "(Param)" after their names.

These fields represent the input parameters of the SP, and can not be used as output fields. In our example above, we selected two fields: ContactName and Phone. These are the columns in the final SELECT statement of our SP (see [Creating SPs in MSSQL 2005 to use in Izenda Reports]().) The last thing that we need before executing our report is to set the value for the input parameter "companyName". This can be done at the Filters tab of the Report Designer.

To assign values to parameters of your SP, you need to select the field from the previous step (the one with "(Param)" at the end of name), then select the "Equals" operator, and type in the value for the parameter. In our example, we used the name "Gourmet" as our filter value. Now the report can be saved and executed. If you were following along, then you should have a datatable with the data [described above](#SampleOutput).

 
Figure 5. Results of executing report, using "GetContact" SP as DataSource.

Using Equals(...) filters operator with Stored Procedures