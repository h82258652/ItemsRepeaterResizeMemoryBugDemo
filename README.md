# ItemsRepeaterResizeMemoryBugDemo

A WinUI 3 desktop repro using **Microsoft.WindowsAppSDK 2.5.4-experimental**
and .NET 8. The original `RadioButtons` template, its `ItemsRepeater` with
`StackLayout`, and the collection of 100 GUID strings are unchanged.

## Build and run

Use Visual Studio with WinUI application development tools, the .NET 8 SDK
(or a newer SDK that supports .NET 8), and Windows SDK 10.0.22621.0 or later.
The app supports Windows 10 version 1809 and later.

Open `ItemsRepeaterResizeMemoryBugDemo.sln`, select `Debug | x64` and the
`ItemsRepeaterResizeMemoryBugDemo (Package)` launch profile, then run with F5.
Enable Windows Developer Mode if needed for local MSIX deployment.
The solution also supports `x86` and `ARM64`; ARM32 is not supported by WinUI 3.

From a Visual Studio Developer PowerShell:

```powershell
msbuild .\ItemsRepeaterResizeMemoryBugDemo.sln /restore /p:Configuration=Debug /p:Platform=x64
```

The project uses single-project MSIX packaging and preserves the original
package identity and assets. Package signing remains disabled for local
development; distributing an MSIX requires configuring a signing certificate.
The matching experimental Windows App Runtime and the .NET 8 runtime are
required to run this framework-dependent app.

## Repro

Run the app and repeatedly resize its window while observing memory usage.
`MainPage.xaml` retains the alternate, commented-out
`ColumnMajorUniformToLargestGridLayout` for comparison with `StackLayout`.
This migration does not attempt to fix the memory issue.

The Windows App SDK version is experimental and is not intended for production use.
