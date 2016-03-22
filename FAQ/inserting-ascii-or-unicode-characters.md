#How do I insert non-alphanumeric characters in a standard character set into an Izenda Report?

[[_TOC_]]

#Question

I'd like to insert some character into my report, but I'm having a hard time using an expression or value range.

#Answer

The easiest way for a user to enter a character which is not a standard letter or number is by using a custom format. This method requires more setup on the backend but is accessible to users with only a few clicks.

In the example code below, we will convert a boolean True to a unicode tickmark and a boolean False to a blank space.

```csharp
AdHocSettings.Formats.Add("Check", new BoolToCheckFormat());


[Serializable]
public class BoolToCheckFormatter : IFormatter
{
    public Type GetOutputDataType(DataTable table, int columnNumber, ReportOutputOptions reportOutputOptions, Field field)
    {
        return typeof(string);
    }

    public object Format(DataTable table, int rowNumber, int columnNumber, Field field, DataTable originalTable, Field nameField)
    {
        object value = table.Rows[rowNumber][columnNumber];
        if (value == null || Convert.IsDBNull(value))
            return null;

        if (value as bool? == true)
            return "&#10004";
        return "&#10008;";
    }
}

public class BoolToCheckFormat : IFormat
{
    private SqlTypeGroupCollection allowedTypeGroups = new SqlTypeGroupCollection();
    public SqlTypeGroupCollection AllowedTypeGroups
    {
        get { return allowedTypeGroups; }
    }

    public SqlTypeGroupCollection DisallowedTypeGroups
    {
        get { return null; }
    }

    public string Name { get { return "Check"; } }

    public SqlTypeGroup DefaultFor
    {
        get { return SqlTypeGroup.None; }
    }

    public bool Visible
    {
        get { return true; }
    }

    public IFormatter[] CreateFormatters()
    {
        return new IFormatter[] { new BoolToCheckFormatter() };
    }

    public BoolToCheckFormat()
    {
        allowedTypeGroups.Add(SqlTypeGroup.Binary);
        allowedTypeGroups.Add(SqlTypeGroup.Numeric);
    }
}
```