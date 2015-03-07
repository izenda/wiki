#How Do I Prevent Information Leaks?

[[_TOC_]]

##Description

Revealing system data or debugging information helps an adversary learn about the system and form a plan of attack. An information leak occurs when system data or debugging information leaves the program through an output stream or logging function. 

More information regarding information leakage can be found at:  https://www.owasp.org/index.php/Information_Leakage 

Adding the below code to the rs.aspx page will help you control what a user is able to see. The “Prohibited” quotes is where you put the literal information displayed to the end user. 

<script runat="server">
private bool SystemInfoPresents(ControlCollection controls)
  {
    foreach (Control c in controls)
      if (c.GetType().FullName == "AdHoc.Controls.SystemInfoControl")
        return true;
    foreach (Control c in controls)
      if (SystemInfoPresents(c.Controls))
        return true;
    return false;
  }
 
  protected override void OnLoad(EventArgs e)
  {
    base.OnLoad(e);
    if (SystemInfoPresents(Controls)) {
        //What you place here changes the response on the rs.aspx page in the browser
        Controls.Clear();
        Controls.Add(new LiteralControl("Prohibited"));
    }
  }
  </script>