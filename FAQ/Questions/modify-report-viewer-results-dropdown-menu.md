#Adding/Removing Values From the Results Dropdown

[[_TOC_]]

##Question

How can I add or remove specific values from the "Results" dropdown list on the Report Viewer page? 

##Answer

The "Records" dropdown menu on the Report Viewer page is simply an unordered list of items with styling applied to it. If you wish to use different values than the pre-built ones, you can "inspect" the item in your browser (F12 for Windows or cmd+click for Mac usually) and find some identifying information. You should then search the "ReportViewer-body.aspx" file for the identifier you chose and you should see an unordered list of items. When you modify this list, you can re-specify as many as you like by following the template we have provided. This method will also work if your company is using a different UI. Here is what the HTML looks like in the demo site provided with Izenda 6.7.

```html
<ul class="dropdown-menu">
      <li onclick="ChangeTopRecords(1, true);" id="resNumLi0"><a href="javascript:void(0)" title="" style="min-width: 12em;">
        <img class="icon" src="rs.aspx?image=ModernImages.result-1-32.png" alt="" />
        <b lang-text="js_Result_1">1 Result</b><br />
        <span lang-text="js_Result_1_Message">Ideal for large forms</span>
      </a></li>
      <li onclick="ChangeTopRecords(10, true);" id="resNumLi1"><a href="javascript:void(0)" title="">
        <img class="icon" src="rs.aspx?image=ModernImages.results-10-32.png" alt="" />
        <b lang-text="js_Result_10">10 Results</b><br />
        <span lang-text="js_Result_10_Message">Good for single parameter reports</span>
      </a></li>
      <li onclick="ChangeTopRecords(100, true);" id="resNumLi2"><a href="javascript:void(0)" title="">
        <img class="icon" src="rs.aspx?image=ModernImages.results-100-32.png" alt="" />
        <b lang-text="js_Result_100">100 Results</b><br />
        <span lang-text="js_Result_100_Message">Default and recommended value</span>
      </a></li>
      <li onclick="ChangeTopRecords(1000, true);" id="resNumLi3"><a href="javascript:void(0)" title="">
        <img class="icon" src="rs.aspx?image=ModernImages.results-1000-32.png" alt="" />
        <b lang-text="js_Result_1000">1000 Results</b><br />
        <span lang-text="js_Result_1000_Message">Good for larger reports</span>
      </a></li>
      <li onclick="ChangeTopRecords(10000, true);" id="resNumLi5"><a href="javascript:void(0)" title="">
        <img class="icon" src="rs.aspx?image=ModernImages.results-10000-32.png" alt="" />
        <b lang-text="js_Result_10000">10000 Results</b><br />
        <span lang-text="js_Result_10000_Message">10000 Results</span>
      </a></li>     
      <li class="divider"></li>
      <li onclick="ChangeTopRecords(-1, true);" id="resNumLi4"><a href="javascript:void(0)" title="">
        <img class="icon" src="rs.aspx?image=ModernImages.results-all-32.png" alt="" />
        <b lang-text="js_Result_All">Show all results</b><br>
        <span lang-text="js_Result_All_Message">Use carefully as this may overload the browser</span>
      </a></li>
    </ul>
```