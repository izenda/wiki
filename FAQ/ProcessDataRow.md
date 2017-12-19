#ProcessDataRow()

[[_TOC_]]

##Usage

The ``ProcessDataRow`` method is useful when you want to use post-processing in your application. This method should be overridden in your global.asax file. 

```csharp
public class CustomAdHocConfig : DatabaseAdHocConfig
{
	public override void ProcessDataRow(DataRow row, Report report, bool isTotals)
	{
		// Put your code here
	}
}
```

```visualbasic
<Serializable()> 
Public Class CustomAdHocConfig
        Inherits FileSystemAdHocConfig

        Public Overrides Sub ProcessDataRow(row As DataRow, report As Report, isTotals As Boolean)
		' put your code here
        End Sub
End Class
```

###Example: Using post-processing

C♯:

```csharp
public override void ProcessDataRow(DataRow row, Report report, bool isTotals)
{
    // We want to alter only "Detail" part of the report set
    if (report.Name == "Detail")
    {
        if (row != null)
        {
            // Iterate through columns to find column with name "Ship Region"
            foreach (DataColumn col in row.Table.Columns)
            {
                if (col.ColumnName == "Ship Region")
                {
                    // Iterate through rows to find the field with a value of "CA"
                    if (row[col].ToString() == "CA")
                        row[col] = "California";
                    // There can be only one column with a specific name,
                    // so we can leave the cycle as soon as we find it
                    break;
                }
            }
        }
    }
}
```

VB.NET

```visualbasic
Public Overrides Sub ProcessDataRow(row As DataRow, report As Report, isTotals As Boolean)
    'We want to alter only "Detail" part of the report set
    If report.Name = "Detail" Then
        If row IsNot Nothing Then
            'Iterate through columns to find column with name "Ship Region"
            For Each col As DataColumn In row.Table.Columns
                If col.ColumnName = "Ship Region" Then
                    If row(col).ToString() = "CA" Then row(col) = "California"
                    'There can be only one column with a specific name,
                    'so we can leave the cycle as soon as we find it
                    Exit For
                End If
            Next
        End If
    End If
End Sub

```

###Example: Dynamically changing time zones

C♯:

```csharp
public override void ProcessDataRow(DataRow row, Report report, bool isTotals)
{
    if (row.Table.Columns.Count == 0)
        return;
    // Iterate through ALL DateTime values and change values according to the local TimeZone 
    // Note: you could also change some fields only    
    foreach (DataColumn column in row.Table.Columns)
        if (column.DataType == typeof(DateTime))
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

VB.NET

```visualbasic
Public Overrides Sub ProcessDataRow(row As DataRow, report As Report, isTotals As Boolean)
    If (row Is Nothing) Then
        Return
    End If
    ' Iterate through ALL DateTime values and change values according to the local TimeZone	
    ' Note: you could also change some fields only	
    For Each column As System.Data.DataColumn In row.Table.Columns
        If (column.DataType Is GetType(DateTime)) Then
            row(column) = GetLocalTime(CType(row(column), DateTime))
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

###Example: Fetching a Column Used in a Report

C♯:

```csharp
public override void ProcessDataRow(DataRow row, Report report, bool isTotals)
{
    string columnToDecrypt = "[dbo].[Orders].[CustomerID]";
    if (report.Name == "Gauges" && row != null)
    {
        ReportSet crs = AdHocContext.CurrentReportSet;
        if (crs != null && crs.Reports.Contains("Gauges") && crs.Reports["Gauges"] != null && crs.Reports["Gauges"].Fields[0].ColumnName == columnToDecrypt)
        {
            // Decrypt ds.Tables[0].Columns[0]
            // ...
        }
    }
}
```

VB.NET:

```visualbasic
Public Overrides Sub ProcessDataRow(row As DataRow, report As Report, isTotals As Boolean)
    Dim columnToDecrypt As String = "[dbo].[Orders].[CustomerID]"
    If report.Name = "Gauges" AndAlso row IsNot Nothing Then
        Dim crs As ReportSet = AdHocContext.CurrentReportSet
        If (crs IsNot Nothing AndAlso crs.Reports.Contains("Gauges") AndAlso crs.Reports("Gauges") IsNot Nothing AndAlso crs.Reports("Gauges").Fields(0).ColumnName = columnToDecrypt) Then
            ' Decrypt ds.Tables[0].Columns[0]
            ' ...
        End If
    End If
End Sub
```