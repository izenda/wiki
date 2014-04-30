#Hiding Report Viewer Buttons

[[_TOC_]]

##Question

How do I hide toolbar buttons on the Report Viewer via the code-behind file?

##Answer

###Option 1 - AdHocSettings & InitializeReporting

For most toolbar buttons, we strongly recommend enabling/disabling them in the [[InitializeReporting()|/FAQ/InitializeReporting]] method of your global.asax. There are a multitude of settings specifically for enabling/disabling common buttons. 

###Option 2 - AdHocSettings & Page CodeFile

If you still believe you must do this in the code behind file for the report viewer page, you can access the [[AdHocSettings|/API/AdHocSettings]] properties from the code behind file on the page.

###Option 3 - Client side hiding

You can always use javascript code to modify any buttons that you need hidden. Javascript can access the asp.net Session collection through server tags if you need to have some way of controlling access to buttons based on information available on the server side. Here is how to access the Session using javascript:

```javascript
function GetUserName()
{
    var username = '<%= Session["UserName"] %>';
    return userName;
}
```

Then you just need to use the appropriate client side ID of the control. Here is a snippet for hiding the **Report List** button on the report viewer. This can go inside your ReportViewer-Body.ascx page. It uses a server tag to insert the evaluated statement into the page's javascript. This will return the string "True" or "False". So then we will just have to check for that string.

```javascript
<script type="text/javascript">
  var displayReportList = '<%= Convert.ToBoolean(Session["ShowReportList"]) %>';
  if (displayReportList == "False") { $('#rlhref').attr("style", "display:none;"); }
</script>
```

 You can set the session variable in your global.asax in a manner like the following:

```csharp
HttpContext.Current.Session["ShowReportList"] = false;
```

_**Note:** You will still have to check for the uppercase "False" regardless if you use vb.net or c#._

###Option 4 - Server side hiding
If you cannot find a setting for the button in question, then you can directly modify the elements in the ReportViewer-Body.ascx file to make them server side. For example, if you want to hide the "Print" options on the page, you will need to modify the following:

```html
  <div class="btn-group cool"> <!--Change this div to use runat="server" and id="ddlPrintReportSet"-->
    <button type="button" class="btn" lang-title="js_Print" title="Print" 
      onclick="responseServer.OpenUrl('rs.aspx?p=htmlreport&print=1', 'aspnetForm', '');">
      <img class="icon" src="rs.aspx?image=ModernImages.print.png" alt="Printer" />
      <span class="hide" lang-text="js_Print">Print</span>
    </button>
    <button type="button" class="btn dropdown-toggle" data-toggle="dropdown">
      <span class="caret"></span>
    </button>
    <ul class="dropdown-menu">
      <li><a href="javascript:void(0)" title="" style="min-width: 18em;"
        onclick="responseServer.OpenUrl('rs.aspx?p=htmlreport&print=1', 'aspnetForm', '');">
        <img class="icon" src="rs.aspx?image=ModernImages.print-32.png" alt="" />
        <b lang-text="js_PrintHTML">Print HTML</b><br>
        <span lang-text="js_PrintDirectlyMessage">Print directly from your browser, the fastest way for modern browsers</span>
      </a></li>
      <li><a href="javascript:void(0)" title="" onclick="responseServer.OpenUrlWithModalDialogNewCustomRsUrl('rs.aspx?output=PDF', 'aspnetForm', 'reportFrame', nrvConfig.ResponseServerUrl);">
        <img class="icon" src="rs.aspx?image=ModernImages.html-to-pdf-32.png" alt="" />
        <b lang-text="js_HTML2PDF">HTML-powered PDF</b><br>
        <span lang-text="js_HTML2PDFMessage">One-file compilation of all the report's pages</span>
        </a></li>
    </ul>
  </div>  
```

In our latest distributions, the controls are all client side. You will want to add a **runat="server"** tag to all the elements you want to access in your code behind. 

Next, you will want to add a code file to **ReportViewer-Body.ascx**. This can be done either by Visual Studio or by navigating to the folder where **ReportViewer-Body.ascx** is located and add the file **ReportViewer-Body.ascx.cs** to the directory.

Open the file and edit its contents to the following:

```csharp
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Izenda.AdHoc;

public partial class Resources_Html_ReportViewer_Body : UserControl {
  protected void Page_Load(object sender, System.EventArgs e) {
    ddlPrintReportSet.Visible = false;
  }
}
```

You will then need to change one more line in your **ReportViewer.ascx** file. It is the top server tag declaration.

```html
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReportViewer-Body.ascx.cs" Inherits="Resources_Html_ReportViewer_Body" %>
```

Now when restart your web site, the newly implemented code should take into effect and you will not see the print options dropdown menu in the report viewer. You can modify this code sample to suit your individual needs.

**Troubleshooting**

If you are having problems getting Visual Studio to recognize your wireup to the code file you created, try closing and re-opening Visual Studio. This will refresh the website wiring and force it to recognize your new code file.