#My Report List Loads Indefinitely:

[[_TOC_]]

##Question

My report list takes forever to load, and never actually loads. What is going on?

##ANswer

The infinitely loading ReportList is a server/.NET configuration issue. The culprit is .NET AJAX assembly System.Web.Extensions.

The server needs access to that assembly to make AJAX calls. If your server won’t allow AJAX calls, the modern report list won’t work. If the assembly is present, make sure .NET and IIS are configured to include it, and the server security does not block it in any way.

If you use .NET 3.5+ the extension assembly is included with your .NET install; If not present, .NET should be reinstalled, making sure to include the AJAX assemblies.

If you are using .NET 2.0 and the assembly is not present please use the link pasted below to install ASP.NET2 AJAX extensions:

http://www.microsoft.com/downloads/details.aspx?FamilyID=ca9d90fa-e8c9-42e3-aa19-08e2c027f5d6&displaylang=en
