#Why Don't I See the Number of Resultant Columns or Rows I Expect In My Report?

[[_TOC_]]

##Settings that affect row results:

- AdHocSettings.ChartLimit (default: **500**) limits the number of rows which can be used in charts.
- AdHocSettings.PivotFieldLimit (default: **100**) limits the number of columns in pivot.
- AdHocSettings.PreviewColumnLimit (default: **100**) limits the number of columns for report at all (has no effect for export)


##The number of rows not limited by settings, but it can depend on some things:

- Results can be limited for the **whole report** within the ReportDesigner (**Fields tab; "Records" field**).
- Results can be limited in **ReportDesigner preview** tab (by "Results" dropdown in menu)
      (``AdHocSettings.DefaultPreviewResults`` default is _100_ for 6.6 and _1000_ for lower versions)
- Results can be limited in **ReportViewer** (by "Results" dropdown in Viewer toolbar)
      (``AdHocSettings.ReportViewerDefaultPreviewResults`` default is _100_ for 6.6 and _1000_ for lower versions)

First in your search you should check the values at the "Results" dropdown in your ReportDesigner/ReportViewer.