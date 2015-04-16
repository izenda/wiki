


#Changing Decimal Type Precision

##About

Below is the SQL sample to create a View with 1 million records using the Northwind example database. This query can be used to load test your application with before you send it out to production.


## What To Change



DECIMAL(18,6) to NUMERIC(22,8)
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