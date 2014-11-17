As of our 6.8 release, the English.resx file is made available to customize the verbiage in it without purchasing the language pack.  However, in order for any edits to the resx file to show up in Izenda, the file must be in Izenda's bin\Resources folder.  If the application does not read a resx file in that location, it will move to the standard resx files in the Izenda DLL.

You may need to create the Resources folder inside of the bin folder.  Below are a few screenshots from a use-case, to illustrate the example:

![Edited resx file in correct location](http://fogbugz.izenda.us/default.asp?pg=pgDownload&pgType=pgFile&ixBugEvent=193062&ixAttachment=28261&sTicket=&sFileName=generated_10763425.png)

![Custom verbiage appearing in Izenda](http://fogbugz.izenda.us/default.asp?pg=pgDownload&pgType=pgFile&ixBugEvent=193062&ixAttachment=28262&sTicket=&sFileName=generated_33590646.png)