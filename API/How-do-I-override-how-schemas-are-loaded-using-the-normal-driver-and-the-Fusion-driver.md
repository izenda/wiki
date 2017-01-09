#How do I override how schemas are loaded using the normal driver and the Fusion driver?

[[_TOC_]]

##Question

When using AdHocSettings.PerUserCaching = true; and the CurrentUserTenantID changes, Izenda reloads the schema. This can be a lengthy process, so overriding the schema load may improve performance. Below are code samples to override this within the driver.

##Answer

[[Custom Fusion classes for C#|/API/How-do-I-override-how-schemas-are-loaded-using-the-normal-driver-and-the-Fusion-driver/custom_fusion_classes_cs.zip]]

[[Custom Fusion classes for VB|/API/How-do-I-override-how-schemas-are-loaded-using-the-normal-driver-and-the-Fusion-driver/custom_fusion_classes_vb.zip]]