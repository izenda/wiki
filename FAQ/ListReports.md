#The ListReports() Method

[[_TOC_]]

##About

The ListReports method allows you to dynamically alter the list of reports that Izenda uses on the Report List page. Below are examples of logic you could use with this method.

##Sample C♯ Methods

These examples are basic customized methods of obtaining a list of reports done using the different methods that Izenda supports.

###[[DatabaseAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]]

```csharp
public override Izenda.AdHoc.ReportInfo[] ListReports() {
  /* BEGIN Database Mode Code Sample */

  ArrayList reportNames = new ArrayList();
  string sql = String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name",
  AdHocSettings.SavedReportsTable);
  System.Data.IDbCommand command = null;
  try {
    command = Izenda.AdHoc.AdHocContext.Driver.CreateCommand(sql);
    System.Data.IDataReader reader = command.ExecuteReader();

    while (reader.Read()) {
      string reportName = reader["Name"].ToString();
      DateTime createdDate = (DateTime)reader["CreatedDate"];
      DateTime modifiedDate = (DateTime)reader["ModifiedDate"];
      if (reportName != "")
        reportNames.Add(new Izenda.AdHoc.ReportInfo(reportName, false, createdDate, modifiedDate));
    }
  }
  catch (Exception) { }

  if (command.Connection.State == System.Data.ConnectionState.Open)
    command.Connection.Close();
  return (Izenda.AdHoc.ReportInfo[])reportNames.ToArray(typeof(Izenda.AdHoc.ReportInfo));
}

```

####Controlling report access

In [[Database Mode|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]], you can override the [[SaveReportSet|/FAQ/SaveReportSet]] method to include [[CurrentUserName|/API/CodeSamples/CurrentUserName]] in the data saved to the [[SavedReportsTable|/API/CodeSample/SavedReportsTable]] and then structure a query like the following:

```csharp
    String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name WHERE UserID='{1}'", AdHocSettings.SavedReportsTable, AdHocSettings.CurrentUserName)
```

### [[FileSystemAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#File-System-Mode]]

```csharp
public override ReportInfo[] ListReports() {
  ArrayList reports = new ArrayList();

  if (AdHocSettings.ReportsPath != null) {
    DirectoryInfo dir = new DirectoryInfo(AdHocSettings.ReportsPath);
    if (dir.Exists) {
      string dirName = Path.GetFullPath(dir.FullName);
      ArrayList fileArray = new ArrayList();
      GetAllXmlFiles(dir, fileArray); //your method for obtaining XML files from your file server
      FileInfo[] files = (FileInfo[])fileArray.ToArray(typeof(FileInfo));
      foreach (FileInfo file in files) {
        if (file.Extension == ".xml") {
          try {
            StreamReader reader = file.OpenText();
            reader.Close();
          }
          catch (Exception) {
            continue;
          }
          bool readOnly = false;
          try {
            StreamWriter writer = file.AppendText();
            writer.Close();
          }
          catch (Exception) {
            readOnly = true;
          }
          string fileName = Path.GetFullPath(file.FullName);
          string reportName = fileName.Substring(dirName.Length + (dirName.EndsWith("\\") ? 0 : 1));
          reportName = StringHelper.TrimEnd(reportName, ".xml");
          reports.Add(new ReportInfo(reportName, readOnly, file.CreationTime,
          file.LastWriteTime));
        }
      }//end foreach
    }//end if
  }//end if
  return (ReportInfo[])reports.ToArray();
}//end method

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
    catch (UnauthorizedAccessException)
    {
    }
}
```

##Sample VB.NET Methods

###DatabaseAdHocConfig

```visualbasic
Public Class CustomAdHocConfig
    Inherits Izenda.AdHoc.DatabaseAdHocConfig

    Protected Overrides Function ListReports() As Izenda.AdHoc.ReportInfo()
        Dim reportNames As New ArrayList()
        Dim sql As String = String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name WHERE UserID='{1}'", AdHocSettings.SavedReportsTable, AdHocSettings.CurrentUserName)

        Dim command As IDbCommand = Nothing
        Try
            command = Izenda.AdHoc.AdHocContext.Driver.CreateCommand(sql)
            Dim reader As IDataReader = command.ExecuteReader()

            While reader.Read()
                Dim reportName As String = reader("Name").ToString()
                Dim createdDate As DateTime = Convert.ToDateTime(reader("CreatedDate").ToString())
                Dim modifiedDate As DateTime = Convert.ToDateTime(reader("ModifiedDate").ToString())
                If reportName.Equals("") Then
                    reportNames.Add(New Izenda.AdHoc.ReportInfo(reportName, False, createdDate, modifiedDate))
                End If
            End While
        Catch
        End Try

        If command.Connection.State = System.Data.ConnectionState.Open Then command.Connection.Close()
        Return DirectCast(reportNames.ToArray(GetType(Izenda.AdHoc.ReportInfo)), Izenda.AdHoc.ReportInfo())
    End Sub
End Class
```

###FileSystemAdHocConfig

```visualbasic
Public Overrides Function ListReports() As ReportInfo()
  Dim reports As New ArrayList()

  If AdHocSettings.ReportsPath IsNot Nothing Then
    Dim dir As DirectoryInfo = New DirectoryInfo(AdHocSettings.ReportsPath)
    If dir.Exists Then
      Dim dirName As String = Path.GetFullPath(dir.FullName)
      Dim fileArray As New ArrayList()
      GetAllXmlFiles(dir, fileArray)
      Dim files As FileInfo() = DirectCast(fileArray.ToArray(typeof(FileInfo)), FileInfo())
      For Each file As FileInfo In files
        If file.Extension = ".xml" Then
          Try
            Dim reader As StreamReader = file.OpenText()
            reader.Close()
          Catch e As Exception
            Continue For
          End Try
          Dim readOnly As Boolean = False
          Try
            Dim writer As StreamWriter = file.AppendText()
            writer.Close()
          catch e As Exception
            readOnly = True
          End Try
          Dim fileName As String = Path.GetFullPath(file.FullName)
          Dim reportName As String = fileName.Substring(dirName.Length + CStr(IIf((dirName.EndsWith("\\"), 0, 1))))
          reportName = StringHelper.TrimEnd(reportName, ".xml")
          reports.Add(New ReportInfo(reportName, readOnly, file.CreationTime, _
          file.LastWriteTime))
        End If
      Next
    End If
  End If
  Return DirectCast(reports.ToArray(), ReportInfo())
End Function

Private Shared Sub GetAllXmlFiles(ByVal dir As System.IO.DirectoryInfo, ByRef files As ArrayList)
    Try
        files.AddRange(dir.GetFiles("*.xml"))
        Dim subDirs As System.IO.DirectoryInfo() = dir.GetDirectories()
        For Each subDir As System.IO.DirectoryInfo In subDirs
            If Not subDir.Name.StartsWith("~"))
                GetAllXmlFiles(subDir, files)
    Catch uae As UnauthorizedAccessException
    End Try
End Sub
```