#Forking The Resources Repository

[[_TOC_]]

##About

The resources repository is where the HTML, CSS, and Javascript reside within the Izenda application. This repository is a public repository to allow customers to be able to modify the resources on an as-needed basis. In order to keep up with changes we make to the resources, it is prudent to fork the repository to keep up with all the updates while maintaining any customizations you might create on your own.

##How to fork

To fork the resources repository, you will need a github account. This can be obtained through your organization or personally and is a straightforward process. Once you have a github account, visit our [[resources repository page|https://github.com/izenda/resources]]. There will be a button at the top of the page that says "Fork". Click this and the repository will be added to your personal repositories. You can now make edits to the resources in your repository without worrying whether you're going to break functionality. Now whenever you update your Izenda.AdHoc.dll to the latest version, instead of copying the Resources from the zipped archive, you will go to your github interface tool (usually a command line, but GUIs are available) and fetch the upstream repository. If there are any conflicts when fetching, you can resolve these using a merge tool. Ideally, there will be no conflicts and your resources will be updated with both your changes and any changes made by us in development. This will allow you to stay current and prevent you from losing any of your own work.