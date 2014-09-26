With the release of 6.8, it is important to note that css configuration may 'break' your configuration of the product. To make necessary adjustments, please check the following configuration in your .aspx pages to make sure you have the configuration set up correctly:

<link rel='stylesheet' href='Resources/css/whatever-file.min.css' />

Yes, minified files are now utilized. If you are not referencing minified files, then this can break your application. The minified files can be found in the Resources/css/ path. 

If you want to make edits in your product, please make them in a custom.css file that you include at the end of the dependency chain; thus, <link rel='stylesheet' href='Resources/css/custom.css' />

