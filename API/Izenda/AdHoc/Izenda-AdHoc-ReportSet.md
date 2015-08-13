#ReportSet

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[AddBookmarkForVisualGroup|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_AddBookmarkForVisualGroup]]|Determines whether PDF exports of this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] will insert a bookmark at the beginning of each visual group.|False|
|Boolean|[[CanBeLoaded|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_CanBeLoaded]]|Determines whether the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] can be loaded by checking every different condition in the validation process.|True|
|String|[[Category|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Category]]| Gets the report category. **(deprecated)**|null|
|Report|[[Chart|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Chart]]|Gets or sets the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that is used as the standard chart on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|null|
|Int32|[[ColumnsCount|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ColumnsCount]]||2|
|Int32|[[ColumnsInPivotGroup|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ColumnsInPivotGroup]]| Gets or sets the number of pivot columns that will be displayed on exports per page. |0|
|IEnumerable|[[CommonParameterFilters|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_CommonParameterFilters]]|Gets a list of all the distinct Izenda.AdHoc.Database.Columns used by all filters on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] and on individual Izenda.AdHoc.Reports within it.|null|
|Boolean|[[CsvOnly|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_CsvOnly]]| Determines whether this report may only be exported to CSV. |False|
|String|[[CustomCss|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_CustomCss]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report-specific CSS styling used on the report.|null|
|String|[[Database|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Database]]||String.Empty|
|DateTime|[[DateCreated|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_DateCreated]]|Gets the [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] representing the date and time the report was created.|null|
|DateTime|[[DateModified|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_DateModified]]|Gets the [[System.DateTime|http://msdn.microsoft.com/en-us/library/03ybds8y]] representing the last date and time the report was modified.|null|
|String|[[Description|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Description]]|Gets or sets the description of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|String.Empty|
|String|[[DescriptionJustification|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_DescriptionJustification]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the page justification of the report description.|null|
|Report|[[Detail|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Detail]]|Gets or sets the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that is used as the standard report.|null|
|Boolean|[[Distinct|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Distinct]]| Determines whether all reports in this report set will enforce a DISTINCT condition on results obtained. |True|
|String|[[DrillDownKey|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_DrillDownKey]]||String.Empty|
|String|[[DrillDownKey2|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_DrillDownKey2]]||String.Empty|
|DrillDownKeys|[[DrillDownKeys|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_DrillDownKeys]]|Gets a collection of columns used to drilldown into a subreport linked to this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|null|
|Boolean|[[ExposeAsDatasource|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ExposeAsDatasource]]| Determines whether this report should be available as a datasource when using the virtual datasources feature. |False|
|Int32|[[FieldValueColumnPairs|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_FieldValueColumnPairs]]| Gets or sets the amount Field&#124;Value column pairs. |2|
|FilterCollection|[[Filters|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Filters]]||null|
|FilterValue|[[FilterValue|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_FilterValue]]|Gets or sets the [[Izenda.AdHoc.FilterValue|/API/Izenda/AdHoc/Izenda-AdHoc-FilterValue]] that determines the number of filters required to view the report.|None|
|String|[[Footer|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Footer]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] footer text for the report.|null|
|String|[[FooterJustification|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_FooterJustification]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the page justification of the report footer.|null|
|String|[[Header|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Header]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] header text for the report.|null|
|String|[[HeaderImageJustification|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_HeaderImageJustification]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the page justification of the logo image shown in the header of the report.|null|
|String|[[HeaderJustification|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_HeaderJustification]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the page justification of the report header.|null|
|Boolean|[[IgnoreDdkValue1|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_IgnoreDdkValue1]]| Determines whether the first drilldown key in the collection of keys will be ignored for subreport data filtering purposes. |False|
|Boolean|[[IsDashBoard|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_IsDashBoard]]| Determines whether the report is being used on a dashboard. |False|
|Boolean|[[IsLocked|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_IsLocked]]| Gets or sets a value indicating that only admins or the report creator can modify the report. The filters may not be changed on the report viewer. |False|
|Boolean|[[IsValid|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_IsValid]]|Determines whether this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] contains errors and has at least one field in one of the contained [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] objects.|True|
|Report|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Item_-_System_String_-_]]|Gets or sets the individual [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] within this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|null|
|Int32|[[ItemsPerPage|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ItemsPerPage]]| Gets or sets the number of rows displayed on each page in the Report Viewer. UsePaginationInWebView must be true for this to have an effect. |10000|
|Boolean|[[LandscapePrinting|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_LandscapePrinting]]|Determines whether printing the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] will default to landscape printing. When false, portrait mode is used.|False|
|Report|[[Map|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Map]]|Gets or sets the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that is used for the map on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|null|
|Boolean|[[MinimizeGridWidth|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_MinimizeGridWidth]]|Determines whether the data grids on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] will use as little space as possible. When false, the data grid will always stretch across the length of the screen.|True|
|Boolean|[[MissingParameters|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_MissingParameters]]||False|
|String|[[Name|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Name]]| Gets the report name. **(deprecated)**|null|
|String|[[Owner|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Owner]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the owner of the report.|DefaultAdministrator|
|String[]|[[OwnerTenantID|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_OwnerTenantID]]|Gets or sets the list of tenant IDs associated with the owner of this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|[]|
|Boolean|[[PageBreakAfterVisualGroups|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_PageBreakAfterVisualGroups]]| Determines whether page breaks will be inserted after each visual group when exporting to PDF. |False|
|String|[[PageHeader|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_PageHeader]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] header text for the report.|null|
|String|[[ProcessedDescription|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ProcessedDescription]]|Gets the description of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with field references replaced with their respective values.|String.Empty|
|String|[[ProcessedFooter|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ProcessedFooter]]|Gets the footer of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with field references replaced with their respective values.|String.Empty|
|String|[[ProcessedHeader|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ProcessedHeader]]|Gets the header of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with field references replaced with their respective values.|String.Empty|
|String|[[ProcessedPageHeader|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ProcessedPageHeader]]|Gets the exported page header of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with field references replaced with their respective values.|String.Empty|
|String|[[ProcessedTitle|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ProcessedTitle]]|Gets the title of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with field references replaced with their respective values.|String.Empty|
|Boolean|[[ReadOnly|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ReadOnly]]| Gets or sets a value indicating whether report can be overriden. |False|
|String|[[Recipients|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Recipients]]|Gets or sets the email recipients for this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] separated by commas.|String.Empty|
|String|[[ReportCategory|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ReportCategory]]| Gets or set the report category.|null|
|String|[[ReportID|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ReportID]]|Gets or sets the GUID that is associated with the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|29156098-0678-469e-a58a-a4bfcd528cb5|
|String|[[ReportName|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ReportName]]| Gets or sets the report name. |null|
|StringCollection|[[ReportOrder|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ReportOrder]]|Gets or sets the rendering order for all [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] objects currently within the AdHoc.reportSet based on their computed absolute position. The report's X and Y position are considered when computing position.|{}|
|ReportCollection|[[Reports|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Reports]]|Gets or sets the collection of individual [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] objects associated with this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|{}|
|ReportSetType|[[ReportSetType|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ReportSetType]]|Gets or sets the [[Izenda.AdHoc.ReportSetType|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetType]] that determines how the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] is processed for viewing on different sources.|ReportDesigner|
|Hashtable|[[ReportVisibility|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ReportVisibility]]|Gets or sets the individual user and role level visibility settings for the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|null|
|ReportSetResults|[[Results|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Results]]|Gets or sets the loaded result data for this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|null|
|String|[[RowTitle|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_RowTitle]]| Gets or sets the title of the report. |String.Empty|
|Boolean|[[Shared|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Shared]]||False|
|Boolean|[[ShowDateTime|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ShowDateTime]]|Determines whether the date and time of the export is displayed on PDF and HTML exports for this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|False|
|Boolean|[[ShowPageNumber|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ShowPageNumber]]|Determines whether the page number will be displayed on PDF and HTML exports for this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].|False|
|Boolean|[[ShowVisualGroupLabels|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ShowVisualGroupLabels]]| Gets or sets whether field names should be shown in visual group header. **(deprecated)**|False|
|String|[[Source|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Source]]| Gets or sets the report source table. |String.Empty|
|String|[[SQL|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_SQL]]|Gets the combined SQL for each part of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] using the set of [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] objects in the set.|String.Empty|
|AdHocStyle|[[Style|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Style]]| Gets common style related to all reports in current reportset. |null|
|Report|[[Summary|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Summary]]|Gets or sets the [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] that is used as a summary of the Detail report.|null|
|String|[[Title|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Title]]| Gets or sets the title of the report. |String.Empty|
|String|[[TitleJustification|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_TitleJustification]]|Gets or sets the [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the page justification of the report title.|null|
|Boolean|[[UsePaginationInWebView|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_UsePaginationInWebView]]|Determines whether the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] will be displayed in pages when being viewed on the Report Viewer.|True|
|Int32|[[Version|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_Version]]| Gets the version number of the report. |6|
|Boolean|[[ViewOnly|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_ViewOnly]]| Gets or sets a value indicating that only admins or the report creator can modify the report. Others can change the filters on the report viewer. |False|
|VisualGroupStyle|[[VisualGroupStyle|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSet_VisualGroupStyle]]|Gets or sets the style that this [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] will use to visually group data.|CommaDelimited|


