# DirectNAot
This is an AOT-friendly version of [DirectN](https://github.com/smourier/DirectN). Only for x64 targets (doesn't mean it won't work for x86 targets, but it may not work for ambiguous types) . Only for .NET Core 8 and beyond.

This is a work in progress. If you want to discuss how and where this is going, just create an issue.

* **DirectNAot** is the AOT-friendly version of DirectN.
* **DirectNAot.Extensions** is a set of utilities that are not mandatory, but quite useful for programming with DirectNAot (and interop in general).
* **DirectNAot.InteropBuilder.Cli** is the tool that generates code in DirectNAot. Contrary to the DirectN project, this tool is now open source, and based on the linked [Win32InteropBuilder](https://github.com/smourier/Win32InteropBuilder) generic project.

So, DirectN has now been split into two projects: the interop code in one project, and the utilities, add-ons and extensions code in another project.

You don't have to use the extensions, but I strongly recommend to use it.

The reason Extensions is separated from DirectNAot is more an engineering reason. Roslyn/.NET source generators at work here tend to choke on ~10000 source-generated classes, so the DirectNAot is just very difficult to work with in Visual Studio.

The key points that drive how code is generated and built:
* Although Win32InteropBuilder is totally generic, the goal for **DirectNAot** is still to create built-in interop code for modern media & graphics technologies only:
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
* Both DirectNAot and Extensions are AOT-friendly.
* `unsafe` usage is limited.
* Raw pointers usage is not exposed, only `interface` types, `object` types, or `nint` depending on the situation.
* Doing interop is inherently unsafe but we want to keep a.NET-like programming whenever possible. The generated code serves a similar purpose to the CsWin32 project, but the generated code and net result are quite different.
