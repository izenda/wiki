#Custom Visualization

[[_TOC_]]

##Preface

This page is about creating a new visualization, or customizing an existing visualization. This page will explain the major statements and components of the javascript that powers a visualization. If you want to customize a chart instead, check the [[CustomizeChart|/FAQ/CustomizeChart]] method.

## Setup

First, create a directory with the path: izenda_root\Resources\Vis\category_name\visualization_name

Next, create View.html. This is the main file of each visualization. It should contain:

### CSS

Any CSS styles should be wrapped in style tags (the attachment of external CSS files is not supported). To access the proper container using Javascript, apply styles to suitable elements inside visualization area using the keyword VIS_ID, which will be replaced with a valid visualization identifier in the server response:

    <style type="text/css">
        #VIS_ID_CONTAINER > span.theme { font-size: 14px; }
        #VIS_ID > span.body { font-size: 12px; }
    </style>

### HTML

Any HTML used to construct the visualization should also be in View.html. To correctly initiate visualization, its HTML tempate should have a root element with id="VIS_ID"; in the case of complex templates (where VIS_ID is used to identify more specific area), id should be replaced with VIS_ID_CONTAINER:

    <div id="VIS_ID_CONTAINER">
        <span class="theme">Title</span>
        <div id="VIS_ID">
            <span class="body">Body</span>
        </div>
    </div>

### JavaScript

You may incorporate external scripts by using the <scriptsrc="file_name.js"></script> tag. Some commonly used scripts, such as D3 and HighCharts, are stored outside of the visualization folder at site_path\Resources\Vis\.scripts. To use one of them in a new visualization just type its name and Izenda will attach the appropriate file automatically. After a user opens a report with an attached visualization, all used scripts (including scripts that contain scripting statements) will be delivered to the client via AJAX request and then executed separately one by one in global context using the ReportScripting.globalEval method. To debug these scripts, use a debugger statement in one of the executed scripts, or manually place breakpoints inside the globalEval method.

## Create your main script

This is the primary code, which should be self-executing:
    <script type="text/javascript">
	    (function ExecuteVIS_ID() {
		    /* code */
	    })();
    </script>

To get access to utility code, which can help with data aggregation, general visualization workflow, and so on, use the global object ReportScripting. Visualizations commonly begin from a declaration reference to it:

    var util = window.ReportScripting;

To properly recreate visualizations each time the browser window resizes, use the util.registerResize method, which should be called with three parameters

    function registerResize(VIS_ID, execute, clearing);

* VIS_ID - A string value with current visualization id (must be "VIS_ID").
* execute - A reference to the main method of the visualization to run it again after resizing.
* clearing - A reference to thsi method, which runs clearing routines so the executed method can be called safety without any intersections with previously created DOM elements.

Here is a simple example (jq$ is a reference to jQuery used across the Izenda platform to avoid intersections with individual customer installations of this library)

    util.registerResize("VIS_ID", ExecuteVIS_ID, function () {
	    jq$("#VIS_ID").empty();
    });

To interact with the report, there are four variables in the context where the visualization is currently executing: VIS_FORMJSASTATUS, VIS_COLUMNS, VIS_ROWS, VIS_CONTEXT. To validate that input meets requirements, use the method util.validate:

    function validate(VIS_ID, VIS_FORMJSASTATUS, VIS_CONTEXT, requirements)

*VIS_ID - A string with current visualization id (must be "VIS_ID").

*VIS_FORMJSASTATUS - A status, which alerts users about problems with rendering report data on the server.

*VIS_CONTEXT - data about current executing context: is visualization loaded into dashboards, is visualization rendering to image or other static context, report's title, etc. To navigate and see its actual values, use a debugger statement at the beginning of visualization and then view it using Report Viewer, or Preview tab on Report Designer.

*requirements - An object, which can notify utility code to check custom environment properties and run additional validation of input data. This object support next fields: svg, canvas, d3,animation - all of them are boolean flags, which ask to run appropriate feature check. The last field "input" ask to run validation function implemented by user (to check the report have necessary structure: type, count of fields etc.), this field accept boolean value too to simply handle validation result. Here is a few examples how to use it:

`if (!util.validate("VIS_ID", VIS_FORMJSASTATUS, VIS_CONTEXT, { d3: true, svg: true, input: VIS_COLUMNS[0].type == 'DateTime' })) return; `

`if (!util.validate("VIS_ID", VIS_FORMJSASTATUS, VIS_CONTEXT, { svg: true, input: function () { return VIS_COLUMNS[0].type == 'DateTime'; }})) return;`

* If validation fails, HTML template of the visualization will be cleared and user will be notified with enumeration of any problems. In that case util.validate() will return false, any further code statement should be skipped and execution terminated.

