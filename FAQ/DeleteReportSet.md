#DeleteReportSet()

[[_TOC_]]

##Preface

The DeleteReportSet method is used to delete reports from your storage system. This method can be overridden in your [[CustomAdHocConfig|http://wiki.izenda.us/Integration/Tutorials/Customizing-Izenda-Settings]] class. 

##Usage
If you have overwritten [SaveReportSet()](http://wiki.izenda.us/FAQ/SaveReportSet) to change the location where reports are saved, it is necessary to use this override to indicate where the deletion will occur.

##Examples
The code samples below demonstrate method of overriding the method to implement custom functionality using both [[DatabaseAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]] and [[FileSystemAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#File-System-Mode]].

### C# DatabaseAdHocConfig Sample

```csharp
public override void DeleteReportSet(string reportName)
    {
      try
      {
        string connectionString = @"Persist Security Info=False;Initial Catalog=Northwind;Data Source=LESHA-PC\SQL2012;User ID=dataLogin;Password=dataPassword;Integrated Security=false;";
        string sql = string.Format(@"DELETE FROM {1} WHERE Name='{0}'", reportName.Trim(), AdHocSettings.SavedReportsTable);
        using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
        {
          connection.Open();
          using (System.Data.IDbCommand command = connection.CreateCommand())
          {
            command.CommandText = sql;
            command.ExecuteNonQuery();
          }
        }
      }
      catch
      {
      }
    }
```

### C# FileSystemAdHocConfig Sample

```csharp
public override void DeleteReportSet(string reportName)
    {
      try
      {
        string filePath = System.IO.Path.Combine(ReportPath, reportName);
        System.IO.File.Delete(filePath + ".xml");
      }
      catch
      {
      }
    }
```

### VB.NET DatabaseAdHocConfig Sample
```visualbasic
Public Overrides Sub DeleteReportSet(reportName As String)
      Try
        Dim connectionString As String = "Persist Security Info=False;Initial Catalog=Northwind;Data Source=LESHA-PC\SQL2012;User ID=dataLogin;Password=dataPassword;Integrated Security=false;"
        Dim sql As String = String.Format("DELETE FROM {1} WHERE Name='{0}'", reportName.Trim(), AdHocSettings.SavedReportsTable)
        Using connection As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
          connection.Open()
          Using command As System.Data.IDbCommand = connection.CreateCommand()
            command.CommandText = sql
            command.ExecuteNonQuery()
          End Using
        End Using
      Catch ex As Exception
      End Try
    End Sub
```

### VB.NET FileSystemAdHocConfig Sample
```visualbasic
Public Overrides Sub DeleteReportSet(reportName As String)
      Try
        Dim filePath As String = System.IO.Path.Combine(ReportPath, reportName)
        System.IO.File.Delete(filePath + ".xml")
      Catch ex As Exception
      End Try
    End Sub
```

