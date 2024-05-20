#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontfamily
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("da20d8ef-812a-4c43-9802-62ec4abd7add")]
public partial interface IDWriteFontFamily : IDWriteFontList
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfamily-getfamilynames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFamilyNames(out IDWriteLocalizedStrings names);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfamily-getfirstmatchingfont
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFirstMatchingFont(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, out IDWriteFont matchingFont);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfamily-getmatchingfonts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatchingFonts(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, out IDWriteFontList matchingFonts);
}
