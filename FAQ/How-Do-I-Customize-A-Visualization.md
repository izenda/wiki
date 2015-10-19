#Custom Visualization

[[_TOC_]]

##Preface

This page is about creating a new visualization, or customizing an existing visualization. This page will explain the major statements and components of the javascript that powers a visualization.

## 1. Create directory to contain visualization

Create a directory with the path: izenda_root\Resources\Vis\category_name\visualization_name

## 2.  Create View.html

View.html is the main file of each visualization. It should contain:

*Used CSS styles wrapped in style tags (attachment of external CSS files is not supported). To access proper container using Javascript, apply styles to suitable elements inside visualization area use a keyword VIS_ID, which will be replaced with valid visualization identifier in server response

    <style type="text/css">
        #VIS_ID_CONTAINER > span.theme { font-size: 14px; }
        #VIS_ID > span.body { font-size: 12px; }
    </style>

* Markup - html template of visualization. To correctly initiate visualization, its html tempate should have root element with id="VIS_ID"; in case of complex templates (where VIS_ID is used to identify more specific area), id should be replaced with VIS_ID_CONTAINER
    <div id="VIS_ID_CONTAINER">
        <span class="theme">Title</span>
        <div id="VIS_ID">
            <span class="body">Body</span>
        </div>
    </div>

* To use any number of external scripts use <scriptsrc="file_name.js"></script> tag. There are several commonly used scripts, like d3, highcharts etc., all these files stored outside of visualization folder - site_path\Resources\Vis\.scripts. To use one of them in new visualization just type its name and Izenda will attach appropriate file automatically. After user open report with attached visualization, all used scripts (including scripts that contain scripting statements) will be delivered to client via AJAX request and then executed separately one by one in global context using ReportScripting.globalEval method. To debug these scripts use debugger statement in one of executed scripts, or manually place breakpoint inside globalEval method.

## 3. Add Main script statement to View.html

That's primary code, which should somehow execute itself. Next statement can be used as an example (name was kept to be able to use the reference to method from inside its body)
    <script type="text/javascript">
	    (function ExecuteVIS_ID() {
		    /* code */
	    })();
    </script>

To get access to utility code, which can help with data aggregation, general visualization workflow use global object ReportScripting. Commonly visualization begin from declaration reference to it:

    var util = window.ReportScripting;

To properly recreate visualization each time window resize, use util.registerResize method, which should be called with next three parameters

    function registerResize(VIS_ID, execute, clearing);

* VIS_ID - string value with current visualization id (must be "VIS_ID")
* execute - reference to main method of visualization to run it again after resize
* clearing - reference to method, which run clearing routines soexecute method can be called safety without any intersections with previously created DOM elements.

Here is a simple example of registration (jq$ - reference to jQuery used all across the Izenda to avoid intersections with customers' installations of this library)

    util.registerResize("VIS_ID", ExecuteVIS_ID, function () {
	    jq$("#VIS_ID").empty();
    });

To interact with the report there are four variables in context where visualization is currently executing: VIS_FORMJSASTATUS,VIS_COLUMNS, VIS_ROWS, VIS_CONTEXT. To validate input meets requirements, use method util.validate:
    function validate(VIS_ID, VIS_FORMJSASTATUS, VIS_CONTEXT, requirements)

*VIS_ID - string with current visualization id (must be "VIS_ID")

*VIS_FORMJSASTATUS - status, which alerts user about problems with rendering report data on the server (in common, should equals "OK")

*VIS_CONTEXT - data about current executing context: is visualization loaded into dashboards, is visualization rendering to image or other static context, , report's title etc. To navigate and see its actual values use debugger statement, place it on the beginning of visualization and then view it using Report Viewer, or Preview tab on Report Designer.

*requirements - object, which can notify utility code to check custom environment properties and run additional validation of input data. This object support next fields: svg, canvas, d3,animation - all of them are boolean flags, which ask to run appropriate feature check. The last field "input" ask to run validation function implemented by user (to check the report have necessary structure: type, count of fields etc.), this field accept boolean value too to simply handle validation result. Here is a few examples how to use it:

`if (!util.validate("VIS_ID", VIS_FORMJSASTATUS, VIS_CONTEXT, { d3: true, svg: true, input: VIS_COLUMNS[0].type == 'DateTime' })) return; `

`if (!util.validate("VIS_ID", VIS_FORMJSASTATUS, VIS_CONTEXT, { svg: true, input: function () { return VIS_COLUMNS[0].type == 'DateTime'; }})) return;`

* If validation fail, html template of visualization will be cleared and user will be notified with enumeration of encountered problems. In that case util.validate() will return false, any further code statement should be skipped and execution aborted.

To use use full list of available utilities, create an instance of ReportScripting by using its function as constructor, pass visualization id and all four context variables:
var vis = new util("VIS_ID", VIS_FORMJSASTATUS, VIS_COLUMNS, VIS_ROWS, VIS_CONTEXT);

Created object have several privileged methods, which give possibility to build different data structures from plain report table suitable for current needs

*collectTree - build tree-like structure. Will not return result, which can be found here: vis.items. This method will create clear parent->children structure without any customization.

* traverseTree - if called after collectTree, will return root object with customized tree structure built from vis.items. This method is recursive and should be called with single parameter - callback function, which accept one "context" parameter { parentNode, node, indexes, level, fi, isLeaf }, which should be updated during callback execution.

* collectMonthlyData - will collect data from the report with three fields: category (GROUP), date (Group (Year & Month)) and one integer value

* collectGraph - will create oriented graph where first two report fields used as nodes and other integer fields determines as metrics