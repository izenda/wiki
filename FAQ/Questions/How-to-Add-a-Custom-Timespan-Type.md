#How to Add a Custom TimePeriod Type

[[_TOC_]]

##Adding Custom TimePeriods

Here is an example of how to add custom time spans to the filters. Apply this code within ``InitializeReporting()`` in your Global.asax.

```csharp
//the if block prevents the key from being re-added to the list
if (!AdHocSettings.CustomTimePeriods.ContainsKey("Lunar Cycle")) { 
    AdHocSettings.CustomTimePeriods.Add("Lunar Cycle", new CustomTimePeriod("Lunar Cycle", new TimeSpan(29, 12, 44, 2, 976))); 
}
```

##Modifying An Existing Time Period

```csharp
      CustomTimePeriod ctp = AdHocSettings.CustomTimePeriods["Lunar Cycle"];
      ctp.StartDate = DateTime.Now + ctp.Period; //passed by reference so the original list will update
```