##Methods

###AddField(System.String,System.String,System.Boolean,System.Boolean,System.String,System.Int32,System.String)
Adds a field to the list of fields on the Detail [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that is being added to the report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] description  - The description that the new field should have.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isOrderByField  - Determines whether the new field will be included in the ORDER BY clause. When true, the sort order will be set to ascending order.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isGroupByField  - Determines whether the new field will be included in hte GROUP BY clause.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] aggregateFunction  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the aggregation function the field should have, if any.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] width  - The width in pixels of the new field.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] formatString  - The replacement [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that will be used to format the field data when it returns from the database.






---


###AddField(System.String,System.String)
Adds a field to the list of fields on the Detail [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the table that will be converted into an [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]].
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the column that will be converted into an [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]].





Returns:

The [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that was generated from the input information and added to the Detail report.


---


###AddField(System.String)
Adds a field to the list of fields on the Detail [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the column that will be converted into an [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]].





Returns:

The [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that was generated from the input information and added to the Detail report.


---


###AddFieldToReport(Izenda.AdHoc.Report,System.String,System.String,System.Boolean,System.Boolean,System.String,System.Int32,System.String)
Adds a field to the list of fields on the specified [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] r  - The [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]] to add the field to.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that is being added to the report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] description  - The description that the new field should have.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isOrderByField  - Determines whether the new field will be included in the ORDER BY clause. When true, the sort order will be set to ascending order.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isGroupByField  - Determines whether the new field will be included in hte GROUP BY clause.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] aggregateFunction  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the aggregation function the field should have, if any.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] width  - The width in pixels of the new field.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] formatString  - The replacement [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that will be used to format the field data when it returns from the database.





Returns:

The [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that was added to the specified report.


---


###AddFilter(System.String)
Adds a new [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] to the report that is hidden from the AdHocReportDesigner and Report Viewer.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that the data will filter on.





Returns:

The [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] that was added to the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###AddFilter(System.String,System.Object)
Adds a new [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] to the report that is visible on the AdHocReportDesigner.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that the data will filter on.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The filter value that will be used.





Returns:

The [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] that was added to the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###AddFilter(System.String,System.Boolean)
Adds a new [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] to the report that is visible on the AdHocReportDesigner. The operator the new filter will use is defaulted to True.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that the data will filter on.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] value  - Whether or not the new filter will use a NOT condition.






---


###AddFilter(System.String,Izenda.AdHoc.OperatorTypes,System.Boolean,System.Object)
Adds a new [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] to the report that is visible on the AdHocReportDesigner.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that the data will filter on.
* [[Izenda.AdHoc.OperatorTypes|/API/Izenda/AdHoc/Izenda-AdHoc-OperatorTypes]] operatorType  - The type of operator the filter will use.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] not  - Whether the NOT keyword will be used in the query generated by the filter.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The filter value that will be used.






