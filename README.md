# DirectN Aot
This is an AOT-friendly version of [DirectN](https://github.com/smourier/DirectN). Aimed at x64 targets (doesn't mean it won't work for x86 targets, but it may not work for ambiguous types) . Only for .NET Core 8 and beyond, it won't work under .NET 8 or with .NET Framework.

This is a work in progress although it's been stabilizing lately. If you want to discuss how, where, why, just create an issue.

* **DirectN** is the AOT-friendly version of DirectN.
* **DirectN.Extensions** is a set of utilities that are not mandatory, but quite useful for programming with DirectN (and interop in general).
* **DirectN.InteropBuilder.Cli** is the tool that generates code in DirectN. Contrary to the DirectN project, this tool is now open source, and based on the linked [Win32InteropBuilder](https://github.com/smourier/Win32InteropBuilder) generic project.

So, DirectN has now been split into two projects: the interop code in one project, and the utilities, add-ons and extensions code in another project.

You don't have to use the extensions, but it's strongly recommend to use it.

The reason Extensions is separated from DirectN is more an engineering reason. Roslyn/.NET source generators at work here tend to choke on ~10000 source-generated classes, so the DirectN project is just very difficult to work with in Visual Studio.

The key points that drive how code is generated and built:
* Although Win32InteropBuilder is totally generic, the goal for **DirectN** is still to create built-in interop code for modern media & graphics technologies only:
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
* Modern code exclusively based on .NET 8 newer source-generated `LibraryImport`, source-generated `ComWrappers`, etc. Note the result is the .dll size is significantly bigger.
* How it works and how it's made is completely driven by strong .NET 8 ComWrapper source generator, and AOT requirements.
* Both DirectN and DirectN.Extensions are AOT-friendly.
* `unsafe` usage is limited.
* Raw pointers usage is not exposed, only interface types (like `ISomething`), or `nint` depending on the situation. `object`  as out parameter type for untyped (`void**`) COM interfaces has been considered but it's been replaced it by `nint` which is really universal (also for authoring scenarios).
* All `ComObject` instances are creating using ComWrappers' "unique instance" (`CreateObjectFlags.UniqueInstance` and `UniqueComInterfaceMarshaller<>`) marshalling feature, as we want to control when objects are released (what's the use of non-unique instance int interop scenarios?)
* Due to the usage of unique instances everywhere in DirectN AOT, we had to add a hack to overcome a nasty .NET 8 bug https://github.com/dotnet/runtime/issues/96901 or everything crashes very quickly at GC or finalizing time. We want to remove this hack ASAP, but it's not sure if this bug will be only releasd with .NET 9 or before...
* Doing interop is inherently unsafe but we want to keep a.NET-like programming whenever possible. The generated code serves a similar purpose to the CsWin32 project, but the final generated code and net result are quite different.
