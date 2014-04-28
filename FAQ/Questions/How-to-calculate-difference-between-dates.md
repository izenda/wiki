#How to calculate difference between dates?

[[_TOC_]]

###Find the difference between two dates

The difference between two dates can be calculated using the simple Arithmetic feature in the Report Designer.
Select the two dates you want to use. In our sample below we use ShippedDate and OrderDate. Then select the "minus" sign ([-]) in the arithmetic column (labeled "A") for the second date. The result of this expression will be the difference between the two dates in days.

*Note: By default the result is an integer, number of days, but you can also set specified decimal places. Use DateArithmeticDecimalPlaces to do this.*

```c#
AdHocSettings.DateArithmeticDecimalPlaces = 3;
```

Please see the following simple example of date arithmetic use: 

![](http://wiki.izenda.us/FAQ/FAQ/date_difference_example.png)

Here we establish our report fields. Note how the (-) operator is selected on the last "OrderDate" field and the field preceeding it will be named "Shipping Time(Days)".

![](http://wiki.izenda.us/FAQ/FAQ/date_difference_results.png)

We can see that our data has appeared as we wanted it in our preview.

###Find the difference between two datetimes

The difference between two datetimes can be determined by implementing an [[Expression|http://wiki.izenda.us/Guides/ReportDesign/15.0-Expressions-in-Izenda]] in the Report Designer that is similar to the following:

``[RequiredDate] - [OrderDate]``

This will, however, format the date as an expression of time from the beginning of the epoch and not as an actual difference in times. (E.g. if your first date is **9/2/2010 3:13:48 AM** and your second date is **8/5/2010 11:18:46 AM**, the result will be **1/28/1900 3:55:02 PM** and not **28 Days 15 Hours 55 Minutes 2 Seconds** or something similar)

For the formatting, you will need to implement a [[Custom Formatter|http://wiki.izenda.us/FAQ/Questions/Add-Formatting-Options#Example-4---Custom-Formatters]].