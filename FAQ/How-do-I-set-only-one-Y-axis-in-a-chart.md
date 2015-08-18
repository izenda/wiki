#How do I set only one Y axis in a chart?

[[_TOC_]]

##Purpose

By default, Izenda charts will display two or more y axes on a chart if multiple plotted items have different ranges. This is to prevent very high values from making lower values unreadably small on the chart, and allow for proportional comparison.

If you would like to override this feature and display only one chart, you can use the following code:

###C#
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