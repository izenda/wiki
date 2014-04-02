#How Are Thumbnails Generated For the Izenda ReportList?

- When you open a report in the ReportViewer, a script on ReportViewer page sends an ajax request to the server.

- The server receives the request, and then:

    a) Loads requested reportSet;

    b) Instantiates the HtmlReportRenderer control;

    c) Passes the loaded reportSet to HtmlReportRenderer, and initiates rendering;

    d) When the reportSet is rendered - it is represented by a big string of HTML data. This string contains whole rendered reportSet with all reports, etc;

    e) The server the sends this string back to client;

    f) The server also passes this string to the internal WebBrowser, which renders HTML, and then code performs a screenshot from the WebBrowser and creates a thumbnail.

- The client receives the HTML and injects it into DIV - rendered reportSet appears in client browser.
