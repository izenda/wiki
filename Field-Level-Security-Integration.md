#Field Level Security Integration

##Field Level Access

The field level property ``FieldFilterRegex`` is a regular expression property that filters based upon the string it's given. The user would not see any fields containing the words 'pass', 'admin' or 'pw'. 

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