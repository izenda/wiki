#Offline Driver

[[_TOC_]]

##creating the driver

In order to implement a driver that operates completely independent of a database, it is necessary to override the following methods at a minimum:

* GetAllTables
* GetColumns
* GetDataSet
* DetectVersion
* CheckConnection
* GetAllStoredProcedures

This will allow Izenda to perform the operations it needs to in order to get database schema information and produce datasets in a completely custom manner. Below is an example of how one might override these to create a driver that does not connect to a database.

##C♯ Example

```csharp
using System;
using System.Collections.Generic;
using Izenda.AdHoc;
using Izenda.AdHoc.Database;
using System.Data;

[Serializable]
public class OfflineDriver : MSSQLDriver
{
    Dictionary<string, Type> colTypes = new Dictionary<string, Type>()
        { {"[dbo].[Fruits].[Price]", typeof(double)},
        {"[dbo].[Drinks].[Price]", typeof(double)},
        {"[dbo].[Fruits].[Name]", typeof(string)},
        {"[dbo].[Drinks].[Name]", typeof(string)},
        {"[dbo].[Fruits].[Color]", typeof(string)},
        {"[dbo].[Drinks].[Alcohol]", typeof(string)}};

    Dictionary<string, object[]> colData = new Dictionary<string, object[]>()
        { {"[dbo].[Fruits].[Price]", new object[] {1.24, 2.61, 1.38, 3.21}},
        {"[dbo].[Drinks].[Price]", new object[] {9.56, 7.11, 9.41, 7.42}},
        {"[dbo].[Fruits].[Name]", new object[] {"Apple", "Pear", "Plum", "Apricot"}},
        {"[dbo].[Drinks].[Name]", new object[] {"Beer", "Tea", "Whiskey", "Coffee"}},
        {"[dbo].[Fruits].[Color]", new object[] {"Green", "Yellow", "Black", "Orange"}},
        {"[dbo].[Drinks].[Alcohol]", new string[] {"Yes", "No", "Yes", "No"}}};

    public override Table[] GetAllTables()
    {
        List<Table> tables = new List<Table>();
        tables.Add(new Table("Fruits", "dbo", TableType.Table));
        tables.Add(new Table("Drinks", "dbo", TableType.Table));
        return tables.ToArray();
    }

    public override Column[] GetColumns(Table table)
    {
        List<Column> columns = new List<Column>();
        columns.Add(new Column("Price", SqlType.Money));
        columns.Add(new Column("Name", SqlType.VarChar));
        if (table.Name == "Fruits")
            columns.Add(new Column("Color", SqlType.VarChar));
        if (table.Name == "Drinks")
            columns.Add(new Column("Alcohol", SqlType.VarChar));
        return columns.ToArray();
    }

    protected override DataSet GetDataSet(IDbCommand command, Report report, string reportPart, string uniqueID)
    {
        if (report == null || String.IsNullOrEmpty(reportPart))
            return base.GetDataSet(command, report, reportPart, uniqueID);
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        ds.Tables.Add(dt);
        foreach (Field f in report.Fields)
            dt.Columns.Add(new DataColumn(f.Description, colTypes[f.DbColumn.FullName]));
        int top = report.Top;
        if (top <= 0 || top > 4)
            top = 4;
        for (int i = 0; i < top; i++)
        {
            DataRow dr = dt.NewRow();
            for (int cc = 0; cc < report.Fields.Count; cc++)
                dr[cc] = colData[report.Fields[cc].DbColumn.FullName][i];
            dt.Rows.Add(dr);
        }
        return ds;
    }

    public override Version DetectVersion()
    {
        return new Version(1, 0);
    }

    public override void CheckConnection()
    {
    }

    public override StoredProcedure[] GetAllStoredProcedures()
    {
        return new StoredProcedure[0];
    }


    public OfflineDriver()
    {
    }
}
```

##VB.NET Example

```visualbasic
Imports System
Imports System.Collections.Generic
Imports Izenda.AdHoc
Imports Izenda.AdHoc.Database
Imports System.Data

<Serializable>
Public Class OfflineDriver
    Inherits MSSQLDriver
    Dim colTypes As Dictionary(Of String, Type) = New Dictionary(Of String, Type)() From
        {{"[dbo].[Fruits].[Price]", GetType(Double)},
        {"[dbo].[Drinks].[Price]", GetType(Double)},
        {"[dbo].[Fruits].[Name]", GetType(String)},
        {"[dbo].[Drinks].[Name]", GetType(String)},
        {"[dbo].[Fruits].[Color]", GetType(String)},
        {"[dbo].[Drinks].[Alcohol]", GetType(String)}}

    Dim colData As Dictionary(Of String, Object()) = New Dictionary(Of String, Object())() From
        {{"[dbo].[Fruits].[Price]", New Object() {1.24, 2.61, 1.38, 3.21}},
        {"[dbo].[Drinks].[Price]", New Object() {9.56, 7.11, 9.41, 7.42}},
        {"[dbo].[Fruits].[Name]", New Object() {"Apple", "Pear", "Plum", "Apricot"}},
        {"[dbo].[Drinks].[Name]", New Object() {"Beer", "Tea", "Whiskey", "Coffee"}},
        {"[dbo].[Fruits].[Color]", New Object() {"Green", "Yellow", "Black", "Orange"}},
        {"[dbo].[Drinks].[Alcohol]", New String() {"Yes", "No", "Yes", "No"}}}

    Public Overrides Function GetAllTables() As Table()
        Dim tables = New List(Of Table)
        tables.Add(New Table("Fruits", "dbo", TableType.Table))
        tables.Add(New Table("Drinks", "dbo", TableType.Table))
        Return tables.ToArray()
    End function

    Public Overrides Function GetColumns(table As Table) As Column()
        Dim columns = New List(Of Column)
        columns.Add(New Column("Price", SqlType.Money))
        columns.Add(New Column("Name", SqlType.VarChar))
        If table.Name.Equals("Fruits") Then
            columns.Add(New Column("Color", SqlType.VarChar))
        End If
        If table.Name.Equals("Drinks") Then
            columns.Add(New Column("Alcohol", SqlType.VarChar))
        End If
        Return columns.ToArray()
    End function

    Protected Overrides Function GetDataSet(command As IDbCommand, report As Report, reportPart As String, uniqueID As String) As DataSet
        If report Is Nothing OrElse String.IsNullOrEmpty(reportPart) Then
            Return MyBase.GetDataSet(command, report, reportPart, uniqueID)
        End If
        Dim ds As New DataSet()
        Dim dt As New DataTable()
        ds.Tables.Add(dt)
        For Each f As Field In report.Fields
            dt.Columns.Add(New DataColumn(f.Description, colTypes(f.DbColumn.FullName)))
        Next
        Dim top = report.Top
        If top <= 0 OrElse top > 4 Then
            top = 4
        End If
        For i As Integer = 0 To top - 1 Step 1
            Dim dr = dt.NewRow()
            For cc As Integer = 0 To report.Fields.Count - 1
                dr(cc) = colData(report.Fields(cc).DbColumn.FullName)(i)
            Next
            dt.Rows.Add(dr)
        Next
        Return ds
    End Function

    Public Overrides Function DetectVersion() As Version
        Return New Version(1, 0)
    End Function

    Public Overrides Sub CheckConnection()

    End Sub

    Public Overrides Function GetAllStoredProcedures() As StoredProcedure()
        Return New StoredProcedure() {}
    End Function

    Public Sub New()

    End Sub
End Class
```