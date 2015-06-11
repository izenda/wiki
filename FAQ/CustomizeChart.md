#CustomizeChart()

[[_TOC_]]

##About

The CustomizeChart method is used to modify chart objects on a per-report basis. Different [[charting engines|/API/CodeSamples/ChartingEngine]] require different checks and some are easier to modify than others due to the way the charting engines structure their data. 

##Dundas Charts

Here is an example method using the Dundas charting engine. API calls can be made to the Dundas.Charting.WebControl.Chart object to typecast the chart and work with it. The reference to the same in-memory object should be kept while you're editing the typecast chart. This means you will not have to re-assign your "chart" object back to "obj", as they reference the same address.

```csharp
public override void CustomizeChart(object obj)
{
    Dundas.Charting.WebControl.Chart chart = obj as Dundas.Charting.WebControl.Chart;
    chart.Width=700;
    foreach (Dundas.Charting.WebControl.Series series in chart.Series)
    {
        series.BackGradientType = Dundas.Charting.WebControl.GradientType.None;
    }
}//end method
```

##HtmlCharts

The HTMLCharts objects are more difficult to work with. Since HighCharts is a javascript library, there is no explicit C# namespace to call. In this case, the entire chart exists within a StringBuilder object and will be injected into the page when it is rendered. In order to interact with this type of chart, one must modify the StringBuilder object with whatever customizations are required. A sample output chart will be displayed below to provide a glimpse of what to expect when working with the CustomizeChart method with respect to HTMLCharts.

_**Note:** Since the chart is rendered after any javascript page events are called, it is not possible to interact with the rendered chart via javascript unless you insert the javascript that will do this into the string returned by CustomizeChart._

