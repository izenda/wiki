#How do I control the alignment of text fields or justification in report output?

[[_TOC_]]

##Controlling Alignment Through Settings.aspx

The justification or alignment can be controlled through the Izenda Reports settings.aspx page (v5.4 and up) by setting the "Show Justification" setting on the "Features" tab.   The justification of certain headers and titles will then be customizable in the report designer. Justification controls are clickable boxes that cycle through the three options (R, M, L).

##Controlling Alignment Through Code

The justification or alignment can also be set in your C# code using the following line in your ConfigureSettings() method.

```csharp
    AdHocSettings.ShowJustification = true;
```

Here is a list of where in the application you can find justification controls:

###The Fields Tab

In the advanced settings (the cog symbol to the right of the fields on each row) there exist two separate justification options.

* **Label Justification:** Adds justification to this field's header item.
* **Value Justification:** Adds justification to this field's data items.

###The Summary Tab

Also in the advanced settings, there exist two separate justification options.

* **Label Justification:** As the fields tab, except that it applies to the summary table.
* **Value Justification:** As the fields tab, except that it applies to the summary table.

###The Misc. Tab

There are a couple of different text boxes that have justification options.

* **Report Header Image Justification:** Adds justification to the report's header image.
* **Description:** Adds justification to the report's description.
* **Footer:** Adds justification to the report's footer.