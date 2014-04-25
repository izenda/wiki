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
  /* END Database Mode Code Sample */
}

```

###Controlling report access

In [[Database Mode|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]], you can override the [[SaveReportSet|/FAQ/SaveReportSet]] method to include [[AdHocSettings.CurrentUserName|/API/CodeSamples/CurrentUserName]] in the data saved to the [[SavedReportsTable|/API/CodeSample/SavedReportsTable]] and then structure a query like the following:

```csharp
    String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name WHERE UserID='{1}'", AdHocSettings.SavedReportsTable, AdHocSettings.CurrentUserName)
```

### [[FileSystemAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#File-System-Mode]]

```csharp
/* BEGIN Filesystem Mode Code Sample */

public override ReportInfo[] ListReports() {
  ArrayList reportNames = new ArrayList();

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
          reportNames.Add(new ReportInfo(reportName, readOnly, file.CreationTime,
          file.LastWriteTime));
        }
      }//end foreach
    }//end if
  }//end if
}//end method
```


```
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{	

    protected override Izenda.AdHoc.ReportInfo[] ListReports()
    {
        ArrayList reportNames = new ArrayList();
        string sql = String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name WHERE UserID='{1}'", AdHocSettings.SavedReportsTable, AdHocSettings.CurrentUserName); 

        System.Data.IDbCommand command = null;
        try
        {
            command = Izenda.AdHoc.AdHocContext.Driver.CreateCommand(sql);
            System.Data.IDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
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
}
```