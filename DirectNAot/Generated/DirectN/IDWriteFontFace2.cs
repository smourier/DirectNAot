namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_2/nn-dwrite_2-idwritefontface2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("d8b768ff-64bc-4e66-982b-ec8e87f693f7")]
public partial interface IDWriteFontFace2 : IDWriteFontFace1
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-iscolorfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsColorFont();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-getcolorpalettecount
    [PreserveSig]
    uint GetColorPaletteCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-getpaletteentrycount
    [PreserveSig]
    uint GetPaletteEntryCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-getpaletteentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, out DWRITE_COLOR_F paletteEntries);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_2/nf-dwrite_2-idwritefontface2-getrecommendedrenderingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, nint/* nint */ transform, [MarshalAs(UnmanagedType.U4)] bool isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams renderingParams, out DWRITE_RENDERING_MODE renderingMode, out DWRITE_GRID_FIT_MODE gridFitMode);
}
