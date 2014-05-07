#Getting ReportList Information

##Question

How do I get the ReportList Information to createmy own ReportList?

##Answer

Different approaches should be used in different architectures. WebForms, MVC, and pure AJAX all have different solutions. To that end, we will explore a couple of different solutions.

###Solution 1: Webforms

Here is a list of some helpful methods that allow you to obtain ReportList information with different structures.

- [[AdHocSettings.AdHocConfig.FilteredListReports|/FAQ/FilteredListReports]] 

- [[AdHocSettings.AdHocConfig.FilteredListReportsCached|/FAQ/FilteredListReportsCached]] 

- [[AdHocSettings.AdHocConfig.FilteredListReportsDictionary|/FAQ/FilteredListReportsDictionary]]

- [[AdHocSettings.AdHocConfig.FilteredListReportsDictionaryCached|/FAQ/FilteredListReportsDictionaryCached]]

- [[AdHocSettings.AdHocConfig.ListReports|/FAQ/ListReports]]

---

_**You can use this information to populate a WebForms Dropdown menu using code like this:**_

```csharp
private void PopulateReports()
{
    ReportInfo[] reports = AdHocSettings.AdHocConfig.FilteredListReportsCached();
    foreach (ReportInfo report in reports)
        ReportsDropDown.Items.Add(new ListItem(report.FullName, report.FullName)); //ReportsDropdown is a server-side control in your custom solution
}
```

###Solution 2: AJAX
---

Here is an example of an AJAX request you can send in order to return the ReportList data. This method returns a JSON formatted object.

- rs.aspx?wscmd=reportlistdata

- rs.aspx?wscmd=reportlistdatalite

_**In this case you could use JSON data to populate a client-side control using javascript like so:**_

```javascript
    function GetReports(keyword, category) {
        var requestString = 'wscmd=reportlistdatalite';
        if (keyword == null)
            keyword = '';
        requestString += '&wsarg0=' + category + '&wsarg1=' + keyword + '&wsarg2=1';
        AjaxRequest('./rs.aspx', requestString, AcceptReports, GetReportsFail, 'reportlistdatalite');
    }
```
------

We cannot, however, provide ready-to-use examples because the code really depends on your particular use-case. Please contact Izenda Services with any questions.