To use the full list of available utilities, create an instance of ReportScripting by using its function as constructor, pass visualization id and all four context variables:

`var vis = new util("VIS_ID", VIS_FORMJSASTATUS, VIS_COLUMNS, VIS_ROWS, VIS_CONTEXT);`

The created object will have several privileged methods, which gives the possibility to build different data structures from a plain report table.

* collectTree - builds a tree-like structure. Will not return result, which will be found in vis.items. This method will create a clear parent->children structure without any customization.

* traverseTree - if called after collectTree, will return root object with customized tree structure built from vis.items. This method is recursive and should be called with single parameter, a callback function, which accepts one "context" parameter { parentNode, node, indexes, level, fi, isLeaf }, which should be updated during callback execution.

* collectMonthlyData - will collect data from the report with three fields: category (GROUP), date (Group (Year & Month)) and one integer value.

* collectGraph - will create oriented graph where first two report fields are used as nodes and the other integer fields determined as metrics.

##Modifying Existing Visualizations

###Aligning Sunburst to Grid

In Sunburst's View.html, change this:

```jscript
var g1 = d3.select("#VIS_ID")
	.append("svg:svg")
		.attr("width", width)
		.attr("height", heightWithOffset);
var g = g1.append("svg:g")
	.attr("class", "container")
	.attr("transform", "translate(" + width / 2 + "," + heightWithOffset / 2 + ")");
g1.append("svg:circle")
	.attr("r", radius * 0.47)
	.attr("transform", "translate(" + width / 2 + "," + heightWithOffset / 2 + ")")
	.style("fill", "#ffffff");
var g2 = g1.append("svg:g");
var explanation = g2.append("svg:text")
	.attr("x", "0")
	.attr("y", "0")
	.attr("style", "fill: #666; color: #666; font-size: 2.5em; align: center; pointer-events: none");
var percentage = explanation.append("tspan")
	.attr("x", "0")
	.attr("dy", "0")
	.attr("text-anchor", "middle")
	.attr("style", "fill: #666; color: #666; font-size: 30px; align: center; font-family: 'Open Sans', sans-serif;")
	.text("100%");
explanation.append("tspan")
	.attr("x", "0")
	.attr("dy", "2.5em")
	.attr("text-anchor", "middle")
	.attr("style", "fill: #666; color: #666; font-size: 12px; align: center; font-family: 'Open Sans', sans-serif;")
	.text(expText);

var tw = g2.node().getBBox().width, th = g2.node().getBBox().height,
	actualRadius = Math.sqrt((tw * tw + th * th) / 4),
	textScaleFactor = (actualRadius > 0) ? (radius * 0.3 / actualRadius) : 1;
g2.attr("transform", "translate(" + width / 2 + "," + heightWithOffset / 2 + ") scale(" + textScaleFactor + ")");

```

To this:

```jscript
ar left = heightWithOffset * 0.5;
var center = width * 0.5;
var rigth = width - heightWithOffset * 0.5;

var align = center;

var g1 = d3.select("#VIS_ID")
	.append("svg:svg")
		.attr("width", width)
		.attr("height", heightWithOffset);
var g = g1.append("svg:g")
	.attr("class", "container")
	.attr("transform", "translate(" + align + "," + heightWithOffset / 2 + ")");
g1.append("svg:circle")
	.attr("r", radius * 0.47)
	.attr("transform", "translate(" + align + "," + heightWithOffset / 2 + ")")
	.style("fill", "#ffffff");
var g2 = g1.append("svg:g");
var explanation = g2.append("svg:text")
	.attr("x", "0")
	.attr("y", "0")
	.attr("style", "fill: #666; color: #666; font-size: 2.5em; align: center; pointer-events: none");
var percentage = explanation.append("tspan")
	.attr("x", "0")
	.attr("dy", "0")
	.attr("text-anchor", "middle")
	.attr("style", "fill: #666; color: #666; font-size: 30px; align: center; font-family: 'Open Sans', sans-serif;")
	.text("100%");
explanation.append("tspan")
	.attr("x", "0")
	.attr("dy", "2.5em")
	.attr("text-anchor", "middle")
	.attr("style", "fill: #666; color: #666; font-size: 12px; align: center; font-family: 'Open Sans', sans-serif;")
	.text(expText);

var tw = g2.node().getBBox().width, th = g2.node().getBBox().height,
	actualRadius = Math.sqrt((tw * tw + th * th) / 4),
	textScaleFactor = (actualRadius > 0) ? (radius * 0.3 / actualRadius) : 1;
g2.attr("transform", "translate(" + align + "," + heightWithOffset / 2 + ") scale(" + textScaleFactor + ")");
```