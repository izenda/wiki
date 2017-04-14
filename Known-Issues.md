<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on April 14, 2017.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.18|May 2|22876|Using ProcessEqualsSelectList to retrieve a list of filter values with the "Doesn't equals" filter operator returns no results.|
|6.10.0.18|May 2|25548|Custom Equals(Popup) not appearing|
|6.10.0.18|May 2|25920|Removed dependence on Izenda's rs.aspx from being in the application root folder rather than an Izenda subfolder.|
|6.10.0.18|May 2|26591|Optimized memory usage when rendering Visualizations.|
|6.10.0.18|May 2|26933|If visualization cannot be rendered due to a lack of data, message should be displayed stating "No Data to Display"|
|6.10.0.18|May 2|27076|Removing AdHocSettings.ToolbarBackgroundImageUrl which is no longer used in application.|
|6.10.0.18|May 2|27131|Issues with Page Break and Separator on VG Hierarchy and Analysis Grid|
|6.10.0.18|May 2|27155|In dashboard when "update results" is clicked a several times, first time it works fine, and only on second time filters disappear (because report suddenly becomes "not-dashboard").|
|6.10.0.18|May 2|27162|Intermittent Null Reference Error due to not-thread-safe work with dictionaries|
|6.10.0.18|May 2|27174|Added ability to set "Enable Responsive Grid" setting value for each tile individually: value depends on source report setting value. If source report uses the responsive grid - dashboard tile will it use too.|
|6.10.0.18|May 2|27177|Refactored Fusion driver for OData connections.|
|6.10.0.18|May 2|27206|Corrected internal methods used in Calendar.cs to prevent rare index out of range errors.|
|6.10.0.18|May 2|27257|Changed when scrollbars display on Dashboards to make them appear less often, especially when unnecessary.|
|6.10.0.18|May 2|27277|Optimized use of AdHocSettings.Driver in Fusion.|
|6.10.0.18|May 2|27317|Upgraded EVO PDF generator to version 7.|
|6.10.0.18|May 2|27327|Case sensitivity causes issues with some text groupings in Visual Groups.|
|6.10.0.18|May 2|27330|Changed field alias swap from Total2 to Total for columns in the summary.|
|6.10.0.18|May 2|27344|When user opens dashboard in the gallery mode for the first time, missing font errors are displayed in browser console.|
|6.10.0.18|May 2|27370|Receiving JS errors in some pages when navigating from new Instant Reports or New Dashboard page to another page in Izenda before page is fully loaded.|
|6.10.0.18|May 2|27388|Angular refactoring, unify all parts of the angular code which use $location service.|
|6.10.0.18|May 2|27422|Fixed error preventing reports with long names from being used as a subreport in a form.|
|6.10.0.18|May 2|27445|Corrected error where two copies of the same visualization with different filter settings would have the filter from the first visualization applied to both visualizations in print export.|



