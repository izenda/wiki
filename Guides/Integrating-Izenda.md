#Integrating Izenda into a Web Application

[[_TOC_]]

##About

This tutorial will demonstrate how to integrate Izenda into an existing web application. There are some additional steps that are not required when integrating into a web site or when using Izenda stand-alone.

##Setting up

When setting up Izenda with your existing web application, you should first decide where the code files will live. Generally, this integration option involves creating a sub-directory within the hosting web application and copying the entire structure of the Izenda web site into that directory. If you use a global.asax in your web application, you can use your existing global.asax instead of the one provided by Izenda. You will add the reference to Izenda.AdHoc.dll into your application's references as normal.

##Global.asax

If you have your own global.asax, you can put your CustomAdHocConfig class inside that file and any settings you need set should be set in there. You can then remove the global.asax in your reporting directory as that will not be required anymore. If you do not have a global.asax and do not plan on using the Izenda global.asax, then you can create the CustomAdHocConfig class in another portion of your application. What matters in the end is that the InitializeReporting method is called before or when your users reach the reporting section of your application.

##Default.master

Izenda uses a masterpage in order to display the common elements such as the logo and the blue banner that contains the options to design new reports and dashboards. If you're already using a masterpage in your project, you may need to make some decisions about how you want Izenda to display in your application. If you want your masterpage elements to be displayed on your reporting pages, you can modify your masterpage to include the placeholders for the Izenda reporting pages. You can see more about how to customize individual pages by visiting the links below.

* [[Report List|http://wiki.izenda.us/API/CodeSamples/ReportList/custom-report-list]]
* [[Report Viewer|]]
* [[Report Designer|]]
* [[Dashboard Viewer|]]
* [[Dashboard Designer|]]
* [[Instant Reports|]]
* [[Settings|http://wiki.izenda.us/API/CodeSamples/Settings/Customizing-Settings-aspx]]

##Calling InitializeReporting

If you're integrating Izenda into a web application and you get the mysterious error:

"The type or namespace name 'global_asax' does not exist in the namespace 'ASP' (are you missing an assembly reference?)"

then you will have to go back to all the reporting pages and change the line:

```csharp
ASP.global_asax.CustomAdHocConfig.InitializeReporting();
```

You will need to replace 'ASP' with the namespace of your application.