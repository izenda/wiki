[[_TOC_]]

#Introduction

#Guide
##Creating a New Dashboard

**a.** Click on the arrow to expose the drop down menu under New

![](/Guides/Dashboards-v2/1.png)

**b.** Select Dashboard from the Menu drop down. A New Blank Dashboard will be exposed with a blank tile.

**c.** Click on the + sign to add a Report Part to the new Dashboard

 ![](/Guides/Dashboards-v2/2.png)

A New window will be displayed allowing you to select the report the user would like to add to the dashboard


##Adding Report Parts to the Dashboard Tile

 ![](/Guides/Dashboards-v2/3.png)

The user can now select a report to use in the dashboard
Once a report is selected, the user is presented with a window displaying all of the report parts as options to add to the new dashboard. These can include charts, maps, summaries or report details.
 ![](/Guides/Dashboards-v2/4.png)

 ![](/Guides/Dashboards-v2/5.png)
The report part selected will then be displayed to the user.
To add additional tiles to the dashboard, the user can click on a blank area of the dashboard background. A new blank tile will then be displayed.
 ![](/Guides/Dashboards-v2/6.png)

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

There are several options available for customizing a tile. These options can be found by clicking on the menu button in the top right corner of the specific tile. The tile will then spin to the reverse side, revealing the additional options. To remove a tile, simply click the “X” in the top right corner of the tile.

![](/Guides/Dashboards-v2/10.png)
![](/Guides/Dashboards-v2/11.png)

The user can now choose to add a Tile that is displayed on the front of the tile along with a Description that is also displayed on the tile

![](/Guides/Dashboards-v2/12.png)

The additional following menu items are available for use on the back of each dashboard tile

![](/Guides/Dashboards-v2/13.png)
![](/Guides/Dashboards-v2/14.png)

#Features

#Installation

##Webforms

1. Update as normal by downloading and replacing the bin and resources folder
2. Download the Webforms Kit and take the Dash.aspx file and copying it to your project.
3. In the global, update the dashboard viewer setting to AdHocSettings.DashboardViewer = "Dash.aspx";

##MVC

1. Update as normal by downloading and replacing the bin and resources folder
2. Download the MVC kit for 6.9 and add the new view to your project
3. Update the IzendaReportingController.cs to include
    public ActionResult Dash() {


      return View();
    }
4. In the global, update the dashboard viewer setting to AdHocSettings.DashboardViewer = "Dash";