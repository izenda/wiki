#Implementing Scheduler Security

[[_TOC_]]

By default, the Izenda report scheduler queries the reporting site's response server (rs.aspx) page. Due to the response server calling the InitializeReporting method, this will result in any requests sent from the scheduler to run through the normal program flow, including any security measures to require users to login. Since the scheduler cannot interact with the webpage and click a button to securely login normally, it can be somewhat of a challenge to ensure that the scheduler has access to the site.

*Under construction*