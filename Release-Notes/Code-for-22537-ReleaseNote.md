
**Original:** 
_class CustomDateFormatter : IFormatter, IExcelFormatter { public string GetExcelCellClass { get { return "xls-text"; } } _
_public Type GetOutputDataType(DataTable table, int columnNumber, ReportOutputOptions reportOutputOptions, Field field) { return typeof(string); } _
_public object Format(DataTable table, int rowNumber, int columnNumber, Field field, DataTable originalTable, Field nameField) { var value = table.Rows[rowNumber][columnNumber]; if (value == null || value == DBNull.Value) return ""; return string.Format("{0:dd MMM yyyy}", value); } }_

**Updated:**
_class CustomDateFormatter : BaseFormatter, IExcelFormatter { public string GetExcelCellClass { get { return "xls-text"; } }_
_public override Type GetOutputDataType(AdHocDataTable table, int columnNumber, ReportOutputOptions reportOutputOptions, Field field) { return typeof(string); }_
_public override object Format(AdHocDataTable table, int rowNumber, int columnNumber, Field field, AdHocDataTable originalTable, Field nameField) { var value = table.Rows[rowNumber][columnNumber]; if (value == null || value == DBNull.Value) return ""; return string.Format("{0:dd MMM yyyy}", value); } }_