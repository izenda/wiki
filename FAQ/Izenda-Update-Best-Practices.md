##Updating within a point release / Performing a 'Maintenance Update' (Ex: 6.10.0.1-> 6.10.0.15)

1) Review release notes [here](http://wiki.izenda.us/Release-Notes). Release notes for each maintenance release will have notes detailing changes, settings, and fixes associated.

2) Set aside any customized files in /Resources - This is typically CSS, but could be HTML or JS.

3) Copy the /Resources & /BIN from the Izenda 'Maintenance' download and after removing your old /Resources &/BIN directories completely, replace with the new folders.

4) Compare the customized files from Step #1 to new updated files and copy your customizations to new files one at a time, testing each.


##Upgrading across point releases (Ex: 6.9.0.6-> 6.10.0.1)

1) Review release notes [here](http://wiki.izenda.us/Release-Notes). Release notes for each release will have notes detailing features, settings, and fixes associated.

2) Set aside any customized files in the entire Izenda deployment - This is typically the global.asax, code-behind files, sometimes individual page code, CSS, HTML or JS.

3) Download an Izenda 'Full Download' that includes all files and pages.

4) In the 'vanilla' kit, enter the connection string and license key into the Global.asax. Launch the 'vanilla' installation to confirm that your license key and connection string are set correctly.

5) Compare customized files from Step #1 to new updated files and merge over your customizations to the new files, starting with the global.asax and connection info (if contained somewhere besides the global). Move over customizations one at a time, testing each.

_See Also:_
[[How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL]]

##Upgrading Beyond Version 6.10.0.16

1A) Download the FULL RI Downloads RI Link from (http://archives.izenda.us)[http://archives.izenda.us]

1B) If you are upgrading from an older version of Izenda and do not want to download the full RI, you can use the RI as a reference. 

It is critical to update your resource links per this example: 

link rel = "stylesheet" type = "text / css" href = "./ rp.aspx? extres = components.vendor.bootstrap.css.bootstrap.min.css" 

2) Unzip and copy the bin and resources to the corresponding website folders as would be done in a standard upgrade. 

3) Locate the rp.aspx page in the extracted folder. For MVC Kits this is in the Reporting folder. In Webforms and VB this is located in the root of the extracted folder. 

4) Copy the new rp.aspx page to all locations in your implementation containing the rs.aspx page (please ensure you search as some implementations have more than one location for this file. 

5) Locate the default.master page in Webforms or VB kit and _SiteLayout.cshtml in MVC kits. Find the following line:

<script type="text/javascript" src="Resources/js/main.js"></script> 

Replace with the following: 

<script type="text/javascript" src="./rp.aspx?js=AdHocQuery"></script> 

This is REQUIRED as the main.js file is no longer included in the kit, and if this is not replaced there will be errors when you try to run the site.

6) Find and replace all references to ./rs.aspx wtih ./rp.aspx (this is not required but making these changes will improve the loading speed for resources on the pages - this change removes blocking issues faced with resources loading) 

7) Replace:

<link rel="stylesheet" href="Resources/css/main.css" type="text/css" /> 

With the following:

<link rel="stylesheet" href="./rp.aspx?extres=css.main.css" type="text/css" />