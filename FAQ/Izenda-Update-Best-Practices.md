##Updating within a point release / Performing a 'Maintenance Update' (Ex: 6.9.0.1-> 6.9.0.3)

1) Review release notes [here](http://wiki.izenda.us/Release-Notes). Release notes for each maintenance release will have notes detailing changes, settings, and fixes associated.

2) Set aside any customized files in /Resources - This is typically CSS, but could be HTML or JS.

3) Copy the /Resources & /BIN from the Izenda 'Maintenance' download and after removing your old /Resources &/BIN directories completely, replace with the new folders.

4) Compare the customized files from Step #1 to new updated files and copy your customizations to new files one at a time, testing each.


##Upgrading across point releases (Ex: 6.8.0.1-> 6.9.0.3)

1) Review release notes [here](http://wiki.izenda.us/Release-Notes). Release notes for each release will have notes detailing features, settings, and fixes associated.

1) Set aside any customized files in the entire Izenda deployment - This is typically the global.asax, code-behind files, sometimes individual page code, CSS, HTML or JS.

2) Download an Izenda 'Full Download' that includes all files and pages.

3) In the 'vanilla' kit, enter the connection string and license key into the Global.asax. Launch the 'vanilla' installation to confirm that your license key and connection string are set correctly.

4) Compare customized files from Step #1 to new updated files and merge over your customizations to the new files, starting with the global.asax and connection info (if contained somewhere besides the global). Move over customizations one at a time, testing each.

_See Also:_
[[How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL]]