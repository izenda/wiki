[[_TOC_]]

#Introduction
Izenda now offers its new Angular.js Dashboard Designer / Viewer with the platform’s latest update to 6.9. Once implemented, any existing dashboards will automatically convert to the new dashboard format. While previous versions were limited to a static structure for the dashboard, tiles can now be resized. Users can add new tiles to any point on the grid in the Dashboard Designer. The dashboard displays with more fluid animation as well. The new Dashboard Designer/Viewer also includes a presentation mode, which allows the user to slide through dashboard tiles on a carousel.


#Features

* New responsive Angular.js Dashboards 
* User friendly user interface
* Modern Look and Feel
* Movable and resizable tiles
* Presentation Mode to scroll through full screen dashboard tiles

#Installation

##Webforms

1. [Download](http://www.izenda.com/update-your-izenda-version/) the full Webforms kit and replace the bin and resources folders within your projectt
2. Take the Dash.aspx and Dash.aspx.cs files from the downloaded kit and copy it to your project
3. Update Default.Master with the new changes to update links to Dash.aspx from Dashboards.aspx  
```c#
    <div class="top-nav applyStyles" id="blueHeader">
      <div class="page">
        <ul id="topnav" style="margin: 0px; padding: 0px;">
          <li class="top-nav-item"><a href="ReportList.aspx">Reports</a></li>
          <li class="top-nav-item"><a href="Dashboards.aspx?clear=1" onclick="ShowRlToDbLoading();">Dashboards</a></li>
```
4. In the global, update the dashboard viewer setting to AdHocSettings.DashboardViewer = "Dash.aspx";, as well as the dashboard designer setting to AdHocSettings.DashboardDesigner = "Dash.aspx";

##MVC

1. [Download ](http://www.izenda.com/update-your-izenda-version/)the full MVC kit for 6.9
2. Copy the bin and resources from the kit downloaded into your project
3. Add:  _Dashboards-New-Head-Angular, _Dashboards-New-Body-Angular, _SiteLayout and Dash files to Views/Reporting. Ensure they are included in the project
4. Update the IzendaReportingController.cs to include:
```c#
    public ActionResult Dash() {

      return View();
    }
```
5. In the global, update the following: AdHocSettings.DashboardViewer = "Dash" and AdHocSettings.DashboardDesignerUrl = "Dash";

### Tips
* When upgrading, ensure log4net.dll and log4net.xml are in the Bin folder
* If you get an error stating System.Web.Mvc or System.Web.Mvc.Ajax are not in the namespace, right-click the file in the references, click properties and ensure Copy Local is true.

#Guide
##Creating a New Dashboard

**a)** Click on the arrow to expose the drop down menu under New  
**b)** Select Dashboard from the Menu drop down. A New Blank Dashboard will be exposed with a blank tile.

![](/Guides/Dashboards-v2/1.png "New Dashboard Drop-down")  

##Adding Report Parts to the Dashboard Tile  

**c)** Click on the + sign to add a Report Part to the new Dashboard  

 ![](/Guides/Dashboards-v2/2.png "New Dashboard Tile")

**d)** The user can now select a report to use in the dashboard. 

 ![](/Guides/Dashboards-v2/3.png "Available Reports for Dashboard")

**e)** Once a report is selected, the user is presented with a window displaying all of the report parts as options to add to the new dashboard. These can include charts, maps, gauges, summaries or report details.

 ![](/Guides/Dashboards-v2/4.png "Report Parts")

**f)** The report part selected will then be displayed to the user.

 ![](/Guides/Dashboards-v2/5.png "The Report Part in its Dashboard Tile")

To remove a tile, simply click the “X” in the top right corner of the tile.

![](/Guides/Dashboards-v2/10.png)

To add additional tiles to the dashboard, the user can click on a blank area of the dashboard background. 

 ![](/Guides/Dashboards-v2/6.png)

A new blank tile will then be displayed.

 ![](/Guides/Dashboards-v2/7.png)

The user can repeat the process to add additional tiles

##Moving & Resizing Dashboard Tiles
The tiles can be resized by dragging the corners to the desired length or width.
Tiles can also be moved around the Dashboard. When the tile shows a green hue, it is positioned correctly and can placed on the grid. If the tile shows a red hue, it is not positioned on the grid properly and cannot be moved.

Properly Positioned Tile for move (green hue)

![](/Guides/Dashboards-v2/8.png)

Improperly Placed Tile for move (red hue)

![](/Guides/Dashboards-v2/9.png)

##Tile Customizations

There are several options available for customizing a tile. These options can be found by clicking on the menu button in the top right corner of the specific tile. The tile will then spin to the reverse side, revealing the additional options. 

![](/Guides/Dashboards-v2/11.png)

The user can now choose to add a Tile that is displayed on the front of the tile along with a Description that is also displayed on the tile

![](/Guides/Dashboards-v2/12.png)

The additional following menu items are available for use on the back of each dashboard tile

![](/Guides/Dashboards-v2/13.png)
![](/Guides/Dashboards-v2/14.png)


|**Appearance**|**Description**|
|:------------:|:-------------:|
|![](/Guides/Dashboards-v2/15.png)|Print tile report – prints the tile from dashboard|
|![](/Guides/Dashboards-v2/16.png)|Export tile report to Excel|
|![](/Guides/Dashboards-v2/17.png)|Opens the Report the tile is created from in report editor|
|![](/Guides/Dashboards-v2/18.png)|Opens the Report the tile is created from in the report viewer|
|![](/Guides/Dashboards-v2/19.png)|Reloads the tile from report|
|![](/Guides/Dashboards-v2/20.png)|Add a new report part to tile (change report part selected from original report)|
|![](/Guides/Dashboards-v2/21.png)|Change the Number of Records to be displayed in the tile|


##Viewing an Existing Dashboard

Click on Dashboard at the Top Navigation Bar

![](/Guides/Dashboards-v2/22.png)

Dashboards will be displayed as tabs in the window with the active window highlighted from below

![](/Guides/Dashboards-v2/23.png)


##Main Dashboard Menu

This menu offers the following menu options are available from the menu button in the top left navigation bar when expanded

![](/Guides/Dashboards-v2/24_25.png)


|**Appearance**|**Description**|
|:------------:|:-------------:|
|![](/Guides/Dashboards-v2/26.png)|Collapse Menu|
|![](/Guides/Dashboards-v2/27.png)|Presentation Mode – Allows the user to scroll through the Dashboard tiles in a carousel |
|![](/Guides/Dashboards-v2/28.png)|Create a New Dashboard|
|![](/Guides/Dashboards-v2/29.png)|Refresh Dashboard|
|![](/Guides/Dashboards-v2/30.png)|View Filters – Each report in the dashboard must share the same filter to be displayed |
|![](/Guides/Dashboards-v2/31.png)|Share Dashboard with other users|
|![](/Guides/Dashboards-v2/32.png)|Schedule Dashboard - Sends dashboard via email at a scheduled time|
|![](/Guides/Dashboards-v2/33.png)|Print Dashboard = Prints Dashboard HTML or Report PDF |
|![](/Guides/Dashboards-v2/34.png)|Save Dashboard - Saves dashboard as different name or pdf file|
|![](/Guides/Dashboards-v2/35.png)|Change Dashboard - Changes background image|
