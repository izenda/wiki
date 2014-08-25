#Workaround for Log4Net version collision

[[_TOC_]]

##Question

When upgrading to the latest version of Izenda, the website will not compile. The issue is with a third party tool I use that references Log4Net and it's not compatible due to Izenda using a differently signed Log4Net driver. How can I resolve this conflict?

##Answer

Back in January 2013, the public key of the signed DLL for Log4Net was changed. As such, tools developed before that date reference an older public key than the one Izenda uses. A possible work-around for this issue is to change your web.config to specifically add the assemblies in a dependent relationship using the public keys of Izenda's log4net and your own. The following example is what this could look like for you:

```xml
<dependentAssembly>
  <assemblyIdentity name="log4net" publicKeyToken="669e0ddf0bb1aa2a"/>
  <codeBase version="1.2.13.0" href="bin\log4net.oldkey\log4net.dll"/>
  <bindingRedirect oldVersion="0.0.0.0-1.2.13.0" newVersion="1.2.13.0"/>
</dependentAssembly>
<dependentAssembly>
  <assemblyIdentity name="log4net" publicKeyToken="YOUR_PUBLIC_KEY_TOKEN"/>
  <codeBase version="1.2.13.0" href="bin\log4net.newkey\log4net.dll"/>
  <bindingRedirect oldVersion="0.0.0.0-1.2.13.0" newVersion="1.2.13.0"/>
</dependentAssembly>
```

You can find out more about the dependentAssembly tag [[at this link.|http://msdn.microsoft.com/en-us/library/0ash1ksb(v=vs.110).aspx]] You can find out what your assembly's public key token is by running the [[strong name tool.|http://blogs.msdn.com/b/wriju/archive/2008/07/01/how-to-find-public-key-token-for-a-net-dll-or-assembly.aspx]]