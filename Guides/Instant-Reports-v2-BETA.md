
[[_TOC_]]

#Introduction

Izenda now offers a BETA version of the new Instant Report Page in Angular.js with the platform’s latest update to 6.10.0.1. This beta release is made available to allow a broad user base to evaluate and give us feedback on the future of the Report Designer, but is not recommended for production use at this stage. This is not a fully supported feature however and any product defects will be noted, but not slated for immediately scheduled work.
 
Izenda will be continually making improvements and enhancements to the features and functionality with each maintenance release during the Beta phase. These items will be contained in our general maintenance release so our clients can follow in the progress. 
The most immediately visible change to Instant Reports is the new screen design and left side navigation bar. These have panels that will open with additional menu items and can collapse giving maximum visibility to the report being designed.
For the initial BETA version the scope of the designer is limited. There are functions that a user cannot complete in the Instant Report page that they may need to move to the full Report Designer page to complete. A list of these major features are included in this guide. 

Any report created in the new Instant Report page can also be edited in this page. If a new report is created in the new Instant Report page, the application will first open it for editing in the Instant Report page. At any time if the report is edited in the Report Designer it will only open in the full Report Designer for editing. 

#Installation
The new page is include in all 6.10.0.1 Reference Implementations for download. The new page can be configured for review using the following setting in the global file:

* WebForms
AdHocSettings.InstantReport = "InstantReportNew.aspx";
	
* MVC
AdHocSettings.InstantReport = "InstantReportNew";

* VB
AdHocSettings.InstantReport = "InstantReportNew.aspx"

This will change the current Instant Report page to the BETA Instant Report Page when navigating from the New Drop Down menu.

![](/Guides/Instant-Reports-v2-BETA/IRBetaImage.PNG)

#Data
![](/Guides/Instant-Reports-v2-BETA/ir1.PNG)
![](/Guides/Instant-Reports-v2-BETA/ir2.PNG)

#Charts
![](/Guides/Instant-Reports-v2-BETA/ir3.PNG)

#Formatting
![](/Guides/Instant-Reports-v2-BETA/ir4.PNG)
![](/Guides/Instant-Reports-v2-BETA/ir5.PNG)
![](/Guides/Instant-Reports-v2-BETA/ir6.PNG)

#Scheduling
![](/Guides/Instant-Reports-v2-BETA/ir7.PNG)

#Sharing
![](/Guides/Instant-Reports-v2-BETA/ir8.PNG)

#Toolbar
![](/Guides/Instant-Reports-v2-BETA/ir9.PNG)

#Filtering
![](/Guides/Instant-Reports-v2-BETA/ir10.PNG)
![](/Guides/Instant-Reports-v2-BETA/ir11.PNG)

#Field Settings
![](/Guides/Instant-Reports-v2-BETA/ir12.PNG)
![](/Guides/Instant-Reports-v2-BETA/ir13.PNG)
![](/Guides/Instant-Reports-v2-BETA/ir14.PNG)

#Unsupported Features

At this time in the Beta Release of Instant Reports 2.0 the following Report Designing Features are unsupported. We will be building out features as we move forward to a production release.

Advanced Datasource Joining Functionality  
Pivot Reports
Only Reports created in Instant Reports 2.0 without any edits in the Report Designer can be opened in Instant Reports. Once a report is edited in the Report Designer, it can no longer be edited with the Instant Report Designer.
HTML Charts / Dundas Charts
SQL Query Export
Forms Design / Edit
Language Translations
Report Summary
Adding Multiple Charts
Adding Summary Grid
