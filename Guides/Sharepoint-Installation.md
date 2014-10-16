#Installing Izenda on SharePoint

[[_TOC_]]

##About

This guide is to give an overview of how to integrate Izenda into a SharePoint server as a Provider Hosted App. Provider Hosted Apps in SharePoint allow a seamless experience between SharePoint and an external web application. To facilitate your integration, we have a re-distributable Provider Hosted App available upon request. And although there are many resources about how to create a provider hosted app in visual studio, we have created a basic template to go by that incorporates the basic Izenda structure. The main difference between the provider hosted app and our standard webforms implementation is that instead of having a global.asax, there is an "AdHoc.cs" file in a folder called "Izenda" that holds the same information you will find in the global.asax. We will discuss this and other differences throughout the article.

##The AdHoc.cs file

As stated before, this file lives in the Izenda directory under the main web project. You will modify this file just like you would the global.asax. 

##Creating

The project has already been created for the Proivder Hosted App, but there is also information related to certificates and trust in the article below.

* [[Creating provider hosted apps with high trust|http://msdn.microsoft.com/en-us/library/office/jj945118(v=office.15).aspx]]

##Publishing

When you are ready to publish your Provider Hosted App to IIS, Microsoft has provided a useful set of guides for this process. It is recommended that you follow them. 

* [[Packaging and publishing apps with high trust|http://msdn.microsoft.com/en-us/library/office/jj860570(v=office.15).aspx]]

The AppManifest.xml will be automatically updated when you publish after going through the wizard. Just plug in your information for your Provider Hosted App and hit "publish". In the Web portion of the application, you should manually update the web.config with your appropriate values.

##Claims-based systems

SharePoint integrates well with claims-based security systems to utilize technologies such as single sign-on and certificates. In order to configure the provider hosted app to use claims-based security, additional steps are required. For this purpose, we have included the ClaimsTokenHelper.cs class. This class is not normally included when the provider hosted app is created, unlike the standard TokenHelper class. You can find more resources on how to leverage ClaimsTokenHelper to contact your SharePoint server using SAML and ADFS claims. Aside from the ClaimsTokenHelper, some additional libraries are also included. These are the SharePoint Client libraries and the Microsoft IdentityModel libraries. In order to leverage these components for your provider hosted app, your targetFramework should be at least 4.5. 

##Limitations

Provider hosted apps were introduced in Visual Studio 2013 and cannot be loaded in any visual studio version below that. Additionally, lite versions of Visual Studio like Visual Studio Express also will not be able to load the Provider Hosted App solution. 