#Upgrading existing 6.7 Reference Implementation with 6.8+ DLL

[[_TOC_]]

##Question
How do I upgrade my existing instance if Izenda (6.7 or older) to 6.8.0.1+?

##Answer
Do to the number of changes in the Reference Implementation, some extra precautions may be necessary to ensure proper upgrade processes.  

###  **If you are upgrading across point releases (Ex: 6.7.255-> 6.8.0.5)**

1) Preserve any customized files in the entire Izenda deployment - This is typically the global.asax, code-behind files, sometimes individual page code, CSS, HTML or JS.

2) Download an Izenda 'Full Download' that includes all files and pages.

3) Launch this 'vanilla' installation with only license key. You should be sent to the settings.aspx page to ask for a connection string.

4) Compare customized files from Step #1 to new updated files and merge over your customizations to the new files, starting with the global.asax and connection info (if contained somewhere besides the global). Move over customizations one at a time, testing each.

Full Download links can be found here- |http://www.izenda.com/update-your-izenda-version/ .  

For best results, it is recommended that you completely remove the existing bin and Resources folder from the current instance, and copy over the new bin and the new Resources folder.

###What if there is custom code in the existing Resources folder?
Izenda's Ad Hoc reporting platform allows for customization of the current CSS and JavaScript.  Many customers have made modifications to adopt branding, color schemes, etc.  Customers who have done this may be tempted to "merge" their existing Resources folder with the new Resources folder.  This is not a best practice, and may result in unwanted and unexpected behavior.  

As mentioned in step 1) the suggested solution to this is to keep your existing Resources off to the side, drop in the new Resources, and then copy your customizations to the new Resources folder one file at a time. This will ensure that the resources make it to the appropriate location.  To see the new layout of the Resources folder for 6.8.0.1+, refer to this Wiki [article](http://wiki.izenda.us/Whats-new-in-the-6-dot-8-0-dot-1-Reference-Implementation).

###The Default.master page
You will notice the [changes](http://wiki.izenda.us/Whats-new-in-the-6-dot-8-0-dot-1-Reference-Implementation) to the Reference Implementation includes slight modification to the Default.master page of Izenda.  The big difference is the rearrangement of the dependency chain.  It is optimized to better receive custom code changes to the main.css and main.js.  It also has paths to the new minified versions of the css files, *.min.css.  Though Izenda will still function properly with the previous Default.master, it is suggested that these changes be made to optimize the product.  You can find the new file for the Reference Implementation here- |https://github.com/izenda/reference-implementations/blob/webforms-cs/Default.master .  

###Important note for 6.8.0.4+
In an out-of-the-box Reference Implementation of 6.8.0.4+, you will notice that there is no Forms folder.  Customers who utilize our Forms add-on will now find the form resources in Resources/tinymce.  In 6.8.0.4+, there is no need for the Forms folder anymore.  In fact, you may get build errors if it is left in when upgrading to 6.8.0.4+.

_See Also:_ 
[[Izenda-Update-Best-Practices]] 