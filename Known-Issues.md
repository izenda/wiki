<!---##View Known Issues Report-->

<!---Click the link below and select "Login" to see the updated Known Issues Report. -->

<!---[Known Issues Report](http://fogbugz.izenda.us/reporting/reportviewer.aspx?rn=Tracking_DO_NOT_EDIT\\KIL\\KnownIssues)-->
##Known Issues

This list of issues is tentative and expected to change. Last updated on September 20, 2017.

|Expected Release|Tenative Date|Case|Notes|
|:----|:-----------|:----------------|:---------------|
|6.10.0.23|October 10|27754|Refactored internal datetime handling to prevent some possible issues with Culture datetime translations.|
|6.10.0.23|October 10|28261|Fixed location of dropdown menu in Instant Reports so as to not try to render itself partially offscreen.|
|6.10.0.23|October 10|28263|Refactored use of forward and back slashes for greater ease of use (both should be acceptable for most uses).|
|6.10.0.23|October 10|28294|Allowed caching of AdHocSettings.Culture.|
|6.10.0.23|October 10|28326|Corrected some UI behavior in Firefox that would prevent deleting reports.|
|6.10.0.23|October 10|28330|Minor tweaks to button color and appearance in the Instant Reports toolbar.|
|6.10.0.23|October 10|28334|Corrected "Multipart Identifier Could Not Be Bound" error when inheriting a field filter against a field from a datasource which is absent in the joined tables list of subreport.|
|6.10.0.23|October 10|28351|Changed URL generation for images so that they load without permissions errors in MVC.|







