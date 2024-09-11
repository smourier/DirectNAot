#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_2/nn-dwrite_2-idwritefontface2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("d8b768ff-64bc-4e66-982b-ec8e87f693f7")]
public partial interface IDWriteFontFace2 : IDWriteFontFace1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-iscolorfont
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsColorFont();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-getcolorpalettecount
    [PreserveSig]
    uint GetColorPaletteCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-getpaletteentrycount
    [PreserveSig]
    uint GetPaletteEntryCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-getpaletteentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, [In][Out][MarshalUsing(CountElementName = nameof(entryCount))] DWRITE_COLOR_F[] paletteEntries);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-getrecommendedrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, nint /* optional DWRITE_MATRIX* */ transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteRenderingParams?>))] IDWriteRenderingParams? renderingParams, out DWRITE_RENDERING_MODE renderingMode, out DWRITE_GRID_FIT_MODE gridFitMode);
}
