#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefactory7
[GeneratedComInterface, Guid("35d0e0b3-9076-4d2e-a016-a91b568a06b4")]
public partial interface IDWriteFactory7 : IDWriteFactory6
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory7-getsystemfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontSet(BOOL includeDownloadableFonts, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet2>))] out IDWriteFontSet2 fontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory7-getsystemfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontCollection(BOOL includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection3>))] out IDWriteFontCollection3 fontCollection);
}
