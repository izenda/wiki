#ProcessDataSet()

[[_TOC_]]

##Usage

The ``ProcessDataSet`` method is useful when you want to use post-processing in your application. This method should be overridden in your global.asax file. 

```csharp
public class CustomAdHocConfig : DatabaseAdHocConfig
{
	public override void ProcessDataSet(DataSet ds, string reportPart)
	{
		// Put your code here
	}
}
```

The first parameter is the System.Data.DataSet retrieved from the database. It is called "ds" here, but it can be named anything as long as the datatype remains the same. The second parameter is the name of the report in the ReportSet. For example, if part of your report is a grid named "Detail" and part of your report is a pie chart named "Chart", you can reference the grid part of your report by checking if ReportPart = "Detail". With that part of the report captured, you can manipulate it how you want and display the results. 

In addition to manipulating the way your data looks, post-processing can assist with encryption, logging, localization, etc. The ProcessDataSet method will be called after your data has been retrieved from the database, but before it is displayed. This means you can manipulate the data however you want in order to display it as you want. For example, you can replace encrypted data values with decrypted ones. Let's explore post-processing with the ProcessDataSet method further.

##Example: Using post-processing

For example, we want to rename the "CA" region code to "California", but only in the results grid. 
Without any post-processing we have the following report: 

![Before Post-Processing](http://www.izenda.com/Site/KB/Uploads/Images/PostProcess_before.png)

Now let's add some extra code to the CustomAdHocConfig class:

###C♯

```csharp
public override void ProcessDataSet(DataSet ds, string reportPart)
{
    // We want to alter only "Detail" part of the report set
    if (reportPart == "Detail") {
        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0) {
            // Iterate through columns to find column with name "Ship Region"
            for (int index = 0; index < ds.Tables[0].Columns.Count; index++) {
                if (ds.Tables[0].Columns[index].ColumnName == "Ship Region") {
                    // Iterate through rows to find the field with a value of "CA"
                    foreach (DataRow row in ds.Tables[0].Rows) {
                        if (row[index].ToString() == "CA")
                            row[index] = "California";
                    } 
                    // There can be only one column with a specific name,
                    // so we can leave the cycle as soon as we find it
                    break;
                }
            }
        }
    }
}
```

###VB.NET

```visualbasic
Public Overrides Sub ProcessDataSet(ByVal ds As DataSet, ByVal reportPart As String)
    'We want to alter only "Detail" part of the report set
    If reportPart = "Detail" Then
        If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0) IsNot Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
	    'Iterate through columns to find column with name "Ship Region"
	    For index As Integer = 0 to ds.Tables(0).Columns.Count - 1
	        If ds.Tables(0).Columns(index).ColumnName = "Ship Region" Then
                    For Each row As DataRow In ds.Tables(0).Rows
		        If row(index).ToString() = "CA" Then row(index) = "California"
                    Next
                    'There can be only one column with a specific name,
                    'so we can leave the cycle as soon as we find it
                    Exit For                                       
	        End If
	    Next
        End If
    End If
End Sub
```

When we run our post-processor code we will get the expected result:

![After Post-Processing](http://www.izenda.com/Site/KB/Uploads/Images/PostProcess_after.png)

As you can see, "CA" was replaced by "California" in the grid but the chart still displays "CA". 
Using this approach, you can change data retrieved from the database in many ways.
---
##Example: Dynamically changing time zones

This code sample show how to change TimeZone dynamically from the code. This allows you to show relevant Date values according to the current user local time.

C♯:

```csharp
public override void ProcessDataSet(DataSet ds, string reportPart)
{    
	if (ds.Tables.Count == 0)        
		return;    
	// Iterate through ALL DateTime values and change values according to the local TimeZone    
	// Note: you could also change some fields only    
	foreach (DataColumn column in ds.Tables[0].Columns)       
		if (column.DataType == typeof(DateTime))            
			foreach (DataRow row in ds.Tables[0].Rows)                
				row[column] = GetLocalTime((DateTime)row[column]);
}

private static DateTime GetLocalTime(DateTime utcTime)
{    
	// The only way to get user local time is to get in on the client-side (using javascript)    
	// Izenda already have this functionality, so you could use IZR_TimeZone session variable    
	// OR you may want to detect user TimeZone using your own methods    
	if (HttpContext.Current.Session["IZR_TimeZone"] == null)       
		return utcTime;    
	return utcTime.AddMinutes((int)HttpContext.Current.Session["IZR_TimeZone"]);
}
```

###VB.NET:

```visualbasic
Public Overrides Sub ProcessDataSet(ds As Data.DataSet, reportPart As String)	
	If (ds.Tables.Count = 0) Then		
		Return	
	End If	
	' Iterate through ALL DateTime values and change values according to the local TimeZone	
	' Note: you could also change some fields only	
	For Each column As System.Data.DataColumn In ds.Tables(0).Columns		
		If (column.DataType Is GetType(DateTime)) Then			
			For Each row As System.Data.DataRow In ds.Tables(0).Rows				  
				row(column) = GetLocalTime(CType(row(column), DateTime))			
			Next		
		End If	
	Next 
End Sub

Private Function GetLocalTime(utcTime As DateTime) As DateTime	
	' The only way to get user local time is to get in on the client-side (using javascript)	
	' Izenda already have this functionality, so you could use IZR_TimeZone session variable	
	' OR you may want to detect user TimeZone using your own methods	
	If (HttpContext.Current.Session("IZR_TimeZone") Is Nothing) Then		
		Return utcTime	
	End If	
	Return utcTime.AddMinutes(DirectCast(HttpContext.Current.Session("IZR_TimeZone"), Integer))
End Function
```