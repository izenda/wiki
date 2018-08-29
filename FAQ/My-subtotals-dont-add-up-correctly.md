#My subtotals don't add up correctly

##Question

I have subtotals on my report and they don't add up to reflect the correct number. Why is this?

##Answers

There are a number of possible reasons why this could be the case.

###Preview Results vs. Total Results

The Preview Results dropdown indicates how many records should be shown in the preview. This is just a sample of all the data in the report. If a report has 10,000 records, we don't always want to display all of those records in one page in the browser. The default number of Preview records to display is 100. Even if there are more than 100 records, by default the first 100 will be displayed. However, the aggregated subtotal will sum up all records, whether they are displayed or not in the viewer.

### TOP records without ordering

If TOP (limit to N records) is used (and it is used in most cases), then subtotals results can be wrong if there is no ORDER BY (sorting) applied to at least one field.