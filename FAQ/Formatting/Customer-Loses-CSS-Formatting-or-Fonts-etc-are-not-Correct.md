#CSS Font/Formatting Loss

[[_TOC_]]

##Question

My customers are reporting their pages are not formatted with CSS properly. How can I fix this?

##Answer

This can be caused if your company distributes an application with reporting to customers without remote access to your CSS files. If this happens, you have a couple of options.

* **Settings.aspx:** You can check the CSS tab on the settings page to make sure that none of the CSS urls are using localhost in the URL or are pointing to an internal web server. The CSS settings must be accessible from a remote location in order for the CSS to work.

* **InitializeReporting():** You can set the corresponding settings for CSS URLs in the [[InitializeReporting|/FAQ/InitializeReporting]] method to the appropriate external server URLs as well.