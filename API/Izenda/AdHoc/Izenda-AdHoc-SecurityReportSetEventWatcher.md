#SecurityReportSetEventWatcher

[[_TOC_]]

##Properties

None.


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###PostExecuteReportSet(Izenda.AdHoc.ReportSet)
 Executed after the ExecuteReportSet method is executed from the AdHocConfig. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to post-process.






---


###PostLoadReportSet(System.String,Izenda.AdHoc.ReportSet)
 Executed after the LoadReportSet method is finished executing from the AdHocConfig. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report name.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that was loaded.






---


###PostSaveReportSet(System.String,Izenda.AdHoc.ReportSet)
 Executed after the SaveReportSet method is finished executing from the AdHocConfig. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report name.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that was saved.






---


###PreExecuteReportSet(Izenda.AdHoc.ReportSet)
 Executed when the ExecuteReportSet method is called from the AdHocConfig. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that the hidden filters will be applied to.






---


###PreLoadReportSet(System.String)
 Executed when the LoadReportSet method is called from the AdHocConfig. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report name.






---


###PreSaveReportSet(System.String,Izenda.AdHoc.ReportSet)
 Executed when the SaveReportSet method is called from the AdHocConfig. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the report name.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] to save.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


