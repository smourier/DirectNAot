# DirectN AOT
This is an AOT-friendly version of [DirectN](https://github.com/smourier/DirectN). Aimed at x64 targets (doesn't mean it won't work for x86 targets, but it may not work for ambiguous types) . Only for .NET Core 8 and beyond, it won't work for version below 8 or with .NET Framework.

This is a still work in progress although it's been stabilizing lately. If you want to discuss how, where, why, just create an issue.

* **DirectN** is the AOT-friendly version of DirectN.
* **DirectN.Extensions** is a set of utilities that are not mandatory, but quite useful for programming with DirectN (and interop in general).
* **DirectN.InteropBuilder.Cli** is the tool that generates code in DirectN. Contrary to the DirectN project, this tool is now open source, and based on the linked [Win32InteropBuilder](https://github.com/smourier/Win32InteropBuilder) generic project.

So, DirectN has now been split into two projects: the interop code in one project, and the utilities, add-ons and extensions code in another project.

You don't have to use the extensions, but it's easier to use it.

The reason Extensions is separated from DirectN is more an engineering reason. The new COM Roslyn/.NET source generator at work here is very slow on ~8000 source-generated classes (since COM interop is not builtin in CLR anymore), so the DirectN project is just very difficult to work directly with in Visual Studio.

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
* Modern code exclusively based on .NET 8 newer source-generated `LibraryImport`, source-generated `ComWrappers, etc. Note the result is the .dll size is significantly bigger.
* How it works and how it's made is, at its root, completely driven by .NET 8 ComWrapper source generator and AOT requirements: trimming, and disabled runtime marshaling.
* Both DirectN and DirectN.Extensions are AOT-friendly.
* `unsafe` usage is as limited as possible.
* Raw pointers (like `ISomething*`) usage is not publicly exposed, only interface types (like `ISomething`), or `nint` depending on the situation. `object` as out parameter type for untyped (native `void**`) COM interfaces has been considered but it's been replaced by `nint` which is more universal, including for authoring (aka implementing COM interfaces in .NET) scenarios.
* All `ComObject` instances are created using ComWrappers' "unique instance" (`CreateObjectFlags.UniqueInstance` and `UniqueComInterfaceMarshaller<>`) marshalling feature, as we want to control when objects are released (what's the serious use of non-unique instances in interop scenarios anyway?)
* Due to the usage of unique instances everywhere in DirectN AOT, we had to add a hack to overcome a nasty .NET 8 bug https://github.com/dotnet/runtime/issues/96901 or everything crashes very quickly at GC or finalizing time. We want to remove this hack ASAP, but it's not sure if this bug will be only released with .NET 9 or before...
* Doing interop is inherently unsafe but we want to keep a .NET-like programming whenever possible. The generated code serves a similar purpose to the CsWin32 project, but the final generated code and net result (ie: how we use it as a caller) are quite different.

# Installation
You can just compile the source (not it take minutes due to the fact ComWrapper Source geneation is *slooooowwwwww*...) or use the nuget packages

https://www.nuget.org/packages/DirectNAot/ and https://www.nuget.org/packages/DirectNAot.Extensions/

# Direct3D11 minimal sample.
The **DirectN.Samples.MinimalD3D11** sample here [https://github.com/smourier/DirectN/tree/master/DirectN/DirectN.WinUI3.MinimalD3D11](https://github.com/smourier/DirectNAot/tree/main/Samples/DirectN.Samples.MinimalD3D11) has been ported to C# from here: https://gist.github.com/d7samurai/abab8a580d0298cb2f34a44eec41d39d which features a minimal Direct3D11 *"'API familiarizer' - an uncluttered Direct3D 11 setup & basic rendering reference implementation, in the form of a complete, runnable Windows application contained in a single function and laid out in a linear, step-by-step fashion"* sample.

 It's dependent on DirectN AOT, .NET 8 and ... that's it. Once built, the fully standalone .exe with *zero dependency* is only 4M bytes!
 
 Here is the output (believe me, it rotates):

 ![Sample](/Assets/minimald3d11_pt3_aot.png?raw=true)

Full credits go to d7Samurai: https://gist.github.com/d7samurai


