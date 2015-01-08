# Upgrading to Izenda 6.8.0.1 +

[[_TOC_]]

##Overview
A number of new items in 6.8.0.1 + should be brought to attention.  In the Reference Implementation, there are new files and folders.  These include the Resources/FromDLL folder, Resources/Vis folder, the node_modules folder, the Gruntfile.js file, and the package.json file.  Also, in the Resources/css folder, there is a new folder called ModernStyles, as well as minified versions of the standard css files.
##

##Question

What are these new files and folders in my Reference Implementation for?

##Answer

There are a number of new files and folders in the Reference Implementation (RI) of Izenda 6.8.0.1 +.  Most of these files are used in the build process before deployment.  In most cases, customers of Izenda can leave these alone, but an explanation of each may be beneficial.

###The node_modules folder

The node_modules folder contains modules from Node.js' package manager.  This mainly consists of modules for Grunt, a JavaScript task runner we use to run our CSS minification process before deployment, and uglifycss, the library that actually minifies the files.  It is recommended that this folder be left alone.

###package.json file

This file holds the dependencies so Node.js' package manager knows what to install to the node_modules folder.  This folder can also be left alone.

###Resources/FromDLL folder

In an effort to make Izenda easier to customize, a lot of resources have been pulled out of the DLL and placed in the Resources folder.  This includes numerous images and scripts used in the product, previously unavailable to customers for modification.  

FromDLL/Resources contains a large group of images used in the product, as well as a few subfolders holding their respective images, such as Dashboard, Toolbar, DataSources, and some extra CSS in the Styles folder. These images are now available to edit and change.  

FromDLL/Scripts holds 30+ scripts previously unavailable to the customer.  These scripts scan now be freely viewed, but modifications to them are not recommended.

###Vis folder

The Vis folder contains the files for Izenda Vision.  Izenda Vision is a product add on utilizing the d3.js library for enhanced and interactive data visualizations.  Inside this folder, you will find 5 subfolders: scripts, Animated, Circular, Rectangular, and Uncategorized.  

The scripts folder contains the necessary scripts for the d3.js library and other necessary scripting libraries.  

Each category houses one or more visualization folder.  For example, the Circular folder contains the folder for the Sunburst visualization.  Inside the Sunburst folder, you will notice some key files- the view.html, the doc.html, and the preview.png.  Every visualization will contain these three files.  Some visualizations contain other helper files, including scripts or additional views.  It is highly recommended that these not be altered.

