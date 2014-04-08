#Layered Subtotaling

[[_TOC_]]

##Purpose

Layered subtotaling is a customized way to display subtotals that will aggregate multiple subtotals based on a set of conditions into one lump sum. This is not a grand total. Below is an example of layered subtotaling.

##Example

![Custom Layered Subtotaling](http://wiki.izenda.us/Guides/Developer-Links-and-Guides/custom_layered_subtotaling.png)

In this example, the data would be aggregated based on [ShipCountry] normally. The subtotal of all countries' freight would be totaled up. With layered subtotaling, we can get subtotals for drilldowns (such as the subtotal of [ShipRegion] ([ShipCountry] drills down to [ShipRegion])) in one report. This allows not only each [ShipCountry] field value to be totaled up, but it also allows us to see each [ShipRegion]'s total.

##Implementation

Here is a sample global.asax to implement layered subtotaling in your own application. This example behavior modifies the "Line Delimited With Labels" option in the Style tab of the Report Designer. However, you can customize which of the visual grouping styles this behavior modifies, if any, by modifying the following line:

```
isTargetVGStyle = AdHocContext.CurrentReportSet.VisualGroupStyle == VisualGroupStyle.LineDelimitedWithLabels;
```

```csharp
    /// <summary>
    /// Overrides base version to support custom totaling of various deltas in the report. 
    /// </summary>

    public override void ProcessDataSet(System.Data.DataSet ds, string reportPart) {
      if (firstPass) {
        string header, where;
        System.Collections.Generic.List<object> dataColumns = new System.Collections.Generic.List<object>();
        System.Collections.Generic.Dictionary<string, string> dataHeaders = new System.Collections.Generic.Dictionary<string, string>();

        deltas = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<object>>();
        isTargetVGStyle = AdHocContext.CurrentReportSet.VisualGroupStyle == VisualGroupStyle.LineDelimitedWithLabels;
              
        if (!String.IsNullOrEmpty(reportPart) && isTargetVGStyle) {
          foreach (System.Data.DataTable table in ds.Tables) {
            foreach (System.Data.DataRow row in table.Rows) {
              header = String.Empty;
              where = String.Empty;

              foreach (System.Data.DataColumn column in table.Columns) {
                // If the value in this column is a string, it means the column is a header, and not a data column.
                if (row[column].GetType() == typeof(string)) {
                  // If the header is empty, add the first value formatted as follows. 
                  if (header.Length == 0) {
                    header = row[column].ToString();
                    where = "[" + column + "] = '" + row[column] + "'";
                  }
                  else {
                    // Otherwise, add the item, separated by a comma.
                    header += ", " + row[column].ToString();
                    where += " AND [" + column + "] = '" + row[column] + "'";
                  }

                  // If the header is already in the list, ignore it and move on.
                  if (!dataHeaders.ContainsKey(header)) {
                    dataHeaders.Add(header, where);
                  }
                }

                // Otherwise this is a data column and add it to that data structure. 
                else if (!dataColumns.Contains(column) && row[column].GetType() != typeof(DBNull)) {
                  dataColumns.Add(column);
                }
              }
            }

            // Iterate over the gathered headers, computing the sum for each data column associated with it. 
            foreach (string head in dataHeaders.Keys) {
              System.Collections.Generic.List<object> data = new System.Collections.Generic.List<object>();
              int i = 0;
              foreach (object column in dataColumns) {
                data.Add(table.Compute("Sum(" + column.ToString() + ")", dataHeaders[head]));
              }

              if (data.Count > 0) {
                // add the header and all the sums for the data columns to the deltas structure. 
                deltas.Add(head, data);
              }
            }
          }
        }
      }

      // If subtotaling is enabled, toggle first pass so the subtotal loop does wipe out custom totals. 
      if (hasSubtotals) {
        firstPass = !firstPass;
      }
    }

    public override void PreExecuteReportSet(ReportSet reportSet) {
      //Inspect the actual report object to determing if subtotaling is used.
      hasSubtotals = reportSet.Detail.AddGrandTotals;
      base.PreExecuteReportSet(reportSet);
    }

    /// <summary>
    /// Override this to implement your own custom report rendering. This requires the 
    /// html agility pack NuGet package to work. 
    /// </summary>

    public override string PerformCustomRendering(string initialHtml) {
      if (isTargetVGStyle) {
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(initialHtml);

        // This uses an Xpath declaration to get all rows that are of class Visual group. This is done to match
        // the visual grouping to the deltas retreived from ProcessDataSet.
        HtmlNodeCollection highestLevelDeltas = doc.DocumentNode.SelectNodes("//tr[@class='VisualGroup']");

        if (highestLevelDeltas == null) {
          return initialHtml;
        }

        //The report table is passed to several functions as a reference to the current report. 
        HtmlNode reportTable = doc.DocumentNode.SelectSingleNode("//table[@class='ReportTable']");

        // Splits the string into an array for looping and comparison.
        string[] lastDelta = SanitizeDelta(highestLevelDeltas.FindFirst("tr").FirstChild.InnerHtml.Split(new string[] { "<br>" }, StringSplitOptions.RemoveEmptyEntries));

        // Loops through all the deltas extracted from the report, node by node.
        foreach (HtmlNode delta in highestLevelDeltas) {
          // Splits the string into an array for looping and comparison.
          string[] currentDelta = SanitizeDelta(delta.FirstChild.InnerHtml.Split(new string[] { "<br>" }, StringSplitOptions.RemoveEmptyEntries));

          string deltaString = string.Empty;

          // Loops through, comparing the arrays index by index. Ignores the last index since this
          // delta is handled by the standard subtotaling.         
          for (int i = 0; i < currentDelta.Length - 1; i++) {
            // Adds the current index from the array to a string for later use. 
            deltaString += lastDelta[i];

            if (lastDelta[i] != currentDelta[i]) {
              // This check is needed to handle 1st level delta changes. In these cases, there can be
              // more than just one delta to output, and this method will print them all. 
              if (i == 0) {
                PrintFinalDeltas(reportTable, delta, lastDelta);
              }
              // Otherwise, add the delta to report and remove it from the list of deltas. 
              else {
                InjectHtml(reportTable, delta, deltaString);
                deltas.Remove(deltaString);
              }
              break;
            }
            // If the values at the index are the same, add a , and move to the next index. 
            else {
              deltaString += ", ";
            }
          }

          lastDelta = currentDelta;

          // This sanitizes the string in the case of a DBNull value. 
          string deltaHead = string.Join(",", currentDelta).Replace(", ,", ", ");


          // Remove the delta from the list. 
          if (deltas.ContainsKey(deltaHead)) {
            deltas.Remove(deltaHead);
          }
        }

        // This final loop writes out the remaining deltas
        PrintFinalDeltas(reportTable, reportTable.LastChild, lastDelta);

        return doc.DocumentNode.OuterHtml;
      }
      return initialHtml;
    }

    /// <summary>
    /// PrintFinalDeltas is called to in the case of level 1 delta changes. It makes sure all deltas get printed out,
    /// not just the level 1.
    /// </summary>
    private static void PrintFinalDeltas(HtmlNode reportTable, HtmlNode previousNode, string[] lastDelta) {
      // delta takes the lastDelta array and converts it back into a string.
      string delta = string.Join(", ", lastDelta);

      // This loop keeps running until all of the pertinent information has been pulled from the string. 
      while (delta.LastIndexOf(',') > 0) {
        //Since standard subtotals print off the low level delta, this puuls that one out and discards it.
        delta = delta.Substring(0, delta.LastIndexOf(','));

        // If the string is a valid delta, print it out and remove it from the dictionary.
        if (deltas.ContainsKey(delta)) {
          InjectHtml(reportTable, previousNode, delta);
          deltas.Remove(delta);
        }
      }
    }

    /// <summary>
    /// InjectHtml actually alters the html string, injecting the deltas into it. 
    /// </summary>

    private static void InjectHtml(HtmlNode reportTable, HtmlNode currentNode, string deltaString) {
      // Build up the table row to inject. 
      HtmlNode deltaRow = HtmlNode.CreateNode("<tr class=ReportFooter></tr>");
      deltaRow.AppendChild(HtmlNode.CreateNode("<td>" + deltaString + "</td>"));

      // This will loop through the various delta columns for a particular row, adding each as a td to the row.
      if (deltas.ContainsKey(deltaString)) {
        foreach (object column in deltas[deltaString]) {
          deltaRow.AppendChild(HtmlNode.CreateNode("<td>" + column + "</td>"));
        }

        // This is where the row actually gets inserted.
        reportTable.InsertBefore(deltaRow, currentNode);
      }
    }

    private static string[] SanitizeDelta(string[] delta) {
      string[] sanitizedDelta = new string[delta.Length];
      for (int i = 0; i < delta.Length; i++) {
        if (!string.IsNullOrEmpty(delta[i].Substring(delta[i].IndexOf(':') + 1).Trim()))
          sanitizedDelta[i] = delta[i].Substring(delta[i].IndexOf(':') + 2);
      }

      return sanitizedDelta;
    }
```