---


###AddFilter(System.String,Izenda.AdHoc.OperatorTypes,System.Boolean,System.Boolean,System.Object[])
Adds a new [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] to the report that is visible on the AdHocReportDesigner.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that the data will filter on.
* [[Izenda.AdHoc.OperatorTypes|/API/Izenda/AdHoc/Izenda-AdHoc-OperatorTypes]] operatorType  - The type of operator the filter will use.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] orIsBlank  - Whether the filter will accept nulls as valid data for the filter.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isParameter 
* [[System.Object[]|http://msdn.microsoft.com/en-us/library/e5kfa45b]] values  - The list of filter values that will be used.






---


###AddHiddenFilter(System.String,System.Object)
Adds a new [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] to the report that is hidden from the AdHocReportDesigner and Report Viewer.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that the data will filter on.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The filter value that will be used.





Returns:

The [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] that was added to the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].


---


###AddSource(System.String)
 Adds a table with the specified name to the list of JoinedTables with no joining information. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sourceTableName  - The Syste.String representation of the name of the table to add.






---


###AddSource(System.String,System.String,System.String,System.String,Izenda.AdHoc.JoinType)
 Adds a table with the specified information to the list of JoinedTables. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] sourceTableName  - The Syste.String representation of the name of the table to add.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fully-qualified column name of the lefthand join relationship.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] joinFieldName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fully-qualified column name of the righthand join relationship.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] foreignTableName  - The Syste.String representation of the name of the righthand table to join on.
* [[Izenda.AdHoc.JoinType|/API/Izenda/AdHoc/Izenda-AdHoc-JoinType]] joinType  - The [[Izenda.AdHoc.JoinType|/API/Izenda/AdHoc/Izenda-AdHoc-JoinType]] that will be used to determine what kind of join to use.






---


###AddSummaryField(System.String,System.String)
Adds a field to the list of fields on the Summary [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] tableName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the table that will be converted into an [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]].
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the column that will be converted into an [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]].





Returns:

The [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]] that was generated from the input information and added to the Detail report.


---


