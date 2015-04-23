#ShowInvalidVizExportLink

[[_TOC_]]

##About

ShowInvalidVizExportLink is a boolean variable that determines whether the message "To view the interactive visualization please click this link." is displayed when charts of type visualization is exported to Word,Excel, and other document form. By default ShowInvalidVizExportLink is true. When the user set it to false then message "To view the interactive visualization please click this link." will not be shown.

##Global.asax (C♯)

```csharp
public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {

        
      AdHocSettings.ShowInvalidVizExportLink = false;
        

    } // End of InitializeReporting
   
   
  } // End of  CustomAdHocConfig
```

##Screenshots

![](/API/CodeSamples/ShowInvalidVizExportLink/ShowInvalidviz.png)