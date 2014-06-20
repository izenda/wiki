#Language

[[_TOC_]]

##About

The Language setting will change the language used within Izenda reports. This can be used to localize the reporting section of your application to your users' cultural dialect. Currently, Izenda reports only supports a limited amount of languages as each additional resource file does take development work. Support for new languages is added based on demand. Setting a language will change interface buttons, labels, and links. This will not change dynamic data such as report names, categories, or information from the database.

**Default Value:** AdHocLanguage.English

###Global.asax (C♯)

``` csharp
//main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{
  // Configure settings
  // Add custom settings after setting the license key and connection string by overriding the ConfigureSettings() method
  public static void InitializeReporting() {
    //Check to see if we've already initialized.
    if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
      return;
    AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE";
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    AdHocSettings.Language = AdHocLanguage.French; //The relevant setting
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }
}
```

##Global.asax (VB.NET)

```visualbasic
'main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
Public Class CustomAdHocConfig
    Inherits Izenda.AdHoc.DatabaseAdHocConfig

    Shared Sub InitializeReporting()
        'Check to see if we've already initialized
        If HttpContext.Current.Session Is Nothing OrElse HttpContext.Current.Session("ReportingInitialized") IsNot Nothing Then
            Return
        'Initialize System
        AdHocSettings.LicenseKey = "INSERT_LICENSE_KEY_HERE"
        AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE"
        Izenda.AdHoc.AdHocSettings.AdHocConfig = New CustomAdHocConfig()
        AdHocSettings.ExportLimit = 100000 'The relevant setting
        HttpContext.Current.Session("ReportingInitialized") = True
    End Sub
End Class
```

##Per Country By Tenant(Customer) ID

```csharp
public static void InitializeReporting()
{
      switch ( GetUserCountry()){
        case "USA":
        case "UK":
        case "Ireland":
          AdHocSettings.Language = AdHocLanguage.English;
          break;
        case "France":
          AdHocSettings.Language = AdHocLanguage.French;
          break;
        case "Spain":
        case "Mexico":
        case "Venezuela":
        case "Argentina":
        case "Brazil":
          AdHocSettings.Language = AdHocLanguage.Spanish;
          break;
        case "Germany":
        case "Austria":
        case "Poland":
        case "Switzerland":
          AdHocSettings.Language = AdHocLanguage.German;
          break;
        case "Russia":
          AdHocSettings.Language = AdHocLanguage.Russian;
          break;
        case "Japan":
          AdHocSettings.Language = AdHocLanguage.Japanese;
          break;
        case "China":
          AdHocSettings.Language = AdHocLanguage.ChinesePeoplesRepublicofChina;
          break;
        case "Taiwan":
          AdHocSettings.Language = AdHocLanguage.ChineseTaiwan;
          break;
        case "Italy":
          AdHocSettings.Language = AdHocLanguage.Italian;
          break;
        case "South Korea":
        case "North Korea":
        case "Korea":
          AdHocSettings.Language = AdHocLanguage.Korean;
          break;
        case "Belgium":
          AdHocSettings.Language = AdHocLanguage.Dutch;
          break;
        default:
          AdHocSettings.Language = AdHocLanguage.English;
          break;
      }
}

public static string GetUserCountry() {
      String sql = string.Format(@"SELECT [dbo].[Customers].[Country] FROM [dbo].[Customers] WHERE [dbo].[Customers].[CustomerID] = '{0}'", AdHocSettings.CurrentUserTenantId);
      SqlCommand cmd = new SqlCommand(sql);
      DataSet ds = new DataSet();
      using (SqlConnection connection = new SqlConnection(AdHocSettings.SqlServerConnectionString)) {
        connection.Open();
        cmd.Connection = connection;
        IDbDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(ds);
      }
      return ds.Tables[0].Rows.Count == 0 ? string.Empty : ds.Tables[0].Rows[0][0].ToString();
}
```

In the above example, CurrentUserTenantID will be set to a company ID (such as ALFKI) and the country will be obtained and the language set.

##Screenshots

####French

![](/API/CodeSamples/Language/adhoclanguage_french.png)

####Arabic

![](http://wiki.izenda.us/Localization/resources_rtl_1.png)