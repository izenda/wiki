#How Does Security Work?

[[_TOC_]]

##Izenda Security Model
Izenda Reports inherits your application's security model. You may assign values to 'roles' or 'users' you create or define. Whether you use sessions, database tables, or any other login and authentication method is your decision. 

In a multi-tenant environment, Izenda Reports will need the user name and tenant identifier. The product includes one pre-defined "_Administrator_" role. In order to implement any other roles, such as power users, sales or any other type, you will need to define them by using our settings to determine what kind of access permissions a role should have.

- Administrators: If a user is set as an admin, then they will be able to see all reports and overwrite even read only reports. Note: this behavior can be changed via code customization.
- All other users: If the user name is set, but the user is not an admin, then by default, that user will only see shared reports and their own reports. Note: this behavior can be changed via code customization, since all settings can be set on a per-use basis.

**If you simply browse to Izenda Reports without requiring a login page, or applying other means of security, the default user is set to DefaultAdministrator. This user has admin privileges and will be able to see and change all other users' reports.** You can use code to create any roles you wish, such as power users, or roles that can only view and export reports. 

Izenda Reports only needs to know which users have which privileges and how you identify them. Since this is different for different deployments, this needs to be integrated as part of your application's login process. Please contact services@izenda.com with questions or to set up an integration call with an Izenda Engineer.