###AddSummaryField(System.String)
Adds a field to the list of fields on the Summary [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name of the column that will be converted into an [[Izenda.AdHoc.Field|/API/Izenda/AdHoc/Izenda-AdHoc-Field]].






---


###AddSummaryField(System.String,System.String,System.Boolean,System.Boolean,System.String,System.Int32,System.String)
Adds a field to the list of fields on the Summary [[Izenda.AdHoc.Report|/API/Izenda/AdHoc/Izenda-AdHoc-Report]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fieldName  - The fully-qualified column name of the database field that is being added to the report.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] description  - The description that the new field should have.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isOrderByField  - Determines whether the new field will be included in the ORDER BY clause. When true, the sort order will be set to ascending order.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] isGroupByField  - Determines whether the new field will be included in hte GROUP BY clause.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] aggregateFunction  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the aggregation function the field should have, if any.
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] width  - The width in pixels of the new field.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] formatString  - The replacement [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that will be used to format the field data when it returns from the database.






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GenerateOutput(System.String)
Creates a serialized output file of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] using the specified output type.

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] type  - The type of file to export to.





Returns:

A serialized [[System.Byte|http://msdn.microsoft.com/en-us/library/yyb1w04y]] array containing the serialized data of the output file.


---


###GetColumnNameArray(System.String)
 Gets the individual parts of a column name using the full name of a column. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] fullName  - The fully qualified name of the column.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] array of the individual parts of the fully qualified column name.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetQualifiedName(System.String)
 Gets the fully qualified column name from an arbitrary representation of the column name. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] columnName  - The source column name.





Returns:

The fully qualified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the column name.


---


###GetSchema()
 Gets the XML schema. 





Returns:

XML schema of this object.


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetVolatileOption(System.String)
Gets the [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] with the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key from a collection of dynamic properties associated with the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key of the dynamic property to get the value of.





Returns:

A [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] representation of the dynamic property.


---


###InitializeNew()
Initializes a new instance of a [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with the source table set to the DefaultTable.





Returns:

A new [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] with the source table set.


---


###LoadData(Izenda.AdHoc.ReportOutputOptions)
Loads the [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] containing the data for the report.

Parameters: 

* [[Izenda.AdHoc.ReportOutputOptions|/API/Izenda/AdHoc/Izenda-AdHoc-ReportOutputOptions]] options  - The various rendering options that deterimine how the data should be loaded.





Returns:

The loaded [[Izenda.AdHoc.ReportSetResults|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSetResults]] containing the report data.


---


###ReadXml(System.Xml.XmlReader)
Reads XML data into the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] using the specified [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]].

Parameters: 

* [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] reader  - The [[System.Xml.XmlReader|http://msdn.microsoft.com/en-us/library/b8a5e1s5]] from which to read.






---


###ReadXml(System.String,Izenda.AdHoc.ReportListAuxData)


Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml 
* [[Izenda.AdHoc.ReportListAuxData|/API/Izenda/AdHoc/Izenda-AdHoc-ReportListAuxData]] auxData 






---


###ReadXml(System.String)
Reads XML data into the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] from the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] xml  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] from which to read.






---


###RemoveVolatileOption(System.String)
Removes the dynamic property with the specified key from the collection on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key to locate in the collection.






---


###RenderHtml()
 Generates the body of the HTML report using the loaded data in the report. 





Returns:

A HTML [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the markup for the report including style information.


---


###SetAllFilterParameters(System.Boolean)
Iterates through every filter on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] and sets the value determining whether they will be displayed on the Report Viewer to the specified value.

Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] b  - Whether each [[Izenda.AdHoc.Filter|/API/Izenda/AdHoc/Izenda-AdHoc-Filter]] in the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] will be displayed on the Report Viewer.






---


###SetVolatileOption(System.String,System.Object)
Sets the [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] representing a dynamic property in the collection of properties associated with the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] key used to identify the dynamic property.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] representation of the dynamic property to set on the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###WriteRdl(System.Xml.XmlWriter)
Writes the generated RDL output for the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to the input [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]].

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] to write the RDL output to.






---


###WriteRdl()







---


###WriteRdlOld(System.Xml.XmlWriter)


Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer 






---


###WriteXml()
Writes the current data of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to the specified [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] and returns it.





Returns:

The XML formatted [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] for the report set.


---


###WriteXml(System.Xml.XmlWriter)
Writes the current data of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to the specified XmlWriter.

Parameters: 

* [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] writer  - The [[System.Xml.XmlWriter|http://msdn.microsoft.com/en-us/library/5y8188ze]] with which to write.






---


###WriteXmlWithoutAnyChanges(System.Boolean,System.Boolean)
Forces the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to be written to the output [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]].

Parameters: 

* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] updateDateTime  - Determines whether the generated XML will use the current time as the last modified date.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] saveHiddenFilters  - Determines whether the generated XML will include hidden filters in addition to regular filters.





Returns:

The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the generated [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] XML.


---


