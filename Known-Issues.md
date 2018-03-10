<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on March 9, 2018.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.28|March 15, 2018|27816|internal - small change to make working with global.asax more stable|
|6.10.0.28|March 15, 2018|28707|Prevented error causing schedule changes to not always save or update when a report is successfully scheduled.|
|6.10.0.28|March 15, 2018|28725|Prevented extra visualization refreshes when visualizations are used on a dashboard which is being resized.|
|6.10.0.28|March 15, 2018|28857|Corrected error with using combokey to call an embedded subreport.|
|6.10.0.28|March 15, 2018|28908|Refactored ReportCollection class.|
|6.10.0.28|March 15, 2018|28921|Prevented Distinct from being disabled when a report is saved with an invalid column name.|
|6.10.0.28|March 15, 2018|28931|Corrected CSS not being applied to forms without first saving the report.|
|6.10.0.28|March 15, 2018|28962|Corrected error which prevented calculated fields from populating filters in instant report.|
|6.10.0.28|March 15, 2018|28970|Trimmed out some unnecessary filter query activity when cascading filters are disabled.|
|6.10.0.28|March 15, 2018|28974|Refactored AntiXSS protection to permit additional characters to be used in visual group.|
|6.10.0.28|March 15, 2018|28980|Corrected issue with calendar selector filter in instant reports.|
|6.10.0.28|March 15, 2018|28983|Corrected animated half circle gauge style conflicting with modern dashboards.|
|6.10.0.28|March 15, 2018|28985|Corrected issue where subtotals would not properly appear on pivots.|
|6.10.0.28|March 15, 2018|28992|Prevented some UI glitches when resizing screen.|
|6.10.0.28|March 15, 2018|29006|Changed behavior of clear pivot button so that it does not retain old data when pivot is re-added.|
|6.10.0.28|March 15, 2018|29008|Prevented being able to input 0 for "Items Per Page" value.|
|6.10.0.28|March 15, 2018|29010|Fixed some issues around printing and rendering embedded subreports.|
|6.10.0.28|March 15, 2018|29026|Further overhauled report parts and resource caching to enhance performance when using individual report parts.|
|6.10.0.28|March 15, 2018|29043|Corrected behavior of subreports in auto chart when using instant reports.|
|6.10.0.28|March 15, 2018|29057|Corrected text description for EmbedReportInServerEmail setting.|
|6.10.0.28|March 15, 2018|29062|Corrected use of Group(Week) function in pivot so that it does not provide faulty output.|
|6.10.0.28|March 15, 2018|29079|Corrected issue with corrupt expressions when a less than or greater than term is tested. This fix was retroactively applied to version 6.10.0.26 and 6.10.0.27 on March 7, 2018.|










