#Customizing Report List

[[_TOC_]]

##About

The Report List page is included in the Izenda starter kit and is simply called ReportList.aspx in the solution. The Report List is robust and AJAX driven. It includes a list of all report **Categories** and **Recent** reports on the left side. It also has a top banner with the options **Reports**, **Dashboards**, **New**, and **Settings**. And the main portion of the page is comprised of a grid of thumbnails and titles of all the reports in the selected category.

![](/API/CodeSamples/ReportList/custom-report-list/reportlist.png)

##Left Side Bar

The bar on the left side is where you will select report categories or recent reports. 

![](/API/CodeSamples/ReportList/custom-report-list/reportlist_Sidebar.png)

Selecting a recent report will take you directly to the Report Viewer page while selecting a category will update the grid to the right. You can also type a search term into the **Search** box. Pressing enter or clicking the magnifying glass will submit the search. The search will update all sections of the ReportViewer with reports and categories corresponding to the search term entered.

##Right Side Grid

The grid on the right side contains all report thumbnails for the selected category or entered search term. 

![](/API/CodeSamples/ReportList/custom-report-list/reportlist_Grid.png)

Each thumbnail has several different options.

![](/API/CodeSamples/ReportList/custom-report-list/reportlist_Thumbnail.png)

You can click on a thumbnail to view the report. You can also hover over the report to view options including printing the selected report, editing the report (redirects to the Report Designer), or deleting the report. These options can be enabled or disabled via various [[AdHocSettings|/API/AdHocSettings]]. 

##Toolbar

The toolbar on this page is included in the Default.Master page. If you are using your own master page, you can incorporate the structure of the Izenda master page into your own solution. You can either paste the structure directly into your existing master page or tweak the structure to fit your own solution.

![](/API/CodeSamples/ReportList/custom-report-list/reportlist_Toolbar.png)

##Customizing Report List

###Prior to 6.7

Before version 6.7, you could use the code-behind of the ReportList.aspx page to customize the page. You can get a list of reports guaranteed available to the current user via the [[FilteredListReports|/FAQ/FilteredListReports]] method. First, you would need to declare this object in your code:

```csharp
private ReportInfo[] reports = AdHocSettings.AdHocConfig.FilteredListReports();
```

Then you can iterate through the collection and process each into an HTML style link

```csharp
foreach (ReportInfo info in reports)
{
	string processedReportName = info.FullName.Replace(' ', ' ');   
	Response.Write("<a href='" 
		+ AdHocSettings.ReportViewerWithDelimiter 
		+ "rn=" 
		+ processedReportName
		+ "'> <b>"
		+ info.FullName
		+ "</b></a><br>");
}
```

As it iterates, you can print out the report name as a hyperlink that links to the Report Designer page. You can also do this via javascript or add buttons and functionality as you desire.

**Report List code sample with no asp objects**

This code sample utilizes no asp objects and prints out a simple list of reports with the format of the name or cat/name in a list on the page.

* [[ReportListNoAspObjects.zip|http://www.izenda.com/Site/downloads/ReportListNoAspObjects.zip]]

**Report List code sample using asp controls**

This code sample utilizes a simple asp control and prints out a simple list of reports with the format of/ the name and category headings in a list down the page.

* [[ReportListAspObjects.zip|http://www.izenda.com/Site/downloads/ReportListAspObjects.zip]]

**Report List code sample with categories and design new report link.**

This code sample utilizes asp controls and prints out a list of reports using the format of the name and category headings in a list down the page.

* [[ReportListFull.zip|http://www.izenda.com/Site/downloads/ReportListFull.zip]]

###6.7 And Later

Newer versions of the demo site that are distributed on the Izenda site include a different page structure that leverages jQuery technologies and can be customized by modifying the javascript. It is pre-built to perform necessary functions that leverage the page structure and naming conventions. However, since it is open for editing, you can see how the Report List is built. As such, there will not be any code samples included here.