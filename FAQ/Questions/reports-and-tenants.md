#Reports and Tenants

[[_TOC_]]

##Question

How does Izenda support multi-tenant and cloud computing systems?

##Answer

Izenda supports these systems with several properties designed specifically for multi-tenant systems. Here is a basic overview of these properties and their functionality.

###Tenant system overview

Here are the basic principles behind how tenants integrate with reports:

* Every ReportSet has an **OwnerTenantID**.
* Every user session is associated with one [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]] that is empty by default.
* When a ReportSet is being saved, its **OwnerTenantID** gets the value of whatever is in [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]].

This means that a ReportSet will not be accessible to the user if their [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]] doesn’t match the ReportSet's OwnerTenantID.

Here is a chart demonstrating accessibility between a user's CurrentUserTenantId and the ReportSet's OwnerTenantId:

|                 |**CurrentUserTenantId**|none|"Tenant_1"|"Tenant_2"|
|:---------------:|:---------------------:|:--:|:--------:|:--------:|
|**OwnerTenantID**|                       |    |          |          |
|none             |                       |  + |    +     |     +    |
|"Tenant_1"       |                       |  - |    +     |     -    |
|"Tenant_2"       |                       |  - |    -     |     +    |

**Legend:** (+) Accessible (-) Not Accessible

###Tenant Field

The [[TenantField|/API/CodeSamples/TenantField]] setting allows per-report filtering based on the value of the user's [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]]. Here are the rules about **ReportSets**.

* Every **ReportSet** contains a list of the **DataSources** used with it. 
* Every **DataSource** has a list of **Fields** associated with it.
* Every **Field** can have a set of applied **Filters**.

This creates a high level of control over what is filtered. Essentially, the system will look at the ReportSet's DataSources, find the Field specified by [[TenantField|/API/CodeSamples/TenantField]] and apply a hidden filter to that field using the value of the user's [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]].

So, if the [[TenantField|/API/CodeSamples/TenantField]] property is specified, the hidden filter of the user's [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]] will be added every time report is populated.

So, the generated SQL will look like the following:

```sql
SELECT [TenantField] FROM [DataSource]
WHERE ... AND [TenantField] = 'CurrentUserTenantId'
```

**For example:**
Let’s create a report with information about customers' orders:

![Customer order report]()

If [[TenantField|/API/CodeSamples/TenantField]] is NOT specified we will see the following report:

![Customer order report output]()

Now let’s specify [[TenantField|/API/CodeSamples/TenantField]] and [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]]:

```csharp
public class CustomAdHocConfig : DatabaseAdHocConfig
{
	public static void InitializeReporting()
	{
		AdHocSettings.TenantField = "CustomerID";
		AdHocSettings.CurrentUserTenantId = "ALFKI";
	}
}
```

With these properties set, we will see a completely different report:

![customer order report filtered]()

As you can see the results are filtered by the “Customer ID” field now. And only those matching “ALFKI” will be populated.

_**Note:** You must always specify [[CurrentUserTenantId|/API/CodeSamples/CurrentUserTenantId]] to use [[TenantField|/API/CodeSamples/TenantField]]. The only exception is reports scheduler (details in the below section)._