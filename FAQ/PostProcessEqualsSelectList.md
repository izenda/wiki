#PostProcessEqualsSelectList()

[[_TOC_]]

##About

This method runs immediately after the ProcessEqualsSelectList method that is responsible for loading a list of all possible values for data-driven filters. This override can be used to edit the list of values after the data has been retrieved and to have control over the labels and values of each item. Normally, the labels and values of the filter options are synonymous, using the same value for both the label and value. For instance, one could have a data-driven filter that returns the value "USA" and then in PostProcessEqualsSelect, the label corresponding to that value can be changed to read "United States of America". The filter would still pass the value USA logically, but the full name would be displayed as opposed to the abbreviation.

The list of filter types that load data are as follows:

* Equals(List)
* Equals(Autocomplete)
* Equals(Select)
* Equals(Multiple)
* Equals(Popup)
* Equals(Checkboxes)
* Doesn't Equal(Select)
* Doesn't Equal Multiple
* Doesn't Equal(Popup)

##Sample C♯ Method

```csharp
public override void PostProcessEqualsSelectList(Column column, List<string> labels, List<string> values)
{
    for(int i = 0; i < values.Count; i++)
    {
        string myValue = values[i];
        if (myValue == "USA")
            labels[i] = "United States of America";
        else
            labels[i] = values[i];
    }
}
```

##Sample VB.NET Method

```visualbasic
Public Overrides Sub PostProcessEqualsSelectList(column As Column, labels As List(Of String), values As List(Of String))
    For i As Integer = 0 To values.Count - 1
        Dim myValue As String = values(i)
        If myValue.Equals("USA") Then
            labels(i) = "United States of America"
        Else
            labels(i) = values(i)
        End If
    Next
End Sub
```
