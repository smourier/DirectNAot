#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetypography
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("55f1112b-1dc2-4b3c-9541-f46894ed85b6")]
public partial interface IDWriteTypography
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetypography-addfontfeature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddFontFeature(DWRITE_FONT_FEATURE fontFeature);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetypography-getfontfeaturecount
    [PreserveSig]
    uint GetFontFeatureCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetypography-getfontfeature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFeature(uint fontFeatureIndex, out DWRITE_FONT_FEATURE fontFeature);
}
