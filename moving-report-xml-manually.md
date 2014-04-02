#Transferring, Moving, or Copying Report XML Manually

Izenda caches current contents of the ReportList based on the ReportSet created/modified date. But it does **NOT** save data on disk. It keeps it in **SESSION** only. Also it has no any relation to Fusion cache or other caching. It's just a stand-alone piece of code that stores the ReportList contents in the session.

**If transferred/copied, reports do not appear in the ReportList.**

There are many possible causes of this:

1) The above feature, which caches contents of ReportList to session, can cause this behavior. If you use out-of-proc session storage, for example, MSSQL session storage with ``timeout=1 week`` for example. You can even reboot the web server - but when you open a browser, they will still not see the new reports in your report list, because cached ReportList is stored in a serialized session. 

2) A malformed ReportSet can also cause this issue. If you copied reports records in your DB, for example, with just ``ctrl-c`` & ``ctrl-v``. As a result, symbols such as ``\r\n`` can be lost. As a result, the whole XML data of the ReportSet becomes a single long string. When this happens, that ReportSet then becomes erroneous from the point of view of Izenda.AdHoc, and won't load/show in ReportList.

3) Make sure TenantId values in ReportSet match the session values in the new deployment. When you copy ReportSet - without ``"_global_"`` tenant - some or all reports may be invisible to usual users.