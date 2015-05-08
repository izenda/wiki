##Question

How do I add Read-Write user permission to DB?

##Answer

Using 'ConnectionStringRW' property, user permissions to DB can be specified. This property should be assigned similarly to normal connection string as below - in the initialization of reporting.

```csharp

 public class CustomAdHocConfig : FileSystemAdHocConfig {
    public static void InitializeReporting() {
      //Check to see if we've already initialized.
      if (HttpContext.Current.Session == null || HttpContext.Current.Session["ReportingInitialized"] != null)
        return;
      //Initialize System
      AdHocSettings.LicenseKey = " License Key Here";
      AdHocSettings.SqlServerConnectionString = @" Connection String Here";
      AdHocContext.Driver.ConnectionStringRW = @" Connection String RW Here";   // ConnectionStringRW was used

      }
}
```
If it's not assigned, Izenda as before uses Driver.ConnectionString for all operations against DB


4) If ConnectionStringRW is also assigned, then Izenda will

  a) Use Driver.ConnectionString for Read-Only operations against DB, thus Driver.ConnectionString can have ReadOnly access to the DB

  b) Use Driver.ConnectionStringRW for Read-Write operations. At this moment this includes only following:

    - Create Reports table if it doesn't exist

    - Create/Update/Delete Thumbnails in Reports table in Database mode

    - Create/Update/Delete Forms in Reports table in Database mode

    - Create/Save/Delete ReportSets in Reports table in Database mode


Here is the video explaining how to create ReadOnly connection string in MSSQL: http://www.screencast.com/users/IzendaReports/folders/Temporary/media/9a2e633c-bbc7-4c47-9425-8df36d36e368

6) Here is video demonstrating how installation works when Driver.ConnectionStringRW is assigned for read-write operations, and Driver.ConnectionString has ReadOnly access: http://www.screencast.com/users/IzendaReports/folders/Temporary/media/a04a117c-89d1-40f3-8053-55d0d7586d1a


Really it can be used always. General case is just safety improvement - if user specifies ConnectionStringRW, and uses read-only DB account for usual Driver.ConnectionString - he can be 100% sure that users will not be able to modify anything in DB by any means - like using SQL injections. Just because everything which user can input - goes to DB via read-only connection string.
