[[_TOC_]]

##About

##Instructions

###Step 1 - 

The basics of integrating Izenda within a Web Forms application:

1.	Add Izenda’s bin contents to your application’s bin directory.
2.	Add Izenda’s Resources Folder to your application’s root directory.
3.	Add Izenda’s CustomAdHocConfing class and InitializeReporting() method to your Global.asax.
4.	Add Izenda’s Web.config settings to your Web.config.
5.	Add Izenda’s ASPX and ASPX.CS pages and other miscellaneous to your directory, except for the Izenda.config (set all API settings in your InitializeReporting() method), Default.aspx and Settings.aspx.
6.	Adjust or remove the Default.master to apply branding. 
a.	If you remove the Default.master, have Izenda use your own master style page, and add to your page the JavaScript and CSS resource references Izenda’s pages require. Feel free to adjust CSS/JavaScript files in the Resources folder in order to apply branding.

