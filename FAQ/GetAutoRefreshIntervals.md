#GetAutoRefreshIntervals()

[[_TOC_]]

This method can be overridden in the CustomAdHocConfig class to enable a dropdown menu in the viewer for reports and dashboards to allow an end user to set an interval for auto refreshing of the report/dashboard.  If the method is not overridden, or returns an empty Dictionary, the dropdown is not displayed in the viewer.  You can define as many intervals as you like.  The intervals are defined in the Dictionary as a <nowiki>&lt;</nowiki>string, int<nowiki>&gt;</nowiki>, meaning that you can display intervals however you choose in the string (i.e. "5 minutes", "5 mins", or "Five minutes"), and the corresponding integer is the time in seconds (i.e. 5 minutes = 300 seconds).

Below is a sample global.asax with an example of the GetAutoRefreshIntervals override method in place. The code block will appear within ``<script runat="server"> </script>`` tags within global.asax.

##Global.asax (C♯)
```csharp
//main class: inherits DatabaseAdHocConfig or FileSystemAdHocConfig
public class CustomAdHocConfig : DatabaseAdHocConfig
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
    HttpContext.Current.Session["ReportingInitialized"] = true;
  }

  //The relevant method
  public override Dictionary<string, int> GetAutoRefreshIntervals() {
    Dictionary<string, int> intervals = new Dictionary<string, int>();
    intervals.Add("Never", -1);
    intervals.Add("5 minutes", 300);
    intervals.Add("10 minutes", 600);
    intervals.Add("30 minutes", 1800);
    intervals.Add("1 hour", 3600);
    return intervals;
  }
  //End

}
```