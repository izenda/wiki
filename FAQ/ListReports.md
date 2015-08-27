#The ListReports() Method

[[_TOC_]]

##About

The ListReports method allows you to dynamically alter the list of reports that Izenda uses on the Report List page. Below are examples of logic you could use with this method.

##Sample C♯ Methods

These examples are basic customized methods of obtaining a list of reports done using the different methods that Izenda supports.

###[[DatabaseAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]]

```csharp
public override ReportInfo[] ListReports()
    {
      try
      {
        string connectionString = @"Persist Security Info=False;Initial Catalog=Northwind;Data Source=LESHA-PC\SQL2012;User ID=dataLogin;Password=dataPassword;Integrated Security=false;";
        string sql = String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name", AdHocSettings.SavedReportsTable);
        ArrayList reportNames = new ArrayList();
        using (System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
        {
          connection.Open();
          using (System.Data.IDbCommand command = connection.CreateCommand())
          {
            command.CommandText = sql;
            using (System.Data.IDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                try
                {
                  string reportName = reader["Name"].ToString();
                  DateTime createdDate = (DateTime) reader["CreatedDate"];
                  DateTime modifiedDate = (DateTime) reader["ModifiedDate"];
                  if (reportName != "")
                    reportNames.Add(new ReportInfo(reportName, false, createdDate, modifiedDate, "_global_"));
                }
                catch
                {
                }
              }
            }
          }
        }
        return (ReportInfo[]) reportNames.ToArray(typeof(ReportInfo));
      }
      catch
      {
      }
      return new ReportInfo[0];
    }
```

####Controlling report access

In [[Database Mode|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]], you can override the [[SaveReportSet|/FAQ/SaveReportSet]] method to include [[CurrentUserName|/API/CodeSamples/CurrentUserName]] in the data saved to the [[SavedReportsTable|/API/CodeSample/SavedReportsTable]] and then structure a query like the following:

```csharp
    String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name WHERE UserID='{1}'", AdHocSettings.SavedReportsTable, AdHocSettings.CurrentUserName)
```

### [[FileSystemAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#File-System-Mode]]

```csharp
public override ReportInfo[] ListReports()
    {
      ArrayList reportNames = new ArrayList();
      if (AdHocSettings.ReportsPath != null)
      {
        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(AdHocSettings.ReportsPath);
        if (dir.Exists)
        {
          string dirName = System.IO.Path.GetFullPath(dir.FullName);
          ArrayList fileArray = new ArrayList();
          GetAllXmlFiles(dir, fileArray);
          System.IO.FileInfo[] files = (System.IO.FileInfo[]) fileArray.ToArray(typeof(System.IO.FileInfo));
          foreach (System.IO.FileInfo file in files)
          {
            if (file.Extension == ".xml")
            {
              try
              {
                System.IO.StreamReader reader = file.OpenText();
                reader.Close();
              }
              catch (Exception)
              {
                continue;
              }
              bool readOnly = false;
              try
              {
                System.IO.StreamWriter writer = file.AppendText();
                writer.Close();
              }
              catch (Exception)
              {
                readOnly = true;
              }
              string fileName = System.IO.Path.GetFullPath(file.FullName);
              string reportName = fileName.Substring(dirName.Length + (dirName.EndsWith("\\") ? 0 : 1));
              reportName = StringHelper.TrimEnd(reportName, ".xml");
              reportNames.Add(new ReportInfo(reportName, readOnly, file.CreationTime, file.LastWriteTime, "_global_"));
            }
          }
        }
      }
      return (ReportInfo[]) reportNames.ToArray(typeof(ReportInfo));
    }

    private static void GetAllXmlFiles(System.IO.DirectoryInfo dir, ArrayList files)
    {
      try
      {
        files.AddRange(dir.GetFiles("*.xml"));
        System.IO.DirectoryInfo[] subDirs = dir.GetDirectories();
        foreach (System.IO.DirectoryInfo subDir in subDirs)
          if (!subDir.Name.StartsWith("~"))
            GetAllXmlFiles(subDir, files);
      }
      catch
      {
      }
    }
```

##Sample VB.NET Methods

###DatabaseAdHocConfig

```visualbasic
Public Overrides Function ListReports() As ReportInfo()
      Try
        Dim connectionString As String = "Persist Security Info=False;Initial Catalog=Northwind;Data Source=LESHA-PC\SQL2012;User ID=dataLogin;Password=dataPassword;Integrated Security=false;"
        Dim sql As String = String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name", AdHocSettings.SavedReportsTable)
        Dim reportNames As ArrayList = New ArrayList()
        Using connection As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)
          connection.Open()
          Using command As System.Data.IDbCommand = connection.CreateCommand()
            command.CommandText = sql
            Using reader As System.Data.IDataReader = command.ExecuteReader()
              While reader.Read()
                Try
                  Dim reportName As String = reader("Name").ToString()
                  Dim createdDate As DateTime = DirectCast(reader("CreatedDate"), DateTime)
                  Dim modifiedDate As DateTime = DirectCast(reader("ModifiedDate"), DateTime)
                  If reportName <> "" Then
                    reportNames.Add(New ReportInfo(reportName, False, createdDate, modifiedDate, "_global_"))
                  End If
                Catch ex As Exception
                End Try
              End While
            End Using
          End Using
        End Using
        Return DirectCast(reportNames.ToArray(GetType(ReportInfo)), ReportInfo())
      Catch ex2 As Exception
      End Try
      Dim res(0) As ReportInfo
      Return res
    End Function
```

###FileSystemAdHocConfig

```visualbasic
Public Overrides Function ListReports() As ReportInfo()
      Dim reportNames As ArrayList = New ArrayList()
      If Not (AdHocSettings.ReportsPath Is Nothing) Then
        Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(AdHocSettings.ReportsPath)
        If dir.Exists Then
          Dim dirName As String = System.IO.Path.GetFullPath(dir.FullName)
          Dim fileArray As ArrayList = New ArrayList()
          GetAllXmlFiles(dir, fileArray)
          Dim files As System.IO.FileInfo() = DirectCast(fileArray.ToArray(GetType(System.IO.FileInfo)), System.IO.FileInfo())
          For Each file As System.IO.FileInfo In files
            If file.Extension = ".xml" Then
              Try
                Dim reader As System.IO.StreamReader = file.OpenText()
                reader.Close()
              Catch ex As Exception
                Continue For                
              End Try
              Dim ro As Boolean = False
              Try
                Dim writer As System.IO.StreamWriter = file.AppendText()
                writer.Close()
              Catch ex2 As Exception
                ro = True
              End Try
              Dim fileName As String = System.IO.Path.GetFullPath(file.FullName)
              Dim reportName As String
              If dirName.EndsWith("\\") Then
                reportName = fileName.Substring(dirName.Length)
              Else
                reportName = fileName.Substring(dirName.Length + 1)
              End If
              reportName = StringHelper.TrimEnd(reportName, ".xml")
              reportNames.Add(New ReportInfo(reportName, ro, file.CreationTime, file.LastWriteTime, "_global_"))
            End If
          Next
        End If
      End If
      Return DirectCast(reportNames.ToArray(GetType(ReportInfo)), ReportInfo())
    End Function
    
    Public Sub GetAllXmlFiles(dir As System.IO.DirectoryInfo, files As ArrayList)
      Try
        files.AddRange(dir.GetFiles("*.xml"))
        Dim subDirs As System.IO.DirectoryInfo() = dir.GetDirectories()
        For Each subDir As System.IO.DirectoryInfo In subDirs
          If Not (subDir.Name.StartsWith("~")) Then
            GetAllXmlFiles(subDir, files)
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub
```