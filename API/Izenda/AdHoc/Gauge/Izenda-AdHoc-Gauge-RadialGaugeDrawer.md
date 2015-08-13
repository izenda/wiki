#RadialGaugeDrawer

[[_TOC_]]

##Properties

None.


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


---


###GetGauge(System.Double,System.Double,System.Double,System.String,System.Double,System.Boolean,Izenda.AdHoc.FieldHighlightInfo,out System.String,System.Collections.Hashtable)
Returns a [[System.Drawing.Image|http://msdn.microsoft.com/en-us/library/k7e7b2kd]] representation of the gauge created using the specified parameters.

Parameters: 

* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] value  - The field value that is being rendered.
* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] min  - The minimum value to display on the gauge.
* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] max  - The maximum value to display on the gauge.
* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] gaugeStyle  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the style of gauge being rendered.
* [[System.Double|http://msdn.microsoft.com/en-us/library/643eft0t]] summValues  - The total sum of all values in the same column being used as the gauge value.
* [[System.Boolean|http://msdn.microsoft.com/en-us/library/a28wyd50]] useCurrencyFormat  - Determines whether or not to format the gauge value as currency.
* [[Izenda.AdHoc.FieldHighlightInfo|/API/Izenda/AdHoc/Izenda-AdHoc-FieldHighlightInfo]] color  - The [[Izenda.AdHoc.FieldHighlightInfo|/API/Izenda/AdHoc/Izenda-AdHoc-FieldHighlightInfo]] color to use as the color of the gauge.
* out [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] additionalAttrs  - Any CSS attributes that should be used on the control containing the gauge.
* [[System.Collections.Hashtable|http://msdn.microsoft.com/en-us/library/aahzb21x]] chartProperties  - A lookup table of additional properties that the gauge needs to render.





Returns:

The [[System.Drawing.Image|http://msdn.microsoft.com/en-us/library/k7e7b2kd]] generated from the input values.


---


###GetHashCode()
 Serves as a hash function for a particular type.  





Returns:

A hash code for the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


###GetType()
Gets the [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] of the current instance.





Returns:

The [[System.Type|http://msdn.microsoft.com/en-us/library/42892f65]] instance that represents the exact runtime type of the current instance.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


