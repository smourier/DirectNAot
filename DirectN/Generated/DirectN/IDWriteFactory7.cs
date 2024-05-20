#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefactory7
[GeneratedComInterface, Guid("35d0e0b3-9076-4d2e-a016-a91b568a06b4")]
public partial interface IDWriteFactory7 : IDWriteFactory6
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory7-getsystemfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontSet([MarshalAs(UnmanagedType.U4)] bool includeDownloadableFonts, out IDWriteFontSet2 fontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory7-getsystemfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontCollection([MarshalAs(UnmanagedType.U4)] bool includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, out IDWriteFontCollection3 fontCollection);
}
