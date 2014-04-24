#Overriding page level css

[[_TOC_]]

##Report Viewer

###Toolbar

Izenda does not currently offer a simple method of editing this portion of the report viewer. However, it is still possible. To edit the CSS for the toolbar on the Report Viewer page, follow the steps below:

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

To override other classes that are not included in this sample, you can easily add the appropriate override by using the developer tools that come with different browsers to inspect the HTML and pick out the elements you wish to modify the CSS for.

##Report Designer

###Tabs

Download the [[css.zip|http://www.izenda.com/Site/KB/uploads/attachments/css.zip]] file and extract the **tabs.css** file to the resources/css folder within your application. Make sure that it is named tabs.css, then enter the dynamically generated tabs.css link into your browser (example:  "/your_site_url/resources/css/tabs.css"). 

There are two ways that you can set this property in your application. 

A. Set [[TabsCssUrl|/API/CodeSamples/TabsCssUrl]] = "your_site_url/resources/css/tabs.css" in ``InitializeReporting()`` in your global.asax.

**-OR-**

B. On the Settings.aspx page, go to the **Appearance (images and css)** tab and insert the absolute path to the tabs.css file in the **Tabs CSS URL** text box (example: your_site_url/resources/css/tabs.css) . We recommend option A to adhere to best practices.

Once you have set the path to tabs.css, you can use the program of your choice to edit it to match your company's colors or fonts.

##Toolbar

With the zip file you downloaded from the last section, extract the **toolbar.css** file into the resources/css folder within your application. Ensure the file is still named toolbar.css, then enter the link generated into your browser (example /your_site_url/resources/css/toolbar.css).

You can either set the [[ToolbarCssUrl|/API/CodeSamples/ToolbarCssUrl]] setting to your new URL or you can enter it into the **Toolbar CSS URL** text box on **settings.aspx**

##Report List

To use custom CSS for the Report List page, you can use the method described above for the Report Viewer to obtain the desired results. However, the file will be called ``reportlist.css`` and the page it should be included on is **ReportList-Head.ascx**. The CSS classes you will have to override will also be different than the ReportViewer page CSS classes.