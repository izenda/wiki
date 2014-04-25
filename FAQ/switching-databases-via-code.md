#Switching databases via code

##Database Level Access

You can set the database access level on a per-user basis using different connection strings by simply adding logic that changes the connection string based on logic you provide. For instance, take the code sample below:

```sql
public static void InitializeReporting() {
    AdHocSettings.CurrentUserName = GetUserName();
    AdHocSettings.CurrentUserTenantID = GetUserTenantID();
    AdHocSettings.CurrentUserIsAdmin = IsAdmin(AdHocSettings.CurrentUserName);
    if(AdHocSettings.CurrentUserIsAdmin) {
        AdHocSettings.SqlServerConnectionString = "server=(local);database=Administration;Trusted_Connection=True";
    }
    else {
        AdHocSettings.SqlServerConnectionString = "server=(local);database=Northwind;Trusted_Connection=True";
    }
}
```

This is a simple method that will connect the user to the database called "Administration" if that user is an admin. You can, however, also switch databases on the fly during runtime. 

##Using the Query String

To dynamically change your connection string via a query string parameter, you can add code like this to the Report Designer, Report List, and Report Viewer. If a "db" parameter is found, it will change the connection string.

```csharp
protected override void OnInit(EventArgs e)
{
	string db = Request.QueryString["db"];
	if (db != null) 
		Izenda.AdHoc.AdHocSettings.SqlServerConnectionString = "server=(local);Trusted_Connection=True;database=" + db;
	
	base.OnInit(e);
}
```

##Custom Button

This sample page can be used to create a drop down & button to dynamically change the database connection string during runtime. Simply add this new page to the folder where your reporting website exists. When the database from the dropdown is selected and the button is clicked, the connection string associated to that database is selected. The application will now use the updated data source information.

```csharp
<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        NameValueCollection Connections = new NameValueCollection();
        Connections["Northwind"] = "server=(local);database=Northwind;Trusted_Connection=True"; 
        Connections["Administration"] = "server=(local);database=Administration;Trusted_Connection=True";

        foreach (string key in Connections.AllKeys)
        {
            ddlConnections.Items.Add(new ListItem(key, Connections[key]));
        }   
    }

    protected void btnChange_Click(object sender, EventArgs e)
    {
        Izenda.AdHoc.AdHocSettings.SqlServerConnectionString = ddlConnections.SelectedValue;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <asp:dropdownlist ID="ddlConnections" runat="server"></asp:dropdownlist><br /><br />
    <asp:Button ID="btnChange" runat="server" Text="Select DB" OnClick="btnChange_Click" />
    </div>
    </form>
    
</body>
</html>
```

You can now choose either the Northwind or Adminstration database connections to pull data sources from.