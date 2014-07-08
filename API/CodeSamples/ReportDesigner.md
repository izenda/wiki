#Report Designer Page Code Samples

[[_TOC_]]

##About

Here we will provide helpful code samples that can be used to control the Report Designer page and its various features via the Izenda API. In our demo website, we provide a sample ReportDesigner.aspx page that will be the basis of how to structure your own web page around. The following code samples will be referring to elements found on that sample.

##Toggling toolbar buttons

Although Izenda does offer a method of toggling toolbar buttons via our AdHocSettings class, some users may find it more beneficial to refer to the toolbar menu items directly in the context of the Report Designer page. However, we recommend that this be done through the [[AdHocSettings|/API/AdHocSettings]] class. [[Here is a list of all the settings|http://wiki.izenda.us/FAQ/Hiding-Buttons-and-Tabs#Report-Designer-Buttons]]. And below is page level code that can be used to perform the same operations.

```csharp
protected void OnInit(EventArgs e)
{
    string currentReportName = Request.QueryString["rn"];
    if (currentReportName == "payroll" || !AdHocSettings.CurrentUserIsAdmin)
    {
        this.adHocReportDesigner1.Toolbar.Items.Remove("SaveButton");
        this.adHocReportDesigner1.Toolbar.Items.Remove("SaveAsButton");
    }
}
```

And here is a list of button keys for reference: 

* ReportListButton
* NewButton
* SaveButton
* SaveAsButton
* PDFButton
* HTMLREPORTButton
* SQLButton
* CSVButton
* XLS(MIME)Button
* DOCButton
* XMLButton
* RTFButton
* EMailServerButton
* EMailClientButton
* AdminButton

Alternately, this could be accomplished by calling the following from global.asax:

```csharp
    string currentReportName = Request.QueryString["rn"];
    if (currentReportName == "payroll" || !AdHocSettings.CurrentUserIsAdmin)
        AdHocSettings.ShowSaveControls = false;
```

This would hide both the **Save** and **Save As...** toolbar buttons and is more reliable, as it does not deal with specific string literals.

See [[this resource|http://wiki.izenda.us/FAQ/Hiding-Buttons-and-Tabs#Report-Designer-Buttons]] for a list of all the settings in the AdHocSettings class you can use to modify the toolbar items.

##Override Page Level CSS

Here is a code sample that shows how to override the CSS in the Report Designer page. Essentially, you insert a ``<style> </style>`` tag as shown below after the ``</FORM>`` tag in the page. You can then override the CSS elements. In this example, it also overrides the "Preview" tab CSS for the HTML preview. You can use any web browser's developer tools add-on (usually accessed by pressing F12 on the keyboard or ctrl+click if on a Mac with Safari developer tools enabled) to find what CSS classes you need to override. **Caveat:** this will only override them while in the "ReportDesigner.aspx" page.

Alternately, you can use the [[CssUrl|http://wiki.izenda.us/FAQ/Questions/Overriding-page-level-css#Report-Designer]] settings along with your own CSS files in order to achieve the same result for this page. 

```csharp
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolder" runat="Server">
  <div class="report-page">
    <form id="form1" runat="server">
      <div id="repHeader"></div>
      <cc1:adhocreportdesigner id="Adhocreportdesigner1" runat="server">
      </cc1:adhocreportdesigner>
    </form>
    /* Custom styles for report designer */
  <style type="text/css">
    body {
        font-size: 20px;
        font-family: Tahoma;
        color: red;
    }

    select {
        font-size: 18px;
        font-family: Tahoma;
        color: blue;
    }

    /* You must use expressions in IE for input elements */
    INPUT {
        color: expression(this.type== "button" ? 'red' : 'yellow' );
    }

    /* For Mozilla and the rest, IE ignores this tag */
    input[type="button"] {
        font-size: 12px;
        font-family: Tahoma;
        color: yellow;
    }

    /* Preview tab css settings for the html report preview, it will NOT show this way in report viewer */

    tr.ReportItem td {
        border-style: solid;
        border-width: 1px;
        font-size: 18pt;
        vertical-align: top;
    }

    table.ReportTable td {
        border-style: solid;
        border-width: 0px;
        font-family: tahoma;
    }

    table.ReportTable td {
        border-color: Black;
    }
    tr.ReportItem {
        color: Black;
    }
    .advancedBtnStyle {
        color: White;
    }
  </style>
  </div>
</asp:Content>
```

##Default Sharing Rights

You can specify which of the options in the default sharing rights box is the default by setting [[DefaultSharingRights|/API/CodeSamples/DefaultSharingRights]] to your desired value.