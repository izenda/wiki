[[_TOC_]]

#Question

I'm getting this error:

```csharp

ImageLoader - Cant load image from this URL: http://host/rs.aspx?image=dm_bar1.gif

Stacktrace:
at Dundas.Maps.WebControl.av.a(String , Boolean )
at Dundas.Maps.WebControl.Symbol.a(MapGraphics , RectangleF )
at Dundas.Maps.WebControl.Symbol.Dundas.Maps.WebControl.IContentElement.IsVisible(MapGraphics g, Layer layer, Boolean allLayers, RectangleF clipRect)
at Dundas.Maps.WebControl.MapCore.a(MapGraphics , Layer , Boolean , RectangleF , bo , Hashtable )
at Dundas.Maps.WebControl.MapCore.a(MapGraphics , PointF , bo )
at Dundas.Maps.WebControl.MapCore.b(MapGraphics )
at Dundas.Maps.WebControl.MapCore.a(Graphics , RenderingType , Stream , Boolean )
at Dundas.Maps.WebControl.MapCore.a(Stream , MapImageFormat , Int32 , Panel , Boolean )
at Dundas.Maps.WebControl.MapControl.SaveAsImage(Stream stream)
at Izenda.AdHoc.DundasMap.GenerateMapControl(Report report, AdHocDataTable formatResult)
at Izenda.Web.UI.HtmlReportRenderer.GenerateReportsControl()


```

#Answer

Make sure this setting is set:

[[AdHocSettings.DundasImagesPath|API/CodeSamples/DundasImagesPath]]

And point it towards this file:

[[dmi.zip|/FAQ/Cant-load-image-from-url-in-maps/dmi.zip]]
