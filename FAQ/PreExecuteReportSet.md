#The PreExecuteReportSet() Method

[[_TOC_]]

##Hidden Filter C♯

This is a code sample showing how to add a hidden filter to a report. The first filter uses the _strArray_, but you will need to write a function which returns the columns which you wish to filter upon.

```csharp
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet) 

{   
    /* First Example, multi valued filter */  
    //columns to filter - write your own function  

    string[] strArray = new string[3] {"Beverages", "Seafood", "Produce"};   
  
      if(reportSet.Source.Contains("[dbo].[Categories]"))  
      {     
        Izenda.AdHoc.Filter newFilter = new Izenda.AdHoc.Filter();     
        newFilter.Column="CategoryName";     
        newFilter.Operator=OperatorTypes.In;     
        newFilter.Values = strArray;     
        
        reportSet.Filters.AddHidden(newFilter);     
        // will only show the category names corresponding to the array values   
      } //end if   

    /* Second Example, single valued filter */  
      if   (reportSet.Source.Contains("[dbo].[OtherCategories]"))   
      {     
        Izenda.AdHoc.Filter newFilter = new Izenda.AdHoc.Filter();     
        newFilter.Column = "CategoryName";     
        newFilter.Operator = OperatorTypes.Like;     
        newFilter.Value = "Sea";     
        reportSet.Filters.AddHidden(newFilter);     
        // will only show category names having the exact string "Sea" in them   
      } //end if 
}//end method
```
Essentially, to use a multi valued filter, you must use the In operator (basically an equals operator with comma separated values) and the .Values specifier.

To use a single valued operator such as "Like" (basically a case sensitive contains), you can not use an array and must use the .Value specifier.

##Hidden Filter with sql override

```csharp
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet) 

    MyBase.PreExecuteReportSet(reportSet)   
    'If reportSet.Source.Equals("[dbo].[Customers]") Then  
    Dim filter As New Izenda.AdHoc.Filter()  
    filter.Column = "email"   
    filter.SqlOverride = "(aspnet_Membership.email = 'greg@edelinsolutions.com' or aspnet_Membership.email='gedelin@yahoo.com')"  
    reportSet.Filters.AddHidden(filter)
    'End If
End Sub
```

##Hidden Filter VB.NET

```visualbasic
Public Overrides Sub PreExecuteReportSet(ByVal reportSet As Izenda.AdHoc.ReportSet) 
    MyBase.PreExecuteReportSet(reportSet)
    Dim emails(1) As String   
    emails(0) = "greg@edelinsolutions.com" 
    emails(1) = "gedelin@yahoo.com1"    
    Dim filter As New Izenda.AdHoc.Filter()   
    filter.Column = "email"   
    filter.Operator = OperatorTypes.In   
    filter.Values = emails   
    reportSet.Filters.AddHidden(filter)
End Sub
```

##Using a stored procedure

This example uses a stored procedure to populate a table before report design or execution. As shown in the comments, the table StoredProcResults must already exist. Every time a report is created or viewed this stored procedure will update the results of the _StoredProcResults_ table.

```csharp
// Customize a report on the fly prior to execution on a per user basis
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
{    

    /*this sample uses the adventure works database
     
    Here is the definition of the table and   
    stored procedure created for this report.
    
    CREATE TABLE [dbo].[StoredProcResults]  
    [ProductID] [int] NOT NULL,
    [OrderQuantity] [int] NOT NULL,   
    [Total] [int] NOT NULL,  
    [DueDate] [smalldatetime] NOT NULL    
    ) ON [PRIMARY]
    
    CREATE PROCEDURE DoCustomAction  (   
    @date1 as smalldatetime,    
    @date2 as smalldatetime  
    ) 
    AS  
    BEGIN  
    
    insert into StoredProcResults   
    select ProductID,OrderQty,LineTotal,ModifiedDate   
    from Sales.SalesOrderDetail   
    where ModifiedDate >= @date1 and ModifiedDate <= @date2   
     
    END    
    */

    string currentReportName =   
    HttpContext.Current.Request.QueryString["rn"];

    if (currentReportName == "StoredProcExample")   
    {      
      SqlConnection myConnection = new       
      SqlConnection(Izenda.AdHoc.AdHocSettings.SqlServerConnectionString);      
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