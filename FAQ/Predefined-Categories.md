#Predefined Categories

[[_TOC_]]

##Preface
Izenda allows you to save reports and dashboards into categories for organization. While categories can be defined at save, they can also be predefined and placed in the category drop-down menu.

##Usage
This feature is useful when you want to limit the users ability to create new categories. It is also useful if you know all of the categories ahead of time and there is no need for users to create them.

##Instructions
In Webforms, add the following code snippet to the header of the ReportDesigner.aspx file.
In MVC, add the following code snippet to the ReportDesigner-Head.ascx file.

```html
<script type="text/javascript">
    jq$(document).ready(function () {
        reportCategories = ",Category 1,Category 2,Category 3";
    });
</script>
```