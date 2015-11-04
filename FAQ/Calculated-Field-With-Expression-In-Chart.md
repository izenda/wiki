# How do I use a field calculated with an expression in a chart?

[[_TOC_]]

## Calculating Fields

There are three ways to calculate a value in Izenda - using a function, using arithmetic, or creating custom behavior using an expression. Functions are the safer route, as they automatically account for data types and other metadata. Arithmetic permits you to use more than one field, and has automatic checks to ensure correct data type matching and combination. Expressions allow for even more flexibity, but are the most complex in terms of not only being able to combine incompatible data types, but also permitting you to insert 'incorrect' output into a field, such as overwriting a datetime with numeric data. 

Because of this capability - using expressions to inject incompatible data into a field with the 'wrong' data type - it's possible to create a confusing situation with charts. Charts require an aggregated field to be used as a value, but it is possible to create an aggregate in expression without setting any of the flags which signal that a value is aggregated. Ultimately, you may end up with a mysterious error: "Column 'column_name' is invalid in the select list because it is not contained in either an aggregate function or the GROUP BY clause" even when the group aggregate is clearly applied. 

It is not possible to use a field, calculated with an expression, included in the group clause, in a chart. To correct this error, make sure that the output of the expression is itself being grouped by a function as if it were a value being derived directly from the database. This means applying the expression, aggregating the output with a function, and testing your report design thoroughly to ensure that both the grouping and the calculations are coming through correctly.