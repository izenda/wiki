#How Do I change the Default Print Settings?

To change the default print settings, you will need to modify the ``PreExecuteReportSet()`` method and set the related properties. The code sample below demonstrates how to accomplish this.

```csharp
public override void PreExecuteReportSet(ReportSet reportSet)
{
    reportSet.PageWidth = 8.27f;
    reportSet.PageHeight = 11.69f;
    reportSet.OutputAreaWidth = 7.27f;
    reportSet.OutputAreaHeight = 10.69f;
    reportSet.OutputAreaLeft = 0.5f;
    reportSet.OutputAreaTop = 0.5f;
}
```

```vb.net
Public Overrides Sub PreExecuteReportSet(reportSet As ReportSet)
    reportSet.PageWidth = 8.27F
    reportSet.PageHeight = 11.69F
    reportSet.OutputAreaWidth = 7.27F
    reportSet.OutputAreaHeight = 10.69F
    reportSet.OutputAreaLeft = 0.5F
    reportSet.OutputAreaTop = 0.5F
End Sub
```