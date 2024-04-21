namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefactory6
[GeneratedComInterface, Guid("f3744d80-21f7-42eb-b35d-995bc72fc223")]
public partial interface IDWriteFactory6 : IDWriteFactory5
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFaceReference(IDWriteFontFile fontFile, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, in DWRITE_FONT_AXIS_VALUE fontAxisValues, uint fontAxisValueCount, out IDWriteFontFaceReference1 fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createfontresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontResource(IDWriteFontFile fontFile, uint faceIndex, out IDWriteFontResource fontResource);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-getsystemfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontSet([MarshalAs(UnmanagedType.U4)] bool includeDownloadableFonts, out IDWriteFontSet1 fontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-getsystemfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontCollection([MarshalAs(UnmanagedType.U4)] bool includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, out IDWriteFontCollection2 fontCollection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createfontcollectionfromfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontCollectionFromFontSet(IDWriteFontSet fontSet, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, out IDWriteFontCollection2 fontCollection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createfontsetbuilder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontSetBuilder(out IDWriteFontSetBuilder2 fontSetBuilder);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createtextformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTextFormat(PWSTR fontFamilyName, IDWriteFontCollection? fontCollection, in DWRITE_FONT_AXIS_VALUE fontAxisValues, uint fontAxisValueCount, float fontSize, PWSTR localeName, out IDWriteTextFormat3 textFormat);
}
