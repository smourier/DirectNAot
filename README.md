# DirectN AOT
100% C# interop code for .NET Core 10+ : DXGI, WIC, DirectX 9 to 12, Direct2D, Direct Write, Direct Composition, Media Foundation, WASAPI, CodecAPI, GDI, Spatial Audio, DVD, Windows Media Player, UWP DXInterop, WinUI3, etc.

This is an AOT-friendly version of [DirectN](https://github.com/smourier/DirectN) (with zero reference to it). Aimed at 64-bit (ARM, AMD) targets (doesn't mean it won't work for x86 targets, but it may not work for ambiguous types). Only for .NET Core 9 and beyond, it won't work for version below 8 nor with .NET Framework.

It's always a work in progress although it's been fairly stable now. If you want to discuss how, where, why, just create an issue.

* **DirectN** is the core project which contains all interop code and is 99% generated.
* **DirectN.Extensions** is a set of utilities that are not mandatory, but super useful for programming with DirectN (and Windows, COM and interop in general).
* **DirectN.InteropBuilder.Cli** is the tool that generates code in DirectN. Contrary to the original DirectN project, this tool is open source, and based on the linked [Win32InteropBuilder](https://github.com/smourier/Win32InteropBuilder) generic project.

So, DirectN has now been split into two projects: the interop code in one project, and the utilities, add-ons and extensions code in another project.

You don't have to use the extensions, but it's muuuuuuch easier to use them. The reason Extensions is separated from DirectN is more an engineering reason. The new COM Roslyn/.NET source generator at work here is very slow on ~8000 source-generated classes (since COM interop is not builtin in CLR anymore), so the DirectN project is just very difficult to work directly with in Visual Studio.

The key points that drive how code is generated and built:
* Although Win32InteropBuilder is totally generic, the goal for **DirectN** is still to create built-in interop code for modern media & graphics Windows (cross-platform is *not* a target) technologies only:
    * DirectX (9 => 12)
    * Direct2D
    * DXGI
    * Media Foundation
    * Windows Imaging Component (WIC)
    * Direct Composition
    * Direct Write
    * Audio (WASAPI)
    * XPS
    * others (dependencies, etc)
* Modern code exclusively based on .NET Core newer source-generated `LibraryImport`, source-generated `ComWrappers, etc. Note the result is the .dll size is significantly bigger.
* How it works and how it's made is, at its root, completely driven by .NET Core ComWrapper source generator and AOT requirements: trimming, and disabled runtime marshaling.
* Both DirectN and DirectN.Extensions are AOT-friendly.
* `unsafe` usage is as limited as possible.
* Raw pointers (like `ISomething*`) usage is not publicly exposed, only interface types (like `ISomething`), or `nint` depending on the situation. `object` as out parameter type for untyped (native `void**`) COM interfaces has been considered but it's been replaced by `nint` which is more universal, including for authoring (aka implementing COM interfaces in .NET) scenarios.
* All `ComObject` instances are created using ComWrappers' "unique instance" (`CreateObjectFlags.UniqueInstance` and `UniqueComInterfaceMarshaller<>`) marshalling feature, as we want to control when objects are released (what's the serious use of non-unique instances in interop scenarios anyway?)
* Due to the usage of unique instances everywhere in DirectN AOT, we had to add a hack to overcome a nasty .NET 8 bug https://github.com/dotnet/runtime/issues/96901 or everything crashes very quickly at GC or finalizing time. This hack is inactive under .NET 9+.
* Doing interop is inherently unsafe but we want to keep a .NET-like programming whenever possible. The generated code serves a similar purpose to the CsWin32 project, but the final generated code and net result (ie: how we use it as a caller) are quite different (although CsWin32 has been improved at the end of 2025).

# Installation
You can just compile the source (note it can take *minutes* due to the fact ComWrapper Source generation is *slooooowwwwww*...) or use the nuget packages

https://www.nuget.org/packages/DirectNAot/ and https://www.nuget.org/packages/DirectNAot.Extensions/

# Direct3D11 minimal sample
The **DirectN.Samples.MinimalD3D11** sample here [https://github.com/smourier/DirectNAot/tree/master/DirectN/DirectN.WinUI3.MinimalD3D11](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.MinimalD3D11) has been ported to C# from here: https://gist.github.com/d7samurai/abab8a580d0298cb2f34a44eec41d39d which features a minimal Direct3D11 *"'API familiarizer' - an uncluttered Direct3D 11 setup & basic rendering reference implementation, in the form of a complete, runnable Windows application contained in a single function and laid out in a linear, step-by-step fashion"* sample.

It's dependent on DirectN AOT, .NET 10 and ... that's it. Once built, the fully standalone .exe with *zero dependency* is only 4M bytes!
 
Here is the output (believe me, it rotates):

<img alt="minimald3d11_pt3" src="/Assets/minimald3d11_pt3_aot.png?raw=true" width="50%">

Full credits go to d7Samurai: https://gist.github.com/d7samurai

# PDF view sample
The **DirectN.Samples.PdfView** sample here [https://github.com/smourier/DirectNAot/tree/master/DirectN/DirectN.WinUI3.PdfView](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.PdfView) is a fully non-Winforms, non-WPF, non-WinUI3 window GUI app that can display a PDF file's content.

It's dependent on DirectN AOT, .NET 10 and ... that's it. Once built, the fully standalone .exe with *zero dependency* is only 6M bytes!

It uses Windows (WinRT) PDF API so it demonstrates how to include WinRT (C#/WinRT) in a DirectN AOT application. It also demonstrates how to use the [Visual Layer](https://learn.microsoft.com/en-us/windows/apps/desktop/modernize/ui/visual-layer-in-desktop-apps) (aka Direct Composition) in a Windows app without any pre-baked UI framework, only DirectN, some of its utilities and Windows.

<img alt="PDFView Sample" src="https://github.com/user-attachments/assets/2e62cdae-375f-4e24-9e9a-82ea15c91bb8" width="50%">

# Screen Capture sample
The **DirectN.Samples.ScreenCapture** sample here [https://github.com/smourier/DirectNAot/tree/master/DirectN/DirectN.ScreenCapture](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.ScreenCapture) is a fully non-Winforms, non-WPF, non-WinUI3 window GUI app that can display a live (primary) screen capture

It's dependent on DirectN AOT, .NET 10 and ... that's it. Once built, the fully standalone .exe with *zero dependency* is only 6M bytes!

<img width="1922" height="1076" alt="ScreenCapture sample" src="https://github.com/user-attachments/assets/15140dfb-4075-4f45-8708-812ab047f143" />

# Media Play sample
The **DirectN.Samples.MediaPlay** sample here [https://github.com/smourier/DirectNAot/tree/master/DirectN/DirectN.MediaPlay](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.MediaPlay) is a fully non-Winforms, non-WPF, non-WinUI3 window GUI app that can play a video file (you can choose the source)

It's dependent on DirectN AOT, .NET 10 and ... that's it. Once built, the fully standalone .exe with *zero dependency* is only 13M bytes!

<img width="1167" height="662" alt="MediaPlay sample" src="https://github.com/user-attachments/assets/853d1e87-d23a-4114-a5e0-6b153d591aa2" />

# WebView2
[WebView2Aot](https://github.com/smourier/WebView2Aot) is an AOT project, using DirectNAOT that exposes .NET 10+ AOT-compatible bindings 100%, fully independent from WinForms, WPF or WinUI3, for Microsoft's WebView2.

# ShellBat
[ShellBat](https://github.com/smourier/ShellBat) is a modern Windows file explorer with file viewers, multi-instance workflows, terminal integration, search capabilities, and deep Windows Shell interoperability.

This project is a hybrid web application that combines C#/.NET with JavaScript, HTML and CSS, based on an approach similar to frameworks like Electron, but rather simplified.

It relies solely on DirectN AOT and .NET 10+ AOT and built on DirectNAOT and [WebView2Aot](https://github.com/smourier/WebView2Aot), again with no dependencies on WinForms, WPF, WinUI 3, or UWP.
The final published file is just a single .exe file of 13MB that works in Windows 10, 11, Sandbox and Virtual environments (Hyver-V, etc.).

Integrated terminal:

<img alt="ShellBat" src="https://raw.githubusercontent.com/smourier/ShellBat/main/DocumentationScreenShots/External%20Command%20Line.png" width="70%">

PDF files rendered:

<img alt="ShellBat" src="https://raw.githubusercontent.com/smourier/ShellBat/main/DocumentationScreenShots/PDF%20Preview%20in%20Images%20View.png" width="70%">

# Wice
Wice (aka "Windows Interface Composition Engine") is a .NET UI engine for creating Windows application. It's not dependent on WPF nor Winforms, nor WinUI 2 nor 3, nor Windows XAML, nor UWP, it's another UI Framework. The way it works is somewhat inspired from WPF, but there is no technical dependency over it.
It supports native-AOT deployment, through usage of DirectN AOT.

Check it out at https://github.com/aelyo-softworks/Wice

<img alt="Wice" src="https://github.com/user-attachments/assets/7dd33147-241c-4db1-a5b9-34fdfcda5a82" width="50%">

<img alt="WebView2 Sample" src="https://github.com/user-attachments/assets/e626a807-1cba-4b0b-a6ff-33a949f78806" width="50%">

# VCamNetSample
[VCamNetSample](https://github.com/smourier/VCamNetSample) is a project that exposes a Media Foundation Virtual Camera Sample developed using .NET AOT with DirectN AOT (only on Windows 11).

<img width="1502" height="848" alt="VCamNetSample" src="https://github.com/user-attachments/assets/03b289a6-cee2-497f-a692-9a060b2b50d9" />




