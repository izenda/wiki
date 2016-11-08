#Security Design Guide

[[_TOC_]]

##Preface

Izenda's .NET API has a number of features with associated functions and variables to plug into your application's security methodology.

Izenda's security allows you to quickly and simply use case statements and your log-in credentials to implement user types and hide information per user role, group or tenant. 

With Izenda, you can: 

* Use your own authentication for Izenda
* Separate users by name, role and/or tenant. 
* Create different user types giving access to different features
* Filter data based on credentials automatically per user, group and/or tenant
* Dictate which tables, views or stored procedures the user can pull data from
* Hide reports or entire categories programatically

This guide will explain the different variables and methods to implement security and explain common scenarios using working code samples.

##[Section 1 - Commonly Used Variables](http://wiki.izenda.us/Integration/SecurityVariables)

A collection of commonly used variables.  

##[Section 2 - Authentication](http://wiki.izenda.us/Integration/Logging-In)

Best practices and tips.

##[Section 3 - Security Basics](http://wiki.izenda.us/Integration/Security-Basics)

A basic security foundation with example code

##[Section 4 - User Types](http://wiki.izenda.us/Integration/User-Types)

An intermediate code sample showing a case statement based on user role