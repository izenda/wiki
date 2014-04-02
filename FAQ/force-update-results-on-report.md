#How Do I Force a User to Click on 'Update Results' Before Showing Any Data?

To ensure a user must click on "Update Results" before showing any report data (regardless if there are filter parameters or not).

Add the following to the _ReportViewer-Body.ascx_ file in the ``<script>`` tag at the very bottom:
 
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