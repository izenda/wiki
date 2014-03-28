#Using Share with, rights, roles properties in Izenda Reports 6+

##Sharing

The ShareWithValues and CurrentUserRoles properties allow reports to be easily shared among users and groups of users. The SharedWithValues property populates the "Share With" drop-down found on the "Misc" tab in the Izenda Reports application. The "Rights" drop-down which is next to the "Share With" drop-down allow the user to assign Full Access, Read Only, View Only, Locked, or None permissions to the selected choice in the "Share With" drop-down.

Roles on a per-user basis are specified by the CurrentUserRoles property. If a user is given a role, then he will have access to the reports which are shared with that role.

```csharp
AdHocSettings.CurrentUserRoles and AdHocSettings.SharedWithValues are per-user properties.

AdHocSettings.CurrentUserIsAdmin = false;
AdHocSettings.CurrentUserName = "Bob";
AdHocSettings.CurrentUserRoles = new string[] { "Sales" };
AdHocSettings.SharedWithValues = new string[] { "Bob", "Sales", "Bob Smith", "Admins", "Sam Jones" }; 
```

In the example above, Bob is a non-admin user who is assigned to the Sales role. Therefore, any reports that are "Shared With" the "Sales" role will be accessible by Bob. Bob will only be able to share reports with the SharedWithValues property shown in the sample. 

##Shared roles

* **Full Access:** Report is available to the user to view, modify, and save changes to the report. Note that owner user(UserName property of the ReportSet) will not be changed on saving, i.e. the original owner(creator) of the report will stay the same. 
* **Read Only** Report is available to the user to view, user can add or remove filters, and modify existing filters' values. Also user can modify(design) the report but cannot save it, however user could Save As this report. 
* **View Only:** Report is available to the user to view, but not to modify in any way or save changes to the report. 
* **Locked:** Report is available to the user to view, and user can modify existing filters' values, but user cannot add or remove filters or fields or save changes to the report. Note that modifying filter operator and/or filtered column is restricted as well. 
None - Report is unavailable to (hidden from) the user.