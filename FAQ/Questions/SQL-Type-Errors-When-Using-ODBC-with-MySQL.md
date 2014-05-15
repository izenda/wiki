#SQL Type Errors When using ODBC with MySQL

[[_TOC_]]

##Questions

I'm getting SQL type errors when connecting to a MySQL database with an ODBC connection. Will this be corrected?

##Answer

There is a [known bug in MySQL Connector/ODBC 3.51](http://bugs.mysql.com/bug.php?id=16235) that results in types not being formatted and converted correctly.  Please be sure you are using the latest version of [MySQL Connector/ODBC](http://dev.mysql.com/downloads/connector/odbc/)