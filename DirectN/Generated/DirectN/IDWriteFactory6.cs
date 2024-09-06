#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefactory6
[GeneratedComInterface, Guid("f3744d80-21f7-42eb-b35d-995bc72fc223")]
public partial interface IDWriteFactory6 : IDWriteFactory5
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFaceReference(IDWriteFontFile fontFile, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [In][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference1>))] out IDWriteFontFaceReference1 fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createfontresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontResource(IDWriteFontFile fontFile, uint faceIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontResource>))] out IDWriteFontResource fontResource);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-getsystemfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontSet(BOOL includeDownloadableFonts, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet1>))] out IDWriteFontSet1 fontSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-getsystemfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemFontCollection(BOOL includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection2>))] out IDWriteFontCollection2 fontCollection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createfontcollectionfromfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontCollectionFromFontSet(IDWriteFontSet fontSet, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection2>))] out IDWriteFontCollection2 fontCollection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createfontsetbuilder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontSetBuilder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSetBuilder2>))] out IDWriteFontSetBuilder2 fontSetBuilder);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefactory6-createtextformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTextFormat(PWSTR fontFamilyName, IDWriteFontCollection? fontCollection, [In][MarshalUsing(CountElementName = nameof(fontAxisValueCount))] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, float fontSize, PWSTR localeName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextFormat3>))] out IDWriteTextFormat3 textFormat);
}
