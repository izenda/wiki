#Creating a Custom Export Button

[[_TOC_]]

##Method

This code sample will allow you to place your own export buttons wherever you need them on your report viewer. This button uses our built-in PDF icon and is set to export to pdf. However, you can change but the **"src"** and **"&output=pdf"** properties to match whatever image and export type you wish to use, respectively.

```csharp
<img src="rs.aspx?image=pdf.gif" onclick="window.location='<%=string.Format("{0}?
    {1}&output=pdf",Request.ServerVariables["PATH_INFO"],Request.ServerVariables"QUERY_STRING"])%>'"
```

##C♯ Sample

This code sample will allow you to use the Izenda API to generate custom export capabilities with a standard webforms page.

```csharp
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Izenda.AdHoc;
using Izenda.AdHoc.Database;

public partial class Export : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach(string ds in AdHocContext.Driver.DatabaseSchema.Tables.AllKeys)
        {
            DataSourcesDD.Items.Add(ds);
        }
    }

    protected void DSButton_Click(object sender, EventArgs e)
    {
        foreach (Column column in AdHocContext.Driver.DatabaseSchema.Tables
                [DataSourcesDD.SelectedItem.Value].Columns.AllValues)
        {
            ListItem li = new ListItem();
            li.Text = column.Name;
            li.Value = column.SqlName;
            li.Selected = true;
            FieldCBL.Items.Add(li);
        }
    }

    protected void ExportButton_Click(object sender, EventArgs e)
    {
        ReportSet rs = new ReportSet();

        JoinedTable jt = new JoinedTable();
        jt.TableName = DataSourcesDD.SelectedItem.Value;
        rs.JoinedTables.Add(jt);

        foreach (ListItem li in FieldCBL.Items)
        {
            if (!li.Selected) continue;

            Field f = new Field(li.Value);
            rs.Detail.Fields.Add(f);
        }
        AdHocContext.CurrentReportSet = rs;
        Response.Redirect("rs.aspx?output=csv");        
    }
}
```

```html
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Default.master" CodeFile="Export.aspx.cs" Inherits="Export" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolder" runat="Server">
  <div class="page">
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DataSourcesDD" runat="server">
        </asp:DropDownList>
        <asp:Button ID="DSButton" runat="server" Text="OK" OnClick="DSButton_Click" />
        <asp:CheckBoxList ID="FieldCBL" runat="server" RepeatColumns="5">
        </asp:CheckBoxList>
    </div>
    <asp:Button ID="ExportButton" runat="server" Text="Export" OnClick="ExportButton_Click" />
    </form>
  </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TrackerPlaceHolder" runat="Server">
</asp:Content>
```