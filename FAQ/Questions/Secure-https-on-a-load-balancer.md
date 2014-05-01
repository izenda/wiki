#Secure HTTPS on a Load Balancer

##Question

How can I use an HTTPS load balancer with Izenda?

##Answer

If you are using a load balancer that does not support http (vs https), please set the following settings so the application can find images and css.

```csharp
string sUrl ="https://www.domain.com/App/Reporting/rs.aspx";

Izenda.AdHoc.AdHocSettings.ResponseServer = sUrl;
Izenda.AdHoc.AdHocSettings.ReportCssUrl = sUrl + "?css=report";
Izenda.AdHoc.AdHocSettings.ToolbarCssUrl = sUrl + "?css=toolbar";
Izenda.AdHoc.AdHocSettings.TabsCssUrl = sUrl + "?css=tabs";
```

Please refer to these articles for information about these settings

* [[ResponseServer|/API/CodeSamples/ResponseServer]]
* [[ReportCssUrl|/API/CodeSamples/ReportCssUrl]]
* [[ToolbarCssUrl|/API/CodeSamples/ToolbarCssUrl]]
* [[TabsCssUrl|/API/CodeSamples/TabsCssUrl]]