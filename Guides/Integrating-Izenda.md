#Integrating Izenda into a Web Application

[[_TOC_]]

##About

This tutorial will demonstrate how to integrate Izenda into an existing web application. There are some additional steps that are not required when integrating into a web site or when using Izenda stand-alone.

##Setting up

When setting up Izenda with your existing web application, you should first decide where the code files will live. Generally, this integration option involves creating a sub-directory within the hosting web application and copying the entire structure of the Izenda web site into that directory. If you use a global.asax in your web application, you can use your existing global.asax instead of the one provided by Izenda. You will add the reference to Izenda.AdHoc.dll into your application's references as normal.

##Global.asax

