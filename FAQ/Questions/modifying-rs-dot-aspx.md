#Modifying rs.aspx

[[_TOC_]]

##About

The rs.aspx page is a placeholder page that interfaces with the response server, allowing data to be transferred from the server to the client and granting access to resources embedded within the Izenda dll. 

##Custom redirects

You can create a subclass of the ``ResponseServer`` class and override the ``PreOnInit()`` method. Then you can, for instance, check if the querystring is blank and redirect if it is. Then all you must do is change the ``inherits=`` line in the page directive from the default ResponseServer to your custom ResponseServer.
```
<%@ Page language="c#" AutoEventWireup="false" Inherits="Izenda.AdHoc.ResponseServer, Izenda.AdHoc"%>
```

**Caveat:** Overriding the response server can lead to abnormal behaviors in the reporting service.