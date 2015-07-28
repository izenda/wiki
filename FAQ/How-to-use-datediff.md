

#About

datediff() is one of the functions in expression. This page shows how to use datediff()

##Syntax

datediff( datepart , startdate , enddate )

##Argument

###datepart
Is the part of startdate and enddate that specifies the type of boundary crossed. The following table lists all valid datepart arguments. User-defined variable equivalents are not valid.

|**datepart**|**Abbreviations**|
|:------------:|:-------------:|
|year|yy, yyyy|
|quarter|qq, q|
|month|mm, m|
|dayofyear|dy, y|
|day|dd, d|
|week|wk, ww|
|hour|hh|
|minute|mi, n|
|second|ss, s|
|millisecond|ms|
|microsecond|mcs|
|nanosecond|ns|

###startdate
Is an expression that can be resolved to a time, date, smalldatetime, datetime, datetime2, or datetimeoffset value. date can be an expression, column expression, user-defined variable or string literal. startdate is subtracted from enddate. To avoid ambiguity, use four-digit years.


###enddate
See startdate.

