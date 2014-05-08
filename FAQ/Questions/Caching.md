#Caching in Izenda

[[_TOC_]]

##Question

What kinds of caching does Izenda use? Can I update the cache?

##Answer

Izenda caches all your reports and schema information automatically per browser session. Here is a list of the caching methods that are available in case you wish to manually update the cache, although generally the cache will self-update as needed.

###[[FilteredListReports]]

The AdHocConfig.FilteredListReports method will return a list of reports that are guaranteed to be available to the current user.

###InvalidateFilteredCaches

The AdHocConfig.InvalidateFilteredCaches() method will clean up the results cached in the FilteredListReports method and can be called manually if needed. Like, for instance, when the XML definitions of one or more reports change outside the environment.

###InvalidateSchemaCache

The AdHocConfig.InvalidateSchemaCache() method will update the schema for database changes, all filtered report lists, queries to the database that were cached, cached HTML results of reports, and cached XML report definitions.

##CleanUpCache

The FusionCache.CleanUpCache method is part of the Izenda Fusion Driver suite and will clear all cached HTML reports.

##RefreshAllCachedReports

The FusionCache.RefreshAllCachedReports method can be called to update the cache of HTML reports. Unlike CleanUpCache above, this will NOT clear the cache. It will include changes made to all HTML reports for the current user.