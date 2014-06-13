#Caching in Izenda

[[_TOC_]]

##Question

What kinds of caching does Izenda use? Can I update the cache?

##Answer

Izenda caches all your reports and schema information automatically per browser session. Here is a list of the caching methods that are available in case you wish to manually update the cache, although generally the cache will self-update as needed.

###FilteredListReports

The [[AdHocConfig.FilteredListReports|http://wiki.izenda.us/FAQ/FilteredListReports]] method will return a list of reports that are guaranteed to be available to the current user.

###InvalidateFilteredCaches

The AdHocConfig.InvalidateFilteredCaches() method will clean up the results cached in the FilteredListReports method and can be called manually if needed. Like, for instance, when the XML definitions of one or more reports change outside the environment.

###InvalidateSchemaCache

The AdHocConfig.InvalidateSchemaCache() method will update the schema for database changes, all filtered report lists, queries to the database that were cached, cached HTML results of reports, and cached XML report definitions.

##CleanUpCache

The ``FusionCache.CleanUpCache`` method is part of the Izenda Fusion Driver suite and will clear all cached XML reports and dashboards.

##RefreshAllCachedReports

The ``FusionCache.RefreshAllCachedReports`` method can be called to update the cache of XML reports and dashboards based on whether the time period specified in the [[DataCacheInterval|/API/CodeSamples/DataCacheInterval]] setting has elapsed since the last time the report was cached. Unlike CleanUpCache above, this will NOT clear the cache. It will include changes made to all HTML reports for the current user. You can call this method yourself to update the cache based on your unique business logic (such as daily, during downtime hours).

##RefreshAllCachedDashboards

The ``FusionCache.RefreshAllCachedDashboards method will update the cache of XML dashboards, but not reports, based on whether the time period specified in the [[DataCacheInterval|/API/CodeSamples/DataCacheInterval]] setting has elapsed since the last time the dashboard was cached. This can be called based on your unique business logic.

##Limitations

Izenda Reports is a web application. Therefore, caching is susceptible to the client state. For example, do not have Izenda Reports running in separate windows or tabs of Internet Explorer. Otherwise, you could get the following behavior: by loading a report in one window and then loading a different report in another window, you may have unknowingly cached the second report, overriding the first. To properly enforce caching, only have a single instance of Izenda Reports running at a time per browser session. If you do open other browser windows and create/modify reports in that window, be sure you do not go back to the previous tab to continue modifying reports. Otherwise, you may see the newly cached report in your viewer instead of the one you were expecting to see.