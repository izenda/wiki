[[_TOC_]]

#Introduction

Izenda uses a host of minified files for performance improvement. When making updates the the .CSS files or occasionally when updating, the minified versions (.min.css) of the CSS files will need to be updated or generated. This can be done using Grunt.

# Instructions

1. Go to nodejs.org and download the latest version of NodeJS.
2. Open your command line and type **_npm install -g grunt-cli_**
3. Navigate to the root of the folder where you have Izenda. You can tell this is the folder as there will be a gruntfile.js
4. After navigating to this location, simply type **_grunt_** 
5. If all went well, you should see a list of files, their size and their
compressed size in the console.