When updating to Izenda **_v6.7.0.272_** there are new changes to the _ReportDesigner.aspx_ file at the root of a standard Izenda deployment.

This file is not included with your Maintenance update - so there are two ways to update this to be compatible into the future:

1) Download the full Izenda RI at http://www.izenda.com/Site/DownloadComplete.aspx and update your ReportDesigner.aspx to the newer copy.

**--OR--**

2) Update the _ReportDesigner.aspx_ page manually:

* Open _ReportDesigner.aspx_ page within Notepad++, Visual Studio or another code tool.

* Replace the character ``$`` with ``jq$`` in the line ``$(document).ready(function() {``

* Relaunch your deployment- be sure to empty the page cache using 'F5' in your browser.