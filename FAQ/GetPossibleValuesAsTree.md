#GetPossibleValuesAsTree

[[_TOC_]]

##About

The GetPossibleValuesAsTree method is an overridable method in the [[AdHocConfig|/API/AdHocConfig]] class that can change the behavior of the Equals (Tree) filter operator. This option is normally hidden from appearing on the list until it is overridden in your [[CustomAdHocConfig|/FAQ/CustomAdHocConfig]]. The [[Equals (Tree)|http://wiki.izenda.us/Guides/ReportDesign/5.0-Filters-tab#5.3-Operator-Categories]] operator will allow you to select elements based on a hierarchy of values starting with "All", which is the root option. Values can be expanded out from the root option and any number may be selected. 

##C♯ Method

In the following example, we will be using the Northwind example database to construct the Equals (Tree) list for the columns ShipCity and ProductName. You may use this snippet to construct an Equals (Tree) list that works for your particular organization.

```csharp
public override System.Collections.Generic.IList<ValueTreeNode> GetPossibleValuesAsTree(string fullColumnName,
                                                                                        int maxRowCount, ReportSet rs) {
      if (string.IsNullOrEmpty(fullColumnName) || fullColumnName == "...")
        return new System.Collections.Generic.List<ValueTreeNode>();

      if (fullColumnName == "[dbo].[Orders].[ShipCity]" || fullColumnName == "[dbo].[Invoices].[ShipCity]") {
        System.Collections.Generic.IList<ValueTreeNode> result = new System.Collections.Generic.List<ValueTreeNode>();
        ValueTreeNode all = new ValueTreeNode("All");
        ValueTreeNode none = new ValueTreeNode("(none)");
        result.Add(all);
        result.Add(none);
        all.Nodes = new System.Collections.Generic.List<ValueTreeNode>();

        string tableName = "[dbo].[Orders]";
        if (fullColumnName == "[dbo].[Invoices].[ShipCity]")
          tableName = "[dbo].[Invoices]";
        System.Data.DataSet ds =
        AdHocContext.Driver.ExecuteDataSet(
        "SELECT DISTINCT [ShipCountry], [ShipRegion], [ShipCity] from " + tableName +
        " order by [ShipCountry], [ShipRegion], [ShipCity]", false);
        System.Data.DataTable table = ds.Tables[0];

        ValueTreeNode shipCountry = null;
        ValueTreeNode shipRegion = null;
        foreach (System.Data.DataRow row in table.Rows) {
          string country = row[0].ToString();
          if (shipCountry == null || shipCountry.Text != country) {
            shipCountry = new ValueTreeNode(country);
            all.Nodes.Add(shipCountry);
            shipCountry.Nodes = new System.Collections.Generic.List<ValueTreeNode>();
            shipRegion = null;
          }

          string region = row[1].ToString();
          if (string.IsNullOrEmpty(region)) {
            shipRegion = shipCountry;
          }
          else {
            if (shipRegion == null || shipRegion.Text != region) {
              shipRegion = new ValueTreeNode(region);
              shipCountry.Nodes.Add(shipRegion);
              shipRegion.Nodes = new System.Collections.Generic.List<ValueTreeNode>();
            }
          }
          shipRegion.Nodes.Add(new ValueTreeNode(row[2].ToString()));
        }
        return result;
      }
      else if (fullColumnName == "[dbo].[Products].[ProductName]") {
        System.Collections.Generic.IList<ValueTreeNode> result = new System.Collections.Generic.List<ValueTreeNode>();
        ValueTreeNode all = new ValueTreeNode("All");
        ValueTreeNode none = new ValueTreeNode("(none)");
        result.Add(all);
        result.Add(none);
        all.Nodes = new System.Collections.Generic.List<ValueTreeNode>();

        System.Data.DataSet ds =
        AdHocContext.Driver.ExecuteDataSet(
        "SELECT DISTINCT [CategoryName], [ProductName] from [dbo].[Categories] left join [dbo].[Products] on [dbo].[Products].[CategoryID] = [dbo].[Categories].[CategoryID] order by [CategoryName], [ProductName]",
        false);
        System.Data.DataTable table = ds.Tables[0];

        ValueTreeNode categoryNode = null;

        foreach (System.Data.DataRow row in table.Rows) {
          string category = row[0].ToString();
          if (categoryNode == null || categoryNode.Text != category) {
            categoryNode = new ValueTreeNode(category);
            all.Nodes.Add(categoryNode);
            categoryNode.Nodes = new System.Collections.Generic.List<ValueTreeNode>();
          }
          categoryNode.Nodes.Add(new ValueTreeNode(row[1].ToString()));

        }
        return result;
      }
      return base.GetPossibleValuesAsTree(fullColumnName, maxRowCount, rs);
    }
```