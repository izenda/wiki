[[_TOC_]]

##Question

What is a virtual data source? How do I create one, and what is it used for?

##Answer

A virtual data source is an Izenda report which can be used as a data source. You can think of it as creating a simulated view, in Izenda. It can be used for multi-level calculated fields

Virtual Data Sources can be used with direct database connections and with direct fusion connections against datasources (MsSql, Oracle, PostgreSQL), but will not work with MySQL due to lack of support of WITH. This feature is NOT compatible with OData datasources. If your environment is using VisibleDataSources to define or trim datasources, you might also experience difficulty getting virtual data sources to appear in the data source menu. Virtual data sources do not automatically update, they are cached based on the behavior of the underlying report - to update a VDS, you must update the report which is used to construct it. When VDS is enabled, data sources will appear as links on the data source menu. Each link shows a popup that displays the name of every report which is built using that data source. 

###Step 1: Enable Virtualdatasource

To use virtual data sources, you will have to change a setting in the global.asax. Set AdHocSettings.AllowVirtualDataSources = true;  

####Code Sample

```csharp
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
    //Creates a connection to Microsoft SQL Server
    AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
    Izenda.AdHoc.AdHocSettings.AdHocConfig = new CustomAdHocConfig();
    HttpContext.Current.Session["ReportingInitialized"] = true;
    AdHocSettings.AllowVirtualDataSources = true;  //The relevant setting
  }
```

###Step 2: Create Report

A virtual data source is simply a typical Izenda report, except the output is used as a table for one or more other reports. Once the virtualdatasources setting is toggled to true, any report you already have or create has the potential to be used as a virtual data source.


###Step 3: Enable report as VDS
On the Misc Tab, above the drilldown key dropdown there is a checkbox labeled "Expose as Datasource". Checking this box then saving the report will cause the report to appear in the data source menu.
![Enable VirtualDataSource](http://wiki.izenda.us/Virtualdatasource/AllowVirtualDatasources.png)
  
###Step 4: Use VDS in new report

When you create a new report, the data sources menu should include the full report name of the report which you just saved as a VDS. You may now build a report based on the output of the VDS report.

![VirtualDataSources Screenshot](http://wiki.izenda.us/Virtualdatasource/AVDS.png)
