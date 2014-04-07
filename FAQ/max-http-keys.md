#Troubleshooting Operation is Invalid

##Problem

If you are experiencing an exception with the message 'Operation is not valid due to the current state of the object' the reason is an update Microsoft made to the .NET framework. They limited the maximum number of HTTP keys to 1000 by default. You can read more about the changes [here](http://support.microsoft.com/kb/2661403).

##Solution

The resolution to this issue is to change the value of aspnet:MaxHttpCollectionKeys in web.config. We've upped the default of 1000 to 2000 already. Caution should be taken in increasing the amount of keys though, as this does expose your system to a potential DOS risk. It is recommended not to arbitrarily raise that value, but only make it as large as needed to accommodate your report data. 