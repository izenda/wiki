#Appearance

[[_TOC_]]

###Introduction

Izenda Reports fully integrates with your application both at the program level and visually. All visual aspects of Izenda Reports are user customizable and can be made to match your existing application's visual look and feel. These are some of the quickest ways to change the look and feel of our application in order to blend seamlessly with your product or application.

###Setting Custom CSS and Navigation Image Files

####Settings.aspx

An example of how to set custom CSS:

  * download the archive
    * [CSS.ZIP](http://wiki.izenda.us/Integration/Appearance/css.zip)
  * edit the CSS files, **but do not change the selector names or the filenames**
  * save the edited files to your server where they can be accessed via absolute urls
  * navigate to the settings.aspx page and click the "Images & CSS" tab shown below **-OR-** you can define them [[programatically|http://wiki.izenda.us/Integration/Tutorials/Appearance#Programatically]].

    ![](http://wiki.izenda.us/Appearance/ImagesCssTab.png)
  * enter the new absolute URLs of the CSS files
  * fully clear your cache and restart the application

####Programatically

  * download the archive
    * [CSS.ZIP](http://wiki.izenda.us/Integration/Appearance/css.zip)
  * edit the CSS files, **but do not change the selector names or the filenames**
  * save the edited files to your server where they can be accessed via absolute urls
  * Open up your global.asax and override the following properties:
    * [[DashboardsCssUrl|/API/CodeSamples/DashboardsCssUrl]]
    * [[FieldValueCssUrl|/API/CodeSamples/FieldValueCssUrl]]
    * [[ReportCssUrl|/API/CodeSamples/ReportCssUrl]]
    * [[SimpleFilterCssUrl|/API/CodeSamples/SimpleFilterCssUrl]]
    * [[TabCssUrl|/API/CodeSamples/TabsCssUrl]]
    * [[ToolbarCssUrl|/API/CodeSamples/ToolbarCssUrl]]
    * [[HeaderStyle|/API/CodeSamples/HeaderStyle]]
  * enter the new absolute URLs of the CSS files
  * fully clear your cache and restart the application
  
After resetting and clearing the cache, the CSS changes should reflect in Izenda Reports.

###Setting the Report List page (ReportList.aspx) CSS

Although the html element styles are hard coded into the application, it is possible to change them by simply placing a style tag into the page right after the end of the form. [[Please see this example]]. 

###Customer Integration Samples

We have screenshots of our customers' integrated solutions available [here](http://www.izenda.com/Site/Pages/Clients.aspx).