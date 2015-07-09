#How Does SSL Work In Izenda?

[[_TOC_]]

###Izenda And SSL

Izenda does not have any special SSL handlers. All Izenda pages will behave the same way as all other pages on the SSL-protected site.

The only extra factor is how Izenda loads internal resources. In many cases, Izenda embeds static resources into the HTML. Those resources must be downloaded first, using WebClient. There is some internal logic to make these resources accessible via HTTPS.

###How do I test to ensure secure connections work as expected?

Classes that are used to download data are all internal so there is no way to manually verify how they work. However, you can test this functionality by verifying these features work properly:

* Exports to different HTML based formats
* Exports of charts
* Thumbnail generation and viewing
* Scheduler exports

If no problems arise, then this should be all that is necessary to verify no further issues with secure connections in your application.

There are several settings that allow you to specify static resource URLs. These settings can also be verified to ensure expected operation:
* AdHocSettings.ReportCssUrl
* AdHocSettings.TabsCssUrl
* AdHocSettings.ReportHeaderImageUrl
* Any similar URl-related settings in the AdHocSettings class