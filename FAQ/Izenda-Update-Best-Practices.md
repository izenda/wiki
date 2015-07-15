##When you update Izenda, you should perform a few steps:

###If you are upgrading within a point release - a 'Maintenance Update' - (Ex: 6.8.0.1-> 6.8.0.3)

1) Preserve any customized files in /Resources - This is typically CSS, but could be HTML or JS.

2) Remove /Resources & /BIN completely.

3) Replace with updated /Resources & /BIN from the Izenda 'Maintenance' download.

4) Compare customized files from Step #1 to new updated files and merge over your customizations to new files one at a time, testing each.


###If you are upgrading across point releases (Ex: 6.7.255-> 6.8.0.5)

1) Preserve any customized files in the entire Izenda deployment - This is typically the global.asax, code-behind files, sometimes individual page code, CSS, HTML or JS.

2) Download an Izenda 'Full Download' that includes all files and pages.

3) Launch this 'vanilla' installation with only license key. You should be sent to the settings.aspx page to ask for a connection string.

4) Compare customized files from Step #1 to new updated files and merge over your customizations to the new files, starting with the global.asax and connection info (if contained somewhere besides the global). Move over customizations one at a time, testing each.

_See Also:_
[[How-do-I-upgrade-my-6-7-RI-with-a-6-8-DLL]]
