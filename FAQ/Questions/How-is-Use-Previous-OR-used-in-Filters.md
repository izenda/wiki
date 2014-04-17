#How is "Use Previous OR" used in Filters?

The filter operator "Use Previous OR" will use the previous field's filter as its own filter. Using this technique, you can require two or more fields to be filtered with only one filter. This is helpful when your database uses composite keys or when you just want to show results filtered by field A AND field B but with only exposing one filter to the users viewing the reports.

Example:

Filters Tab:

Filter Field                  Operator                        Value(s)
OrderDate          -       Between                -      01/10/2007 And 03/01/2008
ShippedDate      -       Use Previous OR 

Results:
The data returned would show all data that falls within the OrderDate range.  The ShippedDate would pull data in accordance with the date range above as well.  The end results would be Order Dates & Shipped Dates that are within the date range specified.