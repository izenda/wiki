#ThumbnailExists()

[[_TOC_]]

##About
Allows customization of the process that checks whether thumbnail pictures exist for reports

##Global.asax (C♯)

```csharp
    static Dictionary<string, byte[]> thumbnails = new Dictionary<string, byte[]>();

    public override bool ThumbnailExists(ReportInfo reportInfo)
    {
      return thumbnails.ContainsKey((reportInfo.Category ?? "") + "#" + (reportInfo.Name ?? ""));
    }
```

##Global.asax (VB.NET)

```visualbasic

```