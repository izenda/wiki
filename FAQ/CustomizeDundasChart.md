#CustomizeDundasChart

[[_TOC_]]

##About

This method is used to customize charts using the Dundas charting engine. In order to use this library for charts, set `AdHocSettings.ChartingEngine = ChartingEngine.DundasChart;`. By default, this setting will be set to this value, but in the standard kit distributed on our site the ChartingEngine is set to HtmlChart. 

Note: As we have switched to HtmlCharts, and with the more current D3 visualizations being the current standard chart type, the Dundas charts are no longer actively maintained.

##C# Example

```csharp
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
```

##VB.NET Example
```visualbasic
Public Overrides Sub CustomizeDundasChart(chart As Object, properties As Hashtable, chartType As Type)
    If Not chartType.FullName.Equals("Izenda.AdHoc.DundasBarChart") Then
        Return
    End If
    Dim dchart As Dundas.Charting.WebControl.Chart = DirectCast(chart, Dundas.Charting.WebControl.Chart)
    If dchart Is Nothing Then
        Return
    End If
    For Each chartArea As Dundas.Charting.WebControl.ChartArea In dchart.ChartAreas
        chartArea.AxisY2.Enabled = Dundas.Charting.WebControl.AxisEnabled.False
    Next
    MyBase.CustomizeDundasChart(chart, properties, chartType)
End Sub
```