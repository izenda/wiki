#How do I Use Custom Date Formats?

[[_TOC_]]

In this example, we show how to set the formats when using an International Date format. This example is for the European Date format and needs to be placed in the ``InitializeReporting()`` method of your global.asax file. 

```csharp
public class CustomAdHocConfig : Izenda.AdHoc.DatabaseAdHocConfig
{
	// Configure settings

	// Add Custom Setting below license key and connection string setting
	public override void ConfigureSettings()
	{
		AdHocSettings.SqlServerConnectionString = "INSERT_CONNECTION_STRING_HERE";
		AdHocSettings.Formats.Add("EuroDate", "{0:dd/MM/yyyy}");
	}
}
```

You can use this example as a template for other date formats as well.