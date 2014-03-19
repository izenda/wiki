Izenda Language Pack
Izenda provides an add-on localization package capable of localizing the Izenda UI, Field Names as well as the data itself into other languages.
What version of AdHoc supports Language Pack?

To use Language Pack you should have Izenda AdHoc of version 6.4.4314 or higher
###<a name="IncludedLanguages"></a>What Languages Are Included?

The following languages are currently supported. More are being added based on customer demand and are available upon request. Please contact your sales rep or sales@izenda.com if you need additional languages.
* Arabic (ar-SA)
* German (de-DE)
* English (en-US)
* Spanish (es-ES)
* French (fr-FR)
* Hindi (hi)
* Italian (it-IT)
* Japanese (ja-JP)
* Korean (ko-KR)
* Portuguese (pt-PT)
* Russian (ru-RU)
* Bulgarian (bg-BG)
* Chinese (zh-CN) Chinese Traditional
* Chinese (zh-TW) Taiwanese

**What Are The Codes Next To The Language Names?**

The Izenda localization capability is built on top of Microsoft’s .NET localization API. The Microsoft .NET localization API assignes a specific culture code to each language. For example, American English spoken in the United States is en-US.

**What Is “Resources”?**

For localization, Izenda uses .Net managed resources Files (*.resx), which are standard resources for .Net. Resource files are XML-formatted text files, so you can edit it in an XML editor or even any plain text editor.

**How To Install The Language Pack?**

The language pack consists of a set of *.resx files inside the “Resources” folder. In addition, you will need a special license key that enables localization. Please contact your account manager to get these resources.
Installing Izenda Language Pack consists of **two** steps:
  1. Copying localization resources
  2. Set up localization in the code

1. Copying localization resources

The language pack consists of a set of *.resx files inside “Resources” folder. You should copy this folder **to the “bin” folder of your website**(Izenda.AdHoc.dll should be in that folder). It's easy to find it, just locate the folder where Izenda.AdHoc.dll is.



2. Set up localization in the code

You can set up the localization language almost anywhere in the code by specifying the AdHocSettings.Language setting.
But normally you would like to set localization in the PostLogin() method of the CustomAdHocConfig class in the Global.asax file because different users might like to use different languages:

``` c#
public override void PostLogin()
{
        AdHocSettings.Language = AdHocLanguage.French;
}
```

Let’s suppose you need Izenda Reports in French. Here is a step-by-step list of actions you need to perform to accomplish this:
  1. Locate the “bin” directory inside the folder with your website. It should contain file named “Izenda.AdHoc.dll”.
  2. Create a “Resources” folder there. So the target folder will be “..\bin\Resources”
  3. Refer to section [What Languages Are Included?](#IncludedLanguages) and get from localization pack the *.resx with name corresponding to the language you need (in our case this will be “French.resx” file).
  4. Copy that file from the localization pack into the previously created “..\bin\Resources” folder of your website (in our case the full file path will be “..\bin\Resources\French.resx”).
  5. Replace your license key with one supporting localization. Please contact support@izenda.com or your account manager for details.

###How To Set The Language I Want To Use?

You should specify the AdHocSettings.Language setting in the code. Normally it’s done in the PostLogin() method (or ConfigureSettings() method if you’d like to all users use the same language) of CustomAdHocConfig in the Global.asax file:

``` c#
public override void PostLogin()  
{
        AdHocSettings.Language = AdHocLanguage.French;
}

```

###Can I Change Some Or All Of The Resources?

Yes, you can change the localization by yourself.
All you have to do is to change the target *.resx resource file. Resource files are XML-formatted files, so you can change them easily using any XML or text editor.
For example, open the French.resx file in text editor. At the top, you will see service information (``` <xsd:schema></xsd:schema> ``` node) and headers ( ```<resheader></resheader> ``` nodes). Just skip them because all you need is ``` <data></data> ``` nodes:

``` xml
<data name="Field" xml:space="preserve">
	<value>Champ</value>
</data>
<data name="Table" xml:space="preserve">
	<value>Table</value>
</data>
<data name="NoFieldsSelected" xml:space="preserve">
	<value>Pas de champs sélectionnés</value>
</data>
    
```

The “name” attribute should be as it is. You can change values inside ``` <value></value> ``` nodes.
That’s it. Save the file and restart IIS and you’ll see the changes immediately.
Note: If a modified *.resx file is not in the “bin\Resources” folder of your site, you should copy it there.

###Can I Use Language That Is Not In The Language Pack?

If you didn’t find the language you want to use in Language Pack (see “What Languages Are Included?” section) you can contact your sales rep or sales@izenda.com to get it.

###What Code Do I Need to Localize The User Interface and Field Names?

The following settings need to be applied to the PostLogin() method of the CustomAdHocConfig class. 
  * Add an alias for every field that needs to be localized or perform a dynamic lookup from the database.
  * Install the appropriate languages in your bin folder

Example: 
  * Set AdHocSettings.Language = AdHocLanguage.Spanish (or the appropriate language) in the PostLogin() method
  * Set Izenda.AdHoc.FieldAliases[“ShipCity”] = “Cuidad” to localize individual field names in PostLogin()

###How Do I Refine The Provided Localization?

The Izenda.AdHoc.AdHocSettings.LabelAliases[] collection may be used to provide more granular UI localization if the provided localization is not sufficient.

###What Code Do I Need to Localize Actual Report Data?

Data may be localized by overriding the AdHocConfig.ProcessDataSet() method and dynamically changing the DataSet returned by the database.

###Does It Support Right-To-Left Languages?

Yes. Right-to-left languages are supported.
First you should add a new css class to the master page (or separately to the all pages if you don't use master page)

``` html
	<style type="text/css">
		.TabStrip .ActiveTab, .TabStrip .InactiveTab, .TabStrip .DisabledTab{
			direction: ltr;
		}
	</style>
  
```

Now you should add some code to the master page code behind file. Since you may change localization almost anywhere in the code, it is required to check the language every time a page is loaded. The best place to do this is in the Page_Load method of the page.

``` c#
	protected void Page_Load(object sender, EventArgs e)  
	{
		if (AdHocSettings.Culture.TextInfo.IsRightToLeft)
			this.Page.Header.Controls.Add(
				new System.Web.UI.LiteralControl(
					"<style type=\"text/css\">div{direction:rtl;}tr.VisualGroup td{text-align:right !important;}</style>"));
	}
  
```

The result is below:

###What Needs To Be Installed on The Server and Browser?

The Microsoft Language must be installed on the server as well as the browser for the fonts to display properly. Please [download the language file](http://www.microsoft.com/downloads/en/details.aspx?FamilyID=507d4589-ca97-4c5a-9c0f-bb9a3c68cc49) from Microsoft’s web site. The Izenda Localization Pack assumes that the server and user have the proper resources installed.