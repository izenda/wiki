#Setting up the Izenda Reports Scheduler

[[_TOC_]]

##Understanding the Scheduler

The Izenda Reports Scheduler at it's core is a simple task that looks at the reports repository at their scheduled execution time. If the scheduled time is in the past, the scheduler sends the report and then updates the time based on the selected frequency.

There are two ways in which the scheduler works which you can select depending on your preference: the Task Based Scheduler, which is created through Windows Task Manager and the Service Based Scheduler which utilized Windows Services.

##Izenda Reports Scheduler Setup Instructions

###Installing the Task-based scheduler

https://github.com/izenda/custom-scheduler

This scheduler requires the use of the Izenda Scheduler executable that is packaged with our [[reference implementation starter kit|http://www.izenda.com/update-your-izenda-version/]]. You then need to add a scheduled task to your system that runs on an interval you specify. The task will execute the Izenda Scheduler to send a command to the response server (rs.aspx) that determines if any reports need to go out. You can specify the URL of your rs.aspx page as a command line parameter when setting up the task as will be discussed below.

Here are the steps to install the Izenda Scheduler. It is recommended that you perform these installation steps on the Web Server on which Izenda Reports is installed. The Windows' Scheduled Task Functionality described is only available on Windows Server operating systems. 

1. Right Click the **Start** button in Windows Server
2. Click on the **Control Panel** menu option
3. Navigate to **Scheduled Tasks**
4. Under Actions menu option select **Create Task...**.
5. In the General tab, give the Task a Name. Select **Run whether user is logged on or not**. 
6. Go to the Triggers Tab and select New, Set the triggers for a the new task (daily, weekly, monthly) and the start date for the task. In the Advanced Settings on this tab set the repeat frequency (5 minutes, 30 minutes, etc.). If you must have the Izenda items scheduled run on the exact minute it is scheduled, your task should be set to run every minute. The delivery will only happen when this task is run, so if a report is set to run at 11:30, and the scheduled task is set for 11:35 the 11:30 report will be delivered at 11:35.
7. Go to the Actions Tab and under Action select "Start a program". In the Program/script window browse to or paste in the full file path of the folder that you installed Izenda Reports and select the Izenda scheduler program ( **IzendaScheduler.exe** ). Example: c:\IzendaReports\reference-implementations\bin\IzendaScheduler.exe. Now in the Add Arguments section you will need to paste the full path to the rs.aspx page for the site, example: (http://localhost/rs.aspx)
8. If you are not an administrator on the machine you may need to enter the user name and password of an account with sufficient rights to schedule the task (usually administrator) 
9. Please review the Conditions and Settings tabs for any items that you may want to set based on your needs.
10. Click **Ok**

Now that you have setup the scheduler, we will need to setup Izenda Reports. There are two ways to do this. We recommend using the [[InitializeReporting()|/FAQ/InitializeReporting]] method in your CustomAdHocConfig class to do this.

###Installing the Service-based scheduler

The MSI installer and service based scheduler is available at our GitHub scheduler repo https://github.com/izenda/custom-scheduler. After running the installer, there will be an executable in the directory you specified in the installer wizard along with a config file called **IzendaService.exe.config**. Here is how to configure the service-based scheduler:

1. Open **task manager**.
2. Locate **IzendaService**.
3. The service should be running. Right click the service and select "Stop".
4. Open the **Windows Explorer**.
5. Navigate to where the **IzendaService** scheduler is installed (by default C:/Program Files (x86)/IzendaService).
6. Open **IzendaService.exe.config** in the text editor of your choice with administrator privileges.
7. Edit the **url** setting to the location of your rs.aspx page with the **run_scheduled_reports=1** query string parameter. (ex: **http://yourhost/yourapp/rs.aspx?run_scheduled_reports=1** ) 
  1. *Optional:* The rs.aspx page also accepts the parameter ssl=1 for running scheduled reports. This will require the process to use SSL security when contacting the email server. (**rs.aspx?run_scheduled_reports=1&ssl=1**)
8. Edit the **interval** setting to the time in milliseconds that will elapse between calls to the URL specified.
9. Save the config file with the modified settings.
10. Go back to the **task manager** and restart the **IzendaService**.

The service-based scheduler is now ready to run and will call the requested URL each time the interval elapses from the time the service was started.

<!--##Enabling scheduling controls in the application

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
-->

##Setting up the scheduler using the Settings.aspx page (Trial/POC)

To use the Settings.aspx page:

* Navigate to the Settings.aspx page in Izenda Reports (for example http://yourhost/yourapp/settings.aspx).
* Click the "Email and Scheduling" Tab
* Set the "Email From Address" field (e.g. admin@yourdomain.com).
* Check the "Show Schedule Controls" check box
* Enter in your SMTP relay server in the "Smtp Server" field (e.g. smtp.yourcompany.com).
* Click "Save to Izenda.Config" in the upper left-hand corner
* Open a report you want to schedule in the report designer, click the “Misc” tab of the report. The scheduler controls will be towards the bottom of the page. Enter the email addresses separated by commas. Set the report type and the repeat frequency. You must set the repeat frequency in order to schedule the report.
* Save the report again.
* The e-mail scheduler setup is now finished.

##Setting up the scheduler using the Global.asax (Production)

To set the settings in the Global.asax:

* Set up your SMTP Server in the Global.asax file inside of the **InitializeReporting()** method by modifying the following settings. The Global.asax file can be found in the root of the directory to which you installed Izenda Reports.

```csharp
Izenda.AdHoc.AdHocSettings.SmtpServer = "INSERT IP ADDRESS HERE";
```

* Set up your e-mail report format string. This is the string that the user will see when the e-mail is received. The {0} will be replaced with the report that the user has been scheduled to receive. Remember to replace "Host" with your domain, such as "SomeCompany.com" and "App" with your application name, such as "Reporting".

```csharp
Izenda.AdHoc.AdHocSettings.ScheduledReportsUrlFormatString = "http://Host/App/reportviewer.aspx?{0}";
```
* Set the e-mail address all users will see when a report is scheduled and sent via e-mail.

```csharp
Izenda.AdHoc.AdHocSettings.EmailFromAddress = "reports@somecompany.com";
```

* Lastly, enable the the report scheduling controls so they are show in the “Misc” tab.

```csharp
Izenda.AdHoc.AdHocSettings.ShowScheduleControls = true;
```


##Testing the scheduler

To test the settings you just set, you will need to schedule a specific report, then use one of two methods to execute the scheduler.

###Scheduling a specific report
* For this testing, you will need to schedule the report to run in the past.

1. Open the report you wish to schedule in the Report Designer.
2. Navigate to the Misc tab. The scheduler controls will be towards the bottom of the page. 
3. Enter the e-mail addresses separated by commas, then set the report type and the schedule frequency. 
4. Save the report. Save the report again. Now go back to the Report List. 

###Executing the scheduler for testing

* For both methods, you will need to have a report scheduled to run in the past
* You should receive the link to your scheduled report in your e-mail.

Using the Command Line

1. Open the DOS command line
2. Navigate into the Izenda Reports root directory (for example, C:\web\IzendaReports)
3. Run the line: IzendaScheduler.exe "http://yourhost/yourapp/rs.aspx" 
4. This will return a list of reports and their next scheduled date and time in the DOS window

Using the rs.aspx Page

1. In your application, navigate to the rs.aspx (ex., http://yourhost/yourapp/rs.aspx)
2. Add the followingto the end of the URL: ?run_scheduled_reports=30 (30 equals the frequency in minutes it will run)
3. The url in the browser should read: http://yourhost/yourapp/rs.aspx?run_scheduled_reports=30
4. This will return a list of reports and their next scheduled date and time in the browser window

## [Advanced Set Up and Scenarios](http://wiki.izenda.us/Guides/Advanced-Scheduler-Functionality)

# To Section 2 - [Using the Reports Scheduler](http://wiki.izenda.us/FAQ/Questions/What-does-Repeat-Types-and-Send-Email-As-mean)