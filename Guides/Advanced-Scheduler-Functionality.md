#Advanced Scheduler Functionality

[[_TOC_]]

##Security On Scheduled Reports

Scheduled reports only supports per-user security using the Link format.  Scheduled attachments will not apply hidden filters normally, but you can apply security through [[PreExecuteReportSet()|/FAQ/PreExecuteReportSet]] based on the security of the report owner.  If per-user security is required, the Link format will require the user to login before seeing the report.

##Saving Reports to Disk

The Scheduler can be used to save reports to disk.

Here are some basic instructions for setting up this functionality with the Scheduler.

* Add the file [[FileScheduler.cs|/FAQ/Questions/How-do-I-use-the-Izenda-Reports-report-email-scheduler/FileScheduler.cs]] to the folder \App_Code\
* In SchedulerPage.aspx, we will create the SchedulerPage.aspx.cs

From your root, create a page called SchedulerPage.aspx with the following SchedulerPage.aspx.cs code behind:

```csharp
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SchedulerPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FileScheduler.RunScheduledReports(Response.Output, DateTime.Now);
    }
}
```

How to use:
* Create a report and schedule it. In this case, we need to save to a folder -- so instead of an email recipient, specify the folder in which to save your report.
* Open the SchedulerPage.aspx page in the browser.

##Clearing scheduler settings on new report save

You can use the following custom code to make sure that when a copy of a report is saved, the scheduler settings are not saved along with the report copy:

```csharp

public override void SaveReportSet(ReportInfo reportInfo, ReportSet reportSet)
{
    ReportSet existingReport = LoadFilteredReportSet(reportInfo.FullName);
    // If this is a new report or SaveAs report
    if (existingReport == null)
    {
        reportSet.Recipients = "";
        reportSet.RepeatType = RepeatType.None;
    }
    
    // Save report normally
    base.SaveReportSet(reportInfo, reportSet);
}

```

##Overnight batch report processing

One extremely useful function of scheduling reports is batch processing of reports during nighttime hours. Implementation of overnight processing is just a matter of setting which reports will run during office off-hours.

First, you need to open the report you will want to schedule in the ReportDesigner. Navigate to the [[Misc tab|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab]] and choose the time your report will run and the frequency. For overnight processing, just select a time period that does not conflict with your normal business hours. Save the report with the desired frequency. You must do this for each report you want to process.

Next, you will just need to ensure the scheduler process is running. Normally servers are left on overnight anyway, so just as long as the server computer that the scheduler is installed on and the server where the reporting application is installed on are running, the reports will get processed. Generally, these will be on the same machine anyway. The interval of the scheduler you defined when you installed it will ping the reporting application to see if any reports need to be scheduled. If one or more are scheduled, the reporting application will begin processing and sending those reports via email. So essentially, overnight processing is the same process as any other time of day with respect to setup.