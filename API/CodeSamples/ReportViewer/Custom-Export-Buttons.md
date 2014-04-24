#Creating a Custom Export Button

[[_TOC_]]

##Method

This code sample will allow you to place your own export buttons wherever you need them on your report viewer. This button uses our built-in PDF icon and is set to export to pdf. However, you can change but the **"src"** and **"&output=pdf"** properties to match whatever image and export type you wish to use, respectively.

```csharp
<img src="rs.aspx?image=pdf.gif" onclick="window.location='<%=string.Format("{0}?
    {1}&output=pdf",Request.ServerVariables["PATH_INFO"],Request.ServerVariables"QUERY_STRING"])%>'"
```