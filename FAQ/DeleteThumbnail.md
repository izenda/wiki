#DeleteThumbnail()

[[_TOC_]]

##About

Allows customization for deleting forms associated with specific reports

##Global.asax (C♯)

```csharp
static Dictionary<string, byte[]> thumbnails = new Dictionary<string, byte[]>();

    public override void DeleteThumbnail(ReportInfo reportInfo)
    {
      if (thumbnails.ContainsKey((reportInfo.Category ?? "") + "#" + (reportInfo.Name ?? "")))
        thumbnails.Remove((reportInfo.Category ?? "") + "#" + (reportInfo.Name ?? ""));
    }
```

##Global.asax (VB.NET)

```visualbasic

```