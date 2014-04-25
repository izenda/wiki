#The ListReports() Method

[[_TOC_]]

##About

The ListReports method allows you to dynamically alter the list of reports that Izenda uses on the Report List page. Below is an example of logic you could use with this method.

##Sample Method (DatabaseAdHocConfig)

```csharp
public override Izenda.AdHoc.ReportInfo[] ListReports()
{
  /* BEGIN Database Mode Code Sample */
  
  ArrayList reportNames = new ArrayList();
  string sql = String.Format("SELECT Name, CreatedDate, ModifiedDate FROM {0} ORDER BY Name", 
  SavedReportsTable);
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
      /* END Database Mode Code Sample */
```

##Sample Method (FileSystemAdHocConfig)

```csharp
      /* BEGIN Filesystem Mode Code Sample */
      ArrayList reportNames = new ArrayList();
    
      if (ReportPath != null)
        {
          DirectoryInfo dir = new DirectoryInfo(ReportPath);
          if (dir.Exists)
            {
              string dirName = Path.GetFullPath(dir.FullName);
              ArrayList fileArray = new ArrayList();
              GetAllXmlFiles(dir, fileArray);
              FileInfo[] files = (FileInfo[])fileArray.ToArray(typeof(FileInfo));
              foreach (FileInfo file in files)
                {
                  if (file.Extension == ".xml")
                    {
                      try
                        {
                          StreamReader reader = file.OpenText();
                          reader.Close();
                        }
                      catch (Exception)
                        {
                          continue;
                        }
                      bool readOnly = false;
                      try
                        {
                          StreamWriter writer = file.AppendText();
                          writer.Close();
                        }
                      catch (Exception)
                        {
                          readOnly = true;
                        }
                        
                      string fileName = Path.GetFullPath(file.FullName);
                      string reportName = fileName.Substring(dirName.Length + (dirName.EndsWith("\\")?0:1));
                      reportName = StringHelper.TrimEnd(reportName, ".xml");
                      reportNames.Add(new ReportInfo(reportName, readOnly, file.CreationTime, 
                      file.LastWriteTime));
                    }//end if
                }//end foreach
            }//end if
        }//end if
         //string[] reportNamesArray = new string[reportNames.Count];
         //reportNames.CopyTo(reportNamesArray, 0);
         //return (ReportInfo[])reportNames.ToArray(typeof(ReportInfo));
         
         /* END Filesystem Mode Code Sample */
}
```