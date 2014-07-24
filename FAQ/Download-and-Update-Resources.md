##Downloading and Updating Izenda

[[_TOC_]]

##Question

How do I update Izenda to a new release?

##Answer

To update Izenda to a new release, you first need to visit our [[download page|http://www.izenda.com/Site/Pages/download.aspx]] and download the zip file. Once that is done, there are just a couple of steps to perform.

###Step 1 Updating the binary files

Within the zip folder, you will find a lot of DLLs. These are the resources that Izenda is dependent upon. You should copy all of these into the bin folder of your reporting website. You can learn more about a first-time setup of Izenda from [[this link|/Integration/Tutorials/Installing-Izenda]].

###Step 2 Updating the resources

Within the zip folder you will also see a resources folder. This contains all the javascript, HTML, and CSS that the Izenda reporting pages use by default. If you have any customizations in these files, we recommend you create backups of your files so you won't override any functionality. Once you have done that, simply paste the new files into the directory. The top-level aspx pages automatically reference these resources in their current state.

###Version 6.7.0.272

We made sweeping changes to the way jQuery is referenced for this version and so this requires additional steps if you are upgrading from a previous version. You can read more about it [[at this link|/FAQ/UpdatingReportDesigner-for-Izenda-6.7.0.272]]