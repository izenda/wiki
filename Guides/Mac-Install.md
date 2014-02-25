1. Izenda is implemented in Microsoft .NET.  Mono is an open source implementation of Microsoft's .NET Framework.  To run Izenda on a Mac, you will first need to download and install [Mono for Mac](http://download.mono-project.com/archive/2.10.11/macos-10-x86//MonoFramework-MRE-2.10.11.macos10.xamarin.x86.dmg).
1. Download [Izenda](http://archives.izenda.us/ri/webforms-cs.zip) and extract the files.
1. Open the webforms-cs directory which was extracted in the previous step.  Within the webforms-cs directory you will find a file called Global.asax.  Open Global.asax in the text editor of your choice.
1. Change INSERT_LICENSE_KEY_HERE to your trial key
1. Change INSERT_CONNECTION_STRING_HERE to Server=66.29.211.132,41433;Database=northwind;User ID=northwind;Password=traders;
1. Change AdHocSettings.GenerateThumbnails from true to false
1. Save your changes and close the text editor
1. Open a terminal window and change directory to the location you extracted webforms-cs
1. At the root of the webforms-cs directory, run xsp2
1. Open [http://localhost:8080](http://localhost:8080) in your web browser

