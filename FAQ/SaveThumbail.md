#SaveThumbnail()

[[_TOC_]]

##About

Allows customization of the process that saves the form attached to a report

##Global.asax (C♯)

```csharp
   static Dictionary<string, byte[]> thumbnails = new Dictionary<string, byte[]>();
    
    public override void SaveThumbnail(ReportInfo reportInfo, System.Drawing.Bitmap thumbnail)
    {
      byte[] thd;
      using (System.IO.MemoryStream ms = new System.IO.MemoryStream()) {
        thumbnail.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        thd = ms.ToArray();
      }
      thumbnails.Add((reportInfo.Category ?? "") + "#" + (reportInfo.Name ?? ""), thd);
    }
```

##Global.asax (VB.NET)

```visualbasic

```

**Note:** The overriden SaveThumbnail method must NOT contain anything which can trigger HttpContext.Current getter call, including reportInfo.FullName.