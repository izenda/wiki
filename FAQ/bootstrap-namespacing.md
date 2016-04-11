#Namespace Izenda's Bootstrap Classes to Avoid Conflicts

**Under Construction**
<!--
[[TOC]]

##Introduction
You will need a CSS pre-processor (SASS or LESS) to accomplish this.

##Using SASS
1. To avoid having to change several references throughout the applicaiton, rename main.css (for example, main-no-namespace.css).

2. Create a SASS sheet titled main.scss.

3. Import the renamed file (in this case, main-no-namespace.css) into the SASS sheet _inside_ the new namespace class.  This sheet will compile to main.css.

4. Add the new namespace class (in this case, izenda-bs) to the top-level Izenda div.  In our vanilla reference implementations, all Izenda pages render inside of the first div below the body tag in the Default.master page.

5. Repeat 1-4 for the Report.css stylesheet.

##Using LESS

-->