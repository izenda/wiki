#How is "Use Previous OR" used in Filters?

The filter operator "Use Previous OR" will use the previous field's filter as its own filter. Using this technique, you can require two or more fields to be filtered with only one filter. This is helpful when your database uses composite keys or when you just want to show results filtered by field A OR field B but with only exposing one filter to the users viewing the reports.

##Example

Here we are using a filter on RequiredDate and specifying that it should fall between 2/27/2012 and 5/13/2012. We then specify a filter on ShippedDate and use the operator "Use Previous OR" to force an OR condition on the two filters using the same values for each.

![](/FAQ/Questions/How-is-Use-Previous-OR-used-in-Filters/use_previous_or.png)

##Results

The data returned would show all data with a RequiredDate between the two values OR with a ShippedDate that falls between those same values. The results can be seen below. Notice the values outlined in red. These values do not fall within the date ranges specified, but the other value on the same row does fall within the range. Therefore, we are using an OR operation rather than an AND which would be the case if we defined both filters with their own Between operator.

![](/FAQ/Questions/How-is-Use-Previous-OR-used-in-Filters/use_previous_or_2.png)