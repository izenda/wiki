#LoadReportSet()

[[_TOC_]]

##About

This method controls how the CurrentReportSet object is loaded into the application for use. You can use this method as-is and Izenda will load reports in the default manner, but if you want to use a custom location to load data from, you should override this method.

##Sample C♯ Methods

###DatabaseAdHocConfig Mode

```csharp
    public override ReportSet LoadReportSet(string reportName)
    {
      try
      {
        string connectionString = @"Persist Security Info=False;Initial Catalog=Northwind;Data Source=LESHA-PC\SQL2012;User ID=dataLogin;Password=dataPassword;Integrated Security=false;";
        string sql = string.Format("SELECT Xml FROM {0} WHERE Name = '{1}'", AdHocSettings.SavedReportsTable, reportName);
        using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
        {
          connection.Open();
          using (System.Data.IDbCommand command = connection.CreateCommand())
          {
            command.CommandText = sql;
            using (System.Data.IDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                ReportSet reportSet = new ReportSet();
                reportSet.ReadXml(reader["Xml"].ToString());
                reportSet.OwnerTenantID = new string[] { "_global_" };
                return reportSet;
              }
              else
                return null;
            }
          }
        }
      }
      catch
      {
      }
      return null;
    }
```

###FileSystemAdHocConfig Mode

```csharp    
     public override ReportSet LoadReportSet(string reportName)
    {
      string fileName = System.IO.Path.GetFullPath(System.IO.Path.Combine(ReportPath, reportName + ".xml"));
      if (!fileName.StartsWith(ReportPath, StringComparison.InvariantCultureIgnoreCase))
        return null;
      System.IO.FileInfo file = new System.IO.FileInfo(fileName);
      if (!file.Exists)
        return null;
      System.IO.StreamReader reader = file.OpenText();
      string xml = reader.ReadToEnd();
      reader.Close();
      ReportSet reportSet = new ReportSet();
      try
      {
        reportSet.ReadXml(xml);
      }
      catch
      {
        return null;        
      }
      reportSet.OwnerTenantID = new string[] { "_global_" };
      return reportSet;
    }
```

##Sample VB.NET Methods

###DatabaseAdHocConfig Mode

```visualbasic
Public Overrides Function LoadReportSet(reportName As String) As ReportSet
      Try
        Dim connectionString As String = "Persist Security Info=False;Initial Catalog=Northwind;Data Source=LESHA-PC\SQL2012;User ID=dataLogin;Password=dataPassword;Integrated Security=false;"
        Dim sql As String = String.Format("SELECT Xml FROM {0} WHERE Name = '{1}'", AdHocSettings.SavedReportsTable, reportName)
        Using connection As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
          connection.Open()
          Using command As System.Data.IDbCommand = connection.CreateCommand()
            command.CommandText = sql
            Using reader As System.Data.IDataReader = command.ExecuteReader()
              If reader.Read() Then
                Dim reportSet As ReportSet = New ReportSet
                reportSet.ReadXml(reader("Xml").ToString())
                Dim owners(0) As String
                owners(0) = "_global_"
                reportSet.OwnerTenantID = owners
                Return reportSet
              Else
                Return Nothing
              End If
            End Using
          End Using
        End Using
      Catch ex As Exception
      End Try
      Return Nothing
    End Function
```

###FileSystemAdHocConfig Mode

```visualbasic
Public Overrides Function LoadReportSet(reportName As String) As ReportSet
      Dim fileName As String = System.IO.Path.GetFullPath(System.IO.Path.Combine(ReportPath, reportName + ".xml"))
      If Not (fileName.StartsWith(ReportPath, StringComparison.InvariantCultureIgnoreCase)) Then
        Return Nothing
      End If
      Dim file As System.IO.FileInfo = New System.IO.FileInfo(fileName)
      If Not (file.Exists) Then
        Return Nothing
      End If
      Dim reader As System.IO.StreamReader = file.OpenText()
      Dim xml As String = reader.ReadToEnd()
      reader.Close()
      Dim reportSet As ReportSet = New ReportSet()
      Try
        reportSet.ReadXml(xml)
      Catch ex As Exception
        Return Nothing
      End Try
      Dim owners(0) As String
      owners(0) = "_global_"
      reportSet.OwnerTenantID = owners
      Return reportSet
    End Function
```

##Logging Loading Exceptions

The "No Fields Selected" error occurs when there are zero valid fields in the report. The system is designed to hide reports when an exception occurs because it assumes it is a security exception and the user is not allowed to view that report for one of a multitude of reasons. The system is designed to hide reports that are not included in the current users's security credentials. If you would like to log the loading exception, you can do so by wrapping the above method in a try catch block and handling the exception by logging it where you want to view it later.