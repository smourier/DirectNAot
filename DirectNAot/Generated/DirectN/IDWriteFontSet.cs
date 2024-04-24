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
    HRESULT GetFontFaceReference(uint listIndex, out IDWriteFontFaceReference fontFaceReference);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-findfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFontFaceReference(IDWriteFontFaceReference fontFaceReference, out uint listIndex, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-findfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFontFace(IDWriteFontFace fontFace, out uint listIndex, [MarshalAs(UnmanagedType.U4)] out bool exists);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getpropertyvalues(dwrite_font_property_id_wcharconst_idwritestringlist)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, out IDWriteStringList values);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getpropertyvalues(dwrite_font_property_id_wcharconst_idwritestringlist)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, PWSTR preferredLocaleNames, out IDWriteStringList values);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getpropertyvalues(dwrite_font_property_id_wcharconst_idwritestringlist)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyValues(uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, [MarshalAs(UnmanagedType.U4)] out bool exists, out IDWriteLocalizedStrings values);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getpropertyoccurrencecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyOccurrenceCount(in DWRITE_FONT_PROPERTY property, out uint propertyOccurrenceCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getmatchingfonts(dwrite_font_propertyconst_uint32_idwritefontset)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatchingFonts(PWSTR familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, out IDWriteFontSet filteredSet);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset-getmatchingfonts(dwrite_font_propertyconst_uint32_idwritefontset)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatchingFonts([MarshalUsing(CountElementName = nameof(propertyCount))] in DWRITE_FONT_PROPERTY[] properties, uint propertyCount, out IDWriteFontSet filteredSet);
}
