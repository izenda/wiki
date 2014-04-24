#Overriding page level css

[[_TOC_]]

##Report Viewer

###Toolbar

To edit the CSS for the toolbar on the Report Viewer page, follow the steps below:

* Create a new file in your **resources/css** directory on your website called reportviewer.css
* Open ReportViewer-Head.ascx in **Resources/html**
* Insert the following line into the page: ``<link rel="stylesheet" type="text/css" href="./Resources/css/reportviewer.css" />``
* Insert the following class overrides into the reportviewer.css file

```css
/*Controls the style of the entire toolbar*/
.nav-tabs {

}

/*Controls the style of just the buttons section of the toolbar*/
.btn-toolbar {

}

/*Controls each button's div element*/
.btn-toolbar div {

}

/*Controls the tabs on the toolbar: Filters, Fields, Pivots*/
.nav-tabs li {

}
```

##Report Designer

###Tabs

Download the [[css.zip|http://www.izenda.com/Site/KB/uploads/attachments/css.zip]] file and extract the tabs.css file to a folder within your application. Make sure that it is named tabs.css, then enter the dynamically generated tabs.css link into your browser (example:  "/izenda/css/tabs.css"). 

There are two ways that you can set this property in your application. 

    A. Set [[TabsCssUrl|/API/CodeSamples/TabsCssUrl]] = "your_site_url/css/tabs.css" in ``InitializeReporting()`` in your global.asax.
    B. On the Settings.aspx page, go to the **images and css** tab and insert the absolute path to the tabs.css file in the **Tabs CSS URL** text box (example: your_site_url/css/tabs.css) 

Once you have set the path to tabs.css, you can use the program of your choice to edit it to match your company's colors or fonts.

##Report List

