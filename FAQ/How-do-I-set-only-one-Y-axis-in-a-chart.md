#How do I set only one Y axis in a chart?

[[_TOC_]]

##Purpose

By default, Izenda uses HTML charting engine. Charting engine can be set via AdHocSettings.ChartingEngine. For more information, refer to [[ChartingEngine|http://wiki.izenda.us/API/CodeSamples/ChartingEngine]].

Izenda charts will display two or more y axes on a chart if multiple plotted items have different ranges. This is to prevent very high values from making lower values unreadably small on the chart, and allow for proportional comparison.

If you would like to override this feature and display only one chart, you can use the following code:

### C# (Dundas engine)
```csharp
public override void CustomizeDundasChart(object chart, Hashtable properties, Type chartType)
{
    if (chartType.FullName != "Izenda.AdHoc.DundasBarChart")
        return;
    Dundas.Charting.WebControl.Chart dchart = chart as Dundas.Charting.WebControl.Chart;
    if (dchart == null)
        return;

    if (dchart.Series.Count > 1)
        dchart.Series[1].YAxisType = Dundas.Charting.WebControl.AxisType.Primary;
}
```
### C# (HTML engine)
Code to hide the right Y axis:
```csharp
/* HTML charts */
public override void CustomizeChart(object chart, Hashtable properties)
{
	if (chart is StringBuilder)
	{
		StringBuilder sb = (StringBuilder)chart;
		String strChart = sb.ToString();

		if (!strChart.Contains("BarChart"))
			return;

		string pattern = @"var\s+(?BarChart\d+Instance);";
		string chartVarName = Regex.Match(strChart, pattern).Groups["chartvarname"].Value;

		sb = sb.Replace("} catch (e) {", "var yAxisLength = " + chartVarName + ".yAxis.length; if(yAxisLength > 1){ for(var i = 1; i < yAxisLength; ++i){" + chartVarName + ".options.yAxis[i].labels.enabled = false; " + chartVarName + ".options.yAxis[i].title.text = null; " + chartVarName + ".yAxis[i].update();}}} catch (e) {");
	}

	base.CustomizeChart(chart, properties);
}
```
Сode to use a common left Y axis:
```csharp
/* HTML charts */
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


###VB
```visualbasic
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
```