```javascript
<div>
    <div id='LineChart433189727' style='min-width: 300px; position:relative; width: 99%; overflow:hidden;'></div>
    <script type='text/javascript'>
        if (typeof String.prototype.trim !== 'function') {    
            String.prototype.trim = function () {        
                return this.replace(/^\\s+|\\s+$/g, '');    
            }
        }
        var LineChart433189727Instance;
        jq$(document).ready(function() {
            var container$ = jq$('#LineChart433189727');
            try {
                function FixLineChart433189727Width(cont) {
                    return;
                    var fullOffset = 0;
                    var currentObj = cont;
                    while (currentObj != null) {
                        if (currentObj.offsetLeft !== 'undefined' && currentObj.offsetLeft != null && fullOffset < currentObj.offsetLeft)
                            fullOffset = currentObj.offsetLeft;
                        currentObj = currentObj.parentElement;
                    }
                    var maxWidth = jq$(window).width() - 2 * fullOffset;
                    cont.style.width = maxWidth + 'px';
                }
                if (typeof htmlChartColors == 'undefined' || htmlChartColors == null || htmlChartColors.length == 0) {
                    htmlChartColors = ['#2f7ed8', '#0d233a', '#8bbc21', '#910000', '#1aadce', '#492970','#f28f43', '#77a1e5', '#c42525', '#a6c96a'];
                    Highcharts.setOptions({
                        colors: htmlChartColors});
                    Highcharts.dateFormats = {
                        Z: function (timestamp) {
                            var monthNames = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
                            var date = new Date(timestamp),
                                month = date.getMonth();
                            return monthNames[month];
                        }
                    };
                }
                var chartCont = jq$('#LineChart433189727');
                FixLineChart433189727Width(chartCont[0]);
                var w = chartCont.width();
                var rotationValue = 0;
                if (w < 550) {
                    rotationValue = 270;
                }
                LineChart433189727Instance = new Highcharts.Chart(
                {
                    chart: { renderTo:'LineChart433189727', animation: true, height: 300, type: 'line' }, 
                    credits: { enabled: false }, 
                    legend: { enabled: true }, 
                    title: { text: '' }, 
                    tooltip: { shared: true },
                    xAxis: { categories: ['1996-Q3', '1996-Q4', '1997-Q1', '1997-Q2', '1997-Q3', '1997-Q4', '1998-Q1', '1998-Q2'], labels: { rotation: rotationValue }, title: { text: 'Month and Year of Order' }, type: 'category' }, 
                    yAxis: { labels: { enabled: true, formatter: function(){ 
                        return jq$.formatNumber(this.value, {
                            format:"#,###.00",locale:"us",customPrefix:"$"});} }, title: { text: 'Total Freight' } }, 
                    series: [{ 
                        tooltipPointCustomFormatter: '{format:\"#,###.00\",locale:\"us\",customPrefix:\"$\"}', 
                        data: [{ y: 0 }, { dataLabels: { y: -12 }, y: 415.57 }, { y: 1336.37 }, { dataLabels: { y: 21 }, y: 539.14 }, { y: 2254.08 }, { y: 846.69 }, { dataLabels: { y: -12 }, y: 659.73 }, { dataLabels: { y: -12 }, y: 270.32 }], 
                        name: 'Canada', type: 'spline' }, { 
                        tooltipPointCustomFormatter: '{format:\"#,###.00\",locale:\"us\",customPrefix:\"$\"}', 
                        data: [{ dataLabels: { y: -12 }, y: 313.49 }, { y: 323.5 }, { dataLabels: { y: 21 }, y: 333.96 }, { y: 1330.07 }, { y: 254.18 }, { dataLabels: { y: 21 }, y: 11.99 }, { y: 504.75 }, { y: 157.57 }], 
                        name: 'Mexico', type: 'spline' }, 
                        { tooltipPointCustomFormatter: '{format:\"#,###.00\",locale:\"us\",customPrefix:\"$\"}', 
                        data: [{ y: 2533.41 }, { y: 3742.1 }, { y: 3813.16 }, { y: 2719.32 }, { y: 9389.36 }, { y: 4853.12 }, { y: 11321.68 }, { y: 7793.67 }], 
                        name: 'USA', type: 'spline' }]
                }, function(chartObj) 
                    {
                        var previousWidth = chartCont.width();
                        if (typeof previousWidth === 'undefined')
                            previousWidth = 0;
                        jq$(window).on('resize.LineChart433189727', 
                            function() {
                                var chartCont = jq$('#LineChart433189727');
                                if (chartCont.length == 0 || typeof chartCont[0] == 'undefined')
                                    return;
                                FixLineChart433189727Width(chartCont[0]);
                                var newWidth = chartCont.width();
                                if (newWidth !== previousWidth) {
                                    if (typeof chartObj.options.xAxis[0].labels === 'undefined') {
                                        chartObj.options.xAxis[0].labels = {};
                                    }
                                    if (newWidth < 550) {                        
                                        chartObj.options.xAxis[0].labels.rotation = 270;
                                        chartObj.xAxis[0].update();
                                    } 
                                    else {
                                        chartObj.options.xAxis[0].labels.rotation = 0;
                                        chartObj.xAxis[0].update();
                                    }
                                }
                                previousWidth = newWidth;
                            }
                        );
                    }
                );
                container$.closest('div.autoWide').find('p.renderedControlContainer>span').remove();
                var childSpan = document.getElementById('LineChart433189727_outerSpan');
                if (childSpan != null) {
                    var parentDiv = childSpan.parentElement;
                    var fullOffset = 0;
                    var currentObj = parentDiv;
                    while (currentObj != null) {
                        if (currentObj.offsetLeft !== 'undefined' && currentObj.offsetLeft != null)
                            fullOffset += currentObj.offsetLeft;
                        currentObj = currentObj.parentElement;
                    }
                    var spanLeft1 = ((jq$(window).width() - 2 * fullOffset) - childSpan.clientWidth) / 2;
                    var spanLeft2 = parentDiv.clientWidth - childSpan.clientWidth;
                    var leftest = spanLeft1;
                    if (spanLeft2 < leftest)
                        leftest = spanLeft2;
                    if (leftest < 0)
                        leftest = 0;
                    childSpan.style.left = leftest + 'px';
                    childSpan.style.position = 'relative';
                }
            } catch (e) {
            throw 'High chart initialization error: ' + e;
            }
            });
        </script>
</div>
```

##VISION

Visualizations must be customized directly within the /Vis directory. Please see the D3 documentation for more information. https://github.com/mbostock/d3/wiki