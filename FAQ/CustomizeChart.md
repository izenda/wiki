#CustomizeChart()

[[_TOC_]]

##About

The CustomizeChart method is used to modify chart objects on a per-report basis. Different [[charting engines|/API/CodeSamples/ChartingEngine]] require different checks and some are easier to modify than others due to the way the charting engines structure their data. Here is an example method using the Dundas charting engine.

```csharp
public override void CustomizeChart(object obj)
{
    Dundas.Charting.WebControl.Chart chart = obj as Dundas.Charting.WebControl.Chart;
    chart.Width=700;
    foreach (Dundas.Charting.WebControl.Series series in chart.Series)
    {
        series.BackGradientType = Dundas.Charting.WebControl.GradientType.None;
    }
}//end method
```