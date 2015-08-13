#Settings

[[_TOC_]]

##Properties

|Datatype|Property name|Property description|Default Value|
|:-------|:----------:|:-----------------:|:-----------:|
|Scope|[[DefaultScope|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Settings_DefaultScope]]|Gets the default [[Izenda.AdHoc.Scope|/API/Izenda/AdHoc/Izenda-AdHoc-Scope]] that the settings will use if not otherwise specified.|StaticMemory|
|ScopeCollection|[[SettingScope|/API/Izenda/AdHoc/CodeSamples/Izenda_AdHoc_Settings_SettingScope]]| Gets the collection of scoping levels that settings can use. |{}|


##Methods

###Equals(System.Object)
Determines whether the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].

Parameters: 

* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] obj  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] to compare with the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

true if the specified [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] is equal to the current System.Object; otherwise, false.


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


###GetValue(System.String)
 Gets the value of the setting with the specified name using the scope specified by the setting referenced. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the setting.





Returns:

The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] representation of the setting value.


---


###GetValue(System.String,System.Object)
 Gets the value of the setting with the specified name using the scope specified by the setting referenced. If the setting cannot be found in the scope, the default value is inserted and returned. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the setting.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] defaultValue  - The default value of the setting that will be used when the setting is not found in the appropriate scope.





Returns:

The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value of the setting that was obtained.


---


###SetValue(System.String,System.Object)
 Sets the value of the setting with the specified name using the scope specified by the setting referenced. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the setting.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value to set.





Returns:

The value that the setting was set to.


---


###SetValueInternal(System.String,System.Object)
 Sets the value of the setting with the specified name using the scope specified by the setting referenced. This also sets the default value of the setting. 

Parameters: 

* [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] name  - The [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] representation of the name of the setting.
* [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value  - The [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]] value to set.





Returns:

The value that the setting was set to.


---


###ToString()
Returns a [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].





Returns:

A [[System.String|http://msdn.microsoft.com/en-us/library/s1wwdcbf]] that represents the current [[System.Object|http://msdn.microsoft.com/en-us/library/e5kfa45b]].


---


