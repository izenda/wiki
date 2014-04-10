#ProcessDataSet()

[[_TOC_]]

##Usage

The ``ProcessDataSet`` method is useful when you want to use post-processing in your application. This method should be overridden in your global.asax file. 

public class CustomAdHocConfig : DatabaseAdHocConfig
{
	public override void ProcessDataSet(DataSet ds, string reportPart)
	{
		// Put your code here
	}
}

The first parameter is the System.Data.DataSet retrieved from the database. It is called "ds" here, but it can be named anything as long as the datatype remains the same. The second parameter is the name of the report in the ReportSet. For example, if part of your report is a grid named "Detail" and part of your report is a pie chart named "Chart", you can reference the grid part of your report by checking if ReportPart = "Detail". With that part of the report captured, you can manipulate it how you want and display the results. 

In addition to manipulating the way your data looks, post-processing can assist with encryption, logging, localization, etc. The ProcessDataSet method will be called after your data has been retrieved from the database, but before it is displayed. This means you can manipulate the data however you want in order to display it as you want. For example, you can replace encrypted data values with decrypted ones. Let's explore post-processing with the ProcessDataSet method further.

###Example: Using post-processing

For example, we want to rename the "CA" region code to "California", but only in the results grid. 
Without any post-processing we have the following report: 

![Before Post-Processing](http://www.izenda.com/Site/KB/Uploads/Images/PostProcess_before.png)

Now let's add some extra code to the CustomAdHocConfig class:

```csharp
public override void ProcessDataSet(DataSet ds, string reportPart)
{
	// We want to alter only "Detail" part of the report set
	if (reportPart == "Detail")
	{
		if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
		{
			// Iterate through columns to find column with name "Ship Region"
			for (int index = 0; index < ds.Tables[0].Columns.Count; index++)
				if (ds.Tables[0].Columns[index].ColumnName == "Ship Region")
				{
					foreach (DataRow row in ds.Tables[0].Rows)
						if (row[index].ToString() == "CA")
							row[index] = "California";
					// There can be only one column with a specific name,
					// so we can leave the cycle as soon as we find it
					break;
				}
		}
	}
}

And after implementing post-prosessor the result will be:

![After Post-Processing](http://www.izenda.com/Site/KB/Uploads/Images/PostProcess_after.png)

As you can see, "CA" was replaced by "California" in the grid but the chart still displays "CA". 
Using this approach, you can change data retrieved from the database in many ways.