#SaveReportSet()

[[_TOC_]]

##About

This method is used to define how your reports are stored. By default, using [[DatabaseAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]] will save your reports in the [[SavedReportsTable|http://wiki.izenda.us/API/CodeSamples/SavedReportsTable]] and using [[FileSystemAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#File-System-Mode]] will save them to the Reports folder on your server's file system. You can redefine that behavior by overriding this method in your [[CustomAdHocConfig|http://wiki.izenda.us/API/AdHocConfig]] class.

##Sample C Methods

###DatabaseAdHocConfig

```csharp
public override void SaveReportSet(string reportName, ReportSet reportSet)
    {
      try
      {
        string connectionString = @"Persist Security Info=False;Initial Catalog=Northwind;Data Source=LESHA-PC\SQL2012;User ID=dataLogin;Password=dataPassword;Integrated Security=false;";
        string sql = string.Format(@"IF (EXISTS (SELECT Name FROM {2} WHERE Name = '{0}'))
          BEGIN UPDATE {2} SET Xml = '{1}', CreatedDate='{3}', ModifiedDate='{4}', TenantID='{5}' WHERE Name = '{0}' END
          ELSE BEGIN INSERT INTO {2} (Name, Xml, CreatedDate, ModifiedDate, TenantID) VALUES ('{0}', '{1}', '{3}', '{4}', '{5}') END",
          reportName.Trim(),
          reportSet.WriteXml(),
          AdHocSettings.SavedReportsTable,
          reportSet.DateCreated.ToString(),
          reportSet.DateModified.ToString(),
          "_global_");
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

###FileSystemAdHocConfig

```csharp
 public override void SaveReportSet(string reportName, ReportSet reportSet)
    {
      System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(ReportPath);
      string message = String.Format("{0} does not exist, Set Izenda.AdHoc.AdHocSettings.ReportsPath to the proper path and give full permission to the {1} for that folder.", dir.FullName, System.Threading.Thread.CurrentPrincipal.Identity.Name);
      if (!dir.Exists)
        throw new Exception(message);
      string fileName = System.IO.Path.Combine(ReportPath, reportName + ".xml");
      try
      {
        System.IO.FileInfo file = new System.IO.FileInfo(fileName);
        if (!file.Directory.Exists)
          file.Directory.Create();
        System.IO.StreamWriter writer = file.CreateText();
        string xml = reportSet.WriteXml();
        writer.Write(xml);
        writer.Close();
      }
      catch (UnauthorizedAccessException e)
      {
        throw new Exception("Make make sure 'NETWORK SERVICE' or 'ASPNET' has full permission to the Reports folder.\n" + e.Message);
      }
    }
```

##Sample VB.NET Methods
###DatabaseAdHocConfig
```visualbasic
Public Overrides Sub SaveReportSet(reportName As String, reportSet As ReportSet)
      Try
        Dim connectionString As String = "Persist Security Info=False;Initial Catalog=Northwind;Data Source=LESHA-PC\SQL2012;User ID=dataLogin;Password=dataPassword;Integrated Security=false;"
        Dim sql As String = String.Format("IF (EXISTS (SELECT Name FROM {2} WHERE Name = '{0}')) BEGIN UPDATE {2} SET Xml = '{1}', CreatedDate='{3}', ModifiedDate='{4}', TenantID='{5}' WHERE Name = '{0}' END ELSE BEGIN INSERT INTO {2} (Name, Xml, CreatedDate, ModifiedDate, TenantID) VALUES ('{0}', '{1}', '{3}', '{4}', '{5}') END", reportName.Trim(), reportSet.WriteXml(), AdHocSettings.SavedReportsTable, reportSet.DateCreated.ToString(), reportSet.DateModified.ToString(), "_global_")
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



###FileSystemAdHocConfig
```visualbasic
Public Overrides Sub SaveReportSet(reportName As String, reportSet As ReportSet)
      Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(ReportPath)
      Dim message As String = String.Format("{0} does not exist, Set Izenda.AdHoc.AdHocSettings.ReportsPath to the proper path and give full permission to the {1} for that folder.", dir.FullName, System.Threading.Thread.CurrentPrincipal.Identity.Name)
      If Not (dir.Exists) Then
        Throw New Exception(message)
      End If
      Dim fileName As String = System.IO.Path.Combine(ReportPath, reportName + ".xml")
      Try
        Dim file As System.IO.FileInfo = New System.IO.FileInfo(fileName)
        If Not (file.Directory.Exists) Then
          file.Directory.Create()
        End If
        Dim writer As System.IO.StreamWriter = file.CreateText()
        Dim xml As String = reportSet.WriteXml()
        writer.Write(xml)
        writer.Close()        
      Catch ex As UnauthorizedAccessException
        Throw New Exception("Make make sure 'NETWORK SERVICE' or 'ASPNET' has full permission to the Reports folder.\n" + ex.Message)
      End Try
    End Sub

```

