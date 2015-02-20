#Integrating an Existing Login Page

[[_TOC_]]

##Question

How Do I Integrate My Login Page?

##Answer

You can use your login page with Izenda reports simply by calling [[ASP.global_asax.CustomAdHocConfig.InitializeReporting()|http://wiki.izenda.us/FAQ/InitializeReporting]] from your login page's code-behind in the OnPreInit() method. If you want to require the user to login then you can use the [[RequireLogin|/API/CodeSamples/RequireLogin]] setting. You will also need to set the [[LoginUrl|/API/CodeSamples/LoginUrl]] setting to be able to redirect from the reporting pages. There are also [[security samples|http://wiki.izenda.us/FAQ/Questions/Applying-Security]] that we offer to help guide you through what to do after redirecting to reporting pages once your user has authenticated. Our [[downloadable demo|http://wiki.izenda.us/Guides/Developer-Links-and-Guides#Helpful-Links]] also offers an example login page that can be used as a template in integrating your login page.