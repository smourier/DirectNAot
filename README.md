# DirectN AOT
100% C# interop code for .NET 10+: DXGI, WIC, DirectX 9 to 12, Direct2D, Direct Write, Direct Composition, Media Foundation, WASAPI, CodecAPI, GDI,
Spatial Audio, DVD, Windows Media Player, UWP DXInterop, WinUI3, etc.

This is the AOT-friendly version of [DirectN](https://github.com/smourier/DirectN), with zero reference to it.
It's for .NET 10 and beyond only, it won't work with older versions nor with .NET Framework.
It's aimed at 64-bit (ARM, AMD) targets. x86 works too, except for about fifty structures that the Win32 metadata lays out differently on x86,
and that are generated for 64-bit only.

If you want to discuss anything, just create an issue.

* **DirectN** is the core project, it contains all the interop code and it is almost entirely generated.
* **DirectN.Extensions** is a set of utilities that are not mandatory, but super useful for programming with DirectN
  (and Windows, COM and interop in general).
* **DirectN.InteropBuilder.Cli** is the tool that generates the code in DirectN. Contrary to the original DirectN project, this tool is open source,
  and based on the generic [Win32InteropBuilder](https://github.com/smourier/Win32InteropBuilder) project.

You don't have to use the extensions, but it's much easier with them.
They are a separate project for an engineering reason. The COM source generator is very slow on thousands of generated types,
so DirectN itself is difficult to work with directly in Visual Studio.

## Generated, not written
Almost none of the source files here are written by hand.
The interop code is generated from the official Win32 metadata, so it's a mechanical projection of the native API, not somebody's interpretation of it.
That is the main reason it can be maintained for a very long time:
* over 9,000 source files are generated, against a few hundred hand-written ones.
  Every interface, structure, enum, constant and function is in the first group.
* by size, about 90% of DirectN is generated.
  The rest is mostly not really code but pure definitions, constants mainly, so there is almost nothing to maintain there.
* a new Windows SDK, or a fix in the metadata, means running the generator again, not rewriting code.
  What the metadata gets wrong is patched in the generator itself, in **DirectN.InteropBuilder.Cli** (`Patches.json`, etc.), so the result stays generated.
  The flip side is that a change in the metadata could introduce source breaking changes for the code that uses DirectN (this has not happened yet).
* the generated code has no author's coding style to keep consistent, so it doesn't drift, and nobody has to remember how it was written.
* the hand-written part is small and kept apart.
  `DirectN/Manual` and `DirectN/Partials` only add what is missing from the metadata, a few types and some helper members on generated structures.
  The rest is **DirectN.Extensions**, which is optional, and its COM helpers, like `ComObject` and `ComMemory`, are fairly stable.

The key points that drive how the code is generated and built:
* Although Win32InteropBuilder is totally generic, DirectN only targets modern media and graphics Windows technologies, cross-platform is *not* a target.
  That's DirectX 9 to 12, Direct2D, DXGI, Media Foundation, WIC, Direct Composition, Direct Write, WASAPI, XPS, and their dependencies.
* Modern code only, based on the source-generated `LibraryImport` and `ComWrappers`. The .dll is significantly bigger as a result.
* How it's made is driven by the .NET COM source generator and by AOT requirements, trimming and disabled runtime marshalling.
  Both DirectN and DirectN.Extensions are AOT-friendly.
* `unsafe` usage is as limited as possible.
* Raw pointers (like `ISomething*`) are not publicly exposed, only interface types (like `ISomething`), or `nint` depending on the situation.
  `nint` replaced `object` as the out parameter type for untyped (native `void**`) COM interfaces, as it's more universal,
  including for authoring COM interfaces in .NET.
* All `ComObject` instances use ComWrappers' unique instance marshalling (`CreateObjectFlags.UniqueInstance` and `UniqueComInterfaceMarshaller<>`),
  because we want to control when objects are released.
* Doing interop is inherently unsafe, but we want to keep a .NET-like programming whenever possible.
  The generated code serves a similar purpose to the CsWin32 project, but the generated code and how you use it as a caller are quite different
  (although CsWin32 has been improved at the end of 2025).

## Same names and types as the native concepts, easy port from C/C++ to C#!
DirectNAot allows you to port C/C++ code to C#, or to write C# code from scratch, probably more easily than with other existing interop libraries in this domain because one of its main objective is to use **exactly the same names and types as the native concepts** (interfaces, enums, structures, constants, methods, arguments, guids, etc.) . So you can read the official documentation, use existing C/C++ samples, and start coding with .NET right away.

By design, everything is in the same namespace (and in the same assembly if you use the whole .dll or nuget package) so you don't need to know where is defined this or that interface, constants, etc.

## Natural .NET programming!
All native COM interfaces are generated as .NET (COM) interfaces, not classes or fancy/complex/unsafe structs. COM utility wrappers are also provided (ComObject, ComMemory, etc.), and many extension methods are also provided for some COM interfaces (the principle used can be extended to any COM method, but this part is not generated). They allow easier .NET programming, but they are not strictly needed. Most of this is possible because **DirectNAot represents COM inheritance by .NET inheritance** (so, `DirectN.IWICImagingFactory2` derives from `DirectN.IWICImagingFactory` for example).

## DirectN.Extensions, the .NET-looking layer
The interfaces in **DirectN** keep the exact native shape: `HRESULT` returns, `out` parameters, `PWSTR`, `nint` for optional pointers.
**DirectN.Extensions** adds a .NET-looking layer on top of them, written by hand for the most used interfaces,
in Direct2D, DirectWrite, DXGI, D3D11, D3D12, Direct Composition, WIC, Media Foundation, etc.
The raw interfaces are always there, so you can mix both styles freely and fall back to the raw call when an extension doesn't exist.

This is the same Direct2D code, first with the raw interface, then with the extensions:

```csharp
// raw interface, same shape as the native API
renderTarget.Object.CreateSolidColorBrush(color, 0, out var solidColorBrush).ThrowOnError();
using var brush = new ComObject<ID2D1SolidColorBrush>(solidColorBrush);
renderTarget.Object.FillRectangle(rect, brush.Object);

// extensions
using var brush = renderTarget.CreateSolidColorBrush(color);
renderTarget.FillRectangle(rect, brush);
```

The extension methods follow a few conventions:
* errors throw instead of being returned as an `HRESULT`, and a few methods also take an optional `throwOnError`.
* `out` parameters become return values, and optional pointers become optional or nullable parameters.
* a COM object returned is an `IComObject<T>` that you dispose,
  some methods also have a generic overload (like `CreateBitmap<T>`) that returns a more derived interface.
* every method exists for the raw interface and for `IComObject<T>`, the second one forwards to the first with `instance?.Object!`,
  so a `null` instance throws an `ArgumentNullException` rather than a `NullReferenceException`.

### Object lifetime
COM objects are not released by the garbage collector in DirectN AOT. Every wrapper is a unique instance, so its lifetime is yours to manage:
* an `IComObject<T>` owns one reference, and `Dispose` releases it right away. Use `using`, or dispose it when its owner is disposed.
* `As<T>()` may return the very same instance it was called on, so never dispose its result.
* `ComObject.FromPointer<T>` takes over the reference of the pointer you give it.
* `ComObject.GetOrCreateComInstance` returns a pointer with an extra reference that you must release,
  `ComObject.WithComInstance` does that for you around a callback.

### Strings, VARIANT and PROPVARIANT
* `Pwstr` turns a .NET string into a `PWSTR` that stays valid until it's disposed,
  so declare it with `using` and keep it alive for the whole native call.
  Don't pass the result of `PWSTR.From` to anything that keeps the pointer past the call, it points into a managed string that isn't pinned.
* `PWSTR.ToStringAndDispose()` reads a string the callee allocated and frees it.
* `Variant` and `PropVariant` wrap `VARIANT` and `PROPVARIANT` and clear them when disposed.
  `Detached` gives the native value while the wrapper still owns it, `Detach()` hands the ownership over, which is what an `out` parameter needs.

Besides COM, DirectN.Extensions also has Win32 utilities: windows, monitors, message decoding, command line, tracing, resources, etc.

# Installation
Use the nuget packages,
[DirectNAot](https://www.nuget.org/packages/DirectNAot/) and [DirectNAot.Extensions](https://www.nuget.org/packages/DirectNAot.Extensions/),
or compile the source (it can take *minutes*, ComWrappers source generation is *slooooowwwwww*...).

# Minimal code sample
This console app draws a circle with Direct2D into a WIC bitmap and saves it as a PNG file.
It uses both packages, and publishes with native AOT as is.

```csharp
using DirectN;
using DirectN.Extensions;
using DirectN.Extensions.Utilities;

// draw a circle with Direct2D into a WIC bitmap
using var bitmap = WicImagingFactory.CreateBitmap(256, 256, Constants.GUID_WICPixelFormat32bppPBGRA);
using var factory = D2D1Functions.D2D1CreateFactory();
using var renderTarget = factory.CreateWicBitmapRenderTarget(bitmap);
using var brush = renderTarget.CreateSolidColorBrush(new D3DCOLORVALUE(0.2f, 0.4f, 0.9f));
renderTarget.BeginDraw();
renderTarget.Clear(new D3DCOLORVALUE(1f, 1f, 1f));
renderTarget.FillEllipse(new D2D1_ELLIPSE(128, 128, 100), brush);
renderTarget.EndDraw();

// save it as a PNG file with WIC
using var file = File.Create("circle.png");
using var encoder = WicImagingFactory.CreateEncoder(Constants.GUID_ContainerFormatPng);
encoder.Initialize(new ManagedIStream(file));
using var frame = encoder.CreateNewFrame();
frame.Encode.Initialize(frame.Bag);
frame.Encode.WriteSource(bitmap);
frame.Encode.Commit();
encoder.Commit();
```

# Building
Generated files are included in the repo, so you can just compile DirectN (this one takes minutes...) and DirectN.Extensions.
They are always up to date, while the nuget packages may be slightly behind.

To regenerate everything from the Win32 metadata, run DirectN.InteropBuilder.Cli, which generates all the files in DirectN,
then compile DirectN and DirectN.Extensions.
It doesn't touch unchanged files, so if you run it from a fresh clone, no file should be updated.

# Samples
The samples in this repo are Windows GUI apps that use no WinForms, WPF or WinUI 3.
Each depends only on DirectN AOT and .NET 10, and publishes as a single standalone .exe with *zero dependency*.

## Minimal Direct3D 11
[DirectN.Samples.MinimalD3D11](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.MinimalD3D11)
is a C# port of [d7samurai's minimal Direct3D 11 sample](https://gist.github.com/d7samurai/abab8a580d0298cb2f34a44eec41d39d),
an *"'API familiarizer' - an uncluttered Direct3D 11 setup & basic rendering reference implementation, in the form of a complete, runnable Windows application contained in a single function and laid out in a linear, step-by-step fashion"*.
The .exe is only 4 MB.

Here is the output (believe me, it rotates):

<img alt="minimald3d11_pt3" src="/Assets/minimald3d11_pt3_aot.png?raw=true" width="50%">

Full credits go to [d7samurai](https://gist.github.com/d7samurai).

## PDF view
[DirectN.Samples.PdfView](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.PdfView) displays the content of a PDF file.
The .exe is only 6 MB.

It uses the Windows (WinRT) PDF API, so it shows how to include WinRT (C#/WinRT) in a DirectN AOT application.
It also shows how to use the
[Visual Layer](https://learn.microsoft.com/en-us/windows/apps/desktop/modernize/ui/visual-layer-in-desktop-apps) (aka Direct Composition) in a Windows app,
without any pre-baked UI framework, only DirectN, some of its utilities and Windows.

<img alt="PDFView Sample" src="https://github.com/user-attachments/assets/2e62cdae-375f-4e24-9e9a-82ea15c91bb8" width="50%">

## Screen capture
[DirectN.Samples.ScreenCapture](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.ScreenCapture)
displays a live capture of the primary screen.
The .exe is only 6 MB.

<img width="1922" height="1076" alt="ScreenCapture sample" src="https://github.com/user-attachments/assets/15140dfb-4075-4f45-8708-812ab047f143" />

## Media play
[DirectN.Samples.MediaPlay](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.MediaPlay) plays a video file of your choice.
The .exe is only 13 MB.

<img width="1167" height="662" alt="MediaPlay sample" src="https://github.com/user-attachments/assets/853d1e87-d23a-4114-a5e0-6b153d591aa2" />

# Projects built with DirectN AOT
Libraries and applications that use DirectN AOT, all compiled with .NET native AOT and free of WinForms, WPF and WinUI 3.

## Libraries and frameworks

### WebView2Aot
[WebView2Aot](https://github.com/smourier/WebView2Aot) is .NET 10+ AOT-compatible bindings for Microsoft's WebView2, built on DirectN AOT,
with a .NET-looking layer on top of the raw interfaces, and no dependency on WinForms, WPF or WinUI 3.

<img alt="WebView2 Sample" src="https://github.com/user-attachments/assets/e626a807-1cba-4b0b-a6ff-33a949f78806" width="50%">

### AOTrino
[AOTrino](https://github.com/aelyo-softworks/AOTrino) builds Electron-like desktop apps
on .NET native AOT and [WebView2Aot](https://github.com/smourier/WebView2Aot).
One executable, no runtime to install and no Chromium to ship, since Windows already has both. It supports x86, x64 and ARM64.

A window is a real HWND, the UI is a web page, and the two talk over a typed bridge. That's the whole idea.
The Fluent UI gallery below is an AOTrino app, and it weighs 4 MB.

<img width="1180" height="820" alt="AOTrino Fluent Gallery" src="https://github.com/user-attachments/assets/8e260baf-5f13-41f7-90dc-56dc7cd8283d" />

### Wice
[Wice](https://github.com/aelyo-softworks/Wice) (aka "Windows Interface Composition Engine") is a .NET UI framework for Windows applications.
It doesn't depend on WPF, WinForms, WinUI 2 or 3, Windows XAML or UWP.
The way it works is somewhat inspired by WPF, but there is no technical dependency on it.
It supports native AOT deployment through DirectN AOT.

<img alt="Wice" src="https://github.com/user-attachments/assets/7dd33147-241c-4db1-a5b9-34fdfcda5a82" width="50%">

### ActiveN
[ActiveN](https://github.com/smourier/ActiveN) is a lightweight framework for building classic COM components and OLE/ActiveX controls
in modern, fully AOT-compatible .NET, with registration-ready deployment.

It lets you author controls and automation objects that run inside legacy or current COM hosts
(VBA, VB6, Delphi, Visual FoxPro, scripting engines, test containers, etc.), without WinForms or WPF, which are not AOT-compatible.

Check out this 1998 VB6 IDE (x86) hosting modern WebView2 :-)

<img width="1361" height="784" alt="VB6 hosting WebView2" src="https://github.com/user-attachments/assets/bd1b283b-c337-46a5-b0d5-a4989323bdde" />

## Applications

### ShellBat
[ShellBat](https://github.com/smourier/ShellBat) is a modern Windows file explorer with file viewers, multi-instance workflows, terminal integration,
search capabilities, and deep Windows Shell interoperability.

It's a hybrid web application that combines C#/.NET with JavaScript, HTML and CSS, in an approach similar to Electron but simpler.
It relies only on .NET 10 AOT, DirectN AOT and [WebView2Aot](https://github.com/smourier/WebView2Aot).
The published app is a single 13 MB .exe that works on Windows 10, 11, Windows Sandbox and virtual machines (Hyper-V, etc.).

Integrated terminal:

<img alt="ShellBat" src="https://raw.githubusercontent.com/smourier/ShellBat/main/DocumentationScreenShots/External%20Command%20Line.png" width="70%">

PDF files rendered:

<img alt="ShellBat" src="https://raw.githubusercontent.com/smourier/ShellBat/main/DocumentationScreenShots/PDF%20Preview%20in%20Images%20View.png" width="70%">

### Filociraptor
[Filociraptor](https://github.com/smourier/Filociraptor) is a fast Windows file manager written in C#,
rendered with Direct2D and compiled with native AOT.
It's GPU drawn, fully virtualized and allocation free on the hot path, so folders with thousands of files open and scroll instantly.

<img width="800" alt="Filociraptor" src="https://github.com/user-attachments/assets/f22c7a41-7491-42c9-ad5f-d13386bfadb1" />

### Treemapolis
[Treemapolis](https://github.com/smourier/Treemapolis) is an evolution of Filociraptor: your disks as a 3D city you can fly through.
Every folder is a slab and every file a building as big as it weighs on disk, for the whole Windows shell namespace.

It's a GPU driven Direct3D 12 renderer (compute shader culling, indirect drawing, shadows, screen effects),
with a Direct2D and Direct Composition chrome,
written in C# with DirectN AOT and compiled with native AOT for x64 and ARM64, about 3 MB once packed with UPX.
When run as administrator, it reads NTFS drives straight from their master file table, 2.8 million items on screen in a few seconds.

🎬 [Watch the demo video](https://github.com/smourier/Treemapolis/raw/main/media/treemapolis-demo.mp4)

<img width="800" alt="Treemapolis" src="https://raw.githubusercontent.com/smourier/Treemapolis/main/media/city.jpg" />

### VCamNetSample
[VCamNetSample](https://github.com/smourier/VCamNetSample) is a Media Foundation virtual camera written in .NET with DirectN AOT,
and compiled with native AOT.
It needs Windows 11.

<img width="1502" height="848" alt="VCamNetSample" src="https://github.com/user-attachments/assets/03b289a6-cee2-497f-a692-9a060b2b50d9" />
