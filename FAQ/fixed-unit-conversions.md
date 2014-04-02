#How Do I Add Fixed Unit Conversions in Izenda So Users Can Easily Access Them?

Functions are added to Izenda through the extended functions API code. This article explains how with an example:

[[Izenda and UDFs (User Defined Functions)|http://wiki.izenda.us/FAQ/izenda-and-udfs]]

These functions are available in the 'Functions' drop-down. They can also be used in an expression by clicking the gear to the right side of the field.

>_**The specific process to deploy functions depends how the data is stored in the DB, and what the use-case is.**_

**Example 1**: _Data stored in Meters - Output needed in Meters, Kilometers and Miles._

If the data for a distance column was stored in meters lets say, and you wanted to display either **meters**, **miles** or **kilometers**. You would add custom Formats (http://www.izenda.com/Site/KB/CodeSamples/Adding-Custom-Formats?) to display desired values to append _(m, km, mi)_, and custom functions to do the conversion to **Miles** and **Kilometers** from **meters**.

**TO use Example 1 in tool once API work is done:**

    1. User selects column 'Distance'.

    2a. To display meters; user chooses no function, and chooses 'm' in format.

    2b. To display in Miles; user chooses 'Miles' in function dropdown, and 'mi' in format.

    2c. To display in Kilometers; user chooses 'Km' in function dropdown, and 'km' in format.

-----

**Example 2**: _Data stored in KpG (Kilometers/Gallon) - Output needed in both 'KpG' and 'MpG' (Miles/Gallon)._ 

    1) Add custom Function to convert KpG -> MpG to DB.

    2) Add custom Function from DB to Izenda (API)

    3) Add custom Formats for 'MpG' and 'KpG'

    4a) To display KpG: Choose mileage field, choose no function, choose 'KpG' format.

    4b) To display MpG: Choose mileage field, choose 'MpG' function, choose 'MpG' format.