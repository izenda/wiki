#ReportingService2005

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Boolean|[[AllowAutoRedirect|http://msdn.microsoft.com/en-us/library/t21skb3a]]| Gets or sets whether the client automatically follows server redirects. |False|
|BatchHeader|[[BatchHeaderValue|/API/Microsoft/SqlServer/ReportingServices2005/CodeSamples/Microsoft_SqlServer_ReportingServices2005_ReportingService2005_BatchHeaderValue]]||null|
|X509CertificateCollection|[[ClientCertificates|http://msdn.microsoft.com/en-us/library/5ksz104t]]| Gets the collection of client certificates. |{}|
|String|[[ConnectionGroupName|http://msdn.microsoft.com/en-us/library/yacf58w5]]| Gets or sets the name of the connection group for the request. |String.Empty|
|IContainer|[[Container|http://msdn.microsoft.com/en-us/library/3c1xtx35]]|Gets the [[System.ComponentModel.IContainer|http://msdn.microsoft.com/en-us/library/z7xdfy67]] that contains the [[System.ComponentModel.Component|http://msdn.microsoft.com/en-us/library/9wbadbce]].|null|
|CookieContainer|[[CookieContainer|http://msdn.microsoft.com/en-us/library/yta0fyx9]]| Gets or sets the collection of cookies. |null|
|ICredentials|[[Credentials|http://msdn.microsoft.com/en-us/library/wy3y46yx]]| Gets or sets security credentials for XML Web service client authentication. |null|
|Boolean|[[EnableDecompression|http://msdn.microsoft.com/en-us/library/ms152747]]|Gets or sets a [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] that indicates whether decompression is enabled for this [[System.Web.Services.Protocols.HttpWebClientProtocol|http://msdn.microsoft.com/en-us/library/bte025xh]].|False|
|ItemNamespaceHeader|[[ItemNamespaceHeaderValue|/API/Microsoft/SqlServer/ReportingServices2005/CodeSamples/Microsoft_SqlServer_ReportingServices2005_ReportingService2005_ItemNamespaceHeaderValue]]||null|
|Boolean|[[PreAuthenticate|http://msdn.microsoft.com/en-us/library/7y03t9d1]]| Gets or sets whether pre-authentication is enabled. |False|
|IWebProxy|[[Proxy|http://msdn.microsoft.com/en-us/library/dxt28dkt]]| Gets or sets proxy information for making an XML Web service request through a firewall. |null|
|Encoding|[[RequestEncoding|http://msdn.microsoft.com/en-us/library/5f41612z]]|The [[System.Text.Encoding|http://msdn.microsoft.com/en-us/library/86hf4sb8]] used to make the client request to the XML Web service.|null|
|ServerInfoHeader|[[ServerInfoHeaderValue|/API/Microsoft/SqlServer/ReportingServices2005/CodeSamples/Microsoft_SqlServer_ReportingServices2005_ReportingService2005_ServerInfoHeaderValue]]||null|
|ISite|[[Site|http://msdn.microsoft.com/en-us/library/1fycyexx]]|Gets or sets the [[System.ComponentModel.ISite|http://msdn.microsoft.com/en-us/library/bafktt51]] of the [[System.ComponentModel.Component|http://msdn.microsoft.com/en-us/library/9wbadbce]].|null|
|SoapProtocolVersion|[[SoapVersion|http://msdn.microsoft.com/en-us/library/yc4x78y0]]| Gets or sets the version of the SOAP protocol used to make the SOAP request to the XML Web service. |Default|
|Int32|[[Timeout|http://msdn.microsoft.com/en-us/library/x881ethf]]| Indicates the time an XML Web service client waits for a synchronous XML Web service request to complete (in milliseconds). |100000|
|Boolean|[[UnsafeAuthenticatedConnectionSharing|http://msdn.microsoft.com/en-us/library/2hc19cat]]| Gets or sets a value that indicates whether connection sharing is enabled when the client uses NTLM authentication to connect to the Web server that hosts the XML Web service. |False|
|String|[[Url|http://msdn.microsoft.com/en-us/library/w2dk0twy]]| Gets or sets the base URL of the XML Web service the client is requesting. |http://localhost/ReportServer/ReportService2005.asmx|
|Boolean|[[UseDefaultCredentials|http://msdn.microsoft.com/en-us/library/ms152953]]|Gets or sets a value that indicates whether to set the [[Credentials|http://msdn.microsoft.com/en-us/library/wy3y46yx]] property to the value of the System.Net.CredentialCache.DefaultCredentials property.|False|
|String|[[UserAgent|http://msdn.microsoft.com/en-us/library/h4w95t4t]]| Gets or sets the value for the user agent header that is sent with each request. |Mozilla/4.0 (compatible; MSIE 6.0; MS Web Services Client Protocol 4.0.30319.42000)|


##Methods

###Abort()
 Cancels a request to an XML Web service method. 






---


###BeginCancelBatch(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCancelJob(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JobID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateBatch(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateDataDrivenSubscription(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateDataSource(System.String,System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition,Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceDefinition]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateFolder(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Folder 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateLinkedReport(System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Link 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateModel(System.String,System.String,System.Byte[],Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateReport(System.String,System.String,System.Boolean,System.Byte[],Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateReportHistorySnapshot(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateResource(System.String,System.String,System.Boolean,System.Byte[],System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Contents 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateRole(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Task[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[Microsoft.SqlServer.ReportingServices2005.Task[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Task[]]] Tasks 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateSchedule(System.String,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinition]] ScheduleDefinition 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginCreateSubscription(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValue[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginDeleteItem(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginDeleteReportHistorySnapshot(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HistoryID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginDeleteRole(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginDeleteSchedule(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginDeleteSubscription(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginDisableDataSource(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginEnableDataSource(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginExecuteBatch(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginFindItems(System.String,Microsoft.SqlServer.ReportingServices2005.BooleanOperatorEnum,Microsoft.SqlServer.ReportingServices2005.SearchCondition[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Folder 
* [[Microsoft.SqlServer.ReportingServices2005.BooleanOperatorEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-BooleanOperatorEnum]] BooleanOperator 
* [[Microsoft.SqlServer.ReportingServices2005.SearchCondition[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SearchCondition[]]] Conditions 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginFireEvent(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventData 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginFlushCache(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGenerateModel(System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetCacheOptions(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetDataDrivenSubscriptionProperties(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataDrivenSubscriptionID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetDataSourceContents(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetExecutionOptions(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetExtensionSettings(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Extension 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetItemDataSourcePrompts(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetItemDataSources(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetItemType(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetModelDefinition(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetModelItemPermissions(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetModelItemPolicies(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetPermissions(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetPolicies(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetProperties(System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetRenderResource(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Format 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DeviceInfo 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetReportDefinition(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetReportHistoryLimit(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetReportHistoryOptions(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetReportLink(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetReportParameters(System.String,System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ParameterValue[],Microsoft.SqlServer.ReportingServices2005.DataSourceCredentials[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HistoryID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] ForRendering 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Values 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceCredentials[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceCredentials[]]] Credentials 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetResourceContents(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetRoleProperties(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetScheduleProperties(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetSubscriptionProperties(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetSystemPermissions(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetSystemPolicies(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetSystemProperties(Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginGetUserModel(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Perspective 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginInheritModelItemParentSecurity(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginInheritParentSecurity(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListChildren(System.String,System.Boolean,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Recursive 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListDependentItems(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListEvents(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListExtensions(Microsoft.SqlServer.ReportingServices2005.ExtensionTypeEnum,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.ExtensionTypeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionTypeEnum]] ExtensionType 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListJobs(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListModelDrillthroughReports(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListModelItemChildren(System.String,System.String,System.Boolean,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Recursive 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListModelPerspectives(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListReportHistory(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListRoles(Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SecurityScopeEnum]] SecurityScope 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListScheduledReports(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListSchedules(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListSecureMethods(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListSubscriptions(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Owner 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListSubscriptionsUsingDataSource(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginListTasks(Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SecurityScopeEnum]] SecurityScope 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginLogoff(System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginLogonUser(System.String,System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] userName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] password 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] authority 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginMoveItem(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Target 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginPauseSchedule(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginPrepareQuery(Microsoft.SqlServer.ReportingServices2005.DataSource,Microsoft.SqlServer.ReportingServices2005.DataSetDefinition,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.DataSource|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSource]] DataSource 
* [[Microsoft.SqlServer.ReportingServices2005.DataSetDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSetDefinition]] DataSet 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginRegenerateModel(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginRemoveAllModelItemPolicies(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginResumeSchedule(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetCacheOptions(System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] CacheReport 
* [[Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExpirationDefinition]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetDataDrivenSubscriptionProperties(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataDrivenSubscriptionID 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetDataSourceContents(System.String,Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceDefinition]] Definition 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetExecutionOptions(System.String,Microsoft.SqlServer.ReportingServices2005.ExecutionSettingEnum,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExecutionSettingEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExecutionSettingEnum]] ExecutionSetting 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetItemDataSources(System.String,Microsoft.SqlServer.ReportingServices2005.DataSource[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.DataSource[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSource[]]] DataSources 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetModelDefinition(System.String,System.Byte[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetModelDrillthroughReports(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ModelDrillthroughReport[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[Microsoft.SqlServer.ReportingServices2005.ModelDrillthroughReport[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ModelDrillthroughReport[]]] Reports 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetModelItemPolicies(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Policy[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetPolicies(System.String,Microsoft.SqlServer.ReportingServices2005.Policy[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetProperties(System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetReportDefinition(System.String,System.Byte[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetReportHistoryLimit(System.String,System.Boolean,System.Int32,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] UseSystem 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] HistoryLimit 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetReportHistoryOptions(System.String,System.Boolean,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] EnableManualSnapshotCreation 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] KeepExecutionSnapshots 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetReportLink(System.String,System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Link 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetReportParameters(System.String,Microsoft.SqlServer.ReportingServices2005.ReportParameter[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ReportParameter[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ReportParameter[]]] Parameters 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetResourceContents(System.String,System.Byte[],System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Contents 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetRoleProperties(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Task[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[Microsoft.SqlServer.ReportingServices2005.Task[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Task[]]] Tasks 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetScheduleProperties(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinition]] ScheduleDefinition 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetSubscriptionProperties(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValue[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetSystemPolicies(Microsoft.SqlServer.ReportingServices2005.Policy[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginSetSystemProperties(Microsoft.SqlServer.ReportingServices2005.Property[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginUpdateReportExecutionSnapshot(System.String,System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###BeginValidateExtensionSettings(System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[],System.AsyncCallback,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Extension 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] ParameterValues 
* [[System.AsyncCallback|http://msdn.microsoft.com/en-us/library/ckbe7yh5]] callback 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] asyncState 






---


###CancelAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CancelBatch()
<remarks />






---


###CancelBatchAsync()
<remarks />






---


###CancelBatchAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CancelJob(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JobID 






---


###CancelJobAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JobID 






---


###CancelJobAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] JobID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateBatch()
<remarks />






---


###CreateBatchAsync()
<remarks />






---


###CreateBatchAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateDataDrivenSubscription(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 






---


###CreateDataDrivenSubscriptionAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 






---


###CreateDataDrivenSubscriptionAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateDataSource(System.String,System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceDefinition]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateDataSourceAsync(System.String,System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceDefinition]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateDataSourceAsync(System.String,System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition,Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceDefinition]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateFolder(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Folder 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateFolderAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Folder 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateFolderAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Folder 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateLinkedReport(System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Link 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateLinkedReportAsync(System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Link 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateLinkedReportAsync(System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Link 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateModel(System.String,System.String,System.Byte[],Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateModelAsync(System.String,System.String,System.Byte[],Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateModelAsync(System.String,System.String,System.Byte[],Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateObjRef(System.Type)
 Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object. 

Parameters: 

* [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] requestedType  - The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the object that the new [[System.Runtime.Remoting.ObjRef|http://msdn.microsoft.com/en-us/library/e8hw2eba]] will reference.





Returns:

 Information required to generate a proxy. 


---


###CreateReport(System.String,System.String,System.Boolean,System.Byte[],Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateReportAsync(System.String,System.String,System.Boolean,System.Byte[],Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateReportAsync(System.String,System.String,System.Boolean,System.Byte[],Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateReportHistorySnapshot(System.String,out Microsoft.SqlServer.ReportingServices2005.Warning[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* out [[Microsoft.SqlServer.ReportingServices2005.Warning[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Warning[]]] Warnings 






---


###CreateReportHistorySnapshotAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###CreateReportHistorySnapshotAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateResource(System.String,System.String,System.Boolean,System.Byte[],System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Contents 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateResourceAsync(System.String,System.String,System.Boolean,System.Byte[],System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Contents 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###CreateResourceAsync(System.String,System.String,System.Boolean,System.Byte[],System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Overwrite 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Contents 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateRole(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Task[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[Microsoft.SqlServer.ReportingServices2005.Task[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Task[]]] Tasks 






---


###CreateRoleAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Task[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[Microsoft.SqlServer.ReportingServices2005.Task[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Task[]]] Tasks 






---


###CreateRoleAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Task[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[Microsoft.SqlServer.ReportingServices2005.Task[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Task[]]] Tasks 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateSchedule(System.String,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinition]] ScheduleDefinition 






---


###CreateScheduleAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinition]] ScheduleDefinition 






---


###CreateScheduleAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinition]] ScheduleDefinition 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###CreateSubscription(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValue[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 






---


###CreateSubscriptionAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValue[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 






---


###CreateSubscriptionAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValue[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###DeleteItem(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###DeleteItemAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###DeleteItemAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###DeleteReportHistorySnapshot(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HistoryID 






---


###DeleteReportHistorySnapshotAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HistoryID 






---


###DeleteReportHistorySnapshotAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HistoryID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###DeleteRole(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 






---


###DeleteRoleAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 






---


###DeleteRoleAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###DeleteSchedule(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###DeleteScheduleAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###DeleteScheduleAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###DeleteSubscription(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 






---


###DeleteSubscriptionAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 






---


###DeleteSubscriptionAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###DisableDataSource(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 






---


###DisableDataSourceAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 






---


###DisableDataSourceAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###Discover()
Dynamically binds to an XML Web service described in the discovery document at [[Url|http://msdn.microsoft.com/en-us/library/w2dk0twy]].






---


###Dispose()
Releases all resources used by the [[System.ComponentModel.Component|http://msdn.microsoft.com/en-us/library/9wbadbce]].






---


###EnableDataSource(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 






---


###EnableDataSourceAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 






---


###EnableDataSourceAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###EndCancelBatch(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCancelJob(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateBatch(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateDataDrivenSubscription(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateDataSource(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateFolder(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateLinkedReport(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateModel(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateReport(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateReportHistorySnapshot(System.IAsyncResult,out Microsoft.SqlServer.ReportingServices2005.Warning[])
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[Microsoft.SqlServer.ReportingServices2005.Warning[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Warning[]]] Warnings 






---


###EndCreateResource(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateRole(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateSchedule(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndCreateSubscription(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndDeleteItem(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndDeleteReportHistorySnapshot(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndDeleteRole(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndDeleteSchedule(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndDeleteSubscription(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndDisableDataSource(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndEnableDataSource(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndExecuteBatch(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndFindItems(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndFireEvent(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndFlushCache(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGenerateModel(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetCacheOptions(System.IAsyncResult,out Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExpirationDefinition]] Item 






---


###EndGetDataDrivenSubscriptionProperties(System.IAsyncResult,out Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,out Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,out System.String,out Microsoft.SqlServer.ReportingServices2005.ActiveState,out System.String,out System.String,out System.String,out Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[])
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* out [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* out [[Microsoft.SqlServer.ReportingServices2005.ActiveState|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ActiveState]] Active 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Status 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* out [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 






---


###EndGetDataSourceContents(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetExecutionOptions(System.IAsyncResult,out Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 






---


###EndGetExtensionSettings(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetItemDataSourcePrompts(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetItemDataSources(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetItemType(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetModelDefinition(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetModelItemPermissions(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetModelItemPolicies(System.IAsyncResult,out System.Boolean)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] InheritParent 






---


###EndGetPermissions(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetPolicies(System.IAsyncResult,out System.Boolean)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] InheritParent 






---


###EndGetProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetRenderResource(System.IAsyncResult,out System.String)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 






---


###EndGetReportDefinition(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetReportHistoryLimit(System.IAsyncResult,out System.Boolean,out System.Int32)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] IsSystem 
* out [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] SystemLimit 






---


###EndGetReportHistoryOptions(System.IAsyncResult,out System.Boolean,out Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] KeepExecutionSnapshots 
* out [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 






---


###EndGetReportLink(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetReportParameters(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetResourceContents(System.IAsyncResult,out System.String)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 






---


###EndGetRoleProperties(System.IAsyncResult,out System.String)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 






---


###EndGetScheduleProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetSubscriptionProperties(System.IAsyncResult,out Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,out System.String,out Microsoft.SqlServer.ReportingServices2005.ActiveState,out System.String,out System.String,out System.String,out Microsoft.SqlServer.ReportingServices2005.ParameterValue[])
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* out [[Microsoft.SqlServer.ReportingServices2005.ActiveState|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ActiveState]] Active 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Status 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* out [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 






---


###EndGetSystemPermissions(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetSystemPolicies(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetSystemProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndGetUserModel(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndInheritModelItemParentSecurity(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndInheritParentSecurity(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListChildren(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListDependentItems(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListEvents(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListExtensions(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListJobs(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListModelDrillthroughReports(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListModelItemChildren(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListModelPerspectives(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListReportHistory(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListRoles(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListScheduledReports(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListSchedules(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListSecureMethods(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListSubscriptions(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListSubscriptionsUsingDataSource(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndListTasks(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndLogoff(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndLogonUser(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndMoveItem(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndPauseSchedule(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndPrepareQuery(System.IAsyncResult,out System.Boolean,out System.String[])
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Changed 
* out [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ParameterNames 






---


###EndRegenerateModel(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndRemoveAllModelItemPolicies(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndResumeSchedule(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetCacheOptions(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetDataDrivenSubscriptionProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetDataSourceContents(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetExecutionOptions(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetItemDataSources(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetModelDefinition(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetModelDrillthroughReports(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetModelItemPolicies(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetPolicies(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetReportDefinition(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetReportHistoryLimit(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetReportHistoryOptions(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetReportLink(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetReportParameters(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetResourceContents(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetRoleProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetScheduleProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetSubscriptionProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetSystemPolicies(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndSetSystemProperties(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndUpdateReportExecutionSnapshot(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###EndValidateExtensionSettings(System.IAsyncResult)
<remarks />

Parameters: 

* [[System.IAsyncResult|http://msdn.microsoft.com/en-us/library/ft8a6455]] asyncResult 






---


###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###ExecuteBatch()
<remarks />






---


###ExecuteBatchAsync()
<remarks />






---


###ExecuteBatchAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###FindItems(System.String,Microsoft.SqlServer.ReportingServices2005.BooleanOperatorEnum,Microsoft.SqlServer.ReportingServices2005.SearchCondition[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Folder 
* [[Microsoft.SqlServer.ReportingServices2005.BooleanOperatorEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-BooleanOperatorEnum]] BooleanOperator 
* [[Microsoft.SqlServer.ReportingServices2005.SearchCondition[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SearchCondition[]]] Conditions 






---


###FindItemsAsync(System.String,Microsoft.SqlServer.ReportingServices2005.BooleanOperatorEnum,Microsoft.SqlServer.ReportingServices2005.SearchCondition[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Folder 
* [[Microsoft.SqlServer.ReportingServices2005.BooleanOperatorEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-BooleanOperatorEnum]] BooleanOperator 
* [[Microsoft.SqlServer.ReportingServices2005.SearchCondition[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SearchCondition[]]] Conditions 






---


###FindItemsAsync(System.String,Microsoft.SqlServer.ReportingServices2005.BooleanOperatorEnum,Microsoft.SqlServer.ReportingServices2005.SearchCondition[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Folder 
* [[Microsoft.SqlServer.ReportingServices2005.BooleanOperatorEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-BooleanOperatorEnum]] BooleanOperator 
* [[Microsoft.SqlServer.ReportingServices2005.SearchCondition[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SearchCondition[]]] Conditions 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###FireEvent(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventData 






---


###FireEventAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventData 






---


###FireEventAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventData 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###FlushCache(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###FlushCacheAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###FlushCacheAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GenerateModel(System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###GenerateModelAsync(System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###GenerateModelAsync(System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Parent 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetCacheOptions(System.String,out Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* out [[Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExpirationDefinition]] Item 






---


###GetCacheOptionsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###GetCacheOptionsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetDataDrivenSubscriptionProperties(System.String,out Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,out Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,out System.String,out Microsoft.SqlServer.ReportingServices2005.ActiveState,out System.String,out System.String,out System.String,out Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataDrivenSubscriptionID 
* out [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* out [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* out [[Microsoft.SqlServer.ReportingServices2005.ActiveState|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ActiveState]] Active 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Status 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* out [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 






---


###GetDataDrivenSubscriptionPropertiesAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataDrivenSubscriptionID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetDataDrivenSubscriptionPropertiesAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataDrivenSubscriptionID 






---


###GetDataSourceContents(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 






---


###GetDataSourceContentsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 






---


###GetDataSourceContentsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetExecutionOptions(System.String,out Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* out [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 






---


###GetExecutionOptionsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###GetExecutionOptionsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetExtensionSettings(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Extension 






---


###GetExtensionSettingsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Extension 






---


###GetExtensionSettingsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Extension 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetItemDataSourcePrompts(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetItemDataSourcePromptsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetItemDataSourcePromptsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetItemDataSources(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetItemDataSourcesAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetItemDataSourcesAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetItemType(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetItemTypeAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetItemTypeAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetLifetimeService()
 Retrieves the current lifetime service object that controls the lifetime policy for this instance. 





Returns:

An object of type [[System.Runtime.Remoting.Lifetime.ILease|http://msdn.microsoft.com/en-us/library/fs2dtxyz]] used to control the lifetime policy for this instance.


---


###GetModelDefinition(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 






---


###GetModelDefinitionAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 






---


###GetModelDefinitionAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetModelItemPermissions(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 






---


###GetModelItemPermissionsAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 






---


###GetModelItemPermissionsAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetModelItemPolicies(System.String,System.String,out System.Boolean)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] InheritParent 






---


###GetModelItemPoliciesAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 






---


###GetModelItemPoliciesAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetPermissions(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetPermissionsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetPermissionsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetPolicies(System.String,out System.Boolean)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] InheritParent 






---


###GetPoliciesAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###GetPoliciesAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetProperties(System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###GetPropertiesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###GetPropertiesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetRenderResource(System.String,System.String,out System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Format 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DeviceInfo 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 






---


###GetRenderResourceAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Format 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DeviceInfo 






---


###GetRenderResourceAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Format 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DeviceInfo 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetReportDefinition(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###GetReportDefinitionAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###GetReportDefinitionAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetReportHistoryLimit(System.String,out System.Boolean,out System.Int32)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] IsSystem 
* out [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] SystemLimit 






---


###GetReportHistoryLimitAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###GetReportHistoryLimitAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetReportHistoryOptions(System.String,out System.Boolean,out Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] KeepExecutionSnapshots 
* out [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 






---


###GetReportHistoryOptionsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###GetReportHistoryOptionsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetReportLink(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###GetReportLinkAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###GetReportLinkAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetReportParameters(System.String,System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ParameterValue[],Microsoft.SqlServer.ReportingServices2005.DataSourceCredentials[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HistoryID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] ForRendering 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Values 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceCredentials[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceCredentials[]]] Credentials 






---


###GetReportParametersAsync(System.String,System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ParameterValue[],Microsoft.SqlServer.ReportingServices2005.DataSourceCredentials[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HistoryID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] ForRendering 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Values 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceCredentials[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceCredentials[]]] Credentials 






---


###GetReportParametersAsync(System.String,System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ParameterValue[],Microsoft.SqlServer.ReportingServices2005.DataSourceCredentials[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] HistoryID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] ForRendering 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Values 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceCredentials[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceCredentials[]]] Credentials 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetResourceContents(System.String,out System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 






---


###GetResourceContentsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 






---


###GetResourceContentsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetRoleProperties(System.String,out System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 






---


###GetRolePropertiesAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 






---


###GetRolePropertiesAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetScheduleProperties(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###GetSchedulePropertiesAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###GetSchedulePropertiesAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetSubscriptionProperties(System.String,out Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,out System.String,out Microsoft.SqlServer.ReportingServices2005.ActiveState,out System.String,out System.String,out System.String,out Microsoft.SqlServer.ReportingServices2005.ParameterValue[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* out [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* out [[Microsoft.SqlServer.ReportingServices2005.ActiveState|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ActiveState]] Active 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Status 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* out [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 






---


###GetSubscriptionPropertiesAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 






---


###GetSubscriptionPropertiesAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetSystemPermissions()
<remarks />






---


###GetSystemPermissionsAsync()
<remarks />






---


###GetSystemPermissionsAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetSystemPolicies()
<remarks />






---


###GetSystemPoliciesAsync()
<remarks />






---


###GetSystemPoliciesAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetSystemProperties(Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###GetSystemPropertiesAsync(Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###GetSystemPropertiesAsync(Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###GetUserModel(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Perspective 






---


###GetUserModelAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Perspective 






---


###GetUserModelAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Perspective 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###InheritModelItemParentSecurity(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 






---


###InheritModelItemParentSecurityAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 






---


###InheritModelItemParentSecurityAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###InheritParentSecurity(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###InheritParentSecurityAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###InheritParentSecurityAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###InitializeLifetimeService()
 Obtains a lifetime service object to control the lifetime policy for this instance. 





Returns:

An object of type [[System.Runtime.Remoting.Lifetime.ILease|http://msdn.microsoft.com/en-us/library/fs2dtxyz]] used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the [[LeaseManagerPollTime|http://msdn.microsoft.com/en-us/library/sb08yz81]] property.


---


###ListChildren(System.String,System.Boolean)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Recursive 






---


###ListChildrenAsync(System.String,System.Boolean)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Recursive 






---


###ListChildrenAsync(System.String,System.Boolean,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Recursive 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListDependentItems(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###ListDependentItemsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 






---


###ListDependentItemsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListEvents()
<remarks />






---


###ListEventsAsync()
<remarks />






---


###ListEventsAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListExtensions(Microsoft.SqlServer.ReportingServices2005.ExtensionTypeEnum)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.ExtensionTypeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionTypeEnum]] ExtensionType 






---


###ListExtensionsAsync(Microsoft.SqlServer.ReportingServices2005.ExtensionTypeEnum)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.ExtensionTypeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionTypeEnum]] ExtensionType 






---


###ListExtensionsAsync(Microsoft.SqlServer.ReportingServices2005.ExtensionTypeEnum,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.ExtensionTypeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionTypeEnum]] ExtensionType 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListJobs()
<remarks />






---


###ListJobsAsync()
<remarks />






---


###ListJobsAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListModelDrillthroughReports(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 






---


###ListModelDrillthroughReportsAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 






---


###ListModelDrillthroughReportsAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListModelItemChildren(System.String,System.String,System.Boolean)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Recursive 






---


###ListModelItemChildrenAsync(System.String,System.String,System.Boolean)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Recursive 






---


###ListModelItemChildrenAsync(System.String,System.String,System.Boolean,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Recursive 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListModelPerspectives(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 






---


###ListModelPerspectivesAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 






---


###ListModelPerspectivesAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListReportHistory(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###ListReportHistoryAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###ListReportHistoryAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListRoles(Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SecurityScopeEnum]] SecurityScope 






---


###ListRolesAsync(Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SecurityScopeEnum]] SecurityScope 






---


###ListRolesAsync(Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SecurityScopeEnum]] SecurityScope 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListScheduledReports(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###ListScheduledReportsAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###ListScheduledReportsAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListSchedules()
<remarks />






---


###ListSchedulesAsync()
<remarks />






---


###ListSchedulesAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListSecureMethods()
<remarks />






---


###ListSecureMethodsAsync()
<remarks />






---


###ListSecureMethodsAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListSubscriptions(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Owner 






---


###ListSubscriptionsAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Owner 






---


###ListSubscriptionsAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Owner 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListSubscriptionsUsingDataSource(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 






---


###ListSubscriptionsUsingDataSourceAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 






---


###ListSubscriptionsUsingDataSourceAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ListTasks(Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SecurityScopeEnum]] SecurityScope 






---


###ListTasksAsync(Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SecurityScopeEnum]] SecurityScope 






---


###ListTasksAsync(Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.SecurityScopeEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-SecurityScopeEnum]] SecurityScope 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###Logoff()
<remarks />






---


###LogoffAsync()
<remarks />






---


###LogoffAsync(System.Object)
<remarks />

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###LogonUser(System.String,System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] userName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] password 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] authority 






---


###LogonUserAsync(System.String,System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] userName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] password 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] authority 






---


###LogonUserAsync(System.String,System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] userName 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] password 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] authority 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###MoveItem(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Target 






---


###MoveItemAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Target 






---


###MoveItemAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Target 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###PauseSchedule(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###PauseScheduleAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###PauseScheduleAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###PrepareQuery(Microsoft.SqlServer.ReportingServices2005.DataSource,Microsoft.SqlServer.ReportingServices2005.DataSetDefinition,out System.Boolean,out System.String[])
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.DataSource|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSource]] DataSource 
* [[Microsoft.SqlServer.ReportingServices2005.DataSetDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSetDefinition]] DataSet 
* out [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] Changed 
* out [[System.String[]|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ParameterNames 






---


###PrepareQueryAsync(Microsoft.SqlServer.ReportingServices2005.DataSource,Microsoft.SqlServer.ReportingServices2005.DataSetDefinition)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.DataSource|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSource]] DataSource 
* [[Microsoft.SqlServer.ReportingServices2005.DataSetDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSetDefinition]] DataSet 






---


###PrepareQueryAsync(Microsoft.SqlServer.ReportingServices2005.DataSource,Microsoft.SqlServer.ReportingServices2005.DataSetDefinition,System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.DataSource|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSource]] DataSource 
* [[Microsoft.SqlServer.ReportingServices2005.DataSetDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSetDefinition]] DataSet 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###RegenerateModel(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 






---


###RegenerateModelAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 






---


###RegenerateModelAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###RemoveAllModelItemPolicies(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 






---


###RemoveAllModelItemPoliciesAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 






---


###RemoveAllModelItemPoliciesAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ResumeSchedule(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###ResumeScheduleAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 






---


###ResumeScheduleAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetCacheOptions(System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] CacheReport 
* [[Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExpirationDefinition]] Item 






---


###SetCacheOptionsAsync(System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] CacheReport 
* [[Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExpirationDefinition]] Item 






---


###SetCacheOptionsAsync(System.String,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] CacheReport 
* [[Microsoft.SqlServer.ReportingServices2005.ExpirationDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExpirationDefinition]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetDataDrivenSubscriptionProperties(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataDrivenSubscriptionID 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 






---


###SetDataDrivenSubscriptionPropertiesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataDrivenSubscriptionID 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 






---


###SetDataDrivenSubscriptionPropertiesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataDrivenSubscriptionID 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[Microsoft.SqlServer.ReportingServices2005.DataRetrievalPlan|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataRetrievalPlan]] DataRetrievalPlan 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] Parameters 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetDataSourceContents(System.String,Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceDefinition]] Definition 






---


###SetDataSourceContentsAsync(System.String,Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceDefinition]] Definition 






---


###SetDataSourceContentsAsync(System.String,Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] DataSource 
* [[Microsoft.SqlServer.ReportingServices2005.DataSourceDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSourceDefinition]] Definition 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetExecutionOptions(System.String,Microsoft.SqlServer.ReportingServices2005.ExecutionSettingEnum,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExecutionSettingEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExecutionSettingEnum]] ExecutionSetting 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 






---


###SetExecutionOptionsAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExecutionSettingEnum,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExecutionSettingEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExecutionSettingEnum]] ExecutionSetting 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 






---


###SetExecutionOptionsAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExecutionSettingEnum,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ExecutionSettingEnum|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExecutionSettingEnum]] ExecutionSetting 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetItemDataSources(System.String,Microsoft.SqlServer.ReportingServices2005.DataSource[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.DataSource[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSource[]]] DataSources 






---


###SetItemDataSourcesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.DataSource[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.DataSource[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSource[]]] DataSources 






---


###SetItemDataSourcesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.DataSource[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.DataSource[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-DataSource[]]] DataSources 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetModelDefinition(System.String,System.Byte[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 






---


###SetModelDefinitionAsync(System.String,System.Byte[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 






---


###SetModelDefinitionAsync(System.String,System.Byte[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetModelDrillthroughReports(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ModelDrillthroughReport[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[Microsoft.SqlServer.ReportingServices2005.ModelDrillthroughReport[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ModelDrillthroughReport[]]] Reports 






---


###SetModelDrillthroughReportsAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ModelDrillthroughReport[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[Microsoft.SqlServer.ReportingServices2005.ModelDrillthroughReport[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ModelDrillthroughReport[]]] Reports 






---


###SetModelDrillthroughReportsAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ModelDrillthroughReport[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[Microsoft.SqlServer.ReportingServices2005.ModelDrillthroughReport[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ModelDrillthroughReport[]]] Reports 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetModelItemPolicies(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Policy[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 






---


###SetModelItemPoliciesAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Policy[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 






---


###SetModelItemPoliciesAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Policy[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Model 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ModelItemID 
* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetPolicies(System.String,Microsoft.SqlServer.ReportingServices2005.Policy[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 






---


###SetPoliciesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.Policy[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 






---


###SetPoliciesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.Policy[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetProperties(System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###SetPropertiesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###SetPropertiesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Item 
* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetReportDefinition(System.String,System.Byte[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 






---


###SetReportDefinitionAsync(System.String,System.Byte[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 






---


###SetReportDefinitionAsync(System.String,System.Byte[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Definition 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetReportHistoryLimit(System.String,System.Boolean,System.Int32)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] UseSystem 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] HistoryLimit 






---


###SetReportHistoryLimitAsync(System.String,System.Boolean,System.Int32)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] UseSystem 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] HistoryLimit 






---


###SetReportHistoryLimitAsync(System.String,System.Boolean,System.Int32,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] UseSystem 
* [[System.Int32|http://msdn.microsoft.com/en-us/library/td2s409d]] HistoryLimit 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetReportHistoryOptions(System.String,System.Boolean,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] EnableManualSnapshotCreation 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] KeepExecutionSnapshots 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 






---


###SetReportHistoryOptionsAsync(System.String,System.Boolean,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] EnableManualSnapshotCreation 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] KeepExecutionSnapshots 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 






---


###SetReportHistoryOptionsAsync(System.String,System.Boolean,System.Boolean,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] EnableManualSnapshotCreation 
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] KeepExecutionSnapshots 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinitionOrReference|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinitionOrReference]] Item 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetReportLink(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Link 






---


###SetReportLinkAsync(System.String,System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Link 






---


###SetReportLinkAsync(System.String,System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Link 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetReportParameters(System.String,Microsoft.SqlServer.ReportingServices2005.ReportParameter[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ReportParameter[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ReportParameter[]]] Parameters 






---


###SetReportParametersAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ReportParameter[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ReportParameter[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ReportParameter[]]] Parameters 






---


###SetReportParametersAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ReportParameter[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[Microsoft.SqlServer.ReportingServices2005.ReportParameter[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ReportParameter[]]] Parameters 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetResourceContents(System.String,System.Byte[],System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Contents 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 






---


###SetResourceContentsAsync(System.String,System.Byte[],System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Contents 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 






---


###SetResourceContentsAsync(System.String,System.Byte[],System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Resource 
* [[System.Byte[]|http://msdn.microsoft.com/en-us/library/yyb1w04y]] Contents 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MimeType 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetRoleProperties(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Task[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[Microsoft.SqlServer.ReportingServices2005.Task[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Task[]]] Tasks 






---


###SetRolePropertiesAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Task[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[Microsoft.SqlServer.ReportingServices2005.Task[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Task[]]] Tasks 






---


###SetRolePropertiesAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.Task[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[Microsoft.SqlServer.ReportingServices2005.Task[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Task[]]] Tasks 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetScheduleProperties(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinition]] ScheduleDefinition 






---


###SetSchedulePropertiesAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinition]] ScheduleDefinition 






---


###SetSchedulePropertiesAsync(System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Name 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] ScheduleID 
* [[Microsoft.SqlServer.ReportingServices2005.ScheduleDefinition|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ScheduleDefinition]] ScheduleDefinition 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetSubscriptionProperties(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValue[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 






---


###SetSubscriptionPropertiesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValue[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 






---


###SetSubscriptionPropertiesAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ExtensionSettings,System.String,System.String,System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValue[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] SubscriptionID 
* [[Microsoft.SqlServer.ReportingServices2005.ExtensionSettings|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ExtensionSettings]] ExtensionSettings 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Description 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] EventType 
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] MatchData 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValue[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValue[]]] Parameters 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetSystemPolicies(Microsoft.SqlServer.ReportingServices2005.Policy[])
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 






---


###SetSystemPoliciesAsync(Microsoft.SqlServer.ReportingServices2005.Policy[])
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 






---


###SetSystemPoliciesAsync(Microsoft.SqlServer.ReportingServices2005.Policy[],System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Policy[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Policy[]]] Policies 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###SetSystemProperties(Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###SetSystemPropertiesAsync(Microsoft.SqlServer.ReportingServices2005.Property[])
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 






---


###SetSystemPropertiesAsync(Microsoft.SqlServer.ReportingServices2005.Property[],System.Object)
<remarks />

Parameters: 

* [[Microsoft.SqlServer.ReportingServices2005.Property[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-Property[]]] Properties 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the name of the System.ComponentModel.Component, if any. This method should not be overridden.





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] containing the name of the System.ComponentModel.Component, if any, or null if the [[System.ComponentModel.Component|http://msdn.microsoft.com/en-us/library/9wbadbce]] is unnamed.


---


###UpdateReportExecutionSnapshot(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###UpdateReportExecutionSnapshotAsync(System.String)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 






---


###UpdateReportExecutionSnapshotAsync(System.String,System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Report 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


###ValidateExtensionSettings(System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Extension 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] ParameterValues 






---


###ValidateExtensionSettingsAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[])
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Extension 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] ParameterValues 






---


###ValidateExtensionSettingsAsync(System.String,Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[],System.Object)
<remarks />

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] Extension 
* [[Microsoft.SqlServer.ReportingServices2005.ParameterValueOrFieldReference[]|/API/Microsoft/SqlServer/ReportingServices2005/Microsoft-SqlServer-ReportingServices2005-ParameterValueOrFieldReference[]]] ParameterValues 
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] userState 






---


