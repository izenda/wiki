#How do I set only one Y axis in a chart?

[[_TOC_]]

##Purpose

By default, Izenda uses the HTML charting engine setting. A different charting engine can be set via AdHocSettings.ChartingEngine. For more information, refer to [[ChartingEngine|http://wiki.izenda.us/API/CodeSamples/ChartingEngine]].
Izenda charts will display two or more y axes on a chart if multiple plotted items have different ranges. This is to prevent very high values from making lower values unreadably small on the chart, but does not allow for proportional comparison. Customizing the code to use a common left axis makes the comparison proportional, while simply hiding the right axis will keep values absolute, but will not show the metric for the second charted item (not recommended).

---


If you would like to override this feature and display only one chart, you can use the following code:

**_Please note that hiding an axis and using a common axis are not the same thing and charts will look different_**.

### C# (HTML engine)

```csharp
//Code to hide the right Y axis:
public override void CustomizeChart(object chart, Hashtable properties)
{
	if (chart is StringBuilder)
	{
		StringBuilder sb = (StringBuilder)chart;
		String strChart = sb.ToString();

		if (!strChart.Contains("BarChart"))
			return;

		string pattern = @"var\s+(?<chartvarname>BarChart\d+Instance);";
		string chartVarName = Regex.Match(strChart, pattern).Groups["chartvarname"].Value;

		sb = sb.Replace("} catch (e) {", "var yAxisLength = " + chartVarName + ".yAxis.length; if(yAxisLength > 1){ for(var i = 1; i < yAxisLength; ++i){" + chartVarName + ".options.yAxis[i].labels.enabled = false; " + chartVarName + ".options.yAxis[i].title.text = null; " + chartVarName + ".yAxis[i].update();}}} catch (e) {");
	}

	base.CustomizeChart(chart, properties);
}


//Сode to use a common (left) Y axis:
public override void CustomizeChart(object chart, Hashtable properties)
{
	if (chart is StringBuilder)
	{
		StringBuilder sb = (StringBuilder)chart;
		String strChart = sb.ToString();
		
		if (!strChart.Contains("BarChart"))
			return;

		sb = sb.Replace("yAxis: 1", "");
	}
		
	base.CustomizeChart(chart, properties);
}

```


### C# (Dundas engine)
```csharp
//Code to hide the right Y axis:
public override void CustomizeDundasChart(object chart, Hashtable properties, Type chartType)
{
	if (chartType.FullName != "Izenda.AdHoc.DundasBarChart")
		return;
	
	Dundas.Charting.WebControl.Chart dchart = chart as Dundas.Charting.WebControl.Chart;
	if (dchart == null)
		return;

	foreach (Dundas.Charting.WebControl.ChartArea chartArea in dchart.ChartAreas)
	{
		chartArea.AxisY2.Enabled = Dundas.Charting.WebControl.AxisEnabled.False;
	}

	base.CustomizeDundasChart(chart, properties, chartType);
}


//Сode to use a common (left) Y axis:
public override void CustomizeDundasChart(object chart, Hashtable properties, Type chartType)
{
	if (chartType.FullName != "Izenda.AdHoc.DundasBarChart")
		return;
		
	Dundas.Charting.WebControl.Chart dchart = chart as Dundas.Charting.WebControl.Chart;
	if (dchart == null)
		return;

	foreach (Dundas.Charting.WebControl.Series series in dchart.Series)
	{
		if (series.YAxisType == Dundas.Charting.WebControl.AxisType.Secondary)
		{
			series.YAxisType = Dundas.Charting.WebControl.AxisType.Primary;
		}
	}

	base.CustomizeDundasChart(chart, properties, chartType);
}

```

###VB (HTML Engine)
```visualbasic
'Code to hide the right Y axis:
    Public Overrides Sub CustomizeChart(chart As Object, properties As Hashtable)
      If TypeOf chart Is StringBuilder Then
        Dim sb As StringBuilder = DirectCast(chart, StringBuilder)
        Dim strChart As [String] = sb.ToString()

        If Not strChart.Contains("BarChart") Then
          Return
        End If

        Dim pattern As String = "var\s+(?<chartvarname>BarChart\d+Instance);"
        Dim chartVarName As String = Regex.Match(strChart, pattern).Groups("chartvarname").Value

        sb = sb.Replace("} catch (e) {", (Convert.ToString((Convert.ToString((Convert.ToString((Convert.ToString("var yAxisLength = ") & chartVarName) + ".yAxis.length; if(yAxisLength > 1){ for(var i = 1; i < yAxisLength; ++i){") & chartVarName) + ".options.yAxis[i].labels.enabled = false; ") & chartVarName) + ".options.yAxis[i].title.text = null; ") & chartVarName) + ".yAxis[i].update();}}} catch (e) {")
      End If

      MyBase.CustomizeChart(chart, properties)
    End Sub



'Сode to use a common (left) Y axis:
    Public Overrides Sub CustomizeChart(chart As Object, properties As Hashtable)
      If TypeOf chart Is StringBuilder Then
        Dim sb As StringBuilder = DirectCast(chart, StringBuilder)
        Dim strChart As [String] = sb.ToString()

        If Not strChart.Contains("BarChart") Then
          Return
        End If

        sb = sb.Replace("yAxis: 1", "")
      End If

      MyBase.CustomizeChart(chart, properties)
    End Sub

```

###VB (Dundas Engine)
```visualbasic
'Сode to use a common (left) Y axis:
Public Overrides Sub CustomizeDundasChart(chart As Object, properties As Hashtable, chartType As Type)
 If chartType.FullName <> "Izenda.AdHoc.DundasBarChart" Then
  Return
 End If
 Dim dchart As Dundas.Charting.WebControl.Chart = TryCast(chart, Dundas.Charting.WebControl.Chart)
 If dchart Is Nothing Then
  Return
 End If

 If dchart.Series.Count > 1 Then
  dchart.Series(1).YAxisType = Dundas.Charting.WebControl.AxisType.Primary
 End If
End Sub



'Code to hide the right Y axis:
Public Overrides Sub CustomizeDundasChart(chart As Object, properties As Hashtable, chartType As Type)
      If chartType.FullName <> "Izenda.AdHoc.DundasBarChart" Then
        Return
      End If
	
      Dim dchart As Dundas.Charting.WebControl.Chart = TryCast(chart, Dundas.Charting.WebControl.Chart)
      If dchart Is Nothing Then
        Return
      End If
      
      For Each chartArea As Dundas.Charting.WebControl.ChartArea In dchart.ChartAreas	  
        chartArea.AxisY2.Enabled = Dundas.Charting.WebControl.AxisEnabled.False
      Next
      MyBase.CustomizeDundasChart(chart, properties, chartType)

    End Sub
```