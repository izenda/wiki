##Error:
'[filename]', is in a different format than specified by the file extension. Verify that the file is not corrupted and is from a trusted source before opening the file. Do you want to open the file now?"  [Yes | No | Help]

##Solution
There is no way to avoid this using our current HTML- Office export process to create XLS exports:

http://blogs.msdn.com/b/vsofficedeveloper/archive/2008/03/11/excel-2007-extension-warning.aspx

This is an inherent part of Office security starting with Office 2007 when opening internet generated (HTML) files. 

The solution is to train your users to say 'Yes' to these particular files - because they specifically choose to open that file.

You can also have disable this security feature in Office (2010 example):
[[Disable Protected Mode|/FAQ/disable-protected-mode-office-2010]]

