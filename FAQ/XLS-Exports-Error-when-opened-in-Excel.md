[[_TOC_]]

##Error: '[filename]', is in a different format...
'[filename]', is in a different format than specified by the file extension. Verify that the file is not corrupted and is from a trusted source before opening the file. Do you want to open the file now?"  [Yes | No | Help]

###Solution
There is no way to avoid this using our current HTML- Office export process to create XLS exports:

http://blogs.msdn.com/b/vsofficedeveloper/archive/2008/03/11/excel-2007-extension-warning.aspx

This is an inherent part of Office security starting with Office 2007 when opening internet generated (HTML) files. 

The solution is to train your users to say 'Yes' to these particular files - because they specifically choose to open that file.

You can also have disable this security feature in Office (2010 example):
[[Disable Protected Mode|/FAQ/disable-protected-mode-office-2010]]

##Error: My Excel file is completely blank

This is a problem likely caused by the MS16-088 Security patch for Office, released July 13 2016. This patch contains a fix, KB3170008, which modifies the behavior of .xls files which are derived from MHTML, such as Izenda's Excel output. The problem is that MHTML is not a 'valid' Excel file and thus does not meet the security rules added in KB3170008, which then causes the Izenda output to fail to load without warning.

###Solution:

Microsoft recommends these workarounds:

A) You can unblock access for individual files you know are safe. To do this:
-Right click on the file and choose Properties
-On the General tab, click Unblock
-Click OK

B) You can make use of existing Trusted Locations capabilities in Excel 2010, 2013, and 2016 via File -> options -> Trust Center -> Trust Center Settings -> Trusted Locations.

You can save the web html file to a trusted location on the local machine (Excel comes with a set of default trust locations). If you do not see the local folder location you trust for these files, then press “Add new location…” button and add it in the Trusted Location dialog. If the HTML document is in a trusted location the KB fix is not applied (e.g. the unsafe HTML file is not blocked).

This approach may unblock you, but it carries some risk as files of any file type in Trusted Locations are fully trusted. If an attacker can drop files into the trusted location they can easily exploit users who open such documents. Be especially cautious when specifying a custom folder as a trusted location.