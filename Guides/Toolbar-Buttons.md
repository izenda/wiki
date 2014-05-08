[[_TOC_]]

##Report Viewer 

All buttons in the Report Viewer are implemented in pure HTML. They all can be manipulated from Resources/html/ReportViewer-Body.ascx. To completely disable any button, simply remove it from the ascx file. If you wish to conditionally suppress a button, you can write conditional logic in your ascx to hide it based on your own custom logic.

###Report List Button 

![Report List Icon](http://wiki.izenda.us/Guides/Toolbar-Buttons/report-list.png)

The report list button is used to jump right into the report list. This is the code within the ReportViewer-Body.ascx that renders this button:
```html
<a class="btn" id="rlhref" href="ReportList.aspx" lang-title="js_Reportlist" title="Report list">
  <img class="icon" src="rs.aspx?image=ModernImages.report-list.png" lang-alt="js_Reportlist" alt="Report list" />
  <span class="hide" lang-text="js_Reportlist">Report list</span>
</a>
```

###Save Options Button

