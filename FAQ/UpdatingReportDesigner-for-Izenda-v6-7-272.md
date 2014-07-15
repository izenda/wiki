When updating to Izenda v6.7.0.272 there are new changes to the ReportDesigner.aspx file at the root of a standard Izenda deployment.

This file is not included with your Maintenance update - so there are two ways to update this.

1) Download the full Izenda RI at  http://izenda.com/Site/DownloadComplete.aspx?msgId=3 and update your ReportDesigner.aspx to the newer copy.

--OR--

2) Updtae the ReportDesigner page manually:

A) Open ReportDesigner.aspx page

B) Replace ``"$"`` with ``"jq$"`` in the line ``"$(document).ready(function() {"``