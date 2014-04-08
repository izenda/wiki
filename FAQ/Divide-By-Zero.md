We have implemented the Div/0 custom format option. This functionality is available in latest maintenance releases past 6.7.258.

Usage; code for your Izenda global.asax:

```
// By default the display still shows "#DIV/0" when a divide by zero action occurs.


//To Display "Division by Zero Text"
(AdHocSettings.Formats.Get("DivisionByZero") as AdHoc.Formats.Formats.DivisionByZeroFormat).ReplaceText = "Division by Zero Text";


//To Display "0"
(AdHocSettings.Formats.Get("DivisionByZero") as AdHoc.Formats.Formats.DivisionByZeroFormat).ReplaceText = "0";


//To Display NULL (nothing)
(AdHocSettings.Formats.Get("DivisionByZero") as AdHoc.Formats.Formats.DivisionByZeroFormat).ReplaceText = "";
```