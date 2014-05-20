#Injecting a "Where" Clause Into Queries

[[_TOC_]]

##Question

Can I inject SQL "Where Clause" or other expressions into a query or queries?

##Answer

Yes, you can perform this in a couple of ways.

Lets say you have the following situation:

You have 2 views: invoices and payments. But when you run a report where the invoice date is a range and you want to display any blank payments also included in this report, you will have an issue where the payment date will show blanks if the payment amount is blank. 

There are 2 basic ways to address this problem.

**Method 1:**

In your filter, select **[[Use Previous Or|http://wiki.izenda.us/FAQ/Questions/How-is-Use-Previous-OR-used-in-Filters]]** to bring in payments. 

**Method 2:**

You can also use the SQL Override property in the [[PreExecuteReportSet|]] method to inject a 'Where' clause.  Please see the hidden filter with Sql Override section in [[this article|http://wiki.izenda.us/FAQ/applying-hidden-filter-using-inner-query]].