#Authenticating Via Hash

[[_TOC_]]

##Question

How Can I Authenticate Against a Hash Sent Via Query String?

##Answer

You can use the following code sample in order to create basic authentication against a hash value sent via the query string parameter "UserHash".

###C♯ Example

```csharp
void Application_PreRequestHandlerExecute(object sender, EventArgs e) {
    //check for query string values
    try {
      string username = HttpContext.Current.Session["UserName"].ToString(); //greg
      string hash = HttpContext.Current.Request.QueryString["UserHash"]; //"EE5BD620F9418FC5CDEE8BC28DD7659E";
      string redir = HttpContext.Current.Request.QueryString["Redirect"]; //null;
      if (username == null || hash == null) {
        //redirect to login
        Response.Redirect("Login.aspx");
      }
      if (CheckMd5Sum(username, hash)) {
        //set global database connection string
        SetUserSession(username, "server=(local);database=Northwind;Trusted_Connection=True", redir);
      }
      else {
        //redirect to login
        Response.Redirect("Login.aspx");
      }
    }
    catch {
      //redirect to login
      Response.Redirect("Login.aspx");
    }
  }

  void SetUserSession(string sUser, string sConnection, string sRedir) {
    //query database and set user information and populate variables
    Izenda.AdHoc.AdHocSettings.SqlServerConnectionString = sConnection;
    Izenda.AdHoc.AdHocSettings.CurrentUserIsAdmin = (bool)(HttpContext.Current.Session["IsAdmin"]); //false
    Izenda.AdHoc.AdHocSettings.CurrentUserName = sUser;

    if (sRedir != null) {
      HttpContext.Current.Response.Redirect(sRedir);
    }
  }
  
  bool CheckMd5Sum(string key, string hash) {
    string sFullKey = key + "Izend$$";
    Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

    byte[] unicodeText = new byte[sFullKey.Length * 2];
    enc.GetBytes(sFullKey.ToCharArray(), 0, sFullKey.Length, unicodeText, 0, true);

    MD5 md5 = new MD5CryptoServiceProvider();
    byte[] result = md5.ComputeHash(unicodeText);

    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < result.Length; i++) {
      sb.Append(result[i].ToString("X2")); //produces a hexadecimal equivalent of the result padded to 2 characters minimum (1 would become 01)
    }
    return (hash.CompareTo(sb.ToString()) == 0);
  }
```