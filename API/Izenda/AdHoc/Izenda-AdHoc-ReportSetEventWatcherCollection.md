#ReportSetEventWatcherCollection

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Int32|[[Capacity|http://msdn.microsoft.com/en-us/library/29z9bdyd]]|Gets or sets the number of elements that the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] can contain.|0|
|Int32|[[Count|http://msdn.microsoft.com/en-us/library/8beysaaa]]|Gets the number of elements contained in the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This property cannot be overridden.|0|
|IReportSetEventWatcher|[[Item|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_ReportSetEventWatcherCollection_Item_-_System_Int32_-_]]|Gets or sets the [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] in the collection at the specified index.|null|


##Methods

###Add(Izenda.AdHoc.IReportSetEventWatcher)
Appends the specified [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] to the end of the collection.

Parameters: 

* [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] value  - The [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] to append to the end of the collection.





Returns:

The System.Integer index of the new item.


---


###Clear()
Removes all objects from the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This method cannot be overridden.






---


###Contains(Izenda.AdHoc.IReportSetEventWatcher)
Determines if the collection contains the specified [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]].

Parameters: 

* [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] value  - The [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] to check for.





Returns:

True if the item was found, otherwise false.


---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetEnumerator()
Returns an enumerator that iterates through the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance.





Returns:

An [[System.Collections.IEnumerator|http://msdn.microsoft.com/en-us/library/1t2267t6]] for the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance.


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


###IndexOf(Izenda.AdHoc.IReportSetEventWatcher)
 Gets the System.Integer index of the target Izenda.AdHoc.IReportSetEventWatcher. 

Parameters: 

* [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] value  - The [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] to locate in the collection.





Returns:

The System.Integer index of the item that was located, or -1 if the item was not in the collection.


---


###Insert(System.Int32,Izenda.AdHoc.IReportSetEventWatcher)
Inserts the specified [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] into the collection at the specified index.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  - The System.Integer index to inssert the item into the collection at.
* [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] value  - The [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] to insert into the collection.






---


###PostExecuteReportSet(Izenda.AdHoc.ReportSet)
Executes all delegates added to the collection of event watchers after the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] is executed.

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is currently being executed.






---


###PostLoadReportSet(System.String,Izenda.AdHoc.ReportSet)
Executes all delegates added to the collection of event watchers after loading the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being loaded.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is currently being loaded.






---


###PostSaveReportSet(System.String,Izenda.AdHoc.ReportSet)
Executes all delegates added to the collection of event watchers after saving the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being saved.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is currently being saved.






---


###PreExecuteReportSet(Izenda.AdHoc.ReportSet)
 Executes all delegates added to the collection of event watchers before the reportset is executed. 

Parameters: 

* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is currently being executed.






---


###PreLoadReportSet(System.String)
Executes all delegates added to the collection of event watchers before loading the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being loaded.






---


###PreSaveReportSet(System.String,Izenda.AdHoc.ReportSet)
Executes all delegates added to the collection of event watchers before saving the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]].

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The name of the [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is being saved.
* [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] reportSet  - The [[Izenda.AdHoc.ReportSet|/API/Izenda/AdHoc/Izenda-AdHoc-ReportSet]] that is currently being saved.






---


###Remove(Izenda.AdHoc.IReportSetEventWatcher)
Removes the specified [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] from the collection.

Parameters: 

* [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] value  - The [[Izenda.AdHoc.IReportSetEventWatcher|/API/Izenda/AdHoc/Izenda-AdHoc-IReportSetEventWatcher]] to remove.






---


###RemoveAt(System.Int32)
Removes the element at the specified index of the [[System.Collections.CollectionBase|http://msdn.microsoft.com/en-us/library/7a03ybbb]] instance. This method is not overridable.

Parameters: 

* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] index  -  The zero-based index of the element to remove. 






---


###SetAdHocConfig(Izenda.AdHoc.AdHocConfig)
Sets the [[Izenda.AdHoc.AdHocConfig|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocConfig]] instance that will be used to process event watchers.

Parameters: 

* [[Izenda.AdHoc.AdHocConfig|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocConfig]] newConfig  - The [[Izenda.AdHoc.AdHocConfig|/API/Izenda/AdHoc/Izenda-AdHoc-AdHocConfig]] object to use to process event watchers.






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


