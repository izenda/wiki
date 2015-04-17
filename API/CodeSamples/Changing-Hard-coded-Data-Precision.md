#Changing Hard-coded Data Precision

##About

Below is the code sample to change the hard-coded Decimal Type Precision from DECIMAL(18,6) to NUMERIC(22,8)


## c#

Ex) DECIMAL(18,6) to NUMERIC(22,8)
```c#
List<KeyValuePair<string, string>> typeOverrides = AdHocContext.Driver.NativeTypesOverrides;
for (int i = 0; i < typeOverrides.Count; i++)
    if (typeOverrides[i].Key == "Decimal")
    {
        typeOverrides[i] = new KeyValuePair<string, string>(typeOverrides[i].Key, "NUMERIC(22,8)");
        break;
    }
AdHocContext.Driver.NativeTypesOverrides = typeOverrides;

```





