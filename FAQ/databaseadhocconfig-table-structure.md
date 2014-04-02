#DatabaseAdHocConfig Table Structure

When using _DatabaseAdHocConfig_ Izenda reports saves report definitions to the database.

Reports are saved in a special table created for this purpose:

```sql
[Name](nvarchar(255), null)
[Xml] (ntext, null)
[CreatedDate](datetime, null)
[ModifiedDate](datetime, null)
[TenantID](nvarchar(255), null)
[Form](nvarchar(max), null)
[ReportSourceID](int, null)
[IzendaAdHocReportsID](int, null)
[Thumbnail] [varbinary](max) NULL
```