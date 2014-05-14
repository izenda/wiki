#Hiding the Report List Button

[[_TOC_]]

##Question

How can I hide the report list button on the report viewer?

##Answer

Prior to version 6.7 you could modify it via the code-behind by adding this code to your ReportViewer.aspx.cs:

```csharp
HtmlOutputReportResults1.FindControl("ReportListButton").Visible = false;
```

For version 6.7 and later, you can directly hide this button in your HTML by locating the ReportViewer-Body.aspx page in the downloadable demo site and locate the following line:

```html
    <a class="btn" id="rlhref" href="ReportList.aspx" lang-title="js_Reportlist" title="Report list">
      <img class="icon" src="rs.aspx?image=ModernImages.report-list.png" lang-alt="js_Reportlist" alt="Report list" />
      <span class="hide" lang-text="js_Reportlist">Report list</span>
    </a>
```

If you set "display:none;" in the style tag of the ``<a>`` element, you can hide it for all users. You could also wrap the element in a ``<%= %>``` server tag and specify a condition for when to display this button and when not to.