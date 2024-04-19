namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/nn-dwrite_1-idwritefactory1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("30572f99-dac6-41db-a16e-0486307e606a")]
public partial interface IDWriteFactory1 : IDWriteFactory
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefactory1-geteudcfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEudcFontCollection(out IDWriteFontCollection fontCollection, [MarshalAs(UnmanagedType.U4)] bool checkForUpdates);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_1/nf-dwrite_1-idwritefactory1-createcustomrenderingparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, out IDWriteRenderingParams1 renderingParams);
}
