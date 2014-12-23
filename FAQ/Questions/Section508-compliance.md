#Section 508 Compliance

[[_TOC_]]

##Question

Is Izenda Section 508 Compliant? Does Izenda have a VPAT or any intention of obtaining one if not?

##Answer

No, Izenda is not completely 508 compliant. By default, any images such as logo images and toolbar buttons have alt text to enable screen-readers to identify them. Additionally, charts and gauges have alt text when the [[/API/CodeSamples/UseImageDescriptions]] setting is enabled. However, this only applies to charts that render their content as an image. Other charts are made up of SVG 1.1 elements that some Assistive Technologies can read fairly well via the Accessibility API available in modern browsers. However, the SVG elements themselves do not generally use <title> elements. These <title> elements are only read by certain browsers currently, and only IE can make very good use of them. Izenda also does not use <desc> tags on SVG elements currently, but again browser support for <desc> tags is about as limited as support for <title> tags. Izenda does, however, use <text> tags to expose the rendered textual elements. Therefore, the text on the SVG charts is highly accessible to screen readers.

Izenda has not received a VPAT and does not at this time have any plans of obtaining one. Since we integrate into customer websites, and since we aim to be highly customizable for each client's needs, the information above should be considered when applying for or renewing a VPAT.