#Common Security Variables

[[_TOC_]]

##Report Restriction

The Izenda [AdHocSettings class](http://wiki.izenda.us/API/AdHocSettings) is the heart of setting up security. Within it, there are a number of variables which will prove useful in creating dynamic security. Below is a list of the commonly used variables.

###[CurrentUserIsAdmin](http://wiki.izenda.us/API/CodeSamples/CurrentUserIsAdmin)

This determines if the user is an admin and is true by default. Note that admins ignore [share-with rights](http://wiki.izenda.us/FAQ/Questions/Using-Share-with-rights-roles-properties-in-Izenda-Reports-6#Shared-roles).  

###[CurrentUserName](http://wiki.izenda.us/API/CodeSamples/CurrentUserName)

This sets the current user's name which is used as the report author during report creation. Authors always have full rights to reports they create.

###[CurrentUserRoles](http://wiki.izenda.us/API/CodeSamples/CurrentUserRoles)

This is a string array that allows you to define a list of roles/groups the current user belongs to.

###[NumSharedDropdowns](http://wiki.izenda.us/API/CodeSamples/NumSharedDropdowns)

This tells Izenda how many rows should be displayed in the Shared-With drop down on in the [Misc. tab](http://wiki.izenda.us/FAQ/Questions/Using-Share-with-rights-roles-properties-in-Izenda-Reports-6#Shared-roles) of the Report Designer.

###[SharedWithValues](http://wiki.izenda.us/API/CodeSamples/SharedWithValues)

This tells Izenda which shared with roles to show in the Shared-With drop down on in the Misc. tab of the Report Designer.

###[CurrentUserTenantId](http://wiki.izenda.us/API/CodeSamples/CurrentUserTenantId)

This sets the current user's tenant ID. A user can only belong to one tenant.

###[HiddenCategories](http://wiki.izenda.us/API/CodeSamples/HiddenCategories)

This will hide an entire category of reports from a user

###[HiddenColumns](http://wiki.izenda.us/FAQ/Izenda-API-Tip-Hidden-Columns)

This will hide any column with the given name. Be sure to fully qualify column names so only the appropriate tables are impacted.

###[HiddenFilters](http://wiki.izenda.us/API/CodeSamples/HiddenFilters)

This will append an equals condition to any report that has the given column name with the value specified.

##Feature Restriction

###[ShowDesignLinks](http://wiki.izenda.us/API/CodeSamples/ShowDesignLinks)

This will removel the new button and the ability to save reports.

###[ShowDesignDashboardLink](http://wiki.izenda.us/API/CodeSamples/ShowDesignDashboardLink)

Removes links to the Dashboard Designer

###ShowNewButton

This will show or hide the expandable New button on the Izenda navigation bar.

###[ShowSettingsButton](http://wiki.izenda.us/API/CodeSamples/ShowSettingsButton)

This will show or hide the settings button on the report list page. A [redirect](http://wiki.izenda.us/Best-Practices/Security-Best-Practices) can be used to ensure that users can't reach this location by typing into the address bar.