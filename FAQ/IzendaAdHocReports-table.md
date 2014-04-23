#IzendaAdHocReports table

[[_TOC_]]

##About

When using _DatabaseAdHocConfig_, Izenda reports saves report definitions to the database. By default, this is the table name that Izenda uses. You can use [[SavedReportsTable|/API/CodeSamples/SavedReportsTable]] to specify a different table name. Izenda will create the table for you, but in the event that something fails, here is the SQL script that will generate the table.

##MSSQL Table Script

```sql
CREATE TABLE [dbo].[IzendaAdHocReports] (
    [Name]                 NVARCHAR (255)  NULL,
    [Xml]                  NTEXT           NULL,
    [CreatedDate]          DATETIME        NULL,
    [ModifiedDate]         DATETIME        NULL,
    [TenantID]             NVARCHAR (255)  NULL,
    [IzendaAdHocReportsID] INT             NULL,
    [ReportSourceID]       INT             NULL,
    [Thumbnail]            VARBINARY (MAX) NULL
);
```

##Oracle Table Script

```sql
BEGIN
    CREATE TABLE IzendaAdHocReports
    ( Name VARCHAR(255) NOT NULL,
      Xml NCLOB,
      CreatedDate DATE,
      ModifiedDate DATE,
      TenantID VARCHAR(255),
      IzendaAdHocReportsID INTEGER,
      ReportSourceID INTEGER,
      Thumbnail BLOB
    );
    COMMIT;
END;
```

##Izenda FORMS plugin

The Izenda [[FORMS|/Guides/ReportDesign/14.0-Izenda-FORMS]] plugin uses a unique process to generate the pixel-perfect forms that the report viewers see. To do this, it needs a special column in the database. Here is the table script with the new column added.

###MSSQL table script

```sql
CREATE TABLE [dbo].[IzendaAdHocReports] (
    [Name]                 NVARCHAR (255)  NULL,
    [Xml]                  NTEXT           NULL,
    [CreatedDate]          DATETIME        NULL,
    [ModifiedDate]         DATETIME        NULL,
    [TenantID]             NVARCHAR (255)  NULL,
    [IzendaAdHocReportsID] INT             NULL,
    [Form]                 NVARCHAR (MAX)  NULL,
    [ReportSourceID]       INT             NULL,
    [Thumbnail]            VARBINARY (MAX) NULL
);
```

###Oracle SQL table script

```sql
BEGIN
    CREATE TABLE IzendaAdHocReports
    ( Name VARCHAR(255) NOT NULL,
      Xml NCLOB,
      CreatedDate DATE,
      ModifiedDate DATE,
      TenantID VARCHAR(255),
      IzendaAdHocReportsID INTEGER,
      Form NCLOB,
      ReportSourceID INTEGER,
      Thumbnail BLOB
    );
    COMMIT;
END;
```

###MSSQL Alter table script

And here is an SQL statement to add the field to an existing table.

```sql
ALTER TABLE [dbo].[IzendaAdHocReports]
ADD [Form] NVARCHAR (MAX)  NULL
```

###Oracle Alter table script

Here is the Oracle equivalent of the above alter table script

```sql
BEGIN
ALTER TABLE IzendaAdHocReports 
ADD (Form NCLOB);
COMMIT;
END;
```