#SaveReportSet()

[[_TOC_]]

##About

This method is used to define how your reports are stored. By default, using [[DatabaseAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#Database-Mode]] will save your reports in the [[SavedReportsTable|http://wiki.izenda.us/API/CodeSamples/SavedReportsTable]] and using [[FileSystemAdHocConfig|http://wiki.izenda.us/FAQ/Storing-Reports#File-System-Mode]] will save them to the Reports folder on your server's file system. You can redefine that behavior by overriding this method in your [[CustomAdHocConfig|http://wiki.izenda.us/API/AdHocConfig]] class.

##Sample C Methods

###DatabaseAdHocConfig

```csharp
public override void SaveReportSet(string reportName, ReportSet reportSet) {
  // BEGIN Database Mode Code Sample  
  string SavedReportsTable = AdHocSettings.SavedReportsTable;
  string sql = string.Format(@"    
IF (EXISTS (SELECT Name FROM {2} WHERE Name = '{0}'))
BEGIN
	UPDATE {2} SET Xml = '{1}' WHERE Name = '{0}'
END
ELSE
BEGIN
	INSERT INTO {2} (Name, Xml) VALUES ('{0}', '{1}')
END",
  reportName.Trim(),
  reportSet.WriteXml(),
  SavedReportsTable);

  System.Data.IDbCommand command = Izenda.AdHoc.AdHocContext.Driver.CreateCommand(sql);
  try {
    command.ExecuteNonQuery();
  }
  finally {
    if (command.Connection.State == System.Data.ConnectionState.Open)
      command.Connection.Close();
  }
  // END Database Mode Code Sample 
}
```

###FileSystemAdHocConfig

```
public override void SaveReportSet(string reportName, Izenda.AdHoc.ReportSet reportSet) {
  // BEGIN Filesystem Mode Code Sample 
  DirectoryInfo dir = new DirectoryInfo(ReportPath);
  string message = string.Format("{0} does not exist, Set Izenda.AdHoc.AdHocSettings.ReportsPath to the proper path and give full permission to the {1} for that folder."
    , dir.FullName
    , Thread.CurrentPrincipal.Identity.Name);
  if (!dir.Exists)
    throw new DirectoryNotFoundException(message);

  string fileName = Path.Combine(ReportPath, reportName + ".xml");
  try {
    FileInfo file = new FileInfo(fileName);
    if (!file.Directory.Exists)
      file.Directory.Create();
    StreamWriter writer = file.CreateText();
    string xml = reportSet.WriteXml();
    writer.Write(xml);
    writer.Close();
  }
  catch (UnauthorizedAccessException e) {
    throw new Exception("Make make sure 'NETWORK SERVICE' or 'ASPNET' has full permission to the Reports folder.\n" + e.Message);
  }
  catch (SecurityException e) {
    throw new Exception("Make make sure 'NETWORK SERVICE' or 'ASPNET' has full permission to the Reports folder.\n" + e.Message);
  }
  // END Filesystem Mode Code Sample 
}
```