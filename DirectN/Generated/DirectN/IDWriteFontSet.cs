#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontset
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("53585141-d9f8-4095-8321-d73cf6bd116b")]
public partial interface IDWriteFontSet
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getfontcount
    [PreserveSig]
    uint GetFontCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFaceReference(uint listIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference>))] out IDWriteFontFaceReference fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-findfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFontFaceReference([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference>))] IDWriteFontFaceReference fontFaceReference, out uint listIndex, out BOOL exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-findfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFontFace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace>))] IDWriteFontFace fontFace, out uint listIndex, out BOOL exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getpropertyvalues(dwrite_font_property_id_wcharconst_idwritestringlist)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteStringList>))] out IDWriteStringList values);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getpropertyvalues(dwrite_font_property_id_wcharconst_idwritestringlist)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, PWSTR preferredLocaleNames, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteStringList>))] out IDWriteStringList values);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getpropertyvalues(dwrite_font_property_id_wcharconst_idwritestringlist)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyValues(uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, out BOOL exists, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteLocalizedStrings>))] out IDWriteLocalizedStrings values);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getpropertyoccurrencecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyOccurrenceCount(in DWRITE_FONT_PROPERTY property, out uint propertyOccurrenceCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getmatchingfonts(dwrite_font_propertyconst_uint32_idwritefontset)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatchingFonts(PWSTR familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet>))] out IDWriteFontSet filteredSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getmatchingfonts(dwrite_font_propertyconst_uint32_idwritefontset)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatchingFonts([In][MarshalUsing(CountElementName = nameof(propertyCount))] DWRITE_FONT_PROPERTY[] properties, uint propertyCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet>))] out IDWriteFontSet filteredSet);
}
