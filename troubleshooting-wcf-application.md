#Troubleshooting a WCF Application

When first setting up a server with IIS, .NET and installing Izenda, you may receive an error similar to the following:

    Server Error in '/WCFApplication' Application

    Could not load type 'System.ServiceModel.Activation.HttpModule' from assembly 'System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'.

This error can occur when IIS is installed after installing .NET Framework 4, or if the 3.0 version of the WCF Http Activation module is installed after installing IIS and .NET Framework 4.

To resolve this problem, you must use the ASP.NET IIS Registration Tool (Aspnet_regiis.exe) to register the correct version of ASP.NET. 

This can be accomplished by using the –iru parameters when running aspnet_regiis.exe from the command line as follows:

    aspnet_regiis.exe -iru

-OR- 

Repair your installation of .NET 4.5 using the Server Features GUI
