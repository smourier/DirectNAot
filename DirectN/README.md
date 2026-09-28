# DirectN AOT
This is an AOT-friendly version of [DirectN](https://github.com/smourier/DirectN), with no reference to it.
It's aimed at 64-bit targets (x64 and ARM64). It doesn't mean it won't work for x86 targets, but it may not work for ambiguous types.
It's only for .NET 10 and beyond, it won't work with older versions nor with .NET Framework.

Don't forget to check the [DirectN.Extensions](https://www.nuget.org/packages/DirectNAot.Extensions/) nuget,
a set of utilities that are not mandatory, but super useful for programming with DirectN (and COM and interop in general).

The key points that drive how code is generated and built:
* the goal for **DirectN** is to create built-in interop code for modern media & graphics Windows technologies only,
  cross-platform is *not* a target:
    * DirectX (9 => 12)
    * Direct2D
    * DXGI
    * Media Foundation
    * Windows Imaging Component (WIC)
    * Direct Composition
    * Direct Write
    * Audio (WASAPI)
    * XPS
    * others (dependencies, etc.)
* modern code exclusively based on source-generated `LibraryImport` and source-generated `ComWrappers`.
* how it works and how it's made is completely driven by the ComWrappers source generator and by AOT requirements,
  trimming and disabled runtime marshalling.
* DirectN is AOT-friendly.
* `unsafe` usage is as limited as possible.
* raw pointers (like `ISomething*`) are not publicly exposed, only interface types (like `ISomething`), or `nint` depending on the situation.
  `object` as the out parameter type for untyped (native `void**`) COM interfaces was considered,
  but `nint` is more universal, including for authoring scenarios (implementing COM interfaces in .NET).
* all `ComObject` instances are created using ComWrappers' "unique instance" marshalling,
  `CreateObjectFlags.UniqueInstance` and `UniqueComInterfaceMarshaller<>`, as we want to control when objects are released.
* doing interop is inherently unsafe, but we want to keep a .NET-like programming whenever possible.
  The generated code serves a similar purpose to the CsWin32 project,
  but the final generated code and the net result (how we use it as a caller) are quite different.

See the [main README](https://github.com/smourier/DirectNAot) for the samples and for the DirectN.Extensions conventions.
