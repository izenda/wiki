#How do I use the Izenda Reports report email scheduler?

[[_TOC_]]

##Izenda Reports Scheduler Setup Instructions

###Task-based scheduler

First, a little background about how the scheduler works. The scheduler requires the use of the Izenda Scheduler executable that is packaged with our [[reference implementation starter kit|http://www.izenda.com/update-your-izenda-version/]]. You then need to add a scheduled task to your system that runs on an interval you specify. The task will execute the Izenda Scheduler to send a command to the response server (rs.aspx) that determines if any reports need to go out. You can specify the URL of your rs.aspx page as a command line parameter when setting up the task as will be discussed below.

Here are the steps to install the Izenda Scheduler. It is recommended that you perform these installation steps on the Web Server on which Izenda Reports is installed.

1. Click the **Start** button in Windows Server
2. Click on the **Control Panel** menu option
3. The **Control Panel** will then expand and show a larger menu. Find the menu option **Scheduled Tasks** and click on it
4. After it expands click **Add Scheduled Task**.
5. The **Scheduled Task Wizard** will start. Click **Next**
6. Select the Izenda scheduler program by clicking **Browse** 
7. Browse to the folder that you installed Izenda Reports in and select the Izenda scheduler program ( **IzendaScheduler.exe** ) 
8. Enter a name for the scheduled task and select the frequency. Click **Next**
9. Set the start time and start date and click **Next**
10. Enter the user name and password of a user with administrative rights and click **Next**
11. Check the **Open Advanced Properties for this Task...** checkbox
12. Click **Finish**
13. Now we need to add the proper command line parameter into the **Run** box. This will be the path to the rs.aspx page. (ex: **http://yourhost/yourapp/rs.aspx** ) 
* Click **Apply** and then Click **Ok**

Now that you have setup the scheduler, we will need to setup Izenda Reports. There are two ways to do this. We recommend using the [[InitializeReporting()|/FAQ/InitializeReporting]] method in your CustomAdHocConfig class to do this, but you may also use the settings.aspx page included with our demo to create a config file that will take the place of any settings in code.

###Service-based scheduler

Izenda now also offers the option of using a service-based scheduler. The msi installer is available upon request. After running the installer, there will be an executable in the directory you specified in the installer wizard along with a config file called **IzendaService.exe.config**. Here is how to configure the service-based scheduler:

1. Open **task manager**.
2. Locate **IzendaService**.
3. The service should be running. Right click the service and select "Stop".
4. Open the **Windows Explorer**.
5. Navigate to where the **IzendaService** scheduler is installed (by default C:/Program Files (x86)/IzendaService).
6. Open **IzendaService.exe.config** in the text editor of your choice with administrator privileges.
7. Edit the **url** setting to the location of your rs.aspx page with the **run_scheduled_reports=1** query string parameter. (ex: **http://yourhost/yourapp/rs.aspx?run_scheduled_reports=1** ) 
8. Edit the **interval** setting to the time in milliseconds that will elapse between calls to the URL specified.
9. Save the config file with the modified settings.
10. Go back to the **task manager** and restart the **IzendaService**.

The service-based scheduler is now ready to run and will call the requested URL each time the interval elapses from the time the service was started.

##Enabling scheduling controls in the application

Next, we must allow the schedule controls to be shown in the Report Designer page. This can be done in one of two ways.

###Via Settings.aspx

1. Navigate to the Izenda Reports settings.aspx page (e.g. http://yourhost/yourapp/settings.aspx)
2. Click the "Email & Scheduling" tab
3. Check the box next to "Show Schedule Controls"
4. Click "Save to Izenda.Config" in the upper left-hand corner

###Via Code

1. Open your global.asax file in your IDE/favorite text editor
2. Look for the [[InitializeReporting|/FAQ/InitializeReporting]] method
3. Add the following line of code into the method

```csharp
Izenda.AdHoc.AdHocSettings.ShowScheduleControls = true;
```

The schedule controls will now be shown in the report designer under the [[Misc tab|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab]].

##Setup using the Settings.aspx page

To use the Settings.aspx page:

* Navigate to the Settings.aspx page in Izenda Reports (for example http://yourhost/yourapp/settings.aspx).
* Click the "Email and Scheduling" Tab
* Set the "Email From Address" field (e.g. admin@yourdomain.com).
* Check the "Show Schedule Controls" check box
* Enter in your SMTP relay server in the "Smtp Server" field (e.g. smtp.yourcompany.com).
* Open a report you want to schedule in the report designer, click the “Misc” tab of the report. The scheduler controls will be towards the bottom of the page. Enter the email addresses separated by commas. Set the report type and the repeat frequency. You must set the repeat frequency in order to schedule the report.
* Save the report again.
* The e-mail scheduler setup is now finished.

##Testing the scheduler

To test this, go back to a report you wish to schedule and click on it. Click the Misc tab of the report. The scheduler controls will be towards the bottom of the page. Enter the e-mail addresses separated by commas, then set the report type and the schedule frequency. Save the report again. Now go back to the Report List. Next to the report, you should see the schedule time for the report. Now we can also look at the scheduled tasks on the server.

* Using the DOS command line, navigate into the Izenda Reports root directory (for example, C:\web\IzendaReports) and run IzendaScheduler.exe "http://yourhost/yourapp/rs.aspx". This should return a list of scheduled reports in the DOS window.
* Navigate to the rs.aspx page in the application (for example, http://yourhost/yourapp/rs.aspx). Now add this to the end of the URL, ?run_scheduled_reports=30 (30 equals the frequency in minutes it will run). The url in the browser should read: http://yourhost/yourapp/rs.aspx?run_scheduled_reports=30
* This will return a list of scheduled reports into the browser window. In either case, you should receive the link to your scheduled report in your e-mail.

To set the settings in code:

* Setup your SMTP Server in the Global.asax file inside of the **InitializeReporting()** method by modifying some settings in it. The Global.asax file is found in the root of the directory to which you installed Izenda Reports.

```csharp
Izenda.AdHoc.AdHocSettings.SmtpServer = "INSERT IP ADDRESS HERE";
```

* Setup your e-mail report format string. This is the string that the user sees when the e-mail is sent to him. The {0} will be replaced with the report that the user has been scheduled to receive. Remember to replace "Host" with your domain, such as "SomeCompany.com" and "App" with your application name, such as "Reporting".

```csharp
Izenda.AdHoc.AdHocSettings.ScheduledReportsUrlFormatString="http://Host/App/reportviewer.aspx?{0}";
```
* Set the e-mail address all users will see when a report is scheduled and sent via e-mail.

```csharp
Izenda.AdHoc.AdHocSettings.EmailFromAddress="reports@somecompany.com";
```

* Lastly, setup the report scheduling controls to show in the “Misc” tab.

```csharp
Izenda.AdHoc.AdHocSettings.ShowScheduleControls=true;
```

To test this, go back to a report you wish to schedule and click on it. Click the Misc tab of the report. The scheduler controls will be towards the bottom of the page. Enter the e-mail addresses separated by commas, then set the report type and the schedule frequency. Save the report again. Now go back to the Report List. Next to the report, you should see the schedule time for the report.

##Security On Scheduled Reports

Scheduled reports only supports per-user security using the Link format.  Scheduled attachments will not apply hidden filters normally, but you can apply security through [[PreExecuteReportSet()|/FAQ/PreExecuteReportSet]] based on the security of the report owner.  If per-user security is required, the Link format will require the user to login before seeing the report.

##Saving Reports to Disk

The Scheduler can be used to save reports to disk, if desired.

Here are some basic instructions for setting up this functionality with the Scheduler.

*Add your FileScheduler.cs -> \App_Code\
*SchedulerPage.aspx, SchedulerPage.aspx.cs -> \

From your root, create your SchedulerPage.aspx with code behind, as such:

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
* Create a report and schedule it. In this case we need to save to the folder -- so instead of emails specify folders in which to save your report.
* Open the SchedulerPage.aspx page in the browser.


##Overnight batch report processing

One extremely useful function of scheduling reports is batch processing of reports during nighttime hours. Implementation of overnight processing is just a matter of setting which reports will run during office off-hours.

First, you need to open the report you will want to schedule in the ReportDesigner. Navigate to the [[Misc tab|http://wiki.izenda.us/Guides/ReportDesign/9.0-Misc-Tab]] and choose the time your report will run and the frequency. For overnight processing, just select a time period that does not conflict with your normal business hours. Save the report with the desired frequency. You must do this for each report you want to process.

Next, you will just need to ensure the scheduler process is running. Normally servers are left on overnight anyway, so just as long as the server computer that the scheduler is installed on and the server where the reporting application is installed on are running, the reports will get processed. Generally, these will be on the same machine anyway. The interval of the scheduler you defined when you installed it will ping the reporting application to see if any reports need to be scheduled. If one or more are scheduled, the reporting application will begin processing and sending those reports via email. So essentially, overnight processing is the same process as any other time of day with respect to setup.