#Security Design Guide - Section 2: Logging in

[[_TOC_]]

##Introduction

Izenda, out of the box, does not come with a log-in mechanism. However, there variables and functions set up to allow you to authenticate Izenda based on your application's log-in process. For those who are using a stand-alone version, we recommend creating a log-in page. Although Izenda comes with a sample log-in page, it should only be used as a guide and customized for your use cases.

##Tips and Best Practices  

* Common ways to deliver authentication from your application are session variables and cookies. Other methods can be used as long as they are able to populate Izenda's variables within the InitializeReporting method.  
* When integrated, common information that we recommend be passed to Izenda includes the User Name, Tenant ID, Admin or Not and Roles.
* The boolean [RequireLogin](http://wiki.izenda.us/API/CodeSamples/RequireLogin) only asserts that the [CurrentUsername](http://wiki.izenda.us/API/CodeSamples/CurrentUserName) is not null or the Izenda default. When it is one of these, the user will be redirected to whatever location is set in the [LoginUrl](http://wiki.izenda.us/API/CodeSamples/LoginUrl) variable.
* There is a sanity check within the InitializeReporting function to ensure that initializtion is run once. We recommend putting code that sets the user outside of this so that it is run every page change. This will ensure that the user hasn't changed and they will only see whatever data they are allowed to see.