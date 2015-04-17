##Question

How can I change default data precision setting?


##Answer

When Izenda loads a report that uses a stored procedure, it creates a temporary table to store the values. For string, it creates NVARCHAR(MAX) columns and for numeric fields a DECIMAL(18,6). Therefore, if any field with greater precision such as NUMERIC(22,8) is used, the report then fails with a conversion error as below because it cannot fit the NUMERIC(22,8) value into a DECIMAL(18,6) column.

[![Test](/Home/Conversion.jpg)]

The hard-code default setting, DECIMAL(18,6) can be easily modified by adding below setting code to the Driver (within InitializeReporting() method) .

### Example) DECIMAL(18,6) (Default) to NUMERIC(22,8)

```csharp
List<KeyValuePair<string, string>> typeOverrides = AdHocContext.Driver.NativeTypesOverrides;
for (int i = 0; i < typeOverrides.Count; i++)
    if (typeOverrides[i].Key == "Decimal")
    {
        typeOverrides[i] = new KeyValuePair<string, string>(typeOverrides[i].Key, "NUMERIC(22,8)");
        break;
    }
AdHocContext.Driver.NativeTypesOverrides = typeOverrides;

```
