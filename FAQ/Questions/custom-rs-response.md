#Creating a custom RS.aspx response

[[_TOC_]]

##Question

How do I create a server response for a custom javascript function to use in my reporting application?

##Answer

Creating a server response for a custom procedure for your application can be quite an involved procedure, depending on what needs to be done. However, the basic steps will be detailed below. This basic structure can be utilized to create any kind of custom response that returns a JSON document. Non-JSON formatted responses can also be returned, but the evaluation will need to differ from this example. Details concerning how to implement specific types of responses can be evaluated by our integration engineers.

###Step 1: Modify rs.aspx.cs

The first item to address is the rs (response server) page in the code-behind. This is where all server requests are routed through, depending on the query string parameters that are sent to it. In the example below, we will use a wscmd query string variable to hold the custom command. Any name can be used for the query string variable, but wscmd is a standard part of the Izenda product.

We will also use the query string parameters wsarg0 and wsarg1 to pass parameters to the command.

```csharp
public partial class rs : Izenda.AdHoc.ResponseServer
{
    //The OnPreInit() and OnInit() methods will not be included in this example, since they do not change from the default.
    
    protected override void OnLoad(EventArgs e)
    {
        string wsCommand = null;
        List<string> wsArgs = new List<string>();
        //Ensure the HttpMethod is a GET method and check if we have a wscmd parameter
        if (Request.HttpMethod == "GET" || !String.IsNullOrEmpty(Request.Params["wscmd"])) // retrieve GET params
        {
            wsCommand = Request.Params["wscmd"];
            int argNum = 0;
            string arg = Request.Params["wsarg" + argNum];
            //loop until our wsarg[x] is empty
            while (arg != null)
            {
                wsArgs.Add(arg);
                argNum++;
                arg = Request.Params["wsarg" + argNum];
            }
        }
        if (wsCommand != null)
        {
            if (wsCommand.Equals("customRSCommand"))
            {
                //Create a response that can be read by the javascript method used as a callback method
                string response = "\"" + string.Join("\":\"", wsArgs.ToArray()) + "\"";
                Response.Clear();
                Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
                Response.Cache.SetValidUntilExpires(false);
                Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();
                Response.Cache.SetMaxAge(new TimeSpan(0));
                Response.Write(response);
                Response.End();
            }
        }
        //perform the standard server request processing last. Many of the base cases will exit the method completely once the procedure completes.
        base.OnLoad(e);
    }
```

###Step 2: Create or modify your javascript

In order to send a request to the server from the client, the javascript file called "main.js" can be modified to hold any command you want to use. It is included in the Default.Master and will be available throughout the entire site as long as the master page is being used. The AjaxRequest method is available from various scripts within different reporting pages and calls the eval() method on the response data, making the return object a JSON formatted object. Keep this in mind when constructing a custom RS command.

```javascript
// Copyright (c) 2005-2013 Izenda, L.L.C. - ALL RIGHTS RESERVED    

// JavaScript

function CustomRSCommand() {
    var requestString = 'wscmd=customRSCommand';
    requestString += '&wsarg0=' + 'returnJSONPropertyName';
    requestString += '&wsarg1=' + 'returnJSONPropertyValue';
    AjaxRequest('./rs.aspx', requestString, CustomRSResponse, null, 'customRSCommand');
}

function CustomRSResponse(returnObj, id)
{
    jq$("#pCopy").html(returnObj.returnJSONPropertyName);
}
```

You can see that the AjaxRequest uses the CustomRSResponse function as a parameter. The function will be called asynchronously when the server response is returned back to the client. So that is where your processing will need to take place. In this example, the response returned will use the wsarg0 string as the formatted JSON document property name, and wsarg1 as the property value. Essentially, the response will be {["returnJSONPropertyName":"returnJSONPropertyValue"]}. If wsarg2=returnJSONPropertyName2 and wsarg3=returnJSONPropertyValue2 were used, the response would be {["returnJSONPropertyName":"returnJSONPropertyValue":"returnJSONPropertyName2":"returnJSONPropertyValue2"]} which would not be valid JSON. So tailor the processing to suit your needs.

###Step 3: Implement your javascript call

In order to start using your custom RS command, you will need to call it somewhere within your website. For instance, in the jQuery standard (document).ready() function, as shown below. How you want to call your command depends again upon your particular use case.

```javascript
$(document).ready(function () {
    CustomRSCommand();
});

```