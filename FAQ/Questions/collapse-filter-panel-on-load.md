#Displaying Filters In Report Viewer

[[_TOC_]]

##Question
How can I default the filter panel to closed when a user accesses the Report Viewer?

##Answer

To default Filters in Report Viewer to closed on load of page use the following code in ReportViewer-Body.ascx. The user will need to click on the Filter Tab in the viewer to expand the filter panel and see the filters.

```javascript
jq$('#tab1li').removeClass('active');
jq$('#tab1').hide();
jq$('#updateBtnPC').show();
```