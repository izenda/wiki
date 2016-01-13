#How to preset values in filter

[[_TOC_]]

##Question

How can I preset date values in time period filter?

##Answer

You can use hidden filter to make reports pre-filtered whenever they are opened so that viewers only see the filtered results. However, hidden filter is not available when the filter operator is something else other than 'Equals'. Still, you can preset values in filter using PreExecuteReportSet method as below


###Example: Presetting a time period (From a year ago to Today)

##Global.asax (C♯)
```csharp
    public override void PreExecuteReportSet(ReportSet reportSet) 
    {
      base.PreExecuteReportSet(reportSet);

  //    if (reportSet.ReportName != "MyReport" || reportSet.ReportName != "MyReport2")  // You can choose to which report this overriding to be applied
//        return;              

      foreach (Izenda.AdHoc.Filter filter in reportSet.Filters) {

        if (filter.Operator == OperatorTypes.BetweenTwoDates) {    // can choose filter as well based on its operator
          
          if (filter.dbColumn.Name.Equals("OrderDate")) {   // To be applied to "OrderDate" filter            
            
         DateTime baseDate = DateTime.Today;

            filter.Values.SetValue(baseDate.AddYears(-1), 0);    //the'Between' operator takes two parameters. the first one's indexed as 0. '-1' for a year ago

            filter.Values.SetValue(DateTime.Today, 1);   

//  reportSet.Filters[count].Values.SetValue("01/01/2010", 1);
//  reportSet.Filters[count].Values.SetValue("01/01/2016", 1);  // the date value could be a specific date 

          }
        }
      }
    }

```


##Global.asax (VB.Net)
```visualbasic
Public Overrides Sub PreExecuteReportSet(reportSet As ReportSet)
	MyBase.PreExecuteReportSet(reportSet)

	'    if (reportSet.ReportName != "MyReport" || reportSet.ReportName != "MyReport2")  // You can choose to which report this overriding to be applied
	'        return;              

	For Each filter As Izenda.AdHoc.Filter In reportSet.Filters

		If filter.[Operator] = OperatorTypes.BetweenTwoDates Then
			' can choose filter as well based on its operator
			If filter.dbColumn.Name.Equals("OrderDate") Then
				' To be applied to "OrderDate" filter            
				Dim baseDate As DateTime = DateTime.Today

				filter.Values.SetValue(baseDate.AddYears(-1), 0)
				'the'Between' operator takes two parameters. the first one's indexed as 0. '-1' for a year ago

					'  reportSet.Filters[count].Values.SetValue("01/01/2010", 1);
					'  reportSet.Filters[count].Values.SetValue("01/01/2016", 1);  // the date value could be a specific date 

				filter.Values.SetValue(DateTime.Today, 1)
			End If
		End If
	Next
End Sub

```
##Screenshots

![](http://wiki.izenda.us//FAQ/Questions/How-To-Preset-Values-In-Filter/Time_Period.png)

