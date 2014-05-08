##Question

How Do I Force a User to Click on 'Update Results' Before Showing Any Data?

##Answer

There are actually two ways to get this functionality. 

###Method 1

If you are using filters in the report you want to force this functionality on, you can use the [[Filter tab|http://wiki.izenda.us/Guides/ReportDesign/5.0-Filters-tab#Require-[blank]-Parameters-in-Viewer]] controls to require a user to enter the filter parameters before ever displaying data. 

###Method 2

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