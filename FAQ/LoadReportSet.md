#The LoadReportSet() Method

```csharp
public override Izenda.AdHoc.ReportSet LoadReportSet(string reportName)
  {
    /* BEGIN Database Mode Code Sample */
    string sql = string.Format("SELECT Xml FROM {0} WHERE Name = '{1}'", SavedReportsTable, reportName);
    object oXml = Izenda.AdHoc.AdHocContext.Driver.GetScalar(sql);
      if (oXml != DBNull.Value && oXml != null)
        {
          Izenda.AdHoc.ReportSet reportSet = new Izenda.AdHoc.ReportSet();
          reportSet.ReadXml(oXml.ToString());
          return reportSet;
        }
      return null;
    /* END Database Mode Code Sample */
```

```csharp    
    /* BEGIN Filesystem Mode Code Sample */
    string fileName = GetFileName(reportName);
      if (fileName == null)
      return null;
      
      FileInfo file = new FileInfo(fileName);
      if (!file.Exists)
      return null;
      
      StreamReader reader = file.OpenText();
      string xml = reader.ReadToEnd();
      reader.Close();
      
      ReportSet reportSet = new ReportSet();
      reportSet.ReadXml(xml);
      return reportSet;
      
    /* END Filesystem Mode Code Sample */
  }
```