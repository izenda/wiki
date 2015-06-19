#Open Custom URL In New Window

[[_TOC_]]

##Usage
OpenCustomURLInNewWindow controls whether or not the on-click action associated with the custom URL feature on the [advanced field settings](http://wiki.izenda.us/FAQ/advanced-field-settings) opens the link in a new browser tab or the current browser tab.

This setting is a boolean. It defaults to True.

true = Opens link in new browser tab.
false = Opens link in current browser tab.

```csharp
AdHocSettings.OpenCustomUrlInNewWindow = false;
```