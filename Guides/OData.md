[[_TOC_]]

## OData Resources
* [Open Data Protocol Introduction](http://msopentech.com/odataorg/introduction/)
* [Wikipedia - Open Data Protocol](http://en.wikipedia.org/wiki/Open_Data_Protocol)
* [MSDN Open Data Article](http://msdn.microsoft.com/en-us/data/hh237663.aspx)

## OData Provider
[The OData Provider](http://archives.izenda.us/ri/odata/odata-provider.zip) is required to fully utilize Izenda's capabilities over OData out of the box.  It exposes your database(s) over OData.

Make the following changes to **WebService.aspx.cs**

* Replace INSERT_LICENSE_KEY_HERE with your license key
* Replace all instances of INSERT_CONNECTION_STRING_HERE with the connection string to your Database

## webforms-cs-odata

[webforms-cs-odata](http://archives.izenda.us/ri/odata/odata-provider.zip) is a reference implementation of Izenda configured to use Izenda's OData provider.

Make the following changes to **Global.asax**

* Replace INSERT_ODATA_URL_HERE with the URL of the OData provider.
  * The URL will be of the form: http://\<your-server\>/odata-provider/WebService.aspx
* Replace INSERT_LICENSE_KEY_HERE with your license key

##Using odata with the Izenda FUSION driver

To find out more about how to use the oData provider with Izenda FUSION, you can read [[this article|http://wiki.izenda.us/Guides/Izenda-AdHoc-Driver#Izenda-Fusion-Driver]].