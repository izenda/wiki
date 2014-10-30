#Run javascript via url links

[[_TOC_]]

##Question

Can I customize links in reports to use javascript functions?

##Answer

Yes, you can. This can be performed on the report designer's fields tab when you click on the **Advanced** settings button next to a field. When the box pops up, there will be a URL textbox that can accept links as well as custom javascript. This can be used to count clicks, set hidden field values, send ajax requests, etc. To use this, simply place the method call in the URL field of advanced field properties with _**"javacript:"**_ before it.


![CustomJavascriptClick](http://wiki.izenda.us/FAQ/FAQ/custom_javascript_click.png)
