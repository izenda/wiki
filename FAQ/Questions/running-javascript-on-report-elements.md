#Running javascript on Report Elements

[[_TOC_]]

##Question

Can I run javascript when a user clicks on a report element?

##Answer

Yes, you can run javascript within any report element (like a field value) by adding the **javascript:** keyword in the URL field on the [[advanced properties|/FAQ/advanced-field-settings]] of the field you want to use the URL with. You can see the screenshot below for an example of how this is used with the column name and value being used in the javascript as well.

![]()

In the above screenshot, you see a couple of items in curly braces **{}**. These are parameters that will be passed into the javascript. They can be used as variables or literal strings.

* **{column}**: This identifier will be replaced by the description of the field that this script is being used on.
* **{0} - {n}**: These identifiers refer to the value of the column referenced by the number. In this case, we are using the value of column 1. This can be used to access any column's value in this javascript section. An error will be thrown if there are less columns in the report than the number referenced in the curly braces. (e.g. using {4} when there are three columns in the report) Zero is special and will refer to the current column's value instead of a specific column number.