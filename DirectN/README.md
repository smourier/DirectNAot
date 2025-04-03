# DirectN AOT
This is an AOT-friendly version of [DirectN](https://github.com/smourier/DirectN). Aimed at x64 targets (doesn't mean it won't work for x86 targets, but it may not work for ambiguous types) . Only for .NET Core 8 and beyond, it won't work for version below 8 or with .NET Framework.

The key points that drive how code is generated and built:

* The goal for **DirectN** is to create built-in interop code for modern media & graphics Windows (cross-platform is *not* a target) technologies only:
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
* Modern code exclusively based on .NET 8, and above, newer source-generated `LibraryImport`, source-generated `ComWrappers, etc.
* How it works and how it's made is, at its root, completely driven by .NET 8 and above ComWrapper source generator and AOT requirements: trimming, and disabled runtime marshaling.
* DirectN is AOT-friendly.
* `unsafe` usage is as limited as possible.
* Raw pointers (like `ISomething*`) usage is not publicly exposed, only interface types (like `ISomething`), or `nint` depending on the situation. `object` as out parameter type for untyped (native `void**`) COM interfaces has been considered but it's been replaced by `nint` which is more universal, including for authoring (aka implementing COM interfaces in .NET) scenarios.
* All `ComObject` instances are created using ComWrappers' "unique instance" (`CreateObjectFlags.UniqueInstance` and `UniqueComInterfaceMarshaller<>`) marshalling feature, as we want to control when objects are released (what's the serious use of non-unique instances in interop scenarios anyway?)
* Due to the usage of unique instances everywhere in DirectN AOT, we had to add a hack to overcome a nasty .NET 8 bug https://github.com/dotnet/runtime/issues/96901 or everything crashes very quickly at GC or finalizing time. We want to remove this hack ASAP, but it's not sure if this bug will be only released with .NET 9 or before...
* Doing interop is inherently unsafe but we want to keep a .NET-like programming whenever possible. The generated code serves a similar purpose to the CsWin32 project, but the final generated code and net result (ie: how we use it as a caller) are quite different.
