[[_TOC_]]

#Report Viewer 

All buttons in the Report Viewer are implemented in pure HTML. They all can be manipulated from Resources/html/ReportViewer-Body.ascx. To completely disable any button, simply remove it from the ascx file. If you wish to conditionally suppress a button, you can write conditional logic in your ascx to hide it based on your own custom logic.

##Report List Button 

![Report List Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/report-list.png)

The report list button is used to jump right into the report list. This is the code within the ReportViewer-Body.ascx that renders this button:
```html
<a class="btn" id="rlhref" href="ReportList.aspx" lang-title="js_Reportlist" title="Report list">
  <img class="icon" src="rs.aspx?image=ModernImages.report-list.png" lang-alt="js_Reportlist" alt="Report list" />
  <span class="hide" lang-text="js_Reportlist">Report list</span>
</a>
```

##Save Options

![Save Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/save.png)

Clicking the downward facing triangle next to the save icon will reveal further save options; save and save as.

```html
<button type="button" class="btn" lang-title="js_Save" title="Save" id="btnSaveDirect" onclick="javascript:event.preventDefault();SaveReportSet();">
  <img class="icon" src="rs.aspx?image=ModernImages.floppy.png" lang-alt="js_Save" alt="Save" />
  <span class="hide" lang-text="js_Save">Save</span>
</button>

<button type="button" class="btn dropdown-toggle" data-toggle="dropdown">
  <span class="caret"></span>
</button>
```

###Save

![Save Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/save-32.png)
 
The save button simply saves the current report. 

```html
<li class="hide-readonly"><a href="javascript:void(0)" style="min-width: 18em;" onclick="javascript:SaveReportSet();">
  <img class="icon" src="rs.aspx?image=ModernImages.save-32.png" lang-alt="js_SaveChanges" alt="Save changes" />
  <b lang-text="js_Save">Save</b><br>
  <span lang-text="js_SaveChangesMessage">Save changes to the report for everyone it is shared with</span>
</a></li>
```

###Save As

![Save As Button](http://wiki.izenda.us/Guides/Toolbar-Buttons/save-as-32.png)

This button allows a user to save the current report with a specific name. 

```html 
<li><a href="javascript:void(0)" onclick="javascript:ShowSaveAsDialog();">
  <img class="icon" src="rs.aspx?image=ModernImages.save-as-32.png" lang-alt="js_SaveACopy" alt="Save a copy" />
  <b lang-text="js_SaveAs">Save As</b><br>
  <span lang-text="js_SaveACopyMessage">Save a copy with a new name, keeping the original intact</span>
</a></li>

```

