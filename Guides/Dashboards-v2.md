[[_TOC_]]

#Introduction

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