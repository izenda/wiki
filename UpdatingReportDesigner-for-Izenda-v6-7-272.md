#Updating to version 6.7.272+

[[_TOC_]]

##Question

How do I upgrade from an earlier version to something beyond 6.7.0.271? I'm getting $ is not defined errors when I try and apply this change.

##Answer

Between version 6.7.0.271 and 6.7.0.272, changes were made to the jQuery library inclusion behavior to avoid conflicts with other deployments of jQuery customers may be using. Upgrading to this version requires some additional steps other than just replacing the DLL with the new version.

###Updating the Report Designer

To complete the upgrade to version 6.7.0.272, you need to modify the ReportDesigner.aspx page manually. This can be achieved by first finding the file in your reporting directory. Below is a screenshot of where to find it.

![](/UpdatingReportDesigner-for-Izenda-v6-7-272/report_designer.png)

Once you have located it, open it and change the line marked in red in the screenshot below to read **jq$** instead of just **$**.

![]()

Once you have done that, and assuming you completed the normal steps in the process, you should no longer see the errors related to "$ is not defined".