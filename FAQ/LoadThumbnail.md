#LoadThumbnail()

[[_TOC_]]

##About

Allows customization of the process for loading report thumbnails 

##Global.asax (C♯)

```csharp
    static Dictionary<string, byte[]> thumbnails = new Dictionary<string, byte[]>();

    public override bool ThumbnailExists(ReportInfo reportInfo)
    {
      return thumbnails.ContainsKey((reportInfo.Category ?? "") + "#" + (reportInfo.Name ?? ""));
    }

    public override byte[] LoadThumbnail(ReportInfo reportInfo)
    {
      if (thumbnails.ContainsKey((reportInfo.Category ?? "") + "#" + (reportInfo.Name ?? "")))
        return thumbnails[(reportInfo.Category ?? "") + "#" + (reportInfo.Name ?? "")];
      return new byte[0];
    }
```

##Global.asax (VB.NET)

```visualbasic

```