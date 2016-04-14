#Force "Update Results" On Report Viewer
[[_TOC_]]

##Question

How Do I Force a User to Click on 'Update Results' Before Showing Any Data?

##Answer

There are three ways to get this functionality. Method 1, using filters, is the easiest to implement, but it requires the user to input filter values to work. Method 2 should be employed if you do not wish for the user to input any filter values when hitting Update to execute the report after page load. Method 3 should only be used in versions of Izenda older than 6.9.0.1.

###Method 1 - Filters

If you are using filters in the report you want to force this functionality on, you can use the [[Filter tab|http://wiki.izenda.us/Guides/ReportDesign/5.0-Filters-tab#Require-[blank]-Parameters-in-Viewer]] controls to require a user to enter the filter parameters before ever displaying data. 

###Method 2 - Modifying _ReportViewer.js_

In the file:

Resources\FromDLL\Scripts\ReportViewer.js

There is a function called GotReportViewerConfig. Change this:

```javascript
if (!initialized)
    GetRenderedReportSet(false);
```

to this:

```javascript
 if (!initialized) {
        initialized = true;
        GetReportViewerConfig();
        FirstLoadInit();
    }
```

###Method 3 - Modifying _ReportViewer-Body.ascx_

**NOTE:** This method should only be used on versions of Izenda older than 6.9.0.1!

To ensure a user must click on "Update Results" before showing any report data (regardless if there are filter parameters or not), add the following to the _ReportViewer-Body.ascx_ file in the ``<script>`` tag at the very bottom. This will override a javascript method that normally runs when the page is loaded:
 
```javascript
function GotReportViewerConfig(returnObj, id) {
    if (id != 'reportviewerconfig' || returnObj == undefined || returnObj == null)
        return;
    nrvConfig = returnObj;
    if (document.getElementById('rlhref') != null)
        document.getElementById('rlhref').href = nrvConfig.ReportListUrl;
    urlSettings = new UrlSettings(nrvConfig.ResponseServerUrl);
    responseServer = new AdHoc.ResponseServer(urlSettings.urlRsPage + '?', 0);
    responseServerWithDelimeter = responseServer;
    ChangeTopRecords(nrvConfig.InitialResults, false);
    if (urlSettings.reportInfo.exportType != null) {
        responseServer.OpenUrlWithModalDialogNewCustomRsUrl('rs.aspx?output=' + urlSettings.reportInfo.exportType, 'aspnetForm', 'reportFrame', nrvConfig.ResponseServerUrl);
    };
    ApplySecurityOptions();
    GetFiltersData();
    if (initialized)
        return;
    initialized = true;
    FirstLoadInit();
}
```