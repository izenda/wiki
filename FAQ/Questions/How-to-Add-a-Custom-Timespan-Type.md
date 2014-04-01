#How to Add a Custom Timespan Type

[[_TOC_]]

##Adding Custom Timespans

Here is an example of how to add custom time spans to the filters. Apply this code within ConfigureSettings in Global.asax.

```csharp
CustomTimePeriod customTimePeriod = AdHocSettings.CustomTimePeriod[key];
TimeSpan period = customTimePeriod.Period;
if (period.Ticks > 0)
{
  startDate = now + period;
}
else
{
  endDate = now;
  startDate = now.period;
} 
```