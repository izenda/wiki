#Adding Fixed Unit Convesions

Functions are added to Izenda through the extended functions API code. You can learn more about UDFs (User Defined Functions) [[here|http://wiki.izenda.us/FAQ/izenda-and-udfs]].

These functions are available in the 'Functions' drop-down. They can also be used in an expression by clicking the gear to the right side of the field.

>_**The specific process to deploy functions depends how the data is stored in the DB, and what the use-case is.**_

**Example 1**: _Data stored in Meters - Output needed in Meters, Kilometers and Miles._

If the data for a distance column was stored in meters lets say, and you wanted to display either **meters**, **miles** or **kilometers**. You would add [[custom Formats|/FAQ/Questions/Add-Formatting-Options]] to display desired values to append _(m, km, mi)_, and custom functions to do the conversion to **Miles** and **Kilometers** from **meters**.

**To use Example 1 in tool once API work is done:**

1. User selects column 'Distance'.
2. User selects the appropriate choices for their needs
    * To display meters; user chooses no function, and chooses 'm' in format.
    * To display in Miles; user chooses 'Miles' in function dropdown, and 'mi' in format.
    * To display in Kilometers; user chooses 'Km' in function dropdown, and 'km' in format.

-----

**Example 2**: _Data stored in KpG (Kilometers/Gallon) - Output needed in both 'KpG' and 'MpG' (Miles/Gallon)._ 

1. Add custom Function to convert KpG -> MpG to DB.
2. Add custom Function from DB to Izenda (API)
3. Add custom Formats for 'MpG' and 'KpG'
    * To display KpG: Choose mileage field, choose no function, choose 'KpG' format.
    * To display MpG: Choose mileage field, choose 'MpG' function, choose 'MpG' format.