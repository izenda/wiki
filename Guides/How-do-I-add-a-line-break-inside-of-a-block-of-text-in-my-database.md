#How do I add a line break inside of a block of text in my database?

[[_TOC_]]

##Question

I have long blocks of text in my database, and line breaks aren't being respected. How can I add these?

##Answer

By default, this text will not appear in the Database the way it was typed in the field. This text will also not appear in the Report Writer the way it was typed in the field. You can force line breaks using special characters. This can be done by overriding the ProcessDataSet method, or by using a custom formatter. A custom format is less dangerous, easier to implement by a user, and is reusable across reports. Please see the following code example:

###Code Sample

```csharp
[Serializable]
    public class HtmlTextFormatter : IFormatter
    {
        public Type GetOutputDataType(DataTable table, int columnNumber, ReportOutputOptions reportOutputOptions, Field field)
        {
            return typeof(string);
        }

        public object Format(DataTable table, int rowNumber, int columnNumber, Field field, DataTable originalTable, Field nameField)
        {
            object value = table.Rows[rowNumber][columnNumber];
            if (value == null)
                return "";
            return value.ToString().Replace("\r\n", "<br/>");
        }
    }

    [Serializable]
    public class HtmlTextFormat : IFormat
    {
        public SqlTypeGroupCollection AllowedTypeGroups
        {
            get { return null; }
        }

        public SqlTypeGroupCollection DisallowedTypeGroups
        {
            get { return null; }
        }

        public string Name { get { return "HTML Text"; } }

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
            return new IFormatter[] { new HtmlTextFormatter() };
        }
    }

```