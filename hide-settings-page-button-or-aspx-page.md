#Hide Settings Page

##The Settings Button

If you want to hide the settings page button in the report designer and restrict it to only admin users, you will need to set the property shown below.

``Izenda.AdHoc.AdHocSettings.ShowAdminButton = false;``

##The Settings Page

If you want to restrict access to the page itself, _settings.aspx_, you can apply typical aspx page restrictions in the ``OnPageLoad()`` event, such as redirecting if the username or similar variable is not set to the required value.