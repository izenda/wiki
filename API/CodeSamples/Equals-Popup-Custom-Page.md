#Equals(Popup) Custom Pages

[[_TOC_]]

##About

In order to use the [[EqualsPopupDestinations|/API/CodeSamples/EqualsPopupDestinations]] setting and the [[FiltersCustomPagesPath|/API/CodeSamples/FiltersCustomPagesPath]] settings, there is a procedure you must follow to get the reporting application to communicate with your custom page. More information about the above settings can be found on their respective pages.

##Using Equals(PopUp) with custom pages

To implement custom filters page you need to perform following steps:

1. Create a separate folder in the root reporting directory for custom filters pages (say, "CustomFilters"), and set it in your AdHocSettings:
    `AdHocSettings.FiltersCustomPagesPath =  "CustomFilters";`

2. Now set the relationship between your custom filters page and the columns you will be using. You can assign several fields to the single custom filters page:

    `AdHocSettings.EqualsPopupDestinations["MyCustomFilter"] = new string[] { "Col1", "Col2", "ProductName", "CategoryName" };`

3. Get the CustomFiltersTemplate page (.aspx and .aspx.cs files), which we can provide for you, and rename it to MyCustomFilter. Then you can paste it into the CustomFilters folder. Below is a screenshot demonstrating this with the default template name.
![](http://wiki.izenda.us/API/CodeSamples/Equals-Popup-Custom-Page/customfilters.png)
4. In the MyCustomFilter.aspx page, add necessary controls between following lines:
```html
    <!--Here is block with custom controls-->

    <!--Here is block with custom controls-->
```
5. In the **MyCustomFilter.aspx.cs** file, locate the **WriteCustomControlsValues** method. It is called when the custom filters page is opened and should automatically obtain the existing values for that column from the application. In this method you should add code that updates your custom page's controls with the filtering values sent from the report designer:
```csharp
    private void WriteCustomControlsValues(string columnName, string[] oldValues)
    {
      //In this method custom controls must be created and filled with old values
      _CODE_HERE_
    }
```
6. In the **MyCustomFilter.aspx.cs** file, locate the **ReadCustomControlsValues** method. It is called when user clicks "OK". Values from your custom page's controls should be passed to the ReportDesigner. In this method you should add code that gathers values from your controls and updates the list of strings with those values:
```csharp
    private void ReadCustomControlsValues(ref List<string> selected)
    {
	  //In this method list of new values must be returned
      _YOUR_CODE_HERE_
    }
```
7. Launch Izenda Reports, go to the Report Designer - Filters tab, select one of the fields assigned to your custom filtering page, select the Equals(PopUp) operator, and click the "..." button. You should see the custom aspx page popup and start being able to select values for your filter. Below is a screenshot of the results of the CustomFilterTemplate.
![](http://wiki.izenda.us/API/CodeSamples/Equals-Popup-Custom-Page/equals_popup_page.png)