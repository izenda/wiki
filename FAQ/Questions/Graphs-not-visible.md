#Graphs Not Visible

[[_TOC_]]

##Question

Why are my graphs visible on my development server (local) but not on my production server (public)?

##Answer

The problem is that reports use a page to load the graph and that page's URL must be publicly available to users of Izenda Reports.  In your Global.asax file, find the [[InitializeReporting|/FAQ/InitializeReporting]] method and modify the [[ResponseServer|/API/CodeSamples/ResponseServer]] property so that it now reflects the absolute path of your **Response Server** page (rs.aspx).