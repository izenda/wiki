#Field Level Security Integration

##Field Level Access

Field access provides a way of limiting what a user sees in the application. This is taken care of through a simple and easy-to-work-with property in the Izenda settings framework.

[[Please see this example|Controlling access to fields]]

**Record Level Security Integration**

- Row and Cell Level Access

Izenda Reports supports the unique feature of being able to hide report data on-the-fly on a per user basis. Consider this scenario: Bill, Mary, and John are all sales people. You want to generate the same report for each of them, but with different sales territory data. With Izenda Reports, simply generate one report, give each user a link to that report, and change the filter for each user to show the specific sales data.

In this example, the ``PreExecuteReportSet`` method adds hidden filters to limit data on-the-fly.

```csharp
public override void PreExecuteReportSet(Izenda.AdHoc.ReportSet reportSet)
{
  Izenda.AdHoc.Filter f = new Izenda.AdHoc.Filter("TerritoryID");
  f.Value = GetCurrentUserTerritory();
  reportSet.Filters.AddHidden(f);
}
```