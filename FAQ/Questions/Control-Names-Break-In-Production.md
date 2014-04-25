#Control Names Break In Production

[[_TOC_]]

##Question

My control names change when deployed from development to production and I can't access them. How do I fix this?

##Answer

This behavior is expected. Generic controls generated at runtime will have dynamic clientIDs created for them depending on many factors. For instance, in development, the "Save As" button on the report designer might appear as "ctl0_PlaceHolder_Adhocreportdesigner1_ctl1_SaveAsButton_Content" but when deployed to production it changes to "ctl00_PlaceHolder_Adhocreportdesigner1_ctl01_SaveAsButton_Content". 

The problem begins when attempting to use javascript to affect custom behavior. Izenda allows you to control many built-in control behaviors and there is probably already an API entry to allow you to control behavior as you desire. You can review our article on the [[Report Designer|http://wiki.izenda.us/API/CodeSamples/ReportDesigner]] to achieve the desired result.