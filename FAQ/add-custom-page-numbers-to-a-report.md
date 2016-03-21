#Adding Custom Page Numbers To A Report

[[_TOC_]]

#Question

If I want to add page numbers to a report and the 'Show Page Numbers' property on the [[Style tab|/Guides/ReportDesign/10.0-Style-tab]] tab isn't sufficient, how do I do this?

#Answer

There are two tags you can use in the Page Header or Footer property on the [[Misc tab|/Guides/ReportDesign/9.0-Misc-Tab]]: [pagenumber] and [totalpages]. When a report is exported to pdf or pdf-to-html print, the current and total page numbers will be calculated and placed in the appropriate tag. You can place either or both tags inside of a style div to control appearance, location, or some other property. 