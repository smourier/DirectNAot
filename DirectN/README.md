# DirectN AOT
This is an AOT-friendly version of [DirectN](https://github.com/smourier/DirectN), with no reference to it.
It's only for .NET 10 and beyond, it won't work with older versions nor with .NET Framework.
It's aimed at 64-bit targets (x64 and ARM64). x86 works too, except for about fifty structures that the Win32 metadata lays out differently on x86,
and that are generated for 64-bit only.

Don't forget to check the [DirectN.Extensions](https://www.nuget.org/packages/DirectNAot.Extensions/) nuget,
a set of utilities that are not mandatory, but super useful for programming with DirectN (and COM and interop in general).

## Generated, not written
Almost none of the source files here are written by hand.
The interop code is generated from the official Win32 metadata, so it's a mechanical projection of the native API, not somebody's interpretation of it.
That is the main reason it can be maintained for a very long time:
* over 9,000 source files are generated, against about a hundred hand-written ones.
  Every interface, structure, enum, constant and function is in the first group.
* by size, about 90% is generated.
  The rest is mostly not really code but pure definitions, constants mainly, so there is almost nothing to maintain there.
* a new Windows SDK, or a fix in the metadata, means running the generator again, not rewriting code.
  What the metadata gets wrong is patched in the generator itself, in **DirectN.InteropBuilder.Cli** (`Patches.json`, etc.), so the result stays generated.
  The flip side is that a change in the metadata can introduce source breaking changes for the code that uses DirectN.
* the generated code has no author's coding style to keep consistent, so it doesn't drift, and nobody has to remember how it was written.
* the hand-written part is small and kept apart, it only adds what is missing from the metadata,
  a few types and some helper members on generated structures.

The key points that drive how code is generated and built:
* the goal for **DirectN** is to create built-in interop code for modern media and graphics Windows technologies only, cross-platform is *not* a target.
  That's DirectX 9 to 12, Direct2D, DXGI, Media Foundation, WIC, Direct Composition, Direct Write, WASAPI, XPS, and their dependencies.
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
