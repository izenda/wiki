#How Do I Get the ReportList Information to Create My Own ReportList?

Different approaches should be used in different architectures. WebForms Asp.Net, MVC, and pure HTML all have different solutions. 

---

_**The main question is how to get the ReportsList:**_

1) _On the server-side you could use any of these methods:_

- AdHocSettings.AdHocConfig.FilteredListReports 

- AdHocSettings.AdHocConfig.FilteredListReportsCached

- AdHocSettings.AdHocConfig.FilteredListReportsDictionary

- AdHocSettings.AdHocConfig.FilteredListReportsDictionaryCached

- AdHocSettings.AdHocConfig.ListReports

---

_**In this case a Dropdown menu could be populated using code like this (WebForms):**_

```csharp
private void PopulateReports()
{
    ReportInfo[] reports = AdHocSettings.AdHocConfig.FilteredListReportsCached();
    foreach (ReportInfo report in reports)
        ReportsDropDown.Items.Add(new ListItem(report.FullName, report.FullName));
}
```

---

2) _On the client side you could use an AJAX request to get JSON data. URLs to be used:_

- rs.aspx?wscmd=reportlistdata

- rs.aspx?wscmd=reportlistdatalite

_**In this case you could use JSON data to populate a client-side control using javascript.**_

------

We cannot provide ready-to-use examples because the code really depends on your particular use-case. Please contact Izenda Services with any questions: 

Services@Izenda.com