#Customizing the Settings Page

[[_TOC_]]

##About

Customizing the settings page is fairly straightforward. Due to its nature as a diagnostic page, there isn't a whole lot that can be changed about it. But if you need to integrate this page into your application, then you may need to change a few items.

##Placeholders

If you changed the PlaceHolders on the default.master or are using a different masterpage then you simply have to reflect those changes in the Settings.aspx code. The two placeholders on this page will need to mimic your masterpage's PlaceHolders.

##Path references

You may also need to change the path references in your application. By default, path references are prefixed with (~) to denote the root path. If your application uses a directory structure where the masterpage is not located in the root or where your reporting pages are nested in directories, then you will want to modify the path so the tilde is no longer used. You may require relative paths using reverse directory traversal (./) to properly reference your masterpage and the other reporting pages.