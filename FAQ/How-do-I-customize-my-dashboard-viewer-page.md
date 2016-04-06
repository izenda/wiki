#How do I customize my dashboard viewer page

[[_TOC_]]

##Question

How can I customize my dashboard viewer page, and what can I customize?

##Answer

The dashboard list is not natively sorted. There is no maximum number of dashboard tiles, though browser performance will be impacted by each tile and large dashboards may load slowly on some systems (30+ tiles). You may override and customize these items:

###Dashboard Color

Typically, this is stored in cookies on a given user's computer. You can force a given image by overriding:

Resources/components/dashboard/templates/toolbar.html

Inside of which is the angular component: 

```html
<div izenda-dashboard-background ... >
```

There this behavior can be defined as a default for all users.

###Dashboard Verbose List

The text links to each dashboard in the dashboard viewer can be turned off, leaving only the folder to navigate category/dashboard name. Modify this file:

Resources/components/dashboard/templates/toolbar.html

Find this element:

```html

<div class="iz-dash-linkspanel-container" ng-show="!toolbarController.isButtonBarVisible">

```

And change it to: 

```html
<div class="iz-dash-linkspanel-container" ng-show="false">
```

###Dashboard Background Image

In dashboard.css, you can override the following class:

"iz-dash-background" 

And establish some property such as:

background-image: url('Resources\images\ExampleBackground.png');