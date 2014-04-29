#LoadReportSet()

[[_TOC_]]

##About

This method controls how the CurrentReportSet object is loaded into the application for use. You can use this method as-is and Izenda will load reports in the default manner, but if you want to use a custom location to load data from, you should override this method.

##Sample C♯ Methods

###DatabaseAdHocConfig Mode

```csharp
public override Izenda.AdHoc.ReportSet LoadReportSet(string reportName)
  {
    /* BEGIN Database Mode Code Sample */
    string sql = string.Format("SELECT Xml FROM {0} WHERE Name = '{1}'", AdHocSettings.SavedReportsTable, reportName);
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

###FileSystemAdHocConfig Mode

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

##Sample VB.NET Methods

###DatabaseAdHocConfig Mode

```visualbasic
Public Overrides Function LoadReportSet(reportName As String) As ReportSet
      'BEGIN Database Mode Code Sample
      Dim sql As String = String.Format("SELECT Xml FROM {0} WHERE Name = '{1}'", AdHocSettings.SavedReportsTable, reportName)
      Dim oXml As Object = Izenda.AdHoc.AdHocContext.Driver.GetScalar(sql)
      If oXml IsNot DBNull.Value AndAlso oXml IsNot Nothing Then
        Dim ReportSet As ReportSet = New Izenda.AdHoc.ReportSet()
        ReportSet.ReadXml(oXml.ToString())
        Return ReportSet
      End If
      Return Nothing
      'END Database Mode Code Sample
End Function
```

###FileSystemAdHocConfig Mode

```visualbasic
Public Overrides Function LoadReportSet(reportName As String) As ReportSet
      ' BEGIN Filesystem Mode Code Sample 
      Dim fileName As String = GetFileName(reportName) 'your method to get 
      If fileName = Nothing Then Return Nothing
      
      Dim file As FileInfo = New FileInfo(fileName)
      If Not file.Exists Then Return Nothing
      
      Dim reader As StreamReader = file.OpenText()
      Dim xml As String = reader.ReadToEnd()
      reader.Close()
      
      Dim reportSet As New ReportSet()
      reportSet.ReadXml(xml)
      Return reportSet
      
      ' END Filesystem Mode Code Sample
End Function
```