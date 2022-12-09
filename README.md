### Coding for kids - Level 7 ASP.NET Core MVC intro

##### Installation Notes VS2022:
- VS 2019 requires a special developer account to download now.
- The Selections options are different than in VS 2019 for installing xamarin, it must be selected under indivudual components after selecting cross platform .NET. Furthermore, xamarin does not seem to work even though the option to add xnarin pages is there. It seemns it must be downloaded as a seperate nuget package. The one in the installer may only work with .NET core v2 or not at all.
- .NET Core 3 is not available for download in VS 2022 Community only version 2 which is no longer supported all. it even warns you of in the installer, with no option to download the latest version.
- It still lets you choose to create a .NET Core MVC project but there are no .NET Core SDK’s to select under the last page SDK selection.
- If you attempt to create the solution it errors out completely silently and you end up with a solution with 0 projects but the project files are still created.
- If you attempt to add the project to the solution it complains it can\'t find the SDK..
- I installed .net core v3 here: https://dotnet.microsoft.com/en-us/download/dotnet/3.1
- Finally removing/reordering the x86 version of from my path variable and then recreating the entire solution (trying to add the project file gave the same generic error as before) fixed it and it added the project to the solution automatically. (dotnet.exe x86/x64 installed by VS installer but x86 was first in PATH, I believe this caused the error.)
 
Then, the solution creator allowed me to select the .net core sdk but I still ended up with an empty solution and the same error upon trying to add the project to the solution.
 
I think VS uses dotnet.exe --list-sdks I think before adding a project to a solution but must use something else on the solution creation screen where it detects all SDKs fine. This is a guess based on the eventual error upon manual add and solution. Why .net core 3 isn\'t available in the latest vs community installer let alone the erroring out with no message whatsoever until you manually attempt to add the project is beyond me. However, I thought I would create these up to date installation notes for windows in case you're interested. It's probably easier to use v2 in the VS installer (untested) but it’s also depreciated.
