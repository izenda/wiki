#OperatorTypes

[[_TOC_]]

##Enum Properties 

* Equals -  Specifies that the filter column is equal to a certain value. 
* EqualsCalendar - Specifies that the filter column is equal to a certain datetime value. Values supplied on the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]] will be limited to a calendar selection.
* Like -  Specifies that the filter column value contains a certain substring value. 
* BeginsWith -  Specifies that the filter column value begins with a certain substring value. 
* EndsWith -  Specifies that the filter column value ends with a certain substring value. 
* Between -  Specifies that the filter column value is between two numeric value. 
* True -  Specifies that the filter column value is equal to one. 
* False -  Specifies that the filter column value is equal to zero. 
* LessThan -  Specifies that the filter column value is less than a specified numeric value. 
* GreaterThan -  Specifies that the filter column value is greater than a specified numeric value. 
* LessThanNot -  Specifies that the filter column value is not less than a specified numeric value. 
* GreaterThanNot -  Specifies that the filter column value is not greater than a specified numeric value. 
* In -  Specifies that the filter column value is equal to a set of comma separated values. 
* Blank -  Specifies that the filter column value is null. 
* Equals_Select -  Specifies that the filter column value is less than a specified numeric value. 
* InTimePeriod -  Specifies that the filter column value is within the specified period of time with a start date and an end date. 
* UsePreviousOR -  Specifies that the filter column value uses the operator of the previous filter with the value supplied and an OR condition for the two columns. 
* Unknown -  Specifies an unknown filter type. 
* InInnerSql -  Specifies that the filter column value is equal to a set of values based on an inner SQL expression. 
* Equals_Multiple - Specifies that the filter column value is equal to a set of values based on a multi-selection list control used on the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]].
* BetweenTwoDates -  Specifies that the filter column value lies between a range of a start date and end date. 
* LessThan_DaysOld -  Specifies that the filter column value is between the current date and the specified number of days preceeding the current date. 
* GreaterThan_DaysOld -  Specifies that the filter column value is greater than the specified number of days preceeding the current date. 
* Equals_DaysOld -  Specifies that the filter column value is equal to the number of days preceeding the current date. 
* EqualsPopup - Specifies that the filter column value is equal to the list of values selected via a popup box on the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]] containing the field values.
* Equals_TextArea - Specifies that the filter column value is equal to the list of values separated by newlines in a textarea control on the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]].
* Equals_Autocomplete - Specifies that the filter column value is equal to the list of values selected via a popup box on the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]] containing the field values.
* Equals_CheckBoxes - Specifies that the filter column value is equal to the list of values selected via checkboxes in a list control on the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]] containing the field values.
* Equals_TreeView - Specifies that the filter column value is equal to the list of values selected via a popup box on the [[Izenda.Web.UI.AdHocReportDesigner|/API/Izenda/Web/UI/Izenda-Web-UI-AdHocReportDesigner]] containing the field values.