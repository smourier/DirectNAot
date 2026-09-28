# DirectN AOT Extensions
This is the companion project of [DirectN AOT](https://github.com/smourier/DirectNAot), which it requires.
It's only for .NET 10 and beyond, it won't work with older versions nor with .NET Framework.

The interfaces in DirectN keep the exact native shape, and DirectN.Extensions adds a .NET-looking layer on top of them:
* extension methods for the most used Direct2D, DirectWrite, DXGI, D3D11, D3D12, Direct Composition, WIC and Media Foundation interfaces.
  They throw instead of returning an `HRESULT`, return `IComObject<T>` for COM objects, and exist for both the raw interface and `IComObject<T>`.
* COM object utilities (`ComObject`, `IComObject<T>`) that release COM references deterministically, and COM memory utilities (`ComMemory`).
* string utilities (`Pwstr` and friends for PWSTR, PSTR, BSTR, etc.).
* VARIANT and PROPVARIANT utilities (`Variant`, `PropVariant`).
* Win32 desktop utilities (windows, monitors, message decoding, command line, etc.), bound to DirectX and Direct2D primitives.

See the [DirectN.Extensions section of the main README](https://github.com/smourier/DirectNAot#directnextensions-the-net-looking-layer)
for the conventions and the object lifetime rules.
