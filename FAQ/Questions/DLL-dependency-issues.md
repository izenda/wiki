#Resolving DLL Dependency Issues

[[_TOC_]]

##Question

I downloaded the latest version of Izenda but now there is a dependency issue with one of the DLLs. Now my application won't run. How can I use my version of a DLL dependency when Izenda uses a different version?

##Answer

This issue likely stems from your application using a version of a DLL dependency that is structurally different from the one Izenda uses. Normally, DLL version differences do not result in this issue since Izenda will automatically attempt to use your version of the DLL, but sometimes the differences between versions cannot be reconciled this easily. Such issues can be indicative of API changes in the embedded resource and would thus result in the application attempting to load and use API references that do not exist anymore or have changed in such a way to be unusable. There are workarounds to this issue, as described below.

###Method 1: Update the GAC

You can manually update the GAC (global assembly cache) to use both versions of the DLL, creating a physical separation of the version loaded by your application and Izenda. To do this, follow the steps below. For this example, we will be using the itextsharp dll:

1. Locate Gacutil.exe. This is part of the Microsoft SDKs that are supplied with Visual Studio. Usually you can find this tool in the following directory: C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools.
2. Download itextsharp.dll v4.0.3.0. This is part of the Izenda Release download pack that you can find at our [[downloads|http://izenda.com/Site/DownloadComplete.aspx?msgId=3]] page. You can find all of our most recent DLLs zipped in the archive.
3. Install itextsharp.dll v.4.0.3.0 to the GAC. 
    1. In the developer command line tool (also distributed with Visual Studio), run the command: gacutil /i "FullPathToDll/itextsharp.dll"
    2. Example: Gacutil.exe /i "D:\Downloads\izenda.adhoc.6.7.0.256\bin\itextsharp.dll"
    3. If you do not have the developer command prompt, you can still use Gacutil by using the regular windows command prompt (as an administrator) and specifying the entire path.
    4. Example: "C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\Gacutil.exe" /i "D:\Downloads\izenda.adhoc.6.7.0.256\bin\itextsharp.dll"
4. You should be able to use your version of the DLL from your solution and Izenda will use the one registered to the GAC.

###Method 2: Use Izenda's version

You can rollback your version of the DLL to the one Izenda uses and update your application accordingly.

###Method 3: Contact Izenda

You can contact us by emailing services@izenda.com and we can work with you to upgrade our version of the DLL. In the meantime, the workaround mentioned in method 1 can act as a temporary patch.